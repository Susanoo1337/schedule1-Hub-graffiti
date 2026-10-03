using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using HUB.Graffiti.Network;
using MelonLoader;
using MelonLoader.Utils;

namespace HUB.Graffiti
{
	/// <summary>
	/// Sticker placements for the currently loaded save. Each game save slot gets its own file at
	/// UserData/HUB_Graffiti/Saves/&lt;steamid&gt;/SaveGame_&lt;n&gt;/sticker_placements.json; the game's
	/// own save folder is never written to.
	/// </summary>
	internal static class StickerSaveManager
	{
		internal enum StorageMode
		{
			/// <summary>Not in a game, or the save hasn't been resolved yet.</summary>
			None,
			/// <summary>Placements are read from and written to the loaded save's file.</summary>
			Save,
			/// <summary>Multiplayer client: the host owns the placements, nothing is written locally.</summary>
			Client,
			/// <summary>In a game, but the loaded save couldn't be identified. Placements last for this session only.</summary>
			Unresolved
		}

		private const string FileName = "sticker_placements.json";
		private const int FormatVersion = 2;

		private static readonly string RootFolder = Path.Combine(MelonEnvironment.UserDataDirectory, "HUB_Graffiti");
		private static readonly string SavesFolder = Path.Combine(RootFolder, "Saves");

		/// <summary>Where v1.2.x kept a single placement list shared by every save.</summary>
		internal static readonly string LegacySavePath = Path.Combine(RootFolder, FileName);

		private static readonly JsonSerializerOptions ReadOptions = new JsonSerializerOptions
		{
			PropertyNameCaseInsensitive = true,
			ReadCommentHandling = JsonCommentHandling.Skip,
			AllowTrailingCommas = true
		};

		private static readonly JsonSerializerOptions WriteOptions = new JsonSerializerOptions
		{
			WriteIndented = true
		};

		private static List<StickerPlacement> _placements = new List<StickerPlacement>();
		private static bool _loaded;
		private static string _saveFolder;
		private static string _saveFilePath;
		private static string _fingerprint;

		internal static IReadOnlyList<StickerPlacement> Placements => _placements;

		internal static StorageMode Mode { get; private set; }

		internal static bool IsLoaded => _loaded;

		/// <summary>Display name of the loaded slot, e.g. "SaveGame_2".</summary>
		internal static string SaveLabel => string.IsNullOrEmpty(_saveFolder) ? "" : Path.GetFileName(_saveFolder);

		internal static string SaveFilePath => _saveFilePath;

		/// <summary>Set when a stale file from an earlier game in the same slot was moved aside on load.</summary>
		internal static string ArchivedStaleFile { get; private set; }

		/// <summary>Host or single player with an identified save: changes go to disk.</summary>
		internal static bool CanPersist => Mode == StorageMode.Save && _saveFilePath != null && (!NetworkHelper.IsMultiplayer || NetworkHelper.IsHost);

		internal static void Load()
		{
			if (_loaded)
			{
				return;
			}
			_loaded = true;
			_placements = new List<StickerPlacement>();
			ArchivedStaleFile = null;

			if (NetworkHelper.IsMultiplayer && !NetworkHelper.IsHost)
			{
				Mode = StorageMode.Client;
				DebugLog.Log("Save", "Multiplayer client: placements come from the host");
				return;
			}

			_saveFolder = SaveContext.GetLoadedSaveFolder();
			if (string.IsNullOrEmpty(_saveFolder))
			{
				Mode = StorageMode.Unresolved;
				MelonLogger.Warning("[HUB - Graffiti] Could not determine the loaded save slot. Stickers placed now will not be saved.");
				return;
			}

			Mode = StorageMode.Save;
			_saveFilePath = Path.Combine(SavesFolder, SaveContext.BuildStorageKey(_saveFolder), FileName);
			_fingerprint = SaveContext.ReadFingerprint(_saveFolder);
			DebugLog.Log("Save", "Save folder: " + _saveFolder);
			DebugLog.Log("Save", "Placement file: " + _saveFilePath + " (fingerprint " + (_fingerprint ?? "unavailable") + ")");

			if (!File.Exists(_saveFilePath))
			{
				DebugLog.Log("Save", "No placements stored for this save yet");
				return;
			}

			try
			{
				SaveFileData data = ParseFile(File.ReadAllText(_saveFilePath));
				if (data == null)
				{
					DebugLog.Log("Save", "Placement file was empty");
					return;
				}

				// A slot that was deleted and restarted keeps its folder name. If the file belongs to the
				// earlier game, move it aside rather than painting the old game's stickers on the new one.
				if (!string.IsNullOrEmpty(data.SaveFingerprint) && !string.IsNullOrEmpty(_fingerprint)
					&& !string.Equals(data.SaveFingerprint, _fingerprint, StringComparison.Ordinal))
				{
					ArchivedStaleFile = ArchiveFile(_saveFilePath, "previous-game");
					MelonLogger.Warning("[HUB - Graffiti] Stored stickers belong to an earlier game in " + SaveLabel + "; moved them to " + Path.GetFileName(ArchivedStaleFile));
					return;
				}

				_placements = Sanitize(data.Placements);
				DebugLog.Log("Save", "Loaded " + _placements.Count + " sticker placements for " + SaveLabel);
			}
			catch (Exception ex)
			{
				// Keep the unreadable file around so a bad edit doesn't silently lose everything on the next write.
				string moved = ArchiveFile(_saveFilePath, "unreadable");
				MelonLogger.Error("[HUB - Graffiti] Could not read " + _saveFilePath + ": " + ex.Message + (moved != null ? " (moved to " + Path.GetFileName(moved) + ")" : ""));
			}
		}

		internal static bool Has(string surfaceGuid)
		{
			return Find(surfaceGuid) != null;
		}

		internal static StickerPlacement Find(string surfaceGuid)
		{
			if (string.IsNullOrEmpty(surfaceGuid))
			{
				return null;
			}
			return _placements.FirstOrDefault(p => string.Equals(p.SurfaceGuid, surfaceGuid, StringComparison.OrdinalIgnoreCase));
		}

		internal static void RecordPlacement(string surfaceGuid, string stickerFileName)
		{
			if (string.IsNullOrEmpty(surfaceGuid) || string.IsNullOrEmpty(stickerFileName))
			{
				return;
			}
			// A sticker placed in the first seconds after loading, before the restore coroutine ran,
			// must land in the save's list rather than a list that Load() would then throw away.
			Load();
			RemoveFromList(surfaceGuid);
			_placements.Add(new StickerPlacement
			{
				SurfaceGuid = surfaceGuid,
				StickerFileName = stickerFileName
			});
			WriteToDisk();
		}

		internal static bool RemovePlacement(string surfaceGuid)
		{
			if (RemoveFromList(surfaceGuid) == 0)
			{
				return false;
			}
			WriteToDisk();
			return true;
		}

		/// <summary>Replaces the in-memory list with the host's. Never written to disk on the client.</summary>
		internal static void ApplyFromNetwork(List<StickerPlacement> placements)
		{
			_placements = Sanitize(placements);
		}

		internal static void Reset()
		{
			_placements = new List<StickerPlacement>();
			_loaded = false;
			_saveFolder = null;
			_saveFilePath = null;
			_fingerprint = null;
			ArchivedStaleFile = null;
			Mode = StorageMode.None;
		}

		// ---- v1.2.x migration ----

		/// <summary>Number of placements in the old shared file, or 0 if there is none.</summary>
		internal static int LegacyPlacementCount
		{
			get
			{
				try
				{
					return File.Exists(LegacySavePath) ? Sanitize(ParseFile(File.ReadAllText(LegacySavePath))?.Placements).Count : 0;
				}
				catch
				{
					return 0;
				}
			}
		}

		/// <summary>
		/// Copies the old shared placements into the current save (existing placements win on conflicts)
		/// and renames the old file so it isn't offered again. Returns the number of placements added.
		/// </summary>
		internal static int ImportLegacy()
		{
			if (!CanPersist || !File.Exists(LegacySavePath))
			{
				return 0;
			}
			int added = 0;
			try
			{
				foreach (StickerPlacement placement in Sanitize(ParseFile(File.ReadAllText(LegacySavePath))?.Placements))
				{
					if (!Has(placement.SurfaceGuid))
					{
						_placements.Add(placement);
						added++;
					}
				}
				WriteToDisk();
				ArchiveFile(LegacySavePath, "imported-into-" + SaveLabel);
				MelonLogger.Msg("[HUB - Graffiti] Imported " + added + " legacy placements into " + SaveLabel);
			}
			catch (Exception ex)
			{
				MelonLogger.Error("[HUB - Graffiti] Legacy import failed: " + ex.Message);
			}
			return added;
		}

		/// <summary>Renames the old shared file without importing it.</summary>
		internal static void DismissLegacy()
		{
			if (File.Exists(LegacySavePath))
			{
				ArchiveFile(LegacySavePath, "dismissed");
			}
		}

		// ---- internals ----

		private static int RemoveFromList(string surfaceGuid)
		{
			if (string.IsNullOrEmpty(surfaceGuid))
			{
				return 0;
			}
			return _placements.RemoveAll(p => string.Equals(p.SurfaceGuid, surfaceGuid, StringComparison.OrdinalIgnoreCase));
		}

		private static void WriteToDisk()
		{
			if (!CanPersist)
			{
				return;
			}
			try
			{
				// A brand-new game may only write its metadata after the first save.
				if (string.IsNullOrEmpty(_fingerprint))
				{
					_fingerprint = SaveContext.ReadFingerprint(_saveFolder);
				}
				Directory.CreateDirectory(Path.GetDirectoryName(_saveFilePath));
				SaveFileData data = new SaveFileData
				{
					Version = FormatVersion,
					SaveFolder = _saveFolder,
					SaveFingerprint = _fingerprint,
					Placements = _placements
				};
				// Write-then-rename so a crash mid-write can't leave a truncated file behind.
				string tempPath = _saveFilePath + ".tmp";
				File.WriteAllText(tempPath, JsonSerializer.Serialize(data, WriteOptions));
				File.Move(tempPath, _saveFilePath, true);
				DebugLog.Log("Save", "Saved " + _placements.Count + " placements for " + SaveLabel);
			}
			catch (Exception ex)
			{
				MelonLogger.Error("[HUB - Graffiti] Could not save sticker placements: " + ex.Message);
			}
		}

		private static SaveFileData ParseFile(string json)
		{
			if (string.IsNullOrWhiteSpace(json))
			{
				return null;
			}
			// v1.2.x wrote a bare array; accept it so an old file copied into a save folder still works.
			if (json.TrimStart().StartsWith("["))
			{
				return new SaveFileData
				{
					Version = 1,
					Placements = JsonSerializer.Deserialize<List<StickerPlacement>>(json, ReadOptions)
				};
			}
			return JsonSerializer.Deserialize<SaveFileData>(json, ReadOptions);
		}

		private static List<StickerPlacement> Sanitize(List<StickerPlacement> placements)
		{
			List<StickerPlacement> result = new List<StickerPlacement>();
			if (placements == null)
			{
				return result;
			}
			foreach (StickerPlacement p in placements)
			{
				if (p == null || string.IsNullOrWhiteSpace(p.SurfaceGuid) || string.IsNullOrWhiteSpace(p.StickerFileName))
				{
					continue;
				}
				// One sticker per surface; a later entry replaces an earlier one, same as RecordPlacement.
				result.RemoveAll(existing => string.Equals(existing.SurfaceGuid, p.SurfaceGuid, StringComparison.OrdinalIgnoreCase));
				result.Add(new StickerPlacement
				{
					SurfaceGuid = p.SurfaceGuid.Trim(),
					StickerFileName = p.StickerFileName.Trim()
				});
			}
			return result;
		}

		private static string ArchiveFile(string path, string reason)
		{
			try
			{
				string target = Path.Combine(
					Path.GetDirectoryName(path),
					Path.GetFileNameWithoutExtension(path) + "." + reason + "-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".json");
				File.Move(path, target);
				DebugLog.Log("Save", "Moved " + path + " -> " + target);
				return target;
			}
			catch (Exception ex)
			{
				DebugLog.Log("Save", "Archive failed for " + path + ": " + ex.Message);
				return null;
			}
		}

		private sealed class SaveFileData
		{
			public int Version { get; set; } = FormatVersion;

			/// <summary>The game save this file belongs to. Informational only.</summary>
			public string SaveFolder { get; set; } = "";

			public string SaveFingerprint { get; set; }

			public List<StickerPlacement> Placements { get; set; } = new List<StickerPlacement>();
		}
	}
}

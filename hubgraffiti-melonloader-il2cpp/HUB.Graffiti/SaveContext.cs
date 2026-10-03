using System;
using System.IO;
using System.Text.Json;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence;

namespace HUB.Graffiti
{
	/// <summary>
	/// Finds out which save slot the game currently has loaded. The game's save folder is only ever
	/// read here, never written: everything the mod stores lives under UserData/HUB_Graffiti.
	/// </summary>
	internal static class SaveContext
	{
		/// <summary>True once the game reports the save finished loading; null if that can't be determined.</summary>
		internal static bool? IsGameLoaded()
		{
			try
			{
				LoadManager loadManager = GetLoadManager();
				if (loadManager == null)
				{
					return null;
				}
				return !loadManager.IsLoading && loadManager.IsGameLoaded;
			}
			catch (Exception ex)
			{
				DebugLog.Log("SaveCtx", "Load state read failed: " + ex.Message);
				return null;
			}
		}

		/// <summary>
		/// Full path of the loaded save, e.g. ...\LocalLow\TVGS\Schedule I\Saves\7656119...\SaveGame_2,
		/// or null when no save is loaded.
		/// </summary>
		internal static string GetLoadedSaveFolder()
		{
			string path = null;
			try
			{
				LoadManager loadManager = GetLoadManager();
				if (loadManager == null)
				{
					DebugLog.Log("SaveCtx", "LoadManager not available");
					return null;
				}
				path = loadManager.LoadedGameFolderPath;
				if (string.IsNullOrWhiteSpace(path) && loadManager.ActiveSaveInfo != null)
				{
					path = loadManager.ActiveSaveInfo.SavePath;
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("SaveCtx", "Save folder read failed: " + ex.Message);
			}
			if (string.IsNullOrWhiteSpace(path))
			{
				return null;
			}
			return path.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
		}

		/// <summary>
		/// Relative storage key that mirrors the game's own layout: "&lt;steamid&gt;/SaveGame_&lt;n&gt;".
		/// </summary>
		internal static string BuildStorageKey(string saveFolder)
		{
			string slot = Sanitize(Path.GetFileName(saveFolder));
			string owner = Sanitize(Path.GetFileName(Path.GetDirectoryName(saveFolder) ?? ""));
			return string.IsNullOrEmpty(owner) ? slot : Path.Combine(owner, slot);
		}

		/// <summary>
		/// Something that identifies this particular playthrough, so a slot that was deleted and started
		/// over doesn't inherit the old game's stickers. Read-only: opens the game's metadata with
		/// FileShare.ReadWrite so it never blocks the game from saving. Returns null if unavailable.
		/// </summary>
		internal static string ReadFingerprint(string saveFolder)
		{
			if (string.IsNullOrEmpty(saveFolder))
			{
				return null;
			}
			try
			{
				string metadataPath = Path.Combine(saveFolder, "Metadata.json");
				if (!File.Exists(metadataPath))
				{
					return null;
				}
				string json;
				using (FileStream stream = new FileStream(metadataPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete))
				using (StreamReader reader = new StreamReader(stream))
				{
					json = reader.ReadToEnd();
				}
				using (JsonDocument doc = JsonDocument.Parse(json))
				{
					if (doc.RootElement.ValueKind == JsonValueKind.Object
						&& doc.RootElement.TryGetProperty("CreationDate", out JsonElement created))
					{
						return "created:" + created.GetRawText().Replace(" ", "").Replace("\r", "").Replace("\n", "").Replace("\t", "");
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("SaveCtx", "Fingerprint read failed: " + ex.Message);
			}
			return null;
		}

		private static LoadManager GetLoadManager()
		{
			return Singleton<LoadManager>.InstanceExists ? Singleton<LoadManager>.Instance : null;
		}

		private static string Sanitize(string segment)
		{
			if (string.IsNullOrEmpty(segment))
			{
				return "";
			}
			foreach (char c in Path.GetInvalidFileNameChars())
			{
				segment = segment.Replace(c, '_');
			}
			return segment == "." || segment == ".." ? "_" : segment;
		}
	}
}

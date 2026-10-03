using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using MelonLoader.Utils;

namespace HUB.Graffiti
{
	// Token: 0x0200000E RID: 14
	[NullableContext(1)]
	[Nullable(0)]
	internal static class StickerSaveManager
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000064E1 File Offset: 0x000046E1
		internal static IReadOnlyList<StickerPlacement> Placements
		{
			get
			{
				return StickerSaveManager._placements;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000064E8 File Offset: 0x000046E8
		internal static void Load()
		{
			if (StickerSaveManager._loaded)
			{
				return;
			}
			StickerSaveManager._loaded = true;
			try
			{
				if (!File.Exists(StickerSaveManager.SavePath))
				{
					DebugLog.Log("Save", "No save file found");
				}
				else
				{
					List<StickerPlacement> list = JsonSerializer.Deserialize<List<StickerPlacement>>(File.ReadAllText(StickerSaveManager.SavePath), null);
					if (list != null)
					{
						StickerSaveManager._placements = list;
						string category = "Save";
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(26, 1);
						defaultInterpolatedStringHandler.AppendLiteral("Loaded ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(StickerSaveManager._placements.Count);
						defaultInterpolatedStringHandler.AppendLiteral(" sticker placements");
						DebugLog.Log(category, defaultInterpolatedStringHandler.ToStringAndClear());
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Save", "Load error: " + ex.Message);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000065AC File Offset: 0x000047AC
		internal static void RecordPlacement(string surfaceGuid, string stickerFileName)
		{
			StickerSaveManager._placements.RemoveAll((StickerPlacement p) => p.SurfaceGuid == surfaceGuid);
			StickerSaveManager._placements.Add(new StickerPlacement
			{
				SurfaceGuid = surfaceGuid,
				StickerFileName = stickerFileName
			});
			StickerSaveManager.WriteToDisk();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006604 File Offset: 0x00004804
		internal static void ApplyFromNetwork(List<StickerPlacement> placements)
		{
			StickerSaveManager._placements = new List<StickerPlacement>(placements);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006611 File Offset: 0x00004811
		internal static void Reset()
		{
			StickerSaveManager._placements.Clear();
			StickerSaveManager._loaded = false;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006624 File Offset: 0x00004824
		private static void WriteToDisk()
		{
			try
			{
				string directoryName = Path.GetDirectoryName(StickerSaveManager.SavePath);
				if (directoryName != null && !Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				string contents = JsonSerializer.Serialize<List<StickerPlacement>>(StickerSaveManager._placements, new JsonSerializerOptions
				{
					WriteIndented = true
				});
				File.WriteAllText(StickerSaveManager.SavePath, contents);
				string category = "Save";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Saved ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(StickerSaveManager._placements.Count);
				defaultInterpolatedStringHandler.AppendLiteral(" placements to disk");
				DebugLog.Log(category, defaultInterpolatedStringHandler.ToStringAndClear());
			}
			catch (Exception ex)
			{
				DebugLog.Log("Save", "Write error: " + ex.Message);
			}
		}

		// Token: 0x04000025 RID: 37
		private static readonly string SavePath = Path.Combine(MelonEnvironment.UserDataDirectory, "HUB_Graffiti", "sticker_placements.json");

		// Token: 0x04000026 RID: 38
		private static List<StickerPlacement> _placements = new List<StickerPlacement>();

		// Token: 0x04000027 RID: 39
		private static bool _loaded;
	}
}

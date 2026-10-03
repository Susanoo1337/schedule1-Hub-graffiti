using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using HarmonyLib;
using HUB.Graffiti.Network;
using Il2CppScheduleOne.Networking;
using MelonLoader;
using ModHub.Core;
using UnityEngine;

namespace HUB.Graffiti
{
	// Token: 0x02000008 RID: 8
	[NullableContext(2)]
	[Nullable(0)]
	public class GraffitiMod : MelonMod
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00003010 File Offset: 0x00001210
		public override void OnInitializeMelon()
		{
			this.SetupPreferences();
			MelonLogger.Msg("===========================================");
			MelonLogger.Msg("  HUB - Graffiti v1.2.1");
			MelonLogger.Msg("  by Trippzad");
			MelonLogger.Msg("===========================================");
			DebugLog.LogSessionStart();
			string modName = "HUB - Graffiti";
			CustomContentRenderer renderer;
			if ((renderer = GraffitiMod.<>O.<0>__RenderContent) == null)
			{
				renderer = (GraffitiMod.<>O.<0>__RenderContent = new CustomContentRenderer(CustomUI.RenderContent));
			}
			ModHubCore.RegisterCustomContent(modName, renderer);
			this.ApplyLobbyChatPatch();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000307C File Offset: 0x0000127C
		private void SetupPreferences()
		{
			GraffitiMod.Category = MelonPreferences.CreateCategory("HUB - Graffiti", "HUB - Graffiti");
			GraffitiMod.EnableMod = GraffitiMod.Category.CreateEntry<bool>("01_EnableMod", true, "Enable Mod", null, false, false, null, null);
			GraffitiMod.SpotsTagged = GraffitiMod.Category.CreateEntry<int>("02_SpotsTagged", 0, "Spots Tagged", null, false, false, null, null);
			MelonPreferences.Save();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000030E0 File Offset: 0x000012E0
		private void ApplyLobbyChatPatch()
		{
			try
			{
				MethodInfo method = typeof(Lobby).GetMethod("OnLobbyChatMessage", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if (method != null)
				{
					MethodInfo method2 = typeof(LobbyChatPatch).GetMethod("Postfix", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
					base.HarmonyInstance.Patch(method, null, new HarmonyMethod(method2), null, null, null);
					DebugLog.Log("Init", "Lobby chat patch applied");
				}
				else
				{
					DebugLog.Log("Init", "Lobby.OnLobbyChatMessage not found â€” MP chat sync unavailable");
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Init", "Lobby chat patch failed: " + ex.Message);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000318C File Offset: 0x0000138C
		public override void OnUpdate()
		{
			DebugLog.Update(Time.deltaTime);
			MelonPreferences_Entry<bool> enableMod = GraffitiMod.EnableMod;
			if (enableMod == null || !enableMod.Value)
			{
				return;
			}
			GraffitiPlacer.Update();
			GraffitiSync.Tick(Time.deltaTime);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000031C0 File Offset: 0x000013C0
		[NullableContext(1)]
		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			DebugLog.Log("Scene", "Scene loaded: " + sceneName);
			GraffitiPlacer.OnSceneLoaded(sceneName);
			NetworkHelper.Reset();
			if (sceneName == "Main")
			{
				StickerManager.Initialize();
				MelonCoroutines.Start(this.RestoreAndSyncCoroutine());
				return;
			}
			GraffitiSync.Shutdown();
			StickerSaveManager.Reset();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003216 File Offset: 0x00001416
		[NullableContext(1)]
		private IEnumerator RestoreAndSyncCoroutine()
		{
			return new GraffitiMod.<RestoreAndSyncCoroutine>d__8(0);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000321E File Offset: 0x0000141E
		public override void OnApplicationQuit()
		{
			GraffitiSync.Shutdown();
			DebugLog.Reset();
		}

		// Token: 0x0400000C RID: 12
		internal static MelonPreferences_Category Category;

		// Token: 0x0400000D RID: 13
		internal static MelonPreferences_Entry<bool> EnableMod;

		// Token: 0x0400000E RID: 14
		internal static MelonPreferences_Entry<int> SpotsTagged;

		// Token: 0x02000013 RID: 19
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000036 RID: 54
			[Nullable(0)]
			public static CustomContentRenderer <0>__RenderContent;
		}
	}
}

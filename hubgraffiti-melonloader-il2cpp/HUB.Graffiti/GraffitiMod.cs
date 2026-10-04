using System;
using System.Collections;
using HUB.Graffiti.Network;
using MelonLoader;
using ModHub.Core;
using UnityEngine;

namespace HUB.Graffiti
{
	public class GraffitiMod : MelonMod
	{
		internal const string ModName = "HUB - Graffiti";
		internal const string ModVersion = "1.3.0";

		internal const int DefaultStickerResolution = 2048;
		internal const int MinStickerResolution = 256;
		internal const int MaxStickerResolutionLimit = 4096;

		private const float MaxLoadWaitSeconds = 120f;
		private const float UnknownLoadStateWaitSeconds = 8f;
		private const float MissingSurfaceRetrySeconds = 15f;

		internal static MelonPreferences_Category Category;
		internal static MelonPreferences_Entry<bool> EnableMod;
		internal static MelonPreferences_Entry<int> SpotsTagged;
		internal static MelonPreferences_Entry<int> StickerResolution;

		/// <summary>Bumped on every scene load so coroutines started for an earlier scene can bail out.</summary>
		internal static int SceneToken { get; private set; }

		/// <summary>Longest side, in pixels, a placed sticker is rendered at (capped by the PNG's own size).</summary>
		internal static int MaxStickerResolution
		{
			get
			{
				int value = StickerResolution != null ? StickerResolution.Value : DefaultStickerResolution;
				return Math.Max(MinStickerResolution, Math.Min(MaxStickerResolutionLimit, value));
			}
		}

		public override void OnInitializeMelon()
		{
			SetupPreferences();
			MelonLogger.Msg("===========================================");
			MelonLogger.Msg("  " + ModName + " v" + ModVersion);
			MelonLogger.Msg("  by Trippzad (community fork)");
			MelonLogger.Msg("===========================================");
			DebugLog.LogSessionStart();
			ModHubCore.RegisterCustomContent(ModName, new CustomContentRenderer(CustomUI.RenderContent));
		}

		private void SetupPreferences()
		{
			Category = MelonPreferences.CreateCategory("HUB - Graffiti", "HUB - Graffiti");
			EnableMod = Category.CreateEntry("01_EnableMod", true, "Enable Mod");
			SpotsTagged = Category.CreateEntry("02_SpotsTagged", 0, "Spots Tagged");
			StickerResolution = Category.CreateEntry("03_StickerResolution", DefaultStickerResolution, "Sticker Resolution",
				"Longest side in pixels that placed stickers are rendered at (" + MinStickerResolution + "-" + MaxStickerResolutionLimit + "). Never exceeds the PNG's own size.");
			MelonPreferences.Save();
		}

		public override void OnUpdate()
		{
			DebugLog.Update(Time.deltaTime);
			CustomUI.Tick();
			if (EnableMod == null || !EnableMod.Value)
			{
				return;
			}
			GraffitiPlacer.Update();
			GraffitiSync.Tick(Time.deltaTime);
		}

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			SceneToken++;
			DebugLog.Log("Scene", "Scene loaded: " + sceneName);
			StickerPickerUI.Close();
			GraffitiPlacer.OnSceneLoaded(sceneName);
			NetworkHelper.Reset();
			GraffitiSync.Shutdown();
			StickerSaveManager.Reset();
			if (sceneName == "Main")
			{
				StickerManager.Initialize();
				MelonCoroutines.Start(RestoreAndSyncCoroutine(SceneToken));
			}
			CustomUI.RequestRefresh();
		}

		/// <summary>
		/// Waits for the game to finish loading the save, then loads this save's placements, starts
		/// multiplayer sync and puts the stickers back on their surfaces.
		/// </summary>
		private static IEnumerator RestoreAndSyncCoroutine(int sceneToken)
		{
			float waited = 0f;
			while (waited < MaxLoadWaitSeconds)
			{
				bool? loaded = SaveContext.IsGameLoaded();
				if (loaded == true || (loaded == null && waited >= UnknownLoadStateWaitSeconds))
				{
					break;
				}
				yield return new WaitForSeconds(0.5f);
				waited += 0.5f;
				if (sceneToken != SceneToken)
				{
					yield break;
				}
			}
			// The game restores its own graffiti right after loading; let it finish so it can't overwrite ours.
			yield return new WaitForSeconds(2f);
			if (sceneToken != SceneToken)
			{
				yield break;
			}

			StickerSaveManager.Load();
			GraffitiSync.Initialize();
			foreach (bool _ in GraffitiPlacer.SyncSteps())
			{
				yield return null;
				if (sceneToken != SceneToken)
				{
					yield break;
				}
			}
			CustomUI.RequestRefresh();

			yield return new WaitForSeconds(5f);
			if (sceneToken != SceneToken)
			{
				yield break;
			}
			SurfaceDecals.ReassertAll();

			// Some surfaces appear after the save has loaded: vehicles spawning in, or (for clients) arriving
			// over the network. Keep looking for the ones not found yet, for as long as this scene lives.
			while (true)
			{
				yield return new WaitForSeconds(MissingSurfaceRetrySeconds);
				if (sceneToken != SceneToken)
				{
					yield break;
				}
				if (GraffitiPlacer.MissingSurfaceCount > 0 && EnableMod != null && EnableMod.Value)
				{
					int before = GraffitiPlacer.MissingSurfaceCount;
					GraffitiPlacer.SyncWorldToPlacements();
					if (GraffitiPlacer.MissingSurfaceCount != before)
					{
						CustomUI.RequestRefresh();
					}
				}
			}
		}

		public override void OnApplicationQuit()
		{
			GraffitiSync.Shutdown();
			DebugLog.Reset();
		}
	}
}

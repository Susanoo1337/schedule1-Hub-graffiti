using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.Networking;
using Il2CppSteamworks;
using MelonLoader;

namespace HUB.Graffiti.Network
{
	// Token: 0x0200000F RID: 15
	[NullableContext(1)]
	[Nullable(0)]
	internal static class GraffitiSync
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00006709 File Offset: 0x00004909
		internal static bool IsRunning
		{
			get
			{
				return GraffitiSync._running;
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00006710 File Offset: 0x00004910
		internal static void Initialize()
		{
			if (GraffitiSync._running)
			{
				return;
			}
			if (!NetworkHelper.IsMultiplayer)
			{
				DebugLog.Log("Sync", "Single-player — sync disabled.");
				return;
			}
			GraffitiSync._running = true;
			GraffitiSync._broadcastTimer = 0f;
			GraffitiSync._lastStateHash = "";
			string str = NetworkHelper.IsHost ? "HOST" : "CLIENT";
			MelonLogger.Msg("[Graffiti] Steam lobby sync initialized as " + str);
			if (NetworkHelper.IsHost)
			{
				GraffitiSync.BroadcastState();
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006788 File Offset: 0x00004988
		internal static void Shutdown()
		{
			if (GraffitiSync._running && NetworkHelper.IsHost)
			{
				try
				{
					Lobby lobby = NetworkHelper.GetLobby();
					if (lobby != null && lobby.IsInLobby)
					{
						lobby.SetLobbyData("graf_state", "");
					}
				}
				catch
				{
				}
			}
			GraffitiSync._running = false;
			GraffitiSync._sleepPaused = false;
			GraffitiSync._sleepResumeDelay = 0f;
			GraffitiSync._lastStateHash = "";
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006800 File Offset: 0x00004A00
		internal static void OnSleepStart()
		{
			if (!GraffitiSync._running)
			{
				return;
			}
			GraffitiSync._sleepPaused = true;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006810 File Offset: 0x00004A10
		internal static void OnSleepEnd()
		{
			if (!GraffitiSync._running)
			{
				return;
			}
			GraffitiSync._sleepResumeDelay = 3f;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006824 File Offset: 0x00004A24
		internal static void Tick(float dt)
		{
			if (!GraffitiSync._running)
			{
				return;
			}
			if (GraffitiSync._sleepResumeDelay > 0f)
			{
				GraffitiSync._sleepResumeDelay -= dt;
				if (GraffitiSync._sleepResumeDelay <= 0f)
				{
					GraffitiSync._sleepPaused = false;
					GraffitiSync._sleepResumeDelay = 0f;
					GraffitiSync._broadcastTimer = 0f;
				}
				return;
			}
			if (GraffitiSync._sleepPaused)
			{
				return;
			}
			if (NetworkHelper.IsHost)
			{
				GraffitiSync._broadcastTimer += dt;
				if (GraffitiSync._broadcastTimer >= 5f)
				{
					GraffitiSync._broadcastTimer = 0f;
					GraffitiSync.BroadcastState();
					return;
				}
			}
			else
			{
				GraffitiSync.PollState();
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000068B4 File Offset: 0x00004AB4
		internal static void NotifyPlacement(string surfaceGuid, string stickerFileName)
		{
			if (!GraffitiSync._running)
			{
				return;
			}
			if (NetworkHelper.IsHost)
			{
				GraffitiSync.BroadcastState();
				return;
			}
			try
			{
				Lobby lobby = NetworkHelper.GetLobby();
				if (!(lobby == null) && lobby.IsInLobby)
				{
					string str = JsonSerializer.Serialize<GraffitiSync.PlacementAction>(new GraffitiSync.PlacementAction
					{
						Type = "place_sticker",
						SurfaceGuid = surfaceGuid,
						StickerFileName = stickerFileName
					}, null);
					lobby.SendLobbyMessage("GRAF:" + str);
					DebugLog.Log("Sync", "Sent placement to host: " + stickerFileName + " on " + surfaceGuid);
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Sync", "Send error: " + ex.Message);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006970 File Offset: 0x00004B70
		private static void BroadcastState()
		{
			try
			{
				Lobby lobby = NetworkHelper.GetLobby();
				if (!(lobby == null) && lobby.IsInLobby)
				{
					string text = JsonSerializer.Serialize<IReadOnlyList<StickerPlacement>>(StickerSaveManager.Placements, null);
					lobby.SetLobbyData("graf_state", text);
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Sync", "Broadcast error: " + ex.Message);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000069E0 File Offset: 0x00004BE0
		private static void PollState()
		{
			try
			{
				Lobby lobby = NetworkHelper.GetLobby();
				if (!(lobby == null) && lobby.IsInLobby)
				{
					string lobbyData = SteamMatchmaking.GetLobbyData(lobby.LobbySteamID, "graf_state");
					if (!string.IsNullOrEmpty(lobbyData))
					{
						string text = lobbyData.GetHashCode().ToString();
						if (!(text == GraffitiSync._lastStateHash))
						{
							GraffitiSync._lastStateHash = text;
							List<StickerPlacement> list = JsonSerializer.Deserialize<List<StickerPlacement>>(lobbyData, null);
							if (list != null)
							{
								StickerSaveManager.ApplyFromNetwork(list);
								GraffitiPlacer.ApplyAllStickers();
								string category = "Sync";
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
								defaultInterpolatedStringHandler.AppendLiteral("Applied ");
								defaultInterpolatedStringHandler.AppendFormatted<int>(list.Count);
								defaultInterpolatedStringHandler.AppendLiteral(" placements from host");
								DebugLog.Log(category, defaultInterpolatedStringHandler.ToStringAndClear());
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Sync", "Poll error: " + ex.Message);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006AD4 File Offset: 0x00004CD4
		internal static void OnLobbyChatReceived(LobbyChatMsg_t result)
		{
			if (!GraffitiSync._running || !NetworkHelper.IsHost || GraffitiSync._sleepPaused)
			{
				return;
			}
			try
			{
				Lobby lobby = NetworkHelper.GetLobby();
				if (!(lobby == null))
				{
					Il2CppStructArray<byte> il2CppStructArray = new Il2CppStructArray<byte>(4096L);
					CSteamID csteamID;
					EChatEntryType echatEntryType;
					int lobbyChatEntry = SteamMatchmaking.GetLobbyChatEntry(lobby.LobbySteamID, (int)result.m_iChatID, ref csteamID, il2CppStructArray, 4096, ref echatEntryType);
					if (lobbyChatEntry > 0)
					{
						byte[] array = new byte[lobbyChatEntry];
						for (int i = 0; i < lobbyChatEntry; i++)
						{
							array[i] = il2CppStructArray[i];
						}
						string @string = Encoding.UTF8.GetString(array, 0, lobbyChatEntry);
						if (@string.StartsWith("GRAF:"))
						{
							GraffitiSync.PlacementAction placementAction = JsonSerializer.Deserialize<GraffitiSync.PlacementAction>(@string.Substring("GRAF:".Length), null);
							if (placementAction != null)
							{
								if (placementAction.Type == "place_sticker" && !string.IsNullOrEmpty(placementAction.SurfaceGuid) && !string.IsNullOrEmpty(placementAction.StickerFileName))
								{
									StickerSaveManager.RecordPlacement(placementAction.SurfaceGuid, placementAction.StickerFileName);
									GraffitiPlacer.ApplyAllStickers();
									GraffitiSync.BroadcastState();
									DebugLog.Log("Sync", "Host recorded remote placement: " + placementAction.StickerFileName + " on " + placementAction.SurfaceGuid);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Sync", "Chat handler error: " + ex.Message);
			}
		}

		// Token: 0x04000028 RID: 40
		private const float BROADCAST_INTERVAL = 5f;

		// Token: 0x04000029 RID: 41
		private const string STATE_KEY = "graf_state";

		// Token: 0x0400002A RID: 42
		private const string MSG_PREFIX = "GRAF:";

		// Token: 0x0400002B RID: 43
		private static bool _running;

		// Token: 0x0400002C RID: 44
		private static float _broadcastTimer;

		// Token: 0x0400002D RID: 45
		private static string _lastStateHash = "";

		// Token: 0x0400002E RID: 46
		private static bool _sleepPaused;

		// Token: 0x0400002F RID: 47
		private static float _sleepResumeDelay;

		// Token: 0x04000030 RID: 48
		private const float SLEEP_RESUME_DELAY = 3f;

		// Token: 0x0200001B RID: 27
		[Nullable(0)]
		private class PlacementAction
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600007B RID: 123 RVA: 0x00006F1F File Offset: 0x0000511F
			// (set) Token: 0x0600007C RID: 124 RVA: 0x00006F27 File Offset: 0x00005127
			public string Type { get; set; } = "";

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600007D RID: 125 RVA: 0x00006F30 File Offset: 0x00005130
			// (set) Token: 0x0600007E RID: 126 RVA: 0x00006F38 File Offset: 0x00005138
			public string SurfaceGuid { get; set; } = "";

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600007F RID: 127 RVA: 0x00006F41 File Offset: 0x00005141
			// (set) Token: 0x06000080 RID: 128 RVA: 0x00006F49 File Offset: 0x00005149
			public string StickerFileName { get; set; } = "";
		}
	}
}

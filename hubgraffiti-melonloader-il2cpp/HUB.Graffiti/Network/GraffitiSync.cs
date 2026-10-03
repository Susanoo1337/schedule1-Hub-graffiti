using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Networking;
using MelonLoader;

namespace HUB.Graffiti.Network
{
	/// <summary>
	/// Multiplayer sync over the game's lobby service (Steam lobby under the hood). The host owns the
	/// placement list and publishes it as lobby data; clients poll it and send their own place/remove
	/// requests to the host as lobby messages, which the host receives through ILobbyService.OnLobbyMessage.
	/// </summary>
	internal static class GraffitiSync
	{
		private const float BroadcastInterval = 5f;
		private const float PollInterval = 1f;
		private const float SleepResumeDelay = 3f;
		private const string StateKey = "graf_state";
		private const string MsgPrefix = "GRAF:";
		private const string ActionPlace = "place_sticker";
		private const string ActionRemove = "remove_sticker";
		// Steam rejects lobby data values above 8 KB.
		private const int MaxLobbyDataBytes = 8192;
		private const int MaxGuidLength = 64;
		private const int MaxNameLength = 128;

		private static bool _running;
		private static float _broadcastTimer;
		private static float _pollTimer;
		private static string _lastReceivedState = "";
		private static string _lastBroadcastState;
		private static bool _warnedOversize;
		private static bool _sleepPaused;
		private static float _sleepResumeDelay;

		// The lobby service we're listening to and the delegate we gave it, so we can unsubscribe.
		private static ILobbyService _subscribedService;
		private static Il2CppSystem.Action<string> _messageHandler;

		internal static bool IsRunning => _running;

		internal static void Initialize()
		{
			if (_running)
			{
				return;
			}
			if (!NetworkHelper.IsMultiplayer)
			{
				DebugLog.Log("Sync", "Single-player - sync disabled.");
				return;
			}
			_running = true;
			_broadcastTimer = 0f;
			_pollTimer = PollInterval;
			_lastReceivedState = "";
			_lastBroadcastState = null;
			MelonLogger.Msg("[Graffiti] Steam lobby sync initialized as " + (NetworkHelper.IsHost ? "HOST" : "CLIENT"));
			if (NetworkHelper.IsHost)
			{
				EnsureMessageSubscription();
				BroadcastState();
			}
		}

		internal static void Shutdown()
		{
			Unsubscribe();
			if (_running && NetworkHelper.IsHost)
			{
				try
				{
					Lobby lobby = NetworkHelper.GetLobby();
					if (lobby != null && lobby.IsInLobby)
					{
						lobby.SetLobbyData(StateKey, "");
					}
				}
				catch
				{
				}
			}
			_running = false;
			_sleepPaused = false;
			_sleepResumeDelay = 0f;
			_lastReceivedState = "";
			_lastBroadcastState = null;
		}

		internal static void OnSleepStart()
		{
			if (_running)
			{
				_sleepPaused = true;
			}
		}

		internal static void OnSleepEnd()
		{
			if (_running)
			{
				_sleepResumeDelay = SleepResumeDelay;
			}
		}

		internal static void Tick(float dt)
		{
			if (!_running)
			{
				return;
			}
			if (_sleepResumeDelay > 0f)
			{
				_sleepResumeDelay -= dt;
				if (_sleepResumeDelay <= 0f)
				{
					_sleepPaused = false;
					_sleepResumeDelay = 0f;
					_broadcastTimer = 0f;
				}
				return;
			}
			if (_sleepPaused)
			{
				return;
			}

			if (NetworkHelper.IsHost)
			{
				_broadcastTimer += dt;
				if (_broadcastTimer >= BroadcastInterval)
				{
					_broadcastTimer = 0f;
					// The game may recreate its lobby service (e.g. a new lobby); follow it.
					EnsureMessageSubscription();
					BroadcastState();
				}
			}
			else
			{
				_pollTimer += dt;
				if (_pollTimer >= PollInterval)
				{
					_pollTimer = 0f;
					PollState();
				}
			}
		}

		internal static void NotifyPlacement(string surfaceGuid, string stickerFileName)
		{
			NotifyAction(ActionPlace, surfaceGuid, stickerFileName);
		}

		internal static void NotifyRemoval(string surfaceGuid)
		{
			NotifyAction(ActionRemove, surfaceGuid, "");
		}

		/// <summary>Host: publish the current list now (after a bulk change such as a legacy import).</summary>
		internal static void NotifyStateChanged()
		{
			if (_running && NetworkHelper.IsHost)
			{
				BroadcastState();
			}
		}

		private static void NotifyAction(string type, string surfaceGuid, string stickerFileName)
		{
			if (!_running)
			{
				return;
			}
			if (NetworkHelper.IsHost)
			{
				BroadcastState();
				return;
			}
			try
			{
				Lobby lobby = NetworkHelper.GetLobby();
				if (lobby == null || !lobby.IsInLobby)
				{
					return;
				}
				string json = JsonSerializer.Serialize(new PlacementAction
				{
					Type = type,
					SurfaceGuid = surfaceGuid,
					StickerFileName = stickerFileName
				});
				lobby.SendLobbyMessage(MsgPrefix + json);
				DebugLog.Log("Sync", "Sent " + type + " to host: " + stickerFileName + " on " + surfaceGuid);
			}
			catch (Exception ex)
			{
				DebugLog.Log("Sync", "Send error: " + ex.Message);
			}
		}

		private static void BroadcastState()
		{
			try
			{
				Lobby lobby = NetworkHelper.GetLobby();
				if (lobby == null || !lobby.IsInLobby)
				{
					return;
				}
				string state = JsonSerializer.Serialize(StickerSaveManager.Placements);
				if (state == _lastBroadcastState)
				{
					return;
				}
				if (Encoding.UTF8.GetByteCount(state) >= MaxLobbyDataBytes)
				{
					if (!_warnedOversize)
					{
						_warnedOversize = true;
						MelonLogger.Warning("[HUB - Graffiti] Too many stickers to sync over the Steam lobby (" + StickerSaveManager.Placements.Count + "); other players may not see all of them.");
					}
					return;
				}
				lobby.SetLobbyData(StateKey, state);
				_lastBroadcastState = state;
			}
			catch (Exception ex)
			{
				DebugLog.Log("Sync", "Broadcast error: " + ex.Message);
			}
		}

		private static void PollState()
		{
			try
			{
				Lobby lobby = NetworkHelper.GetLobby();
				if (lobby == null || !lobby.IsInLobby)
				{
					return;
				}
				ILobbyService service = lobby._lobbyService;
				if (service == null)
				{
					return;
				}
				string state = service.GetLobbyData(StateKey);
				if (string.IsNullOrEmpty(state) || state == _lastReceivedState)
				{
					return;
				}
				_lastReceivedState = state;
				List<StickerPlacement> placements = JsonSerializer.Deserialize<List<StickerPlacement>>(state);
				if (placements == null)
				{
					return;
				}
				StickerSaveManager.ApplyFromNetwork(placements);
				GraffitiPlacer.SyncWorldToPlacements();
				CustomUI.RequestRefresh();
				DebugLog.Log("Sync", "Applied " + placements.Count + " placements from host");
			}
			catch (Exception ex)
			{
				DebugLog.Log("Sync", "Poll error: " + ex.Message);
			}
		}

		private static void EnsureMessageSubscription()
		{
			try
			{
				Lobby lobby = NetworkHelper.GetLobby();
				ILobbyService service = lobby != null ? lobby._lobbyService : null;
				if (service == null)
				{
					return;
				}
				if (_subscribedService != null && _subscribedService.Pointer == service.Pointer)
				{
					return;
				}
				Unsubscribe();
				_messageHandler = DelegateSupport.ConvertDelegate<Il2CppSystem.Action<string>>(new Action<string>(OnLobbyMessage));
				service.add_OnLobbyMessage(_messageHandler);
				_subscribedService = service;
				DebugLog.Log("Sync", "Listening for lobby messages");
			}
			catch (Exception ex)
			{
				DebugLog.Log("Sync", "Lobby message subscribe failed: " + ex.Message);
			}
		}

		private static void Unsubscribe()
		{
			if (_subscribedService != null && _messageHandler != null)
			{
				try
				{
					_subscribedService.remove_OnLobbyMessage(_messageHandler);
				}
				catch
				{
				}
			}
			_subscribedService = null;
			_messageHandler = null;
		}

		/// <summary>Host side: every lobby message arrives here; only ours (GRAF: prefix) are handled.</summary>
		private static void OnLobbyMessage(string message)
		{
			if (!_running || !NetworkHelper.IsHost || _sleepPaused || string.IsNullOrEmpty(message))
			{
				return;
			}
			try
			{
				message = message.TrimEnd('\0');
				if (!message.StartsWith(MsgPrefix))
				{
					return;
				}
				PlacementAction action = JsonSerializer.Deserialize<PlacementAction>(message.Substring(MsgPrefix.Length));
				if (action == null || string.IsNullOrEmpty(action.SurfaceGuid) || action.SurfaceGuid.Length > MaxGuidLength)
				{
					return;
				}

				if (action.Type == ActionPlace)
				{
					if (string.IsNullOrEmpty(action.StickerFileName) || action.StickerFileName.Length > MaxNameLength)
					{
						return;
					}
					StickerSaveManager.RecordPlacement(action.SurfaceGuid, action.StickerFileName);
					GraffitiPlacer.SyncWorldToPlacements();
					BroadcastState();
					CustomUI.RequestRefresh();
					DebugLog.Log("Sync", "Host recorded remote placement: " + action.StickerFileName + " on " + action.SurfaceGuid);
				}
				else if (action.Type == ActionRemove)
				{
					GraffitiPlacer.RemovePlacement(action.SurfaceGuid, true);
					BroadcastState();
					DebugLog.Log("Sync", "Host removed sticker on request: " + action.SurfaceGuid);
				}
			}
			catch (Exception ex)
			{
				DebugLog.Log("Sync", "Lobby message handler error: " + ex.Message);
			}
		}

		private class PlacementAction
		{
			public string Type { get; set; } = "";

			public string SurfaceGuid { get; set; } = "";

			public string StickerFileName { get; set; } = "";
		}
	}
}

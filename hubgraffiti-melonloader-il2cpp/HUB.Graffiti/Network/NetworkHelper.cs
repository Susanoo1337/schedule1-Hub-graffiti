using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Networking;
using MelonLoader;

namespace HUB.Graffiti.Network
{
	internal static class NetworkHelper
	{
		private static bool _loggedOnce;

		/// <summary>True for the lobby host, and in single player (no lobby).</summary>
		internal static bool IsHost
		{
			get
			{
				Lobby lobby = GetLobby();
				if (lobby == null)
				{
					return true;
				}
				bool isHost = lobby.IsHost;
				if (!_loggedOnce)
				{
					string role = lobby.IsInLobby ? (isHost ? "Host" : "Client") : "Single Player (no lobby)";
					MelonLogger.Msg("[Graffiti] Network role: " + role);
					_loggedOnce = true;
				}
				return isHost;
			}
		}

		internal static bool IsClient => !IsHost;

		internal static bool IsMultiplayer
		{
			get
			{
				Lobby lobby = GetLobby();
				return lobby != null && lobby.IsInLobby;
			}
		}

		internal static Lobby GetLobby()
		{
			try
			{
				return Singleton<Lobby>.InstanceExists ? Singleton<Lobby>.Instance : null;
			}
			catch
			{
				return null;
			}
		}

		internal static void Reset()
		{
			_loggedOnce = false;
		}
	}
}

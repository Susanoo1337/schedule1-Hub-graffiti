using System;
using System.Runtime.CompilerServices;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Networking;
using MelonLoader;

namespace HUB.Graffiti.Network
{
	// Token: 0x02000011 RID: 17
	internal static class NetworkHelper
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00006CAC File Offset: 0x00004EAC
		internal static bool IsHost
		{
			get
			{
				Lobby lobby = NetworkHelper.GetLobby();
				if (lobby == null)
				{
					return true;
				}
				bool isHost = lobby.IsHost;
				if (!NetworkHelper._loggedOnce)
				{
					string str = lobby.IsInLobby ? (isHost ? "Host" : "Client") : "Single Player (no lobby)";
					MelonLogger.Msg("[Graffiti] Network role: " + str);
					NetworkHelper._loggedOnce = true;
				}
				return isHost;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00006D0E File Offset: 0x00004F0E
		internal static bool IsClient
		{
			get
			{
				return !NetworkHelper.IsHost;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00006D18 File Offset: 0x00004F18
		internal static bool IsMultiplayer
		{
			get
			{
				Lobby lobby = NetworkHelper.GetLobby();
				return lobby != null && lobby.IsInLobby;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00006D3C File Offset: 0x00004F3C
		[NullableContext(2)]
		internal static Lobby GetLobby()
		{
			Lobby result;
			try
			{
				if (!Singleton<Lobby>.InstanceExists)
				{
					result = null;
				}
				else
				{
					result = Singleton<Lobby>.Instance;
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00006D74 File Offset: 0x00004F74
		internal static void Reset()
		{
			NetworkHelper._loggedOnce = false;
		}

		// Token: 0x04000031 RID: 49
		private static bool _loggedOnce;
	}
}

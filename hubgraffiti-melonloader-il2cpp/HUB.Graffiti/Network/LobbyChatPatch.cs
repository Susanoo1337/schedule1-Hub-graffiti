using System;
using Il2CppSteamworks;

namespace HUB.Graffiti.Network
{
	internal static class LobbyChatPatch
	{
		// Harmony binds by parameter name, so this must stay "result" to match Lobby.OnLobbyChatMessage.
		internal static void Postfix(LobbyChatMsg_t result)
		{
			try
			{
				GraffitiSync.OnLobbyChatReceived(result);
			}
			catch (Exception ex)
			{
				DebugLog.Log("Sync", "LobbyChatPatch error: " + ex.Message);
			}
		}
	}
}

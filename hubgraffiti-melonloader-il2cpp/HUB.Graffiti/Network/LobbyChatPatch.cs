using System;
using Il2CppSteamworks;

namespace HUB.Graffiti.Network
{
	// Token: 0x02000010 RID: 16
	internal static class LobbyChatPatch
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00006C68 File Offset: 0x00004E68
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

using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEngine.Diagnostics
{
	// Token: 0x02000359 RID: 857
	public static class PlayerConnection
	{
		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002E0A RID: 11786 RVA: 0x000AD300 File Offset: 0x000AB500
		public static bool connected
		{
			get
			{
				return UnityEngine.Networking.PlayerConnection.PlayerConnection.instance.isConnected;
			}
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00014818 File Offset: 0x00012A18
		public static void SendFile(string remoteFilePath, Il2CppStructArray<byte> data)
		{
		}
	}
}

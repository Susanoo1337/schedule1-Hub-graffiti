using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x02000294 RID: 660
	[StructLayout(2)]
	public struct CheckIfUserIsFriendBroadcast
	{
		// Token: 0x0600323C RID: 12860 RVA: 0x00019F0E File Offset: 0x0001810E
		// Note: this type is marked as 'beforefieldinit'.
		static CheckIfUserIsFriendBroadcast()
		{
			Il2CppClassPointerStore<CheckIfUserIsFriendBroadcast>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "CheckIfUserIsFriendBroadcast");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckIfUserIsFriendBroadcast>.NativeClassPtr);
			CheckIfUserIsFriendBroadcast.NativeFieldInfoPtr_SteamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckIfUserIsFriendBroadcast>.NativeClassPtr, "SteamId");
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x00019F47 File Offset: 0x00018147
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CheckIfUserIsFriendBroadcast>.NativeClassPtr, ref this));
		}

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeFieldInfoPtr_SteamId;

		// Token: 0x0400216C RID: 8556
		[FieldOffset(0)]
		public ulong SteamId;
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x02000295 RID: 661
	[StructLayout(2)]
	public struct FriendCheckResponseBroadcast
	{
		// Token: 0x0600323E RID: 12862 RVA: 0x00120DFC File Offset: 0x0011EFFC
		// Note: this type is marked as 'beforefieldinit'.
		static FriendCheckResponseBroadcast()
		{
			Il2CppClassPointerStore<FriendCheckResponseBroadcast>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "FriendCheckResponseBroadcast");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendCheckResponseBroadcast>.NativeClassPtr);
			FriendCheckResponseBroadcast.NativeFieldInfoPtr_SenderSteamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendCheckResponseBroadcast>.NativeClassPtr, "SenderSteamId");
			FriendCheckResponseBroadcast.NativeFieldInfoPtr_TargetSteamId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendCheckResponseBroadcast>.NativeClassPtr, "TargetSteamId");
			FriendCheckResponseBroadcast.NativeFieldInfoPtr_IsFriend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendCheckResponseBroadcast>.NativeClassPtr, "IsFriend");
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x00019F59 File Offset: 0x00018159
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FriendCheckResponseBroadcast>.NativeClassPtr, ref this));
		}

		// Token: 0x0400216D RID: 8557
		private static readonly IntPtr NativeFieldInfoPtr_SenderSteamId;

		// Token: 0x0400216E RID: 8558
		private static readonly IntPtr NativeFieldInfoPtr_TargetSteamId;

		// Token: 0x0400216F RID: 8559
		private static readonly IntPtr NativeFieldInfoPtr_IsFriend;

		// Token: 0x04002170 RID: 8560
		[FieldOffset(0)]
		public ulong SenderSteamId;

		// Token: 0x04002171 RID: 8561
		[FieldOffset(8)]
		public ulong TargetSteamId;

		// Token: 0x04002172 RID: 8562
		[FieldOffset(16)]
		[MarshalAs(4)]
		public bool IsFriend;
	}
}

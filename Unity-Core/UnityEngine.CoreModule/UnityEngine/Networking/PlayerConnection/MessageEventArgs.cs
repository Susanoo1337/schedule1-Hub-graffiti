using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020001CC RID: 460
	[Serializable]
	public class MessageEventArgs : Object
	{
		// Token: 0x060020E0 RID: 8416 RVA: 0x00085B28 File Offset: 0x00083D28
		// Note: this type is marked as 'beforefieldinit'.
		static MessageEventArgs()
		{
			Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "MessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr);
			MessageEventArgs.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, "playerId");
			MessageEventArgs.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, "data");
			MessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, 100666868);
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00085B94 File Offset: 0x00083D94
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageEventArgs() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x0000F3B3 File Offset: 0x0000D5B3
		public MessageEventArgs(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x00085BD0 File Offset: 0x00083DD0
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x0000F3BC File Offset: 0x0000D5BC
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x00085BF8 File Offset: 0x00083DF8
		// (set) Token: 0x060020E6 RID: 8422 RVA: 0x0000F3D7 File Offset: 0x0000D5D7
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

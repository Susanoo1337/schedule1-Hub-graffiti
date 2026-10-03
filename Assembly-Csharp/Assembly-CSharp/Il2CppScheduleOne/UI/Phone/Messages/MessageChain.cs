using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020007BA RID: 1978
	[Serializable]
	public class MessageChain : Object
	{
		// Token: 0x0600C184 RID: 49540 RVA: 0x003157E8 File Offset: 0x003139E8
		// Note: this type is marked as 'beforefieldinit'.
		static MessageChain()
		{
			Il2CppClassPointerStore<MessageChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageChain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageChain>.NativeClassPtr);
			MessageChain.NativeFieldInfoPtr_Messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, "Messages");
			MessageChain.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, "id");
			MessageChain.NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, 100688476);
			MessageChain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageChain>.NativeClassPtr, 100688477);
		}

		// Token: 0x0600C185 RID: 49541 RVA: 0x00315868 File Offset: 0x00313A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321028, XrefRangeEnd = 321044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MessageChain Combine(MessageChain a, MessageChain b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageChain.NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x0600C186 RID: 49542 RVA: 0x003158C0 File Offset: 0x00313AC0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 321052, RefRangeEnd = 321060, XrefRangeStart = 321044, XrefRangeEnd = 321052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageChain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageChain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C187 RID: 49543 RVA: 0x0005AD04 File Offset: 0x00058F04
		public MessageChain(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x0600C188 RID: 49544 RVA: 0x003158FC File Offset: 0x00313AFC
		// (set) Token: 0x0600C189 RID: 49545 RVA: 0x0005AD0D File Offset: 0x00058F0D
		public unsafe List<string> Messages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_Messages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_Messages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x0600C18A RID: 49546 RVA: 0x0031592C File Offset: 0x00313B2C
		// (set) Token: 0x0600C18B RID: 49547 RVA: 0x0005AD2C File Offset: 0x00058F2C
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageChain.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x0400845B RID: 33883
		private static readonly IntPtr NativeFieldInfoPtr_Messages;

		// Token: 0x0400845C RID: 33884
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x0400845D RID: 33885
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_MessageChain_MessageChain_MessageChain_0;

		// Token: 0x0400845E RID: 33886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003C4 RID: 964
	[Serializable]
	public class DialogueChain : Object
	{
		// Token: 0x06005704 RID: 22276 RVA: 0x001A8AD4 File Offset: 0x001A6CD4
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChain()
		{
			Il2CppClassPointerStore<DialogueChain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueChain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr);
			DialogueChain.NativeFieldInfoPtr_Lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, "Lines");
			DialogueChain.NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, 100674724);
			DialogueChain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr, 100674725);
		}

		// Token: 0x06005705 RID: 22277 RVA: 0x001A8B40 File Offset: 0x001A6D40
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 191551, RefRangeEnd = 191576, XrefRangeStart = 191543, XrefRangeEnd = 191551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetMessageChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChain.NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x001A8B80 File Offset: 0x001A6D80
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x0002917E File Offset: 0x0002737E
		public DialogueChain(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x06005708 RID: 22280 RVA: 0x001A8BBC File Offset: 0x001A6DBC
		// (set) Token: 0x06005709 RID: 22281 RVA: 0x00029187 File Offset: 0x00027387
		public unsafe Il2CppStringArray Lines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChain.NativeFieldInfoPtr_Lines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChain.NativeFieldInfoPtr_Lines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BEA RID: 15338
		private static readonly IntPtr NativeFieldInfoPtr_Lines;

		// Token: 0x04003BEB RID: 15339
		private static readonly IntPtr NativeMethodInfoPtr_GetMessageChain_Public_MessageChain_0;

		// Token: 0x04003BEC RID: 15340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

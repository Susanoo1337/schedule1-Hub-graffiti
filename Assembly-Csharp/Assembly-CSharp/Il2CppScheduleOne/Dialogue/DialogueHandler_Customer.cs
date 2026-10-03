using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003CA RID: 970
	public class DialogueHandler_Customer : DialogueHandler
	{
		// Token: 0x06005791 RID: 22417 RVA: 0x0002956C File Offset: 0x0002776C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler_Customer()
		{
			Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler_Customer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr);
			DialogueHandler_Customer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr, 100674801);
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x001AAAE8 File Offset: 0x001A8CE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190797, RefRangeEnd = 190799, XrefRangeStart = 190797, XrefRangeEnd = 190799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler_Customer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_Customer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_Customer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x000295A5 File Offset: 0x000277A5
		public DialogueHandler_Customer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003C49 RID: 15433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000812 RID: 2066
	public class PromptImageWithText : PromptImage
	{
		// Token: 0x0600C869 RID: 51305 RVA: 0x0032A6B0 File Offset: 0x003288B0
		// Note: this type is marked as 'beforefieldinit'.
		static PromptImageWithText()
		{
			Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "PromptImageWithText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr);
			PromptImageWithText.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr, "Label");
			PromptImageWithText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr, 100689195);
		}

		// Token: 0x0600C86A RID: 51306 RVA: 0x0032A708 File Offset: 0x00328908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImageWithText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptImageWithText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C86B RID: 51307 RVA: 0x0005EC84 File Offset: 0x0005CE84
		public PromptImageWithText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x0600C86C RID: 51308 RVA: 0x0032A744 File Offset: 0x00328944
		// (set) Token: 0x0600C86D RID: 51309 RVA: 0x0005EC8D File Offset: 0x0005CE8D
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImageWithText.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImageWithText.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008896 RID: 34966
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04008897 RID: 34967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

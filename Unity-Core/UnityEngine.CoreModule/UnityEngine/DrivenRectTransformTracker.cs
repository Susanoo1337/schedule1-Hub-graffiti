using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200016D RID: 365
	[StructLayout(2)]
	public struct DrivenRectTransformTracker
	{
		// Token: 0x06001BBB RID: 7099 RVA: 0x000736E8 File Offset: 0x000718E8
		// Note: this type is marked as 'beforefieldinit'.
		static DrivenRectTransformTracker()
		{
			Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DrivenRectTransformTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr);
			DrivenRectTransformTracker.NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, 100666257);
			DrivenRectTransformTracker.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, 100666258);
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00073740 File Offset: 0x00071940
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drivenProperties;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrivenRectTransformTracker.NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x00073798 File Offset: 0x00071998
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrivenRectTransformTracker.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0000D2CD File Offset: 0x0000B4CD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, ref this));
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x000737C0 File Offset: 0x000719C0
		public static bool CanRecordModifications()
		{
			return true;
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0000D2DF File Offset: 0x0000B4DF
		public void Clear(bool revertValues)
		{
			this.Clear();
		}

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
	}
}

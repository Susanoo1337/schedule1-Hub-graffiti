using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x0200042B RID: 1067
	public static class ClothingColorExtensions : Il2CppSystem.Object
	{
		// Token: 0x06005DF8 RID: 24056 RVA: 0x001BF5E0 File Offset: 0x001BD7E0
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingColorExtensions()
		{
			Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingColorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr);
			ClothingColorExtensions.NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100675584);
			ClothingColorExtensions.NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100675585);
			ClothingColorExtensions.NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100675586);
			ClothingColorExtensions.NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100675587);
			ClothingColorExtensions.NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100675588);
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x001BF674 File Offset: 0x001BD874
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 200484, RefRangeEnd = 200492, XrefRangeStart = 200479, XrefRangeEnd = 200484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetActualColor(this EClothingColor color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x001BF6B4 File Offset: 0x001BD8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200492, XrefRangeEnd = 200497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetLabelColor(this EClothingColor color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x001BF6F4 File Offset: 0x001BD8F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200500, RefRangeEnd = 200502, XrefRangeStart = 200497, XrefRangeEnd = 200500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLabel(this EClothingColor color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x001BF72C File Offset: 0x001BD92C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 200530, RefRangeEnd = 200533, XrefRangeStart = 200502, XrefRangeEnd = 200530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EClothingColor GetClothingColor(Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x001BF76C File Offset: 0x001BD96C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200533, RefRangeEnd = 200534, XrefRangeStart = 200533, XrefRangeEnd = 200533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ColorEquals(Color a, Color b, float tolerance = 0.004f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tolerance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x0002C846 File Offset: 0x0002AA46
		public ClothingColorExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004093 RID: 16531
		private static readonly IntPtr NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0;

		// Token: 0x04004094 RID: 16532
		private static readonly IntPtr NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0;

		// Token: 0x04004095 RID: 16533
		private static readonly IntPtr NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0;

		// Token: 0x04004096 RID: 16534
		private static readonly IntPtr NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0;

		// Token: 0x04004097 RID: 16535
		private static readonly IntPtr NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0;
	}
}

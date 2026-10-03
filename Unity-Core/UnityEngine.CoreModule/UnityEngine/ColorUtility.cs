using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F3 RID: 243
	public class ColorUtility : Object
	{
		// Token: 0x06001372 RID: 4978 RVA: 0x00056A64 File Offset: 0x00054C64
		// Note: this type is marked as 'beforefieldinit'.
		static ColorUtility()
		{
			Il2CppClassPointerStore<ColorUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ColorUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr);
			ColorUtility.NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100665250);
			ColorUtility.NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100665251);
			ColorUtility.NativeMethodInfoPtr_ToHtmlStringRGB_Public_Static_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100665252);
			ColorUtility.NativeMethodInfoPtr_ToHtmlStringRGBA_Public_Static_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100665253);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00056AE4 File Offset: 0x00054CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242352, XrefRangeEnd = 1242354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoTryParseHtmlColor(string htmlString, out Color32 color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(htmlString);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtility.NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00056B34 File Offset: 0x00054D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1242356, RefRangeEnd = 1242358, XrefRangeStart = 1242354, XrefRangeEnd = 1242356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParseHtmlString(string htmlString, out Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(htmlString);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtility.NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00056B84 File Offset: 0x00054D84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1242391, RefRangeEnd = 1242393, XrefRangeStart = 1242358, XrefRangeEnd = 1242391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToHtmlStringRGB(Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtility.NativeMethodInfoPtr_ToHtmlStringRGB_Public_Static_String_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00056BBC File Offset: 0x00054DBC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1242435, RefRangeEnd = 1242449, XrefRangeStart = 1242393, XrefRangeEnd = 1242435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToHtmlStringRGBA(Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUtility.NativeMethodInfoPtr_ToHtmlStringRGBA_Public_Static_String_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0000A7AD File Offset: 0x000089AD
		public ColorUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_ToHtmlStringRGB_Public_Static_String_Color_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_ToHtmlStringRGBA_Public_Static_String_Color_0;
	}
}

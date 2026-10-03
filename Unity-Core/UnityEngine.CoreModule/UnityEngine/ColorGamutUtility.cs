using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200009E RID: 158
	public class ColorGamutUtility : Object
	{
		// Token: 0x0600099E RID: 2462 RVA: 0x00035C80 File Offset: 0x00033E80
		// Note: this type is marked as 'beforefieldinit'.
		static ColorGamutUtility()
		{
			Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ColorGamutUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr);
			ColorGamutUtility.NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664276);
			ColorGamutUtility.NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664277);
			ColorGamutUtility.NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGamutUtility>.NativeClassPtr, 100664278);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00035CEC File Offset: 0x00033EEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1234486, RefRangeEnd = 1234489, XrefRangeStart = 1234484, XrefRangeEnd = 1234486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ColorPrimaries GetColorPrimaries(ColorGamut gamut)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gamut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGamutUtility.NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00035D2C File Offset: 0x00033F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234491, RefRangeEnd = 1234492, XrefRangeStart = 1234489, XrefRangeEnd = 1234491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WhitePoint GetWhitePoint(ColorGamut gamut)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gamut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGamutUtility.NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00035D6C File Offset: 0x00033F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1234494, RefRangeEnd = 1234495, XrefRangeStart = 1234492, XrefRangeEnd = 1234494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TransferFunction GetTransferFunction(ColorGamut gamut)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gamut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorGamutUtility.NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000061E6 File Offset: 0x000043E6
		public ColorGamutUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_GetColorPrimaries_Public_Static_ColorPrimaries_ColorGamut_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_GetWhitePoint_Public_Static_WhitePoint_ColorGamut_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_GetTransferFunction_Public_Static_TransferFunction_ColorGamut_0;
	}
}

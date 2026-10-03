using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FB RID: 251
	[StructLayout(2)]
	public struct Mathf
	{
		// Token: 0x0600148A RID: 5258 RVA: 0x0005B6C0 File Offset: 0x000598C0
		// Note: this type is marked as 'beforefieldinit'.
		static Mathf()
		{
			Il2CppClassPointerStore<Mathf>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Mathf");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mathf>.NativeClassPtr);
			Mathf.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mathf>.NativeClassPtr, "Epsilon");
			Mathf.NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665426);
			Mathf.NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665427);
			Mathf.NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665428);
			Mathf.NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665429);
			Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665430);
			Mathf.NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665431);
			Mathf.NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665432);
			Mathf.NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665433);
			Mathf.NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665434);
			Mathf.NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665435);
			Mathf.NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665436);
			Mathf.NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665437);
			Mathf.NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665438);
			Mathf.NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665439);
			Mathf.NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665440);
			Mathf.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665441);
			Mathf.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665442);
			Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665443);
			Mathf.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665444);
			Mathf.NativeMethodInfoPtr_Min_Public_Static_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665445);
			Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665446);
			Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665447);
			Mathf.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665448);
			Mathf.NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665449);
			Mathf.NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665450);
			Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665451);
			Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665452);
			Mathf.NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665453);
			Mathf.NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665454);
			Mathf.NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665455);
			Mathf.NativeMethodInfoPtr_Round_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665456);
			Mathf.NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665457);
			Mathf.NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665458);
			Mathf.NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665459);
			Mathf.NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665460);
			Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665461);
			Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665462);
			Mathf.NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665463);
			Mathf.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665464);
			Mathf.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665465);
			Mathf.NativeMethodInfoPtr_LerpAngle_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665466);
			Mathf.NativeMethodInfoPtr_MoveTowards_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665467);
			Mathf.NativeMethodInfoPtr_MoveTowardsAngle_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665468);
			Mathf.NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665469);
			Mathf.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665470);
			Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665471);
			Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665472);
			Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665473);
			Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665474);
			Mathf.NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665475);
			Mathf.NativeMethodInfoPtr_PingPong_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665476);
			Mathf.NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665477);
			Mathf.NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665478);
			Mathf.NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665479);
			Mathf.NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665480);
			Mathf.NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665481);
			Mathf.NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665482);
			Mathf.NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665483);
			Mathf.NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665484);
			Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100665486);
			Mathf.ClosestPowerOfTwoDelegateField = IL2CPP.ResolveICall<Mathf.ClosestPowerOfTwoDelegate>("UnityEngine.Mathf::ClosestPowerOfTwo");
			Mathf.HalfToFloatDelegateField = IL2CPP.ResolveICall<Mathf.HalfToFloatDelegate>("UnityEngine.Mathf::HalfToFloat");
			Mathf.PerlinNoise1DDelegateField = IL2CPP.ResolveICall<Mathf.PerlinNoise1DDelegate>("UnityEngine.Mathf::PerlinNoise1D");
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0005BBE4 File Offset: 0x00059DE4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1245008, RefRangeEnd = 1245024, XrefRangeStart = 1245006, XrefRangeEnd = 1245008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPowerOfTwo(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x0005BC24 File Offset: 0x00059E24
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 1245026, RefRangeEnd = 1245114, XrefRangeStart = 1245024, XrefRangeEnd = 1245026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NextPowerOfTwo(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0005BC64 File Offset: 0x00059E64
		[CallerCount(64)]
		[CachedScanResults(RefRangeStart = 1245116, RefRangeEnd = 1245180, XrefRangeStart = 1245114, XrefRangeEnd = 1245116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GammaToLinearSpace(float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0005BCA4 File Offset: 0x00059EA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1245182, RefRangeEnd = 1245188, XrefRangeStart = 1245180, XrefRangeEnd = 1245182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float LinearToGammaSpace(float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0005BCE4 File Offset: 0x00059EE4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1245190, RefRangeEnd = 1245199, XrefRangeStart = 1245188, XrefRangeEnd = 1245190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color CorrelatedColorTemperatureToRGB(float kelvin)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kelvin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0005BD24 File Offset: 0x00059F24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245201, RefRangeEnd = 1245203, XrefRangeStart = 1245199, XrefRangeEnd = 1245201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort FloatToHalf(float val)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0005BD64 File Offset: 0x00059F64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245205, RefRangeEnd = 1245206, XrefRangeStart = 1245203, XrefRangeEnd = 1245205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PerlinNoise(float x, float y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0005BDB0 File Offset: 0x00059FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245206, XrefRangeEnd = 1245210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Sin(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0005BDF0 File Offset: 0x00059FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245210, XrefRangeEnd = 1245214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Cos(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0005BE30 File Offset: 0x0005A030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245214, XrefRangeEnd = 1245218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Tan(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0005BE70 File Offset: 0x0005A070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245218, XrefRangeEnd = 1245222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Asin(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0005BEB0 File Offset: 0x0005A0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245222, XrefRangeEnd = 1245226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Acos(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0005BEF0 File Offset: 0x0005A0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245226, XrefRangeEnd = 1245230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Atan(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0005BF30 File Offset: 0x0005A130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245230, XrefRangeEnd = 1245234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Atan2(float y, float x)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref y;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0005BF7C File Offset: 0x0005A17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245234, XrefRangeEnd = 1245237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Sqrt(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0005BFBC File Offset: 0x0005A1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245237, XrefRangeEnd = 1245240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Abs(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0005BFFC File Offset: 0x0005A1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245240, XrefRangeEnd = 1245243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Abs(int value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0005C03C File Offset: 0x0005A23C
		[CallerCount(0)]
		public unsafe static float Min(float a, float b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0005C088 File Offset: 0x0005A288
		[CallerCount(0)]
		public unsafe static int Min(int a, int b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0005C0D4 File Offset: 0x0005A2D4
		[CallerCount(0)]
		public unsafe static int Min([Optional] Il2CppStructArray<int> values)
		{
			if (values == null)
			{
				values = new Il2CppStructArray<int>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Min_Public_Static_Int32_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0005C124 File Offset: 0x0005A324
		[CallerCount(0)]
		public unsafe static float Max(float a, float b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0005C170 File Offset: 0x0005A370
		[CallerCount(0)]
		public unsafe static float Max([Optional] Il2CppStructArray<float> values)
		{
			if (values == null)
			{
				values = new Il2CppStructArray<float>(0L);
			}
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0005C1C0 File Offset: 0x0005A3C0
		[CallerCount(0)]
		public unsafe static int Max(int a, int b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x0005C20C File Offset: 0x0005A40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245243, XrefRangeEnd = 1245247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Pow(float f, float p)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x0005C258 File Offset: 0x0005A458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245247, XrefRangeEnd = 1245251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Exp(float power)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref power;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0005C298 File Offset: 0x0005A498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245251, XrefRangeEnd = 1245255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Log(float f, float p)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x0005C2E4 File Offset: 0x0005A4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245255, XrefRangeEnd = 1245259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Log(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0005C324 File Offset: 0x0005A524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245259, XrefRangeEnd = 1245263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Log10(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0005C364 File Offset: 0x0005A564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245263, XrefRangeEnd = 1245267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Ceil(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0005C3A4 File Offset: 0x0005A5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245267, XrefRangeEnd = 1245271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Floor(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0005C3E4 File Offset: 0x0005A5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245271, XrefRangeEnd = 1245275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Round(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Round_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0005C424 File Offset: 0x0005A624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245275, XrefRangeEnd = 1245279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CeilToInt(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0005C464 File Offset: 0x0005A664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245279, XrefRangeEnd = 1245283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FloorToInt(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0005C4A4 File Offset: 0x0005A6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245283, XrefRangeEnd = 1245287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RoundToInt(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0005C4E4 File Offset: 0x0005A6E4
		[CallerCount(0)]
		public unsafe static float Sign(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0005C524 File Offset: 0x0005A724
		[CallerCount(0)]
		public unsafe static float Clamp(float value, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0005C580 File Offset: 0x0005A780
		[CallerCount(0)]
		public unsafe static int Clamp(int value, int min, int max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0005C5DC File Offset: 0x0005A7DC
		[CallerCount(0)]
		public unsafe static float Clamp01(float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0005C61C File Offset: 0x0005A81C
		[CallerCount(0)]
		public unsafe static float Lerp(float a, float b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0005C678 File Offset: 0x0005A878
		[CallerCount(0)]
		public unsafe static float LerpUnclamped(float a, float b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0005C6D4 File Offset: 0x0005A8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245290, RefRangeEnd = 1245291, XrefRangeStart = 1245287, XrefRangeEnd = 1245290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float LerpAngle(float a, float b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_LerpAngle_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0005C730 File Offset: 0x0005A930
		[CallerCount(0)]
		public unsafe static float MoveTowards(float current, float target, float maxDelta)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_MoveTowards_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0005C78C File Offset: 0x0005A98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245291, XrefRangeEnd = 1245295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float MoveTowardsAngle(float current, float target, float maxDelta)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_MoveTowardsAngle_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0005C7E8 File Offset: 0x0005A9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245295, XrefRangeEnd = 1245296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothStep(float from, float to, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0005C844 File Offset: 0x0005AA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245296, XrefRangeEnd = 1245298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Approximately(float a, float b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0005C890 File Offset: 0x0005AA90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1245300, RefRangeEnd = 1245303, XrefRangeStart = 1245298, XrefRangeEnd = 1245300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0005C8F8 File Offset: 0x0005AAF8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1245305, RefRangeEnd = 1245328, XrefRangeStart = 1245303, XrefRangeEnd = 1245305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0005C97C File Offset: 0x0005AB7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245332, RefRangeEnd = 1245334, XrefRangeStart = 1245328, XrefRangeEnd = 1245332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0005C9E4 File Offset: 0x0005ABE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245334, XrefRangeEnd = 1245337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0005CA68 File Offset: 0x0005AC68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245338, RefRangeEnd = 1245339, XrefRangeStart = 1245337, XrefRangeEnd = 1245338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Repeat(float t, float length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref t;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0005CAB4 File Offset: 0x0005ACB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245341, RefRangeEnd = 1245342, XrefRangeStart = 1245339, XrefRangeEnd = 1245341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PingPong(float t, float length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref t;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_PingPong_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0005CB00 File Offset: 0x0005AD00
		[CallerCount(0)]
		public unsafe static float InverseLerp(float a, float b, float value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0005CB5C File Offset: 0x0005AD5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245344, RefRangeEnd = 1245345, XrefRangeStart = 1245342, XrefRangeEnd = 1245344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float DeltaAngle(float current, float target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0005CBA8 File Offset: 0x0005ADA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245345, RefRangeEnd = 1245347, XrefRangeStart = 1245345, XrefRangeEnd = 1245345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ClampToFloat(double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0005CBE8 File Offset: 0x0005ADE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245347, RefRangeEnd = 1245349, XrefRangeStart = 1245347, XrefRangeEnd = 1245347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ClampToInt(long value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0005CC28 File Offset: 0x0005AE28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245349, RefRangeEnd = 1245351, XrefRangeStart = 1245349, XrefRangeEnd = 1245349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ClampToUInt(long value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0005CC68 File Offset: 0x0005AE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245351, XrefRangeEnd = 1245357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNumberOfDecimalsForMinimumDifference(double minDifference)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minDifference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0005CCA8 File Offset: 0x0005AEA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245369, RefRangeEnd = 1245371, XrefRangeStart = 1245357, XrefRangeEnd = 1245369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref valueToRound;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDifference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0005CCF4 File Offset: 0x0005AEF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245383, RefRangeEnd = 1245384, XrefRangeStart = 1245371, XrefRangeEnd = 1245383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double DiscardLeastSignificantDecimal(double v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0005CD34 File Offset: 0x0005AF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245384, XrefRangeEnd = 1245386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref kelvin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0000AB0F File Offset: 0x00008D0F
		public static int Min(params int[] values)
		{
			return Mathf.Min(new Il2CppStructArray<int>(values));
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0000AB1C File Offset: 0x00008D1C
		public static float Max(params float[] values)
		{
			return Mathf.Max(new Il2CppStructArray<float>(values));
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0000AB29 File Offset: 0x00008D29
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mathf>.NativeClassPtr, ref this));
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x0005CD74 File Offset: 0x0005AF74
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x0000AB3B File Offset: 0x00008D3B
		public unsafe static float Epsilon
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Mathf.NativeFieldInfoPtr_Epsilon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Mathf.NativeFieldInfoPtr_Epsilon, (void*)(&value));
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0000AB49 File Offset: 0x00008D49
		public static int ClosestPowerOfTwo(int value)
		{
			return Mathf.ClosestPowerOfTwoDelegateField(value);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0000AB56 File Offset: 0x00008D56
		public static float HalfToFloat(ushort val)
		{
			return Mathf.HalfToFloatDelegateField(val);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0000AB63 File Offset: 0x00008D63
		public static float PerlinNoise1D(float x)
		{
			return Mathf.PerlinNoise1DDelegateField(x);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0005CD90 File Offset: 0x0005AF90
		public static float Min(Il2CppStructArray<float> values)
		{
			int num = values.Length;
			bool flag = num == 0;
			float result;
			if (flag)
			{
				result = 0f;
			}
			else
			{
				float num2 = values[0];
				for (int i = 1; i < num; i++)
				{
					bool flag2 = values[i] < num2;
					if (flag2)
					{
						num2 = values[i];
					}
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0000AB70 File Offset: 0x00008D70
		public static float Min(params float[] values)
		{
			return Mathf.Min(new Il2CppStructArray<float>(values));
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0000AB7D File Offset: 0x00008D7D
		public static int Max(Il2CppStructArray<int> values)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0000AB8A File Offset: 0x00008D8A
		public static int Max(params int[] values)
		{
			return Mathf.Max(new Il2CppStructArray<int>(values));
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0005CDF8 File Offset: 0x0005AFF8
		public static float Gamma(float value, float absmax, float gamma)
		{
			bool flag = value < 0f;
			float num = Mathf.Abs(value);
			bool flag2 = num > absmax;
			float result;
			if (flag2)
			{
				result = (flag ? (-num) : num);
			}
			else
			{
				float num2 = Mathf.Pow(num / absmax, gamma) * absmax;
				result = (flag ? (-num2) : num2);
			}
			return result;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0005CE44 File Offset: 0x0005B044
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0005CE68 File Offset: 0x0005B068
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0005CE8C File Offset: 0x0005B08C
		public static bool LineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			float num = p2.x - p1.x;
			float num2 = p2.y - p1.y;
			float num3 = p4.x - p3.x;
			float num4 = p4.y - p3.y;
			float num5 = num * num4 - num2 * num3;
			bool flag = num5 == 0f;
			bool result2;
			if (flag)
			{
				result2 = false;
			}
			else
			{
				float num6 = p3.x - p1.x;
				float num7 = p3.y - p1.y;
				float num8 = (num6 * num4 - num7 * num3) / num5;
				result.x = p1.x + num8 * num;
				result.y = p1.y + num8 * num2;
				result2 = true;
			}
			return result2;
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0005CF48 File Offset: 0x0005B148
		public static bool LineSegmentIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			float num = p2.x - p1.x;
			float num2 = p2.y - p1.y;
			float num3 = p4.x - p3.x;
			float num4 = p4.y - p3.y;
			float num5 = num * num4 - num2 * num3;
			bool flag = num5 == 0f;
			bool result2;
			if (flag)
			{
				result2 = false;
			}
			else
			{
				float num6 = p3.x - p1.x;
				float num7 = p3.y - p1.y;
				float num8 = (num6 * num4 - num7 * num3) / num5;
				bool flag2 = num8 < 0f || num8 > 1f;
				if (flag2)
				{
					result2 = false;
				}
				else
				{
					float num9 = (num6 * num2 - num7 * num) / num5;
					bool flag3 = num9 < 0f || num9 > 1f;
					if (flag3)
					{
						result2 = false;
					}
					else
					{
						result.x = p1.x + num8 * num;
						result.y = p1.y + num8 * num2;
						result2 = true;
					}
				}
			}
			return result2;
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0000AB97 File Offset: 0x00008D97
		public static long RandomToLong(Random r)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0005D058 File Offset: 0x0005B258
		public static float RoundToMultipleOf(float value, float roundingValue)
		{
			bool flag = roundingValue == 0f;
			float result;
			if (flag)
			{
				result = value;
			}
			else
			{
				result = Mathf.Round(value / roundingValue) * roundingValue;
			}
			return result;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0005D084 File Offset: 0x0005B284
		public static float GetClosestPowerOfTen(float positiveNumber)
		{
			bool flag = positiveNumber <= 0f;
			float result;
			if (flag)
			{
				result = 1f;
			}
			else
			{
				result = Mathf.Pow(10f, (float)Mathf.RoundToInt(Mathf.Log10(positiveNumber)));
			}
			return result;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0005D0C4 File Offset: 0x0005B2C4
		public static int GetNumberOfDecimalsForMinimumDifference(float minDifference)
		{
			return Mathf.Clamp(-Mathf.FloorToInt(Mathf.Log10(Mathf.Abs(minDifference))), 0, 15);
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0005D0F0 File Offset: 0x0005B2F0
		public static float RoundBasedOnMinimumDifference(float valueToRound, float minDifference)
		{
			bool flag = minDifference == 0f;
			float result;
			if (flag)
			{
				result = Mathf.DiscardLeastSignificantDecimal(valueToRound);
			}
			else
			{
				result = (float)Math.Round((double)valueToRound, Mathf.GetNumberOfDecimalsForMinimumDifference(minDifference), MidpointRounding.AwayFromZero);
			}
			return result;
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x0005D128 File Offset: 0x0005B328
		public static float DiscardLeastSignificantDecimal(float v)
		{
			int digits = Mathf.Clamp((int)(5f - Mathf.Log10(Mathf.Abs(v))), 0, 15);
			return (float)Math.Round((double)v, digits, MidpointRounding.AwayFromZero);
		}

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeFieldInfoPtr_Epsilon;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr_IsPowerOfTwo_Public_Static_Boolean_Int32_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr_LinearToGammaSpace_Public_Static_Single_Single_0;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Public_Static_Color_Single_0;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeMethodInfoPtr_FloatToHalf_Public_Static_UInt16_Single_0;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeMethodInfoPtr_PerlinNoise_Public_Static_Single_Single_Single_0;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Il2CppStructArray_1_Single_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0;

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeMethodInfoPtr_Exp_Public_Static_Single_Single_0;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Single_Single_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_Log10_Public_Static_Single_Single_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Single_Single_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeMethodInfoPtr_LerpAngle_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeMethodInfoPtr_MoveTowards_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeMethodInfoPtr_MoveTowardsAngle_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_0;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr_PingPong_Public_Static_Single_Single_Single_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_ClampToFloat_Internal_Static_Single_Double_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_ClampToInt_Internal_Static_Int32_Int64_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_ClampToUInt_Internal_Static_UInt32_Int64_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfDecimalsForMinimumDifference_Internal_Static_Int32_Double_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr_RoundBasedOnMinimumDifference_Internal_Static_Double_Double_Double_0;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr_DiscardLeastSignificantDecimal_Internal_Static_Double_Double_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr_CorrelatedColorTemperatureToRGB_Injected_Private_Static_Void_Single_byref_Color_0;

		// Token: 0x04001250 RID: 4688
		public const float PI = 3.1415927f;

		// Token: 0x04001251 RID: 4689
		public const float Infinity = float.PositiveInfinity;

		// Token: 0x04001252 RID: 4690
		public const float NegativeInfinity = float.NegativeInfinity;

		// Token: 0x04001253 RID: 4691
		public const float Deg2Rad = 0.017453292f;

		// Token: 0x04001254 RID: 4692
		public const float Rad2Deg = 57.29578f;

		// Token: 0x04001255 RID: 4693
		public const int kMaxDecimals = 15;

		// Token: 0x04001256 RID: 4694
		private static readonly Mathf.ClosestPowerOfTwoDelegate ClosestPowerOfTwoDelegateField;

		// Token: 0x04001257 RID: 4695
		private static readonly Mathf.HalfToFloatDelegate HalfToFloatDelegateField;

		// Token: 0x04001258 RID: 4696
		private static readonly Mathf.PerlinNoise1DDelegate PerlinNoise1DDelegateField;

		// Token: 0x0200087C RID: 2172
		// (Invoke) Token: 0x0600398B RID: 14731
		private delegate int ClosestPowerOfTwoDelegate(int value);

		// Token: 0x0200087D RID: 2173
		// (Invoke) Token: 0x0600398D RID: 14733
		private delegate float HalfToFloatDelegate(ushort val);

		// Token: 0x0200087E RID: 2174
		// (Invoke) Token: 0x0600398F RID: 14735
		private delegate float PerlinNoise1DDelegate(float x);
	}
}

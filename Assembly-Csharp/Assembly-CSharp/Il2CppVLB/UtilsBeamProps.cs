using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000077 RID: 119
	public static class UtilsBeamProps : Il2CppSystem.Object
	{
		// Token: 0x060008C8 RID: 2248 RVA: 0x000979D0 File Offset: 0x00095BD0
		// Note: this type is marked as 'beforefieldinit'.
		static UtilsBeamProps()
		{
			Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "UtilsBeamProps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr);
			UtilsBeamProps.NativeMethodInfoPtr_CanChangeDuringPlaytime_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664421);
			UtilsBeamProps.NativeMethodInfoPtr_GetInternalLocalRotation_Public_Static_Quaternion_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664422);
			UtilsBeamProps.NativeMethodInfoPtr_GetThickness_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664423);
			UtilsBeamProps.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664424);
			UtilsBeamProps.NativeMethodInfoPtr_GetColorMode_Public_Static_ColorMode_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664425);
			UtilsBeamProps.NativeMethodInfoPtr_GetColorFlat_Public_Static_Color_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664426);
			UtilsBeamProps.NativeMethodInfoPtr_GetColorGradient_Public_Static_Gradient_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664427);
			UtilsBeamProps.NativeMethodInfoPtr_GetConeAngle_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664428);
			UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusStart_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664429);
			UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664430);
			UtilsBeamProps.NativeMethodInfoPtr_GetSortingLayerID_Public_Static_Int32_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664431);
			UtilsBeamProps.NativeMethodInfoPtr_GetSortingOrder_Public_Static_Int32_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664432);
			UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnabled_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664433);
			UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664434);
			UtilsBeamProps.NativeMethodInfoPtr_GetDimensions_Public_Static_Dimensions_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664435);
			UtilsBeamProps.NativeMethodInfoPtr_GetGeomSides_Public_Static_Int32_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UtilsBeamProps>.NativeClassPtr, 100664436);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00097B40 File Offset: 0x00095D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74227, XrefRangeEnd = 74233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanChangeDuringPlaytime(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_CanChangeDuringPlaytime_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00097B84 File Offset: 0x00095D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74233, XrefRangeEnd = 74249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion GetInternalLocalRotation(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetInternalLocalRotation_Public_Static_Quaternion_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00097BC8 File Offset: 0x00095DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74261, RefRangeEnd = 74262, XrefRangeStart = 74249, XrefRangeEnd = 74261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetThickness(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetThickness_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00097C0C File Offset: 0x00095E0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 74274, RefRangeEnd = 74277, XrefRangeStart = 74262, XrefRangeEnd = 74274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFallOffEnd(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00097C50 File Offset: 0x00095E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74277, XrefRangeEnd = 74289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ColorMode GetColorMode(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetColorMode_Public_Static_ColorMode_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00097C94 File Offset: 0x00095E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74289, XrefRangeEnd = 74302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColorFlat(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetColorFlat_Public_Static_Color_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00097CD8 File Offset: 0x00095ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74302, XrefRangeEnd = 74314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Gradient GetColorGradient(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetColorGradient_Public_Static_Gradient_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr3) : null;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00097D1C File Offset: 0x00095F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74314, XrefRangeEnd = 74326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetConeAngle(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetConeAngle_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00097D60 File Offset: 0x00095F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74338, RefRangeEnd = 74340, XrefRangeStart = 74326, XrefRangeEnd = 74338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetConeRadiusStart(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusStart_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00097DA4 File Offset: 0x00095FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74340, XrefRangeEnd = 74352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetConeRadiusEnd(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetConeRadiusEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00097DE8 File Offset: 0x00095FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74352, XrefRangeEnd = 74364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSortingLayerID(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetSortingLayerID_Public_Static_Int32_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00097E2C File Offset: 0x0009602C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74364, XrefRangeEnd = 74376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSortingOrder(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetSortingOrder_Public_Static_Int32_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00097E70 File Offset: 0x00096070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74376, XrefRangeEnd = 74382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFadeOutEnabled(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnabled_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00097EB4 File Offset: 0x000960B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74382, XrefRangeEnd = 74388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFadeOutEnd(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetFadeOutEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00097EF8 File Offset: 0x000960F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 74400, RefRangeEnd = 74403, XrefRangeStart = 74388, XrefRangeEnd = 74400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dimensions GetDimensions(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetDimensions_Public_Static_Dimensions_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00097F3C File Offset: 0x0009613C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74403, XrefRangeEnd = 74410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGeomSides(VolumetricLightBeamAbstractBase self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UtilsBeamProps.NativeMethodInfoPtr_GetGeomSides_Public_Static_Int32_VolumetricLightBeamAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0000618D File Offset: 0x0000438D
		public UtilsBeamProps(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_CanChangeDuringPlaytime_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalLocalRotation_Public_Static_Quaternion_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr_GetThickness_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr_GetFallOffEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_GetColorMode_Public_Static_ColorMode_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_GetColorFlat_Public_Static_Color_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_GetColorGradient_Public_Static_Gradient_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_GetConeAngle_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr_GetConeRadiusStart_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_GetConeRadiusEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingLayerID_Public_Static_Int32_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingOrder_Public_Static_Int32_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_GetFadeOutEnabled_Public_Static_Boolean_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_GetFadeOutEnd_Public_Static_Single_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_GetDimensions_Public_Static_Dimensions_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_GetGeomSides_Public_Static_Int32_VolumetricLightBeamAbstractBase_0;
	}
}

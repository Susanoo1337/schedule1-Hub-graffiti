using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200003C RID: 60
	public static class BatchingHelper : Il2CppSystem.Object
	{
		// Token: 0x060003E4 RID: 996 RVA: 0x00086820 File Offset: 0x00084A20
		// Note: this type is marked as 'beforefieldinit'.
		static BatchingHelper()
		{
			Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "BatchingHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr);
			BatchingHelper.NativeMethodInfoPtr_IsGpuInstancingEnabled_Public_Static_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100663673);
			BatchingHelper.NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100663674);
			BatchingHelper.NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100663675);
			BatchingHelper.NativeMethodInfoPtr_DoesRenderingModePreventBatching_Private_Static_Boolean_ShaderMode_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100663676);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_VolumetricLightBeamSD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100663677);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100663678);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_VolumetricLightBeamHD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100663679);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100663680);
			BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamAbstractBase_VolumetricLightBeamAbstractBase_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100663681);
			BatchingHelper.NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchingHelper>.NativeClassPtr, 100663682);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00086918 File Offset: 0x00084B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68654, XrefRangeEnd = 68656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGpuInstancingEnabled(Material material)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_IsGpuInstancingEnabled_Public_Static_Boolean_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0008695C File Offset: 0x00084B5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68658, RefRangeEnd = 68660, XrefRangeStart = 68656, XrefRangeEnd = 68658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableGpuInstancing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x000869A0 File Offset: 0x00084BA0
		public unsafe static bool forceEnableDepthBlend
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 68662, RefRangeEnd = 68666, XrefRangeStart = 68660, XrefRangeEnd = 68662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000869D0 File Offset: 0x00084BD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68671, RefRangeEnd = 68673, XrefRangeStart = 68666, XrefRangeEnd = 68671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoesRenderingModePreventBatching(ShaderMode shaderMode, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shaderMode;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_DoesRenderingModePreventBatching_Private_Static_Boolean_ShaderMode_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00086A30 File Offset: 0x00084C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68747, RefRangeEnd = 68748, XrefRangeStart = 68673, XrefRangeEnd = 68747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamSD beamA, VolumetricLightBeamSD beamB, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamB);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_VolumetricLightBeamSD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00086AA4 File Offset: 0x00084CA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68768, RefRangeEnd = 68770, XrefRangeStart = 68748, XrefRangeEnd = 68768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamSD beam, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00086B08 File Offset: 0x00084D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68826, RefRangeEnd = 68827, XrefRangeStart = 68770, XrefRangeEnd = 68826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamHD beamA, VolumetricLightBeamHD beamB, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamB);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_VolumetricLightBeamHD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00086B7C File Offset: 0x00084D7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68848, RefRangeEnd = 68850, XrefRangeStart = 68827, XrefRangeEnd = 68848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamHD beam, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beam);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00086BE0 File Offset: 0x00084DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68850, XrefRangeEnd = 68856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanBeBatched(VolumetricLightBeamAbstractBase beamA, VolumetricLightBeamAbstractBase beamB, ref string reasons)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamA);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamB);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(reasons);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamAbstractBase_VolumetricLightBeamAbstractBase_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reasons = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00086C54 File Offset: 0x00084E54
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 68867, RefRangeEnd = 68882, XrefRangeStart = 68856, XrefRangeEnd = 68867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendErrorMessage(ref string message, string toAppend)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(toAppend);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BatchingHelper.NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00004378 File Offset: 0x00002578
		public BatchingHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_IsGpuInstancingEnabled_Public_Static_Boolean_Material_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProperties_Public_Static_Void_Material_Boolean_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_get_forceEnableDepthBlend_Public_Static_get_Boolean_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_DoesRenderingModePreventBatching_Private_Static_Boolean_ShaderMode_byref_String_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_VolumetricLightBeamSD_byref_String_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamSD_byref_String_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_VolumetricLightBeamHD_byref_String_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamHD_byref_String_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBatched_Public_Static_Boolean_VolumetricLightBeamAbstractBase_VolumetricLightBeamAbstractBase_byref_String_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_AppendErrorMessage_Private_Static_Void_byref_String_String_0;
	}
}

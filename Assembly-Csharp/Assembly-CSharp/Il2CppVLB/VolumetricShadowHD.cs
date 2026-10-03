using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200005F RID: 95
	public class VolumetricShadowHD : MonoBehaviour
	{
		// Token: 0x06000600 RID: 1536 RVA: 0x0008DD64 File Offset: 0x0008BF64
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricShadowHD()
		{
			Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricShadowHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr);
			VolumetricShadowHD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "ClassName");
			VolumetricShadowHD.NativeFieldInfoPtr_m_Strength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_Strength");
			VolumetricShadowHD.NativeFieldInfoPtr_m_UpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_UpdateRate");
			VolumetricShadowHD.NativeFieldInfoPtr_m_WaitXFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_WaitXFrames");
			VolumetricShadowHD.NativeFieldInfoPtr_m_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_LayerMask");
			VolumetricShadowHD.NativeFieldInfoPtr_m_UseOcclusionCulling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_UseOcclusionCulling");
			VolumetricShadowHD.NativeFieldInfoPtr_m_DepthMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_DepthMapResolution");
			VolumetricShadowHD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_Master");
			VolumetricShadowHD.NativeFieldInfoPtr_m_TransformPacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_TransformPacked");
			VolumetricShadowHD.NativeFieldInfoPtr_m_LastFrameRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_LastFrameRendered");
			VolumetricShadowHD.NativeFieldInfoPtr_m_DepthCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_DepthCamera");
			VolumetricShadowHD.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "m_NeedToUpdateOcclusionNextFrame");
			VolumetricShadowHD.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "_INTERNAL_ApplyRandomFrameOffset");
			VolumetricShadowHD.NativeMethodInfoPtr_get_strength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663969);
			VolumetricShadowHD.NativeMethodInfoPtr_set_strength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663970);
			VolumetricShadowHD.NativeMethodInfoPtr_get_updateRate_Public_get_ShadowUpdateRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663971);
			VolumetricShadowHD.NativeMethodInfoPtr_set_updateRate_Public_set_Void_ShadowUpdateRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663972);
			VolumetricShadowHD.NativeMethodInfoPtr_get_waitXFrames_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663973);
			VolumetricShadowHD.NativeMethodInfoPtr_set_waitXFrames_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663974);
			VolumetricShadowHD.NativeMethodInfoPtr_get_layerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663975);
			VolumetricShadowHD.NativeMethodInfoPtr_set_layerMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663976);
			VolumetricShadowHD.NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663977);
			VolumetricShadowHD.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663978);
			VolumetricShadowHD.NativeMethodInfoPtr_get_depthMapResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663979);
			VolumetricShadowHD.NativeMethodInfoPtr_set_depthMapResolution_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663980);
			VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663981);
			VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraProperties_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663982);
			VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusion_Private_Void_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663983);
			VolumetricShadowHD.NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricShadowHD_BeamGeometryHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663984);
			VolumetricShadowHD.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663985);
			VolumetricShadowHD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663986);
			VolumetricShadowHD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663987);
			VolumetricShadowHD.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663988);
			VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663989);
			VolumetricShadowHD.NativeMethodInfoPtr_OnBeamEnabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663990);
			VolumetricShadowHD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Public_Void_Camera_BeamGeometryHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663991);
			VolumetricShadowHD.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663992);
			VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663993);
			VolumetricShadowHD.NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663994);
			VolumetricShadowHD.NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663995);
			VolumetricShadowHD.NativeMethodInfoPtr_OnValidateProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663996);
			VolumetricShadowHD.NativeMethodInfoPtr_SetDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663997);
			VolumetricShadowHD.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663998);
			VolumetricShadowHD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, 100663999);
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0008E104 File Offset: 0x0008C304
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x0008E140 File Offset: 0x0008C340
		public unsafe float strength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_strength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70642, XrefRangeEnd = 70643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_strength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0008E180 File Offset: 0x0008C380
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x0008E1BC File Offset: 0x0008C3BC
		public unsafe ShadowUpdateRate updateRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_updateRate_Public_get_ShadowUpdateRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_updateRate_Public_set_Void_ShadowUpdateRate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0008E1FC File Offset: 0x0008C3FC
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x0008E238 File Offset: 0x0008C438
		public unsafe int waitXFrames
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 29072, RefRangeEnd = 29101, XrefRangeStart = 29072, XrefRangeEnd = 29101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_waitXFrames_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29101, RefRangeEnd = 29102, XrefRangeStart = 29101, XrefRangeEnd = 29102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_waitXFrames_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0008E278 File Offset: 0x0008C478
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x0008E2B4 File Offset: 0x0008C4B4
		public unsafe LayerMask layerMask
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 70643, RefRangeEnd = 70670, XrefRangeStart = 70643, XrefRangeEnd = 70643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_layerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70670, XrefRangeEnd = 70671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_layerMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0008E2F4 File Offset: 0x0008C4F4
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x0008E330 File Offset: 0x0008C530
		public unsafe bool useOcclusionCulling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70671, XrefRangeEnd = 70677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0008E370 File Offset: 0x0008C570
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x0008E3AC File Offset: 0x0008C5AC
		public unsafe int depthMapResolution
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 41326, RefRangeEnd = 41452, XrefRangeStart = 41326, XrefRangeEnd = 41452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get_depthMapResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70677, XrefRangeEnd = 70702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_set_depthMapResolution_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0008E3EC File Offset: 0x0008C5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70702, XrefRangeEnd = 70703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusionManually()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0008E420 File Offset: 0x0008C620
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70710, RefRangeEnd = 70713, XrefRangeStart = 70703, XrefRangeEnd = 70710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDepthCameraProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraProperties_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0008E454 File Offset: 0x0008C654
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 70732, RefRangeEnd = 70737, XrefRangeStart = 70713, XrefRangeEnd = 70732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusion(VolumetricShadowHD.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusion_Private_Void_ProcessOcclusionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0008E494 File Offset: 0x0008C694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70758, RefRangeEnd = 70759, XrefRangeStart = 70737, XrefRangeEnd = 70758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyMaterialProperties(VolumetricShadowHD instance, BeamGeometryHD geom)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(geom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricShadowHD_BeamGeometryHD_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0008E4DC File Offset: 0x0008C6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70759, XrefRangeEnd = 70763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0008E510 File Offset: 0x0008C710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70763, XrefRangeEnd = 70769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0008E544 File Offset: 0x0008C744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70769, XrefRangeEnd = 70777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0008E578 File Offset: 0x0008C778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70777, XrefRangeEnd = 70797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0008E5AC File Offset: 0x0008C7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70797, XrefRangeEnd = 70800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessOcclusionInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0008E5E0 File Offset: 0x0008C7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70800, XrefRangeEnd = 70802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeamEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnBeamEnabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0008E614 File Offset: 0x0008C814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70802, XrefRangeEnd = 70813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillCameraRenderThisBeam(Camera cam, BeamGeometryHD beamGeom)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beamGeom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Public_Void_Camera_BeamGeometryHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0008E668 File Offset: 0x0008C868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70813, XrefRangeEnd = 70823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0008E69C File Offset: 0x0008C89C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 70832, RefRangeEnd = 70836, XrefRangeStart = 70823, XrefRangeEnd = 70832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDepthCameraPropertiesAccordingToBeam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0008E6D0 File Offset: 0x0008C8D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70893, RefRangeEnd = 70894, XrefRangeStart = 70836, XrefRangeEnd = 70893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantiateOrActivateDepthCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0008E704 File Offset: 0x0008C904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDepthCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0008E738 File Offset: 0x0008C938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70894, XrefRangeEnd = 70896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_OnValidateProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0008E76C File Offset: 0x0008C96C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70901, RefRangeEnd = 70904, XrefRangeStart = 70896, XrefRangeEnd = 70901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_SetDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0008E7A0 File Offset: 0x0008C9A0
		public unsafe int _INTERNAL_LastFrameRendered
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 63933, RefRangeEnd = 63934, XrefRangeStart = 63933, XrefRangeEnd = 63934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0008E7DC File Offset: 0x0008C9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70904, XrefRangeEnd = 70909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricShadowHD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0000516B File Offset: 0x0000336B
		public VolumetricShadowHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0008E818 File Offset: 0x0008CA18
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00005174 File Offset: 0x00003374
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x0008E838 File Offset: 0x0008CA38
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00005186 File Offset: 0x00003386
		public unsafe float m_Strength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Strength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Strength)) = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0008E860 File Offset: 0x0008CA60
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x000051A1 File Offset: 0x000033A1
		public unsafe ShadowUpdateRate m_UpdateRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UpdateRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UpdateRate)) = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x0008E888 File Offset: 0x0008CA88
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x000051BC File Offset: 0x000033BC
		public unsafe int m_WaitXFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_WaitXFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_WaitXFrames)) = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0008E8B0 File Offset: 0x0008CAB0
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x000051D7 File Offset: 0x000033D7
		public unsafe LayerMask m_LayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LayerMask)) = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0008E8D8 File Offset: 0x0008CAD8
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x000051F2 File Offset: 0x000033F2
		public unsafe bool m_UseOcclusionCulling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UseOcclusionCulling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_UseOcclusionCulling)) = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0008E900 File Offset: 0x0008CB00
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x0000520D File Offset: 0x0000340D
		public unsafe int m_DepthMapResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthMapResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthMapResolution)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0008E928 File Offset: 0x0008CB28
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00005228 File Offset: 0x00003428
		public unsafe VolumetricLightBeamHD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0008E958 File Offset: 0x0008CB58
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00005247 File Offset: 0x00003447
		public unsafe TransformUtils.Packed m_TransformPacked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_TransformPacked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_TransformPacked)) = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x0008E980 File Offset: 0x0008CB80
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00005262 File Offset: 0x00003462
		public unsafe int m_LastFrameRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LastFrameRendered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_LastFrameRendered)) = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0008E9A8 File Offset: 0x0008CBA8
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x0000527D File Offset: 0x0000347D
		public unsafe Camera m_DepthCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_DepthCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x0008E9D8 File Offset: 0x0008CBD8
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x0000529C File Offset: 0x0000349C
		public unsafe bool m_NeedToUpdateOcclusionNextFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricShadowHD.NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame)) = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0008EA00 File Offset: 0x0008CC00
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x000052B7 File Offset: 0x000034B7
		public unsafe static bool _INTERNAL_ApplyRandomFrameOffset
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset, (void*)(&value));
			}
		}

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_m_Strength;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateRate;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitXFrames;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeFieldInfoPtr_m_LayerMask;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr_m_UseOcclusionCulling;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthMapResolution;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_m_TransformPacked;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_m_LastFrameRendered;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthCamera;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedToUpdateOcclusionNextFrame;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr__INTERNAL_ApplyRandomFrameOffset;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_get_strength_Public_get_Single_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_set_strength_Public_set_Void_Single_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_get_updateRate_Public_get_ShadowUpdateRate_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_set_updateRate_Public_set_Void_ShadowUpdateRate_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_get_waitXFrames_Public_get_Int32_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_set_waitXFrames_Public_set_Void_Int32_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_get_layerMask_Public_get_LayerMask_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_set_layerMask_Public_set_Void_LayerMask_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_get_useOcclusionCulling_Public_get_Boolean_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_set_useOcclusionCulling_Public_set_Void_Boolean_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_get_depthMapResolution_Public_get_Int32_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_set_depthMapResolution_Public_set_Void_Int32_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionManually_Public_Void_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDepthCameraProperties_Public_Void_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusion_Private_Void_ProcessOcclusionSource_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterialProperties_Public_Static_Void_VolumetricShadowHD_BeamGeometryHD_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOcclusionInternal_Private_Void_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_OnBeamEnabled_Private_Void_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Public_Void_Camera_BeamGeometryHD_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDepthCameraPropertiesAccordingToBeam_Private_Void_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateOrActivateDepthCamera_Private_Void_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDepthCamera_Private_Void_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Private_Void_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Private_Void_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_LastFrameRendered_Public_get_Int32_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000875 RID: 2165
		[OriginalName("Assembly-CSharp.dll", "", "ProcessOcclusionSource")]
		public enum ProcessOcclusionSource
		{
			// Token: 0x04008ED4 RID: 36564
			RenderLoop,
			// Token: 0x04008ED5 RID: 36565
			OnEnable,
			// Token: 0x04008ED6 RID: 36566
			EditorUpdate,
			// Token: 0x04008ED7 RID: 36567
			User
		}

		// Token: 0x02000876 RID: 2166
		[ObfuscatedName("VLB.VolumetricShadowHD+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D1E7 RID: 53735 RVA: 0x00348050 File Offset: 0x00346250
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricShadowHD>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr);
				VolumetricShadowHD.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, "<>9");
				VolumetricShadowHD.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, "<>9__39_0");
				VolumetricShadowHD.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, 100664002);
				VolumetricShadowHD.__c.NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__39_0_Internal_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr, 100664003);
			}

			// Token: 0x0600D1E8 RID: 53736 RVA: 0x003480CC File Offset: 0x003462CC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricShadowHD.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1E9 RID: 53737 RVA: 0x00348108 File Offset: 0x00346308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70636, XrefRangeEnd = 70642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstantiateOrActivateDepthCamera_b__39_0(Camera cam)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricShadowHD.__c.NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__39_0_Internal_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D1EA RID: 53738 RVA: 0x000635C2 File Offset: 0x000617C2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FC8 RID: 16328
			// (get) Token: 0x0600D1EB RID: 53739 RVA: 0x0034814C File Offset: 0x0034634C
			// (set) Token: 0x0600D1EC RID: 53740 RVA: 0x000635CB File Offset: 0x000617CB
			public unsafe static VolumetricShadowHD.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricShadowHD.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC9 RID: 16329
			// (get) Token: 0x0600D1ED RID: 53741 RVA: 0x00348174 File Offset: 0x00346374
			// (set) Token: 0x0600D1EE RID: 53742 RVA: 0x000635DD File Offset: 0x000617DD
			public unsafe static Action<Camera> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Camera>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumetricShadowHD.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ED8 RID: 36568
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008ED9 RID: 36569
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x04008EDA RID: 36570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EDB RID: 36571
			private static readonly IntPtr NativeMethodInfoPtr__InstantiateOrActivateDepthCamera_b__39_0_Internal_Void_Camera_0;
		}
	}
}

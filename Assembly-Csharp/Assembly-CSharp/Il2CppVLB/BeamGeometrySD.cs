using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppVLB
{
	// Token: 0x02000069 RID: 105
	public class BeamGeometrySD : BeamGeometryAbstractBase
	{
		// Token: 0x0600069B RID: 1691 RVA: 0x000900E0 File Offset: 0x0008E2E0
		// Note: this type is marked as 'beforefieldinit'.
		static BeamGeometrySD()
		{
			Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "BeamGeometrySD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr);
			BeamGeometrySD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "m_Master");
			BeamGeometrySD.NativeFieldInfoPtr_m_CurrentMeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "m_CurrentMeshType");
			BeamGeometrySD.NativeFieldInfoPtr_m_MaterialModifierCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "m_MaterialModifierCallback");
			BeamGeometrySD.NativeFieldInfoPtr_m_CoFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "m_CoFadeOut");
			BeamGeometrySD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "m_CurrentCameraRenderingSRP");
			BeamGeometrySD.NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664109);
			BeamGeometrySD.NativeMethodInfoPtr_get_visible_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664110);
			BeamGeometrySD.NativeMethodInfoPtr_set_visible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664111);
			BeamGeometrySD.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664112);
			BeamGeometrySD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664113);
			BeamGeometrySD.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664114);
			BeamGeometrySD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664115);
			BeamGeometrySD.NativeMethodInfoPtr_get__INTERNAL_IsFadeOutCoroutineRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664116);
			BeamGeometrySD.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664117);
			BeamGeometrySD.NativeMethodInfoPtr_CoUpdateFadeOut_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664118);
			BeamGeometrySD.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664119);
			BeamGeometrySD.NativeMethodInfoPtr_SetFadeOutFactorProp_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664120);
			BeamGeometrySD.NativeMethodInfoPtr_StopFadeOutCoroutine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664121);
			BeamGeometrySD.NativeMethodInfoPtr_RestartFadeOutCoroutine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664122);
			BeamGeometrySD.NativeMethodInfoPtr_OnMasterEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664123);
			BeamGeometrySD.NativeMethodInfoPtr_OnMasterDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664124);
			BeamGeometrySD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664125);
			BeamGeometrySD.NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664126);
			BeamGeometrySD.NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664127);
			BeamGeometrySD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664128);
			BeamGeometrySD.NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamSD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664129);
			BeamGeometrySD.NativeMethodInfoPtr_RegenerateMesh_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664130);
			BeamGeometrySD.NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664131);
			BeamGeometrySD.NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664132);
			BeamGeometrySD.NativeMethodInfoPtr_get_isDepthBlendEnabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664133);
			BeamGeometrySD.NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesSD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664134);
			BeamGeometrySD.NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664135);
			BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664136);
			BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664137);
			BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664138);
			BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664139);
			BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664140);
			BeamGeometrySD.NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664141);
			BeamGeometrySD.NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664142);
			BeamGeometrySD.NativeMethodInfoPtr_SetDynamicOcclusionCallback_Public_Void_String_Callback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664143);
			BeamGeometrySD.NativeMethodInfoPtr_UpdateMaterialAndBounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664144);
			BeamGeometrySD.NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664145);
			BeamGeometrySD.NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664146);
			BeamGeometrySD.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664147);
			BeamGeometrySD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664148);
			BeamGeometrySD.NativeMethodInfoPtr_UpdateCameraRelatedProperties_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664149);
			BeamGeometrySD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, 100664150);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x000904BC File Offset: 0x0008E6BC
		[CallerCount(0)]
		public unsafe override VolumetricLightBeamAbstractBase GetMaster()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeamGeometrySD.NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr3) : null;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00090508 File Offset: 0x0008E708
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00090544 File Offset: 0x0008E744
		public unsafe bool visible
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72087, XrefRangeEnd = 72089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_visible_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 72094, RefRangeEnd = 72100, XrefRangeStart = 72089, XrefRangeEnd = 72094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_set_visible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00090584 File Offset: 0x0008E784
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x000905C0 File Offset: 0x0008E7C0
		public unsafe int sortingLayerID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72100, XrefRangeEnd = 72102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72102, XrefRangeEnd = 72104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00090600 File Offset: 0x0008E800
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x0009063C File Offset: 0x0008E83C
		public unsafe int sortingOrder
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72104, XrefRangeEnd = 72106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72106, XrefRangeEnd = 72108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x0009067C File Offset: 0x0008E87C
		public unsafe bool _INTERNAL_IsFadeOutCoroutineRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get__INTERNAL_IsFadeOutCoroutineRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000906B8 File Offset: 0x0008E8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72108, XrefRangeEnd = 72110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ComputeFadeOutFactor(Transform camTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Single_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00090708 File Offset: 0x0008E908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72110, XrefRangeEnd = 72115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CoUpdateFadeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_CoUpdateFadeOut_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00090748 File Offset: 0x0008E948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72137, RefRangeEnd = 72138, XrefRangeStart = 72115, XrefRangeEnd = 72137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeFadeOutFactor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0009077C File Offset: 0x0008E97C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72148, RefRangeEnd = 72149, XrefRangeStart = 72138, XrefRangeEnd = 72148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFadeOutFactorProp(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetFadeOutFactorProp_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x000907BC File Offset: 0x0008E9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72149, XrefRangeEnd = 72151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFadeOutCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_StopFadeOutCoroutine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x000907F0 File Offset: 0x0008E9F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 72164, RefRangeEnd = 72170, XrefRangeStart = 72151, XrefRangeEnd = 72164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestartFadeOutCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_RestartFadeOutCoroutine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00090824 File Offset: 0x0008EA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72170, XrefRangeEnd = 72173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMasterEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnMasterEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00090858 File Offset: 0x0008EA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72173, XrefRangeEnd = 72177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMasterDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnMasterDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0009088C File Offset: 0x0008EA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72177, XrefRangeEnd = 72185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x000908C0 File Offset: 0x0008EAC0
		public unsafe static bool isCustomRenderPipelineSupported
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x000908F0 File Offset: 0x0008EAF0
		public unsafe bool shouldUseGPUInstancedMaterial
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 72186, RefRangeEnd = 72188, XrefRangeStart = 72185, XrefRangeEnd = 72186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0009092C File Offset: 0x0008EB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72188, XrefRangeEnd = 72196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00090960 File Offset: 0x0008EB60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72249, RefRangeEnd = 72250, XrefRangeStart = 72196, XrefRangeEnd = 72249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(VolumetricLightBeamSD master)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(master);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamSD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x000909A4 File Offset: 0x0008EBA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72293, RefRangeEnd = 72294, XrefRangeStart = 72250, XrefRangeEnd = 72293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateMesh(bool masterEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref masterEnabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_RegenerateMesh_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000909E4 File Offset: 0x0008EBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72294, XrefRangeEnd = 72302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ComputeLocalMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00090A20 File Offset: 0x0008EC20
		public unsafe bool isNoiseEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72302, XrefRangeEnd = 72303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00090A5C File Offset: 0x0008EC5C
		public unsafe bool isDepthBlendEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72303, XrefRangeEnd = 72304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_get_isDepthBlendEnabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00090A98 File Offset: 0x0008EC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72304, XrefRangeEnd = 72312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialManager.StaticPropertiesSD ComputeMaterialStaticProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesSD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00090AD4 File Offset: 0x0008ECD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72342, RefRangeEnd = 72344, XrefRangeStart = 72312, XrefRangeEnd = 72342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ApplyMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00090B10 File Offset: 0x0008ED10
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 72353, RefRangeEnd = 72364, XrefRangeStart = 72344, XrefRangeEnd = 72353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialProp(int nameID, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00090B5C File Offset: 0x0008ED5C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 72373, RefRangeEnd = 72382, XrefRangeStart = 72364, XrefRangeEnd = 72373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialProp(int nameID, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00090BA8 File Offset: 0x0008EDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72382, XrefRangeEnd = 72391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialProp(int nameID, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00090BF4 File Offset: 0x0008EDF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72400, RefRangeEnd = 72403, XrefRangeStart = 72391, XrefRangeEnd = 72400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialProp(int nameID, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00090C40 File Offset: 0x0008EE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72403, XrefRangeEnd = 72415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMaterialProp(int nameID, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00090C90 File Offset: 0x0008EE90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72424, RefRangeEnd = 72427, XrefRangeStart = 72415, XrefRangeEnd = 72424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaterialChangeStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00090CC4 File Offset: 0x0008EEC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72436, RefRangeEnd = 72439, XrefRangeStart = 72427, XrefRangeEnd = 72436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaterialChangeStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00090CF8 File Offset: 0x0008EEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72439, XrefRangeEnd = 72446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shaderKeyword);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_SetDynamicOcclusionCallback_Public_Void_String_Callback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00090D4C File Offset: 0x0008EF4C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 72586, RefRangeEnd = 72593, XrefRangeStart = 72446, XrefRangeEnd = 72586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterialAndBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_UpdateMaterialAndBounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00090D80 File Offset: 0x0008EF80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72607, RefRangeEnd = 72609, XrefRangeStart = 72593, XrefRangeEnd = 72607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00090DB4 File Offset: 0x0008EFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72609, XrefRangeEnd = 72610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00090E04 File Offset: 0x0008F004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72610, XrefRangeEnd = 72622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillRenderObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00090E38 File Offset: 0x0008F038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72622, XrefRangeEnd = 72631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillCameraRenderThisBeam(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00090E7C File Offset: 0x0008F07C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72666, RefRangeEnd = 72668, XrefRangeStart = 72631, XrefRangeEnd = 72666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCameraRelatedProperties(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr_UpdateCameraRelatedProperties_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00090EC0 File Offset: 0x0008F0C0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeamGeometrySD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x000054A2 File Offset: 0x000036A2
		public BeamGeometrySD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00090EFC File Offset: 0x0008F0FC
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x000054AB File Offset: 0x000036AB
		public unsafe VolumetricLightBeamSD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00090F2C File Offset: 0x0008F12C
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x000054CA File Offset: 0x000036CA
		public unsafe MeshType m_CurrentMeshType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CurrentMeshType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CurrentMeshType)) = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00090F54 File Offset: 0x0008F154
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x000054E5 File Offset: 0x000036E5
		public unsafe MaterialModifier.Callback m_MaterialModifierCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_MaterialModifierCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialModifier.Callback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_MaterialModifierCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00090F84 File Offset: 0x0008F184
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00005504 File Offset: 0x00003704
		public unsafe Coroutine m_CoFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CoFadeOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CoFadeOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00090FB4 File Offset: 0x0008F1B4
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00005523 File Offset: 0x00003723
		public unsafe Camera m_CurrentCameraRenderingSRP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentMeshType;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeFieldInfoPtr_m_MaterialModifierCallback;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeFieldInfoPtr_m_CoFadeOut;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCameraRenderingSRP;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_get_visible_Private_get_Boolean_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Private_set_Void_Boolean_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_IsFadeOutCoroutineRunning_Public_get_Boolean_0;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Single_Transform_0;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr_CoUpdateFadeOut_Private_IEnumerator_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr_ComputeFadeOutFactor_Private_Void_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_SetFadeOutFactorProp_Private_Void_Single_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_StopFadeOutCoroutine_Private_Void_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr_RestartFadeOutCoroutine_Public_Void_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_OnMasterEnable_Public_Void_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_OnMasterDisable_Public_Void_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamSD_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateMesh_Public_Void_Boolean_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_get_isDepthBlendEnabled_Private_get_Boolean_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesSD_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Single_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Vector4_0;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Color_0;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Matrix4x4_0;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Virtual_Final_New_Void_Int32_Texture_0;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeMethodInfoPtr_SetDynamicOcclusionCallback_Public_Void_String_Callback_0;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterialAndBounds_Public_Void_0;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraRelatedProperties_Private_Void_Camera_0;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000887 RID: 2183
		[ObfuscatedName("VLB.BeamGeometrySD+<CoUpdateFadeOut>d__17")]
		public sealed class _CoUpdateFadeOut_d__17 : Il2CppSystem.Object
		{
			// Token: 0x0600D24C RID: 53836 RVA: 0x00349714 File Offset: 0x00347914
			// Note: this type is marked as 'beforefieldinit'.
			static _CoUpdateFadeOut_d__17()
			{
				Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BeamGeometrySD>.NativeClassPtr, "<CoUpdateFadeOut>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, "<>1__state");
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, "<>2__current");
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, "<>4__this");
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664151);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664152);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664153);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664154);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664155);
				BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr, 100664156);
			}

			// Token: 0x0600D24D RID: 53837 RVA: 0x003497F4 File Offset: 0x003479F4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CoUpdateFadeOut_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamGeometrySD._CoUpdateFadeOut_d__17>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D24E RID: 53838 RVA: 0x0034983C File Offset: 0x00347A3C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D24F RID: 53839 RVA: 0x00349870 File Offset: 0x00347A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72080, XrefRangeEnd = 72082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003FE5 RID: 16357
			// (get) Token: 0x0600D250 RID: 53840 RVA: 0x003498AC File Offset: 0x00347AAC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D251 RID: 53841 RVA: 0x003498EC File Offset: 0x00347AEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72082, XrefRangeEnd = 72087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FE6 RID: 16358
			// (get) Token: 0x0600D252 RID: 53842 RVA: 0x00349920 File Offset: 0x00347B20
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D253 RID: 53843 RVA: 0x000637C0 File Offset: 0x000619C0
			public _CoUpdateFadeOut_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FE2 RID: 16354
			// (get) Token: 0x0600D254 RID: 53844 RVA: 0x00349960 File Offset: 0x00347B60
			// (set) Token: 0x0600D255 RID: 53845 RVA: 0x000637C9 File Offset: 0x000619C9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003FE3 RID: 16355
			// (get) Token: 0x0600D256 RID: 53846 RVA: 0x00349988 File Offset: 0x00347B88
			// (set) Token: 0x0600D257 RID: 53847 RVA: 0x000637E4 File Offset: 0x000619E4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE4 RID: 16356
			// (get) Token: 0x0600D258 RID: 53848 RVA: 0x003499B8 File Offset: 0x00347BB8
			// (set) Token: 0x0600D259 RID: 53849 RVA: 0x00063803 File Offset: 0x00061A03
			public unsafe BeamGeometrySD __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BeamGeometrySD>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometrySD._CoUpdateFadeOut_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F4F RID: 36687
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F50 RID: 36688
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F51 RID: 36689
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F52 RID: 36690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F53 RID: 36691
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F54 RID: 36692
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F55 RID: 36693
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F56 RID: 36694
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F57 RID: 36695
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

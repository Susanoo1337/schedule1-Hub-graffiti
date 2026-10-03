using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200006C RID: 108
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		// Token: 0x06000718 RID: 1816 RVA: 0x00091F54 File Offset: 0x00090154
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicOcclusionRaycasting()
		{
			Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "DynamicOcclusionRaycasting");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr);
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "ClassName");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "dimensions");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "layerMask");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "considerTriggers");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "minOccluderArea");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "minSurfaceRatio");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "maxSurfaceDot");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "planeAlignment");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "planeOffset");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "fadeDistanceToSurface");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_CurrentHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "m_CurrentHit");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "m_RangeMultiplier");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "<planeEquationWS>k__BackingField");
			DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "m_PrevNonSubHitDirectionId");
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664196);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664197);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664198);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664199);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664200);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_planeEquationWS_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664201);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664202);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664203);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664204);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664205);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664206);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664207);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664208);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664209);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664210);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664211);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664212);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirectionCount_Private_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664213);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664214);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsHitValid_Private_Boolean_byref_HitResult_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664215);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664216);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHit_Private_Void_byref_HitResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664217);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHitNull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664218);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664219);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664220);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664221);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664222);
			DynamicOcclusionRaycasting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, 100664223);
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x000922CC File Offset: 0x000904CC
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00092308 File Offset: 0x00090508
		public unsafe float fadeDistanceToPlane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00092348 File Offset: 0x00090548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73008, XrefRangeEnd = 73014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00092398 File Offset: 0x00090598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73014, XrefRangeEnd = 73016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetShaderKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000923DC File Offset: 0x000905DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70633, RefRangeEnd = 70636, XrefRangeStart = 70633, XrefRangeEnd = 70636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00092424 File Offset: 0x00090624
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00092460 File Offset: 0x00090660
		public unsafe Plane planeEquationWS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_planeEquationWS_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000924A0 File Offset: 0x000906A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73016, XrefRangeEnd = 73017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidateProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000924DC File Offset: 0x000906DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73017, XrefRangeEnd = 73019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnablePostValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00092518 File Offset: 0x00090718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73019, XrefRangeEnd = 73021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00092554 File Offset: 0x00090754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73021, XrefRangeEnd = 73032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00092588 File Offset: 0x00090788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73032, XrefRangeEnd = 73037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angleDiff;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x000925E0 File Offset: 0x000907E0
		public unsafe QueryTriggerInteraction queryTriggerInteraction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x0009261C File Offset: 0x0009081C
		public unsafe float raycastMaxDistance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73037, XrefRangeEnd = 73038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00092658 File Offset: 0x00090858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73038, XrefRangeEnd = 73041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DynamicOcclusionRaycasting.HitResult(pointer);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000926AC File Offset: 0x000908AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 73060, RefRangeEnd = 73063, XrefRangeStart = 73041, XrefRangeEnd = 73060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DynamicOcclusionRaycasting.HitResult(pointer);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00092700 File Offset: 0x00090900
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 73084, RefRangeEnd = 73087, XrefRangeStart = 73063, XrefRangeEnd = 73084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting.HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rayPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rayDir;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DynamicOcclusionRaycasting.HitResult(pointer);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00092754 File Offset: 0x00090954
		[CallerCount(0)]
		public unsafe uint GetDirectionCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirectionCount_Private_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00092790 File Offset: 0x00090990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73099, RefRangeEnd = 73100, XrefRangeStart = 73087, XrefRangeEnd = 73099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetDirection(uint dirInt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dirInt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000927DC File Offset: 0x000909DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73100, XrefRangeEnd = 73101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHitValid(ref DynamicOcclusionRaycasting.HitResult hit, Vector3 forwardVec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hit));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forwardVec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_IsHitValid_Private_Boolean_byref_HitResult_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00092840 File Offset: 0x00090A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73101, XrefRangeEnd = 73135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnProcessOcclusion(DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00092894 File Offset: 0x00090A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 73150, RefRangeEnd = 73151, XrefRangeStart = 73135, XrefRangeEnd = 73150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHit(ref DynamicOcclusionRaycasting.HitResult hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(hit));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHit_Private_Void_byref_HitResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000928DC File Offset: 0x00090ADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73166, RefRangeEnd = 73168, XrefRangeStart = 73151, XrefRangeEnd = 73166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHitNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetHitNull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00092910 File Offset: 0x00090B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73168, XrefRangeEnd = 73181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicOcclusionRaycasting.NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00092960 File Offset: 0x00090B60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73184, RefRangeEnd = 73186, XrefRangeStart = 73181, XrefRangeEnd = 73184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClippingPlane(Plane planeWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref planeWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000929A0 File Offset: 0x00090BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73186, XrefRangeEnd = 73196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetClippingPlaneOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000929D4 File Offset: 0x00090BD4
		[CallerCount(0)]
		public unsafe void SetPlaneWS(Plane planeWS)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref planeWS;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00092A14 File Offset: 0x00090C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73196, XrefRangeEnd = 73204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicOcclusionRaycasting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000056F5 File Offset: 0x000038F5
		public DynamicOcclusionRaycasting(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00092A50 File Offset: 0x00090C50
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x000056FE File Offset: 0x000038FE
		public new unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicOcclusionRaycasting.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicOcclusionRaycasting.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00092A70 File Offset: 0x00090C70
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00005710 File Offset: 0x00003910
		public unsafe Dimensions dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_dimensions)) = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00092A98 File Offset: 0x00090C98
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x0000572B File Offset: 0x0000392B
		public unsafe LayerMask layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_layerMask)) = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00092AC0 File Offset: 0x00090CC0
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00005746 File Offset: 0x00003946
		public unsafe bool considerTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_considerTriggers)) = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00092AE8 File Offset: 0x00090CE8
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00005761 File Offset: 0x00003961
		public unsafe float minOccluderArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minOccluderArea)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00092B10 File Offset: 0x00090D10
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0000577C File Offset: 0x0000397C
		public unsafe float minSurfaceRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_minSurfaceRatio)) = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00092B38 File Offset: 0x00090D38
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00005797 File Offset: 0x00003997
		public unsafe float maxSurfaceDot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_maxSurfaceDot)) = value;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00092B60 File Offset: 0x00090D60
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x000057B2 File Offset: 0x000039B2
		public unsafe PlaneAlignment planeAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeAlignment)) = value;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00092B88 File Offset: 0x00090D88
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x000057CD File Offset: 0x000039CD
		public unsafe float planeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_planeOffset)) = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00092BB0 File Offset: 0x00090DB0
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x000057E8 File Offset: 0x000039E8
		public unsafe float fadeDistanceToSurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_fadeDistanceToSurface)) = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00092BD8 File Offset: 0x00090DD8
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00005803 File Offset: 0x00003A03
		public DynamicOcclusionRaycasting.HitResult m_CurrentHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_CurrentHit);
				return new DynamicOcclusionRaycasting.HitResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_CurrentHit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00092C08 File Offset: 0x00090E08
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00005831 File Offset: 0x00003A31
		public unsafe float m_RangeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_RangeMultiplier)) = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00092C30 File Offset: 0x00090E30
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x0000584C File Offset: 0x00003A4C
		public unsafe Plane _planeEquationWS_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr__planeEquationWS_k__BackingField)) = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00092C58 File Offset: 0x00090E58
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00005867 File Offset: 0x00003A67
		public unsafe uint m_PrevNonSubHitDirectionId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.NativeFieldInfoPtr_m_PrevNonSubHitDirectionId)) = value;
			}
		}

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeFieldInfoPtr_dimensions;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeFieldInfoPtr_considerTriggers;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeFieldInfoPtr_minOccluderArea;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeFieldInfoPtr_minSurfaceRatio;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr_maxSurfaceDot;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr_planeAlignment;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeFieldInfoPtr_planeOffset;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeFieldInfoPtr_fadeDistanceToSurface;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentHit;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeFieldInfoPtr_m_RangeMultiplier;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeFieldInfoPtr__planeEquationWS_k__BackingField;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeFieldInfoPtr_m_PrevNonSubHitDirectionId;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_get_fadeDistanceToPlane_Public_get_Single_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_set_fadeDistanceToPlane_Public_set_Void_Single_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_IsColliderHiddenByDynamicOccluder_Public_Boolean_Collider_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderKeyword_Protected_Virtual_String_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOcclusionMode_Protected_Virtual_DynamicOcclusion_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_get_planeEquationWS_Public_get_Plane_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_set_planeEquationWS_Private_set_Void_Plane_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_OnValidateProperties_Protected_Virtual_Void_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_OnEnablePostValidate_Protected_Virtual_Void_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomVectorAround_Private_Vector3_Vector3_Single_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_get_queryTriggerInteraction_Private_get_QueryTriggerInteraction_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_get_raycastMaxDistance_Private_get_Single_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit3D_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_GetBestHit2D_Private_HitResult_Vector3_Vector3_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectionCount_Private_UInt32_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_GetDirection_Private_Vector3_UInt32_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_IsHitValid_Private_Boolean_byref_HitResult_Vector3_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessOcclusion_Protected_Virtual_Boolean_ProcessOcclusionSource_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_SetHit_Private_Void_byref_HitResult_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_SetHitNull_Private_Void_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_OnModifyMaterialCallback_Protected_Virtual_Void_Interface_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_SetClippingPlane_Private_Void_Plane_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_SetClippingPlaneOff_Private_Void_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_SetPlaneWS_Private_Void_Plane_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200088A RID: 2186
		public sealed class HitResult : ValueType
		{
			// Token: 0x0600D262 RID: 53858 RVA: 0x00349B34 File Offset: 0x00347D34
			// Note: this type is marked as 'beforefieldinit'.
			static HitResult()
			{
				Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicOcclusionRaycasting>.NativeClassPtr, "HitResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr);
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "point");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "normal");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "distance");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "collider2D");
				DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, "collider3D");
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664224);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664225);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664226);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664227);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664228);
				DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_SetNull_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr, 100664229);
			}

			// Token: 0x0600D263 RID: 53859 RVA: 0x00349C3C File Offset: 0x00347E3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72970, XrefRangeEnd = 72976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HitResult(ref RaycastHit hit3D) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &hit3D;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D264 RID: 53860 RVA: 0x00349C88 File Offset: 0x00347E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72976, XrefRangeEnd = 72982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HitResult(ref RaycastHit2D hit2D) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &hit2D;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit2D_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003FEE RID: 16366
			// (get) Token: 0x0600D265 RID: 53861 RVA: 0x00349CD4 File Offset: 0x00347ED4
			public unsafe bool hasCollider
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 72986, RefRangeEnd = 72990, XrefRangeStart = 72982, XrefRangeEnd = 72986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17003FEF RID: 16367
			// (get) Token: 0x0600D266 RID: 53862 RVA: 0x00349D18 File Offset: 0x00347F18
			public unsafe string name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72990, XrefRangeEnd = 72999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003FF0 RID: 16368
			// (get) Token: 0x0600D267 RID: 53863 RVA: 0x00349D54 File Offset: 0x00347F54
			public unsafe Bounds bounds
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72999, XrefRangeEnd = 73006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D268 RID: 53864 RVA: 0x00349D98 File Offset: 0x00347F98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73006, XrefRangeEnd = 73008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNull()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicOcclusionRaycasting.HitResult.NativeMethodInfoPtr_SetNull_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D269 RID: 53865 RVA: 0x0006384F File Offset: 0x00061A4F
			public HitResult(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D26A RID: 53866 RVA: 0x00063858 File Offset: 0x00061A58
			public HitResult() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicOcclusionRaycasting.HitResult>.NativeClassPtr))
			{
			}

			// Token: 0x17003FE9 RID: 16361
			// (get) Token: 0x0600D26B RID: 53867 RVA: 0x00349DD0 File Offset: 0x00347FD0
			// (set) Token: 0x0600D26C RID: 53868 RVA: 0x0006386A File Offset: 0x00061A6A
			public unsafe Vector3 point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x17003FEA RID: 16362
			// (get) Token: 0x0600D26D RID: 53869 RVA: 0x00349DF8 File Offset: 0x00347FF8
			// (set) Token: 0x0600D26E RID: 53870 RVA: 0x00063885 File Offset: 0x00061A85
			public unsafe Vector3 normal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_normal)) = value;
				}
			}

			// Token: 0x17003FEB RID: 16363
			// (get) Token: 0x0600D26F RID: 53871 RVA: 0x00349E20 File Offset: 0x00348020
			// (set) Token: 0x0600D270 RID: 53872 RVA: 0x000638A0 File Offset: 0x00061AA0
			public unsafe float distance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_distance)) = value;
				}
			}

			// Token: 0x17003FEC RID: 16364
			// (get) Token: 0x0600D271 RID: 53873 RVA: 0x00349E48 File Offset: 0x00348048
			// (set) Token: 0x0600D272 RID: 53874 RVA: 0x000638BB File Offset: 0x00061ABB
			public unsafe Collider2D collider2D
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider2D), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FED RID: 16365
			// (get) Token: 0x0600D273 RID: 53875 RVA: 0x00349E78 File Offset: 0x00348078
			// (set) Token: 0x0600D274 RID: 53876 RVA: 0x000638DA File Offset: 0x00061ADA
			public unsafe Collider collider3D
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicOcclusionRaycasting.HitResult.NativeFieldInfoPtr_collider3D), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F61 RID: 36705
			private static readonly IntPtr NativeFieldInfoPtr_point;

			// Token: 0x04008F62 RID: 36706
			private static readonly IntPtr NativeFieldInfoPtr_normal;

			// Token: 0x04008F63 RID: 36707
			private static readonly IntPtr NativeFieldInfoPtr_distance;

			// Token: 0x04008F64 RID: 36708
			private static readonly IntPtr NativeFieldInfoPtr_collider2D;

			// Token: 0x04008F65 RID: 36709
			private static readonly IntPtr NativeFieldInfoPtr_collider3D;

			// Token: 0x04008F66 RID: 36710
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit_0;

			// Token: 0x04008F67 RID: 36711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_RaycastHit2D_0;

			// Token: 0x04008F68 RID: 36712
			private static readonly IntPtr NativeMethodInfoPtr_get_hasCollider_Public_get_Boolean_0;

			// Token: 0x04008F69 RID: 36713
			private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

			// Token: 0x04008F6A RID: 36714
			private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

			// Token: 0x04008F6B RID: 36715
			private static readonly IntPtr NativeMethodInfoPtr_SetNull_Public_Void_0;
		}

		// Token: 0x0200088B RID: 2187
		[OriginalName("Assembly-CSharp.dll", "", "Direction")]
		public enum Direction
		{
			// Token: 0x04008F6D RID: 36717
			Up,
			// Token: 0x04008F6E RID: 36718
			Down,
			// Token: 0x04008F6F RID: 36719
			Left,
			// Token: 0x04008F70 RID: 36720
			Right,
			// Token: 0x04008F71 RID: 36721
			Max2D = 1,
			// Token: 0x04008F72 RID: 36722
			Max3D = 3
		}
	}
}

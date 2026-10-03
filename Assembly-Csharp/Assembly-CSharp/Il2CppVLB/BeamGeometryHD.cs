using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppVLB
{
	// Token: 0x02000058 RID: 88
	public class BeamGeometryHD : BeamGeometryAbstractBase
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x00089714 File Offset: 0x00087914
		// Note: this type is marked as 'beforefieldinit'.
		static BeamGeometryHD()
		{
			Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "BeamGeometryHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr);
			BeamGeometryHD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, "m_Master");
			BeamGeometryHD.NativeFieldInfoPtr_m_Cookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, "m_Cookie");
			BeamGeometryHD.NativeFieldInfoPtr_m_Shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, "m_Shadow");
			BeamGeometryHD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, "m_CurrentCameraRenderingSRP");
			BeamGeometryHD.NativeFieldInfoPtr_m_DirtyProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, "m_DirtyProps");
			BeamGeometryHD.NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663793);
			BeamGeometryHD.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663794);
			BeamGeometryHD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663795);
			BeamGeometryHD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663796);
			BeamGeometryHD.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663797);
			BeamGeometryHD.NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663798);
			BeamGeometryHD.NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663799);
			BeamGeometryHD.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663800);
			BeamGeometryHD.NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663801);
			BeamGeometryHD.NativeMethodInfoPtr_RegenerateMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663802);
			BeamGeometryHD.NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663803);
			BeamGeometryHD.NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663804);
			BeamGeometryHD.NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663805);
			BeamGeometryHD.NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663806);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663807);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663808);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663809);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663810);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663811);
			BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_InvalidTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663812);
			BeamGeometryHD.NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663813);
			BeamGeometryHD.NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663814);
			BeamGeometryHD.NativeMethodInfoPtr_SetPropertyDirty_Public_Void_DirtyProps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663815);
			BeamGeometryHD.NativeMethodInfoPtr_UpdateMaterialAndBounds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663816);
			BeamGeometryHD.NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663817);
			BeamGeometryHD.NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663818);
			BeamGeometryHD.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663819);
			BeamGeometryHD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663820);
			BeamGeometryHD.NativeMethodInfoPtr_UpdateDirtyMaterialProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663821);
			BeamGeometryHD.NativeMethodInfoPtr_UpdateMaterialPropertiesForCamera_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663822);
			BeamGeometryHD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr, 100663823);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00089A14 File Offset: 0x00087C14
		[CallerCount(0)]
		public unsafe override VolumetricLightBeamAbstractBase GetMaster()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeamGeometryHD.NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr3) : null;
		}

		// Token: 0x17000190 RID: 400
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00089A60 File Offset: 0x00087C60
		public unsafe bool visible
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 69612, RefRangeEnd = 69615, XrefRangeStart = 69607, XrefRangeEnd = 69612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000191 RID: 401
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00089AA0 File Offset: 0x00087CA0
		public unsafe int sortingLayerID
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 69620, RefRangeEnd = 69623, XrefRangeStart = 69615, XrefRangeEnd = 69620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000192 RID: 402
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00089AE0 File Offset: 0x00087CE0
		public unsafe int sortingOrder
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 69628, RefRangeEnd = 69630, XrefRangeStart = 69623, XrefRangeEnd = 69628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00089B20 File Offset: 0x00087D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69630, XrefRangeEnd = 69638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00089B54 File Offset: 0x00087D54
		public unsafe static bool isCustomRenderPipelineSupported
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00089B84 File Offset: 0x00087D84
		public unsafe bool shouldUseGPUInstancedMaterial
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 69644, RefRangeEnd = 69646, XrefRangeStart = 69638, XrefRangeEnd = 69644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00089BC0 File Offset: 0x00087DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69646, XrefRangeEnd = 69653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00089BF4 File Offset: 0x00087DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69713, RefRangeEnd = 69714, XrefRangeStart = 69653, XrefRangeEnd = 69713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(VolumetricLightBeamHD master)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(master);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00089C38 File Offset: 0x00087E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69714, XrefRangeEnd = 69730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_RegenerateMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00089C6C File Offset: 0x00087E6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69737, RefRangeEnd = 69739, XrefRangeStart = 69730, XrefRangeEnd = 69737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 ComputeLocalMatrix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00089CA8 File Offset: 0x00087EA8
		public unsafe bool isNoiseEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69739, XrefRangeEnd = 69740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00089CE4 File Offset: 0x00087EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69754, RefRangeEnd = 69755, XrefRangeStart = 69740, XrefRangeEnd = 69754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialManager.StaticPropertiesHD ComputeMaterialStaticProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesHD_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00089D20 File Offset: 0x00087F20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69778, RefRangeEnd = 69780, XrefRangeStart = 69755, XrefRangeEnd = 69778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ApplyMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00089D5C File Offset: 0x00087F5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69789, RefRangeEnd = 69792, XrefRangeStart = 69780, XrefRangeEnd = 69789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00089DA8 File Offset: 0x00087FA8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 69801, RefRangeEnd = 69813, XrefRangeStart = 69792, XrefRangeEnd = 69801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, Vector4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00089DF4 File Offset: 0x00087FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69813, XrefRangeEnd = 69822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00089E40 File Offset: 0x00088040
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69831, RefRangeEnd = 69834, XrefRangeStart = 69822, XrefRangeEnd = 69831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, Matrix4x4 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00089E8C File Offset: 0x0008808C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69839, RefRangeEnd = 69841, XrefRangeStart = 69834, XrefRangeEnd = 69839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, Texture value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00089EDC File Offset: 0x000880DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69841, XrefRangeEnd = 69850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialProp(int nameID, BeamGeometryHD.InvalidTexture invalidTexture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref nameID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invalidTexture;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_InvalidTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00089F28 File Offset: 0x00088128
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69859, RefRangeEnd = 69861, XrefRangeStart = 69850, XrefRangeEnd = 69859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaterialChangeStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00089F5C File Offset: 0x0008815C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69870, RefRangeEnd = 69872, XrefRangeStart = 69861, XrefRangeEnd = 69870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MaterialChangeStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00089F90 File Offset: 0x00088190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69872, XrefRangeEnd = 69879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPropertyDirty(DirtyProps prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_SetPropertyDirty_Public_Void_DirtyProps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00089FD0 File Offset: 0x000881D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 69886, RefRangeEnd = 69890, XrefRangeStart = 69879, XrefRangeEnd = 69886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterialAndBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_UpdateMaterialAndBounds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0008A004 File Offset: 0x00088204
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69904, RefRangeEnd = 69906, XrefRangeStart = 69890, XrefRangeEnd = 69904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0008A038 File Offset: 0x00088238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69906, XrefRangeEnd = 69907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0008A088 File Offset: 0x00088288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69907, XrefRangeEnd = 69911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillRenderObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0008A0BC File Offset: 0x000882BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69934, RefRangeEnd = 69935, XrefRangeStart = 69911, XrefRangeEnd = 69934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWillCameraRenderThisBeam(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0008A100 File Offset: 0x00088300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70003, RefRangeEnd = 70004, XrefRangeStart = 69935, XrefRangeEnd = 70003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDirtyMaterialProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_UpdateDirtyMaterialProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0008A134 File Offset: 0x00088334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70044, RefRangeEnd = 70045, XrefRangeStart = 70004, XrefRangeEnd = 70044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterialPropertiesForCamera(Camera cam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr_UpdateMaterialPropertiesForCamera_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0008A178 File Offset: 0x00088378
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeamGeometryHD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamGeometryHD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryHD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00004B8C File Offset: 0x00002D8C
		public BeamGeometryHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0008A1B4 File Offset: 0x000883B4
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00004B95 File Offset: 0x00002D95
		public unsafe VolumetricLightBeamHD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0008A1E4 File Offset: 0x000883E4
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00004BB4 File Offset: 0x00002DB4
		public unsafe VolumetricCookieHD m_Cookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Cookie);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricCookieHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Cookie), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0008A214 File Offset: 0x00088414
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00004BD3 File Offset: 0x00002DD3
		public unsafe VolumetricShadowHD m_Shadow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Shadow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricShadowHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_Shadow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0008A244 File Offset: 0x00088444
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00004BF2 File Offset: 0x00002DF2
		public unsafe Camera m_CurrentCameraRenderingSRP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_CurrentCameraRenderingSRP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x0008A274 File Offset: 0x00088474
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00004C11 File Offset: 0x00002E11
		public unsafe DirtyProps m_DirtyProps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_DirtyProps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryHD.NativeFieldInfoPtr_m_DirtyProps)) = value;
			}
		}

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr_m_Cookie;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr_m_Shadow;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentCameraRenderingSRP;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeFieldInfoPtr_m_DirtyProps;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_GetMaster_Protected_Virtual_VolumetricLightBeamAbstractBase_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_set_visible_Public_set_Void_Boolean_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_get_isCustomRenderPipelineSupported_Public_Static_get_Boolean_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_get_shouldUseGPUInstancedMaterial_Private_get_Boolean_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_VolumetricLightBeamHD_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateMesh_Public_Void_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_ComputeLocalMatrix_Private_Vector3_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_get_isNoiseEnabled_Private_get_Boolean_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_ComputeMaterialStaticProperties_Private_StaticPropertiesHD_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterial_Private_Boolean_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Single_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Vector4_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Color_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Matrix4x4_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_Texture_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialProp_Public_Void_Int32_InvalidTexture_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_MaterialChangeStart_Private_Void_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_MaterialChangeStop_Private_Void_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertyDirty_Public_Void_DirtyProps_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterialAndBounds_Private_Void_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMatricesPropertiesForGPUInstancingSRP_Private_Void_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_OnBeginCameraRenderingSRP_Private_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_OnWillRenderObject_Private_Void_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_OnWillCameraRenderThisBeam_Private_Void_Camera_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDirtyMaterialProperties_Private_Void_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterialPropertiesForCamera_Private_Void_Camera_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000874 RID: 2164
		[OriginalName("Assembly-CSharp.dll", "", "InvalidTexture")]
		public enum InvalidTexture
		{
			// Token: 0x04008ED1 RID: 36561
			Null,
			// Token: 0x04008ED2 RID: 36562
			NoDepth
		}
	}
}

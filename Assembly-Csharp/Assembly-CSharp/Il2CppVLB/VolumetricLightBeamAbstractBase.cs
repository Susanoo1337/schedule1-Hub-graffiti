using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200007A RID: 122
	public class VolumetricLightBeamAbstractBase : MonoBehaviour
	{
		// Token: 0x06000923 RID: 2339 RVA: 0x00098C38 File Offset: 0x00096E38
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricLightBeamAbstractBase()
		{
			Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricLightBeamAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr);
			VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, "ClassName");
			VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_pluginVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, "pluginVersion");
			VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_m_CachedLightSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, "m_CachedLightSpot");
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetBeamGeometry_Public_Abstract_Virtual_New_BeamGeometryAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664463);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664464);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_hasGeometry_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664465);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664466);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_IsScalable_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664467);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetLossyScale_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664468);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get__INTERNAL_pluginVersion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664469);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetLightSpotAttachedSlow_Public_Light_byref_AttachedLightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664470);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_lightSpotAttached_Public_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664471);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_InitLightSpotAttachedCached_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664472);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664473);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_DestroyBeam_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664474);
			VolumetricLightBeamAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr, 100664475);
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00098DA8 File Offset: 0x00096FA8
		[CallerCount(0)]
		public unsafe virtual BeamGeometryAbstractBase GetBeamGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetBeamGeometry_Public_Abstract_Virtual_New_BeamGeometryAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BeamGeometryAbstractBase>(intPtr3) : null;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00098DF4 File Offset: 0x00096FF4
		[CallerCount(0)]
		public unsafe virtual void SetBeamGeometryNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00098E30 File Offset: 0x00097030
		public unsafe bool hasGeometry
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74868, XrefRangeEnd = 74872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_hasGeometry_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00098E6C File Offset: 0x0009706C
		public unsafe Bounds bounds
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74872, XrefRangeEnd = 74877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00098EA8 File Offset: 0x000970A8
		[CallerCount(0)]
		public unsafe virtual bool IsScalable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_IsScalable_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00098EF0 File Offset: 0x000970F0
		[CallerCount(0)]
		public unsafe virtual Vector3 GetLossyScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetLossyScale_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00098F38 File Offset: 0x00097138
		public unsafe int _INTERNAL_pluginVersion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get__INTERNAL_pluginVersion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00098F74 File Offset: 0x00097174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74877, XrefRangeEnd = 74884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Light GetLightSpotAttachedSlow(out VolumetricLightBeamAbstractBase.AttachedLightType lightType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &lightType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_GetLightSpotAttachedSlow_Public_Light_byref_AttachedLightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00098FC0 File Offset: 0x000971C0
		public unsafe Light lightSpotAttached
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_get_lightSpotAttached_Public_get_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00099000 File Offset: 0x00097200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74895, RefRangeEnd = 74897, XrefRangeStart = 74884, XrefRangeEnd = 74895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitLightSpotAttachedCached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_InitLightSpotAttachedCached_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00099034 File Offset: 0x00097234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74897, XrefRangeEnd = 74902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00099068 File Offset: 0x00097268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyBeam()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr_DestroyBeam_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0009909C File Offset: 0x0009729C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 74903, RefRangeEnd = 74906, XrefRangeStart = 74902, XrefRangeEnd = 74903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricLightBeamAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamAbstractBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000063FD File Offset: 0x000045FD
		public VolumetricLightBeamAbstractBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x000990D8 File Offset: 0x000972D8
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x00006406 File Offset: 0x00004606
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x000990F8 File Offset: 0x000972F8
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00006418 File Offset: 0x00004618
		public unsafe int pluginVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_pluginVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_pluginVersion)) = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00099120 File Offset: 0x00097320
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00006433 File Offset: 0x00004633
		public unsafe Light m_CachedLightSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_m_CachedLightSpot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamAbstractBase.NativeFieldInfoPtr_m_CachedLightSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeFieldInfoPtr_pluginVersion;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedLightSpot;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_GetBeamGeometry_Public_Abstract_Virtual_New_BeamGeometryAbstractBase_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_SetBeamGeometryNull_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_get_hasGeometry_Public_get_Boolean_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_IsScalable_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_GetLossyScale_Public_Abstract_Virtual_New_Vector3_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_get__INTERNAL_pluginVersion_Public_get_Int32_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_GetLightSpotAttachedSlow_Public_Light_byref_AttachedLightType_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_get_lightSpotAttached_Public_get_Light_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_InitLightSpotAttachedCached_Protected_Void_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBeam_Protected_Void_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200089E RID: 2206
		[OriginalName("Assembly-CSharp.dll", "", "AttachedLightType")]
		public enum AttachedLightType
		{
			// Token: 0x04008FD2 RID: 36818
			NoLight,
			// Token: 0x04008FD3 RID: 36819
			OtherLight,
			// Token: 0x04008FD4 RID: 36820
			SpotLight
		}
	}
}

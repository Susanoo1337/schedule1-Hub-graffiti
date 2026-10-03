using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200003D RID: 61
	public class BeamGeometryAbstractBase : MonoBehaviour
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x00086CAC File Offset: 0x00084EAC
		// Note: this type is marked as 'beforefieldinit'.
		static BeamGeometryAbstractBase()
		{
			Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "BeamGeometryAbstractBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr);
			BeamGeometryAbstractBase.NativeFieldInfoPtr__meshRenderer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "<meshRenderer>k__BackingField");
			BeamGeometryAbstractBase.NativeFieldInfoPtr__meshFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "<meshFilter>k__BackingField");
			BeamGeometryAbstractBase.NativeFieldInfoPtr__coneMesh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "<coneMesh>k__BackingField");
			BeamGeometryAbstractBase.NativeFieldInfoPtr_m_ColorGradientMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "m_ColorGradientMatrix");
			BeamGeometryAbstractBase.NativeFieldInfoPtr_m_CustomMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, "m_CustomMaterial");
			BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663683);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshRenderer_Protected_set_Void_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663684);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663685);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshFilter_Protected_set_Void_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663686);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663687);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_set_coneMesh_Protected_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663688);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_GetMaster_Protected_Abstract_Virtual_New_VolumetricLightBeamAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663689);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663690);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663691);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyInvalidOwner_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663692);
			BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyBeamGeometryGameObject_Public_Static_Void_BeamGeometryAbstractBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663693);
			BeamGeometryAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr, 100663694);
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00086E30 File Offset: 0x00085030
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00086E70 File Offset: 0x00085070
		public unsafe MeshRenderer meshRenderer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshRenderer_Protected_set_Void_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00086EB4 File Offset: 0x000850B4
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00086EF4 File Offset: 0x000850F4
		public unsafe MeshFilter meshFilter
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_set_meshFilter_Protected_set_Void_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00086F38 File Offset: 0x00085138
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00086F78 File Offset: 0x00085178
		public unsafe Mesh coneMesh
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_set_coneMesh_Protected_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00086FBC File Offset: 0x000851BC
		[CallerCount(0)]
		public unsafe virtual VolumetricLightBeamAbstractBase GetMaster()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BeamGeometryAbstractBase.NativeMethodInfoPtr_GetMaster_Protected_Abstract_Virtual_New_VolumetricLightBeamAbstractBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr3) : null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00087008 File Offset: 0x00085208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68882, XrefRangeEnd = 68894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0008703C File Offset: 0x0008523C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68894, XrefRangeEnd = 68902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00087070 File Offset: 0x00085270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyInvalidOwner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyInvalidOwner_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000870A4 File Offset: 0x000852A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 68910, RefRangeEnd = 68912, XrefRangeStart = 68902, XrefRangeEnd = 68910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyBeamGeometryGameObject(BeamGeometryAbstractBase beamGeom)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(beamGeom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr_DestroyBeamGeometryGameObject_Public_Static_Void_BeamGeometryAbstractBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000870DC File Offset: 0x000852DC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BeamGeometryAbstractBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeamGeometryAbstractBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeamGeometryAbstractBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00004381 File Offset: 0x00002581
		public BeamGeometryAbstractBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00087118 File Offset: 0x00085318
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x0000438A File Offset: 0x0000258A
		public unsafe MeshRenderer _meshRenderer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshRenderer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshRenderer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00087148 File Offset: 0x00085348
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x000043A9 File Offset: 0x000025A9
		public unsafe MeshFilter _meshFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshFilter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__meshFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00087178 File Offset: 0x00085378
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x000043C8 File Offset: 0x000025C8
		public unsafe Mesh _coneMesh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__coneMesh_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr__coneMesh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x000871A8 File Offset: 0x000853A8
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x000043E7 File Offset: 0x000025E7
		public unsafe Matrix4x4 m_ColorGradientMatrix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_ColorGradientMatrix);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_ColorGradientMatrix)) = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x000871D0 File Offset: 0x000853D0
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00004402 File Offset: 0x00002602
		public unsafe Material m_CustomMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_CustomMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeamGeometryAbstractBase.NativeFieldInfoPtr_m_CustomMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr__meshRenderer_k__BackingField;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr__meshFilter_k__BackingField;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr__coneMesh_k__BackingField;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradientMatrix;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomMaterial;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_get_meshRenderer_Public_get_MeshRenderer_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_set_meshRenderer_Protected_set_Void_MeshRenderer_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_set_meshFilter_Protected_set_Void_MeshFilter_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_get_coneMesh_Public_get_Mesh_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_set_coneMesh_Protected_set_Void_Mesh_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_GetMaster_Protected_Abstract_Virtual_New_VolumetricLightBeamAbstractBase_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_DestroyInvalidOwner_Private_Void_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_DestroyBeamGeometryGameObject_Public_Static_Void_BeamGeometryAbstractBase_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

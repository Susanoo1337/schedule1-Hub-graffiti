using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2Cpp
{
	// Token: 0x02000039 RID: 57
	public class VolumetricFire : MonoBehaviour
	{
		// Token: 0x060003BB RID: 955 RVA: 0x000860B4 File Offset: 0x000842B4
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricFire()
		{
			Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VolumetricFire");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr);
			VolumetricFire.NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "mesh");
			VolumetricFire.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "material");
			VolumetricFire.NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "thickness");
			VolumetricFire.NativeFieldInfoPtr_spread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "spread");
			VolumetricFire.NativeFieldInfoPtr_billboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "billboard");
			VolumetricFire.NativeFieldInfoPtr_materialPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "materialPropertyBlock");
			VolumetricFire.NativeFieldInfoPtr_internalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "internalCount");
			VolumetricFire.NativeFieldInfoPtr_randomStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "randomStatic");
			VolumetricFire.NativeFieldInfoPtr_boundaryCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, "boundaryCollider");
			VolumetricFire.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663660);
			VolumetricFire.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663661);
			VolumetricFire.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663662);
			VolumetricFire.NativeMethodInfoPtr_IsVisible_Private_Static_Boolean_Camera_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663663);
			VolumetricFire.NativeMethodInfoPtr_RenderFlames_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663664);
			VolumetricFire.NativeMethodInfoPtr_SetupMaterialPropertyBlock_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663665);
			VolumetricFire.NativeMethodInfoPtr_CreateItem_Private_Void_Single_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663666);
			VolumetricFire.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr, 100663667);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00086238 File Offset: 0x00084438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68535, XrefRangeEnd = 68556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0008626C File Offset: 0x0008446C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68556, XrefRangeEnd = 68566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000862A0 File Offset: 0x000844A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68566, XrefRangeEnd = 68576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000862D4 File Offset: 0x000844D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68576, XrefRangeEnd = 68578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVisible(Camera camera, Bounds bounds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_IsVisible_Private_Static_Boolean_Camera_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00086324 File Offset: 0x00084524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68578, XrefRangeEnd = 68592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderFlames(ScriptableRenderContext context, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_RenderFlames_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00086374 File Offset: 0x00084574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68592, XrefRangeEnd = 68601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupMaterialPropertyBlock(float item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref item;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_SetupMaterialPropertyBlock_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000863B4 File Offset: 0x000845B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68627, RefRangeEnd = 68628, XrefRangeStart = 68601, XrefRangeEnd = 68627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateItem(float spacing, float item, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spacing;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref item;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr_CreateItem_Private_Void_Single_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00086414 File Offset: 0x00084614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68628, XrefRangeEnd = 68629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricFire() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricFire>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricFire.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00004224 File Offset: 0x00002424
		public VolumetricFire(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00086450 File Offset: 0x00084650
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x0000422D File Offset: 0x0000242D
		public unsafe Mesh mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00086480 File Offset: 0x00084680
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x0000424C File Offset: 0x0000244C
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000864B0 File Offset: 0x000846B0
		// (set) Token: 0x060003CA RID: 970 RVA: 0x0000426B File Offset: 0x0000246B
		public unsafe int thickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_thickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_thickness)) = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003CB RID: 971 RVA: 0x000864D8 File Offset: 0x000846D8
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00004286 File Offset: 0x00002486
		public unsafe float spread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_spread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_spread)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00086500 File Offset: 0x00084700
		// (set) Token: 0x060003CE RID: 974 RVA: 0x000042A1 File Offset: 0x000024A1
		public unsafe bool billboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_billboard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_billboard)) = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00086528 File Offset: 0x00084728
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x000042BC File Offset: 0x000024BC
		public unsafe MaterialPropertyBlock materialPropertyBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_materialPropertyBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_materialPropertyBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00086558 File Offset: 0x00084758
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x000042DB File Offset: 0x000024DB
		public unsafe int internalCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_internalCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_internalCount)) = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00086580 File Offset: 0x00084780
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x000042F6 File Offset: 0x000024F6
		public unsafe float randomStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_randomStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_randomStatic)) = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x000865A8 File Offset: 0x000847A8
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00004311 File Offset: 0x00002511
		public unsafe Collider boundaryCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_boundaryCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricFire.NativeFieldInfoPtr_boundaryCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_mesh;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_thickness;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_spread;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_billboard;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_materialPropertyBlock;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_internalCount;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_randomStatic;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_boundaryCollider;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_IsVisible_Private_Static_Boolean_Camera_Bounds_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_RenderFlames_Private_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_SetupMaterialPropertyBlock_Private_Void_Single_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_CreateItem_Private_Void_Single_Single_Camera_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

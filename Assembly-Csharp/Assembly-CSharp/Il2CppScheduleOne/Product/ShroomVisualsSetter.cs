using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200056B RID: 1387
	public class ShroomVisualsSetter : ProductVisualsSetter
	{
		// Token: 0x06007EBB RID: 32443 RVA: 0x0022F1F4 File Offset: 0x0022D3F4
		// Note: this type is marked as 'beforefieldinit'.
		static ShroomVisualsSetter()
		{
			Il2CppClassPointerStore<ShroomVisualsSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ShroomVisualsSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomVisualsSetter>.NativeClassPtr);
			ShroomVisualsSetter.NativeFieldInfoPtr__meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomVisualsSetter>.NativeClassPtr, "_meshes");
			ShroomVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomVisualsSetter>.NativeClassPtr, 100679662);
			ShroomVisualsSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomVisualsSetter>.NativeClassPtr, 100679663);
		}

		// Token: 0x06007EBC RID: 32444 RVA: 0x0022F260 File Offset: 0x0022D460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242367, XrefRangeEnd = 242401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyVisuals(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EBD RID: 32445 RVA: 0x0022F2B0 File Offset: 0x0022D4B0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomVisualsSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomVisualsSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomVisualsSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EBE RID: 32446 RVA: 0x0003C1A9 File Offset: 0x0003A3A9
		public ShroomVisualsSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002722 RID: 10018
		// (get) Token: 0x06007EBF RID: 32447 RVA: 0x0022F2EC File Offset: 0x0022D4EC
		// (set) Token: 0x06007EC0 RID: 32448 RVA: 0x0003C1B2 File Offset: 0x0003A3B2
		public unsafe Il2CppReferenceArray<ShroomVisualsSetter.MeshMaterialSettings> _meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomVisualsSetter.NativeFieldInfoPtr__meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ShroomVisualsSetter.MeshMaterialSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomVisualsSetter.NativeFieldInfoPtr__meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400568C RID: 22156
		private static readonly IntPtr NativeFieldInfoPtr__meshes;

		// Token: 0x0400568D RID: 22157
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0;

		// Token: 0x0400568E RID: 22158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE1 RID: 3041
		[OriginalName("Assembly-CSharp.dll", "", "EShroomMaterialType")]
		public enum EShroomMaterialType
		{
			// Token: 0x0400A016 RID: 40982
			Mushroom,
			// Token: 0x0400A017 RID: 40983
			Bulk
		}

		// Token: 0x02000BE2 RID: 3042
		[Serializable]
		public class MeshMaterialSettings : Il2CppSystem.Object
		{
			// Token: 0x0600EC7C RID: 60540 RVA: 0x0039529C File Offset: 0x0039349C
			// Note: this type is marked as 'beforefieldinit'.
			static MeshMaterialSettings()
			{
				Il2CppClassPointerStore<ShroomVisualsSetter.MeshMaterialSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShroomVisualsSetter>.NativeClassPtr, "MeshMaterialSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomVisualsSetter.MeshMaterialSettings>.NativeClassPtr);
				ShroomVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomVisualsSetter.MeshMaterialSettings>.NativeClassPtr, "Mesh");
				ShroomVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomVisualsSetter.MeshMaterialSettings>.NativeClassPtr, "Materials");
				ShroomVisualsSetter.MeshMaterialSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomVisualsSetter.MeshMaterialSettings>.NativeClassPtr, 100679664);
			}

			// Token: 0x0600EC7D RID: 60541 RVA: 0x00395304 File Offset: 0x00393504
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshMaterialSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomVisualsSetter.MeshMaterialSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomVisualsSetter.MeshMaterialSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC7E RID: 60542 RVA: 0x0006F90B File Offset: 0x0006DB0B
			public MeshMaterialSettings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047B3 RID: 18355
			// (get) Token: 0x0600EC7F RID: 60543 RVA: 0x00395340 File Offset: 0x00393540
			// (set) Token: 0x0600EC80 RID: 60544 RVA: 0x0006F914 File Offset: 0x0006DB14
			public unsafe MeshRenderer Mesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Mesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047B4 RID: 18356
			// (get) Token: 0x0600EC81 RID: 60545 RVA: 0x00395370 File Offset: 0x00393570
			// (set) Token: 0x0600EC82 RID: 60546 RVA: 0x0006F933 File Offset: 0x0006DB33
			public unsafe List<ShroomVisualsSetter.EShroomMaterialType> Materials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Materials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShroomVisualsSetter.EShroomMaterialType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Materials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A018 RID: 40984
			private static readonly IntPtr NativeFieldInfoPtr_Mesh;

			// Token: 0x0400A019 RID: 40985
			private static readonly IntPtr NativeFieldInfoPtr_Materials;

			// Token: 0x0400A01A RID: 40986
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

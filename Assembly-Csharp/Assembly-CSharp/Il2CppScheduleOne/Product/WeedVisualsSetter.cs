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
	// Token: 0x0200056C RID: 1388
	public class WeedVisualsSetter : ProductVisualsSetter
	{
		// Token: 0x06007EC1 RID: 32449 RVA: 0x0022F31C File Offset: 0x0022D51C
		// Note: this type is marked as 'beforefieldinit'.
		static WeedVisualsSetter()
		{
			Il2CppClassPointerStore<WeedVisualsSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "WeedVisualsSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedVisualsSetter>.NativeClassPtr);
			WeedVisualsSetter.NativeFieldInfoPtr_Meshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedVisualsSetter>.NativeClassPtr, "Meshes");
			WeedVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedVisualsSetter>.NativeClassPtr, 100679665);
			WeedVisualsSetter.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedVisualsSetter>.NativeClassPtr, 100679666);
			WeedVisualsSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedVisualsSetter>.NativeClassPtr, 100679667);
		}

		// Token: 0x06007EC2 RID: 32450 RVA: 0x0022F39C File Offset: 0x0022D59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242401, XrefRangeEnd = 242441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyVisuals(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EC3 RID: 32451 RVA: 0x0022F3EC File Offset: 0x0022D5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242441, XrefRangeEnd = 242459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedVisualsSetter.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EC4 RID: 32452 RVA: 0x0022F420 File Offset: 0x0022D620
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedVisualsSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedVisualsSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedVisualsSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EC5 RID: 32453 RVA: 0x0003C1D1 File Offset: 0x0003A3D1
		public WeedVisualsSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x06007EC6 RID: 32454 RVA: 0x0022F45C File Offset: 0x0022D65C
		// (set) Token: 0x06007EC7 RID: 32455 RVA: 0x0003C1DA File Offset: 0x0003A3DA
		public unsafe Il2CppReferenceArray<WeedVisualsSetter.MeshMaterialSettings> Meshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedVisualsSetter.NativeFieldInfoPtr_Meshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WeedVisualsSetter.MeshMaterialSettings>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedVisualsSetter.NativeFieldInfoPtr_Meshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400568F RID: 22159
		private static readonly IntPtr NativeFieldInfoPtr_Meshes;

		// Token: 0x04005690 RID: 22160
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0;

		// Token: 0x04005691 RID: 22161
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04005692 RID: 22162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BE3 RID: 3043
		[Serializable]
		public class MeshMaterialSettings : Il2CppSystem.Object
		{
			// Token: 0x0600EC83 RID: 60547 RVA: 0x003953A0 File Offset: 0x003935A0
			// Note: this type is marked as 'beforefieldinit'.
			static MeshMaterialSettings()
			{
				Il2CppClassPointerStore<WeedVisualsSetter.MeshMaterialSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WeedVisualsSetter>.NativeClassPtr, "MeshMaterialSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedVisualsSetter.MeshMaterialSettings>.NativeClassPtr);
				WeedVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedVisualsSetter.MeshMaterialSettings>.NativeClassPtr, "Mesh");
				WeedVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedVisualsSetter.MeshMaterialSettings>.NativeClassPtr, "Materials");
				WeedVisualsSetter.MeshMaterialSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedVisualsSetter.MeshMaterialSettings>.NativeClassPtr, 100679668);
			}

			// Token: 0x0600EC84 RID: 60548 RVA: 0x00395408 File Offset: 0x00393608
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshMaterialSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedVisualsSetter.MeshMaterialSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedVisualsSetter.MeshMaterialSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC85 RID: 60549 RVA: 0x0006F952 File Offset: 0x0006DB52
			public MeshMaterialSettings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047B5 RID: 18357
			// (get) Token: 0x0600EC86 RID: 60550 RVA: 0x00395444 File Offset: 0x00393644
			// (set) Token: 0x0600EC87 RID: 60551 RVA: 0x0006F95B File Offset: 0x0006DB5B
			public unsafe MeshRenderer Mesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Mesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047B6 RID: 18358
			// (get) Token: 0x0600EC88 RID: 60552 RVA: 0x00395474 File Offset: 0x00393674
			// (set) Token: 0x0600EC89 RID: 60553 RVA: 0x0006F97A File Offset: 0x0006DB7A
			public unsafe List<WeedAppearanceSettings.EWeedAppearanceType> Materials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Materials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WeedAppearanceSettings.EWeedAppearanceType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedVisualsSetter.MeshMaterialSettings.NativeFieldInfoPtr_Materials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A01B RID: 40987
			private static readonly IntPtr NativeFieldInfoPtr_Mesh;

			// Token: 0x0400A01C RID: 40988
			private static readonly IntPtr NativeFieldInfoPtr_Materials;

			// Token: 0x0400A01D RID: 40989
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

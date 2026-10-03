using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000565 RID: 1381
	[Serializable]
	public class ShroomDefinition : ProductDefinition
	{
		// Token: 0x06007E6D RID: 32365 RVA: 0x0022DE60 File Offset: 0x0022C060
		// Note: this type is marked as 'beforefieldinit'.
		static ShroomDefinition()
		{
			Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ShroomDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr);
			ShroomDefinition.NativeFieldInfoPtr__ShroomMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, "<ShroomMaterial>k__BackingField");
			ShroomDefinition.NativeFieldInfoPtr__BulkMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, "<BulkMaterial>k__BackingField");
			ShroomDefinition.NativeFieldInfoPtr__EyeballMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, "<EyeballMaterial>k__BackingField");
			ShroomDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, "<AppearanceSettings>k__BackingField");
			ShroomDefinition.NativeMethodInfoPtr_get_ShroomMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679610);
			ShroomDefinition.NativeMethodInfoPtr_set_ShroomMaterial_Private_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679611);
			ShroomDefinition.NativeMethodInfoPtr_get_BulkMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679612);
			ShroomDefinition.NativeMethodInfoPtr_set_BulkMaterial_Private_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679613);
			ShroomDefinition.NativeMethodInfoPtr_get_EyeballMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679614);
			ShroomDefinition.NativeMethodInfoPtr_set_EyeballMaterial_Private_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679615);
			ShroomDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_ShroomAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679616);
			ShroomDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_ShroomAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679617);
			ShroomDefinition.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679618);
			ShroomDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_ShroomAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679619);
			ShroomDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679620);
			ShroomDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679621);
			ShroomDefinition.NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679622);
			ShroomDefinition.NativeMethodInfoPtr_GenerateMaterials_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679623);
			ShroomDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_ShroomAppearanceSettings_List_1_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679624);
			ShroomDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, 100679625);
		}

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x06007E6E RID: 32366 RVA: 0x0022E020 File Offset: 0x0022C220
		// (set) Token: 0x06007E6F RID: 32367 RVA: 0x0022E060 File Offset: 0x0022C260
		public unsafe Material ShroomMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr_get_ShroomMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr_set_ShroomMaterial_Private_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x06007E70 RID: 32368 RVA: 0x0022E0A4 File Offset: 0x0022C2A4
		// (set) Token: 0x06007E71 RID: 32369 RVA: 0x0022E0E4 File Offset: 0x0022C2E4
		public unsafe Material BulkMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr_get_BulkMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr_set_BulkMaterial_Private_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x06007E72 RID: 32370 RVA: 0x0022E128 File Offset: 0x0022C328
		// (set) Token: 0x06007E73 RID: 32371 RVA: 0x0022E168 File Offset: 0x0022C368
		public unsafe Material EyeballMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr_get_EyeballMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr_set_EyeballMaterial_Private_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x06007E74 RID: 32372 RVA: 0x0022E1AC File Offset: 0x0022C3AC
		// (set) Token: 0x06007E75 RID: 32373 RVA: 0x0022E1EC File Offset: 0x0022C3EC
		public unsafe ShroomAppearanceSettings AppearanceSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr_get_AppearanceSettings_Public_get_ShroomAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShroomAppearanceSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_ShroomAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x0022E230 File Offset: 0x0022C430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomDefinition.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x0022E26C File Offset: 0x0022C46C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241913, RefRangeEnd = 241914, XrefRangeStart = 241899, XrefRangeEnd = 241913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(List<Effect> properties, List<EDrugType> drugTypes, ShroomAppearanceSettings _appearance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(drugTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_appearance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_ShroomAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E78 RID: 32376 RVA: 0x0022E2D4 File Offset: 0x0022C4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241914, XrefRangeEnd = 241918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x0022E32C File Offset: 0x0022C52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241918, XrefRangeEnd = 241934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ProductData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomDefinition.NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductData>(intPtr3) : null;
		}

		// Token: 0x06007E7A RID: 32378 RVA: 0x0022E378 File Offset: 0x0022C578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241934, XrefRangeEnd = 241938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GenerateAppearanceSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomDefinition.NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x0022E3B4 File Offset: 0x0022C5B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241975, RefRangeEnd = 241977, XrefRangeStart = 241938, XrefRangeEnd = 241975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr_GenerateMaterials_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x0022E3E8 File Offset: 0x0022C5E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242035, RefRangeEnd = 242037, XrefRangeStart = 241977, XrefRangeEnd = 242035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ShroomAppearanceSettings GetAppearanceSettings(List<Effect> properties)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_ShroomAppearanceSettings_List_1_Effect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShroomAppearanceSettings>(intPtr3) : null;
		}

		// Token: 0x06007E7D RID: 32381 RVA: 0x0022E42C File Offset: 0x0022C62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x0003C00C File Offset: 0x0003A20C
		public ShroomDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x06007E7F RID: 32383 RVA: 0x0022E468 File Offset: 0x0022C668
		// (set) Token: 0x06007E80 RID: 32384 RVA: 0x0003C015 File Offset: 0x0003A215
		public unsafe Material _ShroomMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomDefinition.NativeFieldInfoPtr__ShroomMaterial_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomDefinition.NativeFieldInfoPtr__ShroomMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x06007E81 RID: 32385 RVA: 0x0022E498 File Offset: 0x0022C698
		// (set) Token: 0x06007E82 RID: 32386 RVA: 0x0003C034 File Offset: 0x0003A234
		public unsafe Material _BulkMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomDefinition.NativeFieldInfoPtr__BulkMaterial_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomDefinition.NativeFieldInfoPtr__BulkMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x06007E83 RID: 32387 RVA: 0x0022E4C8 File Offset: 0x0022C6C8
		// (set) Token: 0x06007E84 RID: 32388 RVA: 0x0003C053 File Offset: 0x0003A253
		public unsafe Material _EyeballMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomDefinition.NativeFieldInfoPtr__EyeballMaterial_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomDefinition.NativeFieldInfoPtr__EyeballMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x06007E85 RID: 32389 RVA: 0x0022E4F8 File Offset: 0x0022C6F8
		// (set) Token: 0x06007E86 RID: 32390 RVA: 0x0003C072 File Offset: 0x0003A272
		public unsafe ShroomAppearanceSettings _AppearanceSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShroomAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomDefinition.NativeFieldInfoPtr__AppearanceSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005656 RID: 22102
		private static readonly IntPtr NativeFieldInfoPtr__ShroomMaterial_k__BackingField;

		// Token: 0x04005657 RID: 22103
		private static readonly IntPtr NativeFieldInfoPtr__BulkMaterial_k__BackingField;

		// Token: 0x04005658 RID: 22104
		private static readonly IntPtr NativeFieldInfoPtr__EyeballMaterial_k__BackingField;

		// Token: 0x04005659 RID: 22105
		private static readonly IntPtr NativeFieldInfoPtr__AppearanceSettings_k__BackingField;

		// Token: 0x0400565A RID: 22106
		private static readonly IntPtr NativeMethodInfoPtr_get_ShroomMaterial_Public_get_Material_0;

		// Token: 0x0400565B RID: 22107
		private static readonly IntPtr NativeMethodInfoPtr_set_ShroomMaterial_Private_set_Void_Material_0;

		// Token: 0x0400565C RID: 22108
		private static readonly IntPtr NativeMethodInfoPtr_get_BulkMaterial_Public_get_Material_0;

		// Token: 0x0400565D RID: 22109
		private static readonly IntPtr NativeMethodInfoPtr_set_BulkMaterial_Private_set_Void_Material_0;

		// Token: 0x0400565E RID: 22110
		private static readonly IntPtr NativeMethodInfoPtr_get_EyeballMaterial_Public_get_Material_0;

		// Token: 0x0400565F RID: 22111
		private static readonly IntPtr NativeMethodInfoPtr_set_EyeballMaterial_Private_set_Void_Material_0;

		// Token: 0x04005660 RID: 22112
		private static readonly IntPtr NativeMethodInfoPtr_get_AppearanceSettings_Public_get_ShroomAppearanceSettings_0;

		// Token: 0x04005661 RID: 22113
		private static readonly IntPtr NativeMethodInfoPtr_set_AppearanceSettings_Private_set_Void_ShroomAppearanceSettings_0;

		// Token: 0x04005662 RID: 22114
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0;

		// Token: 0x04005663 RID: 22115
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_List_1_Effect_List_1_EDrugType_ShroomAppearanceSettings_0;

		// Token: 0x04005664 RID: 22116
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005665 RID: 22117
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_ProductData_0;

		// Token: 0x04005666 RID: 22118
		private static readonly IntPtr NativeMethodInfoPtr_GenerateAppearanceSettings_Public_Virtual_Void_0;

		// Token: 0x04005667 RID: 22119
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMaterials_Private_Void_0;

		// Token: 0x04005668 RID: 22120
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearanceSettings_Public_Static_ShroomAppearanceSettings_List_1_Effect_0;

		// Token: 0x04005669 RID: 22121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BDD RID: 3037
		[ObfuscatedName("ScheduleOne.Product.ShroomDefinition+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EC52 RID: 60498 RVA: 0x00394B98 File Offset: 0x00392D98
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ShroomDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShroomDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomDefinition.__c>.NativeClassPtr);
				ShroomDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomDefinition.__c>.NativeClassPtr, "<>9");
				ShroomDefinition.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomDefinition.__c>.NativeClassPtr, "<>9__22_0");
				ShroomDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition.__c>.NativeClassPtr, 100679627);
				ShroomDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__22_0_Internal_Int32_Effect_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomDefinition.__c>.NativeClassPtr, 100679628);
			}

			// Token: 0x0600EC53 RID: 60499 RVA: 0x00394C14 File Offset: 0x00392E14
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC54 RID: 60500 RVA: 0x00394C50 File Offset: 0x00392E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetAppearanceSettings_b__22_0(Effect x, Effect y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomDefinition.__c.NativeMethodInfoPtr__GetAppearanceSettings_b__22_0_Internal_Int32_Effect_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC55 RID: 60501 RVA: 0x0006F78F File Offset: 0x0006D98F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047A4 RID: 18340
			// (get) Token: 0x0600EC56 RID: 60502 RVA: 0x00394CB0 File Offset: 0x00392EB0
			// (set) Token: 0x0600EC57 RID: 60503 RVA: 0x0006F798 File Offset: 0x0006D998
			public unsafe static ShroomDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShroomDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShroomDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShroomDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047A5 RID: 18341
			// (get) Token: 0x0600EC58 RID: 60504 RVA: 0x00394CD8 File Offset: 0x00392ED8
			// (set) Token: 0x0600EC59 RID: 60505 RVA: 0x0006F7AA File Offset: 0x0006D9AA
			public unsafe static Comparison<Effect> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShroomDefinition.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Effect>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShroomDefinition.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009FFE RID: 40958
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009FFF RID: 40959
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x0400A000 RID: 40960
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A001 RID: 40961
			private static readonly IntPtr NativeMethodInfoPtr__GetAppearanceSettings_b__22_0_Internal_Int32_Effect_Effect_0;
		}
	}
}

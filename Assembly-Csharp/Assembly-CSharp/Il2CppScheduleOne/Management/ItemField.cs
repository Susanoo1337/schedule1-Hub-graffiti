using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002E4 RID: 740
	public class ItemField : ConfigField
	{
		// Token: 0x06003AA8 RID: 15016 RVA: 0x001405F0 File Offset: 0x0013E7F0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemField()
		{
			Il2CppClassPointerStore<ItemField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ItemField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemField>.NativeClassPtr);
			ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "<SelectedItem>k__BackingField");
			ItemField.NativeFieldInfoPtr_CanSelectNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "CanSelectNone");
			ItemField.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "Options");
			ItemField.NativeFieldInfoPtr_onItemChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "onItemChanged");
			ItemField.NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100670804);
			ItemField.NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100670805);
			ItemField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100670806);
			ItemField.NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100670807);
			ItemField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100670808);
			ItemField.NativeMethodInfoPtr_GetData_Public_ItemFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100670809);
			ItemField.NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100670810);
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x06003AA9 RID: 15017 RVA: 0x001406FC File Offset: 0x0013E8FC
		// (set) Token: 0x06003AAA RID: 15018 RVA: 0x0014073C File Offset: 0x0013E93C
		public unsafe ItemDefinition SelectedItem
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AAB RID: 15019 RVA: 0x00140780 File Offset: 0x0013E980
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 149088, RefRangeEnd = 149096, XrefRangeStart = 149073, XrefRangeEnd = 149088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x001407CC File Offset: 0x0013E9CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149101, RefRangeEnd = 149103, XrefRangeStart = 149096, XrefRangeEnd = 149101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItem(ItemDefinition item, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x0014081C File Offset: 0x0013EA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149103, XrefRangeEnd = 149107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x00140864 File Offset: 0x0013EA64
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 149118, RefRangeEnd = 149126, XrefRangeStart = 149107, XrefRangeEnd = 149118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_GetData_Public_ItemFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr3) : null;
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x001408A4 File Offset: 0x0013EAA4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 149137, RefRangeEnd = 149149, XrefRangeStart = 149126, XrefRangeEnd = 149137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ItemFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x0001D664 File Offset: 0x0001B864
		public ItemField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x001408E8 File Offset: 0x0013EAE8
		// (set) Token: 0x06003AB2 RID: 15026 RVA: 0x0001D66D File Offset: 0x0001B86D
		public unsafe ItemDefinition _SelectedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06003AB3 RID: 15027 RVA: 0x00140918 File Offset: 0x0013EB18
		// (set) Token: 0x06003AB4 RID: 15028 RVA: 0x0001D68C File Offset: 0x0001B88C
		public unsafe bool CanSelectNone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_CanSelectNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_CanSelectNone)) = value;
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x00140940 File Offset: 0x0013EB40
		// (set) Token: 0x06003AB6 RID: 15030 RVA: 0x0001D6A7 File Offset: 0x0001B8A7
		public unsafe List<ItemDefinition> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x00140970 File Offset: 0x0013EB70
		// (set) Token: 0x06003AB8 RID: 15032 RVA: 0x0001D6C6 File Offset: 0x0001B8C6
		public unsafe UnityEvent<ItemDefinition> onItemChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_onItemChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_onItemChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400278C RID: 10124
		private static readonly IntPtr NativeFieldInfoPtr__SelectedItem_k__BackingField;

		// Token: 0x0400278D RID: 10125
		private static readonly IntPtr NativeFieldInfoPtr_CanSelectNone;

		// Token: 0x0400278E RID: 10126
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x0400278F RID: 10127
		private static readonly IntPtr NativeFieldInfoPtr_onItemChanged;

		// Token: 0x04002790 RID: 10128
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0;

		// Token: 0x04002791 RID: 10129
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0;

		// Token: 0x04002792 RID: 10130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x04002793 RID: 10131
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0;

		// Token: 0x04002794 RID: 10132
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x04002795 RID: 10133
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_ItemFieldData_0;

		// Token: 0x04002796 RID: 10134
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0;
	}
}

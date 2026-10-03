using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002E8 RID: 744
	public class ObjectListField : ConfigField
	{
		// Token: 0x06003AF5 RID: 15093 RVA: 0x00141734 File Offset: 0x0013F934
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListField()
		{
			Il2CppClassPointerStore<ObjectListField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ObjectListField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr);
			ObjectListField.NativeFieldInfoPtr_SelectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "SelectedObjects");
			ObjectListField.NativeFieldInfoPtr_MaxItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "MaxItems");
			ObjectListField.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "objectFilter");
			ObjectListField.NativeFieldInfoPtr_TypeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "TypeRequirements");
			ObjectListField.NativeFieldInfoPtr_onListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "onListChanged");
			ObjectListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100670839);
			ObjectListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100670840);
			ObjectListField.NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100670841);
			ObjectListField.NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100670842);
			ObjectListField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100670843);
			ObjectListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100670844);
			ObjectListField.NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100670845);
			ObjectListField.NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100670846);
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00141868 File Offset: 0x0013FA68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 149432, RefRangeEnd = 149436, XrefRangeStart = 149410, XrefRangeEnd = 149432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x001418B4 File Offset: 0x0013FAB4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 149496, RefRangeEnd = 149504, XrefRangeStart = 149436, XrefRangeEnd = 149496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetList(List<BuildableItem> list, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x00141904 File Offset: 0x0013FB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149504, XrefRangeEnd = 149521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x00141948 File Offset: 0x0013FB48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149534, RefRangeEnd = 149536, XrefRangeStart = 149521, XrefRangeEnd = 149534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x0014198C File Offset: 0x0013FB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149536, XrefRangeEnd = 149561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectedObjectDestroyed(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x001419D0 File Offset: 0x0013FBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149561, XrefRangeEnd = 149562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x00141A18 File Offset: 0x0013FC18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 149583, RefRangeEnd = 149587, XrefRangeStart = 149562, XrefRangeEnd = 149583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr3) : null;
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x00141A58 File Offset: 0x0013FC58
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 149616, RefRangeEnd = 149624, XrefRangeStart = 149587, XrefRangeEnd = 149616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ObjectListFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x0001D87F File Offset: 0x0001BA7F
		public ObjectListField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x06003AFF RID: 15103 RVA: 0x00141A9C File Offset: 0x0013FC9C
		// (set) Token: 0x06003B00 RID: 15104 RVA: 0x0001D888 File Offset: 0x0001BA88
		public unsafe List<BuildableItem> SelectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_SelectedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_SelectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x06003B01 RID: 15105 RVA: 0x00141ACC File Offset: 0x0013FCCC
		// (set) Token: 0x06003B02 RID: 15106 RVA: 0x0001D8A7 File Offset: 0x0001BAA7
		public unsafe int MaxItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_MaxItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_MaxItems)) = value;
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06003B03 RID: 15107 RVA: 0x00141AF4 File Offset: 0x0013FCF4
		// (set) Token: 0x06003B04 RID: 15108 RVA: 0x0001D8C2 File Offset: 0x0001BAC2
		public unsafe ObjectSelector.ObjectFilter objectFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_objectFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06003B05 RID: 15109 RVA: 0x00141B24 File Offset: 0x0013FD24
		// (set) Token: 0x06003B06 RID: 15110 RVA: 0x0001D8E1 File Offset: 0x0001BAE1
		public unsafe List<Type> TypeRequirements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_TypeRequirements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_TypeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06003B07 RID: 15111 RVA: 0x00141B54 File Offset: 0x0013FD54
		// (set) Token: 0x06003B08 RID: 15112 RVA: 0x0001D900 File Offset: 0x0001BB00
		public unsafe UnityEvent<List<BuildableItem>> onListChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_onListChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<List<BuildableItem>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_onListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027C0 RID: 10176
		private static readonly IntPtr NativeFieldInfoPtr_SelectedObjects;

		// Token: 0x040027C1 RID: 10177
		private static readonly IntPtr NativeFieldInfoPtr_MaxItems;

		// Token: 0x040027C2 RID: 10178
		private static readonly IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x040027C3 RID: 10179
		private static readonly IntPtr NativeFieldInfoPtr_TypeRequirements;

		// Token: 0x040027C4 RID: 10180
		private static readonly IntPtr NativeFieldInfoPtr_onListChanged;

		// Token: 0x040027C5 RID: 10181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040027C6 RID: 10182
		private static readonly IntPtr NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0;

		// Token: 0x040027C7 RID: 10183
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0;

		// Token: 0x040027C8 RID: 10184
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0;

		// Token: 0x040027C9 RID: 10185
		private static readonly IntPtr NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0;

		// Token: 0x040027CA RID: 10186
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040027CB RID: 10187
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0;

		// Token: 0x040027CC RID: 10188
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0;
	}
}

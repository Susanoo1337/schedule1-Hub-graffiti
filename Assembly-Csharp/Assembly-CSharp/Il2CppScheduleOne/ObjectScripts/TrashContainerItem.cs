using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.Trash;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005C0 RID: 1472
	public class TrashContainerItem : GridItem
	{
		// Token: 0x06008EE3 RID: 36579 RVA: 0x0026BC18 File Offset: 0x00269E18
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerItem()
		{
			Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "TrashContainerItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr);
			TrashContainerItem.NativeFieldInfoPtr_MAX_VERTICAL_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "MAX_VERTICAL_OFFSET");
			TrashContainerItem.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "Container");
			TrashContainerItem.NativeFieldInfoPtr_Flies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "Flies");
			TrashContainerItem.NativeFieldInfoPtr_TrashAddedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "TrashAddedSound");
			TrashContainerItem.NativeFieldInfoPtr_PickupAreaProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "PickupAreaProjector");
			TrashContainerItem.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "accessPoints");
			TrashContainerItem.NativeFieldInfoPtr_UsableByCleaners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "UsableByCleaners");
			TrashContainerItem.NativeFieldInfoPtr_PickupSquareWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "PickupSquareWidth");
			TrashContainerItem.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<InputSlots>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<OutputSlots>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<Selectable>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			TrashContainerItem.NativeFieldInfoPtr_TrashItemsInRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "TrashItemsInRadius");
			TrashContainerItem.NativeFieldInfoPtr_TrashBagsInRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "TrashBagsInRadius");
			TrashContainerItem.NativeFieldInfoPtr_calculatedPickupRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "calculatedPickupRadius");
			TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted");
			TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.TrashContainerItemAssembly-CSharp.dll_Excuted");
			TrashContainerItem.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681831);
			TrashContainerItem.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681832);
			TrashContainerItem.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681833);
			TrashContainerItem.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681834);
			TrashContainerItem.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681835);
			TrashContainerItem.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681836);
			TrashContainerItem.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681837);
			TrashContainerItem.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681838);
			TrashContainerItem.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681839);
			TrashContainerItem.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681840);
			TrashContainerItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681841);
			TrashContainerItem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681842);
			TrashContainerItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681843);
			TrashContainerItem.NativeMethodInfoPtr_TrashLevelChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681844);
			TrashContainerItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681845);
			TrashContainerItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681846);
			TrashContainerItem.NativeMethodInfoPtr_TrashAdded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681847);
			TrashContainerItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681848);
			TrashContainerItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681849);
			TrashContainerItem.NativeMethodInfoPtr_CheckTrashItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681850);
			TrashContainerItem.NativeMethodInfoPtr_AddTrashToRadius_Private_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681851);
			TrashContainerItem.NativeMethodInfoPtr_AddTrashBagToRadius_Private_Void_TrashBag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681852);
			TrashContainerItem.NativeMethodInfoPtr_RemoveTrashItemFromRadius_Private_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681853);
			TrashContainerItem.NativeMethodInfoPtr_RemoveTrashBagFromRadius_Private_Void_TrashBag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681854);
			TrashContainerItem.NativeMethodInfoPtr_IsTrashValid_Private_Boolean_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681855);
			TrashContainerItem.NativeMethodInfoPtr_IsPointInPickupZone_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681856);
			TrashContainerItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681857);
			TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681858);
			TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681859);
			TrashContainerItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681860);
			TrashContainerItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr, 100681861);
		}

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x06008EE4 RID: 36580 RVA: 0x0026C008 File Offset: 0x0026A208
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x06008EE5 RID: 36581 RVA: 0x0026C040 File Offset: 0x0026A240
		// (set) Token: 0x06008EE6 RID: 36582 RVA: 0x0026C080 File Offset: 0x0026A280
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x06008EE7 RID: 36583 RVA: 0x0026C0C4 File Offset: 0x0026A2C4
		// (set) Token: 0x06008EE8 RID: 36584 RVA: 0x0026C104 File Offset: 0x0026A304
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262830, XrefRangeEnd = 262831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x06008EE9 RID: 36585 RVA: 0x0026C148 File Offset: 0x0026A348
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 44652, RefRangeEnd = 44654, XrefRangeStart = 44652, XrefRangeEnd = 44654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x06008EEA RID: 36586 RVA: 0x0026C188 File Offset: 0x0026A388
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x06008EEB RID: 36587 RVA: 0x0026C1C8 File Offset: 0x0026A3C8
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x06008EEC RID: 36588 RVA: 0x0026C204 File Offset: 0x0026A404
		// (set) Token: 0x06008EED RID: 36589 RVA: 0x0026C240 File Offset: 0x0026A440
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008EEE RID: 36590 RVA: 0x0026C280 File Offset: 0x0026A480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262831, XrefRangeEnd = 262837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x0026C2BC File Offset: 0x0026A4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262837, XrefRangeEnd = 262855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF0 RID: 36592 RVA: 0x0026C2F8 File Offset: 0x0026A4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262855, XrefRangeEnd = 262860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF1 RID: 36593 RVA: 0x0026C388 File Offset: 0x0026A588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262860, XrefRangeEnd = 262863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrashLevelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_TrashLevelChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF2 RID: 36594 RVA: 0x0026C3BC File Offset: 0x0026A5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262863, XrefRangeEnd = 262869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008EF3 RID: 36595 RVA: 0x0026C420 File Offset: 0x0026A620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262869, XrefRangeEnd = 262874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr3) : null;
		}

		// Token: 0x06008EF4 RID: 36596 RVA: 0x0026C46C File Offset: 0x0026A66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262874, XrefRangeEnd = 262885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrashAdded(string trashID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_TrashAdded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF5 RID: 36597 RVA: 0x0026C4B0 File Offset: 0x0026A6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262885, XrefRangeEnd = 262888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF6 RID: 36598 RVA: 0x0026C4FC File Offset: 0x0026A6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262888, XrefRangeEnd = 262891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF7 RID: 36599 RVA: 0x0026C538 File Offset: 0x0026A738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262891, XrefRangeEnd = 262926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTrashItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_CheckTrashItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF8 RID: 36600 RVA: 0x0026C56C File Offset: 0x0026A76C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262950, RefRangeEnd = 262951, XrefRangeStart = 262926, XrefRangeEnd = 262950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrashToRadius(TrashItem trashItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_AddTrashToRadius_Private_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EF9 RID: 36601 RVA: 0x0026C5B0 File Offset: 0x0026A7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262972, RefRangeEnd = 262973, XrefRangeStart = 262951, XrefRangeEnd = 262972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrashBagToRadius(TrashBag trashBag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashBag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_AddTrashBagToRadius_Private_Void_TrashBag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EFA RID: 36602 RVA: 0x0026C5F4 File Offset: 0x0026A7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262998, RefRangeEnd = 262999, XrefRangeStart = 262973, XrefRangeEnd = 262998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrashItemFromRadius(TrashItem trashItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_RemoveTrashItemFromRadius_Private_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EFB RID: 36603 RVA: 0x0026C638 File Offset: 0x0026A838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262999, XrefRangeEnd = 263018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrashBagFromRadius(TrashBag trashBag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashBag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_RemoveTrashBagFromRadius_Private_Void_TrashBag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EFC RID: 36604 RVA: 0x0026C67C File Offset: 0x0026A87C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263028, RefRangeEnd = 263030, XrefRangeStart = 263018, XrefRangeEnd = 263028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTrashValid(TrashItem trashItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_IsTrashValid_Private_Boolean_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008EFD RID: 36605 RVA: 0x0026C6CC File Offset: 0x0026A8CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263036, RefRangeEnd = 263038, XrefRangeStart = 263030, XrefRangeEnd = 263036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInPickupZone(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr_IsPointInPickupZone_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008EFE RID: 36606 RVA: 0x0026C718 File Offset: 0x0026A918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263038, XrefRangeEnd = 263065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008EFF RID: 36607 RVA: 0x0026C754 File Offset: 0x0026A954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263065, XrefRangeEnd = 263066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x0026C790 File Offset: 0x0026A990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263066, XrefRangeEnd = 263067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F01 RID: 36609 RVA: 0x0026C7CC File Offset: 0x0026A9CC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F02 RID: 36610 RVA: 0x0026C808 File Offset: 0x0026AA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263067, XrefRangeEnd = 263072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F03 RID: 36611 RVA: 0x0004382D File Offset: 0x00041A2D
		public TrashContainerItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x06008F04 RID: 36612 RVA: 0x0026C844 File Offset: 0x0026AA44
		// (set) Token: 0x06008F05 RID: 36613 RVA: 0x00043836 File Offset: 0x00041A36
		public unsafe static float MAX_VERTICAL_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashContainerItem.NativeFieldInfoPtr_MAX_VERTICAL_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashContainerItem.NativeFieldInfoPtr_MAX_VERTICAL_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x06008F06 RID: 36614 RVA: 0x0026C860 File Offset: 0x0026AA60
		// (set) Token: 0x06008F07 RID: 36615 RVA: 0x00043844 File Offset: 0x00041A44
		public unsafe TrashContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x06008F08 RID: 36616 RVA: 0x0026C890 File Offset: 0x0026AA90
		// (set) Token: 0x06008F09 RID: 36617 RVA: 0x00043863 File Offset: 0x00041A63
		public unsafe ParticleSystem Flies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Flies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_Flies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x06008F0A RID: 36618 RVA: 0x0026C8C0 File Offset: 0x0026AAC0
		// (set) Token: 0x06008F0B RID: 36619 RVA: 0x00043882 File Offset: 0x00041A82
		public unsafe AudioSourceController TrashAddedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashAddedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashAddedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x06008F0C RID: 36620 RVA: 0x0026C8F0 File Offset: 0x0026AAF0
		// (set) Token: 0x06008F0D RID: 36621 RVA: 0x000438A1 File Offset: 0x00041AA1
		public unsafe DecalProjector PickupAreaProjector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupAreaProjector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupAreaProjector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x06008F0E RID: 36622 RVA: 0x0026C920 File Offset: 0x0026AB20
		// (set) Token: 0x06008F0F RID: 36623 RVA: 0x000438C0 File Offset: 0x00041AC0
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C50 RID: 11344
		// (get) Token: 0x06008F10 RID: 36624 RVA: 0x0026C950 File Offset: 0x0026AB50
		// (set) Token: 0x06008F11 RID: 36625 RVA: 0x000438DF File Offset: 0x00041ADF
		public unsafe bool UsableByCleaners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_UsableByCleaners);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_UsableByCleaners)) = value;
			}
		}

		// Token: 0x17002C51 RID: 11345
		// (get) Token: 0x06008F12 RID: 36626 RVA: 0x0026C978 File Offset: 0x0026AB78
		// (set) Token: 0x06008F13 RID: 36627 RVA: 0x000438FA File Offset: 0x00041AFA
		public unsafe float PickupSquareWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupSquareWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_PickupSquareWidth)) = value;
			}
		}

		// Token: 0x17002C52 RID: 11346
		// (get) Token: 0x06008F14 RID: 36628 RVA: 0x0026C9A0 File Offset: 0x0026ABA0
		// (set) Token: 0x06008F15 RID: 36629 RVA: 0x00043915 File Offset: 0x00041B15
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x06008F16 RID: 36630 RVA: 0x0026C9D0 File Offset: 0x0026ABD0
		// (set) Token: 0x06008F17 RID: 36631 RVA: 0x00043934 File Offset: 0x00041B34
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x06008F18 RID: 36632 RVA: 0x0026CA00 File Offset: 0x0026AC00
		// (set) Token: 0x06008F19 RID: 36633 RVA: 0x00043953 File Offset: 0x00041B53
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x06008F1A RID: 36634 RVA: 0x0026CA28 File Offset: 0x0026AC28
		// (set) Token: 0x06008F1B RID: 36635 RVA: 0x0004396E File Offset: 0x00041B6E
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x06008F1C RID: 36636 RVA: 0x0026CA50 File Offset: 0x0026AC50
		// (set) Token: 0x06008F1D RID: 36637 RVA: 0x00043989 File Offset: 0x00041B89
		public unsafe List<TrashItem> TrashItemsInRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashItemsInRadius);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashItemsInRadius), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x06008F1E RID: 36638 RVA: 0x0026CA80 File Offset: 0x0026AC80
		// (set) Token: 0x06008F1F RID: 36639 RVA: 0x000439A8 File Offset: 0x00041BA8
		public unsafe List<TrashBag> TrashBagsInRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashBagsInRadius);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashBag>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_TrashBagsInRadius), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x06008F20 RID: 36640 RVA: 0x0026CAB0 File Offset: 0x0026ACB0
		// (set) Token: 0x06008F21 RID: 36641 RVA: 0x000439C7 File Offset: 0x00041BC7
		public unsafe float calculatedPickupRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_calculatedPickupRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_calculatedPickupRadius)) = value;
			}
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x06008F22 RID: 36642 RVA: 0x0026CAD8 File Offset: 0x0026ACD8
		// (set) Token: 0x06008F23 RID: 36643 RVA: 0x000439E2 File Offset: 0x00041BE2
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x06008F24 RID: 36644 RVA: 0x0026CB00 File Offset: 0x0026AD00
		// (set) Token: 0x06008F25 RID: 36645 RVA: 0x000439FD File Offset: 0x00041BFD
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006218 RID: 25112
		private static readonly IntPtr NativeFieldInfoPtr_MAX_VERTICAL_OFFSET;

		// Token: 0x04006219 RID: 25113
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400621A RID: 25114
		private static readonly IntPtr NativeFieldInfoPtr_Flies;

		// Token: 0x0400621B RID: 25115
		private static readonly IntPtr NativeFieldInfoPtr_TrashAddedSound;

		// Token: 0x0400621C RID: 25116
		private static readonly IntPtr NativeFieldInfoPtr_PickupAreaProjector;

		// Token: 0x0400621D RID: 25117
		private static readonly IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x0400621E RID: 25118
		private static readonly IntPtr NativeFieldInfoPtr_UsableByCleaners;

		// Token: 0x0400621F RID: 25119
		private static readonly IntPtr NativeFieldInfoPtr_PickupSquareWidth;

		// Token: 0x04006220 RID: 25120
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x04006221 RID: 25121
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x04006222 RID: 25122
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x04006223 RID: 25123
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x04006224 RID: 25124
		private static readonly IntPtr NativeFieldInfoPtr_TrashItemsInRadius;

		// Token: 0x04006225 RID: 25125
		private static readonly IntPtr NativeFieldInfoPtr_TrashBagsInRadius;

		// Token: 0x04006226 RID: 25126
		private static readonly IntPtr NativeFieldInfoPtr_calculatedPickupRadius;

		// Token: 0x04006227 RID: 25127
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006228 RID: 25128
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006229 RID: 25129
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400622A RID: 25130
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x0400622B RID: 25131
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400622C RID: 25132
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x0400622D RID: 25133
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x0400622E RID: 25134
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400622F RID: 25135
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04006230 RID: 25136
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006231 RID: 25137
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006232 RID: 25138
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x04006233 RID: 25139
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006234 RID: 25140
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04006235 RID: 25141
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x04006236 RID: 25142
		private static readonly IntPtr NativeMethodInfoPtr_TrashLevelChanged_Private_Void_0;

		// Token: 0x04006237 RID: 25143
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04006238 RID: 25144
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x04006239 RID: 25145
		private static readonly IntPtr NativeMethodInfoPtr_TrashAdded_Private_Void_String_0;

		// Token: 0x0400623A RID: 25146
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Virtual_Void_Color_0;

		// Token: 0x0400623B RID: 25147
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Virtual_Void_0;

		// Token: 0x0400623C RID: 25148
		private static readonly IntPtr NativeMethodInfoPtr_CheckTrashItems_Private_Void_0;

		// Token: 0x0400623D RID: 25149
		private static readonly IntPtr NativeMethodInfoPtr_AddTrashToRadius_Private_Void_TrashItem_0;

		// Token: 0x0400623E RID: 25150
		private static readonly IntPtr NativeMethodInfoPtr_AddTrashBagToRadius_Private_Void_TrashBag_0;

		// Token: 0x0400623F RID: 25151
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrashItemFromRadius_Private_Void_TrashItem_0;

		// Token: 0x04006240 RID: 25152
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrashBagFromRadius_Private_Void_TrashBag_0;

		// Token: 0x04006241 RID: 25153
		private static readonly IntPtr NativeMethodInfoPtr_IsTrashValid_Private_Boolean_TrashItem_0;

		// Token: 0x04006242 RID: 25154
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInPickupZone_Public_Boolean_Vector3_0;

		// Token: 0x04006243 RID: 25155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006244 RID: 25156
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006245 RID: 25157
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006246 RID: 25158
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006247 RID: 25159
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}

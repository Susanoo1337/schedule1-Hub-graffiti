using System;
using Il2CppEPOOutline;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200041D RID: 1053
	public class LoadingDock : MonoBehaviour
	{
		// Token: 0x06005CED RID: 23789 RVA: 0x001BBB0C File Offset: 0x001B9D0C
		// Note: this type is marked as 'beforefieldinit'.
		static LoadingDock()
		{
			Il2CppClassPointerStore<LoadingDock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "LoadingDock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr);
			LoadingDock.NativeFieldInfoPtr__DynamicOccupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<DynamicOccupant>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__StaticOccupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<StaticOccupant>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<GUID>k__BackingField");
			LoadingDock.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "BakedGUID");
			LoadingDock.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<InputSlots>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<OutputSlots>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<Selectable>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			LoadingDock.NativeFieldInfoPtr__IsDestroyed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "<IsDestroyed>k__BackingField");
			LoadingDock.NativeFieldInfoPtr_ParentProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "ParentProperty");
			LoadingDock.NativeFieldInfoPtr_VehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "VehicleDetector");
			LoadingDock.NativeFieldInfoPtr_Parking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "Parking");
			LoadingDock.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "uiPoint");
			LoadingDock.NativeFieldInfoPtr_accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "accessPoints");
			LoadingDock.NativeFieldInfoPtr_OutlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "OutlineRenderers");
			LoadingDock.NativeFieldInfoPtr_OutlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, "OutlineEffect");
			LoadingDock.NativeMethodInfoPtr_get_DynamicOccupant_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675438);
			LoadingDock.NativeMethodInfoPtr_set_DynamicOccupant_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675439);
			LoadingDock.NativeMethodInfoPtr_get_StaticOccupant_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675440);
			LoadingDock.NativeMethodInfoPtr_set_StaticOccupant_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675441);
			LoadingDock.NativeMethodInfoPtr_get_IsInUse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675442);
			LoadingDock.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675443);
			LoadingDock.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675444);
			LoadingDock.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675445);
			LoadingDock.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675446);
			LoadingDock.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675447);
			LoadingDock.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675448);
			LoadingDock.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675449);
			LoadingDock.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675450);
			LoadingDock.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675451);
			LoadingDock.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675452);
			LoadingDock.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675453);
			LoadingDock.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675454);
			LoadingDock.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675455);
			LoadingDock.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675456);
			LoadingDock.NativeMethodInfoPtr_set_IsDestroyed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675457);
			LoadingDock.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675458);
			LoadingDock.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675459);
			LoadingDock.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675460);
			LoadingDock.NativeMethodInfoPtr_RefreshOccupant_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675461);
			LoadingDock.NativeMethodInfoPtr_SetOccupant_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675462);
			LoadingDock.NativeMethodInfoPtr_SetStaticOccupant_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675463);
			LoadingDock.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675464);
			LoadingDock.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675465);
			LoadingDock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr, 100675466);
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06005CEE RID: 23790 RVA: 0x001BBEC0 File Offset: 0x001BA0C0
		// (set) Token: 0x06005CEF RID: 23791 RVA: 0x001BBF00 File Offset: 0x001BA100
		public unsafe LandVehicle DynamicOccupant
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_DynamicOccupant_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_DynamicOccupant_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x06005CF0 RID: 23792 RVA: 0x001BBF44 File Offset: 0x001BA144
		// (set) Token: 0x06005CF1 RID: 23793 RVA: 0x001BBF84 File Offset: 0x001BA184
		public unsafe LandVehicle StaticOccupant
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_StaticOccupant_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_StaticOccupant_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x06005CF2 RID: 23794 RVA: 0x001BBFC8 File Offset: 0x001BA1C8
		public unsafe bool IsInUse
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199245, XrefRangeEnd = 199249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_IsInUse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x06005CF3 RID: 23795 RVA: 0x001BC004 File Offset: 0x001BA204
		// (set) Token: 0x06005CF4 RID: 23796 RVA: 0x001BC040 File Offset: 0x001BA240
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x001BC080 File Offset: 0x001BA280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199249, XrefRangeEnd = 199252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06005CF6 RID: 23798 RVA: 0x001BC0B4 File Offset: 0x001BA2B4
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199252, XrefRangeEnd = 199259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x06005CF7 RID: 23799 RVA: 0x001BC0EC File Offset: 0x001BA2EC
		// (set) Token: 0x06005CF8 RID: 23800 RVA: 0x001BC12C File Offset: 0x001BA32C
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x06005CF9 RID: 23801 RVA: 0x001BC170 File Offset: 0x001BA370
		// (set) Token: 0x06005CFA RID: 23802 RVA: 0x001BC1B0 File Offset: 0x001BA3B0
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x06005CFB RID: 23803 RVA: 0x001BC1F4 File Offset: 0x001BA3F4
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41608, RefRangeEnd = 41609, XrefRangeStart = 41608, XrefRangeEnd = 41609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x06005CFC RID: 23804 RVA: 0x001BC234 File Offset: 0x001BA434
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06005CFD RID: 23805 RVA: 0x001BC274 File Offset: 0x001BA474
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06005CFE RID: 23806 RVA: 0x001BC2B0 File Offset: 0x001BA4B0
		// (set) Token: 0x06005CFF RID: 23807 RVA: 0x001BC2EC File Offset: 0x001BA4EC
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x06005D00 RID: 23808 RVA: 0x001BC32C File Offset: 0x001BA52C
		// (set) Token: 0x06005D01 RID: 23809 RVA: 0x001BC368 File Offset: 0x001BA568
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_set_IsDestroyed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005D02 RID: 23810 RVA: 0x001BC3A8 File Offset: 0x001BA5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199259, XrefRangeEnd = 199264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D03 RID: 23811 RVA: 0x001BC3DC File Offset: 0x001BA5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199264, XrefRangeEnd = 199268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D04 RID: 23812 RVA: 0x001BC410 File Offset: 0x001BA610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199268, XrefRangeEnd = 199272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D05 RID: 23813 RVA: 0x001BC450 File Offset: 0x001BA650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199272, XrefRangeEnd = 199305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshOccupant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_RefreshOccupant_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x001BC484 File Offset: 0x001BA684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199346, RefRangeEnd = 199347, XrefRangeStart = 199305, XrefRangeEnd = 199346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(LandVehicle occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occupant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_SetOccupant_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x001BC4C8 File Offset: 0x001BA6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStaticOccupant(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr_SetStaticOccupant_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x001BC50C File Offset: 0x001BA70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199347, XrefRangeEnd = 199388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x001BC558 File Offset: 0x001BA758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199388, XrefRangeEnd = 199393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingDock.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x001BC594 File Offset: 0x001BA794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199393, XrefRangeEnd = 199409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadingDock() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingDock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingDock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x0002C058 File Offset: 0x0002A258
		public LoadingDock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06005D0C RID: 23820 RVA: 0x001BC5D0 File Offset: 0x001BA7D0
		// (set) Token: 0x06005D0D RID: 23821 RVA: 0x0002C061 File Offset: 0x0002A261
		public unsafe LandVehicle _DynamicOccupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__DynamicOccupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__DynamicOccupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06005D0E RID: 23822 RVA: 0x001BC600 File Offset: 0x001BA800
		// (set) Token: 0x06005D0F RID: 23823 RVA: 0x0002C080 File Offset: 0x0002A280
		public unsafe LandVehicle _StaticOccupant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__StaticOccupant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__StaticOccupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06005D10 RID: 23824 RVA: 0x001BC630 File Offset: 0x001BA830
		// (set) Token: 0x06005D11 RID: 23825 RVA: 0x0002C09F File Offset: 0x0002A29F
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06005D12 RID: 23826 RVA: 0x001BC658 File Offset: 0x001BA858
		// (set) Token: 0x06005D13 RID: 23827 RVA: 0x0002C0BA File Offset: 0x0002A2BA
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06005D14 RID: 23828 RVA: 0x001BC680 File Offset: 0x001BA880
		// (set) Token: 0x06005D15 RID: 23829 RVA: 0x0002C0D9 File Offset: 0x0002A2D9
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06005D16 RID: 23830 RVA: 0x001BC6B0 File Offset: 0x001BA8B0
		// (set) Token: 0x06005D17 RID: 23831 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06005D18 RID: 23832 RVA: 0x001BC6E0 File Offset: 0x001BA8E0
		// (set) Token: 0x06005D19 RID: 23833 RVA: 0x0002C117 File Offset: 0x0002A317
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06005D1A RID: 23834 RVA: 0x001BC708 File Offset: 0x001BA908
		// (set) Token: 0x06005D1B RID: 23835 RVA: 0x0002C132 File Offset: 0x0002A332
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06005D1C RID: 23836 RVA: 0x001BC730 File Offset: 0x001BA930
		// (set) Token: 0x06005D1D RID: 23837 RVA: 0x0002C14D File Offset: 0x0002A34D
		public unsafe bool _IsDestroyed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsDestroyed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr__IsDestroyed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06005D1E RID: 23838 RVA: 0x001BC758 File Offset: 0x001BA958
		// (set) Token: 0x06005D1F RID: 23839 RVA: 0x0002C168 File Offset: 0x0002A368
		public unsafe Property ParentProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_ParentProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_ParentProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06005D20 RID: 23840 RVA: 0x001BC788 File Offset: 0x001BA988
		// (set) Token: 0x06005D21 RID: 23841 RVA: 0x0002C187 File Offset: 0x0002A387
		public unsafe VehicleDetector VehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_VehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_VehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06005D22 RID: 23842 RVA: 0x001BC7B8 File Offset: 0x001BA9B8
		// (set) Token: 0x06005D23 RID: 23843 RVA: 0x0002C1A6 File Offset: 0x0002A3A6
		public unsafe ParkingLot Parking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_Parking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_Parking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x06005D24 RID: 23844 RVA: 0x001BC7E8 File Offset: 0x001BA9E8
		// (set) Token: 0x06005D25 RID: 23845 RVA: 0x0002C1C5 File Offset: 0x0002A3C5
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06005D26 RID: 23846 RVA: 0x001BC818 File Offset: 0x001BAA18
		// (set) Token: 0x06005D27 RID: 23847 RVA: 0x0002C1E4 File Offset: 0x0002A3E4
		public unsafe Il2CppReferenceArray<Transform> accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x06005D28 RID: 23848 RVA: 0x001BC848 File Offset: 0x001BAA48
		// (set) Token: 0x06005D29 RID: 23849 RVA: 0x0002C203 File Offset: 0x0002A403
		public unsafe Il2CppReferenceArray<GameObject> OutlineRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06005D2A RID: 23850 RVA: 0x001BC878 File Offset: 0x001BAA78
		// (set) Token: 0x06005D2B RID: 23851 RVA: 0x0002C222 File Offset: 0x0002A422
		public unsafe Outlinable OutlineEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingDock.NativeFieldInfoPtr_OutlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FC3 RID: 16323
		private static readonly IntPtr NativeFieldInfoPtr__DynamicOccupant_k__BackingField;

		// Token: 0x04003FC4 RID: 16324
		private static readonly IntPtr NativeFieldInfoPtr__StaticOccupant_k__BackingField;

		// Token: 0x04003FC5 RID: 16325
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003FC6 RID: 16326
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04003FC7 RID: 16327
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x04003FC8 RID: 16328
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x04003FC9 RID: 16329
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x04003FCA RID: 16330
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x04003FCB RID: 16331
		private static readonly IntPtr NativeFieldInfoPtr__IsDestroyed_k__BackingField;

		// Token: 0x04003FCC RID: 16332
		private static readonly IntPtr NativeFieldInfoPtr_ParentProperty;

		// Token: 0x04003FCD RID: 16333
		private static readonly IntPtr NativeFieldInfoPtr_VehicleDetector;

		// Token: 0x04003FCE RID: 16334
		private static readonly IntPtr NativeFieldInfoPtr_Parking;

		// Token: 0x04003FCF RID: 16335
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04003FD0 RID: 16336
		private static readonly IntPtr NativeFieldInfoPtr_accessPoints;

		// Token: 0x04003FD1 RID: 16337
		private static readonly IntPtr NativeFieldInfoPtr_OutlineRenderers;

		// Token: 0x04003FD2 RID: 16338
		private static readonly IntPtr NativeFieldInfoPtr_OutlineEffect;

		// Token: 0x04003FD3 RID: 16339
		private static readonly IntPtr NativeMethodInfoPtr_get_DynamicOccupant_Public_get_LandVehicle_0;

		// Token: 0x04003FD4 RID: 16340
		private static readonly IntPtr NativeMethodInfoPtr_set_DynamicOccupant_Private_set_Void_LandVehicle_0;

		// Token: 0x04003FD5 RID: 16341
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticOccupant_Public_get_LandVehicle_0;

		// Token: 0x04003FD6 RID: 16342
		private static readonly IntPtr NativeMethodInfoPtr_set_StaticOccupant_Private_set_Void_LandVehicle_0;

		// Token: 0x04003FD7 RID: 16343
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInUse_Public_get_Boolean_0;

		// Token: 0x04003FD8 RID: 16344
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003FD9 RID: 16345
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003FDA RID: 16346
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04003FDB RID: 16347
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003FDC RID: 16348
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04003FDD RID: 16349
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04003FDE RID: 16350
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04003FDF RID: 16351
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04003FE0 RID: 16352
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003FE1 RID: 16353
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04003FE2 RID: 16354
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003FE3 RID: 16355
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003FE4 RID: 16356
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x04003FE5 RID: 16357
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003FE6 RID: 16358
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDestroyed_Public_set_Void_Boolean_0;

		// Token: 0x04003FE7 RID: 16359
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003FE8 RID: 16360
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003FE9 RID: 16361
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003FEA RID: 16362
		private static readonly IntPtr NativeMethodInfoPtr_RefreshOccupant_Private_Void_0;

		// Token: 0x04003FEB RID: 16363
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Private_Void_LandVehicle_0;

		// Token: 0x04003FEC RID: 16364
		private static readonly IntPtr NativeMethodInfoPtr_SetStaticOccupant_Public_Void_LandVehicle_0;

		// Token: 0x04003FED RID: 16365
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0;

		// Token: 0x04003FEE RID: 16366
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0;

		// Token: 0x04003FEF RID: 16367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

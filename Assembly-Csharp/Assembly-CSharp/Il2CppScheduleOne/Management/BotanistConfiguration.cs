using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002D2 RID: 722
	public class BotanistConfiguration : EntityConfiguration
	{
		// Token: 0x060038D9 RID: 14553 RVA: 0x00139300 File Offset: 0x00137500
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistConfiguration()
		{
			Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "BotanistConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr);
			BotanistConfiguration.NativeFieldInfoPtr_AssignableTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "AssignableTypes");
			BotanistConfiguration.NativeFieldInfoPtr_Home = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "Home");
			BotanistConfiguration.NativeFieldInfoPtr_Supplies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "Supplies");
			BotanistConfiguration.NativeFieldInfoPtr_Assigns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "Assigns");
			BotanistConfiguration.NativeFieldInfoPtr__AssignedPots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "<AssignedPots>k__BackingField");
			BotanistConfiguration.NativeFieldInfoPtr__AssignedRacks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "<AssignedRacks>k__BackingField");
			BotanistConfiguration.NativeFieldInfoPtr__AssignedBeds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "<AssignedBeds>k__BackingField");
			BotanistConfiguration.NativeFieldInfoPtr__AssignedSpawnStations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "<AssignedSpawnStations>k__BackingField");
			BotanistConfiguration.NativeFieldInfoPtr__AssignedHome_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "<AssignedHome>k__BackingField");
			BotanistConfiguration.NativeFieldInfoPtr__thisBotanistAssignedOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "_thisBotanistAssignedOn");
			BotanistConfiguration.NativeFieldInfoPtr__botanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "_botanist");
			BotanistConfiguration.NativeMethodInfoPtr_AllowRename_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670550);
			BotanistConfiguration.NativeMethodInfoPtr_get_AssignedPots_Public_get_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670551);
			BotanistConfiguration.NativeMethodInfoPtr_set_AssignedPots_Private_set_Void_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670552);
			BotanistConfiguration.NativeMethodInfoPtr_get_AssignedRacks_Public_get_List_1_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670553);
			BotanistConfiguration.NativeMethodInfoPtr_set_AssignedRacks_Private_set_Void_List_1_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670554);
			BotanistConfiguration.NativeMethodInfoPtr_get_AssignedBeds_Public_get_List_1_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670555);
			BotanistConfiguration.NativeMethodInfoPtr_set_AssignedBeds_Private_set_Void_List_1_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670556);
			BotanistConfiguration.NativeMethodInfoPtr_get_AssignedSpawnStations_Public_get_List_1_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670557);
			BotanistConfiguration.NativeMethodInfoPtr_set_AssignedSpawnStations_Private_set_Void_List_1_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670558);
			BotanistConfiguration.NativeMethodInfoPtr_get_AssignedHome_Public_get_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670559);
			BotanistConfiguration.NativeMethodInfoPtr_set_AssignedHome_Private_set_Void_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670560);
			BotanistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670561);
			BotanistConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670562);
			BotanistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670563);
			BotanistConfiguration.NativeMethodInfoPtr_AssignsChanged_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670564);
			BotanistConfiguration.NativeMethodInfoPtr_GetNPCField_Private_NPCField_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670565);
			BotanistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670566);
			BotanistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670567);
			BotanistConfiguration.NativeMethodInfoPtr_HomeChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670568);
			BotanistConfiguration.NativeMethodInfoPtr___ctor_b__27_0_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670570);
			BotanistConfiguration.NativeMethodInfoPtr___ctor_b__27_1_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100670571);
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x001395B0 File Offset: 0x001377B0
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AllowRename()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfiguration.NativeMethodInfoPtr_AllowRename_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x060038DB RID: 14555 RVA: 0x001395F8 File Offset: 0x001377F8
		// (set) Token: 0x060038DC RID: 14556 RVA: 0x00139638 File Offset: 0x00137838
		public unsafe List<Pot> AssignedPots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_get_AssignedPots_Public_get_List_1_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_set_AssignedPots_Private_set_Void_List_1_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060038DD RID: 14557 RVA: 0x0013967C File Offset: 0x0013787C
		// (set) Token: 0x060038DE RID: 14558 RVA: 0x001396BC File Offset: 0x001378BC
		public unsafe List<DryingRack> AssignedRacks
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_get_AssignedRacks_Public_get_List_1_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_set_AssignedRacks_Private_set_Void_List_1_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x00139700 File Offset: 0x00137900
		// (set) Token: 0x060038E0 RID: 14560 RVA: 0x00139740 File Offset: 0x00137940
		public unsafe List<MushroomBed> AssignedBeds
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 21999, RefRangeEnd = 22015, XrefRangeStart = 21999, XrefRangeEnd = 22015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_get_AssignedBeds_Public_get_List_1_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MushroomBed>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_set_AssignedBeds_Private_set_Void_List_1_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060038E1 RID: 14561 RVA: 0x00139784 File Offset: 0x00137984
		// (set) Token: 0x060038E2 RID: 14562 RVA: 0x001397C4 File Offset: 0x001379C4
		public unsafe List<MushroomSpawnStation> AssignedSpawnStations
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22015, RefRangeEnd = 22016, XrefRangeStart = 22015, XrefRangeEnd = 22016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_get_AssignedSpawnStations_Public_get_List_1_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MushroomSpawnStation>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_set_AssignedSpawnStations_Private_set_Void_List_1_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x00139808 File Offset: 0x00137A08
		// (set) Token: 0x060038E4 RID: 14564 RVA: 0x00139848 File Offset: 0x00137A48
		public unsafe EmployeeHome AssignedHome
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41608, RefRangeEnd = 41609, XrefRangeStart = 41608, XrefRangeEnd = 41609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_get_AssignedHome_Public_get_EmployeeHome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_set_AssignedHome_Private_set_Void_EmployeeHome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x0013988C File Offset: 0x00137A8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146497, RefRangeEnd = 146498, XrefRangeStart = 146371, XrefRangeEnd = 146497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Botanist _botanist) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_botanist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x001398FC File Offset: 0x00137AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146498, XrefRangeEnd = 146508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x00139938 File Offset: 0x00137B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146508, XrefRangeEnd = 146567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStationValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x001399A0 File Offset: 0x00137BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146567, XrefRangeEnd = 146656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignsChanged(List<BuildableItem> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_AssignsChanged_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x001399E4 File Offset: 0x00137BE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146664, RefRangeEnd = 146666, XrefRangeStart = 146656, XrefRangeEnd = 146664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCField GetNPCField(IConfigurable configurable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_GetNPCField_Private_NPCField_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCField>(intPtr3) : null;
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x00139A34 File Offset: 0x00137C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146666, XrefRangeEnd = 146674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x00139A7C File Offset: 0x00137C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146674, XrefRangeEnd = 146682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x00139AC0 File Offset: 0x00137CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146682, XrefRangeEnd = 146700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HomeChanged(BuildableItem newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_HomeChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x00139B04 File Offset: 0x00137D04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__27_0(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr___ctor_b__27_0_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x00139B48 File Offset: 0x00137D48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__27_1(List<BuildableItem> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr___ctor_b__27_1_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x0001CAAF File Offset: 0x0001ACAF
		public BotanistConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x060038F0 RID: 14576 RVA: 0x00139B8C File Offset: 0x00137D8C
		// (set) Token: 0x060038F1 RID: 14577 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
		public unsafe static Il2CppReferenceArray<Type> AssignableTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BotanistConfiguration.NativeFieldInfoPtr_AssignableTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BotanistConfiguration.NativeFieldInfoPtr_AssignableTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x060038F2 RID: 14578 RVA: 0x00139BB4 File Offset: 0x00137DB4
		// (set) Token: 0x060038F3 RID: 14579 RVA: 0x0001CACA File Offset: 0x0001ACCA
		public unsafe ObjectField Home
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Home);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Home), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x060038F4 RID: 14580 RVA: 0x00139BE4 File Offset: 0x00137DE4
		// (set) Token: 0x060038F5 RID: 14581 RVA: 0x0001CAE9 File Offset: 0x0001ACE9
		public unsafe ObjectField Supplies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Supplies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Supplies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x060038F6 RID: 14582 RVA: 0x00139C14 File Offset: 0x00137E14
		// (set) Token: 0x060038F7 RID: 14583 RVA: 0x0001CB08 File Offset: 0x0001AD08
		public unsafe ObjectListField Assigns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Assigns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Assigns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x060038F8 RID: 14584 RVA: 0x00139C44 File Offset: 0x00137E44
		// (set) Token: 0x060038F9 RID: 14585 RVA: 0x0001CB27 File Offset: 0x0001AD27
		public unsafe List<Pot> _AssignedPots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__AssignedPots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__AssignedPots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x00139C74 File Offset: 0x00137E74
		// (set) Token: 0x060038FB RID: 14587 RVA: 0x0001CB46 File Offset: 0x0001AD46
		public unsafe List<DryingRack> _AssignedRacks_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__AssignedRacks_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__AssignedRacks_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x060038FC RID: 14588 RVA: 0x00139CA4 File Offset: 0x00137EA4
		// (set) Token: 0x060038FD RID: 14589 RVA: 0x0001CB65 File Offset: 0x0001AD65
		public unsafe List<MushroomBed> _AssignedBeds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__AssignedBeds_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MushroomBed>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__AssignedBeds_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x060038FE RID: 14590 RVA: 0x00139CD4 File Offset: 0x00137ED4
		// (set) Token: 0x060038FF RID: 14591 RVA: 0x0001CB84 File Offset: 0x0001AD84
		public unsafe List<MushroomSpawnStation> _AssignedSpawnStations_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__AssignedSpawnStations_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MushroomSpawnStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__AssignedSpawnStations_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06003900 RID: 14592 RVA: 0x00139D04 File Offset: 0x00137F04
		// (set) Token: 0x06003901 RID: 14593 RVA: 0x0001CBA3 File Offset: 0x0001ADA3
		public unsafe EmployeeHome _AssignedHome_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__AssignedHome_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__AssignedHome_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06003902 RID: 14594 RVA: 0x00139D34 File Offset: 0x00137F34
		// (set) Token: 0x06003903 RID: 14595 RVA: 0x0001CBC2 File Offset: 0x0001ADC2
		public unsafe List<BuildableItem> _thisBotanistAssignedOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__thisBotanistAssignedOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__thisBotanistAssignedOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06003904 RID: 14596 RVA: 0x00139D64 File Offset: 0x00137F64
		// (set) Token: 0x06003905 RID: 14597 RVA: 0x0001CBE1 File Offset: 0x0001ADE1
		public unsafe Botanist _botanist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__botanist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__botanist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400262A RID: 9770
		private static readonly IntPtr NativeFieldInfoPtr_AssignableTypes;

		// Token: 0x0400262B RID: 9771
		private static readonly IntPtr NativeFieldInfoPtr_Home;

		// Token: 0x0400262C RID: 9772
		private static readonly IntPtr NativeFieldInfoPtr_Supplies;

		// Token: 0x0400262D RID: 9773
		private static readonly IntPtr NativeFieldInfoPtr_Assigns;

		// Token: 0x0400262E RID: 9774
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPots_k__BackingField;

		// Token: 0x0400262F RID: 9775
		private static readonly IntPtr NativeFieldInfoPtr__AssignedRacks_k__BackingField;

		// Token: 0x04002630 RID: 9776
		private static readonly IntPtr NativeFieldInfoPtr__AssignedBeds_k__BackingField;

		// Token: 0x04002631 RID: 9777
		private static readonly IntPtr NativeFieldInfoPtr__AssignedSpawnStations_k__BackingField;

		// Token: 0x04002632 RID: 9778
		private static readonly IntPtr NativeFieldInfoPtr__AssignedHome_k__BackingField;

		// Token: 0x04002633 RID: 9779
		private static readonly IntPtr NativeFieldInfoPtr__thisBotanistAssignedOn;

		// Token: 0x04002634 RID: 9780
		private static readonly IntPtr NativeFieldInfoPtr__botanist;

		// Token: 0x04002635 RID: 9781
		private static readonly IntPtr NativeMethodInfoPtr_AllowRename_Public_Virtual_Boolean_0;

		// Token: 0x04002636 RID: 9782
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPots_Public_get_List_1_Pot_0;

		// Token: 0x04002637 RID: 9783
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPots_Private_set_Void_List_1_Pot_0;

		// Token: 0x04002638 RID: 9784
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedRacks_Public_get_List_1_DryingRack_0;

		// Token: 0x04002639 RID: 9785
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedRacks_Private_set_Void_List_1_DryingRack_0;

		// Token: 0x0400263A RID: 9786
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedBeds_Public_get_List_1_MushroomBed_0;

		// Token: 0x0400263B RID: 9787
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedBeds_Private_set_Void_List_1_MushroomBed_0;

		// Token: 0x0400263C RID: 9788
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedSpawnStations_Public_get_List_1_MushroomSpawnStation_0;

		// Token: 0x0400263D RID: 9789
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedSpawnStations_Private_set_Void_List_1_MushroomSpawnStation_0;

		// Token: 0x0400263E RID: 9790
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedHome_Public_get_EmployeeHome_0;

		// Token: 0x0400263F RID: 9791
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedHome_Private_set_Void_EmployeeHome_0;

		// Token: 0x04002640 RID: 9792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Botanist_0;

		// Token: 0x04002641 RID: 9793
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04002642 RID: 9794
		private static readonly IntPtr NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04002643 RID: 9795
		private static readonly IntPtr NativeMethodInfoPtr_AssignsChanged_Public_Void_List_1_BuildableItem_0;

		// Token: 0x04002644 RID: 9796
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCField_Private_NPCField_IConfigurable_0;

		// Token: 0x04002645 RID: 9797
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04002646 RID: 9798
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04002647 RID: 9799
		private static readonly IntPtr NativeMethodInfoPtr_HomeChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002648 RID: 9800
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__27_0_Private_Void_BuildableItem_0;

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__27_1_Private_Void_List_1_BuildableItem_0;
	}
}

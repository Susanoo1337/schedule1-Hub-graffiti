using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002D5 RID: 725
	public class ChemistConfiguration : EntityConfiguration
	{
		// Token: 0x06003936 RID: 14646 RVA: 0x0013AA1C File Offset: 0x00138C1C
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistConfiguration()
		{
			Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ChemistConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr);
			ChemistConfiguration.NativeFieldInfoPtr_Home = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "Home");
			ChemistConfiguration.NativeFieldInfoPtr_Stations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "Stations");
			ChemistConfiguration.NativeFieldInfoPtr_ChemStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "ChemStations");
			ChemistConfiguration.NativeFieldInfoPtr_LabOvens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "LabOvens");
			ChemistConfiguration.NativeFieldInfoPtr_Cauldrons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "Cauldrons");
			ChemistConfiguration.NativeFieldInfoPtr_MixStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "MixStations");
			ChemistConfiguration.NativeFieldInfoPtr__chemist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "<chemist>k__BackingField");
			ChemistConfiguration.NativeFieldInfoPtr__assignedHome_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "<assignedHome>k__BackingField");
			ChemistConfiguration.NativeMethodInfoPtr_AllowRename_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670600);
			ChemistConfiguration.NativeMethodInfoPtr_get_TotalStations_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670601);
			ChemistConfiguration.NativeMethodInfoPtr_get_chemist_Public_get_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670602);
			ChemistConfiguration.NativeMethodInfoPtr_set_chemist_Protected_set_Void_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670603);
			ChemistConfiguration.NativeMethodInfoPtr_get_assignedHome_Public_get_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670604);
			ChemistConfiguration.NativeMethodInfoPtr_set_assignedHome_Private_set_Void_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670605);
			ChemistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670606);
			ChemistConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670607);
			ChemistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670608);
			ChemistConfiguration.NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670609);
			ChemistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670610);
			ChemistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670611);
			ChemistConfiguration.NativeMethodInfoPtr_HomeChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670612);
			ChemistConfiguration.NativeMethodInfoPtr___ctor_b__17_0_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100670613);
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x0013AC04 File Offset: 0x00138E04
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AllowRename()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfiguration.NativeMethodInfoPtr_AllowRename_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x0013AC4C File Offset: 0x00138E4C
		public unsafe int TotalStations
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 146886, RefRangeEnd = 146888, XrefRangeStart = 146882, XrefRangeEnd = 146886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_get_TotalStations_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x0013AC88 File Offset: 0x00138E88
		// (set) Token: 0x0600393A RID: 14650 RVA: 0x0013ACC8 File Offset: 0x00138EC8
		public unsafe Chemist chemist
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22015, RefRangeEnd = 22016, XrefRangeStart = 22015, XrefRangeEnd = 22016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_get_chemist_Public_get_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_set_chemist_Protected_set_Void_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x0013AD0C File Offset: 0x00138F0C
		// (set) Token: 0x0600393C RID: 14652 RVA: 0x0013AD4C File Offset: 0x00138F4C
		public unsafe EmployeeHome assignedHome
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41608, RefRangeEnd = 41609, XrefRangeStart = 41608, XrefRangeEnd = 41609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_get_assignedHome_Public_get_EmployeeHome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_set_assignedHome_Private_set_Void_EmployeeHome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x0013AD90 File Offset: 0x00138F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147016, RefRangeEnd = 147017, XrefRangeStart = 146888, XrefRangeEnd = 147016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Chemist _chemist) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_chemist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x0013AE00 File Offset: 0x00139000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147017, XrefRangeEnd = 147090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x0013AE3C File Offset: 0x0013903C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147090, XrefRangeEnd = 147116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStationValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x0013AEA4 File Offset: 0x001390A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147116, XrefRangeEnd = 147317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignedStationsChanged(List<BuildableItem> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x0013AEE8 File Offset: 0x001390E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147317, XrefRangeEnd = 147324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x0013AF30 File Offset: 0x00139130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147324, XrefRangeEnd = 147331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x0013AF74 File Offset: 0x00139174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147331, XrefRangeEnd = 147349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HomeChanged(BuildableItem newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_HomeChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x0013AFB8 File Offset: 0x001391B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__17_0(List<BuildableItem> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr___ctor_b__17_0_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x0001CD0A File Offset: 0x0001AF0A
		public ChemistConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06003946 RID: 14662 RVA: 0x0013AFFC File Offset: 0x001391FC
		// (set) Token: 0x06003947 RID: 14663 RVA: 0x0001CD13 File Offset: 0x0001AF13
		public unsafe ObjectField Home
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Home);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Home), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F7 RID: 4599
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x0013B02C File Offset: 0x0013922C
		// (set) Token: 0x06003949 RID: 14665 RVA: 0x0001CD32 File Offset: 0x0001AF32
		public unsafe ObjectListField Stations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Stations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Stations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x0013B05C File Offset: 0x0013925C
		// (set) Token: 0x0600394B RID: 14667 RVA: 0x0001CD51 File Offset: 0x0001AF51
		public unsafe List<ChemistryStation> ChemStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_ChemStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ChemistryStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_ChemStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x0600394C RID: 14668 RVA: 0x0013B08C File Offset: 0x0013928C
		// (set) Token: 0x0600394D RID: 14669 RVA: 0x0001CD70 File Offset: 0x0001AF70
		public unsafe List<LabOven> LabOvens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_LabOvens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_LabOvens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x0600394E RID: 14670 RVA: 0x0013B0BC File Offset: 0x001392BC
		// (set) Token: 0x0600394F RID: 14671 RVA: 0x0001CD8F File Offset: 0x0001AF8F
		public unsafe List<Cauldron> Cauldrons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Cauldrons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Cauldron>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Cauldrons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x06003950 RID: 14672 RVA: 0x0013B0EC File Offset: 0x001392EC
		// (set) Token: 0x06003951 RID: 14673 RVA: 0x0001CDAE File Offset: 0x0001AFAE
		public unsafe List<MixingStation> MixStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_MixStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MixingStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_MixStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06003952 RID: 14674 RVA: 0x0013B11C File Offset: 0x0013931C
		// (set) Token: 0x06003953 RID: 14675 RVA: 0x0001CDCD File Offset: 0x0001AFCD
		public unsafe Chemist _chemist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__chemist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__chemist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06003954 RID: 14676 RVA: 0x0013B14C File Offset: 0x0013934C
		// (set) Token: 0x06003955 RID: 14677 RVA: 0x0001CDEC File Offset: 0x0001AFEC
		public unsafe EmployeeHome _assignedHome_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__assignedHome_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__assignedHome_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400266E RID: 9838
		private static readonly IntPtr NativeFieldInfoPtr_Home;

		// Token: 0x0400266F RID: 9839
		private static readonly IntPtr NativeFieldInfoPtr_Stations;

		// Token: 0x04002670 RID: 9840
		private static readonly IntPtr NativeFieldInfoPtr_ChemStations;

		// Token: 0x04002671 RID: 9841
		private static readonly IntPtr NativeFieldInfoPtr_LabOvens;

		// Token: 0x04002672 RID: 9842
		private static readonly IntPtr NativeFieldInfoPtr_Cauldrons;

		// Token: 0x04002673 RID: 9843
		private static readonly IntPtr NativeFieldInfoPtr_MixStations;

		// Token: 0x04002674 RID: 9844
		private static readonly IntPtr NativeFieldInfoPtr__chemist_k__BackingField;

		// Token: 0x04002675 RID: 9845
		private static readonly IntPtr NativeFieldInfoPtr__assignedHome_k__BackingField;

		// Token: 0x04002676 RID: 9846
		private static readonly IntPtr NativeMethodInfoPtr_AllowRename_Public_Virtual_Boolean_0;

		// Token: 0x04002677 RID: 9847
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalStations_Public_get_Int32_0;

		// Token: 0x04002678 RID: 9848
		private static readonly IntPtr NativeMethodInfoPtr_get_chemist_Public_get_Chemist_0;

		// Token: 0x04002679 RID: 9849
		private static readonly IntPtr NativeMethodInfoPtr_set_chemist_Protected_set_Void_Chemist_0;

		// Token: 0x0400267A RID: 9850
		private static readonly IntPtr NativeMethodInfoPtr_get_assignedHome_Public_get_EmployeeHome_0;

		// Token: 0x0400267B RID: 9851
		private static readonly IntPtr NativeMethodInfoPtr_set_assignedHome_Private_set_Void_EmployeeHome_0;

		// Token: 0x0400267C RID: 9852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Chemist_0;

		// Token: 0x0400267D RID: 9853
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400267E RID: 9854
		private static readonly IntPtr NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x0400267F RID: 9855
		private static readonly IntPtr NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0;

		// Token: 0x04002680 RID: 9856
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04002681 RID: 9857
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04002682 RID: 9858
		private static readonly IntPtr NativeMethodInfoPtr_HomeChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002683 RID: 9859
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__17_0_Private_Void_List_1_BuildableItem_0;
	}
}

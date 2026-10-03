using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200014C RID: 332
	public class Quest_Employees : Quest
	{
		// Token: 0x0600219D RID: 8605 RVA: 0x000EA3C4 File Offset: 0x000E85C4
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Employees()
		{
			Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Employees");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr);
			Quest_Employees.NativeFieldInfoPtr_EmployeeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "EmployeeType");
			Quest_Employees.NativeFieldInfoPtr_AssignBedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "AssignBedEntry");
			Quest_Employees.NativeFieldInfoPtr_PayEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "PayEntry");
			Quest_Employees.NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667657);
			Quest_Employees.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667658);
			Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667659);
			Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667660);
			Quest_Employees.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667661);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x000EA494 File Offset: 0x000E8694
		[CallerCount(0)]
		public unsafe virtual List<Employee> GetEmployees()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Employees.NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x000EA4E0 File Offset: 0x000E86E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 110844, RefRangeEnd = 110848, XrefRangeStart = 110838, XrefRangeEnd = 110844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Employees.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000EA51C File Offset: 0x000E871C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110862, RefRangeEnd = 110863, XrefRangeStart = 110848, XrefRangeEnd = 110862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAnyEmployeesAssignedBeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x000EA558 File Offset: 0x000E8758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110874, RefRangeEnd = 110875, XrefRangeStart = 110863, XrefRangeEnd = 110874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAnyEmployeesPaid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x000EA594 File Offset: 0x000E8794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Employees() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00011EE4 File Offset: 0x000100E4
		public Quest_Employees(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x000EA5D0 File Offset: 0x000E87D0
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x00011EED File Offset: 0x000100ED
		public unsafe EEmployeeType EmployeeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_EmployeeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_EmployeeType)) = value;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x000EA5F8 File Offset: 0x000E87F8
		// (set) Token: 0x060021A7 RID: 8615 RVA: 0x00011F08 File Offset: 0x00010108
		public unsafe QuestEntry AssignBedEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_AssignBedEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_AssignBedEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x000EA628 File Offset: 0x000E8828
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x00011F27 File Offset: 0x00010127
		public unsafe QuestEntry PayEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_PayEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_PayEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeType;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeFieldInfoPtr_AssignBedEntry;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeFieldInfoPtr_PayEntry;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

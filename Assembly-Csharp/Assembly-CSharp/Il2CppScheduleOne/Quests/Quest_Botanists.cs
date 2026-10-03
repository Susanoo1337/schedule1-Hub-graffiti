using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000144 RID: 324
	public class Quest_Botanists : Quest_Employees
	{
		// Token: 0x06002144 RID: 8516 RVA: 0x000E92BC File Offset: 0x000E74BC
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Botanists()
		{
			Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Botanists");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr);
			Quest_Botanists.NativeFieldInfoPtr_AssignSuppliesEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, "AssignSuppliesEntry");
			Quest_Botanists.NativeFieldInfoPtr_AssignWorkEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, "AssignWorkEntry");
			Quest_Botanists.NativeFieldInfoPtr_AssignDestinationEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, "AssignDestinationEntry");
			Quest_Botanists.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, 100667626);
			Quest_Botanists.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, 100667627);
			Quest_Botanists.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr, 100667628);
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x000E9364 File Offset: 0x000E7564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110391, XrefRangeEnd = 110471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Botanists.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x000E93A0 File Offset: 0x000E75A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110471, XrefRangeEnd = 110477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<Employee> GetEmployees()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Botanists.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x000E93EC File Offset: 0x000E75EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110477, XrefRangeEnd = 110481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Botanists() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Botanists>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Botanists.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00011C22 File Offset: 0x0000FE22
		public Quest_Botanists(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x000E9428 File Offset: 0x000E7628
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x00011C2B File Offset: 0x0000FE2B
		public unsafe QuestEntry AssignSuppliesEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignSuppliesEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignSuppliesEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x000E9458 File Offset: 0x000E7658
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x00011C4A File Offset: 0x0000FE4A
		public unsafe QuestEntry AssignWorkEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignWorkEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignWorkEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000E9488 File Offset: 0x000E7688
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x00011C69 File Offset: 0x0000FE69
		public unsafe QuestEntry AssignDestinationEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignDestinationEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Botanists.NativeFieldInfoPtr_AssignDestinationEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeFieldInfoPtr_AssignSuppliesEntry;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeFieldInfoPtr_AssignWorkEntry;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeFieldInfoPtr_AssignDestinationEntry;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

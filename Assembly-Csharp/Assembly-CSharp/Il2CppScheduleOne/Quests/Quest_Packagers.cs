using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000154 RID: 340
	public class Quest_Packagers : Quest_Employees
	{
		// Token: 0x060021E6 RID: 8678 RVA: 0x000EB094 File Offset: 0x000E9294
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Packagers()
		{
			Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Packagers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr);
			Quest_Packagers.NativeFieldInfoPtr_AssignWorkEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr, "AssignWorkEntry");
			Quest_Packagers.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr, 100667681);
			Quest_Packagers.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr, 100667682);
			Quest_Packagers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr, 100667683);
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000EB114 File Offset: 0x000E9314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111057, XrefRangeEnd = 111081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Packagers.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000EB150 File Offset: 0x000E9350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111081, XrefRangeEnd = 111087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<Employee> GetEmployees()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Packagers.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x000EB19C File Offset: 0x000E939C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Packagers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Packagers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Packagers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x0001214A File Offset: 0x0001034A
		public Quest_Packagers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060021EB RID: 8683 RVA: 0x000EB1D8 File Offset: 0x000E93D8
		// (set) Token: 0x060021EC RID: 8684 RVA: 0x00012153 File Offset: 0x00010353
		public unsafe QuestEntry AssignWorkEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Packagers.NativeFieldInfoPtr_AssignWorkEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Packagers.NativeFieldInfoPtr_AssignWorkEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeFieldInfoPtr_AssignWorkEntry;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

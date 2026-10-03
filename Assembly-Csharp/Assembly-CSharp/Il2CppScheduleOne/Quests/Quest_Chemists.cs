using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000145 RID: 325
	public class Quest_Chemists : Quest_Employees
	{
		// Token: 0x0600214F RID: 8527 RVA: 0x000E94B8 File Offset: 0x000E76B8
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Chemists()
		{
			Il2CppClassPointerStore<Quest_Chemists>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Chemists");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Chemists>.NativeClassPtr);
			Quest_Chemists.NativeFieldInfoPtr_AssignWorkEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Chemists>.NativeClassPtr, "AssignWorkEntry");
			Quest_Chemists.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Chemists>.NativeClassPtr, 100667629);
			Quest_Chemists.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Chemists>.NativeClassPtr, 100667630);
			Quest_Chemists.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Chemists>.NativeClassPtr, 100667631);
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x000E9538 File Offset: 0x000E7738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110481, XrefRangeEnd = 110505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Chemists.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x000E9574 File Offset: 0x000E7774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110505, XrefRangeEnd = 110511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<Employee> GetEmployees()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Chemists.NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x000E95C0 File Offset: 0x000E77C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Chemists() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Chemists>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Chemists.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00011C88 File Offset: 0x0000FE88
		public Quest_Chemists(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x000E95FC File Offset: 0x000E77FC
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x00011C91 File Offset: 0x0000FE91
		public unsafe QuestEntry AssignWorkEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Chemists.NativeFieldInfoPtr_AssignWorkEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Chemists.NativeFieldInfoPtr_AssignWorkEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeFieldInfoPtr_AssignWorkEntry;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployees_Public_Virtual_List_1_Employee_0;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200014D RID: 333
	public class Quest_ExpandingOperations : Quest
	{
		// Token: 0x060021AA RID: 8618 RVA: 0x000EA658 File Offset: 0x000E8858
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_ExpandingOperations()
		{
			Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_ExpandingOperations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr);
			Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, "SetUpGrowTentsEntry");
			Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, "ReachCustomersEntry");
			Quest_ExpandingOperations.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, 100667662);
			Quest_ExpandingOperations.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, 100667663);
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x000EA6D8 File Offset: 0x000E88D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110875, XrefRangeEnd = 110908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_ExpandingOperations.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x000EA714 File Offset: 0x000E8914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110908, XrefRangeEnd = 110912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_ExpandingOperations() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_ExpandingOperations.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00011F46 File Offset: 0x00010146
		public Quest_ExpandingOperations(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x000EA750 File Offset: 0x000E8950
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x00011F4F File Offset: 0x0001014F
		public unsafe QuestEntry SetUpGrowTentsEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x000EA780 File Offset: 0x000E8980
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x00011F6E File Offset: 0x0001016E
		public unsafe QuestEntry ReachCustomersEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeFieldInfoPtr_SetUpGrowTentsEntry;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeFieldInfoPtr_ReachCustomersEntry;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

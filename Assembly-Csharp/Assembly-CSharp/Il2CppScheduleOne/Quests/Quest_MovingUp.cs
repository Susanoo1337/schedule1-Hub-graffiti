using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000151 RID: 337
	public class Quest_MovingUp : Quest
	{
		// Token: 0x060021D0 RID: 8656 RVA: 0x000EACD8 File Offset: 0x000E8ED8
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_MovingUp()
		{
			Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_MovingUp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr);
			Quest_MovingUp.NativeFieldInfoPtr_ReachCustomersEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr, "ReachCustomersEntry");
			Quest_MovingUp.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr, 100667675);
			Quest_MovingUp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr, 100667676);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x000EAD44 File Offset: 0x000E8F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110980, XrefRangeEnd = 110994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_MovingUp.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000EAD80 File Offset: 0x000E8F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110994, XrefRangeEnd = 110998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_MovingUp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_MovingUp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_MovingUp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00012098 File Offset: 0x00010298
		public Quest_MovingUp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x000EADBC File Offset: 0x000E8FBC
		// (set) Token: 0x060021D5 RID: 8661 RVA: 0x000120A1 File Offset: 0x000102A1
		public unsafe QuestEntry ReachCustomersEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_MovingUp.NativeFieldInfoPtr_ReachCustomersEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_MovingUp.NativeFieldInfoPtr_ReachCustomersEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeFieldInfoPtr_ReachCustomersEntry;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

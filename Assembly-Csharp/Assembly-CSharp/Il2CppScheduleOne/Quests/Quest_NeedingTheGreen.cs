using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000152 RID: 338
	public class Quest_NeedingTheGreen : Quest
	{
		// Token: 0x060021D6 RID: 8662 RVA: 0x000EADEC File Offset: 0x000E8FEC
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_NeedingTheGreen()
		{
			Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_NeedingTheGreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr);
			Quest_NeedingTheGreen.NativeFieldInfoPtr_PrerequisiteQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, "PrerequisiteQuests");
			Quest_NeedingTheGreen.NativeFieldInfoPtr_EarnEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, "EarnEntry");
			Quest_NeedingTheGreen.NativeFieldInfoPtr_LifetimeEarningsRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, "LifetimeEarningsRequirement");
			Quest_NeedingTheGreen.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, 100667677);
			Quest_NeedingTheGreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, 100667678);
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x000EAE80 File Offset: 0x000E9080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110998, XrefRangeEnd = 111031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_NeedingTheGreen.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x000EAEBC File Offset: 0x000E90BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111031, XrefRangeEnd = 111035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_NeedingTheGreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_NeedingTheGreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000120C0 File Offset: 0x000102C0
		public Quest_NeedingTheGreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x000EAEF8 File Offset: 0x000E90F8
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x000120C9 File Offset: 0x000102C9
		public unsafe Il2CppReferenceArray<Quest> PrerequisiteQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_PrerequisiteQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_PrerequisiteQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x000EAF28 File Offset: 0x000E9128
		// (set) Token: 0x060021DD RID: 8669 RVA: 0x000120E8 File Offset: 0x000102E8
		public unsafe QuestEntry EarnEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_EarnEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_EarnEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x000EAF58 File Offset: 0x000E9158
		// (set) Token: 0x060021DF RID: 8671 RVA: 0x00012107 File Offset: 0x00010307
		public unsafe float LifetimeEarningsRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_LifetimeEarningsRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_LifetimeEarningsRequirement)) = value;
			}
		}

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeFieldInfoPtr_PrerequisiteQuests;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeFieldInfoPtr_EarnEntry;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeFieldInfoPtr_LifetimeEarningsRequirement;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

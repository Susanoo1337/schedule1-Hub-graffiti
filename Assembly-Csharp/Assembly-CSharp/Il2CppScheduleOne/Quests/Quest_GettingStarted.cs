using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.NPCs.CharacterClasses;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200014F RID: 335
	public class Quest_GettingStarted : Quest
	{
		// Token: 0x060021C0 RID: 8640 RVA: 0x000EAA20 File Offset: 0x000E8C20
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_GettingStarted()
		{
			Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_GettingStarted");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr);
			Quest_GettingStarted.NativeFieldInfoPtr_CashAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "CashAmount");
			Quest_GettingStarted.NativeFieldInfoPtr_CashDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "CashDrop");
			Quest_GettingStarted.NativeFieldInfoPtr_Nelson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, "Nelson");
			Quest_GettingStarted.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr, 100667671);
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x000EAAA0 File Offset: 0x000E8CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110962, XrefRangeEnd = 110966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_GettingStarted() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_GettingStarted>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_GettingStarted.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x0001200E File Offset: 0x0001020E
		public Quest_GettingStarted(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x000EAADC File Offset: 0x000E8CDC
		// (set) Token: 0x060021C4 RID: 8644 RVA: 0x00012017 File Offset: 0x00010217
		public unsafe float CashAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashAmount)) = value;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x000EAB04 File Offset: 0x000E8D04
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x00012032 File Offset: 0x00010232
		public unsafe DeadDrop CashDrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashDrop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadDrop>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_CashDrop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x000EAB34 File Offset: 0x000E8D34
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x00012051 File Offset: 0x00010251
		public unsafe UncleNelson Nelson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_Nelson);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UncleNelson>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_GettingStarted.NativeFieldInfoPtr_Nelson), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeFieldInfoPtr_CashAmount;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeFieldInfoPtr_CashDrop;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeFieldInfoPtr_Nelson;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

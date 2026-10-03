using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Cartel;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000149 RID: 329
	public class Quest_DealForCartel : Quest
	{
		// Token: 0x06002169 RID: 8553 RVA: 0x000E99D8 File Offset: 0x000E7BD8
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_DealForCartel()
		{
			Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_DealForCartel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr);
			Quest_DealForCartel.NativeFieldInfoPtr_MainEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr, "MainEntry");
			Quest_DealForCartel.NativeFieldInfoPtr_EndTruceEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr, "EndTruceEntry");
			Quest_DealForCartel.NativeFieldInfoPtr_dealInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr, "dealInfo");
			Quest_DealForCartel.NativeMethodInfoPtr_Initialize_Public_Void_CartelDealInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr, 100667639);
			Quest_DealForCartel.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr, 100667640);
			Quest_DealForCartel.NativeMethodInfoPtr_UpdateTimingLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr, 100667641);
			Quest_DealForCartel.NativeMethodInfoPtr_NotifyDealCompleted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr, 100667642);
			Quest_DealForCartel.NativeMethodInfoPtr_NotifyTruceEnded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr, 100667643);
			Quest_DealForCartel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr, 100667644);
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x000E9ABC File Offset: 0x000E7CBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110643, RefRangeEnd = 110646, XrefRangeStart = 110604, XrefRangeEnd = 110643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CartelDealInfo dealInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_DealForCartel.NativeMethodInfoPtr_Initialize_Public_Void_CartelDealInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x000E9B00 File Offset: 0x000E7D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110646, XrefRangeEnd = 110648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_DealForCartel.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x000E9B3C File Offset: 0x000E7D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110713, RefRangeEnd = 110714, XrefRangeStart = 110648, XrefRangeEnd = 110713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimingLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_DealForCartel.NativeMethodInfoPtr_UpdateTimingLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x000E9B70 File Offset: 0x000E7D70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110716, RefRangeEnd = 110717, XrefRangeStart = 110714, XrefRangeEnd = 110716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyDealCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_DealForCartel.NativeMethodInfoPtr_NotifyDealCompleted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x000E9BA4 File Offset: 0x000E7DA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110719, RefRangeEnd = 110720, XrefRangeStart = 110717, XrefRangeEnd = 110719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyTruceEnded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_DealForCartel.NativeMethodInfoPtr_NotifyTruceEnded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x000E9BD8 File Offset: 0x000E7DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110720, XrefRangeEnd = 110724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_DealForCartel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_DealForCartel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_DealForCartel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x00011D28 File Offset: 0x0000FF28
		public Quest_DealForCartel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x000E9C14 File Offset: 0x000E7E14
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x00011D31 File Offset: 0x0000FF31
		public unsafe QuestEntry MainEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DealForCartel.NativeFieldInfoPtr_MainEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DealForCartel.NativeFieldInfoPtr_MainEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x000E9C44 File Offset: 0x000E7E44
		// (set) Token: 0x06002174 RID: 8564 RVA: 0x00011D50 File Offset: 0x0000FF50
		public unsafe QuestEntry EndTruceEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DealForCartel.NativeFieldInfoPtr_EndTruceEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DealForCartel.NativeFieldInfoPtr_EndTruceEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000E9C74 File Offset: 0x000E7E74
		// (set) Token: 0x06002176 RID: 8566 RVA: 0x00011D6F File Offset: 0x0000FF6F
		public unsafe CartelDealInfo dealInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DealForCartel.NativeFieldInfoPtr_dealInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelDealInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_DealForCartel.NativeFieldInfoPtr_dealInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeFieldInfoPtr_MainEntry;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeFieldInfoPtr_EndTruceEntry;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeFieldInfoPtr_dealInfo;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_CartelDealInfo_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimingLabel_Private_Void_0;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDealCompleted_Public_Void_0;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeMethodInfoPtr_NotifyTruceEnded_Public_Void_0;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

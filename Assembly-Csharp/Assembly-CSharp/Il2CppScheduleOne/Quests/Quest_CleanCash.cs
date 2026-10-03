using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000146 RID: 326
	public class Quest_CleanCash : Quest
	{
		// Token: 0x06002156 RID: 8534 RVA: 0x000E962C File Offset: 0x000E782C
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_CleanCash()
		{
			Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_CleanCash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr);
			Quest_CleanCash.NativeFieldInfoPtr_BuyBusinessEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, "BuyBusinessEntry");
			Quest_CleanCash.NativeFieldInfoPtr_GoToBusinessEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, "GoToBusinessEntry");
			Quest_CleanCash.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, 100667632);
			Quest_CleanCash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, 100667633);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x000E96AC File Offset: 0x000E78AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110511, XrefRangeEnd = 110547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_CleanCash.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x000E96E8 File Offset: 0x000E78E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110547, XrefRangeEnd = 110551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_CleanCash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_CleanCash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00011CB0 File Offset: 0x0000FEB0
		public Quest_CleanCash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x000E9724 File Offset: 0x000E7924
		// (set) Token: 0x0600215B RID: 8539 RVA: 0x00011CB9 File Offset: 0x0000FEB9
		public unsafe QuestEntry BuyBusinessEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_BuyBusinessEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_BuyBusinessEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x000E9754 File Offset: 0x000E7954
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x00011CD8 File Offset: 0x0000FED8
		public unsafe QuestEntry GoToBusinessEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_GoToBusinessEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_GoToBusinessEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeFieldInfoPtr_BuyBusinessEntry;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeFieldInfoPtr_GoToBusinessEntry;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000268 RID: 616
	[Serializable]
	public class QuestData : SaveData
	{
		// Token: 0x060030E6 RID: 12518 RVA: 0x0011D19C File Offset: 0x0011B39C
		// Note: this type is marked as 'beforefieldinit'.
		static QuestData()
		{
			Il2CppClassPointerStore<QuestData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QuestData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestData>.NativeClassPtr);
			QuestData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "GUID");
			QuestData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "State");
			QuestData.NativeFieldInfoPtr_IsTracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "IsTracked");
			QuestData.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Title");
			QuestData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Description");
			QuestData.NativeFieldInfoPtr_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Expires");
			QuestData.NativeFieldInfoPtr_ExpiryDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "ExpiryDate");
			QuestData.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestData>.NativeClassPtr, "Entries");
			QuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestData>.NativeClassPtr, 100669456);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x0011D280 File Offset: 0x0011B480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135288, RefRangeEnd = 135289, XrefRangeStart = 135282, XrefRangeEnd = 135288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestData(string guid, EQuestState state, bool isTracked, string title, string desc, bool expires, GameDateTimeData expiry, Il2CppReferenceArray<QuestEntryData> entries) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(desc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expires;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expiry);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x000192C2 File Offset: 0x000174C2
		public QuestData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x060030E9 RID: 12521 RVA: 0x0011D344 File Offset: 0x0011B544
		// (set) Token: 0x060030EA RID: 12522 RVA: 0x000192CB File Offset: 0x000174CB
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x0011D36C File Offset: 0x0011B56C
		// (set) Token: 0x060030EC RID: 12524 RVA: 0x000192EA File Offset: 0x000174EA
		public unsafe EQuestState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x0011D394 File Offset: 0x0011B594
		// (set) Token: 0x060030EE RID: 12526 RVA: 0x00019305 File Offset: 0x00017505
		public unsafe bool IsTracked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_IsTracked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_IsTracked)) = value;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x0011D3BC File Offset: 0x0011B5BC
		// (set) Token: 0x060030F0 RID: 12528 RVA: 0x00019320 File Offset: 0x00017520
		public unsafe string Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x0011D3E4 File Offset: 0x0011B5E4
		// (set) Token: 0x060030F2 RID: 12530 RVA: 0x0001933F File Offset: 0x0001753F
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x060030F3 RID: 12531 RVA: 0x0011D40C File Offset: 0x0011B60C
		// (set) Token: 0x060030F4 RID: 12532 RVA: 0x0001935E File Offset: 0x0001755E
		public unsafe bool Expires
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Expires)) = value;
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x060030F5 RID: 12533 RVA: 0x0011D434 File Offset: 0x0011B634
		// (set) Token: 0x060030F6 RID: 12534 RVA: 0x00019379 File Offset: 0x00017579
		public unsafe GameDateTimeData ExpiryDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_ExpiryDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_ExpiryDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x060030F7 RID: 12535 RVA: 0x0011D464 File Offset: 0x0011B664
		// (set) Token: 0x060030F8 RID: 12536 RVA: 0x00019398 File Offset: 0x00017598
		public unsafe Il2CppReferenceArray<QuestEntryData> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestEntryData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestData.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040020BF RID: 8383
		private static readonly IntPtr NativeFieldInfoPtr_IsTracked;

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeFieldInfoPtr_Expires;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeFieldInfoPtr_ExpiryDate;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000269 RID: 617
	[Serializable]
	public class QuestEntryData : SaveData
	{
		// Token: 0x060030F9 RID: 12537 RVA: 0x0011D494 File Offset: 0x0011B694
		// Note: this type is marked as 'beforefieldinit'.
		static QuestEntryData()
		{
			Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QuestEntryData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr);
			QuestEntryData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, "Name");
			QuestEntryData.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, "State");
			QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, 100669457);
			QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr, 100669458);
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x0011D514 File Offset: 0x0011B714
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 134770, RefRangeEnd = 134777, XrefRangeStart = 134770, XrefRangeEnd = 134777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntryData(string name, EQuestState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x0011D570 File Offset: 0x0011B770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134345, RefRangeEnd = 134346, XrefRangeStart = 134345, XrefRangeEnd = 134346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntryData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestEntryData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntryData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x000193B7 File Offset: 0x000175B7
		public QuestEntryData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x0011D5AC File Offset: 0x0011B7AC
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x000193C0 File Offset: 0x000175C0
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x0011D5D4 File Offset: 0x0011B7D4
		// (set) Token: 0x06003100 RID: 12544 RVA: 0x000193DF File Offset: 0x000175DF
		public unsafe EQuestState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntryData.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x040020C6 RID: 8390
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040020C7 RID: 8391
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040020C8 RID: 8392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_0;

		// Token: 0x040020C9 RID: 8393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

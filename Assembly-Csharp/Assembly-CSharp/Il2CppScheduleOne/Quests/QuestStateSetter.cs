using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200015C RID: 348
	[Serializable]
	public class QuestStateSetter : Object
	{
		// Token: 0x06002266 RID: 8806 RVA: 0x000EC870 File Offset: 0x000EAA70
		// Note: this type is marked as 'beforefieldinit'.
		static QuestStateSetter()
		{
			Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "QuestStateSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr);
			QuestStateSetter.NativeFieldInfoPtr_QuestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestName");
			QuestStateSetter.NativeFieldInfoPtr_SetQuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "SetQuestState");
			QuestStateSetter.NativeFieldInfoPtr_QuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestState");
			QuestStateSetter.NativeFieldInfoPtr_SetQuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "SetQuestEntryState");
			QuestStateSetter.NativeFieldInfoPtr_QuestEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestEntryIndex");
			QuestStateSetter.NativeFieldInfoPtr_QuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, "QuestEntryState");
			QuestStateSetter.NativeMethodInfoPtr_Execute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, 100667740);
			QuestStateSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr, 100667741);
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x000EC940 File Offset: 0x000EAB40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111670, RefRangeEnd = 111671, XrefRangeStart = 111651, XrefRangeEnd = 111670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestStateSetter.NativeMethodInfoPtr_Execute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x000EC974 File Offset: 0x000EAB74
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestStateSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestStateSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestStateSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x0001259E File Offset: 0x0001079E
		public QuestStateSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x000EC9B0 File Offset: 0x000EABB0
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x000125A7 File Offset: 0x000107A7
		public unsafe string QuestName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x000EC9D8 File Offset: 0x000EABD8
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x000125C6 File Offset: 0x000107C6
		public unsafe bool SetQuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestState)) = value;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x000ECA00 File Offset: 0x000EAC00
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x000125E1 File Offset: 0x000107E1
		public unsafe QuestManager.EQuestAction QuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestState)) = value;
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x000ECA28 File Offset: 0x000EAC28
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x000125FC File Offset: 0x000107FC
		public unsafe bool SetQuestEntryState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_SetQuestEntryState)) = value;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x000ECA50 File Offset: 0x000EAC50
		// (set) Token: 0x06002273 RID: 8819 RVA: 0x00012617 File Offset: 0x00010817
		public unsafe int QuestEntryIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryIndex)) = value;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x000ECA78 File Offset: 0x000EAC78
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x00012632 File Offset: 0x00010832
		public unsafe EQuestState QuestEntryState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestStateSetter.NativeFieldInfoPtr_QuestEntryState)) = value;
			}
		}

		// Token: 0x040017C1 RID: 6081
		private static readonly IntPtr NativeFieldInfoPtr_QuestName;

		// Token: 0x040017C2 RID: 6082
		private static readonly IntPtr NativeFieldInfoPtr_SetQuestState;

		// Token: 0x040017C3 RID: 6083
		private static readonly IntPtr NativeFieldInfoPtr_QuestState;

		// Token: 0x040017C4 RID: 6084
		private static readonly IntPtr NativeFieldInfoPtr_SetQuestEntryState;

		// Token: 0x040017C5 RID: 6085
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryIndex;

		// Token: 0x040017C6 RID: 6086
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryState;

		// Token: 0x040017C7 RID: 6087
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Void_0;

		// Token: 0x040017C8 RID: 6088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

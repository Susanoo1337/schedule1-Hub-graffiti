using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x020000F8 RID: 248
	[Serializable]
	public class QuestCondition : Object
	{
		// Token: 0x0600178E RID: 6030 RVA: 0x000C8FBC File Offset: 0x000C71BC
		// Note: this type is marked as 'beforefieldinit'.
		static QuestCondition()
		{
			Il2CppClassPointerStore<QuestCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "QuestCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr);
			QuestCondition.NativeFieldInfoPtr_CheckQuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "CheckQuestState");
			QuestCondition.NativeFieldInfoPtr_QuestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestName");
			QuestCondition.NativeFieldInfoPtr_QuestState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestState");
			QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "CheckQuestEntryState");
			QuestCondition.NativeFieldInfoPtr_QuestEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestEntryIndex");
			QuestCondition.NativeFieldInfoPtr_QuestEntryState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, "QuestEntryState");
			QuestCondition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, 100666524);
			QuestCondition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr, 100666525);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x000C908C File Offset: 0x000C728C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97269, XrefRangeEnd = 97285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestCondition.NativeMethodInfoPtr_Evaluate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x000C90C8 File Offset: 0x000C72C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97285, XrefRangeEnd = 97290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestCondition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestCondition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestCondition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0000CEFA File Offset: 0x0000B0FA
		public QuestCondition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x000C9104 File Offset: 0x000C7304
		// (set) Token: 0x06001793 RID: 6035 RVA: 0x0000CF03 File Offset: 0x0000B103
		public unsafe bool CheckQuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestState)) = value;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x000C912C File Offset: 0x000C732C
		// (set) Token: 0x06001795 RID: 6037 RVA: 0x0000CF1E File Offset: 0x0000B11E
		public unsafe string QuestName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x000C9154 File Offset: 0x000C7354
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x0000CF3D File Offset: 0x0000B13D
		public unsafe EQuestState QuestState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestState)) = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x000C917C File Offset: 0x000C737C
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x0000CF58 File Offset: 0x0000B158
		public unsafe bool CheckQuestEntryState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_CheckQuestEntryState)) = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x000C91A4 File Offset: 0x000C73A4
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x0000CF73 File Offset: 0x0000B173
		public unsafe int QuestEntryIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryIndex)) = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x000C91CC File Offset: 0x000C73CC
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x0000CF8E File Offset: 0x0000B18E
		public unsafe EQuestState QuestEntryState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestCondition.NativeFieldInfoPtr_QuestEntryState)) = value;
			}
		}

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeFieldInfoPtr_CheckQuestState;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeFieldInfoPtr_QuestName;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeFieldInfoPtr_QuestState;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeFieldInfoPtr_CheckQuestEntryState;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryIndex;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryState;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

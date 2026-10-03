using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Variables
{
	// Token: 0x020000F6 RID: 246
	[Serializable]
	public class Conditions : Object
	{
		// Token: 0x0600177F RID: 6015 RVA: 0x000C8C54 File Offset: 0x000C6E54
		// Note: this type is marked as 'beforefieldinit'.
		static Conditions()
		{
			Il2CppClassPointerStore<Conditions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Variables", "Conditions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Conditions>.NativeClassPtr);
			Conditions.NativeFieldInfoPtr_EvaluationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "EvaluationType");
			Conditions.NativeFieldInfoPtr_ConditionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "ConditionList");
			Conditions.NativeFieldInfoPtr_QuestConditionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Conditions>.NativeClassPtr, "QuestConditionList");
			Conditions.NativeMethodInfoPtr_Evaluate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conditions>.NativeClassPtr, 100666519);
			Conditions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Conditions>.NativeClassPtr, 100666520);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x000C8CE8 File Offset: 0x000C6EE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97251, RefRangeEnd = 97253, XrefRangeStart = 97240, XrefRangeEnd = 97251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conditions.NativeMethodInfoPtr_Evaluate_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x000C8D24 File Offset: 0x000C6F24
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Conditions() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Conditions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Conditions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x0000CE8F File Offset: 0x0000B08F
		public Conditions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x000C8D60 File Offset: 0x000C6F60
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x0000CE98 File Offset: 0x0000B098
		public unsafe Conditions.EEvaluationType EvaluationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_EvaluationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_EvaluationType)) = value;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x000C8D88 File Offset: 0x000C6F88
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x0000CEB3 File Offset: 0x0000B0B3
		public unsafe Il2CppReferenceArray<Condition> ConditionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_ConditionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Condition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_ConditionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x000C8DB8 File Offset: 0x000C6FB8
		// (set) Token: 0x06001788 RID: 6024 RVA: 0x0000CED2 File Offset: 0x0000B0D2
		public unsafe Il2CppReferenceArray<QuestCondition> QuestConditionList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_QuestConditionList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Conditions.NativeFieldInfoPtr_QuestConditionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeFieldInfoPtr_EvaluationType;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeFieldInfoPtr_ConditionList;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeFieldInfoPtr_QuestConditionList;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000937 RID: 2359
		[OriginalName("Assembly-CSharp.dll", "", "EEvaluationType")]
		public enum EEvaluationType
		{
			// Token: 0x04009350 RID: 37712
			And,
			// Token: 0x04009351 RID: 37713
			Or
		}
	}
}

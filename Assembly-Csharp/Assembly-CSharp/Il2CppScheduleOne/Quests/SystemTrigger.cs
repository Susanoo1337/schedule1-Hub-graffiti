using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Variables;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200015F RID: 351
	[Serializable]
	public class SystemTrigger : Object
	{
		// Token: 0x0600228A RID: 8842 RVA: 0x000ECDD4 File Offset: 0x000EAFD4
		// Note: this type is marked as 'beforefieldinit'.
		static SystemTrigger()
		{
			Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "SystemTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr);
			SystemTrigger.NativeFieldInfoPtr_Conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "Conditions");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueVariableSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateTrueVariableSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueQuestSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateTrueQuestSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateTrue");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseVariableSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateFalseVariableSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseQuestSetters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateFalseQuestSetters");
			SystemTrigger.NativeFieldInfoPtr_onEvaluateFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, "onEvaluateFalse");
			SystemTrigger.NativeMethodInfoPtr_Trigger_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, 100667748);
			SystemTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr, 100667749);
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000ECEB8 File Offset: 0x000EB0B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 111715, RefRangeEnd = 111719, XrefRangeStart = 111709, XrefRangeEnd = 111715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTrigger.NativeMethodInfoPtr_Trigger_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000ECEF4 File Offset: 0x000EB0F4
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemTrigger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x000126D0 File Offset: 0x000108D0
		public SystemTrigger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x000ECF30 File Offset: 0x000EB130
		// (set) Token: 0x0600228F RID: 8847 RVA: 0x000126D9 File Offset: 0x000108D9
		public unsafe Conditions Conditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_Conditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Conditions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_Conditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x000ECF60 File Offset: 0x000EB160
		// (set) Token: 0x06002291 RID: 8849 RVA: 0x000126F8 File Offset: 0x000108F8
		public unsafe Il2CppReferenceArray<VariableSetter> onEvaluateTrueVariableSetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueVariableSetters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VariableSetter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueVariableSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x000ECF90 File Offset: 0x000EB190
		// (set) Token: 0x06002293 RID: 8851 RVA: 0x00012717 File Offset: 0x00010917
		public unsafe Il2CppReferenceArray<QuestStateSetter> onEvaluateTrueQuestSetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueQuestSetters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestStateSetter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrueQuestSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x000ECFC0 File Offset: 0x000EB1C0
		// (set) Token: 0x06002295 RID: 8853 RVA: 0x00012736 File Offset: 0x00010936
		public unsafe UnityEvent onEvaluateTrue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateTrue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x000ECFF0 File Offset: 0x000EB1F0
		// (set) Token: 0x06002297 RID: 8855 RVA: 0x00012755 File Offset: 0x00010955
		public unsafe Il2CppReferenceArray<VariableSetter> onEvaluateFalseVariableSetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseVariableSetters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VariableSetter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseVariableSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x000ED020 File Offset: 0x000EB220
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x00012774 File Offset: 0x00010974
		public unsafe Il2CppReferenceArray<QuestStateSetter> onEvaluateFalseQuestSetters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseQuestSetters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestStateSetter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalseQuestSetters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x000ED050 File Offset: 0x000EB250
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x00012793 File Offset: 0x00010993
		public unsafe UnityEvent onEvaluateFalse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemTrigger.NativeFieldInfoPtr_onEvaluateFalse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017D4 RID: 6100
		private static readonly IntPtr NativeFieldInfoPtr_Conditions;

		// Token: 0x040017D5 RID: 6101
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateTrueVariableSetters;

		// Token: 0x040017D6 RID: 6102
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateTrueQuestSetters;

		// Token: 0x040017D7 RID: 6103
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateTrue;

		// Token: 0x040017D8 RID: 6104
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateFalseVariableSetters;

		// Token: 0x040017D9 RID: 6105
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateFalseQuestSetters;

		// Token: 0x040017DA RID: 6106
		private static readonly IntPtr NativeFieldInfoPtr_onEvaluateFalse;

		// Token: 0x040017DB RID: 6107
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Boolean_0;

		// Token: 0x040017DC RID: 6108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

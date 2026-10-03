using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000156 RID: 342
	public class Quest_SinkOrSwim : Quest
	{
		// Token: 0x060021F3 RID: 8691 RVA: 0x000EB31C File Offset: 0x000E951C
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_SinkOrSwim()
		{
			Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_SinkOrSwim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr);
			Quest_SinkOrSwim.NativeFieldInfoPtr_DAYS_TO_COMPLETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "DAYS_TO_COMPLETE");
			Quest_SinkOrSwim.NativeFieldInfoPtr_QuestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "QuestName");
			Quest_SinkOrSwim.NativeFieldInfoPtr_NelsonCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "NelsonCallTime");
			Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkVehiclePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "LoanSharkVehiclePosition");
			Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkGraves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "LoanSharkGraves");
			Quest_SinkOrSwim.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667686);
			Quest_SinkOrSwim.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667687);
			Quest_SinkOrSwim.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667688);
			Quest_SinkOrSwim.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667689);
			Quest_SinkOrSwim.NativeMethodInfoPtr_SpawnLoanSharkVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667690);
			Quest_SinkOrSwim.NativeMethodInfoPtr_CheckArrival_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667691);
			Quest_SinkOrSwim.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667692);
			Quest_SinkOrSwim.NativeMethodInfoPtr_UpdateName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667693);
			Quest_SinkOrSwim.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667694);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x000EB464 File Offset: 0x000E9664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111093, XrefRangeEnd = 111097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SinkOrSwim.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x000EB4A0 File Offset: 0x000E96A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111097, XrefRangeEnd = 111154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SinkOrSwim.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x000EB4DC File Offset: 0x000E96DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111154, XrefRangeEnd = 111158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x000EB510 File Offset: 0x000E9710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111158, XrefRangeEnd = 111181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x000EB544 File Offset: 0x000E9744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111181, XrefRangeEnd = 111188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnLoanSharkVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_SpawnLoanSharkVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x000EB578 File Offset: 0x000E9778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111188, XrefRangeEnd = 111226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckArrival()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_CheckArrival_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x000EB5AC File Offset: 0x000E97AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111226, XrefRangeEnd = 111230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SinkOrSwim.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x000EB604 File Offset: 0x000E9804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111262, RefRangeEnd = 111263, XrefRangeStart = 111230, XrefRangeEnd = 111262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_UpdateName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x000EB638 File Offset: 0x000E9838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111263, XrefRangeEnd = 111271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_SinkOrSwim() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0001219A File Offset: 0x0001039A
		public Quest_SinkOrSwim(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x000EB674 File Offset: 0x000E9874
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x000121A3 File Offset: 0x000103A3
		public unsafe static int DAYS_TO_COMPLETE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Quest_SinkOrSwim.NativeFieldInfoPtr_DAYS_TO_COMPLETE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_SinkOrSwim.NativeFieldInfoPtr_DAYS_TO_COMPLETE, (void*)(&value));
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x000EB690 File Offset: 0x000E9890
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x000121B1 File Offset: 0x000103B1
		public unsafe string QuestName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_QuestName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_QuestName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x000EB6B8 File Offset: 0x000E98B8
		// (set) Token: 0x06002203 RID: 8707 RVA: 0x000121D0 File Offset: 0x000103D0
		public unsafe int NelsonCallTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_NelsonCallTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_NelsonCallTime)) = value;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x000EB6E0 File Offset: 0x000E98E0
		// (set) Token: 0x06002205 RID: 8709 RVA: 0x000121EB File Offset: 0x000103EB
		public unsafe Transform LoanSharkVehiclePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkVehiclePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkVehiclePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x000EB710 File Offset: 0x000E9910
		// (set) Token: 0x06002207 RID: 8711 RVA: 0x0001220A File Offset: 0x0001040A
		public unsafe GameObject LoanSharkGraves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkGraves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkGraves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeFieldInfoPtr_DAYS_TO_COMPLETE;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeFieldInfoPtr_QuestName;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeFieldInfoPtr_NelsonCallTime;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeFieldInfoPtr_LoanSharkVehiclePosition;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeFieldInfoPtr_LoanSharkGraves;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x04001783 RID: 6019
		private static readonly IntPtr NativeMethodInfoPtr_SpawnLoanSharkVehicle_Private_Void_0;

		// Token: 0x04001784 RID: 6020
		private static readonly IntPtr NativeMethodInfoPtr_CheckArrival_Private_Void_0;

		// Token: 0x04001785 RID: 6021
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0;

		// Token: 0x04001786 RID: 6022
		private static readonly IntPtr NativeMethodInfoPtr_UpdateName_Private_Void_0;

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

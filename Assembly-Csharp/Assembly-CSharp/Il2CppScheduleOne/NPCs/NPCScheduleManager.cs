using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.NPCs.Other;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020005DE RID: 1502
	public class NPCScheduleManager : MonoBehaviour
	{
		// Token: 0x060093F2 RID: 37874 RVA: 0x0027FC58 File Offset: 0x0027DE58
		// Note: this type is marked as 'beforefieldinit'.
		static NPCScheduleManager()
		{
			Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCScheduleManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr);
			NPCScheduleManager.NativeFieldInfoPtr_orderByDescending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "orderByDescending");
			NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ScheduleEnabled>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<CurfewModeEnabled>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "DEBUG_MODE");
			NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ActiveAction>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<PendingActions>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<Npc>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "EnabledDuringCurfew");
			NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "EnabledDuringNoCurfew");
			NPCScheduleManager.NativeFieldInfoPtr__ActionList_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ActionList>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_discreteActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "discreteActions");
			NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ActionsAwaitingStart>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "lastProcessedTime");
			NPCScheduleManager.NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682618);
			NPCScheduleManager.NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682619);
			NPCScheduleManager.NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682620);
			NPCScheduleManager.NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682621);
			NPCScheduleManager.NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682622);
			NPCScheduleManager.NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682623);
			NPCScheduleManager.NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682624);
			NPCScheduleManager.NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682625);
			NPCScheduleManager.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682626);
			NPCScheduleManager.NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682627);
			NPCScheduleManager.NativeMethodInfoPtr_get_DiscreteActions_Public_get_List_1_NPCDiscreteAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682628);
			NPCScheduleManager.NativeMethodInfoPtr_get_ActionList_Public_get_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682629);
			NPCScheduleManager.NativeMethodInfoPtr_set_ActionList_Private_set_Void_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682630);
			NPCScheduleManager.NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682631);
			NPCScheduleManager.NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682632);
			NPCScheduleManager.NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682633);
			NPCScheduleManager.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682634);
			NPCScheduleManager.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682635);
			NPCScheduleManager.NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682636);
			NPCScheduleManager.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682637);
			NPCScheduleManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682638);
			NPCScheduleManager.NativeMethodInfoPtr_EnableSchedule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682639);
			NPCScheduleManager.NativeMethodInfoPtr_DisableSchedule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682640);
			NPCScheduleManager.NativeMethodInfoPtr_InitializeActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682641);
			NPCScheduleManager.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682642);
			NPCScheduleManager.NativeMethodInfoPtr_UpdateActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682643);
			NPCScheduleManager.NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682644);
			NPCScheduleManager.NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682645);
			NPCScheduleManager.NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682646);
			NPCScheduleManager.NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682647);
			NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682648);
			NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682649);
			NPCScheduleManager.NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682650);
			NPCScheduleManager.NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682651);
			NPCScheduleManager.NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682652);
			NPCScheduleManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100682653);
		}

		// Token: 0x17002DC5 RID: 11717
		// (get) Token: 0x060093F3 RID: 37875 RVA: 0x0028005C File Offset: 0x0027E25C
		// (set) Token: 0x060093F4 RID: 37876 RVA: 0x00280098 File Offset: 0x0027E298
		public unsafe bool ScheduleEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DC6 RID: 11718
		// (get) Token: 0x060093F5 RID: 37877 RVA: 0x002800D8 File Offset: 0x0027E2D8
		// (set) Token: 0x060093F6 RID: 37878 RVA: 0x00280114 File Offset: 0x0027E314
		public unsafe bool CurfewModeEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DC7 RID: 11719
		// (get) Token: 0x060093F7 RID: 37879 RVA: 0x00280154 File Offset: 0x0027E354
		// (set) Token: 0x060093F8 RID: 37880 RVA: 0x00280194 File Offset: 0x0027E394
		public unsafe NPCAction ActiveAction
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCAction>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x060093F9 RID: 37881 RVA: 0x002801D8 File Offset: 0x0027E3D8
		// (set) Token: 0x060093FA RID: 37882 RVA: 0x00280218 File Offset: 0x0027E418
		public unsafe List<NPCAction> PendingActions
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x060093FB RID: 37883 RVA: 0x0028025C File Offset: 0x0027E45C
		// (set) Token: 0x060093FC RID: 37884 RVA: 0x0028029C File Offset: 0x0027E49C
		public unsafe NPC Npc
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x060093FD RID: 37885 RVA: 0x002802E0 File Offset: 0x0027E4E0
		public unsafe List<NPCDiscreteAction> DiscreteActions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_DiscreteActions_Public_get_List_1_NPCDiscreteAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCDiscreteAction>>(intPtr3) : null;
			}
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x060093FE RID: 37886 RVA: 0x00280320 File Offset: 0x0027E520
		// (set) Token: 0x060093FF RID: 37887 RVA: 0x00280360 File Offset: 0x0027E560
		public unsafe List<NPCAction> ActionList
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ActionList_Public_get_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ActionList_Private_set_Void_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x06009400 RID: 37888 RVA: 0x002803A4 File Offset: 0x0027E5A4
		// (set) Token: 0x06009401 RID: 37889 RVA: 0x002803E4 File Offset: 0x0027E5E4
		public unsafe List<NPCAction> ActionsAwaitingStart
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DCD RID: 11725
		// (get) Token: 0x06009402 RID: 37890 RVA: 0x00280428 File Offset: 0x0027E628
		public unsafe TimeManager Time
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 270921, RefRangeEnd = 270927, XrefRangeStart = 270918, XrefRangeEnd = 270921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr3) : null;
			}
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x00280468 File Offset: 0x0027E668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270927, XrefRangeEnd = 270933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x002804A4 File Offset: 0x0027E6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270933, XrefRangeEnd = 271029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009405 RID: 37893 RVA: 0x002804E0 File Offset: 0x0027E6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271029, XrefRangeEnd = 271031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009406 RID: 37894 RVA: 0x00280514 File Offset: 0x0027E714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271031, XrefRangeEnd = 271035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x00280548 File Offset: 0x0027E748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271035, XrefRangeEnd = 271039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009408 RID: 37896 RVA: 0x00280584 File Offset: 0x0027E784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271039, RefRangeEnd = 271041, XrefRangeStart = 271039, XrefRangeEnd = 271039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableSchedule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnableSchedule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009409 RID: 37897 RVA: 0x002805B8 File Offset: 0x0027E7B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271055, RefRangeEnd = 271057, XrefRangeStart = 271041, XrefRangeEnd = 271055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableSchedule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_DisableSchedule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x002805EC File Offset: 0x0027E7EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271110, RefRangeEnd = 271113, XrefRangeStart = 271057, XrefRangeEnd = 271110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_InitializeActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940B RID: 37899 RVA: 0x00280620 File Offset: 0x0027E820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271113, XrefRangeEnd = 271123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x0028065C File Offset: 0x0027E85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271243, RefRangeEnd = 271244, XrefRangeStart = 271123, XrefRangeEnd = 271243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_UpdateActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x00280690 File Offset: 0x0027E890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271244, XrefRangeEnd = 271245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x002806CC File Offset: 0x0027E8CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271284, RefRangeEnd = 271286, XrefRangeStart = 271245, XrefRangeEnd = 271284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPCAction> GetActionsOccurringAt(int time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
		}

		// Token: 0x0600940F RID: 37903 RVA: 0x00280718 File Offset: 0x0027E918
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271323, RefRangeEnd = 271325, XrefRangeStart = 271286, XrefRangeEnd = 271323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPCAction> GetActionsTotallyOccurringWithinRange(int min, int max, bool checkShouldStart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkShouldStart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr3) : null;
		}

		// Token: 0x06009410 RID: 37904 RVA: 0x00280780 File Offset: 0x0027E980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271346, RefRangeEnd = 271347, XrefRangeStart = 271325, XrefRangeEnd = 271346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction(NPCAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009411 RID: 37905 RVA: 0x002807C4 File Offset: 0x0027E9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271347, XrefRangeEnd = 271353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009412 RID: 37906 RVA: 0x002807F8 File Offset: 0x0027E9F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271475, RefRangeEnd = 271477, XrefRangeStart = 271353, XrefRangeEnd = 271475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceState(bool initial = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref initial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009413 RID: 37907 RVA: 0x00280838 File Offset: 0x0027EA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271477, XrefRangeEnd = 271478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurfewEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009414 RID: 37908 RVA: 0x00280874 File Offset: 0x0027EA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271478, XrefRangeEnd = 271479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurfewDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009415 RID: 37909 RVA: 0x002808B0 File Offset: 0x0027EAB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271492, RefRangeEnd = 271495, XrefRangeStart = 271479, XrefRangeEnd = 271492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurfewModeEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009416 RID: 37910 RVA: 0x002808F0 File Offset: 0x0027EAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271495, XrefRangeEnd = 271520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCScheduleManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x0004551C File Offset: 0x0004371C
		public NPCScheduleManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x06009418 RID: 37912 RVA: 0x0028092C File Offset: 0x0027EB2C
		// (set) Token: 0x06009419 RID: 37913 RVA: 0x00045525 File Offset: 0x00043725
		public unsafe static NPCActionOrderByDescending orderByDescending
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.NativeFieldInfoPtr_orderByDescending, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCActionOrderByDescending>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.NativeFieldInfoPtr_orderByDescending, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x0600941A RID: 37914 RVA: 0x00280954 File Offset: 0x0027EB54
		// (set) Token: 0x0600941B RID: 37915 RVA: 0x00045537 File Offset: 0x00043737
		public unsafe bool _ScheduleEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x0600941C RID: 37916 RVA: 0x0028097C File Offset: 0x0027EB7C
		// (set) Token: 0x0600941D RID: 37917 RVA: 0x00045552 File Offset: 0x00043752
		public unsafe bool _CurfewModeEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x0600941E RID: 37918 RVA: 0x002809A4 File Offset: 0x0027EBA4
		// (set) Token: 0x0600941F RID: 37919 RVA: 0x0004556D File Offset: 0x0004376D
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x06009420 RID: 37920 RVA: 0x002809CC File Offset: 0x0027EBCC
		// (set) Token: 0x06009421 RID: 37921 RVA: 0x00045588 File Offset: 0x00043788
		public unsafe NPCAction _ActiveAction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x06009422 RID: 37922 RVA: 0x002809FC File Offset: 0x0027EBFC
		// (set) Token: 0x06009423 RID: 37923 RVA: 0x000455A7 File Offset: 0x000437A7
		public unsafe List<NPCAction> _PendingActions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x06009424 RID: 37924 RVA: 0x00280A2C File Offset: 0x0027EC2C
		// (set) Token: 0x06009425 RID: 37925 RVA: 0x000455C6 File Offset: 0x000437C6
		public unsafe NPC _Npc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x06009426 RID: 37926 RVA: 0x00280A5C File Offset: 0x0027EC5C
		// (set) Token: 0x06009427 RID: 37927 RVA: 0x000455E5 File Offset: 0x000437E5
		public unsafe Il2CppReferenceArray<GameObject> EnabledDuringCurfew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x06009428 RID: 37928 RVA: 0x00280A8C File Offset: 0x0027EC8C
		// (set) Token: 0x06009429 RID: 37929 RVA: 0x00045604 File Offset: 0x00043804
		public unsafe Il2CppReferenceArray<GameObject> EnabledDuringNoCurfew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x0600942A RID: 37930 RVA: 0x00280ABC File Offset: 0x0027ECBC
		// (set) Token: 0x0600942B RID: 37931 RVA: 0x00045623 File Offset: 0x00043823
		public unsafe List<NPCAction> _ActionList_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActionList_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActionList_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC2 RID: 11714
		// (get) Token: 0x0600942C RID: 37932 RVA: 0x00280AEC File Offset: 0x0027ECEC
		// (set) Token: 0x0600942D RID: 37933 RVA: 0x00045642 File Offset: 0x00043842
		public unsafe List<NPCDiscreteAction> discreteActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_discreteActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCDiscreteAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_discreteActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC3 RID: 11715
		// (get) Token: 0x0600942E RID: 37934 RVA: 0x00280B1C File Offset: 0x0027ED1C
		// (set) Token: 0x0600942F RID: 37935 RVA: 0x00045661 File Offset: 0x00043861
		public unsafe List<NPCAction> _ActionsAwaitingStart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DC4 RID: 11716
		// (get) Token: 0x06009430 RID: 37936 RVA: 0x00280B4C File Offset: 0x0027ED4C
		// (set) Token: 0x06009431 RID: 37937 RVA: 0x00045680 File Offset: 0x00043880
		public unsafe int lastProcessedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime)) = value;
			}
		}

		// Token: 0x040065E1 RID: 26081
		private static readonly IntPtr NativeFieldInfoPtr_orderByDescending;

		// Token: 0x040065E2 RID: 26082
		private static readonly IntPtr NativeFieldInfoPtr__ScheduleEnabled_k__BackingField;

		// Token: 0x040065E3 RID: 26083
		private static readonly IntPtr NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField;

		// Token: 0x040065E4 RID: 26084
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x040065E5 RID: 26085
		private static readonly IntPtr NativeFieldInfoPtr__ActiveAction_k__BackingField;

		// Token: 0x040065E6 RID: 26086
		private static readonly IntPtr NativeFieldInfoPtr__PendingActions_k__BackingField;

		// Token: 0x040065E7 RID: 26087
		private static readonly IntPtr NativeFieldInfoPtr__Npc_k__BackingField;

		// Token: 0x040065E8 RID: 26088
		private static readonly IntPtr NativeFieldInfoPtr_EnabledDuringCurfew;

		// Token: 0x040065E9 RID: 26089
		private static readonly IntPtr NativeFieldInfoPtr_EnabledDuringNoCurfew;

		// Token: 0x040065EA RID: 26090
		private static readonly IntPtr NativeFieldInfoPtr__ActionList_k__BackingField;

		// Token: 0x040065EB RID: 26091
		private static readonly IntPtr NativeFieldInfoPtr_discreteActions;

		// Token: 0x040065EC RID: 26092
		private static readonly IntPtr NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField;

		// Token: 0x040065ED RID: 26093
		private static readonly IntPtr NativeFieldInfoPtr_lastProcessedTime;

		// Token: 0x040065EE RID: 26094
		private static readonly IntPtr NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0;

		// Token: 0x040065EF RID: 26095
		private static readonly IntPtr NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x040065F0 RID: 26096
		private static readonly IntPtr NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0;

		// Token: 0x040065F1 RID: 26097
		private static readonly IntPtr NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x040065F2 RID: 26098
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0;

		// Token: 0x040065F3 RID: 26099
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0;

		// Token: 0x040065F4 RID: 26100
		private static readonly IntPtr NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0;

		// Token: 0x040065F5 RID: 26101
		private static readonly IntPtr NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0;

		// Token: 0x040065F6 RID: 26102
		private static readonly IntPtr NativeMethodInfoPtr_get_Npc_Public_get_NPC_0;

		// Token: 0x040065F7 RID: 26103
		private static readonly IntPtr NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0;

		// Token: 0x040065F8 RID: 26104
		private static readonly IntPtr NativeMethodInfoPtr_get_DiscreteActions_Public_get_List_1_NPCDiscreteAction_0;

		// Token: 0x040065F9 RID: 26105
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionList_Public_get_List_1_NPCAction_0;

		// Token: 0x040065FA RID: 26106
		private static readonly IntPtr NativeMethodInfoPtr_set_ActionList_Private_set_Void_List_1_NPCAction_0;

		// Token: 0x040065FB RID: 26107
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0;

		// Token: 0x040065FC RID: 26108
		private static readonly IntPtr NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0;

		// Token: 0x040065FD RID: 26109
		private static readonly IntPtr NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0;

		// Token: 0x040065FE RID: 26110
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040065FF RID: 26111
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006600 RID: 26112
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0;

		// Token: 0x04006601 RID: 26113
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006602 RID: 26114
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006603 RID: 26115
		private static readonly IntPtr NativeMethodInfoPtr_EnableSchedule_Public_Void_0;

		// Token: 0x04006604 RID: 26116
		private static readonly IntPtr NativeMethodInfoPtr_DisableSchedule_Public_Void_0;

		// Token: 0x04006605 RID: 26117
		private static readonly IntPtr NativeMethodInfoPtr_InitializeActions_Public_Void_0;

		// Token: 0x04006606 RID: 26118
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04006607 RID: 26119
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActions_Private_Void_0;

		// Token: 0x04006608 RID: 26120
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_0;

		// Token: 0x04006609 RID: 26121
		private static readonly IntPtr NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0;

		// Token: 0x0400660A RID: 26122
		private static readonly IntPtr NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0;

		// Token: 0x0400660B RID: 26123
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0;

		// Token: 0x0400660C RID: 26124
		private static readonly IntPtr NativeMethodInfoPtr_EnforceState_Private_Void_0;

		// Token: 0x0400660D RID: 26125
		private static readonly IntPtr NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0;

		// Token: 0x0400660E RID: 26126
		private static readonly IntPtr NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0;

		// Token: 0x0400660F RID: 26127
		private static readonly IntPtr NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0;

		// Token: 0x04006610 RID: 26128
		private static readonly IntPtr NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0;

		// Token: 0x04006611 RID: 26129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C30 RID: 3120
		[ObfuscatedName("ScheduleOne.NPCs.NPCScheduleManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EEFF RID: 61183 RVA: 0x0039C514 File Offset: 0x0039A714
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr);
				NPCScheduleManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9");
				NPCScheduleManager.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9__45_0");
				NPCScheduleManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100682656);
				NPCScheduleManager.__c.NativeMethodInfoPtr__InitializeActions_b__45_0_Internal_Int32_NPCAction_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100682657);
			}

			// Token: 0x0600EF00 RID: 61184 RVA: 0x0039C590 File Offset: 0x0039A790
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF01 RID: 61185 RVA: 0x0039C5CC File Offset: 0x0039A7CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270896, XrefRangeEnd = 270898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InitializeActions_b__45_0(NPCAction a, NPCAction b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__InitializeActions_b__45_0_Internal_Int32_NPCAction_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EF02 RID: 61186 RVA: 0x00070D57 File Offset: 0x0006EF57
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004874 RID: 18548
			// (get) Token: 0x0600EF03 RID: 61187 RVA: 0x0039C62C File Offset: 0x0039A82C
			// (set) Token: 0x0600EF04 RID: 61188 RVA: 0x00070D60 File Offset: 0x0006EF60
			public unsafe static NPCScheduleManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCScheduleManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004875 RID: 18549
			// (get) Token: 0x0600EF05 RID: 61189 RVA: 0x0039C654 File Offset: 0x0039A854
			// (set) Token: 0x0600EF06 RID: 61190 RVA: 0x00070D72 File Offset: 0x0006EF72
			public unsafe static Comparison<NPCAction> __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<NPCAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A1CB RID: 41419
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A1CC RID: 41420
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x0400A1CD RID: 41421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A1CE RID: 41422
			private static readonly IntPtr NativeMethodInfoPtr__InitializeActions_b__45_0_Internal_Int32_NPCAction_NPCAction_0;
		}

		// Token: 0x02000C31 RID: 3121
		[ObfuscatedName("ScheduleOne.NPCs.NPCScheduleManager+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EF07 RID: 61191 RVA: 0x0039C67C File Offset: 0x0039A87C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass53_0>.NativeClassPtr);
				NPCScheduleManager.__c__DisplayClass53_0.NativeFieldInfoPtr_actionsOccurringThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass53_0>.NativeClassPtr, "actionsOccurringThisFrame");
				NPCScheduleManager.__c__DisplayClass53_0.NativeFieldInfoPtr_skippedActionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass53_0>.NativeClassPtr, "skippedActionOrder");
				NPCScheduleManager.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass53_0>.NativeClassPtr, 100682658);
				NPCScheduleManager.__c__DisplayClass53_0.NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass53_0>.NativeClassPtr, 100682659);
				NPCScheduleManager.__c__DisplayClass53_0.NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass53_0>.NativeClassPtr, 100682660);
			}

			// Token: 0x0600EF08 RID: 61192 RVA: 0x0039C70C File Offset: 0x0039A90C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF09 RID: 61193 RVA: 0x0039C748 File Offset: 0x0039A948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270898, XrefRangeEnd = 270900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EnforceState_b__0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass53_0.NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EF0A RID: 61194 RVA: 0x0039C798 File Offset: 0x0039A998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270900, XrefRangeEnd = 270918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _EnforceState_b__1(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass53_0.NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EF0B RID: 61195 RVA: 0x00070D84 File Offset: 0x0006EF84
			public __c__DisplayClass53_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004876 RID: 18550
			// (get) Token: 0x0600EF0C RID: 61196 RVA: 0x0039C7E8 File Offset: 0x0039A9E8
			// (set) Token: 0x0600EF0D RID: 61197 RVA: 0x00070D8D File Offset: 0x0006EF8D
			public unsafe List<NPCAction> actionsOccurringThisFrame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass53_0.NativeFieldInfoPtr_actionsOccurringThisFrame);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass53_0.NativeFieldInfoPtr_actionsOccurringThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004877 RID: 18551
			// (get) Token: 0x0600EF0E RID: 61198 RVA: 0x0039C818 File Offset: 0x0039AA18
			// (set) Token: 0x0600EF0F RID: 61199 RVA: 0x00070DAC File Offset: 0x0006EFAC
			public unsafe Dictionary<NPCAction, float> skippedActionOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass53_0.NativeFieldInfoPtr_skippedActionOrder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NPCAction, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass53_0.NativeFieldInfoPtr_skippedActionOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A1CF RID: 41423
			private static readonly IntPtr NativeFieldInfoPtr_actionsOccurringThisFrame;

			// Token: 0x0400A1D0 RID: 41424
			private static readonly IntPtr NativeFieldInfoPtr_skippedActionOrder;

			// Token: 0x0400A1D1 RID: 41425
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A1D2 RID: 41426
			private static readonly IntPtr NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0;

			// Token: 0x0400A1D3 RID: 41427
			private static readonly IntPtr NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0;
		}
	}
}

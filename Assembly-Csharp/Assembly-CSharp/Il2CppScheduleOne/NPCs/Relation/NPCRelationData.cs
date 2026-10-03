using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x020005E3 RID: 1507
	[Serializable]
	public class NPCRelationData : Object
	{
		// Token: 0x06009489 RID: 38025 RVA: 0x00282108 File Offset: 0x00280308
		// Note: this type is marked as 'beforefieldinit'.
		static NPCRelationData()
		{
			Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "NPCRelationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr);
			NPCRelationData.NativeFieldInfoPtr_MinRelationship = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "MinRelationship");
			NPCRelationData.NativeFieldInfoPtr_MaxRelationship = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "MaxRelationship");
			NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<RelationDelta>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<Unlocked>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<UnlockType>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<NPC>k__BackingField");
			NPCRelationData.NativeFieldInfoPtr_Connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "Connections");
			NPCRelationData.NativeFieldInfoPtr_OnRelationshipChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "OnRelationshipChange");
			NPCRelationData.NativeFieldInfoPtr_OnUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "OnUnlocked");
			NPCRelationData.NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682713);
			NPCRelationData.NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682714);
			NPCRelationData.NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682715);
			NPCRelationData.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682716);
			NPCRelationData.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682717);
			NPCRelationData.NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682718);
			NPCRelationData.NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682719);
			NPCRelationData.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682720);
			NPCRelationData.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682721);
			NPCRelationData.NativeMethodInfoPtr_add_OnRelationshipChange_Public_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682722);
			NPCRelationData.NativeMethodInfoPtr_remove_OnRelationshipChange_Public_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682723);
			NPCRelationData.NativeMethodInfoPtr_add_OnUnlocked_Public_add_Void_Action_2_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682724);
			NPCRelationData.NativeMethodInfoPtr_remove_OnUnlocked_Public_rem_Void_Action_2_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682725);
			NPCRelationData.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682726);
			NPCRelationData.NativeMethodInfoPtr_Init_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682727);
			NPCRelationData.NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682728);
			NPCRelationData.NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682729);
			NPCRelationData.NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682730);
			NPCRelationData.NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682731);
			NPCRelationData.NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682732);
			NPCRelationData.NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682733);
			NPCRelationData.NativeMethodInfoPtr_IsKnown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682734);
			NPCRelationData.NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682735);
			NPCRelationData.NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682736);
			NPCRelationData.NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682737);
			NPCRelationData.NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682738);
			NPCRelationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, 100682739);
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0600948A RID: 38026 RVA: 0x00282408 File Offset: 0x00280608
		// (set) Token: 0x0600948B RID: 38027 RVA: 0x00282444 File Offset: 0x00280644
		public unsafe float RelationDelta
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 29030, RefRangeEnd = 29033, XrefRangeStart = 29030, XrefRangeEnd = 29033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0600948C RID: 38028 RVA: 0x00282484 File Offset: 0x00280684
		public unsafe float NormalizedRelationDelta
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 271777, RefRangeEnd = 271788, XrefRangeStart = 271777, XrefRangeEnd = 271777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x0600948D RID: 38029 RVA: 0x002824C0 File Offset: 0x002806C0
		// (set) Token: 0x0600948E RID: 38030 RVA: 0x002824FC File Offset: 0x002806FC
		public unsafe bool Unlocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x0600948F RID: 38031 RVA: 0x0028253C File Offset: 0x0028073C
		// (set) Token: 0x06009490 RID: 38032 RVA: 0x00282578 File Offset: 0x00280778
		public unsafe NPCRelationData.EUnlockType UnlockType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3891, RefRangeEnd = 3894, XrefRangeStart = 3891, XrefRangeEnd = 3894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29109, RefRangeEnd = 29110, XrefRangeStart = 29109, XrefRangeEnd = 29110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x06009491 RID: 38033 RVA: 0x002825B8 File Offset: 0x002807B8
		// (set) Token: 0x06009492 RID: 38034 RVA: 0x002825F8 File Offset: 0x002807F8
		public unsafe NPC NPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x0028263C File Offset: 0x0028083C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271793, RefRangeEnd = 271795, XrefRangeStart = 271788, XrefRangeEnd = 271793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRelationshipChange(Action<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_add_OnRelationshipChange_Public_add_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x00282680 File Offset: 0x00280880
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271800, RefRangeEnd = 271802, XrefRangeStart = 271795, XrefRangeEnd = 271800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRelationshipChange(Action<float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_remove_OnRelationshipChange_Public_rem_Void_Action_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009495 RID: 38037 RVA: 0x002826C4 File Offset: 0x002808C4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 271807, RefRangeEnd = 271818, XrefRangeStart = 271802, XrefRangeEnd = 271807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnUnlocked(Action<NPCRelationData.EUnlockType, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_add_OnUnlocked_Public_add_Void_Action_2_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x00282708 File Offset: 0x00280908
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271823, RefRangeEnd = 271825, XrefRangeStart = 271818, XrefRangeEnd = 271823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnUnlocked(Action<NPCRelationData.EUnlockType, bool> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_remove_OnUnlocked_Public_rem_Void_Action_2_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x0028274C File Offset: 0x0028094C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009498 RID: 38040 RVA: 0x00282790 File Offset: 0x00280990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271877, RefRangeEnd = 271878, XrefRangeStart = 271825, XrefRangeEnd = 271877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_Init_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009499 RID: 38041 RVA: 0x002827D4 File Offset: 0x002809D4
		[CallerCount(0)]
		public unsafe virtual void ChangeRelationship(float deltaChange, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deltaChange;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600949A RID: 38042 RVA: 0x0028282C File Offset: 0x00280A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271878, XrefRangeEnd = 271880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRelationship(float newDelta, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newDelta;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600949B RID: 38043 RVA: 0x00282884 File Offset: 0x00280A84
		[CallerCount(0)]
		public unsafe virtual void Unlock(NPCRelationData.EUnlockType type, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x002828DC File Offset: 0x00280ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271880, XrefRangeEnd = 271887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnlockConnections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCRelationData.NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600949D RID: 38045 RVA: 0x00282918 File Offset: 0x00280B18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271891, RefRangeEnd = 271892, XrefRangeStart = 271887, XrefRangeEnd = 271891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RelationshipData>(intPtr3) : null;
		}

		// Token: 0x0600949E RID: 38046 RVA: 0x00282958 File Offset: 0x00280B58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271899, RefRangeEnd = 271901, XrefRangeStart = 271892, XrefRangeEnd = 271899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageMutualRelationship()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600949F RID: 38047 RVA: 0x00282994 File Offset: 0x00280B94
		[CallerCount(0)]
		public unsafe bool IsKnown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_IsKnown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060094A0 RID: 38048 RVA: 0x002829D0 File Offset: 0x00280BD0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 271912, RefRangeEnd = 271920, XrefRangeStart = 271901, XrefRangeEnd = 271912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMutuallyKnown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060094A1 RID: 38049 RVA: 0x00282A0C File Offset: 0x00280C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271920, XrefRangeEnd = 271934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedConnections(bool excludeCustomers = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref excludeCustomers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x060094A2 RID: 38050 RVA: 0x00282A58 File Offset: 0x00280C58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271948, RefRangeEnd = 271949, XrefRangeStart = 271934, XrefRangeEnd = 271948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedDealers(bool excludeRecommended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref excludeRecommended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x060094A3 RID: 38051 RVA: 0x00282AA4 File Offset: 0x00280CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 271968, RefRangeEnd = 271969, XrefRangeStart = 271949, XrefRangeEnd = 271968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetLockedSuppliers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x060094A4 RID: 38052 RVA: 0x00282AE4 File Offset: 0x00280CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271969, XrefRangeEnd = 271977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCRelationData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060094A5 RID: 38053 RVA: 0x00045811 File Offset: 0x00043A11
		public NPCRelationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DE2 RID: 11746
		// (get) Token: 0x060094A6 RID: 38054 RVA: 0x00282B20 File Offset: 0x00280D20
		// (set) Token: 0x060094A7 RID: 38055 RVA: 0x0004581A File Offset: 0x00043A1A
		public unsafe static float MinRelationship
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCRelationData.NativeFieldInfoPtr_MinRelationship, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCRelationData.NativeFieldInfoPtr_MinRelationship, (void*)(&value));
			}
		}

		// Token: 0x17002DE3 RID: 11747
		// (get) Token: 0x060094A8 RID: 38056 RVA: 0x00282B3C File Offset: 0x00280D3C
		// (set) Token: 0x060094A9 RID: 38057 RVA: 0x00045828 File Offset: 0x00043A28
		public unsafe static float MaxRelationship
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCRelationData.NativeFieldInfoPtr_MaxRelationship, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCRelationData.NativeFieldInfoPtr_MaxRelationship, (void*)(&value));
			}
		}

		// Token: 0x17002DE4 RID: 11748
		// (get) Token: 0x060094AA RID: 38058 RVA: 0x00282B58 File Offset: 0x00280D58
		// (set) Token: 0x060094AB RID: 38059 RVA: 0x00045836 File Offset: 0x00043A36
		public unsafe float _RelationDelta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__RelationDelta_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DE5 RID: 11749
		// (get) Token: 0x060094AC RID: 38060 RVA: 0x00282B80 File Offset: 0x00280D80
		// (set) Token: 0x060094AD RID: 38061 RVA: 0x00045851 File Offset: 0x00043A51
		public unsafe bool _Unlocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__Unlocked_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x060094AE RID: 38062 RVA: 0x00282BA8 File Offset: 0x00280DA8
		// (set) Token: 0x060094AF RID: 38063 RVA: 0x0004586C File Offset: 0x00043A6C
		public unsafe NPCRelationData.EUnlockType _UnlockType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__UnlockType_k__BackingField)) = value;
			}
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x060094B0 RID: 38064 RVA: 0x00282BD0 File Offset: 0x00280DD0
		// (set) Token: 0x060094B1 RID: 38065 RVA: 0x00045887 File Offset: 0x00043A87
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x060094B2 RID: 38066 RVA: 0x00282C00 File Offset: 0x00280E00
		// (set) Token: 0x060094B3 RID: 38067 RVA: 0x000458A6 File Offset: 0x00043AA6
		public unsafe List<NPC> Connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_Connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_Connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x060094B4 RID: 38068 RVA: 0x00282C30 File Offset: 0x00280E30
		// (set) Token: 0x060094B5 RID: 38069 RVA: 0x000458C5 File Offset: 0x00043AC5
		public unsafe Action<float> OnRelationshipChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_OnRelationshipChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_OnRelationshipChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x060094B6 RID: 38070 RVA: 0x00282C60 File Offset: 0x00280E60
		// (set) Token: 0x060094B7 RID: 38071 RVA: 0x000458E4 File Offset: 0x00043AE4
		public unsafe Action<NPCRelationData.EUnlockType, bool> OnUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_OnUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NPCRelationData.EUnlockType, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.NativeFieldInfoPtr_OnUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006657 RID: 26199
		private static readonly IntPtr NativeFieldInfoPtr_MinRelationship;

		// Token: 0x04006658 RID: 26200
		private static readonly IntPtr NativeFieldInfoPtr_MaxRelationship;

		// Token: 0x04006659 RID: 26201
		private static readonly IntPtr NativeFieldInfoPtr__RelationDelta_k__BackingField;

		// Token: 0x0400665A RID: 26202
		private static readonly IntPtr NativeFieldInfoPtr__Unlocked_k__BackingField;

		// Token: 0x0400665B RID: 26203
		private static readonly IntPtr NativeFieldInfoPtr__UnlockType_k__BackingField;

		// Token: 0x0400665C RID: 26204
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x0400665D RID: 26205
		private static readonly IntPtr NativeFieldInfoPtr_Connections;

		// Token: 0x0400665E RID: 26206
		private static readonly IntPtr NativeFieldInfoPtr_OnRelationshipChange;

		// Token: 0x0400665F RID: 26207
		private static readonly IntPtr NativeFieldInfoPtr_OnUnlocked;

		// Token: 0x04006660 RID: 26208
		private static readonly IntPtr NativeMethodInfoPtr_get_RelationDelta_Public_get_Single_0;

		// Token: 0x04006661 RID: 26209
		private static readonly IntPtr NativeMethodInfoPtr_set_RelationDelta_Protected_set_Void_Single_0;

		// Token: 0x04006662 RID: 26210
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedRelationDelta_Public_get_Single_0;

		// Token: 0x04006663 RID: 26211
		private static readonly IntPtr NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0;

		// Token: 0x04006664 RID: 26212
		private static readonly IntPtr NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0;

		// Token: 0x04006665 RID: 26213
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockType_Public_get_EUnlockType_0;

		// Token: 0x04006666 RID: 26214
		private static readonly IntPtr NativeMethodInfoPtr_set_UnlockType_Protected_set_Void_EUnlockType_0;

		// Token: 0x04006667 RID: 26215
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x04006668 RID: 26216
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x04006669 RID: 26217
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRelationshipChange_Public_add_Void_Action_1_Single_0;

		// Token: 0x0400666A RID: 26218
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRelationshipChange_Public_rem_Void_Action_1_Single_0;

		// Token: 0x0400666B RID: 26219
		private static readonly IntPtr NativeMethodInfoPtr_add_OnUnlocked_Public_add_Void_Action_2_EUnlockType_Boolean_0;

		// Token: 0x0400666C RID: 26220
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnUnlocked_Public_rem_Void_Action_2_EUnlockType_Boolean_0;

		// Token: 0x0400666D RID: 26221
		private static readonly IntPtr NativeMethodInfoPtr_SetNPC_Public_Void_NPC_0;

		// Token: 0x0400666E RID: 26222
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_NPC_0;

		// Token: 0x0400666F RID: 26223
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRelationship_Public_Virtual_New_Void_Single_Boolean_0;

		// Token: 0x04006670 RID: 26224
		private static readonly IntPtr NativeMethodInfoPtr_SetRelationship_Public_Virtual_New_Void_Single_Boolean_0;

		// Token: 0x04006671 RID: 26225
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Public_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x04006672 RID: 26226
		private static readonly IntPtr NativeMethodInfoPtr_UnlockConnections_Public_Virtual_New_Void_0;

		// Token: 0x04006673 RID: 26227
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_RelationshipData_0;

		// Token: 0x04006674 RID: 26228
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageMutualRelationship_Public_Single_0;

		// Token: 0x04006675 RID: 26229
		private static readonly IntPtr NativeMethodInfoPtr_IsKnown_Public_Boolean_0;

		// Token: 0x04006676 RID: 26230
		private static readonly IntPtr NativeMethodInfoPtr_IsMutuallyKnown_Public_Boolean_0;

		// Token: 0x04006677 RID: 26231
		private static readonly IntPtr NativeMethodInfoPtr_GetLockedConnections_Public_List_1_NPC_Boolean_0;

		// Token: 0x04006678 RID: 26232
		private static readonly IntPtr NativeMethodInfoPtr_GetLockedDealers_Public_List_1_NPC_Boolean_0;

		// Token: 0x04006679 RID: 26233
		private static readonly IntPtr NativeMethodInfoPtr_GetLockedSuppliers_Public_List_1_NPC_0;

		// Token: 0x0400667A RID: 26234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C35 RID: 3125
		[OriginalName("Assembly-CSharp.dll", "", "EUnlockType")]
		public enum EUnlockType
		{
			// Token: 0x0400A1EA RID: 41450
			Recommendation,
			// Token: 0x0400A1EB RID: 41451
			DirectApproach
		}

		// Token: 0x02000C36 RID: 3126
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600EF20 RID: 61216 RVA: 0x0039CB60 File Offset: 0x0039AD60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr);
				NPCRelationData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, "<>9");
				NPCRelationData.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, "<>9__40_0");
				NPCRelationData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, 100682741);
				NPCRelationData.__c.NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr, 100682742);
			}

			// Token: 0x0600EF21 RID: 61217 RVA: 0x0039CBDC File Offset: 0x0039ADDC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF22 RID: 61218 RVA: 0x0039CC18 File Offset: 0x0039AE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271772, XrefRangeEnd = 271773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedSuppliers_b__40_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c.NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EF23 RID: 61219 RVA: 0x00070E4C File Offset: 0x0006F04C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700487E RID: 18558
			// (get) Token: 0x0600EF24 RID: 61220 RVA: 0x0039CC68 File Offset: 0x0039AE68
			// (set) Token: 0x0600EF25 RID: 61221 RVA: 0x00070E55 File Offset: 0x0006F055
			public unsafe static NPCRelationData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCRelationData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCRelationData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCRelationData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700487F RID: 18559
			// (get) Token: 0x0600EF26 RID: 61222 RVA: 0x0039CC90 File Offset: 0x0039AE90
			// (set) Token: 0x0600EF27 RID: 61223 RVA: 0x00070E67 File Offset: 0x0006F067
			public unsafe static Predicate<NPC> __9__40_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCRelationData.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<NPC>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCRelationData.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A1EC RID: 41452
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A1ED RID: 41453
			private static readonly IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x0400A1EE RID: 41454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A1EF RID: 41455
			private static readonly IntPtr NativeMethodInfoPtr__GetLockedSuppliers_b__40_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000C37 RID: 3127
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Object
		{
			// Token: 0x0600EF28 RID: 61224 RVA: 0x0039CCB8 File Offset: 0x0039AEB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr);
				NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, "excludeCustomers");
				NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, 100682743);
				NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr, 100682744);
			}

			// Token: 0x0600EF29 RID: 61225 RVA: 0x0039CD20 File Offset: 0x0039AF20
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass38_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF2A RID: 61226 RVA: 0x0039CD5C File Offset: 0x0039AF5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271773, XrefRangeEnd = 271775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedConnections_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass38_0.NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EF2B RID: 61227 RVA: 0x00070E79 File Offset: 0x0006F079
			public __c__DisplayClass38_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004880 RID: 18560
			// (get) Token: 0x0600EF2C RID: 61228 RVA: 0x0039CDAC File Offset: 0x0039AFAC
			// (set) Token: 0x0600EF2D RID: 61229 RVA: 0x00070E82 File Offset: 0x0006F082
			public unsafe bool excludeCustomers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass38_0.NativeFieldInfoPtr_excludeCustomers)) = value;
				}
			}

			// Token: 0x0400A1F0 RID: 41456
			private static readonly IntPtr NativeFieldInfoPtr_excludeCustomers;

			// Token: 0x0400A1F1 RID: 41457
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A1F2 RID: 41458
			private static readonly IntPtr NativeMethodInfoPtr__GetLockedConnections_b__0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000C38 RID: 3128
		[ObfuscatedName("ScheduleOne.NPCs.Relation.NPCRelationData+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Object
		{
			// Token: 0x0600EF2E RID: 61230 RVA: 0x0039CDD4 File Offset: 0x0039AFD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCRelationData>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr);
				NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, "excludeRecommended");
				NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, 100682745);
				NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr, 100682746);
			}

			// Token: 0x0600EF2F RID: 61231 RVA: 0x0039CE3C File Offset: 0x0039B03C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCRelationData.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF30 RID: 61232 RVA: 0x0039CE78 File Offset: 0x0039B078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271775, XrefRangeEnd = 271777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLockedDealers_b__0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCRelationData.__c__DisplayClass39_0.NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EF31 RID: 61233 RVA: 0x00070E9D File Offset: 0x0006F09D
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004881 RID: 18561
			// (get) Token: 0x0600EF32 RID: 61234 RVA: 0x0039CEC8 File Offset: 0x0039B0C8
			// (set) Token: 0x0600EF33 RID: 61235 RVA: 0x00070EA6 File Offset: 0x0006F0A6
			public unsafe bool excludeRecommended
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCRelationData.__c__DisplayClass39_0.NativeFieldInfoPtr_excludeRecommended)) = value;
				}
			}

			// Token: 0x0400A1F3 RID: 41459
			private static readonly IntPtr NativeFieldInfoPtr_excludeRecommended;

			// Token: 0x0400A1F4 RID: 41460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A1F5 RID: 41461
			private static readonly IntPtr NativeMethodInfoPtr__GetLockedDealers_b__0_Internal_Boolean_NPC_0;
		}
	}
}

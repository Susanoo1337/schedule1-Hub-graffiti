using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.NPCs.Actions;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Responses
{
	// Token: 0x020005DF RID: 1503
	public class NPCResponses : MonoBehaviour
	{
		// Token: 0x06009432 RID: 37938 RVA: 0x00280B74 File Offset: 0x0027ED74
		// Note: this type is marked as 'beforefieldinit'.
		static NPCResponses()
		{
			Il2CppClassPointerStore<NPCResponses>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Responses", "NPCResponses");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr);
			NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "ASSAULT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "DEADLYASSAULT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "AIMED_AT_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "PICKPOCKET_RELATIONSHIPCHANGE");
			NPCResponses.NativeFieldInfoPtr__npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "<npc>k__BackingField");
			NPCResponses.NativeFieldInfoPtr_INITIALIZED_TIME_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "INITIALIZED_TIME_OFFSET");
			NPCResponses.NativeFieldInfoPtr_TIME_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "TIME_THRESHOLD");
			NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "timeSinceLastImpact");
			NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, "timeSinceAimedAt");
			NPCResponses.NativeMethodInfoPtr_get_npc_Protected_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682661);
			NPCResponses.NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682662);
			NPCResponses.NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682663);
			NPCResponses.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682664);
			NPCResponses.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682665);
			NPCResponses.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682666);
			NPCResponses.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682667);
			NPCResponses.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682668);
			NPCResponses.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682669);
			NPCResponses.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682670);
			NPCResponses.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682671);
			NPCResponses.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682672);
			NPCResponses.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682673);
			NPCResponses.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682674);
			NPCResponses.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682675);
			NPCResponses.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682676);
			NPCResponses.NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682677);
			NPCResponses.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682678);
			NPCResponses.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682679);
			NPCResponses.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682680);
			NPCResponses.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682681);
			NPCResponses.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682682);
			NPCResponses.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682683);
			NPCResponses.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr, 100682684);
		}

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x06009433 RID: 37939 RVA: 0x00280E38 File Offset: 0x0027F038
		// (set) Token: 0x06009434 RID: 37940 RVA: 0x00280E78 File Offset: 0x0027F078
		public unsafe NPC npc
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_get_npc_Protected_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x06009435 RID: 37941 RVA: 0x00280EBC File Offset: 0x0027F0BC
		public unsafe NPCActions actions
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 271520, RefRangeEnd = 271522, XrefRangeStart = 271520, XrefRangeEnd = 271520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCActions>(intPtr3) : null;
			}
		}

		// Token: 0x06009436 RID: 37942 RVA: 0x00280EFC File Offset: 0x0027F0FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271528, RefRangeEnd = 271531, XrefRangeStart = 271522, XrefRangeEnd = 271528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009437 RID: 37943 RVA: 0x00280F38 File Offset: 0x0027F138
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GunshotHeard(NoiseEvent gunshotSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gunshotSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009438 RID: 37944 RVA: 0x00280F88 File Offset: 0x0027F188
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExplosionHeard(NoiseEvent explosionSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(explosionSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009439 RID: 37945 RVA: 0x00280FD8 File Offset: 0x0027F1D8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedPettyCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600943A RID: 37946 RVA: 0x00281028 File Offset: 0x0027F228
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedVandalism(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600943B RID: 37947 RVA: 0x00281078 File Offset: 0x0027F278
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SawPickpocketing(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600943C RID: 37948 RVA: 0x002810C8 File Offset: 0x0027F2C8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticePlayerBrandishingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600943D RID: 37949 RVA: 0x00281118 File Offset: 0x0027F318
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticePlayerDischargingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600943E RID: 37950 RVA: 0x00281168 File Offset: 0x0027F368
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271531, RefRangeEnd = 271534, XrefRangeStart = 271531, XrefRangeEnd = 271531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayerFailedPickpocket(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600943F RID: 37951 RVA: 0x002811B8 File Offset: 0x0027F3B8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedDrugDeal(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009440 RID: 37952 RVA: 0x00281208 File Offset: 0x0027F408
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedViolatingCurfew(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009441 RID: 37953 RVA: 0x00281258 File Offset: 0x0027F458
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedWantedPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009442 RID: 37954 RVA: 0x002812A8 File Offset: 0x0027F4A8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NoticedSuspiciousPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009443 RID: 37955 RVA: 0x002812F8 File Offset: 0x0027F4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 271534, XrefRangeEnd = 271562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HitByCar(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009444 RID: 37956 RVA: 0x00281348 File Offset: 0x0027F548
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 271571, RefRangeEnd = 271573, XrefRangeStart = 271562, XrefRangeEnd = 271571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ImpactReceived(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009445 RID: 37957 RVA: 0x00281398 File Offset: 0x0027F598
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 271574, RefRangeEnd = 271580, XrefRangeStart = 271573, XrefRangeEnd = 271574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009446 RID: 37958 RVA: 0x002813F8 File Offset: 0x0027F5F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 271574, RefRangeEnd = 271580, XrefRangeStart = 271574, XrefRangeEnd = 271580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009447 RID: 37959 RVA: 0x00281458 File Offset: 0x0027F658
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271581, RefRangeEnd = 271584, XrefRangeStart = 271580, XrefRangeEnd = 271581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009448 RID: 37960 RVA: 0x002814B8 File Offset: 0x0027F6B8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009449 RID: 37961 RVA: 0x00281518 File Offset: 0x0027F718
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 271586, RefRangeEnd = 271589, XrefRangeStart = 271584, XrefRangeEnd = 271586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RespondToAimedAt(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600944A RID: 37962 RVA: 0x00281568 File Offset: 0x0027F768
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCResponses() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCResponses>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600944B RID: 37963 RVA: 0x0004569B File Offset: 0x0004389B
		public NPCResponses(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DCE RID: 11726
		// (get) Token: 0x0600944C RID: 37964 RVA: 0x002815A4 File Offset: 0x0027F7A4
		// (set) Token: 0x0600944D RID: 37965 RVA: 0x000456A4 File Offset: 0x000438A4
		public unsafe static float ASSAULT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x0600944E RID: 37966 RVA: 0x002815C0 File Offset: 0x0027F7C0
		// (set) Token: 0x0600944F RID: 37967 RVA: 0x000456B2 File Offset: 0x000438B2
		public unsafe static float DEADLYASSAULT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x06009450 RID: 37968 RVA: 0x002815DC File Offset: 0x0027F7DC
		// (set) Token: 0x06009451 RID: 37969 RVA: 0x000456C0 File Offset: 0x000438C0
		public unsafe static float AIMED_AT_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x06009452 RID: 37970 RVA: 0x002815F8 File Offset: 0x0027F7F8
		// (set) Token: 0x06009453 RID: 37971 RVA: 0x000456CE File Offset: 0x000438CE
		public unsafe static float PICKPOCKET_RELATIONSHIPCHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE, (void*)(&value));
			}
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x06009454 RID: 37972 RVA: 0x00281614 File Offset: 0x0027F814
		// (set) Token: 0x06009455 RID: 37973 RVA: 0x000456DC File Offset: 0x000438DC
		public unsafe NPC _npc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr__npc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr__npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x06009456 RID: 37974 RVA: 0x00281644 File Offset: 0x0027F844
		// (set) Token: 0x06009457 RID: 37975 RVA: 0x000456FB File Offset: 0x000438FB
		public unsafe static float INITIALIZED_TIME_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_INITIALIZED_TIME_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_INITIALIZED_TIME_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x06009458 RID: 37976 RVA: 0x00281660 File Offset: 0x0027F860
		// (set) Token: 0x06009459 RID: 37977 RVA: 0x00045709 File Offset: 0x00043909
		public unsafe static float TIME_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCResponses.NativeFieldInfoPtr_TIME_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCResponses.NativeFieldInfoPtr_TIME_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x0600945A RID: 37978 RVA: 0x0028167C File Offset: 0x0027F87C
		// (set) Token: 0x0600945B RID: 37979 RVA: 0x00045717 File Offset: 0x00043917
		public unsafe float timeSinceLastImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceLastImpact)) = value;
			}
		}

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x0600945C RID: 37980 RVA: 0x002816A4 File Offset: 0x0027F8A4
		// (set) Token: 0x0600945D RID: 37981 RVA: 0x00045732 File Offset: 0x00043932
		public unsafe float timeSinceAimedAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses.NativeFieldInfoPtr_timeSinceAimedAt)) = value;
			}
		}

		// Token: 0x04006612 RID: 26130
		private static readonly IntPtr NativeFieldInfoPtr_ASSAULT_RELATIONSHIPCHANGE;

		// Token: 0x04006613 RID: 26131
		private static readonly IntPtr NativeFieldInfoPtr_DEADLYASSAULT_RELATIONSHIPCHANGE;

		// Token: 0x04006614 RID: 26132
		private static readonly IntPtr NativeFieldInfoPtr_AIMED_AT_RELATIONSHIPCHANGE;

		// Token: 0x04006615 RID: 26133
		private static readonly IntPtr NativeFieldInfoPtr_PICKPOCKET_RELATIONSHIPCHANGE;

		// Token: 0x04006616 RID: 26134
		private static readonly IntPtr NativeFieldInfoPtr__npc_k__BackingField;

		// Token: 0x04006617 RID: 26135
		private static readonly IntPtr NativeFieldInfoPtr_INITIALIZED_TIME_OFFSET;

		// Token: 0x04006618 RID: 26136
		private static readonly IntPtr NativeFieldInfoPtr_TIME_THRESHOLD;

		// Token: 0x04006619 RID: 26137
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastImpact;

		// Token: 0x0400661A RID: 26138
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceAimedAt;

		// Token: 0x0400661B RID: 26139
		private static readonly IntPtr NativeMethodInfoPtr_get_npc_Protected_get_NPC_0;

		// Token: 0x0400661C RID: 26140
		private static readonly IntPtr NativeMethodInfoPtr_set_npc_Private_set_Void_NPC_0;

		// Token: 0x0400661D RID: 26141
		private static readonly IntPtr NativeMethodInfoPtr_get_actions_Protected_get_NPCActions_0;

		// Token: 0x0400661E RID: 26142
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400661F RID: 26143
		private static readonly IntPtr NativeMethodInfoPtr_GunshotHeard_Public_Virtual_New_Void_NoiseEvent_0;

		// Token: 0x04006620 RID: 26144
		private static readonly IntPtr NativeMethodInfoPtr_ExplosionHeard_Public_Virtual_New_Void_NoiseEvent_0;

		// Token: 0x04006621 RID: 26145
		private static readonly IntPtr NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_New_Void_Player_0;

		// Token: 0x04006622 RID: 26146
		private static readonly IntPtr NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_New_Void_Player_0;

		// Token: 0x04006623 RID: 26147
		private static readonly IntPtr NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_New_Void_Player_0;

		// Token: 0x04006624 RID: 26148
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_New_Void_Player_0;

		// Token: 0x04006625 RID: 26149
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_New_Void_Player_0;

		// Token: 0x04006626 RID: 26150
		private static readonly IntPtr NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_New_Void_Player_0;

		// Token: 0x04006627 RID: 26151
		private static readonly IntPtr NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_New_Void_Player_0;

		// Token: 0x04006628 RID: 26152
		private static readonly IntPtr NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_New_Void_Player_0;

		// Token: 0x04006629 RID: 26153
		private static readonly IntPtr NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400662A RID: 26154
		private static readonly IntPtr NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400662B RID: 26155
		private static readonly IntPtr NativeMethodInfoPtr_HitByCar_Public_Virtual_New_Void_LandVehicle_0;

		// Token: 0x0400662C RID: 26156
		private static readonly IntPtr NativeMethodInfoPtr_ImpactReceived_Public_Virtual_New_Void_Impact_0;

		// Token: 0x0400662D RID: 26157
		private static readonly IntPtr NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x0400662E RID: 26158
		private static readonly IntPtr NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x0400662F RID: 26159
		private static readonly IntPtr NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x04006630 RID: 26160
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_New_Void_Player_Impact_0;

		// Token: 0x04006631 RID: 26161
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_New_Void_Player_0;

		// Token: 0x04006632 RID: 26162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

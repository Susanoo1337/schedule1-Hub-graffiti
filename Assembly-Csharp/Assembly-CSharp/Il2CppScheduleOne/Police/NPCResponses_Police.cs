using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.NPCs.Responses;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x0200043D RID: 1085
	public class NPCResponses_Police : NPCResponses
	{
		// Token: 0x06006157 RID: 24919 RVA: 0x001CC214 File Offset: 0x001CA414
		// Note: this type is marked as 'beforefieldinit'.
		static NPCResponses_Police()
		{
			Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "NPCResponses_Police");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr);
			NPCResponses_Police.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, "officer");
			NPCResponses_Police.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676074);
			NPCResponses_Police.NativeMethodInfoPtr_HitByCar_Public_Virtual_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676075);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676076);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676077);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676078);
			NPCResponses_Police.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676079);
			NPCResponses_Police.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676080);
			NPCResponses_Police.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676081);
			NPCResponses_Police.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676082);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676083);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676084);
			NPCResponses_Police.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676085);
			NPCResponses_Police.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676086);
			NPCResponses_Police.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676087);
			NPCResponses_Police.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676088);
			NPCResponses_Police.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676089);
			NPCResponses_Police.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676090);
			NPCResponses_Police.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676091);
			NPCResponses_Police.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676092);
			NPCResponses_Police.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr, 100676093);
		}

		// Token: 0x06006158 RID: 24920 RVA: 0x001CC3E8 File Offset: 0x001CA5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206216, XrefRangeEnd = 206222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x001CC424 File Offset: 0x001CA624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206222, XrefRangeEnd = 206247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HitByCar(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_HitByCar_Public_Virtual_Void_LandVehicle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x001CC474 File Offset: 0x001CA674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206247, XrefRangeEnd = 206263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedDrugDeal(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x001CC4C4 File Offset: 0x001CA6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206263, XrefRangeEnd = 206274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedPettyCrime(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x001CC514 File Offset: 0x001CA714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206274, XrefRangeEnd = 206290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedVandalism(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x001CC564 File Offset: 0x001CA764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206290, XrefRangeEnd = 206306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SawPickpocketing(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x001CC5B4 File Offset: 0x001CA7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206306, XrefRangeEnd = 206322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayerFailedPickpocket(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x001CC604 File Offset: 0x001CA804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206322, XrefRangeEnd = 206338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticePlayerBrandishingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006160 RID: 24928 RVA: 0x001CC654 File Offset: 0x001CA854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206338, XrefRangeEnd = 206354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticePlayerDischargingWeapon(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x001CC6A4 File Offset: 0x001CA8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206354, XrefRangeEnd = 206368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedWantedPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x001CC6F4 File Offset: 0x001CA8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206368, XrefRangeEnd = 206377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedSuspiciousPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x001CC744 File Offset: 0x001CA944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206377, XrefRangeEnd = 206396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NoticedViolatingCurfew(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x001CC794 File Offset: 0x001CA994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206396, XrefRangeEnd = 206411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006165 RID: 24933 RVA: 0x001CC7F4 File Offset: 0x001CA9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206411, XrefRangeEnd = 206424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x001CC854 File Offset: 0x001CAA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206424, XrefRangeEnd = 206442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x001CC8B4 File Offset: 0x001CAAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206442, XrefRangeEnd = 206451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(perpetrator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x001CC914 File Offset: 0x001CAB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206451, XrefRangeEnd = 206459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RespondToAimedAt(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x001CC964 File Offset: 0x001CAB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206459, XrefRangeEnd = 206461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ImpactReceived(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_ImpactReceived_Public_Virtual_Void_Impact_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x001CC9B4 File Offset: 0x001CABB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206461, XrefRangeEnd = 206476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GunshotHeard(NoiseEvent gunshotSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gunshotSound);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCResponses_Police.NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x001CCA04 File Offset: 0x001CAC04
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCResponses_Police() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCResponses_Police>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCResponses_Police.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x0002E09F File Offset: 0x0002C29F
		public NPCResponses_Police(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x0600616D RID: 24941 RVA: 0x001CCA40 File Offset: 0x001CAC40
		// (set) Token: 0x0600616E RID: 24942 RVA: 0x0002E0A8 File Offset: 0x0002C2A8
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_Police.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCResponses_Police.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400430D RID: 17165
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x0400430E RID: 17166
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400430F RID: 17167
		private static readonly IntPtr NativeMethodInfoPtr_HitByCar_Public_Virtual_Void_LandVehicle_0;

		// Token: 0x04004310 RID: 17168
		private static readonly IntPtr NativeMethodInfoPtr_NoticedDrugDeal_Public_Virtual_Void_Player_0;

		// Token: 0x04004311 RID: 17169
		private static readonly IntPtr NativeMethodInfoPtr_NoticedPettyCrime_Public_Virtual_Void_Player_0;

		// Token: 0x04004312 RID: 17170
		private static readonly IntPtr NativeMethodInfoPtr_NoticedVandalism_Public_Virtual_Void_Player_0;

		// Token: 0x04004313 RID: 17171
		private static readonly IntPtr NativeMethodInfoPtr_SawPickpocketing_Public_Virtual_Void_Player_0;

		// Token: 0x04004314 RID: 17172
		private static readonly IntPtr NativeMethodInfoPtr_PlayerFailedPickpocket_Public_Virtual_Void_Player_0;

		// Token: 0x04004315 RID: 17173
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerBrandishingWeapon_Public_Virtual_Void_Player_0;

		// Token: 0x04004316 RID: 17174
		private static readonly IntPtr NativeMethodInfoPtr_NoticePlayerDischargingWeapon_Public_Virtual_Void_Player_0;

		// Token: 0x04004317 RID: 17175
		private static readonly IntPtr NativeMethodInfoPtr_NoticedWantedPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04004318 RID: 17176
		private static readonly IntPtr NativeMethodInfoPtr_NoticedSuspiciousPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04004319 RID: 17177
		private static readonly IntPtr NativeMethodInfoPtr_NoticedViolatingCurfew_Public_Virtual_Void_Player_0;

		// Token: 0x0400431A RID: 17178
		private static readonly IntPtr NativeMethodInfoPtr_RespondToFirstNonLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x0400431B RID: 17179
		private static readonly IntPtr NativeMethodInfoPtr_RespondToLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x0400431C RID: 17180
		private static readonly IntPtr NativeMethodInfoPtr_RespondToRepeatedNonLethalAttack_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x0400431D RID: 17181
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAnnoyingImpact_Protected_Virtual_Void_Player_Impact_0;

		// Token: 0x0400431E RID: 17182
		private static readonly IntPtr NativeMethodInfoPtr_RespondToAimedAt_Public_Virtual_Void_Player_0;

		// Token: 0x0400431F RID: 17183
		private static readonly IntPtr NativeMethodInfoPtr_ImpactReceived_Public_Virtual_Void_Impact_0;

		// Token: 0x04004320 RID: 17184
		private static readonly IntPtr NativeMethodInfoPtr_GunshotHeard_Public_Virtual_Void_NoiseEvent_0;

		// Token: 0x04004321 RID: 17185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000647 RID: 1607
	public class SewerGoblin : NPC
	{
		// Token: 0x0600995C RID: 39260 RVA: 0x00291664 File Offset: 0x0028F864
		// Note: this type is marked as 'beforefieldinit'.
		static SewerGoblin()
		{
			Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "SewerGoblin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr);
			SewerGoblin.NativeFieldInfoPtr_COOLDOWN_HOURS_BETWEEN_DEPLOYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "COOLDOWN_HOURS_BETWEEN_DEPLOYS");
			SewerGoblin.NativeFieldInfoPtr_HOURLY_DEPLOY_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "HOURLY_DEPLOY_CHANCE");
			SewerGoblin.NativeFieldInfoPtr_NORMALIZED_HEALTH_THRESHOLD_TO_RETREAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "NORMALIZED_HEALTH_THRESHOLD_TO_RETREAT");
			SewerGoblin.NativeFieldInfoPtr_RETREAT_CHANCE_AFTER_HIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "RETREAT_CHANCE_AFTER_HIT");
			SewerGoblin.NativeFieldInfoPtr_MAX_CANCELLED_RETRIEVE_ATTEMPTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "MAX_CANCELLED_RETRIEVE_ATTEMPTS");
			SewerGoblin.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			SewerGoblin.NativeFieldInfoPtr__CurrentState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "<CurrentState>k__BackingField");
			SewerGoblin.NativeFieldInfoPtr__HoursSinceLastDeploy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "<HoursSinceLastDeploy>k__BackingField");
			SewerGoblin.NativeFieldInfoPtr_SewerHidingBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "SewerHidingBuilding");
			SewerGoblin.NativeFieldInfoPtr_StayInBuildingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "StayInBuildingEvent");
			SewerGoblin.NativeFieldInfoPtr_PacifyItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "PacifyItem");
			SewerGoblin.NativeFieldInfoPtr_RetrieveBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "RetrieveBehaviour");
			SewerGoblin.NativeFieldInfoPtr_ExitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "ExitSound");
			SewerGoblin.NativeFieldInfoPtr_cancelledRetrieveAttempts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "cancelledRetrieveAttempts");
			SewerGoblin.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SewerGoblinAssembly-CSharp.dll_Excuted");
			SewerGoblin.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SewerGoblinAssembly-CSharp.dll_Excuted");
			SewerGoblin.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683262);
			SewerGoblin.NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683263);
			SewerGoblin.NativeMethodInfoPtr_get_CurrentState_Public_get_ESewerGoblinState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683264);
			SewerGoblin.NativeMethodInfoPtr_set_CurrentState_Private_set_Void_ESewerGoblinState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683265);
			SewerGoblin.NativeMethodInfoPtr_get_HoursSinceLastDeploy_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683266);
			SewerGoblin.NativeMethodInfoPtr_set_HoursSinceLastDeploy_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683267);
			SewerGoblin.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683268);
			SewerGoblin.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683269);
			SewerGoblin.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683270);
			SewerGoblin.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683271);
			SewerGoblin.NativeMethodInfoPtr_OnHourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683272);
			SewerGoblin.NativeMethodInfoPtr_DeployToPlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683273);
			SewerGoblin.NativeMethodInfoPtr_AttackTarget_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683274);
			SewerGoblin.NativeMethodInfoPtr_Retreat_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683275);
			SewerGoblin.NativeMethodInfoPtr_EnterBuilding_Protected_Virtual_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683276);
			SewerGoblin.NativeMethodInfoPtr_ExitBuilding_Protected_Virtual_Void_NPCEnterableBuilding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683277);
			SewerGoblin.NativeMethodInfoPtr_DeployToLocalPlayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683278);
			SewerGoblin.NativeMethodInfoPtr_OnSuccesfulCombatHit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683279);
			SewerGoblin.NativeMethodInfoPtr_CanBeginRetieve_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683280);
			SewerGoblin.NativeMethodInfoPtr_BeginRetrieve_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683281);
			SewerGoblin.NativeMethodInfoPtr_OnRetrieveCancel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683282);
			SewerGoblin.NativeMethodInfoPtr_OnRetrieveSuccess_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683283);
			SewerGoblin.NativeMethodInfoPtr_IsPlayerValidTarget_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683284);
			SewerGoblin.NativeMethodInfoPtr_IsPlayerHoldingPacifyItem_Public_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683285);
			SewerGoblin.NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683286);
			SewerGoblin.NativeMethodInfoPtr_OnTakeDamage_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683287);
			SewerGoblin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683288);
			SewerGoblin.NativeMethodInfoPtr__OnMinPass_b__27_0_Private_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683289);
			SewerGoblin.NativeMethodInfoPtr__Retreat_b__31_0_Private_Single_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683290);
			SewerGoblin.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683291);
			SewerGoblin.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683292);
			SewerGoblin.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683293);
			SewerGoblin.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, 100683294);
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x0600995D RID: 39261 RVA: 0x00291A68 File Offset: 0x0028FC68
		// (set) Token: 0x0600995E RID: 39262 RVA: 0x00291AA8 File Offset: 0x0028FCA8
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x0600995F RID: 39263 RVA: 0x00291AEC File Offset: 0x0028FCEC
		// (set) Token: 0x06009960 RID: 39264 RVA: 0x00291B28 File Offset: 0x0028FD28
		public unsafe SewerGoblin.ESewerGoblinState CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_get_CurrentState_Public_get_ESewerGoblinState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_set_CurrentState_Private_set_Void_ESewerGoblinState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x06009961 RID: 39265 RVA: 0x00291B68 File Offset: 0x0028FD68
		// (set) Token: 0x06009962 RID: 39266 RVA: 0x00291BA4 File Offset: 0x0028FDA4
		public unsafe int HoursSinceLastDeploy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_get_HoursSinceLastDeploy_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_set_HoursSinceLastDeploy_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009963 RID: 39267 RVA: 0x00291BE4 File Offset: 0x0028FDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273851, XrefRangeEnd = 273852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblin.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009964 RID: 39268 RVA: 0x00291C20 File Offset: 0x0028FE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273852, XrefRangeEnd = 273904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblin.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009965 RID: 39269 RVA: 0x00291C5C File Offset: 0x0028FE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273904, XrefRangeEnd = 273927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009966 RID: 39270 RVA: 0x00291C90 File Offset: 0x0028FE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273927, XrefRangeEnd = 273952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009967 RID: 39271 RVA: 0x00291CC4 File Offset: 0x0028FEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273952, XrefRangeEnd = 273953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_OnHourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009968 RID: 39272 RVA: 0x00291CF8 File Offset: 0x0028FEF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273993, RefRangeEnd = 273995, XrefRangeStart = 273953, XrefRangeEnd = 273993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeployToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_DeployToPlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009969 RID: 39273 RVA: 0x00291D3C File Offset: 0x0028FF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273995, XrefRangeEnd = 273998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttackTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_AttackTarget_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600996A RID: 39274 RVA: 0x00291D70 File Offset: 0x0028FF70
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 274042, RefRangeEnd = 274046, XrefRangeStart = 273998, XrefRangeEnd = 274042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Retreat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_Retreat_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600996B RID: 39275 RVA: 0x00291DA4 File Offset: 0x0028FFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274046, XrefRangeEnd = 274050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EnterBuilding(string buildingGUID, int doorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblin.NativeMethodInfoPtr_EnterBuilding_Protected_Virtual_Void_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600996C RID: 39276 RVA: 0x00291E00 File Offset: 0x00290000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274050, XrefRangeEnd = 274052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExitBuilding(NPCEnterableBuilding building)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(building);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblin.NativeMethodInfoPtr_ExitBuilding_Protected_Virtual_Void_NPCEnterableBuilding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600996D RID: 39277 RVA: 0x00291E50 File Offset: 0x00290050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274052, XrefRangeEnd = 274057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeployToLocalPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_DeployToLocalPlayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600996E RID: 39278 RVA: 0x00291E84 File Offset: 0x00290084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274057, XrefRangeEnd = 274060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSuccesfulCombatHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_OnSuccesfulCombatHit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600996F RID: 39279 RVA: 0x00291EB8 File Offset: 0x002900B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274060, XrefRangeEnd = 274071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBeginRetieve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_CanBeginRetieve_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009970 RID: 39280 RVA: 0x00291EF4 File Offset: 0x002900F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274071, XrefRangeEnd = 274080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginRetrieve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_BeginRetrieve_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009971 RID: 39281 RVA: 0x00291F28 File Offset: 0x00290128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274080, XrefRangeEnd = 274085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRetrieveCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_OnRetrieveCancel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009972 RID: 39282 RVA: 0x00291F5C File Offset: 0x0029015C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274085, XrefRangeEnd = 274086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRetrieveSuccess()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_OnRetrieveSuccess_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009973 RID: 39283 RVA: 0x00291F90 File Offset: 0x00290190
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 274093, RefRangeEnd = 274096, XrefRangeStart = 274086, XrefRangeEnd = 274093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerValidTarget(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_IsPlayerValidTarget_Public_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009974 RID: 39284 RVA: 0x00291FE0 File Offset: 0x002901E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274097, RefRangeEnd = 274098, XrefRangeStart = 274096, XrefRangeEnd = 274097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerHoldingPacifyItem(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_IsPlayerHoldingPacifyItem_Public_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009975 RID: 39285 RVA: 0x00292030 File Offset: 0x00290230
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblin.NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_Void_Vector3_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009976 RID: 39286 RVA: 0x00292098 File Offset: 0x00290298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274098, XrefRangeEnd = 274099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTakeDamage(float damageAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damageAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr_OnTakeDamage_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009977 RID: 39287 RVA: 0x002920D8 File Offset: 0x002902D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SewerGoblin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009978 RID: 39288 RVA: 0x00292114 File Offset: 0x00290314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274099, XrefRangeEnd = 274100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnMinPass_b__27_0(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr__OnMinPass_b__27_0_Private_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009979 RID: 39289 RVA: 0x00292164 File Offset: 0x00290364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274100, XrefRangeEnd = 274109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _Retreat_b__31_0(StaticDoor door)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(door);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.NativeMethodInfoPtr__Retreat_b__31_0_Private_Single_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600997A RID: 39290 RVA: 0x002921B4 File Offset: 0x002903B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274109, XrefRangeEnd = 274110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblin.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600997B RID: 39291 RVA: 0x002921F0 File Offset: 0x002903F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274110, XrefRangeEnd = 274111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblin.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600997C RID: 39292 RVA: 0x0029222C File Offset: 0x0029042C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblin.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600997D RID: 39293 RVA: 0x00292268 File Offset: 0x00290468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274165, RefRangeEnd = 274166, XrefRangeStart = 274111, XrefRangeEnd = 274165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerGoblin.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600997E RID: 39294 RVA: 0x0004781A File Offset: 0x00045A1A
		public SewerGoblin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002EFA RID: 12026
		// (get) Token: 0x0600997F RID: 39295 RVA: 0x002922A4 File Offset: 0x002904A4
		// (set) Token: 0x06009980 RID: 39296 RVA: 0x00047823 File Offset: 0x00045A23
		public unsafe static int COOLDOWN_HOURS_BETWEEN_DEPLOYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SewerGoblin.NativeFieldInfoPtr_COOLDOWN_HOURS_BETWEEN_DEPLOYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SewerGoblin.NativeFieldInfoPtr_COOLDOWN_HOURS_BETWEEN_DEPLOYS, (void*)(&value));
			}
		}

		// Token: 0x17002EFB RID: 12027
		// (get) Token: 0x06009981 RID: 39297 RVA: 0x002922C0 File Offset: 0x002904C0
		// (set) Token: 0x06009982 RID: 39298 RVA: 0x00047831 File Offset: 0x00045A31
		public unsafe static float HOURLY_DEPLOY_CHANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SewerGoblin.NativeFieldInfoPtr_HOURLY_DEPLOY_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SewerGoblin.NativeFieldInfoPtr_HOURLY_DEPLOY_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x17002EFC RID: 12028
		// (get) Token: 0x06009983 RID: 39299 RVA: 0x002922DC File Offset: 0x002904DC
		// (set) Token: 0x06009984 RID: 39300 RVA: 0x0004783F File Offset: 0x00045A3F
		public unsafe static float NORMALIZED_HEALTH_THRESHOLD_TO_RETREAT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SewerGoblin.NativeFieldInfoPtr_NORMALIZED_HEALTH_THRESHOLD_TO_RETREAT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SewerGoblin.NativeFieldInfoPtr_NORMALIZED_HEALTH_THRESHOLD_TO_RETREAT, (void*)(&value));
			}
		}

		// Token: 0x17002EFD RID: 12029
		// (get) Token: 0x06009985 RID: 39301 RVA: 0x002922F8 File Offset: 0x002904F8
		// (set) Token: 0x06009986 RID: 39302 RVA: 0x0004784D File Offset: 0x00045A4D
		public unsafe static float RETREAT_CHANCE_AFTER_HIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SewerGoblin.NativeFieldInfoPtr_RETREAT_CHANCE_AFTER_HIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SewerGoblin.NativeFieldInfoPtr_RETREAT_CHANCE_AFTER_HIT, (void*)(&value));
			}
		}

		// Token: 0x17002EFE RID: 12030
		// (get) Token: 0x06009987 RID: 39303 RVA: 0x00292314 File Offset: 0x00290514
		// (set) Token: 0x06009988 RID: 39304 RVA: 0x0004785B File Offset: 0x00045A5B
		public unsafe static int MAX_CANCELLED_RETRIEVE_ATTEMPTS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SewerGoblin.NativeFieldInfoPtr_MAX_CANCELLED_RETRIEVE_ATTEMPTS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SewerGoblin.NativeFieldInfoPtr_MAX_CANCELLED_RETRIEVE_ATTEMPTS, (void*)(&value));
			}
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x06009989 RID: 39305 RVA: 0x00292330 File Offset: 0x00290530
		// (set) Token: 0x0600998A RID: 39306 RVA: 0x00047869 File Offset: 0x00045A69
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x0600998B RID: 39307 RVA: 0x00292360 File Offset: 0x00290560
		// (set) Token: 0x0600998C RID: 39308 RVA: 0x00047888 File Offset: 0x00045A88
		public unsafe SewerGoblin.ESewerGoblinState _CurrentState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr__CurrentState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr__CurrentState_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x0600998D RID: 39309 RVA: 0x00292388 File Offset: 0x00290588
		// (set) Token: 0x0600998E RID: 39310 RVA: 0x000478A3 File Offset: 0x00045AA3
		public unsafe int _HoursSinceLastDeploy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr__HoursSinceLastDeploy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr__HoursSinceLastDeploy_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F02 RID: 12034
		// (get) Token: 0x0600998F RID: 39311 RVA: 0x002923B0 File Offset: 0x002905B0
		// (set) Token: 0x06009990 RID: 39312 RVA: 0x000478BE File Offset: 0x00045ABE
		public unsafe NPCEnterableBuilding SewerHidingBuilding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_SewerHidingBuilding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_SewerHidingBuilding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x06009991 RID: 39313 RVA: 0x002923E0 File Offset: 0x002905E0
		// (set) Token: 0x06009992 RID: 39314 RVA: 0x000478DD File Offset: 0x00045ADD
		public unsafe NPCEvent_StayInBuilding StayInBuildingEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_StayInBuildingEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_StayInBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_StayInBuildingEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x06009993 RID: 39315 RVA: 0x00292410 File Offset: 0x00290610
		// (set) Token: 0x06009994 RID: 39316 RVA: 0x000478FC File Offset: 0x00045AFC
		public unsafe ItemDefinition PacifyItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_PacifyItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_PacifyItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x06009995 RID: 39317 RVA: 0x00292440 File Offset: 0x00290640
		// (set) Token: 0x06009996 RID: 39318 RVA: 0x0004791B File Offset: 0x00045B1B
		public unsafe SewerGoblinRetrieveBehaviour RetrieveBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_RetrieveBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SewerGoblinRetrieveBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_RetrieveBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x06009997 RID: 39319 RVA: 0x00292470 File Offset: 0x00290670
		// (set) Token: 0x06009998 RID: 39320 RVA: 0x0004793A File Offset: 0x00045B3A
		public unsafe AudioSourceController ExitSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_ExitSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_ExitSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x06009999 RID: 39321 RVA: 0x002924A0 File Offset: 0x002906A0
		// (set) Token: 0x0600999A RID: 39322 RVA: 0x00047959 File Offset: 0x00045B59
		public unsafe int cancelledRetrieveAttempts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_cancelledRetrieveAttempts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_cancelledRetrieveAttempts)) = value;
			}
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x0600999B RID: 39323 RVA: 0x002924C8 File Offset: 0x002906C8
		// (set) Token: 0x0600999C RID: 39324 RVA: 0x00047974 File Offset: 0x00045B74
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x0600999D RID: 39325 RVA: 0x002924F0 File Offset: 0x002906F0
		// (set) Token: 0x0600999E RID: 39326 RVA: 0x0004798F File Offset: 0x00045B8F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400695C RID: 26972
		private static readonly IntPtr NativeFieldInfoPtr_COOLDOWN_HOURS_BETWEEN_DEPLOYS;

		// Token: 0x0400695D RID: 26973
		private static readonly IntPtr NativeFieldInfoPtr_HOURLY_DEPLOY_CHANCE;

		// Token: 0x0400695E RID: 26974
		private static readonly IntPtr NativeFieldInfoPtr_NORMALIZED_HEALTH_THRESHOLD_TO_RETREAT;

		// Token: 0x0400695F RID: 26975
		private static readonly IntPtr NativeFieldInfoPtr_RETREAT_CHANCE_AFTER_HIT;

		// Token: 0x04006960 RID: 26976
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CANCELLED_RETRIEVE_ATTEMPTS;

		// Token: 0x04006961 RID: 26977
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04006962 RID: 26978
		private static readonly IntPtr NativeFieldInfoPtr__CurrentState_k__BackingField;

		// Token: 0x04006963 RID: 26979
		private static readonly IntPtr NativeFieldInfoPtr__HoursSinceLastDeploy_k__BackingField;

		// Token: 0x04006964 RID: 26980
		private static readonly IntPtr NativeFieldInfoPtr_SewerHidingBuilding;

		// Token: 0x04006965 RID: 26981
		private static readonly IntPtr NativeFieldInfoPtr_StayInBuildingEvent;

		// Token: 0x04006966 RID: 26982
		private static readonly IntPtr NativeFieldInfoPtr_PacifyItem;

		// Token: 0x04006967 RID: 26983
		private static readonly IntPtr NativeFieldInfoPtr_RetrieveBehaviour;

		// Token: 0x04006968 RID: 26984
		private static readonly IntPtr NativeFieldInfoPtr_ExitSound;

		// Token: 0x04006969 RID: 26985
		private static readonly IntPtr NativeFieldInfoPtr_cancelledRetrieveAttempts;

		// Token: 0x0400696A RID: 26986
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400696B RID: 26987
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400696C RID: 26988
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x0400696D RID: 26989
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0;

		// Token: 0x0400696E RID: 26990
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Public_get_ESewerGoblinState_0;

		// Token: 0x0400696F RID: 26991
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentState_Private_set_Void_ESewerGoblinState_0;

		// Token: 0x04006970 RID: 26992
		private static readonly IntPtr NativeMethodInfoPtr_get_HoursSinceLastDeploy_Public_get_Int32_0;

		// Token: 0x04006971 RID: 26993
		private static readonly IntPtr NativeMethodInfoPtr_set_HoursSinceLastDeploy_Public_set_Void_Int32_0;

		// Token: 0x04006972 RID: 26994
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006973 RID: 26995
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04006974 RID: 26996
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006975 RID: 26997
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x04006976 RID: 26998
		private static readonly IntPtr NativeMethodInfoPtr_OnHourPass_Private_Void_0;

		// Token: 0x04006977 RID: 26999
		private static readonly IntPtr NativeMethodInfoPtr_DeployToPlayer_Public_Void_Player_0;

		// Token: 0x04006978 RID: 27000
		private static readonly IntPtr NativeMethodInfoPtr_AttackTarget_Private_Void_0;

		// Token: 0x04006979 RID: 27001
		private static readonly IntPtr NativeMethodInfoPtr_Retreat_Public_Void_0;

		// Token: 0x0400697A RID: 27002
		private static readonly IntPtr NativeMethodInfoPtr_EnterBuilding_Protected_Virtual_Void_String_Int32_0;

		// Token: 0x0400697B RID: 27003
		private static readonly IntPtr NativeMethodInfoPtr_ExitBuilding_Protected_Virtual_Void_NPCEnterableBuilding_0;

		// Token: 0x0400697C RID: 27004
		private static readonly IntPtr NativeMethodInfoPtr_DeployToLocalPlayer_Public_Void_0;

		// Token: 0x0400697D RID: 27005
		private static readonly IntPtr NativeMethodInfoPtr_OnSuccesfulCombatHit_Private_Void_0;

		// Token: 0x0400697E RID: 27006
		private static readonly IntPtr NativeMethodInfoPtr_CanBeginRetieve_Private_Boolean_0;

		// Token: 0x0400697F RID: 27007
		private static readonly IntPtr NativeMethodInfoPtr_BeginRetrieve_Private_Void_0;

		// Token: 0x04006980 RID: 27008
		private static readonly IntPtr NativeMethodInfoPtr_OnRetrieveCancel_Private_Void_0;

		// Token: 0x04006981 RID: 27009
		private static readonly IntPtr NativeMethodInfoPtr_OnRetrieveSuccess_Private_Void_0;

		// Token: 0x04006982 RID: 27010
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerValidTarget_Public_Boolean_Player_0;

		// Token: 0x04006983 RID: 27011
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerHoldingPacifyItem_Public_Boolean_Player_0;

		// Token: 0x04006984 RID: 27012
		private static readonly IntPtr NativeMethodInfoPtr_ProcessImpactForce_Public_Virtual_Void_Vector3_Vector3_Single_0;

		// Token: 0x04006985 RID: 27013
		private static readonly IntPtr NativeMethodInfoPtr_OnTakeDamage_Private_Void_Single_0;

		// Token: 0x04006986 RID: 27014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006987 RID: 27015
		private static readonly IntPtr NativeMethodInfoPtr__OnMinPass_b__27_0_Private_Boolean_Player_0;

		// Token: 0x04006988 RID: 27016
		private static readonly IntPtr NativeMethodInfoPtr__Retreat_b__31_0_Private_Single_StaticDoor_0;

		// Token: 0x04006989 RID: 27017
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400698A RID: 27018
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400698B RID: 27019
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400698C RID: 27020
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000C41 RID: 3137
		[OriginalName("Assembly-CSharp.dll", "", "ESewerGoblinState")]
		public enum ESewerGoblinState
		{
			// Token: 0x0400A225 RID: 41509
			Inactive,
			// Token: 0x0400A226 RID: 41510
			Attacking,
			// Token: 0x0400A227 RID: 41511
			Retrieving,
			// Token: 0x0400A228 RID: 41512
			Retreating
		}

		// Token: 0x02000C42 RID: 3138
		[ObfuscatedName("ScheduleOne.NPCs.CharacterClasses.SewerGoblin+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EF84 RID: 61316 RVA: 0x0039DDB0 File Offset: 0x0039BFB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<SewerGoblin.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SewerGoblin>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerGoblin.__c__DisplayClass29_0>.NativeClassPtr);
				SewerGoblin.__c__DisplayClass29_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerGoblin.__c__DisplayClass29_0>.NativeClassPtr, "player");
				SewerGoblin.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin.__c__DisplayClass29_0>.NativeClassPtr, 100683295);
				SewerGoblin.__c__DisplayClass29_0.NativeMethodInfoPtr__DeployToPlayer_b__0_Internal_Single_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerGoblin.__c__DisplayClass29_0>.NativeClassPtr, 100683296);
			}

			// Token: 0x0600EF85 RID: 61317 RVA: 0x0039DE18 File Offset: 0x0039C018
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerGoblin.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EF86 RID: 61318 RVA: 0x0039DE54 File Offset: 0x0039C054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273842, XrefRangeEnd = 273851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _DeployToPlayer_b__0(StaticDoor door)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(door);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerGoblin.__c__DisplayClass29_0.NativeMethodInfoPtr__DeployToPlayer_b__0_Internal_Single_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EF87 RID: 61319 RVA: 0x000710D9 File Offset: 0x0006F2D9
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700489C RID: 18588
			// (get) Token: 0x0600EF88 RID: 61320 RVA: 0x0039DEA4 File Offset: 0x0039C0A4
			// (set) Token: 0x0600EF89 RID: 61321 RVA: 0x000710E2 File Offset: 0x0006F2E2
			public unsafe Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.__c__DisplayClass29_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerGoblin.__c__DisplayClass29_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A229 RID: 41513
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x0400A22A RID: 41514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A22B RID: 41515
			private static readonly IntPtr NativeMethodInfoPtr__DeployToPlayer_b__0_Internal_Single_StaticDoor_0;
		}
	}
}

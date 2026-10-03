using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x02000301 RID: 769
	public class LevelManager : NetworkSingleton<LevelManager>
	{
		// Token: 0x06003CC6 RID: 15558 RVA: 0x00147E90 File Offset: 0x00146090
		// Note: this type is marked as 'beforefieldinit'.
		static LevelManager()
		{
			Il2CppClassPointerStore<LevelManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "LevelManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelManager>.NativeClassPtr);
			LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "TIERS_PER_RANK");
			LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "XP_PER_TIER_MIN");
			LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "XP_PER_TIER_MAX");
			LevelManager.NativeFieldInfoPtr__Rank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<Rank>k__BackingField");
			LevelManager.NativeFieldInfoPtr_rankCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "rankCount");
			LevelManager.NativeFieldInfoPtr__Tier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<Tier>k__BackingField");
			LevelManager.NativeFieldInfoPtr__XP_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<XP>k__BackingField");
			LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<TotalXP>k__BackingField");
			LevelManager.NativeFieldInfoPtr_onRankUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "onRankUp");
			LevelManager.NativeFieldInfoPtr_onRankChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "onRankChanged");
			LevelManager.NativeFieldInfoPtr_Unlockables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "Unlockables");
			LevelManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "loader");
			LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			LevelManager.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<LoadOrder>k__BackingField");
			LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted");
			LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Levelling.LevelManagerAssembly-CSharp.dll_Excuted");
			LevelManager.NativeMethodInfoPtr_get_Rank_Public_get_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671062);
			LevelManager.NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671063);
			LevelManager.NativeMethodInfoPtr_get_Tier_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671064);
			LevelManager.NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671065);
			LevelManager.NativeMethodInfoPtr_get_XP_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671066);
			LevelManager.NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671067);
			LevelManager.NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671068);
			LevelManager.NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671069);
			LevelManager.NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671070);
			LevelManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671071);
			LevelManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671072);
			LevelManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671073);
			LevelManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671074);
			LevelManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671075);
			LevelManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671076);
			LevelManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671077);
			LevelManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671078);
			LevelManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671079);
			LevelManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671080);
			LevelManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671081);
			LevelManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671082);
			LevelManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671083);
			LevelManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671084);
			LevelManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671085);
			LevelManager.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671086);
			LevelManager.NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671087);
			LevelManager.NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671088);
			LevelManager.NativeMethodInfoPtr_SetUnlockedRegions_Public_Void_NetworkConnection_List_1_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671089);
			LevelManager.NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671090);
			LevelManager.NativeMethodInfoPtr_IncreaseTier_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671091);
			LevelManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671092);
			LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671093);
			LevelManager.NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671094);
			LevelManager.NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671095);
			LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671096);
			LevelManager.NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671097);
			LevelManager.NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671098);
			LevelManager.NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671099);
			LevelManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671100);
			LevelManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671101);
			LevelManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671102);
			LevelManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671103);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671104);
			LevelManager.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671105);
			LevelManager.NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671106);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671107);
			LevelManager.NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671108);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671109);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671110);
			LevelManager.NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671111);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671112);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671113);
			LevelManager.NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671114);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlockedRegions_563230222_Private_Void_NetworkConnection_List_1_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671115);
			LevelManager.NativeMethodInfoPtr_RpcLogic___SetUnlockedRegions_563230222_Public_Void_NetworkConnection_List_1_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671116);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_SetUnlockedRegions_563230222_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671117);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Target_SetUnlockedRegions_563230222_Private_Void_NetworkConnection_List_1_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671118);
			LevelManager.NativeMethodInfoPtr_RpcReader___Target_SetUnlockedRegions_563230222_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671119);
			LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671120);
			LevelManager.NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671121);
			LevelManager.NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671122);
			LevelManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, 100671123);
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x00148500 File Offset: 0x00146700
		// (set) Token: 0x06003CC8 RID: 15560 RVA: 0x0014853C File Offset: 0x0014673C
		public unsafe ERank Rank
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Rank_Public_get_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x0014857C File Offset: 0x0014677C
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x001485B8 File Offset: 0x001467B8
		public unsafe int Tier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Tier_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x001485F8 File Offset: 0x001467F8
		// (set) Token: 0x06003CCC RID: 15564 RVA: 0x00148634 File Offset: 0x00146834
		public unsafe int XP
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_XP_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06003CCD RID: 15565 RVA: 0x00148674 File Offset: 0x00146874
		// (set) Token: 0x06003CCE RID: 15566 RVA: 0x001486B0 File Offset: 0x001468B0
		public unsafe int TotalXP
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 56794, RefRangeEnd = 56832, XrefRangeStart = 56794, XrefRangeEnd = 56832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x001486F0 File Offset: 0x001468F0
		public unsafe float XPToNextTier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151465, XrefRangeEnd = 151467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06003CD0 RID: 15568 RVA: 0x0014872C File Offset: 0x0014692C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151467, XrefRangeEnd = 151469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x00148764 File Offset: 0x00146964
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151469, XrefRangeEnd = 151471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06003CD2 RID: 15570 RVA: 0x0014879C File Offset: 0x0014699C
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06003CD3 RID: 15571 RVA: 0x001487DC File Offset: 0x001469DC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06003CD4 RID: 15572 RVA: 0x00148818 File Offset: 0x00146A18
		// (set) Token: 0x06003CD5 RID: 15573 RVA: 0x00148858 File Offset: 0x00146A58
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06003CD6 RID: 15574 RVA: 0x0014889C File Offset: 0x00146A9C
		// (set) Token: 0x06003CD7 RID: 15575 RVA: 0x001488DC File Offset: 0x00146ADC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x00148920 File Offset: 0x00146B20
		// (set) Token: 0x06003CD9 RID: 15577 RVA: 0x0014895C File Offset: 0x00146B5C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x0014899C File Offset: 0x00146B9C
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x001489D8 File Offset: 0x00146BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151471, XrefRangeEnd = 151486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x00148A14 File Offset: 0x00146C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151486, XrefRangeEnd = 151489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x00148A50 File Offset: 0x00146C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151489, XrefRangeEnd = 151498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x00148AA0 File Offset: 0x00146CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151498, XrefRangeEnd = 151504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x00148ADC File Offset: 0x00146CDC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 151515, RefRangeEnd = 151531, XrefRangeStart = 151504, XrefRangeEnd = 151515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXP(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x00148B1C File Offset: 0x00146D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151531, XrefRangeEnd = 151542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXPLocal(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x00148B5C File Offset: 0x00146D5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151592, RefRangeEnd = 151595, XrefRangeStart = 151542, XrefRangeEnd = 151592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x00148BD8 File Offset: 0x00146DD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151634, RefRangeEnd = 151636, XrefRangeStart = 151595, XrefRangeEnd = 151634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlockedRegions(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unlockedRegions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_SetUnlockedRegions_Public_Void_NetworkConnection_List_1_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x00148C2C File Offset: 0x00146E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151636, XrefRangeEnd = 151647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseTierNetworked(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref after;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00148C78 File Offset: 0x00146E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151647, XrefRangeEnd = 151649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseTier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_IncreaseTier_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00148CAC File Offset: 0x00146EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151649, XrefRangeEnd = 151667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x00148CF0 File Offset: 0x00146EF0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 151667, RefRangeEnd = 151675, XrefRangeStart = 151667, XrefRangeEnd = 151667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank GetFullRank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x00148D2C File Offset: 0x00146F2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151709, RefRangeEnd = 151711, XrefRangeStart = 151675, XrefRangeEnd = 151709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnlockable(Unlockable unlockable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(unlockable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00148D70 File Offset: 0x00146F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151730, RefRangeEnd = 151731, XrefRangeStart = 151711, XrefRangeEnd = 151730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalXPForRank(FullRank fullrank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fullrank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x00148DBC File Offset: 0x00146FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151751, RefRangeEnd = 151752, XrefRangeStart = 151731, XrefRangeEnd = 151751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank GetFullRank(int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x00148E08 File Offset: 0x00147008
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 151755, RefRangeEnd = 151761, XrefRangeStart = 151752, XrefRangeEnd = 151755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetXPForTier(ERank rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x00148E54 File Offset: 0x00147054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151762, RefRangeEnd = 151763, XrefRangeStart = 151761, XrefRangeEnd = 151762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetOrderLimitMultiplier(FullRank rank)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x00148E94 File Offset: 0x00147094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151763, RefRangeEnd = 151764, XrefRangeStart = 151763, XrefRangeEnd = 151763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetRankOrderLimitMultiplier(ERank rank)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x00148ED4 File Offset: 0x001470D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151764, XrefRangeEnd = 151791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LevelManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x00148F10 File Offset: 0x00147110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151791, XrefRangeEnd = 151838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x00148F4C File Offset: 0x0014714C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151838, XrefRangeEnd = 151841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x00148F88 File Offset: 0x00147188
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x00148FC4 File Offset: 0x001471C4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 151515, RefRangeEnd = 151531, XrefRangeStart = 151515, XrefRangeEnd = 151531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x00149004 File Offset: 0x00147204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x00149044 File Offset: 0x00147244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151841, XrefRangeEnd = 151855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AddXP_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x001490A8 File Offset: 0x001472A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddXPLocal_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x001490E8 File Offset: 0x001472E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151878, RefRangeEnd = 151879, XrefRangeStart = 151855, XrefRangeEnd = 151878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddXPLocal_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x00149128 File Offset: 0x00147328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151879, XrefRangeEnd = 151883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddXPLocal_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x00149178 File Offset: 0x00147378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151883, XrefRangeEnd = 151899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x001491F4 File Offset: 0x001473F4
		[CallerCount(0)]
		public unsafe void RpcLogic___SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x00149270 File Offset: 0x00147470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151899, XrefRangeEnd = 151908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x001492C0 File Offset: 0x001474C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151908, XrefRangeEnd = 151924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetData_20965027(NetworkConnection conn, ERank rank, int tier, int xp, int totalXp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x0014933C File Offset: 0x0014753C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151924, XrefRangeEnd = 151933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetData_20965027(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x0014938C File Offset: 0x0014758C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151933, XrefRangeEnd = 151943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unlockedRegions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlockedRegions_563230222_Private_Void_NetworkConnection_List_1_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x001493E0 File Offset: 0x001475E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151963, RefRangeEnd = 151966, XrefRangeStart = 151943, XrefRangeEnd = 151963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unlockedRegions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___SetUnlockedRegions_563230222_Public_Void_NetworkConnection_List_1_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x00149434 File Offset: 0x00147634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151966, XrefRangeEnd = 151970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetUnlockedRegions_563230222(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_SetUnlockedRegions_563230222_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x00149484 File Offset: 0x00147684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151970, XrefRangeEnd = 151980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetUnlockedRegions_563230222(NetworkConnection conn, List<EMapRegion> unlockedRegions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unlockedRegions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Target_SetUnlockedRegions_563230222_Private_Void_NetworkConnection_List_1_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x001494D8 File Offset: 0x001476D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151980, XrefRangeEnd = 151984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetUnlockedRegions_563230222(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Target_SetUnlockedRegions_563230222_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x00149528 File Offset: 0x00147728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref after;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00149574 File Offset: 0x00147774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151984, XrefRangeEnd = 151997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___IncreaseTierNetworked_3953286437(FullRank before, FullRank after)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref before;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref after;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x001495C0 File Offset: 0x001477C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151997, XrefRangeEnd = 152013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_IncreaseTierNetworked_3953286437(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x00149610 File Offset: 0x00147810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152013, XrefRangeEnd = 152027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LevelManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x0001E52F File Offset: 0x0001C72F
		public LevelManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06003D06 RID: 15622 RVA: 0x0014964C File Offset: 0x0014784C
		// (set) Token: 0x06003D07 RID: 15623 RVA: 0x0001E538 File Offset: 0x0001C738
		public unsafe static int TIERS_PER_RANK
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_TIERS_PER_RANK, (void*)(&value));
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06003D08 RID: 15624 RVA: 0x00149668 File Offset: 0x00147868
		// (set) Token: 0x06003D09 RID: 15625 RVA: 0x0001E546 File Offset: 0x0001C746
		public unsafe static int XP_PER_TIER_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06003D0A RID: 15626 RVA: 0x00149684 File Offset: 0x00147884
		// (set) Token: 0x06003D0B RID: 15627 RVA: 0x0001E554 File Offset: 0x0001C754
		public unsafe static int XP_PER_TIER_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LevelManager.NativeFieldInfoPtr_XP_PER_TIER_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06003D0C RID: 15628 RVA: 0x001496A0 File Offset: 0x001478A0
		// (set) Token: 0x06003D0D RID: 15629 RVA: 0x0001E562 File Offset: 0x0001C762
		public unsafe ERank _Rank_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Rank_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Rank_k__BackingField)) = value;
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06003D0E RID: 15630 RVA: 0x001496C8 File Offset: 0x001478C8
		// (set) Token: 0x06003D0F RID: 15631 RVA: 0x0001E57D File Offset: 0x0001C77D
		public unsafe int rankCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_rankCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_rankCount)) = value;
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06003D10 RID: 15632 RVA: 0x001496F0 File Offset: 0x001478F0
		// (set) Token: 0x06003D11 RID: 15633 RVA: 0x0001E598 File Offset: 0x0001C798
		public unsafe int _Tier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Tier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__Tier_k__BackingField)) = value;
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06003D12 RID: 15634 RVA: 0x00149718 File Offset: 0x00147918
		// (set) Token: 0x06003D13 RID: 15635 RVA: 0x0001E5B3 File Offset: 0x0001C7B3
		public unsafe int _XP_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__XP_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__XP_k__BackingField)) = value;
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06003D14 RID: 15636 RVA: 0x00149740 File Offset: 0x00147940
		// (set) Token: 0x06003D15 RID: 15637 RVA: 0x0001E5CE File Offset: 0x0001C7CE
		public unsafe int _TotalXP_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__TotalXP_k__BackingField)) = value;
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06003D16 RID: 15638 RVA: 0x00149768 File Offset: 0x00147968
		// (set) Token: 0x06003D17 RID: 15639 RVA: 0x0001E5E9 File Offset: 0x0001C7E9
		public unsafe Action<FullRank, FullRank> onRankUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_onRankUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FullRank, FullRank>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_onRankUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06003D18 RID: 15640 RVA: 0x00149798 File Offset: 0x00147998
		// (set) Token: 0x06003D19 RID: 15641 RVA: 0x0001E608 File Offset: 0x0001C808
		public unsafe Action<FullRank, FullRank> onRankChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_onRankChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<FullRank, FullRank>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_onRankChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06003D1A RID: 15642 RVA: 0x001497C8 File Offset: 0x001479C8
		// (set) Token: 0x06003D1B RID: 15643 RVA: 0x0001E627 File Offset: 0x0001C827
		public unsafe Dictionary<FullRank, List<Unlockable>> Unlockables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_Unlockables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FullRank, List<Unlockable>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_Unlockables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06003D1C RID: 15644 RVA: 0x001497F8 File Offset: 0x001479F8
		// (set) Token: 0x06003D1D RID: 15645 RVA: 0x0001E646 File Offset: 0x0001C846
		public unsafe RankLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06003D1E RID: 15646 RVA: 0x00149828 File Offset: 0x00147A28
		// (set) Token: 0x06003D1F RID: 15647 RVA: 0x0001E665 File Offset: 0x0001C865
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06003D20 RID: 15648 RVA: 0x00149858 File Offset: 0x00147A58
		// (set) Token: 0x06003D21 RID: 15649 RVA: 0x0001E684 File Offset: 0x0001C884
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x06003D22 RID: 15650 RVA: 0x00149888 File Offset: 0x00147A88
		// (set) Token: 0x06003D23 RID: 15651 RVA: 0x0001E6A3 File Offset: 0x0001C8A3
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x06003D24 RID: 15652 RVA: 0x001498B0 File Offset: 0x00147AB0
		// (set) Token: 0x06003D25 RID: 15653 RVA: 0x0001E6BE File Offset: 0x0001C8BE
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06003D26 RID: 15654 RVA: 0x001498D8 File Offset: 0x00147AD8
		// (set) Token: 0x06003D27 RID: 15655 RVA: 0x0001E6D9 File Offset: 0x0001C8D9
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06003D28 RID: 15656 RVA: 0x00149900 File Offset: 0x00147B00
		// (set) Token: 0x06003D29 RID: 15657 RVA: 0x0001E6F4 File Offset: 0x0001C8F4
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002909 RID: 10505
		private static readonly IntPtr NativeFieldInfoPtr_TIERS_PER_RANK;

		// Token: 0x0400290A RID: 10506
		private static readonly IntPtr NativeFieldInfoPtr_XP_PER_TIER_MIN;

		// Token: 0x0400290B RID: 10507
		private static readonly IntPtr NativeFieldInfoPtr_XP_PER_TIER_MAX;

		// Token: 0x0400290C RID: 10508
		private static readonly IntPtr NativeFieldInfoPtr__Rank_k__BackingField;

		// Token: 0x0400290D RID: 10509
		private static readonly IntPtr NativeFieldInfoPtr_rankCount;

		// Token: 0x0400290E RID: 10510
		private static readonly IntPtr NativeFieldInfoPtr__Tier_k__BackingField;

		// Token: 0x0400290F RID: 10511
		private static readonly IntPtr NativeFieldInfoPtr__XP_k__BackingField;

		// Token: 0x04002910 RID: 10512
		private static readonly IntPtr NativeFieldInfoPtr__TotalXP_k__BackingField;

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeFieldInfoPtr_onRankUp;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeFieldInfoPtr_onRankChanged;

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeFieldInfoPtr_Unlockables;

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x04002919 RID: 10521
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400291B RID: 10523
		private static readonly IntPtr NativeMethodInfoPtr_get_Rank_Public_get_ERank_0;

		// Token: 0x0400291C RID: 10524
		private static readonly IntPtr NativeMethodInfoPtr_set_Rank_Private_set_Void_ERank_0;

		// Token: 0x0400291D RID: 10525
		private static readonly IntPtr NativeMethodInfoPtr_get_Tier_Public_get_Int32_0;

		// Token: 0x0400291E RID: 10526
		private static readonly IntPtr NativeMethodInfoPtr_set_Tier_Private_set_Void_Int32_0;

		// Token: 0x0400291F RID: 10527
		private static readonly IntPtr NativeMethodInfoPtr_get_XP_Public_get_Int32_0;

		// Token: 0x04002920 RID: 10528
		private static readonly IntPtr NativeMethodInfoPtr_set_XP_Private_set_Void_Int32_0;

		// Token: 0x04002921 RID: 10529
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalXP_Public_get_Int32_0;

		// Token: 0x04002922 RID: 10530
		private static readonly IntPtr NativeMethodInfoPtr_set_TotalXP_Private_set_Void_Int32_0;

		// Token: 0x04002923 RID: 10531
		private static readonly IntPtr NativeMethodInfoPtr_get_XPToNextTier_Public_get_Single_0;

		// Token: 0x04002924 RID: 10532
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002925 RID: 10533
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002926 RID: 10534
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04002927 RID: 10535
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002928 RID: 10536
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002929 RID: 10537
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400292A RID: 10538
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400292B RID: 10539
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400292C RID: 10540
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400292D RID: 10541
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400292E RID: 10542
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400292F RID: 10543
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002930 RID: 10544
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04002931 RID: 10545
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04002932 RID: 10546
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04002933 RID: 10547
		private static readonly IntPtr NativeMethodInfoPtr_AddXP_Public_Void_Int32_0;

		// Token: 0x04002934 RID: 10548
		private static readonly IntPtr NativeMethodInfoPtr_AddXPLocal_Private_Void_Int32_0;

		// Token: 0x04002935 RID: 10549
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x04002936 RID: 10550
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlockedRegions_Public_Void_NetworkConnection_List_1_EMapRegion_0;

		// Token: 0x04002937 RID: 10551
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseTierNetworked_Private_Void_FullRank_FullRank_0;

		// Token: 0x04002938 RID: 10552
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseTier_Private_Void_0;

		// Token: 0x04002939 RID: 10553
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400293A RID: 10554
		private static readonly IntPtr NativeMethodInfoPtr_GetFullRank_Public_FullRank_0;

		// Token: 0x0400293B RID: 10555
		private static readonly IntPtr NativeMethodInfoPtr_AddUnlockable_Public_Void_Unlockable_0;

		// Token: 0x0400293C RID: 10556
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalXPForRank_Public_Int32_FullRank_0;

		// Token: 0x0400293D RID: 10557
		private static readonly IntPtr NativeMethodInfoPtr_GetFullRank_Public_FullRank_Int32_0;

		// Token: 0x0400293E RID: 10558
		private static readonly IntPtr NativeMethodInfoPtr_GetXPForTier_Public_Int32_ERank_0;

		// Token: 0x0400293F RID: 10559
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderLimitMultiplier_Public_Static_Single_FullRank_0;

		// Token: 0x04002940 RID: 10560
		private static readonly IntPtr NativeMethodInfoPtr_GetRankOrderLimitMultiplier_Private_Static_Single_ERank_0;

		// Token: 0x04002941 RID: 10561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002942 RID: 10562
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002943 RID: 10563
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002944 RID: 10564
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002945 RID: 10565
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AddXP_3316948804_Private_Void_Int32_0;

		// Token: 0x04002946 RID: 10566
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0;

		// Token: 0x04002947 RID: 10567
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AddXP_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002948 RID: 10568
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddXPLocal_3316948804_Private_Void_Int32_0;

		// Token: 0x04002949 RID: 10569
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddXPLocal_3316948804_Private_Void_Int32_0;

		// Token: 0x0400294A RID: 10570
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddXPLocal_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400294B RID: 10571
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x0400294C RID: 10572
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_20965027_Public_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x0400294D RID: 10573
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetData_20965027_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400294E RID: 10574
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetData_20965027_Private_Void_NetworkConnection_ERank_Int32_Int32_Int32_0;

		// Token: 0x0400294F RID: 10575
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetData_20965027_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002950 RID: 10576
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetUnlockedRegions_563230222_Private_Void_NetworkConnection_List_1_EMapRegion_0;

		// Token: 0x04002951 RID: 10577
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetUnlockedRegions_563230222_Public_Void_NetworkConnection_List_1_EMapRegion_0;

		// Token: 0x04002952 RID: 10578
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetUnlockedRegions_563230222_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002953 RID: 10579
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetUnlockedRegions_563230222_Private_Void_NetworkConnection_List_1_EMapRegion_0;

		// Token: 0x04002954 RID: 10580
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetUnlockedRegions_563230222_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002955 RID: 10581
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0;

		// Token: 0x04002956 RID: 10582
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___IncreaseTierNetworked_3953286437_Private_Void_FullRank_FullRank_0;

		// Token: 0x04002957 RID: 10583
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_IncreaseTierNetworked_3953286437_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002958 RID: 10584
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A3D RID: 2621
		[ObfuscatedName("ScheduleOne.Levelling.LevelManager+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : Object
		{
			// Token: 0x0600DF5F RID: 57183 RVA: 0x00370038 File Offset: 0x0036E238
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<LevelManager.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LevelManager>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelManager.__c__DisplayClass61_0>.NativeClassPtr);
				LevelManager.__c__DisplayClass61_0.NativeFieldInfoPtr_unlockable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelManager.__c__DisplayClass61_0>.NativeClassPtr, "unlockable");
				LevelManager.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager.__c__DisplayClass61_0>.NativeClassPtr, 100671124);
				LevelManager.__c__DisplayClass61_0.NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelManager.__c__DisplayClass61_0>.NativeClassPtr, 100671125);
			}

			// Token: 0x0600DF60 RID: 57184 RVA: 0x003700A0 File Offset: 0x0036E2A0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelManager.__c__DisplayClass61_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF61 RID: 57185 RVA: 0x003700DC File Offset: 0x0036E2DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151461, XrefRangeEnd = 151465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddUnlockable_b__0(Unlockable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelManager.__c__DisplayClass61_0.NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF62 RID: 57186 RVA: 0x00069324 File Offset: 0x00067524
			public __c__DisplayClass61_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043FC RID: 17404
			// (get) Token: 0x0600DF63 RID: 57187 RVA: 0x0037012C File Offset: 0x0036E32C
			// (set) Token: 0x0600DF64 RID: 57188 RVA: 0x0006932D File Offset: 0x0006752D
			public unsafe Unlockable unlockable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.__c__DisplayClass61_0.NativeFieldInfoPtr_unlockable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Unlockable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelManager.__c__DisplayClass61_0.NativeFieldInfoPtr_unlockable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400981F RID: 38943
			private static readonly IntPtr NativeFieldInfoPtr_unlockable;

			// Token: 0x04009820 RID: 38944
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009821 RID: 38945
			private static readonly IntPtr NativeMethodInfoPtr__AddUnlockable_b__0_Internal_Boolean_Unlockable_0;
		}
	}
}

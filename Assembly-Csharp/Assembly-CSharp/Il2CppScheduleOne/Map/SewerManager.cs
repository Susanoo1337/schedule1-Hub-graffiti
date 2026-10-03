using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002C7 RID: 711
	public class SewerManager : NetworkSingleton<SewerManager>
	{
		// Token: 0x06003753 RID: 14163 RVA: 0x00132D7C File Offset: 0x00130F7C
		// Note: this type is marked as 'beforefieldinit'.
		static SewerManager()
		{
			Il2CppClassPointerStore<SewerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "SewerManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerManager>.NativeClassPtr);
			SewerManager.NativeFieldInfoPtr__IsSewerUnlocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "<IsSewerUnlocked>k__BackingField");
			SewerManager.NativeFieldInfoPtr__IsRandomWorldKeyCollected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "<IsRandomWorldKeyCollected>k__BackingField");
			SewerManager.NativeFieldInfoPtr__RandomSewerKeyLocationIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "<RandomSewerKeyLocationIndex>k__BackingField");
			SewerManager.NativeFieldInfoPtr__HasSewerKingBeenDefeated_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "<HasSewerKingBeenDefeated>k__BackingField");
			SewerManager.NativeFieldInfoPtr__RandomSewerPossessorIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "<RandomSewerPossessorIndex>k__BackingField");
			SewerManager.NativeFieldInfoPtr_SewerKeyItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "SewerKeyItem");
			SewerManager.NativeFieldInfoPtr_SewerUnlockSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "SewerUnlockSound");
			SewerManager.NativeFieldInfoPtr_RandomWorldSewerKeyPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "RandomWorldSewerKeyPickup");
			SewerManager.NativeFieldInfoPtr_RandomSewerKeyLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "RandomSewerKeyLocations");
			SewerManager.NativeFieldInfoPtr_SewerKingNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "SewerKingNPC");
			SewerManager.NativeFieldInfoPtr_SewerGoblinNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "SewerGoblinNPC");
			SewerManager.NativeFieldInfoPtr_SewerKeyPossessors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "SewerKeyPossessors");
			SewerManager.NativeFieldInfoPtr_SewerMushrooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "SewerMushrooms");
			SewerManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "loader");
			SewerManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			SewerManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			SewerManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			SewerManager.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "<LoadOrder>k__BackingField");
			SewerManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Map.SewerManagerAssembly-CSharp.dll_Excuted");
			SewerManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Map.SewerManagerAssembly-CSharp.dll_Excuted");
			SewerManager.NativeMethodInfoPtr_get_IsSewerUnlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670271);
			SewerManager.NativeMethodInfoPtr_set_IsSewerUnlocked_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670272);
			SewerManager.NativeMethodInfoPtr_get_IsRandomWorldKeyCollected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670273);
			SewerManager.NativeMethodInfoPtr_set_IsRandomWorldKeyCollected_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670274);
			SewerManager.NativeMethodInfoPtr_get_RandomSewerKeyLocationIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670275);
			SewerManager.NativeMethodInfoPtr_set_RandomSewerKeyLocationIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670276);
			SewerManager.NativeMethodInfoPtr_get_HasSewerKingBeenDefeated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670277);
			SewerManager.NativeMethodInfoPtr_set_HasSewerKingBeenDefeated_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670278);
			SewerManager.NativeMethodInfoPtr_get_RandomSewerPossessorIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670279);
			SewerManager.NativeMethodInfoPtr_set_RandomSewerPossessorIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670280);
			SewerManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670281);
			SewerManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670282);
			SewerManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670283);
			SewerManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670284);
			SewerManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670285);
			SewerManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670286);
			SewerManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670287);
			SewerManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670288);
			SewerManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670289);
			SewerManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670290);
			SewerManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670291);
			SewerManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670292);
			SewerManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670293);
			SewerManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670294);
			SewerManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670295);
			SewerManager.NativeMethodInfoPtr_SetSewerUnlocked_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670296);
			SewerManager.NativeMethodInfoPtr_SetSewerUnlocked_Client_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670297);
			SewerManager.NativeMethodInfoPtr_SetRandomWorldKeyCollected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670298);
			SewerManager.NativeMethodInfoPtr_SetRandomKeyCollected_Server_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670299);
			SewerManager.NativeMethodInfoPtr_SetRandomKeyCollected_Client_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670300);
			SewerManager.NativeMethodInfoPtr_SetSewerKeyLocation_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670301);
			SewerManager.NativeMethodInfoPtr_SewerKingDefeated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670302);
			SewerManager.NativeMethodInfoPtr_DisableSewerKing_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670303);
			SewerManager.NativeMethodInfoPtr_GetPlayersInSewer_Public_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670304);
			SewerManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670305);
			SewerManager.NativeMethodInfoPtr_Load_Public_Void_SewerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670306);
			SewerManager.NativeMethodInfoPtr_SetRandomKeyPossessor_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670307);
			SewerManager.NativeMethodInfoPtr_AskedAboutSewerKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670308);
			SewerManager.NativeMethodInfoPtr_EnsureKeyPosessorHasKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670309);
			SewerManager.NativeMethodInfoPtr_GetSewerKeyPossessor_Public_KeyPossessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670310);
			SewerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670311);
			SewerManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670312);
			SewerManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670313);
			SewerManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670314);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Server_SetSewerUnlocked_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670315);
			SewerManager.NativeMethodInfoPtr_RpcLogic___SetSewerUnlocked_Server_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670316);
			SewerManager.NativeMethodInfoPtr_RpcReader___Server_SetSewerUnlocked_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670317);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Observers_SetSewerUnlocked_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670318);
			SewerManager.NativeMethodInfoPtr_RpcLogic___SetSewerUnlocked_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670319);
			SewerManager.NativeMethodInfoPtr_RpcReader___Observers_SetSewerUnlocked_Client_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670320);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Target_SetSewerUnlocked_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670321);
			SewerManager.NativeMethodInfoPtr_RpcReader___Target_SetSewerUnlocked_Client_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670322);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Server_SetRandomKeyCollected_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670323);
			SewerManager.NativeMethodInfoPtr_RpcLogic___SetRandomKeyCollected_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670324);
			SewerManager.NativeMethodInfoPtr_RpcReader___Server_SetRandomKeyCollected_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670325);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Observers_SetRandomKeyCollected_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670326);
			SewerManager.NativeMethodInfoPtr_RpcLogic___SetRandomKeyCollected_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670327);
			SewerManager.NativeMethodInfoPtr_RpcReader___Observers_SetRandomKeyCollected_Client_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670328);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Target_SetRandomKeyCollected_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670329);
			SewerManager.NativeMethodInfoPtr_RpcReader___Target_SetRandomKeyCollected_Client_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670330);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Observers_SetSewerKeyLocation_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670331);
			SewerManager.NativeMethodInfoPtr_RpcLogic___SetSewerKeyLocation_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670332);
			SewerManager.NativeMethodInfoPtr_RpcReader___Observers_SetSewerKeyLocation_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670333);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Target_SetSewerKeyLocation_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670334);
			SewerManager.NativeMethodInfoPtr_RpcReader___Target_SetSewerKeyLocation_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670335);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Observers_DisableSewerKing_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670336);
			SewerManager.NativeMethodInfoPtr_RpcLogic___DisableSewerKing_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670337);
			SewerManager.NativeMethodInfoPtr_RpcReader___Observers_DisableSewerKing_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670338);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Target_DisableSewerKing_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670339);
			SewerManager.NativeMethodInfoPtr_RpcReader___Target_DisableSewerKing_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670340);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Observers_SetRandomKeyPossessor_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670341);
			SewerManager.NativeMethodInfoPtr_RpcLogic___SetRandomKeyPossessor_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670342);
			SewerManager.NativeMethodInfoPtr_RpcReader___Observers_SetRandomKeyPossessor_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670343);
			SewerManager.NativeMethodInfoPtr_RpcWriter___Target_SetRandomKeyPossessor_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670344);
			SewerManager.NativeMethodInfoPtr_RpcReader___Target_SetRandomKeyPossessor_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670345);
			SewerManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, 100670346);
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x0013352C File Offset: 0x0013172C
		// (set) Token: 0x06003755 RID: 14165 RVA: 0x00133568 File Offset: 0x00131768
		public unsafe bool IsSewerUnlocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_IsSewerUnlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_set_IsSewerUnlocked_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x001335A8 File Offset: 0x001317A8
		// (set) Token: 0x06003757 RID: 14167 RVA: 0x001335E4 File Offset: 0x001317E4
		public unsafe bool IsRandomWorldKeyCollected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_IsRandomWorldKeyCollected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_set_IsRandomWorldKeyCollected_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x00133624 File Offset: 0x00131824
		// (set) Token: 0x06003759 RID: 14169 RVA: 0x00133660 File Offset: 0x00131860
		public unsafe int RandomSewerKeyLocationIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_RandomSewerKeyLocationIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_set_RandomSewerKeyLocationIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x0600375A RID: 14170 RVA: 0x001336A0 File Offset: 0x001318A0
		// (set) Token: 0x0600375B RID: 14171 RVA: 0x001336DC File Offset: 0x001318DC
		public unsafe bool HasSewerKingBeenDefeated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_HasSewerKingBeenDefeated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_set_HasSewerKingBeenDefeated_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x0600375C RID: 14172 RVA: 0x0013371C File Offset: 0x0013191C
		// (set) Token: 0x0600375D RID: 14173 RVA: 0x00133758 File Offset: 0x00131958
		public unsafe int RandomSewerPossessorIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_RandomSewerPossessorIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_set_RandomSewerPossessorIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x0600375E RID: 14174 RVA: 0x00133798 File Offset: 0x00131998
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143086, XrefRangeEnd = 143088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x0600375F RID: 14175 RVA: 0x001337D0 File Offset: 0x001319D0
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143088, XrefRangeEnd = 143090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06003760 RID: 14176 RVA: 0x00133808 File Offset: 0x00131A08
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06003761 RID: 14177 RVA: 0x00133848 File Offset: 0x00131A48
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06003762 RID: 14178 RVA: 0x00133884 File Offset: 0x00131A84
		// (set) Token: 0x06003763 RID: 14179 RVA: 0x001338C4 File Offset: 0x00131AC4
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143090, XrefRangeEnd = 143091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06003764 RID: 14180 RVA: 0x00133908 File Offset: 0x00131B08
		// (set) Token: 0x06003765 RID: 14181 RVA: 0x00133948 File Offset: 0x00131B48
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143091, XrefRangeEnd = 143092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x06003766 RID: 14182 RVA: 0x0013398C File Offset: 0x00131B8C
		// (set) Token: 0x06003767 RID: 14183 RVA: 0x001339C8 File Offset: 0x00131BC8
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06003768 RID: 14184 RVA: 0x00133A08 File Offset: 0x00131C08
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003769 RID: 14185 RVA: 0x00133A44 File Offset: 0x00131C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143092, XrefRangeEnd = 143111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600376A RID: 14186 RVA: 0x00133A80 File Offset: 0x00131C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143111, XrefRangeEnd = 143160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600376B RID: 14187 RVA: 0x00133ABC File Offset: 0x00131CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143160, XrefRangeEnd = 143166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x00133AF8 File Offset: 0x00131CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143166, XrefRangeEnd = 143180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x00133B48 File Offset: 0x00131D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143189, RefRangeEnd = 143190, XrefRangeStart = 143180, XrefRangeEnd = 143189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSewerUnlocked_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_SetSewerUnlocked_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x00133B7C File Offset: 0x00131D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143232, RefRangeEnd = 143233, XrefRangeStart = 143190, XrefRangeEnd = 143232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSewerUnlocked_Client(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_SetSewerUnlocked_Client_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x00133BC0 File Offset: 0x00131DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143233, XrefRangeEnd = 143254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomWorldKeyCollected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_SetRandomWorldKeyCollected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00133BF4 File Offset: 0x00131DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomKeyCollected_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_SetRandomKeyCollected_Server_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x00133C28 File Offset: 0x00131E28
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 143263, RefRangeEnd = 143269, XrefRangeStart = 143254, XrefRangeEnd = 143263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomKeyCollected_Client(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_SetRandomKeyCollected_Client_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00133C6C File Offset: 0x00131E6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 143310, RefRangeEnd = 143314, XrefRangeStart = 143269, XrefRangeEnd = 143310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSewerKeyLocation(NetworkConnection conn, int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_SetSewerKeyLocation_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x00133CBC File Offset: 0x00131EBC
		[CallerCount(0)]
		public unsafe void SewerKingDefeated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_SewerKingDefeated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x00133CF0 File Offset: 0x00131EF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143340, RefRangeEnd = 143342, XrefRangeStart = 143314, XrefRangeEnd = 143340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableSewerKing(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_DisableSewerKing_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x00133D34 File Offset: 0x00131F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143377, RefRangeEnd = 143378, XrefRangeStart = 143342, XrefRangeEnd = 143377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Player> GetPlayersInSewer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_GetPlayersInSewer_Public_List_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr3) : null;
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00133D74 File Offset: 0x00131F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143378, XrefRangeEnd = 143384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x00133DB8 File Offset: 0x00131FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143419, RefRangeEnd = 143420, XrefRangeStart = 143384, XrefRangeEnd = 143419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(SewerData sewerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sewerData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_Load_Public_Void_SewerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x00133DFC File Offset: 0x00131FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 143461, RefRangeEnd = 143463, XrefRangeStart = 143420, XrefRangeEnd = 143461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomKeyPossessor(NetworkConnection conn, int possessorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref possessorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_SetRandomKeyPossessor_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x00133E4C File Offset: 0x0013204C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143463, XrefRangeEnd = 143469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AskedAboutSewerKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_AskedAboutSewerKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x00133E80 File Offset: 0x00132080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143474, RefRangeEnd = 143475, XrefRangeStart = 143469, XrefRangeEnd = 143474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureKeyPosessorHasKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_EnsureKeyPosessorHasKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x00133EB4 File Offset: 0x001320B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143475, RefRangeEnd = 143476, XrefRangeStart = 143475, XrefRangeEnd = 143475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SewerManager.KeyPossessor GetSewerKeyPossessor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_GetSewerKeyPossessor_Public_KeyPossessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SewerManager.KeyPossessor>(intPtr3) : null;
		}

		// Token: 0x0600377C RID: 14204 RVA: 0x00133EF4 File Offset: 0x001320F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143476, XrefRangeEnd = 143496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SewerManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x00133F30 File Offset: 0x00132130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143496, XrefRangeEnd = 143573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x00133F6C File Offset: 0x0013216C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143573, XrefRangeEnd = 143576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00133FA8 File Offset: 0x001321A8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x00133FE4 File Offset: 0x001321E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143576, XrefRangeEnd = 143585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSewerUnlocked_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Server_SetSewerUnlocked_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x00134018 File Offset: 0x00132218
		[CallerCount(0)]
		public unsafe void RpcLogic___SetSewerUnlocked_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcLogic___SetSewerUnlocked_Server_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x0013404C File Offset: 0x0013224C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143585, XrefRangeEnd = 143587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSewerUnlocked_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Server_SetSewerUnlocked_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x001340B0 File Offset: 0x001322B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143587, XrefRangeEnd = 143596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSewerUnlocked_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Observers_SetSewerUnlocked_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x001340F4 File Offset: 0x001322F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 143602, RefRangeEnd = 143603, XrefRangeStart = 143596, XrefRangeEnd = 143602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSewerUnlocked_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcLogic___SetSewerUnlocked_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x00134138 File Offset: 0x00132338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143603, XrefRangeEnd = 143606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSewerUnlocked_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Observers_SetSewerUnlocked_Client_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x00134188 File Offset: 0x00132388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143606, XrefRangeEnd = 143615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSewerUnlocked_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Target_SetSewerUnlocked_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x001341CC File Offset: 0x001323CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143615, XrefRangeEnd = 143623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSewerUnlocked_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Target_SetSewerUnlocked_Client_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x0013421C File Offset: 0x0013241C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143623, XrefRangeEnd = 143632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetRandomKeyCollected_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Server_SetRandomKeyCollected_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x00134250 File Offset: 0x00132450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143632, XrefRangeEnd = 143633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetRandomKeyCollected_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcLogic___SetRandomKeyCollected_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x00134284 File Offset: 0x00132484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143633, XrefRangeEnd = 143636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetRandomKeyCollected_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Server_SetRandomKeyCollected_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x001342E8 File Offset: 0x001324E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143636, XrefRangeEnd = 143645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetRandomKeyCollected_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Observers_SetRandomKeyCollected_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x0013432C File Offset: 0x0013252C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143645, XrefRangeEnd = 143648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetRandomKeyCollected_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcLogic___SetRandomKeyCollected_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x00134370 File Offset: 0x00132570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143648, XrefRangeEnd = 143652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetRandomKeyCollected_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Observers_SetRandomKeyCollected_Client_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x001343C0 File Offset: 0x001325C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143652, XrefRangeEnd = 143661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetRandomKeyCollected_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Target_SetRandomKeyCollected_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x00134404 File Offset: 0x00132604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143661, XrefRangeEnd = 143665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetRandomKeyCollected_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Target_SetRandomKeyCollected_Client_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x00134454 File Offset: 0x00132654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143665, XrefRangeEnd = 143676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSewerKeyLocation_2681120339(NetworkConnection conn, int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Observers_SetSewerKeyLocation_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x001344A4 File Offset: 0x001326A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143690, RefRangeEnd = 143693, XrefRangeStart = 143676, XrefRangeEnd = 143690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSewerKeyLocation_2681120339(NetworkConnection conn, int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcLogic___SetSewerKeyLocation_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x001344F4 File Offset: 0x001326F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143693, XrefRangeEnd = 143698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSewerKeyLocation_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Observers_SetSewerKeyLocation_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x00134544 File Offset: 0x00132744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143698, XrefRangeEnd = 143709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSewerKeyLocation_2681120339(NetworkConnection conn, int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Target_SetSewerKeyLocation_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x00134594 File Offset: 0x00132794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143709, XrefRangeEnd = 143714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSewerKeyLocation_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Target_SetSewerKeyLocation_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x001345E4 File Offset: 0x001327E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143714, XrefRangeEnd = 143723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DisableSewerKing_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Observers_DisableSewerKing_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x00134628 File Offset: 0x00132828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143723, XrefRangeEnd = 143726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DisableSewerKing_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcLogic___DisableSewerKing_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x0013466C File Offset: 0x0013286C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143726, XrefRangeEnd = 143729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DisableSewerKing_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Observers_DisableSewerKing_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x001346BC File Offset: 0x001328BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143729, XrefRangeEnd = 143738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_DisableSewerKing_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Target_DisableSewerKing_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x00134700 File Offset: 0x00132900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143738, XrefRangeEnd = 143742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_DisableSewerKing_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Target_DisableSewerKing_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x00134750 File Offset: 0x00132950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143742, XrefRangeEnd = 143753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetRandomKeyPossessor_2681120339(NetworkConnection conn, int possessorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref possessorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Observers_SetRandomKeyPossessor_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x001347A0 File Offset: 0x001329A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 143781, RefRangeEnd = 143784, XrefRangeStart = 143753, XrefRangeEnd = 143781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetRandomKeyPossessor_2681120339(NetworkConnection conn, int possessorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref possessorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcLogic___SetRandomKeyPossessor_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x001347F0 File Offset: 0x001329F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143784, XrefRangeEnd = 143789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetRandomKeyPossessor_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Observers_SetRandomKeyPossessor_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x00134840 File Offset: 0x00132A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143789, XrefRangeEnd = 143800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetRandomKeyPossessor_2681120339(NetworkConnection conn, int possessorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref possessorIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcWriter___Target_SetRandomKeyPossessor_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x00134890 File Offset: 0x00132A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143800, XrefRangeEnd = 143805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetRandomKeyPossessor_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.NativeMethodInfoPtr_RpcReader___Target_SetRandomKeyPossessor_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x001348E0 File Offset: 0x00132AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143805, XrefRangeEnd = 143824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x0001C288 File Offset: 0x0001A488
		public SewerManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x060037A1 RID: 14241 RVA: 0x0013491C File Offset: 0x00132B1C
		// (set) Token: 0x060037A2 RID: 14242 RVA: 0x0001C291 File Offset: 0x0001A491
		public unsafe bool _IsSewerUnlocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__IsSewerUnlocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__IsSewerUnlocked_k__BackingField)) = value;
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x060037A3 RID: 14243 RVA: 0x00134944 File Offset: 0x00132B44
		// (set) Token: 0x060037A4 RID: 14244 RVA: 0x0001C2AC File Offset: 0x0001A4AC
		public unsafe bool _IsRandomWorldKeyCollected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__IsRandomWorldKeyCollected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__IsRandomWorldKeyCollected_k__BackingField)) = value;
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x060037A5 RID: 14245 RVA: 0x0013496C File Offset: 0x00132B6C
		// (set) Token: 0x060037A6 RID: 14246 RVA: 0x0001C2C7 File Offset: 0x0001A4C7
		public unsafe int _RandomSewerKeyLocationIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__RandomSewerKeyLocationIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__RandomSewerKeyLocationIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x060037A7 RID: 14247 RVA: 0x00134994 File Offset: 0x00132B94
		// (set) Token: 0x060037A8 RID: 14248 RVA: 0x0001C2E2 File Offset: 0x0001A4E2
		public unsafe bool _HasSewerKingBeenDefeated_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__HasSewerKingBeenDefeated_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__HasSewerKingBeenDefeated_k__BackingField)) = value;
			}
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x060037A9 RID: 14249 RVA: 0x001349BC File Offset: 0x00132BBC
		// (set) Token: 0x060037AA RID: 14250 RVA: 0x0001C2FD File Offset: 0x0001A4FD
		public unsafe int _RandomSewerPossessorIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__RandomSewerPossessorIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__RandomSewerPossessorIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x060037AB RID: 14251 RVA: 0x001349E4 File Offset: 0x00132BE4
		// (set) Token: 0x060037AC RID: 14252 RVA: 0x0001C318 File Offset: 0x0001A518
		public unsafe ItemDefinition SewerKeyItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerKeyItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerKeyItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x060037AD RID: 14253 RVA: 0x00134A14 File Offset: 0x00132C14
		// (set) Token: 0x060037AE RID: 14254 RVA: 0x0001C337 File Offset: 0x0001A537
		public unsafe AudioSourceController SewerUnlockSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerUnlockSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerUnlockSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x060037AF RID: 14255 RVA: 0x00134A44 File Offset: 0x00132C44
		// (set) Token: 0x060037B0 RID: 14256 RVA: 0x0001C356 File Offset: 0x0001A556
		public unsafe NetworkedItemPickup RandomWorldSewerKeyPickup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_RandomWorldSewerKeyPickup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkedItemPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_RandomWorldSewerKeyPickup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x060037B1 RID: 14257 RVA: 0x00134A74 File Offset: 0x00132C74
		// (set) Token: 0x060037B2 RID: 14258 RVA: 0x0001C375 File Offset: 0x0001A575
		public unsafe Il2CppReferenceArray<Transform> RandomSewerKeyLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_RandomSewerKeyLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_RandomSewerKeyLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x060037B3 RID: 14259 RVA: 0x00134AA4 File Offset: 0x00132CA4
		// (set) Token: 0x060037B4 RID: 14260 RVA: 0x0001C394 File Offset: 0x0001A594
		public unsafe SewerKing SewerKingNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerKingNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SewerKing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerKingNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x060037B5 RID: 14261 RVA: 0x00134AD4 File Offset: 0x00132CD4
		// (set) Token: 0x060037B6 RID: 14262 RVA: 0x0001C3B3 File Offset: 0x0001A5B3
		public unsafe SewerGoblin SewerGoblinNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerGoblinNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SewerGoblin>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerGoblinNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x060037B7 RID: 14263 RVA: 0x00134B04 File Offset: 0x00132D04
		// (set) Token: 0x060037B8 RID: 14264 RVA: 0x0001C3D2 File Offset: 0x0001A5D2
		public unsafe Il2CppReferenceArray<SewerManager.KeyPossessor> SewerKeyPossessors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerKeyPossessors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SewerManager.KeyPossessor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerKeyPossessors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x060037B9 RID: 14265 RVA: 0x00134B34 File Offset: 0x00132D34
		// (set) Token: 0x060037BA RID: 14266 RVA: 0x0001C3F1 File Offset: 0x0001A5F1
		public unsafe SewerMushrooms SewerMushrooms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerMushrooms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SewerMushrooms>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_SewerMushrooms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x060037BB RID: 14267 RVA: 0x00134B64 File Offset: 0x00132D64
		// (set) Token: 0x060037BC RID: 14268 RVA: 0x0001C410 File Offset: 0x0001A610
		public unsafe SewerLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SewerLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x060037BD RID: 14269 RVA: 0x00134B94 File Offset: 0x00132D94
		// (set) Token: 0x060037BE RID: 14270 RVA: 0x0001C42F File Offset: 0x0001A62F
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x060037BF RID: 14271 RVA: 0x00134BC4 File Offset: 0x00132DC4
		// (set) Token: 0x060037C0 RID: 14272 RVA: 0x0001C44E File Offset: 0x0001A64E
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x060037C1 RID: 14273 RVA: 0x00134BF4 File Offset: 0x00132DF4
		// (set) Token: 0x060037C2 RID: 14274 RVA: 0x0001C46D File Offset: 0x0001A66D
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x060037C3 RID: 14275 RVA: 0x00134C1C File Offset: 0x00132E1C
		// (set) Token: 0x060037C4 RID: 14276 RVA: 0x0001C488 File Offset: 0x0001A688
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x060037C5 RID: 14277 RVA: 0x00134C44 File Offset: 0x00132E44
		// (set) Token: 0x060037C6 RID: 14278 RVA: 0x0001C4A3 File Offset: 0x0001A6A3
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x060037C7 RID: 14279 RVA: 0x00134C6C File Offset: 0x00132E6C
		// (set) Token: 0x060037C8 RID: 14280 RVA: 0x0001C4BE File Offset: 0x0001A6BE
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040024FF RID: 9471
		private static readonly IntPtr NativeFieldInfoPtr__IsSewerUnlocked_k__BackingField;

		// Token: 0x04002500 RID: 9472
		private static readonly IntPtr NativeFieldInfoPtr__IsRandomWorldKeyCollected_k__BackingField;

		// Token: 0x04002501 RID: 9473
		private static readonly IntPtr NativeFieldInfoPtr__RandomSewerKeyLocationIndex_k__BackingField;

		// Token: 0x04002502 RID: 9474
		private static readonly IntPtr NativeFieldInfoPtr__HasSewerKingBeenDefeated_k__BackingField;

		// Token: 0x04002503 RID: 9475
		private static readonly IntPtr NativeFieldInfoPtr__RandomSewerPossessorIndex_k__BackingField;

		// Token: 0x04002504 RID: 9476
		private static readonly IntPtr NativeFieldInfoPtr_SewerKeyItem;

		// Token: 0x04002505 RID: 9477
		private static readonly IntPtr NativeFieldInfoPtr_SewerUnlockSound;

		// Token: 0x04002506 RID: 9478
		private static readonly IntPtr NativeFieldInfoPtr_RandomWorldSewerKeyPickup;

		// Token: 0x04002507 RID: 9479
		private static readonly IntPtr NativeFieldInfoPtr_RandomSewerKeyLocations;

		// Token: 0x04002508 RID: 9480
		private static readonly IntPtr NativeFieldInfoPtr_SewerKingNPC;

		// Token: 0x04002509 RID: 9481
		private static readonly IntPtr NativeFieldInfoPtr_SewerGoblinNPC;

		// Token: 0x0400250A RID: 9482
		private static readonly IntPtr NativeFieldInfoPtr_SewerKeyPossessors;

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeFieldInfoPtr_SewerMushrooms;

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSewerUnlocked_Public_get_Boolean_0;

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSewerUnlocked_Private_set_Void_Boolean_0;

		// Token: 0x04002515 RID: 9493
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRandomWorldKeyCollected_Public_get_Boolean_0;

		// Token: 0x04002516 RID: 9494
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRandomWorldKeyCollected_Private_set_Void_Boolean_0;

		// Token: 0x04002517 RID: 9495
		private static readonly IntPtr NativeMethodInfoPtr_get_RandomSewerKeyLocationIndex_Public_get_Int32_0;

		// Token: 0x04002518 RID: 9496
		private static readonly IntPtr NativeMethodInfoPtr_set_RandomSewerKeyLocationIndex_Public_set_Void_Int32_0;

		// Token: 0x04002519 RID: 9497
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSewerKingBeenDefeated_Public_get_Boolean_0;

		// Token: 0x0400251A RID: 9498
		private static readonly IntPtr NativeMethodInfoPtr_set_HasSewerKingBeenDefeated_Private_set_Void_Boolean_0;

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeMethodInfoPtr_get_RandomSewerPossessorIndex_Public_get_Int32_0;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeMethodInfoPtr_set_RandomSewerPossessorIndex_Public_set_Void_Int32_0;

		// Token: 0x0400251D RID: 9501
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400251E RID: 9502
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400251F RID: 9503
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04002520 RID: 9504
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002521 RID: 9505
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002522 RID: 9506
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002523 RID: 9507
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002524 RID: 9508
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002525 RID: 9509
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002526 RID: 9510
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04002527 RID: 9511
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002528 RID: 9512
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002529 RID: 9513
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x0400252A RID: 9514
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400252B RID: 9515
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400252C RID: 9516
		private static readonly IntPtr NativeMethodInfoPtr_SetSewerUnlocked_Server_Public_Void_0;

		// Token: 0x0400252D RID: 9517
		private static readonly IntPtr NativeMethodInfoPtr_SetSewerUnlocked_Client_Private_Void_NetworkConnection_0;

		// Token: 0x0400252E RID: 9518
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomWorldKeyCollected_Public_Void_0;

		// Token: 0x0400252F RID: 9519
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomKeyCollected_Server_Private_Void_0;

		// Token: 0x04002530 RID: 9520
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomKeyCollected_Client_Private_Void_NetworkConnection_0;

		// Token: 0x04002531 RID: 9521
		private static readonly IntPtr NativeMethodInfoPtr_SetSewerKeyLocation_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04002532 RID: 9522
		private static readonly IntPtr NativeMethodInfoPtr_SewerKingDefeated_Private_Void_0;

		// Token: 0x04002533 RID: 9523
		private static readonly IntPtr NativeMethodInfoPtr_DisableSewerKing_Private_Void_NetworkConnection_0;

		// Token: 0x04002534 RID: 9524
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayersInSewer_Public_List_1_Player_0;

		// Token: 0x04002535 RID: 9525
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04002536 RID: 9526
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_SewerData_0;

		// Token: 0x04002537 RID: 9527
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomKeyPossessor_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04002538 RID: 9528
		private static readonly IntPtr NativeMethodInfoPtr_AskedAboutSewerKey_Private_Void_0;

		// Token: 0x04002539 RID: 9529
		private static readonly IntPtr NativeMethodInfoPtr_EnsureKeyPosessorHasKey_Private_Void_0;

		// Token: 0x0400253A RID: 9530
		private static readonly IntPtr NativeMethodInfoPtr_GetSewerKeyPossessor_Public_KeyPossessor_0;

		// Token: 0x0400253B RID: 9531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400253C RID: 9532
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400253D RID: 9533
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400253E RID: 9534
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400253F RID: 9535
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSewerUnlocked_Server_2166136261_Private_Void_0;

		// Token: 0x04002540 RID: 9536
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSewerUnlocked_Server_2166136261_Public_Void_0;

		// Token: 0x04002541 RID: 9537
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSewerUnlocked_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002542 RID: 9538
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSewerUnlocked_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002543 RID: 9539
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSewerUnlocked_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002544 RID: 9540
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSewerUnlocked_Client_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002545 RID: 9541
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSewerUnlocked_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002546 RID: 9542
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSewerUnlocked_Client_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002547 RID: 9543
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetRandomKeyCollected_Server_2166136261_Private_Void_0;

		// Token: 0x04002548 RID: 9544
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetRandomKeyCollected_Server_2166136261_Private_Void_0;

		// Token: 0x04002549 RID: 9545
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetRandomKeyCollected_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400254A RID: 9546
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetRandomKeyCollected_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400254B RID: 9547
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetRandomKeyCollected_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400254C RID: 9548
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetRandomKeyCollected_Client_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400254D RID: 9549
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetRandomKeyCollected_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400254E RID: 9550
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetRandomKeyCollected_Client_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400254F RID: 9551
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSewerKeyLocation_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04002550 RID: 9552
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSewerKeyLocation_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04002551 RID: 9553
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSewerKeyLocation_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002552 RID: 9554
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSewerKeyLocation_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04002553 RID: 9555
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSewerKeyLocation_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002554 RID: 9556
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DisableSewerKing_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002555 RID: 9557
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DisableSewerKing_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002556 RID: 9558
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DisableSewerKing_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002557 RID: 9559
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_DisableSewerKing_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002558 RID: 9560
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_DisableSewerKing_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002559 RID: 9561
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetRandomKeyPossessor_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x0400255A RID: 9562
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetRandomKeyPossessor_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x0400255B RID: 9563
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetRandomKeyPossessor_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400255C RID: 9564
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetRandomKeyPossessor_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x0400255D RID: 9565
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetRandomKeyPossessor_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400255E RID: 9566
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A1C RID: 2588
		[Serializable]
		public class KeyPossessor : Il2CppSystem.Object
		{
			// Token: 0x0600DE66 RID: 56934 RVA: 0x0036D6F8 File Offset: 0x0036B8F8
			// Note: this type is marked as 'beforefieldinit'.
			static KeyPossessor()
			{
				Il2CppClassPointerStore<SewerManager.KeyPossessor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SewerManager>.NativeClassPtr, "KeyPossessor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerManager.KeyPossessor>.NativeClassPtr);
				SewerManager.KeyPossessor.NativeFieldInfoPtr_NPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager.KeyPossessor>.NativeClassPtr, "NPC");
				SewerManager.KeyPossessor.NativeFieldInfoPtr_NPCDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerManager.KeyPossessor>.NativeClassPtr, "NPCDescription");
				SewerManager.KeyPossessor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerManager.KeyPossessor>.NativeClassPtr, 100670347);
			}

			// Token: 0x0600DE67 RID: 56935 RVA: 0x0036D760 File Offset: 0x0036B960
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyPossessor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerManager.KeyPossessor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerManager.KeyPossessor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE68 RID: 56936 RVA: 0x00068B16 File Offset: 0x00066D16
			public KeyPossessor(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B6 RID: 17334
			// (get) Token: 0x0600DE69 RID: 56937 RVA: 0x0036D79C File Offset: 0x0036B99C
			// (set) Token: 0x0600DE6A RID: 56938 RVA: 0x00068B1F File Offset: 0x00066D1F
			public unsafe NPC NPC
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.KeyPossessor.NativeFieldInfoPtr_NPC);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.KeyPossessor.NativeFieldInfoPtr_NPC), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B7 RID: 17335
			// (get) Token: 0x0600DE6B RID: 56939 RVA: 0x0036D7CC File Offset: 0x0036B9CC
			// (set) Token: 0x0600DE6C RID: 56940 RVA: 0x00068B3E File Offset: 0x00066D3E
			public unsafe string NPCDescription
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.KeyPossessor.NativeFieldInfoPtr_NPCDescription);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerManager.KeyPossessor.NativeFieldInfoPtr_NPCDescription), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009785 RID: 38789
			private static readonly IntPtr NativeFieldInfoPtr_NPC;

			// Token: 0x04009786 RID: 38790
			private static readonly IntPtr NativeFieldInfoPtr_NPCDescription;

			// Token: 0x04009787 RID: 38791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

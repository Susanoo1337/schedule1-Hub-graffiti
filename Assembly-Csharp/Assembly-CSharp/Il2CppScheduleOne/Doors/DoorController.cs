using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x020003A8 RID: 936
	public class DoorController : NetworkBehaviour
	{
		// Token: 0x060054ED RID: 21741 RVA: 0x001A1620 File Offset: 0x0019F820
		// Note: this type is marked as 'beforefieldinit'.
		static DoorController()
		{
			Il2CppClassPointerStore<DoorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DoorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorController>.NativeClassPtr);
			DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "DISTANT_PLAYER_THRESHOLD");
			DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<IsOpen>k__BackingField");
			DoorController.NativeFieldInfoPtr_PlayerAccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "PlayerAccess");
			DoorController.NativeFieldInfoPtr_AutoOpenForPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoOpenForPlayer");
			DoorController.NativeFieldInfoPtr_InteriorIntObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "InteriorIntObjs");
			DoorController.NativeFieldInfoPtr_ExteriorIntObjs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ExteriorIntObjs");
			DoorController.NativeFieldInfoPtr_PlayerBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "PlayerBlocker");
			DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "InteriorDoorHandleAnimation");
			DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ExteriorDoorHandleAnimation");
			DoorController.NativeFieldInfoPtr_AutoCloseOnSleep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoCloseOnSleep");
			DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "AutoCloseOnDistantPlayer");
			DoorController.NativeFieldInfoPtr_OpenableByNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "OpenableByNPCs");
			DoorController.NativeFieldInfoPtr_ReturnToOriginalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "ReturnToOriginalTime");
			DoorController.NativeFieldInfoPtr_onDoorOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "onDoorOpened");
			DoorController.NativeFieldInfoPtr_onDoorClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "onDoorClosed");
			DoorController.NativeFieldInfoPtr_lastOpenSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "lastOpenSide");
			DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<openedByNPC>k__BackingField");
			DoorController.NativeFieldInfoPtr__detectedNPCCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<detectedNPCCount>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeSinceNPCSensed>k__BackingField");
			DoorController.NativeFieldInfoPtr_autoOpenedForPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "autoOpenedForPlayer");
			DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<playerDetectedSinceOpened>k__BackingField");
			DoorController.NativeFieldInfoPtr__detectedPlayerCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<detectedPlayerCount>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeSincePlayerSensed>k__BackingField");
			DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "<timeInCurrentState>k__BackingField");
			DoorController.NativeFieldInfoPtr_noAccessErrorMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "noAccessErrorMessage");
			DoorController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted");
			DoorController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Doors.DoorControllerAssembly-CSharp.dll_Excuted");
			DoorController.NativeMethodInfoPtr_get_IsOpen_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674446);
			DoorController.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674447);
			DoorController.NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674448);
			DoorController.NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674449);
			DoorController.NativeMethodInfoPtr_get_detectedNPCCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674450);
			DoorController.NativeMethodInfoPtr_set_detectedNPCCount_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674451);
			DoorController.NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674452);
			DoorController.NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674453);
			DoorController.NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674454);
			DoorController.NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674455);
			DoorController.NativeMethodInfoPtr_get_detectedPlayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674456);
			DoorController.NativeMethodInfoPtr_set_detectedPlayerCount_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674457);
			DoorController.NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674458);
			DoorController.NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674459);
			DoorController.NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674460);
			DoorController.NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674461);
			DoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674462);
			DoorController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674463);
			DoorController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674464);
			DoorController.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674465);
			DoorController.NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674466);
			DoorController.NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674467);
			DoorController.NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674468);
			DoorController.NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674469);
			DoorController.NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674470);
			DoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674471);
			DoorController.NativeMethodInfoPtr_NPCVicinityEnter_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674472);
			DoorController.NativeMethodInfoPtr_NPCVicinityExit_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674473);
			DoorController.NativeMethodInfoPtr_PlayerVicinityEnter_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674474);
			DoorController.NativeMethodInfoPtr_PlayerVicinityExit_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674475);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674476);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674477);
			DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674478);
			DoorController.NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674479);
			DoorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674480);
			DoorController.NativeMethodInfoPtr__Start_b__50_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674481);
			DoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674482);
			DoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674483);
			DoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674484);
			DoorController.NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674485);
			DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674486);
			DoorController.NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674487);
			DoorController.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674488);
			DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674489);
			DoorController.NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674490);
			DoorController.NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674491);
			DoorController.NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674492);
			DoorController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorController>.NativeClassPtr, 100674493);
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x060054EE RID: 21742 RVA: 0x001A1C2C File Offset: 0x0019FE2C
		// (set) Token: 0x060054EF RID: 21743 RVA: 0x001A1C68 File Offset: 0x0019FE68
		public unsafe virtual bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_IsOpen_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x060054F0 RID: 21744 RVA: 0x001A1CA8 File Offset: 0x0019FEA8
		// (set) Token: 0x060054F1 RID: 21745 RVA: 0x001A1CE4 File Offset: 0x0019FEE4
		public unsafe bool openedByNPC
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x060054F2 RID: 21746 RVA: 0x001A1D24 File Offset: 0x0019FF24
		// (set) Token: 0x060054F3 RID: 21747 RVA: 0x001A1D60 File Offset: 0x0019FF60
		public unsafe int detectedNPCCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_detectedNPCCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_detectedNPCCount_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x060054F4 RID: 21748 RVA: 0x001A1DA0 File Offset: 0x0019FFA0
		// (set) Token: 0x060054F5 RID: 21749 RVA: 0x001A1DDC File Offset: 0x0019FFDC
		public unsafe float timeSinceNPCSensed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x060054F6 RID: 21750 RVA: 0x001A1E1C File Offset: 0x001A001C
		// (set) Token: 0x060054F7 RID: 21751 RVA: 0x001A1E58 File Offset: 0x001A0058
		public unsafe bool playerDetectedSinceOpened
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x060054F8 RID: 21752 RVA: 0x001A1E98 File Offset: 0x001A0098
		// (set) Token: 0x060054F9 RID: 21753 RVA: 0x001A1ED4 File Offset: 0x001A00D4
		public unsafe int detectedPlayerCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_detectedPlayerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_detectedPlayerCount_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x060054FA RID: 21754 RVA: 0x001A1F14 File Offset: 0x001A0114
		// (set) Token: 0x060054FB RID: 21755 RVA: 0x001A1F50 File Offset: 0x001A0150
		public unsafe float timeSincePlayerSensed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x060054FC RID: 21756 RVA: 0x001A1F90 File Offset: 0x001A0190
		// (set) Token: 0x060054FD RID: 21757 RVA: 0x001A1FCC File Offset: 0x001A01CC
		public unsafe float timeInCurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x001A200C File Offset: 0x001A020C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189000, RefRangeEnd = 189002, XrefRangeStart = 188999, XrefRangeEnd = 189000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x001A2048 File Offset: 0x001A0248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189002, XrefRangeEnd = 189017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x001A2084 File Offset: 0x001A0284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189017, XrefRangeEnd = 189023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x001A20C0 File Offset: 0x001A02C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189023, XrefRangeEnd = 189025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x001A2110 File Offset: 0x001A0310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189025, XrefRangeEnd = 189037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InteriorHandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x001A214C File Offset: 0x001A034C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189037, XrefRangeEnd = 189043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InteriorHandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x001A2188 File Offset: 0x001A0388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189043, XrefRangeEnd = 189055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExteriorHandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x001A21C4 File Offset: 0x001A03C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189055, XrefRangeEnd = 189061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExteriorHandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005506 RID: 21766 RVA: 0x001A2200 File Offset: 0x001A0400
		[CallerCount(0)]
		public unsafe bool CanPlayerAccess(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x001A224C File Offset: 0x001A044C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189062, RefRangeEnd = 189063, XrefRangeStart = 189061, XrefRangeEnd = 189062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x001A22BC File Offset: 0x001A04BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189063, XrefRangeEnd = 189066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCVicinityEnter(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NPCVicinityEnter_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x001A2308 File Offset: 0x001A0508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189066, XrefRangeEnd = 189067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCVicinityExit(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NPCVicinityExit_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x001A2354 File Offset: 0x001A0554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189067, XrefRangeEnd = 189068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayerVicinityEnter(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_PlayerVicinityEnter_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x001A23A0 File Offset: 0x001A05A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189068, XrefRangeEnd = 189069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayerVicinityExit(EDoorSide side)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref side;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_PlayerVicinityExit_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x001A23EC File Offset: 0x001A05EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 189093, RefRangeEnd = 189101, XrefRangeStart = 189069, XrefRangeEnd = 189093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen_Server(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x001A2448 File Offset: 0x001A0648
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 189141, RefRangeEnd = 189146, XrefRangeStart = 189101, XrefRangeEnd = 189141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x001A24A8 File Offset: 0x001A06A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189146, XrefRangeEnd = 189151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x001A2500 File Offset: 0x001A0700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189151, XrefRangeEnd = 189156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckAutoCloseForDistantPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x001A253C File Offset: 0x001A073C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189160, RefRangeEnd = 189161, XrefRangeStart = 189156, XrefRangeEnd = 189160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x001A2578 File Offset: 0x001A0778
		[CallerCount(0)]
		public unsafe void _Start_b__50_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr__Start_b__50_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x001A25AC File Offset: 0x001A07AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189181, RefRangeEnd = 189182, XrefRangeStart = 189161, XrefRangeEnd = 189181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x001A25E8 File Offset: 0x001A07E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 105226, RefRangeEnd = 105227, XrefRangeStart = 105226, XrefRangeEnd = 105227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x001A2624 File Offset: 0x001A0824
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x001A2660 File Offset: 0x001A0860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189182, XrefRangeEnd = 189194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x001A26BC File Offset: 0x001A08BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189194, XrefRangeEnd = 189195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsOpen_Server_1319291243(bool open, EDoorSide accessSide, bool openedForPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref accessSide;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openedForPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x001A2718 File Offset: 0x001A0918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189195, XrefRangeEnd = 189199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetIsOpen_Server_1319291243(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x001A277C File Offset: 0x001A097C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189199, XrefRangeEnd = 189210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x001A27DC File Offset: 0x001A09DC
		[CallerCount(0)]
		public unsafe void RpcLogic___SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x001A283C File Offset: 0x001A0A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189210, XrefRangeEnd = 189213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x001A288C File Offset: 0x001A0A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189213, XrefRangeEnd = 189224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsOpen_3381113727(NetworkConnection conn, bool open, EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref open;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x001A28EC File Offset: 0x001A0AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189224, XrefRangeEnd = 189227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsOpen_3381113727(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorController.NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x001A293C File Offset: 0x001A0B3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 189267, RefRangeEnd = 189269, XrefRangeStart = 189227, XrefRangeEnd = 189267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DoorController.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x000281C5 File Offset: 0x000263C5
		public DoorController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x0600551F RID: 21791 RVA: 0x001A2978 File Offset: 0x001A0B78
		// (set) Token: 0x06005520 RID: 21792 RVA: 0x000281CE File Offset: 0x000263CE
		public unsafe static float DISTANT_PLAYER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoorController.NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06005521 RID: 21793 RVA: 0x001A2994 File Offset: 0x001A0B94
		// (set) Token: 0x06005522 RID: 21794 RVA: 0x000281DC File Offset: 0x000263DC
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06005523 RID: 21795 RVA: 0x001A29BC File Offset: 0x001A0BBC
		// (set) Token: 0x06005524 RID: 21796 RVA: 0x000281F7 File Offset: 0x000263F7
		public unsafe EDoorAccess PlayerAccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerAccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerAccess)) = value;
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06005525 RID: 21797 RVA: 0x001A29E4 File Offset: 0x001A0BE4
		// (set) Token: 0x06005526 RID: 21798 RVA: 0x00028212 File Offset: 0x00026412
		public unsafe bool AutoOpenForPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoOpenForPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoOpenForPlayer)) = value;
			}
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06005527 RID: 21799 RVA: 0x001A2A0C File Offset: 0x001A0C0C
		// (set) Token: 0x06005528 RID: 21800 RVA: 0x0002822D File Offset: 0x0002642D
		public unsafe Il2CppReferenceArray<InteractableObject> InteriorIntObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorIntObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InteractableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorIntObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06005529 RID: 21801 RVA: 0x001A2A3C File Offset: 0x001A0C3C
		// (set) Token: 0x0600552A RID: 21802 RVA: 0x0002824C File Offset: 0x0002644C
		public unsafe Il2CppReferenceArray<InteractableObject> ExteriorIntObjs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorIntObjs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InteractableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorIntObjs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x0600552B RID: 21803 RVA: 0x001A2A6C File Offset: 0x001A0C6C
		// (set) Token: 0x0600552C RID: 21804 RVA: 0x0002826B File Offset: 0x0002646B
		public unsafe BoxCollider PlayerBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_PlayerBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x0600552D RID: 21805 RVA: 0x001A2A9C File Offset: 0x001A0C9C
		// (set) Token: 0x0600552E RID: 21806 RVA: 0x0002828A File Offset: 0x0002648A
		public unsafe Animation InteriorDoorHandleAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_InteriorDoorHandleAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x0600552F RID: 21807 RVA: 0x001A2ACC File Offset: 0x001A0CCC
		// (set) Token: 0x06005530 RID: 21808 RVA: 0x000282A9 File Offset: 0x000264A9
		public unsafe Animation ExteriorDoorHandleAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ExteriorDoorHandleAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06005531 RID: 21809 RVA: 0x001A2AFC File Offset: 0x001A0CFC
		// (set) Token: 0x06005532 RID: 21810 RVA: 0x000282C8 File Offset: 0x000264C8
		public unsafe bool AutoCloseOnSleep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnSleep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnSleep)) = value;
			}
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06005533 RID: 21811 RVA: 0x001A2B24 File Offset: 0x001A0D24
		// (set) Token: 0x06005534 RID: 21812 RVA: 0x000282E3 File Offset: 0x000264E3
		public unsafe bool AutoCloseOnDistantPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_AutoCloseOnDistantPlayer)) = value;
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06005535 RID: 21813 RVA: 0x001A2B4C File Offset: 0x001A0D4C
		// (set) Token: 0x06005536 RID: 21814 RVA: 0x000282FE File Offset: 0x000264FE
		public unsafe bool OpenableByNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_OpenableByNPCs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_OpenableByNPCs)) = value;
			}
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x06005537 RID: 21815 RVA: 0x001A2B74 File Offset: 0x001A0D74
		// (set) Token: 0x06005538 RID: 21816 RVA: 0x00028319 File Offset: 0x00026519
		public unsafe float ReturnToOriginalTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ReturnToOriginalTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_ReturnToOriginalTime)) = value;
			}
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06005539 RID: 21817 RVA: 0x001A2B9C File Offset: 0x001A0D9C
		// (set) Token: 0x0600553A RID: 21818 RVA: 0x00028334 File Offset: 0x00026534
		public unsafe UnityEvent<EDoorSide> onDoorOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EDoorSide>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x0600553B RID: 21819 RVA: 0x001A2BCC File Offset: 0x001A0DCC
		// (set) Token: 0x0600553C RID: 21820 RVA: 0x00028353 File Offset: 0x00026553
		public unsafe UnityEvent onDoorClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_onDoorClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x0600553D RID: 21821 RVA: 0x001A2BFC File Offset: 0x001A0DFC
		// (set) Token: 0x0600553E RID: 21822 RVA: 0x00028372 File Offset: 0x00026572
		public unsafe EDoorSide lastOpenSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_lastOpenSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_lastOpenSide)) = value;
			}
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x0600553F RID: 21823 RVA: 0x001A2C24 File Offset: 0x001A0E24
		// (set) Token: 0x06005540 RID: 21824 RVA: 0x0002838D File Offset: 0x0002658D
		public unsafe bool _openedByNPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__openedByNPC_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06005541 RID: 21825 RVA: 0x001A2C4C File Offset: 0x001A0E4C
		// (set) Token: 0x06005542 RID: 21826 RVA: 0x000283A8 File Offset: 0x000265A8
		public unsafe int _detectedNPCCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__detectedNPCCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__detectedNPCCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06005543 RID: 21827 RVA: 0x001A2C74 File Offset: 0x001A0E74
		// (set) Token: 0x06005544 RID: 21828 RVA: 0x000283C3 File Offset: 0x000265C3
		public unsafe float _timeSinceNPCSensed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06005545 RID: 21829 RVA: 0x001A2C9C File Offset: 0x001A0E9C
		// (set) Token: 0x06005546 RID: 21830 RVA: 0x000283DE File Offset: 0x000265DE
		public unsafe bool autoOpenedForPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_autoOpenedForPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_autoOpenedForPlayer)) = value;
			}
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x06005547 RID: 21831 RVA: 0x001A2CC4 File Offset: 0x001A0EC4
		// (set) Token: 0x06005548 RID: 21832 RVA: 0x000283F9 File Offset: 0x000265F9
		public unsafe bool _playerDetectedSinceOpened_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x06005549 RID: 21833 RVA: 0x001A2CEC File Offset: 0x001A0EEC
		// (set) Token: 0x0600554A RID: 21834 RVA: 0x00028414 File Offset: 0x00026614
		public unsafe int _detectedPlayerCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__detectedPlayerCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__detectedPlayerCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x0600554B RID: 21835 RVA: 0x001A2D14 File Offset: 0x001A0F14
		// (set) Token: 0x0600554C RID: 21836 RVA: 0x0002842F File Offset: 0x0002662F
		public unsafe float _timeSincePlayerSensed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x0600554D RID: 21837 RVA: 0x001A2D3C File Offset: 0x001A0F3C
		// (set) Token: 0x0600554E RID: 21838 RVA: 0x0002844A File Offset: 0x0002664A
		public unsafe float _timeInCurrentState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr__timeInCurrentState_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x0600554F RID: 21839 RVA: 0x001A2D64 File Offset: 0x001A0F64
		// (set) Token: 0x06005550 RID: 21840 RVA: 0x00028465 File Offset: 0x00026665
		public unsafe string noAccessErrorMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_noAccessErrorMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_noAccessErrorMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06005551 RID: 21841 RVA: 0x001A2D8C File Offset: 0x001A0F8C
		// (set) Token: 0x06005552 RID: 21842 RVA: 0x00028484 File Offset: 0x00026684
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06005553 RID: 21843 RVA: 0x001A2DB4 File Offset: 0x001A0FB4
		// (set) Token: 0x06005554 RID: 21844 RVA: 0x0002849F File Offset: 0x0002669F
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003A8F RID: 14991
		private static readonly IntPtr NativeFieldInfoPtr_DISTANT_PLAYER_THRESHOLD;

		// Token: 0x04003A90 RID: 14992
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04003A91 RID: 14993
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAccess;

		// Token: 0x04003A92 RID: 14994
		private static readonly IntPtr NativeFieldInfoPtr_AutoOpenForPlayer;

		// Token: 0x04003A93 RID: 14995
		private static readonly IntPtr NativeFieldInfoPtr_InteriorIntObjs;

		// Token: 0x04003A94 RID: 14996
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorIntObjs;

		// Token: 0x04003A95 RID: 14997
		private static readonly IntPtr NativeFieldInfoPtr_PlayerBlocker;

		// Token: 0x04003A96 RID: 14998
		private static readonly IntPtr NativeFieldInfoPtr_InteriorDoorHandleAnimation;

		// Token: 0x04003A97 RID: 14999
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorDoorHandleAnimation;

		// Token: 0x04003A98 RID: 15000
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseOnSleep;

		// Token: 0x04003A99 RID: 15001
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseOnDistantPlayer;

		// Token: 0x04003A9A RID: 15002
		private static readonly IntPtr NativeFieldInfoPtr_OpenableByNPCs;

		// Token: 0x04003A9B RID: 15003
		private static readonly IntPtr NativeFieldInfoPtr_ReturnToOriginalTime;

		// Token: 0x04003A9C RID: 15004
		private static readonly IntPtr NativeFieldInfoPtr_onDoorOpened;

		// Token: 0x04003A9D RID: 15005
		private static readonly IntPtr NativeFieldInfoPtr_onDoorClosed;

		// Token: 0x04003A9E RID: 15006
		private static readonly IntPtr NativeFieldInfoPtr_lastOpenSide;

		// Token: 0x04003A9F RID: 15007
		private static readonly IntPtr NativeFieldInfoPtr__openedByNPC_k__BackingField;

		// Token: 0x04003AA0 RID: 15008
		private static readonly IntPtr NativeFieldInfoPtr__detectedNPCCount_k__BackingField;

		// Token: 0x04003AA1 RID: 15009
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceNPCSensed_k__BackingField;

		// Token: 0x04003AA2 RID: 15010
		private static readonly IntPtr NativeFieldInfoPtr_autoOpenedForPlayer;

		// Token: 0x04003AA3 RID: 15011
		private static readonly IntPtr NativeFieldInfoPtr__playerDetectedSinceOpened_k__BackingField;

		// Token: 0x04003AA4 RID: 15012
		private static readonly IntPtr NativeFieldInfoPtr__detectedPlayerCount_k__BackingField;

		// Token: 0x04003AA5 RID: 15013
		private static readonly IntPtr NativeFieldInfoPtr__timeSincePlayerSensed_k__BackingField;

		// Token: 0x04003AA6 RID: 15014
		private static readonly IntPtr NativeFieldInfoPtr__timeInCurrentState_k__BackingField;

		// Token: 0x04003AA7 RID: 15015
		private static readonly IntPtr NativeFieldInfoPtr_noAccessErrorMessage;

		// Token: 0x04003AA8 RID: 15016
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003AA9 RID: 15017
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003AAA RID: 15018
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003AAB RID: 15019
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04003AAC RID: 15020
		private static readonly IntPtr NativeMethodInfoPtr_get_openedByNPC_Public_get_Boolean_0;

		// Token: 0x04003AAD RID: 15021
		private static readonly IntPtr NativeMethodInfoPtr_set_openedByNPC_Protected_set_Void_Boolean_0;

		// Token: 0x04003AAE RID: 15022
		private static readonly IntPtr NativeMethodInfoPtr_get_detectedNPCCount_Public_get_Int32_0;

		// Token: 0x04003AAF RID: 15023
		private static readonly IntPtr NativeMethodInfoPtr_set_detectedNPCCount_Protected_set_Void_Int32_0;

		// Token: 0x04003AB0 RID: 15024
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceNPCSensed_Public_get_Single_0;

		// Token: 0x04003AB1 RID: 15025
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceNPCSensed_Protected_set_Void_Single_0;

		// Token: 0x04003AB2 RID: 15026
		private static readonly IntPtr NativeMethodInfoPtr_get_playerDetectedSinceOpened_Public_get_Boolean_0;

		// Token: 0x04003AB3 RID: 15027
		private static readonly IntPtr NativeMethodInfoPtr_set_playerDetectedSinceOpened_Protected_set_Void_Boolean_0;

		// Token: 0x04003AB4 RID: 15028
		private static readonly IntPtr NativeMethodInfoPtr_get_detectedPlayerCount_Public_get_Int32_0;

		// Token: 0x04003AB5 RID: 15029
		private static readonly IntPtr NativeMethodInfoPtr_set_detectedPlayerCount_Protected_set_Void_Int32_0;

		// Token: 0x04003AB6 RID: 15030
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSincePlayerSensed_Public_get_Single_0;

		// Token: 0x04003AB7 RID: 15031
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSincePlayerSensed_Protected_set_Void_Single_0;

		// Token: 0x04003AB8 RID: 15032
		private static readonly IntPtr NativeMethodInfoPtr_get_timeInCurrentState_Public_get_Single_0;

		// Token: 0x04003AB9 RID: 15033
		private static readonly IntPtr NativeMethodInfoPtr_set_timeInCurrentState_Protected_set_Void_Single_0;

		// Token: 0x04003ABA RID: 15034
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003ABB RID: 15035
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04003ABC RID: 15036
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x04003ABD RID: 15037
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003ABE RID: 15038
		private static readonly IntPtr NativeMethodInfoPtr_InteriorHandleHovered_Public_Virtual_New_Void_0;

		// Token: 0x04003ABF RID: 15039
		private static readonly IntPtr NativeMethodInfoPtr_InteriorHandleInteracted_Public_Virtual_New_Void_0;

		// Token: 0x04003AC0 RID: 15040
		private static readonly IntPtr NativeMethodInfoPtr_ExteriorHandleHovered_Public_Virtual_New_Void_0;

		// Token: 0x04003AC1 RID: 15041
		private static readonly IntPtr NativeMethodInfoPtr_ExteriorHandleInteracted_Public_Virtual_New_Void_0;

		// Token: 0x04003AC2 RID: 15042
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Public_Boolean_EDoorSide_0;

		// Token: 0x04003AC3 RID: 15043
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAccess_Protected_Virtual_New_Boolean_EDoorSide_byref_String_0;

		// Token: 0x04003AC4 RID: 15044
		private static readonly IntPtr NativeMethodInfoPtr_NPCVicinityEnter_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04003AC5 RID: 15045
		private static readonly IntPtr NativeMethodInfoPtr_NPCVicinityExit_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04003AC6 RID: 15046
		private static readonly IntPtr NativeMethodInfoPtr_PlayerVicinityEnter_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04003AC7 RID: 15047
		private static readonly IntPtr NativeMethodInfoPtr_PlayerVicinityExit_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04003AC8 RID: 15048
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Server_Public_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04003AC9 RID: 15049
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003ACA RID: 15050
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_EDoorSide_0;

		// Token: 0x04003ACB RID: 15051
		private static readonly IntPtr NativeMethodInfoPtr_CheckAutoCloseForDistantPlayer_Protected_Virtual_New_Void_1;

		// Token: 0x04003ACC RID: 15052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003ACD RID: 15053
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__50_0_Private_Void_0;

		// Token: 0x04003ACE RID: 15054
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003ACF RID: 15055
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003AD0 RID: 15056
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003AD1 RID: 15057
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetIsOpen_Server_1319291243_Private_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04003AD2 RID: 15058
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOpen_Server_1319291243_Public_Void_Boolean_EDoorSide_Boolean_0;

		// Token: 0x04003AD3 RID: 15059
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetIsOpen_Server_1319291243_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003AD4 RID: 15060
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003AD5 RID: 15061
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOpen_3381113727_Public_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003AD6 RID: 15062
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003AD7 RID: 15063
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsOpen_3381113727_Private_Void_NetworkConnection_Boolean_EDoorSide_0;

		// Token: 0x04003AD8 RID: 15064
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsOpen_3381113727_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003AD9 RID: 15065
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}

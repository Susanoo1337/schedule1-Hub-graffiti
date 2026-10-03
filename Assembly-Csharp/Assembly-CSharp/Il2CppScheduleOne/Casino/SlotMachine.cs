using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x02000435 RID: 1077
	public class SlotMachine : NetworkBehaviour
	{
		// Token: 0x0600600D RID: 24589 RVA: 0x001C7F48 File Offset: 0x001C6148
		// Note: this type is marked as 'beforefieldinit'.
		static SlotMachine()
		{
			Il2CppClassPointerStore<SlotMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "SlotMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr);
			SlotMachine.NativeFieldInfoPtr_BetAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BetAmounts");
			SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "<IsSpinning>k__BackingField");
			SlotMachine.NativeFieldInfoPtr_DownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "DownButton");
			SlotMachine.NativeFieldInfoPtr_UpButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "UpButton");
			SlotMachine.NativeFieldInfoPtr_HandleIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "HandleIntObj");
			SlotMachine.NativeFieldInfoPtr_BetAmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BetAmountLabel");
			SlotMachine.NativeFieldInfoPtr_Reels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "Reels");
			SlotMachine.NativeFieldInfoPtr_SpinLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SpinLoop");
			SlotMachine.NativeFieldInfoPtr_ScreenAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "ScreenAnimation");
			SlotMachine.NativeFieldInfoPtr_JackpotParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotParticles");
			SlotMachine.NativeFieldInfoPtr_WinAmountLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "WinAmountLabels");
			SlotMachine.NativeFieldInfoPtr_MiniWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "MiniWinAnimation");
			SlotMachine.NativeFieldInfoPtr_SmallWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SmallWinAnimation");
			SlotMachine.NativeFieldInfoPtr_BigWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BigWinAnimation");
			SlotMachine.NativeFieldInfoPtr_JackpotAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotAnimation");
			SlotMachine.NativeFieldInfoPtr_MiniWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "MiniWinSound");
			SlotMachine.NativeFieldInfoPtr_SmallWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SmallWinSound");
			SlotMachine.NativeFieldInfoPtr_BigWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BigWinSound");
			SlotMachine.NativeFieldInfoPtr_JackpotSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotSound");
			SlotMachine.NativeFieldInfoPtr_onDownPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onDownPressed");
			SlotMachine.NativeFieldInfoPtr_onUpPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onUpPressed");
			SlotMachine.NativeFieldInfoPtr_onHandlePulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onHandlePulled");
			SlotMachine.NativeFieldInfoPtr_currentBetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "currentBetIndex");
			SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted");
			SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted");
			SlotMachine.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675936);
			SlotMachine.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675937);
			SlotMachine.NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675938);
			SlotMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675939);
			SlotMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675940);
			SlotMachine.NativeMethodInfoPtr_DownHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675941);
			SlotMachine.NativeMethodInfoPtr_DownInteracted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675942);
			SlotMachine.NativeMethodInfoPtr_UpHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675943);
			SlotMachine.NativeMethodInfoPtr_UpInteracted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675944);
			SlotMachine.NativeMethodInfoPtr_HandleHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675945);
			SlotMachine.NativeMethodInfoPtr_HandleInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675946);
			SlotMachine.NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675947);
			SlotMachine.NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675948);
			SlotMachine.NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675949);
			SlotMachine.NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675950);
			SlotMachine.NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675951);
			SlotMachine.NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675952);
			SlotMachine.NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675953);
			SlotMachine.NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675954);
			SlotMachine.NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675955);
			SlotMachine.NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675956);
			SlotMachine.NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675957);
			SlotMachine.NativeMethodInfoPtr_SimulateMany_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675958);
			SlotMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675959);
			SlotMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675961);
			SlotMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675962);
			SlotMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675963);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675964);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675965);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675966);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675967);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675968);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675969);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675970);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675971);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675972);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675973);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675974);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675975);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675976);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675977);
			SlotMachine.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100675978);
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x0600600E RID: 24590 RVA: 0x001C84B4 File Offset: 0x001C66B4
		// (set) Token: 0x0600600F RID: 24591 RVA: 0x001C84F0 File Offset: 0x001C66F0
		public unsafe bool IsSpinning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x06006010 RID: 24592 RVA: 0x001C8530 File Offset: 0x001C6730
		public unsafe int currentBetAmount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 204836, RefRangeEnd = 204839, XrefRangeStart = 204832, XrefRangeEnd = 204836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x001C856C File Offset: 0x001C676C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204839, XrefRangeEnd = 204840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x001C85A8 File Offset: 0x001C67A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204840, XrefRangeEnd = 204842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006013 RID: 24595 RVA: 0x001C85F8 File Offset: 0x001C67F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204842, XrefRangeEnd = 204845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DownHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DownHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006014 RID: 24596 RVA: 0x001C862C File Offset: 0x001C682C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204845, XrefRangeEnd = 204847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DownInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DownInteracted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006015 RID: 24597 RVA: 0x001C8660 File Offset: 0x001C6860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204847, XrefRangeEnd = 204850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_UpHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x001C8694 File Offset: 0x001C6894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204850, XrefRangeEnd = 204862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_UpInteracted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006017 RID: 24599 RVA: 0x001C86C8 File Offset: 0x001C68C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204862, XrefRangeEnd = 204874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_HandleHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006018 RID: 24600 RVA: 0x001C86FC File Offset: 0x001C68FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204874, XrefRangeEnd = 204913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_HandleInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x001C8730 File Offset: 0x001C6930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 204936, RefRangeEnd = 204938, XrefRangeStart = 204913, XrefRangeEnd = 204936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBetIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x001C8770 File Offset: 0x001C6970
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 204979, RefRangeEnd = 204984, XrefRangeStart = 204938, XrefRangeEnd = 204979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBetIndex(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x001C87C0 File Offset: 0x001C69C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204984, XrefRangeEnd = 205008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStartSpin(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x001C8810 File Offset: 0x001C6A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205008, XrefRangeEnd = 205033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSpin(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600601D RID: 24605 RVA: 0x001C8874 File Offset: 0x001C6A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205035, RefRangeEnd = 205036, XrefRangeStart = 205033, XrefRangeEnd = 205035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotMachine.EOutcome EvaluateOutcome(Il2CppStructArray<SlotMachine.ESymbol> outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outcome);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600601E RID: 24606 RVA: 0x001C88C4 File Offset: 0x001C6AC4
		[CallerCount(0)]
		public unsafe int GetWinAmount(SlotMachine.EOutcome outcome, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x001C891C File Offset: 0x001C6B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205036, XrefRangeEnd = 205043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayOutcome(SlotMachine.EOutcome outcome, int winAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref winAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x001C8968 File Offset: 0x001C6B68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205059, RefRangeEnd = 205062, XrefRangeStart = 205043, XrefRangeEnd = 205059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SlotMachine.ESymbol GetRandomSymbol()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x001C8998 File Offset: 0x001C6B98
		[CallerCount(0)]
		public unsafe bool IsFruit(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref symbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x001C89E4 File Offset: 0x001C6BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205062, XrefRangeEnd = 205063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAllFruit(Il2CppStructArray<SlotMachine.ESymbol> symbols)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x001C8A34 File Offset: 0x001C6C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205063, XrefRangeEnd = 205064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUniform(Il2CppStructArray<SlotMachine.ESymbol> symbols)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x001C8A84 File Offset: 0x001C6C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205064, XrefRangeEnd = 205112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SimulateMany()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SimulateMany_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x001C8AB8 File Offset: 0x001C6CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205112, XrefRangeEnd = 205113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x001C8AF4 File Offset: 0x001C6CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205113, XrefRangeEnd = 205145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x001C8B30 File Offset: 0x001C6D30
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x001C8B6C File Offset: 0x001C6D6C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x001C8BA8 File Offset: 0x001C6DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205145, XrefRangeEnd = 205156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBetIndex_3316948804(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x001C8BE8 File Offset: 0x001C6DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205156, XrefRangeEnd = 205157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBetIndex_3316948804(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x001C8C28 File Offset: 0x001C6E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205157, XrefRangeEnd = 205162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBetIndex_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x001C8C8C File Offset: 0x001C6E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205162, XrefRangeEnd = 205173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x001C8CDC File Offset: 0x001C6EDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205183, RefRangeEnd = 205186, XrefRangeStart = 205173, XrefRangeEnd = 205183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x001C8D2C File Offset: 0x001C6F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205186, XrefRangeEnd = 205191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x001C8D7C File Offset: 0x001C6F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205191, XrefRangeEnd = 205202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x001C8DCC File Offset: 0x001C6FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205202, XrefRangeEnd = 205207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x001C8E1C File Offset: 0x001C701C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205207, XrefRangeEnd = 205219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x001C8E6C File Offset: 0x001C706C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205251, RefRangeEnd = 205254, XrefRangeStart = 205219, XrefRangeEnd = 205251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x001C8EBC File Offset: 0x001C70BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205254, XrefRangeEnd = 205260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendStartSpin_2681120339(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x001C8F20 File Offset: 0x001C7120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205260, XrefRangeEnd = 205273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartSpin_2659526290(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x001C8F84 File Offset: 0x001C7184
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 205290, RefRangeEnd = 205293, XrefRangeStart = 205273, XrefRangeEnd = 205290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSpin_2659526290(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x001C8FE8 File Offset: 0x001C71E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205293, XrefRangeEnd = 205300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartSpin_2659526290(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x001C9038 File Offset: 0x001C7238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205339, RefRangeEnd = 205340, XrefRangeStart = 205300, XrefRangeEnd = 205339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x0002D4C9 File Offset: 0x0002B6C9
		public SlotMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x06006039 RID: 24633 RVA: 0x001C906C File Offset: 0x001C726C
		// (set) Token: 0x0600603A RID: 24634 RVA: 0x0002D4D2 File Offset: 0x0002B6D2
		public unsafe static Il2CppStructArray<int> BetAmounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SlotMachine.NativeFieldInfoPtr_BetAmounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SlotMachine.NativeFieldInfoPtr_BetAmounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x0600603B RID: 24635 RVA: 0x001C9094 File Offset: 0x001C7294
		// (set) Token: 0x0600603C RID: 24636 RVA: 0x0002D4E4 File Offset: 0x0002B6E4
		public unsafe bool _IsSpinning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x0600603D RID: 24637 RVA: 0x001C90BC File Offset: 0x001C72BC
		// (set) Token: 0x0600603E RID: 24638 RVA: 0x0002D4FF File Offset: 0x0002B6FF
		public unsafe InteractableObject DownButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_DownButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_DownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x0600603F RID: 24639 RVA: 0x001C90EC File Offset: 0x001C72EC
		// (set) Token: 0x06006040 RID: 24640 RVA: 0x0002D51E File Offset: 0x0002B71E
		public unsafe InteractableObject UpButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_UpButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_UpButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06006041 RID: 24641 RVA: 0x001C911C File Offset: 0x001C731C
		// (set) Token: 0x06006042 RID: 24642 RVA: 0x0002D53D File Offset: 0x0002B73D
		public unsafe InteractableObject HandleIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_HandleIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_HandleIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06006043 RID: 24643 RVA: 0x001C914C File Offset: 0x001C734C
		// (set) Token: 0x06006044 RID: 24644 RVA: 0x0002D55C File Offset: 0x0002B75C
		public unsafe TextMeshPro BetAmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BetAmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BetAmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06006045 RID: 24645 RVA: 0x001C917C File Offset: 0x001C737C
		// (set) Token: 0x06006046 RID: 24646 RVA: 0x0002D57B File Offset: 0x0002B77B
		public unsafe Il2CppReferenceArray<SlotReel> Reels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_Reels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotReel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_Reels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06006047 RID: 24647 RVA: 0x001C91AC File Offset: 0x001C73AC
		// (set) Token: 0x06006048 RID: 24648 RVA: 0x0002D59A File Offset: 0x0002B79A
		public unsafe AudioSourceController SpinLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SpinLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SpinLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06006049 RID: 24649 RVA: 0x001C91DC File Offset: 0x001C73DC
		// (set) Token: 0x0600604A RID: 24650 RVA: 0x0002D5B9 File Offset: 0x0002B7B9
		public unsafe Animation ScreenAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_ScreenAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_ScreenAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x0600604B RID: 24651 RVA: 0x001C920C File Offset: 0x001C740C
		// (set) Token: 0x0600604C RID: 24652 RVA: 0x0002D5D8 File Offset: 0x0002B7D8
		public unsafe Il2CppReferenceArray<ParticleSystem> JackpotParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x0600604D RID: 24653 RVA: 0x001C923C File Offset: 0x001C743C
		// (set) Token: 0x0600604E RID: 24654 RVA: 0x0002D5F7 File Offset: 0x0002B7F7
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> WinAmountLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_WinAmountLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_WinAmountLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x0600604F RID: 24655 RVA: 0x001C926C File Offset: 0x001C746C
		// (set) Token: 0x06006050 RID: 24656 RVA: 0x0002D616 File Offset: 0x0002B816
		public unsafe AnimationClip MiniWinAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06006051 RID: 24657 RVA: 0x001C929C File Offset: 0x001C749C
		// (set) Token: 0x06006052 RID: 24658 RVA: 0x0002D635 File Offset: 0x0002B835
		public unsafe AnimationClip SmallWinAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x06006053 RID: 24659 RVA: 0x001C92CC File Offset: 0x001C74CC
		// (set) Token: 0x06006054 RID: 24660 RVA: 0x0002D654 File Offset: 0x0002B854
		public unsafe AnimationClip BigWinAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x06006055 RID: 24661 RVA: 0x001C92FC File Offset: 0x001C74FC
		// (set) Token: 0x06006056 RID: 24662 RVA: 0x0002D673 File Offset: 0x0002B873
		public unsafe AnimationClip JackpotAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D95 RID: 7573
		// (get) Token: 0x06006057 RID: 24663 RVA: 0x001C932C File Offset: 0x001C752C
		// (set) Token: 0x06006058 RID: 24664 RVA: 0x0002D692 File Offset: 0x0002B892
		public unsafe AudioSourceController MiniWinSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D96 RID: 7574
		// (get) Token: 0x06006059 RID: 24665 RVA: 0x001C935C File Offset: 0x001C755C
		// (set) Token: 0x0600605A RID: 24666 RVA: 0x0002D6B1 File Offset: 0x0002B8B1
		public unsafe AudioSourceController SmallWinSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D97 RID: 7575
		// (get) Token: 0x0600605B RID: 24667 RVA: 0x001C938C File Offset: 0x001C758C
		// (set) Token: 0x0600605C RID: 24668 RVA: 0x0002D6D0 File Offset: 0x0002B8D0
		public unsafe AudioSourceController BigWinSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x0600605D RID: 24669 RVA: 0x001C93BC File Offset: 0x001C75BC
		// (set) Token: 0x0600605E RID: 24670 RVA: 0x0002D6EF File Offset: 0x0002B8EF
		public unsafe AudioSourceController JackpotSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x0600605F RID: 24671 RVA: 0x001C93EC File Offset: 0x001C75EC
		// (set) Token: 0x06006060 RID: 24672 RVA: 0x0002D70E File Offset: 0x0002B90E
		public unsafe UnityEvent onDownPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onDownPressed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onDownPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x06006061 RID: 24673 RVA: 0x001C941C File Offset: 0x001C761C
		// (set) Token: 0x06006062 RID: 24674 RVA: 0x0002D72D File Offset: 0x0002B92D
		public unsafe UnityEvent onUpPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onUpPressed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onUpPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06006063 RID: 24675 RVA: 0x001C944C File Offset: 0x001C764C
		// (set) Token: 0x06006064 RID: 24676 RVA: 0x0002D74C File Offset: 0x0002B94C
		public unsafe UnityEvent onHandlePulled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onHandlePulled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onHandlePulled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06006065 RID: 24677 RVA: 0x001C947C File Offset: 0x001C767C
		// (set) Token: 0x06006066 RID: 24678 RVA: 0x0002D76B File Offset: 0x0002B96B
		public unsafe int currentBetIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_currentBetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_currentBetIndex)) = value;
			}
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x06006067 RID: 24679 RVA: 0x001C94A4 File Offset: 0x001C76A4
		// (set) Token: 0x06006068 RID: 24680 RVA: 0x0002D786 File Offset: 0x0002B986
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06006069 RID: 24681 RVA: 0x001C94CC File Offset: 0x001C76CC
		// (set) Token: 0x0600606A RID: 24682 RVA: 0x0002D7A1 File Offset: 0x0002B9A1
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004234 RID: 16948
		private static readonly IntPtr NativeFieldInfoPtr_BetAmounts;

		// Token: 0x04004235 RID: 16949
		private static readonly IntPtr NativeFieldInfoPtr__IsSpinning_k__BackingField;

		// Token: 0x04004236 RID: 16950
		private static readonly IntPtr NativeFieldInfoPtr_DownButton;

		// Token: 0x04004237 RID: 16951
		private static readonly IntPtr NativeFieldInfoPtr_UpButton;

		// Token: 0x04004238 RID: 16952
		private static readonly IntPtr NativeFieldInfoPtr_HandleIntObj;

		// Token: 0x04004239 RID: 16953
		private static readonly IntPtr NativeFieldInfoPtr_BetAmountLabel;

		// Token: 0x0400423A RID: 16954
		private static readonly IntPtr NativeFieldInfoPtr_Reels;

		// Token: 0x0400423B RID: 16955
		private static readonly IntPtr NativeFieldInfoPtr_SpinLoop;

		// Token: 0x0400423C RID: 16956
		private static readonly IntPtr NativeFieldInfoPtr_ScreenAnimation;

		// Token: 0x0400423D RID: 16957
		private static readonly IntPtr NativeFieldInfoPtr_JackpotParticles;

		// Token: 0x0400423E RID: 16958
		private static readonly IntPtr NativeFieldInfoPtr_WinAmountLabels;

		// Token: 0x0400423F RID: 16959
		private static readonly IntPtr NativeFieldInfoPtr_MiniWinAnimation;

		// Token: 0x04004240 RID: 16960
		private static readonly IntPtr NativeFieldInfoPtr_SmallWinAnimation;

		// Token: 0x04004241 RID: 16961
		private static readonly IntPtr NativeFieldInfoPtr_BigWinAnimation;

		// Token: 0x04004242 RID: 16962
		private static readonly IntPtr NativeFieldInfoPtr_JackpotAnimation;

		// Token: 0x04004243 RID: 16963
		private static readonly IntPtr NativeFieldInfoPtr_MiniWinSound;

		// Token: 0x04004244 RID: 16964
		private static readonly IntPtr NativeFieldInfoPtr_SmallWinSound;

		// Token: 0x04004245 RID: 16965
		private static readonly IntPtr NativeFieldInfoPtr_BigWinSound;

		// Token: 0x04004246 RID: 16966
		private static readonly IntPtr NativeFieldInfoPtr_JackpotSound;

		// Token: 0x04004247 RID: 16967
		private static readonly IntPtr NativeFieldInfoPtr_onDownPressed;

		// Token: 0x04004248 RID: 16968
		private static readonly IntPtr NativeFieldInfoPtr_onUpPressed;

		// Token: 0x04004249 RID: 16969
		private static readonly IntPtr NativeFieldInfoPtr_onHandlePulled;

		// Token: 0x0400424A RID: 16970
		private static readonly IntPtr NativeFieldInfoPtr_currentBetIndex;

		// Token: 0x0400424B RID: 16971
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400424C RID: 16972
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400424D RID: 16973
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0;

		// Token: 0x0400424E RID: 16974
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0;

		// Token: 0x0400424F RID: 16975
		private static readonly IntPtr NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0;

		// Token: 0x04004250 RID: 16976
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004251 RID: 16977
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004252 RID: 16978
		private static readonly IntPtr NativeMethodInfoPtr_DownHovered_Private_Void_1;

		// Token: 0x04004253 RID: 16979
		private static readonly IntPtr NativeMethodInfoPtr_DownInteracted_Private_Void_1;

		// Token: 0x04004254 RID: 16980
		private static readonly IntPtr NativeMethodInfoPtr_UpHovered_Private_Void_1;

		// Token: 0x04004255 RID: 16981
		private static readonly IntPtr NativeMethodInfoPtr_UpInteracted_Private_Void_1;

		// Token: 0x04004256 RID: 16982
		private static readonly IntPtr NativeMethodInfoPtr_HandleHovered_Private_Void_1;

		// Token: 0x04004257 RID: 16983
		private static readonly IntPtr NativeMethodInfoPtr_HandleInteracted_Public_Void_0;

		// Token: 0x04004258 RID: 16984
		private static readonly IntPtr NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0;

		// Token: 0x04004259 RID: 16985
		private static readonly IntPtr NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x0400425A RID: 16986
		private static readonly IntPtr NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x0400425B RID: 16987
		private static readonly IntPtr NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x0400425C RID: 16988
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x0400425D RID: 16989
		private static readonly IntPtr NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0;

		// Token: 0x0400425E RID: 16990
		private static readonly IntPtr NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0;

		// Token: 0x0400425F RID: 16991
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0;

		// Token: 0x04004260 RID: 16992
		private static readonly IntPtr NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0;

		// Token: 0x04004261 RID: 16993
		private static readonly IntPtr NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x04004262 RID: 16994
		private static readonly IntPtr NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x04004263 RID: 16995
		private static readonly IntPtr NativeMethodInfoPtr_SimulateMany_Public_Void_0;

		// Token: 0x04004264 RID: 16996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004265 RID: 16997
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004266 RID: 16998
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004267 RID: 16999
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004268 RID: 17000
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0;

		// Token: 0x04004269 RID: 17001
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0;

		// Token: 0x0400426A RID: 17002
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400426B RID: 17003
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x0400426C RID: 17004
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x0400426D RID: 17005
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400426E RID: 17006
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x0400426F RID: 17007
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004270 RID: 17008
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04004271 RID: 17009
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04004272 RID: 17010
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004273 RID: 17011
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x04004274 RID: 17012
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x04004275 RID: 17013
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004276 RID: 17014
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000B2B RID: 2859
		[OriginalName("Assembly-CSharp.dll", "", "ESymbol")]
		public enum ESymbol
		{
			// Token: 0x04009C66 RID: 40038
			Cherry,
			// Token: 0x04009C67 RID: 40039
			Lemon,
			// Token: 0x04009C68 RID: 40040
			Grape,
			// Token: 0x04009C69 RID: 40041
			Watermelon,
			// Token: 0x04009C6A RID: 40042
			Bell,
			// Token: 0x04009C6B RID: 40043
			Seven
		}

		// Token: 0x02000B2C RID: 2860
		[OriginalName("Assembly-CSharp.dll", "", "EOutcome")]
		public enum EOutcome
		{
			// Token: 0x04009C6D RID: 40045
			Jackpot,
			// Token: 0x04009C6E RID: 40046
			BigWin,
			// Token: 0x04009C6F RID: 40047
			SmallWin,
			// Token: 0x04009C70 RID: 40048
			MiniWin,
			// Token: 0x04009C71 RID: 40049
			NoWin
		}

		// Token: 0x02000B2D RID: 2861
		[ObfuscatedName("ScheduleOne.Casino.SlotMachine+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E663 RID: 58979 RVA: 0x00383A84 File Offset: 0x00381C84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr);
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "symbols");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "betAmount");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "spinner");
				SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, 100675979);
				SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, 100675980);
			}

			// Token: 0x0600E664 RID: 58980 RVA: 0x00383B28 File Offset: 0x00381D28
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E665 RID: 58981 RVA: 0x00383B64 File Offset: 0x00381D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204827, XrefRangeEnd = 204832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E666 RID: 58982 RVA: 0x0006CA7D File Offset: 0x0006AC7D
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045EE RID: 17902
			// (get) Token: 0x0600E667 RID: 58983 RVA: 0x00383BA4 File Offset: 0x00381DA4
			// (set) Token: 0x0600E668 RID: 58984 RVA: 0x0006CA86 File Offset: 0x0006AC86
			public unsafe SlotMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045EF RID: 17903
			// (get) Token: 0x0600E669 RID: 58985 RVA: 0x00383BD4 File Offset: 0x00381DD4
			// (set) Token: 0x0600E66A RID: 58986 RVA: 0x0006CAA5 File Offset: 0x0006ACA5
			public unsafe Il2CppStructArray<SlotMachine.ESymbol> symbols
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SlotMachine.ESymbol>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045F0 RID: 17904
			// (get) Token: 0x0600E66B RID: 58987 RVA: 0x00383C04 File Offset: 0x00381E04
			// (set) Token: 0x0600E66C RID: 58988 RVA: 0x0006CAC4 File Offset: 0x0006ACC4
			public unsafe int betAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount)) = value;
				}
			}

			// Token: 0x170045F1 RID: 17905
			// (get) Token: 0x0600E66D RID: 58989 RVA: 0x00383C2C File Offset: 0x00381E2C
			// (set) Token: 0x0600E66E RID: 58990 RVA: 0x0006CADF File Offset: 0x0006ACDF
			public unsafe NetworkConnection spinner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009C72 RID: 40050
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009C73 RID: 40051
			private static readonly IntPtr NativeFieldInfoPtr_symbols;

			// Token: 0x04009C74 RID: 40052
			private static readonly IntPtr NativeFieldInfoPtr_betAmount;

			// Token: 0x04009C75 RID: 40053
			private static readonly IntPtr NativeFieldInfoPtr_spinner;

			// Token: 0x04009C76 RID: 40054
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009C77 RID: 40055
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DDB RID: 3547
			[ObfuscatedName("ScheduleOne.Casino.SlotMachine+<>c__DisplayClass41_0+<<StartSpin>g__Spin|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FFFA RID: 65530 RVA: 0x003CD6FC File Offset: 0x003CB8FC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique()
				{
					Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "<<StartSpin>g__Spin|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>1__state");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>2__current");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>4__this");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<outcome>5__2");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<i>5__3");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100675981);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100675982);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100675983);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100675984);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100675985);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100675986);
				}

				// Token: 0x0600FFFB RID: 65531 RVA: 0x003CD804 File Offset: 0x003CBA04
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFFC RID: 65532 RVA: 0x003CD84C File Offset: 0x003CBA4C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FFFD RID: 65533 RVA: 0x003CD880 File Offset: 0x003CBA80
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204814, XrefRangeEnd = 204822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DFB RID: 19963
				// (get) Token: 0x0600FFFE RID: 65534 RVA: 0x003CD8BC File Offset: 0x003CBABC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FFFF RID: 65535 RVA: 0x003CD8FC File Offset: 0x003CBAFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204822, XrefRangeEnd = 204827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DFC RID: 19964
				// (get) Token: 0x06010000 RID: 65536 RVA: 0x003CD930 File Offset: 0x003CBB30
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010001 RID: 65537 RVA: 0x000794FB File Offset: 0x000776FB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DF6 RID: 19958
				// (get) Token: 0x06010002 RID: 65538 RVA: 0x003CD970 File Offset: 0x003CBB70
				// (set) Token: 0x06010003 RID: 65539 RVA: 0x00079504 File Offset: 0x00077704
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DF7 RID: 19959
				// (get) Token: 0x06010004 RID: 65540 RVA: 0x003CD998 File Offset: 0x003CBB98
				// (set) Token: 0x06010005 RID: 65541 RVA: 0x0007951F File Offset: 0x0007771F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DF8 RID: 19960
				// (get) Token: 0x06010006 RID: 65542 RVA: 0x003CD9C8 File Offset: 0x003CBBC8
				// (set) Token: 0x06010007 RID: 65543 RVA: 0x0007953E File Offset: 0x0007773E
				public unsafe SlotMachine.__c__DisplayClass41_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotMachine.__c__DisplayClass41_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DF9 RID: 19961
				// (get) Token: 0x06010008 RID: 65544 RVA: 0x003CD9F8 File Offset: 0x003CBBF8
				// (set) Token: 0x06010009 RID: 65545 RVA: 0x0007955D File Offset: 0x0007775D
				public unsafe SlotMachine.EOutcome _outcome_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2)) = value;
					}
				}

				// Token: 0x17004DFA RID: 19962
				// (get) Token: 0x0601000A RID: 65546 RVA: 0x003CDA20 File Offset: 0x003CBC20
				// (set) Token: 0x0601000B RID: 65547 RVA: 0x00079578 File Offset: 0x00077778
				public unsafe int _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x0400AC70 RID: 44144
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC71 RID: 44145
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC72 RID: 44146
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC73 RID: 44147
				private static readonly IntPtr NativeFieldInfoPtr__outcome_5__2;

				// Token: 0x0400AC74 RID: 44148
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400AC75 RID: 44149
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC76 RID: 44150
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC77 RID: 44151
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC78 RID: 44152
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC79 RID: 44153
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC7A RID: 44154
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}

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
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005BB RID: 1467
	public class Recycler : NetworkBehaviour
	{
		// Token: 0x06008D6E RID: 36206 RVA: 0x00266868 File Offset: 0x00264A68
		// Note: this type is marked as 'beforefieldinit'.
		static Recycler()
		{
			Il2CppClassPointerStore<Recycler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Recycler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recycler>.NativeClassPtr);
			Recycler.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<State>k__BackingField");
			Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<IsHatchOpen>k__BackingField");
			Recycler.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "DetectionMask");
			Recycler.NativeFieldInfoPtr_HandleIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "HandleIntObj");
			Recycler.NativeFieldInfoPtr_ButtonIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonIntObj");
			Recycler.NativeFieldInfoPtr_CashIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashIntObj");
			Recycler.NativeFieldInfoPtr_ButtonLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonLight");
			Recycler.NativeFieldInfoPtr_ButtonAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonAnim");
			Recycler.NativeFieldInfoPtr_HatchAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "HatchAnim");
			Recycler.NativeFieldInfoPtr_CashAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashAnim");
			Recycler.NativeFieldInfoPtr_OpenHatchInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "OpenHatchInstruction");
			Recycler.NativeFieldInfoPtr_InsertTrashInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "InsertTrashInstruction");
			Recycler.NativeFieldInfoPtr_PressBeginInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "PressBeginInstruction");
			Recycler.NativeFieldInfoPtr_ProcessingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ProcessingScreen");
			Recycler.NativeFieldInfoPtr_ProcessingLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ProcessingLabel");
			Recycler.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ValueLabel");
			Recycler.NativeFieldInfoPtr_CheckCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CheckCollider");
			Recycler.NativeFieldInfoPtr_Cash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "Cash");
			Recycler.NativeFieldInfoPtr_BankNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "BankNote");
			Recycler.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "OpenSound");
			Recycler.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CloseSound");
			Recycler.NativeFieldInfoPtr_PressSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "PressSound");
			Recycler.NativeFieldInfoPtr_DoneSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "DoneSound");
			Recycler.NativeFieldInfoPtr_CashEjectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashEjectSound");
			Recycler.NativeFieldInfoPtr_cashValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "cashValue");
			Recycler.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "onStart");
			Recycler.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "onStop");
			Recycler.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted");
			Recycler.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted");
			Recycler.NativeMethodInfoPtr_get_State_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681614);
			Recycler.NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681615);
			Recycler.NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681616);
			Recycler.NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681617);
			Recycler.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681618);
			Recycler.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681619);
			Recycler.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681620);
			Recycler.NativeMethodInfoPtr_OnTick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681621);
			Recycler.NativeMethodInfoPtr_HandleInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681622);
			Recycler.NativeMethodInfoPtr_ButtonInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681623);
			Recycler.NativeMethodInfoPtr_CashInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681624);
			Recycler.NativeMethodInfoPtr_SendCashCollected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681625);
			Recycler.NativeMethodInfoPtr_CashCollected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681626);
			Recycler.NativeMethodInfoPtr_EnableCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681627);
			Recycler.NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681628);
			Recycler.NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681629);
			Recycler.NativeMethodInfoPtr_SendState_Public_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681630);
			Recycler.NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681631);
			Recycler.NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681632);
			Recycler.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681633);
			Recycler.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681634);
			Recycler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681635);
			Recycler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681636);
			Recycler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681637);
			Recycler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681638);
			Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681639);
			Recycler.NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681640);
			Recycler.NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681641);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681642);
			Recycler.NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681643);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681644);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681645);
			Recycler.NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681646);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681647);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681648);
			Recycler.NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681649);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681650);
			Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681651);
			Recycler.NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681652);
			Recycler.NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681653);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681654);
			Recycler.NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681655);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681656);
			Recycler.NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681657);
			Recycler.NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681658);
			Recycler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100681659);
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x06008D6F RID: 36207 RVA: 0x00266E74 File Offset: 0x00265074
		// (set) Token: 0x06008D70 RID: 36208 RVA: 0x00266EB0 File Offset: 0x002650B0
		public unsafe Recycler.EState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_get_State_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x06008D71 RID: 36209 RVA: 0x00266EF0 File Offset: 0x002650F0
		// (set) Token: 0x06008D72 RID: 36210 RVA: 0x00266F2C File Offset: 0x0026512C
		public unsafe bool IsHatchOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008D73 RID: 36211 RVA: 0x00266F6C File Offset: 0x0026516C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261248, XrefRangeEnd = 261280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D74 RID: 36212 RVA: 0x00266FA0 File Offset: 0x002651A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261280, XrefRangeEnd = 261282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D75 RID: 36213 RVA: 0x00266FF0 File Offset: 0x002651F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261282, XrefRangeEnd = 261297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D76 RID: 36214 RVA: 0x00267024 File Offset: 0x00265224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261297, XrefRangeEnd = 261309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_OnTick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D77 RID: 36215 RVA: 0x00267058 File Offset: 0x00265258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261309, XrefRangeEnd = 261310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_HandleInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x0026708C File Offset: 0x0026528C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261310, XrefRangeEnd = 261320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_ButtonInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D79 RID: 36217 RVA: 0x002670C0 File Offset: 0x002652C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261320, XrefRangeEnd = 261350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CashInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_CashInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x002670F4 File Offset: 0x002652F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261350, XrefRangeEnd = 261359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCashCollected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SendCashCollected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D7B RID: 36219 RVA: 0x00267128 File Offset: 0x00265328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261359, XrefRangeEnd = 261381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CashCollected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_CashCollected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D7C RID: 36220 RVA: 0x0026715C File Offset: 0x0026535C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261400, RefRangeEnd = 261401, XrefRangeStart = 261381, XrefRangeEnd = 261400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_EnableCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D7D RID: 36221 RVA: 0x00267190 File Offset: 0x00265390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261421, RefRangeEnd = 261422, XrefRangeStart = 261401, XrefRangeEnd = 261421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCashValue(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D7E RID: 36222 RVA: 0x002671D0 File Offset: 0x002653D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261427, RefRangeEnd = 261429, XrefRangeStart = 261422, XrefRangeEnd = 261427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Process(bool startedByLocalPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startedByLocalPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008D7F RID: 36223 RVA: 0x0026721C File Offset: 0x0026541C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 261450, RefRangeEnd = 261458, XrefRangeStart = 261429, XrefRangeEnd = 261450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendState(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SendState_Public_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x0026725C File Offset: 0x0026545C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 261499, RefRangeEnd = 261503, XrefRangeStart = 261458, XrefRangeEnd = 261499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D81 RID: 36225 RVA: 0x002672BC File Offset: 0x002654BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261503, XrefRangeEnd = 261507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHatchOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x002672FC File Offset: 0x002654FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261545, RefRangeEnd = 261547, XrefRangeStart = 261507, XrefRangeEnd = 261545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TrashItem> GetTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItem>>(intPtr3) : null;
		}

		// Token: 0x06008D83 RID: 36227 RVA: 0x0026733C File Offset: 0x0026553C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261547, XrefRangeEnd = 261555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D84 RID: 36228 RVA: 0x00267370 File Offset: 0x00265570
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 65655, RefRangeEnd = 65684, XrefRangeStart = 65655, XrefRangeEnd = 65684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recycler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recycler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D85 RID: 36229 RVA: 0x002673AC File Offset: 0x002655AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261555, XrefRangeEnd = 261599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D86 RID: 36230 RVA: 0x002673E8 File Offset: 0x002655E8
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D87 RID: 36231 RVA: 0x00267424 File Offset: 0x00265624
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D88 RID: 36232 RVA: 0x00267460 File Offset: 0x00265660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D89 RID: 36233 RVA: 0x00267494 File Offset: 0x00265694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D8A RID: 36234 RVA: 0x002674C8 File Offset: 0x002656C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261599, XrefRangeEnd = 261622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCashCollected_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D8B RID: 36235 RVA: 0x0026752C File Offset: 0x0026572C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261622, XrefRangeEnd = 261631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D8C RID: 36236 RVA: 0x00267560 File Offset: 0x00265760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261631, XrefRangeEnd = 261634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D8D RID: 36237 RVA: 0x00267594 File Offset: 0x00265794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261634, XrefRangeEnd = 261639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CashCollected_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D8E RID: 36238 RVA: 0x002675E4 File Offset: 0x002657E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261639, XrefRangeEnd = 261648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnableCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D8F RID: 36239 RVA: 0x00267618 File Offset: 0x00265818
		[CallerCount(0)]
		public unsafe void RpcLogic___EnableCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D90 RID: 36240 RVA: 0x0026764C File Offset: 0x0026584C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261648, XrefRangeEnd = 261650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnableCash_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D91 RID: 36241 RVA: 0x0026769C File Offset: 0x0026589C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261650, XrefRangeEnd = 261660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCashValue_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D92 RID: 36242 RVA: 0x002676DC File Offset: 0x002658DC
		[CallerCount(0)]
		public unsafe void RpcLogic___SetCashValue_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D93 RID: 36243 RVA: 0x0026771C File Offset: 0x0026591C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261660, XrefRangeEnd = 261663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCashValue_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D94 RID: 36244 RVA: 0x0026776C File Offset: 0x0026596C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261663, XrefRangeEnd = 261673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendState_3569965459(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D95 RID: 36245 RVA: 0x002677AC File Offset: 0x002659AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261673, XrefRangeEnd = 261674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendState_3569965459(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D96 RID: 36246 RVA: 0x002677EC File Offset: 0x002659EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261674, XrefRangeEnd = 261678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendState_3569965459(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D97 RID: 36247 RVA: 0x00267850 File Offset: 0x00265A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261678, XrefRangeEnd = 261689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D98 RID: 36248 RVA: 0x002678B0 File Offset: 0x00265AB0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261709, RefRangeEnd = 261712, XrefRangeStart = 261689, XrefRangeEnd = 261709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D99 RID: 36249 RVA: 0x00267910 File Offset: 0x00265B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261712, XrefRangeEnd = 261716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D9A RID: 36250 RVA: 0x00267960 File Offset: 0x00265B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261716, XrefRangeEnd = 261727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D9B RID: 36251 RVA: 0x002679C0 File Offset: 0x00265BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261727, XrefRangeEnd = 261731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D9C RID: 36252 RVA: 0x00267A10 File Offset: 0x00265C10
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008D9D RID: 36253 RVA: 0x00042DAE File Offset: 0x00040FAE
		public Recycler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x06008D9E RID: 36254 RVA: 0x00267A4C File Offset: 0x00265C4C
		// (set) Token: 0x06008D9F RID: 36255 RVA: 0x00042DB7 File Offset: 0x00040FB7
		public unsafe Recycler.EState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x06008DA0 RID: 36256 RVA: 0x00267A74 File Offset: 0x00265C74
		// (set) Token: 0x06008DA1 RID: 36257 RVA: 0x00042DD2 File Offset: 0x00040FD2
		public unsafe bool _IsHatchOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x06008DA2 RID: 36258 RVA: 0x00267A9C File Offset: 0x00265C9C
		// (set) Token: 0x06008DA3 RID: 36259 RVA: 0x00042DED File Offset: 0x00040FED
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x06008DA4 RID: 36260 RVA: 0x00267AC4 File Offset: 0x00265CC4
		// (set) Token: 0x06008DA5 RID: 36261 RVA: 0x00042E08 File Offset: 0x00041008
		public unsafe InteractableObject HandleIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HandleIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HandleIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x06008DA6 RID: 36262 RVA: 0x00267AF4 File Offset: 0x00265CF4
		// (set) Token: 0x06008DA7 RID: 36263 RVA: 0x00042E27 File Offset: 0x00041027
		public unsafe InteractableObject ButtonIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x06008DA8 RID: 36264 RVA: 0x00267B24 File Offset: 0x00265D24
		// (set) Token: 0x06008DA9 RID: 36265 RVA: 0x00042E46 File Offset: 0x00041046
		public unsafe InteractableObject CashIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x06008DAA RID: 36266 RVA: 0x00267B54 File Offset: 0x00265D54
		// (set) Token: 0x06008DAB RID: 36267 RVA: 0x00042E65 File Offset: 0x00041065
		public unsafe ToggleableLight ButtonLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x06008DAC RID: 36268 RVA: 0x00267B84 File Offset: 0x00265D84
		// (set) Token: 0x06008DAD RID: 36269 RVA: 0x00042E84 File Offset: 0x00041084
		public unsafe Animation ButtonAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x06008DAE RID: 36270 RVA: 0x00267BB4 File Offset: 0x00265DB4
		// (set) Token: 0x06008DAF RID: 36271 RVA: 0x00042EA3 File Offset: 0x000410A3
		public unsafe Animation HatchAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HatchAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HatchAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x06008DB0 RID: 36272 RVA: 0x00267BE4 File Offset: 0x00265DE4
		// (set) Token: 0x06008DB1 RID: 36273 RVA: 0x00042EC2 File Offset: 0x000410C2
		public unsafe Animation CashAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x06008DB2 RID: 36274 RVA: 0x00267C14 File Offset: 0x00265E14
		// (set) Token: 0x06008DB3 RID: 36275 RVA: 0x00042EE1 File Offset: 0x000410E1
		public unsafe RectTransform OpenHatchInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenHatchInstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenHatchInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x06008DB4 RID: 36276 RVA: 0x00267C44 File Offset: 0x00265E44
		// (set) Token: 0x06008DB5 RID: 36277 RVA: 0x00042F00 File Offset: 0x00041100
		public unsafe RectTransform InsertTrashInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_InsertTrashInstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_InsertTrashInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x06008DB6 RID: 36278 RVA: 0x00267C74 File Offset: 0x00265E74
		// (set) Token: 0x06008DB7 RID: 36279 RVA: 0x00042F1F File Offset: 0x0004111F
		public unsafe RectTransform PressBeginInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressBeginInstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressBeginInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x06008DB8 RID: 36280 RVA: 0x00267CA4 File Offset: 0x00265EA4
		// (set) Token: 0x06008DB9 RID: 36281 RVA: 0x00042F3E File Offset: 0x0004113E
		public unsafe RectTransform ProcessingScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x06008DBA RID: 36282 RVA: 0x00267CD4 File Offset: 0x00265ED4
		// (set) Token: 0x06008DBB RID: 36283 RVA: 0x00042F5D File Offset: 0x0004115D
		public unsafe TextMeshProUGUI ProcessingLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x06008DBC RID: 36284 RVA: 0x00267D04 File Offset: 0x00265F04
		// (set) Token: 0x06008DBD RID: 36285 RVA: 0x00042F7C File Offset: 0x0004117C
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x06008DBE RID: 36286 RVA: 0x00267D34 File Offset: 0x00265F34
		// (set) Token: 0x06008DBF RID: 36287 RVA: 0x00042F9B File Offset: 0x0004119B
		public unsafe BoxCollider CheckCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CheckCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CheckCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x06008DC0 RID: 36288 RVA: 0x00267D64 File Offset: 0x00265F64
		// (set) Token: 0x06008DC1 RID: 36289 RVA: 0x00042FBA File Offset: 0x000411BA
		public unsafe Transform Cash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_Cash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_Cash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x06008DC2 RID: 36290 RVA: 0x00267D94 File Offset: 0x00265F94
		// (set) Token: 0x06008DC3 RID: 36291 RVA: 0x00042FD9 File Offset: 0x000411D9
		public unsafe GameObject BankNote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_BankNote);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_BankNote), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x06008DC4 RID: 36292 RVA: 0x00267DC4 File Offset: 0x00265FC4
		// (set) Token: 0x06008DC5 RID: 36293 RVA: 0x00042FF8 File Offset: 0x000411F8
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x06008DC6 RID: 36294 RVA: 0x00267DF4 File Offset: 0x00265FF4
		// (set) Token: 0x06008DC7 RID: 36295 RVA: 0x00043017 File Offset: 0x00041217
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x06008DC8 RID: 36296 RVA: 0x00267E24 File Offset: 0x00266024
		// (set) Token: 0x06008DC9 RID: 36297 RVA: 0x00043036 File Offset: 0x00041236
		public unsafe AudioSourceController PressSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x06008DCA RID: 36298 RVA: 0x00267E54 File Offset: 0x00266054
		// (set) Token: 0x06008DCB RID: 36299 RVA: 0x00043055 File Offset: 0x00041255
		public unsafe AudioSourceController DoneSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DoneSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DoneSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x06008DCC RID: 36300 RVA: 0x00267E84 File Offset: 0x00266084
		// (set) Token: 0x06008DCD RID: 36301 RVA: 0x00043074 File Offset: 0x00041274
		public unsafe AudioSourceController CashEjectSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashEjectSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashEjectSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x06008DCE RID: 36302 RVA: 0x00267EB4 File Offset: 0x002660B4
		// (set) Token: 0x06008DCF RID: 36303 RVA: 0x00043093 File Offset: 0x00041293
		public unsafe float cashValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_cashValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_cashValue)) = value;
			}
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x06008DD0 RID: 36304 RVA: 0x00267EDC File Offset: 0x002660DC
		// (set) Token: 0x06008DD1 RID: 36305 RVA: 0x000430AE File Offset: 0x000412AE
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x06008DD2 RID: 36306 RVA: 0x00267F0C File Offset: 0x0026610C
		// (set) Token: 0x06008DD3 RID: 36307 RVA: 0x000430CD File Offset: 0x000412CD
		public unsafe UnityEvent onStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x06008DD4 RID: 36308 RVA: 0x00267F3C File Offset: 0x0026613C
		// (set) Token: 0x06008DD5 RID: 36309 RVA: 0x000430EC File Offset: 0x000412EC
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x06008DD6 RID: 36310 RVA: 0x00267F64 File Offset: 0x00266164
		// (set) Token: 0x06008DD7 RID: 36311 RVA: 0x00043107 File Offset: 0x00041307
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400610A RID: 24842
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x0400610B RID: 24843
		private static readonly IntPtr NativeFieldInfoPtr__IsHatchOpen_k__BackingField;

		// Token: 0x0400610C RID: 24844
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x0400610D RID: 24845
		private static readonly IntPtr NativeFieldInfoPtr_HandleIntObj;

		// Token: 0x0400610E RID: 24846
		private static readonly IntPtr NativeFieldInfoPtr_ButtonIntObj;

		// Token: 0x0400610F RID: 24847
		private static readonly IntPtr NativeFieldInfoPtr_CashIntObj;

		// Token: 0x04006110 RID: 24848
		private static readonly IntPtr NativeFieldInfoPtr_ButtonLight;

		// Token: 0x04006111 RID: 24849
		private static readonly IntPtr NativeFieldInfoPtr_ButtonAnim;

		// Token: 0x04006112 RID: 24850
		private static readonly IntPtr NativeFieldInfoPtr_HatchAnim;

		// Token: 0x04006113 RID: 24851
		private static readonly IntPtr NativeFieldInfoPtr_CashAnim;

		// Token: 0x04006114 RID: 24852
		private static readonly IntPtr NativeFieldInfoPtr_OpenHatchInstruction;

		// Token: 0x04006115 RID: 24853
		private static readonly IntPtr NativeFieldInfoPtr_InsertTrashInstruction;

		// Token: 0x04006116 RID: 24854
		private static readonly IntPtr NativeFieldInfoPtr_PressBeginInstruction;

		// Token: 0x04006117 RID: 24855
		private static readonly IntPtr NativeFieldInfoPtr_ProcessingScreen;

		// Token: 0x04006118 RID: 24856
		private static readonly IntPtr NativeFieldInfoPtr_ProcessingLabel;

		// Token: 0x04006119 RID: 24857
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x0400611A RID: 24858
		private static readonly IntPtr NativeFieldInfoPtr_CheckCollider;

		// Token: 0x0400611B RID: 24859
		private static readonly IntPtr NativeFieldInfoPtr_Cash;

		// Token: 0x0400611C RID: 24860
		private static readonly IntPtr NativeFieldInfoPtr_BankNote;

		// Token: 0x0400611D RID: 24861
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x0400611E RID: 24862
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x0400611F RID: 24863
		private static readonly IntPtr NativeFieldInfoPtr_PressSound;

		// Token: 0x04006120 RID: 24864
		private static readonly IntPtr NativeFieldInfoPtr_DoneSound;

		// Token: 0x04006121 RID: 24865
		private static readonly IntPtr NativeFieldInfoPtr_CashEjectSound;

		// Token: 0x04006122 RID: 24866
		private static readonly IntPtr NativeFieldInfoPtr_cashValue;

		// Token: 0x04006123 RID: 24867
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04006124 RID: 24868
		private static readonly IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x04006125 RID: 24869
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006126 RID: 24870
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006127 RID: 24871
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EState_0;

		// Token: 0x04006128 RID: 24872
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0;

		// Token: 0x04006129 RID: 24873
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0;

		// Token: 0x0400612A RID: 24874
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400612B RID: 24875
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400612C RID: 24876
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400612D RID: 24877
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400612E RID: 24878
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Private_Void_0;

		// Token: 0x0400612F RID: 24879
		private static readonly IntPtr NativeMethodInfoPtr_HandleInteracted_Public_Void_0;

		// Token: 0x04006130 RID: 24880
		private static readonly IntPtr NativeMethodInfoPtr_ButtonInteracted_Public_Void_0;

		// Token: 0x04006131 RID: 24881
		private static readonly IntPtr NativeMethodInfoPtr_CashInteracted_Public_Void_0;

		// Token: 0x04006132 RID: 24882
		private static readonly IntPtr NativeMethodInfoPtr_SendCashCollected_Private_Void_0;

		// Token: 0x04006133 RID: 24883
		private static readonly IntPtr NativeMethodInfoPtr_CashCollected_Private_Void_0;

		// Token: 0x04006134 RID: 24884
		private static readonly IntPtr NativeMethodInfoPtr_EnableCash_Private_Void_0;

		// Token: 0x04006135 RID: 24885
		private static readonly IntPtr NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0;

		// Token: 0x04006136 RID: 24886
		private static readonly IntPtr NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0;

		// Token: 0x04006137 RID: 24887
		private static readonly IntPtr NativeMethodInfoPtr_SendState_Public_Void_EState_0;

		// Token: 0x04006138 RID: 24888
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006139 RID: 24889
		private static readonly IntPtr NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0;

		// Token: 0x0400613A RID: 24890
		private static readonly IntPtr NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0;

		// Token: 0x0400613B RID: 24891
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x0400613C RID: 24892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400613D RID: 24893
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400613E RID: 24894
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400613F RID: 24895
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006140 RID: 24896
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0;

		// Token: 0x04006141 RID: 24897
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0;

		// Token: 0x04006142 RID: 24898
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006143 RID: 24899
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0;

		// Token: 0x04006144 RID: 24900
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0;

		// Token: 0x04006145 RID: 24901
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006146 RID: 24902
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0;

		// Token: 0x04006147 RID: 24903
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0;

		// Token: 0x04006148 RID: 24904
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006149 RID: 24905
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0;

		// Token: 0x0400614A RID: 24906
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0;

		// Token: 0x0400614B RID: 24907
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400614C RID: 24908
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0;

		// Token: 0x0400614D RID: 24909
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0;

		// Token: 0x0400614E RID: 24910
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400614F RID: 24911
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006150 RID: 24912
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006151 RID: 24913
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006152 RID: 24914
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006153 RID: 24915
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006154 RID: 24916
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C15 RID: 3093
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x0400A12A RID: 41258
			HatchClosed,
			// Token: 0x0400A12B RID: 41259
			HatchOpen,
			// Token: 0x0400A12C RID: 41260
			Processing
		}

		// Token: 0x02000C16 RID: 3094
		[ObfuscatedName("ScheduleOne.ObjectScripts.Recycler+<Process>d__45")]
		public sealed class _Process_d__45 : Il2CppSystem.Object
		{
			// Token: 0x0600EE04 RID: 60932 RVA: 0x003997D4 File Offset: 0x003979D4
			// Note: this type is marked as 'beforefieldinit'.
			static _Process_d__45()
			{
				Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<Process>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr);
				Recycler._Process_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>1__state");
				Recycler._Process_d__45.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>2__current");
				Recycler._Process_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>4__this");
				Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "startedByLocalPlayer");
				Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<value>5__2");
				Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<lerpTime>5__3");
				Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<i>5__4");
				Recycler._Process_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100681660);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100681661);
				Recycler._Process_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100681662);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100681663);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100681664);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100681665);
			}

			// Token: 0x0600EE05 RID: 60933 RVA: 0x00399904 File Offset: 0x00397B04
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Process_d__45(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE06 RID: 60934 RVA: 0x0039994C File Offset: 0x00397B4C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE07 RID: 60935 RVA: 0x00399980 File Offset: 0x00397B80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261165, XrefRangeEnd = 261243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700482C RID: 18476
			// (get) Token: 0x0600EE08 RID: 60936 RVA: 0x003999BC File Offset: 0x00397BBC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE09 RID: 60937 RVA: 0x003999FC File Offset: 0x00397BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261243, XrefRangeEnd = 261248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700482D RID: 18477
			// (get) Token: 0x0600EE0A RID: 60938 RVA: 0x00399A30 File Offset: 0x00397C30
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE0B RID: 60939 RVA: 0x0007055B File Offset: 0x0006E75B
			public _Process_d__45(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004825 RID: 18469
			// (get) Token: 0x0600EE0C RID: 60940 RVA: 0x00399A70 File Offset: 0x00397C70
			// (set) Token: 0x0600EE0D RID: 60941 RVA: 0x00070564 File Offset: 0x0006E764
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004826 RID: 18470
			// (get) Token: 0x0600EE0E RID: 60942 RVA: 0x00399A98 File Offset: 0x00397C98
			// (set) Token: 0x0600EE0F RID: 60943 RVA: 0x0007057F File Offset: 0x0006E77F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004827 RID: 18471
			// (get) Token: 0x0600EE10 RID: 60944 RVA: 0x00399AC8 File Offset: 0x00397CC8
			// (set) Token: 0x0600EE11 RID: 60945 RVA: 0x0007059E File Offset: 0x0006E79E
			public unsafe Recycler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recycler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004828 RID: 18472
			// (get) Token: 0x0600EE12 RID: 60946 RVA: 0x00399AF8 File Offset: 0x00397CF8
			// (set) Token: 0x0600EE13 RID: 60947 RVA: 0x000705BD File Offset: 0x0006E7BD
			public unsafe bool startedByLocalPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer)) = value;
				}
			}

			// Token: 0x17004829 RID: 18473
			// (get) Token: 0x0600EE14 RID: 60948 RVA: 0x00399B20 File Offset: 0x00397D20
			// (set) Token: 0x0600EE15 RID: 60949 RVA: 0x000705D8 File Offset: 0x0006E7D8
			public unsafe float _value_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2)) = value;
				}
			}

			// Token: 0x1700482A RID: 18474
			// (get) Token: 0x0600EE16 RID: 60950 RVA: 0x00399B48 File Offset: 0x00397D48
			// (set) Token: 0x0600EE17 RID: 60951 RVA: 0x000705F3 File Offset: 0x0006E7F3
			public unsafe float _lerpTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3)) = value;
				}
			}

			// Token: 0x1700482B RID: 18475
			// (get) Token: 0x0600EE18 RID: 60952 RVA: 0x00399B70 File Offset: 0x00397D70
			// (set) Token: 0x0600EE19 RID: 60953 RVA: 0x0007060E File Offset: 0x0006E80E
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400A12D RID: 41261
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A12E RID: 41262
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A12F RID: 41263
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A130 RID: 41264
			private static readonly IntPtr NativeFieldInfoPtr_startedByLocalPlayer;

			// Token: 0x0400A131 RID: 41265
			private static readonly IntPtr NativeFieldInfoPtr__value_5__2;

			// Token: 0x0400A132 RID: 41266
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__3;

			// Token: 0x0400A133 RID: 41267
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400A134 RID: 41268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A135 RID: 41269
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A136 RID: 41270
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A137 RID: 41271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A138 RID: 41272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A139 RID: 41273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

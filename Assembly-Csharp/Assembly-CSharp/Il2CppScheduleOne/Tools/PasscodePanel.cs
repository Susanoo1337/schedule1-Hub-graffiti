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
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004F0 RID: 1264
	public class PasscodePanel : NetworkBehaviour
	{
		// Token: 0x06007282 RID: 29314 RVA: 0x00203828 File Offset: 0x00201A28
		// Note: this type is marked as 'beforefieldinit'.
		static PasscodePanel()
		{
			Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PasscodePanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr);
			PasscodePanel.NativeFieldInfoPtr_PasscodeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "PasscodeLength");
			PasscodePanel.NativeFieldInfoPtr_CorrectPasscode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "CorrectPasscode");
			PasscodePanel.NativeFieldInfoPtr_Buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "Buttons");
			PasscodePanel.NativeFieldInfoPtr_CodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "CodeLabel");
			PasscodePanel.NativeFieldInfoPtr_onButtonPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "onButtonPressed");
			PasscodePanel.NativeFieldInfoPtr_onCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "onCorrect");
			PasscodePanel.NativeFieldInfoPtr_onIncorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "onIncorrect");
			PasscodePanel.NativeFieldInfoPtr_enteredPasscode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "enteredPasscode");
			PasscodePanel.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Tools.PasscodePanelAssembly-CSharp.dll_Excuted");
			PasscodePanel.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Tools.PasscodePanelAssembly-CSharp.dll_Excuted");
			PasscodePanel.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678101);
			PasscodePanel.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678102);
			PasscodePanel.NativeMethodInfoPtr_OnButtonPressed_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678103);
			PasscodePanel.NativeMethodInfoPtr_OnButtonPressed_Server_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678104);
			PasscodePanel.NativeMethodInfoPtr_RegisterButtonPress_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678105);
			PasscodePanel.NativeMethodInfoPtr_SetIsUsable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678106);
			PasscodePanel.NativeMethodInfoPtr_SetEnteredPasscode_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678107);
			PasscodePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678108);
			PasscodePanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678109);
			PasscodePanel.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678110);
			PasscodePanel.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678111);
			PasscodePanel.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678112);
			PasscodePanel.NativeMethodInfoPtr_RpcWriter___Server_OnButtonPressed_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678113);
			PasscodePanel.NativeMethodInfoPtr_RpcLogic___OnButtonPressed_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678114);
			PasscodePanel.NativeMethodInfoPtr_RpcReader___Server_OnButtonPressed_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678115);
			PasscodePanel.NativeMethodInfoPtr_RpcWriter___Observers_RegisterButtonPress_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678116);
			PasscodePanel.NativeMethodInfoPtr_RpcLogic___RegisterButtonPress_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678117);
			PasscodePanel.NativeMethodInfoPtr_RpcReader___Observers_RegisterButtonPress_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678118);
			PasscodePanel.NativeMethodInfoPtr_RpcWriter___Observers_SetEnteredPasscode_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678119);
			PasscodePanel.NativeMethodInfoPtr_RpcLogic___SetEnteredPasscode_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678120);
			PasscodePanel.NativeMethodInfoPtr_RpcReader___Observers_SetEnteredPasscode_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678121);
			PasscodePanel.NativeMethodInfoPtr_RpcWriter___Target_SetEnteredPasscode_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678122);
			PasscodePanel.NativeMethodInfoPtr_RpcReader___Target_SetEnteredPasscode_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678123);
			PasscodePanel.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, 100678124);
		}

		// Token: 0x06007283 RID: 29315 RVA: 0x00203B00 File Offset: 0x00201D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226489, XrefRangeEnd = 226490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasscodePanel.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007284 RID: 29316 RVA: 0x00203B3C File Offset: 0x00201D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226490, XrefRangeEnd = 226496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasscodePanel.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007285 RID: 29317 RVA: 0x00203B8C File Offset: 0x00201D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226496, XrefRangeEnd = 226518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButtonPressed(int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_OnButtonPressed_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x00203BCC File Offset: 0x00201DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226518, XrefRangeEnd = 226529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButtonPressed_Server(int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_OnButtonPressed_Server_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007287 RID: 29319 RVA: 0x00203C0C File Offset: 0x00201E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226529, XrefRangeEnd = 226540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterButtonPress(int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RegisterButtonPress_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007288 RID: 29320 RVA: 0x00203C4C File Offset: 0x00201E4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226541, RefRangeEnd = 226543, XrefRangeStart = 226540, XrefRangeEnd = 226541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsUsable(bool isUsable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isUsable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_SetIsUsable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007289 RID: 29321 RVA: 0x00203C8C File Offset: 0x00201E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226571, RefRangeEnd = 226572, XrefRangeStart = 226543, XrefRangeEnd = 226571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnteredPasscode(NetworkConnection conn, string passcode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(passcode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_SetEnteredPasscode_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600728A RID: 29322 RVA: 0x00203CE0 File Offset: 0x00201EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226572, XrefRangeEnd = 226581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PasscodePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600728B RID: 29323 RVA: 0x00203D1C File Offset: 0x00201F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226581, XrefRangeEnd = 226586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600728C RID: 29324 RVA: 0x00203D5C File Offset: 0x00201F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226586, XrefRangeEnd = 226612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasscodePanel.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600728D RID: 29325 RVA: 0x00203D98 File Offset: 0x00201F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202414, RefRangeEnd = 202415, XrefRangeStart = 202414, XrefRangeEnd = 202415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasscodePanel.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600728E RID: 29326 RVA: 0x00203DD4 File Offset: 0x00201FD4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PasscodePanel.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600728F RID: 29327 RVA: 0x00203E10 File Offset: 0x00202010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_OnButtonPressed_Server_3316948804(int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RpcWriter___Server_OnButtonPressed_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x00203E50 File Offset: 0x00202050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___OnButtonPressed_Server_3316948804(int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RpcLogic___OnButtonPressed_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x00203E90 File Offset: 0x00202090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226612, XrefRangeEnd = 226626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_OnButtonPressed_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RpcReader___Server_OnButtonPressed_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007292 RID: 29330 RVA: 0x00203EF4 File Offset: 0x002020F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RegisterButtonPress_3316948804(int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RpcWriter___Observers_RegisterButtonPress_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007293 RID: 29331 RVA: 0x00203F34 File Offset: 0x00202134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226626, XrefRangeEnd = 226631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RegisterButtonPress_3316948804(int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RpcLogic___RegisterButtonPress_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007294 RID: 29332 RVA: 0x00203F74 File Offset: 0x00202174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226631, XrefRangeEnd = 226639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RegisterButtonPress_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RpcReader___Observers_RegisterButtonPress_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007295 RID: 29333 RVA: 0x00203FC4 File Offset: 0x002021C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226639, XrefRangeEnd = 226649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetEnteredPasscode_2971853958(NetworkConnection conn, string passcode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(passcode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RpcWriter___Observers_SetEnteredPasscode_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007296 RID: 29334 RVA: 0x00204018 File Offset: 0x00202218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226649, XrefRangeEnd = 226651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetEnteredPasscode_2971853958(NetworkConnection conn, string passcode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(passcode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RpcLogic___SetEnteredPasscode_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007297 RID: 29335 RVA: 0x0020406C File Offset: 0x0020226C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226651, XrefRangeEnd = 226654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetEnteredPasscode_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RpcReader___Observers_SetEnteredPasscode_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007298 RID: 29336 RVA: 0x002040BC File Offset: 0x002022BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226654, XrefRangeEnd = 226664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetEnteredPasscode_2971853958(NetworkConnection conn, string passcode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(passcode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RpcWriter___Target_SetEnteredPasscode_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x00204110 File Offset: 0x00202310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226664, XrefRangeEnd = 226668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetEnteredPasscode_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_RpcReader___Target_SetEnteredPasscode_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x00204160 File Offset: 0x00202360
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226695, RefRangeEnd = 226696, XrefRangeStart = 226668, XrefRangeEnd = 226695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x0003674E File Offset: 0x0003494E
		public PasscodePanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x0600729C RID: 29340 RVA: 0x00204194 File Offset: 0x00202394
		// (set) Token: 0x0600729D RID: 29341 RVA: 0x00036757 File Offset: 0x00034957
		public unsafe static int PasscodeLength
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PasscodePanel.NativeFieldInfoPtr_PasscodeLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PasscodePanel.NativeFieldInfoPtr_PasscodeLength, (void*)(&value));
			}
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x0600729E RID: 29342 RVA: 0x002041B0 File Offset: 0x002023B0
		// (set) Token: 0x0600729F RID: 29343 RVA: 0x00036765 File Offset: 0x00034965
		public unsafe string CorrectPasscode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_CorrectPasscode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_CorrectPasscode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x060072A0 RID: 29344 RVA: 0x002041D8 File Offset: 0x002023D8
		// (set) Token: 0x060072A1 RID: 29345 RVA: 0x00036784 File Offset: 0x00034984
		public unsafe Il2CppReferenceArray<InteractableObject> Buttons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_Buttons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InteractableObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_Buttons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x060072A2 RID: 29346 RVA: 0x00204208 File Offset: 0x00202408
		// (set) Token: 0x060072A3 RID: 29347 RVA: 0x000367A3 File Offset: 0x000349A3
		public unsafe TextMeshPro CodeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_CodeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_CodeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x060072A4 RID: 29348 RVA: 0x00204238 File Offset: 0x00202438
		// (set) Token: 0x060072A5 RID: 29349 RVA: 0x000367C2 File Offset: 0x000349C2
		public unsafe UnityEvent onButtonPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_onButtonPressed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_onButtonPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x060072A6 RID: 29350 RVA: 0x00204268 File Offset: 0x00202468
		// (set) Token: 0x060072A7 RID: 29351 RVA: 0x000367E1 File Offset: 0x000349E1
		public unsafe UnityEvent onCorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_onCorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_onCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x060072A8 RID: 29352 RVA: 0x00204298 File Offset: 0x00202498
		// (set) Token: 0x060072A9 RID: 29353 RVA: 0x00036800 File Offset: 0x00034A00
		public unsafe UnityEvent onIncorrect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_onIncorrect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_onIncorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x060072AA RID: 29354 RVA: 0x002042C8 File Offset: 0x002024C8
		// (set) Token: 0x060072AB RID: 29355 RVA: 0x0003681F File Offset: 0x00034A1F
		public unsafe string enteredPasscode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_enteredPasscode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_enteredPasscode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x060072AC RID: 29356 RVA: 0x002042F0 File Offset: 0x002024F0
		// (set) Token: 0x060072AD RID: 29357 RVA: 0x0003683E File Offset: 0x00034A3E
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x060072AE RID: 29358 RVA: 0x00204318 File Offset: 0x00202518
		// (set) Token: 0x060072AF RID: 29359 RVA: 0x00036859 File Offset: 0x00034A59
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004E31 RID: 20017
		private static readonly IntPtr NativeFieldInfoPtr_PasscodeLength;

		// Token: 0x04004E32 RID: 20018
		private static readonly IntPtr NativeFieldInfoPtr_CorrectPasscode;

		// Token: 0x04004E33 RID: 20019
		private static readonly IntPtr NativeFieldInfoPtr_Buttons;

		// Token: 0x04004E34 RID: 20020
		private static readonly IntPtr NativeFieldInfoPtr_CodeLabel;

		// Token: 0x04004E35 RID: 20021
		private static readonly IntPtr NativeFieldInfoPtr_onButtonPressed;

		// Token: 0x04004E36 RID: 20022
		private static readonly IntPtr NativeFieldInfoPtr_onCorrect;

		// Token: 0x04004E37 RID: 20023
		private static readonly IntPtr NativeFieldInfoPtr_onIncorrect;

		// Token: 0x04004E38 RID: 20024
		private static readonly IntPtr NativeFieldInfoPtr_enteredPasscode;

		// Token: 0x04004E39 RID: 20025
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004E3A RID: 20026
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004E3B RID: 20027
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004E3C RID: 20028
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004E3D RID: 20029
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonPressed_Private_Void_Int32_0;

		// Token: 0x04004E3E RID: 20030
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonPressed_Server_Private_Void_Int32_0;

		// Token: 0x04004E3F RID: 20031
		private static readonly IntPtr NativeMethodInfoPtr_RegisterButtonPress_Private_Void_Int32_0;

		// Token: 0x04004E40 RID: 20032
		private static readonly IntPtr NativeMethodInfoPtr_SetIsUsable_Public_Void_Boolean_0;

		// Token: 0x04004E41 RID: 20033
		private static readonly IntPtr NativeMethodInfoPtr_SetEnteredPasscode_Private_Void_NetworkConnection_String_0;

		// Token: 0x04004E42 RID: 20034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004E43 RID: 20035
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04004E44 RID: 20036
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004E45 RID: 20037
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004E46 RID: 20038
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004E47 RID: 20039
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_OnButtonPressed_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x04004E48 RID: 20040
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___OnButtonPressed_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x04004E49 RID: 20041
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_OnButtonPressed_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004E4A RID: 20042
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RegisterButtonPress_3316948804_Private_Void_Int32_0;

		// Token: 0x04004E4B RID: 20043
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RegisterButtonPress_3316948804_Private_Void_Int32_0;

		// Token: 0x04004E4C RID: 20044
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RegisterButtonPress_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004E4D RID: 20045
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetEnteredPasscode_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04004E4E RID: 20046
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetEnteredPasscode_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04004E4F RID: 20047
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetEnteredPasscode_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004E50 RID: 20048
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetEnteredPasscode_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04004E51 RID: 20049
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetEnteredPasscode_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004E52 RID: 20050
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000B9F RID: 2975
		[ObfuscatedName("ScheduleOne.Tools.PasscodePanel+<<RegisterButtonPress>g__Evaluate|12_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique : Object
		{
			// Token: 0x0600EA25 RID: 59941 RVA: 0x0038E69C File Offset: 0x0038C89C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique()
			{
				Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "<<RegisterButtonPress>g__Evaluate|12_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr);
				PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr, "<>1__state");
				PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr, "<>2__current");
				PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr, "<>4__this");
				PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr, 100678125);
				PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr, 100678126);
				PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr, 100678127);
				PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr, 100678128);
				PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr, 100678129);
				PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr, 100678130);
			}

			// Token: 0x0600EA26 RID: 59942 RVA: 0x0038E77C File Offset: 0x0038C97C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA27 RID: 59943 RVA: 0x0038E7C4 File Offset: 0x0038C9C4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA28 RID: 59944 RVA: 0x0038E7F8 File Offset: 0x0038C9F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226407, XrefRangeEnd = 226413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004709 RID: 18185
			// (get) Token: 0x0600EA29 RID: 59945 RVA: 0x0038E834 File Offset: 0x0038CA34
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EA2A RID: 59946 RVA: 0x0038E874 File Offset: 0x0038CA74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226413, XrefRangeEnd = 226418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700470A RID: 18186
			// (get) Token: 0x0600EA2B RID: 59947 RVA: 0x0038E8A8 File Offset: 0x0038CAA8
			public unsafe Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EA2C RID: 59948 RVA: 0x0006E766 File Offset: 0x0006C966
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004706 RID: 18182
			// (get) Token: 0x0600EA2D RID: 59949 RVA: 0x0038E8E8 File Offset: 0x0038CAE8
			// (set) Token: 0x0600EA2E RID: 59950 RVA: 0x0006E76F File Offset: 0x0006C96F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004707 RID: 18183
			// (get) Token: 0x0600EA2F RID: 59951 RVA: 0x0038E910 File Offset: 0x0038CB10
			// (set) Token: 0x0600EA30 RID: 59952 RVA: 0x0006E78A File Offset: 0x0006C98A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004708 RID: 18184
			// (get) Token: 0x0600EA31 RID: 59953 RVA: 0x0038E940 File Offset: 0x0038CB40
			// (set) Token: 0x0600EA32 RID: 59954 RVA: 0x0006E7A9 File Offset: 0x0006C9A9
			public unsafe PasscodePanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PasscodePanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009EBC RID: 40636
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009EBD RID: 40637
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009EBE RID: 40638
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009EBF RID: 40639
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009EC0 RID: 40640
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009EC1 RID: 40641
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009EC2 RID: 40642
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009EC3 RID: 40643
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009EC4 RID: 40644
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BA0 RID: 2976
		[ObfuscatedName("ScheduleOne.Tools.PasscodePanel+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600EA33 RID: 59955 RVA: 0x0038E970 File Offset: 0x0038CB70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<PasscodePanel.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PasscodePanel>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PasscodePanel.__c__DisplayClass8_0>.NativeClassPtr);
				PasscodePanel.__c__DisplayClass8_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel.__c__DisplayClass8_0>.NativeClassPtr, "index");
				PasscodePanel.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PasscodePanel.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				PasscodePanel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel.__c__DisplayClass8_0>.NativeClassPtr, 100678131);
				PasscodePanel.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PasscodePanel.__c__DisplayClass8_0>.NativeClassPtr, 100678132);
			}

			// Token: 0x0600EA34 RID: 59956 RVA: 0x0038E9EC File Offset: 0x0038CBEC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PasscodePanel.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA35 RID: 59957 RVA: 0x0038EA28 File Offset: 0x0038CC28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226418, XrefRangeEnd = 226489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PasscodePanel.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA36 RID: 59958 RVA: 0x0006E7C8 File Offset: 0x0006C9C8
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700470B RID: 18187
			// (get) Token: 0x0600EA37 RID: 59959 RVA: 0x0038EA5C File Offset: 0x0038CC5C
			// (set) Token: 0x0600EA38 RID: 59960 RVA: 0x0006E7D1 File Offset: 0x0006C9D1
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.__c__DisplayClass8_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.__c__DisplayClass8_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700470C RID: 18188
			// (get) Token: 0x0600EA39 RID: 59961 RVA: 0x0038EA84 File Offset: 0x0038CC84
			// (set) Token: 0x0600EA3A RID: 59962 RVA: 0x0006E7EC File Offset: 0x0006C9EC
			public unsafe PasscodePanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PasscodePanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PasscodePanel.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009EC5 RID: 40645
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009EC6 RID: 40646
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009EC7 RID: 40647
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009EC8 RID: 40648
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}

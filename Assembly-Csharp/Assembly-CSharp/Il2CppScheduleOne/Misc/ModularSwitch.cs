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
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x020002FD RID: 765
	public class ModularSwitch : NetworkBehaviour
	{
		// Token: 0x06003C7C RID: 15484 RVA: 0x00146D74 File Offset: 0x00144F74
		// Note: this type is marked as 'beforefieldinit'.
		static ModularSwitch()
		{
			Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "ModularSwitch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr);
			ModularSwitch.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "isOn");
			ModularSwitch.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "intObj");
			ModularSwitch.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "button");
			ModularSwitch.NativeFieldInfoPtr_OnAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "OnAudio");
			ModularSwitch.NativeFieldInfoPtr_OffAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "OffAudio");
			ModularSwitch.NativeFieldInfoPtr_LightsToControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "LightsToControl");
			ModularSwitch.NativeFieldInfoPtr_SwitchesToSyncWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "SwitchesToSyncWith");
			ModularSwitch.NativeFieldInfoPtr_onToggled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "onToggled");
			ModularSwitch.NativeFieldInfoPtr_switchedOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "switchedOn");
			ModularSwitch.NativeFieldInfoPtr_switchedOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "switchedOff");
			ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted");
			ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted");
			ModularSwitch.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671020);
			ModularSwitch.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671021);
			ModularSwitch.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671022);
			ModularSwitch.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671023);
			ModularSwitch.NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671024);
			ModularSwitch.NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671025);
			ModularSwitch.NativeMethodInfoPtr_SwitchOn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671026);
			ModularSwitch.NativeMethodInfoPtr_SwitchOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671027);
			ModularSwitch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671028);
			ModularSwitch.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671029);
			ModularSwitch.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671030);
			ModularSwitch.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671031);
			ModularSwitch.NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671032);
			ModularSwitch.NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671033);
			ModularSwitch.NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671034);
			ModularSwitch.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671035);
			ModularSwitch.NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671036);
			ModularSwitch.NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671037);
			ModularSwitch.NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671038);
			ModularSwitch.NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671039);
			ModularSwitch.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100671040);
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x00147038 File Offset: 0x00145238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151192, XrefRangeEnd = 151193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x00147074 File Offset: 0x00145274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151193, XrefRangeEnd = 151195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C7F RID: 15487 RVA: 0x001470C4 File Offset: 0x001452C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151195, XrefRangeEnd = 151202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x001470F8 File Offset: 0x001452F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151202, XrefRangeEnd = 151203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x0014712C File Offset: 0x0014532C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151225, RefRangeEnd = 151226, XrefRangeStart = 151203, XrefRangeEnd = 151225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendIsOn(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x0014716C File Offset: 0x0014536C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 151266, RefRangeEnd = 151270, XrefRangeStart = 151226, XrefRangeEnd = 151266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(NetworkConnection conn, bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x001471BC File Offset: 0x001453BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 151278, RefRangeEnd = 151283, XrefRangeStart = 151270, XrefRangeEnd = 151278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_SwitchOn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C84 RID: 15492 RVA: 0x001471F0 File Offset: 0x001453F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 151291, RefRangeEnd = 151295, XrefRangeStart = 151283, XrefRangeEnd = 151291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_SwitchOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C85 RID: 15493 RVA: 0x00147224 File Offset: 0x00145424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151295, XrefRangeEnd = 151303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModularSwitch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C86 RID: 15494 RVA: 0x00147260 File Offset: 0x00145460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151303, XrefRangeEnd = 151323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x0014729C File Offset: 0x0014549C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x001472D8 File Offset: 0x001454D8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x00147314 File Offset: 0x00145514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151323, XrefRangeEnd = 151333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendIsOn_1140765316(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x00147354 File Offset: 0x00145554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151333, XrefRangeEnd = 151334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendIsOn_1140765316(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x00147394 File Offset: 0x00145594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151334, XrefRangeEnd = 151337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x001473F8 File Offset: 0x001455F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151337, XrefRangeEnd = 151347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x00147448 File Offset: 0x00145648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151347, XrefRangeEnd = 151348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x00147498 File Offset: 0x00145698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151348, XrefRangeEnd = 151351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x001474E8 File Offset: 0x001456E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151351, XrefRangeEnd = 151361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x00147538 File Offset: 0x00145738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151361, XrefRangeEnd = 151364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x00147588 File Offset: 0x00145788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151391, RefRangeEnd = 151392, XrefRangeStart = 151364, XrefRangeEnd = 151391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x0001E35F File Offset: 0x0001C55F
		public ModularSwitch(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06003C93 RID: 15507 RVA: 0x001475C4 File Offset: 0x001457C4
		// (set) Token: 0x06003C94 RID: 15508 RVA: 0x0001E368 File Offset: 0x0001C568
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06003C95 RID: 15509 RVA: 0x001475EC File Offset: 0x001457EC
		// (set) Token: 0x06003C96 RID: 15510 RVA: 0x0001E383 File Offset: 0x0001C583
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06003C97 RID: 15511 RVA: 0x0014761C File Offset: 0x0014581C
		// (set) Token: 0x06003C98 RID: 15512 RVA: 0x0001E3A2 File Offset: 0x0001C5A2
		public unsafe Transform button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x0014764C File Offset: 0x0014584C
		// (set) Token: 0x06003C9A RID: 15514 RVA: 0x0001E3C1 File Offset: 0x0001C5C1
		public unsafe AudioSourceController OnAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_OnAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_OnAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x0014767C File Offset: 0x0014587C
		// (set) Token: 0x06003C9C RID: 15516 RVA: 0x0001E3E0 File Offset: 0x0001C5E0
		public unsafe AudioSourceController OffAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_OffAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_OffAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x001476AC File Offset: 0x001458AC
		// (set) Token: 0x06003C9E RID: 15518 RVA: 0x0001E3FF File Offset: 0x0001C5FF
		public unsafe Il2CppReferenceArray<ToggleableLight> LightsToControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_LightsToControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ToggleableLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_LightsToControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x001476DC File Offset: 0x001458DC
		// (set) Token: 0x06003CA0 RID: 15520 RVA: 0x0001E41E File Offset: 0x0001C61E
		public unsafe List<ModularSwitch> SwitchesToSyncWith
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_SwitchesToSyncWith);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ModularSwitch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_SwitchesToSyncWith), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x0014770C File Offset: 0x0014590C
		// (set) Token: 0x06003CA2 RID: 15522 RVA: 0x0001E43D File Offset: 0x0001C63D
		public unsafe ModularSwitch.ButtonChange onToggled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_onToggled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModularSwitch.ButtonChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_onToggled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x0014773C File Offset: 0x0014593C
		// (set) Token: 0x06003CA4 RID: 15524 RVA: 0x0001E45C File Offset: 0x0001C65C
		public unsafe UnityEvent switchedOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_switchedOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_switchedOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x0014776C File Offset: 0x0014596C
		// (set) Token: 0x06003CA6 RID: 15526 RVA: 0x0001E47B File Offset: 0x0001C67B
		public unsafe UnityEvent switchedOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_switchedOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_switchedOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x0014779C File Offset: 0x0014599C
		// (set) Token: 0x06003CA8 RID: 15528 RVA: 0x0001E49A File Offset: 0x0001C69A
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06003CA9 RID: 15529 RVA: 0x001477C4 File Offset: 0x001459C4
		// (set) Token: 0x06003CAA RID: 15530 RVA: 0x0001E4B5 File Offset: 0x0001C6B5
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040028C4 RID: 10436
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x040028C5 RID: 10437
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x040028C6 RID: 10438
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x040028C7 RID: 10439
		private static readonly IntPtr NativeFieldInfoPtr_OnAudio;

		// Token: 0x040028C8 RID: 10440
		private static readonly IntPtr NativeFieldInfoPtr_OffAudio;

		// Token: 0x040028C9 RID: 10441
		private static readonly IntPtr NativeFieldInfoPtr_LightsToControl;

		// Token: 0x040028CA RID: 10442
		private static readonly IntPtr NativeFieldInfoPtr_SwitchesToSyncWith;

		// Token: 0x040028CB RID: 10443
		private static readonly IntPtr NativeFieldInfoPtr_onToggled;

		// Token: 0x040028CC RID: 10444
		private static readonly IntPtr NativeFieldInfoPtr_switchedOn;

		// Token: 0x040028CD RID: 10445
		private static readonly IntPtr NativeFieldInfoPtr_switchedOff;

		// Token: 0x040028CE RID: 10446
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040028CF RID: 10447
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040028D0 RID: 10448
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040028D1 RID: 10449
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040028D2 RID: 10450
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x040028D3 RID: 10451
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x040028D4 RID: 10452
		private static readonly IntPtr NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0;

		// Token: 0x040028D5 RID: 10453
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040028D6 RID: 10454
		private static readonly IntPtr NativeMethodInfoPtr_SwitchOn_Public_Void_0;

		// Token: 0x040028D7 RID: 10455
		private static readonly IntPtr NativeMethodInfoPtr_SwitchOff_Public_Void_0;

		// Token: 0x040028D8 RID: 10456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040028D9 RID: 10457
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040028DA RID: 10458
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040028DB RID: 10459
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040028DC RID: 10460
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x040028DD RID: 10461
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x040028DE RID: 10462
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040028DF RID: 10463
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040028E0 RID: 10464
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040028E1 RID: 10465
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028E2 RID: 10466
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x040028E3 RID: 10467
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x040028E4 RID: 10468
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000A3C RID: 2620
		public sealed class ButtonChange : MulticastDelegate
		{
			// Token: 0x0600DF56 RID: 57174 RVA: 0x0036FE74 File Offset: 0x0036E074
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonChange()
			{
				Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "ButtonChange");
				ModularSwitch.ButtonChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr, 100671041);
				ModularSwitch.ButtonChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr, 100671042);
				ModularSwitch.ButtonChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr, 100671043);
				ModularSwitch.ButtonChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr, 100671044);
			}

			// Token: 0x0600DF57 RID: 57175 RVA: 0x0036FEE8 File Offset: 0x0036E0E8
			[CallerCount(56)]
			[CachedScanResults(RefRangeStart = 151132, RefRangeEnd = 151188, XrefRangeStart = 151129, XrefRangeEnd = 151132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.ButtonChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF58 RID: 57176 RVA: 0x0036FF44 File Offset: 0x0036E144
			[CallerCount(0)]
			public unsafe void Invoke(bool isOn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref isOn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.ButtonChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF59 RID: 57177 RVA: 0x0036FF84 File Offset: 0x0036E184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151188, XrefRangeEnd = 151192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(bool isOn, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref isOn;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.ButtonChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600DF5A RID: 57178 RVA: 0x0036FFF4 File Offset: 0x0036E1F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.ButtonChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF5B RID: 57179 RVA: 0x000692F4 File Offset: 0x000674F4
			public ButtonChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DF5C RID: 57180 RVA: 0x000692FD File Offset: 0x000674FD
			public static implicit operator ModularSwitch.ButtonChange(Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<ModularSwitch.ButtonChange>(A_0);
			}

			// Token: 0x0600DF5D RID: 57181 RVA: 0x00069305 File Offset: 0x00067505
			public static ModularSwitch.ButtonChange operator +(ModularSwitch.ButtonChange A_0, ModularSwitch.ButtonChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ModularSwitch.ButtonChange>();
			}

			// Token: 0x0600DF5E RID: 57182 RVA: 0x00069313 File Offset: 0x00067513
			public static ModularSwitch.ButtonChange operator -(ModularSwitch.ButtonChange A_0, ModularSwitch.ButtonChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<ModularSwitch.ButtonChange>();
				}
				return result;
			}

			// Token: 0x0400981B RID: 38939
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400981C RID: 38940
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

			// Token: 0x0400981D RID: 38941
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

			// Token: 0x0400981E RID: 38942
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}

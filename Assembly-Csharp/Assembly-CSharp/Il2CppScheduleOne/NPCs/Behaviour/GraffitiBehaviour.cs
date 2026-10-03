using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Graffiti;
using Il2CppScheduleOne.NPCs.Other;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200067D RID: 1661
	public class GraffitiBehaviour : Behaviour
	{
		// Token: 0x0600A037 RID: 41015 RVA: 0x002AB7F4 File Offset: 0x002A99F4
		// Note: this type is marked as 'beforefieldinit'.
		static GraffitiBehaviour()
		{
			Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "GraffitiBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr);
			GraffitiBehaviour.NativeFieldInfoPtr_InterruptionXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "InterruptionXP");
			GraffitiBehaviour.NativeFieldInfoPtr_InterruptionCartelInfluenceChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "InterruptionCartelInfluenceChange");
			GraffitiBehaviour.NativeFieldInfoPtr__sprayPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_sprayPaint");
			GraffitiBehaviour.NativeFieldInfoPtr__graffitiDurationInMinutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_graffitiDurationInMinutes");
			GraffitiBehaviour.NativeFieldInfoPtr__minMaxEffectLoopDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_minMaxEffectLoopDuration");
			GraffitiBehaviour.NativeFieldInfoPtr__minMaxEffectPauseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_minMaxEffectPauseDuration");
			GraffitiBehaviour.NativeFieldInfoPtr__effectColorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_effectColorGradient");
			GraffitiBehaviour.NativeFieldInfoPtr__drawinglist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_drawinglist");
			GraffitiBehaviour.NativeFieldInfoPtr__interruptingBehaviours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_interruptingBehaviours");
			GraffitiBehaviour.NativeFieldInfoPtr__debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_debugMode");
			GraffitiBehaviour.NativeFieldInfoPtr__duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_duration");
			GraffitiBehaviour.NativeFieldInfoPtr__effectCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_effectCoroutine");
			GraffitiBehaviour.NativeFieldInfoPtr__spraySurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_spraySurface");
			GraffitiBehaviour.NativeFieldInfoPtr__graffitiCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "_graffitiCompleted");
			GraffitiBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.GraffitiBehaviourAssembly-CSharp.dll_Excuted");
			GraffitiBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.GraffitiBehaviourAssembly-CSharp.dll_Excuted");
			GraffitiBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684451);
			GraffitiBehaviour.NativeMethodInfoPtr_Enable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684452);
			GraffitiBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684453);
			GraffitiBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684454);
			GraffitiBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684455);
			GraffitiBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684456);
			GraffitiBehaviour.NativeMethodInfoPtr_Complete_Server_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684457);
			GraffitiBehaviour.NativeMethodInfoPtr_CheckForInterruptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684458);
			GraffitiBehaviour.NativeMethodInfoPtr_SetupEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684459);
			GraffitiBehaviour.NativeMethodInfoPtr_CleanUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684460);
			GraffitiBehaviour.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684461);
			GraffitiBehaviour.NativeMethodInfoPtr_OnTimePass_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684462);
			GraffitiBehaviour.NativeMethodInfoPtr_StopEffectRoutine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684463);
			GraffitiBehaviour.NativeMethodInfoPtr_DoEffectRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684464);
			GraffitiBehaviour.NativeMethodInfoPtr_SetSpraySurface_Client_Public_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684465);
			GraffitiBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684466);
			GraffitiBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684467);
			GraffitiBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684468);
			GraffitiBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684469);
			GraffitiBehaviour.NativeMethodInfoPtr_RpcWriter___Server_Complete_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684470);
			GraffitiBehaviour.NativeMethodInfoPtr_RpcLogic___Complete_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684471);
			GraffitiBehaviour.NativeMethodInfoPtr_RpcReader___Server_Complete_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684472);
			GraffitiBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetSpraySurface_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684473);
			GraffitiBehaviour.NativeMethodInfoPtr_RpcLogic___SetSpraySurface_Client_1824087381_Public_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684474);
			GraffitiBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetSpraySurface_Client_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684475);
			GraffitiBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, 100684476);
		}

		// Token: 0x0600A038 RID: 41016 RVA: 0x002ABB6C File Offset: 0x002A9D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283083, XrefRangeEnd = 283094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A039 RID: 41017 RVA: 0x002ABBBC File Offset: 0x002A9DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283094, XrefRangeEnd = 283107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiBehaviour.NativeMethodInfoPtr_Enable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A03A RID: 41018 RVA: 0x002ABBF8 File Offset: 0x002A9DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283107, XrefRangeEnd = 283146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A03B RID: 41019 RVA: 0x002ABC34 File Offset: 0x002A9E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283146, XrefRangeEnd = 283178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A03C RID: 41020 RVA: 0x002ABC70 File Offset: 0x002A9E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283178, XrefRangeEnd = 283184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A03D RID: 41021 RVA: 0x002ABCAC File Offset: 0x002A9EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283184, XrefRangeEnd = 283196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A03E RID: 41022 RVA: 0x002ABCE8 File Offset: 0x002A9EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283196, XrefRangeEnd = 283205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_Complete_Server_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A03F RID: 41023 RVA: 0x002ABD1C File Offset: 0x002A9F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283205, XrefRangeEnd = 283223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForInterruptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_CheckForInterruptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A040 RID: 41024 RVA: 0x002ABD50 File Offset: 0x002A9F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283265, RefRangeEnd = 283266, XrefRangeStart = 283223, XrefRangeEnd = 283265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_SetupEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A041 RID: 41025 RVA: 0x002ABD84 File Offset: 0x002A9F84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283307, RefRangeEnd = 283309, XrefRangeStart = 283266, XrefRangeEnd = 283307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_CleanUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A042 RID: 41026 RVA: 0x002ABDB8 File Offset: 0x002A9FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283309, XrefRangeEnd = 283327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A043 RID: 41027 RVA: 0x002ABDEC File Offset: 0x002A9FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283327, XrefRangeEnd = 283345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimePass(int minutes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minutes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_OnTimePass_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A044 RID: 41028 RVA: 0x002ABE2C File Offset: 0x002AA02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283345, XrefRangeEnd = 283347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopEffectRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_StopEffectRoutine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x002ABE60 File Offset: 0x002AA060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283347, XrefRangeEnd = 283352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoEffectRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_DoEffectRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x002ABEA0 File Offset: 0x002AA0A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283358, RefRangeEnd = 283359, XrefRangeStart = 283352, XrefRangeEnd = 283358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpraySurface_Client(NetworkConnection conn, NetworkObject surface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surface);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_SetSpraySurface_Client_Public_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A047 RID: 41031 RVA: 0x002ABEF4 File Offset: 0x002AA0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283359, XrefRangeEnd = 283360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraffitiBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A048 RID: 41032 RVA: 0x002ABF30 File Offset: 0x002AA130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283360, XrefRangeEnd = 283375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A049 RID: 41033 RVA: 0x002ABF6C File Offset: 0x002AA16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283375, XrefRangeEnd = 283376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A04A RID: 41034 RVA: 0x002ABFA8 File Offset: 0x002AA1A8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A04B RID: 41035 RVA: 0x002ABFE4 File Offset: 0x002AA1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Complete_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_RpcWriter___Server_Complete_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A04C RID: 41036 RVA: 0x002AC018 File Offset: 0x002AA218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283411, RefRangeEnd = 283412, XrefRangeStart = 283376, XrefRangeEnd = 283411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Complete_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_RpcLogic___Complete_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A04D RID: 41037 RVA: 0x002AC04C File Offset: 0x002AA24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283412, XrefRangeEnd = 283414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Complete_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_RpcReader___Server_Complete_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A04E RID: 41038 RVA: 0x002AC0B0 File Offset: 0x002AA2B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283433, RefRangeEnd = 283435, XrefRangeStart = 283414, XrefRangeEnd = 283433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSpraySurface_Client_1824087381(NetworkConnection conn, NetworkObject surface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surface);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetSpraySurface_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A04F RID: 41039 RVA: 0x002AC104 File Offset: 0x002AA304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283435, XrefRangeEnd = 283440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSpraySurface_Client_1824087381(NetworkConnection conn, NetworkObject surface)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surface);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_RpcLogic___SetSpraySurface_Client_1824087381_Public_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A050 RID: 41040 RVA: 0x002AC158 File Offset: 0x002AA358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283440, XrefRangeEnd = 283448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSpraySurface_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetSpraySurface_Client_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A051 RID: 41041 RVA: 0x002AC1A8 File Offset: 0x002AA3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraffitiBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A052 RID: 41042 RVA: 0x00049ABE File Offset: 0x00047CBE
		public GraffitiBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700306E RID: 12398
		// (get) Token: 0x0600A053 RID: 41043 RVA: 0x002AC1E4 File Offset: 0x002AA3E4
		// (set) Token: 0x0600A054 RID: 41044 RVA: 0x00049AC7 File Offset: 0x00047CC7
		public unsafe static int InterruptionXP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GraffitiBehaviour.NativeFieldInfoPtr_InterruptionXP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraffitiBehaviour.NativeFieldInfoPtr_InterruptionXP, (void*)(&value));
			}
		}

		// Token: 0x1700306F RID: 12399
		// (get) Token: 0x0600A055 RID: 41045 RVA: 0x002AC200 File Offset: 0x002AA400
		// (set) Token: 0x0600A056 RID: 41046 RVA: 0x00049AD5 File Offset: 0x00047CD5
		public unsafe static float InterruptionCartelInfluenceChange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GraffitiBehaviour.NativeFieldInfoPtr_InterruptionCartelInfluenceChange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraffitiBehaviour.NativeFieldInfoPtr_InterruptionCartelInfluenceChange, (void*)(&value));
			}
		}

		// Token: 0x17003070 RID: 12400
		// (get) Token: 0x0600A057 RID: 41047 RVA: 0x002AC21C File Offset: 0x002AA41C
		// (set) Token: 0x0600A058 RID: 41048 RVA: 0x00049AE3 File Offset: 0x00047CE3
		public unsafe SprayPaint _sprayPaint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__sprayPaint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SprayPaint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__sprayPaint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003071 RID: 12401
		// (get) Token: 0x0600A059 RID: 41049 RVA: 0x002AC24C File Offset: 0x002AA44C
		// (set) Token: 0x0600A05A RID: 41050 RVA: 0x00049B02 File Offset: 0x00047D02
		public unsafe Vector2Int _graffitiDurationInMinutes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__graffitiDurationInMinutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__graffitiDurationInMinutes)) = value;
			}
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x0600A05B RID: 41051 RVA: 0x002AC274 File Offset: 0x002AA474
		// (set) Token: 0x0600A05C RID: 41052 RVA: 0x00049B1D File Offset: 0x00047D1D
		public unsafe Vector2 _minMaxEffectLoopDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__minMaxEffectLoopDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__minMaxEffectLoopDuration)) = value;
			}
		}

		// Token: 0x17003073 RID: 12403
		// (get) Token: 0x0600A05D RID: 41053 RVA: 0x002AC29C File Offset: 0x002AA49C
		// (set) Token: 0x0600A05E RID: 41054 RVA: 0x00049B38 File Offset: 0x00047D38
		public unsafe Vector2 _minMaxEffectPauseDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__minMaxEffectPauseDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__minMaxEffectPauseDuration)) = value;
			}
		}

		// Token: 0x17003074 RID: 12404
		// (get) Token: 0x0600A05F RID: 41055 RVA: 0x002AC2C4 File Offset: 0x002AA4C4
		// (set) Token: 0x0600A060 RID: 41056 RVA: 0x00049B53 File Offset: 0x00047D53
		public unsafe Gradient _effectColorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__effectColorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__effectColorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003075 RID: 12405
		// (get) Token: 0x0600A061 RID: 41057 RVA: 0x002AC2F4 File Offset: 0x002AA4F4
		// (set) Token: 0x0600A062 RID: 41058 RVA: 0x00049B72 File Offset: 0x00047D72
		public unsafe List<SerializedGraffitiDrawing> _drawinglist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__drawinglist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedGraffitiDrawing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__drawinglist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003076 RID: 12406
		// (get) Token: 0x0600A063 RID: 41059 RVA: 0x002AC324 File Offset: 0x002AA524
		// (set) Token: 0x0600A064 RID: 41060 RVA: 0x00049B91 File Offset: 0x00047D91
		public unsafe List<Behaviour> _interruptingBehaviours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__interruptingBehaviours);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Behaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__interruptingBehaviours), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x0600A065 RID: 41061 RVA: 0x002AC354 File Offset: 0x002AA554
		// (set) Token: 0x0600A066 RID: 41062 RVA: 0x00049BB0 File Offset: 0x00047DB0
		public unsafe bool _debugMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__debugMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__debugMode)) = value;
			}
		}

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x0600A067 RID: 41063 RVA: 0x002AC37C File Offset: 0x002AA57C
		// (set) Token: 0x0600A068 RID: 41064 RVA: 0x00049BCB File Offset: 0x00047DCB
		public unsafe int _duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__duration)) = value;
			}
		}

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x0600A069 RID: 41065 RVA: 0x002AC3A4 File Offset: 0x002AA5A4
		// (set) Token: 0x0600A06A RID: 41066 RVA: 0x00049BE6 File Offset: 0x00047DE6
		public unsafe Coroutine _effectCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__effectCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__effectCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x0600A06B RID: 41067 RVA: 0x002AC3D4 File Offset: 0x002AA5D4
		// (set) Token: 0x0600A06C RID: 41068 RVA: 0x00049C05 File Offset: 0x00047E05
		public unsafe WorldSpraySurface _spraySurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__spraySurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldSpraySurface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__spraySurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700307B RID: 12411
		// (get) Token: 0x0600A06D RID: 41069 RVA: 0x002AC404 File Offset: 0x002AA604
		// (set) Token: 0x0600A06E RID: 41070 RVA: 0x00049C24 File Offset: 0x00047E24
		public unsafe bool _graffitiCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__graffitiCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr__graffitiCompleted)) = value;
			}
		}

		// Token: 0x1700307C RID: 12412
		// (get) Token: 0x0600A06F RID: 41071 RVA: 0x002AC42C File Offset: 0x002AA62C
		// (set) Token: 0x0600A070 RID: 41072 RVA: 0x00049C3F File Offset: 0x00047E3F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x0600A071 RID: 41073 RVA: 0x002AC454 File Offset: 0x002AA654
		// (set) Token: 0x0600A072 RID: 41074 RVA: 0x00049C5A File Offset: 0x00047E5A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006E91 RID: 28305
		private static readonly IntPtr NativeFieldInfoPtr_InterruptionXP;

		// Token: 0x04006E92 RID: 28306
		private static readonly IntPtr NativeFieldInfoPtr_InterruptionCartelInfluenceChange;

		// Token: 0x04006E93 RID: 28307
		private static readonly IntPtr NativeFieldInfoPtr__sprayPaint;

		// Token: 0x04006E94 RID: 28308
		private static readonly IntPtr NativeFieldInfoPtr__graffitiDurationInMinutes;

		// Token: 0x04006E95 RID: 28309
		private static readonly IntPtr NativeFieldInfoPtr__minMaxEffectLoopDuration;

		// Token: 0x04006E96 RID: 28310
		private static readonly IntPtr NativeFieldInfoPtr__minMaxEffectPauseDuration;

		// Token: 0x04006E97 RID: 28311
		private static readonly IntPtr NativeFieldInfoPtr__effectColorGradient;

		// Token: 0x04006E98 RID: 28312
		private static readonly IntPtr NativeFieldInfoPtr__drawinglist;

		// Token: 0x04006E99 RID: 28313
		private static readonly IntPtr NativeFieldInfoPtr__interruptingBehaviours;

		// Token: 0x04006E9A RID: 28314
		private static readonly IntPtr NativeFieldInfoPtr__debugMode;

		// Token: 0x04006E9B RID: 28315
		private static readonly IntPtr NativeFieldInfoPtr__duration;

		// Token: 0x04006E9C RID: 28316
		private static readonly IntPtr NativeFieldInfoPtr__effectCoroutine;

		// Token: 0x04006E9D RID: 28317
		private static readonly IntPtr NativeFieldInfoPtr__spraySurface;

		// Token: 0x04006E9E RID: 28318
		private static readonly IntPtr NativeFieldInfoPtr__graffitiCompleted;

		// Token: 0x04006E9F RID: 28319
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006EA0 RID: 28320
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006EA1 RID: 28321
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04006EA2 RID: 28322
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Virtual_Void_0;

		// Token: 0x04006EA3 RID: 28323
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04006EA4 RID: 28324
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04006EA5 RID: 28325
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x04006EA6 RID: 28326
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04006EA7 RID: 28327
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Server_Private_Void_0;

		// Token: 0x04006EA8 RID: 28328
		private static readonly IntPtr NativeMethodInfoPtr_CheckForInterruptions_Private_Void_0;

		// Token: 0x04006EA9 RID: 28329
		private static readonly IntPtr NativeMethodInfoPtr_SetupEvents_Private_Void_0;

		// Token: 0x04006EAA RID: 28330
		private static readonly IntPtr NativeMethodInfoPtr_CleanUp_Private_Void_0;

		// Token: 0x04006EAB RID: 28331
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x04006EAC RID: 28332
		private static readonly IntPtr NativeMethodInfoPtr_OnTimePass_Private_Void_Int32_0;

		// Token: 0x04006EAD RID: 28333
		private static readonly IntPtr NativeMethodInfoPtr_StopEffectRoutine_Private_Void_0;

		// Token: 0x04006EAE RID: 28334
		private static readonly IntPtr NativeMethodInfoPtr_DoEffectRoutine_Private_IEnumerator_0;

		// Token: 0x04006EAF RID: 28335
		private static readonly IntPtr NativeMethodInfoPtr_SetSpraySurface_Client_Public_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04006EB0 RID: 28336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006EB1 RID: 28337
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006EB2 RID: 28338
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006EB3 RID: 28339
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006EB4 RID: 28340
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Complete_Server_2166136261_Private_Void_0;

		// Token: 0x04006EB5 RID: 28341
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Complete_Server_2166136261_Private_Void_0;

		// Token: 0x04006EB6 RID: 28342
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Complete_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006EB7 RID: 28343
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSpraySurface_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04006EB8 RID: 28344
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSpraySurface_Client_1824087381_Public_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04006EB9 RID: 28345
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSpraySurface_Client_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006EBA RID: 28346
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C63 RID: 3171
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.GraffitiBehaviour+<DoEffectRoutine>d__27")]
		public sealed class _DoEffectRoutine_d__27 : Il2CppSystem.Object
		{
			// Token: 0x0600F129 RID: 61737 RVA: 0x003A2F70 File Offset: 0x003A1170
			// Note: this type is marked as 'beforefieldinit'.
			static _DoEffectRoutine_d__27()
			{
				Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraffitiBehaviour>.NativeClassPtr, "<DoEffectRoutine>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr);
				GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr, "<>1__state");
				GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr, "<>2__current");
				GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr, "<>4__this");
				GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr__safetyCounter_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr, "<safetyCounter>5__2");
				GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr, 100684477);
				GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr, 100684478);
				GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr, 100684479);
				GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr, 100684480);
				GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr, 100684481);
				GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr, 100684482);
			}

			// Token: 0x0600F12A RID: 61738 RVA: 0x003A3064 File Offset: 0x003A1264
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoEffectRoutine_d__27(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraffitiBehaviour._DoEffectRoutine_d__27>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F12B RID: 61739 RVA: 0x003A30AC File Offset: 0x003A12AC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F12C RID: 61740 RVA: 0x003A30E0 File Offset: 0x003A12E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283070, XrefRangeEnd = 283078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004938 RID: 18744
			// (get) Token: 0x0600F12D RID: 61741 RVA: 0x003A311C File Offset: 0x003A131C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F12E RID: 61742 RVA: 0x003A315C File Offset: 0x003A135C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283078, XrefRangeEnd = 283083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004939 RID: 18745
			// (get) Token: 0x0600F12F RID: 61743 RVA: 0x003A3190 File Offset: 0x003A1390
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraffitiBehaviour._DoEffectRoutine_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F130 RID: 61744 RVA: 0x00071D40 File Offset: 0x0006FF40
			public _DoEffectRoutine_d__27(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004934 RID: 18740
			// (get) Token: 0x0600F131 RID: 61745 RVA: 0x003A31D0 File Offset: 0x003A13D0
			// (set) Token: 0x0600F132 RID: 61746 RVA: 0x00071D49 File Offset: 0x0006FF49
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004935 RID: 18741
			// (get) Token: 0x0600F133 RID: 61747 RVA: 0x003A31F8 File Offset: 0x003A13F8
			// (set) Token: 0x0600F134 RID: 61748 RVA: 0x00071D64 File Offset: 0x0006FF64
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004936 RID: 18742
			// (get) Token: 0x0600F135 RID: 61749 RVA: 0x003A3228 File Offset: 0x003A1428
			// (set) Token: 0x0600F136 RID: 61750 RVA: 0x00071D83 File Offset: 0x0006FF83
			public unsafe GraffitiBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraffitiBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004937 RID: 18743
			// (get) Token: 0x0600F137 RID: 61751 RVA: 0x003A3258 File Offset: 0x003A1458
			// (set) Token: 0x0600F138 RID: 61752 RVA: 0x00071DA2 File Offset: 0x0006FFA2
			public unsafe int _safetyCounter_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr__safetyCounter_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraffitiBehaviour._DoEffectRoutine_d__27.NativeFieldInfoPtr__safetyCounter_5__2)) = value;
				}
			}

			// Token: 0x0400A341 RID: 41793
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A342 RID: 41794
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A343 RID: 41795
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A344 RID: 41796
			private static readonly IntPtr NativeFieldInfoPtr__safetyCounter_5__2;

			// Token: 0x0400A345 RID: 41797
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A346 RID: 41798
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A347 RID: 41799
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A348 RID: 41800
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A349 RID: 41801
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A34A RID: 41802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

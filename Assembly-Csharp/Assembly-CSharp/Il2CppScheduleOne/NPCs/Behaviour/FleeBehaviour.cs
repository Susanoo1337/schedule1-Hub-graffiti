using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000678 RID: 1656
	public class FleeBehaviour : Behaviour
	{
		// Token: 0x06009FA5 RID: 40869 RVA: 0x002A9764 File Offset: 0x002A7964
		// Note: this type is marked as 'beforefieldinit'.
		static FleeBehaviour()
		{
			Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FleeBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr);
			FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_DIST_MIN");
			FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_DIST_MAX");
			FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_SPEED");
			FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<EntityToFlee>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<FleeMode>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<FleeOrigin>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "currentFleeTarget");
			FleeBehaviour.NativeFieldInfoPtr_nextVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "nextVO");
			FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted");
			FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted");
			FleeBehaviour.NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684375);
			FleeBehaviour.NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684376);
			FleeBehaviour.NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684377);
			FleeBehaviour.NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684378);
			FleeBehaviour.NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684379);
			FleeBehaviour.NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684380);
			FleeBehaviour.NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684381);
			FleeBehaviour.NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684382);
			FleeBehaviour.NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684383);
			FleeBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684384);
			FleeBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684385);
			FleeBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684386);
			FleeBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684387);
			FleeBehaviour.NativeMethodInfoPtr_StartFlee_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684388);
			FleeBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684389);
			FleeBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684390);
			FleeBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684391);
			FleeBehaviour.NativeMethodInfoPtr_Flee_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684392);
			FleeBehaviour.NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684393);
			FleeBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684394);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684395);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684396);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684397);
			FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684398);
			FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684399);
			FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684400);
			FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684401);
			FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684402);
			FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684403);
			FleeBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100684404);
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x06009FA6 RID: 40870 RVA: 0x002A9AB4 File Offset: 0x002A7CB4
		// (set) Token: 0x06009FA7 RID: 40871 RVA: 0x002A9AF4 File Offset: 0x002A7CF4
		public unsafe NetworkObject EntityToFlee
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x06009FA8 RID: 40872 RVA: 0x002A9B38 File Offset: 0x002A7D38
		public unsafe Vector3 PointToFlee
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x06009FA9 RID: 40873 RVA: 0x002A9B74 File Offset: 0x002A7D74
		// (set) Token: 0x06009FAA RID: 40874 RVA: 0x002A9BB0 File Offset: 0x002A7DB0
		public unsafe FleeBehaviour.EFleeMode FleeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x06009FAB RID: 40875 RVA: 0x002A9BF0 File Offset: 0x002A7DF0
		// (set) Token: 0x06009FAC RID: 40876 RVA: 0x002A9C2C File Offset: 0x002A7E2C
		public unsafe Vector3 FleeOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x002A9C6C File Offset: 0x002A7E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282369, RefRangeEnd = 282370, XrefRangeStart = 282348, XrefRangeEnd = 282369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntityToFlee(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FAE RID: 40878 RVA: 0x002A9CB0 File Offset: 0x002A7EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282370, XrefRangeEnd = 282392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPointToFlee(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FAF RID: 40879 RVA: 0x002A9CF0 File Offset: 0x002A7EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282392, XrefRangeEnd = 282398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB0 RID: 40880 RVA: 0x002A9D2C File Offset: 0x002A7F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282398, XrefRangeEnd = 282400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB1 RID: 40881 RVA: 0x002A9D68 File Offset: 0x002A7F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282400, XrefRangeEnd = 282407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB2 RID: 40882 RVA: 0x002A9DA4 File Offset: 0x002A7FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282407, XrefRangeEnd = 282409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB3 RID: 40883 RVA: 0x002A9DE0 File Offset: 0x002A7FE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282424, RefRangeEnd = 282426, XrefRangeStart = 282409, XrefRangeEnd = 282424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFlee()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_StartFlee_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB4 RID: 40884 RVA: 0x002A9E14 File Offset: 0x002A8014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282426, XrefRangeEnd = 282443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB5 RID: 40885 RVA: 0x002A9E50 File Offset: 0x002A8050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282443, XrefRangeEnd = 282450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB6 RID: 40886 RVA: 0x002A9E8C File Offset: 0x002A808C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282457, RefRangeEnd = 282459, XrefRangeStart = 282450, XrefRangeEnd = 282457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB7 RID: 40887 RVA: 0x002A9EC0 File Offset: 0x002A80C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282462, RefRangeEnd = 282463, XrefRangeStart = 282459, XrefRangeEnd = 282462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flee()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_Flee_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FB8 RID: 40888 RVA: 0x002A9EF4 File Offset: 0x002A80F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282512, RefRangeEnd = 282513, XrefRangeStart = 282463, XrefRangeEnd = 282512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetFleePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009FB9 RID: 40889 RVA: 0x002A9F30 File Offset: 0x002A8130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282513, XrefRangeEnd = 282518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FleeBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FBA RID: 40890 RVA: 0x002A9F6C File Offset: 0x002A816C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282518, XrefRangeEnd = 282532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FBB RID: 40891 RVA: 0x002A9FA8 File Offset: 0x002A81A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FBC RID: 40892 RVA: 0x002A9FE4 File Offset: 0x002A81E4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FBD RID: 40893 RVA: 0x002AA020 File Offset: 0x002A8220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282532, XrefRangeEnd = 282542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetEntityToFlee_3323014238(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FBE RID: 40894 RVA: 0x002AA064 File Offset: 0x002A8264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282542, XrefRangeEnd = 282543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetEntityToFlee_3323014238(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FBF RID: 40895 RVA: 0x002AA0A8 File Offset: 0x002A82A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282543, XrefRangeEnd = 282547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetEntityToFlee_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FC0 RID: 40896 RVA: 0x002AA0F8 File Offset: 0x002A82F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282547, XrefRangeEnd = 282559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPointToFlee_4276783012(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FC1 RID: 40897 RVA: 0x002AA138 File Offset: 0x002A8338
		[CallerCount(0)]
		public unsafe void RpcLogic___SetPointToFlee_4276783012(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FC2 RID: 40898 RVA: 0x002AA178 File Offset: 0x002A8378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282559, XrefRangeEnd = 282564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPointToFlee_4276783012(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FC3 RID: 40899 RVA: 0x002AA1C8 File Offset: 0x002A83C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FC4 RID: 40900 RVA: 0x00049795 File Offset: 0x00047995
		public FleeBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x06009FC5 RID: 40901 RVA: 0x002AA204 File Offset: 0x002A8404
		// (set) Token: 0x06009FC6 RID: 40902 RVA: 0x0004979E File Offset: 0x0004799E
		public unsafe static float FLEE_DIST_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN, (void*)(&value));
			}
		}

		// Token: 0x1700304C RID: 12364
		// (get) Token: 0x06009FC7 RID: 40903 RVA: 0x002AA220 File Offset: 0x002A8420
		// (set) Token: 0x06009FC8 RID: 40904 RVA: 0x000497AC File Offset: 0x000479AC
		public unsafe static float FLEE_DIST_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX, (void*)(&value));
			}
		}

		// Token: 0x1700304D RID: 12365
		// (get) Token: 0x06009FC9 RID: 40905 RVA: 0x002AA23C File Offset: 0x002A843C
		// (set) Token: 0x06009FCA RID: 40906 RVA: 0x000497BA File Offset: 0x000479BA
		public unsafe static float FLEE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x1700304E RID: 12366
		// (get) Token: 0x06009FCB RID: 40907 RVA: 0x002AA258 File Offset: 0x002A8458
		// (set) Token: 0x06009FCC RID: 40908 RVA: 0x000497C8 File Offset: 0x000479C8
		public unsafe NetworkObject _EntityToFlee_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700304F RID: 12367
		// (get) Token: 0x06009FCD RID: 40909 RVA: 0x002AA288 File Offset: 0x002A8488
		// (set) Token: 0x06009FCE RID: 40910 RVA: 0x000497E7 File Offset: 0x000479E7
		public unsafe FleeBehaviour.EFleeMode _FleeMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17003050 RID: 12368
		// (get) Token: 0x06009FCF RID: 40911 RVA: 0x002AA2B0 File Offset: 0x002A84B0
		// (set) Token: 0x06009FD0 RID: 40912 RVA: 0x00049802 File Offset: 0x00047A02
		public unsafe Vector3 _FleeOrigin_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField)) = value;
			}
		}

		// Token: 0x17003051 RID: 12369
		// (get) Token: 0x06009FD1 RID: 40913 RVA: 0x002AA2D8 File Offset: 0x002A84D8
		// (set) Token: 0x06009FD2 RID: 40914 RVA: 0x0004981D File Offset: 0x00047A1D
		public unsafe Vector3 currentFleeTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget)) = value;
			}
		}

		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x06009FD3 RID: 40915 RVA: 0x002AA300 File Offset: 0x002A8500
		// (set) Token: 0x06009FD4 RID: 40916 RVA: 0x00049838 File Offset: 0x00047A38
		public unsafe float nextVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_nextVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_nextVO)) = value;
			}
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x06009FD5 RID: 40917 RVA: 0x002AA328 File Offset: 0x002A8528
		// (set) Token: 0x06009FD6 RID: 40918 RVA: 0x00049853 File Offset: 0x00047A53
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x06009FD7 RID: 40919 RVA: 0x002AA350 File Offset: 0x002A8550
		// (set) Token: 0x06009FD8 RID: 40920 RVA: 0x0004986E File Offset: 0x00047A6E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006E27 RID: 28199
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_DIST_MIN;

		// Token: 0x04006E28 RID: 28200
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_DIST_MAX;

		// Token: 0x04006E29 RID: 28201
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_SPEED;

		// Token: 0x04006E2A RID: 28202
		private static readonly IntPtr NativeFieldInfoPtr__EntityToFlee_k__BackingField;

		// Token: 0x04006E2B RID: 28203
		private static readonly IntPtr NativeFieldInfoPtr__FleeMode_k__BackingField;

		// Token: 0x04006E2C RID: 28204
		private static readonly IntPtr NativeFieldInfoPtr__FleeOrigin_k__BackingField;

		// Token: 0x04006E2D RID: 28205
		private static readonly IntPtr NativeFieldInfoPtr_currentFleeTarget;

		// Token: 0x04006E2E RID: 28206
		private static readonly IntPtr NativeFieldInfoPtr_nextVO;

		// Token: 0x04006E2F RID: 28207
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006E30 RID: 28208
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006E31 RID: 28209
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0;

		// Token: 0x04006E32 RID: 28210
		private static readonly IntPtr NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0;

		// Token: 0x04006E33 RID: 28211
		private static readonly IntPtr NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0;

		// Token: 0x04006E34 RID: 28212
		private static readonly IntPtr NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0;

		// Token: 0x04006E35 RID: 28213
		private static readonly IntPtr NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0;

		// Token: 0x04006E36 RID: 28214
		private static readonly IntPtr NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0;

		// Token: 0x04006E37 RID: 28215
		private static readonly IntPtr NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0;

		// Token: 0x04006E38 RID: 28216
		private static readonly IntPtr NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0;

		// Token: 0x04006E39 RID: 28217
		private static readonly IntPtr NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0;

		// Token: 0x04006E3A RID: 28218
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04006E3B RID: 28219
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04006E3C RID: 28220
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04006E3D RID: 28221
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x04006E3E RID: 28222
		private static readonly IntPtr NativeMethodInfoPtr_StartFlee_Private_Void_0;

		// Token: 0x04006E3F RID: 28223
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x04006E40 RID: 28224
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04006E41 RID: 28225
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_0;

		// Token: 0x04006E42 RID: 28226
		private static readonly IntPtr NativeMethodInfoPtr_Flee_Private_Void_0;

		// Token: 0x04006E43 RID: 28227
		private static readonly IntPtr NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0;

		// Token: 0x04006E44 RID: 28228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006E45 RID: 28229
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006E46 RID: 28230
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006E47 RID: 28231
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006E48 RID: 28232
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04006E49 RID: 28233
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04006E4A RID: 28234
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006E4B RID: 28235
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0;

		// Token: 0x04006E4C RID: 28236
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0;

		// Token: 0x04006E4D RID: 28237
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006E4E RID: 28238
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C62 RID: 3170
		[OriginalName("Assembly-CSharp.dll", "", "EFleeMode")]
		public enum EFleeMode
		{
			// Token: 0x0400A33F RID: 41791
			Entity,
			// Token: 0x0400A340 RID: 41792
			Point
		}
	}
}

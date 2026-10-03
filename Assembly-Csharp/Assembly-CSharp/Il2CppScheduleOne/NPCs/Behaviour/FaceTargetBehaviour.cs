using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000677 RID: 1655
	public class FaceTargetBehaviour : Behaviour
	{
		// Token: 0x06009F76 RID: 40822 RVA: 0x002A8A54 File Offset: 0x002A6C54
		// Note: this type is marked as 'beforefieldinit'.
		static FaceTargetBehaviour()
		{
			Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FaceTargetBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr);
			FaceTargetBehaviour.NativeFieldInfoPtr__TargetType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, "<TargetType>k__BackingField");
			FaceTargetBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, "<TargetPlayer>k__BackingField");
			FaceTargetBehaviour.NativeFieldInfoPtr__TargetPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, "<TargetPosition>k__BackingField");
			FaceTargetBehaviour.NativeFieldInfoPtr__Countdown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, "<Countdown>k__BackingField");
			FaceTargetBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FaceTargetBehaviourAssembly-CSharp.dll_Excuted");
			FaceTargetBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FaceTargetBehaviourAssembly-CSharp.dll_Excuted");
			FaceTargetBehaviour.NativeMethodInfoPtr_get_TargetType_Public_get_ETargetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684342);
			FaceTargetBehaviour.NativeMethodInfoPtr_set_TargetType_Private_set_Void_ETargetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684343);
			FaceTargetBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684344);
			FaceTargetBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684345);
			FaceTargetBehaviour.NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684346);
			FaceTargetBehaviour.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684347);
			FaceTargetBehaviour.NativeMethodInfoPtr_get_Countdown_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684348);
			FaceTargetBehaviour.NativeMethodInfoPtr_set_Countdown_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684349);
			FaceTargetBehaviour.NativeMethodInfoPtr_SetTarget_Public_Void_NetworkObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684350);
			FaceTargetBehaviour.NativeMethodInfoPtr_SetTargetLocal_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684351);
			FaceTargetBehaviour.NativeMethodInfoPtr_SetTarget_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684352);
			FaceTargetBehaviour.NativeMethodInfoPtr_SetTargetLocal_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684353);
			FaceTargetBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684354);
			FaceTargetBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684355);
			FaceTargetBehaviour.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684356);
			FaceTargetBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684357);
			FaceTargetBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684358);
			FaceTargetBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684359);
			FaceTargetBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684360);
			FaceTargetBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684361);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SetTarget_244313061_Private_Void_NetworkObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684362);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_244313061_Public_Void_NetworkObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684363);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcReader___Server_SetTarget_244313061_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684364);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684365);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcLogic___SetTargetLocal_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684366);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684367);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SetTarget_3661469815_Private_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684368);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_3661469815_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684369);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcReader___Server_SetTarget_3661469815_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684370);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684371);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcLogic___SetTargetLocal_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684372);
			FaceTargetBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_4276783012_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684373);
			FaceTargetBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr, 100684374);
		}

		// Token: 0x17003047 RID: 12359
		// (get) Token: 0x06009F77 RID: 40823 RVA: 0x002A8D90 File Offset: 0x002A6F90
		// (set) Token: 0x06009F78 RID: 40824 RVA: 0x002A8DCC File Offset: 0x002A6FCC
		public unsafe FaceTargetBehaviour.ETargetType TargetType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_get_TargetType_Public_get_ETargetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_set_TargetType_Private_set_Void_ETargetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003048 RID: 12360
		// (get) Token: 0x06009F79 RID: 40825 RVA: 0x002A8E0C File Offset: 0x002A700C
		// (set) Token: 0x06009F7A RID: 40826 RVA: 0x002A8E4C File Offset: 0x002A704C
		public unsafe Player TargetPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 140441, RefRangeEnd = 140444, XrefRangeStart = 140441, XrefRangeEnd = 140444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x06009F7B RID: 40827 RVA: 0x002A8E90 File Offset: 0x002A7090
		// (set) Token: 0x06009F7C RID: 40828 RVA: 0x002A8ECC File Offset: 0x002A70CC
		public unsafe Vector3 TargetPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x06009F7D RID: 40829 RVA: 0x002A8F0C File Offset: 0x002A710C
		// (set) Token: 0x06009F7E RID: 40830 RVA: 0x002A8F48 File Offset: 0x002A7148
		public unsafe float Countdown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_get_Countdown_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_set_Countdown_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009F7F RID: 40831 RVA: 0x002A8F88 File Offset: 0x002A7188
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 282095, RefRangeEnd = 282100, XrefRangeStart = 282072, XrefRangeEnd = 282095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(NetworkObject player, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_SetTarget_Public_Void_NetworkObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x002A8FD8 File Offset: 0x002A71D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282130, RefRangeEnd = 282131, XrefRangeStart = 282100, XrefRangeEnd = 282130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetLocal(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_SetTargetLocal_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x002A901C File Offset: 0x002A721C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282155, RefRangeEnd = 282157, XrefRangeStart = 282131, XrefRangeEnd = 282155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(Vector3 position, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_SetTarget_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x002A9068 File Offset: 0x002A7268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282157, XrefRangeEnd = 282179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetLocal(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_SetTargetLocal_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F83 RID: 40835 RVA: 0x002A90A8 File Offset: 0x002A72A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282179, XrefRangeEnd = 282183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FaceTargetBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F84 RID: 40836 RVA: 0x002A90E4 File Offset: 0x002A72E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282183, XrefRangeEnd = 282198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FaceTargetBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F85 RID: 40837 RVA: 0x002A9120 File Offset: 0x002A7320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282198, XrefRangeEnd = 282203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009F86 RID: 40838 RVA: 0x002A915C File Offset: 0x002A735C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FaceTargetBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F87 RID: 40839 RVA: 0x002A9198 File Offset: 0x002A7398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282203, XrefRangeEnd = 282206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FaceTargetBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FaceTargetBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F88 RID: 40840 RVA: 0x002A91D4 File Offset: 0x002A73D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282206, XrefRangeEnd = 282233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FaceTargetBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F89 RID: 40841 RVA: 0x002A9210 File Offset: 0x002A7410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FaceTargetBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x002A924C File Offset: 0x002A744C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FaceTargetBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F8B RID: 40843 RVA: 0x002A9288 File Offset: 0x002A7488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282233, XrefRangeEnd = 282244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetTarget_244313061(NetworkObject player, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SetTarget_244313061_Private_Void_NetworkObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F8C RID: 40844 RVA: 0x002A92D8 File Offset: 0x002A74D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282255, RefRangeEnd = 282257, XrefRangeStart = 282244, XrefRangeEnd = 282255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTarget_244313061(NetworkObject player, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_244313061_Public_Void_NetworkObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F8D RID: 40845 RVA: 0x002A9328 File Offset: 0x002A7528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282257, XrefRangeEnd = 282262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetTarget_244313061(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcReader___Server_SetTarget_244313061_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F8E RID: 40846 RVA: 0x002A938C File Offset: 0x002A758C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282262, XrefRangeEnd = 282272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTargetLocal_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F8F RID: 40847 RVA: 0x002A93D0 File Offset: 0x002A75D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282282, RefRangeEnd = 282283, XrefRangeStart = 282272, XrefRangeEnd = 282282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTargetLocal_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcLogic___SetTargetLocal_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F90 RID: 40848 RVA: 0x002A9414 File Offset: 0x002A7614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282283, XrefRangeEnd = 282287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTargetLocal_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F91 RID: 40849 RVA: 0x002A9464 File Offset: 0x002A7664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282287, XrefRangeEnd = 282300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetTarget_3661469815(Vector3 position, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SetTarget_3661469815_Private_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x002A94B0 File Offset: 0x002A76B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 282322, RefRangeEnd = 282324, XrefRangeStart = 282300, XrefRangeEnd = 282322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTarget_3661469815(Vector3 position, float countDown = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref countDown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_3661469815_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F93 RID: 40851 RVA: 0x002A94FC File Offset: 0x002A76FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282324, XrefRangeEnd = 282331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetTarget_3661469815(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcReader___Server_SetTarget_3661469815_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F94 RID: 40852 RVA: 0x002A9560 File Offset: 0x002A7760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282331, XrefRangeEnd = 282343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTargetLocal_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F95 RID: 40853 RVA: 0x002A95A0 File Offset: 0x002A77A0
		[CallerCount(0)]
		public unsafe void RpcLogic___SetTargetLocal_4276783012(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcLogic___SetTargetLocal_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F96 RID: 40854 RVA: 0x002A95E0 File Offset: 0x002A77E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282343, XrefRangeEnd = 282348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTargetLocal_4276783012(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FaceTargetBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_4276783012_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F97 RID: 40855 RVA: 0x002A9630 File Offset: 0x002A7830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FaceTargetBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009F98 RID: 40856 RVA: 0x000496E6 File Offset: 0x000478E6
		public FaceTargetBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003041 RID: 12353
		// (get) Token: 0x06009F99 RID: 40857 RVA: 0x002A966C File Offset: 0x002A786C
		// (set) Token: 0x06009F9A RID: 40858 RVA: 0x000496EF File Offset: 0x000478EF
		public unsafe FaceTargetBehaviour.ETargetType _TargetType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr__TargetType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr__TargetType_k__BackingField)) = value;
			}
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x06009F9B RID: 40859 RVA: 0x002A9694 File Offset: 0x002A7894
		// (set) Token: 0x06009F9C RID: 40860 RVA: 0x0004970A File Offset: 0x0004790A
		public unsafe Player _TargetPlayer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr__TargetPlayer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x06009F9D RID: 40861 RVA: 0x002A96C4 File Offset: 0x002A78C4
		// (set) Token: 0x06009F9E RID: 40862 RVA: 0x00049729 File Offset: 0x00047929
		public unsafe Vector3 _TargetPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr__TargetPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr__TargetPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x06009F9F RID: 40863 RVA: 0x002A96EC File Offset: 0x002A78EC
		// (set) Token: 0x06009FA0 RID: 40864 RVA: 0x00049744 File Offset: 0x00047944
		public unsafe float _Countdown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr__Countdown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr__Countdown_k__BackingField)) = value;
			}
		}

		// Token: 0x17003045 RID: 12357
		// (get) Token: 0x06009FA1 RID: 40865 RVA: 0x002A9714 File Offset: 0x002A7914
		// (set) Token: 0x06009FA2 RID: 40866 RVA: 0x0004975F File Offset: 0x0004795F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003046 RID: 12358
		// (get) Token: 0x06009FA3 RID: 40867 RVA: 0x002A973C File Offset: 0x002A793C
		// (set) Token: 0x06009FA4 RID: 40868 RVA: 0x0004977A File Offset: 0x0004797A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FaceTargetBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006E00 RID: 28160
		private static readonly IntPtr NativeFieldInfoPtr__TargetType_k__BackingField;

		// Token: 0x04006E01 RID: 28161
		private static readonly IntPtr NativeFieldInfoPtr__TargetPlayer_k__BackingField;

		// Token: 0x04006E02 RID: 28162
		private static readonly IntPtr NativeFieldInfoPtr__TargetPosition_k__BackingField;

		// Token: 0x04006E03 RID: 28163
		private static readonly IntPtr NativeFieldInfoPtr__Countdown_k__BackingField;

		// Token: 0x04006E04 RID: 28164
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006E05 RID: 28165
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006E06 RID: 28166
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetType_Public_get_ETargetType_0;

		// Token: 0x04006E07 RID: 28167
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetType_Private_set_Void_ETargetType_0;

		// Token: 0x04006E08 RID: 28168
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPlayer_Public_get_Player_0;

		// Token: 0x04006E09 RID: 28169
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPlayer_Private_set_Void_Player_0;

		// Token: 0x04006E0A RID: 28170
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetPosition_Public_get_Vector3_0;

		// Token: 0x04006E0B RID: 28171
		private static readonly IntPtr NativeMethodInfoPtr_set_TargetPosition_Private_set_Void_Vector3_0;

		// Token: 0x04006E0C RID: 28172
		private static readonly IntPtr NativeMethodInfoPtr_get_Countdown_Public_get_Single_0;

		// Token: 0x04006E0D RID: 28173
		private static readonly IntPtr NativeMethodInfoPtr_set_Countdown_Private_set_Void_Single_0;

		// Token: 0x04006E0E RID: 28174
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_NetworkObject_Single_0;

		// Token: 0x04006E0F RID: 28175
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetLocal_Private_Void_NetworkObject_0;

		// Token: 0x04006E10 RID: 28176
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_Vector3_Single_0;

		// Token: 0x04006E11 RID: 28177
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetLocal_Private_Void_Vector3_0;

		// Token: 0x04006E12 RID: 28178
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04006E13 RID: 28179
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04006E14 RID: 28180
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0;

		// Token: 0x04006E15 RID: 28181
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04006E16 RID: 28182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006E17 RID: 28183
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006E18 RID: 28184
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006E19 RID: 28185
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006E1A RID: 28186
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetTarget_244313061_Private_Void_NetworkObject_Single_0;

		// Token: 0x04006E1B RID: 28187
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTarget_244313061_Public_Void_NetworkObject_Single_0;

		// Token: 0x04006E1C RID: 28188
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetTarget_244313061_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006E1D RID: 28189
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04006E1E RID: 28190
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTargetLocal_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04006E1F RID: 28191
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006E20 RID: 28192
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetTarget_3661469815_Private_Void_Vector3_Single_0;

		// Token: 0x04006E21 RID: 28193
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTarget_3661469815_Public_Void_Vector3_Single_0;

		// Token: 0x04006E22 RID: 28194
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetTarget_3661469815_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006E23 RID: 28195
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTargetLocal_4276783012_Private_Void_Vector3_0;

		// Token: 0x04006E24 RID: 28196
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTargetLocal_4276783012_Private_Void_Vector3_0;

		// Token: 0x04006E25 RID: 28197
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTargetLocal_4276783012_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006E26 RID: 28198
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000C61 RID: 3169
		[OriginalName("Assembly-CSharp.dll", "", "ETargetType")]
		public enum ETargetType
		{
			// Token: 0x0400A33C RID: 41788
			Player,
			// Token: 0x0400A33D RID: 41789
			Position
		}
	}
}

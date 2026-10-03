using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.UI.WorldspacePopup;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000658 RID: 1624
	public class CallPoliceBehaviour : Behaviour
	{
		// Token: 0x06009B05 RID: 39685 RVA: 0x00297288 File Offset: 0x00295488
		// Note: this type is marked as 'beforefieldinit'.
		static CallPoliceBehaviour()
		{
			Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "CallPoliceBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr);
			CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "CALL_POLICE_TIME");
			CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "PhoneCallPopup");
			CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "PhonePrefab");
			CallPoliceBehaviour.NativeFieldInfoPtr_CallSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "CallSound");
			CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "currentCallTime");
			CallPoliceBehaviour.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "Target");
			CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "ReportedCrime");
			CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted");
			CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted");
			CallPoliceBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683475);
			CallPoliceBehaviour.NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683476);
			CallPoliceBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683477);
			CallPoliceBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683478);
			CallPoliceBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683479);
			CallPoliceBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683480);
			CallPoliceBehaviour.NativeMethodInfoPtr_RefreshIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683481);
			CallPoliceBehaviour.NativeMethodInfoPtr_FinalizeCall_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683482);
			CallPoliceBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683483);
			CallPoliceBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683484);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683485);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683486);
			CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683487);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683488);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683489);
			CallPoliceBehaviour.NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683490);
			CallPoliceBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr, 100683491);
		}

		// Token: 0x06009B06 RID: 39686 RVA: 0x002974C0 File Offset: 0x002956C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276157, XrefRangeEnd = 276177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x002974FC File Offset: 0x002956FC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(NetworkObject player, Crime crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(crime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B08 RID: 39688 RVA: 0x00297550 File Offset: 0x00295750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276177, XrefRangeEnd = 276184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B09 RID: 39689 RVA: 0x0029758C File Offset: 0x0029578C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276184, XrefRangeEnd = 276191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B0A RID: 39690 RVA: 0x002975C8 File Offset: 0x002957C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276191, XrefRangeEnd = 276198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x00297604 File Offset: 0x00295804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276198, XrefRangeEnd = 276221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B0C RID: 39692 RVA: 0x00297640 File Offset: 0x00295840
		[CallerCount(0)]
		public unsafe void RefreshIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RefreshIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B0D RID: 39693 RVA: 0x00297674 File Offset: 0x00295874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276221, XrefRangeEnd = 276242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_FinalizeCall_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x002976A8 File Offset: 0x002958A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 276246, RefRangeEnd = 276249, XrefRangeStart = 276242, XrefRangeEnd = 276246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009B0F RID: 39695 RVA: 0x002976E4 File Offset: 0x002958E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276250, RefRangeEnd = 276252, XrefRangeStart = 276249, XrefRangeEnd = 276250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallPoliceBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallPoliceBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B10 RID: 39696 RVA: 0x00297720 File Offset: 0x00295920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276252, XrefRangeEnd = 276259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B11 RID: 39697 RVA: 0x0029775C File Offset: 0x0029595C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B12 RID: 39698 RVA: 0x00297798 File Offset: 0x00295998
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x002977D4 File Offset: 0x002959D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276259, XrefRangeEnd = 276268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_FinalizeCall_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B14 RID: 39700 RVA: 0x00297808 File Offset: 0x00295A08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 276279, RefRangeEnd = 276282, XrefRangeStart = 276268, XrefRangeEnd = 276279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___FinalizeCall_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B15 RID: 39701 RVA: 0x0029783C File Offset: 0x00295A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276282, XrefRangeEnd = 276285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_FinalizeCall_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallPoliceBehaviour.NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x0029788C File Offset: 0x00295A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276285, XrefRangeEnd = 276286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallPoliceBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x000481E8 File Offset: 0x000463E8
		public CallPoliceBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x06009B18 RID: 39704 RVA: 0x002978C8 File Offset: 0x00295AC8
		// (set) Token: 0x06009B19 RID: 39705 RVA: 0x000481F1 File Offset: 0x000463F1
		public unsafe static float CALL_POLICE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallPoliceBehaviour.NativeFieldInfoPtr_CALL_POLICE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x06009B1A RID: 39706 RVA: 0x002978E4 File Offset: 0x00295AE4
		// (set) Token: 0x06009B1B RID: 39707 RVA: 0x000481FF File Offset: 0x000463FF
		public unsafe WorldspacePopup PhoneCallPopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhoneCallPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x06009B1C RID: 39708 RVA: 0x00297914 File Offset: 0x00295B14
		// (set) Token: 0x06009B1D RID: 39709 RVA: 0x0004821E File Offset: 0x0004641E
		public unsafe AvatarEquippable PhonePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_PhonePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x06009B1E RID: 39710 RVA: 0x00297944 File Offset: 0x00295B44
		// (set) Token: 0x06009B1F RID: 39711 RVA: 0x0004823D File Offset: 0x0004643D
		public unsafe AudioSourceController CallSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_CallSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_CallSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x06009B20 RID: 39712 RVA: 0x00297974 File Offset: 0x00295B74
		// (set) Token: 0x06009B21 RID: 39713 RVA: 0x0004825C File Offset: 0x0004645C
		public unsafe float currentCallTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_currentCallTime)) = value;
			}
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x06009B22 RID: 39714 RVA: 0x0029799C File Offset: 0x00295B9C
		// (set) Token: 0x06009B23 RID: 39715 RVA: 0x00048277 File Offset: 0x00046477
		public unsafe Player Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x06009B24 RID: 39716 RVA: 0x002979CC File Offset: 0x00295BCC
		// (set) Token: 0x06009B25 RID: 39717 RVA: 0x00048296 File Offset: 0x00046496
		public unsafe Crime ReportedCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Crime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_ReportedCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x06009B26 RID: 39718 RVA: 0x002979FC File Offset: 0x00295BFC
		// (set) Token: 0x06009B27 RID: 39719 RVA: 0x000482B5 File Offset: 0x000464B5
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x06009B28 RID: 39720 RVA: 0x00297A24 File Offset: 0x00295C24
		// (set) Token: 0x06009B29 RID: 39721 RVA: 0x000482D0 File Offset: 0x000464D0
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallPoliceBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006A89 RID: 27273
		private static readonly IntPtr NativeFieldInfoPtr_CALL_POLICE_TIME;

		// Token: 0x04006A8A RID: 27274
		private static readonly IntPtr NativeFieldInfoPtr_PhoneCallPopup;

		// Token: 0x04006A8B RID: 27275
		private static readonly IntPtr NativeFieldInfoPtr_PhonePrefab;

		// Token: 0x04006A8C RID: 27276
		private static readonly IntPtr NativeFieldInfoPtr_CallSound;

		// Token: 0x04006A8D RID: 27277
		private static readonly IntPtr NativeFieldInfoPtr_currentCallTime;

		// Token: 0x04006A8E RID: 27278
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x04006A8F RID: 27279
		private static readonly IntPtr NativeFieldInfoPtr_ReportedCrime;

		// Token: 0x04006A90 RID: 27280
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006A91 RID: 27281
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006A92 RID: 27282
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04006A93 RID: 27283
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_NetworkObject_Crime_0;

		// Token: 0x04006A94 RID: 27284
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04006A95 RID: 27285
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04006A96 RID: 27286
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x04006A97 RID: 27287
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04006A98 RID: 27288
		private static readonly IntPtr NativeMethodInfoPtr_RefreshIcon_Private_Void_0;

		// Token: 0x04006A99 RID: 27289
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeCall_Private_Void_0;

		// Token: 0x04006A9A RID: 27290
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0;

		// Token: 0x04006A9B RID: 27291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006A9C RID: 27292
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006A9D RID: 27293
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006A9E RID: 27294
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006A9F RID: 27295
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_FinalizeCall_2166136261_Private_Void_0;

		// Token: 0x04006AA0 RID: 27296
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___FinalizeCall_2166136261_Private_Void_0;

		// Token: 0x04006AA1 RID: 27297
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_FinalizeCall_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006AA2 RID: 27298
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}

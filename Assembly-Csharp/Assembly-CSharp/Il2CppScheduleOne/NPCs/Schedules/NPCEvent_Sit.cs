using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x02000693 RID: 1683
	public class NPCEvent_Sit : NPCEvent
	{
		// Token: 0x0600A3F4 RID: 41972 RVA: 0x002B8FEC File Offset: 0x002B71EC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEvent_Sit()
		{
			Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCEvent_Sit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr);
			NPCEvent_Sit.NativeFieldInfoPtr_DESTINATION_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "DESTINATION_THRESHOLD");
			NPCEvent_Sit.NativeFieldInfoPtr_SeatSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "SeatSet");
			NPCEvent_Sit.NativeFieldInfoPtr_WarpIfSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "WarpIfSkipped");
			NPCEvent_Sit.NativeFieldInfoPtr_seated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "seated");
			NPCEvent_Sit.NativeFieldInfoPtr_targetSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "targetSeat");
			NPCEvent_Sit.NativeFieldInfoPtr_onSeated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "onSeated");
			NPCEvent_Sit.NativeFieldInfoPtr_onStandUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "onStandUp");
			NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted");
			NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted");
			NPCEvent_Sit.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100684993);
			NPCEvent_Sit.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100684994);
			NPCEvent_Sit.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100684995);
			NPCEvent_Sit.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100684996);
			NPCEvent_Sit.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100684997);
			NPCEvent_Sit.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100684998);
			NPCEvent_Sit.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100684999);
			NPCEvent_Sit.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685000);
			NPCEvent_Sit.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685001);
			NPCEvent_Sit.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685002);
			NPCEvent_Sit.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685003);
			NPCEvent_Sit.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685004);
			NPCEvent_Sit.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685005);
			NPCEvent_Sit.NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685006);
			NPCEvent_Sit.NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685007);
			NPCEvent_Sit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685008);
			NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685009);
			NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685010);
			NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685011);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Observers_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685012);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcLogic___StartAction_2681120339_Protected_Virtual_New_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685013);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Observers_StartAction_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685014);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Target_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685015);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Target_StartAction_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685016);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685017);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685018);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685019);
			NPCEvent_Sit.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100685020);
		}

		// Token: 0x17003160 RID: 12640
		// (get) Token: 0x0600A3F5 RID: 41973 RVA: 0x002B9300 File Offset: 0x002B7500
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287968, XrefRangeEnd = 287970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x002B9338 File Offset: 0x002B7538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287970, XrefRangeEnd = 287979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x002B937C File Offset: 0x002B757C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287979, XrefRangeEnd = 287985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x002B93B8 File Offset: 0x002B75B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287985, XrefRangeEnd = 287990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x002B9408 File Offset: 0x002B7608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287990, XrefRangeEnd = 287996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3FA RID: 41978 RVA: 0x002B9444 File Offset: 0x002B7644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287996, XrefRangeEnd = 288030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3FB RID: 41979 RVA: 0x002B9480 File Offset: 0x002B7680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288030, XrefRangeEnd = 288045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3FC RID: 41980 RVA: 0x002B94BC File Offset: 0x002B76BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288045, XrefRangeEnd = 288047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x002B94F8 File Offset: 0x002B76F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288047, XrefRangeEnd = 288051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x002B9534 File Offset: 0x002B7734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288051, XrefRangeEnd = 288057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3FF RID: 41983 RVA: 0x002B9570 File Offset: 0x002B7770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288057, XrefRangeEnd = 288062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A400 RID: 41984 RVA: 0x002B95AC File Offset: 0x002B77AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 288073, RefRangeEnd = 288079, XrefRangeStart = 288062, XrefRangeEnd = 288073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A401 RID: 41985 RVA: 0x002B95E8 File Offset: 0x002B77E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288079, XrefRangeEnd = 288086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A402 RID: 41986 RVA: 0x002B9634 File Offset: 0x002B7834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288086, XrefRangeEnd = 288127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartAction(NetworkConnection conn, int seatIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A403 RID: 41987 RVA: 0x002B9690 File Offset: 0x002B7890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288127, XrefRangeEnd = 288148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A404 RID: 41988 RVA: 0x002B96CC File Offset: 0x002B78CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEvent_Sit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A405 RID: 41989 RVA: 0x002B9708 File Offset: 0x002B7908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288148, XrefRangeEnd = 288168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A406 RID: 41990 RVA: 0x002B9744 File Offset: 0x002B7944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A407 RID: 41991 RVA: 0x002B9780 File Offset: 0x002B7980
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A408 RID: 41992 RVA: 0x002B97BC File Offset: 0x002B79BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288168, XrefRangeEnd = 288179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartAction_2681120339(NetworkConnection conn, int seatIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Observers_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A409 RID: 41993 RVA: 0x002B980C File Offset: 0x002B7A0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 288183, RefRangeEnd = 288186, XrefRangeStart = 288179, XrefRangeEnd = 288183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___StartAction_2681120339(NetworkConnection conn, int seatIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_RpcLogic___StartAction_2681120339_Protected_Virtual_New_Void_NetworkConnection_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A40A RID: 41994 RVA: 0x002B9868 File Offset: 0x002B7A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288186, XrefRangeEnd = 288191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartAction_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Observers_StartAction_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A40B RID: 41995 RVA: 0x002B98B8 File Offset: 0x002B7AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288191, XrefRangeEnd = 288202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_StartAction_2681120339(NetworkConnection conn, int seatIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Target_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x002B9908 File Offset: 0x002B7B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288202, XrefRangeEnd = 288207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_StartAction_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Target_StartAction_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A40D RID: 41997 RVA: 0x002B9958 File Offset: 0x002B7B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288207, XrefRangeEnd = 288216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x002B998C File Offset: 0x002B7B8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288218, RefRangeEnd = 288219, XrefRangeStart = 288216, XrefRangeEnd = 288218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___EndAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x002B99C8 File Offset: 0x002B7BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288219, XrefRangeEnd = 288222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A410 RID: 42000 RVA: 0x002B9A18 File Offset: 0x002B7C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A411 RID: 42001 RVA: 0x0004B123 File Offset: 0x00049323
		public NPCEvent_Sit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003157 RID: 12631
		// (get) Token: 0x0600A412 RID: 42002 RVA: 0x002B9A54 File Offset: 0x002B7C54
		// (set) Token: 0x0600A413 RID: 42003 RVA: 0x0004B12C File Offset: 0x0004932C
		public unsafe static float DESTINATION_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCEvent_Sit.NativeFieldInfoPtr_DESTINATION_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCEvent_Sit.NativeFieldInfoPtr_DESTINATION_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x0600A414 RID: 42004 RVA: 0x002B9A70 File Offset: 0x002B7C70
		// (set) Token: 0x0600A415 RID: 42005 RVA: 0x0004B13A File Offset: 0x0004933A
		public unsafe AvatarSeatSet SeatSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_SeatSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeatSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_SeatSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x0600A416 RID: 42006 RVA: 0x002B9AA0 File Offset: 0x002B7CA0
		// (set) Token: 0x0600A417 RID: 42007 RVA: 0x0004B159 File Offset: 0x00049359
		public unsafe bool WarpIfSkipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_WarpIfSkipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_WarpIfSkipped)) = value;
			}
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x0600A418 RID: 42008 RVA: 0x002B9AC8 File Offset: 0x002B7CC8
		// (set) Token: 0x0600A419 RID: 42009 RVA: 0x0004B174 File Offset: 0x00049374
		public unsafe bool seated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_seated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_seated)) = value;
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x0600A41A RID: 42010 RVA: 0x002B9AF0 File Offset: 0x002B7CF0
		// (set) Token: 0x0600A41B RID: 42011 RVA: 0x0004B18F File Offset: 0x0004938F
		public unsafe AvatarSeat targetSeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_targetSeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_targetSeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315C RID: 12636
		// (get) Token: 0x0600A41C RID: 42012 RVA: 0x002B9B20 File Offset: 0x002B7D20
		// (set) Token: 0x0600A41D RID: 42013 RVA: 0x0004B1AE File Offset: 0x000493AE
		public unsafe UnityEvent onSeated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_onSeated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_onSeated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315D RID: 12637
		// (get) Token: 0x0600A41E RID: 42014 RVA: 0x002B9B50 File Offset: 0x002B7D50
		// (set) Token: 0x0600A41F RID: 42015 RVA: 0x0004B1CD File Offset: 0x000493CD
		public unsafe UnityEvent onStandUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_onStandUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_onStandUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315E RID: 12638
		// (get) Token: 0x0600A420 RID: 42016 RVA: 0x002B9B80 File Offset: 0x002B7D80
		// (set) Token: 0x0600A421 RID: 42017 RVA: 0x0004B1EC File Offset: 0x000493EC
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700315F RID: 12639
		// (get) Token: 0x0600A422 RID: 42018 RVA: 0x002B9BA8 File Offset: 0x002B7DA8
		// (set) Token: 0x0600A423 RID: 42019 RVA: 0x0004B207 File Offset: 0x00049407
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400714F RID: 29007
		private static readonly IntPtr NativeFieldInfoPtr_DESTINATION_THRESHOLD;

		// Token: 0x04007150 RID: 29008
		private static readonly IntPtr NativeFieldInfoPtr_SeatSet;

		// Token: 0x04007151 RID: 29009
		private static readonly IntPtr NativeFieldInfoPtr_WarpIfSkipped;

		// Token: 0x04007152 RID: 29010
		private static readonly IntPtr NativeFieldInfoPtr_seated;

		// Token: 0x04007153 RID: 29011
		private static readonly IntPtr NativeFieldInfoPtr_targetSeat;

		// Token: 0x04007154 RID: 29012
		private static readonly IntPtr NativeFieldInfoPtr_onSeated;

		// Token: 0x04007155 RID: 29013
		private static readonly IntPtr NativeFieldInfoPtr_onStandUp;

		// Token: 0x04007156 RID: 29014
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007157 RID: 29015
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007158 RID: 29016
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x04007159 RID: 29017
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x0400715A RID: 29018
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x0400715B RID: 29019
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400715C RID: 29020
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x0400715D RID: 29021
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x0400715E RID: 29022
		private static readonly IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0;

		// Token: 0x0400715F RID: 29023
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x04007160 RID: 29024
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x04007161 RID: 29025
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04007162 RID: 29026
		private static readonly IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0;

		// Token: 0x04007163 RID: 29027
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04007164 RID: 29028
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x04007165 RID: 29029
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_Int32_0;

		// Token: 0x04007166 RID: 29030
		private static readonly IntPtr NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0;

		// Token: 0x04007167 RID: 29031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007168 RID: 29032
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007169 RID: 29033
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400716A RID: 29034
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400716B RID: 29035
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x0400716C RID: 29036
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartAction_2681120339_Protected_Virtual_New_Void_NetworkConnection_Int32_0;

		// Token: 0x0400716D RID: 29037
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartAction_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400716E RID: 29038
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x0400716F RID: 29039
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_StartAction_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007170 RID: 29040
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0;

		// Token: 0x04007171 RID: 29041
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x04007172 RID: 29042
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007173 RID: 29043
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}

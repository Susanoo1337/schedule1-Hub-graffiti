using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dragging
{
	// Token: 0x020003A2 RID: 930
	public class DragManager : NetworkSingleton<DragManager>
	{
		// Token: 0x06005494 RID: 21652 RVA: 0x0019FF70 File Offset: 0x0019E170
		// Note: this type is marked as 'beforefieldinit'.
		static DragManager()
		{
			Il2CppClassPointerStore<DragManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dragging", "DragManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragManager>.NativeClassPtr);
			DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DRAGGABLE_OFFSET");
			DragManager.NativeFieldInfoPtr_ThrowSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "ThrowSound");
			DragManager.NativeFieldInfoPtr_DragForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DragForce");
			DragManager.NativeFieldInfoPtr_DampingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "DampingFactor");
			DragManager.NativeFieldInfoPtr_TorqueForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "TorqueForce");
			DragManager.NativeFieldInfoPtr_TorqueDampingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "TorqueDampingFactor");
			DragManager.NativeFieldInfoPtr_ThrowForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "ThrowForce");
			DragManager.NativeFieldInfoPtr_MassInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "MassInfluence");
			DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "<CurrentDraggable>k__BackingField");
			DragManager.NativeFieldInfoPtr_AllDraggables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "AllDraggables");
			DragManager.NativeFieldInfoPtr_CurrentlyUpdating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "CurrentlyUpdating");
			DragManager.NativeFieldInfoPtr_lastThrownDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "lastThrownDraggable");
			DragManager.NativeFieldInfoPtr_lastHeldDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "lastHeldDraggable");
			DragManager.NativeFieldInfoPtr__dragStartedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "_dragStartedThisFrame");
			DragManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted");
			DragManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Dragging.DragManagerAssembly-CSharp.dll_Excuted");
			DragManager.NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674401);
			DragManager.NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674402);
			DragManager.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674403);
			DragManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674404);
			DragManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674405);
			DragManager.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674406);
			DragManager.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674407);
			DragManager.NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674408);
			DragManager.NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674409);
			DragManager.NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674410);
			DragManager.NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674411);
			DragManager.NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674412);
			DragManager.NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674413);
			DragManager.NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674414);
			DragManager.NativeMethodInfoPtr_SyncDraggable_Public_Void_Draggable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674415);
			DragManager.NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674416);
			DragManager.NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674417);
			DragManager.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674418);
			DragManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674419);
			DragManager.NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674420);
			DragManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674421);
			DragManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674422);
			DragManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674423);
			DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674424);
			DragManager.NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674425);
			DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674426);
			DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674427);
			DragManager.NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674428);
			DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674429);
			DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674430);
			DragManager.NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674431);
			DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674432);
			DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674433);
			DragManager.NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674434);
			DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674435);
			DragManager.NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674436);
			DragManager.NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674437);
			DragManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragManager>.NativeClassPtr, 100674438);
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06005495 RID: 21653 RVA: 0x001A03D8 File Offset: 0x0019E5D8
		// (set) Token: 0x06005496 RID: 21654 RVA: 0x001A0418 File Offset: 0x0019E618
		public unsafe Draggable CurrentDraggable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06005497 RID: 21655 RVA: 0x001A045C File Offset: 0x0019E65C
		public unsafe bool IsDragging
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 188337, RefRangeEnd = 188339, XrefRangeStart = 188333, XrefRangeEnd = 188337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x001A0498 File Offset: 0x0019E698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188339, XrefRangeEnd = 188366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x001A04E8 File Offset: 0x0019E6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188366, XrefRangeEnd = 188414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x001A051C File Offset: 0x0019E71C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188455, RefRangeEnd = 188456, XrefRangeStart = 188414, XrefRangeEnd = 188455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x001A0550 File Offset: 0x0019E750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188456, XrefRangeEnd = 188496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x001A0584 File Offset: 0x0019E784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188507, RefRangeEnd = 188509, XrefRangeStart = 188496, XrefRangeEnd = 188507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDraggingAllowed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x001A05C0 File Offset: 0x0019E7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188509, XrefRangeEnd = 188515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterDraggable(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x001A0604 File Offset: 0x0019E804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188515, XrefRangeEnd = 188521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deregister(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x001A0648 File Offset: 0x0019E848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188542, RefRangeEnd = 188543, XrefRangeStart = 188521, XrefRangeEnd = 188542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragging(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x001A068C File Offset: 0x0019E88C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188557, RefRangeEnd = 188559, XrefRangeStart = 188543, XrefRangeEnd = 188557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x001A06F0 File Offset: 0x0019E8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188559, XrefRangeEnd = 188573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragger(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054A2 RID: 21666 RVA: 0x001A0754 File Offset: 0x0019E954
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 188593, RefRangeEnd = 188596, XrefRangeStart = 188573, XrefRangeEnd = 188593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDragging(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x001A0794 File Offset: 0x0019E994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188596, XrefRangeEnd = 188609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncDraggable(Draggable draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(draggable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SyncDraggable_Public_Void_Draggable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x001A07D8 File Offset: 0x0019E9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188609, XrefRangeEnd = 188612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDraggableTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054A5 RID: 21669 RVA: 0x001A0844 File Offset: 0x0019EA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188612, XrefRangeEnd = 188613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggableTransformData(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054A6 RID: 21670 RVA: 0x001A08C4 File Offset: 0x0019EAC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188624, RefRangeEnd = 188626, XrefRangeStart = 188613, XrefRangeEnd = 188624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060054A7 RID: 21671 RVA: 0x001A0900 File Offset: 0x0019EB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188626, XrefRangeEnd = 188641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054A8 RID: 21672 RVA: 0x001A093C File Offset: 0x0019EB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188641, XrefRangeEnd = 188668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_NetworkConnection_PDM_0(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x001A0980 File Offset: 0x0019EB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188668, XrefRangeEnd = 188703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x001A09BC File Offset: 0x0019EBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188703, XrefRangeEnd = 188706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x001A09F8 File Offset: 0x0019EBF8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x001A0A34 File Offset: 0x0019EC34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188557, RefRangeEnd = 188559, XrefRangeStart = 188557, XrefRangeEnd = 188559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x001A0A98 File Offset: 0x0019EC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x001A0AFC File Offset: 0x0019ECFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188706, XrefRangeEnd = 188726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDragger_807933219(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054AF RID: 21679 RVA: 0x001A0B60 File Offset: 0x0019ED60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x001A0BC4 File Offset: 0x0019EDC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188762, RefRangeEnd = 188763, XrefRangeStart = 188726, XrefRangeEnd = 188762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDragger_807933219(string draggableGUID, NetworkObject dragger, Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(draggableGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x001A0C28 File Offset: 0x0019EE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188763, XrefRangeEnd = 188770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetDragger_807933219(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x001A0C78 File Offset: 0x0019EE78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 188798, RefRangeEnd = 188802, XrefRangeStart = 188770, XrefRangeEnd = 188798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x001A0CE4 File Offset: 0x0019EEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188802, XrefRangeEnd = 188804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDraggableTransformData_4062762274(string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x001A0D50 File Offset: 0x0019EF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188804, XrefRangeEnd = 188817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDraggableTransformData_4062762274(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x001A0DB4 File Offset: 0x0019EFB4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 188845, RefRangeEnd = 188852, XrefRangeStart = 188817, XrefRangeEnd = 188845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x001A0E34 File Offset: 0x0019F034
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 188882, RefRangeEnd = 188891, XrefRangeStart = 188852, XrefRangeEnd = 188882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x001A0EB4 File Offset: 0x0019F0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188891, XrefRangeEnd = 188903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x001A0F04 File Offset: 0x0019F104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188931, RefRangeEnd = 188933, XrefRangeStart = 188903, XrefRangeEnd = 188931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetDraggableTransformData_3831223955(NetworkConnection conn, string guid, Vector3 position, Quaternion rotation, Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x001A0F84 File Offset: 0x0019F184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188933, XrefRangeEnd = 188945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetDraggableTransformData_3831223955(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragManager.NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x001A0FD4 File Offset: 0x0019F1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188945, XrefRangeEnd = 188948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DragManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00027FA8 File Offset: 0x000261A8
		public DragManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x060054BC RID: 21692 RVA: 0x001A1010 File Offset: 0x0019F210
		// (set) Token: 0x060054BD RID: 21693 RVA: 0x00027FB1 File Offset: 0x000261B1
		public unsafe static float DRAGGABLE_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DragManager.NativeFieldInfoPtr_DRAGGABLE_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x060054BE RID: 21694 RVA: 0x001A102C File Offset: 0x0019F22C
		// (set) Token: 0x060054BF RID: 21695 RVA: 0x00027FBF File Offset: 0x000261BF
		public unsafe AudioSourceController ThrowSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x060054C0 RID: 21696 RVA: 0x001A105C File Offset: 0x0019F25C
		// (set) Token: 0x060054C1 RID: 21697 RVA: 0x00027FDE File Offset: 0x000261DE
		public unsafe float DragForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DragForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DragForce)) = value;
			}
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x060054C2 RID: 21698 RVA: 0x001A1084 File Offset: 0x0019F284
		// (set) Token: 0x060054C3 RID: 21699 RVA: 0x00027FF9 File Offset: 0x000261F9
		public unsafe float DampingFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DampingFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_DampingFactor)) = value;
			}
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x060054C4 RID: 21700 RVA: 0x001A10AC File Offset: 0x0019F2AC
		// (set) Token: 0x060054C5 RID: 21701 RVA: 0x00028014 File Offset: 0x00026214
		public unsafe float TorqueForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueForce)) = value;
			}
		}

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x060054C6 RID: 21702 RVA: 0x001A10D4 File Offset: 0x0019F2D4
		// (set) Token: 0x060054C7 RID: 21703 RVA: 0x0002802F File Offset: 0x0002622F
		public unsafe float TorqueDampingFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueDampingFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_TorqueDampingFactor)) = value;
			}
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x060054C8 RID: 21704 RVA: 0x001A10FC File Offset: 0x0019F2FC
		// (set) Token: 0x060054C9 RID: 21705 RVA: 0x0002804A File Offset: 0x0002624A
		public unsafe float ThrowForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_ThrowForce)) = value;
			}
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x060054CA RID: 21706 RVA: 0x001A1124 File Offset: 0x0019F324
		// (set) Token: 0x060054CB RID: 21707 RVA: 0x00028065 File Offset: 0x00026265
		public unsafe float MassInfluence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_MassInfluence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_MassInfluence)) = value;
			}
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x060054CC RID: 21708 RVA: 0x001A114C File Offset: 0x0019F34C
		// (set) Token: 0x060054CD RID: 21709 RVA: 0x00028080 File Offset: 0x00026280
		public unsafe Draggable _CurrentDraggable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr__CurrentDraggable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x060054CE RID: 21710 RVA: 0x001A117C File Offset: 0x0019F37C
		// (set) Token: 0x060054CF RID: 21711 RVA: 0x0002809F File Offset: 0x0002629F
		public unsafe List<Draggable> AllDraggables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_AllDraggables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Draggable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_AllDraggables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x060054D0 RID: 21712 RVA: 0x001A11AC File Offset: 0x0019F3AC
		// (set) Token: 0x060054D1 RID: 21713 RVA: 0x000280BE File Offset: 0x000262BE
		public unsafe List<Draggable> CurrentlyUpdating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_CurrentlyUpdating);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Draggable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_CurrentlyUpdating), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x060054D2 RID: 21714 RVA: 0x001A11DC File Offset: 0x0019F3DC
		// (set) Token: 0x060054D3 RID: 21715 RVA: 0x000280DD File Offset: 0x000262DD
		public unsafe Draggable lastThrownDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastThrownDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastThrownDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x060054D4 RID: 21716 RVA: 0x001A120C File Offset: 0x0019F40C
		// (set) Token: 0x060054D5 RID: 21717 RVA: 0x000280FC File Offset: 0x000262FC
		public unsafe Draggable lastHeldDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastHeldDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_lastHeldDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x060054D6 RID: 21718 RVA: 0x001A123C File Offset: 0x0019F43C
		// (set) Token: 0x060054D7 RID: 21719 RVA: 0x0002811B File Offset: 0x0002631B
		public unsafe bool _dragStartedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr__dragStartedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr__dragStartedThisFrame)) = value;
			}
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x060054D8 RID: 21720 RVA: 0x001A1264 File Offset: 0x0019F464
		// (set) Token: 0x060054D9 RID: 21721 RVA: 0x00028136 File Offset: 0x00026336
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x060054DA RID: 21722 RVA: 0x001A128C File Offset: 0x0019F48C
		// (set) Token: 0x060054DB RID: 21723 RVA: 0x00028151 File Offset: 0x00026351
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003A48 RID: 14920
		private static readonly IntPtr NativeFieldInfoPtr_DRAGGABLE_OFFSET;

		// Token: 0x04003A49 RID: 14921
		private static readonly IntPtr NativeFieldInfoPtr_ThrowSound;

		// Token: 0x04003A4A RID: 14922
		private static readonly IntPtr NativeFieldInfoPtr_DragForce;

		// Token: 0x04003A4B RID: 14923
		private static readonly IntPtr NativeFieldInfoPtr_DampingFactor;

		// Token: 0x04003A4C RID: 14924
		private static readonly IntPtr NativeFieldInfoPtr_TorqueForce;

		// Token: 0x04003A4D RID: 14925
		private static readonly IntPtr NativeFieldInfoPtr_TorqueDampingFactor;

		// Token: 0x04003A4E RID: 14926
		private static readonly IntPtr NativeFieldInfoPtr_ThrowForce;

		// Token: 0x04003A4F RID: 14927
		private static readonly IntPtr NativeFieldInfoPtr_MassInfluence;

		// Token: 0x04003A50 RID: 14928
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDraggable_k__BackingField;

		// Token: 0x04003A51 RID: 14929
		private static readonly IntPtr NativeFieldInfoPtr_AllDraggables;

		// Token: 0x04003A52 RID: 14930
		private static readonly IntPtr NativeFieldInfoPtr_CurrentlyUpdating;

		// Token: 0x04003A53 RID: 14931
		private static readonly IntPtr NativeFieldInfoPtr_lastThrownDraggable;

		// Token: 0x04003A54 RID: 14932
		private static readonly IntPtr NativeFieldInfoPtr_lastHeldDraggable;

		// Token: 0x04003A55 RID: 14933
		private static readonly IntPtr NativeFieldInfoPtr__dragStartedThisFrame;

		// Token: 0x04003A56 RID: 14934
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003A57 RID: 14935
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003A58 RID: 14936
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDraggable_Public_get_Draggable_0;

		// Token: 0x04003A59 RID: 14937
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDraggable_Protected_set_Void_Draggable_0;

		// Token: 0x04003A5A RID: 14938
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0;

		// Token: 0x04003A5B RID: 14939
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003A5C RID: 14940
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04003A5D RID: 14941
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04003A5E RID: 14942
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04003A5F RID: 14943
		private static readonly IntPtr NativeMethodInfoPtr_IsDraggingAllowed_Public_Boolean_0;

		// Token: 0x04003A60 RID: 14944
		private static readonly IntPtr NativeMethodInfoPtr_RegisterDraggable_Public_Void_Draggable_0;

		// Token: 0x04003A61 RID: 14945
		private static readonly IntPtr NativeMethodInfoPtr_Deregister_Public_Void_Draggable_0;

		// Token: 0x04003A62 RID: 14946
		private static readonly IntPtr NativeMethodInfoPtr_StartDragging_Public_Void_Draggable_0;

		// Token: 0x04003A63 RID: 14947
		private static readonly IntPtr NativeMethodInfoPtr_SendDragger_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003A64 RID: 14948
		private static readonly IntPtr NativeMethodInfoPtr_SetDragger_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003A65 RID: 14949
		private static readonly IntPtr NativeMethodInfoPtr_StopDragging_Public_Void_Vector3_0;

		// Token: 0x04003A66 RID: 14950
		private static readonly IntPtr NativeMethodInfoPtr_SyncDraggable_Public_Void_Draggable_0;

		// Token: 0x04003A67 RID: 14951
		private static readonly IntPtr NativeMethodInfoPtr_SendDraggableTransformData_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003A68 RID: 14952
		private static readonly IntPtr NativeMethodInfoPtr_SetDraggableTransformData_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003A69 RID: 14953
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetPosition_Private_Vector3_0;

		// Token: 0x04003A6A RID: 14954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003A6B RID: 14955
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_PDM_0;

		// Token: 0x04003A6C RID: 14956
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003A6D RID: 14957
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003A6E RID: 14958
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003A6F RID: 14959
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003A70 RID: 14960
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003A71 RID: 14961
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDragger_807933219_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003A72 RID: 14962
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003A73 RID: 14963
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDragger_807933219_Private_Void_String_NetworkObject_Vector3_0;

		// Token: 0x04003A74 RID: 14964
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetDragger_807933219_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A75 RID: 14965
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003A76 RID: 14966
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDraggableTransformData_4062762274_Private_Void_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003A77 RID: 14967
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDraggableTransformData_4062762274_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003A78 RID: 14968
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003A79 RID: 14969
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003A7A RID: 14970
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A7B RID: 14971
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetDraggableTransformData_3831223955_Private_Void_NetworkConnection_String_Vector3_Quaternion_Vector3_0;

		// Token: 0x04003A7C RID: 14972
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetDraggableTransformData_3831223955_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A7D RID: 14973
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}

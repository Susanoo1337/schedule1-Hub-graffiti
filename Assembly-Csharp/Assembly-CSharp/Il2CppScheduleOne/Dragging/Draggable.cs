using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dragging
{
	// Token: 0x020003A1 RID: 929
	public class Draggable : MonoBehaviour
	{
		// Token: 0x06005457 RID: 21591 RVA: 0x0019F424 File Offset: 0x0019D624
		// Note: this type is marked as 'beforefieldinit'.
		static Draggable()
		{
			Il2CppClassPointerStore<Draggable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dragging", "Draggable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Draggable>.NativeClassPtr);
			Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "INITIAL_REPLICATION_DISTANCE");
			Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "MAX_DRAG_START_RANGE");
			Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "MAX_TARGET_OFFSET");
			Draggable.NativeFieldInfoPtr_isBeingDragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "isBeingDragged");
			Draggable.NativeFieldInfoPtr_currentDragger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "currentDragger");
			Draggable.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<GUID>k__BackingField");
			Draggable.NativeFieldInfoPtr_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "Rigidbody");
			Draggable.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "IntObj");
			Draggable.NativeFieldInfoPtr_DragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragOrigin");
			Draggable.NativeFieldInfoPtr_CreateCoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "CreateCoM");
			Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "HoldDistanceMultiplier");
			Draggable.NativeFieldInfoPtr_DragForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragForceMultiplier");
			Draggable.NativeFieldInfoPtr_InitialReplicationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "InitialReplicationMode");
			Draggable.NativeFieldInfoPtr_onDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onDragStart");
			Draggable.NativeFieldInfoPtr_onDragEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onDragEnd");
			Draggable.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onHovered");
			Draggable.NativeFieldInfoPtr_onInteracted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onInteracted");
			Draggable.NativeFieldInfoPtr_timeSinceLastDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "timeSinceLastDrag");
			Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<initialPosition>k__BackingField");
			Draggable.NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674380);
			Draggable.NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674381);
			Draggable.NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674382);
			Draggable.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674383);
			Draggable.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674384);
			Draggable.NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674385);
			Draggable.NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674386);
			Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674387);
			Draggable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674388);
			Draggable.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674389);
			Draggable.NativeMethodInfoPtr_OnValidate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674390);
			Draggable.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674391);
			Draggable.NativeMethodInfoPtr_UpdateDraggable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674392);
			Draggable.NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674393);
			Draggable.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674394);
			Draggable.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674395);
			Draggable.NativeMethodInfoPtr_CanInteract_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674396);
			Draggable.NativeMethodInfoPtr_StartDragging_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674397);
			Draggable.NativeMethodInfoPtr_StopDragging_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674398);
			Draggable.NativeMethodInfoPtr_Sync_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674399);
			Draggable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100674400);
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06005458 RID: 21592 RVA: 0x0019F774 File Offset: 0x0019D974
		public unsafe bool IsBeingDragged
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x06005459 RID: 21593 RVA: 0x0019F7B0 File Offset: 0x0019D9B0
		// (set) Token: 0x0600545A RID: 21594 RVA: 0x0019F7F0 File Offset: 0x0019D9F0
		public unsafe Player CurrentDragger
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 188120, RefRangeEnd = 188126, XrefRangeStart = 188114, XrefRangeEnd = 188120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x0600545B RID: 21595 RVA: 0x0019F834 File Offset: 0x0019DA34
		// (set) Token: 0x0600545C RID: 21596 RVA: 0x0019F870 File Offset: 0x0019DA70
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x0600545D RID: 21597 RVA: 0x0019F8B0 File Offset: 0x0019DAB0
		// (set) Token: 0x0600545E RID: 21598 RVA: 0x0019F8EC File Offset: 0x0019DAEC
		public unsafe Vector3 initialPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600545F RID: 21599 RVA: 0x0019F92C File Offset: 0x0019DB2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188167, RefRangeEnd = 188168, XrefRangeStart = 188126, XrefRangeEnd = 188167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005460 RID: 21600 RVA: 0x0019F968 File Offset: 0x0019DB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188168, XrefRangeEnd = 188178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005461 RID: 21601 RVA: 0x0019F9A4 File Offset: 0x0019DBA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188183, RefRangeEnd = 188185, XrefRangeStart = 188178, XrefRangeEnd = 188183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x0019F9E4 File Offset: 0x0019DBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188185, XrefRangeEnd = 188200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_OnValidate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x0019FA18 File Offset: 0x0019DC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188200, XrefRangeEnd = 188224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x0019FA4C File Offset: 0x0019DC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188224, XrefRangeEnd = 188235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDraggable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_UpdateDraggable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x0019FA80 File Offset: 0x0019DC80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 188279, RefRangeEnd = 188282, XrefRangeStart = 188235, XrefRangeEnd = 188279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDragForces(Vector3 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x0019FAC0 File Offset: 0x0019DCC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188282, XrefRangeEnd = 188289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x0019FAFC File Offset: 0x0019DCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188289, XrefRangeEnd = 188296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x0019FB38 File Offset: 0x0019DD38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188307, RefRangeEnd = 188309, XrefRangeStart = 188296, XrefRangeEnd = 188307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_CanInteract_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x0019FB74 File Offset: 0x0019DD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188309, XrefRangeEnd = 188312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragging(Player dragger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_StartDragging_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x0019FBB8 File Offset: 0x0019DDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188312, XrefRangeEnd = 188315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDragging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_StopDragging_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x0019FBEC File Offset: 0x0019DDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188315, XrefRangeEnd = 188332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_Sync_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x0019FC20 File Offset: 0x0019DE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188332, XrefRangeEnd = 188333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Draggable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Draggable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x00027DA5 File Offset: 0x00025FA5
		public Draggable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x0600546E RID: 21614 RVA: 0x0019FC5C File Offset: 0x0019DE5C
		// (set) Token: 0x0600546F RID: 21615 RVA: 0x00027DAE File Offset: 0x00025FAE
		public unsafe static float INITIAL_REPLICATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x06005470 RID: 21616 RVA: 0x0019FC78 File Offset: 0x0019DE78
		// (set) Token: 0x06005471 RID: 21617 RVA: 0x00027DBC File Offset: 0x00025FBC
		public unsafe static float MAX_DRAG_START_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x06005472 RID: 21618 RVA: 0x0019FC94 File Offset: 0x0019DE94
		// (set) Token: 0x06005473 RID: 21619 RVA: 0x00027DCA File Offset: 0x00025FCA
		public unsafe static float MAX_TARGET_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x06005474 RID: 21620 RVA: 0x0019FCB0 File Offset: 0x0019DEB0
		// (set) Token: 0x06005475 RID: 21621 RVA: 0x00027DD8 File Offset: 0x00025FD8
		public unsafe bool isBeingDragged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_isBeingDragged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_isBeingDragged)) = value;
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06005476 RID: 21622 RVA: 0x0019FCD8 File Offset: 0x0019DED8
		// (set) Token: 0x06005477 RID: 21623 RVA: 0x00027DF3 File Offset: 0x00025FF3
		public unsafe Player currentDragger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_currentDragger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_currentDragger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06005478 RID: 21624 RVA: 0x0019FD08 File Offset: 0x0019DF08
		// (set) Token: 0x06005479 RID: 21625 RVA: 0x00027E12 File Offset: 0x00026012
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x0600547A RID: 21626 RVA: 0x0019FD30 File Offset: 0x0019DF30
		// (set) Token: 0x0600547B RID: 21627 RVA: 0x00027E2D File Offset: 0x0002602D
		public unsafe Rigidbody Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Rigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x0600547C RID: 21628 RVA: 0x0019FD60 File Offset: 0x0019DF60
		// (set) Token: 0x0600547D RID: 21629 RVA: 0x00027E4C File Offset: 0x0002604C
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x0600547E RID: 21630 RVA: 0x0019FD90 File Offset: 0x0019DF90
		// (set) Token: 0x0600547F RID: 21631 RVA: 0x00027E6B File Offset: 0x0002606B
		public unsafe Transform DragOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06005480 RID: 21632 RVA: 0x0019FDC0 File Offset: 0x0019DFC0
		// (set) Token: 0x06005481 RID: 21633 RVA: 0x00027E8A File Offset: 0x0002608A
		public unsafe bool CreateCoM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CreateCoM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CreateCoM)) = value;
			}
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06005482 RID: 21634 RVA: 0x0019FDE8 File Offset: 0x0019DFE8
		// (set) Token: 0x06005483 RID: 21635 RVA: 0x00027EA5 File Offset: 0x000260A5
		public unsafe float HoldDistanceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier)) = value;
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06005484 RID: 21636 RVA: 0x0019FE10 File Offset: 0x0019E010
		// (set) Token: 0x06005485 RID: 21637 RVA: 0x00027EC0 File Offset: 0x000260C0
		public unsafe float DragForceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceMultiplier)) = value;
			}
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06005486 RID: 21638 RVA: 0x0019FE38 File Offset: 0x0019E038
		// (set) Token: 0x06005487 RID: 21639 RVA: 0x00027EDB File Offset: 0x000260DB
		public unsafe Draggable.EInitialReplicationMode InitialReplicationMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_InitialReplicationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_InitialReplicationMode)) = value;
			}
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06005488 RID: 21640 RVA: 0x0019FE60 File Offset: 0x0019E060
		// (set) Token: 0x06005489 RID: 21641 RVA: 0x00027EF6 File Offset: 0x000260F6
		public unsafe UnityEvent onDragStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x0600548A RID: 21642 RVA: 0x0019FE90 File Offset: 0x0019E090
		// (set) Token: 0x0600548B RID: 21643 RVA: 0x00027F15 File Offset: 0x00026115
		public unsafe UnityEvent onDragEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x0600548C RID: 21644 RVA: 0x0019FEC0 File Offset: 0x0019E0C0
		// (set) Token: 0x0600548D RID: 21645 RVA: 0x00027F34 File Offset: 0x00026134
		public unsafe UnityEvent onHovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onHovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x0600548E RID: 21646 RVA: 0x0019FEF0 File Offset: 0x0019E0F0
		// (set) Token: 0x0600548F RID: 21647 RVA: 0x00027F53 File Offset: 0x00026153
		public unsafe UnityEvent onInteracted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onInteracted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onInteracted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06005490 RID: 21648 RVA: 0x0019FF20 File Offset: 0x0019E120
		// (set) Token: 0x06005491 RID: 21649 RVA: 0x00027F72 File Offset: 0x00026172
		public unsafe float timeSinceLastDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_timeSinceLastDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_timeSinceLastDrag)) = value;
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06005492 RID: 21650 RVA: 0x0019FF48 File Offset: 0x0019E148
		// (set) Token: 0x06005493 RID: 21651 RVA: 0x00027F8D File Offset: 0x0002618D
		public unsafe Vector3 _initialPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x04003A20 RID: 14880
		private static readonly IntPtr NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE;

		// Token: 0x04003A21 RID: 14881
		private static readonly IntPtr NativeFieldInfoPtr_MAX_DRAG_START_RANGE;

		// Token: 0x04003A22 RID: 14882
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TARGET_OFFSET;

		// Token: 0x04003A23 RID: 14883
		private static readonly IntPtr NativeFieldInfoPtr_isBeingDragged;

		// Token: 0x04003A24 RID: 14884
		private static readonly IntPtr NativeFieldInfoPtr_currentDragger;

		// Token: 0x04003A25 RID: 14885
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003A26 RID: 14886
		private static readonly IntPtr NativeFieldInfoPtr_Rigidbody;

		// Token: 0x04003A27 RID: 14887
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04003A28 RID: 14888
		private static readonly IntPtr NativeFieldInfoPtr_DragOrigin;

		// Token: 0x04003A29 RID: 14889
		private static readonly IntPtr NativeFieldInfoPtr_CreateCoM;

		// Token: 0x04003A2A RID: 14890
		private static readonly IntPtr NativeFieldInfoPtr_HoldDistanceMultiplier;

		// Token: 0x04003A2B RID: 14891
		private static readonly IntPtr NativeFieldInfoPtr_DragForceMultiplier;

		// Token: 0x04003A2C RID: 14892
		private static readonly IntPtr NativeFieldInfoPtr_InitialReplicationMode;

		// Token: 0x04003A2D RID: 14893
		private static readonly IntPtr NativeFieldInfoPtr_onDragStart;

		// Token: 0x04003A2E RID: 14894
		private static readonly IntPtr NativeFieldInfoPtr_onDragEnd;

		// Token: 0x04003A2F RID: 14895
		private static readonly IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x04003A30 RID: 14896
		private static readonly IntPtr NativeFieldInfoPtr_onInteracted;

		// Token: 0x04003A31 RID: 14897
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastDrag;

		// Token: 0x04003A32 RID: 14898
		private static readonly IntPtr NativeFieldInfoPtr__initialPosition_k__BackingField;

		// Token: 0x04003A33 RID: 14899
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0;

		// Token: 0x04003A34 RID: 14900
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0;

		// Token: 0x04003A35 RID: 14901
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0;

		// Token: 0x04003A36 RID: 14902
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003A37 RID: 14903
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003A38 RID: 14904
		private static readonly IntPtr NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0;

		// Token: 0x04003A39 RID: 14905
		private static readonly IntPtr NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0;

		// Token: 0x04003A3A RID: 14906
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003A3B RID: 14907
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04003A3C RID: 14908
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003A3D RID: 14909
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Void_0;

		// Token: 0x04003A3E RID: 14910
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

		// Token: 0x04003A3F RID: 14911
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDraggable_Public_Void_0;

		// Token: 0x04003A40 RID: 14912
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0;

		// Token: 0x04003A41 RID: 14913
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0;

		// Token: 0x04003A42 RID: 14914
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0;

		// Token: 0x04003A43 RID: 14915
		private static readonly IntPtr NativeMethodInfoPtr_CanInteract_Private_Boolean_0;

		// Token: 0x04003A44 RID: 14916
		private static readonly IntPtr NativeMethodInfoPtr_StartDragging_Public_Void_Player_0;

		// Token: 0x04003A45 RID: 14917
		private static readonly IntPtr NativeMethodInfoPtr_StopDragging_Public_Void_0;

		// Token: 0x04003A46 RID: 14918
		private static readonly IntPtr NativeMethodInfoPtr_Sync_Public_Void_0;

		// Token: 0x04003A47 RID: 14919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB5 RID: 2741
		[OriginalName("Assembly-CSharp.dll", "", "EInitialReplicationMode")]
		public enum EInitialReplicationMode
		{
			// Token: 0x04009A89 RID: 39561
			Off,
			// Token: 0x04009A8A RID: 39562
			OnlyIfMoved,
			// Token: 0x04009A8B RID: 39563
			Full
		}
	}
}

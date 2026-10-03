using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000544 RID: 1348
	public class SporeSyringeStationItem : StationItem
	{
		// Token: 0x06007B34 RID: 31540 RVA: 0x0022138C File Offset: 0x0021F58C
		// Note: this type is marked as 'beforefieldinit'.
		static SporeSyringeStationItem()
		{
			Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "SporeSyringeStationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr);
			SporeSyringeStationItem.NativeFieldInfoPtr_MaxAngleDifferenceForInjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "MaxAngleDifferenceForInjection");
			SporeSyringeStationItem.NativeFieldInfoPtr_PlungerPushSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "PlungerPushSpeed");
			SporeSyringeStationItem.NativeFieldInfoPtr_PlungerDragDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "PlungerDragDistanceMultiplier");
			SporeSyringeStationItem.NativeFieldInfoPtr__capHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_capHighlight");
			SporeSyringeStationItem.NativeFieldInfoPtr__capContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_capContainer");
			SporeSyringeStationItem.NativeFieldInfoPtr__capClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_capClickable");
			SporeSyringeStationItem.NativeFieldInfoPtr__syringeDraggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_syringeDraggable");
			SporeSyringeStationItem.NativeFieldInfoPtr__plungerHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_plungerHighlight");
			SporeSyringeStationItem.NativeFieldInfoPtr__plungerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_plungerTransform");
			SporeSyringeStationItem.NativeFieldInfoPtr__plungerExtendedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_plungerExtendedPosition");
			SporeSyringeStationItem.NativeFieldInfoPtr__plungerCompressedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_plungerCompressedPosition");
			SporeSyringeStationItem.NativeFieldInfoPtr__liquidTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_liquidTransform");
			SporeSyringeStationItem.NativeFieldInfoPtr__plungerClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_plungerClickable");
			SporeSyringeStationItem.NativeFieldInfoPtr__plungerSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_plungerSound");
			SporeSyringeStationItem.NativeFieldInfoPtr__injectionPortCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_injectionPortCollider");
			SporeSyringeStationItem.NativeFieldInfoPtr_onCapRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "onCapRemoved");
			SporeSyringeStationItem.NativeFieldInfoPtr_onInserted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "onInserted");
			SporeSyringeStationItem.NativeFieldInfoPtr_onPlungerMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "onPlungerMoved");
			SporeSyringeStationItem.NativeFieldInfoPtr__PlungerPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "<PlungerPosition>k__BackingField");
			SporeSyringeStationItem.NativeFieldInfoPtr__capRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_capRemoved");
			SporeSyringeStationItem.NativeFieldInfoPtr__initialPlungerHitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "_initialPlungerHitPoint");
			SporeSyringeStationItem.NativeFieldInfoPtr_timeOnPlungerClickStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "timeOnPlungerClickStart");
			SporeSyringeStationItem.NativeMethodInfoPtr_get_PlungerPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679130);
			SporeSyringeStationItem.NativeMethodInfoPtr_set_PlungerPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679131);
			SporeSyringeStationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679132);
			SporeSyringeStationItem.NativeMethodInfoPtr_Initialize_Public_Void_MushroomSpawnStation_MushroomSpawnStationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679133);
			SporeSyringeStationItem.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679134);
			SporeSyringeStationItem.NativeMethodInfoPtr_SetCapInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679135);
			SporeSyringeStationItem.NativeMethodInfoPtr_SetInjectionPortCollider_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679136);
			SporeSyringeStationItem.NativeMethodInfoPtr_RemoveCap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679137);
			SporeSyringeStationItem.NativeMethodInfoPtr_SetSyringeDraggable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679138);
			SporeSyringeStationItem.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679139);
			SporeSyringeStationItem.NativeMethodInfoPtr_InsertSyringe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679140);
			SporeSyringeStationItem.NativeMethodInfoPtr_SetPlungerInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679141);
			SporeSyringeStationItem.NativeMethodInfoPtr_SetPlungerPosition_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679142);
			SporeSyringeStationItem.NativeMethodInfoPtr_OnPlungerClickStart_Private_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679143);
			SporeSyringeStationItem.NativeMethodInfoPtr_OnPlungerClickEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679144);
			SporeSyringeStationItem.NativeMethodInfoPtr_GetPlungerPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679145);
			SporeSyringeStationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679146);
			SporeSyringeStationItem.NativeMethodInfoPtr__Awake_b__25_0_Private_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679147);
			SporeSyringeStationItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, 100679148);
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x06007B35 RID: 31541 RVA: 0x002216F0 File Offset: 0x0021F8F0
		// (set) Token: 0x06007B36 RID: 31542 RVA: 0x0022172C File Offset: 0x0021F92C
		public unsafe float PlungerPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_get_PlungerPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_set_PlungerPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x0022176C File Offset: 0x0021F96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235388, XrefRangeEnd = 235418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SporeSyringeStationItem.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x002217A8 File Offset: 0x0021F9A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235430, RefRangeEnd = 235431, XrefRangeStart = 235418, XrefRangeEnd = 235430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MushroomSpawnStation station, MushroomSpawnStationItem spawn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spawn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_Initialize_Public_Void_MushroomSpawnStation_MushroomSpawnStationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x002217FC File Offset: 0x0021F9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235431, XrefRangeEnd = 235469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x00221830 File Offset: 0x0021FA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235469, XrefRangeEnd = 235470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCapInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_SetCapInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x00221870 File Offset: 0x0021FA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInjectionPortCollider(Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_SetInjectionPortCollider_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3C RID: 31548 RVA: 0x002218B4 File Offset: 0x0021FAB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235490, RefRangeEnd = 235491, XrefRangeStart = 235470, XrefRangeEnd = 235490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_RemoveCap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x002218E8 File Offset: 0x0021FAE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 235496, RefRangeEnd = 235500, XrefRangeStart = 235491, XrefRangeEnd = 235496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSyringeDraggable(bool draggable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref draggable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_SetSyringeDraggable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x00221928 File Offset: 0x0021FB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235500, XrefRangeEnd = 235520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B3F RID: 31551 RVA: 0x0022196C File Offset: 0x0021FB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235520, XrefRangeEnd = 235528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertSyringe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_InsertSyringe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B40 RID: 31552 RVA: 0x002219A0 File Offset: 0x0021FBA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235528, RefRangeEnd = 235529, XrefRangeStart = 235528, XrefRangeEnd = 235528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlungerInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_SetPlungerInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x002219E0 File Offset: 0x0021FBE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 235538, RefRangeEnd = 235542, XrefRangeStart = 235529, XrefRangeEnd = 235538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlungerPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_SetPlungerPosition_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x00221A20 File Offset: 0x0021FC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235542, XrefRangeEnd = 235546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlungerClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_OnPlungerClickStart_Private_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x00221A60 File Offset: 0x0021FC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235546, XrefRangeEnd = 235548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlungerClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_OnPlungerClickEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x00221A94 File Offset: 0x0021FC94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 235569, RefRangeEnd = 235571, XrefRangeStart = 235548, XrefRangeEnd = 235569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlungerPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_GetPlungerPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x00221AD0 File Offset: 0x0021FCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SporeSyringeStationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B46 RID: 31558 RVA: 0x00221B0C File Offset: 0x0021FD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235571, XrefRangeEnd = 235572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__25_0(RaycastHit h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr__Awake_b__25_0_Private_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B47 RID: 31559 RVA: 0x00221B4C File Offset: 0x0021FD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235572, XrefRangeEnd = 235577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007B48 RID: 31560 RVA: 0x0003AA72 File Offset: 0x00038C72
		public SporeSyringeStationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x06007B49 RID: 31561 RVA: 0x00221B8C File Offset: 0x0021FD8C
		// (set) Token: 0x06007B4A RID: 31562 RVA: 0x0003AA7B File Offset: 0x00038C7B
		public unsafe static float MaxAngleDifferenceForInjection
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SporeSyringeStationItem.NativeFieldInfoPtr_MaxAngleDifferenceForInjection, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SporeSyringeStationItem.NativeFieldInfoPtr_MaxAngleDifferenceForInjection, (void*)(&value));
			}
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x06007B4B RID: 31563 RVA: 0x00221BA8 File Offset: 0x0021FDA8
		// (set) Token: 0x06007B4C RID: 31564 RVA: 0x0003AA89 File Offset: 0x00038C89
		public unsafe static float PlungerPushSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SporeSyringeStationItem.NativeFieldInfoPtr_PlungerPushSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SporeSyringeStationItem.NativeFieldInfoPtr_PlungerPushSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x06007B4D RID: 31565 RVA: 0x00221BC4 File Offset: 0x0021FDC4
		// (set) Token: 0x06007B4E RID: 31566 RVA: 0x0003AA97 File Offset: 0x00038C97
		public unsafe static float PlungerDragDistanceMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SporeSyringeStationItem.NativeFieldInfoPtr_PlungerDragDistanceMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SporeSyringeStationItem.NativeFieldInfoPtr_PlungerDragDistanceMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x06007B4F RID: 31567 RVA: 0x00221BE0 File Offset: 0x0021FDE0
		// (set) Token: 0x06007B50 RID: 31568 RVA: 0x0003AAA5 File Offset: 0x00038CA5
		public unsafe GameObject _capHighlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__capHighlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__capHighlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x06007B51 RID: 31569 RVA: 0x00221C10 File Offset: 0x0021FE10
		// (set) Token: 0x06007B52 RID: 31570 RVA: 0x0003AAC4 File Offset: 0x00038CC4
		public unsafe Transform _capContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__capContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__capContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x06007B53 RID: 31571 RVA: 0x00221C40 File Offset: 0x0021FE40
		// (set) Token: 0x06007B54 RID: 31572 RVA: 0x0003AAE3 File Offset: 0x00038CE3
		public unsafe Clickable _capClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__capClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__capClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x06007B55 RID: 31573 RVA: 0x00221C70 File Offset: 0x0021FE70
		// (set) Token: 0x06007B56 RID: 31574 RVA: 0x0003AB02 File Offset: 0x00038D02
		public unsafe Draggable _syringeDraggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__syringeDraggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__syringeDraggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x06007B57 RID: 31575 RVA: 0x00221CA0 File Offset: 0x0021FEA0
		// (set) Token: 0x06007B58 RID: 31576 RVA: 0x0003AB21 File Offset: 0x00038D21
		public unsafe GameObject _plungerHighlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerHighlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerHighlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x06007B59 RID: 31577 RVA: 0x00221CD0 File Offset: 0x0021FED0
		// (set) Token: 0x06007B5A RID: 31578 RVA: 0x0003AB40 File Offset: 0x00038D40
		public unsafe Transform _plungerTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x06007B5B RID: 31579 RVA: 0x00221D00 File Offset: 0x0021FF00
		// (set) Token: 0x06007B5C RID: 31580 RVA: 0x0003AB5F File Offset: 0x00038D5F
		public unsafe Transform _plungerExtendedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerExtendedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerExtendedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x06007B5D RID: 31581 RVA: 0x00221D30 File Offset: 0x0021FF30
		// (set) Token: 0x06007B5E RID: 31582 RVA: 0x0003AB7E File Offset: 0x00038D7E
		public unsafe Transform _plungerCompressedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerCompressedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerCompressedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x06007B5F RID: 31583 RVA: 0x00221D60 File Offset: 0x0021FF60
		// (set) Token: 0x06007B60 RID: 31584 RVA: 0x0003AB9D File Offset: 0x00038D9D
		public unsafe Transform _liquidTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__liquidTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__liquidTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262F RID: 9775
		// (get) Token: 0x06007B61 RID: 31585 RVA: 0x00221D90 File Offset: 0x0021FF90
		// (set) Token: 0x06007B62 RID: 31586 RVA: 0x0003ABBC File Offset: 0x00038DBC
		public unsafe Clickable _plungerClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002630 RID: 9776
		// (get) Token: 0x06007B63 RID: 31587 RVA: 0x00221DC0 File Offset: 0x0021FFC0
		// (set) Token: 0x06007B64 RID: 31588 RVA: 0x0003ABDB File Offset: 0x00038DDB
		public unsafe AudioSourceController _plungerSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__plungerSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002631 RID: 9777
		// (get) Token: 0x06007B65 RID: 31589 RVA: 0x00221DF0 File Offset: 0x0021FFF0
		// (set) Token: 0x06007B66 RID: 31590 RVA: 0x0003ABFA File Offset: 0x00038DFA
		public unsafe Collider _injectionPortCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__injectionPortCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__injectionPortCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x06007B67 RID: 31591 RVA: 0x00221E20 File Offset: 0x00220020
		// (set) Token: 0x06007B68 RID: 31592 RVA: 0x0003AC19 File Offset: 0x00038E19
		public unsafe UnityEvent onCapRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr_onCapRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr_onCapRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x06007B69 RID: 31593 RVA: 0x00221E50 File Offset: 0x00220050
		// (set) Token: 0x06007B6A RID: 31594 RVA: 0x0003AC38 File Offset: 0x00038E38
		public unsafe UnityEvent onInserted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr_onInserted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr_onInserted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x06007B6B RID: 31595 RVA: 0x00221E80 File Offset: 0x00220080
		// (set) Token: 0x06007B6C RID: 31596 RVA: 0x0003AC57 File Offset: 0x00038E57
		public unsafe UnityEvent<float> onPlungerMoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr_onPlungerMoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr_onPlungerMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x06007B6D RID: 31597 RVA: 0x00221EB0 File Offset: 0x002200B0
		// (set) Token: 0x06007B6E RID: 31598 RVA: 0x0003AC76 File Offset: 0x00038E76
		public unsafe float _PlungerPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__PlungerPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__PlungerPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x06007B6F RID: 31599 RVA: 0x00221ED8 File Offset: 0x002200D8
		// (set) Token: 0x06007B70 RID: 31600 RVA: 0x0003AC91 File Offset: 0x00038E91
		public unsafe bool _capRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__capRemoved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__capRemoved)) = value;
			}
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x06007B71 RID: 31601 RVA: 0x00221F00 File Offset: 0x00220100
		// (set) Token: 0x06007B72 RID: 31602 RVA: 0x0003ACAC File Offset: 0x00038EAC
		public unsafe Vector3 _initialPlungerHitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__initialPlungerHitPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr__initialPlungerHitPoint)) = value;
			}
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x06007B73 RID: 31603 RVA: 0x00221F28 File Offset: 0x00220128
		// (set) Token: 0x06007B74 RID: 31604 RVA: 0x0003ACC7 File Offset: 0x00038EC7
		public unsafe float timeOnPlungerClickStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr_timeOnPlungerClickStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.NativeFieldInfoPtr_timeOnPlungerClickStart)) = value;
			}
		}

		// Token: 0x040053FC RID: 21500
		private static readonly IntPtr NativeFieldInfoPtr_MaxAngleDifferenceForInjection;

		// Token: 0x040053FD RID: 21501
		private static readonly IntPtr NativeFieldInfoPtr_PlungerPushSpeed;

		// Token: 0x040053FE RID: 21502
		private static readonly IntPtr NativeFieldInfoPtr_PlungerDragDistanceMultiplier;

		// Token: 0x040053FF RID: 21503
		private static readonly IntPtr NativeFieldInfoPtr__capHighlight;

		// Token: 0x04005400 RID: 21504
		private static readonly IntPtr NativeFieldInfoPtr__capContainer;

		// Token: 0x04005401 RID: 21505
		private static readonly IntPtr NativeFieldInfoPtr__capClickable;

		// Token: 0x04005402 RID: 21506
		private static readonly IntPtr NativeFieldInfoPtr__syringeDraggable;

		// Token: 0x04005403 RID: 21507
		private static readonly IntPtr NativeFieldInfoPtr__plungerHighlight;

		// Token: 0x04005404 RID: 21508
		private static readonly IntPtr NativeFieldInfoPtr__plungerTransform;

		// Token: 0x04005405 RID: 21509
		private static readonly IntPtr NativeFieldInfoPtr__plungerExtendedPosition;

		// Token: 0x04005406 RID: 21510
		private static readonly IntPtr NativeFieldInfoPtr__plungerCompressedPosition;

		// Token: 0x04005407 RID: 21511
		private static readonly IntPtr NativeFieldInfoPtr__liquidTransform;

		// Token: 0x04005408 RID: 21512
		private static readonly IntPtr NativeFieldInfoPtr__plungerClickable;

		// Token: 0x04005409 RID: 21513
		private static readonly IntPtr NativeFieldInfoPtr__plungerSound;

		// Token: 0x0400540A RID: 21514
		private static readonly IntPtr NativeFieldInfoPtr__injectionPortCollider;

		// Token: 0x0400540B RID: 21515
		private static readonly IntPtr NativeFieldInfoPtr_onCapRemoved;

		// Token: 0x0400540C RID: 21516
		private static readonly IntPtr NativeFieldInfoPtr_onInserted;

		// Token: 0x0400540D RID: 21517
		private static readonly IntPtr NativeFieldInfoPtr_onPlungerMoved;

		// Token: 0x0400540E RID: 21518
		private static readonly IntPtr NativeFieldInfoPtr__PlungerPosition_k__BackingField;

		// Token: 0x0400540F RID: 21519
		private static readonly IntPtr NativeFieldInfoPtr__capRemoved;

		// Token: 0x04005410 RID: 21520
		private static readonly IntPtr NativeFieldInfoPtr__initialPlungerHitPoint;

		// Token: 0x04005411 RID: 21521
		private static readonly IntPtr NativeFieldInfoPtr_timeOnPlungerClickStart;

		// Token: 0x04005412 RID: 21522
		private static readonly IntPtr NativeMethodInfoPtr_get_PlungerPosition_Public_get_Single_0;

		// Token: 0x04005413 RID: 21523
		private static readonly IntPtr NativeMethodInfoPtr_set_PlungerPosition_Private_set_Void_Single_0;

		// Token: 0x04005414 RID: 21524
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005415 RID: 21525
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MushroomSpawnStation_MushroomSpawnStationItem_0;

		// Token: 0x04005416 RID: 21526
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005417 RID: 21527
		private static readonly IntPtr NativeMethodInfoPtr_SetCapInteractable_Public_Void_Boolean_0;

		// Token: 0x04005418 RID: 21528
		private static readonly IntPtr NativeMethodInfoPtr_SetInjectionPortCollider_Public_Void_Collider_0;

		// Token: 0x04005419 RID: 21529
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCap_Private_Void_0;

		// Token: 0x0400541A RID: 21530
		private static readonly IntPtr NativeMethodInfoPtr_SetSyringeDraggable_Public_Void_Boolean_0;

		// Token: 0x0400541B RID: 21531
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Public_Void_Collider_0;

		// Token: 0x0400541C RID: 21532
		private static readonly IntPtr NativeMethodInfoPtr_InsertSyringe_Private_Void_0;

		// Token: 0x0400541D RID: 21533
		private static readonly IntPtr NativeMethodInfoPtr_SetPlungerInteractable_Public_Void_Boolean_0;

		// Token: 0x0400541E RID: 21534
		private static readonly IntPtr NativeMethodInfoPtr_SetPlungerPosition_Private_Void_Single_0;

		// Token: 0x0400541F RID: 21535
		private static readonly IntPtr NativeMethodInfoPtr_OnPlungerClickStart_Private_Void_RaycastHit_0;

		// Token: 0x04005420 RID: 21536
		private static readonly IntPtr NativeMethodInfoPtr_OnPlungerClickEnd_Private_Void_0;

		// Token: 0x04005421 RID: 21537
		private static readonly IntPtr NativeMethodInfoPtr_GetPlungerPlaneHit_Private_Vector3_0;

		// Token: 0x04005422 RID: 21538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005423 RID: 21539
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__25_0_Private_Void_RaycastHit_0;

		// Token: 0x04005424 RID: 21540
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000BBB RID: 3003
		[ObfuscatedName("ScheduleOne.StationFramework.SporeSyringeStationItem+<<InsertSyringe>g__MoveSyringe|33_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600EB35 RID: 60213 RVA: 0x00391868 File Offset: 0x0038FA68
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique()
			{
				Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SporeSyringeStationItem>.NativeClassPtr, "<<InsertSyringe>g__MoveSyringe|33_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr);
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, "<>1__state");
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, "<>2__current");
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, "<>4__this");
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__duration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, "<duration>5__2");
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__elapsed_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, "<elapsed>5__3");
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__startPosition_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, "<startPosition>5__4");
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__targetPosition_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, "<targetPosition>5__5");
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, 100679149);
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, 100679150);
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, 100679151);
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, 100679152);
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, 100679153);
				SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr, 100679154);
			}

			// Token: 0x0600EB36 RID: 60214 RVA: 0x00391998 File Offset: 0x0038FB98
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB37 RID: 60215 RVA: 0x003919E0 File Offset: 0x0038FBE0
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB38 RID: 60216 RVA: 0x00391A14 File Offset: 0x0038FC14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235361, XrefRangeEnd = 235383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700475F RID: 18271
			// (get) Token: 0x0600EB39 RID: 60217 RVA: 0x00391A50 File Offset: 0x0038FC50
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EB3A RID: 60218 RVA: 0x00391A90 File Offset: 0x0038FC90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235383, XrefRangeEnd = 235388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004760 RID: 18272
			// (get) Token: 0x0600EB3B RID: 60219 RVA: 0x00391AC4 File Offset: 0x0038FCC4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EB3C RID: 60220 RVA: 0x0006EF44 File Offset: 0x0006D144
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004758 RID: 18264
			// (get) Token: 0x0600EB3D RID: 60221 RVA: 0x00391B04 File Offset: 0x0038FD04
			// (set) Token: 0x0600EB3E RID: 60222 RVA: 0x0006EF4D File Offset: 0x0006D14D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004759 RID: 18265
			// (get) Token: 0x0600EB3F RID: 60223 RVA: 0x00391B2C File Offset: 0x0038FD2C
			// (set) Token: 0x0600EB40 RID: 60224 RVA: 0x0006EF68 File Offset: 0x0006D168
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700475A RID: 18266
			// (get) Token: 0x0600EB41 RID: 60225 RVA: 0x00391B5C File Offset: 0x0038FD5C
			// (set) Token: 0x0600EB42 RID: 60226 RVA: 0x0006EF87 File Offset: 0x0006D187
			public unsafe SporeSyringeStationItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SporeSyringeStationItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700475B RID: 18267
			// (get) Token: 0x0600EB43 RID: 60227 RVA: 0x00391B8C File Offset: 0x0038FD8C
			// (set) Token: 0x0600EB44 RID: 60228 RVA: 0x0006EFA6 File Offset: 0x0006D1A6
			public unsafe float _duration_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__duration_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__duration_5__2)) = value;
				}
			}

			// Token: 0x1700475C RID: 18268
			// (get) Token: 0x0600EB45 RID: 60229 RVA: 0x00391BB4 File Offset: 0x0038FDB4
			// (set) Token: 0x0600EB46 RID: 60230 RVA: 0x0006EFC1 File Offset: 0x0006D1C1
			public unsafe float _elapsed_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__elapsed_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__elapsed_5__3)) = value;
				}
			}

			// Token: 0x1700475D RID: 18269
			// (get) Token: 0x0600EB47 RID: 60231 RVA: 0x00391BDC File Offset: 0x0038FDDC
			// (set) Token: 0x0600EB48 RID: 60232 RVA: 0x0006EFDC File Offset: 0x0006D1DC
			public unsafe Vector3 _startPosition_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__startPosition_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__startPosition_5__4)) = value;
				}
			}

			// Token: 0x1700475E RID: 18270
			// (get) Token: 0x0600EB49 RID: 60233 RVA: 0x00391C04 File Offset: 0x0038FE04
			// (set) Token: 0x0600EB4A RID: 60234 RVA: 0x0006EFF7 File Offset: 0x0006D1F7
			public unsafe Vector3 _targetPosition_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__targetPosition_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeStationItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpSiVeSiVeObObUnique.NativeFieldInfoPtr__targetPosition_5__5)) = value;
				}
			}

			// Token: 0x04009F62 RID: 40802
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009F63 RID: 40803
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009F64 RID: 40804
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009F65 RID: 40805
			private static readonly IntPtr NativeFieldInfoPtr__duration_5__2;

			// Token: 0x04009F66 RID: 40806
			private static readonly IntPtr NativeFieldInfoPtr__elapsed_5__3;

			// Token: 0x04009F67 RID: 40807
			private static readonly IntPtr NativeFieldInfoPtr__startPosition_5__4;

			// Token: 0x04009F68 RID: 40808
			private static readonly IntPtr NativeFieldInfoPtr__targetPosition_5__5;

			// Token: 0x04009F69 RID: 40809
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009F6A RID: 40810
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009F6B RID: 40811
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009F6C RID: 40812
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009F6D RID: 40813
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009F6E RID: 40814
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

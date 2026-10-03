using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.Police;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000685 RID: 1669
	public class SentryBehaviour : Behaviour
	{
		// Token: 0x0600A1EB RID: 41451 RVA: 0x002B1FF8 File Offset: 0x002B01F8
		// Note: this type is marked as 'beforefieldinit'.
		static SentryBehaviour()
		{
			Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "SentryBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr);
			SentryBehaviour.NativeFieldInfoPtr_BodySearchChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "BodySearchChance");
			SentryBehaviour.NativeFieldInfoPtr_FlashlightMinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "FlashlightMinTime");
			SentryBehaviour.NativeFieldInfoPtr_FlashlightMaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "FlashlightMaxTime");
			SentryBehaviour.NativeFieldInfoPtr_FlashlightAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "FlashlightAssetPath");
			SentryBehaviour.NativeFieldInfoPtr_AngularSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "AngularSpeedMultiplier");
			SentryBehaviour.NativeFieldInfoPtr_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "WalkSpeed");
			SentryBehaviour.NativeFieldInfoPtr_UseFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "UseFlashlight");
			SentryBehaviour.NativeFieldInfoPtr_flashlightEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "flashlightEquipped");
			SentryBehaviour.NativeFieldInfoPtr__AssignedLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "<AssignedLocation>k__BackingField");
			SentryBehaviour.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "officer");
			SentryBehaviour.NativeFieldInfoPtr__currentRoutePointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "_currentRoutePointIndex");
			SentryBehaviour.NativeFieldInfoPtr__minutesAtCurrentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "_minutesAtCurrentPoint");
			SentryBehaviour.NativeFieldInfoPtr__movementModifiersApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "_movementModifiersApplied");
			SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted");
			SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SentryBehaviourAssembly-CSharp.dll_Excuted");
			SentryBehaviour.NativeMethodInfoPtr_get_AssignedLocation_Public_get_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684723);
			SentryBehaviour.NativeMethodInfoPtr_set_AssignedLocation_Private_set_Void_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684724);
			SentryBehaviour.NativeMethodInfoPtr_get__currentRoute_Private_get_SentryRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684725);
			SentryBehaviour.NativeMethodInfoPtr_get__standPoint_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684726);
			SentryBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684727);
			SentryBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684728);
			SentryBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684729);
			SentryBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684730);
			SentryBehaviour.NativeMethodInfoPtr_AssignLocation_Public_Void_SentryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684731);
			SentryBehaviour.NativeMethodInfoPtr_UnassignLocation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684732);
			SentryBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684733);
			SentryBehaviour.NativeMethodInfoPtr_OnActiveUncappedMinutePass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684734);
			SentryBehaviour.NativeMethodInfoPtr_IsAtStandPoint_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684735);
			SentryBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684736);
			SentryBehaviour.NativeMethodInfoPtr_ApplyMovementModifiers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684737);
			SentryBehaviour.NativeMethodInfoPtr_RemoveMovementModifiers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684738);
			SentryBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684739);
			SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684740);
			SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684741);
			SentryBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684742);
			SentryBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr, 100684743);
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x0600A1EC RID: 41452 RVA: 0x002B22F8 File Offset: 0x002B04F8
		// (set) Token: 0x0600A1ED RID: 41453 RVA: 0x002B2338 File Offset: 0x002B0538
		public unsafe SentryLocation AssignedLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_get_AssignedLocation_Public_get_SentryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SentryLocation>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 140441, RefRangeEnd = 140444, XrefRangeStart = 140441, XrefRangeEnd = 140444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_set_AssignedLocation_Private_set_Void_SentryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x0600A1EE RID: 41454 RVA: 0x002B237C File Offset: 0x002B057C
		public unsafe SentryLocation.SentryRoute _currentRoute
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 285858, RefRangeEnd = 285864, XrefRangeStart = 285848, XrefRangeEnd = 285858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_get__currentRoute_Private_get_SentryRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SentryLocation.SentryRoute>(intPtr3) : null;
			}
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x0600A1EF RID: 41455 RVA: 0x002B23BC File Offset: 0x002B05BC
		public unsafe Transform _standPoint
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 285866, RefRangeEnd = 285867, XrefRangeStart = 285864, XrefRangeEnd = 285866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_get__standPoint_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x002B23FC File Offset: 0x002B05FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285867, XrefRangeEnd = 285874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x002B2438 File Offset: 0x002B0638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285874, XrefRangeEnd = 285883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x002B2474 File Offset: 0x002B0674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285883, XrefRangeEnd = 285890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x002B24B0 File Offset: 0x002B06B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x002B24EC File Offset: 0x002B06EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285908, RefRangeEnd = 285909, XrefRangeStart = 285890, XrefRangeEnd = 285908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignLocation(SentryLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_AssignLocation_Public_Void_SentryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F5 RID: 41461 RVA: 0x002B2530 File Offset: 0x002B0730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285917, RefRangeEnd = 285918, XrefRangeStart = 285909, XrefRangeEnd = 285917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_UnassignLocation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x002B2564 File Offset: 0x002B0764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285918, XrefRangeEnd = 285929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x002B25A0 File Offset: 0x002B07A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285929, XrefRangeEnd = 285951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveUncappedMinutePass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_OnActiveUncappedMinutePass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1F8 RID: 41464 RVA: 0x002B25DC File Offset: 0x002B07DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285962, RefRangeEnd = 285964, XrefRangeStart = 285951, XrefRangeEnd = 285962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtStandPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_IsAtStandPoint_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A1F9 RID: 41465 RVA: 0x002B2618 File Offset: 0x002B0818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285964, XrefRangeEnd = 285972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlashlightEquipped(bool equipped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref equipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1FA RID: 41466 RVA: 0x002B2658 File Offset: 0x002B0858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285972, XrefRangeEnd = 285981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMovementModifiers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_ApplyMovementModifiers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1FB RID: 41467 RVA: 0x002B268C File Offset: 0x002B088C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285986, RefRangeEnd = 285988, XrefRangeStart = 285981, XrefRangeEnd = 285986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveMovementModifiers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr_RemoveMovementModifiers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x002B26C0 File Offset: 0x002B08C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1FD RID: 41469 RVA: 0x002B26FC File Offset: 0x002B08FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285988, XrefRangeEnd = 285989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1FE RID: 41470 RVA: 0x002B2738 File Offset: 0x002B0938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285989, XrefRangeEnd = 285990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1FF RID: 41471 RVA: 0x002B2774 File Offset: 0x002B0974
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A200 RID: 41472 RVA: 0x002B27B0 File Offset: 0x002B09B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285990, XrefRangeEnd = 285997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SentryBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A201 RID: 41473 RVA: 0x0004A474 File Offset: 0x00048674
		public SentryBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x0600A202 RID: 41474 RVA: 0x002B27EC File Offset: 0x002B09EC
		// (set) Token: 0x0600A203 RID: 41475 RVA: 0x0004A47D File Offset: 0x0004867D
		public unsafe static float BodySearchChance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SentryBehaviour.NativeFieldInfoPtr_BodySearchChance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SentryBehaviour.NativeFieldInfoPtr_BodySearchChance, (void*)(&value));
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x0600A204 RID: 41476 RVA: 0x002B2808 File Offset: 0x002B0A08
		// (set) Token: 0x0600A205 RID: 41477 RVA: 0x0004A48B File Offset: 0x0004868B
		public unsafe static int FlashlightMinTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SentryBehaviour.NativeFieldInfoPtr_FlashlightMinTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SentryBehaviour.NativeFieldInfoPtr_FlashlightMinTime, (void*)(&value));
			}
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x0600A206 RID: 41478 RVA: 0x002B2824 File Offset: 0x002B0A24
		// (set) Token: 0x0600A207 RID: 41479 RVA: 0x0004A499 File Offset: 0x00048699
		public unsafe int FlashlightMaxTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_FlashlightMaxTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_FlashlightMaxTime)) = value;
			}
		}

		// Token: 0x170030D2 RID: 12498
		// (get) Token: 0x0600A208 RID: 41480 RVA: 0x002B284C File Offset: 0x002B0A4C
		// (set) Token: 0x0600A209 RID: 41481 RVA: 0x0004A4B4 File Offset: 0x000486B4
		public unsafe static string FlashlightAssetPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SentryBehaviour.NativeFieldInfoPtr_FlashlightAssetPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SentryBehaviour.NativeFieldInfoPtr_FlashlightAssetPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170030D3 RID: 12499
		// (get) Token: 0x0600A20A RID: 41482 RVA: 0x002B286C File Offset: 0x002B0A6C
		// (set) Token: 0x0600A20B RID: 41483 RVA: 0x0004A4C6 File Offset: 0x000486C6
		public unsafe static float AngularSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SentryBehaviour.NativeFieldInfoPtr_AngularSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SentryBehaviour.NativeFieldInfoPtr_AngularSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170030D4 RID: 12500
		// (get) Token: 0x0600A20C RID: 41484 RVA: 0x002B2888 File Offset: 0x002B0A88
		// (set) Token: 0x0600A20D RID: 41485 RVA: 0x0004A4D4 File Offset: 0x000486D4
		public unsafe static float WalkSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SentryBehaviour.NativeFieldInfoPtr_WalkSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SentryBehaviour.NativeFieldInfoPtr_WalkSpeed, (void*)(&value));
			}
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x0600A20E RID: 41486 RVA: 0x002B28A4 File Offset: 0x002B0AA4
		// (set) Token: 0x0600A20F RID: 41487 RVA: 0x0004A4E2 File Offset: 0x000486E2
		public unsafe bool UseFlashlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_UseFlashlight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_UseFlashlight)) = value;
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x0600A210 RID: 41488 RVA: 0x002B28CC File Offset: 0x002B0ACC
		// (set) Token: 0x0600A211 RID: 41489 RVA: 0x0004A4FD File Offset: 0x000486FD
		public unsafe bool flashlightEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_flashlightEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_flashlightEquipped)) = value;
			}
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x0600A212 RID: 41490 RVA: 0x002B28F4 File Offset: 0x002B0AF4
		// (set) Token: 0x0600A213 RID: 41491 RVA: 0x0004A518 File Offset: 0x00048718
		public unsafe SentryLocation _AssignedLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__AssignedLocation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SentryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__AssignedLocation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x0600A214 RID: 41492 RVA: 0x002B2924 File Offset: 0x002B0B24
		// (set) Token: 0x0600A215 RID: 41493 RVA: 0x0004A537 File Offset: 0x00048737
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x0600A216 RID: 41494 RVA: 0x002B2954 File Offset: 0x002B0B54
		// (set) Token: 0x0600A217 RID: 41495 RVA: 0x0004A556 File Offset: 0x00048756
		public unsafe int _currentRoutePointIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__currentRoutePointIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__currentRoutePointIndex)) = value;
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x0600A218 RID: 41496 RVA: 0x002B297C File Offset: 0x002B0B7C
		// (set) Token: 0x0600A219 RID: 41497 RVA: 0x0004A571 File Offset: 0x00048771
		public unsafe int _minutesAtCurrentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__minutesAtCurrentPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__minutesAtCurrentPoint)) = value;
			}
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x0600A21A RID: 41498 RVA: 0x002B29A4 File Offset: 0x002B0BA4
		// (set) Token: 0x0600A21B RID: 41499 RVA: 0x0004A58C File Offset: 0x0004878C
		public unsafe bool _movementModifiersApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__movementModifiersApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr__movementModifiersApplied)) = value;
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x0600A21C RID: 41500 RVA: 0x002B29CC File Offset: 0x002B0BCC
		// (set) Token: 0x0600A21D RID: 41501 RVA: 0x0004A5A7 File Offset: 0x000487A7
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x0600A21E RID: 41502 RVA: 0x002B29F4 File Offset: 0x002B0BF4
		// (set) Token: 0x0600A21F RID: 41503 RVA: 0x0004A5C2 File Offset: 0x000487C2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SentryBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006FDA RID: 28634
		private static readonly IntPtr NativeFieldInfoPtr_BodySearchChance;

		// Token: 0x04006FDB RID: 28635
		private static readonly IntPtr NativeFieldInfoPtr_FlashlightMinTime;

		// Token: 0x04006FDC RID: 28636
		private static readonly IntPtr NativeFieldInfoPtr_FlashlightMaxTime;

		// Token: 0x04006FDD RID: 28637
		private static readonly IntPtr NativeFieldInfoPtr_FlashlightAssetPath;

		// Token: 0x04006FDE RID: 28638
		private static readonly IntPtr NativeFieldInfoPtr_AngularSpeedMultiplier;

		// Token: 0x04006FDF RID: 28639
		private static readonly IntPtr NativeFieldInfoPtr_WalkSpeed;

		// Token: 0x04006FE0 RID: 28640
		private static readonly IntPtr NativeFieldInfoPtr_UseFlashlight;

		// Token: 0x04006FE1 RID: 28641
		private static readonly IntPtr NativeFieldInfoPtr_flashlightEquipped;

		// Token: 0x04006FE2 RID: 28642
		private static readonly IntPtr NativeFieldInfoPtr__AssignedLocation_k__BackingField;

		// Token: 0x04006FE3 RID: 28643
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04006FE4 RID: 28644
		private static readonly IntPtr NativeFieldInfoPtr__currentRoutePointIndex;

		// Token: 0x04006FE5 RID: 28645
		private static readonly IntPtr NativeFieldInfoPtr__minutesAtCurrentPoint;

		// Token: 0x04006FE6 RID: 28646
		private static readonly IntPtr NativeFieldInfoPtr__movementModifiersApplied;

		// Token: 0x04006FE7 RID: 28647
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006FE8 RID: 28648
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006FE9 RID: 28649
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedLocation_Public_get_SentryLocation_0;

		// Token: 0x04006FEA RID: 28650
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedLocation_Private_set_Void_SentryLocation_0;

		// Token: 0x04006FEB RID: 28651
		private static readonly IntPtr NativeMethodInfoPtr_get__currentRoute_Private_get_SentryRoute_0;

		// Token: 0x04006FEC RID: 28652
		private static readonly IntPtr NativeMethodInfoPtr_get__standPoint_Private_get_Transform_0;

		// Token: 0x04006FED RID: 28653
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006FEE RID: 28654
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04006FEF RID: 28655
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x04006FF0 RID: 28656
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04006FF1 RID: 28657
		private static readonly IntPtr NativeMethodInfoPtr_AssignLocation_Public_Void_SentryLocation_0;

		// Token: 0x04006FF2 RID: 28658
		private static readonly IntPtr NativeMethodInfoPtr_UnassignLocation_Public_Void_0;

		// Token: 0x04006FF3 RID: 28659
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x04006FF4 RID: 28660
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveUncappedMinutePass_Public_Virtual_Void_0;

		// Token: 0x04006FF5 RID: 28661
		private static readonly IntPtr NativeMethodInfoPtr_IsAtStandPoint_Private_Boolean_0;

		// Token: 0x04006FF6 RID: 28662
		private static readonly IntPtr NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0;

		// Token: 0x04006FF7 RID: 28663
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMovementModifiers_Private_Void_0;

		// Token: 0x04006FF8 RID: 28664
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMovementModifiers_Private_Void_0;

		// Token: 0x04006FF9 RID: 28665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006FFA RID: 28666
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006FFB RID: 28667
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006FFC RID: 28668
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006FFD RID: 28669
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}

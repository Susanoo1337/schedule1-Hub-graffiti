using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x0200019D RID: 413
	public class VisionEvent : Object
	{
		// Token: 0x060029E1 RID: 10721 RVA: 0x00105728 File Offset: 0x00103928
		// Note: this type is marked as 'beforefieldinit'.
		static VisionEvent()
		{
			Il2CppClassPointerStore<VisionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr);
			VisionEvent.NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "NOTICE_DROP_THRESHOLD");
			VisionEvent.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<Target>k__BackingField");
			VisionEvent.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<State>k__BackingField");
			VisionEvent.NativeFieldInfoPtr__Owner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<Owner>k__BackingField");
			VisionEvent.NativeFieldInfoPtr__FullNoticeTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<FullNoticeTime>k__BackingField");
			VisionEvent.NativeFieldInfoPtr_timeSinceSighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "timeSinceSighted");
			VisionEvent.NativeFieldInfoPtr_currentNoticeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "currentNoticeTime");
			VisionEvent.NativeFieldInfoPtr_playTremolo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "playTremolo");
			VisionEvent.NativeMethodInfoPtr_get_Target_Public_get_ISightable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668648);
			VisionEvent.NativeMethodInfoPtr_set_Target_Protected_set_Void_ISightable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668649);
			VisionEvent.NativeMethodInfoPtr_get_State_Public_get_EntityVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668650);
			VisionEvent.NativeMethodInfoPtr_set_State_Protected_set_Void_EntityVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668651);
			VisionEvent.NativeMethodInfoPtr_get_Owner_Public_get_VisionCone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668652);
			VisionEvent.NativeMethodInfoPtr_set_Owner_Protected_set_Void_VisionCone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668653);
			VisionEvent.NativeMethodInfoPtr_get_FullNoticeTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668654);
			VisionEvent.NativeMethodInfoPtr_set_FullNoticeTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668655);
			VisionEvent.NativeMethodInfoPtr_get_NormalizedNoticeLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668656);
			VisionEvent.NativeMethodInfoPtr__ctor_Public_Void_VisionCone_ISightable_EntityVisualState_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668657);
			VisionEvent.NativeMethodInfoPtr_UpdateEvent_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668658);
			VisionEvent.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100668659);
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x060029E2 RID: 10722 RVA: 0x001058E8 File Offset: 0x00103AE8
		// (set) Token: 0x060029E3 RID: 10723 RVA: 0x00105928 File Offset: 0x00103B28
		public unsafe ISightable Target
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_Target_Public_get_ISightable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISightable>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_Target_Protected_set_Void_ISightable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x060029E4 RID: 10724 RVA: 0x0010596C File Offset: 0x00103B6C
		// (set) Token: 0x060029E5 RID: 10725 RVA: 0x001059AC File Offset: 0x00103BAC
		public unsafe EntityVisualState State
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_State_Public_get_EntityVisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityVisualState>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_State_Protected_set_Void_EntityVisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x001059F0 File Offset: 0x00103BF0
		// (set) Token: 0x060029E7 RID: 10727 RVA: 0x00105A30 File Offset: 0x00103C30
		public unsafe VisionCone Owner
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_Owner_Public_get_VisionCone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisionCone>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_Owner_Protected_set_Void_VisionCone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x060029E8 RID: 10728 RVA: 0x00105A74 File Offset: 0x00103C74
		// (set) Token: 0x060029E9 RID: 10729 RVA: 0x00105AB0 File Offset: 0x00103CB0
		public unsafe float FullNoticeTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55725, RefRangeEnd = 55726, XrefRangeStart = 55725, XrefRangeEnd = 55726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_FullNoticeTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_FullNoticeTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x060029EA RID: 10730 RVA: 0x00105AF0 File Offset: 0x00103CF0
		public unsafe float NormalizedNoticeLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 123608, RefRangeEnd = 123609, XrefRangeStart = 123608, XrefRangeEnd = 123608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_NormalizedNoticeLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x00105B2C File Offset: 0x00103D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123627, RefRangeEnd = 123628, XrefRangeStart = 123609, XrefRangeEnd = 123627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEvent(VisionCone _owner, ISightable _target, EntityVisualState _state, float _noticeTime, bool _playTremolo) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_owner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _noticeTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _playTremolo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr__ctor_Public_Void_VisionCone_ISightable_EntityVisualState_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x00105BB8 File Offset: 0x00103DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123656, RefRangeEnd = 123657, XrefRangeStart = 123628, XrefRangeEnd = 123656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEvent(float visionDeltaThisFrame, float tickTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visionDeltaThisFrame;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tickTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_UpdateEvent_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00105C04 File Offset: 0x00103E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123663, RefRangeEnd = 123665, XrefRangeStart = 123657, XrefRangeEnd = 123663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x00015EE0 File Offset: 0x000140E0
		public VisionEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x060029EF RID: 10735 RVA: 0x00105C38 File Offset: 0x00103E38
		// (set) Token: 0x060029F0 RID: 10736 RVA: 0x00015EE9 File Offset: 0x000140E9
		public unsafe static float NOTICE_DROP_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionEvent.NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionEvent.NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x00105C54 File Offset: 0x00103E54
		// (set) Token: 0x060029F2 RID: 10738 RVA: 0x00015EF7 File Offset: 0x000140F7
		public unsafe ISightable _Target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISightable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x00105C84 File Offset: 0x00103E84
		// (set) Token: 0x060029F4 RID: 10740 RVA: 0x00015F16 File Offset: 0x00014116
		public unsafe EntityVisualState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__State_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityVisualState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__State_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x00105CB4 File Offset: 0x00103EB4
		// (set) Token: 0x060029F6 RID: 10742 RVA: 0x00015F35 File Offset: 0x00014135
		public unsafe VisionCone _Owner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Owner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Owner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x00105CE4 File Offset: 0x00103EE4
		// (set) Token: 0x060029F8 RID: 10744 RVA: 0x00015F54 File Offset: 0x00014154
		public unsafe float _FullNoticeTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__FullNoticeTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__FullNoticeTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x00105D0C File Offset: 0x00103F0C
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x00015F6F File Offset: 0x0001416F
		public unsafe float timeSinceSighted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_timeSinceSighted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_timeSinceSighted)) = value;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x00105D34 File Offset: 0x00103F34
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x00015F8A File Offset: 0x0001418A
		public unsafe float currentNoticeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_currentNoticeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_currentNoticeTime)) = value;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x00105D5C File Offset: 0x00103F5C
		// (set) Token: 0x060029FE RID: 10750 RVA: 0x00015FA5 File Offset: 0x000141A5
		public unsafe bool playTremolo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_playTremolo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_playTremolo)) = value;
			}
		}

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeFieldInfoPtr__Owner_k__BackingField;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeFieldInfoPtr__FullNoticeTime_k__BackingField;

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceSighted;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeFieldInfoPtr_currentNoticeTime;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeFieldInfoPtr_playTremolo;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_ISightable_0;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Protected_set_Void_ISightable_0;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EntityVisualState_0;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Protected_set_Void_EntityVisualState_0;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_get_VisionCone_0;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeMethodInfoPtr_set_Owner_Protected_set_Void_VisionCone_0;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeMethodInfoPtr_get_FullNoticeTime_Public_get_Single_0;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeMethodInfoPtr_set_FullNoticeTime_Protected_set_Void_Single_0;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedNoticeLevel_Public_get_Single_0;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VisionCone_ISightable_EntityVisualState_Single_Boolean_0;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEvent_Public_Void_Single_Single_0;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;
	}
}

using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004FE RID: 1278
	public class SmoothedVelocityCalculator : MonoBehaviour
	{
		// Token: 0x06007340 RID: 29504 RVA: 0x00205E14 File Offset: 0x00204014
		// Note: this type is marked as 'beforefieldinit'.
		static SmoothedVelocityCalculator()
		{
			Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SmoothedVelocityCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr);
			SmoothedVelocityCalculator.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "DEBUG");
			SmoothedVelocityCalculator.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "<Target>k__BackingField");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "SampleLength");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "MaxReasonableVelocity");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_sampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "sampleCount");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_velocityHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "velocityHistory");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_lastSamplePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "lastSamplePosition");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_timeOnLastSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "timeOnLastSample");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_timeSinceLastSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "timeSinceLastSample");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "zeroOut");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_isTargetValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "isTargetValid");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_sampleIntervalCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "sampleIntervalCached");
			SmoothedVelocityCalculator.NativeFieldInfoPtr_maxReasonableVelocitySqrCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "maxReasonableVelocitySqrCached");
			SmoothedVelocityCalculator.NativeMethodInfoPtr_get_Target_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678189);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_set_Target_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678190);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_get_Velocity_Public_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678191);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678192);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678193);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_LateUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678194);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_FlushBuffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678195);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678196);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678197);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_SetSampleLength_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678198);
			SmoothedVelocityCalculator.NativeMethodInfoPtr_SetMaxReasonableVelocity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678199);
			SmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, 100678200);
		}

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x06007341 RID: 29505 RVA: 0x00206038 File Offset: 0x00204238
		// (set) Token: 0x06007342 RID: 29506 RVA: 0x00206078 File Offset: 0x00204278
		public unsafe Transform Target
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_get_Target_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_set_Target_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002393 RID: 9107
		// (get) Token: 0x06007343 RID: 29507 RVA: 0x002060BC File Offset: 0x002042BC
		public unsafe virtual Vector3 Velocity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227336, XrefRangeEnd = 227342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmoothedVelocityCalculator.NativeMethodInfoPtr_get_Velocity_Public_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x00206104 File Offset: 0x00204304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227342, XrefRangeEnd = 227391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x00206138 File Offset: 0x00204338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227391, XrefRangeEnd = 227398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x0020616C File Offset: 0x0020436C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227398, XrefRangeEnd = 227430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_LateUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x002061A0 File Offset: 0x002043A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227438, RefRangeEnd = 227439, XrefRangeStart = 227430, XrefRangeEnd = 227438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_FlushBuffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x002061D4 File Offset: 0x002043D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227439, XrefRangeEnd = 227451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZeroOut(float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x00206214 File Offset: 0x00204414
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227464, RefRangeEnd = 227465, XrefRangeStart = 227451, XrefRangeEnd = 227464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600734A RID: 29514 RVA: 0x00206258 File Offset: 0x00204458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227465, RefRangeEnd = 227466, XrefRangeStart = 227465, XrefRangeEnd = 227465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSampleLength(float length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_SetSampleLength_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x00206298 File Offset: 0x00204498
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 227466, RefRangeEnd = 227468, XrefRangeStart = 227466, XrefRangeEnd = 227466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaxReasonableVelocity(float maxVelocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxVelocity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr_SetMaxReasonableVelocity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600734C RID: 29516 RVA: 0x002062D8 File Offset: 0x002044D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 227520, RefRangeEnd = 227521, XrefRangeStart = 227468, XrefRangeEnd = 227520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmoothedVelocityCalculator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600734D RID: 29517 RVA: 0x00036CBE File Offset: 0x00034EBE
		public SmoothedVelocityCalculator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x0600734E RID: 29518 RVA: 0x00206314 File Offset: 0x00204514
		// (set) Token: 0x0600734F RID: 29519 RVA: 0x00036CC7 File Offset: 0x00034EC7
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x06007350 RID: 29520 RVA: 0x0020633C File Offset: 0x0020453C
		// (set) Token: 0x06007351 RID: 29521 RVA: 0x00036CE2 File Offset: 0x00034EE2
		public unsafe Transform _Target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr__Target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x06007352 RID: 29522 RVA: 0x0020636C File Offset: 0x0020456C
		// (set) Token: 0x06007353 RID: 29523 RVA: 0x00036D01 File Offset: 0x00034F01
		public unsafe float SampleLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_SampleLength)) = value;
			}
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x06007354 RID: 29524 RVA: 0x00206394 File Offset: 0x00204594
		// (set) Token: 0x06007355 RID: 29525 RVA: 0x00036D1C File Offset: 0x00034F1C
		public unsafe float MaxReasonableVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_MaxReasonableVelocity)) = value;
			}
		}

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x06007356 RID: 29526 RVA: 0x002063BC File Offset: 0x002045BC
		// (set) Token: 0x06007357 RID: 29527 RVA: 0x00036D37 File Offset: 0x00034F37
		public unsafe int sampleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_sampleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_sampleCount)) = value;
			}
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x06007358 RID: 29528 RVA: 0x002063E4 File Offset: 0x002045E4
		// (set) Token: 0x06007359 RID: 29529 RVA: 0x00036D52 File Offset: 0x00034F52
		public unsafe RollingAverage<Vector3> velocityHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_velocityHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RollingAverage<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_velocityHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700238B RID: 9099
		// (get) Token: 0x0600735A RID: 29530 RVA: 0x00206414 File Offset: 0x00204614
		// (set) Token: 0x0600735B RID: 29531 RVA: 0x00036D71 File Offset: 0x00034F71
		public unsafe Vector3 lastSamplePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_lastSamplePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_lastSamplePosition)) = value;
			}
		}

		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x0600735C RID: 29532 RVA: 0x0020643C File Offset: 0x0020463C
		// (set) Token: 0x0600735D RID: 29533 RVA: 0x00036D8C File Offset: 0x00034F8C
		public unsafe float timeOnLastSample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_timeOnLastSample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_timeOnLastSample)) = value;
			}
		}

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x0600735E RID: 29534 RVA: 0x00206464 File Offset: 0x00204664
		// (set) Token: 0x0600735F RID: 29535 RVA: 0x00036DA7 File Offset: 0x00034FA7
		public unsafe float timeSinceLastSample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_timeSinceLastSample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_timeSinceLastSample)) = value;
			}
		}

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x06007360 RID: 29536 RVA: 0x0020648C File Offset: 0x0020468C
		// (set) Token: 0x06007361 RID: 29537 RVA: 0x00036DC2 File Offset: 0x00034FC2
		public unsafe bool zeroOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_zeroOut)) = value;
			}
		}

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x06007362 RID: 29538 RVA: 0x002064B4 File Offset: 0x002046B4
		// (set) Token: 0x06007363 RID: 29539 RVA: 0x00036DDD File Offset: 0x00034FDD
		public unsafe bool isTargetValid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_isTargetValid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_isTargetValid)) = value;
			}
		}

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x06007364 RID: 29540 RVA: 0x002064DC File Offset: 0x002046DC
		// (set) Token: 0x06007365 RID: 29541 RVA: 0x00036DF8 File Offset: 0x00034FF8
		public unsafe float sampleIntervalCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_sampleIntervalCached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_sampleIntervalCached)) = value;
			}
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x06007366 RID: 29542 RVA: 0x00206504 File Offset: 0x00204704
		// (set) Token: 0x06007367 RID: 29543 RVA: 0x00036E13 File Offset: 0x00035013
		public unsafe float maxReasonableVelocitySqrCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_maxReasonableVelocitySqrCached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.NativeFieldInfoPtr_maxReasonableVelocitySqrCached)) = value;
			}
		}

		// Token: 0x04004EA7 RID: 20135
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04004EA8 RID: 20136
		private static readonly IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x04004EA9 RID: 20137
		private static readonly IntPtr NativeFieldInfoPtr_SampleLength;

		// Token: 0x04004EAA RID: 20138
		private static readonly IntPtr NativeFieldInfoPtr_MaxReasonableVelocity;

		// Token: 0x04004EAB RID: 20139
		private static readonly IntPtr NativeFieldInfoPtr_sampleCount;

		// Token: 0x04004EAC RID: 20140
		private static readonly IntPtr NativeFieldInfoPtr_velocityHistory;

		// Token: 0x04004EAD RID: 20141
		private static readonly IntPtr NativeFieldInfoPtr_lastSamplePosition;

		// Token: 0x04004EAE RID: 20142
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastSample;

		// Token: 0x04004EAF RID: 20143
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastSample;

		// Token: 0x04004EB0 RID: 20144
		private static readonly IntPtr NativeFieldInfoPtr_zeroOut;

		// Token: 0x04004EB1 RID: 20145
		private static readonly IntPtr NativeFieldInfoPtr_isTargetValid;

		// Token: 0x04004EB2 RID: 20146
		private static readonly IntPtr NativeFieldInfoPtr_sampleIntervalCached;

		// Token: 0x04004EB3 RID: 20147
		private static readonly IntPtr NativeFieldInfoPtr_maxReasonableVelocitySqrCached;

		// Token: 0x04004EB4 RID: 20148
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Transform_0;

		// Token: 0x04004EB5 RID: 20149
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Private_set_Void_Transform_0;

		// Token: 0x04004EB6 RID: 20150
		private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_Virtual_New_get_Vector3_0;

		// Token: 0x04004EB7 RID: 20151
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004EB8 RID: 20152
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004EB9 RID: 20153
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Void_0;

		// Token: 0x04004EBA RID: 20154
		private static readonly IntPtr NativeMethodInfoPtr_FlushBuffer_Public_Void_0;

		// Token: 0x04004EBB RID: 20155
		private static readonly IntPtr NativeMethodInfoPtr_ZeroOut_Public_Void_Single_0;

		// Token: 0x04004EBC RID: 20156
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0;

		// Token: 0x04004EBD RID: 20157
		private static readonly IntPtr NativeMethodInfoPtr_SetSampleLength_Public_Void_Single_0;

		// Token: 0x04004EBE RID: 20158
		private static readonly IntPtr NativeMethodInfoPtr_SetMaxReasonableVelocity_Public_Void_Single_0;

		// Token: 0x04004EBF RID: 20159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BA3 RID: 2979
		[ObfuscatedName("ScheduleOne.Tools.SmoothedVelocityCalculator+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EA4B RID: 59979 RVA: 0x0038ED5C File Offset: 0x0038CF5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr);
				SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, "<>9");
				SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, "<>9__18_0");
				SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, "<>9__18_1");
				SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__18_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, "<>9__18_2");
				SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, "<>9__26_0");
				SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__26_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, "<>9__26_1");
				SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__26_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, "<>9__26_2");
				SmoothedVelocityCalculator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, 100678202);
				SmoothedVelocityCalculator.__c.NativeMethodInfoPtr__Awake_b__18_0_Internal_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, 100678203);
				SmoothedVelocityCalculator.__c.NativeMethodInfoPtr__Awake_b__18_1_Internal_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, 100678204);
				SmoothedVelocityCalculator.__c.NativeMethodInfoPtr__Awake_b__18_2_Internal_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, 100678205);
				SmoothedVelocityCalculator.__c.NativeMethodInfoPtr___ctor_b__26_0_Internal_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, 100678206);
				SmoothedVelocityCalculator.__c.NativeMethodInfoPtr___ctor_b__26_1_Internal_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, 100678207);
				SmoothedVelocityCalculator.__c.NativeMethodInfoPtr___ctor_b__26_2_Internal_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr, 100678208);
			}

			// Token: 0x0600EA4C RID: 59980 RVA: 0x0038EEA0 File Offset: 0x0038D0A0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA4D RID: 59981 RVA: 0x0038EEDC File Offset: 0x0038D0DC
			[CallerCount(0)]
			public unsafe Vector3 _Awake_b__18_0(Vector3 a, Vector3 b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c.NativeMethodInfoPtr__Awake_b__18_0_Internal_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA4E RID: 59982 RVA: 0x0038EF34 File Offset: 0x0038D134
			[CallerCount(0)]
			public unsafe Vector3 _Awake_b__18_1(Vector3 a, Vector3 b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c.NativeMethodInfoPtr__Awake_b__18_1_Internal_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA4F RID: 59983 RVA: 0x0038EF8C File Offset: 0x0038D18C
			[CallerCount(0)]
			public unsafe Vector3 _Awake_b__18_2(Vector3 a, float c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c.NativeMethodInfoPtr__Awake_b__18_2_Internal_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA50 RID: 59984 RVA: 0x0038EFE4 File Offset: 0x0038D1E4
			[CallerCount(0)]
			public unsafe Vector3 __ctor_b__26_0(Vector3 a, Vector3 b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c.NativeMethodInfoPtr___ctor_b__26_0_Internal_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA51 RID: 59985 RVA: 0x0038F03C File Offset: 0x0038D23C
			[CallerCount(0)]
			public unsafe Vector3 __ctor_b__26_1(Vector3 a, Vector3 b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c.NativeMethodInfoPtr___ctor_b__26_1_Internal_Vector3_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA52 RID: 59986 RVA: 0x0038F094 File Offset: 0x0038D294
			[CallerCount(0)]
			public unsafe Vector3 __ctor_b__26_2(Vector3 a, float c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c.NativeMethodInfoPtr___ctor_b__26_2_Internal_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA53 RID: 59987 RVA: 0x0006E865 File Offset: 0x0006CA65
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004711 RID: 18193
			// (get) Token: 0x0600EA54 RID: 59988 RVA: 0x0038F0EC File Offset: 0x0038D2EC
			// (set) Token: 0x0600EA55 RID: 59989 RVA: 0x0006E86E File Offset: 0x0006CA6E
			public unsafe static SmoothedVelocityCalculator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004712 RID: 18194
			// (get) Token: 0x0600EA56 RID: 59990 RVA: 0x0038F114 File Offset: 0x0038D314
			// (set) Token: 0x0600EA57 RID: 59991 RVA: 0x0006E880 File Offset: 0x0006CA80
			public unsafe static Func<Vector3, Vector3, Vector3> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004713 RID: 18195
			// (get) Token: 0x0600EA58 RID: 59992 RVA: 0x0038F13C File Offset: 0x0038D33C
			// (set) Token: 0x0600EA59 RID: 59993 RVA: 0x0006E892 File Offset: 0x0006CA92
			public unsafe static Func<Vector3, Vector3, Vector3> __9__18_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004714 RID: 18196
			// (get) Token: 0x0600EA5A RID: 59994 RVA: 0x0038F164 File Offset: 0x0038D364
			// (set) Token: 0x0600EA5B RID: 59995 RVA: 0x0006E8A4 File Offset: 0x0006CAA4
			public unsafe static Func<Vector3, float, Vector3> __9__18_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__18_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__18_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004715 RID: 18197
			// (get) Token: 0x0600EA5C RID: 59996 RVA: 0x0038F18C File Offset: 0x0038D38C
			// (set) Token: 0x0600EA5D RID: 59997 RVA: 0x0006E8B6 File Offset: 0x0006CAB6
			public unsafe static Func<Vector3, Vector3, Vector3> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004716 RID: 18198
			// (get) Token: 0x0600EA5E RID: 59998 RVA: 0x0038F1B4 File Offset: 0x0038D3B4
			// (set) Token: 0x0600EA5F RID: 59999 RVA: 0x0006E8C8 File Offset: 0x0006CAC8
			public unsafe static Func<Vector3, Vector3, Vector3> __9__26_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__26_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector3, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__26_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004717 RID: 18199
			// (get) Token: 0x0600EA60 RID: 60000 RVA: 0x0038F1DC File Offset: 0x0038D3DC
			// (set) Token: 0x0600EA61 RID: 60001 RVA: 0x0006E8DA File Offset: 0x0006CADA
			public unsafe static Func<Vector3, float, Vector3> __9__26_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__26_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float, Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SmoothedVelocityCalculator.__c.NativeFieldInfoPtr___9__26_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009ED1 RID: 40657
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009ED2 RID: 40658
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04009ED3 RID: 40659
			private static readonly IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x04009ED4 RID: 40660
			private static readonly IntPtr NativeFieldInfoPtr___9__18_2;

			// Token: 0x04009ED5 RID: 40661
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04009ED6 RID: 40662
			private static readonly IntPtr NativeFieldInfoPtr___9__26_1;

			// Token: 0x04009ED7 RID: 40663
			private static readonly IntPtr NativeFieldInfoPtr___9__26_2;

			// Token: 0x04009ED8 RID: 40664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009ED9 RID: 40665
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__18_0_Internal_Vector3_Vector3_Vector3_0;

			// Token: 0x04009EDA RID: 40666
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__18_1_Internal_Vector3_Vector3_Vector3_0;

			// Token: 0x04009EDB RID: 40667
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__18_2_Internal_Vector3_Vector3_Single_0;

			// Token: 0x04009EDC RID: 40668
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__26_0_Internal_Vector3_Vector3_Vector3_0;

			// Token: 0x04009EDD RID: 40669
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__26_1_Internal_Vector3_Vector3_Vector3_0;

			// Token: 0x04009EDE RID: 40670
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__26_2_Internal_Vector3_Vector3_Single_0;
		}

		// Token: 0x02000BA4 RID: 2980
		[ObfuscatedName("ScheduleOne.Tools.SmoothedVelocityCalculator+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EA62 RID: 60002 RVA: 0x0038F204 File Offset: 0x0038D404
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmoothedVelocityCalculator>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0>.NativeClassPtr);
				SmoothedVelocityCalculator.__c__DisplayClass22_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0>.NativeClassPtr, "duration");
				SmoothedVelocityCalculator.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				SmoothedVelocityCalculator.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0>.NativeClassPtr, 100678209);
				SmoothedVelocityCalculator.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0>.NativeClassPtr, 100678210);
			}

			// Token: 0x0600EA63 RID: 60003 RVA: 0x0038F280 File Offset: 0x0038D480
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA64 RID: 60004 RVA: 0x0038F2BC File Offset: 0x0038D4BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227331, XrefRangeEnd = 227336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EA65 RID: 60005 RVA: 0x0006E8EC File Offset: 0x0006CAEC
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004718 RID: 18200
			// (get) Token: 0x0600EA66 RID: 60006 RVA: 0x0038F2FC File Offset: 0x0038D4FC
			// (set) Token: 0x0600EA67 RID: 60007 RVA: 0x0006E8F5 File Offset: 0x0006CAF5
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass22_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass22_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004719 RID: 18201
			// (get) Token: 0x0600EA68 RID: 60008 RVA: 0x0038F324 File Offset: 0x0038D524
			// (set) Token: 0x0600EA69 RID: 60009 RVA: 0x0006E910 File Offset: 0x0006CB10
			public unsafe SmoothedVelocityCalculator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009EDF RID: 40671
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04009EE0 RID: 40672
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009EE1 RID: 40673
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009EE2 RID: 40674
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DE8 RID: 3560
			[ObfuscatedName("ScheduleOne.Tools.SmoothedVelocityCalculator+<>c__DisplayClass22_0+<<ZeroOut>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060100D0 RID: 65744 RVA: 0x003CFF88 File Offset: 0x003CE188
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0>.NativeClassPtr, "<<ZeroOut>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678211);
					SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678212);
					SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678213);
					SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678214);
					SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678215);
					SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678216);
				}

				// Token: 0x060100D1 RID: 65745 RVA: 0x003D0068 File Offset: 0x003CE268
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100D2 RID: 65746 RVA: 0x003D00B0 File Offset: 0x003CE2B0
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100D3 RID: 65747 RVA: 0x003D00E4 File Offset: 0x003CE2E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227321, XrefRangeEnd = 227326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E4A RID: 20042
				// (get) Token: 0x060100D4 RID: 65748 RVA: 0x003D0120 File Offset: 0x003CE320
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100D5 RID: 65749 RVA: 0x003D0160 File Offset: 0x003CE360
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227326, XrefRangeEnd = 227331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E4B RID: 20043
				// (get) Token: 0x060100D6 RID: 65750 RVA: 0x003D0194 File Offset: 0x003CE394
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100D7 RID: 65751 RVA: 0x00079BA9 File Offset: 0x00077DA9
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E47 RID: 20039
				// (get) Token: 0x060100D8 RID: 65752 RVA: 0x003D01D4 File Offset: 0x003CE3D4
				// (set) Token: 0x060100D9 RID: 65753 RVA: 0x00079BB2 File Offset: 0x00077DB2
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E48 RID: 20040
				// (get) Token: 0x060100DA RID: 65754 RVA: 0x003D01FC File Offset: 0x003CE3FC
				// (set) Token: 0x060100DB RID: 65755 RVA: 0x00079BCD File Offset: 0x00077DCD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E49 RID: 20041
				// (get) Token: 0x060100DC RID: 65756 RVA: 0x003D022C File Offset: 0x003CE42C
				// (set) Token: 0x060100DD RID: 65757 RVA: 0x00079BEC File Offset: 0x00077DEC
				public unsafe SmoothedVelocityCalculator.__c__DisplayClass22_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator.__c__DisplayClass22_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmoothedVelocityCalculator.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ACF5 RID: 44277
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ACF6 RID: 44278
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ACF7 RID: 44279
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ACF8 RID: 44280
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ACF9 RID: 44281
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACFA RID: 44282
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ACFB RID: 44283
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ACFC RID: 44284
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACFD RID: 44285
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}

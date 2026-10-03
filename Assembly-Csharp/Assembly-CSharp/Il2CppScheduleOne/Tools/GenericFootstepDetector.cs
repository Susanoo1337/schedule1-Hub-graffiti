using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004E5 RID: 1253
	public class GenericFootstepDetector : MonoBehaviour
	{
		// Token: 0x060071ED RID: 29165 RVA: 0x00201C08 File Offset: 0x001FFE08
		// Note: this type is marked as 'beforefieldinit'.
		static GenericFootstepDetector()
		{
			Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "GenericFootstepDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr);
			GenericFootstepDetector.NativeFieldInfoPtr_GroundDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, "GroundDetectionRange");
			GenericFootstepDetector.NativeFieldInfoPtr_GroundDetectionRayOriginShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, "GroundDetectionRayOriginShift");
			GenericFootstepDetector.NativeFieldInfoPtr__VolumeMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, "<VolumeMultiplier>k__BackingField");
			GenericFootstepDetector.NativeFieldInfoPtr__baseVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, "_baseVolume");
			GenericFootstepDetector.NativeFieldInfoPtr__stepDetectionCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, "_stepDetectionCooldown");
			GenericFootstepDetector.NativeFieldInfoPtr__referencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, "_referencePoint");
			GenericFootstepDetector.NativeFieldInfoPtr__timeOnLastStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, "_timeOnLastStep");
			GenericFootstepDetector.NativeFieldInfoPtr__groundDetectionLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, "_groundDetectionLayerMask");
			GenericFootstepDetector.NativeMethodInfoPtr_get_VolumeMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, 100678036);
			GenericFootstepDetector.NativeMethodInfoPtr_set_VolumeMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, 100678037);
			GenericFootstepDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, 100678038);
			GenericFootstepDetector.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, 100678039);
			GenericFootstepDetector.NativeMethodInfoPtr_TriggerStep_Protected_Void_EMaterialType_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, 100678040);
			GenericFootstepDetector.NativeMethodInfoPtr_IsCooldown_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, 100678041);
			GenericFootstepDetector.NativeMethodInfoPtr_IsGrounded_Protected_Boolean_byref_EMaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, 100678042);
			GenericFootstepDetector.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr, 100678043);
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x060071EE RID: 29166 RVA: 0x00201D78 File Offset: 0x001FFF78
		// (set) Token: 0x060071EF RID: 29167 RVA: 0x00201DB4 File Offset: 0x001FFFB4
		public unsafe float VolumeMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFootstepDetector.NativeMethodInfoPtr_get_VolumeMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29040, RefRangeEnd = 29041, XrefRangeStart = 29040, XrefRangeEnd = 29041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFootstepDetector.NativeMethodInfoPtr_set_VolumeMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060071F0 RID: 29168 RVA: 0x00201DF4 File Offset: 0x001FFFF4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFootstepDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F1 RID: 29169 RVA: 0x00201E28 File Offset: 0x00200028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225979, XrefRangeEnd = 226001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericFootstepDetector.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F2 RID: 29170 RVA: 0x00201E64 File Offset: 0x00200064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226012, RefRangeEnd = 226014, XrefRangeStart = 226001, XrefRangeEnd = 226012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerStep(EMaterialType materialType, Vector3 stepPosition, bool spatialAudio = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref materialType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepPosition;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spatialAudio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFootstepDetector.NativeMethodInfoPtr_TriggerStep_Protected_Void_EMaterialType_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F3 RID: 29171 RVA: 0x00201EC0 File Offset: 0x002000C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 226015, RefRangeEnd = 226016, XrefRangeStart = 226014, XrefRangeEnd = 226015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFootstepDetector.NativeMethodInfoPtr_IsCooldown_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060071F4 RID: 29172 RVA: 0x00201EFC File Offset: 0x002000FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226032, RefRangeEnd = 226034, XrefRangeStart = 226016, XrefRangeEnd = 226032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded(out EMaterialType surfaceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &surfaceType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFootstepDetector.NativeMethodInfoPtr_IsGrounded_Protected_Boolean_byref_EMaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060071F5 RID: 29173 RVA: 0x00201F48 File Offset: 0x00200148
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 226035, RefRangeEnd = 226037, XrefRangeStart = 226034, XrefRangeEnd = 226035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericFootstepDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericFootstepDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericFootstepDetector.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x00036317 File Offset: 0x00034517
		public GenericFootstepDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x060071F7 RID: 29175 RVA: 0x00201F84 File Offset: 0x00200184
		// (set) Token: 0x060071F8 RID: 29176 RVA: 0x00036320 File Offset: 0x00034520
		public unsafe static float GroundDetectionRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GenericFootstepDetector.NativeFieldInfoPtr_GroundDetectionRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericFootstepDetector.NativeFieldInfoPtr_GroundDetectionRange, (void*)(&value));
			}
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x060071F9 RID: 29177 RVA: 0x00201FA0 File Offset: 0x002001A0
		// (set) Token: 0x060071FA RID: 29178 RVA: 0x0003632E File Offset: 0x0003452E
		public unsafe static float GroundDetectionRayOriginShift
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GenericFootstepDetector.NativeFieldInfoPtr_GroundDetectionRayOriginShift, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericFootstepDetector.NativeFieldInfoPtr_GroundDetectionRayOriginShift, (void*)(&value));
			}
		}

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x060071FB RID: 29179 RVA: 0x00201FBC File Offset: 0x002001BC
		// (set) Token: 0x060071FC RID: 29180 RVA: 0x0003633C File Offset: 0x0003453C
		public unsafe float _VolumeMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFootstepDetector.NativeFieldInfoPtr__VolumeMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFootstepDetector.NativeFieldInfoPtr__VolumeMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x060071FD RID: 29181 RVA: 0x00201FE4 File Offset: 0x002001E4
		// (set) Token: 0x060071FE RID: 29182 RVA: 0x00036357 File Offset: 0x00034557
		public unsafe float _baseVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFootstepDetector.NativeFieldInfoPtr__baseVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFootstepDetector.NativeFieldInfoPtr__baseVolume)) = value;
			}
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x060071FF RID: 29183 RVA: 0x0020200C File Offset: 0x0020020C
		// (set) Token: 0x06007200 RID: 29184 RVA: 0x00036372 File Offset: 0x00034572
		public unsafe float _stepDetectionCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFootstepDetector.NativeFieldInfoPtr__stepDetectionCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFootstepDetector.NativeFieldInfoPtr__stepDetectionCooldown)) = value;
			}
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x06007201 RID: 29185 RVA: 0x00202034 File Offset: 0x00200234
		// (set) Token: 0x06007202 RID: 29186 RVA: 0x0003638D File Offset: 0x0003458D
		public unsafe Transform _referencePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFootstepDetector.NativeFieldInfoPtr__referencePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFootstepDetector.NativeFieldInfoPtr__referencePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x06007203 RID: 29187 RVA: 0x00202064 File Offset: 0x00200264
		// (set) Token: 0x06007204 RID: 29188 RVA: 0x000363AC File Offset: 0x000345AC
		public unsafe float _timeOnLastStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFootstepDetector.NativeFieldInfoPtr__timeOnLastStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericFootstepDetector.NativeFieldInfoPtr__timeOnLastStep)) = value;
			}
		}

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x06007205 RID: 29189 RVA: 0x0020208C File Offset: 0x0020028C
		// (set) Token: 0x06007206 RID: 29190 RVA: 0x000363C7 File Offset: 0x000345C7
		public unsafe static LayerMask _groundDetectionLayerMask
		{
			get
			{
				LayerMask result;
				IL2CPP.il2cpp_field_static_get_value(GenericFootstepDetector.NativeFieldInfoPtr__groundDetectionLayerMask, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GenericFootstepDetector.NativeFieldInfoPtr__groundDetectionLayerMask, (void*)(&value));
			}
		}

		// Token: 0x04004DD6 RID: 19926
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionRange;

		// Token: 0x04004DD7 RID: 19927
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionRayOriginShift;

		// Token: 0x04004DD8 RID: 19928
		private static readonly IntPtr NativeFieldInfoPtr__VolumeMultiplier_k__BackingField;

		// Token: 0x04004DD9 RID: 19929
		private static readonly IntPtr NativeFieldInfoPtr__baseVolume;

		// Token: 0x04004DDA RID: 19930
		private static readonly IntPtr NativeFieldInfoPtr__stepDetectionCooldown;

		// Token: 0x04004DDB RID: 19931
		private static readonly IntPtr NativeFieldInfoPtr__referencePoint;

		// Token: 0x04004DDC RID: 19932
		private static readonly IntPtr NativeFieldInfoPtr__timeOnLastStep;

		// Token: 0x04004DDD RID: 19933
		private static readonly IntPtr NativeFieldInfoPtr__groundDetectionLayerMask;

		// Token: 0x04004DDE RID: 19934
		private static readonly IntPtr NativeMethodInfoPtr_get_VolumeMultiplier_Public_get_Single_0;

		// Token: 0x04004DDF RID: 19935
		private static readonly IntPtr NativeMethodInfoPtr_set_VolumeMultiplier_Public_set_Void_Single_0;

		// Token: 0x04004DE0 RID: 19936
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004DE1 RID: 19937
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004DE2 RID: 19938
		private static readonly IntPtr NativeMethodInfoPtr_TriggerStep_Protected_Void_EMaterialType_Vector3_Boolean_0;

		// Token: 0x04004DE3 RID: 19939
		private static readonly IntPtr NativeMethodInfoPtr_IsCooldown_Protected_Boolean_0;

		// Token: 0x04004DE4 RID: 19940
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Protected_Boolean_byref_EMaterialType_0;

		// Token: 0x04004DE5 RID: 19941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

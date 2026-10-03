using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x020004BB RID: 1211
	public class AvatarFootstepDetector : GenericFootstepDetector
	{
		// Token: 0x06006EF4 RID: 28404 RVA: 0x001F9498 File Offset: 0x001F7698
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarFootstepDetector()
		{
			Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarFootstepDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr);
			AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "StepThreshold");
			AvatarFootstepDetector.NativeFieldInfoPtr__detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "_detectionRange");
			AvatarFootstepDetector.NativeFieldInfoPtr__avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "_avatar");
			AvatarFootstepDetector.NativeFieldInfoPtr__leftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "_leftDown");
			AvatarFootstepDetector.NativeFieldInfoPtr__rightDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "_rightDown");
			AvatarFootstepDetector.NativeFieldInfoPtr__detectionRangeSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "_detectionRangeSqr");
			AvatarFootstepDetector.NativeMethodInfoPtr_get__leftBone_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100677707);
			AvatarFootstepDetector.NativeMethodInfoPtr_get__rightBone_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100677708);
			AvatarFootstepDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100677709);
			AvatarFootstepDetector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100677710);
			AvatarFootstepDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100677711);
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x06006EF5 RID: 28405 RVA: 0x001F95A4 File Offset: 0x001F77A4
		public unsafe Transform _leftBone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_get__leftBone_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x06006EF6 RID: 28406 RVA: 0x001F95E4 File Offset: 0x001F77E4
		public unsafe Transform _rightBone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_get__rightBone_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06006EF7 RID: 28407 RVA: 0x001F9624 File Offset: 0x001F7824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223443, XrefRangeEnd = 223447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EF8 RID: 28408 RVA: 0x001F9658 File Offset: 0x001F7858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223447, XrefRangeEnd = 223477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarFootstepDetector.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EF9 RID: 28409 RVA: 0x001F9694 File Offset: 0x001F7894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223477, XrefRangeEnd = 223481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarFootstepDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x000348DD File Offset: 0x00032ADD
		public AvatarFootstepDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x06006EFB RID: 28411 RVA: 0x001F96D0 File Offset: 0x001F78D0
		// (set) Token: 0x06006EFC RID: 28412 RVA: 0x000348E6 File Offset: 0x00032AE6
		public unsafe static float StepThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x06006EFD RID: 28413 RVA: 0x001F96EC File Offset: 0x001F78EC
		// (set) Token: 0x06006EFE RID: 28414 RVA: 0x000348F4 File Offset: 0x00032AF4
		public unsafe float _detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr__detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr__detectionRange)) = value;
			}
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x06006EFF RID: 28415 RVA: 0x001F9714 File Offset: 0x001F7914
		// (set) Token: 0x06006F00 RID: 28416 RVA: 0x0003490F File Offset: 0x00032B0F
		public unsafe Avatar _avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr__avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr__avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x06006F01 RID: 28417 RVA: 0x001F9744 File Offset: 0x001F7944
		// (set) Token: 0x06006F02 RID: 28418 RVA: 0x0003492E File Offset: 0x00032B2E
		public unsafe bool _leftDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr__leftDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr__leftDown)) = value;
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x06006F03 RID: 28419 RVA: 0x001F976C File Offset: 0x001F796C
		// (set) Token: 0x06006F04 RID: 28420 RVA: 0x00034949 File Offset: 0x00032B49
		public unsafe bool _rightDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr__rightDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr__rightDown)) = value;
			}
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x06006F05 RID: 28421 RVA: 0x001F9794 File Offset: 0x001F7994
		// (set) Token: 0x06006F06 RID: 28422 RVA: 0x00034964 File Offset: 0x00032B64
		public unsafe float _detectionRangeSqr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr__detectionRangeSqr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr__detectionRangeSqr)) = value;
			}
		}

		// Token: 0x04004C0C RID: 19468
		private static readonly IntPtr NativeFieldInfoPtr_StepThreshold;

		// Token: 0x04004C0D RID: 19469
		private static readonly IntPtr NativeFieldInfoPtr__detectionRange;

		// Token: 0x04004C0E RID: 19470
		private static readonly IntPtr NativeFieldInfoPtr__avatar;

		// Token: 0x04004C0F RID: 19471
		private static readonly IntPtr NativeFieldInfoPtr__leftDown;

		// Token: 0x04004C10 RID: 19472
		private static readonly IntPtr NativeFieldInfoPtr__rightDown;

		// Token: 0x04004C11 RID: 19473
		private static readonly IntPtr NativeFieldInfoPtr__detectionRangeSqr;

		// Token: 0x04004C12 RID: 19474
		private static readonly IntPtr NativeMethodInfoPtr_get__leftBone_Private_get_Transform_0;

		// Token: 0x04004C13 RID: 19475
		private static readonly IntPtr NativeMethodInfoPtr_get__rightBone_Private_get_Transform_0;

		// Token: 0x04004C14 RID: 19476
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004C15 RID: 19477
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004C16 RID: 19478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

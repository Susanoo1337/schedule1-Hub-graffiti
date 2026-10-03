using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000505 RID: 1285
	public class WheelRotator : MonoBehaviour
	{
		// Token: 0x060073B6 RID: 29622 RVA: 0x00207124 File Offset: 0x00205324
		// Note: this type is marked as 'beforefieldinit'.
		static WheelRotator()
		{
			Il2CppClassPointerStore<WheelRotator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "WheelRotator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr);
			WheelRotator.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Radius");
			WheelRotator.NativeFieldInfoPtr_Wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Wheel");
			WheelRotator.NativeFieldInfoPtr_Flip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Flip");
			WheelRotator.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Controller");
			WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "AudioVolumeDivisor");
			WheelRotator.NativeFieldInfoPtr_RotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "RotationAxis");
			WheelRotator.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "lastFramePosition");
			WheelRotator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678234);
			WheelRotator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678235);
			WheelRotator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678236);
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x0020721C File Offset: 0x0020541C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227631, XrefRangeEnd = 227639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x00207250 File Offset: 0x00205450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227639, XrefRangeEnd = 227654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x00207284 File Offset: 0x00205484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227654, XrefRangeEnd = 227659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WheelRotator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x000370F7 File Offset: 0x000352F7
		public WheelRotator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x060073BB RID: 29627 RVA: 0x002072C0 File Offset: 0x002054C0
		// (set) Token: 0x060073BC RID: 29628 RVA: 0x00037100 File Offset: 0x00035300
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x060073BD RID: 29629 RVA: 0x002072E8 File Offset: 0x002054E8
		// (set) Token: 0x060073BE RID: 29630 RVA: 0x0003711B File Offset: 0x0003531B
		public unsafe Transform Wheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Wheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Wheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x060073BF RID: 29631 RVA: 0x00207318 File Offset: 0x00205518
		// (set) Token: 0x060073C0 RID: 29632 RVA: 0x0003713A File Offset: 0x0003533A
		public unsafe bool Flip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Flip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Flip)) = value;
			}
		}

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x060073C1 RID: 29633 RVA: 0x00207340 File Offset: 0x00205540
		// (set) Token: 0x060073C2 RID: 29634 RVA: 0x00037155 File Offset: 0x00035355
		public unsafe AudioSourceController Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x060073C3 RID: 29635 RVA: 0x00207370 File Offset: 0x00205570
		// (set) Token: 0x060073C4 RID: 29636 RVA: 0x00037174 File Offset: 0x00035374
		public unsafe float AudioVolumeDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor)) = value;
			}
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x060073C5 RID: 29637 RVA: 0x00207398 File Offset: 0x00205598
		// (set) Token: 0x060073C6 RID: 29638 RVA: 0x0003718F File Offset: 0x0003538F
		public unsafe Vector3 RotationAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_RotationAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_RotationAxis)) = value;
			}
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x060073C7 RID: 29639 RVA: 0x002073C0 File Offset: 0x002055C0
		// (set) Token: 0x060073C8 RID: 29640 RVA: 0x000371AA File Offset: 0x000353AA
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x04004EE9 RID: 20201
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x04004EEA RID: 20202
		private static readonly IntPtr NativeFieldInfoPtr_Wheel;

		// Token: 0x04004EEB RID: 20203
		private static readonly IntPtr NativeFieldInfoPtr_Flip;

		// Token: 0x04004EEC RID: 20204
		private static readonly IntPtr NativeFieldInfoPtr_Controller;

		// Token: 0x04004EED RID: 20205
		private static readonly IntPtr NativeFieldInfoPtr_AudioVolumeDivisor;

		// Token: 0x04004EEE RID: 20206
		private static readonly IntPtr NativeFieldInfoPtr_RotationAxis;

		// Token: 0x04004EEF RID: 20207
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x04004EF0 RID: 20208
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004EF1 RID: 20209
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04004EF2 RID: 20210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

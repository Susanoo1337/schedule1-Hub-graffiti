using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003DA RID: 986
	public class FlickeringLight : MonoBehaviour
	{
		// Token: 0x06005847 RID: 22599 RVA: 0x001ACDF4 File Offset: 0x001AAFF4
		// Note: this type is marked as 'beforefieldinit'.
		static FlickeringLight()
		{
			Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "FlickeringLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr);
			FlickeringLight.NativeFieldInfoPtr_minIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "minIntensity");
			FlickeringLight.NativeFieldInfoPtr_maxIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "maxIntensity");
			FlickeringLight.NativeFieldInfoPtr_enableColorShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "enableColorShift");
			FlickeringLight.NativeFieldInfoPtr_minColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "minColor");
			FlickeringLight.NativeFieldInfoPtr_maxColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "maxColor");
			FlickeringLight.NativeFieldInfoPtr_flickerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "flickerSpeed");
			FlickeringLight.NativeFieldInfoPtr_lightSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "lightSource");
			FlickeringLight.NativeFieldInfoPtr_targetIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "targetIntensity");
			FlickeringLight.NativeFieldInfoPtr_targetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "targetColor");
			FlickeringLight.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100674900);
			FlickeringLight.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100674901);
			FlickeringLight.NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100674902);
			FlickeringLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100674903);
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x001ACF28 File Offset: 0x001AB128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193014, XrefRangeEnd = 193019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x001ACF5C File Offset: 0x001AB15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193019, XrefRangeEnd = 193029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x001ACF90 File Offset: 0x001AB190
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 193032, RefRangeEnd = 193034, XrefRangeStart = 193029, XrefRangeEnd = 193032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTargetValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x001ACFC4 File Offset: 0x001AB1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193034, XrefRangeEnd = 193035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlickeringLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x00029B71 File Offset: 0x00027D71
		public FlickeringLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x0600584D RID: 22605 RVA: 0x001AD000 File Offset: 0x001AB200
		// (set) Token: 0x0600584E RID: 22606 RVA: 0x00029B7A File Offset: 0x00027D7A
		public unsafe float minIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minIntensity)) = value;
			}
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x0600584F RID: 22607 RVA: 0x001AD028 File Offset: 0x001AB228
		// (set) Token: 0x06005850 RID: 22608 RVA: 0x00029B95 File Offset: 0x00027D95
		public unsafe float maxIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxIntensity)) = value;
			}
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06005851 RID: 22609 RVA: 0x001AD050 File Offset: 0x001AB250
		// (set) Token: 0x06005852 RID: 22610 RVA: 0x00029BB0 File Offset: 0x00027DB0
		public unsafe bool enableColorShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_enableColorShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_enableColorShift)) = value;
			}
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06005853 RID: 22611 RVA: 0x001AD078 File Offset: 0x001AB278
		// (set) Token: 0x06005854 RID: 22612 RVA: 0x00029BCB File Offset: 0x00027DCB
		public unsafe Color minColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minColor)) = value;
			}
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06005855 RID: 22613 RVA: 0x001AD0A0 File Offset: 0x001AB2A0
		// (set) Token: 0x06005856 RID: 22614 RVA: 0x00029BE6 File Offset: 0x00027DE6
		public unsafe Color maxColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxColor)) = value;
			}
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06005857 RID: 22615 RVA: 0x001AD0C8 File Offset: 0x001AB2C8
		// (set) Token: 0x06005858 RID: 22616 RVA: 0x00029C01 File Offset: 0x00027E01
		public unsafe float flickerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_flickerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_flickerSpeed)) = value;
			}
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06005859 RID: 22617 RVA: 0x001AD0F0 File Offset: 0x001AB2F0
		// (set) Token: 0x0600585A RID: 22618 RVA: 0x00029C1C File Offset: 0x00027E1C
		public unsafe Light lightSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_lightSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_lightSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x0600585B RID: 22619 RVA: 0x001AD120 File Offset: 0x001AB320
		// (set) Token: 0x0600585C RID: 22620 RVA: 0x00029C3B File Offset: 0x00027E3B
		public unsafe float targetIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetIntensity)) = value;
			}
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x0600585D RID: 22621 RVA: 0x001AD148 File Offset: 0x001AB348
		// (set) Token: 0x0600585E RID: 22622 RVA: 0x00029C56 File Offset: 0x00027E56
		public unsafe Color targetColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetColor)) = value;
			}
		}

		// Token: 0x04003CBC RID: 15548
		private static readonly IntPtr NativeFieldInfoPtr_minIntensity;

		// Token: 0x04003CBD RID: 15549
		private static readonly IntPtr NativeFieldInfoPtr_maxIntensity;

		// Token: 0x04003CBE RID: 15550
		private static readonly IntPtr NativeFieldInfoPtr_enableColorShift;

		// Token: 0x04003CBF RID: 15551
		private static readonly IntPtr NativeFieldInfoPtr_minColor;

		// Token: 0x04003CC0 RID: 15552
		private static readonly IntPtr NativeFieldInfoPtr_maxColor;

		// Token: 0x04003CC1 RID: 15553
		private static readonly IntPtr NativeFieldInfoPtr_flickerSpeed;

		// Token: 0x04003CC2 RID: 15554
		private static readonly IntPtr NativeFieldInfoPtr_lightSource;

		// Token: 0x04003CC3 RID: 15555
		private static readonly IntPtr NativeFieldInfoPtr_targetIntensity;

		// Token: 0x04003CC4 RID: 15556
		private static readonly IntPtr NativeFieldInfoPtr_targetColor;

		// Token: 0x04003CC5 RID: 15557
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003CC6 RID: 15558
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003CC7 RID: 15559
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0;

		// Token: 0x04003CC8 RID: 15560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

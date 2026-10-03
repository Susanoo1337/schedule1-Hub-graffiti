using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006E8 RID: 1768
	public class HapticsData : ScriptableObject
	{
		// Token: 0x0600AAAC RID: 43692 RVA: 0x002D0FD4 File Offset: 0x002CF1D4
		// Note: this type is marked as 'beforefieldinit'.
		static HapticsData()
		{
			Il2CppClassPointerStore<HapticsData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "HapticsData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HapticsData>.NativeClassPtr);
			HapticsData.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsData>.NativeClassPtr, "Id");
			HapticsData.NativeFieldInfoPtr_HapticMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsData>.NativeClassPtr, "HapticMode");
			HapticsData.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsData>.NativeClassPtr, "Duration");
			HapticsData.NativeFieldInfoPtr_EnterCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsData>.NativeClassPtr, "EnterCurve");
			HapticsData.NativeFieldInfoPtr_ExitCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsData>.NativeClassPtr, "ExitCurve");
			HapticsData.NativeFieldInfoPtr_LowFrequencySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsData>.NativeClassPtr, "LowFrequencySettings");
			HapticsData.NativeFieldInfoPtr_HighFrequencySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticsData>.NativeClassPtr, "HighFrequencySettings");
			HapticsData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticsData>.NativeClassPtr, 100685922);
		}

		// Token: 0x0600AAAD RID: 43693 RVA: 0x002D10A4 File Offset: 0x002CF2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294618, XrefRangeEnd = 294623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HapticsData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HapticsData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticsData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAAE RID: 43694 RVA: 0x0004DCBF File Offset: 0x0004BEBF
		public HapticsData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600AAAF RID: 43695 RVA: 0x002D10E0 File Offset: 0x002CF2E0
		// (set) Token: 0x0600AAB0 RID: 43696 RVA: 0x0004DCC8 File Offset: 0x0004BEC8
		public unsafe string Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600AAB1 RID: 43697 RVA: 0x002D1108 File Offset: 0x002CF308
		// (set) Token: 0x0600AAB2 RID: 43698 RVA: 0x0004DCE7 File Offset: 0x0004BEE7
		public unsafe EHapticMode HapticMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_HapticMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_HapticMode)) = value;
			}
		}

		// Token: 0x1700330F RID: 13071
		// (get) Token: 0x0600AAB3 RID: 43699 RVA: 0x002D1130 File Offset: 0x002CF330
		// (set) Token: 0x0600AAB4 RID: 43700 RVA: 0x0004DD02 File Offset: 0x0004BF02
		public unsafe Vector3 Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_Duration)) = value;
			}
		}

		// Token: 0x17003310 RID: 13072
		// (get) Token: 0x0600AAB5 RID: 43701 RVA: 0x002D1158 File Offset: 0x002CF358
		// (set) Token: 0x0600AAB6 RID: 43702 RVA: 0x0004DD1D File Offset: 0x0004BF1D
		public unsafe AnimationCurve EnterCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_EnterCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_EnterCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600AAB7 RID: 43703 RVA: 0x002D1188 File Offset: 0x002CF388
		// (set) Token: 0x0600AAB8 RID: 43704 RVA: 0x0004DD3C File Offset: 0x0004BF3C
		public unsafe AnimationCurve ExitCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_ExitCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_ExitCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600AAB9 RID: 43705 RVA: 0x002D11B8 File Offset: 0x002CF3B8
		// (set) Token: 0x0600AABA RID: 43706 RVA: 0x0004DD5B File Offset: 0x0004BF5B
		public unsafe HapticSettings LowFrequencySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_LowFrequencySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HapticSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_LowFrequencySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600AABB RID: 43707 RVA: 0x002D11E8 File Offset: 0x002CF3E8
		// (set) Token: 0x0600AABC RID: 43708 RVA: 0x0004DD7A File Offset: 0x0004BF7A
		public unsafe HapticSettings HighFrequencySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_HighFrequencySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HapticSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticsData.NativeFieldInfoPtr_HighFrequencySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040075F3 RID: 30195
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x040075F4 RID: 30196
		private static readonly IntPtr NativeFieldInfoPtr_HapticMode;

		// Token: 0x040075F5 RID: 30197
		private static readonly IntPtr NativeFieldInfoPtr_Duration;

		// Token: 0x040075F6 RID: 30198
		private static readonly IntPtr NativeFieldInfoPtr_EnterCurve;

		// Token: 0x040075F7 RID: 30199
		private static readonly IntPtr NativeFieldInfoPtr_ExitCurve;

		// Token: 0x040075F8 RID: 30200
		private static readonly IntPtr NativeFieldInfoPtr_LowFrequencySettings;

		// Token: 0x040075F9 RID: 30201
		private static readonly IntPtr NativeFieldInfoPtr_HighFrequencySettings;

		// Token: 0x040075FA RID: 30202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

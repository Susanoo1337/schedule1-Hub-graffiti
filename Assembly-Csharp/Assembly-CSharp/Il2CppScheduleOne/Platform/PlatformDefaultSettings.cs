using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Gamepad;
using UnityEngine;

namespace Il2CppScheduleOne.Platform
{
	// Token: 0x020001A4 RID: 420
	public class PlatformDefaultSettings : ScriptableObject
	{
		// Token: 0x06002A3F RID: 10815 RVA: 0x0010696C File Offset: 0x00104B6C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDefaultSettings()
		{
			Il2CppClassPointerStore<PlatformDefaultSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Platform", "PlatformDefaultSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDefaultSettings>.NativeClassPtr);
			PlatformDefaultSettings.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDefaultSettings>.NativeClassPtr, "Platform");
			PlatformDefaultSettings.NativeFieldInfoPtr_DisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDefaultSettings>.NativeClassPtr, "DisplaySettings");
			PlatformDefaultSettings.NativeFieldInfoPtr_GraphicsSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDefaultSettings>.NativeClassPtr, "GraphicsSettings");
			PlatformDefaultSettings.NativeFieldInfoPtr_InputSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDefaultSettings>.NativeClassPtr, "InputSettings");
			PlatformDefaultSettings.NativeFieldInfoPtr_GamepadSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDefaultSettings>.NativeClassPtr, "GamepadSettings");
			PlatformDefaultSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDefaultSettings>.NativeClassPtr, 100668695);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00106A14 File Offset: 0x00104C14
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDefaultSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDefaultSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDefaultSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00016124 File Offset: 0x00014324
		public PlatformDefaultSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x00106A50 File Offset: 0x00104C50
		// (set) Token: 0x06002A43 RID: 10819 RVA: 0x0001612D File Offset: 0x0001432D
		public unsafe EHardwarePlatform Platform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDefaultSettings.NativeFieldInfoPtr_Platform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDefaultSettings.NativeFieldInfoPtr_Platform)) = value;
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x00106A78 File Offset: 0x00104C78
		// (set) Token: 0x06002A45 RID: 10821 RVA: 0x00016148 File Offset: 0x00014348
		public unsafe DisplaySettings DisplaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDefaultSettings.NativeFieldInfoPtr_DisplaySettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDefaultSettings.NativeFieldInfoPtr_DisplaySettings)) = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x00106AA0 File Offset: 0x00104CA0
		// (set) Token: 0x06002A47 RID: 10823 RVA: 0x00016163 File Offset: 0x00014363
		public unsafe GraphicsSettings GraphicsSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDefaultSettings.NativeFieldInfoPtr_GraphicsSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDefaultSettings.NativeFieldInfoPtr_GraphicsSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x00106AD0 File Offset: 0x00104CD0
		// (set) Token: 0x06002A49 RID: 10825 RVA: 0x00016182 File Offset: 0x00014382
		public unsafe InputSettings InputSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDefaultSettings.NativeFieldInfoPtr_InputSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDefaultSettings.NativeFieldInfoPtr_InputSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x00106B00 File Offset: 0x00104D00
		// (set) Token: 0x06002A4B RID: 10827 RVA: 0x000161A1 File Offset: 0x000143A1
		public unsafe GamepadSettings GamepadSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDefaultSettings.NativeFieldInfoPtr_GamepadSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GamepadSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDefaultSettings.NativeFieldInfoPtr_GamepadSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeFieldInfoPtr_Platform;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeFieldInfoPtr_DisplaySettings;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeFieldInfoPtr_GraphicsSettings;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeFieldInfoPtr_InputSettings;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeFieldInfoPtr_GamepadSettings;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

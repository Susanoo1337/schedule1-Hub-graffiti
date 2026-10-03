using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Gamepad
{
	// Token: 0x020006EA RID: 1770
	[Serializable]
	public class HapticSettings : Object
	{
		// Token: 0x0600AABD RID: 43709 RVA: 0x002D1218 File Offset: 0x002CF418
		// Note: this type is marked as 'beforefieldinit'.
		static HapticSettings()
		{
			Il2CppClassPointerStore<HapticSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Gamepad", "HapticSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HapticSettings>.NativeClassPtr);
			HapticSettings.NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticSettings>.NativeClassPtr, "Intensity");
			HapticSettings.NativeFieldInfoPtr_PulseCyclesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticSettings>.NativeClassPtr, "PulseCyclesPerSecond");
			HapticSettings.NativeFieldInfoPtr_PulseIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticSettings>.NativeClassPtr, "PulseIntensity");
			HapticSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticSettings>.NativeClassPtr, 100685923);
		}

		// Token: 0x0600AABE RID: 43710 RVA: 0x002D1298 File Offset: 0x002CF498
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HapticSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HapticSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HapticSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AABF RID: 43711 RVA: 0x0004DD99 File Offset: 0x0004BF99
		public HapticSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600AAC0 RID: 43712 RVA: 0x002D12D4 File Offset: 0x002CF4D4
		// (set) Token: 0x0600AAC1 RID: 43713 RVA: 0x0004DDA2 File Offset: 0x0004BFA2
		public unsafe float Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticSettings.NativeFieldInfoPtr_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticSettings.NativeFieldInfoPtr_Intensity)) = value;
			}
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600AAC2 RID: 43714 RVA: 0x002D12FC File Offset: 0x002CF4FC
		// (set) Token: 0x0600AAC3 RID: 43715 RVA: 0x0004DDBD File Offset: 0x0004BFBD
		public unsafe float PulseCyclesPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticSettings.NativeFieldInfoPtr_PulseCyclesPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticSettings.NativeFieldInfoPtr_PulseCyclesPerSecond)) = value;
			}
		}

		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600AAC4 RID: 43716 RVA: 0x002D1324 File Offset: 0x002CF524
		// (set) Token: 0x0600AAC5 RID: 43717 RVA: 0x0004DDD8 File Offset: 0x0004BFD8
		public unsafe float PulseIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticSettings.NativeFieldInfoPtr_PulseIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HapticSettings.NativeFieldInfoPtr_PulseIntensity)) = value;
			}
		}

		// Token: 0x040075FE RID: 30206
		private static readonly IntPtr NativeFieldInfoPtr_Intensity;

		// Token: 0x040075FF RID: 30207
		private static readonly IntPtr NativeFieldInfoPtr_PulseCyclesPerSecond;

		// Token: 0x04007600 RID: 30208
		private static readonly IntPtr NativeFieldInfoPtr_PulseIntensity;

		// Token: 0x04007601 RID: 30209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

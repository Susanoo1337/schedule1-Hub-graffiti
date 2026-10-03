using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;

namespace Il2CppScheduleOne.Platform
{
	// Token: 0x020001A1 RID: 417
	public static class HardwarePlatformUtility : Object
	{
		// Token: 0x06002A0C RID: 10764 RVA: 0x00105FB0 File Offset: 0x001041B0
		// Note: this type is marked as 'beforefieldinit'.
		static HardwarePlatformUtility()
		{
			Il2CppClassPointerStore<HardwarePlatformUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Platform", "HardwarePlatformUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HardwarePlatformUtility>.NativeClassPtr);
			HardwarePlatformUtility.NativeMethodInfoPtr_GetCurrentPlatform_Public_Static_EHardwarePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwarePlatformUtility>.NativeClassPtr, 100668663);
			HardwarePlatformUtility.NativeMethodInfoPtr_IsAnyGamepadConnected_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwarePlatformUtility>.NativeClassPtr, 100668664);
			HardwarePlatformUtility.NativeMethodInfoPtr_GetAvailableDisplayModes_Public_Static_Il2CppStructArray_1_EDisplayMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HardwarePlatformUtility>.NativeClassPtr, 100668665);
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x0010601C File Offset: 0x0010421C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123680, RefRangeEnd = 123681, XrefRangeStart = 123678, XrefRangeEnd = 123680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EHardwarePlatform GetCurrentPlatform()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwarePlatformUtility.NativeMethodInfoPtr_GetCurrentPlatform_Public_Static_EHardwarePlatform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x0010604C File Offset: 0x0010424C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123683, RefRangeEnd = 123684, XrefRangeStart = 123681, XrefRangeEnd = 123683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAnyGamepadConnected()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwarePlatformUtility.NativeMethodInfoPtr_IsAnyGamepadConnected_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x0010607C File Offset: 0x0010427C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 123687, RefRangeEnd = 123692, XrefRangeStart = 123684, XrefRangeEnd = 123687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<DisplaySettings.EDisplayMode> GetAvailableDisplayModes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HardwarePlatformUtility.NativeMethodInfoPtr_GetAvailableDisplayModes_Public_Static_Il2CppStructArray_1_EDisplayMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DisplaySettings.EDisplayMode>>(intPtr3) : null;
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x00016027 File Offset: 0x00014227
		public HardwarePlatformUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPlatform_Public_Static_EHardwarePlatform_0;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyGamepadConnected_Public_Static_Boolean_0;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableDisplayModes_Public_Static_Il2CppStructArray_1_EDisplayMode_0;
	}
}

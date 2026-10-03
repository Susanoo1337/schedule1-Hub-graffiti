using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x0200009D RID: 157
	public class HDROutputSettings : Object
	{
		// Token: 0x06000977 RID: 2423 RVA: 0x000353F8 File Offset: 0x000335F8
		// Note: this type is marked as 'beforefieldinit'.
		static HDROutputSettings()
		{
			Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HDROutputSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr);
			HDROutputSettings.NativeFieldInfoPtr_m_DisplayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, "m_DisplayIndex");
			HDROutputSettings.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, "displays");
			HDROutputSettings.NativeFieldInfoPtr__mainDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, "_mainDisplay");
			HDROutputSettings.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664254);
			HDROutputSettings.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664255);
			HDROutputSettings.NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664256);
			HDROutputSettings.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664257);
			HDROutputSettings.NativeMethodInfoPtr_get_available_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664258);
			HDROutputSettings.NativeMethodInfoPtr_set_automaticHDRTonemapping_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664259);
			HDROutputSettings.NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664260);
			HDROutputSettings.NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664261);
			HDROutputSettings.NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664262);
			HDROutputSettings.NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664263);
			HDROutputSettings.NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664264);
			HDROutputSettings.NativeMethodInfoPtr_RequestHDRModeChange_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664265);
			HDROutputSettings.NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664266);
			HDROutputSettings.NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664267);
			HDROutputSettings.NativeMethodInfoPtr_SetAutomaticHDRTonemapping_Private_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664268);
			HDROutputSettings.NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664269);
			HDROutputSettings.NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664270);
			HDROutputSettings.NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664271);
			HDROutputSettings.NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664272);
			HDROutputSettings.NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664273);
			HDROutputSettings.NativeMethodInfoPtr_RequestHDRModeChangeInternal_Private_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664274);
			HDROutputSettings.GetAutomaticHDRTonemappingDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetAutomaticHDRTonemappingDelegate>("UnityEngine.HDROutputSettings::GetAutomaticHDRTonemapping");
			HDROutputSettings.GetGraphicsFormatDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetGraphicsFormatDelegate>("UnityEngine.HDROutputSettings::GetGraphicsFormat");
			HDROutputSettings.SetPaperWhiteNitsDelegateField = IL2CPP.ResolveICall<HDROutputSettings.SetPaperWhiteNitsDelegate>("UnityEngine.HDROutputSettings::SetPaperWhiteNits");
			HDROutputSettings.GetHDRModeChangeRequestedDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetHDRModeChangeRequestedDelegate>("UnityEngine.HDROutputSettings::GetHDRModeChangeRequested");
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00035644 File Offset: 0x00033844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HDROutputSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00035680 File Offset: 0x00033880
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HDROutputSettings(int displayIndex) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref displayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x000356C8 File Offset: 0x000338C8
		public unsafe static HDROutputSettings main
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1234362, RefRangeEnd = 1234375, XrefRangeStart = 1234358, XrefRangeEnd = 1234362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HDROutputSettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x000356FC File Offset: 0x000338FC
		public unsafe bool active
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1234380, RefRangeEnd = 1234388, XrefRangeStart = 1234375, XrefRangeEnd = 1234380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00035738 File Offset: 0x00033938
		public unsafe bool available
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1234393, RefRangeEnd = 1234396, XrefRangeStart = 1234388, XrefRangeEnd = 1234393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_available_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00035BD8 File Offset: 0x00033DD8
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x00035774 File Offset: 0x00033974
		public unsafe bool automaticHDRTonemapping
		{
			get
			{
				return HDROutputSettings.GetAutomaticHDRTonemapping(this.m_DisplayIndex);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1234401, RefRangeEnd = 1234403, XrefRangeStart = 1234396, XrefRangeEnd = 1234401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_set_automaticHDRTonemapping_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x000357B4 File Offset: 0x000339B4
		public unsafe ColorGamut displayColorGamut
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1234408, RefRangeEnd = 1234411, XrefRangeStart = 1234403, XrefRangeEnd = 1234408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000357F0 File Offset: 0x000339F0
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x000061A1 File Offset: 0x000043A1
		public unsafe float paperWhiteNits
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1234416, RefRangeEnd = 1234418, XrefRangeStart = 1234411, XrefRangeEnd = 1234416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				HDROutputSettings.SetPaperWhiteNits(this.m_DisplayIndex, value);
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0003582C File Offset: 0x00033A2C
		public unsafe int maxFullFrameToneMapLuminance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1234423, RefRangeEnd = 1234425, XrefRangeStart = 1234418, XrefRangeEnd = 1234423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00035868 File Offset: 0x00033A68
		public unsafe int maxToneMapLuminance
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1234430, RefRangeEnd = 1234433, XrefRangeStart = 1234425, XrefRangeEnd = 1234430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x000358A4 File Offset: 0x00033AA4
		public unsafe int minToneMapLuminance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1234438, RefRangeEnd = 1234440, XrefRangeStart = 1234433, XrefRangeEnd = 1234438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000358E0 File Offset: 0x00033AE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1234445, RefRangeEnd = 1234447, XrefRangeStart = 1234440, XrefRangeEnd = 1234445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestHDRModeChange(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_RequestHDRModeChange_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00035920 File Offset: 0x00033B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234447, XrefRangeEnd = 1234449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetActive(int displayIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref displayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00035960 File Offset: 0x00033B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234449, XrefRangeEnd = 1234451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAvailable(int displayIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref displayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x000359A0 File Offset: 0x00033BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234451, XrefRangeEnd = 1234472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAutomaticHDRTonemapping(int displayIndex, bool scripted)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref displayIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scripted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_SetAutomaticHDRTonemapping_Private_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x000359E0 File Offset: 0x00033BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234472, XrefRangeEnd = 1234474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ColorGamut GetDisplayColorGamut(int displayIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref displayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00035A20 File Offset: 0x00033C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234474, XrefRangeEnd = 1234476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPaperWhiteNits(int displayIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref displayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00035A60 File Offset: 0x00033C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234476, XrefRangeEnd = 1234478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxFullFrameToneMapLuminance(int displayIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref displayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00035AA0 File Offset: 0x00033CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234478, XrefRangeEnd = 1234480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxToneMapLuminance(int displayIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref displayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00035AE0 File Offset: 0x00033CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234480, XrefRangeEnd = 1234482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMinToneMapLuminance(int displayIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref displayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00035B20 File Offset: 0x00033D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234482, XrefRangeEnd = 1234484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestHDRModeChangeInternal(int displayIndex, bool enabled)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref displayIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_RequestHDRModeChangeInternal_Private_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00006159 File Offset: 0x00004359
		public HDROutputSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00035B60 File Offset: 0x00033D60
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00006162 File Offset: 0x00004362
		public unsafe int m_DisplayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDROutputSettings.NativeFieldInfoPtr_m_DisplayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDROutputSettings.NativeFieldInfoPtr_m_DisplayIndex)) = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00035B88 File Offset: 0x00033D88
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x0000617D File Offset: 0x0000437D
		public unsafe static Il2CppReferenceArray<HDROutputSettings> displays
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HDROutputSettings.NativeFieldInfoPtr_displays, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HDROutputSettings>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HDROutputSettings.NativeFieldInfoPtr_displays, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00035BB0 File Offset: 0x00033DB0
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x0000618F File Offset: 0x0000438F
		public unsafe static HDROutputSettings _mainDisplay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HDROutputSettings.NativeFieldInfoPtr__mainDisplay, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDROutputSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HDROutputSettings.NativeFieldInfoPtr__mainDisplay, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x00035BF8 File Offset: 0x00033DF8
		public RenderTextureFormat format
		{
			get
			{
				return UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetRenderTextureFormat(HDROutputSettings.GetGraphicsFormat(this.m_DisplayIndex));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00035C1C File Offset: 0x00033E1C
		public UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			get
			{
				return HDROutputSettings.GetGraphicsFormat(this.m_DisplayIndex);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00035C3C File Offset: 0x00033E3C
		public bool HDRModeChangeRequested
		{
			get
			{
				return HDROutputSettings.GetHDRModeChangeRequested(this.m_DisplayIndex);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00035C5C File Offset: 0x00033E5C
		public static void SetPaperWhiteInNits(float paperWhite)
		{
			int displayIndex = 0;
			bool available = HDROutputSettings.GetAvailable(displayIndex);
			if (available)
			{
				HDROutputSettings.SetPaperWhiteNits(displayIndex, paperWhite);
			}
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x000061B1 File Offset: 0x000043B1
		public static bool GetAutomaticHDRTonemapping(int displayIndex)
		{
			return HDROutputSettings.GetAutomaticHDRTonemappingDelegateField(displayIndex);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000061BE File Offset: 0x000043BE
		public static UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(int displayIndex)
		{
			return HDROutputSettings.GetGraphicsFormatDelegateField(displayIndex);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000061CB File Offset: 0x000043CB
		public static void SetPaperWhiteNits(int displayIndex, float paperWhite)
		{
			HDROutputSettings.SetPaperWhiteNitsDelegateField(displayIndex, paperWhite);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000061D9 File Offset: 0x000043D9
		public static bool GetHDRModeChangeRequested(int displayIndex)
		{
			return HDROutputSettings.GetHDRModeChangeRequestedDelegateField(displayIndex);
		}

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayIndex;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeFieldInfoPtr_displays;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeFieldInfoPtr__mainDisplay;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_get_available_Public_get_Boolean_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_set_automaticHDRTonemapping_Public_set_Void_Boolean_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_RequestHDRModeChange_Public_Void_Boolean_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_SetAutomaticHDRTonemapping_Private_Static_Void_Int32_Boolean_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_RequestHDRModeChangeInternal_Private_Static_Void_Int32_Boolean_0;

		// Token: 0x04000771 RID: 1905
		private static readonly HDROutputSettings.GetAutomaticHDRTonemappingDelegate GetAutomaticHDRTonemappingDelegateField;

		// Token: 0x04000772 RID: 1906
		private static readonly HDROutputSettings.GetGraphicsFormatDelegate GetGraphicsFormatDelegateField;

		// Token: 0x04000773 RID: 1907
		private static readonly HDROutputSettings.SetPaperWhiteNitsDelegate SetPaperWhiteNitsDelegateField;

		// Token: 0x04000774 RID: 1908
		private static readonly HDROutputSettings.GetHDRModeChangeRequestedDelegate GetHDRModeChangeRequestedDelegateField;

		// Token: 0x02000572 RID: 1394
		// (Invoke) Token: 0x0600339E RID: 13214
		private delegate bool GetAutomaticHDRTonemappingDelegate(int displayIndex);

		// Token: 0x02000573 RID: 1395
		// (Invoke) Token: 0x060033A0 RID: 13216
		private delegate UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormatDelegate(int displayIndex);

		// Token: 0x02000574 RID: 1396
		// (Invoke) Token: 0x060033A2 RID: 13218
		private delegate void SetPaperWhiteNitsDelegate(int displayIndex, float paperWhite);

		// Token: 0x02000575 RID: 1397
		// (Invoke) Token: 0x060033A4 RID: 13220
		private delegate bool GetHDRModeChangeRequestedDelegate(int displayIndex);
	}
}

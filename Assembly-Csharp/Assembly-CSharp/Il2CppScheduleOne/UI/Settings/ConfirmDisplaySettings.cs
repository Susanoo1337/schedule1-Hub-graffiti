using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000789 RID: 1929
	public class ConfirmDisplaySettings : MonoBehaviour
	{
		// Token: 0x0600BBC4 RID: 48068 RVA: 0x00303BC8 File Offset: 0x00301DC8
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmDisplaySettings()
		{
			Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "ConfirmDisplaySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr);
			ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "RevertTime");
			ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "SubtitleLabel");
			ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "timeUntilRevert");
			ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "oldSettings");
			ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, "newSettings");
			ConfirmDisplaySettings.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100687788);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100687789);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100687790);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100687791);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100687792);
			ConfirmDisplaySettings.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100687793);
			ConfirmDisplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr, 100687794);
		}

		// Token: 0x170038CA RID: 14538
		// (get) Token: 0x0600BBC5 RID: 48069 RVA: 0x00303CE8 File Offset: 0x00301EE8
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313245, XrefRangeEnd = 313255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600BBC6 RID: 48070 RVA: 0x00303D24 File Offset: 0x00301F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313255, XrefRangeEnd = 313265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBC7 RID: 48071 RVA: 0x00303D58 File Offset: 0x00301F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313265, XrefRangeEnd = 313275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(DisplaySettings _oldSettings, DisplaySettings _newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _oldSettings;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _newSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBC8 RID: 48072 RVA: 0x00303DA4 File Offset: 0x00301FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313275, XrefRangeEnd = 313287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBC9 RID: 48073 RVA: 0x00303DE8 File Offset: 0x00301FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313287, XrefRangeEnd = 313295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBCA RID: 48074 RVA: 0x00303E1C File Offset: 0x0030201C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 313313, RefRangeEnd = 313316, XrefRangeStart = 313295, XrefRangeEnd = 313313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool revert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref revert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBCB RID: 48075 RVA: 0x00303E5C File Offset: 0x0030205C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmDisplaySettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmDisplaySettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmDisplaySettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBCC RID: 48076 RVA: 0x000579DB File Offset: 0x00055BDB
		public ConfirmDisplaySettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x0600BBCD RID: 48077 RVA: 0x00303E98 File Offset: 0x00302098
		// (set) Token: 0x0600BBCE RID: 48078 RVA: 0x000579E4 File Offset: 0x00055BE4
		public unsafe static float RevertTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfirmDisplaySettings.NativeFieldInfoPtr_RevertTime, (void*)(&value));
			}
		}

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x0600BBCF RID: 48079 RVA: 0x00303EB4 File Offset: 0x003020B4
		// (set) Token: 0x0600BBD0 RID: 48080 RVA: 0x000579F2 File Offset: 0x00055BF2
		public unsafe TextMeshProUGUI SubtitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x0600BBD1 RID: 48081 RVA: 0x00303EE4 File Offset: 0x003020E4
		// (set) Token: 0x0600BBD2 RID: 48082 RVA: 0x00057A11 File Offset: 0x00055C11
		public unsafe float timeUntilRevert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_timeUntilRevert)) = value;
			}
		}

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x0600BBD3 RID: 48083 RVA: 0x00303F0C File Offset: 0x0030210C
		// (set) Token: 0x0600BBD4 RID: 48084 RVA: 0x00057A2C File Offset: 0x00055C2C
		public unsafe DisplaySettings oldSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_oldSettings)) = value;
			}
		}

		// Token: 0x170038C9 RID: 14537
		// (get) Token: 0x0600BBD5 RID: 48085 RVA: 0x00303F34 File Offset: 0x00302134
		// (set) Token: 0x0600BBD6 RID: 48086 RVA: 0x00057A47 File Offset: 0x00055C47
		public unsafe DisplaySettings newSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmDisplaySettings.NativeFieldInfoPtr_newSettings)) = value;
			}
		}

		// Token: 0x040080AF RID: 32943
		private static readonly IntPtr NativeFieldInfoPtr_RevertTime;

		// Token: 0x040080B0 RID: 32944
		private static readonly IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x040080B1 RID: 32945
		private static readonly IntPtr NativeFieldInfoPtr_timeUntilRevert;

		// Token: 0x040080B2 RID: 32946
		private static readonly IntPtr NativeFieldInfoPtr_oldSettings;

		// Token: 0x040080B3 RID: 32947
		private static readonly IntPtr NativeFieldInfoPtr_newSettings;

		// Token: 0x040080B4 RID: 32948
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040080B5 RID: 32949
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040080B6 RID: 32950
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_DisplaySettings_DisplaySettings_0;

		// Token: 0x040080B7 RID: 32951
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040080B8 RID: 32952
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040080B9 RID: 32953
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x040080BA RID: 32954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200040F RID: 1039
	[Serializable]
	public class AudioSettings : Object
	{
		// Token: 0x06005B70 RID: 23408 RVA: 0x001B69C8 File Offset: 0x001B4BC8
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSettings()
		{
			Il2CppClassPointerStore<AudioSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AudioSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr);
			AudioSettings.NativeFieldInfoPtr_MasterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "MasterVolume");
			AudioSettings.NativeFieldInfoPtr_AmbientVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "AmbientVolume");
			AudioSettings.NativeFieldInfoPtr_MusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "MusicVolume");
			AudioSettings.NativeFieldInfoPtr_SFXVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "SFXVolume");
			AudioSettings.NativeFieldInfoPtr_UIVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "UIVolume");
			AudioSettings.NativeFieldInfoPtr_DialogueVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "DialogueVolume");
			AudioSettings.NativeFieldInfoPtr_FootstepsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "FootstepsVolume");
			AudioSettings.NativeFieldInfoPtr_WeatherVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "WeatherVolume");
			AudioSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100675246);
		}

		// Token: 0x06005B71 RID: 23409 RVA: 0x001B6AAC File Offset: 0x001B4CAC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x0002B497 File Offset: 0x00029697
		public AudioSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06005B73 RID: 23411 RVA: 0x001B6AE8 File Offset: 0x001B4CE8
		// (set) Token: 0x06005B74 RID: 23412 RVA: 0x0002B4A0 File Offset: 0x000296A0
		public unsafe float MasterVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MasterVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MasterVolume)) = value;
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06005B75 RID: 23413 RVA: 0x001B6B10 File Offset: 0x001B4D10
		// (set) Token: 0x06005B76 RID: 23414 RVA: 0x0002B4BB File Offset: 0x000296BB
		public unsafe float AmbientVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_AmbientVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_AmbientVolume)) = value;
			}
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06005B77 RID: 23415 RVA: 0x001B6B38 File Offset: 0x001B4D38
		// (set) Token: 0x06005B78 RID: 23416 RVA: 0x0002B4D6 File Offset: 0x000296D6
		public unsafe float MusicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MusicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MusicVolume)) = value;
			}
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06005B79 RID: 23417 RVA: 0x001B6B60 File Offset: 0x001B4D60
		// (set) Token: 0x06005B7A RID: 23418 RVA: 0x0002B4F1 File Offset: 0x000296F1
		public unsafe float SFXVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_SFXVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_SFXVolume)) = value;
			}
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06005B7B RID: 23419 RVA: 0x001B6B88 File Offset: 0x001B4D88
		// (set) Token: 0x06005B7C RID: 23420 RVA: 0x0002B50C File Offset: 0x0002970C
		public unsafe float UIVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_UIVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_UIVolume)) = value;
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06005B7D RID: 23421 RVA: 0x001B6BB0 File Offset: 0x001B4DB0
		// (set) Token: 0x06005B7E RID: 23422 RVA: 0x0002B527 File Offset: 0x00029727
		public unsafe float DialogueVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_DialogueVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_DialogueVolume)) = value;
			}
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06005B7F RID: 23423 RVA: 0x001B6BD8 File Offset: 0x001B4DD8
		// (set) Token: 0x06005B80 RID: 23424 RVA: 0x0002B542 File Offset: 0x00029742
		public unsafe float FootstepsVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_FootstepsVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_FootstepsVolume)) = value;
			}
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06005B81 RID: 23425 RVA: 0x001B6C00 File Offset: 0x001B4E00
		// (set) Token: 0x06005B82 RID: 23426 RVA: 0x0002B55D File Offset: 0x0002975D
		public unsafe float WeatherVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_WeatherVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_WeatherVolume)) = value;
			}
		}

		// Token: 0x04003EAB RID: 16043
		private static readonly IntPtr NativeFieldInfoPtr_MasterVolume;

		// Token: 0x04003EAC RID: 16044
		private static readonly IntPtr NativeFieldInfoPtr_AmbientVolume;

		// Token: 0x04003EAD RID: 16045
		private static readonly IntPtr NativeFieldInfoPtr_MusicVolume;

		// Token: 0x04003EAE RID: 16046
		private static readonly IntPtr NativeFieldInfoPtr_SFXVolume;

		// Token: 0x04003EAF RID: 16047
		private static readonly IntPtr NativeFieldInfoPtr_UIVolume;

		// Token: 0x04003EB0 RID: 16048
		private static readonly IntPtr NativeFieldInfoPtr_DialogueVolume;

		// Token: 0x04003EB1 RID: 16049
		private static readonly IntPtr NativeFieldInfoPtr_FootstepsVolume;

		// Token: 0x04003EB2 RID: 16050
		private static readonly IntPtr NativeFieldInfoPtr_WeatherVolume;

		// Token: 0x04003EB3 RID: 16051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

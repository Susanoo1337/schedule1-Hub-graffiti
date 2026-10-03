using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Core.Audio;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000786 RID: 1926
	public class AudioSlider : SettingsSlider
	{
		// Token: 0x0600BBAE RID: 48046 RVA: 0x00303730 File Offset: 0x00301930
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSlider()
		{
			Il2CppClassPointerStore<AudioSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "AudioSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr);
			AudioSlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "MULTIPLIER");
			AudioSlider.NativeFieldInfoPtr_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "Master");
			AudioSlider.NativeFieldInfoPtr_AudioType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "AudioType");
			AudioSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100687778);
			AudioSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100687779);
			AudioSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100687780);
		}

		// Token: 0x0600BBAF RID: 48047 RVA: 0x003037D8 File Offset: 0x003019D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313155, XrefRangeEnd = 313165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBB0 RID: 48048 RVA: 0x00303814 File Offset: 0x00301A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313165, XrefRangeEnd = 313203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBB1 RID: 48049 RVA: 0x00303860 File Offset: 0x00301A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313203, XrefRangeEnd = 313204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BBB2 RID: 48050 RVA: 0x0005797C File Offset: 0x00055B7C
		public AudioSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0600BBB3 RID: 48051 RVA: 0x0030389C File Offset: 0x00301A9C
		// (set) Token: 0x0600BBB4 RID: 48052 RVA: 0x00057985 File Offset: 0x00055B85
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x0600BBB5 RID: 48053 RVA: 0x003038B8 File Offset: 0x00301AB8
		// (set) Token: 0x0600BBB6 RID: 48054 RVA: 0x00057993 File Offset: 0x00055B93
		public unsafe bool Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_Master);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_Master)) = value;
			}
		}

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x0600BBB7 RID: 48055 RVA: 0x003038E0 File Offset: 0x00301AE0
		// (set) Token: 0x0600BBB8 RID: 48056 RVA: 0x000579AE File Offset: 0x00055BAE
		public unsafe EAudioType AudioType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_AudioType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_AudioType)) = value;
			}
		}

		// Token: 0x040080A2 RID: 32930
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x040080A3 RID: 32931
		private static readonly IntPtr NativeFieldInfoPtr_Master;

		// Token: 0x040080A4 RID: 32932
		private static readonly IntPtr NativeFieldInfoPtr_AudioType;

		// Token: 0x040080A5 RID: 32933
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x040080A6 RID: 32934
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x040080A7 RID: 32935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

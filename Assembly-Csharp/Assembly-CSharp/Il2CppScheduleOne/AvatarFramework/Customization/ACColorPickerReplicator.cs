using System;
using Il2CppHSVPicker;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004B2 RID: 1202
	public class ACColorPickerReplicator : ACReplicator
	{
		// Token: 0x06006D90 RID: 28048 RVA: 0x001F59E4 File Offset: 0x001F3BE4
		// Note: this type is marked as 'beforefieldinit'.
		static ACColorPickerReplicator()
		{
			Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACColorPickerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr);
			ACColorPickerReplicator.NativeFieldInfoPtr_picker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, "picker");
			ACColorPickerReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, 100677607);
			ACColorPickerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, 100677608);
		}

		// Token: 0x06006D91 RID: 28049 RVA: 0x001F5A50 File Offset: 0x001F3C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222217, XrefRangeEnd = 222222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACColorPickerReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D92 RID: 28050 RVA: 0x001F5AA0 File Offset: 0x001F3CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222226, RefRangeEnd = 222227, XrefRangeStart = 222222, XrefRangeEnd = 222226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACColorPickerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACColorPickerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D93 RID: 28051 RVA: 0x00033BA4 File Offset: 0x00031DA4
		public ACColorPickerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021B2 RID: 8626
		// (get) Token: 0x06006D94 RID: 28052 RVA: 0x001F5ADC File Offset: 0x001F3CDC
		// (set) Token: 0x06006D95 RID: 28053 RVA: 0x00033BAD File Offset: 0x00031DAD
		public unsafe ColorPicker picker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACColorPickerReplicator.NativeFieldInfoPtr_picker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACColorPickerReplicator.NativeFieldInfoPtr_picker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B3B RID: 19259
		private static readonly IntPtr NativeFieldInfoPtr_picker;

		// Token: 0x04004B3C RID: 19260
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04004B3D RID: 19261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

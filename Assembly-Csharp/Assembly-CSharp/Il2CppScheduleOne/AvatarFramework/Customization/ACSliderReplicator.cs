using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004B5 RID: 1205
	public class ACSliderReplicator : ACReplicator
	{
		// Token: 0x06006DA0 RID: 28064 RVA: 0x001F5CB0 File Offset: 0x001F3EB0
		// Note: this type is marked as 'beforefieldinit'.
		static ACSliderReplicator()
		{
			Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACSliderReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr);
			ACSliderReplicator.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, "slider");
			ACSliderReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, 100677613);
			ACSliderReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, 100677614);
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x001F5D1C File Offset: 0x001F3F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222255, XrefRangeEnd = 222261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSliderReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x001F5D6C File Offset: 0x001F3F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222226, RefRangeEnd = 222227, XrefRangeStart = 222226, XrefRangeEnd = 222227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACSliderReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSliderReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x00033C36 File Offset: 0x00031E36
		public ACSliderReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021B4 RID: 8628
		// (get) Token: 0x06006DA4 RID: 28068 RVA: 0x001F5DA8 File Offset: 0x001F3FA8
		// (set) Token: 0x06006DA5 RID: 28069 RVA: 0x00033C3F File Offset: 0x00031E3F
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSliderReplicator.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSliderReplicator.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B43 RID: 19267
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04004B44 RID: 19268
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04004B45 RID: 19269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

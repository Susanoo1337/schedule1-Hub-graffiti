using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x0200047F RID: 1151
	public class RandomizedAudioSourceController : AudioSourceController
	{
		// Token: 0x060067CC RID: 26572 RVA: 0x001E23B8 File Offset: 0x001E05B8
		// Note: this type is marked as 'beforefieldinit'.
		static RandomizedAudioSourceController()
		{
			Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "RandomizedAudioSourceController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr);
			RandomizedAudioSourceController.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, "Clips");
			RandomizedAudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100676874);
			RandomizedAudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100676875);
			RandomizedAudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100676876);
		}

		// Token: 0x060067CD RID: 26573 RVA: 0x001E2438 File Offset: 0x001E0638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215435, XrefRangeEnd = 215451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomizedAudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x001E2474 File Offset: 0x001E0674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215451, XrefRangeEnd = 215466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayOneShot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomizedAudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x001E24B0 File Offset: 0x001E06B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomizedAudioSourceController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomizedAudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x00030E75 File Offset: 0x0002F075
		public RandomizedAudioSourceController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x060067D1 RID: 26577 RVA: 0x001E24EC File Offset: 0x001E06EC
		// (set) Token: 0x060067D2 RID: 26578 RVA: 0x00030E7E File Offset: 0x0002F07E
		public unsafe Il2CppReferenceArray<AudioClip> Clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomizedAudioSourceController.NativeFieldInfoPtr_Clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomizedAudioSourceController.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400476A RID: 18282
		private static readonly IntPtr NativeFieldInfoPtr_Clips;

		// Token: 0x0400476B RID: 18283
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x0400476C RID: 18284
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_0;

		// Token: 0x0400476D RID: 18285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

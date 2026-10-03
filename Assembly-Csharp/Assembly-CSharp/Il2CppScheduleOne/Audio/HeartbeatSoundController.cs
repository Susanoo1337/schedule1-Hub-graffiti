using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000476 RID: 1142
	public class HeartbeatSoundController : MonoBehaviour
	{
		// Token: 0x06006753 RID: 26451 RVA: 0x001E0BA0 File Offset: 0x001DEDA0
		// Note: this type is marked as 'beforefieldinit'.
		static HeartbeatSoundController()
		{
			Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "HeartbeatSoundController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr);
			HeartbeatSoundController.NativeFieldInfoPtr__volumeController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "_volumeController");
			HeartbeatSoundController.NativeFieldInfoPtr__pitchController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "_pitchController");
			HeartbeatSoundController.NativeFieldInfoPtr__sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "_sound");
			HeartbeatSoundController.NativeMethodInfoPtr_get_VolumeController_Public_get_FloatSmoother_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100676803);
			HeartbeatSoundController.NativeMethodInfoPtr_get_PitchController_Public_get_FloatSmoother_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100676804);
			HeartbeatSoundController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100676805);
			HeartbeatSoundController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100676806);
			HeartbeatSoundController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100676807);
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x06006754 RID: 26452 RVA: 0x001E0C70 File Offset: 0x001DEE70
		public unsafe FloatSmoother VolumeController
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr_get_VolumeController_Public_get_FloatSmoother_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr3) : null;
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x06006755 RID: 26453 RVA: 0x001E0CB0 File Offset: 0x001DEEB0
		public unsafe FloatSmoother PitchController
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr_get_PitchController_Public_get_FloatSmoother_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr3) : null;
			}
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x001E0CF0 File Offset: 0x001DEEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214947, XrefRangeEnd = 214952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006757 RID: 26455 RVA: 0x001E0D24 File Offset: 0x001DEF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214952, XrefRangeEnd = 214956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006758 RID: 26456 RVA: 0x001E0D58 File Offset: 0x001DEF58
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeartbeatSoundController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006759 RID: 26457 RVA: 0x00030B67 File Offset: 0x0002ED67
		public HeartbeatSoundController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x0600675A RID: 26458 RVA: 0x001E0D94 File Offset: 0x001DEF94
		// (set) Token: 0x0600675B RID: 26459 RVA: 0x00030B70 File Offset: 0x0002ED70
		public unsafe FloatSmoother _volumeController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr__volumeController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr__volumeController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x0600675C RID: 26460 RVA: 0x001E0DC4 File Offset: 0x001DEFC4
		// (set) Token: 0x0600675D RID: 26461 RVA: 0x00030B8F File Offset: 0x0002ED8F
		public unsafe FloatSmoother _pitchController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr__pitchController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr__pitchController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x0600675E RID: 26462 RVA: 0x001E0DF4 File Offset: 0x001DEFF4
		// (set) Token: 0x0600675F RID: 26463 RVA: 0x00030BAE File Offset: 0x0002EDAE
		public unsafe AudioSourceController _sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr__sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr__sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400471C RID: 18204
		private static readonly IntPtr NativeFieldInfoPtr__volumeController;

		// Token: 0x0400471D RID: 18205
		private static readonly IntPtr NativeFieldInfoPtr__pitchController;

		// Token: 0x0400471E RID: 18206
		private static readonly IntPtr NativeFieldInfoPtr__sound;

		// Token: 0x0400471F RID: 18207
		private static readonly IntPtr NativeMethodInfoPtr_get_VolumeController_Public_get_FloatSmoother_0;

		// Token: 0x04004720 RID: 18208
		private static readonly IntPtr NativeMethodInfoPtr_get_PitchController_Public_get_FloatSmoother_0;

		// Token: 0x04004721 RID: 18209
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004722 RID: 18210
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004723 RID: 18211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

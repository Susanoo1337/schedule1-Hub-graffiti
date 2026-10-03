using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000478 RID: 1144
	public class LegacyAudioSourceController : AudioSourceController
	{
		// Token: 0x06006763 RID: 26467 RVA: 0x001E0E6C File Offset: 0x001DF06C
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyAudioSourceController()
		{
			Il2CppClassPointerStore<LegacyAudioSourceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "LegacyAudioSourceController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyAudioSourceController>.NativeClassPtr);
			LegacyAudioSourceController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyAudioSourceController>.NativeClassPtr, 100676809);
			LegacyAudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyAudioSourceController>.NativeClassPtr, 100676810);
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x001E0EC4 File Offset: 0x001DF0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214956, XrefRangeEnd = 214958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyAudioSourceController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006765 RID: 26469 RVA: 0x001E0EF8 File Offset: 0x001DF0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyAudioSourceController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyAudioSourceController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyAudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x00030C05 File Offset: 0x0002EE05
		public LegacyAudioSourceController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004725 RID: 18213
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004726 RID: 18214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000481 RID: 1153
	public class SewerAmbientSound : MonoBehaviour
	{
		// Token: 0x060067E3 RID: 26595 RVA: 0x001E27B0 File Offset: 0x001E09B0
		// Note: this type is marked as 'beforefieldinit'.
		static SewerAmbientSound()
		{
			Il2CppClassPointerStore<SewerAmbientSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "SewerAmbientSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerAmbientSound>.NativeClassPtr);
			SewerAmbientSound.NativeFieldInfoPtr_SewerCameraPresense = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerAmbientSound>.NativeClassPtr, "SewerCameraPresense");
			SewerAmbientSound.NativeFieldInfoPtr_SewerAmbienceSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerAmbientSound>.NativeClassPtr, "SewerAmbienceSource");
			SewerAmbientSound.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerAmbientSound>.NativeClassPtr, 100676881);
			SewerAmbientSound.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerAmbientSound>.NativeClassPtr, 100676882);
			SewerAmbientSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerAmbientSound>.NativeClassPtr, 100676883);
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x001E2844 File Offset: 0x001E0A44
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerAmbientSound.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x001E2878 File Offset: 0x001E0A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215521, XrefRangeEnd = 215523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerAmbientSound.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x001E28AC File Offset: 0x001E0AAC
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SewerAmbientSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerAmbientSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerAmbientSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x00030F17 File Offset: 0x0002F117
		public SewerAmbientSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x060067E8 RID: 26600 RVA: 0x001E28E8 File Offset: 0x001E0AE8
		// (set) Token: 0x060067E9 RID: 26601 RVA: 0x00030F20 File Offset: 0x0002F120
		public unsafe SewerCameraPresense SewerCameraPresense
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerAmbientSound.NativeFieldInfoPtr_SewerCameraPresense);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SewerCameraPresense>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerAmbientSound.NativeFieldInfoPtr_SewerCameraPresense), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x060067EA RID: 26602 RVA: 0x001E2918 File Offset: 0x001E0B18
		// (set) Token: 0x060067EB RID: 26603 RVA: 0x00030F3F File Offset: 0x0002F13F
		public unsafe AudioSourceController SewerAmbienceSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerAmbientSound.NativeFieldInfoPtr_SewerAmbienceSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerAmbientSound.NativeFieldInfoPtr_SewerAmbienceSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004777 RID: 18295
		private static readonly IntPtr NativeFieldInfoPtr_SewerCameraPresense;

		// Token: 0x04004778 RID: 18296
		private static readonly IntPtr NativeFieldInfoPtr_SewerAmbienceSource;

		// Token: 0x04004779 RID: 18297
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400477A RID: 18298
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400477B RID: 18299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

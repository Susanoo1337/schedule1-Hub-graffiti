using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vision;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000484 RID: 1156
	public class SpottedTremolo : MonoBehaviour
	{
		// Token: 0x06006806 RID: 26630 RVA: 0x001E2F70 File Offset: 0x001E1170
		// Note: this type is marked as 'beforefieldinit'.
		static SpottedTremolo()
		{
			Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "SpottedTremolo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr);
			SpottedTremolo.NativeFieldInfoPtr_MinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MinVolume");
			SpottedTremolo.NativeFieldInfoPtr_MaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MaxVolume");
			SpottedTremolo.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MinPitch");
			SpottedTremolo.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "MaxPitch");
			SpottedTremolo.NativeFieldInfoPtr_SmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "SmoothTime");
			SpottedTremolo.NativeFieldInfoPtr__visibilityComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "_visibilityComponent");
			SpottedTremolo.NativeFieldInfoPtr__audio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "_audio");
			SpottedTremolo.NativeFieldInfoPtr__targetIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "_targetIntensity");
			SpottedTremolo.NativeFieldInfoPtr__smoothedIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, "_smoothedIntensity");
			SpottedTremolo.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, 100676901);
			SpottedTremolo.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, 100676902);
			SpottedTremolo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr, 100676903);
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x001E3090 File Offset: 0x001E1290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215809, XrefRangeEnd = 215813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpottedTremolo.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x001E30C4 File Offset: 0x001E12C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215813, XrefRangeEnd = 215831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpottedTremolo.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x001E30F8 File Offset: 0x001E12F8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpottedTremolo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpottedTremolo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpottedTremolo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x00030FFA File Offset: 0x0002F1FA
		public SpottedTremolo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x0600680B RID: 26635 RVA: 0x001E3134 File Offset: 0x001E1334
		// (set) Token: 0x0600680C RID: 26636 RVA: 0x00031003 File Offset: 0x0002F203
		public unsafe static float MinVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpottedTremolo.NativeFieldInfoPtr_MinVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpottedTremolo.NativeFieldInfoPtr_MinVolume, (void*)(&value));
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x0600680D RID: 26637 RVA: 0x001E3150 File Offset: 0x001E1350
		// (set) Token: 0x0600680E RID: 26638 RVA: 0x00031011 File Offset: 0x0002F211
		public unsafe static float MaxVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpottedTremolo.NativeFieldInfoPtr_MaxVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpottedTremolo.NativeFieldInfoPtr_MaxVolume, (void*)(&value));
			}
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x0600680F RID: 26639 RVA: 0x001E316C File Offset: 0x001E136C
		// (set) Token: 0x06006810 RID: 26640 RVA: 0x0003101F File Offset: 0x0002F21F
		public unsafe static float MinPitch
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpottedTremolo.NativeFieldInfoPtr_MinPitch, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpottedTremolo.NativeFieldInfoPtr_MinPitch, (void*)(&value));
			}
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x06006811 RID: 26641 RVA: 0x001E3188 File Offset: 0x001E1388
		// (set) Token: 0x06006812 RID: 26642 RVA: 0x0003102D File Offset: 0x0002F22D
		public unsafe static float MaxPitch
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpottedTremolo.NativeFieldInfoPtr_MaxPitch, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpottedTremolo.NativeFieldInfoPtr_MaxPitch, (void*)(&value));
			}
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x06006813 RID: 26643 RVA: 0x001E31A4 File Offset: 0x001E13A4
		// (set) Token: 0x06006814 RID: 26644 RVA: 0x0003103B File Offset: 0x0002F23B
		public unsafe static float SmoothTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpottedTremolo.NativeFieldInfoPtr_SmoothTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpottedTremolo.NativeFieldInfoPtr_SmoothTime, (void*)(&value));
			}
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x06006815 RID: 26645 RVA: 0x001E31C0 File Offset: 0x001E13C0
		// (set) Token: 0x06006816 RID: 26646 RVA: 0x00031049 File Offset: 0x0002F249
		public unsafe EntityVisibility _visibilityComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr__visibilityComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityVisibility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr__visibilityComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD7 RID: 8151
		// (get) Token: 0x06006817 RID: 26647 RVA: 0x001E31F0 File Offset: 0x001E13F0
		// (set) Token: 0x06006818 RID: 26648 RVA: 0x00031068 File Offset: 0x0002F268
		public unsafe AudioSourceController _audio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr__audio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr__audio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x06006819 RID: 26649 RVA: 0x001E3220 File Offset: 0x001E1420
		// (set) Token: 0x0600681A RID: 26650 RVA: 0x00031087 File Offset: 0x0002F287
		public unsafe float _targetIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr__targetIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr__targetIntensity)) = value;
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x0600681B RID: 26651 RVA: 0x001E3248 File Offset: 0x001E1448
		// (set) Token: 0x0600681C RID: 26652 RVA: 0x000310A2 File Offset: 0x0002F2A2
		public unsafe float _smoothedIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr__smoothedIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpottedTremolo.NativeFieldInfoPtr__smoothedIntensity)) = value;
			}
		}

		// Token: 0x0400478D RID: 18317
		private static readonly IntPtr NativeFieldInfoPtr_MinVolume;

		// Token: 0x0400478E RID: 18318
		private static readonly IntPtr NativeFieldInfoPtr_MaxVolume;

		// Token: 0x0400478F RID: 18319
		private static readonly IntPtr NativeFieldInfoPtr_MinPitch;

		// Token: 0x04004790 RID: 18320
		private static readonly IntPtr NativeFieldInfoPtr_MaxPitch;

		// Token: 0x04004791 RID: 18321
		private static readonly IntPtr NativeFieldInfoPtr_SmoothTime;

		// Token: 0x04004792 RID: 18322
		private static readonly IntPtr NativeFieldInfoPtr__visibilityComponent;

		// Token: 0x04004793 RID: 18323
		private static readonly IntPtr NativeFieldInfoPtr__audio;

		// Token: 0x04004794 RID: 18324
		private static readonly IntPtr NativeFieldInfoPtr__targetIntensity;

		// Token: 0x04004795 RID: 18325
		private static readonly IntPtr NativeFieldInfoPtr__smoothedIntensity;

		// Token: 0x04004796 RID: 18326
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004797 RID: 18327
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004798 RID: 18328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

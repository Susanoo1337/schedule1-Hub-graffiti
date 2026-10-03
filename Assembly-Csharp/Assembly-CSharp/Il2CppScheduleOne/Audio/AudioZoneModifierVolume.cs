using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000473 RID: 1139
	public class AudioZoneModifierVolume : MonoBehaviour
	{
		// Token: 0x0600670D RID: 26381 RVA: 0x001E0084 File Offset: 0x001DE284
		// Note: this type is marked as 'beforefieldinit'.
		static AudioZoneModifierVolume()
		{
			Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioZoneModifierVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr);
			AudioZoneModifierVolume.NativeFieldInfoPtr__zones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "_zones");
			AudioZoneModifierVolume.NativeFieldInfoPtr__volumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "_volumeMultiplier");
			AudioZoneModifierVolume.NativeFieldInfoPtr__colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "_colliders");
			AudioZoneModifierVolume.NativeMethodInfoPtr_get_VolumeMultiplier_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100676784);
			AudioZoneModifierVolume.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100676785);
			AudioZoneModifierVolume.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100676786);
			AudioZoneModifierVolume.NativeMethodInfoPtr_IsCameraWithinVolume_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100676787);
			AudioZoneModifierVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100676788);
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x0600670E RID: 26382 RVA: 0x001E0154 File Offset: 0x001DE354
		public unsafe virtual float VolumeMultiplier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55725, RefRangeEnd = 55726, XrefRangeStart = 55725, XrefRangeEnd = 55726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr_get_VolumeMultiplier_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x001E0190 File Offset: 0x001DE390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214750, XrefRangeEnd = 214762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x001E01C4 File Offset: 0x001DE3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214762, XrefRangeEnd = 214828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006711 RID: 26385 RVA: 0x001E01F8 File Offset: 0x001DE3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214828, XrefRangeEnd = 214849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCameraWithinVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr_IsCameraWithinVolume_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006712 RID: 26386 RVA: 0x001E0234 File Offset: 0x001DE434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214849, XrefRangeEnd = 214857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioZoneModifierVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006713 RID: 26387 RVA: 0x00030889 File Offset: 0x0002EA89
		public AudioZoneModifierVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x06006714 RID: 26388 RVA: 0x001E0270 File Offset: 0x001DE470
		// (set) Token: 0x06006715 RID: 26389 RVA: 0x00030892 File Offset: 0x0002EA92
		public unsafe List<AudioZone> _zones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr__zones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioZone>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr__zones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06006716 RID: 26390 RVA: 0x001E02A0 File Offset: 0x001DE4A0
		// (set) Token: 0x06006717 RID: 26391 RVA: 0x000308B1 File Offset: 0x0002EAB1
		public unsafe float _volumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr__volumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr__volumeMultiplier)) = value;
			}
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06006718 RID: 26392 RVA: 0x001E02C8 File Offset: 0x001DE4C8
		// (set) Token: 0x06006719 RID: 26393 RVA: 0x000308CC File Offset: 0x0002EACC
		public unsafe Il2CppReferenceArray<BoxCollider> _colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr__colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr__colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046F5 RID: 18165
		private static readonly IntPtr NativeFieldInfoPtr__zones;

		// Token: 0x040046F6 RID: 18166
		private static readonly IntPtr NativeFieldInfoPtr__volumeMultiplier;

		// Token: 0x040046F7 RID: 18167
		private static readonly IntPtr NativeFieldInfoPtr__colliders;

		// Token: 0x040046F8 RID: 18168
		private static readonly IntPtr NativeMethodInfoPtr_get_VolumeMultiplier_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040046F9 RID: 18169
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040046FA RID: 18170
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x040046FB RID: 18171
		private static readonly IntPtr NativeMethodInfoPtr_IsCameraWithinVolume_Private_Boolean_0;

		// Token: 0x040046FC RID: 18172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B48 RID: 2888
		[ObfuscatedName("ScheduleOne.Audio.AudioZoneModifierVolume+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E72E RID: 59182 RVA: 0x00385DC0 File Offset: 0x00383FC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AudioZoneModifierVolume.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZoneModifierVolume.__c>.NativeClassPtr);
				AudioZoneModifierVolume.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume.__c>.NativeClassPtr, "<>9");
				AudioZoneModifierVolume.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume.__c>.NativeClassPtr, "<>9__7_0");
				AudioZoneModifierVolume.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume.__c>.NativeClassPtr, 100676790);
				AudioZoneModifierVolume.__c.NativeMethodInfoPtr__IsCameraWithinVolume_b__7_0_Internal_Boolean_BoxCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume.__c>.NativeClassPtr, 100676791);
			}

			// Token: 0x0600E72F RID: 59183 RVA: 0x00385E3C File Offset: 0x0038403C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZoneModifierVolume.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E730 RID: 59184 RVA: 0x00385E78 File Offset: 0x00384078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214742, XrefRangeEnd = 214750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsCameraWithinVolume_b__7_0(BoxCollider c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.__c.NativeMethodInfoPtr__IsCameraWithinVolume_b__7_0_Internal_Boolean_BoxCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E731 RID: 59185 RVA: 0x0006D0C5 File Offset: 0x0006B2C5
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004629 RID: 17961
			// (get) Token: 0x0600E732 RID: 59186 RVA: 0x00385EC8 File Offset: 0x003840C8
			// (set) Token: 0x0600E733 RID: 59187 RVA: 0x0006D0CE File Offset: 0x0006B2CE
			public unsafe static AudioZoneModifierVolume.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AudioZoneModifierVolume.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioZoneModifierVolume.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AudioZoneModifierVolume.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700462A RID: 17962
			// (get) Token: 0x0600E734 RID: 59188 RVA: 0x00385EF0 File Offset: 0x003840F0
			// (set) Token: 0x0600E735 RID: 59189 RVA: 0x0006D0E0 File Offset: 0x0006B2E0
			public unsafe static Func<BoxCollider, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AudioZoneModifierVolume.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<BoxCollider, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AudioZoneModifierVolume.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CF2 RID: 40178
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009CF3 RID: 40179
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04009CF4 RID: 40180
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CF5 RID: 40181
			private static readonly IntPtr NativeMethodInfoPtr__IsCameraWithinVolume_b__7_0_Internal_Boolean_BoxCollider_0;
		}
	}
}

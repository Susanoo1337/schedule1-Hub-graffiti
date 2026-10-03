using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x02000475 RID: 1141
	public class ButtonSound : MonoBehaviour
	{
		// Token: 0x0600673C RID: 26428 RVA: 0x001E07B8 File Offset: 0x001DE9B8
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonSound()
		{
			Il2CppClassPointerStore<ButtonSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "ButtonSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr);
			ButtonSound.NativeFieldInfoPtr__playSoundOnClickStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "_playSoundOnClickStart");
			ButtonSound.NativeFieldInfoPtr__hoverClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "_hoverClip");
			ButtonSound.NativeFieldInfoPtr__hoverVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "_hoverVolume");
			ButtonSound.NativeFieldInfoPtr__clickClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "_clickClip");
			ButtonSound.NativeFieldInfoPtr__clickVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "_clickVolume");
			ButtonSound.NativeFieldInfoPtr__audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "_audioSource");
			ButtonSound.NativeFieldInfoPtr__button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "_button");
			ButtonSound.NativeFieldInfoPtr__eventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "_eventTrigger");
			ButtonSound.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676796);
			ButtonSound.NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676797);
			ButtonSound.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676798);
			ButtonSound.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676799);
			ButtonSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, 100676800);
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x001E08EC File Offset: 0x001DEAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214884, XrefRangeEnd = 214911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x001E0920 File Offset: 0x001DEB20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214936, RefRangeEnd = 214939, XrefRangeStart = 214911, XrefRangeEnd = 214936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEventTrigger(EventTrigger eventTrigger, EventTriggerType eventTriggerType, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventTrigger);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventTriggerType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600673F RID: 26431 RVA: 0x001E0984 File Offset: 0x001DEB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214939, XrefRangeEnd = 214944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ButtonSound.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006740 RID: 26432 RVA: 0x001E09C0 File Offset: 0x001DEBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214944, XrefRangeEnd = 214946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ButtonSound.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006741 RID: 26433 RVA: 0x001E09FC File Offset: 0x001DEBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214946, XrefRangeEnd = 214947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x00030A72 File Offset: 0x0002EC72
		public ButtonSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06006743 RID: 26435 RVA: 0x001E0A38 File Offset: 0x001DEC38
		// (set) Token: 0x06006744 RID: 26436 RVA: 0x00030A7B File Offset: 0x0002EC7B
		public unsafe bool _playSoundOnClickStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__playSoundOnClickStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__playSoundOnClickStart)) = value;
			}
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06006745 RID: 26437 RVA: 0x001E0A60 File Offset: 0x001DEC60
		// (set) Token: 0x06006746 RID: 26438 RVA: 0x00030A96 File Offset: 0x0002EC96
		public unsafe AudioClip _hoverClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__hoverClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__hoverClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06006747 RID: 26439 RVA: 0x001E0A90 File Offset: 0x001DEC90
		// (set) Token: 0x06006748 RID: 26440 RVA: 0x00030AB5 File Offset: 0x0002ECB5
		public unsafe float _hoverVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__hoverVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__hoverVolume)) = value;
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x06006749 RID: 26441 RVA: 0x001E0AB8 File Offset: 0x001DECB8
		// (set) Token: 0x0600674A RID: 26442 RVA: 0x00030AD0 File Offset: 0x0002ECD0
		public unsafe AudioClip _clickClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__clickClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__clickClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x0600674B RID: 26443 RVA: 0x001E0AE8 File Offset: 0x001DECE8
		// (set) Token: 0x0600674C RID: 26444 RVA: 0x00030AEF File Offset: 0x0002ECEF
		public unsafe float _clickVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__clickVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__clickVolume)) = value;
			}
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x0600674D RID: 26445 RVA: 0x001E0B10 File Offset: 0x001DED10
		// (set) Token: 0x0600674E RID: 26446 RVA: 0x00030B0A File Offset: 0x0002ED0A
		public unsafe AudioSourceController _audioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__audioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__audioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x0600674F RID: 26447 RVA: 0x001E0B40 File Offset: 0x001DED40
		// (set) Token: 0x06006750 RID: 26448 RVA: 0x00030B29 File Offset: 0x0002ED29
		public unsafe Button _button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x06006751 RID: 26449 RVA: 0x001E0B70 File Offset: 0x001DED70
		// (set) Token: 0x06006752 RID: 26450 RVA: 0x00030B48 File Offset: 0x0002ED48
		public unsafe EventTrigger _eventTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__eventTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.NativeFieldInfoPtr__eventTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400470F RID: 18191
		private static readonly IntPtr NativeFieldInfoPtr__playSoundOnClickStart;

		// Token: 0x04004710 RID: 18192
		private static readonly IntPtr NativeFieldInfoPtr__hoverClip;

		// Token: 0x04004711 RID: 18193
		private static readonly IntPtr NativeFieldInfoPtr__hoverVolume;

		// Token: 0x04004712 RID: 18194
		private static readonly IntPtr NativeFieldInfoPtr__clickClip;

		// Token: 0x04004713 RID: 18195
		private static readonly IntPtr NativeFieldInfoPtr__clickVolume;

		// Token: 0x04004714 RID: 18196
		private static readonly IntPtr NativeFieldInfoPtr__audioSource;

		// Token: 0x04004715 RID: 18197
		private static readonly IntPtr NativeFieldInfoPtr__button;

		// Token: 0x04004716 RID: 18198
		private static readonly IntPtr NativeFieldInfoPtr__eventTrigger;

		// Token: 0x04004717 RID: 18199
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04004718 RID: 18200
		private static readonly IntPtr NativeMethodInfoPtr_AddEventTrigger_Public_Void_EventTrigger_EventTriggerType_Action_0;

		// Token: 0x04004719 RID: 18201
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0;

		// Token: 0x0400471A RID: 18202
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0;

		// Token: 0x0400471B RID: 18203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B49 RID: 2889
		[ObfuscatedName("ScheduleOne.Audio.ButtonSound+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E736 RID: 59190 RVA: 0x00385F18 File Offset: 0x00384118
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ButtonSound>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr);
				ButtonSound.__c__DisplayClass9_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr, "action");
				ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr, 100676801);
				ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr, 100676802);
			}

			// Token: 0x0600E737 RID: 59191 RVA: 0x00385F80 File Offset: 0x00384180
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonSound.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E738 RID: 59192 RVA: 0x00385FBC File Offset: 0x003841BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddEventTrigger_b__0(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonSound.__c__DisplayClass9_0.NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E739 RID: 59193 RVA: 0x0006D0F2 File Offset: 0x0006B2F2
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700462B RID: 17963
			// (get) Token: 0x0600E73A RID: 59194 RVA: 0x00386000 File Offset: 0x00384200
			// (set) Token: 0x0600E73B RID: 59195 RVA: 0x0006D0FB File Offset: 0x0006B2FB
			public unsafe Action action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.__c__DisplayClass9_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ButtonSound.__c__DisplayClass9_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CF6 RID: 40182
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04009CF7 RID: 40183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CF8 RID: 40184
			private static readonly IntPtr NativeMethodInfoPtr__AddEventTrigger_b__0_Internal_Void_BaseEventData_0;
		}
	}
}

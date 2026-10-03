using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.CustomUI
{
	// Token: 0x02000843 RID: 2115
	public class UISelectable_Slider : UISelectable
	{
		// Token: 0x0600CE13 RID: 52755 RVA: 0x0033C5EC File Offset: 0x0033A7EC
		// Note: this type is marked as 'beforefieldinit'.
		static UISelectable_Slider()
		{
			Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.CustomUI", "UISelectable_Slider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr);
			UISelectable_Slider.NativeFieldInfoPtr_DelayBeforeRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "DelayBeforeRepeat");
			UISelectable_Slider.NativeFieldInfoPtr_SlowestRepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "SlowestRepeatDelay");
			UISelectable_Slider.NativeFieldInfoPtr_FastestRepeatDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "FastestRepeatDelay");
			UISelectable_Slider.NativeFieldInfoPtr_VerticalMoveThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "VerticalMoveThreshold");
			UISelectable_Slider.NativeFieldInfoPtr_SliderMoveThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "SliderMoveThreshold");
			UISelectable_Slider.NativeFieldInfoPtr_TimeToReachFastestRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "TimeToReachFastestRepeat");
			UISelectable_Slider.NativeFieldInfoPtr__increment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "_increment");
			UISelectable_Slider.NativeFieldInfoPtr__bigIncrements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "_bigIncrements");
			UISelectable_Slider.NativeFieldInfoPtr__bigIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "_bigIncrement");
			UISelectable_Slider.NativeFieldInfoPtr__wasNavPressedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "_wasNavPressedLastFrame");
			UISelectable_Slider.NativeFieldInfoPtr__timeBeforeNextRepeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "_timeBeforeNextRepeat");
			UISelectable_Slider.NativeFieldInfoPtr__timeSinceNavStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "_timeSinceNavStart");
			UISelectable_Slider.NativeFieldInfoPtr__slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, "_slider");
			UISelectable_Slider.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, 100689834);
			UISelectable_Slider.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, 100689835);
			UISelectable_Slider.NativeMethodInfoPtr_DetectInput_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, 100689836);
			UISelectable_Slider.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, 100689837);
			UISelectable_Slider.NativeMethodInfoPtr_Increment_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, 100689838);
			UISelectable_Slider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr, 100689839);
		}

		// Token: 0x0600CE14 RID: 52756 RVA: 0x0033C798 File Offset: 0x0033A998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337187, XrefRangeEnd = 337192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable_Slider.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE15 RID: 52757 RVA: 0x0033C7D4 File Offset: 0x0033A9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337192, XrefRangeEnd = 337193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_Slider.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE16 RID: 52758 RVA: 0x0033C808 File Offset: 0x0033AA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337193, XrefRangeEnd = 337233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DetectInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable_Slider.NativeMethodInfoPtr_DetectInput_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE17 RID: 52759 RVA: 0x0033C844 File Offset: 0x0033AA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337233, XrefRangeEnd = 337234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable_Slider.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE18 RID: 52760 RVA: 0x0033C894 File Offset: 0x0033AA94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337235, RefRangeEnd = 337237, XrefRangeStart = 337234, XrefRangeEnd = 337235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Increment(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_Slider.NativeMethodInfoPtr_Increment_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE19 RID: 52761 RVA: 0x0033C8D4 File Offset: 0x0033AAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337237, XrefRangeEnd = 337238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable_Slider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISelectable_Slider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_Slider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE1A RID: 52762 RVA: 0x00061E92 File Offset: 0x00060092
		public UISelectable_Slider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x0600CE1B RID: 52763 RVA: 0x0033C910 File Offset: 0x0033AB10
		// (set) Token: 0x0600CE1C RID: 52764 RVA: 0x00061E9B File Offset: 0x0006009B
		public unsafe static float DelayBeforeRepeat
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UISelectable_Slider.NativeFieldInfoPtr_DelayBeforeRepeat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UISelectable_Slider.NativeFieldInfoPtr_DelayBeforeRepeat, (void*)(&value));
			}
		}

		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x0600CE1D RID: 52765 RVA: 0x0033C92C File Offset: 0x0033AB2C
		// (set) Token: 0x0600CE1E RID: 52766 RVA: 0x00061EA9 File Offset: 0x000600A9
		public unsafe static float SlowestRepeatDelay
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UISelectable_Slider.NativeFieldInfoPtr_SlowestRepeatDelay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UISelectable_Slider.NativeFieldInfoPtr_SlowestRepeatDelay, (void*)(&value));
			}
		}

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x0600CE1F RID: 52767 RVA: 0x0033C948 File Offset: 0x0033AB48
		// (set) Token: 0x0600CE20 RID: 52768 RVA: 0x00061EB7 File Offset: 0x000600B7
		public unsafe static float FastestRepeatDelay
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UISelectable_Slider.NativeFieldInfoPtr_FastestRepeatDelay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UISelectable_Slider.NativeFieldInfoPtr_FastestRepeatDelay, (void*)(&value));
			}
		}

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x0600CE21 RID: 52769 RVA: 0x0033C964 File Offset: 0x0033AB64
		// (set) Token: 0x0600CE22 RID: 52770 RVA: 0x00061EC5 File Offset: 0x000600C5
		public unsafe static float VerticalMoveThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UISelectable_Slider.NativeFieldInfoPtr_VerticalMoveThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UISelectable_Slider.NativeFieldInfoPtr_VerticalMoveThreshold, (void*)(&value));
			}
		}

		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x0600CE23 RID: 52771 RVA: 0x0033C980 File Offset: 0x0033AB80
		// (set) Token: 0x0600CE24 RID: 52772 RVA: 0x00061ED3 File Offset: 0x000600D3
		public unsafe static float SliderMoveThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UISelectable_Slider.NativeFieldInfoPtr_SliderMoveThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UISelectable_Slider.NativeFieldInfoPtr_SliderMoveThreshold, (void*)(&value));
			}
		}

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x0600CE25 RID: 52773 RVA: 0x0033C99C File Offset: 0x0033AB9C
		// (set) Token: 0x0600CE26 RID: 52774 RVA: 0x00061EE1 File Offset: 0x000600E1
		public unsafe static float TimeToReachFastestRepeat
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UISelectable_Slider.NativeFieldInfoPtr_TimeToReachFastestRepeat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UISelectable_Slider.NativeFieldInfoPtr_TimeToReachFastestRepeat, (void*)(&value));
			}
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x0600CE27 RID: 52775 RVA: 0x0033C9B8 File Offset: 0x0033ABB8
		// (set) Token: 0x0600CE28 RID: 52776 RVA: 0x00061EEF File Offset: 0x000600EF
		public unsafe float _increment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__increment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__increment)) = value;
			}
		}

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x0600CE29 RID: 52777 RVA: 0x0033C9E0 File Offset: 0x0033ABE0
		// (set) Token: 0x0600CE2A RID: 52778 RVA: 0x00061F0A File Offset: 0x0006010A
		public unsafe bool _bigIncrements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__bigIncrements);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__bigIncrements)) = value;
			}
		}

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x0600CE2B RID: 52779 RVA: 0x0033CA08 File Offset: 0x0033AC08
		// (set) Token: 0x0600CE2C RID: 52780 RVA: 0x00061F25 File Offset: 0x00060125
		public unsafe float _bigIncrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__bigIncrement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__bigIncrement)) = value;
			}
		}

		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x0600CE2D RID: 52781 RVA: 0x0033CA30 File Offset: 0x0033AC30
		// (set) Token: 0x0600CE2E RID: 52782 RVA: 0x00061F40 File Offset: 0x00060140
		public unsafe bool _wasNavPressedLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__wasNavPressedLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__wasNavPressedLastFrame)) = value;
			}
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x0600CE2F RID: 52783 RVA: 0x0033CA58 File Offset: 0x0033AC58
		// (set) Token: 0x0600CE30 RID: 52784 RVA: 0x00061F5B File Offset: 0x0006015B
		public unsafe float _timeBeforeNextRepeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__timeBeforeNextRepeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__timeBeforeNextRepeat)) = value;
			}
		}

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x0600CE31 RID: 52785 RVA: 0x0033CA80 File Offset: 0x0033AC80
		// (set) Token: 0x0600CE32 RID: 52786 RVA: 0x00061F76 File Offset: 0x00060176
		public unsafe float _timeSinceNavStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__timeSinceNavStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__timeSinceNavStart)) = value;
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x0600CE33 RID: 52787 RVA: 0x0033CAA8 File Offset: 0x0033ACA8
		// (set) Token: 0x0600CE34 RID: 52788 RVA: 0x00061F91 File Offset: 0x00060191
		public unsafe Slider _slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_Slider.NativeFieldInfoPtr__slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008C51 RID: 35921
		private static readonly IntPtr NativeFieldInfoPtr_DelayBeforeRepeat;

		// Token: 0x04008C52 RID: 35922
		private static readonly IntPtr NativeFieldInfoPtr_SlowestRepeatDelay;

		// Token: 0x04008C53 RID: 35923
		private static readonly IntPtr NativeFieldInfoPtr_FastestRepeatDelay;

		// Token: 0x04008C54 RID: 35924
		private static readonly IntPtr NativeFieldInfoPtr_VerticalMoveThreshold;

		// Token: 0x04008C55 RID: 35925
		private static readonly IntPtr NativeFieldInfoPtr_SliderMoveThreshold;

		// Token: 0x04008C56 RID: 35926
		private static readonly IntPtr NativeFieldInfoPtr_TimeToReachFastestRepeat;

		// Token: 0x04008C57 RID: 35927
		private static readonly IntPtr NativeFieldInfoPtr__increment;

		// Token: 0x04008C58 RID: 35928
		private static readonly IntPtr NativeFieldInfoPtr__bigIncrements;

		// Token: 0x04008C59 RID: 35929
		private static readonly IntPtr NativeFieldInfoPtr__bigIncrement;

		// Token: 0x04008C5A RID: 35930
		private static readonly IntPtr NativeFieldInfoPtr__wasNavPressedLastFrame;

		// Token: 0x04008C5B RID: 35931
		private static readonly IntPtr NativeFieldInfoPtr__timeBeforeNextRepeat;

		// Token: 0x04008C5C RID: 35932
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceNavStart;

		// Token: 0x04008C5D RID: 35933
		private static readonly IntPtr NativeFieldInfoPtr__slider;

		// Token: 0x04008C5E RID: 35934
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008C5F RID: 35935
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04008C60 RID: 35936
		private static readonly IntPtr NativeMethodInfoPtr_DetectInput_Protected_Virtual_New_Void_0;

		// Token: 0x04008C61 RID: 35937
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04008C62 RID: 35938
		private static readonly IntPtr NativeMethodInfoPtr_Increment_Private_Void_Single_0;

		// Token: 0x04008C63 RID: 35939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

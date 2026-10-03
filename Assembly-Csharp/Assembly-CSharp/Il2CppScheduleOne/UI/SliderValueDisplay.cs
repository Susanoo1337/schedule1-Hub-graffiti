using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200075D RID: 1885
	public class SliderValueDisplay : MonoBehaviour
	{
		// Token: 0x0600B7D7 RID: 47063 RVA: 0x002F7FCC File Offset: 0x002F61CC
		// Note: this type is marked as 'beforefieldinit'.
		static SliderValueDisplay()
		{
			Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SliderValueDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr);
			SliderValueDisplay.NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr, "_label");
			SliderValueDisplay.NativeFieldInfoPtr__tmpLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr, "_tmpLabel");
			SliderValueDisplay.NativeFieldInfoPtr__slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr, "_slider");
			SliderValueDisplay.NativeFieldInfoPtr__displayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr, "_displayMode");
			SliderValueDisplay.NativeFieldInfoPtr_showDecimalPlaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr, "showDecimalPlaces");
			SliderValueDisplay.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr, 100687363);
			SliderValueDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr, 100687364);
			SliderValueDisplay.NativeMethodInfoPtr_SliderChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr, 100687365);
			SliderValueDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr, 100687366);
		}

		// Token: 0x0600B7D8 RID: 47064 RVA: 0x002F80B0 File Offset: 0x002F62B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308672, XrefRangeEnd = 308682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderValueDisplay.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7D9 RID: 47065 RVA: 0x002F80E4 File Offset: 0x002F62E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308682, XrefRangeEnd = 308684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderValueDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7DA RID: 47066 RVA: 0x002F8118 File Offset: 0x002F6318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308708, RefRangeEnd = 308709, XrefRangeStart = 308684, XrefRangeEnd = 308708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SliderChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderValueDisplay.NativeMethodInfoPtr_SliderChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7DB RID: 47067 RVA: 0x002F8158 File Offset: 0x002F6358
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SliderValueDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliderValueDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SliderValueDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7DC RID: 47068 RVA: 0x00055689 File Offset: 0x00053889
		public SliderValueDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x0600B7DD RID: 47069 RVA: 0x002F8194 File Offset: 0x002F6394
		// (set) Token: 0x0600B7DE RID: 47070 RVA: 0x00055692 File Offset: 0x00053892
		public unsafe Text _label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderValueDisplay.NativeFieldInfoPtr__label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderValueDisplay.NativeFieldInfoPtr__label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x0600B7DF RID: 47071 RVA: 0x002F81C4 File Offset: 0x002F63C4
		// (set) Token: 0x0600B7E0 RID: 47072 RVA: 0x000556B1 File Offset: 0x000538B1
		public unsafe TextMeshProUGUI _tmpLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderValueDisplay.NativeFieldInfoPtr__tmpLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderValueDisplay.NativeFieldInfoPtr__tmpLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x0600B7E1 RID: 47073 RVA: 0x002F81F4 File Offset: 0x002F63F4
		// (set) Token: 0x0600B7E2 RID: 47074 RVA: 0x000556D0 File Offset: 0x000538D0
		public unsafe Slider _slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderValueDisplay.NativeFieldInfoPtr__slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderValueDisplay.NativeFieldInfoPtr__slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x0600B7E3 RID: 47075 RVA: 0x002F8224 File Offset: 0x002F6424
		// (set) Token: 0x0600B7E4 RID: 47076 RVA: 0x000556EF File Offset: 0x000538EF
		public unsafe SliderValueDisplay.EDisplayMode _displayMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderValueDisplay.NativeFieldInfoPtr__displayMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderValueDisplay.NativeFieldInfoPtr__displayMode)) = value;
			}
		}

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x0600B7E5 RID: 47077 RVA: 0x002F824C File Offset: 0x002F644C
		// (set) Token: 0x0600B7E6 RID: 47078 RVA: 0x0005570A File Offset: 0x0005390A
		public unsafe bool showDecimalPlaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderValueDisplay.NativeFieldInfoPtr_showDecimalPlaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SliderValueDisplay.NativeFieldInfoPtr_showDecimalPlaces)) = value;
			}
		}

		// Token: 0x04007E43 RID: 32323
		private static readonly IntPtr NativeFieldInfoPtr__label;

		// Token: 0x04007E44 RID: 32324
		private static readonly IntPtr NativeFieldInfoPtr__tmpLabel;

		// Token: 0x04007E45 RID: 32325
		private static readonly IntPtr NativeFieldInfoPtr__slider;

		// Token: 0x04007E46 RID: 32326
		private static readonly IntPtr NativeFieldInfoPtr__displayMode;

		// Token: 0x04007E47 RID: 32327
		private static readonly IntPtr NativeFieldInfoPtr_showDecimalPlaces;

		// Token: 0x04007E48 RID: 32328
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007E49 RID: 32329
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04007E4A RID: 32330
		private static readonly IntPtr NativeMethodInfoPtr_SliderChanged_Private_Void_Single_0;

		// Token: 0x04007E4B RID: 32331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CF4 RID: 3316
		[OriginalName("Assembly-CSharp.dll", "", "EDisplayMode")]
		public enum EDisplayMode
		{
			// Token: 0x0400A6F6 RID: 42742
			Normal,
			// Token: 0x0400A6F7 RID: 42743
			Percentage,
			// Token: 0x0400A6F8 RID: 42744
			Money
		}
	}
}

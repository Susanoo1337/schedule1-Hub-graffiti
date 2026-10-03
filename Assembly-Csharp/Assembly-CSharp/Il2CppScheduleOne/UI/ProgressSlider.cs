using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000755 RID: 1877
	public class ProgressSlider : Singleton<ProgressSlider>
	{
		// Token: 0x0600B71A RID: 46874 RVA: 0x002F5B78 File Offset: 0x002F3D78
		// Note: this type is marked as 'beforefieldinit'.
		static ProgressSlider()
		{
			Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ProgressSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr);
			ProgressSlider.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Container");
			ProgressSlider.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Label");
			ProgressSlider.NativeFieldInfoPtr_Slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "Slider");
			ProgressSlider.NativeFieldInfoPtr_SliderFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "SliderFill");
			ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, "progressSetThisFrame");
			ProgressSlider.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100687252);
			ProgressSlider.NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100687253);
			ProgressSlider.NativeMethodInfoPtr_Configure_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100687254);
			ProgressSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr, 100687255);
		}

		// Token: 0x0600B71B RID: 46875 RVA: 0x002F5C5C File Offset: 0x002F3E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307527, XrefRangeEnd = 307529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B71C RID: 46876 RVA: 0x002F5C90 File Offset: 0x002F3E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307530, RefRangeEnd = 307531, XrefRangeStart = 307529, XrefRangeEnd = 307530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B71D RID: 46877 RVA: 0x002F5CD0 File Offset: 0x002F3ED0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307531, RefRangeEnd = 307533, XrefRangeStart = 307531, XrefRangeEnd = 307531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(string label, Color sliderFillColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sliderFillColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr_Configure_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B71E RID: 46878 RVA: 0x002F5D20 File Offset: 0x002F3F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307533, XrefRangeEnd = 307536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProgressSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProgressSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B71F RID: 46879 RVA: 0x00054FEE File Offset: 0x000531EE
		public ProgressSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x0600B720 RID: 46880 RVA: 0x002F5D5C File Offset: 0x002F3F5C
		// (set) Token: 0x0600B721 RID: 46881 RVA: 0x00054FF7 File Offset: 0x000531F7
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x0600B722 RID: 46882 RVA: 0x002F5D8C File Offset: 0x002F3F8C
		// (set) Token: 0x0600B723 RID: 46883 RVA: 0x00055016 File Offset: 0x00053216
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x0600B724 RID: 46884 RVA: 0x002F5DBC File Offset: 0x002F3FBC
		// (set) Token: 0x0600B725 RID: 46885 RVA: 0x00055035 File Offset: 0x00053235
		public unsafe Slider Slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_Slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x0600B726 RID: 46886 RVA: 0x002F5DEC File Offset: 0x002F3FEC
		// (set) Token: 0x0600B727 RID: 46887 RVA: 0x00055054 File Offset: 0x00053254
		public unsafe Image SliderFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_SliderFill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_SliderFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0600B728 RID: 46888 RVA: 0x002F5E1C File Offset: 0x002F401C
		// (set) Token: 0x0600B729 RID: 46889 RVA: 0x00055073 File Offset: 0x00053273
		public unsafe bool progressSetThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProgressSlider.NativeFieldInfoPtr_progressSetThisFrame)) = value;
			}
		}

		// Token: 0x04007DCB RID: 32203
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007DCC RID: 32204
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04007DCD RID: 32205
		private static readonly IntPtr NativeFieldInfoPtr_Slider;

		// Token: 0x04007DCE RID: 32206
		private static readonly IntPtr NativeFieldInfoPtr_SliderFill;

		// Token: 0x04007DCF RID: 32207
		private static readonly IntPtr NativeFieldInfoPtr_progressSetThisFrame;

		// Token: 0x04007DD0 RID: 32208
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007DD1 RID: 32209
		private static readonly IntPtr NativeMethodInfoPtr_ShowProgress_Public_Void_Single_0;

		// Token: 0x04007DD2 RID: 32210
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_String_Color_0;

		// Token: 0x04007DD3 RID: 32211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

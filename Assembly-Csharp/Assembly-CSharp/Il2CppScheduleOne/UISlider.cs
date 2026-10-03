using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x020000B5 RID: 181
	public class UISlider : UIOption
	{
		// Token: 0x06001069 RID: 4201 RVA: 0x000B20F4 File Offset: 0x000B02F4
		// Note: this type is marked as 'beforefieldinit'.
		static UISlider()
		{
			Il2CppClassPointerStore<UISlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UISlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISlider>.NativeClassPtr);
			UISlider.NativeFieldInfoPtr_canUpdateValueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISlider>.NativeClassPtr, "canUpdateValueText");
			UISlider.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISlider>.NativeClassPtr, "slider");
			UISlider.NativeFieldInfoPtr_stepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISlider>.NativeClassPtr, "stepSize");
			UISlider.NativeFieldInfoPtr_valueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISlider>.NativeClassPtr, "valueText");
			UISlider.NativeFieldInfoPtr_OnChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISlider>.NativeClassPtr, "OnChanged");
			UISlider.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISlider>.NativeClassPtr, 100665378);
			UISlider.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISlider>.NativeClassPtr, 100665379);
			UISlider.NativeMethodInfoPtr_MoveLeft_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISlider>.NativeClassPtr, 100665380);
			UISlider.NativeMethodInfoPtr_MoveRight_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISlider>.NativeClassPtr, 100665381);
			UISlider.NativeMethodInfoPtr_UpdateSliderChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISlider>.NativeClassPtr, 100665382);
			UISlider.NativeMethodInfoPtr_UpdateText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISlider>.NativeClassPtr, 100665383);
			UISlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISlider>.NativeClassPtr, 100665384);
			UISlider.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISlider>.NativeClassPtr, 100665385);
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x000B2228 File Offset: 0x000B0428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84969, XrefRangeEnd = 84985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISlider.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x000B2264 File Offset: 0x000B0464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34910, RefRangeEnd = 34911, XrefRangeStart = 34910, XrefRangeEnd = 34911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISlider.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x000B22A0 File Offset: 0x000B04A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84985, XrefRangeEnd = 84988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISlider.NativeMethodInfoPtr_MoveLeft_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x000B22DC File Offset: 0x000B04DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84988, XrefRangeEnd = 84991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISlider.NativeMethodInfoPtr_MoveRight_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x000B2318 File Offset: 0x000B0518
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84995, RefRangeEnd = 84998, XrefRangeStart = 84991, XrefRangeEnd = 84995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSliderChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISlider.NativeMethodInfoPtr_UpdateSliderChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x000B234C File Offset: 0x000B054C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 85001, RefRangeEnd = 85003, XrefRangeStart = 84998, XrefRangeEnd = 85001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISlider.NativeMethodInfoPtr_UpdateText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x000B2380 File Offset: 0x000B0580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85003, XrefRangeEnd = 85004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x000B23BC File Offset: 0x000B05BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85004, XrefRangeEnd = 85005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__5_0(float v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISlider.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0000995A File Offset: 0x00007B5A
		public UISlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x000B23FC File Offset: 0x000B05FC
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x00009963 File Offset: 0x00007B63
		public unsafe bool canUpdateValueText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISlider.NativeFieldInfoPtr_canUpdateValueText);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISlider.NativeFieldInfoPtr_canUpdateValueText)) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x000B2424 File Offset: 0x000B0624
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x0000997E File Offset: 0x00007B7E
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISlider.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISlider.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x000B2454 File Offset: 0x000B0654
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x0000999D File Offset: 0x00007B9D
		public unsafe float stepSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISlider.NativeFieldInfoPtr_stepSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISlider.NativeFieldInfoPtr_stepSize)) = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x000B247C File Offset: 0x000B067C
		// (set) Token: 0x0600107A RID: 4218 RVA: 0x000099B8 File Offset: 0x00007BB8
		public unsafe TextMeshProUGUI valueText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISlider.NativeFieldInfoPtr_valueText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISlider.NativeFieldInfoPtr_valueText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x000B24AC File Offset: 0x000B06AC
		// (set) Token: 0x0600107C RID: 4220 RVA: 0x000099D7 File Offset: 0x00007BD7
		public unsafe UnityEvent<float> OnChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISlider.NativeFieldInfoPtr_OnChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISlider.NativeFieldInfoPtr_OnChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeFieldInfoPtr_canUpdateValueText;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeFieldInfoPtr_stepSize;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeFieldInfoPtr_valueText;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeFieldInfoPtr_OnChanged;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Protected_Virtual_Void_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Protected_Virtual_Void_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSliderChanged_Private_Void_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_UpdateText_Private_Void_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_0_Private_Void_Single_0;
	}
}

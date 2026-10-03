using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000808 RID: 2056
	public class InputPromptsItemUI : MonoBehaviour
	{
		// Token: 0x0600C7B2 RID: 51122 RVA: 0x00327F68 File Offset: 0x00326168
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsItemUI()
		{
			Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptsItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr);
			InputPromptsItemUI.NativeFieldInfoPtr__promptLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, "_promptLabel");
			InputPromptsItemUI.NativeFieldInfoPtr__promptImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, "_promptImages");
			InputPromptsItemUI.NativeFieldInfoPtr__pulseDimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, "_pulseDimDuration");
			InputPromptsItemUI.NativeFieldInfoPtr__pulseBrightDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, "_pulseBrightDuration");
			InputPromptsItemUI.NativeFieldInfoPtr__pulseDimMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, "_pulseDimMultiplier");
			InputPromptsItemUI.NativeFieldInfoPtr__isPulsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, "_isPulsing");
			InputPromptsItemUI.NativeFieldInfoPtr__animElapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, "_animElapsedTime");
			InputPromptsItemUI.NativeFieldInfoPtr__promptAnimColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, "_promptAnimColors");
			InputPromptsItemUI.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, 100689122);
			InputPromptsItemUI.NativeMethodInfoPtr_Set_Public_Void_String_Color_List_1_InputPromptsBindingData_Boolean_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, 100689123);
			InputPromptsItemUI.NativeMethodInfoPtr_ResetPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, 100689124);
			InputPromptsItemUI.NativeMethodInfoPtr_HandlePulseAnimation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, 100689125);
			InputPromptsItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, 100689126);
		}

		// Token: 0x0600C7B3 RID: 51123 RVA: 0x0032809C File Offset: 0x0032629C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329007, XrefRangeEnd = 329008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsItemUI.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7B4 RID: 51124 RVA: 0x003280D0 File Offset: 0x003262D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329039, RefRangeEnd = 329041, XrefRangeStart = 329008, XrefRangeEnd = 329039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(string promptLabel, Color promptColor, List<InputPromptsBindingData> bindingDataList, bool isPulsing, List<string> bindingDisplayStrings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(promptLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref promptColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindingDataList);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPulsing;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindingDisplayStrings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsItemUI.NativeMethodInfoPtr_Set_Public_Void_String_Color_List_1_InputPromptsBindingData_Boolean_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7B5 RID: 51125 RVA: 0x00328154 File Offset: 0x00326354
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 329061, RefRangeEnd = 329065, XrefRangeStart = 329041, XrefRangeEnd = 329061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsItemUI.NativeMethodInfoPtr_ResetPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7B6 RID: 51126 RVA: 0x00328188 File Offset: 0x00326388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329077, RefRangeEnd = 329078, XrefRangeStart = 329065, XrefRangeEnd = 329077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandlePulseAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsItemUI.NativeMethodInfoPtr_HandlePulseAnimation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7B7 RID: 51127 RVA: 0x003281BC File Offset: 0x003263BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329078, XrefRangeEnd = 329086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7B8 RID: 51128 RVA: 0x0005E643 File Offset: 0x0005C843
		public InputPromptsItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C9D RID: 15517
		// (get) Token: 0x0600C7B9 RID: 51129 RVA: 0x003281F8 File Offset: 0x003263F8
		// (set) Token: 0x0600C7BA RID: 51130 RVA: 0x0005E64C File Offset: 0x0005C84C
		public unsafe TextMeshProUGUI _promptLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__promptLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__promptLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x0600C7BB RID: 51131 RVA: 0x00328228 File Offset: 0x00326428
		// (set) Token: 0x0600C7BC RID: 51132 RVA: 0x0005E66B File Offset: 0x0005C86B
		public unsafe List<InputPromptsItemUI.PromptImage> _promptImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__promptImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputPromptsItemUI.PromptImage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__promptImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x0600C7BD RID: 51133 RVA: 0x00328258 File Offset: 0x00326458
		// (set) Token: 0x0600C7BE RID: 51134 RVA: 0x0005E68A File Offset: 0x0005C88A
		public unsafe float _pulseDimDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__pulseDimDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__pulseDimDuration)) = value;
			}
		}

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x0600C7BF RID: 51135 RVA: 0x00328280 File Offset: 0x00326480
		// (set) Token: 0x0600C7C0 RID: 51136 RVA: 0x0005E6A5 File Offset: 0x0005C8A5
		public unsafe float _pulseBrightDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__pulseBrightDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__pulseBrightDuration)) = value;
			}
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x0600C7C1 RID: 51137 RVA: 0x003282A8 File Offset: 0x003264A8
		// (set) Token: 0x0600C7C2 RID: 51138 RVA: 0x0005E6C0 File Offset: 0x0005C8C0
		public unsafe float _pulseDimMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__pulseDimMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__pulseDimMultiplier)) = value;
			}
		}

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x0600C7C3 RID: 51139 RVA: 0x003282D0 File Offset: 0x003264D0
		// (set) Token: 0x0600C7C4 RID: 51140 RVA: 0x0005E6DB File Offset: 0x0005C8DB
		public unsafe bool _isPulsing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__isPulsing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__isPulsing)) = value;
			}
		}

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x0600C7C5 RID: 51141 RVA: 0x003282F8 File Offset: 0x003264F8
		// (set) Token: 0x0600C7C6 RID: 51142 RVA: 0x0005E6F6 File Offset: 0x0005C8F6
		public unsafe float _animElapsedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__animElapsedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__animElapsedTime)) = value;
			}
		}

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x0600C7C7 RID: 51143 RVA: 0x00328320 File Offset: 0x00326520
		// (set) Token: 0x0600C7C8 RID: 51144 RVA: 0x0005E711 File Offset: 0x0005C911
		public unsafe List<Color> _promptAnimColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__promptAnimColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.NativeFieldInfoPtr__promptAnimColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400881A RID: 34842
		private static readonly IntPtr NativeFieldInfoPtr__promptLabel;

		// Token: 0x0400881B RID: 34843
		private static readonly IntPtr NativeFieldInfoPtr__promptImages;

		// Token: 0x0400881C RID: 34844
		private static readonly IntPtr NativeFieldInfoPtr__pulseDimDuration;

		// Token: 0x0400881D RID: 34845
		private static readonly IntPtr NativeFieldInfoPtr__pulseBrightDuration;

		// Token: 0x0400881E RID: 34846
		private static readonly IntPtr NativeFieldInfoPtr__pulseDimMultiplier;

		// Token: 0x0400881F RID: 34847
		private static readonly IntPtr NativeFieldInfoPtr__isPulsing;

		// Token: 0x04008820 RID: 34848
		private static readonly IntPtr NativeFieldInfoPtr__animElapsedTime;

		// Token: 0x04008821 RID: 34849
		private static readonly IntPtr NativeFieldInfoPtr__promptAnimColors;

		// Token: 0x04008822 RID: 34850
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04008823 RID: 34851
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_Color_List_1_InputPromptsBindingData_Boolean_List_1_String_0;

		// Token: 0x04008824 RID: 34852
		private static readonly IntPtr NativeMethodInfoPtr_ResetPrompt_Public_Void_0;

		// Token: 0x04008825 RID: 34853
		private static readonly IntPtr NativeMethodInfoPtr_HandlePulseAnimation_Private_Void_0;

		// Token: 0x04008826 RID: 34854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D6F RID: 3439
		[Serializable]
		public class PromptImage : Il2CppSystem.Object
		{
			// Token: 0x0600FB43 RID: 64323 RVA: 0x003BFEB4 File Offset: 0x003BE0B4
			// Note: this type is marked as 'beforefieldinit'.
			static PromptImage()
			{
				Il2CppClassPointerStore<InputPromptsItemUI.PromptImage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputPromptsItemUI>.NativeClassPtr, "PromptImage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsItemUI.PromptImage>.NativeClassPtr);
				InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI.PromptImage>.NativeClassPtr, "Image");
				InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Backdrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI.PromptImage>.NativeClassPtr, "Backdrop");
				InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI.PromptImage>.NativeClassPtr, "Layout");
				InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsItemUI.PromptImage>.NativeClassPtr, "Label");
				InputPromptsItemUI.PromptImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsItemUI.PromptImage>.NativeClassPtr, 100689127);
			}

			// Token: 0x0600FB44 RID: 64324 RVA: 0x003BFF44 File Offset: 0x003BE144
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PromptImage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsItemUI.PromptImage>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsItemUI.PromptImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB45 RID: 64325 RVA: 0x00076E3F File Offset: 0x0007503F
			public PromptImage(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C58 RID: 19544
			// (get) Token: 0x0600FB46 RID: 64326 RVA: 0x003BFF80 File Offset: 0x003BE180
			// (set) Token: 0x0600FB47 RID: 64327 RVA: 0x00076E48 File Offset: 0x00075048
			public unsafe Image Image
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Image);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C59 RID: 19545
			// (get) Token: 0x0600FB48 RID: 64328 RVA: 0x003BFFB0 File Offset: 0x003BE1B0
			// (set) Token: 0x0600FB49 RID: 64329 RVA: 0x00076E67 File Offset: 0x00075067
			public unsafe Image Backdrop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Backdrop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Backdrop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C5A RID: 19546
			// (get) Token: 0x0600FB4A RID: 64330 RVA: 0x003BFFE0 File Offset: 0x003BE1E0
			// (set) Token: 0x0600FB4B RID: 64331 RVA: 0x00076E86 File Offset: 0x00075086
			public unsafe LayoutElement Layout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Layout);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Layout), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C5B RID: 19547
			// (get) Token: 0x0600FB4C RID: 64332 RVA: 0x003C0010 File Offset: 0x003BE210
			// (set) Token: 0x0600FB4D RID: 64333 RVA: 0x00076EA5 File Offset: 0x000750A5
			public unsafe TextMeshProUGUI Label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Label);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsItemUI.PromptImage.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A986 RID: 43398
			private static readonly IntPtr NativeFieldInfoPtr_Image;

			// Token: 0x0400A987 RID: 43399
			private static readonly IntPtr NativeFieldInfoPtr_Backdrop;

			// Token: 0x0400A988 RID: 43400
			private static readonly IntPtr NativeFieldInfoPtr_Layout;

			// Token: 0x0400A989 RID: 43401
			private static readonly IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x0400A98A RID: 43402
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

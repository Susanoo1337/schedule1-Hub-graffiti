using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000803 RID: 2051
	public class InputPrompt : MonoBehaviour
	{
		// Token: 0x0600C747 RID: 51015 RVA: 0x00326F3C File Offset: 0x0032513C
		// Note: this type is marked as 'beforefieldinit'.
		static InputPrompt()
		{
			Il2CppClassPointerStore<InputPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr);
			InputPrompt.NativeFieldInfoPtr_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Spacing");
			InputPrompt.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Actions");
			InputPrompt.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Label");
			InputPrompt.NativeFieldInfoPtr_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Alignment");
			InputPrompt.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Container");
			InputPrompt.NativeFieldInfoPtr_ImagesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "ImagesContainer");
			InputPrompt.NativeFieldInfoPtr_LabelComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "LabelComponent");
			InputPrompt.NativeFieldInfoPtr_Shade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Shade");
			InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "OverridePromptImageColor");
			InputPrompt.NativeFieldInfoPtr_PromptImageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "PromptImageColor");
			InputPrompt.NativeFieldInfoPtr_promptImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "promptImages");
			InputPrompt.NativeFieldInfoPtr_displayedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "displayedActions");
			InputPrompt.NativeFieldInfoPtr_AppliedAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "AppliedAlignment");
			InputPrompt.NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100689102);
			InputPrompt.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100689103);
			InputPrompt.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100689104);
			InputPrompt.NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100689105);
			InputPrompt.NativeMethodInfoPtr_SetLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100689106);
			InputPrompt.NativeMethodInfoPtr_UpdateShade_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100689107);
			InputPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100689108);
		}

		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x0600C748 RID: 51016 RVA: 0x003270FC File Offset: 0x003252FC
		public unsafe InputPromptsManager manager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328772, XrefRangeEnd = 328781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputPromptsManager>(intPtr3) : null;
			}
		}

		// Token: 0x0600C749 RID: 51017 RVA: 0x0032713C File Offset: 0x0032533C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328781, XrefRangeEnd = 328785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C74A RID: 51018 RVA: 0x00327170 File Offset: 0x00325370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229661, RefRangeEnd = 229663, XrefRangeStart = 229661, XrefRangeEnd = 229663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C74B RID: 51019 RVA: 0x003271A4 File Offset: 0x003253A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328884, RefRangeEnd = 328885, XrefRangeStart = 328785, XrefRangeEnd = 328884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPromptImages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C74C RID: 51020 RVA: 0x003271D8 File Offset: 0x003253D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328885, XrefRangeEnd = 328888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLabel(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_SetLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C74D RID: 51021 RVA: 0x0032721C File Offset: 0x0032541C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328891, RefRangeEnd = 328893, XrefRangeStart = 328888, XrefRangeEnd = 328891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_UpdateShade_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C74E RID: 51022 RVA: 0x00327250 File Offset: 0x00325450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328893, XrefRangeEnd = 328913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPrompt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C74F RID: 51023 RVA: 0x0005E1B2 File Offset: 0x0005C3B2
		public InputPrompt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C75 RID: 15477
		// (get) Token: 0x0600C750 RID: 51024 RVA: 0x0032728C File Offset: 0x0032548C
		// (set) Token: 0x0600C751 RID: 51025 RVA: 0x0005E1BB File Offset: 0x0005C3BB
		public unsafe static float Spacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InputPrompt.NativeFieldInfoPtr_Spacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputPrompt.NativeFieldInfoPtr_Spacing, (void*)(&value));
			}
		}

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x0600C752 RID: 51026 RVA: 0x003272A8 File Offset: 0x003254A8
		// (set) Token: 0x0600C753 RID: 51027 RVA: 0x0005E1C9 File Offset: 0x0005C3C9
		public unsafe List<InputActionReference> Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x0600C754 RID: 51028 RVA: 0x003272D8 File Offset: 0x003254D8
		// (set) Token: 0x0600C755 RID: 51029 RVA: 0x0005E1E8 File Offset: 0x0005C3E8
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x0600C756 RID: 51030 RVA: 0x00327300 File Offset: 0x00325500
		// (set) Token: 0x0600C757 RID: 51031 RVA: 0x0005E207 File Offset: 0x0005C407
		public unsafe InputPrompt.EInputPromptAlignment Alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Alignment)) = value;
			}
		}

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x0600C758 RID: 51032 RVA: 0x00327328 File Offset: 0x00325528
		// (set) Token: 0x0600C759 RID: 51033 RVA: 0x0005E222 File Offset: 0x0005C422
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x0600C75A RID: 51034 RVA: 0x00327358 File Offset: 0x00325558
		// (set) Token: 0x0600C75B RID: 51035 RVA: 0x0005E241 File Offset: 0x0005C441
		public unsafe RectTransform ImagesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_ImagesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_ImagesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C7B RID: 15483
		// (get) Token: 0x0600C75C RID: 51036 RVA: 0x00327388 File Offset: 0x00325588
		// (set) Token: 0x0600C75D RID: 51037 RVA: 0x0005E260 File Offset: 0x0005C460
		public unsafe TextMeshProUGUI LabelComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_LabelComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_LabelComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C7C RID: 15484
		// (get) Token: 0x0600C75E RID: 51038 RVA: 0x003273B8 File Offset: 0x003255B8
		// (set) Token: 0x0600C75F RID: 51039 RVA: 0x0005E27F File Offset: 0x0005C47F
		public unsafe RectTransform Shade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Shade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Shade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C7D RID: 15485
		// (get) Token: 0x0600C760 RID: 51040 RVA: 0x003273E8 File Offset: 0x003255E8
		// (set) Token: 0x0600C761 RID: 51041 RVA: 0x0005E29E File Offset: 0x0005C49E
		public unsafe bool OverridePromptImageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor)) = value;
			}
		}

		// Token: 0x17003C7E RID: 15486
		// (get) Token: 0x0600C762 RID: 51042 RVA: 0x00327410 File Offset: 0x00325610
		// (set) Token: 0x0600C763 RID: 51043 RVA: 0x0005E2B9 File Offset: 0x0005C4B9
		public unsafe Color PromptImageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_PromptImageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_PromptImageColor)) = value;
			}
		}

		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x0600C764 RID: 51044 RVA: 0x00327438 File Offset: 0x00325638
		// (set) Token: 0x0600C765 RID: 51045 RVA: 0x0005E2D4 File Offset: 0x0005C4D4
		public unsafe List<PromptImage> promptImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_promptImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PromptImage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_promptImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x0600C766 RID: 51046 RVA: 0x00327468 File Offset: 0x00325668
		// (set) Token: 0x0600C767 RID: 51047 RVA: 0x0005E2F3 File Offset: 0x0005C4F3
		public unsafe List<InputActionReference> displayedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_displayedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_displayedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x0600C768 RID: 51048 RVA: 0x00327498 File Offset: 0x00325698
		// (set) Token: 0x0600C769 RID: 51049 RVA: 0x0005E312 File Offset: 0x0005C512
		public unsafe InputPrompt.EInputPromptAlignment AppliedAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_AppliedAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_AppliedAlignment)) = value;
			}
		}

		// Token: 0x040087E0 RID: 34784
		private static readonly IntPtr NativeFieldInfoPtr_Spacing;

		// Token: 0x040087E1 RID: 34785
		private static readonly IntPtr NativeFieldInfoPtr_Actions;

		// Token: 0x040087E2 RID: 34786
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x040087E3 RID: 34787
		private static readonly IntPtr NativeFieldInfoPtr_Alignment;

		// Token: 0x040087E4 RID: 34788
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040087E5 RID: 34789
		private static readonly IntPtr NativeFieldInfoPtr_ImagesContainer;

		// Token: 0x040087E6 RID: 34790
		private static readonly IntPtr NativeFieldInfoPtr_LabelComponent;

		// Token: 0x040087E7 RID: 34791
		private static readonly IntPtr NativeFieldInfoPtr_Shade;

		// Token: 0x040087E8 RID: 34792
		private static readonly IntPtr NativeFieldInfoPtr_OverridePromptImageColor;

		// Token: 0x040087E9 RID: 34793
		private static readonly IntPtr NativeFieldInfoPtr_PromptImageColor;

		// Token: 0x040087EA RID: 34794
		private static readonly IntPtr NativeFieldInfoPtr_promptImages;

		// Token: 0x040087EB RID: 34795
		private static readonly IntPtr NativeFieldInfoPtr_displayedActions;

		// Token: 0x040087EC RID: 34796
		private static readonly IntPtr NativeFieldInfoPtr_AppliedAlignment;

		// Token: 0x040087ED RID: 34797
		private static readonly IntPtr NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0;

		// Token: 0x040087EE RID: 34798
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040087EF RID: 34799
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040087F0 RID: 34800
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0;

		// Token: 0x040087F1 RID: 34801
		private static readonly IntPtr NativeMethodInfoPtr_SetLabel_Public_Void_String_0;

		// Token: 0x040087F2 RID: 34802
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShade_Private_Void_0;

		// Token: 0x040087F3 RID: 34803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D6D RID: 3437
		[OriginalName("Assembly-CSharp.dll", "", "EInputPromptAlignment")]
		public enum EInputPromptAlignment
		{
			// Token: 0x0400A980 RID: 43392
			Left,
			// Token: 0x0400A981 RID: 43393
			Middle,
			// Token: 0x0400A982 RID: 43394
			Right
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x0200080E RID: 2062
	public class InputPromptsPanelUI : MonoBehaviour
	{
		// Token: 0x0600C830 RID: 51248 RVA: 0x00329B44 File Offset: 0x00327D44
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsPanelUI()
		{
			Il2CppClassPointerStore<InputPromptsPanelUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptsPanelUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsPanelUI>.NativeClassPtr);
			InputPromptsPanelUI.NativeFieldInfoPtr__promptsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsPanelUI>.NativeClassPtr, "_promptsContainer");
			InputPromptsPanelUI.NativeFieldInfoPtr__promptItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsPanelUI>.NativeClassPtr, "_promptItemPrefab");
			InputPromptsPanelUI.NativeFieldInfoPtr__activePrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsPanelUI>.NativeClassPtr, "_activePrompts");
			InputPromptsPanelUI.NativeFieldInfoPtr__inactivePrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsPanelUI>.NativeClassPtr, "_inactivePrompts");
			InputPromptsPanelUI.NativeMethodInfoPtr_AddPrompt_Public_Void_String_Color_List_1_InputPromptsBindingData_Boolean_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsPanelUI>.NativeClassPtr, 100689178);
			InputPromptsPanelUI.NativeMethodInfoPtr_ClearPrompts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsPanelUI>.NativeClassPtr, 100689179);
			InputPromptsPanelUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsPanelUI>.NativeClassPtr, 100689180);
		}

		// Token: 0x0600C831 RID: 51249 RVA: 0x00329C00 File Offset: 0x00327E00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330224, RefRangeEnd = 330226, XrefRangeStart = 330205, XrefRangeEnd = 330224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPrompt(string promptLabel, Color promptColor, List<InputPromptsBindingData> bindingDataList, bool isPulsing, List<string> bindingDisplayStrings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(promptLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref promptColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindingDataList);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPulsing;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindingDisplayStrings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsPanelUI.NativeMethodInfoPtr_AddPrompt_Public_Void_String_Color_List_1_InputPromptsBindingData_Boolean_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C832 RID: 51250 RVA: 0x00329C84 File Offset: 0x00327E84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 330248, RefRangeEnd = 330251, XrefRangeStart = 330226, XrefRangeEnd = 330248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPrompts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsPanelUI.NativeMethodInfoPtr_ClearPrompts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C833 RID: 51251 RVA: 0x00329CB8 File Offset: 0x00327EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330251, XrefRangeEnd = 330266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsPanelUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsPanelUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsPanelUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C834 RID: 51252 RVA: 0x0005EA78 File Offset: 0x0005CC78
		public InputPromptsPanelUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003CBF RID: 15551
		// (get) Token: 0x0600C835 RID: 51253 RVA: 0x00329CF4 File Offset: 0x00327EF4
		// (set) Token: 0x0600C836 RID: 51254 RVA: 0x0005EA81 File Offset: 0x0005CC81
		public unsafe Transform _promptsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsPanelUI.NativeFieldInfoPtr__promptsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsPanelUI.NativeFieldInfoPtr__promptsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CC0 RID: 15552
		// (get) Token: 0x0600C837 RID: 51255 RVA: 0x00329D24 File Offset: 0x00327F24
		// (set) Token: 0x0600C838 RID: 51256 RVA: 0x0005EAA0 File Offset: 0x0005CCA0
		public unsafe InputPromptsItemUI _promptItemPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsPanelUI.NativeFieldInfoPtr__promptItemPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsPanelUI.NativeFieldInfoPtr__promptItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CC1 RID: 15553
		// (get) Token: 0x0600C839 RID: 51257 RVA: 0x00329D54 File Offset: 0x00327F54
		// (set) Token: 0x0600C83A RID: 51258 RVA: 0x0005EABF File Offset: 0x0005CCBF
		public unsafe List<InputPromptsItemUI> _activePrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsPanelUI.NativeFieldInfoPtr__activePrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputPromptsItemUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsPanelUI.NativeFieldInfoPtr__activePrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CC2 RID: 15554
		// (get) Token: 0x0600C83B RID: 51259 RVA: 0x00329D84 File Offset: 0x00327F84
		// (set) Token: 0x0600C83C RID: 51260 RVA: 0x0005EADE File Offset: 0x0005CCDE
		public unsafe Queue<InputPromptsItemUI> _inactivePrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsPanelUI.NativeFieldInfoPtr__inactivePrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<InputPromptsItemUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsPanelUI.NativeFieldInfoPtr__inactivePrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008875 RID: 34933
		private static readonly IntPtr NativeFieldInfoPtr__promptsContainer;

		// Token: 0x04008876 RID: 34934
		private static readonly IntPtr NativeFieldInfoPtr__promptItemPrefab;

		// Token: 0x04008877 RID: 34935
		private static readonly IntPtr NativeFieldInfoPtr__activePrompts;

		// Token: 0x04008878 RID: 34936
		private static readonly IntPtr NativeFieldInfoPtr__inactivePrompts;

		// Token: 0x04008879 RID: 34937
		private static readonly IntPtr NativeMethodInfoPtr_AddPrompt_Public_Void_String_Color_List_1_InputPromptsBindingData_Boolean_List_1_String_0;

		// Token: 0x0400887A RID: 34938
		private static readonly IntPtr NativeMethodInfoPtr_ClearPrompts_Public_Void_0;

		// Token: 0x0400887B RID: 34939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

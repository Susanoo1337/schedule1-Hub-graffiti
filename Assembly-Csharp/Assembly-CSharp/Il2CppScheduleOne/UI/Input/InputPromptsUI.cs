using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000810 RID: 2064
	public class InputPromptsUI : MonoBehaviour
	{
		// Token: 0x0600C844 RID: 51268 RVA: 0x00329EB4 File Offset: 0x003280B4
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsUI()
		{
			Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptsUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr);
			InputPromptsUI.NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, "_canvas");
			InputPromptsUI.NativeFieldInfoPtr__rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, "_rectTransform");
			InputPromptsUI.NativeFieldInfoPtr__promptsCenterContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, "_promptsCenterContainer");
			InputPromptsUI.NativeFieldInfoPtr__promptsBottomLeftInGameContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, "_promptsBottomLeftInGameContainer");
			InputPromptsUI.NativeFieldInfoPtr__promptsBottomLeftMenuContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, "_promptsBottomLeftMenuContainer");
			InputPromptsUI.NativeFieldInfoPtr__promptsCustomContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, "_promptsCustomContainer");
			InputPromptsUI.NativeFieldInfoPtr__promptItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, "_promptItemPrefab");
			InputPromptsUI.NativeFieldInfoPtr__activePrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, "_activePrompts");
			InputPromptsUI.NativeFieldInfoPtr__inactivePrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, "_inactivePrompts");
			InputPromptsUI.NativeMethodInfoPtr_get_RectTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689182);
			InputPromptsUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689183);
			InputPromptsUI.NativeMethodInfoPtr_AddPanel_Public_Boolean_String_EInputPromptPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689184);
			InputPromptsUI.NativeMethodInfoPtr_AddPanel_Public_Boolean_String_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689185);
			InputPromptsUI.NativeMethodInfoPtr_AddPrompt_Public_Void_String_String_Color_List_1_InputPromptsBindingData_Boolean_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689186);
			InputPromptsUI.NativeMethodInfoPtr_ClearPanel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689187);
			InputPromptsUI.NativeMethodInfoPtr_RemovePanel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689188);
			InputPromptsUI.NativeMethodInfoPtr_ShowHidePanel_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689189);
			InputPromptsUI.NativeMethodInfoPtr_GetPromptsContainer_Private_Transform_EInputPromptPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689190);
			InputPromptsUI.NativeMethodInfoPtr_GetCanvasSorting_Private_Int32_EInputPromptPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689191);
			InputPromptsUI.NativeMethodInfoPtr_HasActivePrompts_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689192);
			InputPromptsUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr, 100689193);
		}

		// Token: 0x17003CCE RID: 15566
		// (get) Token: 0x0600C845 RID: 51269 RVA: 0x0032A088 File Offset: 0x00328288
		public unsafe RectTransform RectTransform
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr_get_RectTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x0600C846 RID: 51270 RVA: 0x0032A0C8 File Offset: 0x003282C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330266, XrefRangeEnd = 330280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C847 RID: 51271 RVA: 0x0032A0FC File Offset: 0x003282FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330308, RefRangeEnd = 330309, XrefRangeStart = 330280, XrefRangeEnd = 330308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddPanel(string id, EInputPromptPosition position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr_AddPanel_Public_Boolean_String_EInputPromptPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C848 RID: 51272 RVA: 0x0032A158 File Offset: 0x00328358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330339, RefRangeEnd = 330340, XrefRangeStart = 330309, XrefRangeEnd = 330339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddPanel(string id, Vector3 position, int canvasSortingOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canvasSortingOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr_AddPanel_Public_Boolean_String_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C849 RID: 51273 RVA: 0x0032A1C4 File Offset: 0x003283C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330340, XrefRangeEnd = 330347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPrompt(string panelId, string promptLabel, Color promptColor, List<InputPromptsBindingData> bindingDataList, bool isPulsing, List<string> bindingDisplayStrings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(panelId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(promptLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref promptColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindingDataList);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPulsing;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindingDisplayStrings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr_AddPrompt_Public_Void_String_String_Color_List_1_InputPromptsBindingData_Boolean_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C84A RID: 51274 RVA: 0x0032A25C File Offset: 0x0032845C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330347, XrefRangeEnd = 330354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPanel(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr_ClearPanel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C84B RID: 51275 RVA: 0x0032A2A0 File Offset: 0x003284A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330370, RefRangeEnd = 330372, XrefRangeStart = 330354, XrefRangeEnd = 330370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePanel(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr_RemovePanel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C84C RID: 51276 RVA: 0x0032A2E4 File Offset: 0x003284E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330372, XrefRangeEnd = 330377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHidePanel(string id, bool show)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref show;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr_ShowHidePanel_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C84D RID: 51277 RVA: 0x0032A334 File Offset: 0x00328534
		[CallerCount(0)]
		public unsafe Transform GetPromptsContainer(EInputPromptPosition position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr_GetPromptsContainer_Private_Transform_EInputPromptPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x0600C84E RID: 51278 RVA: 0x0032A380 File Offset: 0x00328580
		[CallerCount(0)]
		public unsafe int GetCanvasSorting(EInputPromptPosition position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr_GetCanvasSorting_Private_Int32_EInputPromptPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C84F RID: 51279 RVA: 0x0032A3CC File Offset: 0x003285CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330377, XrefRangeEnd = 330380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasActivePrompts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr_HasActivePrompts_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C850 RID: 51280 RVA: 0x0032A408 File Offset: 0x00328608
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C851 RID: 51281 RVA: 0x0005EB40 File Offset: 0x0005CD40
		public InputPromptsUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x0600C852 RID: 51282 RVA: 0x0032A444 File Offset: 0x00328644
		// (set) Token: 0x0600C853 RID: 51283 RVA: 0x0005EB49 File Offset: 0x0005CD49
		public unsafe Canvas _canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x0600C854 RID: 51284 RVA: 0x0032A474 File Offset: 0x00328674
		// (set) Token: 0x0600C855 RID: 51285 RVA: 0x0005EB68 File Offset: 0x0005CD68
		public unsafe RectTransform _rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x0600C856 RID: 51286 RVA: 0x0032A4A4 File Offset: 0x003286A4
		// (set) Token: 0x0600C857 RID: 51287 RVA: 0x0005EB87 File Offset: 0x0005CD87
		public unsafe Transform _promptsCenterContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__promptsCenterContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__promptsCenterContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x0600C858 RID: 51288 RVA: 0x0032A4D4 File Offset: 0x003286D4
		// (set) Token: 0x0600C859 RID: 51289 RVA: 0x0005EBA6 File Offset: 0x0005CDA6
		public unsafe Transform _promptsBottomLeftInGameContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__promptsBottomLeftInGameContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__promptsBottomLeftInGameContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x0600C85A RID: 51290 RVA: 0x0032A504 File Offset: 0x00328704
		// (set) Token: 0x0600C85B RID: 51291 RVA: 0x0005EBC5 File Offset: 0x0005CDC5
		public unsafe Transform _promptsBottomLeftMenuContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__promptsBottomLeftMenuContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__promptsBottomLeftMenuContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CCA RID: 15562
		// (get) Token: 0x0600C85C RID: 51292 RVA: 0x0032A534 File Offset: 0x00328734
		// (set) Token: 0x0600C85D RID: 51293 RVA: 0x0005EBE4 File Offset: 0x0005CDE4
		public unsafe Transform _promptsCustomContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__promptsCustomContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__promptsCustomContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CCB RID: 15563
		// (get) Token: 0x0600C85E RID: 51294 RVA: 0x0032A564 File Offset: 0x00328764
		// (set) Token: 0x0600C85F RID: 51295 RVA: 0x0005EC03 File Offset: 0x0005CE03
		public unsafe InputPromptsPanelUI _promptItemPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__promptItemPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsPanelUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__promptItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CCC RID: 15564
		// (get) Token: 0x0600C860 RID: 51296 RVA: 0x0032A594 File Offset: 0x00328794
		// (set) Token: 0x0600C861 RID: 51297 RVA: 0x0005EC22 File Offset: 0x0005CE22
		public unsafe Dictionary<string, InputPromptsPanelUI> _activePrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__activePrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, InputPromptsPanelUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__activePrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CCD RID: 15565
		// (get) Token: 0x0600C862 RID: 51298 RVA: 0x0032A5C4 File Offset: 0x003287C4
		// (set) Token: 0x0600C863 RID: 51299 RVA: 0x0005EC41 File Offset: 0x0005CE41
		public unsafe Queue<InputPromptsPanelUI> _inactivePrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__inactivePrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<InputPromptsPanelUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsUI.NativeFieldInfoPtr__inactivePrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400887F RID: 34943
		private static readonly IntPtr NativeFieldInfoPtr__canvas;

		// Token: 0x04008880 RID: 34944
		private static readonly IntPtr NativeFieldInfoPtr__rectTransform;

		// Token: 0x04008881 RID: 34945
		private static readonly IntPtr NativeFieldInfoPtr__promptsCenterContainer;

		// Token: 0x04008882 RID: 34946
		private static readonly IntPtr NativeFieldInfoPtr__promptsBottomLeftInGameContainer;

		// Token: 0x04008883 RID: 34947
		private static readonly IntPtr NativeFieldInfoPtr__promptsBottomLeftMenuContainer;

		// Token: 0x04008884 RID: 34948
		private static readonly IntPtr NativeFieldInfoPtr__promptsCustomContainer;

		// Token: 0x04008885 RID: 34949
		private static readonly IntPtr NativeFieldInfoPtr__promptItemPrefab;

		// Token: 0x04008886 RID: 34950
		private static readonly IntPtr NativeFieldInfoPtr__activePrompts;

		// Token: 0x04008887 RID: 34951
		private static readonly IntPtr NativeFieldInfoPtr__inactivePrompts;

		// Token: 0x04008888 RID: 34952
		private static readonly IntPtr NativeMethodInfoPtr_get_RectTransform_Public_get_RectTransform_0;

		// Token: 0x04008889 RID: 34953
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400888A RID: 34954
		private static readonly IntPtr NativeMethodInfoPtr_AddPanel_Public_Boolean_String_EInputPromptPosition_0;

		// Token: 0x0400888B RID: 34955
		private static readonly IntPtr NativeMethodInfoPtr_AddPanel_Public_Boolean_String_Vector3_Int32_0;

		// Token: 0x0400888C RID: 34956
		private static readonly IntPtr NativeMethodInfoPtr_AddPrompt_Public_Void_String_String_Color_List_1_InputPromptsBindingData_Boolean_List_1_String_0;

		// Token: 0x0400888D RID: 34957
		private static readonly IntPtr NativeMethodInfoPtr_ClearPanel_Public_Void_String_0;

		// Token: 0x0400888E RID: 34958
		private static readonly IntPtr NativeMethodInfoPtr_RemovePanel_Public_Void_String_0;

		// Token: 0x0400888F RID: 34959
		private static readonly IntPtr NativeMethodInfoPtr_ShowHidePanel_Public_Void_String_Boolean_0;

		// Token: 0x04008890 RID: 34960
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptsContainer_Private_Transform_EInputPromptPosition_0;

		// Token: 0x04008891 RID: 34961
		private static readonly IntPtr NativeMethodInfoPtr_GetCanvasSorting_Private_Int32_EInputPromptPosition_0;

		// Token: 0x04008892 RID: 34962
		private static readonly IntPtr NativeMethodInfoPtr_HasActivePrompts_Public_Boolean_0;

		// Token: 0x04008893 RID: 34963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

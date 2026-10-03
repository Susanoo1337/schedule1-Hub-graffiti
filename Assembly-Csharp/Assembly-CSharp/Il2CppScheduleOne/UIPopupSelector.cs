using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine.Events;

namespace Il2CppScheduleOne
{
	// Token: 0x020000AD RID: 173
	public class UIPopupSelector : UIOption
	{
		// Token: 0x06000F61 RID: 3937 RVA: 0x000AE6BC File Offset: 0x000AC8BC
		// Note: this type is marked as 'beforefieldinit'.
		static UIPopupSelector()
		{
			Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIPopupSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr);
			UIPopupSelector.NativeFieldInfoPtr_currentOptionNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, "currentOptionNameText");
			UIPopupSelector.NativeFieldInfoPtr_OnChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, "OnChanged");
			UIPopupSelector.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, "options");
			UIPopupSelector.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, "currentIndex");
			UIPopupSelector.NativeMethodInfoPtr_GetOptionCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665242);
			UIPopupSelector.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665243);
			UIPopupSelector.NativeMethodInfoPtr_OpenPopup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665244);
			UIPopupSelector.NativeMethodInfoPtr_ClosePopup_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665245);
			UIPopupSelector.NativeMethodInfoPtr_SetCurrentOptionWithoutNotify_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665246);
			UIPopupSelector.NativeMethodInfoPtr_UpdateCurrentOptionText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665247);
			UIPopupSelector.NativeMethodInfoPtr_AddOption_Public_Void_ContextMenuOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665248);
			UIPopupSelector.NativeMethodInfoPtr_AddOptions_Public_Void_Il2CppReferenceArray_1_ContextMenuOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665249);
			UIPopupSelector.NativeMethodInfoPtr_ClearOptions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665250);
			UIPopupSelector.NativeMethodInfoPtr_ClampCurrentIndex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665251);
			UIPopupSelector.NativeMethodInfoPtr_SetOptions_Public_Void_Il2CppReferenceArray_1_ContextMenuOption_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665252);
			UIPopupSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665253);
			UIPopupSelector.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, 100665254);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x000AE840 File Offset: 0x000ACA40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82783, RefRangeEnd = 82785, XrefRangeStart = 82783, XrefRangeEnd = 82783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOptionCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr_GetOptionCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000AE87C File Offset: 0x000ACA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82785, XrefRangeEnd = 82794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupSelector.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x000AE8B8 File Offset: 0x000ACAB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82832, RefRangeEnd = 82833, XrefRangeStart = 82794, XrefRangeEnd = 82832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenPopup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr_OpenPopup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x000AE8EC File Offset: 0x000ACAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82833, XrefRangeEnd = 82839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClosePopup(int selectedIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectedIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr_ClosePopup_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x000AE92C File Offset: 0x000ACB2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82840, RefRangeEnd = 82841, XrefRangeStart = 82839, XrefRangeEnd = 82840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentOptionWithoutNotify(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr_SetCurrentOptionWithoutNotify_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x000AE96C File Offset: 0x000ACB6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82845, RefRangeEnd = 82849, XrefRangeStart = 82841, XrefRangeEnd = 82845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentOptionText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr_UpdateCurrentOptionText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x000AE9A0 File Offset: 0x000ACBA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82861, RefRangeEnd = 82862, XrefRangeStart = 82849, XrefRangeEnd = 82861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOption(UIPopupScreen_ContextMenu.ContextMenuOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr_AddOption_Public_Void_ContextMenuOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x000AE9E4 File Offset: 0x000ACBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82862, XrefRangeEnd = 82871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOptions(Il2CppReferenceArray<UIPopupScreen_ContextMenu.ContextMenuOption> newOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr_AddOptions_Public_Void_Il2CppReferenceArray_1_ContextMenuOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x000AEA28 File Offset: 0x000ACC28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82875, RefRangeEnd = 82877, XrefRangeStart = 82871, XrefRangeEnd = 82875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr_ClearOptions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x000AEA5C File Offset: 0x000ACC5C
		[CallerCount(0)]
		public unsafe void ClampCurrentIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr_ClampCurrentIndex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000AEA90 File Offset: 0x000ACC90
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82902, RefRangeEnd = 82906, XrefRangeStart = 82877, XrefRangeEnd = 82902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOptions(Il2CppReferenceArray<UIPopupScreen_ContextMenu.ContextMenuOption> newOptions, int defaultIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newOptions);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr_SetOptions_Public_Void_Il2CppReferenceArray_1_ContextMenuOption_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x000AEAE0 File Offset: 0x000ACCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82906, XrefRangeEnd = 82911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIPopupSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x000AEB1C File Offset: 0x000ACD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82911, XrefRangeEnd = 82912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__5_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.NativeMethodInfoPtr__Awake_b__5_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00009271 File Offset: 0x00007471
		public UIPopupSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x000AEB50 File Offset: 0x000ACD50
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0000927A File Offset: 0x0000747A
		public unsafe TextMeshProUGUI currentOptionNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.NativeFieldInfoPtr_currentOptionNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.NativeFieldInfoPtr_currentOptionNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x000AEB80 File Offset: 0x000ACD80
		// (set) Token: 0x06000F73 RID: 3955 RVA: 0x00009299 File Offset: 0x00007499
		public unsafe UnityEvent<UIPopupScreen_ContextMenu.ContextMenuOption> OnChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.NativeFieldInfoPtr_OnChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<UIPopupScreen_ContextMenu.ContextMenuOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.NativeFieldInfoPtr_OnChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x000AEBB0 File Offset: 0x000ACDB0
		// (set) Token: 0x06000F75 RID: 3957 RVA: 0x000092B8 File Offset: 0x000074B8
		public unsafe Il2CppReferenceArray<UIPopupScreen_ContextMenu.ContextMenuOption> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UIPopupScreen_ContextMenu.ContextMenuOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x000AEBE0 File Offset: 0x000ACDE0
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x000092D7 File Offset: 0x000074D7
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeFieldInfoPtr_currentOptionNameText;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeFieldInfoPtr_OnChanged;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_GetOptionCount_Public_Int32_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_OpenPopup_Private_Void_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_ClosePopup_Private_Void_Int32_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentOptionWithoutNotify_Public_Void_Int32_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentOptionText_Private_Void_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_AddOption_Public_Void_ContextMenuOption_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_Il2CppReferenceArray_1_ContextMenuOption_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_ClearOptions_Public_Void_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_ClampCurrentIndex_Private_Void_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Void_Il2CppReferenceArray_1_ContextMenuOption_Int32_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__5_0_Private_Void_0;

		// Token: 0x020008C6 RID: 2246
		[ObfuscatedName("ScheduleOne.UIPopupSelector+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600D4D8 RID: 54488 RVA: 0x0034FB64 File Offset: 0x0034DD64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<UIPopupSelector.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPopupSelector>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupSelector.__c__DisplayClass14_0>.NativeClassPtr);
				UIPopupSelector.__c__DisplayClass14_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSelector.__c__DisplayClass14_0>.NativeClassPtr, "option");
				UIPopupSelector.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupSelector.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				UIPopupSelector.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector.__c__DisplayClass14_0>.NativeClassPtr, 100665255);
				UIPopupSelector.__c__DisplayClass14_0.NativeMethodInfoPtr__SetOptions_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupSelector.__c__DisplayClass14_0>.NativeClassPtr, 100665256);
			}

			// Token: 0x0600D4D9 RID: 54489 RVA: 0x0034FBE0 File Offset: 0x0034DDE0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupSelector.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4DA RID: 54490 RVA: 0x0034FC1C File Offset: 0x0034DE1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82777, XrefRangeEnd = 82783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetOptions_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupSelector.__c__DisplayClass14_0.NativeMethodInfoPtr__SetOptions_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4DB RID: 54491 RVA: 0x00064B38 File Offset: 0x00062D38
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D0 RID: 16592
			// (get) Token: 0x0600D4DC RID: 54492 RVA: 0x0034FC50 File Offset: 0x0034DE50
			// (set) Token: 0x0600D4DD RID: 54493 RVA: 0x00064B41 File Offset: 0x00062D41
			public unsafe UIPopupScreen_ContextMenu.ContextMenuOption option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.__c__DisplayClass14_0.NativeFieldInfoPtr_option);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupScreen_ContextMenu.ContextMenuOption>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.__c__DisplayClass14_0.NativeFieldInfoPtr_option), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040D1 RID: 16593
			// (get) Token: 0x0600D4DE RID: 54494 RVA: 0x0034FC80 File Offset: 0x0034DE80
			// (set) Token: 0x0600D4DF RID: 54495 RVA: 0x00064B60 File Offset: 0x00062D60
			public unsafe UIPopupSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupSelector.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090F2 RID: 37106
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x040090F3 RID: 37107
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090F4 RID: 37108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090F5 RID: 37109
			private static readonly IntPtr NativeMethodInfoPtr__SetOptions_b__0_Internal_Void_0;
		}
	}
}

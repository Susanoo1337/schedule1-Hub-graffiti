using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000817 RID: 2071
	public class CharacterCustomizationCategory : MonoBehaviour
	{
		// Token: 0x0600C93D RID: 51517 RVA: 0x0032CE24 File Offset: 0x0032B024
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationCategory()
		{
			Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "CharacterCustomizationCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr);
			CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "CategoryName");
			CharacterCustomizationCategory.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "TitleText");
			CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "BackButton");
			CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "ScrollRect");
			CharacterCustomizationCategory.NativeFieldInfoPtr_ContentPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "ContentPanel");
			CharacterCustomizationCategory.NativeFieldInfoPtr_ui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "ui");
			CharacterCustomizationCategory.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "options");
			CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "onOpen");
			CharacterCustomizationCategory.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "onClose");
			CharacterCustomizationCategory.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100689274);
			CharacterCustomizationCategory.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100689275);
			CharacterCustomizationCategory.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100689276);
			CharacterCustomizationCategory.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100689277);
			CharacterCustomizationCategory.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100689278);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100689279);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100689280);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100689281);
			CharacterCustomizationCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100689282);
		}

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x0600C93E RID: 51518 RVA: 0x0032CFD0 File Offset: 0x0032B1D0
		// (set) Token: 0x0600C93F RID: 51519 RVA: 0x0032D00C File Offset: 0x0032B20C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C940 RID: 51520 RVA: 0x0032D04C File Offset: 0x0032B24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331420, XrefRangeEnd = 331467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C941 RID: 51521 RVA: 0x0032D080 File Offset: 0x0032B280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331476, RefRangeEnd = 331477, XrefRangeStart = 331467, XrefRangeEnd = 331476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C942 RID: 51522 RVA: 0x0032D0B4 File Offset: 0x0032B2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331477, XrefRangeEnd = 331484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C943 RID: 51523 RVA: 0x0032D0E8 File Offset: 0x0032B2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331484, XrefRangeEnd = 331492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C944 RID: 51524 RVA: 0x0032D12C File Offset: 0x0032B32C
		[CallerCount(0)]
		public unsafe void OptionDeselected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C945 RID: 51525 RVA: 0x0032D170 File Offset: 0x0032B370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331492, XrefRangeEnd = 331504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionPurchased(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C946 RID: 51526 RVA: 0x0032D1B4 File Offset: 0x0032B3B4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C947 RID: 51527 RVA: 0x0005F4D2 File Offset: 0x0005D6D2
		public CharacterCustomizationCategory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x0600C948 RID: 51528 RVA: 0x0032D1F0 File Offset: 0x0032B3F0
		// (set) Token: 0x0600C949 RID: 51529 RVA: 0x0005F4DB File Offset: 0x0005D6DB
		public unsafe string CategoryName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x0600C94A RID: 51530 RVA: 0x0032D218 File Offset: 0x0032B418
		// (set) Token: 0x0600C94B RID: 51531 RVA: 0x0005F4FA File Offset: 0x0005D6FA
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x0600C94C RID: 51532 RVA: 0x0032D240 File Offset: 0x0032B440
		// (set) Token: 0x0600C94D RID: 51533 RVA: 0x0005F515 File Offset: 0x0005D715
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x0600C94E RID: 51534 RVA: 0x0032D270 File Offset: 0x0032B470
		// (set) Token: 0x0600C94F RID: 51535 RVA: 0x0005F534 File Offset: 0x0005D734
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x0600C950 RID: 51536 RVA: 0x0032D2A0 File Offset: 0x0032B4A0
		// (set) Token: 0x0600C951 RID: 51537 RVA: 0x0005F553 File Offset: 0x0005D753
		public unsafe ScrollRect ScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x0600C952 RID: 51538 RVA: 0x0032D2D0 File Offset: 0x0032B4D0
		// (set) Token: 0x0600C953 RID: 51539 RVA: 0x0005F572 File Offset: 0x0005D772
		public unsafe UIContentPanel ContentPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ContentPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIContentPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ContentPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x0600C954 RID: 51540 RVA: 0x0032D300 File Offset: 0x0032B500
		// (set) Token: 0x0600C955 RID: 51541 RVA: 0x0005F591 File Offset: 0x0005D791
		public unsafe CharacterCustomizationUI ui
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ui);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ui), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x0600C956 RID: 51542 RVA: 0x0032D330 File Offset: 0x0032B530
		// (set) Token: 0x0600C957 RID: 51543 RVA: 0x0005F5B0 File Offset: 0x0005D7B0
		public unsafe Il2CppReferenceArray<CharacterCustomizationOption> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterCustomizationOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x0600C958 RID: 51544 RVA: 0x0032D360 File Offset: 0x0032B560
		// (set) Token: 0x0600C959 RID: 51545 RVA: 0x0005F5CF File Offset: 0x0005D7CF
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x0600C95A RID: 51546 RVA: 0x0032D390 File Offset: 0x0032B590
		// (set) Token: 0x0600C95B RID: 51547 RVA: 0x0005F5EE File Offset: 0x0005D7EE
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008919 RID: 35097
		private static readonly IntPtr NativeFieldInfoPtr_CategoryName;

		// Token: 0x0400891A RID: 35098
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400891B RID: 35099
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x0400891C RID: 35100
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x0400891D RID: 35101
		private static readonly IntPtr NativeFieldInfoPtr_ScrollRect;

		// Token: 0x0400891E RID: 35102
		private static readonly IntPtr NativeFieldInfoPtr_ContentPanel;

		// Token: 0x0400891F RID: 35103
		private static readonly IntPtr NativeFieldInfoPtr_ui;

		// Token: 0x04008920 RID: 35104
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04008921 RID: 35105
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04008922 RID: 35106
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04008923 RID: 35107
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008924 RID: 35108
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04008925 RID: 35109
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04008926 RID: 35110
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04008927 RID: 35111
		private static readonly IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x04008928 RID: 35112
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x04008929 RID: 35113
		private static readonly IntPtr NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x0400892A RID: 35114
		private static readonly IntPtr NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x0400892B RID: 35115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D79 RID: 3449
		[ObfuscatedName("ScheduleOne.UI.CharacterCustomization.CharacterCustomizationCategory+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FBA7 RID: 64423 RVA: 0x003C10B0 File Offset: 0x003BF2B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass13_0>.NativeClassPtr);
				CharacterCustomizationCategory.__c__DisplayClass13_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass13_0>.NativeClassPtr, "option");
				CharacterCustomizationCategory.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				CharacterCustomizationCategory.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass13_0>.NativeClassPtr, 100689283);
				CharacterCustomizationCategory.__c__DisplayClass13_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass13_0>.NativeClassPtr, 100689284);
				CharacterCustomizationCategory.__c__DisplayClass13_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass13_0>.NativeClassPtr, 100689285);
				CharacterCustomizationCategory.__c__DisplayClass13_0.NativeMethodInfoPtr__Awake_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass13_0>.NativeClassPtr, 100689286);
			}

			// Token: 0x0600FBA8 RID: 64424 RVA: 0x003C1154 File Offset: 0x003BF354
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBA9 RID: 64425 RVA: 0x003C1190 File Offset: 0x003BF390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331400, XrefRangeEnd = 331408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass13_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBAA RID: 64426 RVA: 0x003C11C4 File Offset: 0x003BF3C4
			[CallerCount(0)]
			public unsafe void _Awake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass13_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBAB RID: 64427 RVA: 0x003C11F8 File Offset: 0x003BF3F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331408, XrefRangeEnd = 331420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass13_0.NativeMethodInfoPtr__Awake_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBAC RID: 64428 RVA: 0x000771E5 File Offset: 0x000753E5
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C7B RID: 19579
			// (get) Token: 0x0600FBAD RID: 64429 RVA: 0x003C122C File Offset: 0x003BF42C
			// (set) Token: 0x0600FBAE RID: 64430 RVA: 0x000771EE File Offset: 0x000753EE
			public unsafe CharacterCustomizationOption option
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass13_0.NativeFieldInfoPtr_option);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationOption>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass13_0.NativeFieldInfoPtr_option), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C7C RID: 19580
			// (get) Token: 0x0600FBAF RID: 64431 RVA: 0x003C125C File Offset: 0x003BF45C
			// (set) Token: 0x0600FBB0 RID: 64432 RVA: 0x0007720D File Offset: 0x0007540D
			public unsafe CharacterCustomizationCategory __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCategory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9C5 RID: 43461
			private static readonly IntPtr NativeFieldInfoPtr_option;

			// Token: 0x0400A9C6 RID: 43462
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A9C7 RID: 43463
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9C8 RID: 43464
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;

			// Token: 0x0400A9C9 RID: 43465
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_0;

			// Token: 0x0400A9CA RID: 43466
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__2_Internal_Void_0;
		}
	}
}

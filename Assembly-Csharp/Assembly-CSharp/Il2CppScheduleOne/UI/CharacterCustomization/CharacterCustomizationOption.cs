using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Levelling;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000818 RID: 2072
	public class CharacterCustomizationOption : MonoBehaviour
	{
		// Token: 0x0600C95C RID: 51548 RVA: 0x0032D3C0 File Offset: 0x0032B5C0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationOption()
		{
			Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "CharacterCustomizationOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr);
			CharacterCustomizationOption.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Name");
			CharacterCustomizationOption.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Label");
			CharacterCustomizationOption.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "Price");
			CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "RequireLevel");
			CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "RequiredLevel");
			CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "NameLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "PriceLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "LevelLabel");
			CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "LockDisplay");
			CharacterCustomizationOption.NativeFieldInfoPtr_MainButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "MainButton");
			CharacterCustomizationOption.NativeFieldInfoPtr_MainSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "MainSelectable");
			CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "BuyButton");
			CharacterCustomizationOption.NativeFieldInfoPtr_OwnedIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "OwnedIndicator");
			CharacterCustomizationOption.NativeFieldInfoPtr_onSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onSelect");
			CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onDeselect");
			CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "onPurchase");
			CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "<purchased>k__BackingField");
			CharacterCustomizationOption.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, "selected");
			CharacterCustomizationOption.NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689287);
			CharacterCustomizationOption.NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689288);
			CharacterCustomizationOption.NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689289);
			CharacterCustomizationOption.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689290);
			CharacterCustomizationOption.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689291);
			CharacterCustomizationOption.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689292);
			CharacterCustomizationOption.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689293);
			CharacterCustomizationOption.NativeMethodInfoPtr_Selected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689294);
			CharacterCustomizationOption.NativeMethodInfoPtr_Deselected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689295);
			CharacterCustomizationOption.NativeMethodInfoPtr_Purchased_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689296);
			CharacterCustomizationOption.NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689297);
			CharacterCustomizationOption.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689298);
			CharacterCustomizationOption.NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689299);
			CharacterCustomizationOption.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689300);
			CharacterCustomizationOption.NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689301);
			CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689302);
			CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689303);
			CharacterCustomizationOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr, 100689304);
		}

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x0600C95D RID: 51549 RVA: 0x0032D6C0 File Offset: 0x0032B8C0
		// (set) Token: 0x0600C95E RID: 51550 RVA: 0x0032D6FC File Offset: 0x0032B8FC
		public unsafe bool purchased
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x0600C95F RID: 51551 RVA: 0x0032D73C File Offset: 0x0032B93C
		public unsafe bool purchaseable
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 331505, RefRangeEnd = 331509, XrefRangeStart = 331504, XrefRangeEnd = 331505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600C960 RID: 51552 RVA: 0x0032D778 File Offset: 0x0032B978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331509, XrefRangeEnd = 331543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C961 RID: 51553 RVA: 0x0032D7AC File Offset: 0x0032B9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C962 RID: 51554 RVA: 0x0032D7E0 File Offset: 0x0032B9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331543, XrefRangeEnd = 331550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C963 RID: 51555 RVA: 0x0032D814 File Offset: 0x0032BA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331550, XrefRangeEnd = 331551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C964 RID: 51556 RVA: 0x0032D848 File Offset: 0x0032BA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331551, XrefRangeEnd = 331554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Selected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C965 RID: 51557 RVA: 0x0032D87C File Offset: 0x0032BA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331554, XrefRangeEnd = 331557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Deselected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C966 RID: 51558 RVA: 0x0032D8B0 File Offset: 0x0032BAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331557, XrefRangeEnd = 331568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Purchased()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_Purchased_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C967 RID: 51559 RVA: 0x0032D8E4 File Offset: 0x0032BAE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331576, RefRangeEnd = 331579, XrefRangeStart = 331568, XrefRangeEnd = 331576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePriceColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C968 RID: 51560 RVA: 0x0032D918 File Offset: 0x0032BB18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331582, RefRangeEnd = 331583, XrefRangeStart = 331579, XrefRangeEnd = 331582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelected(bool _selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _selected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C969 RID: 51561 RVA: 0x0032D958 File Offset: 0x0032BB58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 331594, RefRangeEnd = 331598, XrefRangeStart = 331583, XrefRangeEnd = 331594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPurchased(bool _purchased)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _purchased;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C96A RID: 51562 RVA: 0x0032D998 File Offset: 0x0032BB98
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 331610, RefRangeEnd = 331624, XrefRangeStart = 331598, XrefRangeEnd = 331610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C96B RID: 51563 RVA: 0x0032D9CC File Offset: 0x0032BBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331624, XrefRangeEnd = 331628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParentCategoryClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C96C RID: 51564 RVA: 0x0032DA00 File Offset: 0x0032BC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331628, XrefRangeEnd = 331635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SiblingOptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C96D RID: 51565 RVA: 0x0032DA44 File Offset: 0x0032BC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331635, XrefRangeEnd = 331646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SiblingOptionPurchased(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C96E RID: 51566 RVA: 0x0032DA88 File Offset: 0x0032BC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331646, XrefRangeEnd = 331656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationOption>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C96F RID: 51567 RVA: 0x0005F60D File Offset: 0x0005D80D
		public CharacterCustomizationOption(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x0600C970 RID: 51568 RVA: 0x0032DAC4 File Offset: 0x0032BCC4
		// (set) Token: 0x0600C971 RID: 51569 RVA: 0x0005F616 File Offset: 0x0005D816
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x0600C972 RID: 51570 RVA: 0x0032DAEC File Offset: 0x0032BCEC
		// (set) Token: 0x0600C973 RID: 51571 RVA: 0x0005F635 File Offset: 0x0005D835
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x0600C974 RID: 51572 RVA: 0x0032DB14 File Offset: 0x0032BD14
		// (set) Token: 0x0600C975 RID: 51573 RVA: 0x0005F654 File Offset: 0x0005D854
		public unsafe float Price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_Price)) = value;
			}
		}

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x0600C976 RID: 51574 RVA: 0x0032DB3C File Offset: 0x0032BD3C
		// (set) Token: 0x0600C977 RID: 51575 RVA: 0x0005F66F File Offset: 0x0005D86F
		public unsafe bool RequireLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequireLevel)) = value;
			}
		}

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x0600C978 RID: 51576 RVA: 0x0032DB64 File Offset: 0x0032BD64
		// (set) Token: 0x0600C979 RID: 51577 RVA: 0x0005F68A File Offset: 0x0005D88A
		public unsafe FullRank RequiredLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_RequiredLevel)) = value;
			}
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x0600C97A RID: 51578 RVA: 0x0032DB8C File Offset: 0x0032BD8C
		// (set) Token: 0x0600C97B RID: 51579 RVA: 0x0005F6A5 File Offset: 0x0005D8A5
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D2C RID: 15660
		// (get) Token: 0x0600C97C RID: 51580 RVA: 0x0032DBBC File Offset: 0x0032BDBC
		// (set) Token: 0x0600C97D RID: 51581 RVA: 0x0005F6C4 File Offset: 0x0005D8C4
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D2D RID: 15661
		// (get) Token: 0x0600C97E RID: 51582 RVA: 0x0032DBEC File Offset: 0x0032BDEC
		// (set) Token: 0x0600C97F RID: 51583 RVA: 0x0005F6E3 File Offset: 0x0005D8E3
		public unsafe TextMeshProUGUI LevelLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LevelLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x0600C980 RID: 51584 RVA: 0x0032DC1C File Offset: 0x0032BE1C
		// (set) Token: 0x0600C981 RID: 51585 RVA: 0x0005F702 File Offset: 0x0005D902
		public unsafe RectTransform LockDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_LockDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x0600C982 RID: 51586 RVA: 0x0032DC4C File Offset: 0x0032BE4C
		// (set) Token: 0x0600C983 RID: 51587 RVA: 0x0005F721 File Offset: 0x0005D921
		public unsafe Button MainButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_MainButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_MainButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x0600C984 RID: 51588 RVA: 0x0032DC7C File Offset: 0x0032BE7C
		// (set) Token: 0x0600C985 RID: 51589 RVA: 0x0005F740 File Offset: 0x0005D940
		public unsafe UISelectable MainSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_MainSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_MainSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D31 RID: 15665
		// (get) Token: 0x0600C986 RID: 51590 RVA: 0x0032DCAC File Offset: 0x0032BEAC
		// (set) Token: 0x0600C987 RID: 51591 RVA: 0x0005F75F File Offset: 0x0005D95F
		public unsafe Button BuyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_BuyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x0600C988 RID: 51592 RVA: 0x0032DCDC File Offset: 0x0032BEDC
		// (set) Token: 0x0600C989 RID: 51593 RVA: 0x0005F77E File Offset: 0x0005D97E
		public unsafe RectTransform OwnedIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_OwnedIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_OwnedIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x0600C98A RID: 51594 RVA: 0x0032DD0C File Offset: 0x0032BF0C
		// (set) Token: 0x0600C98B RID: 51595 RVA: 0x0005F79D File Offset: 0x0005D99D
		public unsafe UnityEvent onSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x0600C98C RID: 51596 RVA: 0x0032DD3C File Offset: 0x0032BF3C
		// (set) Token: 0x0600C98D RID: 51597 RVA: 0x0005F7BC File Offset: 0x0005D9BC
		public unsafe UnityEvent onDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x0600C98E RID: 51598 RVA: 0x0032DD6C File Offset: 0x0032BF6C
		// (set) Token: 0x0600C98F RID: 51599 RVA: 0x0005F7DB File Offset: 0x0005D9DB
		public unsafe UnityEvent onPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x0600C990 RID: 51600 RVA: 0x0032DD9C File Offset: 0x0032BF9C
		// (set) Token: 0x0600C991 RID: 51601 RVA: 0x0005F7FA File Offset: 0x0005D9FA
		public unsafe bool _purchased_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr__purchased_k__BackingField)) = value;
			}
		}

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x0600C992 RID: 51602 RVA: 0x0032DDC4 File Offset: 0x0032BFC4
		// (set) Token: 0x0600C993 RID: 51603 RVA: 0x0005F815 File Offset: 0x0005DA15
		public unsafe bool selected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_selected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationOption.NativeFieldInfoPtr_selected)) = value;
			}
		}

		// Token: 0x0400892C RID: 35116
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400892D RID: 35117
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x0400892E RID: 35118
		private static readonly IntPtr NativeFieldInfoPtr_Price;

		// Token: 0x0400892F RID: 35119
		private static readonly IntPtr NativeFieldInfoPtr_RequireLevel;

		// Token: 0x04008930 RID: 35120
		private static readonly IntPtr NativeFieldInfoPtr_RequiredLevel;

		// Token: 0x04008931 RID: 35121
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04008932 RID: 35122
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04008933 RID: 35123
		private static readonly IntPtr NativeFieldInfoPtr_LevelLabel;

		// Token: 0x04008934 RID: 35124
		private static readonly IntPtr NativeFieldInfoPtr_LockDisplay;

		// Token: 0x04008935 RID: 35125
		private static readonly IntPtr NativeFieldInfoPtr_MainButton;

		// Token: 0x04008936 RID: 35126
		private static readonly IntPtr NativeFieldInfoPtr_MainSelectable;

		// Token: 0x04008937 RID: 35127
		private static readonly IntPtr NativeFieldInfoPtr_BuyButton;

		// Token: 0x04008938 RID: 35128
		private static readonly IntPtr NativeFieldInfoPtr_OwnedIndicator;

		// Token: 0x04008939 RID: 35129
		private static readonly IntPtr NativeFieldInfoPtr_onSelect;

		// Token: 0x0400893A RID: 35130
		private static readonly IntPtr NativeFieldInfoPtr_onDeselect;

		// Token: 0x0400893B RID: 35131
		private static readonly IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x0400893C RID: 35132
		private static readonly IntPtr NativeFieldInfoPtr__purchased_k__BackingField;

		// Token: 0x0400893D RID: 35133
		private static readonly IntPtr NativeFieldInfoPtr_selected;

		// Token: 0x0400893E RID: 35134
		private static readonly IntPtr NativeMethodInfoPtr_get_purchased_Public_get_Boolean_0;

		// Token: 0x0400893F RID: 35135
		private static readonly IntPtr NativeMethodInfoPtr_set_purchased_Private_set_Void_Boolean_0;

		// Token: 0x04008940 RID: 35136
		private static readonly IntPtr NativeMethodInfoPtr_get_purchaseable_Private_get_Boolean_0;

		// Token: 0x04008941 RID: 35137
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04008942 RID: 35138
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04008943 RID: 35139
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04008944 RID: 35140
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04008945 RID: 35141
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Private_Void_0;

		// Token: 0x04008946 RID: 35142
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Private_Void_0;

		// Token: 0x04008947 RID: 35143
		private static readonly IntPtr NativeMethodInfoPtr_Purchased_Private_Void_0;

		// Token: 0x04008948 RID: 35144
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePriceColor_Private_Void_0;

		// Token: 0x04008949 RID: 35145
		private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Boolean_0;

		// Token: 0x0400894A RID: 35146
		private static readonly IntPtr NativeMethodInfoPtr_SetPurchased_Public_Void_Boolean_0;

		// Token: 0x0400894B RID: 35147
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x0400894C RID: 35148
		private static readonly IntPtr NativeMethodInfoPtr_ParentCategoryClosed_Public_Void_0;

		// Token: 0x0400894D RID: 35149
		private static readonly IntPtr NativeMethodInfoPtr_SiblingOptionSelected_Public_Void_CharacterCustomizationOption_0;

		// Token: 0x0400894E RID: 35150
		private static readonly IntPtr NativeMethodInfoPtr_SiblingOptionPurchased_Public_Void_CharacterCustomizationOption_0;

		// Token: 0x0400894F RID: 35151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

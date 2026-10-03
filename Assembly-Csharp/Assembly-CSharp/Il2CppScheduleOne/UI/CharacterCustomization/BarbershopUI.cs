using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000816 RID: 2070
	public class BarbershopUI : CharacterCustomizationUI
	{
		// Token: 0x0600C92B RID: 51499 RVA: 0x0032CA48 File Offset: 0x0032AC48
		// Note: this type is marked as 'beforefieldinit'.
		static BarbershopUI()
		{
			Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "BarbershopUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr);
			BarbershopUI.NativeFieldInfoPtr_ColorPicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "ColorPicker");
			BarbershopUI.NativeFieldInfoPtr_ApplyColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "ApplyColorButton");
			BarbershopUI.NativeFieldInfoPtr_ColorCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "ColorCategory");
			BarbershopUI.NativeFieldInfoPtr_appliedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "appliedColor");
			BarbershopUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100689266);
			BarbershopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100689267);
			BarbershopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100689268);
			BarbershopUI.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100689269);
			BarbershopUI.NativeMethodInfoPtr_ColorFieldChanged_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100689270);
			BarbershopUI.NativeMethodInfoPtr_ApplyColorChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100689271);
			BarbershopUI.NativeMethodInfoPtr_RevertColorChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100689272);
			BarbershopUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100689273);
		}

		// Token: 0x0600C92C RID: 51500 RVA: 0x0032CB68 File Offset: 0x0032AD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331347, XrefRangeEnd = 331369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C92D RID: 51501 RVA: 0x0032CBA4 File Offset: 0x0032ADA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331369, XrefRangeEnd = 331371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C92E RID: 51502 RVA: 0x0032CBFC File Offset: 0x0032ADFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331371, XrefRangeEnd = 331377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C92F RID: 51503 RVA: 0x0032CC4C File Offset: 0x0032AE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331377, XrefRangeEnd = 331381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C930 RID: 51504 RVA: 0x0032CC88 File Offset: 0x0032AE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331381, XrefRangeEnd = 331385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorFieldChanged(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_ColorFieldChanged_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C931 RID: 51505 RVA: 0x0032CCC8 File Offset: 0x0032AEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331385, XrefRangeEnd = 331390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColorChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_ApplyColorChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C932 RID: 51506 RVA: 0x0032CCFC File Offset: 0x0032AEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331390, XrefRangeEnd = 331395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RevertColorChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_RevertColorChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C933 RID: 51507 RVA: 0x0032CD30 File Offset: 0x0032AF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331395, XrefRangeEnd = 331400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BarbershopUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C934 RID: 51508 RVA: 0x0005F451 File Offset: 0x0005D651
		public BarbershopUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x0600C935 RID: 51509 RVA: 0x0032CD6C File Offset: 0x0032AF6C
		// (set) Token: 0x0600C936 RID: 51510 RVA: 0x0005F45A File Offset: 0x0005D65A
		public unsafe HSVColorPicker ColorPicker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ColorPicker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HSVColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ColorPicker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x0600C937 RID: 51511 RVA: 0x0032CD9C File Offset: 0x0032AF9C
		// (set) Token: 0x0600C938 RID: 51512 RVA: 0x0005F479 File Offset: 0x0005D679
		public unsafe Button ApplyColorButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ApplyColorButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ApplyColorButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x0600C939 RID: 51513 RVA: 0x0032CDCC File Offset: 0x0032AFCC
		// (set) Token: 0x0600C93A RID: 51514 RVA: 0x0005F498 File Offset: 0x0005D698
		public unsafe CharacterCustomizationCategory ColorCategory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ColorCategory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCategory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ColorCategory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x0600C93B RID: 51515 RVA: 0x0032CDFC File Offset: 0x0032AFFC
		// (set) Token: 0x0600C93C RID: 51516 RVA: 0x0005F4B7 File Offset: 0x0005D6B7
		public unsafe Color appliedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_appliedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_appliedColor)) = value;
			}
		}

		// Token: 0x0400890D RID: 35085
		private static readonly IntPtr NativeFieldInfoPtr_ColorPicker;

		// Token: 0x0400890E RID: 35086
		private static readonly IntPtr NativeFieldInfoPtr_ApplyColorButton;

		// Token: 0x0400890F RID: 35087
		private static readonly IntPtr NativeFieldInfoPtr_ColorCategory;

		// Token: 0x04008910 RID: 35088
		private static readonly IntPtr NativeFieldInfoPtr_appliedColor;

		// Token: 0x04008911 RID: 35089
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008912 RID: 35090
		private static readonly IntPtr NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0;

		// Token: 0x04008913 RID: 35091
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0;

		// Token: 0x04008914 RID: 35092
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04008915 RID: 35093
		private static readonly IntPtr NativeMethodInfoPtr_ColorFieldChanged_Private_Void_Color_0;

		// Token: 0x04008916 RID: 35094
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorChange_Private_Void_0;

		// Token: 0x04008917 RID: 35095
		private static readonly IntPtr NativeMethodInfoPtr_RevertColorChange_Private_Void_0;

		// Token: 0x04008918 RID: 35096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

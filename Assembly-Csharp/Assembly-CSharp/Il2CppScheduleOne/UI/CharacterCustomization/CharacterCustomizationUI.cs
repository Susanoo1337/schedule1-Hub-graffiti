using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000819 RID: 2073
	public class CharacterCustomizationUI : MonoBehaviour
	{
		// Token: 0x0600C994 RID: 51604 RVA: 0x0032DDEC File Offset: 0x0032BFEC
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationUI()
		{
			Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "CharacterCustomizationUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr);
			CharacterCustomizationUI.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "<IsOpen>k__BackingField");
			CharacterCustomizationUI.NativeFieldInfoPtr__ActiveCategory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "<ActiveCategory>k__BackingField");
			CharacterCustomizationUI.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "Title");
			CharacterCustomizationUI.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "Categories");
			CharacterCustomizationUI.NativeFieldInfoPtr_LoadAvatarSettingsNaked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "LoadAvatarSettingsNaked");
			CharacterCustomizationUI.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "Canvas");
			CharacterCustomizationUI.NativeFieldInfoPtr_MainContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "MainContainer");
			CharacterCustomizationUI.NativeFieldInfoPtr_MenuContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "MenuContainer");
			CharacterCustomizationUI.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "TitleText");
			CharacterCustomizationUI.NativeFieldInfoPtr_ButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "ButtonContainer");
			CharacterCustomizationUI.NativeFieldInfoPtr_ExitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "ExitButton");
			CharacterCustomizationUI.NativeFieldInfoPtr_RigRotationSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "RigRotationSlider");
			CharacterCustomizationUI.NativeFieldInfoPtr_PreviewIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "PreviewIndicator");
			CharacterCustomizationUI.NativeFieldInfoPtr_CharacterCustomizationShop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "CharacterCustomizationShop");
			CharacterCustomizationUI.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "State");
			CharacterCustomizationUI.NativeFieldInfoPtr_MainPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "MainPanel");
			CharacterCustomizationUI.NativeFieldInfoPtr_CategoryButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "CategoryButtonPrefab");
			CharacterCustomizationUI.NativeFieldInfoPtr_rigTargetY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "rigTargetY");
			CharacterCustomizationUI.NativeFieldInfoPtr_openCloseRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "openCloseRoutine");
			CharacterCustomizationUI.NativeFieldInfoPtr_currentSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "currentSettings");
			CharacterCustomizationUI.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689305);
			CharacterCustomizationUI.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689306);
			CharacterCustomizationUI.NativeMethodInfoPtr_get_ActiveCategory_Public_get_CharacterCustomizationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689307);
			CharacterCustomizationUI.NativeMethodInfoPtr_set_ActiveCategory_Private_set_Void_CharacterCustomizationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689308);
			CharacterCustomizationUI.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689309);
			CharacterCustomizationUI.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689310);
			CharacterCustomizationUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689311);
			CharacterCustomizationUI.NativeMethodInfoPtr_SetActiveCategory_Public_Void_CharacterCustomizationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689312);
			CharacterCustomizationUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_New_Boolean_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689313);
			CharacterCustomizationUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_New_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689314);
			CharacterCustomizationUI.NativeMethodInfoPtr_OptionDeselected_Public_Virtual_New_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689315);
			CharacterCustomizationUI.NativeMethodInfoPtr_OptionPurchased_Public_Virtual_New_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689316);
			CharacterCustomizationUI.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689317);
			CharacterCustomizationUI.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689318);
			CharacterCustomizationUI.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689319);
			CharacterCustomizationUI.NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689320);
			CharacterCustomizationUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689321);
			CharacterCustomizationUI.NativeMethodInfoPtr__Awake_b__27_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689322);
			CharacterCustomizationUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689323);
			CharacterCustomizationUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, 100689324);
		}

		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x0600C995 RID: 51605 RVA: 0x0032E13C File Offset: 0x0032C33C
		// (set) Token: 0x0600C996 RID: 51606 RVA: 0x0032E178 File Offset: 0x0032C378
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x0600C997 RID: 51607 RVA: 0x0032E1B8 File Offset: 0x0032C3B8
		// (set) Token: 0x0600C998 RID: 51608 RVA: 0x0032E1F8 File Offset: 0x0032C3F8
		public unsafe CharacterCustomizationCategory ActiveCategory
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_get_ActiveCategory_Public_get_CharacterCustomizationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCategory>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_set_ActiveCategory_Private_set_Void_CharacterCustomizationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C999 RID: 51609 RVA: 0x0032E23C File Offset: 0x0032C43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331719, XrefRangeEnd = 331724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C99A RID: 51610 RVA: 0x0032E270 File Offset: 0x0032C470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331792, RefRangeEnd = 331793, XrefRangeStart = 331724, XrefRangeEnd = 331792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C99B RID: 51611 RVA: 0x0032E2AC File Offset: 0x0032C4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331793, XrefRangeEnd = 331797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C99C RID: 51612 RVA: 0x0032E2E8 File Offset: 0x0032C4E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 331815, RefRangeEnd = 331820, XrefRangeStart = 331797, XrefRangeEnd = 331815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveCategory(CharacterCustomizationCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(category);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_SetActiveCategory_Public_Void_CharacterCustomizationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C99D RID: 51613 RVA: 0x0032E32C File Offset: 0x0032C52C
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_New_Boolean_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C99E RID: 51614 RVA: 0x0032E384 File Offset: 0x0032C584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331820, XrefRangeEnd = 331823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_New_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C99F RID: 51615 RVA: 0x0032E3D4 File Offset: 0x0032C5D4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OptionDeselected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_OptionDeselected_Public_Virtual_New_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9A0 RID: 51616 RVA: 0x0032E424 File Offset: 0x0032C624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331823, XrefRangeEnd = 331826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OptionPurchased(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_OptionPurchased_Public_Virtual_New_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9A1 RID: 51617 RVA: 0x0032E474 File Offset: 0x0032C674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331851, RefRangeEnd = 331852, XrefRangeStart = 331826, XrefRangeEnd = 331851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9A2 RID: 51618 RVA: 0x0032E4B0 File Offset: 0x0032C6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331852, XrefRangeEnd = 331859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9A3 RID: 51619 RVA: 0x0032E4F4 File Offset: 0x0032C6F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9A4 RID: 51620 RVA: 0x0032E528 File Offset: 0x0032C728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331859, XrefRangeEnd = 331875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCustomizationUI.NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9A5 RID: 51621 RVA: 0x0032E564 File Offset: 0x0032C764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331875, XrefRangeEnd = 331880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9A6 RID: 51622 RVA: 0x0032E5A0 File Offset: 0x0032C7A0
		[CallerCount(0)]
		public unsafe void _Awake_b__27_0(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr__Awake_b__27_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9A7 RID: 51623 RVA: 0x0032E5E0 File Offset: 0x0032C7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331880, XrefRangeEnd = 331885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600C9A8 RID: 51624 RVA: 0x0032E620 File Offset: 0x0032C820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331885, XrefRangeEnd = 331890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600C9A9 RID: 51625 RVA: 0x0005F830 File Offset: 0x0005DA30
		public CharacterCustomizationUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x0600C9AA RID: 51626 RVA: 0x0032E660 File Offset: 0x0032C860
		// (set) Token: 0x0600C9AB RID: 51627 RVA: 0x0005F839 File Offset: 0x0005DA39
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x0600C9AC RID: 51628 RVA: 0x0032E688 File Offset: 0x0032C888
		// (set) Token: 0x0600C9AD RID: 51629 RVA: 0x0005F854 File Offset: 0x0005DA54
		public unsafe CharacterCustomizationCategory _ActiveCategory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr__ActiveCategory_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCategory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr__ActiveCategory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x0600C9AE RID: 51630 RVA: 0x0032E6B8 File Offset: 0x0032C8B8
		// (set) Token: 0x0600C9AF RID: 51631 RVA: 0x0005F873 File Offset: 0x0005DA73
		public unsafe string Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x0600C9B0 RID: 51632 RVA: 0x0032E6E0 File Offset: 0x0032C8E0
		// (set) Token: 0x0600C9B1 RID: 51633 RVA: 0x0005F892 File Offset: 0x0005DA92
		public unsafe Il2CppReferenceArray<CharacterCustomizationCategory> Categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterCustomizationCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x0600C9B2 RID: 51634 RVA: 0x0032E710 File Offset: 0x0032C910
		// (set) Token: 0x0600C9B3 RID: 51635 RVA: 0x0005F8B1 File Offset: 0x0005DAB1
		public unsafe bool LoadAvatarSettingsNaked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_LoadAvatarSettingsNaked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_LoadAvatarSettingsNaked)) = value;
			}
		}

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x0600C9B4 RID: 51636 RVA: 0x0032E738 File Offset: 0x0032C938
		// (set) Token: 0x0600C9B5 RID: 51637 RVA: 0x0005F8CC File Offset: 0x0005DACC
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x0600C9B6 RID: 51638 RVA: 0x0032E768 File Offset: 0x0032C968
		// (set) Token: 0x0600C9B7 RID: 51639 RVA: 0x0005F8EB File Offset: 0x0005DAEB
		public unsafe RectTransform MainContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_MainContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_MainContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x0600C9B8 RID: 51640 RVA: 0x0032E798 File Offset: 0x0032C998
		// (set) Token: 0x0600C9B9 RID: 51641 RVA: 0x0005F90A File Offset: 0x0005DB0A
		public unsafe RectTransform MenuContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_MenuContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_MenuContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x0600C9BA RID: 51642 RVA: 0x0032E7C8 File Offset: 0x0032C9C8
		// (set) Token: 0x0600C9BB RID: 51643 RVA: 0x0005F929 File Offset: 0x0005DB29
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x0600C9BC RID: 51644 RVA: 0x0032E7F8 File Offset: 0x0032C9F8
		// (set) Token: 0x0600C9BD RID: 51645 RVA: 0x0005F948 File Offset: 0x0005DB48
		public unsafe RectTransform ButtonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_ButtonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_ButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x0600C9BE RID: 51646 RVA: 0x0032E828 File Offset: 0x0032CA28
		// (set) Token: 0x0600C9BF RID: 51647 RVA: 0x0005F967 File Offset: 0x0005DB67
		public unsafe Button ExitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_ExitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_ExitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x0600C9C0 RID: 51648 RVA: 0x0032E858 File Offset: 0x0032CA58
		// (set) Token: 0x0600C9C1 RID: 51649 RVA: 0x0005F986 File Offset: 0x0005DB86
		public unsafe Slider RigRotationSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_RigRotationSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_RigRotationSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x0600C9C2 RID: 51650 RVA: 0x0032E888 File Offset: 0x0032CA88
		// (set) Token: 0x0600C9C3 RID: 51651 RVA: 0x0005F9A5 File Offset: 0x0005DBA5
		public unsafe RectTransform PreviewIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_PreviewIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_PreviewIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x0600C9C4 RID: 51652 RVA: 0x0032E8B8 File Offset: 0x0032CAB8
		// (set) Token: 0x0600C9C5 RID: 51653 RVA: 0x0005F9C4 File Offset: 0x0005DBC4
		public unsafe CharacterCustomizationShop CharacterCustomizationShop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_CharacterCustomizationShop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationShop>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_CharacterCustomizationShop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x0600C9C6 RID: 51654 RVA: 0x0032E8E8 File Offset: 0x0032CAE8
		// (set) Token: 0x0600C9C7 RID: 51655 RVA: 0x0005F9E3 File Offset: 0x0005DBE3
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x0600C9C8 RID: 51656 RVA: 0x0032E918 File Offset: 0x0032CB18
		// (set) Token: 0x0600C9C9 RID: 51657 RVA: 0x0005FA02 File Offset: 0x0005DC02
		public unsafe UIContentPanel MainPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_MainPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIContentPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_MainPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x0600C9CA RID: 51658 RVA: 0x0032E948 File Offset: 0x0032CB48
		// (set) Token: 0x0600C9CB RID: 51659 RVA: 0x0005FA21 File Offset: 0x0005DC21
		public unsafe Button CategoryButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_CategoryButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_CategoryButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x0600C9CC RID: 51660 RVA: 0x0032E978 File Offset: 0x0032CB78
		// (set) Token: 0x0600C9CD RID: 51661 RVA: 0x0005FA40 File Offset: 0x0005DC40
		public unsafe float rigTargetY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_rigTargetY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_rigTargetY)) = value;
			}
		}

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x0600C9CE RID: 51662 RVA: 0x0032E9A0 File Offset: 0x0032CBA0
		// (set) Token: 0x0600C9CF RID: 51663 RVA: 0x0005FA5B File Offset: 0x0005DC5B
		public unsafe Coroutine openCloseRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_openCloseRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_openCloseRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x0600C9D0 RID: 51664 RVA: 0x0032E9D0 File Offset: 0x0032CBD0
		// (set) Token: 0x0600C9D1 RID: 51665 RVA: 0x0005FA7A File Offset: 0x0005DC7A
		public unsafe BasicAvatarSettings currentSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_currentSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicAvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.NativeFieldInfoPtr_currentSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008950 RID: 35152
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04008951 RID: 35153
		private static readonly IntPtr NativeFieldInfoPtr__ActiveCategory_k__BackingField;

		// Token: 0x04008952 RID: 35154
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04008953 RID: 35155
		private static readonly IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x04008954 RID: 35156
		private static readonly IntPtr NativeFieldInfoPtr_LoadAvatarSettingsNaked;

		// Token: 0x04008955 RID: 35157
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04008956 RID: 35158
		private static readonly IntPtr NativeFieldInfoPtr_MainContainer;

		// Token: 0x04008957 RID: 35159
		private static readonly IntPtr NativeFieldInfoPtr_MenuContainer;

		// Token: 0x04008958 RID: 35160
		private static readonly IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04008959 RID: 35161
		private static readonly IntPtr NativeFieldInfoPtr_ButtonContainer;

		// Token: 0x0400895A RID: 35162
		private static readonly IntPtr NativeFieldInfoPtr_ExitButton;

		// Token: 0x0400895B RID: 35163
		private static readonly IntPtr NativeFieldInfoPtr_RigRotationSlider;

		// Token: 0x0400895C RID: 35164
		private static readonly IntPtr NativeFieldInfoPtr_PreviewIndicator;

		// Token: 0x0400895D RID: 35165
		private static readonly IntPtr NativeFieldInfoPtr_CharacterCustomizationShop;

		// Token: 0x0400895E RID: 35166
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x0400895F RID: 35167
		private static readonly IntPtr NativeFieldInfoPtr_MainPanel;

		// Token: 0x04008960 RID: 35168
		private static readonly IntPtr NativeFieldInfoPtr_CategoryButtonPrefab;

		// Token: 0x04008961 RID: 35169
		private static readonly IntPtr NativeFieldInfoPtr_rigTargetY;

		// Token: 0x04008962 RID: 35170
		private static readonly IntPtr NativeFieldInfoPtr_openCloseRoutine;

		// Token: 0x04008963 RID: 35171
		private static readonly IntPtr NativeFieldInfoPtr_currentSettings;

		// Token: 0x04008964 RID: 35172
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008965 RID: 35173
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04008966 RID: 35174
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCategory_Public_get_CharacterCustomizationCategory_0;

		// Token: 0x04008967 RID: 35175
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveCategory_Private_set_Void_CharacterCustomizationCategory_0;

		// Token: 0x04008968 RID: 35176
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04008969 RID: 35177
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400896A RID: 35178
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400896B RID: 35179
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveCategory_Public_Void_CharacterCustomizationCategory_0;

		// Token: 0x0400896C RID: 35180
		private static readonly IntPtr NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_New_Boolean_CharacterCustomizationOption_0;

		// Token: 0x0400896D RID: 35181
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Public_Virtual_New_Void_CharacterCustomizationOption_0;

		// Token: 0x0400896E RID: 35182
		private static readonly IntPtr NativeMethodInfoPtr_OptionDeselected_Public_Virtual_New_Void_CharacterCustomizationOption_0;

		// Token: 0x0400896F RID: 35183
		private static readonly IntPtr NativeMethodInfoPtr_OptionPurchased_Public_Virtual_New_Void_CharacterCustomizationOption_0;

		// Token: 0x04008970 RID: 35184
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0;

		// Token: 0x04008971 RID: 35185
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04008972 RID: 35186
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x04008973 RID: 35187
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Protected_Virtual_New_Void_0;

		// Token: 0x04008974 RID: 35188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04008975 RID: 35189
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__27_0_Private_Void_Single_0;

		// Token: 0x04008976 RID: 35190
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04008977 RID: 35191
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x02000D7A RID: 3450
		[ObfuscatedName("ScheduleOne.UI.CharacterCustomization.CharacterCustomizationUI+<<OnClose>g__Close|37_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600FBB1 RID: 64433 RVA: 0x003C128C File Offset: 0x003BF48C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "<<OnClose>g__Close|37_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100689325);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100689326);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100689327);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100689328);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100689329);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr, 100689330);
			}

			// Token: 0x0600FBB2 RID: 64434 RVA: 0x003C136C File Offset: 0x003BF56C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBB3 RID: 64435 RVA: 0x003C13B4 File Offset: 0x003BF5B4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBB4 RID: 64436 RVA: 0x003C13E8 File Offset: 0x003BF5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331656, XrefRangeEnd = 331668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004C80 RID: 19584
			// (get) Token: 0x0600FBB5 RID: 64437 RVA: 0x003C1424 File Offset: 0x003BF624
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600FBB6 RID: 64438 RVA: 0x003C1464 File Offset: 0x003BF664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331668, XrefRangeEnd = 331673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004C81 RID: 19585
			// (get) Token: 0x0600FBB7 RID: 64439 RVA: 0x003C1498 File Offset: 0x003BF698
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600FBB8 RID: 64440 RVA: 0x0007722C File Offset: 0x0007542C
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C7D RID: 19581
			// (get) Token: 0x0600FBB9 RID: 64441 RVA: 0x003C14D8 File Offset: 0x003BF6D8
			// (set) Token: 0x0600FBBA RID: 64442 RVA: 0x00077235 File Offset: 0x00075435
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004C7E RID: 19582
			// (get) Token: 0x0600FBBB RID: 64443 RVA: 0x003C1500 File Offset: 0x003BF700
			// (set) Token: 0x0600FBBC RID: 64444 RVA: 0x00077250 File Offset: 0x00075450
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C7F RID: 19583
			// (get) Token: 0x0600FBBD RID: 64445 RVA: 0x003C1530 File Offset: 0x003BF730
			// (set) Token: 0x0600FBBE RID: 64446 RVA: 0x0007726F File Offset: 0x0007546F
			public unsafe CharacterCustomizationUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9CB RID: 43467
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A9CC RID: 43468
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A9CD RID: 43469
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A9CE RID: 43470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A9CF RID: 43471
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A9D0 RID: 43472
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A9D1 RID: 43473
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A9D2 RID: 43474
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A9D3 RID: 43475
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D7B RID: 3451
		[ObfuscatedName("ScheduleOne.UI.CharacterCustomization.CharacterCustomizationUI+<<Open>g__Close|34_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600FBBF RID: 64447 RVA: 0x003C1560 File Offset: 0x003BF760
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "<<Open>g__Close|34_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100689331);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100689332);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100689333);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100689334);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100689335);
				CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr, 100689336);
			}

			// Token: 0x0600FBC0 RID: 64448 RVA: 0x003C1640 File Offset: 0x003BF840
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBC1 RID: 64449 RVA: 0x003C1688 File Offset: 0x003BF888
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBC2 RID: 64450 RVA: 0x003C16BC File Offset: 0x003BF8BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331673, XrefRangeEnd = 331712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004C85 RID: 19589
			// (get) Token: 0x0600FBC3 RID: 64451 RVA: 0x003C16F8 File Offset: 0x003BF8F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600FBC4 RID: 64452 RVA: 0x003C1738 File Offset: 0x003BF938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331712, XrefRangeEnd = 331717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004C86 RID: 19590
			// (get) Token: 0x0600FBC5 RID: 64453 RVA: 0x003C176C File Offset: 0x003BF96C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600FBC6 RID: 64454 RVA: 0x0007728E File Offset: 0x0007548E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C82 RID: 19586
			// (get) Token: 0x0600FBC7 RID: 64455 RVA: 0x003C17AC File Offset: 0x003BF9AC
			// (set) Token: 0x0600FBC8 RID: 64456 RVA: 0x00077297 File Offset: 0x00075497
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004C83 RID: 19587
			// (get) Token: 0x0600FBC9 RID: 64457 RVA: 0x003C17D4 File Offset: 0x003BF9D4
			// (set) Token: 0x0600FBCA RID: 64458 RVA: 0x000772B2 File Offset: 0x000754B2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C84 RID: 19588
			// (get) Token: 0x0600FBCB RID: 64459 RVA: 0x003C1804 File Offset: 0x003BFA04
			// (set) Token: 0x0600FBCC RID: 64460 RVA: 0x000772D1 File Offset: 0x000754D1
			public unsafe CharacterCustomizationUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObChVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9D4 RID: 43476
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A9D5 RID: 43477
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A9D6 RID: 43478
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A9D7 RID: 43479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A9D8 RID: 43480
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A9D9 RID: 43481
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A9DA RID: 43482
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A9DB RID: 43483
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A9DC RID: 43484
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D7C RID: 3452
		[ObfuscatedName("ScheduleOne.UI.CharacterCustomization.CharacterCustomizationUI+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FBCD RID: 64461 RVA: 0x003C1834 File Offset: 0x003BFA34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationUI>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr);
				CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr, "category");
				CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				CharacterCustomizationUI.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr, 100689337);
				CharacterCustomizationUI.__c__DisplayClass27_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr, 100689338);
			}

			// Token: 0x0600FBCE RID: 64462 RVA: 0x003C18B0 File Offset: 0x003BFAB0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationUI.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBCF RID: 64463 RVA: 0x003C18EC File Offset: 0x003BFAEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331717, XrefRangeEnd = 331719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationUI.__c__DisplayClass27_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FBD0 RID: 64464 RVA: 0x000772F0 File Offset: 0x000754F0
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C87 RID: 19591
			// (get) Token: 0x0600FBD1 RID: 64465 RVA: 0x003C1920 File Offset: 0x003BFB20
			// (set) Token: 0x0600FBD2 RID: 64466 RVA: 0x000772F9 File Offset: 0x000754F9
			public unsafe CharacterCustomizationCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr_category);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCategory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr_category), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C88 RID: 19592
			// (get) Token: 0x0600FBD3 RID: 64467 RVA: 0x003C1950 File Offset: 0x003BFB50
			// (set) Token: 0x0600FBD4 RID: 64468 RVA: 0x00077318 File Offset: 0x00075518
			public unsafe CharacterCustomizationUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationUI.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9DD RID: 43485
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x0400A9DE RID: 43486
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A9DF RID: 43487
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A9E0 RID: 43488
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_0;
		}
	}
}

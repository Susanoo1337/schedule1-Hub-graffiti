using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000744 RID: 1860
	public class NewMixScreen : Singleton<NewMixScreen>
	{
		// Token: 0x0600B484 RID: 46212 RVA: 0x002EE330 File Offset: 0x002EC530
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixScreen()
		{
			Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "NewMixScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr);
			NewMixScreen.NativeFieldInfoPtr_MaxDisplayedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "MaxDisplayedProperties");
			NewMixScreen.NativeFieldInfoPtr_onMixNamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "onMixNamed");
			NewMixScreen.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "canvas");
			NewMixScreen.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "container");
			NewMixScreen.NativeFieldInfoPtr_nameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "nameInputField");
			NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "mixAlreadyExistsText");
			NewMixScreen.NativeFieldInfoPtr_editIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "editIcon");
			NewMixScreen.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "confirmButton");
			NewMixScreen.NativeFieldInfoPtr_propertiesLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "propertiesLabels");
			NewMixScreen.NativeFieldInfoPtr_marketValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "marketValueLabel");
			NewMixScreen.NativeFieldInfoPtr_sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "sound");
			NewMixScreen.NativeFieldInfoPtr_screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "screen");
			NewMixScreen.NativeFieldInfoPtr_name1Library = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "name1Library");
			NewMixScreen.NativeFieldInfoPtr_name2Library = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "name2Library");
			NewMixScreen.NativeMethodInfoPtr_add_onMixNamed_Public_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686959);
			NewMixScreen.NativeMethodInfoPtr_remove_onMixNamed_Public_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686960);
			NewMixScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686961);
			NewMixScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686962);
			NewMixScreen.NativeMethodInfoPtr_Open_Public_Void_List_1_Effect_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686963);
			NewMixScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686964);
			NewMixScreen.NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686965);
			NewMixScreen.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686966);
			NewMixScreen.NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Effect_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686967);
			NewMixScreen.NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686968);
			NewMixScreen.NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686969);
			NewMixScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100686970);
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x002EE568 File Offset: 0x002EC768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304097, RefRangeEnd = 304098, XrefRangeStart = 304092, XrefRangeEnd = 304097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onMixNamed(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_add_onMixNamed_Public_add_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B486 RID: 46214 RVA: 0x002EE5AC File Offset: 0x002EC7AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304103, RefRangeEnd = 304104, XrefRangeStart = 304098, XrefRangeEnd = 304103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onMixNamed(Action<string> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_remove_onMixNamed_Public_rem_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x0600B487 RID: 46215 RVA: 0x002EE5F0 File Offset: 0x002EC7F0
		public unsafe bool IsOpen
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 304106, RefRangeEnd = 304108, XrefRangeStart = 304104, XrefRangeEnd = 304106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B488 RID: 46216 RVA: 0x002EE62C File Offset: 0x002EC82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304108, XrefRangeEnd = 304131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewMixScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x002EE668 File Offset: 0x002EC868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304190, RefRangeEnd = 304191, XrefRangeStart = 304131, XrefRangeEnd = 304190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<Effect> properties, EDrugType drugType, float productMarketValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productMarketValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_Open_Public_Void_List_1_Effect_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x002EE6C8 File Offset: 0x002EC8C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304206, RefRangeEnd = 304207, XrefRangeStart = 304191, XrefRangeEnd = 304206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48B RID: 46219 RVA: 0x002EE6FC File Offset: 0x002EC8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304207, XrefRangeEnd = 304210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48C RID: 46220 RVA: 0x002EE730 File Offset: 0x002EC930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304210, XrefRangeEnd = 304227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x002EE764 File Offset: 0x002EC964
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 304268, RefRangeEnd = 304273, XrefRangeStart = 304227, XrefRangeEnd = 304268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GenerateUniqueName(Il2CppReferenceArray<Effect> properties = null, EDrugType drugType = EDrugType.Marijuana)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Effect_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x002EE7BC File Offset: 0x002EC9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304273, XrefRangeEnd = 304276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNameButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x002EE7F0 File Offset: 0x002EC9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304276, XrefRangeEnd = 304299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNameValueChanged(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B490 RID: 46224 RVA: 0x002EE834 File Offset: 0x002ECA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304299, XrefRangeEnd = 304314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B491 RID: 46225 RVA: 0x00053733 File Offset: 0x00051933
		public NewMixScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0600B492 RID: 46226 RVA: 0x002EE870 File Offset: 0x002ECA70
		// (set) Token: 0x0600B493 RID: 46227 RVA: 0x0005373C File Offset: 0x0005193C
		public unsafe static int MaxDisplayedProperties
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NewMixScreen.NativeFieldInfoPtr_MaxDisplayedProperties, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewMixScreen.NativeFieldInfoPtr_MaxDisplayedProperties, (void*)(&value));
			}
		}

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x0600B494 RID: 46228 RVA: 0x002EE88C File Offset: 0x002ECA8C
		// (set) Token: 0x0600B495 RID: 46229 RVA: 0x0005374A File Offset: 0x0005194A
		public unsafe Action<string> onMixNamed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_onMixNamed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_onMixNamed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x0600B496 RID: 46230 RVA: 0x002EE8BC File Offset: 0x002ECABC
		// (set) Token: 0x0600B497 RID: 46231 RVA: 0x00053769 File Offset: 0x00051969
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x0600B498 RID: 46232 RVA: 0x002EE8EC File Offset: 0x002ECAEC
		// (set) Token: 0x0600B499 RID: 46233 RVA: 0x00053788 File Offset: 0x00051988
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x0600B49A RID: 46234 RVA: 0x002EE91C File Offset: 0x002ECB1C
		// (set) Token: 0x0600B49B RID: 46235 RVA: 0x000537A7 File Offset: 0x000519A7
		public unsafe TMP_InputField nameInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_nameInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_nameInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x0600B49C RID: 46236 RVA: 0x002EE94C File Offset: 0x002ECB4C
		// (set) Token: 0x0600B49D RID: 46237 RVA: 0x000537C6 File Offset: 0x000519C6
		public unsafe GameObject mixAlreadyExistsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x0600B49E RID: 46238 RVA: 0x002EE97C File Offset: 0x002ECB7C
		// (set) Token: 0x0600B49F RID: 46239 RVA: 0x000537E5 File Offset: 0x000519E5
		public unsafe RectTransform editIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_editIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_editIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x0600B4A0 RID: 46240 RVA: 0x002EE9AC File Offset: 0x002ECBAC
		// (set) Token: 0x0600B4A1 RID: 46241 RVA: 0x00053804 File Offset: 0x00051A04
		public unsafe Button confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x0600B4A2 RID: 46242 RVA: 0x002EE9DC File Offset: 0x002ECBDC
		// (set) Token: 0x0600B4A3 RID: 46243 RVA: 0x00053823 File Offset: 0x00051A23
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> propertiesLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_propertiesLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_propertiesLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x0600B4A4 RID: 46244 RVA: 0x002EEA0C File Offset: 0x002ECC0C
		// (set) Token: 0x0600B4A5 RID: 46245 RVA: 0x00053842 File Offset: 0x00051A42
		public unsafe TextMeshProUGUI marketValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_marketValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_marketValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x0600B4A6 RID: 46246 RVA: 0x002EEA3C File Offset: 0x002ECC3C
		// (set) Token: 0x0600B4A7 RID: 46247 RVA: 0x00053861 File Offset: 0x00051A61
		public unsafe AudioSourceController sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x0600B4A8 RID: 46248 RVA: 0x002EEA6C File Offset: 0x002ECC6C
		// (set) Token: 0x0600B4A9 RID: 46249 RVA: 0x00053880 File Offset: 0x00051A80
		public unsafe UIScreen screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x0600B4AA RID: 46250 RVA: 0x002EEA9C File Offset: 0x002ECC9C
		// (set) Token: 0x0600B4AB RID: 46251 RVA: 0x0005389F File Offset: 0x00051A9F
		public unsafe List<string> name1Library
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name1Library);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name1Library), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x0600B4AC RID: 46252 RVA: 0x002EEACC File Offset: 0x002ECCCC
		// (set) Token: 0x0600B4AD RID: 46253 RVA: 0x000538BE File Offset: 0x00051ABE
		public unsafe List<string> name2Library
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name2Library);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name2Library), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C2D RID: 31789
		private static readonly IntPtr NativeFieldInfoPtr_MaxDisplayedProperties;

		// Token: 0x04007C2E RID: 31790
		private static readonly IntPtr NativeFieldInfoPtr_onMixNamed;

		// Token: 0x04007C2F RID: 31791
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04007C30 RID: 31792
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04007C31 RID: 31793
		private static readonly IntPtr NativeFieldInfoPtr_nameInputField;

		// Token: 0x04007C32 RID: 31794
		private static readonly IntPtr NativeFieldInfoPtr_mixAlreadyExistsText;

		// Token: 0x04007C33 RID: 31795
		private static readonly IntPtr NativeFieldInfoPtr_editIcon;

		// Token: 0x04007C34 RID: 31796
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x04007C35 RID: 31797
		private static readonly IntPtr NativeFieldInfoPtr_propertiesLabels;

		// Token: 0x04007C36 RID: 31798
		private static readonly IntPtr NativeFieldInfoPtr_marketValueLabel;

		// Token: 0x04007C37 RID: 31799
		private static readonly IntPtr NativeFieldInfoPtr_sound;

		// Token: 0x04007C38 RID: 31800
		private static readonly IntPtr NativeFieldInfoPtr_screen;

		// Token: 0x04007C39 RID: 31801
		private static readonly IntPtr NativeFieldInfoPtr_name1Library;

		// Token: 0x04007C3A RID: 31802
		private static readonly IntPtr NativeFieldInfoPtr_name2Library;

		// Token: 0x04007C3B RID: 31803
		private static readonly IntPtr NativeMethodInfoPtr_add_onMixNamed_Public_add_Void_Action_1_String_0;

		// Token: 0x04007C3C RID: 31804
		private static readonly IntPtr NativeMethodInfoPtr_remove_onMixNamed_Public_rem_Void_Action_1_String_0;

		// Token: 0x04007C3D RID: 31805
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007C3E RID: 31806
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007C3F RID: 31807
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_Effect_EDrugType_Single_0;

		// Token: 0x04007C40 RID: 31808
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007C41 RID: 31809
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0;

		// Token: 0x04007C42 RID: 31810
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0;

		// Token: 0x04007C43 RID: 31811
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Effect_EDrugType_0;

		// Token: 0x04007C44 RID: 31812
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0;

		// Token: 0x04007C45 RID: 31813
		private static readonly IntPtr NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0;

		// Token: 0x04007C46 RID: 31814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

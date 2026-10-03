using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000168 RID: 360
	public class TouchScreenKeyboard : Object
	{
		// Token: 0x06001B5F RID: 7007 RVA: 0x000721A0 File Offset: 0x000703A0
		// Note: this type is marked as 'beforefieldinit'.
		static TouchScreenKeyboard()
		{
			Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TouchScreenKeyboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr);
			TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, "m_Ptr");
			TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, "<disableInPlaceEditing>k__BackingField");
			TouchScreenKeyboard.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666218);
			TouchScreenKeyboard.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666219);
			TouchScreenKeyboard.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666220);
			TouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666221);
			TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666222);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666223);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666224);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666225);
			TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666226);
			TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666227);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666228);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666229);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666230);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666231);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666232);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666233);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666234);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666235);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666236);
			TouchScreenKeyboard.NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666237);
			TouchScreenKeyboard.NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666238);
			TouchScreenKeyboard.NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666239);
			TouchScreenKeyboard.NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100666240);
			TouchScreenKeyboard.IsInPlaceEditingAllowedDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.IsInPlaceEditingAllowedDelegate>("UnityEngine.TouchScreenKeyboard::IsInPlaceEditingAllowed");
			TouchScreenKeyboard.IsRequiredToForceOpenDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.IsRequiredToForceOpenDelegate>("UnityEngine.TouchScreenKeyboard::IsRequiredToForceOpen");
			TouchScreenKeyboard.get_hideInputDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_hideInputDelegate>("UnityEngine.TouchScreenKeyboard::get_hideInput");
			TouchScreenKeyboard.GetDoneDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.GetDoneDelegate>("UnityEngine.TouchScreenKeyboard::GetDone");
			TouchScreenKeyboard.GetWasCanceledDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.GetWasCanceledDelegate>("UnityEngine.TouchScreenKeyboard::GetWasCanceled");
			TouchScreenKeyboard.get_characterLimitDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_characterLimitDelegate>("UnityEngine.TouchScreenKeyboard::get_characterLimit");
			TouchScreenKeyboard.get_typeDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_typeDelegate>("UnityEngine.TouchScreenKeyboard::get_type");
			TouchScreenKeyboard.get_visibleDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_visibleDelegate>("UnityEngine.TouchScreenKeyboard::get_visible");
			TouchScreenKeyboard.get_area_InjectedDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_area_InjectedDelegate>("UnityEngine.TouchScreenKeyboard::get_area_Injected");
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0007244C File Offset: 0x0007064C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273287, XrefRangeEnd = 1273289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			IntPtr* ptr2 = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr2 = ref ptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00072480 File Offset: 0x00070680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273289, XrefRangeEnd = 1273296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x000724B4 File Offset: 0x000706B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273296, XrefRangeEnd = 1273306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TouchScreenKeyboard.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x000724F0 File Offset: 0x000706F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273306, XrefRangeEnd = 1273320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autocorrection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x000725A4 File Offset: 0x000707A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273320, XrefRangeEnd = 1273322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &arguments;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x00072608 File Offset: 0x00070808
		public unsafe static bool isSupported
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1273326, RefRangeEnd = 1273344, XrefRangeStart = 1273322, XrefRangeEnd = 1273326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x00072638 File Offset: 0x00070838
		// (set) Token: 0x06001B7C RID: 7036 RVA: 0x0000D1B7 File Offset: 0x0000B3B7
		public unsafe static bool disableInPlaceEditing
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273344, XrefRangeEnd = 1273346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				TouchScreenKeyboard._disableInPlaceEditing_k__BackingField = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00072668 File Offset: 0x00070868
		public unsafe static bool isInPlaceEditingAllowed
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1273347, RefRangeEnd = 1273358, XrefRangeStart = 1273346, XrefRangeEnd = 1273347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00072698 File Offset: 0x00070898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1273375, RefRangeEnd = 1273377, XrefRangeStart = 1273358, XrefRangeEnd = 1273375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autocorrection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alert;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterLimit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr3) : null;
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00072744 File Offset: 0x00070944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273396, RefRangeEnd = 1273397, XrefRangeStart = 1273377, XrefRangeEnd = 1273396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyboardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autocorrection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiline;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr3) : null;
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x000727C0 File Offset: 0x000709C0
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x000727F8 File Offset: 0x000709F8
		public unsafe string text
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1273399, RefRangeEnd = 1273405, XrefRangeStart = 1273397, XrefRangeEnd = 1273399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1273407, RefRangeEnd = 1273419, XrefRangeStart = 1273405, XrefRangeEnd = 1273407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x0000D1D7 File Offset: 0x0000B3D7
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0007283C File Offset: 0x00070A3C
		public unsafe static bool hideInput
		{
			get
			{
				return TouchScreenKeyboard.get_hideInputDelegateField();
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1273421, RefRangeEnd = 1273425, XrefRangeStart = 1273419, XrefRangeEnd = 1273421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x00072870 File Offset: 0x00070A70
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x000728AC File Offset: 0x00070AAC
		public unsafe bool active
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1273427, RefRangeEnd = 1273433, XrefRangeStart = 1273425, XrefRangeEnd = 1273427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1273435, RefRangeEnd = 1273441, XrefRangeStart = 1273433, XrefRangeEnd = 1273435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x000728EC File Offset: 0x00070AEC
		public unsafe TouchScreenKeyboard.Status status
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1273443, RefRangeEnd = 1273444, XrefRangeStart = 1273441, XrefRangeEnd = 1273443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Public_get_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0000D1FD File Offset: 0x0000B3FD
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x00072928 File Offset: 0x00070B28
		public unsafe int characterLimit
		{
			get
			{
				return TouchScreenKeyboard.get_characterLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1273446, RefRangeEnd = 1273448, XrefRangeStart = 1273444, XrefRangeEnd = 1273446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x00072968 File Offset: 0x00070B68
		public unsafe bool canGetSelection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273448, XrefRangeEnd = 1273450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x000729A4 File Offset: 0x00070BA4
		public unsafe bool canSetSelection
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1273452, RefRangeEnd = 1273455, XrefRangeStart = 1273450, XrefRangeEnd = 1273452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x000729E0 File Offset: 0x00070BE0
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x00072A1C File Offset: 0x00070C1C
		public unsafe RangeInt selection
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1273457, RefRangeEnd = 1273460, XrefRangeStart = 1273455, XrefRangeEnd = 1273457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1273472, RefRangeEnd = 1273481, XrefRangeStart = 1273460, XrefRangeEnd = 1273472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00072A5C File Offset: 0x00070C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273481, XrefRangeEnd = 1273483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSelection(out int start, out int length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00072A9C File Offset: 0x00070C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273483, XrefRangeEnd = 1273485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSelection(int start, int length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0000D185 File Offset: 0x0000B385
		public TouchScreenKeyboard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x00072ADC File Offset: 0x00070CDC
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0000D18E File Offset: 0x0000B38E
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00072B04 File Offset: 0x00070D04
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0000D1A9 File Offset: 0x0000B3A9
		public unsafe static bool _disableInPlaceEditing_k__BackingField
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0000D1BF File Offset: 0x0000B3BF
		public static bool IsInPlaceEditingAllowed()
		{
			return TouchScreenKeyboard.IsInPlaceEditingAllowedDelegateField();
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x00072B20 File Offset: 0x00070D20
		public static bool isRequiredToForceOpen
		{
			get
			{
				return TouchScreenKeyboard.IsRequiredToForceOpen();
			}
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0000D1CB File Offset: 0x0000B3CB
		public static bool IsRequiredToForceOpen()
		{
			return TouchScreenKeyboard.IsRequiredToForceOpenDelegateField();
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00072B38 File Offset: 0x00070D38
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder)
		{
			int characterLimit = 0;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00072B5C File Offset: 0x00070D5C
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert)
		{
			int characterLimit = 0;
			string textPlaceholder = "";
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00072B88 File Offset: 0x00070D88
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline)
		{
			int characterLimit = 0;
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x00072BB8 File Offset: 0x00070DB8
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection)
		{
			int characterLimit = 0;
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			bool multiline = false;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x00072BEC File Offset: 0x00070DEC
		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType)
		{
			int characterLimit = 0;
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			bool multiline = false;
			bool autocorrection = true;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00072C24 File Offset: 0x00070E24
		public static TouchScreenKeyboard Open(string text)
		{
			int characterLimit = 0;
			string textPlaceholder = "";
			bool alert = false;
			bool secure = false;
			bool multiline = false;
			bool autocorrection = true;
			TouchScreenKeyboardType keyboardType = TouchScreenKeyboardType.Default;
			return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0000D1E3 File Offset: 0x0000B3E3
		public static bool GetDone(IntPtr ptr)
		{
			return TouchScreenKeyboard.GetDoneDelegateField(ptr);
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x00072C60 File Offset: 0x00070E60
		public bool done
		{
			get
			{
				return TouchScreenKeyboard.GetDone(this.m_Ptr);
			}
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0000D1F0 File Offset: 0x0000B3F0
		public static bool GetWasCanceled(IntPtr ptr)
		{
			return TouchScreenKeyboard.GetWasCanceledDelegateField(ptr);
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x00072C80 File Offset: 0x00070E80
		public bool wasCanceled
		{
			get
			{
				return TouchScreenKeyboard.GetWasCanceled(this.m_Ptr);
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x0000D20F File Offset: 0x0000B40F
		public TouchScreenKeyboardType type
		{
			get
			{
				return TouchScreenKeyboard.get_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x00072CA0 File Offset: 0x00070EA0
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0000D221 File Offset: 0x0000B421
		public int targetDisplay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00072CB4 File Offset: 0x00070EB4
		public static Rect area
		{
			get
			{
				Rect result;
				TouchScreenKeyboard.get_area_Injected(out result);
				return result;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0000D224 File Offset: 0x0000B424
		public static bool visible
		{
			get
			{
				return TouchScreenKeyboard.get_visibleDelegateField();
			}
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0000D230 File Offset: 0x0000B430
		public static void get_area_Injected(out Rect ret)
		{
			TouchScreenKeyboard.get_area_InjectedDelegateField(out ret);
		}

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04001689 RID: 5769
		private static readonly IntPtr NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField;

		// Token: 0x0400168A RID: 5770
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x0400168B RID: 5771
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;

		// Token: 0x0400168C RID: 5772
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400168D RID: 5773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0;

		// Token: 0x0400168E RID: 5774
		private static readonly IntPtr NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0;

		// Token: 0x0400168F RID: 5775
		private static readonly IntPtr NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0;

		// Token: 0x04001690 RID: 5776
		private static readonly IntPtr NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0;

		// Token: 0x04001691 RID: 5777
		private static readonly IntPtr NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0;

		// Token: 0x04001692 RID: 5778
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0;

		// Token: 0x04001693 RID: 5779
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0;

		// Token: 0x04001694 RID: 5780
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x04001695 RID: 5781
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x04001696 RID: 5782
		private static readonly IntPtr NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0;

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeMethodInfoPtr_get_status_Public_get_Status_0;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly TouchScreenKeyboard.IsInPlaceEditingAllowedDelegate IsInPlaceEditingAllowedDelegateField;

		// Token: 0x040016A2 RID: 5794
		private static readonly TouchScreenKeyboard.IsRequiredToForceOpenDelegate IsRequiredToForceOpenDelegateField;

		// Token: 0x040016A3 RID: 5795
		private static readonly TouchScreenKeyboard.get_hideInputDelegate get_hideInputDelegateField;

		// Token: 0x040016A4 RID: 5796
		private static readonly TouchScreenKeyboard.GetDoneDelegate GetDoneDelegateField;

		// Token: 0x040016A5 RID: 5797
		private static readonly TouchScreenKeyboard.GetWasCanceledDelegate GetWasCanceledDelegateField;

		// Token: 0x040016A6 RID: 5798
		private static readonly TouchScreenKeyboard.get_characterLimitDelegate get_characterLimitDelegateField;

		// Token: 0x040016A7 RID: 5799
		private static readonly TouchScreenKeyboard.get_typeDelegate get_typeDelegateField;

		// Token: 0x040016A8 RID: 5800
		private static readonly TouchScreenKeyboard.get_visibleDelegate get_visibleDelegateField;

		// Token: 0x040016A9 RID: 5801
		private static readonly TouchScreenKeyboard.get_area_InjectedDelegate get_area_InjectedDelegateField;

		// Token: 0x0200096A RID: 2410
		[OriginalName("UnityEngine.CoreModule.dll", "", "Status")]
		public enum Status
		{
			// Token: 0x04002B55 RID: 11093
			Visible,
			// Token: 0x04002B56 RID: 11094
			Done,
			// Token: 0x04002B57 RID: 11095
			Canceled,
			// Token: 0x04002B58 RID: 11096
			LostFocus
		}

		// Token: 0x0200096B RID: 2411
		public class Android
		{
		}

		// Token: 0x0200096C RID: 2412
		// (Invoke) Token: 0x06003B50 RID: 15184
		private delegate bool IsInPlaceEditingAllowedDelegate();

		// Token: 0x0200096D RID: 2413
		// (Invoke) Token: 0x06003B52 RID: 15186
		private delegate bool IsRequiredToForceOpenDelegate();

		// Token: 0x0200096E RID: 2414
		// (Invoke) Token: 0x06003B54 RID: 15188
		private delegate bool get_hideInputDelegate();

		// Token: 0x0200096F RID: 2415
		// (Invoke) Token: 0x06003B56 RID: 15190
		private delegate bool GetDoneDelegate(IntPtr ptr);

		// Token: 0x02000970 RID: 2416
		// (Invoke) Token: 0x06003B58 RID: 15192
		private delegate bool GetWasCanceledDelegate(IntPtr ptr);

		// Token: 0x02000971 RID: 2417
		// (Invoke) Token: 0x06003B5A RID: 15194
		private delegate int get_characterLimitDelegate(IntPtr @this);

		// Token: 0x02000972 RID: 2418
		// (Invoke) Token: 0x06003B5C RID: 15196
		private delegate TouchScreenKeyboardType get_typeDelegate(IntPtr @this);

		// Token: 0x02000973 RID: 2419
		// (Invoke) Token: 0x06003B5E RID: 15198
		private delegate bool get_visibleDelegate();

		// Token: 0x02000974 RID: 2420
		// (Invoke) Token: 0x06003B60 RID: 15200
		private delegate void get_area_InjectedDelegate([Out] IntPtr ret);
	}
}

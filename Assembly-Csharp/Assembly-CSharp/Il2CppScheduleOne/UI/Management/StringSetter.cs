using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007E0 RID: 2016
	public class StringSetter : ClipboardScreen
	{
		// Token: 0x0600C527 RID: 50471 RVA: 0x00320408 File Offset: 0x0031E608
		// Note: this type is marked as 'beforefieldinit'.
		static StringSetter()
		{
			Il2CppClassPointerStore<StringSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "StringSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringSetter>.NativeClassPtr);
			StringSetter.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, "TitleLabel");
			StringSetter.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, "InputField");
			StringSetter.NativeFieldInfoPtr_DoneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, "DoneButton");
			StringSetter.NativeFieldInfoPtr__existingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, "_existingValue");
			StringSetter.NativeFieldInfoPtr__allowEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, "_allowEmpty");
			StringSetter.NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, "_callback");
			StringSetter.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, "panel");
			StringSetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, 100688857);
			StringSetter.NativeMethodInfoPtr_Initialize_Public_Void_String_String_Int32_Boolean_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, 100688858);
			StringSetter.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, 100688859);
			StringSetter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, 100688860);
			StringSetter.NativeMethodInfoPtr_DoneButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, 100688861);
			StringSetter.NativeMethodInfoPtr_OnSubmit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, 100688862);
			StringSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSetter>.NativeClassPtr, 100688863);
		}

		// Token: 0x0600C528 RID: 50472 RVA: 0x00320550 File Offset: 0x0031E750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326609, XrefRangeEnd = 326626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringSetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C529 RID: 50473 RVA: 0x00320584 File Offset: 0x0031E784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326644, RefRangeEnd = 326645, XrefRangeStart = 326626, XrefRangeEnd = 326644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string selectionTitle, string existingValue, int characterLimit, bool allowEmpty, Action<string> callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(existingValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterLimit;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowEmpty;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringSetter.NativeMethodInfoPtr_Initialize_Public_Void_String_String_Int32_Boolean_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C52A RID: 50474 RVA: 0x00320608 File Offset: 0x0031E808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326645, XrefRangeEnd = 326660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringSetter.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C52B RID: 50475 RVA: 0x00320644 File Offset: 0x0031E844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326660, XrefRangeEnd = 326670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringSetter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C52C RID: 50476 RVA: 0x00320680 File Offset: 0x0031E880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326670, XrefRangeEnd = 326672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoneButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringSetter.NativeMethodInfoPtr_DoneButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C52D RID: 50477 RVA: 0x003206B4 File Offset: 0x0031E8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326672, XrefRangeEnd = 326673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmit(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringSetter.NativeMethodInfoPtr_OnSubmit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C52E RID: 50478 RVA: 0x003206F8 File Offset: 0x0031E8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326673, XrefRangeEnd = 326678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C52F RID: 50479 RVA: 0x0005D0E5 File Offset: 0x0005B2E5
		public StringSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003BD9 RID: 15321
		// (get) Token: 0x0600C530 RID: 50480 RVA: 0x00320734 File Offset: 0x0031E934
		// (set) Token: 0x0600C531 RID: 50481 RVA: 0x0005D0EE File Offset: 0x0005B2EE
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BDA RID: 15322
		// (get) Token: 0x0600C532 RID: 50482 RVA: 0x00320764 File Offset: 0x0031E964
		// (set) Token: 0x0600C533 RID: 50483 RVA: 0x0005D10D File Offset: 0x0005B30D
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x0600C534 RID: 50484 RVA: 0x00320794 File Offset: 0x0031E994
		// (set) Token: 0x0600C535 RID: 50485 RVA: 0x0005D12C File Offset: 0x0005B32C
		public unsafe Button DoneButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr_DoneButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr_DoneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x0600C536 RID: 50486 RVA: 0x003207C4 File Offset: 0x0031E9C4
		// (set) Token: 0x0600C537 RID: 50487 RVA: 0x0005D14B File Offset: 0x0005B34B
		public unsafe string _existingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr__existingValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr__existingValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x0600C538 RID: 50488 RVA: 0x003207EC File Offset: 0x0031E9EC
		// (set) Token: 0x0600C539 RID: 50489 RVA: 0x0005D16A File Offset: 0x0005B36A
		public unsafe bool _allowEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr__allowEmpty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr__allowEmpty)) = value;
			}
		}

		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x0600C53A RID: 50490 RVA: 0x00320814 File Offset: 0x0031EA14
		// (set) Token: 0x0600C53B RID: 50491 RVA: 0x0005D185 File Offset: 0x0005B385
		public unsafe Action<string> _callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr__callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr__callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x0600C53C RID: 50492 RVA: 0x00320844 File Offset: 0x0031EA44
		// (set) Token: 0x0600C53D RID: 50493 RVA: 0x0005D1A4 File Offset: 0x0005B3A4
		public unsafe UIContentPanel panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr_panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIContentPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSetter.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400868D RID: 34445
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400868E RID: 34446
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x0400868F RID: 34447
		private static readonly IntPtr NativeFieldInfoPtr_DoneButton;

		// Token: 0x04008690 RID: 34448
		private static readonly IntPtr NativeFieldInfoPtr__existingValue;

		// Token: 0x04008691 RID: 34449
		private static readonly IntPtr NativeFieldInfoPtr__allowEmpty;

		// Token: 0x04008692 RID: 34450
		private static readonly IntPtr NativeFieldInfoPtr__callback;

		// Token: 0x04008693 RID: 34451
		private static readonly IntPtr NativeFieldInfoPtr_panel;

		// Token: 0x04008694 RID: 34452
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04008695 RID: 34453
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_String_Int32_Boolean_Action_1_String_0;

		// Token: 0x04008696 RID: 34454
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04008697 RID: 34455
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04008698 RID: 34456
		private static readonly IntPtr NativeMethodInfoPtr_DoneButtonPressed_Private_Void_0;

		// Token: 0x04008699 RID: 34457
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Private_Void_String_0;

		// Token: 0x0400869A RID: 34458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

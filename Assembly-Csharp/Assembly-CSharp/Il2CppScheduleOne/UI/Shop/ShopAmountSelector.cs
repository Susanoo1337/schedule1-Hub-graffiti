using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200083B RID: 2107
	public class ShopAmountSelector : MonoBehaviour
	{
		// Token: 0x0600CCCB RID: 52427 RVA: 0x0033863C File Offset: 0x0033683C
		// Note: this type is marked as 'beforefieldinit'.
		static ShopAmountSelector()
		{
			Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopAmountSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr);
			ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "<SelectedAmount>k__BackingField");
			ShopAmountSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "Container");
			ShopAmountSelector.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "InputField");
			ShopAmountSelector.NativeFieldInfoPtr_onSubmitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, "onSubmitted");
			ShopAmountSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100689679);
			ShopAmountSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100689680);
			ShopAmountSelector.NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100689681);
			ShopAmountSelector.NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100689682);
			ShopAmountSelector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100689683);
			ShopAmountSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100689684);
			ShopAmountSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100689685);
			ShopAmountSelector.NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100689686);
			ShopAmountSelector.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100689687);
			ShopAmountSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr, 100689688);
		}

		// Token: 0x17003E37 RID: 15927
		// (get) Token: 0x0600CCCC RID: 52428 RVA: 0x00338798 File Offset: 0x00336998
		// (set) Token: 0x0600CCCD RID: 52429 RVA: 0x003387D4 File Offset: 0x003369D4
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003E38 RID: 15928
		// (get) Token: 0x0600CCCE RID: 52430 RVA: 0x00338814 File Offset: 0x00336A14
		// (set) Token: 0x0600CCCF RID: 52431 RVA: 0x00338850 File Offset: 0x00336A50
		public unsafe int SelectedAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29041, RefRangeEnd = 29043, XrefRangeStart = 29041, XrefRangeEnd = 29043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600CCD0 RID: 52432 RVA: 0x00338890 File Offset: 0x00336A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335576, XrefRangeEnd = 335595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCD1 RID: 52433 RVA: 0x003388C4 File Offset: 0x00336AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335595, XrefRangeEnd = 335601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCD2 RID: 52434 RVA: 0x003388F8 File Offset: 0x00336AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335601, XrefRangeEnd = 335603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCD3 RID: 52435 RVA: 0x0033892C File Offset: 0x00336B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335603, XrefRangeEnd = 335615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCD4 RID: 52436 RVA: 0x00338970 File Offset: 0x00336B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335615, XrefRangeEnd = 335619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCD5 RID: 52437 RVA: 0x003389B4 File Offset: 0x00336BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335619, XrefRangeEnd = 335620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopAmountSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopAmountSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopAmountSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CCD6 RID: 52438 RVA: 0x0006130E File Offset: 0x0005F50E
		public ShopAmountSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003E32 RID: 15922
		// (get) Token: 0x0600CCD7 RID: 52439 RVA: 0x003389F0 File Offset: 0x00336BF0
		// (set) Token: 0x0600CCD8 RID: 52440 RVA: 0x00061317 File Offset: 0x0005F517
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003E33 RID: 15923
		// (get) Token: 0x0600CCD9 RID: 52441 RVA: 0x00338A18 File Offset: 0x00336C18
		// (set) Token: 0x0600CCDA RID: 52442 RVA: 0x00061332 File Offset: 0x0005F532
		public unsafe int _SelectedAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr__SelectedAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x0600CCDB RID: 52443 RVA: 0x00338A40 File Offset: 0x00336C40
		// (set) Token: 0x0600CCDC RID: 52444 RVA: 0x0006134D File Offset: 0x0005F54D
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E35 RID: 15925
		// (get) Token: 0x0600CCDD RID: 52445 RVA: 0x00338A70 File Offset: 0x00336C70
		// (set) Token: 0x0600CCDE RID: 52446 RVA: 0x0006136C File Offset: 0x0005F56C
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E36 RID: 15926
		// (get) Token: 0x0600CCDF RID: 52447 RVA: 0x00338AA0 File Offset: 0x00336CA0
		// (set) Token: 0x0600CCE0 RID: 52448 RVA: 0x0006138B File Offset: 0x0005F58B
		public unsafe UnityEvent<int> onSubmitted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_onSubmitted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopAmountSelector.NativeFieldInfoPtr_onSubmitted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008B7B RID: 35707
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04008B7C RID: 35708
		private static readonly IntPtr NativeFieldInfoPtr__SelectedAmount_k__BackingField;

		// Token: 0x04008B7D RID: 35709
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04008B7E RID: 35710
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04008B7F RID: 35711
		private static readonly IntPtr NativeFieldInfoPtr_onSubmitted;

		// Token: 0x04008B80 RID: 35712
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008B81 RID: 35713
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04008B82 RID: 35714
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedAmount_Public_get_Int32_0;

		// Token: 0x04008B83 RID: 35715
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedAmount_Private_set_Void_Int32_0;

		// Token: 0x04008B84 RID: 35716
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04008B85 RID: 35717
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04008B86 RID: 35718
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04008B87 RID: 35719
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmitted_Private_Void_String_0;

		// Token: 0x04008B88 RID: 35720
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Private_Void_String_0;

		// Token: 0x04008B89 RID: 35721
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007DA RID: 2010
	public class StringFieldUI : MonoBehaviour
	{
		// Token: 0x0600C458 RID: 50264 RVA: 0x0031DBF0 File Offset: 0x0031BDF0
		// Note: this type is marked as 'beforefieldinit'.
		static StringFieldUI()
		{
			Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "StringFieldUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr);
			StringFieldUI.NativeFieldInfoPtr__Fields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr, "<Fields>k__BackingField");
			StringFieldUI.NativeFieldInfoPtr_FieldLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr, "FieldLabel");
			StringFieldUI.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr, "InputField");
			StringFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_StringField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr, 100688759);
			StringFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StringField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr, 100688760);
			StringFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_StringField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr, 100688761);
			StringFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr, 100688762);
			StringFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr, 100688763);
			StringFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr, 100688764);
			StringFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr, 100688765);
		}

		// Token: 0x17003B99 RID: 15257
		// (get) Token: 0x0600C459 RID: 50265 RVA: 0x0031DCE8 File Offset: 0x0031BEE8
		// (set) Token: 0x0600C45A RID: 50266 RVA: 0x0031DD28 File Offset: 0x0031BF28
		public unsafe List<StringField> Fields
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFieldUI.NativeMethodInfoPtr_get_Fields_Public_get_List_1_StringField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StringField>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFieldUI.NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StringField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C45B RID: 50267 RVA: 0x0031DD6C File Offset: 0x0031BF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325009, XrefRangeEnd = 325054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(List<StringField> field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFieldUI.NativeMethodInfoPtr_Bind_Public_Void_List_1_StringField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C45C RID: 50268 RVA: 0x0031DDB0 File Offset: 0x0031BFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325054, XrefRangeEnd = 325067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFieldUI.NativeMethodInfoPtr_Refresh_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C45D RID: 50269 RVA: 0x0031DDF4 File Offset: 0x0031BFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325067, XrefRangeEnd = 325075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreFieldsUniform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFieldUI.NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C45E RID: 50270 RVA: 0x0031DE30 File Offset: 0x0031C030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325075, XrefRangeEnd = 325081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValueChanged(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFieldUI.NativeMethodInfoPtr_ValueChanged_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C45F RID: 50271 RVA: 0x0031DE74 File Offset: 0x0031C074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325081, XrefRangeEnd = 325089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringFieldUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringFieldUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFieldUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C460 RID: 50272 RVA: 0x0005C971 File Offset: 0x0005AB71
		public StringFieldUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B96 RID: 15254
		// (get) Token: 0x0600C461 RID: 50273 RVA: 0x0031DEB0 File Offset: 0x0031C0B0
		// (set) Token: 0x0600C462 RID: 50274 RVA: 0x0005C97A File Offset: 0x0005AB7A
		public unsafe List<StringField> _Fields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringFieldUI.NativeFieldInfoPtr__Fields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StringField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringFieldUI.NativeFieldInfoPtr__Fields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B97 RID: 15255
		// (get) Token: 0x0600C463 RID: 50275 RVA: 0x0031DEE0 File Offset: 0x0031C0E0
		// (set) Token: 0x0600C464 RID: 50276 RVA: 0x0005C999 File Offset: 0x0005AB99
		public unsafe TextMeshProUGUI FieldLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringFieldUI.NativeFieldInfoPtr_FieldLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringFieldUI.NativeFieldInfoPtr_FieldLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B98 RID: 15256
		// (get) Token: 0x0600C465 RID: 50277 RVA: 0x0031DF10 File Offset: 0x0031C110
		// (set) Token: 0x0600C466 RID: 50278 RVA: 0x0005C9B8 File Offset: 0x0005ABB8
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringFieldUI.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringFieldUI.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008609 RID: 34313
		private static readonly IntPtr NativeFieldInfoPtr__Fields_k__BackingField;

		// Token: 0x0400860A RID: 34314
		private static readonly IntPtr NativeFieldInfoPtr_FieldLabel;

		// Token: 0x0400860B RID: 34315
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x0400860C RID: 34316
		private static readonly IntPtr NativeMethodInfoPtr_get_Fields_Public_get_List_1_StringField_0;

		// Token: 0x0400860D RID: 34317
		private static readonly IntPtr NativeMethodInfoPtr_set_Fields_Protected_set_Void_List_1_StringField_0;

		// Token: 0x0400860E RID: 34318
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Void_List_1_StringField_0;

		// Token: 0x0400860F RID: 34319
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_String_0;

		// Token: 0x04008610 RID: 34320
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldsUniform_Private_Boolean_0;

		// Token: 0x04008611 RID: 34321
		private static readonly IntPtr NativeMethodInfoPtr_ValueChanged_Public_Void_String_0;

		// Token: 0x04008612 RID: 34322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

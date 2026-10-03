using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002EC RID: 748
	public class StringField : ConfigField
	{
		// Token: 0x06003B35 RID: 15157 RVA: 0x001425DC File Offset: 0x001407DC
		// Note: this type is marked as 'beforefieldinit'.
		static StringField()
		{
			Il2CppClassPointerStore<StringField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "StringField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringField>.NativeClassPtr);
			StringField.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringField>.NativeClassPtr, "<Value>k__BackingField");
			StringField.NativeFieldInfoPtr__CharacterLimit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringField>.NativeClassPtr, "<CharacterLimit>k__BackingField");
			StringField.NativeFieldInfoPtr__defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringField>.NativeClassPtr, "_defaultValue");
			StringField.NativeFieldInfoPtr__canBeNullOrEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringField>.NativeClassPtr, "_canBeNullOrEmpty");
			StringField.NativeFieldInfoPtr_onItemChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringField>.NativeClassPtr, "onItemChanged");
			StringField.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringField>.NativeClassPtr, 100670871);
			StringField.NativeMethodInfoPtr_set_Value_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringField>.NativeClassPtr, 100670872);
			StringField.NativeMethodInfoPtr_get_CharacterLimit_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringField>.NativeClassPtr, 100670873);
			StringField.NativeMethodInfoPtr_set_CharacterLimit_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringField>.NativeClassPtr, 100670874);
			StringField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringField>.NativeClassPtr, 100670875);
			StringField.NativeMethodInfoPtr_SetValue_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringField>.NativeClassPtr, 100670876);
			StringField.NativeMethodInfoPtr_Configure_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringField>.NativeClassPtr, 100670877);
			StringField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringField>.NativeClassPtr, 100670878);
			StringField.NativeMethodInfoPtr_GetData_Public_StringFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringField>.NativeClassPtr, 100670879);
			StringField.NativeMethodInfoPtr_Load_Public_Void_StringFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringField>.NativeClassPtr, 100670880);
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06003B36 RID: 15158 RVA: 0x00142738 File Offset: 0x00140938
		// (set) Token: 0x06003B37 RID: 15159 RVA: 0x00142770 File Offset: 0x00140970
		public unsafe string Value
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringField.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringField.NativeMethodInfoPtr_set_Value_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06003B38 RID: 15160 RVA: 0x001427B4 File Offset: 0x001409B4
		// (set) Token: 0x06003B39 RID: 15161 RVA: 0x001427F0 File Offset: 0x001409F0
		public unsafe int CharacterLimit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringField.NativeMethodInfoPtr_get_CharacterLimit_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29057, RefRangeEnd = 29058, XrefRangeStart = 29057, XrefRangeEnd = 29058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringField.NativeMethodInfoPtr_set_CharacterLimit_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x00142830 File Offset: 0x00140A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149914, RefRangeEnd = 149915, XrefRangeStart = 149899, XrefRangeEnd = 149914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringField(EntityConfiguration parentConfig, string defaultValue) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x00142890 File Offset: 0x00140A90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 149921, RefRangeEnd = 149924, XrefRangeStart = 149915, XrefRangeEnd = 149921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(string value, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringField.NativeMethodInfoPtr_SetValue_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x001428E0 File Offset: 0x00140AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149924, RefRangeEnd = 149925, XrefRangeStart = 149924, XrefRangeEnd = 149924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Configure(int characterLimit, bool canBeNullOrEmpty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref characterLimit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canBeNullOrEmpty;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringField.NativeMethodInfoPtr_Configure_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x0014292C File Offset: 0x00140B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149925, XrefRangeEnd = 149926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x00142974 File Offset: 0x00140B74
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 149930, RefRangeEnd = 149940, XrefRangeStart = 149926, XrefRangeEnd = 149930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringField.NativeMethodInfoPtr_GetData_Public_StringFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringFieldData>(intPtr3) : null;
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x001429B4 File Offset: 0x00140BB4
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 149946, RefRangeEnd = 149965, XrefRangeStart = 149940, XrefRangeEnd = 149946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(StringFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringField.NativeMethodInfoPtr_Load_Public_Void_StringFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x0001DA2A File Offset: 0x0001BC2A
		public StringField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06003B41 RID: 15169 RVA: 0x001429F8 File Offset: 0x00140BF8
		// (set) Token: 0x06003B42 RID: 15170 RVA: 0x0001DA33 File Offset: 0x0001BC33
		public unsafe string _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringField.NativeFieldInfoPtr__Value_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringField.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06003B43 RID: 15171 RVA: 0x00142A20 File Offset: 0x00140C20
		// (set) Token: 0x06003B44 RID: 15172 RVA: 0x0001DA52 File Offset: 0x0001BC52
		public unsafe int _CharacterLimit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringField.NativeFieldInfoPtr__CharacterLimit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringField.NativeFieldInfoPtr__CharacterLimit_k__BackingField)) = value;
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06003B45 RID: 15173 RVA: 0x00142A48 File Offset: 0x00140C48
		// (set) Token: 0x06003B46 RID: 15174 RVA: 0x0001DA6D File Offset: 0x0001BC6D
		public unsafe string _defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringField.NativeFieldInfoPtr__defaultValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringField.NativeFieldInfoPtr__defaultValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06003B47 RID: 15175 RVA: 0x00142A70 File Offset: 0x00140C70
		// (set) Token: 0x06003B48 RID: 15176 RVA: 0x0001DA8C File Offset: 0x0001BC8C
		public unsafe bool _canBeNullOrEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringField.NativeFieldInfoPtr__canBeNullOrEmpty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringField.NativeFieldInfoPtr__canBeNullOrEmpty)) = value;
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06003B49 RID: 15177 RVA: 0x00142A98 File Offset: 0x00140C98
		// (set) Token: 0x06003B4A RID: 15178 RVA: 0x0001DAA7 File Offset: 0x0001BCA7
		public unsafe UnityEvent<string> onItemChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringField.NativeFieldInfoPtr_onItemChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringField.NativeFieldInfoPtr_onItemChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040027EB RID: 10219
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040027EC RID: 10220
		private static readonly IntPtr NativeFieldInfoPtr__CharacterLimit_k__BackingField;

		// Token: 0x040027ED RID: 10221
		private static readonly IntPtr NativeFieldInfoPtr__defaultValue;

		// Token: 0x040027EE RID: 10222
		private static readonly IntPtr NativeFieldInfoPtr__canBeNullOrEmpty;

		// Token: 0x040027EF RID: 10223
		private static readonly IntPtr NativeFieldInfoPtr_onItemChanged;

		// Token: 0x040027F0 RID: 10224
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x040027F1 RID: 10225
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Protected_set_Void_String_0;

		// Token: 0x040027F2 RID: 10226
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterLimit_Public_get_Int32_0;

		// Token: 0x040027F3 RID: 10227
		private static readonly IntPtr NativeMethodInfoPtr_set_CharacterLimit_Protected_set_Void_Int32_0;

		// Token: 0x040027F4 RID: 10228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_String_0;

		// Token: 0x040027F5 RID: 10229
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_String_Boolean_0;

		// Token: 0x040027F6 RID: 10230
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Void_Int32_Boolean_0;

		// Token: 0x040027F7 RID: 10231
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040027F8 RID: 10232
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_StringFieldData_0;

		// Token: 0x040027F9 RID: 10233
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_StringFieldData_0;
	}
}

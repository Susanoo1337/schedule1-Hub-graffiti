using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppSystem;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x0200081D RID: 2077
	public class CharacterCreatorField<T> : BaseCharacterCreatorField
	{
		// Token: 0x0600C9F9 RID: 51705 RVA: 0x0032F180 File Offset: 0x0032D380
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorField()
		{
			Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorField`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr);
			CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, "<value>k__BackingField");
			CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, "selectedClothingDefinition");
			CharacterCreatorField<T>.NativeMethodInfoPtr_get_value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100689355);
			CharacterCreatorField<T>.NativeMethodInfoPtr_set_value_Protected_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100689356);
			CharacterCreatorField<T>.NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100689357);
			CharacterCreatorField<T>.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100689358);
			CharacterCreatorField<T>.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100689359);
			CharacterCreatorField<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr, 100689360);
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x0600C9FA RID: 51706 RVA: 0x0032F28C File Offset: 0x0032D48C
		// (set) Token: 0x0600C9FB RID: 51707 RVA: 0x0032F2C8 File Offset: 0x0032D4C8
		public unsafe T value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr_get_value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr3 != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref value;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr_set_value_Protected_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C9FC RID: 51708 RVA: 0x0032F358 File Offset: 0x0032D558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332017, XrefRangeEnd = 332022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T ReadValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600C9FD RID: 51709 RVA: 0x0032F39C File Offset: 0x0032D59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332022, XrefRangeEnd = 332032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteValue(bool applyValue = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref applyValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9FE RID: 51710 RVA: 0x0032F3E8 File Offset: 0x0032D5E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332033, RefRangeEnd = 332034, XrefRangeStart = 332032, XrefRangeEnd = 332033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorField<T>.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C9FF RID: 51711 RVA: 0x0032F424 File Offset: 0x0032D624
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorField<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorField<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA00 RID: 51712 RVA: 0x0005FBD5 File Offset: 0x0005DDD5
		public CharacterCreatorField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x0600CA01 RID: 51713 RVA: 0x0032F460 File Offset: 0x0032D660
		// (set) Token: 0x0600CA02 RID: 51714 RVA: 0x0032F488 File Offset: 0x0032D688
		public unsafe T _value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr__value_k__BackingField);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x0600CA03 RID: 51715 RVA: 0x0032F530 File Offset: 0x0032D730
		// (set) Token: 0x0600CA04 RID: 51716 RVA: 0x0005FBDE File Offset: 0x0005DDDE
		public unsafe ClothingDefinition selectedClothingDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClothingDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorField<T>.NativeFieldInfoPtr_selectedClothingDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400898F RID: 35215
		private static readonly IntPtr NativeFieldInfoPtr__value_k__BackingField;

		// Token: 0x04008990 RID: 35216
		private static readonly IntPtr NativeFieldInfoPtr_selectedClothingDefinition;

		// Token: 0x04008991 RID: 35217
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_T_0;

		// Token: 0x04008992 RID: 35218
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Protected_set_Void_T_0;

		// Token: 0x04008993 RID: 35219
		private static readonly IntPtr NativeMethodInfoPtr_ReadValue_Public_Virtual_New_T_0;

		// Token: 0x04008994 RID: 35220
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_Void_Boolean_0;

		// Token: 0x04008995 RID: 35221
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04008996 RID: 35222
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

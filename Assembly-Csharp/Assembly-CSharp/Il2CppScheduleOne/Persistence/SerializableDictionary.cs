using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001B8 RID: 440
	[Serializable]
	public class SerializableDictionary<TKey, TValue> : Object
	{
		// Token: 0x06002BF1 RID: 11249 RVA: 0x0010C5DC File Offset: 0x0010A7DC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableDictionary()
		{
			Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SerializableDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr);
			SerializableDictionary<TKey, TValue>.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, "keys");
			SerializableDictionary<TKey, TValue>.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, "values");
			SerializableDictionary<TKey, TValue>.NativeFieldInfoPtr_dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, "dictionary");
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668970);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668971);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668972);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668973);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668974);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668975);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668976);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668977);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668978);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668979);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668980);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668981);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668982);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668983);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668984);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668985);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668986);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668987);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668988);
			SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr, 100668989);
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x0010C828 File Offset: 0x0010AA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128120, XrefRangeEnd = 128130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x0010C85C File Offset: 0x0010AA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128130, XrefRangeEnd = 128140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x0010C890 File Offset: 0x0010AA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128140, XrefRangeEnd = 128142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(TKey key, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			TKey ptr4;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				if (!(tkey is string))
				{
					ref TKey ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
				}
			}
			else
			{
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			TValue ptr7;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				if (!(tvalue is string))
				{
					ref TValue ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase);
					if (ref ptr6 != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(tvalue as string);
				}
			}
			else
			{
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x0010C97C File Offset: 0x0010AB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128142, XrefRangeEnd = 128146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsKey(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			TKey ptr4;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				if (!(tkey is string))
				{
					ref TKey ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
				}
			}
			else
			{
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x0010CA14 File Offset: 0x0010AC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128146, XrefRangeEnd = 128150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(TKey key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			TKey ptr4;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				if (!(tkey is string))
				{
					ref TKey ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
				}
			}
			else
			{
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x0010CAAC File Offset: 0x0010ACAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128150, XrefRangeEnd = 128154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetValue(TKey key, out TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			TKey ptr4;
			if (!typeof(TKey).IsValueType)
			{
				TKey tkey = key;
				if (!(tkey is string))
				{
					ref TKey ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase);
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
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
				}
			}
			else
			{
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TValue).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr5 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TValue).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x17000E68 RID: 3688
		public unsafe virtual TValue this[TKey key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128154, XrefRangeEnd = 128157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				TKey ptr4;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					if (!(tkey is string))
					{
						ref TKey ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase);
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
					}
				}
				else
				{
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128157, XrefRangeEnd = 128159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				TKey ptr4;
				if (!typeof(TKey).IsValueType)
				{
					TKey tkey = key;
					if (!(tkey is string))
					{
						ref TKey ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(tkey as Il2CppObjectBase);
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(tkey as string);
					}
				}
				else
				{
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				TValue ptr7;
				if (!typeof(TValue).IsValueType)
				{
					TValue tvalue = value;
					if (!(tvalue is string))
					{
						ref TValue ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase);
						if (ref ptr6 != null)
						{
							ptr7 = ref ptr6;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
							{
								ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
							}
						}
					}
					else
					{
						ptr7 = IL2CPP.ManagedStringToIl2Cpp(tvalue as string);
					}
				}
				else
				{
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x0010CD18 File Offset: 0x0010AF18
		public unsafe virtual ICollection<TKey> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128159, XrefRangeEnd = 128162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TKey>>(intPtr3) : null;
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06002BFB RID: 11259 RVA: 0x0010CD58 File Offset: 0x0010AF58
		public unsafe virtual ICollection<TValue> Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128162, XrefRangeEnd = 128168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<TValue>>(intPtr3) : null;
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06002BFC RID: 11260 RVA: 0x0010CD98 File Offset: 0x0010AF98
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128168, XrefRangeEnd = 128175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x0010CDD4 File Offset: 0x0010AFD4
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x0010CE10 File Offset: 0x0010B010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128175, XrefRangeEnd = 128177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x0010CE58 File Offset: 0x0010B058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128177, XrefRangeEnd = 128180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x0010CE8C File Offset: 0x0010B08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x0010CEE0 File Offset: 0x0010B0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128180, XrefRangeEnd = 128184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<KeyValuePair<TKey, TValue>> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x0010CF30 File Offset: 0x0010B130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(KeyValuePair<TKey, TValue> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x0010CF84 File Offset: 0x0010B184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128184, XrefRangeEnd = 128186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<TKey, TValue>>>(intPtr3) : null;
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x0010CFC4 File Offset: 0x0010B1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x0010D004 File Offset: 0x0010B204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128199, RefRangeEnd = 128200, XrefRangeStart = 128186, XrefRangeEnd = 128199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionary<TKey, TValue>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x00016C91 File Offset: 0x00014E91
		public SerializableDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x0010D040 File Offset: 0x0010B240
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x00016C9A File Offset: 0x00014E9A
		public unsafe List<TKey> keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<TKey, TValue>.NativeFieldInfoPtr_keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<TKey, TValue>.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x0010D070 File Offset: 0x0010B270
		// (set) Token: 0x06002C0A RID: 11274 RVA: 0x00016CB9 File Offset: 0x00014EB9
		public unsafe List<TValue> values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<TKey, TValue>.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<TKey, TValue>.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x0010D0A0 File Offset: 0x0010B2A0
		// (set) Token: 0x06002C0C RID: 11276 RVA: 0x00016CD8 File Offset: 0x00014ED8
		public unsafe Dictionary<TKey, TValue> dictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<TKey, TValue>.NativeFieldInfoPtr_dictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<TKey, TValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<TKey, TValue>.NativeFieldInfoPtr_dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeFieldInfoPtr_keys;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x04001E36 RID: 7734
		private static readonly IntPtr NativeFieldInfoPtr_dictionary;

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_TKey_TValue_0;

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_TKey_0;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_TKey_byref_TValue_0;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_TValue_TKey_0;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_TKey_TValue_0;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_TKey_0;

		// Token: 0x04001E40 RID: 7744
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_TValue_0;

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04001E44 RID: 7748
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001E45 RID: 7749
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04001E46 RID: 7750
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_TKey_TValue_Int32_0;

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_TKey_TValue_0;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

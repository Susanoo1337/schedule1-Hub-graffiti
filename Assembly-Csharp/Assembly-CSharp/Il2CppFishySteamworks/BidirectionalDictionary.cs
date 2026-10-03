using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks
{
	// Token: 0x02000090 RID: 144
	public class BidirectionalDictionary<T1, T2> : Object
	{
		// Token: 0x06000C2C RID: 3116 RVA: 0x000A2EA0 File Offset: 0x000A10A0
		// Note: this type is marked as 'beforefieldinit'.
		static BidirectionalDictionary()
		{
			Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "BidirectionalDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr);
			BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t1ToT2Dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, "t1ToT2Dict");
			BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t2ToT1Dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, "t2ToT1Dict");
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_FirstTypes_Public_get_IEnumerable_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664822);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_SecondTypes_Public_get_IEnumerable_1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664823);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664824);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664825);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_First_Public_get_Dictionary_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664826);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Second_Public_get_Dictionary_2_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664827);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664828);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664829);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664830);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664831);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T1_byref_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664832);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T2_byref_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664833);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664834);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664835);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664836);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664837);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664838);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664839);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664840);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664841);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100664842);
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x000A30EC File Offset: 0x000A12EC
		public unsafe IEnumerable<T1> FirstTypes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78219, RefRangeEnd = 78220, XrefRangeStart = 78215, XrefRangeEnd = 78219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_FirstTypes_Public_get_IEnumerable_1_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T1>>(intPtr3) : null;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x000A312C File Offset: 0x000A132C
		public unsafe IEnumerable<T2> SecondTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78220, XrefRangeEnd = 78226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_SecondTypes_Public_get_IEnumerable_1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T2>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x000A316C File Offset: 0x000A136C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78226, XrefRangeEnd = 78228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x000A31AC File Offset: 0x000A13AC
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78228, XrefRangeEnd = 78230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x000A31E8 File Offset: 0x000A13E8
		public unsafe Dictionary<T1, T2> First
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_First_Public_get_Dictionary_2_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T1, T2>>(intPtr3) : null;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x000A3228 File Offset: 0x000A1428
		public unsafe Dictionary<T2, T1> Second
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Second_Public_get_Dictionary_2_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T2, T1>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000A3268 File Offset: 0x000A1468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78250, RefRangeEnd = 78251, XrefRangeStart = 78230, XrefRangeEnd = 78250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T1 key, T2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T2 ptr7;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = value;
				if (!(t2 is string))
				{
					ref T2 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x000A3354 File Offset: 0x000A1554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78251, XrefRangeEnd = 78259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T2 key, T1 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T1 ptr7;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = value;
				if (!(t2 is string))
				{
					ref T1 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000A3440 File Offset: 0x000A1640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78259, XrefRangeEnd = 78261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T2 Get(T1 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T2>(intPtr, false, true);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000A34D8 File Offset: 0x000A16D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78261, XrefRangeEnd = 78267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T1 Get(T2 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T1>(intPtr, false, true);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000A3570 File Offset: 0x000A1770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78267, XrefRangeEnd = 78273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(T1 key, out T2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T1_byref_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T2).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000A3658 File Offset: 0x000A1858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78275, RefRangeEnd = 78277, XrefRangeStart = 78273, XrefRangeEnd = 78275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(T2 key, out T1 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T2_byref_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T1).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x000A3740 File Offset: 0x000A1940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78277, XrefRangeEnd = 78279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(T1 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x000A37D8 File Offset: 0x000A19D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78279, XrefRangeEnd = 78283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(T2 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000A3870 File Offset: 0x000A1A70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78287, RefRangeEnd = 78288, XrefRangeStart = 78283, XrefRangeEnd = 78287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(T1 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000A3900 File Offset: 0x000A1B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 78292, RefRangeEnd = 78293, XrefRangeStart = 78288, XrefRangeEnd = 78292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(T2 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000436 RID: 1078
		public unsafe T1 this[T2 key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T2 ptr4;
				if (!typeof(T2).IsValueType)
				{
					T2 t = key;
					if (!(t is string))
					{
						ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T1>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78293, XrefRangeEnd = 78309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T2 ptr4;
				if (!typeof(T2).IsValueType)
				{
					T2 t = key;
					if (!(t is string))
					{
						ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				T1 ptr7;
				if (!typeof(T1).IsValueType)
				{
					T1 t2 = value;
					if (!(t2 is string))
					{
						ref T1 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
						ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000437 RID: 1079
		public unsafe T2 this[T1 key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T1 ptr4;
				if (!typeof(T1).IsValueType)
				{
					T1 t = key;
					if (!(t is string))
					{
						ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, false, true);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78329, RefRangeEnd = 78330, XrefRangeStart = 78309, XrefRangeEnd = 78329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T1 ptr4;
				if (!typeof(T1).IsValueType)
				{
					T1 t = key;
					if (!(t is string))
					{
						ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				T2 ptr7;
				if (!typeof(T2).IsValueType)
				{
					T2 t2 = value;
					if (!(t2 is string))
					{
						ref T2 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
						ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x000A3C98 File Offset: 0x000A1E98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 78348, RefRangeEnd = 78350, XrefRangeStart = 78330, XrefRangeEnd = 78348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BidirectionalDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00007A72 File Offset: 0x00005C72
		public BidirectionalDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x000A3CD4 File Offset: 0x000A1ED4
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x00007A7B File Offset: 0x00005C7B
		public unsafe Dictionary<T1, T2> t1ToT2Dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t1ToT2Dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T1, T2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t1ToT2Dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x000A3D04 File Offset: 0x000A1F04
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x00007A9A File Offset: 0x00005C9A
		public unsafe Dictionary<T2, T1> t2ToT1Dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t2ToT1Dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T2, T1>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t2ToT1Dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeFieldInfoPtr_t1ToT2Dict;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeFieldInfoPtr_t2ToT1Dict;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstTypes_Public_get_IEnumerable_1_T1_0;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondTypes_Public_get_IEnumerable_1_T2_0;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeMethodInfoPtr_get_First_Public_get_Dictionary_2_T1_T2_0;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_get_Second_Public_get_Dictionary_2_T2_T1_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T1_T2_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T2_T1_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T2_T1_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T1_T2_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_T1_byref_T2_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_T2_byref_T1_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T1_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T2_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_T1_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_T2_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T1_T2_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_T2_T1_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T2_T1_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_T1_T2_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

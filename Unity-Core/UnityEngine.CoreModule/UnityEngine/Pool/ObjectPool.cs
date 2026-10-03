using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Pool
{
	// Token: 0x020001C9 RID: 457
	public class ObjectPool<T> : Object where T : class
	{
		// Token: 0x060020B5 RID: 8373 RVA: 0x00085104 File Offset: 0x00083304
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectPool()
		{
			Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "ObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr);
			ObjectPool<T>.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_List");
			ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_CreateFunc");
			ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_ActionOnGet");
			ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_ActionOnRelease");
			ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_ActionOnDestroy");
			ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_MaxSize");
			ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_CollectionCheck");
			ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "<CountAll>k__BackingField");
			ObjectPool<T>.NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100666855);
			ObjectPool<T>.NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100666856);
			ObjectPool<T>.NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100666857);
			ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100666858);
			ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100666859);
			ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_PooledObject_1_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100666860);
			ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100666861);
			ObjectPool<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100666862);
			ObjectPool<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100666863);
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x000852C4 File Offset: 0x000834C4
		// (set) Token: 0x060020B7 RID: 8375 RVA: 0x00085300 File Offset: 0x00083500
		public unsafe int CountAll
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 44532, RefRangeEnd = 44533, XrefRangeStart = 44532, XrefRangeEnd = 44533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x00085340 File Offset: 0x00083540
		public unsafe virtual int CountInactive
		{
			[CallerCount(57)]
			[CachedScanResults(RefRangeStart = 32354, RefRangeEnd = 32411, XrefRangeStart = 32354, XrefRangeEnd = 32411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x0008537C File Offset: 0x0008357C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1286644, RefRangeEnd = 1286646, XrefRangeStart = 1286620, XrefRangeEnd = 1286644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(createFunc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionOnGet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionOnRelease);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionOnDestroy);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collectionCheck;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultCapacity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00085428 File Offset: 0x00083628
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1286649, RefRangeEnd = 1286656, XrefRangeStart = 1286646, XrefRangeEnd = 1286649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x00085464 File Offset: 0x00083664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1286661, RefRangeEnd = 1286662, XrefRangeStart = 1286656, XrefRangeEnd = 1286661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual PooledObject<T> Get(out T v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref v;
			}
			ptr2 = intPtr2;
			IntPtr intPtr3;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_PooledObject_1_T_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr4 = intPtr;
				v = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}
			return new PooledObject<T>(pointer);
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x000854EC File Offset: 0x000836EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1286662, RefRangeEnd = 1286670, XrefRangeStart = 1286662, XrefRangeEnd = 1286662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Release(T element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = element;
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
				ptr4 = ref element;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x0008557C File Offset: 0x0008377C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1286677, RefRangeEnd = 1286679, XrefRangeStart = 1286670, XrefRangeEnd = 1286677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x000855B0 File Offset: 0x000837B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286679, XrefRangeEnd = 1286680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x0000F269 File Offset: 0x0000D469
		public ObjectPool(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x000855E4 File Offset: 0x000837E4
		// (set) Token: 0x060020C1 RID: 8385 RVA: 0x0000F272 File Offset: 0x0000D472
		public unsafe List<T> m_List
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_List);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x00085614 File Offset: 0x00083814
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x0000F291 File Offset: 0x0000D491
		public unsafe Func<T> m_CreateFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x00085644 File Offset: 0x00083844
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x0000F2B0 File Offset: 0x0000D4B0
		public unsafe Action<T> m_ActionOnGet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x00085674 File Offset: 0x00083874
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x0000F2CF File Offset: 0x0000D4CF
		public unsafe Action<T> m_ActionOnRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x000856A4 File Offset: 0x000838A4
		// (set) Token: 0x060020C9 RID: 8393 RVA: 0x0000F2EE File Offset: 0x0000D4EE
		public unsafe Action<T> m_ActionOnDestroy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x000856D4 File Offset: 0x000838D4
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x0000F30D File Offset: 0x0000D50D
		public unsafe int m_MaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize)) = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x000856FC File Offset: 0x000838FC
		// (set) Token: 0x060020CD RID: 8397 RVA: 0x0000F328 File Offset: 0x0000D528
		public unsafe bool m_CollectionCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck)) = value;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x00085724 File Offset: 0x00083924
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x0000F343 File Offset: 0x0000D543
		public unsafe int _CountAll_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField)) = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x0008574C File Offset: 0x0008394C
		public int CountActive
		{
			get
			{
				return this.CountAll - this.CountInactive;
			}
		}

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeFieldInfoPtr_m_List;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateFunc;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionOnGet;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionOnRelease;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionOnDestroy;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSize;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectionCheck;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeFieldInfoPtr__CountAll_k__BackingField;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_PooledObject_1_T_byref_T_0;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}

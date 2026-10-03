using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections;

namespace Il2Cpp
{
	// Token: 0x0200001D RID: 29
	public class CircularQueue<T> : Object where T : new()
	{
		// Token: 0x0600016A RID: 362 RVA: 0x0007FD10 File Offset: 0x0007DF10
		// Note: this type is marked as 'beforefieldinit'.
		static CircularQueue()
		{
			Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CircularQueue`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr);
			CircularQueue<T>.NativeFieldInfoPtr_q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, "q");
			CircularQueue<T>.NativeFieldInfoPtr_idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, "idx");
			CircularQueue<T>.NativeFieldInfoPtr_cap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, "cap");
			CircularQueue<T>.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, "length");
			CircularQueue<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, 100663467);
			CircularQueue<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, 100663468);
			CircularQueue<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, 100663469);
			CircularQueue<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, 100663470);
			CircularQueue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, 100663471);
			CircularQueue<T>.NativeMethodInfoPtr_Dequeue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, 100663472);
			CircularQueue<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, 100663473);
			CircularQueue<T>.NativeMethodInfoPtr_modulo_Private_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr, 100663474);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0007FE6C File Offset: 0x0007E06C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66645, RefRangeEnd = 66646, XrefRangeStart = 66643, XrefRangeEnd = 66645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CircularQueue(int capacity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CircularQueue<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularQueue<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000067 RID: 103
		public unsafe T this[int i]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularQueue<T>.NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0007FEFC File Offset: 0x0007E0FC
		public unsafe int Capacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularQueue<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0007FF38 File Offset: 0x0007E138
		public unsafe int Count
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 29072, RefRangeEnd = 29101, XrefRangeStart = 29072, XrefRangeEnd = 29101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularQueue<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0007FF74 File Offset: 0x0007E174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66646, RefRangeEnd = 66647, XrefRangeStart = 66646, XrefRangeEnd = 66646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enqueue(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = item;
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
				ptr4 = ref item;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularQueue<T>.NativeMethodInfoPtr_Enqueue_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00080004 File Offset: 0x0007E204
		[CallerCount(0)]
		public unsafe void Dequeue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularQueue<T>.NativeMethodInfoPtr_Dequeue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00080038 File Offset: 0x0007E238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66647, XrefRangeEnd = 66649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularQueue<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0008006C File Offset: 0x0007E26C
		[CallerCount(0)]
		public unsafe int modulo(int i, int m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref i;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CircularQueue<T>.NativeMethodInfoPtr_modulo_Private_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002BE5 File Offset: 0x00000DE5
		public CircularQueue(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000800C4 File Offset: 0x0007E2C4
		// (set) Token: 0x06000175 RID: 373 RVA: 0x00002BEE File Offset: 0x00000DEE
		public NativeArray<T> q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularQueue<T>.NativeFieldInfoPtr_q);
				return new NativeArray<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularQueue<T>.NativeFieldInfoPtr_q), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<T>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000800F4 File Offset: 0x0007E2F4
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002C1C File Offset: 0x00000E1C
		public unsafe int idx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularQueue<T>.NativeFieldInfoPtr_idx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularQueue<T>.NativeFieldInfoPtr_idx)) = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0008011C File Offset: 0x0007E31C
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002C37 File Offset: 0x00000E37
		public unsafe int cap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularQueue<T>.NativeFieldInfoPtr_cap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularQueue<T>.NativeFieldInfoPtr_cap)) = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00080144 File Offset: 0x0007E344
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002C52 File Offset: 0x00000E52
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularQueue<T>.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CircularQueue<T>.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_q;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_idx;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_cap;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T_Int32_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_T_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_Dequeue_Public_Void_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_modulo_Private_Int32_Int32_Int32_0;
	}
}

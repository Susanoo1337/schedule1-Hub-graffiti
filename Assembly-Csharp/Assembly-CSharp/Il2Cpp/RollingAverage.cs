using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200001F RID: 31
	public class RollingAverage<T> : Object
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00080234 File Offset: 0x0007E434
		// Note: this type is marked as 'beforefieldinit'.
		static RollingAverage()
		{
			Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RollingAverage`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr);
			RollingAverage<T>.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, "buffer");
			RollingAverage<T>.NativeFieldInfoPtr_add = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, "add");
			RollingAverage<T>.NativeFieldInfoPtr_sub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, "sub");
			RollingAverage<T>.NativeFieldInfoPtr_div = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, "div");
			RollingAverage<T>.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, "head");
			RollingAverage<T>.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, "count");
			RollingAverage<T>.NativeFieldInfoPtr_sum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, "sum");
			RollingAverage<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_T_T_T_Func_3_T_T_T_Func_3_T_Single_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, 100663480);
			RollingAverage<T>.NativeMethodInfoPtr_Add_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, 100663481);
			RollingAverage<T>.NativeMethodInfoPtr_get_Average_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, 100663482);
			RollingAverage<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, 100663483);
			RollingAverage<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, 100663484);
			RollingAverage<T>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr, 100663485);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000803A4 File Offset: 0x0007E5A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66682, RefRangeEnd = 66683, XrefRangeStart = 66675, XrefRangeEnd = 66682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RollingAverage(int capacity, Func<T, T, T> add, Func<T, T, T> sub, Func<T, float, T> div) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RollingAverage<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capacity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(add);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sub);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(div);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollingAverage<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_T_T_T_Func_3_T_T_T_Func_3_T_Single_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00080424 File Offset: 0x0007E624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66684, RefRangeEnd = 66685, XrefRangeStart = 66683, XrefRangeEnd = 66684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollingAverage<T>.NativeMethodInfoPtr_Add_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000804B4 File Offset: 0x0007E6B4
		public unsafe T Average
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 66685, RefRangeEnd = 66687, XrefRangeStart = 66685, XrefRangeEnd = 66685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollingAverage<T>.NativeMethodInfoPtr_get_Average_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000804F0 File Offset: 0x0007E6F0
		public unsafe int Count
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 41326, RefRangeEnd = 41452, XrefRangeStart = 41326, XrefRangeEnd = 41452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollingAverage<T>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0008052C File Offset: 0x0007E72C
		public unsafe int Capacity
		{
			[CallerCount(57)]
			[CachedScanResults(RefRangeStart = 32354, RefRangeEnd = 32411, XrefRangeStart = 32354, XrefRangeEnd = 32411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollingAverage<T>.NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00080568 File Offset: 0x0007E768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66687, XrefRangeEnd = 66688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RollingAverage<T>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002C76 File Offset: 0x00000E76
		public RollingAverage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0008059C File Offset: 0x0007E79C
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002C7F File Offset: 0x00000E7F
		public unsafe Il2CppArrayBase<T> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_buffer);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000805C4 File Offset: 0x0007E7C4
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002C9E File Offset: 0x00000E9E
		public unsafe Func<T, T, T> add
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_add);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T, T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_add), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000805F4 File Offset: 0x0007E7F4
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00002CBD File Offset: 0x00000EBD
		public unsafe Func<T, T, T> sub
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_sub);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, T, T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_sub), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00080624 File Offset: 0x0007E824
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002CDC File Offset: 0x00000EDC
		public unsafe Func<T, float, T> div
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_div);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, float, T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_div), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00080654 File Offset: 0x0007E854
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002CFB File Offset: 0x00000EFB
		public unsafe int head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_head);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_head)) = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0008067C File Offset: 0x0007E87C
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002D16 File Offset: 0x00000F16
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000806A4 File Offset: 0x0007E8A4
		// (set) Token: 0x06000195 RID: 405 RVA: 0x000806CC File Offset: 0x0007E8CC
		public unsafe T sum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_sum);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RollingAverage<T>.NativeFieldInfoPtr_sum);
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

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr_add;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_sub;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_div;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr_sum;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_3_T_T_T_Func_3_T_T_T_Func_3_T_Single_T_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_get_Average_Public_get_T_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_get_Capacity_Public_get_Int32_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
	}
}

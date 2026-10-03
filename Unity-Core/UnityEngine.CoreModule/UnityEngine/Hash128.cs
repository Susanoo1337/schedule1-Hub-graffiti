using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x020000E5 RID: 229
	[Serializable]
	[StructLayout(2)]
	public struct Hash128
	{
		// Token: 0x060012AA RID: 4778 RVA: 0x00052FF8 File Offset: 0x000511F8
		// Note: this type is marked as 'beforefieldinit'.
		static Hash128()
		{
			Il2CppClassPointerStore<Hash128>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Hash128");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hash128>.NativeClassPtr);
			Hash128.NativeFieldInfoPtr_u64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, "u64_0");
			Hash128.NativeFieldInfoPtr_u64_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, "u64_1");
			Hash128.NativeFieldInfoPtr_kConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128>.NativeClassPtr, "kConst");
			Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665136);
			Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665137);
			Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665138);
			Hash128.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665139);
			Hash128.NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665140);
			Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665141);
			Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665142);
			Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665143);
			Hash128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665144);
			Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665145);
			Hash128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665146);
			Hash128.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665147);
			Hash128.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665148);
			Hash128.NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_String_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665149);
			Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_String_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128>.NativeClassPtr, 100665150);
			Hash128.ComputeFromStringDelegateField = IL2CPP.ResolveICall<Hash128.ComputeFromStringDelegate>("UnityEngine.Hash128::ComputeFromString");
			Hash128.ComputeFromPtrDelegateField = IL2CPP.ResolveICall<Hash128.ComputeFromPtrDelegate>("UnityEngine.Hash128::ComputeFromPtr");
			Hash128.ComputeFromArrayDelegateField = IL2CPP.ResolveICall<Hash128.ComputeFromArrayDelegate>("UnityEngine.Hash128::ComputeFromArray");
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x000531C0 File Offset: 0x000513C0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1241842, RefRangeEnd = 1241846, XrefRangeStart = 1241842, XrefRangeEnd = 1241842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref u32_0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u32_1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u32_2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u32_3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0005321C File Offset: 0x0005141C
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 436674, RefRangeEnd = 436719, XrefRangeStart = 436674, XrefRangeEnd = 436719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hash128(ulong u64_0, ulong u64_1)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref u64_0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u64_1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0005325C File Offset: 0x0005145C
		[CallerCount(0)]
		public unsafe int CompareTo(Hash128 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0005329C File Offset: 0x0005149C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1241848, RefRangeEnd = 1241851, XrefRangeStart = 1241846, XrefRangeEnd = 1241848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000532C8 File Offset: 0x000514C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241853, RefRangeEnd = 1241854, XrefRangeStart = 1241851, XrefRangeEnd = 1241853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hash128 Parse(string hashString)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(hashString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0005330C File Offset: 0x0005150C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241854, XrefRangeEnd = 1241856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Hash128ToStringImpl(Hash128 hash)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00053344 File Offset: 0x00051544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241856, XrefRangeEnd = 1241859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00053388 File Offset: 0x00051588
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 670977, RefRangeEnd = 670979, XrefRangeStart = 670977, XrefRangeEnd = 670979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Hash128 obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref obj;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x000533C8 File Offset: 0x000515C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241859, XrefRangeEnd = 1241861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000533F8 File Offset: 0x000515F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241861, XrefRangeEnd = 1241864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0005343C File Offset: 0x0005163C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 670977, RefRangeEnd = 670979, XrefRangeStart = 670977, XrefRangeEnd = 670979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Hash128 hash1, Hash128 hash2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hash1;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00053488 File Offset: 0x00051688
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1241864, RefRangeEnd = 1241867, XrefRangeStart = 1241864, XrefRangeEnd = 1241864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(Hash128 x, Hash128 y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000534D4 File Offset: 0x000516D4
		[CallerCount(0)]
		public unsafe static bool operator >(Hash128 x, Hash128 y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00053520 File Offset: 0x00051720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241867, XrefRangeEnd = 1241869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Parse_Injected(string hashString, out Hash128 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(hashString);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_String_byref_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00053564 File Offset: 0x00051764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241869, XrefRangeEnd = 1241871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Hash128ToStringImpl_Injected(ref Hash128 hash)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128.NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_String_byref_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x0000A521 File Offset: 0x00008721
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Hash128>.NativeClassPtr, ref this));
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x0005359C File Offset: 0x0005179C
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x0000A533 File Offset: 0x00008733
		public unsafe static ulong kConst
		{
			get
			{
				ulong result;
				IL2CPP.il2cpp_field_static_get_value(Hash128.NativeFieldInfoPtr_kConst, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hash128.NativeFieldInfoPtr_kConst, (void*)(&value));
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x0000A541 File Offset: 0x00008741
		public bool isValid
		{
			get
			{
				return this.u64_0 != 0UL || this.u64_1 > 0UL;
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0000A558 File Offset: 0x00008758
		public static void ComputeFromString(string data, ref Hash128 hash)
		{
			Hash128.ComputeFromStringDelegateField(IL2CPP.ManagedStringToIl2Cpp(data), ref hash);
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0000A56B File Offset: 0x0000876B
		public static void ComputeFromPtr(IntPtr data, int start, int count, int elemSize, ref Hash128 hash)
		{
			Hash128.ComputeFromPtrDelegateField(data, start, count, elemSize, ref hash);
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0000A57D File Offset: 0x0000877D
		public static void ComputeFromArray(Array data, int start, int count, int elemSize, ref Hash128 hash)
		{
			Hash128.ComputeFromArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr(data), start, count, elemSize, ref hash);
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x000535B8 File Offset: 0x000517B8
		public static Hash128 Compute(string data)
		{
			Hash128 result = default(Hash128);
			Hash128.ComputeFromString(data, ref result);
			return result;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x000535DC File Offset: 0x000517DC
		public static Hash128 Compute<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			Hash128 result = default(Hash128);
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref result);
			return result;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00053618 File Offset: 0x00051818
		public static Hash128 Compute<T>(Unity.Collections.NativeArray<T> data, int start, int count) where T : struct
		{
			bool flag = start < 0 || count < 0 || start + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128 result = default(Hash128);
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref result);
			return result;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00053684 File Offset: 0x00051884
		public static Hash128 Compute<T>(Il2CppArrayBase<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Compute must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			Hash128 result = default(Hash128);
			Hash128.ComputeFromArray(data, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref result);
			return result;
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x000536D8 File Offset: 0x000518D8
		public static Hash128 Compute<T>(Il2CppArrayBase<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Compute must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Length;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128 result = default(Hash128);
			Hash128.ComputeFromArray(data, start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref result);
			return result;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00053760 File Offset: 0x00051960
		public static Hash128 Compute<T>(List<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Compute", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			Hash128 result = default(Hash128);
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), 0, data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref result);
			return result;
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x000537C8 File Offset: 0x000519C8
		public static Hash128 Compute<T>(List<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Compute", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Count;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128 result = default(Hash128);
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref result);
			return result;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00053860 File Offset: 0x00051A60
		public unsafe static Hash128 Compute<T>(ref T val) where T : struct, ValueType
		{
			fixed (T* ptr = &val)
			{
				void* value = (void*)ptr;
				Hash128 result = default(Hash128);
				Hash128.ComputeFromPtr((IntPtr)value, 0, 1, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref result);
				return result;
			}
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00053898 File Offset: 0x00051A98
		public static Hash128 Compute(int val)
		{
			Hash128 result = default(Hash128);
			result.Append(val);
			return result;
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x000538BC File Offset: 0x00051ABC
		public static Hash128 Compute(float val)
		{
			Hash128 result = default(Hash128);
			result.Append(val);
			return result;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x000538E0 File Offset: 0x00051AE0
		public unsafe static Hash128 Compute(void* data, ulong size)
		{
			Hash128 result = default(Hash128);
			Hash128.ComputeFromPtr(new IntPtr(data), 0, (int)size, 1, ref result);
			return result;
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0000A594 File Offset: 0x00008794
		public void Append(string data)
		{
			Hash128.ComputeFromString(data, ref this);
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0000A59F File Offset: 0x0000879F
		public void Append<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00053910 File Offset: 0x00051B10
		public void Append<T>(Unity.Collections.NativeArray<T> data, int start, int count) where T : struct
		{
			bool flag = start < 0 || count < 0 || start + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128.ComputeFromPtr((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00053970 File Offset: 0x00051B70
		public void Append<T>(Il2CppArrayBase<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Append must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			Hash128.ComputeFromArray(data, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000539B8 File Offset: 0x00051BB8
		public void Append<T>(Il2CppArrayBase<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag)
			{
				throw new ArgumentException(String.Concat("Array passed to Append must be blittable.\n", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Length;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128.ComputeFromArray(data, start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00053A30 File Offset: 0x00051C30
		public void Append<T>(List<T> data) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Append", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), 0, data.Count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00053A88 File Offset: 0x00051C88
		public void Append<T>(List<T> data, int start, int count) where T : struct
		{
			bool flag = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to {1} must be blittable.\n{2}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), "Append", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag2 = start < 0 || count < 0 || start + count > data.Count;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad start/count arguments (start:{0} count:{1})", start, count));
			}
			Hash128.ComputeFromArray(NoAllocHelpers.ExtractArrayFromList(data), start, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00053B10 File Offset: 0x00051D10
		public unsafe void Append<T>(ref T val) where T : struct, ValueType
		{
			fixed (T* ptr = &val)
			{
				void* value = (void*)ptr;
				Hash128.ComputeFromPtr((IntPtr)value, 0, 1, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>(), ref this);
			}
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0000A5C1 File Offset: 0x000087C1
		public void Append(int val)
		{
			this.ShortHash4((uint)val);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0000A5CC File Offset: 0x000087CC
		public unsafe void Append(float val)
		{
			this.ShortHash4(*(uint*)(&val));
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x0000A5DA File Offset: 0x000087DA
		public unsafe void Append(void* data, ulong size)
		{
			Hash128.ComputeFromPtr(new IntPtr(data), 0, (int)size, 1, ref this);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x00053B3C File Offset: 0x00051D3C
		public static bool operator !=(Hash128 hash1, Hash128 hash2)
		{
			return !(hash1 == hash2);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00053B58 File Offset: 0x00051D58
		public void ShortHash4(uint data)
		{
			ulong num = this.u64_0;
			ulong num2 = this.u64_1;
			ulong num3 = 16045690984833335023UL;
			ulong num4 = 16045690984833335023UL;
			num4 += 288230376151711744UL;
			num3 += (ulong)data;
			Hash128.ShortEnd(ref num, ref num2, ref num3, ref num4);
			this.u64_0 = num;
			this.u64_1 = num2;
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00053BB8 File Offset: 0x00051DB8
		public static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
		{
			h3 ^= h2;
			Hash128.Rot64(ref h2, 15);
			h3 += h2;
			h0 ^= h3;
			Hash128.Rot64(ref h3, 52);
			h0 += h3;
			h1 ^= h0;
			Hash128.Rot64(ref h0, 26);
			h1 += h0;
			h2 ^= h1;
			Hash128.Rot64(ref h1, 51);
			h2 += h1;
			h3 ^= h2;
			Hash128.Rot64(ref h2, 28);
			h3 += h2;
			h0 ^= h3;
			Hash128.Rot64(ref h3, 9);
			h0 += h3;
			h1 ^= h0;
			Hash128.Rot64(ref h0, 47);
			h1 += h0;
			h2 ^= h1;
			Hash128.Rot64(ref h1, 54);
			h2 += h1;
			h3 ^= h2;
			Hash128.Rot64(ref h2, 32);
			h3 += h2;
			h0 ^= h3;
			Hash128.Rot64(ref h3, 25);
			h0 += h3;
			h1 ^= h0;
			Hash128.Rot64(ref h0, 63);
			h1 += h0;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x0000A5EE File Offset: 0x000087EE
		public static void Rot64(ref ulong x, int k)
		{
			x = (x << k | x >> 64 - k);
		}

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeFieldInfoPtr_u64_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeFieldInfoPtr_u64_1;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeFieldInfoPtr_kConst;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Hash128_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Static_Hash128_String_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr_Hash128ToStringImpl_Private_Static_String_Hash128_0;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Hash128_0;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Hash128_Hash128_0;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Hash128_Hash128_0;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Hash128_Hash128_0;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Injected_Private_Static_Void_String_byref_Hash128_0;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_Hash128ToStringImpl_Injected_Private_Static_String_byref_Hash128_0;

		// Token: 0x04000F2C RID: 3884
		[FieldOffset(0)]
		public ulong u64_0;

		// Token: 0x04000F2D RID: 3885
		[FieldOffset(8)]
		public ulong u64_1;

		// Token: 0x04000F2E RID: 3886
		private static readonly Hash128.ComputeFromStringDelegate ComputeFromStringDelegateField;

		// Token: 0x04000F2F RID: 3887
		private static readonly Hash128.ComputeFromPtrDelegate ComputeFromPtrDelegateField;

		// Token: 0x04000F30 RID: 3888
		private static readonly Hash128.ComputeFromArrayDelegate ComputeFromArrayDelegateField;

		// Token: 0x0200086C RID: 2156
		// (Invoke) Token: 0x0600396A RID: 14698
		private delegate void ComputeFromStringDelegate(IntPtr data, IntPtr hash);

		// Token: 0x0200086D RID: 2157
		// (Invoke) Token: 0x0600396C RID: 14700
		private delegate void ComputeFromPtrDelegate(IntPtr data, int start, int count, int elemSize, IntPtr hash);

		// Token: 0x0200086E RID: 2158
		// (Invoke) Token: 0x0600396E RID: 14702
		private delegate void ComputeFromArrayDelegate(IntPtr data, int start, int count, int elemSize, IntPtr hash);
	}
}

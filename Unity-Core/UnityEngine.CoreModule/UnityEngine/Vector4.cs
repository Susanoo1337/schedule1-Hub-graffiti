using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FF RID: 255
	[StructLayout(2)]
	public struct Vector4
	{
		// Token: 0x060015A1 RID: 5537 RVA: 0x0005FD5C File Offset: 0x0005DF5C
		// Note: this type is marked as 'beforefieldinit'.
		static Vector4()
		{
			Il2CppClassPointerStore<Vector4>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4>.NativeClassPtr);
			Vector4.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "kEpsilon");
			Vector4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "x");
			Vector4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "y");
			Vector4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "z");
			Vector4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "w");
			Vector4.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "zeroVector");
			Vector4.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "oneVector");
			Vector4.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "positiveInfinityVector");
			Vector4.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "negativeInfinityVector");
			Vector4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665579);
			Vector4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665580);
			Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665581);
			Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665582);
			Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665583);
			Vector4.NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665584);
			Vector4.NativeMethodInfoPtr_Scale_Public_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665585);
			Vector4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665586);
			Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665587);
			Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665588);
			Vector4.NativeMethodInfoPtr_Normalize_Public_Static_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665589);
			Vector4.NativeMethodInfoPtr_get_normalized_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665590);
			Vector4.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665591);
			Vector4.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665592);
			Vector4.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665593);
			Vector4.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665594);
			Vector4.NativeMethodInfoPtr_get_one_Public_Static_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665595);
			Vector4.NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665596);
			Vector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665597);
			Vector4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665598);
			Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665599);
			Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665600);
			Vector4.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665601);
			Vector4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665602);
			Vector4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665603);
			Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665604);
			Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665605);
			Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665606);
			Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665607);
			Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665608);
			Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665609);
			Vector4.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100665610);
		}

		// Token: 0x17000493 RID: 1171
		public unsafe float this[int index]
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 1245679, RefRangeEnd = 1245694, XrefRangeStart = 1245679, XrefRangeEnd = 1245679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1245694, RefRangeEnd = 1245698, XrefRangeStart = 1245694, XrefRangeEnd = 1245694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x00060140 File Offset: 0x0005E340
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 450606, RefRangeEnd = 450617, XrefRangeStart = 450606, XrefRangeEnd = 450617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4(float x, float y, float z, float w)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0006019C File Offset: 0x0005E39C
		[CallerCount(0)]
		public unsafe Vector4(float x, float y, float z)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x000601EC File Offset: 0x0005E3EC
		[CallerCount(0)]
		public unsafe Vector4(float x, float y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0006022C File Offset: 0x0005E42C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 450606, RefRangeEnd = 450617, XrefRangeStart = 450606, XrefRangeEnd = 450617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(float newX, float newY, float newZ, float newW)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newZ;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newW;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00060288 File Offset: 0x0005E488
		[CallerCount(0)]
		public unsafe void Scale(Vector4 scale)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Scale_Public_Void_Vector4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x000602BC File Offset: 0x0005E4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x000602EC File Offset: 0x0005E4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245698, XrefRangeEnd = 1245701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00060330 File Offset: 0x0005E530
		[CallerCount(0)]
		public unsafe bool Equals(Vector4 other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00060370 File Offset: 0x0005E570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245709, RefRangeEnd = 1245710, XrefRangeStart = 1245701, XrefRangeEnd = 1245709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 Normalize(Vector4 a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Normalize_Public_Static_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x000603B0 File Offset: 0x0005E5B0
		public unsafe Vector4 normalized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245710, XrefRangeEnd = 1245711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_normalized_Public_get_Vector4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000603E0 File Offset: 0x0005E5E0
		[CallerCount(0)]
		public unsafe static float Dot(Vector4 a, Vector4 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x0006042C File Offset: 0x0005E62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245711, XrefRangeEnd = 1245714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Magnitude(Vector4 a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x0006046C File Offset: 0x0005E66C
		public unsafe float sqrMagnitude
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x0006049C File Offset: 0x0005E69C
		public unsafe static Vector4 zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245714, XrefRangeEnd = 1245716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x000604CC File Offset: 0x0005E6CC
		public unsafe static Vector4 one
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245716, XrefRangeEnd = 1245718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_one_Public_Static_get_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000604FC File Offset: 0x0005E6FC
		[CallerCount(0)]
		public unsafe static Vector4 operator +(Vector4 a, Vector4 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00060548 File Offset: 0x0005E748
		[CallerCount(0)]
		public unsafe static Vector4 operator -(Vector4 a, Vector4 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00060594 File Offset: 0x0005E794
		[CallerCount(0)]
		public unsafe static Vector4 operator -(Vector4 a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000605D4 File Offset: 0x0005E7D4
		[CallerCount(0)]
		public unsafe static Vector4 operator *(Vector4 a, float d)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00060620 File Offset: 0x0005E820
		[CallerCount(0)]
		public unsafe static Vector4 operator *(float d, Vector4 a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref d;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Single_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x0006066C File Offset: 0x0005E86C
		[CallerCount(0)]
		public unsafe static Vector4 operator /(Vector4 a, float d)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000606B8 File Offset: 0x0005E8B8
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector4 lhs, Vector4 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00060704 File Offset: 0x0005E904
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector4 lhs, Vector4 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00060750 File Offset: 0x0005E950
		[CallerCount(0)]
		public unsafe static implicit operator Vector4(Vector3 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00060790 File Offset: 0x0005E990
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 60678, RefRangeEnd = 60714, XrefRangeStart = 60678, XrefRangeEnd = 60714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector3(Vector4 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x000607D0 File Offset: 0x0005E9D0
		[CallerCount(0)]
		public unsafe static implicit operator Vector4(Vector2 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00060810 File Offset: 0x0005EA10
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(Vector4 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00060850 File Offset: 0x0005EA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245718, XrefRangeEnd = 1245724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0006087C File Offset: 0x0005EA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245724, XrefRangeEnd = 1245759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x000608CC File Offset: 0x0005EACC
		[CallerCount(0)]
		public unsafe static float SqrMagnitude(Vector4 a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0000ADC3 File Offset: 0x00008FC3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector4>.NativeClassPtr, ref this));
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x0006090C File Offset: 0x0005EB0C
		// (set) Token: 0x060015C4 RID: 5572 RVA: 0x0000ADD5 File Offset: 0x00008FD5
		public unsafe static float kEpsilon
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_kEpsilon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x00060928 File Offset: 0x0005EB28
		// (set) Token: 0x060015C6 RID: 5574 RVA: 0x0000ADE3 File Offset: 0x00008FE3
		public unsafe static Vector4 zeroVector
		{
			get
			{
				Vector4 result;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_zeroVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_zeroVector, (void*)(&value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x00060944 File Offset: 0x0005EB44
		// (set) Token: 0x060015C8 RID: 5576 RVA: 0x0000ADF1 File Offset: 0x00008FF1
		public unsafe static Vector4 oneVector
		{
			get
			{
				Vector4 result;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_oneVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_oneVector, (void*)(&value));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00060960 File Offset: 0x0005EB60
		// (set) Token: 0x060015CA RID: 5578 RVA: 0x0000ADFF File Offset: 0x00008FFF
		public unsafe static Vector4 positiveInfinityVector
		{
			get
			{
				Vector4 result;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x0006097C File Offset: 0x0005EB7C
		// (set) Token: 0x060015CC RID: 5580 RVA: 0x0000AE0D File Offset: 0x0000900D
		public unsafe static Vector4 negativeInfinityVector
		{
			get
			{
				Vector4 result;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00060998 File Offset: 0x0005EB98
		public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00060A10 File Offset: 0x0005EC10
		public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t)
		{
			return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00060A80 File Offset: 0x0005EC80
		public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta)
		{
			float num = target.x - current.x;
			float num2 = target.y - current.y;
			float num3 = target.z - current.z;
			float num4 = target.w - current.w;
			float num5 = num * num + num2 * num2 + num3 * num3 + num4 * num4;
			bool flag = num5 == 0f || (maxDistanceDelta >= 0f && num5 <= maxDistanceDelta * maxDistanceDelta);
			Vector4 result;
			if (flag)
			{
				result = target;
			}
			else
			{
				float num6 = (float)Math.Sqrt((double)num5);
				result = new Vector4(current.x + num / num6 * maxDistanceDelta, current.y + num2 / num6 * maxDistanceDelta, current.z + num3 / num6 * maxDistanceDelta, current.w + num4 / num6 * maxDistanceDelta);
			}
			return result;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00060B50 File Offset: 0x0005ED50
		public static Vector4 Scale(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00060B9C File Offset: 0x0005ED9C
		public void Normalize()
		{
			float num = Vector4.Magnitude(this);
			bool flag = num > 1E-05f;
			if (flag)
			{
				this /= num;
			}
			else
			{
				this = Vector4.zero;
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00060BE4 File Offset: 0x0005EDE4
		public static Vector4 Project(Vector4 a, Vector4 b)
		{
			return b * (Vector4.Dot(a, b) / Vector4.Dot(b, b));
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00060C0C File Offset: 0x0005EE0C
		public static float Distance(Vector4 a, Vector4 b)
		{
			return Vector4.Magnitude(a - b);
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x00060C2C File Offset: 0x0005EE2C
		public float magnitude
		{
			get
			{
				return (float)Math.Sqrt((double)Vector4.Dot(this, this));
			}
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00060C58 File Offset: 0x0005EE58
		public static Vector4 Min(Vector4 lhs, Vector4 rhs)
		{
			return new Vector4(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z), Mathf.Min(lhs.w, rhs.w));
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00060CB4 File Offset: 0x0005EEB4
		public static Vector4 Max(Vector4 lhs, Vector4 rhs)
		{
			return new Vector4(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z), Mathf.Max(lhs.w, rhs.w));
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x00060D10 File Offset: 0x0005EF10
		public static Vector4 positiveInfinity
		{
			get
			{
				return Vector4.positiveInfinityVector;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00060D28 File Offset: 0x0005EF28
		public static Vector4 negativeInfinity
		{
			get
			{
				return Vector4.negativeInfinityVector;
			}
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00060D40 File Offset: 0x0005EF40
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00060D5C File Offset: 0x0005EF5C
		public float SqrMagnitude()
		{
			return Vector4.Dot(this, this);
		}

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeFieldInfoPtr_zeroVector;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeFieldInfoPtr_oneVector;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinityVector;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinityVector;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Void_Vector4_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Vector4_Vector4_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_get_normalized_Public_get_Vector4_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector4_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector4_0;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_Vector4_Vector4_0;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_Vector4_Vector4_0;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector4_Vector4_0;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Single_Vector4_0;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0;

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040012FF RID: 4863
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector4_0;

		// Token: 0x04001301 RID: 4865
		[FieldOffset(0)]
		public float x;

		// Token: 0x04001302 RID: 4866
		[FieldOffset(4)]
		public float y;

		// Token: 0x04001303 RID: 4867
		[FieldOffset(8)]
		public float z;

		// Token: 0x04001304 RID: 4868
		[FieldOffset(12)]
		public float w;
	}
}

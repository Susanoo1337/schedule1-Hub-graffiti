using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FC RID: 252
	[StructLayout(2)]
	public struct Vector2
	{
		// Token: 0x060014DE RID: 5342 RVA: 0x0005D160 File Offset: 0x0005B360
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2()
		{
			Il2CppClassPointerStore<Vector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2>.NativeClassPtr);
			Vector2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "x");
			Vector2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "y");
			Vector2.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "zeroVector");
			Vector2.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "oneVector");
			Vector2.NativeFieldInfoPtr_upVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "upVector");
			Vector2.NativeFieldInfoPtr_downVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "downVector");
			Vector2.NativeFieldInfoPtr_leftVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "leftVector");
			Vector2.NativeFieldInfoPtr_rightVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "rightVector");
			Vector2.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "positiveInfinityVector");
			Vector2.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "negativeInfinityVector");
			Vector2.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "kEpsilon");
			Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "kEpsilonNormalSqrt");
			Vector2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665487);
			Vector2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665488);
			Vector2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665489);
			Vector2.NativeMethodInfoPtr_Set_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665490);
			Vector2.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665491);
			Vector2.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665492);
			Vector2.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665493);
			Vector2.NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665494);
			Vector2.NativeMethodInfoPtr_Normalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665495);
			Vector2.NativeMethodInfoPtr_get_normalized_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665496);
			Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665497);
			Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665498);
			Vector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665499);
			Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665500);
			Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665501);
			Vector2.NativeMethodInfoPtr_Perpendicular_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665502);
			Vector2.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665503);
			Vector2.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665504);
			Vector2.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665505);
			Vector2.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665506);
			Vector2.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665507);
			Vector2.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665508);
			Vector2.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665509);
			Vector2.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665510);
			Vector2.NativeMethodInfoPtr_Min_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665511);
			Vector2.NativeMethodInfoPtr_Max_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665512);
			Vector2.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665513);
			Vector2.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665514);
			Vector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665515);
			Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665516);
			Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665517);
			Vector2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665518);
			Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665519);
			Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665520);
			Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665521);
			Vector2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665522);
			Vector2.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665523);
			Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665524);
			Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665525);
			Vector2.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665526);
			Vector2.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665527);
			Vector2.NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665528);
			Vector2.NativeMethodInfoPtr_get_down_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665529);
			Vector2.NativeMethodInfoPtr_get_left_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665530);
			Vector2.NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665531);
			Vector2.NativeMethodInfoPtr_get_positiveInfinity_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665532);
			Vector2.NativeMethodInfoPtr_get_negativeInfinity_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100665533);
		}

		// Token: 0x1700045B RID: 1115
		public unsafe float this[int index]
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1245386, RefRangeEnd = 1245415, XrefRangeStart = 1245386, XrefRangeEnd = 1245386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1245415, RefRangeEnd = 1245431, XrefRangeStart = 1245415, XrefRangeEnd = 1245415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0005D6AC File Offset: 0x0005B8AC
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 71922, RefRangeEnd = 71952, XrefRangeStart = 71922, XrefRangeEnd = 71952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2(float x, float y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0005D6EC File Offset: 0x0005B8EC
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 71922, RefRangeEnd = 71952, XrefRangeStart = 71922, XrefRangeEnd = 71952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(float newX, float newY)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Set_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0005D72C File Offset: 0x0005B92C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245432, RefRangeEnd = 1245434, XrefRangeStart = 1245431, XrefRangeEnd = 1245432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Lerp(Vector2 a, Vector2 b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0005D788 File Offset: 0x0005B988
		[CallerCount(0)]
		public unsafe static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0005D7E4 File Offset: 0x0005B9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245434, XrefRangeEnd = 1245439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistanceDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0005D840 File Offset: 0x0005BA40
		[CallerCount(0)]
		public unsafe static Vector2 Scale(Vector2 a, Vector2 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0005D88C File Offset: 0x0005BA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245439, XrefRangeEnd = 1245442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Normalize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Normalize_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x0005D8B4 File Offset: 0x0005BAB4
		public unsafe Vector2 normalized
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 1245450, RefRangeEnd = 1245494, XrefRangeStart = 1245442, XrefRangeEnd = 1245450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_normalized_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0005D8E4 File Offset: 0x0005BAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245494, XrefRangeEnd = 1245495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0005D910 File Offset: 0x0005BB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245495, XrefRangeEnd = 1245529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0005D960 File Offset: 0x0005BB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245529, XrefRangeEnd = 1245531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0005D990 File Offset: 0x0005BB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245531, XrefRangeEnd = 1245534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0005D9D4 File Offset: 0x0005BBD4
		[CallerCount(0)]
		public unsafe bool Equals(Vector2 other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0005DA14 File Offset: 0x0005BC14
		[CallerCount(0)]
		public unsafe static Vector2 Perpendicular(Vector2 inDirection)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Perpendicular_Public_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0005DA54 File Offset: 0x0005BC54
		[CallerCount(0)]
		public unsafe static float Dot(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x0005DAA0 File Offset: 0x0005BCA0
		public unsafe float magnitude
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245534, XrefRangeEnd = 1245539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x0005DAD0 File Offset: 0x0005BCD0
		public unsafe float sqrMagnitude
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0005DB00 File Offset: 0x0005BD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245539, XrefRangeEnd = 1245548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Angle(Vector2 from, Vector2 to)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0005DB4C File Offset: 0x0005BD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245548, XrefRangeEnd = 1245558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SignedAngle(Vector2 from, Vector2 to)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0005DB98 File Offset: 0x0005BD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245558, XrefRangeEnd = 1245561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Distance(Vector2 a, Vector2 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0005DBE4 File Offset: 0x0005BDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245561, XrefRangeEnd = 1245566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 ClampMagnitude(Vector2 vector, float maxLength)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0005DC30 File Offset: 0x0005BE30
		[CallerCount(0)]
		public unsafe static float SqrMagnitude(Vector2 a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0005DC70 File Offset: 0x0005BE70
		[CallerCount(0)]
		public unsafe static Vector2 Min(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Min_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0005DCBC File Offset: 0x0005BEBC
		[CallerCount(0)]
		public unsafe static Vector2 Max(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Max_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0005DD08 File Offset: 0x0005BF08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245572, RefRangeEnd = 1245573, XrefRangeStart = 1245566, XrefRangeEnd = 1245572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0005DD8C File Offset: 0x0005BF8C
		[CallerCount(0)]
		public unsafe static Vector2 operator +(Vector2 a, Vector2 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0005DDD8 File Offset: 0x0005BFD8
		[CallerCount(0)]
		public unsafe static Vector2 operator -(Vector2 a, Vector2 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0005DE24 File Offset: 0x0005C024
		[CallerCount(0)]
		public unsafe static Vector2 operator *(Vector2 a, Vector2 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0005DE70 File Offset: 0x0005C070
		[CallerCount(0)]
		public unsafe static Vector2 operator /(Vector2 a, Vector2 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0005DEBC File Offset: 0x0005C0BC
		[CallerCount(0)]
		public unsafe static Vector2 operator -(Vector2 a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0005DEFC File Offset: 0x0005C0FC
		[CallerCount(0)]
		public unsafe static Vector2 operator *(Vector2 a, float d)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0005DF48 File Offset: 0x0005C148
		[CallerCount(0)]
		public unsafe static Vector2 operator *(float d, Vector2 a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref d;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0005DF94 File Offset: 0x0005C194
		[CallerCount(0)]
		public unsafe static Vector2 operator /(Vector2 a, float d)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x0005DFE0 File Offset: 0x0005C1E0
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0005E02C File Offset: 0x0005C22C
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0005E078 File Offset: 0x0005C278
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(Vector3 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x0005E0B8 File Offset: 0x0005C2B8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1245573, RefRangeEnd = 1245588, XrefRangeStart = 1245573, XrefRangeEnd = 1245573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector3(Vector2 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0005E0F8 File Offset: 0x0005C2F8
		public unsafe static Vector2 zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245588, XrefRangeEnd = 1245590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x0005E128 File Offset: 0x0005C328
		public unsafe static Vector2 one
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245590, XrefRangeEnd = 1245592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x0005E158 File Offset: 0x0005C358
		public unsafe static Vector2 up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245592, XrefRangeEnd = 1245594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x0005E188 File Offset: 0x0005C388
		public unsafe static Vector2 down
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245594, XrefRangeEnd = 1245596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_down_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x0005E1B8 File Offset: 0x0005C3B8
		public unsafe static Vector2 left
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245596, XrefRangeEnd = 1245598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_left_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x0005E1E8 File Offset: 0x0005C3E8
		public unsafe static Vector2 right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245598, XrefRangeEnd = 1245600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x0005E218 File Offset: 0x0005C418
		public unsafe static Vector2 positiveInfinity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245600, XrefRangeEnd = 1245602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_positiveInfinity_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x0005E248 File Offset: 0x0005C448
		public unsafe static Vector2 negativeInfinity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245602, XrefRangeEnd = 1245604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_negativeInfinity_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector2>.NativeClassPtr, ref this));
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x0005E278 File Offset: 0x0005C478
		// (set) Token: 0x06001510 RID: 5392 RVA: 0x0000ABB6 File Offset: 0x00008DB6
		public unsafe static Vector2 zeroVector
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_zeroVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_zeroVector, (void*)(&value));
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x0005E294 File Offset: 0x0005C494
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x0000ABC4 File Offset: 0x00008DC4
		public unsafe static Vector2 oneVector
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_oneVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_oneVector, (void*)(&value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x0005E2B0 File Offset: 0x0005C4B0
		// (set) Token: 0x06001514 RID: 5396 RVA: 0x0000ABD2 File Offset: 0x00008DD2
		public unsafe static Vector2 upVector
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_upVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_upVector, (void*)(&value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x0005E2CC File Offset: 0x0005C4CC
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x0000ABE0 File Offset: 0x00008DE0
		public unsafe static Vector2 downVector
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_downVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_downVector, (void*)(&value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x0005E2E8 File Offset: 0x0005C4E8
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x0000ABEE File Offset: 0x00008DEE
		public unsafe static Vector2 leftVector
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_leftVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_leftVector, (void*)(&value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x0005E304 File Offset: 0x0005C504
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x0000ABFC File Offset: 0x00008DFC
		public unsafe static Vector2 rightVector
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_rightVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_rightVector, (void*)(&value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0005E320 File Offset: 0x0005C520
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x0000AC0A File Offset: 0x00008E0A
		public unsafe static Vector2 positiveInfinityVector
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x0005E33C File Offset: 0x0005C53C
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x0000AC18 File Offset: 0x00008E18
		public unsafe static Vector2 negativeInfinityVector
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x0005E358 File Offset: 0x0005C558
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x0000AC26 File Offset: 0x00008E26
		public unsafe static float kEpsilon
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_kEpsilon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0005E374 File Offset: 0x0005C574
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x0000AC34 File Offset: 0x00008E34
		public unsafe static float kEpsilonNormalSqrt
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&value));
			}
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0000AC42 File Offset: 0x00008E42
		public void Scale(Vector2 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0005E390 File Offset: 0x0005C590
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0005E3AC File Offset: 0x0005C5AC
		public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal)
		{
			float num = -2f * Vector2.Dot(inNormal, inDirection);
			return new Vector2(num * inNormal.x + inDirection.x, num * inNormal.y + inDirection.y);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0005E3F0 File Offset: 0x0005C5F0
		public float SqrMagnitude()
		{
			return this.x * this.x + this.y * this.y;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0005E420 File Offset: 0x0005C620
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0005E444 File Offset: 0x0005C644
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime)
		{
			float deltaTime = Time.deltaTime;
			float positiveInfinity = float.PositiveInfinity;
			return Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, positiveInfinity, deltaTime);
		}

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeFieldInfoPtr_zeroVector;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeFieldInfoPtr_oneVector;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeFieldInfoPtr_upVector;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeFieldInfoPtr_downVector;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeFieldInfoPtr_leftVector;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeFieldInfoPtr_rightVector;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinityVector;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinityVector;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilonNormalSqrt;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04001266 RID: 4710
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04001267 RID: 4711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04001268 RID: 4712
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_Single_0;

		// Token: 0x04001269 RID: 4713
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0;

		// Token: 0x0400126A RID: 4714
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector2_Vector2_Vector2_Single_0;

		// Token: 0x0400126B RID: 4715
		private static readonly IntPtr NativeMethodInfoPtr_MoveTowards_Public_Static_Vector2_Vector2_Vector2_Single_0;

		// Token: 0x0400126C RID: 4716
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x0400126D RID: 4717
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Void_0;

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeMethodInfoPtr_get_normalized_Public_get_Vector2_0;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeMethodInfoPtr_Perpendicular_Public_Static_Vector2_Vector2_0;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector2_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_Single_Single_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector2_Vector2_0;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Single_Vector2_0;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0;

		// Token: 0x0400128B RID: 4747
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0;

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0;

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeMethodInfoPtr_get_down_Public_Static_get_Vector2_0;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_Static_get_Vector2_0;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0;

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeMethodInfoPtr_get_positiveInfinity_Public_Static_get_Vector2_0;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_get_negativeInfinity_Public_Static_get_Vector2_0;

		// Token: 0x04001294 RID: 4756
		[FieldOffset(0)]
		public float x;

		// Token: 0x04001295 RID: 4757
		[FieldOffset(4)]
		public float y;
	}
}

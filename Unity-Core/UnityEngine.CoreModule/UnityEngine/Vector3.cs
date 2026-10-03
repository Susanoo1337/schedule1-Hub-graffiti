using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F9 RID: 249
	[StructLayout(2)]
	public struct Vector3
	{
		// Token: 0x060013E2 RID: 5090 RVA: 0x00058A20 File Offset: 0x00056C20
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3()
		{
			Il2CppClassPointerStore<Vector3>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3>.NativeClassPtr);
			Vector3.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "kEpsilon");
			Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "kEpsilonNormalSqrt");
			Vector3.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "x");
			Vector3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "y");
			Vector3.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "z");
			Vector3.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "zeroVector");
			Vector3.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "oneVector");
			Vector3.NativeFieldInfoPtr_upVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "upVector");
			Vector3.NativeFieldInfoPtr_downVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "downVector");
			Vector3.NativeFieldInfoPtr_leftVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "leftVector");
			Vector3.NativeFieldInfoPtr_rightVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "rightVector");
			Vector3.NativeFieldInfoPtr_forwardVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "forwardVector");
			Vector3.NativeFieldInfoPtr_backVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "backVector");
			Vector3.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "positiveInfinityVector");
			Vector3.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3>.NativeClassPtr, "negativeInfinityVector");
			Vector3.NativeMethodInfoPtr_Slerp_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665319);
			Vector3.NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665320);
			Vector3.NativeMethodInfoPtr_OrthoNormalize2_Private_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665321);
			Vector3.NativeMethodInfoPtr_OrthoNormalize_Public_Static_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665322);
			Vector3.NativeMethodInfoPtr_RotateTowards_Public_Static_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665323);
			Vector3.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665324);
			Vector3.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665325);
			Vector3.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665326);
			Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665327);
			Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665328);
			Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665329);
			Vector3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665330);
			Vector3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665331);
			Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665332);
			Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665333);
			Vector3.NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665334);
			Vector3.NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665335);
			Vector3.NativeMethodInfoPtr_Scale_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665336);
			Vector3.NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665337);
			Vector3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665338);
			Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665339);
			Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665340);
			Vector3.NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665341);
			Vector3.NativeMethodInfoPtr_Normalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665342);
			Vector3.NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665343);
			Vector3.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665344);
			Vector3.NativeMethodInfoPtr_Project_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665345);
			Vector3.NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665346);
			Vector3.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665347);
			Vector3.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665348);
			Vector3.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665349);
			Vector3.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665350);
			Vector3.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665351);
			Vector3.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665352);
			Vector3.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665353);
			Vector3.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665354);
			Vector3.NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665355);
			Vector3.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665356);
			Vector3.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665357);
			Vector3.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665358);
			Vector3.NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665359);
			Vector3.NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665360);
			Vector3.NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665361);
			Vector3.NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665362);
			Vector3.NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665363);
			Vector3.NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665364);
			Vector3.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665365);
			Vector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665366);
			Vector3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665367);
			Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665368);
			Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665369);
			Vector3.NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665370);
			Vector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665371);
			Vector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665372);
			Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665373);
			Vector3.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665374);
			Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665375);
			Vector3.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665377);
			Vector3.NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665378);
			Vector3.NativeMethodInfoPtr_RotateTowards_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3>.NativeClassPtr, 100665379);
			Vector3.OrthoNormalize3DelegateField = IL2CPP.ResolveICall<Vector3.OrthoNormalize3Delegate>("UnityEngine.Vector3::OrthoNormalize3");
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0005903C File Offset: 0x0005723C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1243145, RefRangeEnd = 1243163, XrefRangeStart = 1243143, XrefRangeEnd = 1243145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Slerp(Vector3 a, Vector3 b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Slerp_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00059098 File Offset: 0x00057298
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1243165, RefRangeEnd = 1243183, XrefRangeStart = 1243163, XrefRangeEnd = 1243165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x000590F4 File Offset: 0x000572F4
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1243185, RefRangeEnd = 1243222, XrefRangeStart = 1243183, XrefRangeEnd = 1243185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OrthoNormalize2(ref Vector3 a, ref Vector3 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_OrthoNormalize2_Private_Static_Void_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00059134 File Offset: 0x00057334
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 1243185, RefRangeEnd = 1243222, XrefRangeStart = 1243185, XrefRangeEnd = 1243222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &normal;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &tangent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_OrthoNormalize_Public_Static_Void_byref_Vector3_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x00059174 File Offset: 0x00057374
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1243224, RefRangeEnd = 1243232, XrefRangeStart = 1243222, XrefRangeEnd = 1243224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxRadiansDelta;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxMagnitudeDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_RotateTowards_Public_Static_Vector3_Vector3_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x000591DC File Offset: 0x000573DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243232, XrefRangeEnd = 1243233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Lerp(Vector3 a, Vector3 b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x00059238 File Offset: 0x00057438
		[CallerCount(0)]
		public unsafe static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00059294 File Offset: 0x00057494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243233, XrefRangeEnd = 1243239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistanceDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x000592F0 File Offset: 0x000574F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243239, XrefRangeEnd = 1243241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00059368 File Offset: 0x00057568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243241, XrefRangeEnd = 1243243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x000593D0 File Offset: 0x000575D0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1243249, RefRangeEnd = 1243265, XrefRangeStart = 1243243, XrefRangeEnd = 1243249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700043B RID: 1083
		public unsafe float this[int index]
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 1243265, RefRangeEnd = 1243276, XrefRangeStart = 1243265, XrefRangeEnd = 1243265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x000594D4 File Offset: 0x000576D4
		[CallerCount(0)]
		public unsafe Vector3(float x, float y, float z)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00059524 File Offset: 0x00057724
		[CallerCount(0)]
		public unsafe Vector3(float x, float y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00059564 File Offset: 0x00057764
		[CallerCount(0)]
		public unsafe void Set(float newX, float newY, float newZ)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newZ;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x000595B4 File Offset: 0x000577B4
		[CallerCount(0)]
		public unsafe static Vector3 Scale(Vector3 a, Vector3 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00059600 File Offset: 0x00057800
		[CallerCount(0)]
		public unsafe void Scale(Vector3 scale)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Scale_Public_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00059634 File Offset: 0x00057834
		[CallerCount(0)]
		public unsafe static Vector3 Cross(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x00059680 File Offset: 0x00057880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243276, XrefRangeEnd = 1243279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x000596B0 File Offset: 0x000578B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243279, XrefRangeEnd = 1243282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x000596F4 File Offset: 0x000578F4
		[CallerCount(0)]
		public unsafe bool Equals(Vector3 other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x00059734 File Offset: 0x00057934
		[CallerCount(78)]
		[CachedScanResults(RefRangeStart = 1243290, RefRangeEnd = 1243368, XrefRangeStart = 1243282, XrefRangeEnd = 1243290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Normalize(Vector3 value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00059774 File Offset: 0x00057974
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1243376, RefRangeEnd = 1243381, XrefRangeStart = 1243368, XrefRangeEnd = 1243376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Normalize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Normalize_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x0005979C File Offset: 0x0005799C
		public unsafe Vector3 normalized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243381, XrefRangeEnd = 1243382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x000597CC File Offset: 0x000579CC
		[CallerCount(0)]
		public unsafe static float Dot(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00059818 File Offset: 0x00057A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243382, XrefRangeEnd = 1243384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Project(Vector3 vector, Vector3 onNormal)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onNormal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Project_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x00059864 File Offset: 0x00057A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243384, XrefRangeEnd = 1243386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref planeNormal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x000598B0 File Offset: 0x00057AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243386, XrefRangeEnd = 1243395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Angle(Vector3 from, Vector3 to)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x000598FC File Offset: 0x00057AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243395, XrefRangeEnd = 1243397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x00059958 File Offset: 0x00057B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243397, XrefRangeEnd = 1243402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Distance(Vector3 a, Vector3 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x000599A4 File Offset: 0x00057BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243402, XrefRangeEnd = 1243408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x000599F0 File Offset: 0x00057BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243408, XrefRangeEnd = 1243413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Magnitude(Vector3 vector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x00059A30 File Offset: 0x00057C30
		public unsafe float magnitude
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243413, XrefRangeEnd = 1243418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00059A60 File Offset: 0x00057C60
		[CallerCount(0)]
		public unsafe static float SqrMagnitude(Vector3 vector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x00059AA0 File Offset: 0x00057CA0
		public unsafe float sqrMagnitude
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x00059AD0 File Offset: 0x00057CD0
		[CallerCount(0)]
		public unsafe static Vector3 Min(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x00059B1C File Offset: 0x00057D1C
		[CallerCount(0)]
		public unsafe static Vector3 Max(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x00059B68 File Offset: 0x00057D68
		public unsafe static Vector3 zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243418, XrefRangeEnd = 1243420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x00059B98 File Offset: 0x00057D98
		public unsafe static Vector3 one
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243420, XrefRangeEnd = 1243422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x00059BC8 File Offset: 0x00057DC8
		public unsafe static Vector3 forward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243422, XrefRangeEnd = 1243424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00059BF8 File Offset: 0x00057DF8
		public unsafe static Vector3 back
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243424, XrefRangeEnd = 1243426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x00059C28 File Offset: 0x00057E28
		public unsafe static Vector3 up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243426, XrefRangeEnd = 1243428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x00059C58 File Offset: 0x00057E58
		public unsafe static Vector3 down
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243428, XrefRangeEnd = 1243430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x00059C88 File Offset: 0x00057E88
		public unsafe static Vector3 left
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243430, XrefRangeEnd = 1243432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x00059CB8 File Offset: 0x00057EB8
		public unsafe static Vector3 right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243432, XrefRangeEnd = 1243434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00059CE8 File Offset: 0x00057EE8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 1243434, RefRangeEnd = 1243508, XrefRangeStart = 1243434, XrefRangeEnd = 1243434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator +(Vector3 a, Vector3 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00059D34 File Offset: 0x00057F34
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1243508, RefRangeEnd = 1243524, XrefRangeStart = 1243508, XrefRangeEnd = 1243508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator -(Vector3 a, Vector3 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00059D80 File Offset: 0x00057F80
		[CallerCount(0)]
		public unsafe static Vector3 operator -(Vector3 a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00059DC0 File Offset: 0x00057FC0
		[CallerCount(0)]
		public unsafe static Vector3 operator *(Vector3 a, float d)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00059E0C File Offset: 0x0005800C
		[CallerCount(0)]
		public unsafe static Vector3 operator *(float d, Vector3 a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref d;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00059E58 File Offset: 0x00058058
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1243524, RefRangeEnd = 1243533, XrefRangeStart = 1243524, XrefRangeEnd = 1243524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator /(Vector3 a, float d)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00059EA4 File Offset: 0x000580A4
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00059EF0 File Offset: 0x000580F0
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x00059F3C File Offset: 0x0005813C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243533, XrefRangeEnd = 1243534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00059F68 File Offset: 0x00058168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243534, XrefRangeEnd = 1243535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00059FA4 File Offset: 0x000581A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243535, XrefRangeEnd = 1243576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00059FF4 File Offset: 0x000581F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243576, XrefRangeEnd = 1243578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x0005A050 File Offset: 0x00058250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243578, XrefRangeEnd = 1243580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SlerpUnclamped_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0005A0AC File Offset: 0x000582AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243580, XrefRangeEnd = 1243582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &current;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxRadiansDelta;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxMagnitudeDelta;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3.NativeMethodInfoPtr_RotateTowards_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_Single_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0000A951 File Offset: 0x00008B51
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector3>.NativeClassPtr, ref this));
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x0005A118 File Offset: 0x00058318
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x0000A963 File Offset: 0x00008B63
		public unsafe static float kEpsilon
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_kEpsilon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x0005A134 File Offset: 0x00058334
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x0000A971 File Offset: 0x00008B71
		public unsafe static float kEpsilonNormalSqrt
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&value));
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x0005A150 File Offset: 0x00058350
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x0000A97F File Offset: 0x00008B7F
		public unsafe static Vector3 zeroVector
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_zeroVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_zeroVector, (void*)(&value));
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0005A16C File Offset: 0x0005836C
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x0000A98D File Offset: 0x00008B8D
		public unsafe static Vector3 oneVector
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_oneVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_oneVector, (void*)(&value));
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x0005A188 File Offset: 0x00058388
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x0000A99B File Offset: 0x00008B9B
		public unsafe static Vector3 upVector
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_upVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_upVector, (void*)(&value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x0005A1A4 File Offset: 0x000583A4
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x0000A9A9 File Offset: 0x00008BA9
		public unsafe static Vector3 downVector
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_downVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_downVector, (void*)(&value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x0005A1C0 File Offset: 0x000583C0
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x0000A9B7 File Offset: 0x00008BB7
		public unsafe static Vector3 leftVector
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_leftVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_leftVector, (void*)(&value));
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x0005A1DC File Offset: 0x000583DC
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x0000A9C5 File Offset: 0x00008BC5
		public unsafe static Vector3 rightVector
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_rightVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_rightVector, (void*)(&value));
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x0005A1F8 File Offset: 0x000583F8
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x0000A9D3 File Offset: 0x00008BD3
		public unsafe static Vector3 forwardVector
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_forwardVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_forwardVector, (void*)(&value));
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x0005A214 File Offset: 0x00058414
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x0000A9E1 File Offset: 0x00008BE1
		public unsafe static Vector3 backVector
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_backVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_backVector, (void*)(&value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0005A230 File Offset: 0x00058430
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x0000A9EF File Offset: 0x00008BEF
		public unsafe static Vector3 positiveInfinityVector
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0005A24C File Offset: 0x0005844C
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x0000A9FD File Offset: 0x00008BFD
		public unsafe static Vector3 negativeInfinityVector
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Vector3.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0000AA0B File Offset: 0x00008C0B
		public static void OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c)
		{
			Vector3.OrthoNormalize3DelegateField(ref a, ref b, ref c);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0000AA1A File Offset: 0x00008C1A
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal)
		{
			Vector3.OrthoNormalize3(ref normal, ref tangent, ref binormal);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x0005A268 File Offset: 0x00058468
		public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
		{
			float num = -2f * Vector3.Dot(inNormal, inDirection);
			return new Vector3(num * inNormal.x + inDirection.x, num * inNormal.y + inDirection.y, num * inNormal.z + inDirection.z);
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x0600143B RID: 5179 RVA: 0x0005A2BC File Offset: 0x000584BC
		public static Vector3 positiveInfinity
		{
			get
			{
				return Vector3.positiveInfinityVector;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x0005A2D4 File Offset: 0x000584D4
		public static Vector3 negativeInfinity
		{
			get
			{
				return Vector3.negativeInfinityVector;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600143D RID: 5181 RVA: 0x0005A2EC File Offset: 0x000584EC
		public static Vector3 fwd
		{
			get
			{
				return new Vector3(0f, 0f, 1f);
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0005A314 File Offset: 0x00058514
		public static float AngleBetween(Vector3 from, Vector3 to)
		{
			return (float)Math.Acos((double)Mathf.Clamp(Vector3.Dot(from.normalized, to.normalized), -1f, 1f));
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0005A350 File Offset: 0x00058550
		public static Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat)
		{
			return Vector3.ProjectOnPlane(fromThat, excludeThis);
		}

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilonNormalSqrt;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeFieldInfoPtr_zeroVector;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeFieldInfoPtr_oneVector;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeFieldInfoPtr_upVector;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeFieldInfoPtr_downVector;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeFieldInfoPtr_leftVector;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeFieldInfoPtr_rightVector;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeFieldInfoPtr_forwardVector;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeFieldInfoPtr_backVector;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinityVector;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinityVector;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_Slerp_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_OrthoNormalize2_Private_Static_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_OrthoNormalize_Public_Static_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_RotateTowards_Public_Static_Vector3_Vector3_Vector3_Single_Single_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_MoveTowards_Public_Static_Vector3_Vector3_Vector3_Single_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector3_Vector3_Vector3_byref_Vector3_Single_Single_Single_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Void_Vector3_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_Cross_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3_0;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Vector3_Vector3_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Void_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr_get_normalized_Public_get_Vector3_0;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeMethodInfoPtr_Project_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeMethodInfoPtr_ProjectOnPlane_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeMethodInfoPtr_SignedAngle_Public_Static_Single_Vector3_Vector3_Vector3_0;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Vector3_Vector3_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr_ClampMagnitude_Public_Static_Vector3_Vector3_Single_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector3_0;

		// Token: 0x040011BD RID: 4541
		private static readonly IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

		// Token: 0x040011BE RID: 4542
		private static readonly IntPtr NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector3_0;

		// Token: 0x040011BF RID: 4543
		private static readonly IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;

		// Token: 0x040011C0 RID: 4544
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x040011C1 RID: 4545
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x040011C2 RID: 4546
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3_0;

		// Token: 0x040011C3 RID: 4547
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector3_0;

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeMethodInfoPtr_get_forward_Public_Static_get_Vector3_0;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr_get_back_Public_Static_get_Vector3_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_Static_get_Vector3_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr_get_down_Public_Static_get_Vector3_0;

		// Token: 0x040011C8 RID: 4552
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_Static_get_Vector3_0;

		// Token: 0x040011C9 RID: 4553
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_Vector3_0;

		// Token: 0x040011CA RID: 4554
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x040011CB RID: 4555
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x040011CC RID: 4556
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector3_Vector3_0;

		// Token: 0x040011CD RID: 4557
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Vector3_Single_0;

		// Token: 0x040011CE RID: 4558
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Single_Vector3_0;

		// Token: 0x040011CF RID: 4559
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector3_Vector3_Single_0;

		// Token: 0x040011D0 RID: 4560
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3_Vector3_0;

		// Token: 0x040011D1 RID: 4561
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3_Vector3_0;

		// Token: 0x040011D2 RID: 4562
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040011D3 RID: 4563
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x040011D4 RID: 4564
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040011D5 RID: 4565
		private static readonly IntPtr NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0;

		// Token: 0x040011D6 RID: 4566
		private static readonly IntPtr NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_byref_Vector3_0;

		// Token: 0x040011D7 RID: 4567
		private static readonly IntPtr NativeMethodInfoPtr_RotateTowards_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_Single_Single_byref_Vector3_0;

		// Token: 0x040011D8 RID: 4568
		[FieldOffset(0)]
		public float x;

		// Token: 0x040011D9 RID: 4569
		[FieldOffset(4)]
		public float y;

		// Token: 0x040011DA RID: 4570
		[FieldOffset(8)]
		public float z;

		// Token: 0x040011DB RID: 4571
		private static readonly Vector3.OrthoNormalize3Delegate OrthoNormalize3DelegateField;

		// Token: 0x0200087B RID: 2171
		// (Invoke) Token: 0x06003989 RID: 14729
		private delegate void OrthoNormalize3Delegate(IntPtr a, IntPtr b, IntPtr c);
	}
}

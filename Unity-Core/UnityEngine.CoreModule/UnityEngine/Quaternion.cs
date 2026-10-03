using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000FA RID: 250
	[StructLayout(2)]
	public struct Quaternion
	{
		// Token: 0x06001440 RID: 5184 RVA: 0x0005A36C File Offset: 0x0005856C
		// Note: this type is marked as 'beforefieldinit'.
		static Quaternion()
		{
			Il2CppClassPointerStore<Quaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Quaternion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quaternion>.NativeClassPtr);
			Quaternion.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "x");
			Quaternion.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "y");
			Quaternion.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "z");
			Quaternion.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "w");
			Quaternion.NativeFieldInfoPtr_identityQuaternion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "identityQuaternion");
			Quaternion.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "kEpsilon");
			Quaternion.NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665380);
			Quaternion.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665381);
			Quaternion.NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665382);
			Quaternion.NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665383);
			Quaternion.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665384);
			Quaternion.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665385);
			Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665386);
			Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665387);
			Quaternion.NativeMethodInfoPtr_Internal_ToAxisAngleRad_Private_Static_Void_Quaternion_byref_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665388);
			Quaternion.NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665389);
			Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665390);
			Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665391);
			Quaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665392);
			Quaternion.NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665393);
			Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665394);
			Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665395);
			Quaternion.NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665396);
			Quaternion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665397);
			Quaternion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665398);
			Quaternion.NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665399);
			Quaternion.NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665400);
			Quaternion.NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665401);
			Quaternion.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665402);
			Quaternion.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665403);
			Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665404);
			Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665405);
			Quaternion.NativeMethodInfoPtr_ToAngleAxis_Public_Void_byref_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665406);
			Quaternion.NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665407);
			Quaternion.NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665408);
			Quaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665409);
			Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665410);
			Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665411);
			Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665412);
			Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665413);
			Quaternion.NativeMethodInfoPtr_FromToRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665415);
			Quaternion.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665416);
			Quaternion.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665417);
			Quaternion.NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665418);
			Quaternion.NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665419);
			Quaternion.NativeMethodInfoPtr_LerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665420);
			Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665421);
			Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665422);
			Quaternion.NativeMethodInfoPtr_Internal_ToAxisAngleRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665423);
			Quaternion.NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665424);
			Quaternion.NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665425);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0005A798 File Offset: 0x00058998
		[CallerCount(72)]
		[CachedScanResults(RefRangeStart = 1243584, RefRangeEnd = 1243656, XrefRangeStart = 1243582, XrefRangeEnd = 1243584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fromDirection;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0005A7E4 File Offset: 0x000589E4
		[CallerCount(156)]
		[CachedScanResults(RefRangeStart = 1243658, RefRangeEnd = 1243814, XrefRangeStart = 1243656, XrefRangeEnd = 1243658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Inverse(Quaternion rotation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0005A824 File Offset: 0x00058A24
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 1243816, RefRangeEnd = 1243861, XrefRangeStart = 1243814, XrefRangeEnd = 1243816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Slerp(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0005A880 File Offset: 0x00058A80
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1243863, RefRangeEnd = 1243872, XrefRangeStart = 1243861, XrefRangeEnd = 1243863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0005A8DC File Offset: 0x00058ADC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 1243874, RefRangeEnd = 1243988, XrefRangeStart = 1243872, XrefRangeEnd = 1243874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Lerp(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0005A938 File Offset: 0x00058B38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1243990, RefRangeEnd = 1243992, XrefRangeStart = 1243988, XrefRangeEnd = 1243990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0005A994 File Offset: 0x00058B94
		[CallerCount(140)]
		[CachedScanResults(RefRangeStart = 1243994, RefRangeEnd = 1244134, XrefRangeStart = 1243992, XrefRangeEnd = 1243994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Internal_FromEulerRad(Vector3 euler)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref euler;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0005A9D4 File Offset: 0x00058BD4
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 1244136, RefRangeEnd = 1244187, XrefRangeStart = 1244134, XrefRangeEnd = 1244136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Internal_ToEulerRad(Quaternion rotation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0005AA14 File Offset: 0x00058C14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1244189, RefRangeEnd = 1244192, XrefRangeStart = 1244187, XrefRangeEnd = 1244189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref q;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToAxisAngleRad_Private_Static_Void_Quaternion_byref_Vector3_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0005AA64 File Offset: 0x00058C64
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 1244194, RefRangeEnd = 1244271, XrefRangeStart = 1244192, XrefRangeEnd = 1244194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0005AAB0 File Offset: 0x00058CB0
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 1244273, RefRangeEnd = 1244371, XrefRangeStart = 1244271, XrefRangeEnd = 1244273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion LookRotation(Vector3 forward, Vector3 upwards)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forward;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upwards;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0005AAFC File Offset: 0x00058CFC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1244375, RefRangeEnd = 1244393, XrefRangeStart = 1244371, XrefRangeEnd = 1244375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion LookRotation(Vector3 forward)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forward;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x0005AB3C File Offset: 0x00058D3C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 450606, RefRangeEnd = 450617, XrefRangeStart = 450606, XrefRangeEnd = 450617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quaternion(float x, float y, float z, float w)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0005AB98 File Offset: 0x00058D98
		public unsafe static Quaternion identity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244393, XrefRangeEnd = 1244395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0005ABC8 File Offset: 0x00058DC8
		[CallerCount(0)]
		public unsafe static Quaternion operator *(Quaternion lhs, Quaternion rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x0005AC14 File Offset: 0x00058E14
		[CallerCount(462)]
		[CachedScanResults(RefRangeStart = 1244395, RefRangeEnd = 1244857, XrefRangeStart = 1244395, XrefRangeEnd = 1244395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x0005AC60 File Offset: 0x00058E60
		[CallerCount(0)]
		public unsafe static bool IsEqualUsingDot(float dot)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x0005ACA0 File Offset: 0x00058EA0
		[CallerCount(0)]
		public unsafe static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x0005ACEC File Offset: 0x00058EEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1244857, RefRangeEnd = 1244859, XrefRangeStart = 1244857, XrefRangeEnd = 1244857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0005AD38 File Offset: 0x00058F38
		[CallerCount(0)]
		public unsafe static float Dot(Quaternion a, Quaternion b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x0005AD84 File Offset: 0x00058F84
		[CallerCount(0)]
		public unsafe static float Angle(Quaternion a, Quaternion b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x0005ADD0 File Offset: 0x00058FD0
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 1244862, RefRangeEnd = 1244913, XrefRangeStart = 1244859, XrefRangeEnd = 1244862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Internal_MakePositive(Vector3 euler)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref euler;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0005AE10 File Offset: 0x00059010
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x0005AE40 File Offset: 0x00059040
		public unsafe Vector3 eulerAngles
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244913, XrefRangeEnd = 1244918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244918, XrefRangeEnd = 1244920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x0005AE74 File Offset: 0x00059074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244920, XrefRangeEnd = 1244922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Euler(float x, float y, float z)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x0005AED0 File Offset: 0x000590D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244922, XrefRangeEnd = 1244924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Euler(Vector3 euler)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref euler;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x0005AF10 File Offset: 0x00059110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244924, XrefRangeEnd = 1244926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToAngleAxis(out float angle, out Vector3 axis)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_ToAngleAxis_Public_Void_byref_Single_byref_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x0005AF50 File Offset: 0x00059150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244926, XrefRangeEnd = 1244930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDegreesDelta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x0005AFAC File Offset: 0x000591AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244930, XrefRangeEnd = 1244934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quaternion Normalize(Quaternion q)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref q;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x0005AFEC File Offset: 0x000591EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244934, XrefRangeEnd = 1244938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0005B01C File Offset: 0x0005921C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244938, XrefRangeEnd = 1244946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x0005B060 File Offset: 0x00059260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Quaternion other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x0005B0A0 File Offset: 0x000592A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244946, XrefRangeEnd = 1244949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x0005B0CC File Offset: 0x000592CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244949, XrefRangeEnd = 1244984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0005B11C File Offset: 0x0005931C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244984, XrefRangeEnd = 1244986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &fromDirection;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &toDirection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_FromToRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x0005B16C File Offset: 0x0005936C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244986, XrefRangeEnd = 1244988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &rotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x0005B1AC File Offset: 0x000593AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244988, XrefRangeEnd = 1244990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x0005B208 File Offset: 0x00059408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244990, XrefRangeEnd = 1244992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x0005B264 File Offset: 0x00059464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244992, XrefRangeEnd = 1244994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x0005B2C0 File Offset: 0x000594C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244994, XrefRangeEnd = 1244996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x0005B31C File Offset: 0x0005951C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244996, XrefRangeEnd = 1244998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &euler;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x0005B35C File Offset: 0x0005955C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1244998, XrefRangeEnd = 1245000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &rotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x0005B39C File Offset: 0x0005959C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245000, XrefRangeEnd = 1245002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ToAxisAngleRad_Injected(ref Quaternion q, out Vector3 axis, out float angle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &q;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_Internal_ToAxisAngleRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x0005B3EC File Offset: 0x000595EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245002, XrefRangeEnd = 1245004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0005B43C File Offset: 0x0005963C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245004, XrefRangeEnd = 1245006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &forward;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &upwards;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quaternion.NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0000AA26 File Offset: 0x00008C26
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, ref this));
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0005B48C File Offset: 0x0005968C
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x0000AA38 File Offset: 0x00008C38
		public unsafe static Quaternion identityQuaternion
		{
			get
			{
				Quaternion result;
				IL2CPP.il2cpp_field_static_get_value(Quaternion.NativeFieldInfoPtr_identityQuaternion, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quaternion.NativeFieldInfoPtr_identityQuaternion, (void*)(&value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0005B4A8 File Offset: 0x000596A8
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x0000AA46 File Offset: 0x00008C46
		public unsafe static float kEpsilon
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quaternion.NativeFieldInfoPtr_kEpsilon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quaternion.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x1700044E RID: 1102
		public float this[int index]
		{
			get
			{
				float result;
				switch (index)
				{
				case 0:
					result = this.x;
					break;
				case 1:
					result = this.y;
					break;
				case 2:
					result = this.z;
					break;
				case 3:
					result = this.w;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
				}
				return result;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.x = value;
					break;
				case 1:
					this.y = value;
					break;
				case 2:
					this.z = value;
					break;
				case 3:
					this.w = value;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid Quaternion index!");
				}
			}
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0000AA54 File Offset: 0x00008C54
		public void Set(float newX, float newY, float newZ, float newW)
		{
			this.x = newX;
			this.y = newY;
			this.z = newZ;
			this.w = newW;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0005B57C File Offset: 0x0005977C
		public void SetLookRotation(Vector3 view)
		{
			Vector3 up = Vector3.up;
			this.SetLookRotation(view, up);
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0000AA74 File Offset: 0x00008C74
		public void SetLookRotation(Vector3 view, Vector3 up)
		{
			this = Quaternion.LookRotation(view, up);
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0000AA84 File Offset: 0x00008C84
		public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			this = Quaternion.FromToRotation(fromDirection, toDirection);
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0000AA94 File Offset: 0x00008C94
		public void Normalize()
		{
			this = Quaternion.Normalize(this);
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0005B59C File Offset: 0x0005979C
		public Quaternion normalized
		{
			get
			{
				return Quaternion.Normalize(this);
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x0005B5BC File Offset: 0x000597BC
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0005B5D8 File Offset: 0x000597D8
		public static Quaternion EulerRotation(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0005B5F8 File Offset: 0x000597F8
		public static Quaternion EulerRotation(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0000AAA8 File Offset: 0x00008CA8
		public void SetEulerRotation(float x, float y, float z)
		{
			this = Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x0000AABE File Offset: 0x00008CBE
		public void SetEulerRotation(Vector3 euler)
		{
			this = Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0005B610 File Offset: 0x00059810
		public Vector3 ToEuler()
		{
			return Quaternion.Internal_ToEulerRad(this);
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0005B630 File Offset: 0x00059830
		public static Quaternion EulerAngles(float x, float y, float z)
		{
			return Quaternion.Internal_FromEulerRad(new Vector3(x, y, z));
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0005B650 File Offset: 0x00059850
		public static Quaternion EulerAngles(Vector3 euler)
		{
			return Quaternion.Internal_FromEulerRad(euler);
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x0000AACD File Offset: 0x00008CCD
		public void ToAxisAngle(out Vector3 axis, out float angle)
		{
			Quaternion.Internal_ToAxisAngleRad(this, out axis, out angle);
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0000AADE File Offset: 0x00008CDE
		public void SetEulerAngles(float x, float y, float z)
		{
			this.SetEulerRotation(new Vector3(x, y, z));
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		public void SetEulerAngles(Vector3 euler)
		{
			this = Quaternion.EulerRotation(euler);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0005B668 File Offset: 0x00059868
		public static Vector3 ToEulerAngles(Quaternion rotation)
		{
			return Quaternion.Internal_ToEulerRad(rotation);
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0005B680 File Offset: 0x00059880
		public Vector3 ToEulerAngles()
		{
			return Quaternion.Internal_ToEulerRad(this);
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0000AAFF File Offset: 0x00008CFF
		public void SetAxisAngle(Vector3 axis, float angle)
		{
			this = Quaternion.AxisAngle(axis, angle);
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0005B6A0 File Offset: 0x000598A0
		public static Quaternion AxisAngle(Vector3 axis, float angle)
		{
			return Quaternion.AngleAxis(57.29578f * angle, axis);
		}

		// Token: 0x040011DC RID: 4572
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040011DD RID: 4573
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040011DE RID: 4574
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x040011DF RID: 4575
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x040011E0 RID: 4576
		private static readonly IntPtr NativeFieldInfoPtr_identityQuaternion;

		// Token: 0x040011E1 RID: 4577
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x040011E2 RID: 4578
		private static readonly IntPtr NativeMethodInfoPtr_FromToRotation_Public_Static_Quaternion_Vector3_Vector3_0;

		// Token: 0x040011E3 RID: 4579
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0;

		// Token: 0x040011E4 RID: 4580
		private static readonly IntPtr NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x040011E5 RID: 4581
		private static readonly IntPtr NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x040011E6 RID: 4582
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x040011E7 RID: 4583
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x040011E8 RID: 4584
		private static readonly IntPtr NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0;

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ToAxisAngleRad_Private_Static_Void_Quaternion_byref_Vector3_byref_Single_0;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_ToAngleAxis_Public_Void_byref_Single_byref_Vector3_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Quaternion_Quaternion_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_FromToRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ToAxisAngleRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_byref_Single_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0;

		// Token: 0x0400120F RID: 4623
		[FieldOffset(0)]
		public float x;

		// Token: 0x04001210 RID: 4624
		[FieldOffset(4)]
		public float y;

		// Token: 0x04001211 RID: 4625
		[FieldOffset(8)]
		public float z;

		// Token: 0x04001212 RID: 4626
		[FieldOffset(12)]
		public float w;
	}
}

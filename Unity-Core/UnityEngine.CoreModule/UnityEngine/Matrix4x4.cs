using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F8 RID: 248
	[StructLayout(2)]
	public struct Matrix4x4
	{
		// Token: 0x06001397 RID: 5015 RVA: 0x0005738C File Offset: 0x0005558C
		// Note: this type is marked as 'beforefieldinit'.
		static Matrix4x4()
		{
			Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Matrix4x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr);
			Matrix4x4.NativeFieldInfoPtr_m00 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m00");
			Matrix4x4.NativeFieldInfoPtr_m10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m10");
			Matrix4x4.NativeFieldInfoPtr_m20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m20");
			Matrix4x4.NativeFieldInfoPtr_m30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m30");
			Matrix4x4.NativeFieldInfoPtr_m01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m01");
			Matrix4x4.NativeFieldInfoPtr_m11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m11");
			Matrix4x4.NativeFieldInfoPtr_m21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m21");
			Matrix4x4.NativeFieldInfoPtr_m31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m31");
			Matrix4x4.NativeFieldInfoPtr_m02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m02");
			Matrix4x4.NativeFieldInfoPtr_m12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m12");
			Matrix4x4.NativeFieldInfoPtr_m22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m22");
			Matrix4x4.NativeFieldInfoPtr_m32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m32");
			Matrix4x4.NativeFieldInfoPtr_m03 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m03");
			Matrix4x4.NativeFieldInfoPtr_m13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m13");
			Matrix4x4.NativeFieldInfoPtr_m23 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m23");
			Matrix4x4.NativeFieldInfoPtr_m33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "m33");
			Matrix4x4.NativeFieldInfoPtr_zeroMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "zeroMatrix");
			Matrix4x4.NativeFieldInfoPtr_identityMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, "identityMatrix");
			Matrix4x4.NativeMethodInfoPtr_IsIdentity_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665270);
			Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Private_FrustumPlanes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665271);
			Matrix4x4.NativeMethodInfoPtr_get_isIdentity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665272);
			Matrix4x4.NativeMethodInfoPtr_get_decomposeProjection_Public_get_FrustumPlanes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665273);
			Matrix4x4.NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665274);
			Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665275);
			Matrix4x4.NativeMethodInfoPtr_Inverse_Public_Static_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665276);
			Matrix4x4.NativeMethodInfoPtr_get_inverse_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665277);
			Matrix4x4.NativeMethodInfoPtr_Transpose_Public_Static_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665278);
			Matrix4x4.NativeMethodInfoPtr_get_transpose_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665279);
			Matrix4x4.NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665280);
			Matrix4x4.NativeMethodInfoPtr_Perspective_Public_Static_Matrix4x4_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665281);
			Matrix4x4.NativeMethodInfoPtr_LookAt_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665282);
			Matrix4x4.NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665283);
			Matrix4x4.NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_FrustumPlanes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665284);
			Matrix4x4.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665285);
			Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665286);
			Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665287);
			Matrix4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665288);
			Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665289);
			Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665290);
			Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665291);
			Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Matrix4x4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665292);
			Matrix4x4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665293);
			Matrix4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665294);
			Matrix4x4.NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665295);
			Matrix4x4.NativeMethodInfoPtr_GetRow_Public_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665296);
			Matrix4x4.NativeMethodInfoPtr_SetColumn_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665297);
			Matrix4x4.NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665298);
			Matrix4x4.NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665299);
			Matrix4x4.NativeMethodInfoPtr_MultiplyVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665300);
			Matrix4x4.NativeMethodInfoPtr_Scale_Public_Static_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665301);
			Matrix4x4.NativeMethodInfoPtr_Translate_Public_Static_Matrix4x4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665302);
			Matrix4x4.NativeMethodInfoPtr_Rotate_Public_Static_Matrix4x4_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665303);
			Matrix4x4.NativeMethodInfoPtr_get_zero_Public_Static_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665304);
			Matrix4x4.NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665305);
			Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665306);
			Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665307);
			Matrix4x4.NativeMethodInfoPtr_IsIdentity_Injected_Private_Static_Boolean_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665309);
			Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Injected_Private_Static_Void_byref_Matrix4x4_byref_FrustumPlanes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665310);
			Matrix4x4.NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665311);
			Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665312);
			Matrix4x4.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665313);
			Matrix4x4.NativeMethodInfoPtr_Transpose_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665314);
			Matrix4x4.NativeMethodInfoPtr_Ortho_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665315);
			Matrix4x4.NativeMethodInfoPtr_Perspective_Injected_Private_Static_Void_Single_Single_Single_Single_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665316);
			Matrix4x4.NativeMethodInfoPtr_LookAt_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665317);
			Matrix4x4.NativeMethodInfoPtr_Frustum_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, 100665318);
			Matrix4x4.GetRotation_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.GetRotation_InjectedDelegate>("UnityEngine.Matrix4x4::GetRotation_Injected");
			Matrix4x4.GetLossyScale_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.GetLossyScale_InjectedDelegate>("UnityEngine.Matrix4x4::GetLossyScale_Injected");
			Matrix4x4.GetDeterminant_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.GetDeterminant_InjectedDelegate>("UnityEngine.Matrix4x4::GetDeterminant_Injected");
			Matrix4x4.ValidTRS_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.ValidTRS_InjectedDelegate>("UnityEngine.Matrix4x4::ValidTRS_Injected");
			Matrix4x4.CompareApproximately_InjectedDelegateField = IL2CPP.ResolveICall<Matrix4x4.CompareApproximately_InjectedDelegate>("UnityEngine.Matrix4x4::CompareApproximately_Injected");
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00057930 File Offset: 0x00055B30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1242551, RefRangeEnd = 1242554, XrefRangeStart = 1242549, XrefRangeEnd = 1242551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIdentity()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_IsIdentity_Private_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00057960 File Offset: 0x00055B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242554, XrefRangeEnd = 1242556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrustumPlanes DecomposeProjection()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Private_FrustumPlanes_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00057990 File Offset: 0x00055B90
		public unsafe bool isIdentity
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1242551, RefRangeEnd = 1242554, XrefRangeStart = 1242551, XrefRangeEnd = 1242554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_isIdentity_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x000579C0 File Offset: 0x00055BC0
		public unsafe FrustumPlanes decomposeProjection
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1242558, RefRangeEnd = 1242561, XrefRangeStart = 1242556, XrefRangeEnd = 1242558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_decomposeProjection_Public_get_FrustumPlanes_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x000579F0 File Offset: 0x00055BF0
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 1242563, RefRangeEnd = 1242618, XrefRangeStart = 1242561, XrefRangeEnd = 1242563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00057A4C File Offset: 0x00055C4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1242620, RefRangeEnd = 1242622, XrefRangeStart = 1242618, XrefRangeEnd = 1242620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref input;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00057A98 File Offset: 0x00055C98
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1242624, RefRangeEnd = 1242640, XrefRangeStart = 1242622, XrefRangeEnd = 1242624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Inverse(Matrix4x4 m)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse_Public_Static_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x00057AD8 File Offset: 0x00055CD8
		public unsafe Matrix4x4 inverse
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 1242642, RefRangeEnd = 1242668, XrefRangeStart = 1242640, XrefRangeEnd = 1242642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_inverse_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00057B08 File Offset: 0x00055D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242668, XrefRangeEnd = 1242670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Transpose(Matrix4x4 m)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Transpose_Public_Static_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060013A1 RID: 5025 RVA: 0x00057B48 File Offset: 0x00055D48
		public unsafe Matrix4x4 transpose
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1242672, RefRangeEnd = 1242673, XrefRangeStart = 1242670, XrefRangeEnd = 1242672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_transpose_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00057B78 File Offset: 0x00055D78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1242675, RefRangeEnd = 1242678, XrefRangeStart = 1242673, XrefRangeEnd = 1242675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00057BFC File Offset: 0x00055DFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1242680, RefRangeEnd = 1242682, XrefRangeStart = 1242678, XrefRangeEnd = 1242680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fov;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aspect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Perspective_Public_Static_Matrix4x4_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00057C64 File Offset: 0x00055E64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1242684, RefRangeEnd = 1242686, XrefRangeStart = 1242682, XrefRangeEnd = 1242684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 LookAt(Vector3 from, Vector3 to, Vector3 up)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref up;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_LookAt_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00057CC0 File Offset: 0x00055EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242686, XrefRangeEnd = 1242688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00057D44 File Offset: 0x00055F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1242690, RefRangeEnd = 1242691, XrefRangeStart = 1242688, XrefRangeEnd = 1242690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Frustum(FrustumPlanes fp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_FrustumPlanes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00057D84 File Offset: 0x00055F84
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1242691, RefRangeEnd = 1242695, XrefRangeStart = 1242691, XrefRangeEnd = 1242691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref column0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000428 RID: 1064
		public unsafe int this[int row, int column]
		{
			get
			{
				return this[row + column * 4];
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242695, XrefRangeEnd = 1242696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref row;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000429 RID: 1065
		public unsafe int this[int index]
		{
			get
			{
				float result;
				switch (index)
				{
				case 0:
					result = this.m00;
					break;
				case 1:
					result = this.m10;
					break;
				case 2:
					result = this.m20;
					break;
				case 3:
					result = this.m30;
					break;
				case 4:
					result = this.m01;
					break;
				case 5:
					result = this.m11;
					break;
				case 6:
					result = this.m21;
					break;
				case 7:
					result = this.m31;
					break;
				case 8:
					result = this.m02;
					break;
				case 9:
					result = this.m12;
					break;
				case 10:
					result = this.m22;
					break;
				case 11:
					result = this.m32;
					break;
				case 12:
					result = this.m03;
					break;
				case 13:
					result = this.m13;
					break;
				case 14:
					result = this.m23;
					break;
				case 15:
					result = this.m33;
					break;
				default:
					throw new IndexOutOfRangeException("Invalid matrix index!");
				}
				return result;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1242696, RefRangeEnd = 1242702, XrefRangeStart = 1242696, XrefRangeEnd = 1242696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00057E70 File Offset: 0x00056070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242702, XrefRangeEnd = 1242718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00057EA0 File Offset: 0x000560A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242718, XrefRangeEnd = 1242722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00057EE4 File Offset: 0x000560E4
		[CallerCount(0)]
		public unsafe bool Equals(Matrix4x4 other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00057F24 File Offset: 0x00056124
		[CallerCount(78)]
		[CachedScanResults(RefRangeStart = 1242722, RefRangeEnd = 1242800, XrefRangeStart = 1242722, XrefRangeEnd = 1242722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00057F70 File Offset: 0x00056170
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1242800, RefRangeEnd = 1242810, XrefRangeStart = 1242800, XrefRangeEnd = 1242800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 operator *(Matrix4x4 lhs, Vector4 vector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Matrix4x4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00057FBC File Offset: 0x000561BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1242810, RefRangeEnd = 1242814, XrefRangeStart = 1242810, XrefRangeEnd = 1242810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00058008 File Offset: 0x00056208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242814, XrefRangeEnd = 1242815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00058054 File Offset: 0x00056254
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1242815, RefRangeEnd = 1242839, XrefRangeStart = 1242815, XrefRangeEnd = 1242815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetColumn(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00058094 File Offset: 0x00056294
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1242839, RefRangeEnd = 1242845, XrefRangeStart = 1242839, XrefRangeEnd = 1242839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetRow(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_GetRow_Public_Vector4_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x000580D4 File Offset: 0x000562D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1242849, RefRangeEnd = 1242854, XrefRangeStart = 1242845, XrefRangeEnd = 1242849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColumn(int index, Vector4 column)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_SetColumn_Public_Void_Int32_Vector4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x00058114 File Offset: 0x00056314
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1242854, RefRangeEnd = 1242866, XrefRangeStart = 1242854, XrefRangeEnd = 1242854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 MultiplyPoint(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x00058154 File Offset: 0x00056354
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 1242866, RefRangeEnd = 1242971, XrefRangeStart = 1242866, XrefRangeEnd = 1242866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 MultiplyPoint3x4(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00058194 File Offset: 0x00056394
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1242971, RefRangeEnd = 1242996, XrefRangeStart = 1242971, XrefRangeEnd = 1242971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 MultiplyVector(Vector3 vector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_MultiplyVector_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x000581D4 File Offset: 0x000563D4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1242996, RefRangeEnd = 1243011, XrefRangeStart = 1242996, XrefRangeEnd = 1242996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Scale(Vector3 vector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Scale_Public_Static_Matrix4x4_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00058214 File Offset: 0x00056414
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1243011, RefRangeEnd = 1243016, XrefRangeStart = 1243011, XrefRangeEnd = 1243011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Translate(Vector3 vector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Translate_Public_Static_Matrix4x4_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00058254 File Offset: 0x00056454
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1243016, RefRangeEnd = 1243024, XrefRangeStart = 1243016, XrefRangeEnd = 1243016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 Rotate(Quaternion q)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref q;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Rotate_Public_Static_Matrix4x4_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x00058294 File Offset: 0x00056494
		public unsafe static Matrix4x4 zero
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1243026, RefRangeEnd = 1243027, XrefRangeStart = 1243024, XrefRangeEnd = 1243026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_zero_Public_Static_get_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x000582C4 File Offset: 0x000564C4
		public unsafe static Matrix4x4 identity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243027, XrefRangeEnd = 1243029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x000582F4 File Offset: 0x000564F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243029, XrefRangeEnd = 1243030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x00058320 File Offset: 0x00056520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243030, XrefRangeEnd = 1243125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x00058370 File Offset: 0x00056570
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1242551, RefRangeEnd = 1242554, XrefRangeStart = 1242551, XrefRangeEnd = 1242554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsIdentity_Injected(ref Matrix4x4 _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_IsIdentity_Injected_Private_Static_Boolean_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x000583B0 File Offset: 0x000565B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243125, XrefRangeEnd = 1243127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_DecomposeProjection_Injected_Private_Static_Void_byref_Matrix4x4_byref_FrustumPlanes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x000583F0 File Offset: 0x000565F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243127, XrefRangeEnd = 1243129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &q;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x0005844C File Offset: 0x0005664C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243129, XrefRangeEnd = 1243131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &input;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x00058498 File Offset: 0x00056698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243131, XrefRangeEnd = 1243133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &m;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x000584D8 File Offset: 0x000566D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243133, XrefRangeEnd = 1243135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &m;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Transpose_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00058518 File Offset: 0x00056718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243135, XrefRangeEnd = 1243137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Ortho_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x000585A0 File Offset: 0x000567A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243137, XrefRangeEnd = 1243139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fov;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aspect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Perspective_Injected_Private_Static_Void_Single_Single_Single_Single_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x0005860C File Offset: 0x0005680C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243139, XrefRangeEnd = 1243141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LookAt_Injected(ref Vector3 from, ref Vector3 to, ref Vector3 up, out Matrix4x4 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &from;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &up;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_LookAt_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00058668 File Offset: 0x00056868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243141, XrefRangeEnd = 1243143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bottom;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zNear;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zFar;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Matrix4x4.NativeMethodInfoPtr_Frustum_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0000A872 File Offset: 0x00008A72
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Matrix4x4>.NativeClassPtr, ref this));
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x000586F0 File Offset: 0x000568F0
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x0000A884 File Offset: 0x00008A84
		public unsafe static Matrix4x4 zeroMatrix
		{
			get
			{
				Matrix4x4 result;
				IL2CPP.il2cpp_field_static_get_value(Matrix4x4.NativeFieldInfoPtr_zeroMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Matrix4x4.NativeFieldInfoPtr_zeroMatrix, (void*)(&value));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x0005870C File Offset: 0x0005690C
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x0000A892 File Offset: 0x00008A92
		public unsafe static Matrix4x4 identityMatrix
		{
			get
			{
				Matrix4x4 result;
				IL2CPP.il2cpp_field_static_get_value(Matrix4x4.NativeFieldInfoPtr_identityMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Matrix4x4.NativeFieldInfoPtr_identityMatrix, (void*)(&value));
			}
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00058728 File Offset: 0x00056928
		public Quaternion GetRotation()
		{
			Quaternion result;
			Matrix4x4.GetRotation_Injected(ref this, out result);
			return result;
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00058740 File Offset: 0x00056940
		public Vector3 GetLossyScale()
		{
			Vector3 result;
			Matrix4x4.GetLossyScale_Injected(ref this, out result);
			return result;
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0000A8A0 File Offset: 0x00008AA0
		public float GetDeterminant()
		{
			return Matrix4x4.GetDeterminant_Injected(ref this);
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x00058758 File Offset: 0x00056958
		public Quaternion rotation
		{
			get
			{
				return this.GetRotation();
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00058770 File Offset: 0x00056970
		public Vector3 lossyScale
		{
			get
			{
				return this.GetLossyScale();
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x00058788 File Offset: 0x00056988
		public float determinant
		{
			get
			{
				return this.GetDeterminant();
			}
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		public bool ValidTRS()
		{
			return Matrix4x4.ValidTRS_Injected(ref this);
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x000587A0 File Offset: 0x000569A0
		public static float Determinant(Matrix4x4 m)
		{
			return m.determinant;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0000A8B0 File Offset: 0x00008AB0
		public void SetTRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			this = Matrix4x4.TRS(pos, q, s);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0000A8C1 File Offset: 0x00008AC1
		public static bool CompareApproximately(Matrix4x4 a, Matrix4x4 b, float threshold)
		{
			return Matrix4x4.CompareApproximately_Injected(ref a, ref b, threshold);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x000588E0 File Offset: 0x00056AE0
		public Vector3 GetPosition()
		{
			return new Vector3(this.m03, this.m13, this.m23);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0000A8CD File Offset: 0x00008ACD
		public void SetRow(int index, Vector4 row)
		{
			this[index, 0] = row.x;
			this[index, 1] = row.y;
			this[index, 2] = row.z;
			this[index, 3] = row.w;
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0005890C File Offset: 0x00056B0C
		public Plane TransformPlane(Plane plane)
		{
			Matrix4x4 inverse = this.inverse;
			float x = plane.normal.x;
			float y = plane.normal.y;
			float z = plane.normal.z;
			float distance = plane.distance;
			float x2 = inverse.m00 * x + inverse.m10 * y + inverse.m20 * z + inverse.m30 * distance;
			float y2 = inverse.m01 * x + inverse.m11 * y + inverse.m21 * z + inverse.m31 * distance;
			float z2 = inverse.m02 * x + inverse.m12 * y + inverse.m22 * z + inverse.m32 * distance;
			float d = inverse.m03 * x + inverse.m13 * y + inverse.m23 * z + inverse.m33 * distance;
			return new Plane(new Vector3(x2, y2, z2), d);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00058A04 File Offset: 0x00056C04
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0000A90C File Offset: 0x00008B0C
		public static void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret)
		{
			Matrix4x4.GetRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0000A91A File Offset: 0x00008B1A
		public static void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret)
		{
			Matrix4x4.GetLossyScale_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0000A928 File Offset: 0x00008B28
		public static float GetDeterminant_Injected(ref Matrix4x4 _unity_self)
		{
			return Matrix4x4.GetDeterminant_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0000A935 File Offset: 0x00008B35
		public static bool ValidTRS_Injected(ref Matrix4x4 _unity_self)
		{
			return Matrix4x4.ValidTRS_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0000A942 File Offset: 0x00008B42
		public static bool CompareApproximately_Injected(ref Matrix4x4 a, ref Matrix4x4 b, float threshold)
		{
			return Matrix4x4.CompareApproximately_InjectedDelegateField(ref a, ref b, threshold);
		}

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeFieldInfoPtr_m00;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeFieldInfoPtr_m10;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeFieldInfoPtr_m20;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeFieldInfoPtr_m30;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeFieldInfoPtr_m01;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeFieldInfoPtr_m11;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeFieldInfoPtr_m21;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeFieldInfoPtr_m31;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeFieldInfoPtr_m02;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeFieldInfoPtr_m12;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeFieldInfoPtr_m22;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeFieldInfoPtr_m32;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeFieldInfoPtr_m03;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeFieldInfoPtr_m13;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeFieldInfoPtr_m23;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeFieldInfoPtr_m33;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeFieldInfoPtr_zeroMatrix;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeFieldInfoPtr_identityMatrix;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_IsIdentity_Private_Boolean_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_DecomposeProjection_Private_FrustumPlanes_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_get_isIdentity_Public_get_Boolean_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_get_decomposeProjection_Public_get_FrustumPlanes_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_TRS_Public_Static_Matrix4x4_Vector3_Quaternion_Vector3_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_Inverse3DAffine_Public_Static_Boolean_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Public_Static_Matrix4x4_Matrix4x4_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_get_inverse_Public_get_Matrix4x4_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_Transpose_Public_Static_Matrix4x4_Matrix4x4_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_get_transpose_Public_get_Matrix4x4_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_Ortho_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_Perspective_Public_Static_Matrix4x4_Single_Single_Single_Single_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Static_Matrix4x4_Vector3_Vector3_Vector3_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_Frustum_Public_Static_Matrix4x4_FrustumPlanes_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Vector4_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Matrix4x4_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Matrix4x4_Matrix4x4_Matrix4x4_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Matrix4x4_Vector4_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Matrix4x4_Matrix4x4_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_GetColumn_Public_Vector4_Int32_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_GetRow_Public_Vector4_Int32_0;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_SetColumn_Public_Void_Int32_Vector4_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyPoint_Public_Vector3_Vector3_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyPoint3x4_Public_Vector3_Vector3_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_MultiplyVector_Public_Vector3_Vector3_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_Matrix4x4_Vector3_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Static_Matrix4x4_Vector3_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Static_Matrix4x4_Quaternion_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Matrix4x4_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_get_identity_Public_Static_get_Matrix4x4_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_IsIdentity_Injected_Private_Static_Boolean_byref_Matrix4x4_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_DecomposeProjection_Injected_Private_Static_Void_byref_Matrix4x4_byref_FrustumPlanes_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_TRS_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_byref_Vector3_byref_Matrix4x4_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_Inverse3DAffine_Injected_Private_Static_Boolean_byref_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_Transpose_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_Ortho_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_Perspective_Injected_Private_Static_Void_Single_Single_Single_Single_byref_Matrix4x4_0;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Vector3_byref_Matrix4x4_0;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeMethodInfoPtr_Frustum_Injected_Private_Static_Void_Single_Single_Single_Single_Single_Single_byref_Matrix4x4_0;

		// Token: 0x04001178 RID: 4472
		[FieldOffset(0)]
		public float m00;

		// Token: 0x04001179 RID: 4473
		[FieldOffset(4)]
		public float m10;

		// Token: 0x0400117A RID: 4474
		[FieldOffset(8)]
		public float m20;

		// Token: 0x0400117B RID: 4475
		[FieldOffset(12)]
		public float m30;

		// Token: 0x0400117C RID: 4476
		[FieldOffset(16)]
		public float m01;

		// Token: 0x0400117D RID: 4477
		[FieldOffset(20)]
		public float m11;

		// Token: 0x0400117E RID: 4478
		[FieldOffset(24)]
		public float m21;

		// Token: 0x0400117F RID: 4479
		[FieldOffset(28)]
		public float m31;

		// Token: 0x04001180 RID: 4480
		[FieldOffset(32)]
		public float m02;

		// Token: 0x04001181 RID: 4481
		[FieldOffset(36)]
		public float m12;

		// Token: 0x04001182 RID: 4482
		[FieldOffset(40)]
		public float m22;

		// Token: 0x04001183 RID: 4483
		[FieldOffset(44)]
		public float m32;

		// Token: 0x04001184 RID: 4484
		[FieldOffset(48)]
		public float m03;

		// Token: 0x04001185 RID: 4485
		[FieldOffset(52)]
		public float m13;

		// Token: 0x04001186 RID: 4486
		[FieldOffset(56)]
		public float m23;

		// Token: 0x04001187 RID: 4487
		[FieldOffset(60)]
		public float m33;

		// Token: 0x04001188 RID: 4488
		private static readonly Matrix4x4.GetRotation_InjectedDelegate GetRotation_InjectedDelegateField;

		// Token: 0x04001189 RID: 4489
		private static readonly Matrix4x4.GetLossyScale_InjectedDelegate GetLossyScale_InjectedDelegateField;

		// Token: 0x0400118A RID: 4490
		private static readonly Matrix4x4.GetDeterminant_InjectedDelegate GetDeterminant_InjectedDelegateField;

		// Token: 0x0400118B RID: 4491
		private static readonly Matrix4x4.ValidTRS_InjectedDelegate ValidTRS_InjectedDelegateField;

		// Token: 0x0400118C RID: 4492
		private static readonly Matrix4x4.CompareApproximately_InjectedDelegate CompareApproximately_InjectedDelegateField;

		// Token: 0x02000876 RID: 2166
		// (Invoke) Token: 0x0600397F RID: 14719
		private delegate void GetRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000877 RID: 2167
		// (Invoke) Token: 0x06003981 RID: 14721
		private delegate void GetLossyScale_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x02000878 RID: 2168
		// (Invoke) Token: 0x06003983 RID: 14723
		private delegate float GetDeterminant_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000879 RID: 2169
		// (Invoke) Token: 0x06003985 RID: 14725
		private delegate bool ValidTRS_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x0200087A RID: 2170
		// (Invoke) Token: 0x06003987 RID: 14727
		private delegate bool CompareApproximately_InjectedDelegate(IntPtr a, IntPtr b, float threshold);
	}
}

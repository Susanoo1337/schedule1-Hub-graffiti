using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F1 RID: 241
	[StructLayout(2)]
	public struct Color
	{
		// Token: 0x06001337 RID: 4919 RVA: 0x00055700 File Offset: 0x00053900
		// Note: this type is marked as 'beforefieldinit'.
		static Color()
		{
			Il2CppClassPointerStore<Color>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Color");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Color>.NativeClassPtr);
			Color.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "r");
			Color.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "g");
			Color.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "b");
			Color.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, "a");
			Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665206);
			Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665207);
			Color.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665208);
			Color.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665209);
			Color.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665210);
			Color.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665211);
			Color.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665212);
			Color.NativeMethodInfoPtr_op_Addition_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665213);
			Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665214);
			Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665215);
			Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665216);
			Color.NativeMethodInfoPtr_op_Division_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665217);
			Color.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665218);
			Color.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665219);
			Color.NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665220);
			Color.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665221);
			Color.NativeMethodInfoPtr_RGBMultiplied_Internal_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665222);
			Color.NativeMethodInfoPtr_get_red_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665223);
			Color.NativeMethodInfoPtr_get_green_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665224);
			Color.NativeMethodInfoPtr_get_blue_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665225);
			Color.NativeMethodInfoPtr_get_white_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665226);
			Color.NativeMethodInfoPtr_get_black_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665227);
			Color.NativeMethodInfoPtr_get_yellow_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665228);
			Color.NativeMethodInfoPtr_get_cyan_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665229);
			Color.NativeMethodInfoPtr_get_magenta_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665230);
			Color.NativeMethodInfoPtr_get_gray_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665231);
			Color.NativeMethodInfoPtr_get_grey_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665232);
			Color.NativeMethodInfoPtr_get_clear_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665233);
			Color.NativeMethodInfoPtr_get_grayscale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665234);
			Color.NativeMethodInfoPtr_get_linear_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665235);
			Color.NativeMethodInfoPtr_get_gamma_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665236);
			Color.NativeMethodInfoPtr_get_maxColorComponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665237);
			Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665238);
			Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665239);
			Color.NativeMethodInfoPtr_RGBToHSV_Public_Static_Void_Color_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665240);
			Color.NativeMethodInfoPtr_RGBToHSVHelper_Private_Static_Void_Single_Single_Single_Single_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665241);
			Color.NativeMethodInfoPtr_HSVToRGB_Public_Static_Color_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665242);
			Color.NativeMethodInfoPtr_HSVToRGB_Public_Static_Color_Single_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100665243);
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00055A78 File Offset: 0x00053C78
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 450606, RefRangeEnd = 450617, XrefRangeStart = 450606, XrefRangeEnd = 450617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color(float r, float g, float b, float a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref r;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00055AD4 File Offset: 0x00053CD4
		[CallerCount(0)]
		public unsafe Color(float r, float g, float b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref r;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00055B24 File Offset: 0x00053D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242067, XrefRangeEnd = 1242068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00055B50 File Offset: 0x00053D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242068, XrefRangeEnd = 1242103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00055BA0 File Offset: 0x00053DA0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1242107, RefRangeEnd = 1242125, XrefRangeStart = 1242103, XrefRangeEnd = 1242107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00055BD0 File Offset: 0x00053DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242125, XrefRangeEnd = 1242133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00055C14 File Offset: 0x00053E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242133, XrefRangeEnd = 1242137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Color other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00055C54 File Offset: 0x00053E54
		[CallerCount(0)]
		public unsafe static Color operator +(Color a, Color b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Addition_Public_Static_Color_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00055CA0 File Offset: 0x00053EA0
		[CallerCount(0)]
		public unsafe static Color operator *(Color a, Color b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00055CEC File Offset: 0x00053EEC
		[CallerCount(0)]
		public unsafe static Color operator *(Color a, float b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00055D38 File Offset: 0x00053F38
		[CallerCount(0)]
		public unsafe static Color operator *(float b, Color a)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref b;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Single_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00055D84 File Offset: 0x00053F84
		[CallerCount(0)]
		public unsafe static Color operator /(Color a, float b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Division_Public_Static_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00055DD0 File Offset: 0x00053FD0
		[CallerCount(0)]
		public unsafe static bool operator ==(Color lhs, Color rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00055E1C File Offset: 0x0005401C
		[CallerCount(0)]
		public unsafe static bool operator !=(Color lhs, Color rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00055E68 File Offset: 0x00054068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242137, XrefRangeEnd = 1242138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color Lerp(Color a, Color b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00055EC4 File Offset: 0x000540C4
		[CallerCount(0)]
		public unsafe static Color LerpUnclamped(Color a, Color b, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Color_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00055F20 File Offset: 0x00054120
		[CallerCount(0)]
		public unsafe Color RGBMultiplied(float multiplier)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_RGBMultiplied_Internal_Color_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x00055F60 File Offset: 0x00054160
		public unsafe static Color red
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_red_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x00055F90 File Offset: 0x00054190
		public unsafe static Color green
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_green_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x00055FC0 File Offset: 0x000541C0
		public unsafe static Color blue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_blue_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00055FF0 File Offset: 0x000541F0
		public unsafe static Color white
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1242138, RefRangeEnd = 1242139, XrefRangeStart = 1242138, XrefRangeEnd = 1242138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_white_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x00056020 File Offset: 0x00054220
		public unsafe static Color black
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_black_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x00056050 File Offset: 0x00054250
		public unsafe static Color yellow
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_yellow_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x00056080 File Offset: 0x00054280
		public unsafe static Color cyan
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_cyan_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x000560B0 File Offset: 0x000542B0
		public unsafe static Color magenta
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_magenta_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x000560E0 File Offset: 0x000542E0
		public unsafe static Color gray
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_gray_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x00056110 File Offset: 0x00054310
		public unsafe static Color grey
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_grey_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x00056140 File Offset: 0x00054340
		public unsafe static Color clear
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 1232935, RefRangeEnd = 1232971, XrefRangeStart = 1232935, XrefRangeEnd = 1232971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_clear_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x00056170 File Offset: 0x00054370
		public unsafe float grayscale
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_grayscale_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x000561A0 File Offset: 0x000543A0
		public unsafe Color linear
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242139, XrefRangeEnd = 1242145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_linear_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x000561D0 File Offset: 0x000543D0
		public unsafe Color gamma
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242145, XrefRangeEnd = 1242151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_gamma_Public_get_Color_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00056200 File Offset: 0x00054400
		public unsafe float maxColorComponent
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_maxColorComponent_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00056230 File Offset: 0x00054430
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1096018, RefRangeEnd = 1096030, XrefRangeStart = 1096018, XrefRangeEnd = 1096030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector4(Color c)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00056270 File Offset: 0x00054470
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1096018, RefRangeEnd = 1096030, XrefRangeStart = 1096018, XrefRangeEnd = 1096030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Color(Vector4 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x000562B0 File Offset: 0x000544B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1242154, RefRangeEnd = 1242157, XrefRangeStart = 1242151, XrefRangeEnd = 1242154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RGBToHSV(Color rgbColor, out float H, out float S, out float V)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rgbColor;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &H;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &S;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &V;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_RGBToHSV_Public_Static_Void_Color_byref_Single_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x0005630C File Offset: 0x0005450C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1242157, RefRangeEnd = 1242158, XrefRangeStart = 1242157, XrefRangeEnd = 1242157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, out float H, out float S, out float V)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offset;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dominantcolor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colorone;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colortwo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &H;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &S;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &V;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_RGBToHSVHelper_Private_Static_Void_Single_Single_Single_Single_byref_Single_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00056398 File Offset: 0x00054598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242158, XrefRangeEnd = 1242159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color HSVToRGB(float H, float S, float V)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref H;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref S;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref V;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_HSVToRGB_Public_Static_Color_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000563F4 File Offset: 0x000545F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1242160, RefRangeEnd = 1242166, XrefRangeStart = 1242159, XrefRangeEnd = 1242160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color HSVToRGB(float H, float S, float V, bool hdr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref H;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref S;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref V;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_HSVToRGB_Public_Static_Color_Single_Single_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0000A789 File Offset: 0x00008989
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Color>.NativeClassPtr, ref this));
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0005645C File Offset: 0x0005465C
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00056478 File Offset: 0x00054678
		public static Color operator -(Color a, Color b)
		{
			return new Color(a.r - b.r, a.g - b.g, a.b - b.b, a.a - b.a);
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x000564C4 File Offset: 0x000546C4
		public Color AlphaMultiplied(float multiplier)
		{
			return new Color(this.r, this.g, this.b, this.a * multiplier);
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x000564F8 File Offset: 0x000546F8
		public Color RGBMultiplied(Color multiplier)
		{
			return new Color(this.r * multiplier.r, this.g * multiplier.g, this.b * multiplier.b, this.a);
		}

		// Token: 0x1700041B RID: 1051
		public float this[int index]
		{
			get
			{
				float result;
				switch (index)
				{
				case 0:
					result = this.r;
					break;
				case 1:
					result = this.g;
					break;
				case 2:
					result = this.b;
					break;
				case 3:
					result = this.a;
					break;
				default:
					throw new IndexOutOfRangeException(String.Concat("Invalid Color index(", index.ToString(), ")!"));
				}
				return result;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.r = value;
					break;
				case 1:
					this.g = value;
					break;
				case 2:
					this.b = value;
					break;
				case 3:
					this.a = value;
					break;
				default:
					throw new IndexOutOfRangeException(String.Concat("Invalid Color index(", index.ToString(), ")!"));
				}
			}
		}

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeFieldInfoPtr_r;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeFieldInfoPtr_g;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeFieldInfoPtr_b;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeFieldInfoPtr_a;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Color_Color_Color_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Color_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Single_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Single_Color_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Color_Color_Single_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Color_Color_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Color_Color_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Color_Color_Color_Single_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_RGBMultiplied_Internal_Color_Single_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_get_red_Public_Static_get_Color_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_get_green_Public_Static_get_Color_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_get_blue_Public_Static_get_Color_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_get_white_Public_Static_get_Color_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_get_black_Public_Static_get_Color_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_get_yellow_Public_Static_get_Color_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_get_cyan_Public_Static_get_Color_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr_get_magenta_Public_Static_get_Color_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_get_gray_Public_Static_get_Color_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_get_grey_Public_Static_get_Color_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_get_clear_Public_Static_get_Color_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_get_grayscale_Public_get_Single_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_get_linear_Public_get_Color_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_get_gamma_Public_get_Color_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_get_maxColorComponent_Public_get_Single_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Color_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Vector4_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_RGBToHSV_Public_Static_Void_Color_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_RGBToHSVHelper_Private_Static_Void_Single_Single_Single_Single_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_HSVToRGB_Public_Static_Color_Single_Single_Single_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_HSVToRGB_Public_Static_Color_Single_Single_Single_Boolean_0;

		// Token: 0x040010F4 RID: 4340
		[FieldOffset(0)]
		public float r;

		// Token: 0x040010F5 RID: 4341
		[FieldOffset(4)]
		public float g;

		// Token: 0x040010F6 RID: 4342
		[FieldOffset(8)]
		public float b;

		// Token: 0x040010F7 RID: 4343
		[FieldOffset(12)]
		public float a;
	}
}

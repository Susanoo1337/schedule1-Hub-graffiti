using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200016A RID: 362
	public static class UINumericFieldsUtils : Object
	{
		// Token: 0x06001B92 RID: 7058 RVA: 0x00072CCC File Offset: 0x00070ECC
		// Note: this type is marked as 'beforefieldinit'.
		static UINumericFieldsUtils()
		{
			Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UINumericFieldsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr);
			UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_AllowedCharactersForFloat");
			UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_AllowedCharactersForInt");
			UINumericFieldsUtils.NativeFieldInfoPtr_k_DoubleFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_DoubleFieldFormatString");
			UINumericFieldsUtils.NativeFieldInfoPtr_k_FloatFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_FloatFieldFormatString");
			UINumericFieldsUtils.NativeFieldInfoPtr_k_IntFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_IntFieldFormatString");
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666241);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666242);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666243);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666244);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666245);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666246);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666247);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666248);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100666249);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00072E14 File Offset: 0x00071014
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1273511, RefRangeEnd = 1273515, XrefRangeStart = 1273485, XrefRangeEnd = 1273511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToDouble(string str, out double value, out ExpressionEvaluator.Expression expr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expr = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00072E88 File Offset: 0x00071088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273526, RefRangeEnd = 1273527, XrefRangeStart = 1273515, XrefRangeEnd = 1273526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToDouble(string str, string initialValueAsString, out double value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00072F0C File Offset: 0x0007110C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1273542, RefRangeEnd = 1273544, XrefRangeStart = 1273527, XrefRangeEnd = 1273542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToFloat(string str, string initialValueAsString, out float value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x00072F90 File Offset: 0x00071190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273550, RefRangeEnd = 1273551, XrefRangeStart = 1273544, XrefRangeEnd = 1273550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToLong(string str, out long value, out ExpressionEvaluator.Expression expr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expr = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x00073004 File Offset: 0x00071204
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1273567, RefRangeEnd = 1273570, XrefRangeStart = 1273551, XrefRangeEnd = 1273567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToLong(string str, string initialValueAsString, out long value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00073088 File Offset: 0x00071288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273576, RefRangeEnd = 1273577, XrefRangeStart = 1273570, XrefRangeEnd = 1273576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToULong(string str, out ulong value, out ExpressionEvaluator.Expression expr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expr = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x000730FC File Offset: 0x000712FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273593, RefRangeEnd = 1273594, XrefRangeStart = 1273577, XrefRangeEnd = 1273593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToULong(string str, string initialValueAsString, out ulong value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x00073180 File Offset: 0x00071380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1273599, RefRangeEnd = 1273601, XrefRangeStart = 1273594, XrefRangeEnd = 1273599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToInt(string str, string initialValueAsString, out int value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x00073204 File Offset: 0x00071404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273606, RefRangeEnd = 1273607, XrefRangeStart = 1273601, XrefRangeEnd = 1273606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToUInt(string str, string initialValueAsString, out uint value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0000D23D File Offset: 0x0000B43D
		public UINumericFieldsUtils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x00073288 File Offset: 0x00071488
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x0000D246 File Offset: 0x0000B446
		public unsafe static string k_AllowedCharactersForFloat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForFloat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForFloat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x000732A8 File Offset: 0x000714A8
		// (set) Token: 0x06001BA0 RID: 7072 RVA: 0x0000D258 File Offset: 0x0000B458
		public unsafe static string k_AllowedCharactersForInt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForInt, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForInt, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x000732C8 File Offset: 0x000714C8
		// (set) Token: 0x06001BA2 RID: 7074 RVA: 0x0000D26A File Offset: 0x0000B46A
		public unsafe static string k_DoubleFieldFormatString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_DoubleFieldFormatString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_DoubleFieldFormatString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x000732E8 File Offset: 0x000714E8
		// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x0000D27C File Offset: 0x0000B47C
		public unsafe static string k_FloatFieldFormatString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_FloatFieldFormatString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_FloatFieldFormatString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x00073308 File Offset: 0x00071508
		// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x0000D28E File Offset: 0x0000B48E
		public unsafe static string k_IntFieldFormatString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_IntFieldFormatString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_IntFieldFormatString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00073328 File Offset: 0x00071528
		public static bool TryConvertStringToDouble(string str, out double value)
		{
			ExpressionEvaluator.Expression expression;
			return UINumericFieldsUtils.TryConvertStringToDouble(str, out value, out expression);
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00073344 File Offset: 0x00071544
		public static bool TryConvertStringToLong(string str, out long value)
		{
			ExpressionEvaluator.Expression expression;
			return ExpressionEvaluator.Evaluate<long>(str, out value, out expression);
		}

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeFieldInfoPtr_k_AllowedCharactersForFloat;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeFieldInfoPtr_k_AllowedCharactersForInt;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeFieldInfoPtr_k_DoubleFieldFormatString;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeFieldInfoPtr_k_FloatFieldFormatString;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeFieldInfoPtr_k_IntFieldFormatString;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0;
	}
}

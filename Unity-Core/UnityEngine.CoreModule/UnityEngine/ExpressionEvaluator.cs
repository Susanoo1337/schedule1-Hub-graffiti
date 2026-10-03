using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200007F RID: 127
	public class ExpressionEvaluator : Object
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x00029CBC File Offset: 0x00027EBC
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionEvaluator()
		{
			Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExpressionEvaluator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr);
			ExpressionEvaluator.NativeFieldInfoPtr_s_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "s_Random");
			ExpressionEvaluator.NativeFieldInfoPtr_s_Operators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "s_Operators");
			ExpressionEvaluator.NativeMethodInfoPtr_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663910);
			ExpressionEvaluator.NativeMethodInfoPtr_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663911);
			ExpressionEvaluator.NativeMethodInfoPtr_EvaluateDouble_Private_Static_Boolean_Il2CppStringArray_byref_Double_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663912);
			ExpressionEvaluator.NativeMethodInfoPtr_InfixToRPN_Private_Static_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663913);
			ExpressionEvaluator.NativeMethodInfoPtr_NeedToPop_Private_Static_Boolean_Stack_1_String_Operator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663914);
			ExpressionEvaluator.NativeMethodInfoPtr_ExpressionToTokens_Private_Static_Il2CppStringArray_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663915);
			ExpressionEvaluator.NativeMethodInfoPtr_IsCommand_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663916);
			ExpressionEvaluator.NativeMethodInfoPtr_IsVariable_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663917);
			ExpressionEvaluator.NativeMethodInfoPtr_IsDelayedFunction_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663918);
			ExpressionEvaluator.NativeMethodInfoPtr_IsOperator_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663919);
			ExpressionEvaluator.NativeMethodInfoPtr_TokenToOperator_Private_Static_Operator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663920);
			ExpressionEvaluator.NativeMethodInfoPtr_PreFormatExpression_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663921);
			ExpressionEvaluator.NativeMethodInfoPtr_FixUnaryOperators_Private_Static_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663922);
			ExpressionEvaluator.NativeMethodInfoPtr_EvaluateOp_Private_Static_Double_Il2CppStructArray_1_Double_Op_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663923);
			ExpressionEvaluator.NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, 100663924);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00029E40 File Offset: 0x00028040
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1232096, RefRangeEnd = 1232101, XrefRangeStart = 1232083, XrefRangeEnd = 1232096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Evaluate<T>(string expression, out T value, out ExpressionEvaluator.Expression delayed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr3 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.MethodInfoStoreGeneric_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0<T>.Pointer, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr6 = intPtr;
				value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
			}
			IntPtr intPtr7 = intPtr3;
			delayed = ((intPtr7 == 0) ? null : new ExpressionEvaluator.Expression(intPtr7));
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00029EF4 File Offset: 0x000280F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1232145, RefRangeEnd = 1232147, XrefRangeStart = 1232101, XrefRangeEnd = 1232145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EvaluateTokens<T>(Il2CppStringArray tokens, ref T value, int index, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.MethodInfoStoreGeneric_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00029F7C File Offset: 0x0002817C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232228, RefRangeEnd = 1232229, XrefRangeStart = 1232147, XrefRangeEnd = 1232228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EvaluateDouble(Il2CppStringArray tokens, ref double value, int index, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_EvaluateDouble_Private_Static_Boolean_Il2CppStringArray_byref_Double_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00029FE8 File Offset: 0x000281E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232324, RefRangeEnd = 1232325, XrefRangeStart = 1232229, XrefRangeEnd = 1232324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray InfixToRPN(Il2CppStringArray tokens)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_InfixToRPN_Private_Static_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0002A02C File Offset: 0x0002822C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232325, XrefRangeEnd = 1232333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NeedToPop(Stack<string> operatorStack, ExpressionEvaluator.Operator newOperator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(operatorStack);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newOperator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_NeedToPop_Private_Static_Boolean_Stack_1_String_Operator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0002A080 File Offset: 0x00028280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232395, RefRangeEnd = 1232396, XrefRangeStart = 1232333, XrefRangeEnd = 1232395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray ExpressionToTokens(string expression, out bool hasVariables)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hasVariables;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_ExpressionToTokens_Private_Static_Il2CppStringArray_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0002A0D4 File Offset: 0x000282D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1232398, RefRangeEnd = 1232401, XrefRangeStart = 1232396, XrefRangeEnd = 1232398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCommand(string token)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsCommand_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0002A118 File Offset: 0x00028318
		[CallerCount(0)]
		public unsafe static bool IsVariable(string token)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsVariable_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0002A15C File Offset: 0x0002835C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1232405, RefRangeEnd = 1232407, XrefRangeStart = 1232401, XrefRangeEnd = 1232405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDelayedFunction(string token)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsDelayedFunction_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0002A1A0 File Offset: 0x000283A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1232415, RefRangeEnd = 1232419, XrefRangeStart = 1232407, XrefRangeEnd = 1232415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOperator(string token)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_IsOperator_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0002A1E4 File Offset: 0x000283E4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1232426, RefRangeEnd = 1232432, XrefRangeStart = 1232419, XrefRangeEnd = 1232426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ExpressionEvaluator.Operator TokenToOperator(string token)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_TokenToOperator_Private_Static_Operator_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionEvaluator.Operator>(intPtr3) : null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0002A228 File Offset: 0x00028428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232460, RefRangeEnd = 1232461, XrefRangeStart = 1232432, XrefRangeEnd = 1232460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string PreFormatExpression(string expression)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_PreFormatExpression_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0002A264 File Offset: 0x00028464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232461, XrefRangeEnd = 1232479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray FixUnaryOperators(Il2CppStringArray tokens)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_FixUnaryOperators_Private_Static_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0002A2A8 File Offset: 0x000284A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232533, RefRangeEnd = 1232534, XrefRangeStart = 1232479, XrefRangeEnd = 1232533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double EvaluateOp(Il2CppStructArray<double> values, ExpressionEvaluator.Op op, int index, int count)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.NativeMethodInfoPtr_EvaluateOp_Private_Static_Double_Il2CppStructArray_1_Double_Op_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0002A314 File Offset: 0x00028514
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1232646, RefRangeEnd = 1232649, XrefRangeStart = 1232534, XrefRangeEnd = 1232646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryParse<T>(string expression, out T result)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref result;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.MethodInfoStoreGeneric_TryParse_Private_Static_Boolean_String_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00004E50 File Offset: 0x00003050
		public ExpressionEvaluator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0002A3A4 File Offset: 0x000285A4
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00004E59 File Offset: 0x00003059
		public unsafe static ExpressionEvaluator.PcgRandom s_Random
		{
			get
			{
				ExpressionEvaluator.PcgRandom result;
				IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Random, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Random, (void*)(&value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0002A3C0 File Offset: 0x000285C0
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00004E67 File Offset: 0x00003067
		public unsafe static Dictionary<string, ExpressionEvaluator.Operator> s_Operators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Operators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ExpressionEvaluator.Operator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.NativeFieldInfoPtr_s_Operators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0002A3E8 File Offset: 0x000285E8
		public static bool Evaluate<T>(string expression, out T value)
		{
			ExpressionEvaluator.Expression expression2;
			return ExpressionEvaluator.Evaluate<T>(expression, out value, out expression2);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00004E79 File Offset: 0x00003079
		public static void SetRandomState(uint state)
		{
			ExpressionEvaluator.s_Random = new ExpressionEvaluator.PcgRandom((ulong)state, 0UL);
		}

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeFieldInfoPtr_s_Random;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeFieldInfoPtr_s_Operators;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateDouble_Private_Static_Boolean_Il2CppStringArray_byref_Double_Int32_Int32_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_InfixToRPN_Private_Static_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_NeedToPop_Private_Static_Boolean_Stack_1_String_Operator_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionToTokens_Private_Static_Il2CppStringArray_String_byref_Boolean_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_IsCommand_Private_Static_Boolean_String_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_IsVariable_Private_Static_Boolean_String_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_IsDelayedFunction_Private_Static_Boolean_String_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_IsOperator_Private_Static_Boolean_String_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_TokenToOperator_Private_Static_Operator_String_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_PreFormatExpression_Private_Static_String_String_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_FixUnaryOperators_Private_Static_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateOp_Private_Static_Double_Il2CppStructArray_1_Double_Op_Int32_Int32_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_byref_T_0;

		// Token: 0x020004D6 RID: 1238
		public class Expression : Object
		{
			// Token: 0x0600324B RID: 12875 RVA: 0x000B0128 File Offset: 0x000AE328
			// Note: this type is marked as 'beforefieldinit'.
			static Expression()
			{
				Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "Expression");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr);
				ExpressionEvaluator.Expression.NativeFieldInfoPtr_rpnTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, "rpnTokens");
				ExpressionEvaluator.Expression.NativeFieldInfoPtr_hasVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, "hasVariables");
				ExpressionEvaluator.Expression.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100663926);
				ExpressionEvaluator.Expression.NativeMethodInfoPtr_Evaluate_Public_Boolean_byref_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100663927);
				ExpressionEvaluator.Expression.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100663928);
				ExpressionEvaluator.Expression.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100663929);
				ExpressionEvaluator.Expression.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr, 100663930);
			}

			// Token: 0x0600324C RID: 12876 RVA: 0x000B01E0 File Offset: 0x000AE3E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1232049, RefRangeEnd = 1232050, XrefRangeStart = 1232021, XrefRangeEnd = 1232049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Expression(string expression) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expression);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.Expression.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600324D RID: 12877 RVA: 0x000B022C File Offset: 0x000AE42C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1232059, RefRangeEnd = 1232063, XrefRangeStart = 1232050, XrefRangeEnd = 1232059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Evaluate<T>(ref T value, int index = 0, int count = 1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.Expression.MethodInfoStoreGeneric_Evaluate_Public_Boolean_byref_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600324E RID: 12878 RVA: 0x000B02B0 File Offset: 0x000AE4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232063, XrefRangeEnd = 1232068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionEvaluator.Expression.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600324F RID: 12879 RVA: 0x000B0308 File Offset: 0x000AE508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionEvaluator.Expression.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003250 RID: 12880 RVA: 0x000B0350 File Offset: 0x000AE550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232068, XrefRangeEnd = 1232071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionEvaluator.Expression.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06003251 RID: 12881 RVA: 0x00015B3F File Offset: 0x00013D3F
			public Expression(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A07 RID: 2567
			// (get) Token: 0x06003252 RID: 12882 RVA: 0x000B0394 File Offset: 0x000AE594
			// (set) Token: 0x06003253 RID: 12883 RVA: 0x00015B48 File Offset: 0x00013D48
			public unsafe Il2CppStringArray rpnTokens
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_rpnTokens);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_rpnTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A08 RID: 2568
			// (get) Token: 0x06003254 RID: 12884 RVA: 0x000B03C4 File Offset: 0x000AE5C4
			// (set) Token: 0x06003255 RID: 12885 RVA: 0x00015B67 File Offset: 0x00013D67
			public unsafe bool hasVariables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_hasVariables);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Expression.NativeFieldInfoPtr_hasVariables)) = value;
				}
			}

			// Token: 0x04002A61 RID: 10849
			private static readonly IntPtr NativeFieldInfoPtr_rpnTokens;

			// Token: 0x04002A62 RID: 10850
			private static readonly IntPtr NativeFieldInfoPtr_hasVariables;

			// Token: 0x04002A63 RID: 10851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

			// Token: 0x04002A64 RID: 10852
			private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Boolean_byref_T_Int32_Int32_0;

			// Token: 0x04002A65 RID: 10853
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04002A66 RID: 10854
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04002A67 RID: 10855
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x02000D48 RID: 3400
			private sealed class MethodInfoStoreGeneric_Evaluate_Public_Boolean_byref_T_Int32_Int32_0<T>
			{
				// Token: 0x04002CA3 RID: 11427
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.Expression.NativeMethodInfoPtr_Evaluate_Public_Boolean_byref_T_Int32_Int32_0, Il2CppClassPointerStore<ExpressionEvaluator.Expression>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				}))));
			}
		}

		// Token: 0x020004D7 RID: 1239
		[StructLayout(2)]
		public struct PcgRandom
		{
			// Token: 0x06003256 RID: 12886 RVA: 0x000B03EC File Offset: 0x000AE5EC
			// Note: this type is marked as 'beforefieldinit'.
			static PcgRandom()
			{
				Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "PcgRandom");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr);
				ExpressionEvaluator.PcgRandom.NativeFieldInfoPtr_increment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, "increment");
				ExpressionEvaluator.PcgRandom.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, "state");
				ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100663931);
				ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_GetUInt_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100663932);
				ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100663933);
				ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_XshRr_Private_Static_UInt32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100663934);
				ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_Step_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, 100663935);
			}

			// Token: 0x06003257 RID: 12887 RVA: 0x000B04A4 File Offset: 0x000AE6A4
			[CallerCount(0)]
			public unsafe PcgRandom(ulong state = 0UL, ulong sequence = 0UL)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref state;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequence;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003258 RID: 12888 RVA: 0x000B04E4 File Offset: 0x000AE6E4
			[CallerCount(0)]
			public unsafe uint GetUInt()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_GetUInt_Public_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003259 RID: 12889 RVA: 0x000B0514 File Offset: 0x000AE714
			[CallerCount(0)]
			public unsafe static uint RotateRight(uint v, int rot)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref v;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600325A RID: 12890 RVA: 0x000B0560 File Offset: 0x000AE760
			[CallerCount(0)]
			public unsafe static uint XshRr(ulong s)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_XshRr_Private_Static_UInt32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600325B RID: 12891 RVA: 0x000B05A0 File Offset: 0x000AE7A0
			[CallerCount(0)]
			public unsafe void Step()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.PcgRandom.NativeMethodInfoPtr_Step_Private_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600325C RID: 12892 RVA: 0x00015B82 File Offset: 0x00013D82
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExpressionEvaluator.PcgRandom>.NativeClassPtr, ref this));
			}

			// Token: 0x04002A68 RID: 10856
			private static readonly IntPtr NativeFieldInfoPtr_increment;

			// Token: 0x04002A69 RID: 10857
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x04002A6A RID: 10858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_UInt64_0;

			// Token: 0x04002A6B RID: 10859
			private static readonly IntPtr NativeMethodInfoPtr_GetUInt_Public_UInt32_0;

			// Token: 0x04002A6C RID: 10860
			private static readonly IntPtr NativeMethodInfoPtr_RotateRight_Private_Static_UInt32_UInt32_Int32_0;

			// Token: 0x04002A6D RID: 10861
			private static readonly IntPtr NativeMethodInfoPtr_XshRr_Private_Static_UInt32_UInt64_0;

			// Token: 0x04002A6E RID: 10862
			private static readonly IntPtr NativeMethodInfoPtr_Step_Private_Void_0;

			// Token: 0x04002A6F RID: 10863
			[FieldOffset(0)]
			public readonly ulong increment;

			// Token: 0x04002A70 RID: 10864
			[FieldOffset(8)]
			public ulong state;
		}

		// Token: 0x020004D8 RID: 1240
		[OriginalName("UnityEngine.CoreModule.dll", "", "Op")]
		public enum Op
		{
			// Token: 0x04002A72 RID: 10866
			Add,
			// Token: 0x04002A73 RID: 10867
			Sub,
			// Token: 0x04002A74 RID: 10868
			Mul,
			// Token: 0x04002A75 RID: 10869
			Div,
			// Token: 0x04002A76 RID: 10870
			Mod,
			// Token: 0x04002A77 RID: 10871
			Neg,
			// Token: 0x04002A78 RID: 10872
			Pow,
			// Token: 0x04002A79 RID: 10873
			Sqrt,
			// Token: 0x04002A7A RID: 10874
			Sin,
			// Token: 0x04002A7B RID: 10875
			Cos,
			// Token: 0x04002A7C RID: 10876
			Tan,
			// Token: 0x04002A7D RID: 10877
			Floor,
			// Token: 0x04002A7E RID: 10878
			Ceil,
			// Token: 0x04002A7F RID: 10879
			Round,
			// Token: 0x04002A80 RID: 10880
			Rand,
			// Token: 0x04002A81 RID: 10881
			Linear
		}

		// Token: 0x020004D9 RID: 1241
		[OriginalName("UnityEngine.CoreModule.dll", "", "Associativity")]
		public enum Associativity
		{
			// Token: 0x04002A83 RID: 10883
			Left,
			// Token: 0x04002A84 RID: 10884
			Right
		}

		// Token: 0x020004DA RID: 1242
		public class Operator : Object
		{
			// Token: 0x0600325D RID: 12893 RVA: 0x000B05C8 File Offset: 0x000AE7C8
			// Note: this type is marked as 'beforefieldinit'.
			static Operator()
			{
				Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "Operator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr);
				ExpressionEvaluator.Operator.NativeFieldInfoPtr_op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, "op");
				ExpressionEvaluator.Operator.NativeFieldInfoPtr_precedence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, "precedence");
				ExpressionEvaluator.Operator.NativeFieldInfoPtr_associativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, "associativity");
				ExpressionEvaluator.Operator.NativeFieldInfoPtr_inputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, "inputs");
				ExpressionEvaluator.Operator.NativeMethodInfoPtr__ctor_Public_Void_Op_Int32_Int32_Associativity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr, 100663936);
			}

			// Token: 0x0600325E RID: 12894 RVA: 0x000B0658 File Offset: 0x000AE858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232071, XrefRangeEnd = 1232072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Operator(ExpressionEvaluator.Op op, int precedence, int inputs, ExpressionEvaluator.Associativity associativity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionEvaluator.Operator>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref op;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precedence;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputs;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref associativity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.Operator.NativeMethodInfoPtr__ctor_Public_Void_Op_Int32_Int32_Associativity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600325F RID: 12895 RVA: 0x00015B94 File Offset: 0x00013D94
			public Operator(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A09 RID: 2569
			// (get) Token: 0x06003260 RID: 12896 RVA: 0x000B06CC File Offset: 0x000AE8CC
			// (set) Token: 0x06003261 RID: 12897 RVA: 0x00015B9D File Offset: 0x00013D9D
			public unsafe ExpressionEvaluator.Op op
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_op);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_op)) = value;
				}
			}

			// Token: 0x17000A0A RID: 2570
			// (get) Token: 0x06003262 RID: 12898 RVA: 0x000B06F4 File Offset: 0x000AE8F4
			// (set) Token: 0x06003263 RID: 12899 RVA: 0x00015BB8 File Offset: 0x00013DB8
			public unsafe int precedence
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_precedence);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_precedence)) = value;
				}
			}

			// Token: 0x17000A0B RID: 2571
			// (get) Token: 0x06003264 RID: 12900 RVA: 0x000B071C File Offset: 0x000AE91C
			// (set) Token: 0x06003265 RID: 12901 RVA: 0x00015BD3 File Offset: 0x00013DD3
			public unsafe ExpressionEvaluator.Associativity associativity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_associativity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_associativity)) = value;
				}
			}

			// Token: 0x17000A0C RID: 2572
			// (get) Token: 0x06003266 RID: 12902 RVA: 0x000B0744 File Offset: 0x000AE944
			// (set) Token: 0x06003267 RID: 12903 RVA: 0x00015BEE File Offset: 0x00013DEE
			public unsafe int inputs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_inputs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionEvaluator.Operator.NativeFieldInfoPtr_inputs)) = value;
				}
			}

			// Token: 0x04002A85 RID: 10885
			private static readonly IntPtr NativeFieldInfoPtr_op;

			// Token: 0x04002A86 RID: 10886
			private static readonly IntPtr NativeFieldInfoPtr_precedence;

			// Token: 0x04002A87 RID: 10887
			private static readonly IntPtr NativeFieldInfoPtr_associativity;

			// Token: 0x04002A88 RID: 10888
			private static readonly IntPtr NativeFieldInfoPtr_inputs;

			// Token: 0x04002A89 RID: 10889
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Op_Int32_Int32_Associativity_0;
		}

		// Token: 0x020004DB RID: 1243
		[ObfuscatedName("UnityEngine.ExpressionEvaluator+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003268 RID: 12904 RVA: 0x000B076C File Offset: 0x000AE96C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr);
				ExpressionEvaluator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, "<>9");
				ExpressionEvaluator.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, "<>9__14_0");
				ExpressionEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, 100663938);
				ExpressionEvaluator.__c.NativeMethodInfoPtr__ExpressionToTokens_b__14_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr, 100663939);
			}

			// Token: 0x06003269 RID: 12905 RVA: 0x000B07E8 File Offset: 0x000AE9E8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionEvaluator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600326A RID: 12906 RVA: 0x000B0824 File Offset: 0x000AEA24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232072, XrefRangeEnd = 1232083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExpressionToTokens_b__14_0(string f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionEvaluator.__c.NativeMethodInfoPtr__ExpressionToTokens_b__14_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600326B RID: 12907 RVA: 0x00015C09 File Offset: 0x00013E09
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A0D RID: 2573
			// (get) Token: 0x0600326C RID: 12908 RVA: 0x000B0874 File Offset: 0x000AEA74
			// (set) Token: 0x0600326D RID: 12909 RVA: 0x00015C12 File Offset: 0x00013E12
			public unsafe static ExpressionEvaluator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpressionEvaluator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A0E RID: 2574
			// (get) Token: 0x0600326E RID: 12910 RVA: 0x000B089C File Offset: 0x000AEA9C
			// (set) Token: 0x0600326F RID: 12911 RVA: 0x00015C24 File Offset: 0x00013E24
			public unsafe static Func<string, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExpressionEvaluator.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002A8A RID: 10890
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002A8B RID: 10891
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04002A8C RID: 10892
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002A8D RID: 10893
			private static readonly IntPtr NativeMethodInfoPtr__ExpressionToTokens_b__14_0_Internal_Boolean_String_0;
		}

		// Token: 0x020004DC RID: 1244
		private sealed class MethodInfoStoreGeneric_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0<T>
		{
			// Token: 0x04002A8E RID: 10894
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.NativeMethodInfoPtr_Evaluate_Internal_Static_Boolean_String_byref_T_byref_Expression_0, Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020004DD RID: 1245
		private sealed class MethodInfoStoreGeneric_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0<T>
		{
			// Token: 0x04002A8F RID: 10895
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.NativeMethodInfoPtr_EvaluateTokens_Private_Static_Boolean_Il2CppStringArray_byref_T_Int32_Int32_0, Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020004DE RID: 1246
		private sealed class MethodInfoStoreGeneric_TryParse_Private_Static_Boolean_String_byref_T_0<T>
		{
			// Token: 0x04002A90 RID: 10896
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ExpressionEvaluator.NativeMethodInfoPtr_TryParse_Private_Static_Boolean_String_byref_T_0, Il2CppClassPointerStore<ExpressionEvaluator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020004DF RID: 1247
		[Serializable]
		public sealed class <>c
		{
		}
	}
}

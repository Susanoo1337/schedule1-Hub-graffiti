using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000103 RID: 259
	public class NumericFieldDraggerUtility : Object
	{
		// Token: 0x06001631 RID: 5681 RVA: 0x00061418 File Offset: 0x0005F618
		// Note: this type is marked as 'beforefieldinit'.
		static NumericFieldDraggerUtility()
		{
			Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "NumericFieldDraggerUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr);
			NumericFieldDraggerUtility.NativeFieldInfoPtr_s_UseYSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, "s_UseYSign");
			NumericFieldDraggerUtility.NativeMethodInfoPtr_Acceleration_Internal_Static_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100665619);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_NiceDelta_Internal_Static_Single_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100665620);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100665621);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100665622);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100665623);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100665624);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Private_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100665625);
			NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100665626);
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x000614FC File Offset: 0x0005F6FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1245808, RefRangeEnd = 1245816, XrefRangeStart = 1245808, XrefRangeEnd = 1245808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Acceleration(bool shiftPressed, bool altPressed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shiftPressed;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref altPressed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_Acceleration_Internal_Static_Single_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00061548 File Offset: 0x0005F748
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1245823, RefRangeEnd = 1245831, XrefRangeStart = 1245816, XrefRangeEnd = 1245823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float NiceDelta(Vector2 deviceDelta, float acceleration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deviceDelta;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceleration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_NiceDelta_Internal_Static_Single_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00061594 File Offset: 0x0005F794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245836, RefRangeEnd = 1245838, XrefRangeStart = 1245831, XrefRangeEnd = 1245836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CalculateFloatDragSensitivity(double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x000615D4 File Offset: 0x0005F7D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245842, RefRangeEnd = 1245843, XrefRangeStart = 1245838, XrefRangeEnd = 1245842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CalculateFloatDragSensitivity(double value, double minValue, double maxValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00061630 File Offset: 0x0005F830
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1245844, RefRangeEnd = 1245847, XrefRangeStart = 1245843, XrefRangeEnd = 1245844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CalculateIntDragSensitivity(long value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00061670 File Offset: 0x0005F870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245849, RefRangeEnd = 1245850, XrefRangeStart = 1245847, XrefRangeEnd = 1245849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong CalculateIntDragSensitivity(ulong value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_UInt64_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x000616B0 File Offset: 0x0005F8B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245855, RefRangeEnd = 1245857, XrefRangeStart = 1245850, XrefRangeEnd = 1245855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CalculateIntDragSensitivity(double value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Private_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x000616F0 File Offset: 0x0005F8F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1245861, RefRangeEnd = 1245862, XrefRangeStart = 1245857, XrefRangeEnd = 1245861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CalculateIntDragSensitivity(long value, long minValue, long maxValue)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0000B346 File Offset: 0x00009546
		public NumericFieldDraggerUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x0006174C File Offset: 0x0005F94C
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x0000B34F File Offset: 0x0000954F
		public unsafe static bool s_UseYSign
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(NumericFieldDraggerUtility.NativeFieldInfoPtr_s_UseYSign, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumericFieldDraggerUtility.NativeFieldInfoPtr_s_UseYSign, (void*)(&value));
			}
		}

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr_s_UseYSign;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeMethodInfoPtr_Acceleration_Internal_Static_Single_Boolean_Boolean_0;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeMethodInfoPtr_NiceDelta_Internal_Static_Single_Vector2_Single_0;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_0;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFloatDragSensitivity_Internal_Static_Double_Double_Double_Double_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_0;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_UInt64_UInt64_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Private_Static_Double_Double_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Internal_Static_Int64_Int64_Int64_Int64_0;

		// Token: 0x04001327 RID: 4903
		public const float kDragSensitivity = 0.03f;
	}
}

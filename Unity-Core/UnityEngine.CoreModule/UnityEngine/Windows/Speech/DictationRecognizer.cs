using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000188 RID: 392
	public sealed class DictationRecognizer : Object
	{
		// Token: 0x06001E2D RID: 7725 RVA: 0x0007B000 File Offset: 0x00079200
		// Note: this type is marked as 'beforefieldinit'.
		static DictationRecognizer()
		{
			Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "DictationRecognizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr);
			DictationRecognizer.NativeFieldInfoPtr_m_Recognizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "m_Recognizer");
			DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationHypothesis");
			DictationRecognizer.NativeFieldInfoPtr_DictationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationResult");
			DictationRecognizer.NativeFieldInfoPtr_DictationComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationComplete");
			DictationRecognizer.NativeFieldInfoPtr_DictationError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationError");
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100666518);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100666519);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100666520);
			DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100666521);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0007B0E4 File Offset: 0x000792E4
		[CallerCount(0)]
		public unsafe void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0007B128 File Offset: 0x00079328
		[CallerCount(0)]
		public unsafe void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, ConfidenceLevel minimumConfidence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(keyword);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minimumConfidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0007B178 File Offset: 0x00079378
		[CallerCount(0)]
		public unsafe void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cause;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0007B1B8 File Offset: 0x000793B8
		[CallerCount(0)]
		public unsafe void DictationRecognizer_InvokeErrorEvent(string error, int hresult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0000E316 File Offset: 0x0000C516
		public DictationRecognizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x0007B208 File Offset: 0x00079408
		// (set) Token: 0x06001E34 RID: 7732 RVA: 0x0000E31F File Offset: 0x0000C51F
		public unsafe IntPtr m_Recognizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_m_Recognizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_m_Recognizer)) = value;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x0007B230 File Offset: 0x00079430
		// (set) Token: 0x06001E36 RID: 7734 RVA: 0x0000E33A File Offset: 0x0000C53A
		public unsafe DictationRecognizer.DictationHypothesisDelegate DictationHypothesis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationHypothesisDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationHypothesis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x0007B260 File Offset: 0x00079460
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x0000E359 File Offset: 0x0000C559
		public unsafe DictationRecognizer.DictationResultDelegate DictationResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationResultDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x0007B290 File Offset: 0x00079490
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x0000E378 File Offset: 0x0000C578
		public unsafe DictationRecognizer.DictationCompletedDelegate DictationComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationCompletedDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x0007B2C0 File Offset: 0x000794C0
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x0000E397 File Offset: 0x0000C597
		public unsafe DictationRecognizer.DictationErrorHandler DictationError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationError);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DictationRecognizer.DictationErrorHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DictationRecognizer.NativeFieldInfoPtr_DictationError), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400188F RID: 6287
		private static readonly IntPtr NativeFieldInfoPtr_m_Recognizer;

		// Token: 0x04001890 RID: 6288
		private static readonly IntPtr NativeFieldInfoPtr_DictationHypothesis;

		// Token: 0x04001891 RID: 6289
		private static readonly IntPtr NativeFieldInfoPtr_DictationResult;

		// Token: 0x04001892 RID: 6290
		private static readonly IntPtr NativeFieldInfoPtr_DictationComplete;

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeFieldInfoPtr_DictationError;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_String_0;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_String_ConfidenceLevel_0;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0;

		// Token: 0x02000A07 RID: 2567
		public sealed class DictationHypothesisDelegate : MulticastDelegate
		{
			// Token: 0x06003C9D RID: 15517 RVA: 0x00016224 File Offset: 0x00014424
			// Note: this type is marked as 'beforefieldinit'.
			static DictationHypothesisDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationHypothesisDelegate");
				DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100666522);
				DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr, 100666523);
			}

			// Token: 0x06003C9E RID: 15518 RVA: 0x000B3820 File Offset: 0x000B1A20
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 73307, RefRangeEnd = 73313, XrefRangeStart = 73307, XrefRangeEnd = 73313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationHypothesisDelegate(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationHypothesisDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C9F RID: 15519 RVA: 0x000B387C File Offset: 0x000B1A7C
			[CallerCount(0)]
			public unsafe void Invoke(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationHypothesisDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CA0 RID: 15520 RVA: 0x00016262 File Offset: 0x00014462
			public DictationHypothesisDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CA1 RID: 15521 RVA: 0x0001626B File Offset: 0x0001446B
			public static implicit operator DictationRecognizer.DictationHypothesisDelegate(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationHypothesisDelegate>(A_0);
			}

			// Token: 0x06003CA2 RID: 15522 RVA: 0x00016273 File Offset: 0x00014473
			public static DictationRecognizer.DictationHypothesisDelegate operator +(DictationRecognizer.DictationHypothesisDelegate A_0, DictationRecognizer.DictationHypothesisDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationHypothesisDelegate>();
			}

			// Token: 0x06003CA3 RID: 15523 RVA: 0x00016281 File Offset: 0x00014481
			public static DictationRecognizer.DictationHypothesisDelegate operator -(DictationRecognizer.DictationHypothesisDelegate A_0, DictationRecognizer.DictationHypothesisDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<DictationRecognizer.DictationHypothesisDelegate>();
				}
				return result;
			}

			// Token: 0x04002B77 RID: 11127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B78 RID: 11128
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;
		}

		// Token: 0x02000A08 RID: 2568
		public sealed class DictationResultDelegate : MulticastDelegate
		{
			// Token: 0x06003CA4 RID: 15524 RVA: 0x00016292 File Offset: 0x00014492
			// Note: this type is marked as 'beforefieldinit'.
			static DictationResultDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationResultDelegate");
				DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100666524);
				DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr, 100666525);
			}

			// Token: 0x06003CA5 RID: 15525 RVA: 0x000B38C0 File Offset: 0x000B1AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationResultDelegate(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationResultDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CA6 RID: 15526 RVA: 0x000B391C File Offset: 0x000B1B1C
			[CallerCount(0)]
			public unsafe void Invoke(string text, ConfidenceLevel confidence)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationResultDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CA7 RID: 15527 RVA: 0x000162D0 File Offset: 0x000144D0
			public DictationResultDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CA8 RID: 15528 RVA: 0x000162D9 File Offset: 0x000144D9
			public static implicit operator DictationRecognizer.DictationResultDelegate(Action<string, ConfidenceLevel> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationResultDelegate>(A_0);
			}

			// Token: 0x06003CA9 RID: 15529 RVA: 0x000162E1 File Offset: 0x000144E1
			public static DictationRecognizer.DictationResultDelegate operator +(DictationRecognizer.DictationResultDelegate A_0, DictationRecognizer.DictationResultDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationResultDelegate>();
			}

			// Token: 0x06003CAA RID: 15530 RVA: 0x000162EF File Offset: 0x000144EF
			public static DictationRecognizer.DictationResultDelegate operator -(DictationRecognizer.DictationResultDelegate A_0, DictationRecognizer.DictationResultDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<DictationRecognizer.DictationResultDelegate>();
				}
				return result;
			}

			// Token: 0x04002B79 RID: 11129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B7A RID: 11130
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0;
		}

		// Token: 0x02000A09 RID: 2569
		public sealed class DictationCompletedDelegate : MulticastDelegate
		{
			// Token: 0x06003CAB RID: 15531 RVA: 0x00016300 File Offset: 0x00014500
			// Note: this type is marked as 'beforefieldinit'.
			static DictationCompletedDelegate()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationCompletedDelegate");
				DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100666526);
				DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr, 100666527);
			}

			// Token: 0x06003CAC RID: 15532 RVA: 0x000B396C File Offset: 0x000B1B6C
			[CallerCount(152)]
			[CachedScanResults(RefRangeStart = 95930, RefRangeEnd = 96082, XrefRangeStart = 95930, XrefRangeEnd = 96082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationCompletedDelegate(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationCompletedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CAD RID: 15533 RVA: 0x000B39C8 File Offset: 0x000B1BC8
			[CallerCount(0)]
			public unsafe void Invoke(DictationCompletionCause cause)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref cause;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationCompletedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CAE RID: 15534 RVA: 0x0001633E File Offset: 0x0001453E
			public DictationCompletedDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CAF RID: 15535 RVA: 0x00016347 File Offset: 0x00014547
			public static implicit operator DictationRecognizer.DictationCompletedDelegate(Action<DictationCompletionCause> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationCompletedDelegate>(A_0);
			}

			// Token: 0x06003CB0 RID: 15536 RVA: 0x0001634F File Offset: 0x0001454F
			public static DictationRecognizer.DictationCompletedDelegate operator +(DictationRecognizer.DictationCompletedDelegate A_0, DictationRecognizer.DictationCompletedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationCompletedDelegate>();
			}

			// Token: 0x06003CB1 RID: 15537 RVA: 0x0001635D File Offset: 0x0001455D
			public static DictationRecognizer.DictationCompletedDelegate operator -(DictationRecognizer.DictationCompletedDelegate A_0, DictationRecognizer.DictationCompletedDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<DictationRecognizer.DictationCompletedDelegate>();
				}
				return result;
			}

			// Token: 0x04002B7B RID: 11131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B7C RID: 11132
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0;
		}

		// Token: 0x02000A0A RID: 2570
		public sealed class DictationErrorHandler : MulticastDelegate
		{
			// Token: 0x06003CB2 RID: 15538 RVA: 0x0001636E File Offset: 0x0001456E
			// Note: this type is marked as 'beforefieldinit'.
			static DictationErrorHandler()
			{
				Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationErrorHandler");
				DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100666528);
				DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr, 100666529);
			}

			// Token: 0x06003CB3 RID: 15539 RVA: 0x000B3A08 File Offset: 0x000B1C08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictationErrorHandler(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationRecognizer.DictationErrorHandler>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CB4 RID: 15540 RVA: 0x000B3A64 File Offset: 0x000B1C64
			[CallerCount(0)]
			public unsafe void Invoke(string error, int hresult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hresult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictationRecognizer.DictationErrorHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003CB5 RID: 15541 RVA: 0x000163AC File Offset: 0x000145AC
			public DictationErrorHandler(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003CB6 RID: 15542 RVA: 0x000163B5 File Offset: 0x000145B5
			public static implicit operator DictationRecognizer.DictationErrorHandler(Action<string, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<DictationRecognizer.DictationErrorHandler>(A_0);
			}

			// Token: 0x06003CB7 RID: 15543 RVA: 0x000163BD File Offset: 0x000145BD
			public static DictationRecognizer.DictationErrorHandler operator +(DictationRecognizer.DictationErrorHandler A_0, DictationRecognizer.DictationErrorHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DictationRecognizer.DictationErrorHandler>();
			}

			// Token: 0x06003CB8 RID: 15544 RVA: 0x000163CB File Offset: 0x000145CB
			public static DictationRecognizer.DictationErrorHandler operator -(DictationRecognizer.DictationErrorHandler A_0, DictationRecognizer.DictationErrorHandler A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<DictationRecognizer.DictationErrorHandler>();
				}
				return result;
			}

			// Token: 0x04002B7D RID: 11133
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B7E RID: 11134
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0;
		}
	}
}

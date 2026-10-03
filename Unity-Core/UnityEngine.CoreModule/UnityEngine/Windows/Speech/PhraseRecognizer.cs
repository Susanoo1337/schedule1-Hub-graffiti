using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000187 RID: 391
	public class PhraseRecognizer : Object
	{
		// Token: 0x06001E25 RID: 7717 RVA: 0x0007AE3C File Offset: 0x0007903C
		// Note: this type is marked as 'beforefieldinit'.
		static PhraseRecognizer()
		{
			Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr);
			PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "m_Recognizer");
			PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "OnPhraseRecognized");
			PhraseRecognizer.NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, 100666514);
			PhraseRecognizer.NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, 100666515);
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0007AEBC File Offset: 0x000790BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282567, XrefRangeEnd = 1282577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokePhraseRecognizedEvent(string text, ConfidenceLevel confidence, Il2CppReferenceArray<SemanticMeaning> semanticMeanings, long phraseStartFileTime, long phraseDurationTicks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(semanticMeanings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseStartFileTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseDurationTicks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0007AF3C File Offset: 0x0007913C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282577, XrefRangeEnd = 1282592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<SemanticMeaning> MarshalSemanticMeaning(IntPtr keys, IntPtr values, IntPtr valueSizes, int valueCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref keys;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref values;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueSizes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SemanticMeaning>>(intPtr3) : null;
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0000E2D3 File Offset: 0x0000C4D3
		public PhraseRecognizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x0007AFA8 File Offset: 0x000791A8
		// (set) Token: 0x06001E2A RID: 7722 RVA: 0x0000E2DC File Offset: 0x0000C4DC
		public unsafe IntPtr m_Recognizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_m_Recognizer)) = value;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0007AFD0 File Offset: 0x000791D0
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x0000E2F7 File Offset: 0x0000C4F7
		public unsafe PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhraseRecognizer.PhraseRecognizedDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizer.NativeFieldInfoPtr_OnPhraseRecognized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeFieldInfoPtr_m_Recognizer;

		// Token: 0x0400188C RID: 6284
		private static readonly IntPtr NativeFieldInfoPtr_OnPhraseRecognized;

		// Token: 0x0400188D RID: 6285
		private static readonly IntPtr NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0;

		// Token: 0x0400188E RID: 6286
		private static readonly IntPtr NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0;

		// Token: 0x02000A06 RID: 2566
		public sealed class PhraseRecognizedDelegate : MulticastDelegate
		{
			// Token: 0x06003C96 RID: 15510 RVA: 0x000161B6 File Offset: 0x000143B6
			// Note: this type is marked as 'beforefieldinit'.
			static PhraseRecognizedDelegate()
			{
				Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "PhraseRecognizedDelegate");
				PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr, 100666516);
				PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr, 100666517);
			}

			// Token: 0x06003C97 RID: 15511 RVA: 0x000B377C File Offset: 0x000B197C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1282565, RefRangeEnd = 1282567, XrefRangeStart = 1282562, XrefRangeEnd = 1282565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PhraseRecognizedDelegate(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizer.PhraseRecognizedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C98 RID: 15512 RVA: 0x000B37D8 File Offset: 0x000B19D8
			[CallerCount(0)]
			public unsafe void Invoke(PhraseRecognizedEventArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizer.PhraseRecognizedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C99 RID: 15513 RVA: 0x000161F4 File Offset: 0x000143F4
			public PhraseRecognizedDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003C9A RID: 15514 RVA: 0x000161FD File Offset: 0x000143FD
			public static implicit operator PhraseRecognizer.PhraseRecognizedDelegate(Action<PhraseRecognizedEventArgs> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhraseRecognizer.PhraseRecognizedDelegate>(A_0);
			}

			// Token: 0x06003C9B RID: 15515 RVA: 0x00016205 File Offset: 0x00014405
			public static PhraseRecognizer.PhraseRecognizedDelegate operator +(PhraseRecognizer.PhraseRecognizedDelegate A_0, PhraseRecognizer.PhraseRecognizedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhraseRecognizer.PhraseRecognizedDelegate>();
			}

			// Token: 0x06003C9C RID: 15516 RVA: 0x00016213 File Offset: 0x00014413
			public static PhraseRecognizer.PhraseRecognizedDelegate operator -(PhraseRecognizer.PhraseRecognizedDelegate A_0, PhraseRecognizer.PhraseRecognizedDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PhraseRecognizer.PhraseRecognizedDelegate>();
				}
				return result;
			}

			// Token: 0x04002B75 RID: 11125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B76 RID: 11126
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0;
		}
	}
}

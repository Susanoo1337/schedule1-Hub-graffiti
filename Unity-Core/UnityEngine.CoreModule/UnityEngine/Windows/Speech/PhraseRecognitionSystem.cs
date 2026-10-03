using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x02000186 RID: 390
	public static class PhraseRecognitionSystem : Object
	{
		// Token: 0x06001E1D RID: 7709 RVA: 0x0007AD04 File Offset: 0x00078F04
		// Note: this type is marked as 'beforefieldinit'.
		static PhraseRecognitionSystem()
		{
			Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognitionSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr);
			PhraseRecognitionSystem.NativeFieldInfoPtr_OnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "OnError");
			PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "OnStatusChanged");
			PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100666508);
			PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100666509);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0007AD84 File Offset: 0x00078F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282558, XrefRangeEnd = 1282560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0007ADB8 File Offset: 0x00078FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282560, XrefRangeEnd = 1282562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0000E2A6 File Offset: 0x0000C4A6
		public PhraseRecognitionSystem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x0007ADEC File Offset: 0x00078FEC
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x0000E2AF File Offset: 0x0000C4AF
		public unsafe static PhraseRecognitionSystem.ErrorDelegate OnError
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnError, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhraseRecognitionSystem.ErrorDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnError, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x0007AE14 File Offset: 0x00079014
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x0000E2C1 File Offset: 0x0000C4C1
		public unsafe static PhraseRecognitionSystem.StatusDelegate OnStatusChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhraseRecognitionSystem.StatusDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeFieldInfoPtr_OnError;

		// Token: 0x04001888 RID: 6280
		private static readonly IntPtr NativeFieldInfoPtr_OnStatusChanged;

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0;

		// Token: 0x02000A04 RID: 2564
		public sealed class ErrorDelegate : MulticastDelegate
		{
			// Token: 0x06003C88 RID: 15496 RVA: 0x000160DA File Offset: 0x000142DA
			// Note: this type is marked as 'beforefieldinit'.
			static ErrorDelegate()
			{
				Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "ErrorDelegate");
				PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100666510);
				PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100666511);
			}

			// Token: 0x06003C89 RID: 15497 RVA: 0x000B3644 File Offset: 0x000B1844
			[CallerCount(152)]
			[CachedScanResults(RefRangeStart = 95930, RefRangeEnd = 96082, XrefRangeStart = 95930, XrefRangeEnd = 96082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorDelegate(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C8A RID: 15498 RVA: 0x000B36A0 File Offset: 0x000B18A0
			[CallerCount(0)]
			public unsafe void Invoke(SpeechError errorCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C8B RID: 15499 RVA: 0x00016118 File Offset: 0x00014318
			public ErrorDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003C8C RID: 15500 RVA: 0x00016121 File Offset: 0x00014321
			public static implicit operator PhraseRecognitionSystem.ErrorDelegate(Action<SpeechError> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhraseRecognitionSystem.ErrorDelegate>(A_0);
			}

			// Token: 0x06003C8D RID: 15501 RVA: 0x00016129 File Offset: 0x00014329
			public static PhraseRecognitionSystem.ErrorDelegate operator +(PhraseRecognitionSystem.ErrorDelegate A_0, PhraseRecognitionSystem.ErrorDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhraseRecognitionSystem.ErrorDelegate>();
			}

			// Token: 0x06003C8E RID: 15502 RVA: 0x00016137 File Offset: 0x00014337
			public static PhraseRecognitionSystem.ErrorDelegate operator -(PhraseRecognitionSystem.ErrorDelegate A_0, PhraseRecognitionSystem.ErrorDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PhraseRecognitionSystem.ErrorDelegate>();
				}
				return result;
			}

			// Token: 0x04002B71 RID: 11121
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B72 RID: 11122
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0;
		}

		// Token: 0x02000A05 RID: 2565
		public sealed class StatusDelegate : MulticastDelegate
		{
			// Token: 0x06003C8F RID: 15503 RVA: 0x00016148 File Offset: 0x00014348
			// Note: this type is marked as 'beforefieldinit'.
			static StatusDelegate()
			{
				Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "StatusDelegate");
				PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100666512);
				PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100666513);
			}

			// Token: 0x06003C90 RID: 15504 RVA: 0x000B36E0 File Offset: 0x000B18E0
			[CallerCount(152)]
			[CachedScanResults(RefRangeStart = 95930, RefRangeEnd = 96082, XrefRangeStart = 95930, XrefRangeEnd = 96082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StatusDelegate(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C91 RID: 15505 RVA: 0x000B373C File Offset: 0x000B193C
			[CallerCount(0)]
			public unsafe void Invoke(SpeechSystemStatus status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003C92 RID: 15506 RVA: 0x00016186 File Offset: 0x00014386
			public StatusDelegate(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06003C93 RID: 15507 RVA: 0x0001618F File Offset: 0x0001438F
			public static implicit operator PhraseRecognitionSystem.StatusDelegate(Action<SpeechSystemStatus> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhraseRecognitionSystem.StatusDelegate>(A_0);
			}

			// Token: 0x06003C94 RID: 15508 RVA: 0x00016197 File Offset: 0x00014397
			public static PhraseRecognitionSystem.StatusDelegate operator +(PhraseRecognitionSystem.StatusDelegate A_0, PhraseRecognitionSystem.StatusDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhraseRecognitionSystem.StatusDelegate>();
			}

			// Token: 0x06003C95 RID: 15509 RVA: 0x000161A5 File Offset: 0x000143A5
			public static PhraseRecognitionSystem.StatusDelegate operator -(PhraseRecognitionSystem.StatusDelegate A_0, PhraseRecognitionSystem.StatusDelegate A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PhraseRecognitionSystem.StatusDelegate>();
				}
				return result;
			}

			// Token: 0x04002B73 RID: 11123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04002B74 RID: 11124
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0;
		}
	}
}

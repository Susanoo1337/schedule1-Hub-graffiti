using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x0200018E RID: 398
	public sealed class PhraseRecognizedEventArgs : ValueType
	{
		// Token: 0x06001E44 RID: 7748 RVA: 0x0007B3A0 File Offset: 0x000795A0
		// Note: this type is marked as 'beforefieldinit'.
		static PhraseRecognizedEventArgs()
		{
			Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognizedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr);
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "confidence");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "semanticMeanings");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "text");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "phraseStartTime");
			PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "phraseDuration");
			PhraseRecognizedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, 100666530);
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x0007B448 File Offset: 0x00079648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282592, XrefRangeEnd = 1282594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, Il2CppReferenceArray<SemanticMeaning> semanticMeanings, DateTime phraseStartTime, TimeSpan phraseDuration) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(semanticMeanings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseStartTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref phraseDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognizedEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0000E40F File Offset: 0x0000C60F
		public PhraseRecognizedEventArgs(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0000E418 File Offset: 0x0000C618
		public PhraseRecognizedEventArgs() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
		{
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0007B4D4 File Offset: 0x000796D4
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0000E42A File Offset: 0x0000C62A
		public unsafe ConfidenceLevel confidence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_confidence)) = value;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0007B4FC File Offset: 0x000796FC
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0000E445 File Offset: 0x0000C645
		public unsafe Il2CppReferenceArray<SemanticMeaning> semanticMeanings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SemanticMeaning>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_semanticMeanings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x0007B52C File Offset: 0x0007972C
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x0000E464 File Offset: 0x0000C664
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x0007B554 File Offset: 0x00079754
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x0000E483 File Offset: 0x0000C683
		public unsafe DateTime phraseStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseStartTime)) = value;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x0007B57C File Offset: 0x0007977C
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x0000E49E File Offset: 0x0000C69E
		public unsafe TimeSpan phraseDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhraseRecognizedEventArgs.NativeFieldInfoPtr_phraseDuration)) = value;
			}
		}

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeFieldInfoPtr_confidence;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeFieldInfoPtr_semanticMeanings;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeFieldInfoPtr_phraseStartTime;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeFieldInfoPtr_phraseDuration;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0;
	}
}

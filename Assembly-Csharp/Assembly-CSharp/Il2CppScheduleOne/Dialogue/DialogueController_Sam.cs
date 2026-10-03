using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003B8 RID: 952
	public class DialogueController_Sam : DialogueController
	{
		// Token: 0x06005664 RID: 22116 RVA: 0x001A6348 File Offset: 0x001A4548
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Sam()
		{
			Il2CppClassPointerStore<DialogueController_Sam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Sam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Sam>.NativeClassPtr);
			DialogueController_Sam.NativeFieldInfoPtr_questDefeatCartel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Sam>.NativeClassPtr, "questDefeatCartel");
			DialogueController_Sam.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Sam>.NativeClassPtr, 100674617);
			DialogueController_Sam.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Sam>.NativeClassPtr, 100674618);
			DialogueController_Sam.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Sam>.NativeClassPtr, 100674619);
			DialogueController_Sam.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Sam>.NativeClassPtr, 100674620);
			DialogueController_Sam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Sam>.NativeClassPtr, 100674621);
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x001A63F0 File Offset: 0x001A45F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190477, XrefRangeEnd = 190515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Sam.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x001A642C File Offset: 0x001A462C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190515, XrefRangeEnd = 190527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Sam.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x001A64A0 File Offset: 0x001A46A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190527, XrefRangeEnd = 190540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Sam.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x001A6508 File Offset: 0x001A4708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190540, XrefRangeEnd = 190551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Sam.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x001A6558 File Offset: 0x001A4758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Sam() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Sam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Sam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x00028DD6 File Offset: 0x00026FD6
		public DialogueController_Sam(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x0600566B RID: 22123 RVA: 0x001A6594 File Offset: 0x001A4794
		// (set) Token: 0x0600566C RID: 22124 RVA: 0x00028DDF File Offset: 0x00026FDF
		public unsafe Quest_DefeatCartel questDefeatCartel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Sam.NativeFieldInfoPtr_questDefeatCartel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_DefeatCartel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Sam.NativeFieldInfoPtr_questDefeatCartel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B7F RID: 15231
		private static readonly IntPtr NativeFieldInfoPtr_questDefeatCartel;

		// Token: 0x04003B80 RID: 15232
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003B81 RID: 15233
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04003B82 RID: 15234
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04003B83 RID: 15235
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x04003B84 RID: 15236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ABF RID: 2751
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_Sam+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600E3B3 RID: 58291 RVA: 0x0037C140 File Offset: 0x0037A340
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogueController_Sam.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_Sam>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Sam.__c>.NativeClassPtr);
				DialogueController_Sam.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Sam.__c>.NativeClassPtr, "<>9");
				DialogueController_Sam.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Sam.__c>.NativeClassPtr, "<>9__1_0");
				DialogueController_Sam.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Sam.__c>.NativeClassPtr, 100674623);
				DialogueController_Sam.__c.NativeMethodInfoPtr__Start_b__1_0_Internal_Boolean_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Sam.__c>.NativeClassPtr, 100674624);
			}

			// Token: 0x0600E3B4 RID: 58292 RVA: 0x0037C1BC File Offset: 0x0037A3BC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Sam.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Sam.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3B5 RID: 58293 RVA: 0x0037C1F8 File Offset: 0x0037A3F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190475, XrefRangeEnd = 190477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__1_0(Quest q)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Sam.__c.NativeMethodInfoPtr__Start_b__1_0_Internal_Boolean_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E3B6 RID: 58294 RVA: 0x0006B57F File Offset: 0x0006977F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004544 RID: 17732
			// (get) Token: 0x0600E3B7 RID: 58295 RVA: 0x0037C248 File Offset: 0x0037A448
			// (set) Token: 0x0600E3B8 RID: 58296 RVA: 0x0006B588 File Offset: 0x00069788
			public unsafe static DialogueController_Sam.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Sam.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_Sam.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Sam.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004545 RID: 17733
			// (get) Token: 0x0600E3B9 RID: 58297 RVA: 0x0037C270 File Offset: 0x0037A470
			// (set) Token: 0x0600E3BA RID: 58298 RVA: 0x0006B59A File Offset: 0x0006979A
			public unsafe static Func<Quest, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Sam.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Quest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Sam.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AC2 RID: 39618
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009AC3 RID: 39619
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04009AC4 RID: 39620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AC5 RID: 39621
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_0_Internal_Boolean_Quest_0;
		}
	}
}

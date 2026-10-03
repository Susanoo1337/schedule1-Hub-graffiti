using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003B6 RID: 950
	public class DialogueController_Jen : DialogueController
	{
		// Token: 0x06005639 RID: 22073 RVA: 0x001A59AC File Offset: 0x001A3BAC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Jen()
		{
			Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Jen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr);
			DialogueController_Jen.NativeFieldInfoPtr_BuyKeyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr, "BuyKeyText");
			DialogueController_Jen.NativeFieldInfoPtr_KeyItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr, "KeyItem");
			DialogueController_Jen.NativeFieldInfoPtr_BuyKeyDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr, "BuyKeyDialogue");
			DialogueController_Jen.NativeFieldInfoPtr_MinRelationToBuyKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr, "MinRelationToBuyKey");
			DialogueController_Jen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr, 100674599);
			DialogueController_Jen.NativeMethodInfoPtr_CanBuyKey_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr, 100674600);
			DialogueController_Jen.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr, 100674601);
			DialogueController_Jen.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr, 100674602);
			DialogueController_Jen.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr, 100674603);
			DialogueController_Jen.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr, 100674604);
			DialogueController_Jen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr, 100674605);
		}

		// Token: 0x0600563A RID: 22074 RVA: 0x001A5AB8 File Offset: 0x001A3CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190264, XrefRangeEnd = 190286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Jen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x001A5AF4 File Offset: 0x001A3CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190286, XrefRangeEnd = 190293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBuyKey(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController_Jen.NativeMethodInfoPtr_CanBuyKey_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600563C RID: 22076 RVA: 0x001A5B4C File Offset: 0x001A3D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190293, XrefRangeEnd = 190308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Jen.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x001A5BB4 File Offset: 0x001A3DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190308, XrefRangeEnd = 190325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Jen.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600563E RID: 22078 RVA: 0x001A5C1C File Offset: 0x001A3E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190325, XrefRangeEnd = 190337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Jen.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x001A5C90 File Offset: 0x001A3E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190337, XrefRangeEnd = 190357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Jen.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x001A5CE0 File Offset: 0x001A3EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190357, XrefRangeEnd = 190362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Jen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Jen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Jen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x00028C58 File Offset: 0x00026E58
		public DialogueController_Jen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x06005642 RID: 22082 RVA: 0x001A5D1C File Offset: 0x001A3F1C
		// (set) Token: 0x06005643 RID: 22083 RVA: 0x00028C61 File Offset: 0x00026E61
		public unsafe string BuyKeyText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Jen.NativeFieldInfoPtr_BuyKeyText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Jen.NativeFieldInfoPtr_BuyKeyText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x06005644 RID: 22084 RVA: 0x001A5D44 File Offset: 0x001A3F44
		// (set) Token: 0x06005645 RID: 22085 RVA: 0x00028C80 File Offset: 0x00026E80
		public unsafe StorableItemDefinition KeyItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Jen.NativeFieldInfoPtr_KeyItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Jen.NativeFieldInfoPtr_KeyItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x06005646 RID: 22086 RVA: 0x001A5D74 File Offset: 0x001A3F74
		// (set) Token: 0x06005647 RID: 22087 RVA: 0x00028C9F File Offset: 0x00026E9F
		public unsafe DialogueContainer BuyKeyDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Jen.NativeFieldInfoPtr_BuyKeyDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Jen.NativeFieldInfoPtr_BuyKeyDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06005648 RID: 22088 RVA: 0x001A5DA4 File Offset: 0x001A3FA4
		// (set) Token: 0x06005649 RID: 22089 RVA: 0x00028CBE File Offset: 0x00026EBE
		public unsafe float MinRelationToBuyKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Jen.NativeFieldInfoPtr_MinRelationToBuyKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Jen.NativeFieldInfoPtr_MinRelationToBuyKey)) = value;
			}
		}

		// Token: 0x04003B64 RID: 15204
		private static readonly IntPtr NativeFieldInfoPtr_BuyKeyText;

		// Token: 0x04003B65 RID: 15205
		private static readonly IntPtr NativeFieldInfoPtr_KeyItem;

		// Token: 0x04003B66 RID: 15206
		private static readonly IntPtr NativeFieldInfoPtr_BuyKeyDialogue;

		// Token: 0x04003B67 RID: 15207
		private static readonly IntPtr NativeFieldInfoPtr_MinRelationToBuyKey;

		// Token: 0x04003B68 RID: 15208
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003B69 RID: 15209
		private static readonly IntPtr NativeMethodInfoPtr_CanBuyKey_Private_Boolean_byref_String_0;

		// Token: 0x04003B6A RID: 15210
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0;

		// Token: 0x04003B6B RID: 15211
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04003B6C RID: 15212
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04003B6D RID: 15213
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x04003B6E RID: 15214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

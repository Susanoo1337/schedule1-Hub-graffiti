using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003B7 RID: 951
	public class DialogueController_Ming : DialogueController
	{
		// Token: 0x0600564A RID: 22090 RVA: 0x001A5DCC File Offset: 0x001A3FCC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Ming()
		{
			Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Ming");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr);
			DialogueController_Ming.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "Property");
			DialogueController_Ming.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "Price");
			DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "BuyDialogue");
			DialogueController_Ming.NativeFieldInfoPtr_BuyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "BuyText");
			DialogueController_Ming.NativeFieldInfoPtr_RemindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "RemindText");
			DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "RemindLocationDialogue");
			DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "PurchaseRoomQuests");
			DialogueController_Ming.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "onPurchase");
			DialogueController_Ming.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100674606);
			DialogueController_Ming.NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100674607);
			DialogueController_Ming.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100674608);
			DialogueController_Ming.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100674609);
			DialogueController_Ming.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100674610);
			DialogueController_Ming.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100674611);
			DialogueController_Ming.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100674612);
			DialogueController_Ming.NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100674613);
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x001A5F3C File Offset: 0x001A413C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190362, XrefRangeEnd = 190400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x001A5F78 File Offset: 0x001A4178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190400, XrefRangeEnd = 190405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBuyRoom(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x001A5FC4 File Offset: 0x001A41C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190405, XrefRangeEnd = 190420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x001A602C File Offset: 0x001A422C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190420, XrefRangeEnd = 190437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x001A6094 File Offset: 0x001A4294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190437, XrefRangeEnd = 190449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x001A6108 File Offset: 0x001A4308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190449, XrefRangeEnd = 190466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x001A6158 File Offset: 0x001A4358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190466, XrefRangeEnd = 190475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Ming() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x001A6194 File Offset: 0x001A4394
		[CallerCount(0)]
		public unsafe bool _Start_b__8_0(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x00028CD9 File Offset: 0x00026ED9
		public DialogueController_Ming(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06005654 RID: 22100 RVA: 0x001A61E0 File Offset: 0x001A43E0
		// (set) Token: 0x06005655 RID: 22101 RVA: 0x00028CE2 File Offset: 0x00026EE2
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06005656 RID: 22102 RVA: 0x001A6210 File Offset: 0x001A4410
		// (set) Token: 0x06005657 RID: 22103 RVA: 0x00028D01 File Offset: 0x00026F01
		public unsafe float Price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Price)) = value;
			}
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06005658 RID: 22104 RVA: 0x001A6238 File Offset: 0x001A4438
		// (set) Token: 0x06005659 RID: 22105 RVA: 0x00028D1C File Offset: 0x00026F1C
		public unsafe DialogueContainer BuyDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x0600565A RID: 22106 RVA: 0x001A6268 File Offset: 0x001A4468
		// (set) Token: 0x0600565B RID: 22107 RVA: 0x00028D3B File Offset: 0x00026F3B
		public unsafe string BuyText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x0600565C RID: 22108 RVA: 0x001A6290 File Offset: 0x001A4490
		// (set) Token: 0x0600565D RID: 22109 RVA: 0x00028D5A File Offset: 0x00026F5A
		public unsafe string RemindText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x0600565E RID: 22110 RVA: 0x001A62B8 File Offset: 0x001A44B8
		// (set) Token: 0x0600565F RID: 22111 RVA: 0x00028D79 File Offset: 0x00026F79
		public unsafe DialogueContainer RemindLocationDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06005660 RID: 22112 RVA: 0x001A62E8 File Offset: 0x001A44E8
		// (set) Token: 0x06005661 RID: 22113 RVA: 0x00028D98 File Offset: 0x00026F98
		public unsafe Il2CppReferenceArray<QuestEntry> PurchaseRoomQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06005662 RID: 22114 RVA: 0x001A6318 File Offset: 0x001A4518
		// (set) Token: 0x06005663 RID: 22115 RVA: 0x00028DB7 File Offset: 0x00026FB7
		public unsafe UnityEvent onPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_onPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B6F RID: 15215
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04003B70 RID: 15216
		private static readonly IntPtr NativeFieldInfoPtr_Price;

		// Token: 0x04003B71 RID: 15217
		private static readonly IntPtr NativeFieldInfoPtr_BuyDialogue;

		// Token: 0x04003B72 RID: 15218
		private static readonly IntPtr NativeFieldInfoPtr_BuyText;

		// Token: 0x04003B73 RID: 15219
		private static readonly IntPtr NativeFieldInfoPtr_RemindText;

		// Token: 0x04003B74 RID: 15220
		private static readonly IntPtr NativeFieldInfoPtr_RemindLocationDialogue;

		// Token: 0x04003B75 RID: 15221
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseRoomQuests;

		// Token: 0x04003B76 RID: 15222
		private static readonly IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x04003B77 RID: 15223
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003B78 RID: 15224
		private static readonly IntPtr NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0;

		// Token: 0x04003B79 RID: 15225
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0;

		// Token: 0x04003B7A RID: 15226
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04003B7B RID: 15227
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04003B7C RID: 15228
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x04003B7D RID: 15229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B7E RID: 15230
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0;

		// Token: 0x02000ABE RID: 2750
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_Ming+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600E3AB RID: 58283 RVA: 0x0037BFE8 File Offset: 0x0037A1E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr);
				DialogueController_Ming.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, "<>9");
				DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, "<>9__9_0");
				DialogueController_Ming.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, 100674615);
				DialogueController_Ming.__c.NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, 100674616);
			}

			// Token: 0x0600E3AC RID: 58284 RVA: 0x0037C064 File Offset: 0x0037A264
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3AD RID: 58285 RVA: 0x0037C0A0 File Offset: 0x0037A2A0
			[CallerCount(0)]
			public unsafe bool _CanBuyRoom_b__9_0(QuestEntry q)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.__c.NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E3AE RID: 58286 RVA: 0x0006B552 File Offset: 0x00069752
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004542 RID: 17730
			// (get) Token: 0x0600E3AF RID: 58287 RVA: 0x0037C0F0 File Offset: 0x0037A2F0
			// (set) Token: 0x0600E3B0 RID: 58288 RVA: 0x0006B55B File Offset: 0x0006975B
			public unsafe static DialogueController_Ming.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_Ming.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004543 RID: 17731
			// (get) Token: 0x0600E3B1 RID: 58289 RVA: 0x0037C118 File Offset: 0x0037A318
			// (set) Token: 0x0600E3B2 RID: 58290 RVA: 0x0006B56D File Offset: 0x0006976D
			public unsafe static Func<QuestEntry, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<QuestEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009ABE RID: 39614
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009ABF RID: 39615
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04009AC0 RID: 39616
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AC1 RID: 39617
			private static readonly IntPtr NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0;
		}
	}
}

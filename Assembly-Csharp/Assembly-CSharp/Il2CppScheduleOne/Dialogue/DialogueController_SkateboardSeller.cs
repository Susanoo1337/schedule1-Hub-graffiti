using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003B9 RID: 953
	public class DialogueController_SkateboardSeller : DialogueController
	{
		// Token: 0x0600566D RID: 22125 RVA: 0x001A65C4 File Offset: 0x001A47C4
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_SkateboardSeller()
		{
			Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_SkateboardSeller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr);
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "Options");
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "chosenWeapon");
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "onPurchase");
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100674625);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100674626);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100674627);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100674628);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100674629);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100674630);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100674631);
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x001A66BC File Offset: 0x001A48BC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x001A66F0 File Offset: 0x001A48F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190551, XrefRangeEnd = 190597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x001A6740 File Offset: 0x001A4940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190597, XrefRangeEnd = 190612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x001A67B4 File Offset: 0x001A49B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190652, RefRangeEnd = 190653, XrefRangeStart = 190612, XrefRangeEnd = 190652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueChoiceData> GetChoices(List<DialogueController_SkateboardSeller.Option> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr3) : null;
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x001A6804 File Offset: 0x001A4A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190653, XrefRangeEnd = 190678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x001A6878 File Offset: 0x001A4A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190678, XrefRangeEnd = 190698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x001A68E0 File Offset: 0x001A4AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190698, XrefRangeEnd = 190706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_SkateboardSeller() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x00028DFE File Offset: 0x00026FFE
		public DialogueController_SkateboardSeller(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06005676 RID: 22134 RVA: 0x001A691C File Offset: 0x001A4B1C
		// (set) Token: 0x06005677 RID: 22135 RVA: 0x00028E07 File Offset: 0x00027007
		public unsafe List<DialogueController_SkateboardSeller.Option> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_SkateboardSeller.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06005678 RID: 22136 RVA: 0x001A694C File Offset: 0x001A4B4C
		// (set) Token: 0x06005679 RID: 22137 RVA: 0x00028E26 File Offset: 0x00027026
		public unsafe DialogueController_SkateboardSeller.Option chosenWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_SkateboardSeller.Option>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x0600567A RID: 22138 RVA: 0x001A697C File Offset: 0x001A4B7C
		// (set) Token: 0x0600567B RID: 22139 RVA: 0x00028E45 File Offset: 0x00027045
		public unsafe UnityEvent onPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B85 RID: 15237
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04003B86 RID: 15238
		private static readonly IntPtr NativeFieldInfoPtr_chosenWeapon;

		// Token: 0x04003B87 RID: 15239
		private static readonly IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x04003B88 RID: 15240
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003B89 RID: 15241
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x04003B8A RID: 15242
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x04003B8B RID: 15243
		private static readonly IntPtr NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0;

		// Token: 0x04003B8C RID: 15244
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04003B8D RID: 15245
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04003B8E RID: 15246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC0 RID: 2752
		[Serializable]
		public class Option : Object
		{
			// Token: 0x0600E3BB RID: 58299 RVA: 0x0037C298 File Offset: 0x0037A498
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr);
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Name");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Price");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "IsAvailable");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "NotAvailableReason");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Item");
				DialogueController_SkateboardSeller.Option.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, 100674632);
			}

			// Token: 0x0600E3BC RID: 58300 RVA: 0x0037C33C File Offset: 0x0037A53C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.Option.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3BD RID: 58301 RVA: 0x0006B5AC File Offset: 0x000697AC
			public Option(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004546 RID: 17734
			// (get) Token: 0x0600E3BE RID: 58302 RVA: 0x0037C378 File Offset: 0x0037A578
			// (set) Token: 0x0600E3BF RID: 58303 RVA: 0x0006B5B5 File Offset: 0x000697B5
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004547 RID: 17735
			// (get) Token: 0x0600E3C0 RID: 58304 RVA: 0x0037C3A0 File Offset: 0x0037A5A0
			// (set) Token: 0x0600E3C1 RID: 58305 RVA: 0x0006B5D4 File Offset: 0x000697D4
			public unsafe float Price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price)) = value;
				}
			}

			// Token: 0x17004548 RID: 17736
			// (get) Token: 0x0600E3C2 RID: 58306 RVA: 0x0037C3C8 File Offset: 0x0037A5C8
			// (set) Token: 0x0600E3C3 RID: 58307 RVA: 0x0006B5EF File Offset: 0x000697EF
			public unsafe bool IsAvailable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable)) = value;
				}
			}

			// Token: 0x17004549 RID: 17737
			// (get) Token: 0x0600E3C4 RID: 58308 RVA: 0x0037C3F0 File Offset: 0x0037A5F0
			// (set) Token: 0x0600E3C5 RID: 58309 RVA: 0x0006B60A File Offset: 0x0006980A
			public unsafe string NotAvailableReason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700454A RID: 17738
			// (get) Token: 0x0600E3C6 RID: 58310 RVA: 0x0037C418 File Offset: 0x0037A618
			// (set) Token: 0x0600E3C7 RID: 58311 RVA: 0x0006B629 File Offset: 0x00069829
			public unsafe ItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AC6 RID: 39622
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04009AC7 RID: 39623
			private static readonly IntPtr NativeFieldInfoPtr_Price;

			// Token: 0x04009AC8 RID: 39624
			private static readonly IntPtr NativeFieldInfoPtr_IsAvailable;

			// Token: 0x04009AC9 RID: 39625
			private static readonly IntPtr NativeFieldInfoPtr_NotAvailableReason;

			// Token: 0x04009ACA RID: 39626
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04009ACB RID: 39627
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AC1 RID: 2753
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_SkateboardSeller+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x0600E3C8 RID: 58312 RVA: 0x0037C448 File Offset: 0x0037A648
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr);
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, "choiceLabel");
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, 100674633);
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, 100674634);
			}

			// Token: 0x0600E3C9 RID: 58313 RVA: 0x0037C4B0 File Offset: 0x0037A6B0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3CA RID: 58314 RVA: 0x0037C4EC File Offset: 0x0037A6EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(DialogueController_SkateboardSeller.Option x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E3CB RID: 58315 RVA: 0x0006B648 File Offset: 0x00069848
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700454B RID: 17739
			// (get) Token: 0x0600E3CC RID: 58316 RVA: 0x0037C53C File Offset: 0x0037A73C
			// (set) Token: 0x0600E3CD RID: 58317 RVA: 0x0006B651 File Offset: 0x00069851
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009ACC RID: 39628
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04009ACD RID: 39629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009ACE RID: 39630
			private static readonly IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0;
		}

		// Token: 0x02000AC2 RID: 2754
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_SkateboardSeller+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600E3CE RID: 58318 RVA: 0x0037C564 File Offset: 0x0037A764
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr);
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, "choiceLabel");
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, 100674635);
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, 100674636);
			}

			// Token: 0x0600E3CF RID: 58319 RVA: 0x0037C5CC File Offset: 0x0037A7CC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3D0 RID: 58320 RVA: 0x0037C608 File Offset: 0x0037A808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__0(DialogueController_SkateboardSeller.Option x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E3D1 RID: 58321 RVA: 0x0006B670 File Offset: 0x00069870
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700454C RID: 17740
			// (get) Token: 0x0600E3D2 RID: 58322 RVA: 0x0037C658 File Offset: 0x0037A858
			// (set) Token: 0x0600E3D3 RID: 58323 RVA: 0x0006B679 File Offset: 0x00069879
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009ACF RID: 39631
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04009AD0 RID: 39632
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AD1 RID: 39633
			private static readonly IntPtr NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0;
		}
	}
}

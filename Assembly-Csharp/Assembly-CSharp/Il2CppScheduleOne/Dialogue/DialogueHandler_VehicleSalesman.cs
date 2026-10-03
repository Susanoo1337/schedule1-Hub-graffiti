using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003CD RID: 973
	public class DialogueHandler_VehicleSalesman : ControlledDialogueHandler
	{
		// Token: 0x060057AD RID: 22445 RVA: 0x001AB194 File Offset: 0x001A9394
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler_VehicleSalesman()
		{
			Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler_VehicleSalesman");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr);
			DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_Salesman = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "Salesman");
			DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_selectedVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "selectedVehicle");
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100674827);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100674828);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100674829);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100674830);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100674831);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100674832);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100674833);
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x001AB278 File Offset: 0x001A9478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192492, XrefRangeEnd = 192528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x001AB2E0 File Offset: 0x001A94E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192528, XrefRangeEnd = 192543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x001AB354 File Offset: 0x001A9554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192543, XrefRangeEnd = 192568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x001AB3A4 File Offset: 0x001A95A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192568, XrefRangeEnd = 192576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CheckBranch(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x001AB3FC File Offset: 0x001A95FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192576, XrefRangeEnd = 192577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DialogueCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x001AB44C File Offset: 0x001A964C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192577, XrefRangeEnd = 192586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x001AB4B4 File Offset: 0x001A96B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler_VehicleSalesman() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x0002963C File Offset: 0x0002783C
		public DialogueHandler_VehicleSalesman(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x060057B6 RID: 22454 RVA: 0x001AB4F0 File Offset: 0x001A96F0
		// (set) Token: 0x060057B7 RID: 22455 RVA: 0x00029645 File Offset: 0x00027845
		public unsafe Jeremy Salesman
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_Salesman);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jeremy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_Salesman), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x001AB520 File Offset: 0x001A9720
		// (set) Token: 0x060057B9 RID: 22457 RVA: 0x00029664 File Offset: 0x00027864
		public unsafe Jeremy.DealershipListing selectedVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_selectedVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jeremy.DealershipListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_selectedVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C5B RID: 15451
		private static readonly IntPtr NativeFieldInfoPtr_Salesman;

		// Token: 0x04003C5C RID: 15452
		private static readonly IntPtr NativeFieldInfoPtr_selectedVehicle;

		// Token: 0x04003C5D RID: 15453
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0;

		// Token: 0x04003C5E RID: 15454
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04003C5F RID: 15455
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0;

		// Token: 0x04003C60 RID: 15456
		private static readonly IntPtr NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0;

		// Token: 0x04003C61 RID: 15457
		private static readonly IntPtr NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0;

		// Token: 0x04003C62 RID: 15458
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0;

		// Token: 0x04003C63 RID: 15459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ACF RID: 2767
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_VehicleSalesman+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600E445 RID: 58437 RVA: 0x0037DAD4 File Offset: 0x0037BCD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr, 100674834);
				DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_DealershipListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr, 100674835);
			}

			// Token: 0x0600E446 RID: 58438 RVA: 0x0037DB3C File Offset: 0x0037BD3C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E447 RID: 58439 RVA: 0x0037DB78 File Offset: 0x0037BD78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ModifyChoiceText_b__0(Jeremy.DealershipListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_DealershipListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E448 RID: 58440 RVA: 0x0006BA2E File Offset: 0x00069C2E
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700456B RID: 17771
			// (get) Token: 0x0600E449 RID: 58441 RVA: 0x0037DBC8 File Offset: 0x0037BDC8
			// (set) Token: 0x0600E44A RID: 58442 RVA: 0x0006BA37 File Offset: 0x00069C37
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B0F RID: 39695
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04009B10 RID: 39696
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B11 RID: 39697
			private static readonly IntPtr NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_DealershipListing_0;
		}

		// Token: 0x02000AD0 RID: 2768
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_VehicleSalesman+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600E44B RID: 58443 RVA: 0x0037DBF0 File Offset: 0x0037BDF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr);
				DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr, 100674836);
				DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_DealershipListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr, 100674837);
			}

			// Token: 0x0600E44C RID: 58444 RVA: 0x0037DC58 File Offset: 0x0037BE58
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E44D RID: 58445 RVA: 0x0037DC94 File Offset: 0x0037BE94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(Jeremy.DealershipListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_DealershipListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E44E RID: 58446 RVA: 0x0006BA56 File Offset: 0x00069C56
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700456C RID: 17772
			// (get) Token: 0x0600E44F RID: 58447 RVA: 0x0037DCE4 File Offset: 0x0037BEE4
			// (set) Token: 0x0600E450 RID: 58448 RVA: 0x0006BA5F File Offset: 0x00069C5F
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B12 RID: 39698
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04009B13 RID: 39699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B14 RID: 39700
			private static readonly IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_DealershipListing_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003B3 RID: 947
	public class DialogueController_Billy : DialogueController
	{
		// Token: 0x0600561C RID: 22044 RVA: 0x001A529C File Offset: 0x001A349C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Billy()
		{
			Il2CppClassPointerStore<DialogueController_Billy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Billy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Billy>.NativeClassPtr);
			DialogueController_Billy.NativeFieldInfoPtr_questDefeatCartel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Billy>.NativeClassPtr, "questDefeatCartel");
			DialogueController_Billy.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Billy>.NativeClassPtr, 100674583);
			DialogueController_Billy.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Billy>.NativeClassPtr, 100674584);
			DialogueController_Billy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Billy>.NativeClassPtr, 100674585);
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x001A531C File Offset: 0x001A351C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190005, XrefRangeEnd = 190043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Billy.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x001A5358 File Offset: 0x001A3558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190043, XrefRangeEnd = 190049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Billy.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x001A53C0 File Offset: 0x001A35C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Billy() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Billy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Billy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x00028BAA File Offset: 0x00026DAA
		public DialogueController_Billy(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06005621 RID: 22049 RVA: 0x001A53FC File Offset: 0x001A35FC
		// (set) Token: 0x06005622 RID: 22050 RVA: 0x00028BB3 File Offset: 0x00026DB3
		public unsafe Quest_DefeatCartel questDefeatCartel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Billy.NativeFieldInfoPtr_questDefeatCartel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_DefeatCartel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Billy.NativeFieldInfoPtr_questDefeatCartel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B52 RID: 15186
		private static readonly IntPtr NativeFieldInfoPtr_questDefeatCartel;

		// Token: 0x04003B53 RID: 15187
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003B54 RID: 15188
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04003B55 RID: 15189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ABD RID: 2749
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_Billy+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600E3A3 RID: 58275 RVA: 0x0037BE90 File Offset: 0x0037A090
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogueController_Billy.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_Billy>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Billy.__c>.NativeClassPtr);
				DialogueController_Billy.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Billy.__c>.NativeClassPtr, "<>9");
				DialogueController_Billy.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Billy.__c>.NativeClassPtr, "<>9__1_0");
				DialogueController_Billy.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Billy.__c>.NativeClassPtr, 100674587);
				DialogueController_Billy.__c.NativeMethodInfoPtr__Start_b__1_0_Internal_Boolean_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Billy.__c>.NativeClassPtr, 100674588);
			}

			// Token: 0x0600E3A4 RID: 58276 RVA: 0x0037BF0C File Offset: 0x0037A10C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Billy.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Billy.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3A5 RID: 58277 RVA: 0x0037BF48 File Offset: 0x0037A148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190003, XrefRangeEnd = 190005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__1_0(Quest q)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Billy.__c.NativeMethodInfoPtr__Start_b__1_0_Internal_Boolean_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E3A6 RID: 58278 RVA: 0x0006B525 File Offset: 0x00069725
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004540 RID: 17728
			// (get) Token: 0x0600E3A7 RID: 58279 RVA: 0x0037BF98 File Offset: 0x0037A198
			// (set) Token: 0x0600E3A8 RID: 58280 RVA: 0x0006B52E File Offset: 0x0006972E
			public unsafe static DialogueController_Billy.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Billy.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_Billy.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Billy.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004541 RID: 17729
			// (get) Token: 0x0600E3A9 RID: 58281 RVA: 0x0037BFC0 File Offset: 0x0037A1C0
			// (set) Token: 0x0600E3AA RID: 58282 RVA: 0x0006B540 File Offset: 0x00069740
			public unsafe static Func<Quest, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Billy.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Quest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Billy.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009ABA RID: 39610
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009ABB RID: 39611
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04009ABC RID: 39612
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009ABD RID: 39613
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_0_Internal_Boolean_Quest_0;
		}
	}
}

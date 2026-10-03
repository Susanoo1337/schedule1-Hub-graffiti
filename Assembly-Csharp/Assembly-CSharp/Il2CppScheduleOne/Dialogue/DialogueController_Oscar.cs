using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003C0 RID: 960
	public class DialogueController_Oscar : DialogueController
	{
		// Token: 0x060056EB RID: 22251 RVA: 0x001A8598 File Offset: 0x001A6798
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Oscar()
		{
			Il2CppClassPointerStore<DialogueController_Oscar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Oscar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Oscar>.NativeClassPtr);
			DialogueController_Oscar.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Oscar>.NativeClassPtr, 100674713);
			DialogueController_Oscar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Oscar>.NativeClassPtr, 100674714);
		}

		// Token: 0x060056EC RID: 22252 RVA: 0x001A85F0 File Offset: 0x001A67F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191498, XrefRangeEnd = 191530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Oscar.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x001A8658 File Offset: 0x001A6858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Oscar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Oscar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Oscar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x000290FD File Offset: 0x000272FD
		public DialogueController_Oscar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003BDC RID: 15324
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04003BDD RID: 15325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

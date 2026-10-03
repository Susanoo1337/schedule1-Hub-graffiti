using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003B4 RID: 948
	public class DialogueController_Dan : DialogueController
	{
		// Token: 0x06005623 RID: 22051 RVA: 0x001A542C File Offset: 0x001A362C
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Dan()
		{
			Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Dan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr);
			DialogueController_Dan.NativeFieldInfoPtr_ItemToGive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr, "ItemToGive");
			DialogueController_Dan.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr, 100674589);
			DialogueController_Dan.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr, 100674590);
			DialogueController_Dan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr, 100674591);
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x001A54AC File Offset: 0x001A36AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190049, XrefRangeEnd = 190060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Dan.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x001A54E8 File Offset: 0x001A36E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190060, XrefRangeEnd = 190073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Dan.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x001A5550 File Offset: 0x001A3750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Dan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Dan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Dan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x00028BD2 File Offset: 0x00026DD2
		public DialogueController_Dan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06005628 RID: 22056 RVA: 0x001A558C File Offset: 0x001A378C
		// (set) Token: 0x06005629 RID: 22057 RVA: 0x00028BDB File Offset: 0x00026DDB
		public unsafe ItemDefinition ItemToGive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Dan.NativeFieldInfoPtr_ItemToGive);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Dan.NativeFieldInfoPtr_ItemToGive), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B56 RID: 15190
		private static readonly IntPtr NativeFieldInfoPtr_ItemToGive;

		// Token: 0x04003B57 RID: 15191
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003B58 RID: 15192
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04003B59 RID: 15193
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

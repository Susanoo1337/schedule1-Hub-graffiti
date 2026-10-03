using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003BC RID: 956
	public class DialogueChoiceEnabler : MonoBehaviour
	{
		// Token: 0x0600568F RID: 22159 RVA: 0x001A6F68 File Offset: 0x001A5168
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChoiceEnabler()
		{
			Il2CppClassPointerStore<DialogueChoiceEnabler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueChoiceEnabler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChoiceEnabler>.NativeClassPtr);
			DialogueChoiceEnabler.NativeFieldInfoPtr_DialogueController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEnabler>.NativeClassPtr, "DialogueController");
			DialogueChoiceEnabler.NativeFieldInfoPtr_ChoiceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEnabler>.NativeClassPtr, "ChoiceIndex");
			DialogueChoiceEnabler.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceEnabler>.NativeClassPtr, "choice");
			DialogueChoiceEnabler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEnabler>.NativeClassPtr, 100674656);
			DialogueChoiceEnabler.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEnabler>.NativeClassPtr, 100674657);
			DialogueChoiceEnabler.NativeMethodInfoPtr_EnableChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEnabler>.NativeClassPtr, 100674658);
			DialogueChoiceEnabler.NativeMethodInfoPtr_DisableChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEnabler>.NativeClassPtr, 100674659);
			DialogueChoiceEnabler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceEnabler>.NativeClassPtr, 100674660);
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x001A7038 File Offset: 0x001A5238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190799, XrefRangeEnd = 190814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEnabler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x001A706C File Offset: 0x001A526C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190814, XrefRangeEnd = 190843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEnabler.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x001A70A0 File Offset: 0x001A52A0
		[CallerCount(0)]
		public unsafe void EnableChoice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEnabler.NativeMethodInfoPtr_EnableChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x001A70D4 File Offset: 0x001A52D4
		[CallerCount(0)]
		public unsafe void DisableChoice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEnabler.NativeMethodInfoPtr_DisableChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x001A7108 File Offset: 0x001A5308
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChoiceEnabler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChoiceEnabler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceEnabler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005695 RID: 22165 RVA: 0x00028E95 File Offset: 0x00027095
		public DialogueChoiceEnabler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06005696 RID: 22166 RVA: 0x001A7144 File Offset: 0x001A5344
		// (set) Token: 0x06005697 RID: 22167 RVA: 0x00028E9E File Offset: 0x0002709E
		public unsafe DialogueController DialogueController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEnabler.NativeFieldInfoPtr_DialogueController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEnabler.NativeFieldInfoPtr_DialogueController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06005698 RID: 22168 RVA: 0x001A7174 File Offset: 0x001A5374
		// (set) Token: 0x06005699 RID: 22169 RVA: 0x00028EBD File Offset: 0x000270BD
		public unsafe int ChoiceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEnabler.NativeFieldInfoPtr_ChoiceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEnabler.NativeFieldInfoPtr_ChoiceIndex)) = value;
			}
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x0600569A RID: 22170 RVA: 0x001A719C File Offset: 0x001A539C
		// (set) Token: 0x0600569B RID: 22171 RVA: 0x00028ED8 File Offset: 0x000270D8
		public unsafe DialogueController.DialogueChoice choice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEnabler.NativeFieldInfoPtr_choice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceEnabler.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B9D RID: 15261
		private static readonly IntPtr NativeFieldInfoPtr_DialogueController;

		// Token: 0x04003B9E RID: 15262
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceIndex;

		// Token: 0x04003B9F RID: 15263
		private static readonly IntPtr NativeFieldInfoPtr_choice;

		// Token: 0x04003BA0 RID: 15264
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003BA1 RID: 15265
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003BA2 RID: 15266
		private static readonly IntPtr NativeMethodInfoPtr_EnableChoice_Public_Void_0;

		// Token: 0x04003BA3 RID: 15267
		private static readonly IntPtr NativeMethodInfoPtr_DisableChoice_Public_Void_0;

		// Token: 0x04003BA4 RID: 15268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

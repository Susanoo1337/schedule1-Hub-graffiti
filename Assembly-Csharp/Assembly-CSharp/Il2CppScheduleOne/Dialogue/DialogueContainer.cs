using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003D4 RID: 980
	[Serializable]
	public class DialogueContainer : ScriptableObject
	{
		// Token: 0x060057EB RID: 22507 RVA: 0x001ABDE4 File Offset: 0x001A9FE4
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueContainer()
		{
			Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr);
			DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<allowExit>k__BackingField");
			DialogueContainer.NativeFieldInfoPtr_NodeLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "NodeLinks");
			DialogueContainer.NativeFieldInfoPtr_DialogueNodeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "DialogueNodeData");
			DialogueContainer.NativeFieldInfoPtr_BranchNodeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "BranchNodeData");
			DialogueContainer.NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100674855);
			DialogueContainer.NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100674856);
			DialogueContainer.NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100674857);
			DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100674858);
			DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100674859);
			DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100674860);
			DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100674861);
			DialogueContainer.NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100674862);
			DialogueContainer.NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100674863);
			DialogueContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, 100674864);
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x060057EC RID: 22508 RVA: 0x001ABF2C File Offset: 0x001AA12C
		// (set) Token: 0x060057ED RID: 22509 RVA: 0x001ABF68 File Offset: 0x001AA168
		public unsafe bool allowExit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 192743, RefRangeEnd = 192745, XrefRangeStart = 192743, XrefRangeEnd = 192743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001B1D RID: 6941
		// (get) Token: 0x060057EE RID: 22510 RVA: 0x001ABFA8 File Offset: 0x001AA1A8
		public unsafe bool AllowExit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 192751, RefRangeEnd = 192752, XrefRangeStart = 192745, XrefRangeEnd = 192751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x001ABFE4 File Offset: 0x001AA1E4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 192767, RefRangeEnd = 192776, XrefRangeStart = 192752, XrefRangeEnd = 192767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetDialogueNodeByLabel(string dialogueNodeLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueNodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x001AC034 File Offset: 0x001AA234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192791, RefRangeEnd = 192793, XrefRangeStart = 192776, XrefRangeEnd = 192791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData GetBranchNodeByLabel(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BranchNodeData>(intPtr3) : null;
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x001AC084 File Offset: 0x001AA284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192808, RefRangeEnd = 192810, XrefRangeStart = 192793, XrefRangeEnd = 192808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeData GetDialogueNodeByGUID(string dialogueNodeGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueNodeGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x060057F2 RID: 22514 RVA: 0x001AC0D4 File Offset: 0x001AA2D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192825, RefRangeEnd = 192827, XrefRangeStart = 192810, XrefRangeEnd = 192825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchNodeData GetBranchNodeByGUID(string branchGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BranchNodeData>(intPtr3) : null;
		}

		// Token: 0x060057F3 RID: 22515 RVA: 0x001AC124 File Offset: 0x001AA324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192842, RefRangeEnd = 192843, XrefRangeStart = 192827, XrefRangeEnd = 192842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseChoiceOrOptionGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NodeLinkData>(intPtr3) : null;
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x001AC174 File Offset: 0x001AA374
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 192743, RefRangeEnd = 192745, XrefRangeStart = 192743, XrefRangeEnd = 192745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllowExit(bool allowed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref allowed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x001AC1B4 File Offset: 0x001AA3B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 192865, RefRangeEnd = 192868, XrefRangeStart = 192843, XrefRangeEnd = 192865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x00029837 File Offset: 0x00027A37
		public DialogueContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x060057F7 RID: 22519 RVA: 0x001AC1F0 File Offset: 0x001AA3F0
		// (set) Token: 0x060057F8 RID: 22520 RVA: 0x00029840 File Offset: 0x00027A40
		public unsafe bool _allowExit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr__allowExit_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x060057F9 RID: 22521 RVA: 0x001AC218 File Offset: 0x001AA418
		// (set) Token: 0x060057FA RID: 22522 RVA: 0x0002985B File Offset: 0x00027A5B
		public unsafe List<NodeLinkData> NodeLinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_NodeLinks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLinkData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_NodeLinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x060057FB RID: 22523 RVA: 0x001AC248 File Offset: 0x001AA448
		// (set) Token: 0x060057FC RID: 22524 RVA: 0x0002987A File Offset: 0x00027A7A
		public unsafe List<DialogueNodeData> DialogueNodeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_DialogueNodeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueNodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_DialogueNodeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x060057FD RID: 22525 RVA: 0x001AC278 File Offset: 0x001AA478
		// (set) Token: 0x060057FE RID: 22526 RVA: 0x00029899 File Offset: 0x00027A99
		public unsafe List<BranchNodeData> BranchNodeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_BranchNodeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BranchNodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.NativeFieldInfoPtr_BranchNodeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C87 RID: 15495
		private static readonly IntPtr NativeFieldInfoPtr__allowExit_k__BackingField;

		// Token: 0x04003C88 RID: 15496
		private static readonly IntPtr NativeFieldInfoPtr_NodeLinks;

		// Token: 0x04003C89 RID: 15497
		private static readonly IntPtr NativeFieldInfoPtr_DialogueNodeData;

		// Token: 0x04003C8A RID: 15498
		private static readonly IntPtr NativeFieldInfoPtr_BranchNodeData;

		// Token: 0x04003C8B RID: 15499
		private static readonly IntPtr NativeMethodInfoPtr_get_allowExit_Public_get_Boolean_0;

		// Token: 0x04003C8C RID: 15500
		private static readonly IntPtr NativeMethodInfoPtr_set_allowExit_Private_set_Void_Boolean_0;

		// Token: 0x04003C8D RID: 15501
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowExit_Public_get_Boolean_0;

		// Token: 0x04003C8E RID: 15502
		private static readonly IntPtr NativeMethodInfoPtr_GetDialogueNodeByLabel_Public_DialogueNodeData_String_0;

		// Token: 0x04003C8F RID: 15503
		private static readonly IntPtr NativeMethodInfoPtr_GetBranchNodeByLabel_Public_BranchNodeData_String_0;

		// Token: 0x04003C90 RID: 15504
		private static readonly IntPtr NativeMethodInfoPtr_GetDialogueNodeByGUID_Public_DialogueNodeData_String_0;

		// Token: 0x04003C91 RID: 15505
		private static readonly IntPtr NativeMethodInfoPtr_GetBranchNodeByGUID_Public_BranchNodeData_String_0;

		// Token: 0x04003C92 RID: 15506
		private static readonly IntPtr NativeMethodInfoPtr_GetLink_Public_NodeLinkData_String_0;

		// Token: 0x04003C93 RID: 15507
		private static readonly IntPtr NativeMethodInfoPtr_SetAllowExit_Public_Void_Boolean_0;

		// Token: 0x04003C94 RID: 15508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AD3 RID: 2771
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E45D RID: 58461 RVA: 0x0037DF48 File Offset: 0x0037C148
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, "branchLabel");
				DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, 100674865);
				DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr, 100674866);
			}

			// Token: 0x0600E45E RID: 58462 RVA: 0x0037DFB0 File Offset: 0x0037C1B0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E45F RID: 58463 RVA: 0x0037DFEC File Offset: 0x0037C1EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBranchNodeByLabel_b__0(BranchNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass10_0.NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E460 RID: 58464 RVA: 0x0006BACA File Offset: 0x00069CCA
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700456F RID: 17775
			// (get) Token: 0x0600E461 RID: 58465 RVA: 0x0037E03C File Offset: 0x0037C23C
			// (set) Token: 0x0600E462 RID: 58466 RVA: 0x0006BAD3 File Offset: 0x00069CD3
			public unsafe string branchLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass10_0.NativeFieldInfoPtr_branchLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B1B RID: 39707
			private static readonly IntPtr NativeFieldInfoPtr_branchLabel;

			// Token: 0x04009B1C RID: 39708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B1D RID: 39709
			private static readonly IntPtr NativeMethodInfoPtr__GetBranchNodeByLabel_b__0_Internal_Boolean_BranchNodeData_0;
		}

		// Token: 0x02000AD4 RID: 2772
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E463 RID: 58467 RVA: 0x0037E064 File Offset: 0x0037C264
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, "dialogueNodeGUID");
				DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, 100674867);
				DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr, 100674868);
			}

			// Token: 0x0600E464 RID: 58468 RVA: 0x0037E0CC File Offset: 0x0037C2CC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E465 RID: 58469 RVA: 0x0037E108 File Offset: 0x0037C308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDialogueNodeByGUID_b__0(DialogueNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass11_0.NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E466 RID: 58470 RVA: 0x0006BAF2 File Offset: 0x00069CF2
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004570 RID: 17776
			// (get) Token: 0x0600E467 RID: 58471 RVA: 0x0037E158 File Offset: 0x0037C358
			// (set) Token: 0x0600E468 RID: 58472 RVA: 0x0006BAFB File Offset: 0x00069CFB
			public unsafe string dialogueNodeGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass11_0.NativeFieldInfoPtr_dialogueNodeGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B1E RID: 39710
			private static readonly IntPtr NativeFieldInfoPtr_dialogueNodeGUID;

			// Token: 0x04009B1F RID: 39711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B20 RID: 39712
			private static readonly IntPtr NativeMethodInfoPtr__GetDialogueNodeByGUID_b__0_Internal_Boolean_DialogueNodeData_0;
		}

		// Token: 0x02000AD5 RID: 2773
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E469 RID: 58473 RVA: 0x0037E180 File Offset: 0x0037C380
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, "branchGUID");
				DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, 100674869);
				DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr, 100674870);
			}

			// Token: 0x0600E46A RID: 58474 RVA: 0x0037E1E8 File Offset: 0x0037C3E8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E46B RID: 58475 RVA: 0x0037E224 File Offset: 0x0037C424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBranchNodeByGUID_b__0(BranchNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass12_0.NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E46C RID: 58476 RVA: 0x0006BB1A File Offset: 0x00069D1A
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004571 RID: 17777
			// (get) Token: 0x0600E46D RID: 58477 RVA: 0x0037E274 File Offset: 0x0037C474
			// (set) Token: 0x0600E46E RID: 58478 RVA: 0x0006BB23 File Offset: 0x00069D23
			public unsafe string branchGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass12_0.NativeFieldInfoPtr_branchGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B21 RID: 39713
			private static readonly IntPtr NativeFieldInfoPtr_branchGUID;

			// Token: 0x04009B22 RID: 39714
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B23 RID: 39715
			private static readonly IntPtr NativeMethodInfoPtr__GetBranchNodeByGUID_b__0_Internal_Boolean_BranchNodeData_0;
		}

		// Token: 0x02000AD6 RID: 2774
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E46F RID: 58479 RVA: 0x0037E29C File Offset: 0x0037C49C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, "baseChoiceOrOptionGUID");
				DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, 100674871);
				DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr, 100674872);
			}

			// Token: 0x0600E470 RID: 58480 RVA: 0x0037E304 File Offset: 0x0037C504
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E471 RID: 58481 RVA: 0x0037E340 File Offset: 0x0037C540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLink_b__0(NodeLinkData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass13_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E472 RID: 58482 RVA: 0x0006BB42 File Offset: 0x00069D42
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004572 RID: 17778
			// (get) Token: 0x0600E473 RID: 58483 RVA: 0x0037E390 File Offset: 0x0037C590
			// (set) Token: 0x0600E474 RID: 58484 RVA: 0x0006BB4B File Offset: 0x00069D4B
			public unsafe string baseChoiceOrOptionGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass13_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B24 RID: 39716
			private static readonly IntPtr NativeFieldInfoPtr_baseChoiceOrOptionGUID;

			// Token: 0x04009B25 RID: 39717
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B26 RID: 39718
			private static readonly IntPtr NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0;
		}

		// Token: 0x02000AD7 RID: 2775
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueContainer+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E475 RID: 58485 RVA: 0x0037E3B8 File Offset: 0x0037C5B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueContainer>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr);
				DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, "dialogueNodeLabel");
				DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, 100674873);
				DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr, 100674874);
			}

			// Token: 0x0600E476 RID: 58486 RVA: 0x0037E420 File Offset: 0x0037C620
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueContainer.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E477 RID: 58487 RVA: 0x0037E45C File Offset: 0x0037C65C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 192713, XrefRangeEnd = 192743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDialogueNodeByLabel_b__0(DialogueNodeData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueContainer.__c__DisplayClass9_0.NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E478 RID: 58488 RVA: 0x0006BB6A File Offset: 0x00069D6A
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004573 RID: 17779
			// (get) Token: 0x0600E479 RID: 58489 RVA: 0x0037E4AC File Offset: 0x0037C6AC
			// (set) Token: 0x0600E47A RID: 58490 RVA: 0x0006BB73 File Offset: 0x00069D73
			public unsafe string dialogueNodeLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueContainer.__c__DisplayClass9_0.NativeFieldInfoPtr_dialogueNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009B27 RID: 39719
			private static readonly IntPtr NativeFieldInfoPtr_dialogueNodeLabel;

			// Token: 0x04009B28 RID: 39720
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B29 RID: 39721
			private static readonly IntPtr NativeMethodInfoPtr__GetDialogueNodeByLabel_b__0_Internal_Boolean_DialogueNodeData_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x020003D3 RID: 979
	[Serializable]
	public class DialogueChoiceData : Object
	{
		// Token: 0x060057DF RID: 22495 RVA: 0x001ABC20 File Offset: 0x001A9E20
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueChoiceData()
		{
			Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueChoiceData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr);
			DialogueChoiceData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "Guid");
			DialogueChoiceData.NativeFieldInfoPtr_ChoiceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "ChoiceText");
			DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "ChoiceLabel");
			DialogueChoiceData.NativeFieldInfoPtr_ShowWorldspaceDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, "ShowWorldspaceDialogue");
			DialogueChoiceData.NativeMethodInfoPtr_GetCopy_Public_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, 100674853);
			DialogueChoiceData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr, 100674854);
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x001ABCC8 File Offset: 0x001A9EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 192703, RefRangeEnd = 192704, XrefRangeStart = 192696, XrefRangeEnd = 192703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChoiceData GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceData.NativeMethodInfoPtr_GetCopy_Public_DialogueChoiceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChoiceData>(intPtr3) : null;
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x001ABD08 File Offset: 0x001A9F08
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 192705, RefRangeEnd = 192713, XrefRangeStart = 192704, XrefRangeEnd = 192705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChoiceData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueChoiceData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueChoiceData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060057E2 RID: 22498 RVA: 0x000297B6 File Offset: 0x000279B6
		public DialogueChoiceData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x060057E3 RID: 22499 RVA: 0x001ABD44 File Offset: 0x001A9F44
		// (set) Token: 0x060057E4 RID: 22500 RVA: 0x000297BF File Offset: 0x000279BF
		public unsafe string Guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_Guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x060057E5 RID: 22501 RVA: 0x001ABD6C File Offset: 0x001A9F6C
		// (set) Token: 0x060057E6 RID: 22502 RVA: 0x000297DE File Offset: 0x000279DE
		public unsafe string ChoiceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x060057E7 RID: 22503 RVA: 0x001ABD94 File Offset: 0x001A9F94
		// (set) Token: 0x060057E8 RID: 22504 RVA: 0x000297FD File Offset: 0x000279FD
		public unsafe string ChoiceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ChoiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x060057E9 RID: 22505 RVA: 0x001ABDBC File Offset: 0x001A9FBC
		// (set) Token: 0x060057EA RID: 22506 RVA: 0x0002981C File Offset: 0x00027A1C
		public unsafe bool ShowWorldspaceDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ShowWorldspaceDialogue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueChoiceData.NativeFieldInfoPtr_ShowWorldspaceDialogue)) = value;
			}
		}

		// Token: 0x04003C81 RID: 15489
		private static readonly IntPtr NativeFieldInfoPtr_Guid;

		// Token: 0x04003C82 RID: 15490
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceText;

		// Token: 0x04003C83 RID: 15491
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceLabel;

		// Token: 0x04003C84 RID: 15492
		private static readonly IntPtr NativeFieldInfoPtr_ShowWorldspaceDialogue;

		// Token: 0x04003C85 RID: 15493
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_DialogueChoiceData_0;

		// Token: 0x04003C86 RID: 15494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

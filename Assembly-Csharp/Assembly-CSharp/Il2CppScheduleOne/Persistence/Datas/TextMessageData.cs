using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000272 RID: 626
	[Serializable]
	public class TextMessageData : Object
	{
		// Token: 0x06003152 RID: 12626 RVA: 0x0011E2B4 File Offset: 0x0011C4B4
		// Note: this type is marked as 'beforefieldinit'.
		static TextMessageData()
		{
			Il2CppClassPointerStore<TextMessageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TextMessageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr);
			TextMessageData.NativeFieldInfoPtr_Sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "Sender");
			TextMessageData.NativeFieldInfoPtr_MessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "MessageID");
			TextMessageData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "Text");
			TextMessageData.NativeFieldInfoPtr_EndOfChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, "EndOfChain");
			TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, 100669470);
			TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr, 100669471);
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x0011E35C File Offset: 0x0011C55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135469, XrefRangeEnd = 135471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData(int sender, int messageID, string text, bool endOfChain) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sender;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endOfChain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x0011E3D4 File Offset: 0x0011C5D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135476, RefRangeEnd = 135477, XrefRangeStart = 135471, XrefRangeEnd = 135476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMessageData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextMessageData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x00019739 File Offset: 0x00017939
		public TextMessageData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06003156 RID: 12630 RVA: 0x0011E410 File Offset: 0x0011C610
		// (set) Token: 0x06003157 RID: 12631 RVA: 0x00019742 File Offset: 0x00017942
		public unsafe int Sender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Sender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Sender)) = value;
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06003158 RID: 12632 RVA: 0x0011E438 File Offset: 0x0011C638
		// (set) Token: 0x06003159 RID: 12633 RVA: 0x0001975D File Offset: 0x0001795D
		public unsafe int MessageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_MessageID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_MessageID)) = value;
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x0600315A RID: 12634 RVA: 0x0011E460 File Offset: 0x0011C660
		// (set) Token: 0x0600315B RID: 12635 RVA: 0x00019778 File Offset: 0x00017978
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x0011E488 File Offset: 0x0011C688
		// (set) Token: 0x0600315D RID: 12637 RVA: 0x00019797 File Offset: 0x00017997
		public unsafe bool EndOfChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_EndOfChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextMessageData.NativeFieldInfoPtr_EndOfChain)) = value;
			}
		}

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeFieldInfoPtr_Sender;

		// Token: 0x040020F1 RID: 8433
		private static readonly IntPtr NativeFieldInfoPtr_MessageID;

		// Token: 0x040020F2 RID: 8434
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeFieldInfoPtr_EndOfChain;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_Boolean_0;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

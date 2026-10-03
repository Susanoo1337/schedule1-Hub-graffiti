using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x020002A4 RID: 676
	[Serializable]
	public class Message : Object
	{
		// Token: 0x06003345 RID: 13125 RVA: 0x00124EF8 File Offset: 0x001230F8
		// Note: this type is marked as 'beforefieldinit'.
		static Message()
		{
			Il2CppClassPointerStore<Message>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "Message");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Message>.NativeClassPtr);
			Message.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "messageId");
			Message.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "text");
			Message.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "sender");
			Message.NativeFieldInfoPtr_endOfGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Message>.NativeClassPtr, "endOfGroup");
			Message.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100669727);
			Message.NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100669728);
			Message.NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100669729);
			Message.NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Message>.NativeClassPtr, 100669730);
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x00124FC8 File Offset: 0x001231C8
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 137626, RefRangeEnd = 137679, XrefRangeStart = 137625, XrefRangeEnd = 137626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x00125004 File Offset: 0x00123204
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 137682, RefRangeEnd = 137693, XrefRangeStart = 137679, XrefRangeEnd = 137682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message(string _text, Message.ESenderType _type, bool _endOfGroup = false, int _messageId = -1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _endOfGroup;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _messageId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x0012507C File Offset: 0x0012327C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137695, RefRangeEnd = 137696, XrefRangeStart = 137693, XrefRangeEnd = 137695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Message(TextMessageData data) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Message>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x001250C8 File Offset: 0x001232C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137701, RefRangeEnd = 137702, XrefRangeStart = 137696, XrefRangeEnd = 137701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextMessageData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Message.NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMessageData>(intPtr3) : null;
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x0001A3F9 File Offset: 0x000185F9
		public Message(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x00125108 File Offset: 0x00123308
		// (set) Token: 0x0600334C RID: 13132 RVA: 0x0001A402 File Offset: 0x00018602
		public unsafe int messageId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_messageId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_messageId)) = value;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x0600334D RID: 13133 RVA: 0x00125130 File Offset: 0x00123330
		// (set) Token: 0x0600334E RID: 13134 RVA: 0x0001A41D File Offset: 0x0001861D
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x0600334F RID: 13135 RVA: 0x00125158 File Offset: 0x00123358
		// (set) Token: 0x06003350 RID: 13136 RVA: 0x0001A43C File Offset: 0x0001863C
		public unsafe Message.ESenderType sender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_sender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_sender)) = value;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06003351 RID: 13137 RVA: 0x00125180 File Offset: 0x00123380
		// (set) Token: 0x06003352 RID: 13138 RVA: 0x0001A457 File Offset: 0x00018657
		public unsafe bool endOfGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_endOfGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Message.NativeFieldInfoPtr_endOfGroup)) = value;
			}
		}

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeFieldInfoPtr_messageId;

		// Token: 0x0400223A RID: 8762
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400223B RID: 8763
		private static readonly IntPtr NativeFieldInfoPtr_sender;

		// Token: 0x0400223C RID: 8764
		private static readonly IntPtr NativeFieldInfoPtr_endOfGroup;

		// Token: 0x0400223D RID: 8765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ESenderType_Boolean_Int32_0;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextMessageData_0;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_TextMessageData_0;

		// Token: 0x020009FF RID: 2559
		[OriginalName("Assembly-CSharp.dll", "", "ESenderType")]
		public enum ESenderType
		{
			// Token: 0x040096E7 RID: 38631
			Player,
			// Token: 0x040096E8 RID: 38632
			Other
		}
	}
}

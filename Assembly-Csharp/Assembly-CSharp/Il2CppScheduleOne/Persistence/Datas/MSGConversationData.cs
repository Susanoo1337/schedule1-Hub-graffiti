using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000238 RID: 568
	[Serializable]
	public class MSGConversationData : SaveData
	{
		// Token: 0x06002F3B RID: 12091 RVA: 0x00117F98 File Offset: 0x00116198
		// Note: this type is marked as 'beforefieldinit'.
		static MSGConversationData()
		{
			Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MSGConversationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr);
			MSGConversationData.NativeFieldInfoPtr_ConversationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "ConversationIndex");
			MSGConversationData.NativeFieldInfoPtr_Read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "Read");
			MSGConversationData.NativeFieldInfoPtr_MessageHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "MessageHistory");
			MSGConversationData.NativeFieldInfoPtr_ActiveResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "ActiveResponses");
			MSGConversationData.NativeFieldInfoPtr_IsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, "IsHidden");
			MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, 100669405);
			MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr, 100669406);
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x00118054 File Offset: 0x00116254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134992, RefRangeEnd = 134993, XrefRangeStart = 134989, XrefRangeEnd = 134992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData(int conversationIndex, bool read, Il2CppReferenceArray<TextMessageData> messageHistory, Il2CppReferenceArray<TextResponseData> activeResponses, bool isHidden) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref conversationIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref read;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(messageHistory);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeResponses);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isHidden;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x001180DC File Offset: 0x001162DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135002, RefRangeEnd = 135003, XrefRangeStart = 134993, XrefRangeEnd = 135002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversationData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversationData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000180F2 File Offset: 0x000162F2
		public MSGConversationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x00118118 File Offset: 0x00116318
		// (set) Token: 0x06002F40 RID: 12096 RVA: 0x000180FB File Offset: 0x000162FB
		public unsafe int ConversationIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ConversationIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ConversationIndex)) = value;
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x00118140 File Offset: 0x00116340
		// (set) Token: 0x06002F42 RID: 12098 RVA: 0x00018116 File Offset: 0x00016316
		public unsafe bool Read
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_Read);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_Read)) = value;
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06002F43 RID: 12099 RVA: 0x00118168 File Offset: 0x00116368
		// (set) Token: 0x06002F44 RID: 12100 RVA: 0x00018131 File Offset: 0x00016331
		public unsafe Il2CppReferenceArray<TextMessageData> MessageHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_MessageHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMessageData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_MessageHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06002F45 RID: 12101 RVA: 0x00118198 File Offset: 0x00116398
		// (set) Token: 0x06002F46 RID: 12102 RVA: 0x00018150 File Offset: 0x00016350
		public unsafe Il2CppReferenceArray<TextResponseData> ActiveResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ActiveResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextResponseData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_ActiveResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06002F47 RID: 12103 RVA: 0x001181C8 File Offset: 0x001163C8
		// (set) Token: 0x06002F48 RID: 12104 RVA: 0x0001816F File Offset: 0x0001636F
		public unsafe bool IsHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_IsHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversationData.NativeFieldInfoPtr_IsHidden)) = value;
			}
		}

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeFieldInfoPtr_ConversationIndex;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeFieldInfoPtr_Read;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeFieldInfoPtr_MessageHistory;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeFieldInfoPtr_ActiveResponses;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeFieldInfoPtr_IsHidden;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_Il2CppReferenceArray_1_TextMessageData_Il2CppReferenceArray_1_TextResponseData_Boolean_0;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Polling
{
	// Token: 0x0200016F RID: 367
	[Serializable]
	public class PollAnswer : Object
	{
		// Token: 0x06002513 RID: 9491 RVA: 0x000F6158 File Offset: 0x000F4358
		// Note: this type is marked as 'beforefieldinit'.
		static PollAnswer()
		{
			Il2CppClassPointerStore<PollAnswer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Polling", "PollAnswer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr);
			PollAnswer.NativeFieldInfoPtr_pollId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr, "pollId");
			PollAnswer.NativeFieldInfoPtr_answer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr, "answer");
			PollAnswer.NativeFieldInfoPtr_ticket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr, "ticket");
			PollAnswer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr, 100668113);
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x000F61D8 File Offset: 0x000F43D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115210, XrefRangeEnd = 115212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollAnswer(int _pollId, int _answer, string _ticket) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollAnswer>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _pollId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _answer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_ticket);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollAnswer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00013832 File Offset: 0x00011A32
		public PollAnswer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x000F6240 File Offset: 0x000F4440
		// (set) Token: 0x06002517 RID: 9495 RVA: 0x0001383B File Offset: 0x00011A3B
		public unsafe int pollId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_pollId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_pollId)) = value;
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x000F6268 File Offset: 0x000F4468
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x00013856 File Offset: 0x00011A56
		public unsafe int answer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_answer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_answer)) = value;
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x000F6290 File Offset: 0x000F4490
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x00013871 File Offset: 0x00011A71
		public unsafe string ticket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_ticket);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollAnswer.NativeFieldInfoPtr_ticket), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeFieldInfoPtr_pollId;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeFieldInfoPtr_answer;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeFieldInfoPtr_ticket;

		// Token: 0x040019A7 RID: 6567
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_String_0;
	}
}

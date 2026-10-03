using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Polling
{
	// Token: 0x02000170 RID: 368
	[Serializable]
	public class PollData : Object
	{
		// Token: 0x0600251C RID: 9500 RVA: 0x000F62B8 File Offset: 0x000F44B8
		// Note: this type is marked as 'beforefieldinit'.
		static PollData()
		{
			Il2CppClassPointerStore<PollData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Polling", "PollData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollData>.NativeClassPtr);
			PollData.NativeFieldInfoPtr_pollId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollData>.NativeClassPtr, "pollId");
			PollData.NativeFieldInfoPtr_question = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollData>.NativeClassPtr, "question");
			PollData.NativeFieldInfoPtr_answers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollData>.NativeClassPtr, "answers");
			PollData.NativeFieldInfoPtr_answerDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollData>.NativeClassPtr, "answerDescriptions");
			PollData.NativeFieldInfoPtr_winnerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollData>.NativeClassPtr, "winnerIndex");
			PollData.NativeFieldInfoPtr_confirmationMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollData>.NativeClassPtr, "confirmationMessage");
			PollData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollData>.NativeClassPtr, 100668114);
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x000F6374 File Offset: 0x000F4574
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x00013890 File Offset: 0x00011A90
		public PollData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x0600251F RID: 9503 RVA: 0x000F63B0 File Offset: 0x000F45B0
		// (set) Token: 0x06002520 RID: 9504 RVA: 0x00013899 File Offset: 0x00011A99
		public unsafe int pollId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_pollId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_pollId)) = value;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06002521 RID: 9505 RVA: 0x000F63D8 File Offset: 0x000F45D8
		// (set) Token: 0x06002522 RID: 9506 RVA: 0x000138B4 File Offset: 0x00011AB4
		public unsafe string question
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_question);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_question), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06002523 RID: 9507 RVA: 0x000F6400 File Offset: 0x000F4600
		// (set) Token: 0x06002524 RID: 9508 RVA: 0x000138D3 File Offset: 0x00011AD3
		public unsafe Il2CppStringArray answers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_answers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_answers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x000F6430 File Offset: 0x000F4630
		// (set) Token: 0x06002526 RID: 9510 RVA: 0x000138F2 File Offset: 0x00011AF2
		public unsafe Il2CppStringArray answerDescriptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_answerDescriptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_answerDescriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x000F6460 File Offset: 0x000F4660
		// (set) Token: 0x06002528 RID: 9512 RVA: 0x00013911 File Offset: 0x00011B11
		public unsafe int winnerIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_winnerIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_winnerIndex)) = value;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002529 RID: 9513 RVA: 0x000F6488 File Offset: 0x000F4688
		// (set) Token: 0x0600252A RID: 9514 RVA: 0x0001392C File Offset: 0x00011B2C
		public unsafe string confirmationMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_confirmationMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollData.NativeFieldInfoPtr_confirmationMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040019A8 RID: 6568
		private static readonly IntPtr NativeFieldInfoPtr_pollId;

		// Token: 0x040019A9 RID: 6569
		private static readonly IntPtr NativeFieldInfoPtr_question;

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeFieldInfoPtr_answers;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeFieldInfoPtr_answerDescriptions;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeFieldInfoPtr_winnerIndex;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeFieldInfoPtr_confirmationMessage;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

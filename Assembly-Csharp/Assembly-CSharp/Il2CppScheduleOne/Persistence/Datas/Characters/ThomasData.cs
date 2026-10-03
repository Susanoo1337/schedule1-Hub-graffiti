using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas.Characters
{
	// Token: 0x02000280 RID: 640
	public class ThomasData : NPCData
	{
		// Token: 0x060031C7 RID: 12743 RVA: 0x0011F5B0 File Offset: 0x0011D7B0
		// Note: this type is marked as 'beforefieldinit'.
		static ThomasData()
		{
			Il2CppClassPointerStore<ThomasData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas.Characters", "ThomasData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThomasData>.NativeClassPtr);
			ThomasData.NativeFieldInfoPtr_MeetingReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, "MeetingReminderSent");
			ThomasData.NativeFieldInfoPtr_HandoverReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, "HandoverReminderSent");
			ThomasData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThomasData>.NativeClassPtr, 100669487);
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x0011F61C File Offset: 0x0011D81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135559, XrefRangeEnd = 135561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThomasData(string id, bool meetingReminderSent, bool handoverReminderSent) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThomasData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meetingReminderSent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverReminderSent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThomasData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x00019C1C File Offset: 0x00017E1C
		public ThomasData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x0011F684 File Offset: 0x0011D884
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x00019C25 File Offset: 0x00017E25
		public unsafe bool MeetingReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_MeetingReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_MeetingReminderSent)) = value;
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x0011F6AC File Offset: 0x0011D8AC
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x00019C40 File Offset: 0x00017E40
		public unsafe bool HandoverReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_HandoverReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThomasData.NativeFieldInfoPtr_HandoverReminderSent)) = value;
			}
		}

		// Token: 0x04002125 RID: 8485
		private static readonly IntPtr NativeFieldInfoPtr_MeetingReminderSent;

		// Token: 0x04002126 RID: 8486
		private static readonly IntPtr NativeFieldInfoPtr_HandoverReminderSent;

		// Token: 0x04002127 RID: 8487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Boolean_0;
	}
}

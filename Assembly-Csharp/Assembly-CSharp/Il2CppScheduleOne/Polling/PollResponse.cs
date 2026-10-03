using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Polling
{
	// Token: 0x02000172 RID: 370
	[Serializable]
	public class PollResponse : Object
	{
		// Token: 0x06002557 RID: 9559 RVA: 0x000F6ECC File Offset: 0x000F50CC
		// Note: this type is marked as 'beforefieldinit'.
		static PollResponse()
		{
			Il2CppClassPointerStore<PollResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Polling", "PollResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollResponse>.NativeClassPtr);
			PollResponse.NativeFieldInfoPtr_polls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, "polls");
			PollResponse.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, "active");
			PollResponse.NativeFieldInfoPtr_confirmed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, "confirmed");
			PollResponse.NativeMethodInfoPtr_GetActive_Public_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, 100668150);
			PollResponse.NativeMethodInfoPtr_GetConfirmed_Public_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, 100668151);
			PollResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, 100668152);
			PollResponse.NativeMethodInfoPtr__GetActive_b__3_0_Private_Boolean_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, 100668153);
			PollResponse.NativeMethodInfoPtr__GetConfirmed_b__4_0_Private_Boolean_PollData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponse>.NativeClassPtr, 100668154);
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000F6F9C File Offset: 0x000F519C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115473, RefRangeEnd = 115475, XrefRangeStart = 115464, XrefRangeEnd = 115473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollData GetActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollResponse.NativeMethodInfoPtr_GetActive_Public_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr3) : null;
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000F6FDC File Offset: 0x000F51DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115484, RefRangeEnd = 115486, XrefRangeStart = 115475, XrefRangeEnd = 115484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollData GetConfirmed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollResponse.NativeMethodInfoPtr_GetConfirmed_Public_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PollData>(intPtr3) : null;
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000F701C File Offset: 0x000F521C
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollResponse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000F7058 File Offset: 0x000F5258
		[CallerCount(0)]
		public unsafe bool _GetActive_b__3_0(PollData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollResponse.NativeMethodInfoPtr__GetActive_b__3_0_Private_Boolean_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000F70A8 File Offset: 0x000F52A8
		[CallerCount(0)]
		public unsafe bool _GetConfirmed_b__4_0(PollData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollResponse.NativeMethodInfoPtr__GetConfirmed_b__4_0_Private_Boolean_PollData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00013A75 File Offset: 0x00011C75
		public PollResponse(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x000F70F8 File Offset: 0x000F52F8
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x00013A7E File Offset: 0x00011C7E
		public unsafe Il2CppReferenceArray<PollData> polls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_polls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PollData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_polls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x000F7128 File Offset: 0x000F5328
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x00013A9D File Offset: 0x00011C9D
		public unsafe int active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000F7150 File Offset: 0x000F5350
		// (set) Token: 0x06002563 RID: 9571 RVA: 0x00013AB8 File Offset: 0x00011CB8
		public unsafe int confirmed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_confirmed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponse.NativeFieldInfoPtr_confirmed)) = value;
			}
		}

		// Token: 0x040019CF RID: 6607
		private static readonly IntPtr NativeFieldInfoPtr_polls;

		// Token: 0x040019D0 RID: 6608
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x040019D1 RID: 6609
		private static readonly IntPtr NativeFieldInfoPtr_confirmed;

		// Token: 0x040019D2 RID: 6610
		private static readonly IntPtr NativeMethodInfoPtr_GetActive_Public_PollData_0;

		// Token: 0x040019D3 RID: 6611
		private static readonly IntPtr NativeMethodInfoPtr_GetConfirmed_Public_PollData_0;

		// Token: 0x040019D4 RID: 6612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019D5 RID: 6613
		private static readonly IntPtr NativeMethodInfoPtr__GetActive_b__3_0_Private_Boolean_PollData_0;

		// Token: 0x040019D6 RID: 6614
		private static readonly IntPtr NativeMethodInfoPtr__GetConfirmed_b__4_0_Private_Boolean_PollData_0;
	}
}

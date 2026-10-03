using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Polling
{
	// Token: 0x02000173 RID: 371
	[Serializable]
	public class PollResponseWrapper : Object
	{
		// Token: 0x06002564 RID: 9572 RVA: 0x000F7178 File Offset: 0x000F5378
		// Note: this type is marked as 'beforefieldinit'.
		static PollResponseWrapper()
		{
			Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Polling", "PollResponseWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr);
			PollResponseWrapper.NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr, "success");
			PollResponseWrapper.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr, "data");
			PollResponseWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr, 100668155);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x000F71E4 File Offset: 0x000F53E4
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PollResponseWrapper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PollResponseWrapper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PollResponseWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00013AD3 File Offset: 0x00011CD3
		public PollResponseWrapper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002567 RID: 9575 RVA: 0x000F7220 File Offset: 0x000F5420
		// (set) Token: 0x06002568 RID: 9576 RVA: 0x00013ADC File Offset: 0x00011CDC
		public unsafe bool success
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponseWrapper.NativeFieldInfoPtr_success);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponseWrapper.NativeFieldInfoPtr_success)) = value;
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002569 RID: 9577 RVA: 0x000F7248 File Offset: 0x000F5448
		// (set) Token: 0x0600256A RID: 9578 RVA: 0x00013AF7 File Offset: 0x00011CF7
		public unsafe PollResponse data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponseWrapper.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PollResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PollResponseWrapper.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019D7 RID: 6615
		private static readonly IntPtr NativeFieldInfoPtr_success;

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

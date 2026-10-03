using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Reporting
{
	// Token: 0x02000138 RID: 312
	[Serializable]
	public class ReportSubmissionResponse : Object
	{
		// Token: 0x06001F5C RID: 8028 RVA: 0x000E1AA8 File Offset: 0x000DFCA8
		// Note: this type is marked as 'beforefieldinit'.
		static ReportSubmissionResponse()
		{
			Il2CppClassPointerStore<ReportSubmissionResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Reporting", "ReportSubmissionResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportSubmissionResponse>.NativeClassPtr);
			ReportSubmissionResponse.NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportSubmissionResponse>.NativeClassPtr, "success");
			ReportSubmissionResponse.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportSubmissionResponse>.NativeClassPtr, "data");
			ReportSubmissionResponse.NativeFieldInfoPtr_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportSubmissionResponse>.NativeClassPtr, "error");
			ReportSubmissionResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportSubmissionResponse>.NativeClassPtr, 100667358);
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x000E1B28 File Offset: 0x000DFD28
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReportSubmissionResponse() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportSubmissionResponse>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportSubmissionResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00010F58 File Offset: 0x0000F158
		public ReportSubmissionResponse(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001F5F RID: 8031 RVA: 0x000E1B64 File Offset: 0x000DFD64
		// (set) Token: 0x06001F60 RID: 8032 RVA: 0x00010F61 File Offset: 0x0000F161
		public unsafe bool success
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmissionResponse.NativeFieldInfoPtr_success);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmissionResponse.NativeFieldInfoPtr_success)) = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001F61 RID: 8033 RVA: 0x000E1B8C File Offset: 0x000DFD8C
		// (set) Token: 0x06001F62 RID: 8034 RVA: 0x00010F7C File Offset: 0x0000F17C
		public unsafe ReportResponseData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmissionResponse.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReportResponseData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmissionResponse.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001F63 RID: 8035 RVA: 0x000E1BBC File Offset: 0x000DFDBC
		// (set) Token: 0x06001F64 RID: 8036 RVA: 0x00010F9B File Offset: 0x0000F19B
		public unsafe string error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmissionResponse.NativeFieldInfoPtr_error);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmissionResponse.NativeFieldInfoPtr_error), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeFieldInfoPtr_success;

		// Token: 0x040015AC RID: 5548
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeFieldInfoPtr_error;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

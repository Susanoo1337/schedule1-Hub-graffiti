using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Reporting
{
	// Token: 0x02000136 RID: 310
	[Serializable]
	public class ReportResponseData : Object
	{
		// Token: 0x06001F48 RID: 8008 RVA: 0x000E17EC File Offset: 0x000DF9EC
		// Note: this type is marked as 'beforefieldinit'.
		static ReportResponseData()
		{
			Il2CppClassPointerStore<ReportResponseData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Reporting", "ReportResponseData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportResponseData>.NativeClassPtr);
			ReportResponseData.NativeFieldInfoPtr_reportUid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportResponseData>.NativeClassPtr, "reportUid");
			ReportResponseData.NativeFieldInfoPtr_uploadLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportResponseData>.NativeClassPtr, "uploadLinks");
			ReportResponseData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportResponseData>.NativeClassPtr, 100667356);
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x000E1858 File Offset: 0x000DFA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106797, XrefRangeEnd = 106805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReportResponseData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportResponseData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportResponseData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00010E6D File Offset: 0x0000F06D
		public ReportResponseData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x000E1894 File Offset: 0x000DFA94
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x00010E76 File Offset: 0x0000F076
		public unsafe string reportUid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportResponseData.NativeFieldInfoPtr_reportUid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportResponseData.NativeFieldInfoPtr_reportUid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x000E18BC File Offset: 0x000DFABC
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00010E95 File Offset: 0x0000F095
		public unsafe Dictionary<string, ReportUploadLink> uploadLinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportResponseData.NativeFieldInfoPtr_uploadLinks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ReportUploadLink>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportResponseData.NativeFieldInfoPtr_uploadLinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015A2 RID: 5538
		private static readonly IntPtr NativeFieldInfoPtr_reportUid;

		// Token: 0x040015A3 RID: 5539
		private static readonly IntPtr NativeFieldInfoPtr_uploadLinks;

		// Token: 0x040015A4 RID: 5540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

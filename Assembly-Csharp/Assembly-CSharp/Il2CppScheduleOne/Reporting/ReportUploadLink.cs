using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Reporting
{
	// Token: 0x0200013A RID: 314
	[Serializable]
	public class ReportUploadLink : Object
	{
		// Token: 0x06001F6C RID: 8044 RVA: 0x000E1D00 File Offset: 0x000DFF00
		// Note: this type is marked as 'beforefieldinit'.
		static ReportUploadLink()
		{
			Il2CppClassPointerStore<ReportUploadLink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Reporting", "ReportUploadLink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportUploadLink>.NativeClassPtr);
			ReportUploadLink.NativeFieldInfoPtr_signedUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportUploadLink>.NativeClassPtr, "signedUrl");
			ReportUploadLink.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportUploadLink>.NativeClassPtr, "token");
			ReportUploadLink.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportUploadLink>.NativeClassPtr, "path");
			ReportUploadLink.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportUploadLink>.NativeClassPtr, "contentType");
			ReportUploadLink.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportUploadLink>.NativeClassPtr, 100667360);
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x000E1D94 File Offset: 0x000DFF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106810, XrefRangeEnd = 106820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReportUploadLink() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportUploadLink>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportUploadLink.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00011001 File Offset: 0x0000F201
		public ReportUploadLink(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001F6F RID: 8047 RVA: 0x000E1DD0 File Offset: 0x000DFFD0
		// (set) Token: 0x06001F70 RID: 8048 RVA: 0x0001100A File Offset: 0x0000F20A
		public unsafe string signedUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportUploadLink.NativeFieldInfoPtr_signedUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportUploadLink.NativeFieldInfoPtr_signedUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x000E1DF8 File Offset: 0x000DFFF8
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x00011029 File Offset: 0x0000F229
		public unsafe string token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportUploadLink.NativeFieldInfoPtr_token);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportUploadLink.NativeFieldInfoPtr_token), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x000E1E20 File Offset: 0x000E0020
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x00011048 File Offset: 0x0000F248
		public unsafe string path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportUploadLink.NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportUploadLink.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001F75 RID: 8053 RVA: 0x000E1E48 File Offset: 0x000E0048
		// (set) Token: 0x06001F76 RID: 8054 RVA: 0x00011067 File Offset: 0x0000F267
		public unsafe string contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportUploadLink.NativeFieldInfoPtr_contentType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportUploadLink.NativeFieldInfoPtr_contentType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040015B2 RID: 5554
		private static readonly IntPtr NativeFieldInfoPtr_signedUrl;

		// Token: 0x040015B3 RID: 5555
		private static readonly IntPtr NativeFieldInfoPtr_token;

		// Token: 0x040015B4 RID: 5556
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x040015B5 RID: 5557
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x040015B6 RID: 5558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Reporting
{
	// Token: 0x02000137 RID: 311
	[Serializable]
	public class ReportSubmission : Object
	{
		// Token: 0x06001F4F RID: 8015 RVA: 0x000E18EC File Offset: 0x000DFAEC
		// Note: this type is marked as 'beforefieldinit'.
		static ReportSubmission()
		{
			Il2CppClassPointerStore<ReportSubmission>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Reporting", "ReportSubmission");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportSubmission>.NativeClassPtr);
			ReportSubmission.NativeFieldInfoPtr_ticket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportSubmission>.NativeClassPtr, "ticket");
			ReportSubmission.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportSubmission>.NativeClassPtr, "title");
			ReportSubmission.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportSubmission>.NativeClassPtr, "description");
			ReportSubmission.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportSubmission>.NativeClassPtr, "tags");
			ReportSubmission.NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportSubmission>.NativeClassPtr, "metadata");
			ReportSubmission.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportSubmission>.NativeClassPtr, 100667357);
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x000E1994 File Offset: 0x000DFB94
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReportSubmission() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportSubmission>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportSubmission.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x00010EB4 File Offset: 0x0000F0B4
		public ReportSubmission(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x000E19D0 File Offset: 0x000DFBD0
		// (set) Token: 0x06001F53 RID: 8019 RVA: 0x00010EBD File Offset: 0x0000F0BD
		public unsafe string ticket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmission.NativeFieldInfoPtr_ticket);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmission.NativeFieldInfoPtr_ticket), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001F54 RID: 8020 RVA: 0x000E19F8 File Offset: 0x000DFBF8
		// (set) Token: 0x06001F55 RID: 8021 RVA: 0x00010EDC File Offset: 0x0000F0DC
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmission.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmission.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x000E1A20 File Offset: 0x000DFC20
		// (set) Token: 0x06001F57 RID: 8023 RVA: 0x00010EFB File Offset: 0x0000F0FB
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmission.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmission.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001F58 RID: 8024 RVA: 0x000E1A48 File Offset: 0x000DFC48
		// (set) Token: 0x06001F59 RID: 8025 RVA: 0x00010F1A File Offset: 0x0000F11A
		public unsafe Il2CppReferenceArray<ReportTag> tags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmission.NativeFieldInfoPtr_tags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ReportTag>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmission.NativeFieldInfoPtr_tags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x000E1A78 File Offset: 0x000DFC78
		// (set) Token: 0x06001F5B RID: 8027 RVA: 0x00010F39 File Offset: 0x0000F139
		public unsafe Dictionary<string, string> metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmission.NativeFieldInfoPtr_metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportSubmission.NativeFieldInfoPtr_metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015A5 RID: 5541
		private static readonly IntPtr NativeFieldInfoPtr_ticket;

		// Token: 0x040015A6 RID: 5542
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x040015A7 RID: 5543
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x040015A8 RID: 5544
		private static readonly IntPtr NativeFieldInfoPtr_tags;

		// Token: 0x040015A9 RID: 5545
		private static readonly IntPtr NativeFieldInfoPtr_metadata;

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

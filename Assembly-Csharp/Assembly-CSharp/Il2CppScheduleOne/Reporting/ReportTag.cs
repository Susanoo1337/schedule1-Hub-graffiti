using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Reporting
{
	// Token: 0x02000139 RID: 313
	[Serializable]
	public class ReportTag : Object
	{
		// Token: 0x06001F65 RID: 8037 RVA: 0x000E1BE4 File Offset: 0x000DFDE4
		// Note: this type is marked as 'beforefieldinit'.
		static ReportTag()
		{
			Il2CppClassPointerStore<ReportTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Reporting", "ReportTag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReportTag>.NativeClassPtr);
			ReportTag.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportTag>.NativeClassPtr, "name");
			ReportTag.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReportTag>.NativeClassPtr, "category");
			ReportTag.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReportTag>.NativeClassPtr, 100667359);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x000E1C50 File Offset: 0x000DFE50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106808, RefRangeEnd = 106810, XrefRangeStart = 106805, XrefRangeEnd = 106808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReportTag(string category, string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReportTag>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReportTag.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00010FBA File Offset: 0x0000F1BA
		public ReportTag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x000E1CB0 File Offset: 0x000DFEB0
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00010FC3 File Offset: 0x0000F1C3
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportTag.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportTag.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x000E1CD8 File Offset: 0x000DFED8
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x00010FE2 File Offset: 0x0000F1E2
		public unsafe string category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportTag.NativeFieldInfoPtr_category);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReportTag.NativeFieldInfoPtr_category), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeFieldInfoPtr_category;

		// Token: 0x040015B1 RID: 5553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}

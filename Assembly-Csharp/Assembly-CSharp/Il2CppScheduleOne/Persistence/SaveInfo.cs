using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001B4 RID: 436
	public class SaveInfo : Object
	{
		// Token: 0x06002B69 RID: 11113 RVA: 0x0010AC00 File Offset: 0x00108E00
		// Note: this type is marked as 'beforefieldinit'.
		static SaveInfo()
		{
			Il2CppClassPointerStore<SaveInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SaveInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr);
			SaveInfo.NativeFieldInfoPtr_SavePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SavePath");
			SaveInfo.NativeFieldInfoPtr_SaveSlotNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SaveSlotNumber");
			SaveInfo.NativeFieldInfoPtr_OrganisationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "OrganisationName");
			SaveInfo.NativeFieldInfoPtr_DateCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "DateCreated");
			SaveInfo.NativeFieldInfoPtr_DateLastPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "DateLastPlayed");
			SaveInfo.NativeFieldInfoPtr_Networth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "Networth");
			SaveInfo.NativeFieldInfoPtr_SaveVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SaveVersion");
			SaveInfo.NativeFieldInfoPtr_MetaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "MetaData");
			SaveInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_DateTime_DateTime_Single_String_MetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, 100668914);
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x0010ACE4 File Offset: 0x00108EE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127363, RefRangeEnd = 127365, XrefRangeStart = 127358, XrefRangeEnd = 127363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveInfo(string savePath, int saveSlotNumber, string organisationName, DateTime dateCreated, DateTime dateLastPlayed, float networth, string saveVersion, MetaData metaData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(savePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveSlotNumber;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(organisationName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateCreated;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateLastPlayed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref networth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(saveVersion);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metaData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_DateTime_DateTime_Single_String_MetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x0001685C File Offset: 0x00014A5C
		public SaveInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06002B6C RID: 11116 RVA: 0x0010ADA0 File Offset: 0x00108FA0
		// (set) Token: 0x06002B6D RID: 11117 RVA: 0x00016865 File Offset: 0x00014A65
		public unsafe string SavePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SavePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SavePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x0010ADC8 File Offset: 0x00108FC8
		// (set) Token: 0x06002B6F RID: 11119 RVA: 0x00016884 File Offset: 0x00014A84
		public unsafe int SaveSlotNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveSlotNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveSlotNumber)) = value;
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x0010ADF0 File Offset: 0x00108FF0
		// (set) Token: 0x06002B71 RID: 11121 RVA: 0x0001689F File Offset: 0x00014A9F
		public unsafe string OrganisationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_OrganisationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_OrganisationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x0010AE18 File Offset: 0x00109018
		// (set) Token: 0x06002B73 RID: 11123 RVA: 0x000168BE File Offset: 0x00014ABE
		public unsafe DateTime DateCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateCreated)) = value;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x0010AE40 File Offset: 0x00109040
		// (set) Token: 0x06002B75 RID: 11125 RVA: 0x000168D9 File Offset: 0x00014AD9
		public unsafe DateTime DateLastPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateLastPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateLastPlayed)) = value;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x0010AE68 File Offset: 0x00109068
		// (set) Token: 0x06002B77 RID: 11127 RVA: 0x000168F4 File Offset: 0x00014AF4
		public unsafe float Networth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_Networth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_Networth)) = value;
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002B78 RID: 11128 RVA: 0x0010AE90 File Offset: 0x00109090
		// (set) Token: 0x06002B79 RID: 11129 RVA: 0x0001690F File Offset: 0x00014B0F
		public unsafe string SaveVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06002B7A RID: 11130 RVA: 0x0010AEB8 File Offset: 0x001090B8
		// (set) Token: 0x06002B7B RID: 11131 RVA: 0x0001692E File Offset: 0x00014B2E
		public unsafe MetaData MetaData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_MetaData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_MetaData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DDC RID: 7644
		private static readonly IntPtr NativeFieldInfoPtr_SavePath;

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeFieldInfoPtr_SaveSlotNumber;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeFieldInfoPtr_OrganisationName;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeFieldInfoPtr_DateCreated;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeFieldInfoPtr_DateLastPlayed;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeFieldInfoPtr_Networth;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeFieldInfoPtr_SaveVersion;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeFieldInfoPtr_MetaData;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_DateTime_DateTime_Single_String_MetaData_0;
	}
}

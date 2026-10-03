using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000236 RID: 566
	[Serializable]
	public class MetaData : SaveData
	{
		// Token: 0x06002F23 RID: 12067 RVA: 0x00117BE0 File Offset: 0x00115DE0
		// Note: this type is marked as 'beforefieldinit'.
		static MetaData()
		{
			Il2CppClassPointerStore<MetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MetaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetaData>.NativeClassPtr);
			MetaData.NativeFieldInfoPtr_CreationDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "CreationDate");
			MetaData.NativeFieldInfoPtr_LastPlayedDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "LastPlayedDate");
			MetaData.NativeFieldInfoPtr_CreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "CreationVersion");
			MetaData.NativeFieldInfoPtr_LastSaveVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "LastSaveVersion");
			MetaData.NativeFieldInfoPtr_PlayTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetaData>.NativeClassPtr, "PlayTutorial");
			MetaData.NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetaData>.NativeClassPtr, 100669403);
		}

		// Token: 0x06002F24 RID: 12068 RVA: 0x00117C88 File Offset: 0x00115E88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 134983, RefRangeEnd = 134987, XrefRangeStart = 134978, XrefRangeEnd = 134983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetaData(DateTimeData creationDate, DateTimeData lastPlayedDate, string creationVersion, string lastSaveVersion, bool playTutorial) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetaData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(creationDate);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastPlayedDate);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(creationVersion);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastSaveVersion);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playTutorial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetaData.NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00017FDD File Offset: 0x000161DD
		public MetaData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x00117D18 File Offset: 0x00115F18
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x00017FE6 File Offset: 0x000161E6
		public unsafe DateTimeData CreationDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x00117D48 File Offset: 0x00115F48
		// (set) Token: 0x06002F29 RID: 12073 RVA: 0x00018005 File Offset: 0x00016205
		public unsafe DateTimeData LastPlayedDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastPlayedDate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastPlayedDate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06002F2A RID: 12074 RVA: 0x00117D78 File Offset: 0x00115F78
		// (set) Token: 0x06002F2B RID: 12075 RVA: 0x00018024 File Offset: 0x00016224
		public unsafe string CreationVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_CreationVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x00117DA0 File Offset: 0x00115FA0
		// (set) Token: 0x06002F2D RID: 12077 RVA: 0x00018043 File Offset: 0x00016243
		public unsafe string LastSaveVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastSaveVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_LastSaveVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x00117DC8 File Offset: 0x00115FC8
		// (set) Token: 0x06002F2F RID: 12079 RVA: 0x00018062 File Offset: 0x00016262
		public unsafe bool PlayTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_PlayTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MetaData.NativeFieldInfoPtr_PlayTutorial)) = value;
			}
		}

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeFieldInfoPtr_CreationDate;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeFieldInfoPtr_LastPlayedDate;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeFieldInfoPtr_CreationVersion;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeFieldInfoPtr_LastSaveVersion;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeFieldInfoPtr_PlayTutorial;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTimeData_DateTimeData_String_String_Boolean_0;
	}
}

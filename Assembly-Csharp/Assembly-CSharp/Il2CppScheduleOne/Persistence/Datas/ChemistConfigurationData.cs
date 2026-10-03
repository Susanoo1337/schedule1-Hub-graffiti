using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000220 RID: 544
	[Serializable]
	public class ChemistConfigurationData : SaveData
	{
		// Token: 0x06002E91 RID: 11921 RVA: 0x001162F4 File Offset: 0x001144F4
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistConfigurationData()
		{
			Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ChemistConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr);
			ChemistConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr, "Bed");
			ChemistConfigurationData.NativeFieldInfoPtr_Stations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr, "Stations");
			ChemistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr, 100669381);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00116360 File Offset: 0x00114560
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134812, XrefRangeStart = 134800, XrefRangeEnd = 134812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistConfigurationData(ObjectFieldData bed, ObjectListFieldData stations) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00017A53 File Offset: 0x00015C53
		public ChemistConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002E94 RID: 11924 RVA: 0x001163C0 File Offset: 0x001145C0
		// (set) Token: 0x06002E95 RID: 11925 RVA: 0x00017A5C File Offset: 0x00015C5C
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x001163F0 File Offset: 0x001145F0
		// (set) Token: 0x06002E97 RID: 11927 RVA: 0x00017A7B File Offset: 0x00015C7B
		public unsafe ObjectListFieldData Stations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Stations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Stations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04001FB6 RID: 8118
		private static readonly IntPtr NativeFieldInfoPtr_Stations;

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0;
	}
}

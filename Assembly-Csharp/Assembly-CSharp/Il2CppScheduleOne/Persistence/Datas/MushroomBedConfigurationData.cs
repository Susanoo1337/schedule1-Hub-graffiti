using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000227 RID: 551
	[Serializable]
	public class MushroomBedConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06002EC0 RID: 11968 RVA: 0x00116B0C File Offset: 0x00114D0C
		// Note: this type is marked as 'beforefieldinit'.
		static MushroomBedConfigurationData()
		{
			Il2CppClassPointerStore<MushroomBedConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MushroomBedConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomBedConfigurationData>.NativeClassPtr);
			MushroomBedConfigurationData.NativeFieldInfoPtr_Spawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfigurationData>.NativeClassPtr, "Spawn");
			MushroomBedConfigurationData.NativeFieldInfoPtr_Additive1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfigurationData>.NativeClassPtr, "Additive1");
			MushroomBedConfigurationData.NativeFieldInfoPtr_Additive2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfigurationData>.NativeClassPtr, "Additive2");
			MushroomBedConfigurationData.NativeFieldInfoPtr_Additive3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfigurationData>.NativeClassPtr, "Additive3");
			MushroomBedConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfigurationData>.NativeClassPtr, "Destination");
			MushroomBedConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfigurationData>.NativeClassPtr, 100669388);
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x00116BB4 File Offset: 0x00114DB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134819, RefRangeEnd = 134821, XrefRangeStart = 134812, XrefRangeEnd = 134819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MushroomBedConfigurationData(StringFieldData name, ItemFieldData spawn, ItemFieldData additive1, ItemFieldData additive2, ItemFieldData additive3, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomBedConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spawn);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive3);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x00017C25 File Offset: 0x00015E25
		public MushroomBedConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002EC3 RID: 11971 RVA: 0x00116C5C File Offset: 0x00114E5C
		// (set) Token: 0x06002EC4 RID: 11972 RVA: 0x00017C2E File Offset: 0x00015E2E
		public unsafe ItemFieldData Spawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigurationData.NativeFieldInfoPtr_Spawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigurationData.NativeFieldInfoPtr_Spawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06002EC5 RID: 11973 RVA: 0x00116C8C File Offset: 0x00114E8C
		// (set) Token: 0x06002EC6 RID: 11974 RVA: 0x00017C4D File Offset: 0x00015E4D
		public unsafe ItemFieldData Additive1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigurationData.NativeFieldInfoPtr_Additive1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigurationData.NativeFieldInfoPtr_Additive1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06002EC7 RID: 11975 RVA: 0x00116CBC File Offset: 0x00114EBC
		// (set) Token: 0x06002EC8 RID: 11976 RVA: 0x00017C6C File Offset: 0x00015E6C
		public unsafe ItemFieldData Additive2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigurationData.NativeFieldInfoPtr_Additive2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigurationData.NativeFieldInfoPtr_Additive2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x00116CEC File Offset: 0x00114EEC
		// (set) Token: 0x06002ECA RID: 11978 RVA: 0x00017C8B File Offset: 0x00015E8B
		public unsafe ItemFieldData Additive3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigurationData.NativeFieldInfoPtr_Additive3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigurationData.NativeFieldInfoPtr_Additive3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06002ECB RID: 11979 RVA: 0x00116D1C File Offset: 0x00114F1C
		// (set) Token: 0x06002ECC RID: 11980 RVA: 0x00017CAA File Offset: 0x00015EAA
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FC9 RID: 8137
		private static readonly IntPtr NativeFieldInfoPtr_Spawn;

		// Token: 0x04001FCA RID: 8138
		private static readonly IntPtr NativeFieldInfoPtr_Additive1;

		// Token: 0x04001FCB RID: 8139
		private static readonly IntPtr NativeFieldInfoPtr_Additive2;

		// Token: 0x04001FCC RID: 8140
		private static readonly IntPtr NativeFieldInfoPtr_Additive3;

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0;
	}
}

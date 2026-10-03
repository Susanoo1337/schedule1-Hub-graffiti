using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200022E RID: 558
	[Serializable]
	public class PotConfigurationData : RenamableConfigurationData
	{
		// Token: 0x06002EEF RID: 12015 RVA: 0x001172E8 File Offset: 0x001154E8
		// Note: this type is marked as 'beforefieldinit'.
		static PotConfigurationData()
		{
			Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PotConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr);
			PotConfigurationData.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Seed");
			PotConfigurationData.NativeFieldInfoPtr_Additive1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive1");
			PotConfigurationData.NativeFieldInfoPtr_Additive2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive2");
			PotConfigurationData.NativeFieldInfoPtr_Additive3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive3");
			PotConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Destination");
			PotConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, 100669395);
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x00117390 File Offset: 0x00115590
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134819, RefRangeEnd = 134821, XrefRangeStart = 134819, XrefRangeEnd = 134821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotConfigurationData(StringFieldData name, ItemFieldData seed, ItemFieldData additive1, ItemFieldData additive2, ItemFieldData additive3, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(seed);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive2);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive3);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x00017DF3 File Offset: 0x00015FF3
		public PotConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06002EF2 RID: 12018 RVA: 0x00117438 File Offset: 0x00115638
		// (set) Token: 0x06002EF3 RID: 12019 RVA: 0x00017DFC File Offset: 0x00015FFC
		public unsafe ItemFieldData Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06002EF4 RID: 12020 RVA: 0x00117468 File Offset: 0x00115668
		// (set) Token: 0x06002EF5 RID: 12021 RVA: 0x00017E1B File Offset: 0x0001601B
		public unsafe ItemFieldData Additive1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06002EF6 RID: 12022 RVA: 0x00117498 File Offset: 0x00115698
		// (set) Token: 0x06002EF7 RID: 12023 RVA: 0x00017E3A File Offset: 0x0001603A
		public unsafe ItemFieldData Additive2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06002EF8 RID: 12024 RVA: 0x001174C8 File Offset: 0x001156C8
		// (set) Token: 0x06002EF9 RID: 12025 RVA: 0x00017E59 File Offset: 0x00016059
		public unsafe ItemFieldData Additive3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06002EFA RID: 12026 RVA: 0x001174F8 File Offset: 0x001156F8
		// (set) Token: 0x06002EFB RID: 12027 RVA: 0x00017E78 File Offset: 0x00016078
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeFieldInfoPtr_Additive1;

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeFieldInfoPtr_Additive2;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeFieldInfoPtr_Additive3;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StringFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0;
	}
}

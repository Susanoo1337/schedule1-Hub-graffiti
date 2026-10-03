using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200021D RID: 541
	[Serializable]
	public class BotanistConfigurationData : SaveData
	{
		// Token: 0x06002E7E RID: 11902 RVA: 0x00115FA4 File Offset: 0x001141A4
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistConfigurationData()
		{
			Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BotanistConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr);
			BotanistConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Bed");
			BotanistConfigurationData.NativeFieldInfoPtr_Supplies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Supplies");
			BotanistConfigurationData.NativeFieldInfoPtr_Pots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Pots");
			BotanistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, 100669378);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00116024 File Offset: 0x00114224
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 134792, RefRangeEnd = 134797, XrefRangeStart = 134788, XrefRangeEnd = 134792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistConfigurationData(ObjectFieldData bed, ObjectFieldData supplies, ObjectListFieldData pots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(supplies);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x0001799D File Offset: 0x00015B9D
		public BotanistConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x00116094 File Offset: 0x00114294
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x000179A6 File Offset: 0x00015BA6
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x001160C4 File Offset: 0x001142C4
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x000179C5 File Offset: 0x00015BC5
		public unsafe ObjectFieldData Supplies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Supplies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Supplies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x001160F4 File Offset: 0x001142F4
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x000179E4 File Offset: 0x00015BE4
		public unsafe ObjectListFieldData Pots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Pots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Pots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeFieldInfoPtr_Supplies;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeFieldInfoPtr_Pots;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0;
	}
}

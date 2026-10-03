using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025D RID: 605
	[Serializable]
	public class PlantData : SaveData
	{
		// Token: 0x06003072 RID: 12402 RVA: 0x0011BC74 File Offset: 0x00119E74
		// Note: this type is marked as 'beforefieldinit'.
		static PlantData()
		{
			Il2CppClassPointerStore<PlantData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PlantData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantData>.NativeClassPtr);
			PlantData.NativeFieldInfoPtr_SeedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "SeedID");
			PlantData.NativeFieldInfoPtr_GrowthProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "GrowthProgress");
			PlantData.NativeFieldInfoPtr_ActiveBuds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "ActiveBuds");
			PlantData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantData>.NativeClassPtr, 100669444);
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x0011BCF4 File Offset: 0x00119EF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135216, RefRangeEnd = 135217, XrefRangeStart = 135213, XrefRangeEnd = 135216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantData(string seedID, float growthProgress, Il2CppStructArray<int> activeBuds) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeBuds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x00018D8C File Offset: 0x00016F8C
		public PlantData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x0011BD60 File Offset: 0x00119F60
		// (set) Token: 0x06003076 RID: 12406 RVA: 0x00018D95 File Offset: 0x00016F95
		public unsafe string SeedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_SeedID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_SeedID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x0011BD88 File Offset: 0x00119F88
		// (set) Token: 0x06003078 RID: 12408 RVA: 0x00018DB4 File Offset: 0x00016FB4
		public unsafe float GrowthProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_GrowthProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_GrowthProgress)) = value;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06003079 RID: 12409 RVA: 0x0011BDB0 File Offset: 0x00119FB0
		// (set) Token: 0x0600307A RID: 12410 RVA: 0x00018DCF File Offset: 0x00016FCF
		public unsafe Il2CppStructArray<int> ActiveBuds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_ActiveBuds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_ActiveBuds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002088 RID: 8328
		private static readonly IntPtr NativeFieldInfoPtr_SeedID;

		// Token: 0x04002089 RID: 8329
		private static readonly IntPtr NativeFieldInfoPtr_GrowthProgress;

		// Token: 0x0400208A RID: 8330
		private static readonly IntPtr NativeFieldInfoPtr_ActiveBuds;

		// Token: 0x0400208B RID: 8331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Il2CppStructArray_1_Int32_0;
	}
}

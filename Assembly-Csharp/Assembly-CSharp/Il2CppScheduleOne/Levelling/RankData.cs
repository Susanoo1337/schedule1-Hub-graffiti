using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x02000303 RID: 771
	public class RankData : SaveData
	{
		// Token: 0x06003D33 RID: 15667 RVA: 0x00149A94 File Offset: 0x00147C94
		// Note: this type is marked as 'beforefieldinit'.
		static RankData()
		{
			Il2CppClassPointerStore<RankData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "RankData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankData>.NativeClassPtr);
			RankData.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "Rank");
			RankData.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "Tier");
			RankData.NativeFieldInfoPtr_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "XP");
			RankData.NativeFieldInfoPtr_TotalXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "TotalXP");
			RankData.NativeFieldInfoPtr_UnlockedRegions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankData>.NativeClassPtr, "UnlockedRegions");
			RankData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_List_1_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankData>.NativeClassPtr, 100671127);
		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00149B3C File Offset: 0x00147D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152033, XrefRangeEnd = 152042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankData(int rank, int tier, int xp, int totalXP, List<EMapRegion> unlockedRegions) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalXP;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unlockedRegions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_List_1_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x0001E771 File Offset: 0x0001C971
		public RankData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06003D36 RID: 15670 RVA: 0x00149BC0 File Offset: 0x00147DC0
		// (set) Token: 0x06003D37 RID: 15671 RVA: 0x0001E77A File Offset: 0x0001C97A
		public unsafe int Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06003D38 RID: 15672 RVA: 0x00149BE8 File Offset: 0x00147DE8
		// (set) Token: 0x06003D39 RID: 15673 RVA: 0x0001E795 File Offset: 0x0001C995
		public unsafe int Tier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Tier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_Tier)) = value;
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06003D3A RID: 15674 RVA: 0x00149C10 File Offset: 0x00147E10
		// (set) Token: 0x06003D3B RID: 15675 RVA: 0x0001E7B0 File Offset: 0x0001C9B0
		public unsafe int XP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_XP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_XP)) = value;
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06003D3C RID: 15676 RVA: 0x00149C38 File Offset: 0x00147E38
		// (set) Token: 0x06003D3D RID: 15677 RVA: 0x0001E7CB File Offset: 0x0001C9CB
		public unsafe int TotalXP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_TotalXP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_TotalXP)) = value;
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06003D3E RID: 15678 RVA: 0x00149C60 File Offset: 0x00147E60
		// (set) Token: 0x06003D3F RID: 15679 RVA: 0x0001E7E6 File Offset: 0x0001C9E6
		public unsafe List<EMapRegion> UnlockedRegions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_UnlockedRegions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EMapRegion>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankData.NativeFieldInfoPtr_UnlockedRegions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400295D RID: 10589
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x0400295E RID: 10590
		private static readonly IntPtr NativeFieldInfoPtr_Tier;

		// Token: 0x0400295F RID: 10591
		private static readonly IntPtr NativeFieldInfoPtr_XP;

		// Token: 0x04002960 RID: 10592
		private static readonly IntPtr NativeFieldInfoPtr_TotalXP;

		// Token: 0x04002961 RID: 10593
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedRegions;

		// Token: 0x04002962 RID: 10594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_List_1_EMapRegion_0;
	}
}

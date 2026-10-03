using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000270 RID: 624
	[Serializable]
	public class ShroomColonyData : Object
	{
		// Token: 0x06003140 RID: 12608 RVA: 0x0011DFDC File Offset: 0x0011C1DC
		// Note: this type is marked as 'beforefieldinit'.
		static ShroomColonyData()
		{
			Il2CppClassPointerStore<ShroomColonyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ShroomColonyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomColonyData>.NativeClassPtr);
			ShroomColonyData.NativeFieldInfoPtr_MushroomSpawnID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColonyData>.NativeClassPtr, "MushroomSpawnID");
			ShroomColonyData.NativeFieldInfoPtr_GrowthProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColonyData>.NativeClassPtr, "GrowthProgress");
			ShroomColonyData.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColonyData>.NativeClassPtr, "Quality");
			ShroomColonyData.NativeFieldInfoPtr_ActiveMushroomAlignmentIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColonyData>.NativeClassPtr, "ActiveMushroomAlignmentIndices");
			ShroomColonyData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColonyData>.NativeClassPtr, 100669468);
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x0011E070 File Offset: 0x0011C270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135458, RefRangeEnd = 135459, XrefRangeStart = 135455, XrefRangeEnd = 135458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomColonyData(string mushroomSpawnID, float growthProgress, float quality, Il2CppStructArray<int> activeMushroomAlignmentIndices) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomColonyData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mushroomSpawnID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeMushroomAlignmentIndices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColonyData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x00019679 File Offset: 0x00017879
		public ShroomColonyData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x0011E0EC File Offset: 0x0011C2EC
		// (set) Token: 0x06003144 RID: 12612 RVA: 0x00019682 File Offset: 0x00017882
		public unsafe string MushroomSpawnID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColonyData.NativeFieldInfoPtr_MushroomSpawnID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColonyData.NativeFieldInfoPtr_MushroomSpawnID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x0011E114 File Offset: 0x0011C314
		// (set) Token: 0x06003146 RID: 12614 RVA: 0x000196A1 File Offset: 0x000178A1
		public unsafe float GrowthProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColonyData.NativeFieldInfoPtr_GrowthProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColonyData.NativeFieldInfoPtr_GrowthProgress)) = value;
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06003147 RID: 12615 RVA: 0x0011E13C File Offset: 0x0011C33C
		// (set) Token: 0x06003148 RID: 12616 RVA: 0x000196BC File Offset: 0x000178BC
		public unsafe float Quality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColonyData.NativeFieldInfoPtr_Quality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColonyData.NativeFieldInfoPtr_Quality)) = value;
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06003149 RID: 12617 RVA: 0x0011E164 File Offset: 0x0011C364
		// (set) Token: 0x0600314A RID: 12618 RVA: 0x000196D7 File Offset: 0x000178D7
		public unsafe Il2CppStructArray<int> ActiveMushroomAlignmentIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColonyData.NativeFieldInfoPtr_ActiveMushroomAlignmentIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColonyData.NativeFieldInfoPtr_ActiveMushroomAlignmentIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeFieldInfoPtr_MushroomSpawnID;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeFieldInfoPtr_GrowthProgress;

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeFieldInfoPtr_Quality;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeFieldInfoPtr_ActiveMushroomAlignmentIndices;

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Il2CppStructArray_1_Int32_0;
	}
}

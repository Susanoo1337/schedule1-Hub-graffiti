using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Levelling;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002BC RID: 700
	public class Map : Singleton<Map>
	{
		// Token: 0x0600364F RID: 13903 RVA: 0x0012FC6C File Offset: 0x0012DE6C
		// Note: this type is marked as 'beforefieldinit'.
		static Map()
		{
			Il2CppClassPointerStore<Map>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Map");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map>.NativeClassPtr);
			Map.NativeFieldInfoPtr_FINAL_REGION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "FINAL_REGION");
			Map.NativeFieldInfoPtr_UNLOCK_ALL_REGIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "UNLOCK_ALL_REGIONS");
			Map.NativeFieldInfoPtr_Regions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "Regions");
			Map.NativeFieldInfoPtr_PoliceStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "PoliceStation");
			Map.NativeFieldInfoPtr_MedicalCentre = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "MedicalCentre");
			Map.NativeFieldInfoPtr_TreeBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map>.NativeClassPtr, "TreeBounds");
			Map.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100670161);
			Map.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100670162);
			Map.NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100670163);
			Map.NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100670164);
			Map.NativeMethodInfoPtr_GetUnlockedRegions_Public_List_1_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100670165);
			Map.NativeMethodInfoPtr_GetRegionFromPosition_Public_EMapRegion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100670166);
			Map.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map>.NativeClassPtr, 100670167);
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x0012FDA0 File Offset: 0x0012DFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142040, XrefRangeEnd = 142102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Map.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x0012FDDC File Offset: 0x0012DFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142102, XrefRangeEnd = 142132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Map.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x0012FE18 File Offset: 0x0012E018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142132, XrefRangeEnd = 142152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRankUp(FullRank old, FullRank newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref old;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x0012FE64 File Offset: 0x0012E064
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 142166, RefRangeEnd = 142185, XrefRangeStart = 142152, XrefRangeEnd = 142166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapRegionData GetRegionData(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MapRegionData>(intPtr3) : null;
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x0012FEB0 File Offset: 0x0012E0B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142195, RefRangeEnd = 142197, XrefRangeStart = 142185, XrefRangeEnd = 142195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EMapRegion> GetUnlockedRegions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_GetUnlockedRegions_Public_List_1_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EMapRegion>>(intPtr3) : null;
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x0012FEF0 File Offset: 0x0012E0F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142202, RefRangeEnd = 142204, XrefRangeStart = 142197, XrefRangeEnd = 142202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EMapRegion GetRegionFromPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr_GetRegionFromPosition_Public_EMapRegion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x0012FF3C File Offset: 0x0012E13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142204, XrefRangeEnd = 142207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Map() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x0001B9BB File Offset: 0x00019BBB
		public Map(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06003658 RID: 13912 RVA: 0x0012FF78 File Offset: 0x0012E178
		// (set) Token: 0x06003659 RID: 13913 RVA: 0x0001B9C4 File Offset: 0x00019BC4
		public unsafe static EMapRegion FINAL_REGION
		{
			get
			{
				EMapRegion result;
				IL2CPP.il2cpp_field_static_get_value(Map.NativeFieldInfoPtr_FINAL_REGION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Map.NativeFieldInfoPtr_FINAL_REGION, (void*)(&value));
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x0600365A RID: 13914 RVA: 0x0012FF94 File Offset: 0x0012E194
		// (set) Token: 0x0600365B RID: 13915 RVA: 0x0001B9D2 File Offset: 0x00019BD2
		public unsafe bool UNLOCK_ALL_REGIONS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_UNLOCK_ALL_REGIONS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_UNLOCK_ALL_REGIONS)) = value;
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x0600365C RID: 13916 RVA: 0x0012FFBC File Offset: 0x0012E1BC
		// (set) Token: 0x0600365D RID: 13917 RVA: 0x0001B9ED File Offset: 0x00019BED
		public unsafe Il2CppReferenceArray<MapRegionData> Regions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_Regions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapRegionData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_Regions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x0600365E RID: 13918 RVA: 0x0012FFEC File Offset: 0x0012E1EC
		// (set) Token: 0x0600365F RID: 13919 RVA: 0x0001BA0C File Offset: 0x00019C0C
		public unsafe PoliceStation PoliceStation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_PoliceStation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_PoliceStation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06003660 RID: 13920 RVA: 0x0013001C File Offset: 0x0012E21C
		// (set) Token: 0x06003661 RID: 13921 RVA: 0x0001BA2B File Offset: 0x00019C2B
		public unsafe MedicalCentre MedicalCentre
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_MedicalCentre);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MedicalCentre>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_MedicalCentre), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x0013004C File Offset: 0x0012E24C
		// (set) Token: 0x06003663 RID: 13923 RVA: 0x0001BA4A File Offset: 0x00019C4A
		public unsafe Transform TreeBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_TreeBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.NativeFieldInfoPtr_TreeBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400245C RID: 9308
		private static readonly IntPtr NativeFieldInfoPtr_FINAL_REGION;

		// Token: 0x0400245D RID: 9309
		private static readonly IntPtr NativeFieldInfoPtr_UNLOCK_ALL_REGIONS;

		// Token: 0x0400245E RID: 9310
		private static readonly IntPtr NativeFieldInfoPtr_Regions;

		// Token: 0x0400245F RID: 9311
		private static readonly IntPtr NativeFieldInfoPtr_PoliceStation;

		// Token: 0x04002460 RID: 9312
		private static readonly IntPtr NativeFieldInfoPtr_MedicalCentre;

		// Token: 0x04002461 RID: 9313
		private static readonly IntPtr NativeFieldInfoPtr_TreeBounds;

		// Token: 0x04002462 RID: 9314
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002463 RID: 9315
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002464 RID: 9316
		private static readonly IntPtr NativeMethodInfoPtr_OnRankUp_Private_Void_FullRank_FullRank_0;

		// Token: 0x04002465 RID: 9317
		private static readonly IntPtr NativeMethodInfoPtr_GetRegionData_Public_MapRegionData_EMapRegion_0;

		// Token: 0x04002466 RID: 9318
		private static readonly IntPtr NativeMethodInfoPtr_GetUnlockedRegions_Public_List_1_EMapRegion_0;

		// Token: 0x04002467 RID: 9319
		private static readonly IntPtr NativeMethodInfoPtr_GetRegionFromPosition_Public_EMapRegion_Vector3_0;

		// Token: 0x04002468 RID: 9320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A13 RID: 2579
		[ObfuscatedName("ScheduleOne.Map.Map+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE2B RID: 56875 RVA: 0x0036CC3C File Offset: 0x0036AE3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<Map.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Map>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map.__c__DisplayClass6_0>.NativeClassPtr);
				Map.__c__DisplayClass6_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map.__c__DisplayClass6_0>.NativeClassPtr, "region");
				Map.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass6_0>.NativeClassPtr, 100670168);
				Map.__c__DisplayClass6_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass6_0>.NativeClassPtr, 100670169);
			}

			// Token: 0x0600DE2C RID: 56876 RVA: 0x0036CCA4 File Offset: 0x0036AEA4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE2D RID: 56877 RVA: 0x0036CCE0 File Offset: 0x0036AEE0
			[CallerCount(0)]
			public unsafe bool _Awake_b__0(MapRegionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass6_0.NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE2E RID: 56878 RVA: 0x000689A6 File Offset: 0x00066BA6
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A7 RID: 17319
			// (get) Token: 0x0600DE2F RID: 56879 RVA: 0x0036CD30 File Offset: 0x0036AF30
			// (set) Token: 0x0600DE30 RID: 56880 RVA: 0x000689AF File Offset: 0x00066BAF
			public unsafe EMapRegion region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass6_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass6_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x0400975D RID: 38749
			private static readonly IntPtr NativeFieldInfoPtr_region;

			// Token: 0x0400975E RID: 38750
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400975F RID: 38751
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Boolean_MapRegionData_0;
		}

		// Token: 0x02000A14 RID: 2580
		[ObfuscatedName("ScheduleOne.Map.Map+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE31 RID: 56881 RVA: 0x0036CD58 File Offset: 0x0036AF58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<Map.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Map>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Map.__c__DisplayClass9_0>.NativeClassPtr);
				Map.__c__DisplayClass9_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Map.__c__DisplayClass9_0>.NativeClassPtr, "region");
				Map.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass9_0>.NativeClassPtr, 100670170);
				Map.__c__DisplayClass9_0.NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Map.__c__DisplayClass9_0>.NativeClassPtr, 100670171);
			}

			// Token: 0x0600DE32 RID: 56882 RVA: 0x0036CDC0 File Offset: 0x0036AFC0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Map.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE33 RID: 56883 RVA: 0x0036CDFC File Offset: 0x0036AFFC
			[CallerCount(0)]
			public unsafe bool _GetRegionData_b__0(MapRegionData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Map.__c__DisplayClass9_0.NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE34 RID: 56884 RVA: 0x000689CA File Offset: 0x00066BCA
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A8 RID: 17320
			// (get) Token: 0x0600DE35 RID: 56885 RVA: 0x0036CE4C File Offset: 0x0036B04C
			// (set) Token: 0x0600DE36 RID: 56886 RVA: 0x000689D3 File Offset: 0x00066BD3
			public unsafe EMapRegion region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass9_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Map.__c__DisplayClass9_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x04009760 RID: 38752
			private static readonly IntPtr NativeFieldInfoPtr_region;

			// Token: 0x04009761 RID: 38753
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009762 RID: 38754
			private static readonly IntPtr NativeMethodInfoPtr__GetRegionData_b__0_Internal_Boolean_MapRegionData_0;
		}
	}
}

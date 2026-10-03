using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002B5 RID: 693
	[Serializable]
	public class MapRegionData : Il2CppSystem.Object
	{
		// Token: 0x0600359D RID: 13725 RVA: 0x0012DCEC File Offset: 0x0012BEEC
		// Note: this type is marked as 'beforefieldinit'.
		static MapRegionData()
		{
			Il2CppClassPointerStore<MapRegionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "MapRegionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr);
			MapRegionData.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "Region");
			MapRegionData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "Name");
			MapRegionData.NativeFieldInfoPtr_UnlockedByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "UnlockedByDefault");
			MapRegionData.NativeFieldInfoPtr_RankRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RankRequirement");
			MapRegionData.NativeFieldInfoPtr_StartingNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "StartingNPCs");
			MapRegionData.NativeFieldInfoPtr_RegionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RegionSprite");
			MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RegionDeliveryLocations");
			MapRegionData.NativeFieldInfoPtr_AdjacentRegions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "AdjacentRegions");
			MapRegionData.NativeFieldInfoPtr_RegionBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RegionBounds");
			MapRegionData.NativeFieldInfoPtr__IsUnlocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "<IsUnlocked>k__BackingField");
			MapRegionData.NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100670102);
			MapRegionData.NativeMethodInfoPtr_set_IsUnlocked_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100670103);
			MapRegionData.NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100670104);
			MapRegionData.NativeMethodInfoPtr_SetUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100670105);
			MapRegionData.NativeMethodInfoPtr_GetAdjacentRegions_Public_List_1_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100670106);
			MapRegionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, 100670107);
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x0012DE5C File Offset: 0x0012C05C
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x0012DE98 File Offset: 0x0012C098
		public unsafe bool IsUnlocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_set_IsUnlocked_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x0012DED8 File Offset: 0x0012C0D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141665, RefRangeEnd = 141667, XrefRangeStart = 141629, XrefRangeEnd = 141665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryLocation GetRandomUnscheduledDeliveryLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr3) : null;
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x0012DF18 File Offset: 0x0012C118
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 141678, RefRangeEnd = 141684, XrefRangeStart = 141667, XrefRangeEnd = 141678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_SetUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x0012DF4C File Offset: 0x0012C14C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141695, RefRangeEnd = 141696, XrefRangeStart = 141684, XrefRangeEnd = 141695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EMapRegion> GetAdjacentRegions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr_GetAdjacentRegions_Public_List_1_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EMapRegion>>(intPtr3) : null;
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x0012DF8C File Offset: 0x0012C18C
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapRegionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x0001B39E File Offset: 0x0001959E
		public MapRegionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x0012DFC8 File Offset: 0x0012C1C8
		// (set) Token: 0x060035A6 RID: 13734 RVA: 0x0001B3A7 File Offset: 0x000195A7
		public unsafe EMapRegion Region
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Region)) = value;
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x0012DFF0 File Offset: 0x0012C1F0
		// (set) Token: 0x060035A8 RID: 13736 RVA: 0x0001B3C2 File Offset: 0x000195C2
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x0012E018 File Offset: 0x0012C218
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x0001B3E1 File Offset: 0x000195E1
		public unsafe bool UnlockedByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_UnlockedByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_UnlockedByDefault)) = value;
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x0012E040 File Offset: 0x0012C240
		// (set) Token: 0x060035AC RID: 13740 RVA: 0x0001B3FC File Offset: 0x000195FC
		public unsafe FullRank RankRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RankRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RankRequirement)) = value;
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x0012E068 File Offset: 0x0012C268
		// (set) Token: 0x060035AE RID: 13742 RVA: 0x0001B417 File Offset: 0x00019617
		public unsafe Il2CppReferenceArray<NPC> StartingNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_StartingNPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_StartingNPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x060035AF RID: 13743 RVA: 0x0012E098 File Offset: 0x0012C298
		// (set) Token: 0x060035B0 RID: 13744 RVA: 0x0001B436 File Offset: 0x00019636
		public unsafe Sprite RegionSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x060035B1 RID: 13745 RVA: 0x0012E0C8 File Offset: 0x0012C2C8
		// (set) Token: 0x060035B2 RID: 13746 RVA: 0x0001B455 File Offset: 0x00019655
		public unsafe Il2CppReferenceArray<DeliveryLocation> RegionDeliveryLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryLocation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionDeliveryLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x0012E0F8 File Offset: 0x0012C2F8
		// (set) Token: 0x060035B4 RID: 13748 RVA: 0x0001B474 File Offset: 0x00019674
		public unsafe Il2CppReferenceArray<MapRegionData.RegionContainer> AdjacentRegions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_AdjacentRegions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MapRegionData.RegionContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_AdjacentRegions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x0012E128 File Offset: 0x0012C328
		// (set) Token: 0x060035B6 RID: 13750 RVA: 0x0001B493 File Offset: 0x00019693
		public unsafe PolygonalZone RegionBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonalZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr_RegionBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x060035B7 RID: 13751 RVA: 0x0012E158 File Offset: 0x0012C358
		// (set) Token: 0x060035B8 RID: 13752 RVA: 0x0001B4B2 File Offset: 0x000196B2
		public unsafe bool _IsUnlocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr__IsUnlocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.NativeFieldInfoPtr__IsUnlocked_k__BackingField)) = value;
			}
		}

		// Token: 0x040023EF RID: 9199
		private static readonly IntPtr NativeFieldInfoPtr_Region;

		// Token: 0x040023F0 RID: 9200
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040023F1 RID: 9201
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedByDefault;

		// Token: 0x040023F2 RID: 9202
		private static readonly IntPtr NativeFieldInfoPtr_RankRequirement;

		// Token: 0x040023F3 RID: 9203
		private static readonly IntPtr NativeFieldInfoPtr_StartingNPCs;

		// Token: 0x040023F4 RID: 9204
		private static readonly IntPtr NativeFieldInfoPtr_RegionSprite;

		// Token: 0x040023F5 RID: 9205
		private static readonly IntPtr NativeFieldInfoPtr_RegionDeliveryLocations;

		// Token: 0x040023F6 RID: 9206
		private static readonly IntPtr NativeFieldInfoPtr_AdjacentRegions;

		// Token: 0x040023F7 RID: 9207
		private static readonly IntPtr NativeFieldInfoPtr_RegionBounds;

		// Token: 0x040023F8 RID: 9208
		private static readonly IntPtr NativeFieldInfoPtr__IsUnlocked_k__BackingField;

		// Token: 0x040023F9 RID: 9209
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0;

		// Token: 0x040023FA RID: 9210
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUnlocked_Private_set_Void_Boolean_0;

		// Token: 0x040023FB RID: 9211
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomUnscheduledDeliveryLocation_Public_DeliveryLocation_0;

		// Token: 0x040023FC RID: 9212
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Public_Void_0;

		// Token: 0x040023FD RID: 9213
		private static readonly IntPtr NativeMethodInfoPtr_GetAdjacentRegions_Public_List_1_EMapRegion_0;

		// Token: 0x040023FE RID: 9214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A10 RID: 2576
		[Serializable]
		public class RegionContainer : Il2CppSystem.Object
		{
			// Token: 0x0600DE15 RID: 56853 RVA: 0x0036C8E4 File Offset: 0x0036AAE4
			// Note: this type is marked as 'beforefieldinit'.
			static RegionContainer()
			{
				Il2CppClassPointerStore<MapRegionData.RegionContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "RegionContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapRegionData.RegionContainer>.NativeClassPtr);
				MapRegionData.RegionContainer.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData.RegionContainer>.NativeClassPtr, "Region");
				MapRegionData.RegionContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData.RegionContainer>.NativeClassPtr, 100670108);
			}

			// Token: 0x0600DE16 RID: 56854 RVA: 0x0036C938 File Offset: 0x0036AB38
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RegionContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapRegionData.RegionContainer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.RegionContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE17 RID: 56855 RVA: 0x000688EF File Offset: 0x00066AEF
			public RegionContainer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A1 RID: 17313
			// (get) Token: 0x0600DE18 RID: 56856 RVA: 0x0036C974 File Offset: 0x0036AB74
			// (set) Token: 0x0600DE19 RID: 56857 RVA: 0x000688F8 File Offset: 0x00066AF8
			public unsafe EMapRegion Region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.RegionContainer.NativeFieldInfoPtr_Region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapRegionData.RegionContainer.NativeFieldInfoPtr_Region)) = value;
				}
			}

			// Token: 0x04009753 RID: 38739
			private static readonly IntPtr NativeFieldInfoPtr_Region;

			// Token: 0x04009754 RID: 38740
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A11 RID: 2577
		[ObfuscatedName("ScheduleOne.Map.MapRegionData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DE1A RID: 56858 RVA: 0x0036C99C File Offset: 0x0036AB9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MapRegionData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr);
				MapRegionData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, "<>9");
				MapRegionData.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, "<>9__14_0");
				MapRegionData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, 100670110);
				MapRegionData.__c.NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__14_0_Internal_Boolean_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr, 100670111);
			}

			// Token: 0x0600DE1B RID: 56859 RVA: 0x0036CA18 File Offset: 0x0036AC18
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapRegionData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE1C RID: 56860 RVA: 0x0036CA54 File Offset: 0x0036AC54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141628, XrefRangeEnd = 141629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomUnscheduledDeliveryLocation_b__14_0(DeliveryLocation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapRegionData.__c.NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__14_0_Internal_Boolean_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE1D RID: 56861 RVA: 0x00068913 File Offset: 0x00066B13
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A2 RID: 17314
			// (get) Token: 0x0600DE1E RID: 56862 RVA: 0x0036CAA4 File Offset: 0x0036ACA4
			// (set) Token: 0x0600DE1F RID: 56863 RVA: 0x0006891C File Offset: 0x00066B1C
			public unsafe static MapRegionData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MapRegionData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapRegionData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MapRegionData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A3 RID: 17315
			// (get) Token: 0x0600DE20 RID: 56864 RVA: 0x0036CACC File Offset: 0x0036ACCC
			// (set) Token: 0x0600DE21 RID: 56865 RVA: 0x0006892E File Offset: 0x00066B2E
			public unsafe static Func<DeliveryLocation, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MapRegionData.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeliveryLocation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MapRegionData.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009755 RID: 38741
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009756 RID: 38742
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04009757 RID: 38743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009758 RID: 38744
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomUnscheduledDeliveryLocation_b__14_0_Internal_Boolean_DeliveryLocation_0;
		}
	}
}

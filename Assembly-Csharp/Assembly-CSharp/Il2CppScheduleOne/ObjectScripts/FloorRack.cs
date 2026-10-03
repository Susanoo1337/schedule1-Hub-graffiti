using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Building;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200059A RID: 1434
	public class FloorRack : GridItem
	{
		// Token: 0x060082A4 RID: 33444 RVA: 0x0023BCB0 File Offset: 0x00239EB0
		// Note: this type is marked as 'beforefieldinit'.
		static FloorRack()
		{
			Il2CppClassPointerStore<FloorRack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "FloorRack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloorRack>.NativeClassPtr);
			FloorRack.NativeFieldInfoPtr_leg_BottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_BottomLeft");
			FloorRack.NativeFieldInfoPtr_leg_BottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_BottomRight");
			FloorRack.NativeFieldInfoPtr_leg_TopLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_TopLeft");
			FloorRack.NativeFieldInfoPtr_leg_TopRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_TopRight");
			FloorRack.NativeFieldInfoPtr_obs_BottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_BottomLeft");
			FloorRack.NativeFieldInfoPtr_obs_BottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_BottomRight");
			FloorRack.NativeFieldInfoPtr_obs_TopLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_TopLeft");
			FloorRack.NativeFieldInfoPtr_obs_TopRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_TopRight");
			FloorRack.NativeFieldInfoPtr_procTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "procTiles");
			FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted");
			FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted");
			FloorRack.NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680094);
			FloorRack.NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680095);
			FloorRack.NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680096);
			FloorRack.NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680097);
			FloorRack.NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680098);
			FloorRack.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680099);
			FloorRack.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680100);
			FloorRack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680101);
			FloorRack.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680102);
			FloorRack.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680103);
			FloorRack.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680104);
			FloorRack.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100680105);
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x060082A5 RID: 33445 RVA: 0x0023BEAC File Offset: 0x0023A0AC
		public unsafe virtual List<ProceduralTile> ProceduralTiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr3) : null;
			}
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x0023BEEC File Offset: 0x0023A0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246727, XrefRangeEnd = 246735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLegVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x0023BF28 File Offset: 0x0023A128
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 246818, RefRangeEnd = 246822, XrefRangeStart = 246735, XrefRangeEnd = 246818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CockAndBalls(GameObject leg, CornerObstacle obs, int xOffset, int yOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leg);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x0023BF98 File Offset: 0x0023A198
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 246833, RefRangeEnd = 246841, XrefRangeStart = 246822, XrefRangeEnd = 246833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloorRack GetFloorRackFromOccupants(List<GridItem> occs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FloorRack>(intPtr3) : null;
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x0023BFE8 File Offset: 0x0023A1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246841, XrefRangeEnd = 246871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<FloorRack> GetSurroundingRacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FloorRack>>(intPtr3) : null;
		}

		// Token: 0x060082AA RID: 33450 RVA: 0x0023C028 File Offset: 0x0023A228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246871, XrefRangeEnd = 246878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanShareTileWith(List<GridItem> obstacles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obstacles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060082AB RID: 33451 RVA: 0x0023C080 File Offset: 0x0023A280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246878, XrefRangeEnd = 246898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060082AC RID: 33452 RVA: 0x0023C0E4 File Offset: 0x0023A2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloorRack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloorRack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082AD RID: 33453 RVA: 0x0023C120 File Offset: 0x0023A320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246898, XrefRangeEnd = 246899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082AE RID: 33454 RVA: 0x0023C15C File Offset: 0x0023A35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246899, XrefRangeEnd = 246900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082AF RID: 33455 RVA: 0x0023C198 File Offset: 0x0023A398
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B0 RID: 33456 RVA: 0x0023C1D4 File Offset: 0x0023A3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060082B1 RID: 33457 RVA: 0x0003E0E4 File Offset: 0x0003C2E4
		public FloorRack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x060082B2 RID: 33458 RVA: 0x0023C210 File Offset: 0x0023A410
		// (set) Token: 0x060082B3 RID: 33459 RVA: 0x0003E0ED File Offset: 0x0003C2ED
		public unsafe Transform leg_BottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x060082B4 RID: 33460 RVA: 0x0023C240 File Offset: 0x0023A440
		// (set) Token: 0x060082B5 RID: 33461 RVA: 0x0003E10C File Offset: 0x0003C30C
		public unsafe Transform leg_BottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x060082B6 RID: 33462 RVA: 0x0023C270 File Offset: 0x0023A470
		// (set) Token: 0x060082B7 RID: 33463 RVA: 0x0003E12B File Offset: 0x0003C32B
		public unsafe Transform leg_TopLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x060082B8 RID: 33464 RVA: 0x0023C2A0 File Offset: 0x0023A4A0
		// (set) Token: 0x060082B9 RID: 33465 RVA: 0x0003E14A File Offset: 0x0003C34A
		public unsafe Transform leg_TopRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002858 RID: 10328
		// (get) Token: 0x060082BA RID: 33466 RVA: 0x0023C2D0 File Offset: 0x0023A4D0
		// (set) Token: 0x060082BB RID: 33467 RVA: 0x0003E169 File Offset: 0x0003C369
		public unsafe CornerObstacle obs_BottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002859 RID: 10329
		// (get) Token: 0x060082BC RID: 33468 RVA: 0x0023C300 File Offset: 0x0023A500
		// (set) Token: 0x060082BD RID: 33469 RVA: 0x0003E188 File Offset: 0x0003C388
		public unsafe CornerObstacle obs_BottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285A RID: 10330
		// (get) Token: 0x060082BE RID: 33470 RVA: 0x0023C330 File Offset: 0x0023A530
		// (set) Token: 0x060082BF RID: 33471 RVA: 0x0003E1A7 File Offset: 0x0003C3A7
		public unsafe CornerObstacle obs_TopLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285B RID: 10331
		// (get) Token: 0x060082C0 RID: 33472 RVA: 0x0023C360 File Offset: 0x0023A560
		// (set) Token: 0x060082C1 RID: 33473 RVA: 0x0003E1C6 File Offset: 0x0003C3C6
		public unsafe CornerObstacle obs_TopRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285C RID: 10332
		// (get) Token: 0x060082C2 RID: 33474 RVA: 0x0023C390 File Offset: 0x0023A590
		// (set) Token: 0x060082C3 RID: 33475 RVA: 0x0003E1E5 File Offset: 0x0003C3E5
		public unsafe List<ProceduralTile> procTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_procTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_procTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700285D RID: 10333
		// (get) Token: 0x060082C4 RID: 33476 RVA: 0x0023C3C0 File Offset: 0x0023A5C0
		// (set) Token: 0x060082C5 RID: 33477 RVA: 0x0003E204 File Offset: 0x0003C404
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x060082C6 RID: 33478 RVA: 0x0023C3E8 File Offset: 0x0023A5E8
		// (set) Token: 0x060082C7 RID: 33479 RVA: 0x0003E21F File Offset: 0x0003C41F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005914 RID: 22804
		private static readonly IntPtr NativeFieldInfoPtr_leg_BottomLeft;

		// Token: 0x04005915 RID: 22805
		private static readonly IntPtr NativeFieldInfoPtr_leg_BottomRight;

		// Token: 0x04005916 RID: 22806
		private static readonly IntPtr NativeFieldInfoPtr_leg_TopLeft;

		// Token: 0x04005917 RID: 22807
		private static readonly IntPtr NativeFieldInfoPtr_leg_TopRight;

		// Token: 0x04005918 RID: 22808
		private static readonly IntPtr NativeFieldInfoPtr_obs_BottomLeft;

		// Token: 0x04005919 RID: 22809
		private static readonly IntPtr NativeFieldInfoPtr_obs_BottomRight;

		// Token: 0x0400591A RID: 22810
		private static readonly IntPtr NativeFieldInfoPtr_obs_TopLeft;

		// Token: 0x0400591B RID: 22811
		private static readonly IntPtr NativeFieldInfoPtr_obs_TopRight;

		// Token: 0x0400591C RID: 22812
		private static readonly IntPtr NativeFieldInfoPtr_procTiles;

		// Token: 0x0400591D RID: 22813
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400591E RID: 22814
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400591F RID: 22815
		private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0;

		// Token: 0x04005920 RID: 22816
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0;

		// Token: 0x04005921 RID: 22817
		private static readonly IntPtr NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0;

		// Token: 0x04005922 RID: 22818
		private static readonly IntPtr NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0;

		// Token: 0x04005923 RID: 22819
		private static readonly IntPtr NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0;

		// Token: 0x04005924 RID: 22820
		private static readonly IntPtr NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0;

		// Token: 0x04005925 RID: 22821
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04005926 RID: 22822
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005927 RID: 22823
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005928 RID: 22824
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005929 RID: 22825
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400592A RID: 22826
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}

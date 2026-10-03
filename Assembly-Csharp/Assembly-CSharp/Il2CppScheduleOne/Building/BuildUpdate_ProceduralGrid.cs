using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000466 RID: 1126
	public class BuildUpdate_ProceduralGrid : BuildUpdate_Base
	{
		// Token: 0x060065B1 RID: 26033 RVA: 0x001DBD84 File Offset: 0x001D9F84
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_ProceduralGrid()
		{
			Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_ProceduralGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr);
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "GhostModel");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "ItemClass");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "ItemInstance");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "detectionRange");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "detectionMask");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "rotation_Smoothing");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "_rotation");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "validPosition");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "currentGhostMaterial");
			BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "bestIntersection");
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676647);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676648);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676649);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676650);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676651);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676652);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676653);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Place_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676654);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676655);
			BuildUpdate_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, 100676656);
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x001DBF44 File Offset: 0x001DA144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212815, XrefRangeEnd = 212823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B3 RID: 26035 RVA: 0x001DBF80 File Offset: 0x001DA180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212823, XrefRangeEnd = 212864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B4 RID: 26036 RVA: 0x001DBFBC File Offset: 0x001DA1BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212882, RefRangeEnd = 212883, XrefRangeStart = 212864, XrefRangeEnd = 212882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B5 RID: 26037 RVA: 0x001DBFF0 File Offset: 0x001DA1F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212914, RefRangeEnd = 212915, XrefRangeStart = 212883, XrefRangeEnd = 212914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x001DC024 File Offset: 0x001DA224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212915, XrefRangeEnd = 212996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckGridIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x001DC060 File Offset: 0x001DA260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213013, RefRangeEnd = 213014, XrefRangeStart = 212996, XrefRangeEnd = 213013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x001DC094 File Offset: 0x001DA294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213032, RefRangeEnd = 213034, XrefRangeStart = 213014, XrefRangeEnd = 213032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatchValid(FootprintTile footprintTile, ProceduralTile matchedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprintTile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matchedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065B9 RID: 26041 RVA: 0x001DC0F4 File Offset: 0x001DA2F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213077, RefRangeEnd = 213078, XrefRangeStart = 213034, XrefRangeEnd = 213077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_Place_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065BA RID: 26042 RVA: 0x001DC128 File Offset: 0x001DA328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213078, XrefRangeEnd = 213093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralTile GetNearbyProcTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr3) : null;
		}

		// Token: 0x060065BB RID: 26043 RVA: 0x001DC168 File Offset: 0x001DA368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213093, XrefRangeEnd = 213094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_ProceduralGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x0002FDB5 File Offset: 0x0002DFB5
		public BuildUpdate_ProceduralGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x060065BD RID: 26045 RVA: 0x001DC1A4 File Offset: 0x001DA3A4
		// (set) Token: 0x060065BE RID: 26046 RVA: 0x0002FDBE File Offset: 0x0002DFBE
		public unsafe GameObject GhostModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_GhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x060065BF RID: 26047 RVA: 0x001DC1D4 File Offset: 0x001DA3D4
		// (set) Token: 0x060065C0 RID: 26048 RVA: 0x0002FDDD File Offset: 0x0002DFDD
		public unsafe ProceduralGridItem ItemClass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemClass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x060065C1 RID: 26049 RVA: 0x001DC204 File Offset: 0x001DA404
		// (set) Token: 0x060065C2 RID: 26050 RVA: 0x0002FDFC File Offset: 0x0002DFFC
		public unsafe ItemInstance ItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_ItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x060065C3 RID: 26051 RVA: 0x001DC234 File Offset: 0x001DA434
		// (set) Token: 0x060065C4 RID: 26052 RVA: 0x0002FE1B File Offset: 0x0002E01B
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x060065C5 RID: 26053 RVA: 0x001DC25C File Offset: 0x001DA45C
		// (set) Token: 0x060065C6 RID: 26054 RVA: 0x0002FE36 File Offset: 0x0002E036
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x060065C7 RID: 26055 RVA: 0x001DC284 File Offset: 0x001DA484
		// (set) Token: 0x060065C8 RID: 26056 RVA: 0x0002FE51 File Offset: 0x0002E051
		public unsafe float rotation_Smoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_rotation_Smoothing)) = value;
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x060065C9 RID: 26057 RVA: 0x001DC2AC File Offset: 0x001DA4AC
		// (set) Token: 0x060065CA RID: 26058 RVA: 0x0002FE6C File Offset: 0x0002E06C
		public unsafe float _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr__rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr__rotation)) = value;
			}
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x060065CB RID: 26059 RVA: 0x001DC2D4 File Offset: 0x001DA4D4
		// (set) Token: 0x060065CC RID: 26060 RVA: 0x0002FE87 File Offset: 0x0002E087
		public unsafe bool validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_validPosition)) = value;
			}
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x060065CD RID: 26061 RVA: 0x001DC2FC File Offset: 0x001DA4FC
		// (set) Token: 0x060065CE RID: 26062 RVA: 0x0002FEA2 File Offset: 0x0002E0A2
		public unsafe Material currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x060065CF RID: 26063 RVA: 0x001DC32C File Offset: 0x001DA52C
		// (set) Token: 0x060065D0 RID: 26064 RVA: 0x0002FEC1 File Offset: 0x0002E0C1
		public unsafe BuildUpdate_ProceduralGrid.Intersection bestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildUpdate_ProceduralGrid.Intersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.NativeFieldInfoPtr_bestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004613 RID: 17939
		private static readonly IntPtr NativeFieldInfoPtr_GhostModel;

		// Token: 0x04004614 RID: 17940
		private static readonly IntPtr NativeFieldInfoPtr_ItemClass;

		// Token: 0x04004615 RID: 17941
		private static readonly IntPtr NativeFieldInfoPtr_ItemInstance;

		// Token: 0x04004616 RID: 17942
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x04004617 RID: 17943
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x04004618 RID: 17944
		private static readonly IntPtr NativeFieldInfoPtr_rotation_Smoothing;

		// Token: 0x04004619 RID: 17945
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x0400461A RID: 17946
		private static readonly IntPtr NativeFieldInfoPtr_validPosition;

		// Token: 0x0400461B RID: 17947
		private static readonly IntPtr NativeFieldInfoPtr_currentGhostMaterial;

		// Token: 0x0400461C RID: 17948
		private static readonly IntPtr NativeFieldInfoPtr_bestIntersection;

		// Token: 0x0400461D RID: 17949
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400461E RID: 17950
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400461F RID: 17951
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x04004620 RID: 17952
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x04004621 RID: 17953
		private static readonly IntPtr NativeMethodInfoPtr_CheckGridIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x04004622 RID: 17954
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x04004623 RID: 17955
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchValid_Private_Boolean_FootprintTile_ProceduralTile_0;

		// Token: 0x04004624 RID: 17956
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Void_0;

		// Token: 0x04004625 RID: 17957
		private static readonly IntPtr NativeMethodInfoPtr_GetNearbyProcTile_Private_ProceduralTile_0;

		// Token: 0x04004626 RID: 17958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B43 RID: 2883
		public class Intersection : Il2CppSystem.Object
		{
			// Token: 0x0600E717 RID: 59159 RVA: 0x003859AC File Offset: 0x00383BAC
			// Note: this type is marked as 'beforefieldinit'.
			static Intersection()
			{
				Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid>.NativeClassPtr, "Intersection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr);
				BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, "footprintTile");
				BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, "procTile");
				BuildUpdate_ProceduralGrid.Intersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr, 100676657);
			}

			// Token: 0x0600E718 RID: 59160 RVA: 0x00385A14 File Offset: 0x00383C14
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Intersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_ProceduralGrid.Intersection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_ProceduralGrid.Intersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E719 RID: 59161 RVA: 0x0006D001 File Offset: 0x0006B201
			public Intersection(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004621 RID: 17953
			// (get) Token: 0x0600E71A RID: 59162 RVA: 0x00385A50 File Offset: 0x00383C50
			// (set) Token: 0x0600E71B RID: 59163 RVA: 0x0006D00A File Offset: 0x0006B20A
			public unsafe FootprintTile footprintTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_footprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004622 RID: 17954
			// (get) Token: 0x0600E71C RID: 59164 RVA: 0x00385A80 File Offset: 0x00383C80
			// (set) Token: 0x0600E71D RID: 59165 RVA: 0x0006D029 File Offset: 0x0006B229
			public unsafe ProceduralTile procTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_ProceduralGrid.Intersection.NativeFieldInfoPtr_procTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CD7 RID: 40151
			private static readonly IntPtr NativeFieldInfoPtr_footprintTile;

			// Token: 0x04009CD8 RID: 40152
			private static readonly IntPtr NativeFieldInfoPtr_procTile;

			// Token: 0x04009CD9 RID: 40153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

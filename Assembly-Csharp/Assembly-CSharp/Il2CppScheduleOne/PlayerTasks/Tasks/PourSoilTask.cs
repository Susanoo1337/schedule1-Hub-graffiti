using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts.Soil;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000191 RID: 401
	public class PourSoilTask : GrowContainerPourTask
	{
		// Token: 0x060028A6 RID: 10406 RVA: 0x00101454 File Offset: 0x000FF654
		// Note: this type is marked as 'beforefieldinit'.
		static PourSoilTask()
		{
			Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "PourSoilTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr);
			PourSoilTask.NativeFieldInfoPtr__soilDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, "_soilDefinition");
			PourSoilTask.NativeFieldInfoPtr__pourableSoil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, "_pourableSoil");
			PourSoilTask.NativeFieldInfoPtr__hoveredTopCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, "_hoveredTopCollider");
			PourSoilTask.NativeFieldInfoPtr__growContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, "_growContainer");
			PourSoilTask.NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668491);
			PourSoilTask.NativeMethodInfoPtr_OnInitialPour_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668492);
			PourSoilTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668493);
			PourSoilTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668494);
			PourSoilTask.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668495);
			PourSoilTask.NativeMethodInfoPtr_UpdateHover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668496);
			PourSoilTask.NativeMethodInfoPtr_GetHoveredTopCollider_Private_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668497);
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x00101560 File Offset: 0x000FF760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121494, RefRangeEnd = 121495, XrefRangeStart = 121462, XrefRangeEnd = 121494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourSoilTask(GrowContainer growContainer, ItemInstance itemInstance, Pourable pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pourablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourSoilTask.NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x001015D0 File Offset: 0x000FF7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121495, XrefRangeEnd = 121496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourSoilTask.NativeMethodInfoPtr_OnInitialPour_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x0010160C File Offset: 0x000FF80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121496, XrefRangeEnd = 121522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourSoilTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00101648 File Offset: 0x000FF848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121522, XrefRangeEnd = 121529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourSoilTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x00101684 File Offset: 0x000FF884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121529, XrefRangeEnd = 121546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourSoilTask.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x001016C0 File Offset: 0x000FF8C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121562, RefRangeEnd = 121563, XrefRangeStart = 121546, XrefRangeEnd = 121562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourSoilTask.NativeMethodInfoPtr_UpdateHover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x001016F4 File Offset: 0x000FF8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121563, XrefRangeEnd = 121577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider GetHoveredTopCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourSoilTask.NativeMethodInfoPtr_GetHoveredTopCollider_Private_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000155D8 File Offset: 0x000137D8
		public PourSoilTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x00101734 File Offset: 0x000FF934
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x000155E1 File Offset: 0x000137E1
		public unsafe SoilDefinition _soilDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr__soilDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr__soilDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x00101764 File Offset: 0x000FF964
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x00015600 File Offset: 0x00013800
		public unsafe PourableSoil _pourableSoil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr__pourableSoil);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableSoil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr__pourableSoil), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x00101794 File Offset: 0x000FF994
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x0001561F File Offset: 0x0001381F
		public unsafe Collider _hoveredTopCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr__hoveredTopCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr__hoveredTopCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x001017C4 File Offset: 0x000FF9C4
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x0001563E File Offset: 0x0001383E
		public unsafe GrowContainer _growContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr__growContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr__growContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BF3 RID: 7155
		private static readonly IntPtr NativeFieldInfoPtr__soilDefinition;

		// Token: 0x04001BF4 RID: 7156
		private static readonly IntPtr NativeFieldInfoPtr__pourableSoil;

		// Token: 0x04001BF5 RID: 7157
		private static readonly IntPtr NativeFieldInfoPtr__hoveredTopCollider;

		// Token: 0x04001BF6 RID: 7158
		private static readonly IntPtr NativeFieldInfoPtr__growContainer;

		// Token: 0x04001BF7 RID: 7159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0;

		// Token: 0x04001BF8 RID: 7160
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialPour_Protected_Virtual_Void_0;

		// Token: 0x04001BF9 RID: 7161
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001BFA RID: 7162
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001BFB RID: 7163
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0;

		// Token: 0x04001BFC RID: 7164
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHover_Private_Void_0;

		// Token: 0x04001BFD RID: 7165
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredTopCollider_Private_Collider_0;
	}
}

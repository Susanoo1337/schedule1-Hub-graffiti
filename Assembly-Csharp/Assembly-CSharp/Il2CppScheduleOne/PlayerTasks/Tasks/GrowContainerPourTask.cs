using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x0200018E RID: 398
	public class GrowContainerPourTask : Task
	{
		// Token: 0x06002867 RID: 10343 RVA: 0x001007FC File Offset: 0x000FE9FC
		// Note: this type is marked as 'beforefieldinit'.
		static GrowContainerPourTask()
		{
			Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "GrowContainerPourTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr);
			GrowContainerPourTask.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, "<TaskName>k__BackingField");
			GrowContainerPourTask.NativeFieldInfoPtr_growContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, "growContainer");
			GrowContainerPourTask.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, "item");
			GrowContainerPourTask.NativeFieldInfoPtr_pourable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, "pourable");
			GrowContainerPourTask.NativeFieldInfoPtr__UseCoverage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, "<UseCoverage>k__BackingField");
			GrowContainerPourTask.NativeFieldInfoPtr__FailOnEmpty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, "<FailOnEmpty>k__BackingField");
			GrowContainerPourTask.NativeFieldInfoPtr__CameraPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, "<CameraPosition>k__BackingField");
			GrowContainerPourTask.NativeFieldInfoPtr_removeItemAfterInitialPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, "removeItemAfterInitialPour");
			GrowContainerPourTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, 100668470);
			GrowContainerPourTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, 100668471);
			GrowContainerPourTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, 100668472);
			GrowContainerPourTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, 100668473);
			GrowContainerPourTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_New_get_ECameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, 100668474);
			GrowContainerPourTask.NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, 100668475);
			GrowContainerPourTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, 100668476);
			GrowContainerPourTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, 100668477);
			GrowContainerPourTask.NativeMethodInfoPtr_OnInitialPour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, 100668478);
			GrowContainerPourTask.NativeMethodInfoPtr_RemoveItem_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, 100668479);
			GrowContainerPourTask.NativeMethodInfoPtr_FullyCovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr, 100668480);
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x001009A8 File Offset: 0x000FEBA8
		// (set) Token: 0x06002869 RID: 10345 RVA: 0x001009EC File Offset: 0x000FEBEC
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerPourTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerPourTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x00100A3C File Offset: 0x000FEC3C
		public unsafe virtual bool UseCoverage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerPourTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x00100A84 File Offset: 0x000FEC84
		public unsafe virtual bool FailOnEmpty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerPourTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x00100ACC File Offset: 0x000FECCC
		public unsafe virtual GrowContainerCameraHandler.ECameraPosition CameraPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerPourTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_New_get_ECameraPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00100B14 File Offset: 0x000FED14
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 121221, RefRangeEnd = 121226, XrefRangeStart = 121129, XrefRangeEnd = 121221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrowContainerPourTask(GrowContainer _growContainer, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerPourTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_growContainer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerPourTask.NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00100B84 File Offset: 0x000FED84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121227, RefRangeEnd = 121228, XrefRangeStart = 121226, XrefRangeEnd = 121227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerPourTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00100BC0 File Offset: 0x000FEDC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 121261, RefRangeEnd = 121264, XrefRangeStart = 121228, XrefRangeEnd = 121261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerPourTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00100BFC File Offset: 0x000FEDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121264, XrefRangeEnd = 121265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInitialPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerPourTask.NativeMethodInfoPtr_OnInitialPour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00100C38 File Offset: 0x000FEE38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 121291, RefRangeEnd = 121294, XrefRangeStart = 121265, XrefRangeEnd = 121291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerPourTask.NativeMethodInfoPtr_RemoveItem_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00100C6C File Offset: 0x000FEE6C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FullyCovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerPourTask.NativeMethodInfoPtr_FullyCovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x000153CD File Offset: 0x000135CD
		public GrowContainerPourTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x00100CA8 File Offset: 0x000FEEA8
		// (set) Token: 0x06002875 RID: 10357 RVA: 0x000153D6 File Offset: 0x000135D6
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06002876 RID: 10358 RVA: 0x00100CD0 File Offset: 0x000FEED0
		// (set) Token: 0x06002877 RID: 10359 RVA: 0x000153F5 File Offset: 0x000135F5
		public unsafe GrowContainer growContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr_growContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr_growContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x00100D00 File Offset: 0x000FEF00
		// (set) Token: 0x06002879 RID: 10361 RVA: 0x00015414 File Offset: 0x00013614
		public unsafe ItemInstance item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr_item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x0600287A RID: 10362 RVA: 0x00100D30 File Offset: 0x000FEF30
		// (set) Token: 0x0600287B RID: 10363 RVA: 0x00015433 File Offset: 0x00013633
		public unsafe Pourable pourable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr_pourable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pourable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr_pourable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x00100D60 File Offset: 0x000FEF60
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x00015452 File Offset: 0x00013652
		public unsafe bool _UseCoverage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr__UseCoverage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr__UseCoverage_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x0600287E RID: 10366 RVA: 0x00100D88 File Offset: 0x000FEF88
		// (set) Token: 0x0600287F RID: 10367 RVA: 0x0001546D File Offset: 0x0001366D
		public unsafe bool _FailOnEmpty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr__FailOnEmpty_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr__FailOnEmpty_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x00100DB0 File Offset: 0x000FEFB0
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x00015488 File Offset: 0x00013688
		public unsafe GrowContainerCameraHandler.ECameraPosition _CameraPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr__CameraPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr__CameraPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x00100DD8 File Offset: 0x000FEFD8
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x000154A3 File Offset: 0x000136A3
		public unsafe bool removeItemAfterInitialPour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr_removeItemAfterInitialPour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerPourTask.NativeFieldInfoPtr_removeItemAfterInitialPour)) = value;
			}
		}

		// Token: 0x04001BCC RID: 7116
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001BCD RID: 7117
		private static readonly IntPtr NativeFieldInfoPtr_growContainer;

		// Token: 0x04001BCE RID: 7118
		private static readonly IntPtr NativeFieldInfoPtr_item;

		// Token: 0x04001BCF RID: 7119
		private static readonly IntPtr NativeFieldInfoPtr_pourable;

		// Token: 0x04001BD0 RID: 7120
		private static readonly IntPtr NativeFieldInfoPtr__UseCoverage_k__BackingField;

		// Token: 0x04001BD1 RID: 7121
		private static readonly IntPtr NativeFieldInfoPtr__FailOnEmpty_k__BackingField;

		// Token: 0x04001BD2 RID: 7122
		private static readonly IntPtr NativeFieldInfoPtr__CameraPosition_k__BackingField;

		// Token: 0x04001BD3 RID: 7123
		private static readonly IntPtr NativeFieldInfoPtr_removeItemAfterInitialPour;

		// Token: 0x04001BD4 RID: 7124
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001BD5 RID: 7125
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001BD6 RID: 7126
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04001BD7 RID: 7127
		private static readonly IntPtr NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04001BD8 RID: 7128
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_New_get_ECameraPosition_0;

		// Token: 0x04001BD9 RID: 7129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0;

		// Token: 0x04001BDA RID: 7130
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialPour_Protected_Virtual_New_Void_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Protected_Void_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_FullyCovered_Protected_Virtual_New_Void_0;
	}
}

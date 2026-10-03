using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000190 RID: 400
	public class PourOntoTargetTask : GrowContainerPourTask
	{
		// Token: 0x0600289A RID: 10394 RVA: 0x001011FC File Offset: 0x000FF3FC
		// Note: this type is marked as 'beforefieldinit'.
		static PourOntoTargetTask()
		{
			Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "PourOntoTargetTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr);
			PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "SUCCESS_THRESHOLD");
			PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "SUCCESS_TIME");
			PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, "timeOverTarget");
			PourOntoTargetTask.NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668487);
			PourOntoTargetTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668488);
			PourOntoTargetTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668489);
			PourOntoTargetTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr, 100668490);
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x001012B8 File Offset: 0x000FF4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121444, XrefRangeEnd = 121448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourOntoTargetTask(GrowContainer _growContainer, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourOntoTargetTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_growContainer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourOntoTargetTask.NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x00101328 File Offset: 0x000FF528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121448, XrefRangeEnd = 121452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x00101364 File Offset: 0x000FF564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121452, XrefRangeEnd = 121455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x001013A0 File Offset: 0x000FF5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121455, XrefRangeEnd = 121462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TargetReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourOntoTargetTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x0001557E File Offset: 0x0001377E
		public PourOntoTargetTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x001013DC File Offset: 0x000FF5DC
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x00015587 File Offset: 0x00013787
		public unsafe float SUCCESS_THRESHOLD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_THRESHOLD)) = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x00101404 File Offset: 0x000FF604
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x000155A2 File Offset: 0x000137A2
		public unsafe float SUCCESS_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_SUCCESS_TIME)) = value;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x0010142C File Offset: 0x000FF62C
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x000155BD File Offset: 0x000137BD
		public unsafe float timeOverTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourOntoTargetTask.NativeFieldInfoPtr_timeOverTarget)) = value;
			}
		}

		// Token: 0x04001BEC RID: 7148
		private static readonly IntPtr NativeFieldInfoPtr_SUCCESS_THRESHOLD;

		// Token: 0x04001BED RID: 7149
		private static readonly IntPtr NativeFieldInfoPtr_SUCCESS_TIME;

		// Token: 0x04001BEE RID: 7150
		private static readonly IntPtr NativeFieldInfoPtr_timeOverTarget;

		// Token: 0x04001BEF RID: 7151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0;

		// Token: 0x04001BF0 RID: 7152
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001BF1 RID: 7153
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001BF2 RID: 7154
		private static readonly IntPtr NativeMethodInfoPtr_TargetReached_Public_Virtual_New_Void_0;
	}
}

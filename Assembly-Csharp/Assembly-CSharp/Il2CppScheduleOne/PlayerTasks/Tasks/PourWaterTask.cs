using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000192 RID: 402
	public class PourWaterTask : PourOntoTargetTask
	{
		// Token: 0x060028B7 RID: 10423 RVA: 0x001017F4 File Offset: 0x000FF9F4
		// Note: this type is marked as 'beforefieldinit'.
		static PourWaterTask()
		{
			Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "PourWaterTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr);
			PourWaterTask.NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, "NORMALIZED_FILL_PER_TARGET");
			PourWaterTask.NativeFieldInfoPtr_hintShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, "hintShown");
			PourWaterTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668498);
			PourWaterTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668499);
			PourWaterTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668500);
			PourWaterTask.NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668501);
			PourWaterTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668502);
			PourWaterTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr, 100668503);
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x001018C4 File Offset: 0x000FFAC4
		public unsafe override bool UseCoverage
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x0010190C File Offset: 0x000FFB0C
		public unsafe override bool FailOnEmpty
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x00101954 File Offset: 0x000FFB54
		public unsafe override GrowContainerCameraHandler.ECameraPosition CameraPosition
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 118222, RefRangeEnd = 118228, XrefRangeStart = 118222, XrefRangeEnd = 118228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x0010199C File Offset: 0x000FFB9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121610, RefRangeEnd = 121611, XrefRangeStart = 121577, XrefRangeEnd = 121610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourWaterTask(GrowContainer _growContainer, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourWaterTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_growContainer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourWaterTask.NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x00101A0C File Offset: 0x000FFC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121611, XrefRangeEnd = 121615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x00101A48 File Offset: 0x000FFC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121615, XrefRangeEnd = 121639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void TargetReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourWaterTask.NativeMethodInfoPtr_TargetReached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0001565D File Offset: 0x0001385D
		public PourWaterTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x00101A84 File Offset: 0x000FFC84
		// (set) Token: 0x060028C0 RID: 10432 RVA: 0x00015666 File Offset: 0x00013866
		public unsafe static float NORMALIZED_FILL_PER_TARGET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourWaterTask.NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourWaterTask.NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET, (void*)(&value));
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x00101AA0 File Offset: 0x000FFCA0
		// (set) Token: 0x060028C2 RID: 10434 RVA: 0x00015674 File Offset: 0x00013874
		public unsafe static bool hintShown
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(PourWaterTask.NativeFieldInfoPtr_hintShown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourWaterTask.NativeFieldInfoPtr_hintShown, (void*)(&value));
			}
		}

		// Token: 0x04001BFE RID: 7166
		private static readonly IntPtr NativeFieldInfoPtr_NORMALIZED_FILL_PER_TARGET;

		// Token: 0x04001BFF RID: 7167
		private static readonly IntPtr NativeFieldInfoPtr_hintShown;

		// Token: 0x04001C00 RID: 7168
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_get_Boolean_0;

		// Token: 0x04001C01 RID: 7169
		private static readonly IntPtr NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_get_Boolean_0;

		// Token: 0x04001C02 RID: 7170
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_get_ECameraPosition_0;

		// Token: 0x04001C03 RID: 7171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GrowContainer_ItemInstance_Pourable_0;

		// Token: 0x04001C04 RID: 7172
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001C05 RID: 7173
		private static readonly IntPtr NativeMethodInfoPtr_TargetReached_Public_Virtual_Void_0;
	}
}

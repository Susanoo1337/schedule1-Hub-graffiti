using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000184 RID: 388
	public class HarvestMushroomBedTask : Task
	{
		// Token: 0x0600275A RID: 10074 RVA: 0x000FD21C File Offset: 0x000FB41C
		// Note: this type is marked as 'beforefieldinit'.
		static HarvestMushroomBedTask()
		{
			Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "HarvestMushroomBedTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr);
			HarvestMushroomBedTask.NativeFieldInfoPtr__soundLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr, "_soundLoop");
			HarvestMushroomBedTask.NativeFieldInfoPtr__mushroomBed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr, "_mushroomBed");
			HarvestMushroomBedTask.NativeFieldInfoPtr__canDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr, "_canDrag");
			HarvestMushroomBedTask.NativeFieldInfoPtr__harvestCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr, "_harvestCount");
			HarvestMushroomBedTask.NativeFieldInfoPtr__harvestTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr, "_harvestTotal");
			HarvestMushroomBedTask.NativeMethodInfoPtr__ctor_Public_Void_MushroomBed_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr, 100668345);
			HarvestMushroomBedTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr, 100668346);
			HarvestMushroomBedTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr, 100668347);
			HarvestMushroomBedTask.NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr, 100668348);
			HarvestMushroomBedTask.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr, 100668349);
			HarvestMushroomBedTask.NativeMethodInfoPtr_GetHoveredHarvestable_Private_GrowingMushroom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr, 100668350);
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000FD328 File Offset: 0x000FB528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119055, XrefRangeEnd = 119116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HarvestMushroomBedTask(MushroomBed mushroomBed, bool canDrag, AudioSourceController soundLoopPrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HarvestMushroomBedTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mushroomBed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canDrag;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(soundLoopPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestMushroomBedTask.NativeMethodInfoPtr__ctor_Public_Void_MushroomBed_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x000FD394 File Offset: 0x000FB594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119116, XrefRangeEnd = 119148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x000FD3D0 File Offset: 0x000FB5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119148, XrefRangeEnd = 119220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000FD40C File Offset: 0x000FB60C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119247, RefRangeEnd = 119249, XrefRangeStart = 119220, XrefRangeEnd = 119247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstructionText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestMushroomBedTask.NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000FD440 File Offset: 0x000FB640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119249, XrefRangeEnd = 119263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedTask.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x000FD47C File Offset: 0x000FB67C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119280, RefRangeEnd = 119282, XrefRangeStart = 119263, XrefRangeEnd = 119280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrowingMushroom GetHoveredHarvestable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestMushroomBedTask.NativeMethodInfoPtr_GetHoveredHarvestable_Private_GrowingMushroom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GrowingMushroom>(intPtr3) : null;
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00014B90 File Offset: 0x00012D90
		public HarvestMushroomBedTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x000FD4BC File Offset: 0x000FB6BC
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x00014B99 File Offset: 0x00012D99
		public unsafe AudioSourceController _soundLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedTask.NativeFieldInfoPtr__soundLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedTask.NativeFieldInfoPtr__soundLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x000FD4EC File Offset: 0x000FB6EC
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x00014BB8 File Offset: 0x00012DB8
		public unsafe MushroomBed _mushroomBed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedTask.NativeFieldInfoPtr__mushroomBed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedTask.NativeFieldInfoPtr__mushroomBed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002766 RID: 10086 RVA: 0x000FD51C File Offset: 0x000FB71C
		// (set) Token: 0x06002767 RID: 10087 RVA: 0x00014BD7 File Offset: 0x00012DD7
		public unsafe bool _canDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedTask.NativeFieldInfoPtr__canDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedTask.NativeFieldInfoPtr__canDrag)) = value;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06002768 RID: 10088 RVA: 0x000FD544 File Offset: 0x000FB744
		// (set) Token: 0x06002769 RID: 10089 RVA: 0x00014BF2 File Offset: 0x00012DF2
		public unsafe int _harvestCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedTask.NativeFieldInfoPtr__harvestCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedTask.NativeFieldInfoPtr__harvestCount)) = value;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x000FD56C File Offset: 0x000FB76C
		// (set) Token: 0x0600276B RID: 10091 RVA: 0x00014C0D File Offset: 0x00012E0D
		public unsafe int _harvestTotal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedTask.NativeFieldInfoPtr__harvestTotal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedTask.NativeFieldInfoPtr__harvestTotal)) = value;
			}
		}

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeFieldInfoPtr__soundLoop;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeFieldInfoPtr__mushroomBed;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeFieldInfoPtr__canDrag;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeFieldInfoPtr__harvestCount;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeFieldInfoPtr__harvestTotal;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MushroomBed_Boolean_AudioSourceController_0;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredHarvestable_Private_GrowingMushroom_0;
	}
}

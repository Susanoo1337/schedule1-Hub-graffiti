using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000185 RID: 389
	public class HarvestPlant : Task
	{
		// Token: 0x0600276C RID: 10092 RVA: 0x000FD594 File Offset: 0x000FB794
		// Note: this type is marked as 'beforefieldinit'.
		static HarvestPlant()
		{
			Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "HarvestPlant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr);
			HarvestPlant.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "<TaskName>k__BackingField");
			HarvestPlant.NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "pot");
			HarvestPlant.NativeFieldInfoPtr_HarvestCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "HarvestCount");
			HarvestPlant.NativeFieldInfoPtr_HarvestTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "HarvestTotal");
			HarvestPlant.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "rotation");
			HarvestPlant.NativeFieldInfoPtr_CanDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "CanDrag");
			HarvestPlant.NativeFieldInfoPtr_SoundLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, "SoundLoop");
			HarvestPlant.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668351);
			HarvestPlant.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668352);
			HarvestPlant.NativeMethodInfoPtr__ctor_Public_Void_Pot_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668353);
			HarvestPlant.NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668354);
			HarvestPlant.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668355);
			HarvestPlant.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668356);
			HarvestPlant.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668357);
			HarvestPlant.NativeMethodInfoPtr_GetHoveredHarvestable_Private_PlantHarvestable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668358);
			HarvestPlant.NativeMethodInfoPtr_StartContinuousHaptics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668359);
			HarvestPlant.NativeMethodInfoPtr_StopContinuousHaptics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr, 100668360);
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000FD718 File Offset: 0x000FB918
		// (set) Token: 0x0600276E RID: 10094 RVA: 0x000FD75C File Offset: 0x000FB95C
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x000FD7AC File Offset: 0x000FB9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119282, XrefRangeEnd = 119372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HarvestPlant(Pot _pot, bool canDrag, AudioSourceController soundLoopPrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HarvestPlant>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canDrag;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(soundLoopPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPlant.NativeMethodInfoPtr__ctor_Public_Void_Pot_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x000FD818 File Offset: 0x000FBA18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119404, RefRangeEnd = 119406, XrefRangeStart = 119372, XrefRangeEnd = 119404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstructionText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPlant.NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x000FD84C File Offset: 0x000FBA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119406, XrefRangeEnd = 119451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x000FD888 File Offset: 0x000FBA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119451, XrefRangeEnd = 119465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x000FD8C4 File Offset: 0x000FBAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119465, XrefRangeEnd = 119561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPlant.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x000FD900 File Offset: 0x000FBB00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119578, RefRangeEnd = 119580, XrefRangeStart = 119561, XrefRangeEnd = 119578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantHarvestable GetHoveredHarvestable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPlant.NativeMethodInfoPtr_GetHoveredHarvestable_Private_PlantHarvestable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlantHarvestable>(intPtr3) : null;
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x000FD940 File Offset: 0x000FBB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119580, XrefRangeEnd = 119585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartContinuousHaptics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPlant.NativeMethodInfoPtr_StartContinuousHaptics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000FD974 File Offset: 0x000FBB74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119588, RefRangeEnd = 119589, XrefRangeStart = 119585, XrefRangeEnd = 119588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopContinuousHaptics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPlant.NativeMethodInfoPtr_StopContinuousHaptics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00014C28 File Offset: 0x00012E28
		public HarvestPlant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000FD9A8 File Offset: 0x000FBBA8
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x00014C31 File Offset: 0x00012E31
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x000FD9D0 File Offset: 0x000FBBD0
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x00014C50 File Offset: 0x00012E50
		public unsafe Pot pot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_pot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_pot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x000FDA00 File Offset: 0x000FBC00
		// (set) Token: 0x0600277D RID: 10109 RVA: 0x00014C6F File Offset: 0x00012E6F
		public unsafe int HarvestCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestCount)) = value;
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x000FDA28 File Offset: 0x000FBC28
		// (set) Token: 0x0600277F RID: 10111 RVA: 0x00014C8A File Offset: 0x00012E8A
		public unsafe int HarvestTotal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestTotal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_HarvestTotal)) = value;
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x000FDA50 File Offset: 0x000FBC50
		// (set) Token: 0x06002781 RID: 10113 RVA: 0x00014CA5 File Offset: 0x00012EA5
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06002782 RID: 10114 RVA: 0x000FDA78 File Offset: 0x000FBC78
		// (set) Token: 0x06002783 RID: 10115 RVA: 0x00014CC0 File Offset: 0x00012EC0
		public unsafe static bool CanDrag
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(HarvestPlant.NativeFieldInfoPtr_CanDrag, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HarvestPlant.NativeFieldInfoPtr_CanDrag, (void*)(&value));
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x000FDA94 File Offset: 0x000FBC94
		// (set) Token: 0x06002785 RID: 10117 RVA: 0x00014CCE File Offset: 0x00012ECE
		public unsafe AudioSourceController SoundLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_SoundLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPlant.NativeFieldInfoPtr_SoundLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeFieldInfoPtr_pot;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeFieldInfoPtr_HarvestCount;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeFieldInfoPtr_HarvestTotal;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeFieldInfoPtr_CanDrag;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeFieldInfoPtr_SoundLoop;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_Boolean_AudioSourceController_0;

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructionText_Private_Void_0;

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0;

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredHarvestable_Private_PlantHarvestable_0;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeMethodInfoPtr_StartContinuousHaptics_Private_Void_0;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeMethodInfoPtr_StopContinuousHaptics_Private_Void_0;
	}
}

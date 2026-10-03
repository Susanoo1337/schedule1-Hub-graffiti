using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000186 RID: 390
	public class InocculateGrainBagTask : Task
	{
		// Token: 0x06002786 RID: 10118 RVA: 0x000FDAC4 File Offset: 0x000FBCC4
		// Note: this type is marked as 'beforefieldinit'.
		static InocculateGrainBagTask()
		{
			Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "InocculateGrainBagTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr);
			InocculateGrainBagTask.NativeFieldInfoPtr_FoV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, "FoV");
			InocculateGrainBagTask.NativeFieldInfoPtr_CameraLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, "CameraLerpTime");
			InocculateGrainBagTask.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, "<TaskName>k__BackingField");
			InocculateGrainBagTask.NativeFieldInfoPtr__station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, "_station");
			InocculateGrainBagTask.NativeFieldInfoPtr__spawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, "_spawn");
			InocculateGrainBagTask.NativeFieldInfoPtr__syringe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, "_syringe");
			InocculateGrainBagTask.NativeFieldInfoPtr__currentStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, "_currentStage");
			InocculateGrainBagTask.NativeFieldInfoPtr__grainBagInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, "_grainBagInstance");
			InocculateGrainBagTask.NativeFieldInfoPtr__syringeInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, "_syringeInstance");
			InocculateGrainBagTask.NativeFieldInfoPtr__spawnDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, "_spawnDefinition");
			InocculateGrainBagTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, 100668361);
			InocculateGrainBagTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, 100668362);
			InocculateGrainBagTask.NativeMethodInfoPtr__ctor_Public_Void_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, 100668363);
			InocculateGrainBagTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, 100668364);
			InocculateGrainBagTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, 100668365);
			InocculateGrainBagTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, 100668366);
			InocculateGrainBagTask.NativeMethodInfoPtr_GetInstructionForStage_Private_String_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, 100668367);
			InocculateGrainBagTask.NativeMethodInfoPtr_OnSyringeCapRemoved_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, 100668368);
			InocculateGrainBagTask.NativeMethodInfoPtr_OnSyringeInserted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, 100668369);
			InocculateGrainBagTask.NativeMethodInfoPtr_OnPlungerPushed_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr, 100668370);
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x000FDC84 File Offset: 0x000FBE84
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x000FDCC8 File Offset: 0x000FBEC8
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InocculateGrainBagTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InocculateGrainBagTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x000FDD18 File Offset: 0x000FBF18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119664, RefRangeEnd = 119666, XrefRangeStart = 119589, XrefRangeEnd = 119664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InocculateGrainBagTask(MushroomSpawnStation station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InocculateGrainBagTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InocculateGrainBagTask.NativeMethodInfoPtr__ctor_Public_Void_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278A RID: 10122 RVA: 0x000FDD64 File Offset: 0x000FBF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119666, XrefRangeEnd = 119685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InocculateGrainBagTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278B RID: 10123 RVA: 0x000FDDA0 File Offset: 0x000FBFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119685, XrefRangeEnd = 119701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InocculateGrainBagTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278C RID: 10124 RVA: 0x000FDDDC File Offset: 0x000FBFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119701, XrefRangeEnd = 119722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InocculateGrainBagTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278D RID: 10125 RVA: 0x000FDE18 File Offset: 0x000FC018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119722, XrefRangeEnd = 119728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInstructionForStage(InocculateGrainBagTask.EStage stage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InocculateGrainBagTask.NativeMethodInfoPtr_GetInstructionForStage_Private_String_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600278E RID: 10126 RVA: 0x000FDE5C File Offset: 0x000FC05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119728, XrefRangeEnd = 119731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSyringeCapRemoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InocculateGrainBagTask.NativeMethodInfoPtr_OnSyringeCapRemoved_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x000FDE90 File Offset: 0x000FC090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119731, XrefRangeEnd = 119734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSyringeInserted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InocculateGrainBagTask.NativeMethodInfoPtr_OnSyringeInserted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x000FDEC4 File Offset: 0x000FC0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119734, XrefRangeEnd = 119735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlungerPushed(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InocculateGrainBagTask.NativeMethodInfoPtr_OnPlungerPushed_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00014CED File Offset: 0x00012EED
		public InocculateGrainBagTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x000FDF04 File Offset: 0x000FC104
		// (set) Token: 0x06002793 RID: 10131 RVA: 0x00014CF6 File Offset: 0x00012EF6
		public unsafe static float FoV
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InocculateGrainBagTask.NativeFieldInfoPtr_FoV, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InocculateGrainBagTask.NativeFieldInfoPtr_FoV, (void*)(&value));
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x000FDF20 File Offset: 0x000FC120
		// (set) Token: 0x06002795 RID: 10133 RVA: 0x00014D04 File Offset: 0x00012F04
		public unsafe static float CameraLerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InocculateGrainBagTask.NativeFieldInfoPtr_CameraLerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InocculateGrainBagTask.NativeFieldInfoPtr_CameraLerpTime, (void*)(&value));
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x000FDF3C File Offset: 0x000FC13C
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x00014D12 File Offset: 0x00012F12
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x000FDF64 File Offset: 0x000FC164
		// (set) Token: 0x06002799 RID: 10137 RVA: 0x00014D31 File Offset: 0x00012F31
		public unsafe MushroomSpawnStation _station
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__station);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomSpawnStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__station), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x000FDF94 File Offset: 0x000FC194
		// (set) Token: 0x0600279B RID: 10139 RVA: 0x00014D50 File Offset: 0x00012F50
		public unsafe MushroomSpawnStationItem _spawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__spawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomSpawnStationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__spawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x000FDFC4 File Offset: 0x000FC1C4
		// (set) Token: 0x0600279D RID: 10141 RVA: 0x00014D6F File Offset: 0x00012F6F
		public unsafe SporeSyringeStationItem _syringe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__syringe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SporeSyringeStationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__syringe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x0600279E RID: 10142 RVA: 0x000FDFF4 File Offset: 0x000FC1F4
		// (set) Token: 0x0600279F RID: 10143 RVA: 0x00014D8E File Offset: 0x00012F8E
		public unsafe InocculateGrainBagTask.EStage _currentStage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__currentStage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__currentStage)) = value;
			}
		}

		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x000FE01C File Offset: 0x000FC21C
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x00014DA9 File Offset: 0x00012FA9
		public unsafe ItemInstance _grainBagInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__grainBagInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__grainBagInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x000FE04C File Offset: 0x000FC24C
		// (set) Token: 0x060027A3 RID: 10147 RVA: 0x00014DC8 File Offset: 0x00012FC8
		public unsafe ItemInstance _syringeInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__syringeInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__syringeInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x000FE07C File Offset: 0x000FC27C
		// (set) Token: 0x060027A5 RID: 10149 RVA: 0x00014DE7 File Offset: 0x00012FE7
		public unsafe ShroomSpawnDefinition _spawnDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__spawnDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShroomSpawnDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InocculateGrainBagTask.NativeFieldInfoPtr__spawnDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeFieldInfoPtr_FoV;

		// Token: 0x04001B37 RID: 6967
		private static readonly IntPtr NativeFieldInfoPtr_CameraLerpTime;

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeFieldInfoPtr__station;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeFieldInfoPtr__spawn;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeFieldInfoPtr__syringe;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeFieldInfoPtr__currentStage;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeFieldInfoPtr__grainBagInstance;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeFieldInfoPtr__syringeInstance;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeFieldInfoPtr__spawnDefinition;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MushroomSpawnStation_0;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeMethodInfoPtr_GetInstructionForStage_Private_String_EStage_0;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeMethodInfoPtr_OnSyringeCapRemoved_Private_Void_0;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr_OnSyringeInserted_Private_Void_0;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeMethodInfoPtr_OnPlungerPushed_Private_Void_Single_0;

		// Token: 0x0200098C RID: 2444
		[OriginalName("Assembly-CSharp.dll", "", "EStage")]
		public enum EStage
		{
			// Token: 0x0400950B RID: 38155
			RemoveCap,
			// Token: 0x0400950C RID: 38156
			InsertSyringe,
			// Token: 0x0400950D RID: 38157
			PushPlunger
		}
	}
}

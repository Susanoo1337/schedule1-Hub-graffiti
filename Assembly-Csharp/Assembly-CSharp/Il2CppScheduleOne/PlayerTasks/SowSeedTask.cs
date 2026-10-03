using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200018A RID: 394
	public class SowSeedTask : Task
	{
		// Token: 0x060027E3 RID: 10211 RVA: 0x000FED70 File Offset: 0x000FCF70
		// Note: this type is marked as 'beforefieldinit'.
		static SowSeedTask()
		{
			Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "SowSeedTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr);
			SowSeedTask.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "<TaskName>k__BackingField");
			SowSeedTask.NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "pot");
			SowSeedTask.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "definition");
			SowSeedTask.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "seed");
			SowSeedTask.NativeFieldInfoPtr_seedExitedVial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "seedExitedVial");
			SowSeedTask.NativeFieldInfoPtr_seedReachedDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "seedReachedDestination");
			SowSeedTask.NativeFieldInfoPtr_successfullyPlanted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "successfullyPlanted");
			SowSeedTask.NativeFieldInfoPtr_weedSeedStationaryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "weedSeedStationaryTime");
			SowSeedTask.NativeFieldInfoPtr_capRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, "capRemoved");
			SowSeedTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668398);
			SowSeedTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668399);
			SowSeedTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_SeedDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668400);
			SowSeedTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668401);
			SowSeedTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668402);
			SowSeedTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668403);
			SowSeedTask.NativeMethodInfoPtr_OnSeedExitVial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668404);
			SowSeedTask.NativeMethodInfoPtr_OnSeedReachedDestination_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr, 100668405);
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060027E4 RID: 10212 RVA: 0x000FEEF4 File Offset: 0x000FD0F4
		// (set) Token: 0x060027E5 RID: 10213 RVA: 0x000FEF38 File Offset: 0x000FD138
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x000FEF88 File Offset: 0x000FD188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120224, RefRangeEnd = 120225, XrefRangeStart = 120116, XrefRangeEnd = 120224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SowSeedTask(Pot _pot, SeedDefinition def) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SowSeedTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SowSeedTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_SeedDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x000FEFE8 File Offset: 0x000FD1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120225, XrefRangeEnd = 120260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x000FF024 File Offset: 0x000FD224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120260, XrefRangeEnd = 120300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x000FF060 File Offset: 0x000FD260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120300, XrefRangeEnd = 120341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x000FF09C File Offset: 0x000FD29C
		[CallerCount(0)]
		public unsafe void OnSeedExitVial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SowSeedTask.NativeMethodInfoPtr_OnSeedExitVial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x000FF0D0 File Offset: 0x000FD2D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120369, RefRangeEnd = 120370, XrefRangeStart = 120341, XrefRangeEnd = 120369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSeedReachedDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SowSeedTask.NativeMethodInfoPtr_OnSeedReachedDestination_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x00014FCB File Offset: 0x000131CB
		public SowSeedTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x000FF104 File Offset: 0x000FD304
		// (set) Token: 0x060027EE RID: 10222 RVA: 0x00014FD4 File Offset: 0x000131D4
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x000FF12C File Offset: 0x000FD32C
		// (set) Token: 0x060027F0 RID: 10224 RVA: 0x00014FF3 File Offset: 0x000131F3
		public unsafe Pot pot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_pot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_pot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x000FF15C File Offset: 0x000FD35C
		// (set) Token: 0x060027F2 RID: 10226 RVA: 0x00015012 File Offset: 0x00013212
		public unsafe SeedDefinition definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SeedDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x000FF18C File Offset: 0x000FD38C
		// (set) Token: 0x060027F4 RID: 10228 RVA: 0x00015031 File Offset: 0x00013231
		public unsafe FunctionalSeed seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalSeed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x000FF1BC File Offset: 0x000FD3BC
		// (set) Token: 0x060027F6 RID: 10230 RVA: 0x00015050 File Offset: 0x00013250
		public unsafe bool seedExitedVial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedExitedVial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedExitedVial)) = value;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x000FF1E4 File Offset: 0x000FD3E4
		// (set) Token: 0x060027F8 RID: 10232 RVA: 0x0001506B File Offset: 0x0001326B
		public unsafe bool seedReachedDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedReachedDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_seedReachedDestination)) = value;
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x000FF20C File Offset: 0x000FD40C
		// (set) Token: 0x060027FA RID: 10234 RVA: 0x00015086 File Offset: 0x00013286
		public unsafe bool successfullyPlanted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_successfullyPlanted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_successfullyPlanted)) = value;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x060027FB RID: 10235 RVA: 0x000FF234 File Offset: 0x000FD434
		// (set) Token: 0x060027FC RID: 10236 RVA: 0x000150A1 File Offset: 0x000132A1
		public unsafe float weedSeedStationaryTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_weedSeedStationaryTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_weedSeedStationaryTime)) = value;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x000FF25C File Offset: 0x000FD45C
		// (set) Token: 0x060027FE RID: 10238 RVA: 0x000150BC File Offset: 0x000132BC
		public unsafe bool capRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_capRemoved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedTask.NativeFieldInfoPtr_capRemoved)) = value;
			}
		}

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeFieldInfoPtr_pot;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeFieldInfoPtr_definition;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeFieldInfoPtr_seed;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeFieldInfoPtr_seedExitedVial;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeFieldInfoPtr_seedReachedDestination;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeFieldInfoPtr_successfullyPlanted;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeFieldInfoPtr_weedSeedStationaryTime;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeFieldInfoPtr_capRemoved;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_SeedDefinition_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeMethodInfoPtr_OnSeedExitVial_Private_Void_0;

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeMethodInfoPtr_OnSeedReachedDestination_Private_Void_0;
	}
}

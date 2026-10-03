using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000193 RID: 403
	public class UseMixingStationTask : Task
	{
		// Token: 0x060028C3 RID: 10435 RVA: 0x00101ABC File Offset: 0x000FFCBC
		// Note: this type is marked as 'beforefieldinit'.
		static UseMixingStationTask()
		{
			Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "UseMixingStationTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr);
			UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<Station>k__BackingField");
			UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			UseMixingStationTask.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "items");
			UseMixingStationTask.NativeFieldInfoPtr_mixerItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "mixerItems");
			UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "ingredientPieces");
			UseMixingStationTask.NativeFieldInfoPtr_removedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "removedIngredients");
			UseMixingStationTask.NativeFieldInfoPtr_Jug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "Jug");
			UseMixingStationTask.NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668504);
			UseMixingStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668505);
			UseMixingStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668506);
			UseMixingStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668507);
			UseMixingStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668508);
			UseMixingStationTask.NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668509);
			UseMixingStationTask.NativeMethodInfoPtr_CreateJug_Private_Beaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668510);
			UseMixingStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668511);
			UseMixingStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668512);
			UseMixingStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668513);
			UseMixingStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668514);
			UseMixingStationTask.NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668515);
			UseMixingStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668516);
			UseMixingStationTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668517);
			UseMixingStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668518);
			UseMixingStationTask.NativeMethodInfoPtr_CreateTrash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668519);
			UseMixingStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668520);
			UseMixingStationTask.NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, 100668521);
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x00101CE0 File Offset: 0x000FFEE0
		// (set) Token: 0x060028C5 RID: 10437 RVA: 0x00101D20 File Offset: 0x000FFF20
		public unsafe MixingStation Station
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x00101D64 File Offset: 0x000FFF64
		// (set) Token: 0x060028C7 RID: 10439 RVA: 0x00101DA0 File Offset: 0x000FFFA0
		public unsafe UseMixingStationTask.EStep CurrentStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x00101DE0 File Offset: 0x000FFFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121639, XrefRangeEnd = 121643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepDescription(UseMixingStationTask.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00101E18 File Offset: 0x00100018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121715, RefRangeEnd = 121716, XrefRangeStart = 121643, XrefRangeEnd = 121715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UseMixingStationTask(MixingStation station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00101E64 File Offset: 0x00100064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121716, XrefRangeEnd = 121738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Beaker CreateJug()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CreateJug_Private_Beaker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr3) : null;
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x00101EA4 File Offset: 0x001000A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121738, XrefRangeEnd = 121755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x00101EE0 File Offset: 0x001000E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121788, RefRangeEnd = 121789, XrefRangeStart = 121755, XrefRangeEnd = 121788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x00101F14 File Offset: 0x00100114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121789, XrefRangeEnd = 121796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x00101F48 File Offset: 0x00100148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121796, XrefRangeEnd = 121803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CombineIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x00101F7C File Offset: 0x0010017C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 121835, RefRangeEnd = 121839, XrefRangeStart = 121803, XrefRangeEnd = 121835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCombinedIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x00101FB8 File Offset: 0x001001B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121839, XrefRangeEnd = 121840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x00101FEC File Offset: 0x001001EC
		[CallerCount(0)]
		public unsafe void StartButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x00102020 File Offset: 0x00100220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121840, XrefRangeEnd = 121855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x0010205C File Offset: 0x0010025C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121891, RefRangeEnd = 121892, XrefRangeStart = 121855, XrefRangeEnd = 121891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_CreateTrash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00102090 File Offset: 0x00100290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121892, XrefRangeEnd = 121938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseMixingStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x001020CC File Offset: 0x001002CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122004, RefRangeEnd = 122006, XrefRangeStart = 121938, XrefRangeEnd = 122004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0(StorableItemDefinition def, int index, bool mixer, ref UseMixingStationTask.__c__DisplayClass15_0 A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mixer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_4));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseMixingStationTask.NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00015682 File Offset: 0x00013882
		public UseMixingStationTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x00102144 File Offset: 0x00100344
		// (set) Token: 0x060028D8 RID: 10456 RVA: 0x0001568B File Offset: 0x0001388B
		public unsafe MixingStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x00102174 File Offset: 0x00100374
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x000156AA File Offset: 0x000138AA
		public unsafe UseMixingStationTask.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x0010219C File Offset: 0x0010039C
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x000156C5 File Offset: 0x000138C5
		public unsafe List<StationItem> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x001021CC File Offset: 0x001003CC
		// (set) Token: 0x060028DE RID: 10462 RVA: 0x000156E4 File Offset: 0x000138E4
		public unsafe List<StationItem> mixerItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_mixerItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_mixerItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x001021FC File Offset: 0x001003FC
		// (set) Token: 0x060028E0 RID: 10464 RVA: 0x00015703 File Offset: 0x00013903
		public unsafe List<IngredientPiece> ingredientPieces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IngredientPiece>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_ingredientPieces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x0010222C File Offset: 0x0010042C
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x00015722 File Offset: 0x00013922
		public unsafe Il2CppReferenceArray<ItemInstance> removedIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_removedIngredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_removedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x0010225C File Offset: 0x0010045C
		// (set) Token: 0x060028E4 RID: 10468 RVA: 0x00015741 File Offset: 0x00013941
		public unsafe Beaker Jug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_Jug);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.NativeFieldInfoPtr_Jug), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C06 RID: 7174
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04001C07 RID: 7175
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001C08 RID: 7176
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001C09 RID: 7177
		private static readonly IntPtr NativeFieldInfoPtr_mixerItems;

		// Token: 0x04001C0A RID: 7178
		private static readonly IntPtr NativeFieldInfoPtr_ingredientPieces;

		// Token: 0x04001C0B RID: 7179
		private static readonly IntPtr NativeFieldInfoPtr_removedIngredients;

		// Token: 0x04001C0C RID: 7180
		private static readonly IntPtr NativeFieldInfoPtr_Jug;

		// Token: 0x04001C0D RID: 7181
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0;

		// Token: 0x04001C0E RID: 7182
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Private_set_Void_MixingStation_0;

		// Token: 0x04001C0F RID: 7183
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001C10 RID: 7184
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0;

		// Token: 0x04001C11 RID: 7185
		private static readonly IntPtr NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0;

		// Token: 0x04001C12 RID: 7186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MixingStation_0;

		// Token: 0x04001C13 RID: 7187
		private static readonly IntPtr NativeMethodInfoPtr_CreateJug_Private_Beaker_0;

		// Token: 0x04001C14 RID: 7188
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001C15 RID: 7189
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04001C16 RID: 7190
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001C17 RID: 7191
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0;

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinedIngredients_Private_Int32_0;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeMethodInfoPtr_StartButtonPressed_Private_Void_0;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrash_Private_Void_0;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_StorableItemDefinition_Int32_Boolean_byref___c__DisplayClass15_0_0;

		// Token: 0x02000993 RID: 2451
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x0400953A RID: 38202
			CombineIngredients,
			// Token: 0x0400953B RID: 38203
			StartMixing
		}

		// Token: 0x02000994 RID: 2452
		[ObfuscatedName("ScheduleOne.PlayerTasks.Tasks.UseMixingStationTask+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : ValueType
		{
			// Token: 0x0600DA77 RID: 55927 RVA: 0x003628B4 File Offset: 0x00360AB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UseMixingStationTask>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr);
				UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr, "station");
			}

			// Token: 0x0600DA78 RID: 55928 RVA: 0x00066B47 File Offset: 0x00064D47
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DA79 RID: 55929 RVA: 0x00066B50 File Offset: 0x00064D50
			public __c__DisplayClass15_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseMixingStationTask.__c__DisplayClass15_0>.NativeClassPtr))
			{
			}

			// Token: 0x170042B5 RID: 17077
			// (get) Token: 0x0600DA7A RID: 55930 RVA: 0x00362908 File Offset: 0x00360B08
			// (set) Token: 0x0600DA7B RID: 55931 RVA: 0x00066B62 File Offset: 0x00064D62
			public unsafe UseMixingStationTask __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UseMixingStationTask>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042B6 RID: 17078
			// (get) Token: 0x0600DA7C RID: 55932 RVA: 0x00362938 File Offset: 0x00360B38
			// (set) Token: 0x0600DA7D RID: 55933 RVA: 0x00066B81 File Offset: 0x00064D81
			public unsafe MixingStation station
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseMixingStationTask.__c__DisplayClass15_0.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400953C RID: 38204
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400953D RID: 38205
			private static readonly IntPtr NativeFieldInfoPtr_station;
		}
	}
}

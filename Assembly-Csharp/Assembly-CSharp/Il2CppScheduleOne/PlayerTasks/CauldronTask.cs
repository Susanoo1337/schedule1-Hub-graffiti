using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000180 RID: 384
	public class CauldronTask : Task
	{
		// Token: 0x0600270F RID: 9999 RVA: 0x000FC350 File Offset: 0x000FA550
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronTask()
		{
			Il2CppClassPointerStore<CauldronTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "CauldronTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr);
			CauldronTask.NativeFieldInfoPtr__Cauldron_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, "<Cauldron>k__BackingField");
			CauldronTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			CauldronTask.NativeFieldInfoPtr_CocaLeaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, "CocaLeaves");
			CauldronTask.NativeFieldInfoPtr_Gasoline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, "Gasoline");
			CauldronTask.NativeFieldInfoPtr_Tub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, "Tub");
			CauldronTask.NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668302);
			CauldronTask.NativeMethodInfoPtr_set_Cauldron_Private_set_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668303);
			CauldronTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668304);
			CauldronTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668305);
			CauldronTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668306);
			CauldronTask.NativeMethodInfoPtr__ctor_Public_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668307);
			CauldronTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668308);
			CauldronTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668309);
			CauldronTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668310);
			CauldronTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668311);
			CauldronTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668312);
			CauldronTask.NativeMethodInfoPtr_StartMixing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668313);
			CauldronTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668314);
			CauldronTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr, 100668315);
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x000FC4FC File Offset: 0x000FA6FC
		// (set) Token: 0x06002711 RID: 10001 RVA: 0x000FC53C File Offset: 0x000FA73C
		public unsafe Cauldron Cauldron
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_set_Cauldron_Private_set_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x000FC580 File Offset: 0x000FA780
		// (set) Token: 0x06002713 RID: 10003 RVA: 0x000FC5BC File Offset: 0x000FA7BC
		public unsafe CauldronTask.EStep CurrentStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x000FC5FC File Offset: 0x000FA7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118579, XrefRangeEnd = 118583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepDescription(CauldronTask.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000FC634 File Offset: 0x000FA834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118674, RefRangeEnd = 118676, XrefRangeStart = 118583, XrefRangeEnd = 118674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronTask(Cauldron caudron) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(caudron);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr__ctor_Public_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000FC680 File Offset: 0x000FA880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118676, XrefRangeEnd = 118693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000FC6BC File Offset: 0x000FA8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118693, XrefRangeEnd = 118728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000FC6F8 File Offset: 0x000FA8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118728, XrefRangeEnd = 118758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000FC734 File Offset: 0x000FA934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118758, XrefRangeEnd = 118770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x000FC768 File Offset: 0x000FA968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118770, XrefRangeEnd = 118782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CombineIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000FC79C File Offset: 0x000FA99C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 118806, RefRangeEnd = 118809, XrefRangeStart = 118782, XrefRangeEnd = 118806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMixing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_StartMixing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000FC7D0 File Offset: 0x000FA9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118809, XrefRangeEnd = 118817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000FC804 File Offset: 0x000FAA04
		[CallerCount(0)]
		public unsafe void StartButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronTask.NativeMethodInfoPtr_StartButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x0001493B File Offset: 0x00012B3B
		public CauldronTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x0600271F RID: 10015 RVA: 0x000FC838 File Offset: 0x000FAA38
		// (set) Token: 0x06002720 RID: 10016 RVA: 0x00014944 File Offset: 0x00012B44
		public unsafe Cauldron _Cauldron_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr__Cauldron_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr__Cauldron_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x000FC868 File Offset: 0x000FAA68
		// (set) Token: 0x06002722 RID: 10018 RVA: 0x00014963 File Offset: 0x00012B63
		public unsafe CauldronTask.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x000FC890 File Offset: 0x000FAA90
		// (set) Token: 0x06002724 RID: 10020 RVA: 0x0001497E File Offset: 0x00012B7E
		public unsafe Il2CppReferenceArray<StationItem> CocaLeaves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_CocaLeaves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_CocaLeaves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x000FC8C0 File Offset: 0x000FAAC0
		// (set) Token: 0x06002726 RID: 10022 RVA: 0x0001499D File Offset: 0x00012B9D
		public unsafe StationItem Gasoline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_Gasoline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_Gasoline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x000FC8F0 File Offset: 0x000FAAF0
		// (set) Token: 0x06002728 RID: 10024 RVA: 0x000149BC File Offset: 0x00012BBC
		public unsafe Draggable Tub
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_Tub);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronTask.NativeFieldInfoPtr_Tub), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AE9 RID: 6889
		private static readonly IntPtr NativeFieldInfoPtr__Cauldron_k__BackingField;

		// Token: 0x04001AEA RID: 6890
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001AEB RID: 6891
		private static readonly IntPtr NativeFieldInfoPtr_CocaLeaves;

		// Token: 0x04001AEC RID: 6892
		private static readonly IntPtr NativeFieldInfoPtr_Gasoline;

		// Token: 0x04001AED RID: 6893
		private static readonly IntPtr NativeFieldInfoPtr_Tub;

		// Token: 0x04001AEE RID: 6894
		private static readonly IntPtr NativeMethodInfoPtr_get_Cauldron_Public_get_Cauldron_0;

		// Token: 0x04001AEF RID: 6895
		private static readonly IntPtr NativeMethodInfoPtr_set_Cauldron_Private_set_Void_Cauldron_0;

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Cauldron_0;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr_StartMixing_Private_Void_0;

		// Token: 0x04001AFA RID: 6906
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04001AFB RID: 6907
		private static readonly IntPtr NativeMethodInfoPtr_StartButtonPressed_Private_Void_0;

		// Token: 0x02000989 RID: 2441
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x040094F6 RID: 38134
			CombineIngredients,
			// Token: 0x040094F7 RID: 38135
			StartMixing
		}
	}
}

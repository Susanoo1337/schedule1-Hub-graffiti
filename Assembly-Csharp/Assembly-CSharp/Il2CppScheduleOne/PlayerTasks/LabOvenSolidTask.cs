using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000187 RID: 391
	public class LabOvenSolidTask : Task
	{
		// Token: 0x060027A6 RID: 10150 RVA: 0x000FE0AC File Offset: 0x000FC2AC
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenSolidTask()
		{
			Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "LabOvenSolidTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr);
			LabOvenSolidTask.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "<Oven>k__BackingField");
			LabOvenSolidTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			LabOvenSolidTask.NativeFieldInfoPtr_ingredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "ingredient");
			LabOvenSolidTask.NativeFieldInfoPtr_ingredientQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "ingredientQuantity");
			LabOvenSolidTask.NativeFieldInfoPtr_stationItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "stationItems");
			LabOvenSolidTask.NativeFieldInfoPtr_stationDraggables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, "stationDraggables");
			LabOvenSolidTask.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668371);
			LabOvenSolidTask.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668372);
			LabOvenSolidTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668373);
			LabOvenSolidTask.NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668374);
			LabOvenSolidTask.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668375);
			LabOvenSolidTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668376);
			LabOvenSolidTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668377);
			LabOvenSolidTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668378);
			LabOvenSolidTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668379);
			LabOvenSolidTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668380);
			LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668381);
			LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_PlaceItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668382);
			LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668383);
			LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668384);
			LabOvenSolidTask.NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr, 100668385);
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x060027A7 RID: 10151 RVA: 0x000FE280 File Offset: 0x000FC480
		// (set) Token: 0x060027A8 RID: 10152 RVA: 0x000FE2C0 File Offset: 0x000FC4C0
		public unsafe LabOven Oven
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x060027A9 RID: 10153 RVA: 0x000FE304 File Offset: 0x000FC504
		// (set) Token: 0x060027AA RID: 10154 RVA: 0x000FE340 File Offset: 0x000FC540
		public unsafe LabOvenSolidTask.EStep CurrentStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000FE380 File Offset: 0x000FC580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119769, RefRangeEnd = 119770, XrefRangeStart = 119735, XrefRangeEnd = 119769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenSolidTask(LabOven oven) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenSolidTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x000FE3CC File Offset: 0x000FC5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119770, XrefRangeEnd = 119787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenSolidTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x000FE408 File Offset: 0x000FC608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119787, XrefRangeEnd = 119805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenSolidTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000FE444 File Offset: 0x000FC644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119805, XrefRangeEnd = 119817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenSolidTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x000FE480 File Offset: 0x000FC680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119829, RefRangeEnd = 119830, XrefRangeStart = 119817, XrefRangeEnd = 119829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000FE4B4 File Offset: 0x000FC6B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 119840, RefRangeEnd = 119847, XrefRangeStart = 119830, XrefRangeEnd = 119840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x000FE4E8 File Offset: 0x000FC6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119847, XrefRangeEnd = 119850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_OpenDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x000FE51C File Offset: 0x000FC71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119850, XrefRangeEnd = 119858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_PlaceItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_PlaceItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x000FE550 File Offset: 0x000FC750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119858, XrefRangeEnd = 119861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CloseDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x000FE584 File Offset: 0x000FC784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119861, XrefRangeEnd = 119862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_PressButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x000FE5B8 File Offset: 0x000FC7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119862, XrefRangeEnd = 119868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepInstruction(LabOvenSolidTask.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenSolidTask.NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x00014E06 File Offset: 0x00013006
		public LabOvenSolidTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x000FE5F0 File Offset: 0x000FC7F0
		// (set) Token: 0x060027B8 RID: 10168 RVA: 0x00014E0F File Offset: 0x0001300F
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr__Oven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x000FE620 File Offset: 0x000FC820
		// (set) Token: 0x060027BA RID: 10170 RVA: 0x00014E2E File Offset: 0x0001302E
		public unsafe LabOvenSolidTask.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x000FE648 File Offset: 0x000FC848
		// (set) Token: 0x060027BC RID: 10172 RVA: 0x00014E49 File Offset: 0x00013049
		public unsafe ItemInstance ingredient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_ingredient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_ingredient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x000FE678 File Offset: 0x000FC878
		// (set) Token: 0x060027BE RID: 10174 RVA: 0x00014E68 File Offset: 0x00013068
		public unsafe int ingredientQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_ingredientQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_ingredientQuantity)) = value;
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x000FE6A0 File Offset: 0x000FC8A0
		// (set) Token: 0x060027C0 RID: 10176 RVA: 0x00014E83 File Offset: 0x00013083
		public unsafe Il2CppReferenceArray<StationItem> stationItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_stationItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_stationItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x000FE6D0 File Offset: 0x000FC8D0
		// (set) Token: 0x060027C2 RID: 10178 RVA: 0x00014EA2 File Offset: 0x000130A2
		public unsafe Il2CppReferenceArray<Draggable> stationDraggables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_stationDraggables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Draggable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenSolidTask.NativeFieldInfoPtr_stationDraggables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeFieldInfoPtr_ingredient;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeFieldInfoPtr_ingredientQuantity;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeFieldInfoPtr_stationItems;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeFieldInfoPtr_stationDraggables;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LabOven_0;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001B5A RID: 7002
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0;

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_PlaceItems_Private_Void_0;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0;

		// Token: 0x0200098D RID: 2445
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x0400950F RID: 38159
			OpenDoor,
			// Token: 0x04009510 RID: 38160
			PlaceItems,
			// Token: 0x04009511 RID: 38161
			CloseDoor,
			// Token: 0x04009512 RID: 38162
			PressButton
		}
	}
}

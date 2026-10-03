using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200018B RID: 395
	public class StartLabOvenTask : Task
	{
		// Token: 0x060027FF RID: 10239 RVA: 0x000FF284 File Offset: 0x000FD484
		// Note: this type is marked as 'beforefieldinit'.
		static StartLabOvenTask()
		{
			Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "StartLabOvenTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr);
			StartLabOvenTask.NativeFieldInfoPtr__Oven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "<Oven>k__BackingField");
			StartLabOvenTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			StartLabOvenTask.NativeFieldInfoPtr_ingredient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "ingredient");
			StartLabOvenTask.NativeFieldInfoPtr_pourRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "pourRoutine");
			StartLabOvenTask.NativeFieldInfoPtr_stationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "stationItem");
			StartLabOvenTask.NativeFieldInfoPtr_pourableModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "pourableModule");
			StartLabOvenTask.NativeFieldInfoPtr_pourAnimDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "pourAnimDone");
			StartLabOvenTask.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668406);
			StartLabOvenTask.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668407);
			StartLabOvenTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668408);
			StartLabOvenTask.NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668409);
			StartLabOvenTask.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668410);
			StartLabOvenTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668411);
			StartLabOvenTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668412);
			StartLabOvenTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668413);
			StartLabOvenTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668414);
			StartLabOvenTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668415);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668416);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_Pour_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668417);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668418);
			StartLabOvenTask.NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668419);
			StartLabOvenTask.NativeMethodInfoPtr_PlayPourAnimation_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668420);
			StartLabOvenTask.NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, 100668421);
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x000FF480 File Offset: 0x000FD680
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x000FF4C0 File Offset: 0x000FD6C0
		public unsafe LabOven Oven
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x000FF504 File Offset: 0x000FD704
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x000FF540 File Offset: 0x000FD740
		public unsafe StartLabOvenTask.EStep CurrentStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x000FF580 File Offset: 0x000FD780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120434, RefRangeEnd = 120435, XrefRangeStart = 120381, XrefRangeEnd = 120434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartLabOvenTask(LabOven oven) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr__ctor_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x000FF5CC File Offset: 0x000FD7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120435, XrefRangeEnd = 120469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartLabOvenTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x000FF608 File Offset: 0x000FD808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120469, XrefRangeEnd = 120487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartLabOvenTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000FF644 File Offset: 0x000FD844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120487, XrefRangeEnd = 120499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartLabOvenTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000FF680 File Offset: 0x000FD880
		[CallerCount(0)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000FF6B4 File Offset: 0x000FD8B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 120509, RefRangeEnd = 120516, XrefRangeStart = 120499, XrefRangeEnd = 120509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000FF6E8 File Offset: 0x000FD8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120516, XrefRangeEnd = 120519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_OpenDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x000FF71C File Offset: 0x000FD91C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120519, XrefRangeEnd = 120520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_Pour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_Pour_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x000FF750 File Offset: 0x000FD950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120520, XrefRangeEnd = 120523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CloseDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000FF784 File Offset: 0x000FD984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120523, XrefRangeEnd = 120524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_PressButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000FF7B8 File Offset: 0x000FD9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120524, XrefRangeEnd = 120529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlayPourAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_PlayPourAnimation_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x000FF7F8 File Offset: 0x000FD9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120529, XrefRangeEnd = 120535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepInstruction(StartLabOvenTask.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask.NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x000150D7 File Offset: 0x000132D7
		public StartLabOvenTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002811 RID: 10257 RVA: 0x000FF830 File Offset: 0x000FDA30
		// (set) Token: 0x06002812 RID: 10258 RVA: 0x000150E0 File Offset: 0x000132E0
		public unsafe LabOven _Oven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__Oven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__Oven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002813 RID: 10259 RVA: 0x000FF860 File Offset: 0x000FDA60
		// (set) Token: 0x06002814 RID: 10260 RVA: 0x000150FF File Offset: 0x000132FF
		public unsafe StartLabOvenTask.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06002815 RID: 10261 RVA: 0x000FF888 File Offset: 0x000FDA88
		// (set) Token: 0x06002816 RID: 10262 RVA: 0x0001511A File Offset: 0x0001331A
		public unsafe ItemInstance ingredient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_ingredient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_ingredient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06002817 RID: 10263 RVA: 0x000FF8B8 File Offset: 0x000FDAB8
		// (set) Token: 0x06002818 RID: 10264 RVA: 0x00015139 File Offset: 0x00013339
		public unsafe Coroutine pourRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x000FF8E8 File Offset: 0x000FDAE8
		// (set) Token: 0x0600281A RID: 10266 RVA: 0x00015158 File Offset: 0x00013358
		public unsafe StationItem stationItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_stationItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_stationItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x000FF918 File Offset: 0x000FDB18
		// (set) Token: 0x0600281C RID: 10268 RVA: 0x00015177 File Offset: 0x00013377
		public unsafe PourableModule pourableModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourableModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourableModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x0600281D RID: 10269 RVA: 0x000FF948 File Offset: 0x000FDB48
		// (set) Token: 0x0600281E RID: 10270 RVA: 0x00015196 File Offset: 0x00013396
		public unsafe bool pourAnimDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourAnimDone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask.NativeFieldInfoPtr_pourAnimDone)) = value;
			}
		}

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeFieldInfoPtr__Oven_k__BackingField;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeFieldInfoPtr_ingredient;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeFieldInfoPtr_pourRoutine;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeFieldInfoPtr_stationItem;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeFieldInfoPtr_pourableModule;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeFieldInfoPtr_pourAnimDone;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeMethodInfoPtr_get_Oven_Public_get_LabOven_0;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeMethodInfoPtr_set_Oven_Private_set_Void_LabOven_0;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Protected_set_Void_EStep_0;

		// Token: 0x04001B8F RID: 7055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LabOven_0;

		// Token: 0x04001B90 RID: 7056
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001B91 RID: 7057
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001B92 RID: 7058
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_OpenDoor_Private_Void_0;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_Pour_Private_Void_0;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CloseDoor_Private_Void_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_PressButton_Private_Void_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr_PlayPourAnimation_Private_IEnumerator_0;

		// Token: 0x04001B9A RID: 7066
		private static readonly IntPtr NativeMethodInfoPtr_GetStepInstruction_Public_Static_String_EStep_0;

		// Token: 0x0200098E RID: 2446
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x04009514 RID: 38164
			OpenDoor,
			// Token: 0x04009515 RID: 38165
			Pour,
			// Token: 0x04009516 RID: 38166
			CloseDoor,
			// Token: 0x04009517 RID: 38167
			PressButton
		}

		// Token: 0x0200098F RID: 2447
		[ObfuscatedName("ScheduleOne.PlayerTasks.StartLabOvenTask+<PlayPourAnimation>d__24")]
		public sealed class _PlayPourAnimation_d__24 : Il2CppSystem.Object
		{
			// Token: 0x0600DA49 RID: 55881 RVA: 0x00361FC0 File Offset: 0x003601C0
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayPourAnimation_d__24()
			{
				Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartLabOvenTask>.NativeClassPtr, "<PlayPourAnimation>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<>1__state");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<>2__current");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<>4__this");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__pourTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<pourTime>5__2");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, "<i>5__3");
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668422);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668423);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668424);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668425);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668426);
				StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr, 100668427);
			}

			// Token: 0x0600DA4A RID: 55882 RVA: 0x003620C8 File Offset: 0x003602C8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayPourAnimation_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLabOvenTask._PlayPourAnimation_d__24>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA4B RID: 55883 RVA: 0x00362110 File Offset: 0x00360310
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA4C RID: 55884 RVA: 0x00362144 File Offset: 0x00360344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120370, XrefRangeEnd = 120376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042A9 RID: 17065
			// (get) Token: 0x0600DA4D RID: 55885 RVA: 0x00362180 File Offset: 0x00360380
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA4E RID: 55886 RVA: 0x003621C0 File Offset: 0x003603C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120376, XrefRangeEnd = 120381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042AA RID: 17066
			// (get) Token: 0x0600DA4F RID: 55887 RVA: 0x003621F4 File Offset: 0x003603F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLabOvenTask._PlayPourAnimation_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA50 RID: 55888 RVA: 0x000669EB File Offset: 0x00064BEB
			public _PlayPourAnimation_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042A4 RID: 17060
			// (get) Token: 0x0600DA51 RID: 55889 RVA: 0x00362234 File Offset: 0x00360434
			// (set) Token: 0x0600DA52 RID: 55890 RVA: 0x000669F4 File Offset: 0x00064BF4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042A5 RID: 17061
			// (get) Token: 0x0600DA53 RID: 55891 RVA: 0x0036225C File Offset: 0x0036045C
			// (set) Token: 0x0600DA54 RID: 55892 RVA: 0x00066A0F File Offset: 0x00064C0F
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A6 RID: 17062
			// (get) Token: 0x0600DA55 RID: 55893 RVA: 0x0036228C File Offset: 0x0036048C
			// (set) Token: 0x0600DA56 RID: 55894 RVA: 0x00066A2E File Offset: 0x00064C2E
			public unsafe StartLabOvenTask __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartLabOvenTask>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A7 RID: 17063
			// (get) Token: 0x0600DA57 RID: 55895 RVA: 0x003622BC File Offset: 0x003604BC
			// (set) Token: 0x0600DA58 RID: 55896 RVA: 0x00066A4D File Offset: 0x00064C4D
			public unsafe float _pourTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__pourTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__pourTime_5__2)) = value;
				}
			}

			// Token: 0x170042A8 RID: 17064
			// (get) Token: 0x0600DA59 RID: 55897 RVA: 0x003622E4 File Offset: 0x003604E4
			// (set) Token: 0x0600DA5A RID: 55898 RVA: 0x00066A68 File Offset: 0x00064C68
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLabOvenTask._PlayPourAnimation_d__24.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04009518 RID: 38168
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009519 RID: 38169
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400951A RID: 38170
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400951B RID: 38171
			private static readonly IntPtr NativeFieldInfoPtr__pourTime_5__2;

			// Token: 0x0400951C RID: 38172
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400951D RID: 38173
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400951E RID: 38174
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400951F RID: 38175
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009520 RID: 38176
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009521 RID: 38177
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009522 RID: 38178
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

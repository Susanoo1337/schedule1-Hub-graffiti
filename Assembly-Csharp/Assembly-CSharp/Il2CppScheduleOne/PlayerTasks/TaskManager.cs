using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200017D RID: 381
	public class TaskManager : Singleton<TaskManager>
	{
		// Token: 0x060026C5 RID: 9925 RVA: 0x000FB3C0 File Offset: 0x000F95C0
		// Note: this type is marked as 'beforefieldinit'.
		static TaskManager()
		{
			Il2CppClassPointerStore<TaskManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "TaskManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskManager>.NativeClassPtr);
			TaskManager.NativeFieldInfoPtr__CurrentTask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, "<CurrentTask>k__BackingField");
			TaskManager.NativeFieldInfoPtr__TimeOnLastTaskEnd_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, "<TimeOnLastTaskEnd>k__BackingField");
			TaskManager.NativeFieldInfoPtr_OnTaskStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, "OnTaskStarted");
			TaskManager.NativeFieldInfoPtr_TaskCompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, "TaskCompleteSound");
			TaskManager.NativeMethodInfoPtr_get_IsTaskActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668270);
			TaskManager.NativeMethodInfoPtr_get_CurrentTask_Public_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668271);
			TaskManager.NativeMethodInfoPtr_set_CurrentTask_Private_set_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668272);
			TaskManager.NativeMethodInfoPtr_get_TimeOnLastTaskEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668273);
			TaskManager.NativeMethodInfoPtr_set_TimeOnLastTaskEnd_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668274);
			TaskManager.NativeMethodInfoPtr_add_OnTaskStarted_Public_add_Void_Action_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668275);
			TaskManager.NativeMethodInfoPtr_remove_OnTaskStarted_Public_rem_Void_Action_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668276);
			TaskManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668277);
			TaskManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668278);
			TaskManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668279);
			TaskManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668280);
			TaskManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668281);
			TaskManager.NativeMethodInfoPtr_PlayTaskCompleteSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668282);
			TaskManager.NativeMethodInfoPtr_StartTask_Public_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668283);
			TaskManager.NativeMethodInfoPtr_EndTask_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668284);
			TaskManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668285);
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x000FB580 File Offset: 0x000F9780
		public unsafe bool IsTaskActive
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 118175, RefRangeEnd = 118179, XrefRangeStart = 118175, XrefRangeEnd = 118175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_get_IsTaskActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060026C7 RID: 9927 RVA: 0x000FB5BC File Offset: 0x000F97BC
		// (set) Token: 0x060026C8 RID: 9928 RVA: 0x000FB5FC File Offset: 0x000F97FC
		public unsafe Task CurrentTask
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_get_CurrentTask_Public_get_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_set_CurrentTask_Private_set_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060026C9 RID: 9929 RVA: 0x000FB640 File Offset: 0x000F9840
		// (set) Token: 0x060026CA RID: 9930 RVA: 0x000FB67C File Offset: 0x000F987C
		public unsafe float TimeOnLastTaskEnd
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29130, RefRangeEnd = 29131, XrefRangeStart = 29130, XrefRangeEnd = 29131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_get_TimeOnLastTaskEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29131, RefRangeEnd = 29133, XrefRangeStart = 29131, XrefRangeEnd = 29133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_set_TimeOnLastTaskEnd_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x000FB6BC File Offset: 0x000F98BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118184, RefRangeEnd = 118185, XrefRangeStart = 118179, XrefRangeEnd = 118184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnTaskStarted(Action<Task> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_add_OnTaskStarted_Public_add_Void_Action_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x000FB700 File Offset: 0x000F9900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118185, XrefRangeEnd = 118190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnTaskStarted(Action<Task> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_remove_OnTaskStarted_Public_rem_Void_Action_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x000FB744 File Offset: 0x000F9944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118190, XrefRangeEnd = 118203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x000FB780 File Offset: 0x000F9980
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x000FB7BC File Offset: 0x000F99BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118203, XrefRangeEnd = 118205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x000FB800 File Offset: 0x000F9A00
		[CallerCount(0)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000FB83C File Offset: 0x000F9A3C
		[CallerCount(0)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x000FB878 File Offset: 0x000F9A78
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 118206, RefRangeEnd = 118216, XrefRangeStart = 118205, XrefRangeEnd = 118206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTaskCompleteSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_PlayTaskCompleteSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x000FB8AC File Offset: 0x000F9AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118216, XrefRangeEnd = 118217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_StartTask_Public_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x000FB8F0 File Offset: 0x000F9AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118217, XrefRangeEnd = 118219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_EndTask_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x000FB924 File Offset: 0x000F9B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118219, XrefRangeEnd = 118222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x00014746 File Offset: 0x00012946
		public TaskManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x000FB960 File Offset: 0x000F9B60
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x0001474F File Offset: 0x0001294F
		public unsafe Task _CurrentTask_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr__CurrentTask_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr__CurrentTask_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x000FB990 File Offset: 0x000F9B90
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x0001476E File Offset: 0x0001296E
		public unsafe float _TimeOnLastTaskEnd_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr__TimeOnLastTaskEnd_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr__TimeOnLastTaskEnd_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x000FB9B8 File Offset: 0x000F9BB8
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x00014789 File Offset: 0x00012989
		public unsafe Action<Task> OnTaskStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_OnTaskStarted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_OnTaskStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x000FB9E8 File Offset: 0x000F9BE8
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x000147A8 File Offset: 0x000129A8
		public unsafe AudioSourceController TaskCompleteSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_TaskCompleteSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_TaskCompleteSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTask_k__BackingField;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeFieldInfoPtr__TimeOnLastTaskEnd_k__BackingField;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeFieldInfoPtr_OnTaskStarted;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeFieldInfoPtr_TaskCompleteSound;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTaskActive_Public_get_Boolean_0;

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTask_Public_get_Task_0;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTask_Private_set_Void_Task_0;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeOnLastTaskEnd_Public_get_Single_0;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeOnLastTaskEnd_Private_set_Void_Single_0;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_add_OnTaskStarted_Public_add_Void_Action_1_Task_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnTaskStarted_Public_rem_Void_Action_1_Task_0;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeMethodInfoPtr_PlayTaskCompleteSound_Public_Void_0;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeMethodInfoPtr_StartTask_Public_Void_Task_0;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeMethodInfoPtr_EndTask_Public_Void_0;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

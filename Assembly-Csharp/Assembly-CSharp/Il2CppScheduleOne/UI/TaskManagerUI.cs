using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000763 RID: 1891
	public class TaskManagerUI : Singleton<TaskManagerUI>
	{
		// Token: 0x0600B85B RID: 47195 RVA: 0x002F99E8 File Offset: 0x002F7BE8
		// Note: this type is marked as 'beforefieldinit'.
		static TaskManagerUI()
		{
			Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TaskManagerUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr);
			TaskManagerUI.NativeFieldInfoPtr_textShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "textShown");
			TaskManagerUI.NativeFieldInfoPtr_inputPromptUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "inputPromptUI");
			TaskManagerUI.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "canvas");
			TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "multiGrabIndicator");
			TaskManagerUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100687422);
			TaskManagerUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100687423);
			TaskManagerUI.NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100687424);
			TaskManagerUI.NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100687425);
			TaskManagerUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100687426);
		}

		// Token: 0x0600B85C RID: 47196 RVA: 0x002F9ACC File Offset: 0x002F7CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309041, XrefRangeEnd = 309047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B85D RID: 47197 RVA: 0x002F9B08 File Offset: 0x002F7D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309047, XrefRangeEnd = 309064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B85E RID: 47198 RVA: 0x002F9B44 File Offset: 0x002F7D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309064, XrefRangeEnd = 309080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateInstructionLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B85F RID: 47199 RVA: 0x002F9B80 File Offset: 0x002F7D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309080, XrefRangeEnd = 309104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TaskStarted(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManagerUI.NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B860 RID: 47200 RVA: 0x002F9BC4 File Offset: 0x002F7DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309104, XrefRangeEnd = 309107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskManagerUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManagerUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B861 RID: 47201 RVA: 0x00055B26 File Offset: 0x00053D26
		public TaskManagerUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x0600B862 RID: 47202 RVA: 0x002F9C00 File Offset: 0x002F7E00
		// (set) Token: 0x0600B863 RID: 47203 RVA: 0x00055B2F File Offset: 0x00053D2F
		public unsafe bool textShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_textShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_textShown)) = value;
			}
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0600B864 RID: 47204 RVA: 0x002F9C28 File Offset: 0x002F7E28
		// (set) Token: 0x0600B865 RID: 47205 RVA: 0x00055B4A File Offset: 0x00053D4A
		public unsafe GenericUIScreen inputPromptUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_inputPromptUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericUIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_inputPromptUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0600B866 RID: 47206 RVA: 0x002F9C58 File Offset: 0x002F7E58
		// (set) Token: 0x0600B867 RID: 47207 RVA: 0x00055B69 File Offset: 0x00053D69
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0600B868 RID: 47208 RVA: 0x002F9C88 File Offset: 0x002F7E88
		// (set) Token: 0x0600B869 RID: 47209 RVA: 0x00055B88 File Offset: 0x00053D88
		public unsafe RectTransform multiGrabIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007E94 RID: 32404
		private static readonly IntPtr NativeFieldInfoPtr_textShown;

		// Token: 0x04007E95 RID: 32405
		private static readonly IntPtr NativeFieldInfoPtr_inputPromptUI;

		// Token: 0x04007E96 RID: 32406
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04007E97 RID: 32407
		private static readonly IntPtr NativeFieldInfoPtr_multiGrabIndicator;

		// Token: 0x04007E98 RID: 32408
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007E99 RID: 32409
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007E9A RID: 32410
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0;

		// Token: 0x04007E9B RID: 32411
		private static readonly IntPtr NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0;

		// Token: 0x04007E9C RID: 32412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

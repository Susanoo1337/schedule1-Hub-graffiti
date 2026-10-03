using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200017C RID: 380
	public class Task : State
	{
		// Token: 0x0600267B RID: 9851 RVA: 0x000FA574 File Offset: 0x000F8774
		// Note: this type is marked as 'beforefieldinit'.
		static Task()
		{
			Il2CppClassPointerStore<Task>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "Task");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task>.NativeClassPtr);
			Task.NativeFieldInfoPtr_ClickDetectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "ClickDetectionRange");
			Task.NativeFieldInfoPtr_ClickDetectionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "ClickDetectionRadius");
			Task.NativeFieldInfoPtr_MultiGrabRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "MultiGrabRadius");
			Task.NativeFieldInfoPtr_MultiGrabForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "MultiGrabForceMultiplier");
			Task.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<TaskName>k__BackingField");
			Task.NativeFieldInfoPtr__CurrentInstruction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<CurrentInstruction>k__BackingField");
			Task.NativeFieldInfoPtr__TaskActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<TaskActive>k__BackingField");
			Task.NativeFieldInfoPtr_ClickDetectionEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "ClickDetectionEnabled");
			Task.NativeFieldInfoPtr__Outcome_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "<Outcome>k__BackingField");
			Task.NativeFieldInfoPtr_onTaskSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "onTaskSuccess");
			Task.NativeFieldInfoPtr_onTaskFail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "onTaskFail");
			Task.NativeFieldInfoPtr_onTaskStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "onTaskStop");
			Task.NativeFieldInfoPtr_clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "clickable");
			Task.NativeFieldInfoPtr_draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "draggable");
			Task.NativeFieldInfoPtr_constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "constraint");
			Task.NativeFieldInfoPtr_hitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "hitDistance");
			Task.NativeFieldInfoPtr_relativeHitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "relativeHitOffset");
			Task.NativeFieldInfoPtr_multiDraggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "multiDraggingEnabled");
			Task.NativeFieldInfoPtr_multiGrabProjectionPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "multiGrabProjectionPlane");
			Task.NativeFieldInfoPtr_multiDragTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "multiDragTargets");
			Task.NativeFieldInfoPtr_isMultiDragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "isMultiDragging");
			Task.NativeFieldInfoPtr_forcedClickables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "forcedClickables");
			Task.NativeFieldInfoPtr_clickablesLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task>.NativeClassPtr, "clickablesLayerMask");
			Task.NativeMethodInfoPtr_get_TaskName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668244);
			Task.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668245);
			Task.NativeMethodInfoPtr_get_CurrentInstruction_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668246);
			Task.NativeMethodInfoPtr_set_CurrentInstruction_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668247);
			Task.NativeMethodInfoPtr_get_TaskActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668248);
			Task.NativeMethodInfoPtr_set_TaskActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668249);
			Task.NativeMethodInfoPtr_get_Outcome_Public_get_EOutcome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668250);
			Task.NativeMethodInfoPtr_set_Outcome_Protected_set_Void_EOutcome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668251);
			Task.NativeMethodInfoPtr_get_TaskPointerData_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668252);
			Task.NativeMethodInfoPtr_get_InputWord_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668253);
			Task.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668254);
			Task.NativeMethodInfoPtr_CancelTask_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668255);
			Task.NativeMethodInfoPtr_StopTask_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668256);
			Task.NativeMethodInfoPtr_Success_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668257);
			Task.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668258);
			Task.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668259);
			Task.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668260);
			Task.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668261);
			Task.NativeMethodInfoPtr_GetMultiDragOrigin_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668262);
			Task.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668263);
			Task.NativeMethodInfoPtr_ForceStartClick_Public_Void_Clickable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668264);
			Task.NativeMethodInfoPtr_ForceEndClick_Public_Void_Clickable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668265);
			Task.NativeMethodInfoPtr_UpdateDraggablePhysics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668266);
			Task.NativeMethodInfoPtr_GetClickable_Protected_Virtual_New_Clickable_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668267);
			Task.NativeMethodInfoPtr_EnableMultiDragging_Protected_Void_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668268);
			Task.NativeMethodInfoPtr_DisableMultiDragging_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task>.NativeClassPtr, 100668269);
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x000FA978 File Offset: 0x000F8B78
		// (set) Token: 0x0600267D RID: 9853 RVA: 0x000FA9BC File Offset: 0x000F8BBC
		public unsafe virtual string TaskName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38421, RefRangeEnd = 38424, XrefRangeStart = 38421, XrefRangeEnd = 38424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_TaskName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x000FAA0C File Offset: 0x000F8C0C
		// (set) Token: 0x0600267F RID: 9855 RVA: 0x000FAA44 File Offset: 0x000F8C44
		public unsafe string CurrentInstruction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_CurrentInstruction_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_set_CurrentInstruction_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x000FAA88 File Offset: 0x000F8C88
		// (set) Token: 0x06002681 RID: 9857 RVA: 0x000FAAC4 File Offset: 0x000F8CC4
		public unsafe bool TaskActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_TaskActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_set_TaskActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x000FAB04 File Offset: 0x000F8D04
		// (set) Token: 0x06002683 RID: 9859 RVA: 0x000FAB40 File Offset: 0x000F8D40
		public unsafe Task.EOutcome Outcome
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 70620, RefRangeEnd = 70628, XrefRangeStart = 70620, XrefRangeEnd = 70628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_get_Outcome_Public_get_EOutcome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 117628, RefRangeEnd = 117633, XrefRangeStart = 117628, XrefRangeEnd = 117628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_set_Outcome_Protected_set_Void_EOutcome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x000FAB80 File Offset: 0x000F8D80
		public unsafe virtual string TaskPointerData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117633, XrefRangeEnd = 117635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_TaskPointerData_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x000FABC4 File Offset: 0x000F8DC4
		public unsafe virtual string InputWord
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117635, XrefRangeEnd = 117646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_get_InputWord_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x000FAC08 File Offset: 0x000F8E08
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 117712, RefRangeEnd = 117730, XrefRangeStart = 117646, XrefRangeEnd = 117712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000FAC44 File Offset: 0x000F8E44
		[CallerCount(0)]
		public unsafe virtual void CancelTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_CancelTask_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x000FAC80 File Offset: 0x000F8E80
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 117770, RefRangeEnd = 117787, XrefRangeStart = 117730, XrefRangeEnd = 117770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_StopTask_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000FACBC File Offset: 0x000F8EBC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 117791, RefRangeEnd = 117800, XrefRangeStart = 117787, XrefRangeEnd = 117791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Success_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000FACF8 File Offset: 0x000F8EF8
		[CallerCount(0)]
		public unsafe virtual void Fail()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x000FAD34 File Offset: 0x000F8F34
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 117846, RefRangeEnd = 117862, XrefRangeStart = 117800, XrefRangeEnd = 117846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x000FAD70 File Offset: 0x000F8F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117874, RefRangeEnd = 117875, XrefRangeStart = 117862, XrefRangeEnd = 117874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000FADAC File Offset: 0x000F8FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117922, RefRangeEnd = 117923, XrefRangeStart = 117875, XrefRangeEnd = 117922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000FADE8 File Offset: 0x000F8FE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117950, RefRangeEnd = 117952, XrefRangeStart = 117923, XrefRangeEnd = 117950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetMultiDragOrigin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_GetMultiDragOrigin_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000FAE24 File Offset: 0x000F9024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117952, XrefRangeEnd = 118045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000FAE60 File Offset: 0x000F9060
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 118053, RefRangeEnd = 118056, XrefRangeStart = 118045, XrefRangeEnd = 118053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceStartClick(Clickable _clickable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_clickable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ForceStartClick_Public_Void_Clickable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x000FAEA4 File Offset: 0x000F90A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 118063, RefRangeEnd = 118070, XrefRangeStart = 118056, XrefRangeEnd = 118063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceEndClick(Clickable _clickable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_clickable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_ForceEndClick_Public_Void_Clickable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x000FAEE8 File Offset: 0x000F90E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118148, RefRangeEnd = 118149, XrefRangeStart = 118070, XrefRangeEnd = 118148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDraggablePhysics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_UpdateDraggablePhysics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000FAF1C File Offset: 0x000F911C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118149, XrefRangeEnd = 118172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Clickable GetClickable(out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task.NativeMethodInfoPtr_GetClickable_Protected_Virtual_New_Clickable_byref_RaycastHit_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr3) : null;
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x000FAF74 File Offset: 0x000F9174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118173, RefRangeEnd = 118174, XrefRangeStart = 118172, XrefRangeEnd = 118173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableMultiDragging(Transform projectionPlane, float radius = 0.08f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(projectionPlane);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_EnableMultiDragging_Protected_Void_Transform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000FAFC4 File Offset: 0x000F91C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118174, XrefRangeEnd = 118175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableMultiDragging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task.NativeMethodInfoPtr_DisableMultiDragging_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x000144BE File Offset: 0x000126BE
		public Task(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x000FAFF8 File Offset: 0x000F91F8
		// (set) Token: 0x06002698 RID: 9880 RVA: 0x000144C7 File Offset: 0x000126C7
		public unsafe static float ClickDetectionRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_ClickDetectionRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_ClickDetectionRange, (void*)(&value));
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x000FB014 File Offset: 0x000F9214
		// (set) Token: 0x0600269A RID: 9882 RVA: 0x000144D5 File Offset: 0x000126D5
		public unsafe float ClickDetectionRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionRadius)) = value;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x000FB03C File Offset: 0x000F923C
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x000144F0 File Offset: 0x000126F0
		public unsafe float MultiGrabRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_MultiGrabRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_MultiGrabRadius)) = value;
			}
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x000FB064 File Offset: 0x000F9264
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x0001450B File Offset: 0x0001270B
		public unsafe static float MultiGrabForceMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Task.NativeFieldInfoPtr_MultiGrabForceMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task.NativeFieldInfoPtr_MultiGrabForceMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x0600269F RID: 9887 RVA: 0x000FB080 File Offset: 0x000F9280
		// (set) Token: 0x060026A0 RID: 9888 RVA: 0x00014519 File Offset: 0x00012719
		public unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060026A1 RID: 9889 RVA: 0x000FB0A8 File Offset: 0x000F92A8
		// (set) Token: 0x060026A2 RID: 9890 RVA: 0x00014538 File Offset: 0x00012738
		public unsafe string _CurrentInstruction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__CurrentInstruction_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__CurrentInstruction_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x000FB0D0 File Offset: 0x000F92D0
		// (set) Token: 0x060026A4 RID: 9892 RVA: 0x00014557 File Offset: 0x00012757
		public unsafe bool _TaskActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__TaskActive_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x000FB0F8 File Offset: 0x000F92F8
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x00014572 File Offset: 0x00012772
		public unsafe bool ClickDetectionEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_ClickDetectionEnabled)) = value;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x000FB120 File Offset: 0x000F9320
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x0001458D File Offset: 0x0001278D
		public unsafe Task.EOutcome _Outcome_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__Outcome_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr__Outcome_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x060026A9 RID: 9897 RVA: 0x000FB148 File Offset: 0x000F9348
		// (set) Token: 0x060026AA RID: 9898 RVA: 0x000145A8 File Offset: 0x000127A8
		public unsafe Action onTaskSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskSuccess);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskSuccess), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x060026AB RID: 9899 RVA: 0x000FB178 File Offset: 0x000F9378
		// (set) Token: 0x060026AC RID: 9900 RVA: 0x000145C7 File Offset: 0x000127C7
		public unsafe Action onTaskFail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskFail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskFail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x000FB1A8 File Offset: 0x000F93A8
		// (set) Token: 0x060026AE RID: 9902 RVA: 0x000145E6 File Offset: 0x000127E6
		public unsafe Action onTaskStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_onTaskStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x000FB1D8 File Offset: 0x000F93D8
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x00014605 File Offset: 0x00012805
		public unsafe Clickable clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x000FB208 File Offset: 0x000F9408
		// (set) Token: 0x060026B2 RID: 9906 RVA: 0x00014624 File Offset: 0x00012824
		public unsafe Draggable draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x000FB238 File Offset: 0x000F9438
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x00014643 File Offset: 0x00012843
		public unsafe DraggableConstraint constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x000FB268 File Offset: 0x000F9468
		// (set) Token: 0x060026B6 RID: 9910 RVA: 0x00014662 File Offset: 0x00012862
		public unsafe float hitDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_hitDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_hitDistance)) = value;
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x000FB290 File Offset: 0x000F9490
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x0001467D File Offset: 0x0001287D
		public unsafe Vector3 relativeHitOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_relativeHitOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_relativeHitOffset)) = value;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x000FB2B8 File Offset: 0x000F94B8
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x00014698 File Offset: 0x00012898
		public unsafe bool multiDraggingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDraggingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDraggingEnabled)) = value;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060026BB RID: 9915 RVA: 0x000FB2E0 File Offset: 0x000F94E0
		// (set) Token: 0x060026BC RID: 9916 RVA: 0x000146B3 File Offset: 0x000128B3
		public unsafe Transform multiGrabProjectionPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiGrabProjectionPlane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiGrabProjectionPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060026BD RID: 9917 RVA: 0x000FB310 File Offset: 0x000F9510
		// (set) Token: 0x060026BE RID: 9918 RVA: 0x000146D2 File Offset: 0x000128D2
		public unsafe List<Draggable> multiDragTargets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDragTargets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Draggable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_multiDragTargets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060026BF RID: 9919 RVA: 0x000FB340 File Offset: 0x000F9540
		// (set) Token: 0x060026C0 RID: 9920 RVA: 0x000146F1 File Offset: 0x000128F1
		public unsafe bool isMultiDragging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_isMultiDragging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_isMultiDragging)) = value;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x000FB368 File Offset: 0x000F9568
		// (set) Token: 0x060026C2 RID: 9922 RVA: 0x0001470C File Offset: 0x0001290C
		public unsafe List<Clickable> forcedClickables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_forcedClickables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Clickable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_forcedClickables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000FB398 File Offset: 0x000F9598
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x0001472B File Offset: 0x0001292B
		public unsafe LayerMask clickablesLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_clickablesLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task.NativeFieldInfoPtr_clickablesLayerMask)) = value;
			}
		}

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeFieldInfoPtr_ClickDetectionRange;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeFieldInfoPtr_ClickDetectionRadius;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeFieldInfoPtr_MultiGrabRadius;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeFieldInfoPtr_MultiGrabForceMultiplier;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeFieldInfoPtr__CurrentInstruction_k__BackingField;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeFieldInfoPtr__TaskActive_k__BackingField;

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeFieldInfoPtr_ClickDetectionEnabled;

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeFieldInfoPtr__Outcome_k__BackingField;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeFieldInfoPtr_onTaskSuccess;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeFieldInfoPtr_onTaskFail;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeFieldInfoPtr_onTaskStop;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeFieldInfoPtr_clickable;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeFieldInfoPtr_draggable;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeFieldInfoPtr_constraint;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeFieldInfoPtr_hitDistance;

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeFieldInfoPtr_relativeHitOffset;

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeFieldInfoPtr_multiDraggingEnabled;

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeFieldInfoPtr_multiGrabProjectionPlane;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeFieldInfoPtr_multiDragTargets;

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeFieldInfoPtr_isMultiDragging;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeFieldInfoPtr_forcedClickables;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeFieldInfoPtr_clickablesLayerMask;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_New_get_String_0;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_New_set_Void_String_0;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentInstruction_Public_get_String_0;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentInstruction_Protected_set_Void_String_0;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskActive_Public_get_Boolean_0;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskActive_Private_set_Void_Boolean_0;

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeMethodInfoPtr_get_Outcome_Public_get_EOutcome_0;

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeMethodInfoPtr_set_Outcome_Protected_set_Void_EOutcome_0;

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskPointerData_Protected_Virtual_New_get_String_0;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeMethodInfoPtr_get_InputWord_Protected_Virtual_New_get_String_0;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeMethodInfoPtr_CancelTask_Public_Virtual_New_Void_0;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_New_Void_0;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_New_Void_0;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_0;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_New_Void_0;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeMethodInfoPtr_GetMultiDragOrigin_Private_Vector3_0;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeMethodInfoPtr_ForceStartClick_Public_Void_Clickable_0;

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeMethodInfoPtr_ForceEndClick_Public_Void_Clickable_0;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDraggablePhysics_Private_Void_0;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeMethodInfoPtr_GetClickable_Protected_Virtual_New_Clickable_byref_RaycastHit_0;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeMethodInfoPtr_EnableMultiDragging_Protected_Void_Transform_Single_0;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeMethodInfoPtr_DisableMultiDragging_Protected_Void_0;

		// Token: 0x02000987 RID: 2439
		[OriginalName("Assembly-CSharp.dll", "", "EOutcome")]
		public enum EOutcome
		{
			// Token: 0x040094EF RID: 38127
			Cancelled,
			// Token: 0x040094F0 RID: 38128
			Success,
			// Token: 0x040094F1 RID: 38129
			Fail
		}
	}
}

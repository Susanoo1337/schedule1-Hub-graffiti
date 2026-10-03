using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.State
{
	// Token: 0x02000126 RID: 294
	public class MonoState : MonoBehaviour
	{
		// Token: 0x06001C07 RID: 7175 RVA: 0x000D7CD0 File Offset: 0x000D5ED0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoState()
		{
			Il2CppClassPointerStore<MonoState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.State", "MonoState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoState>.NativeClassPtr);
			MonoState.NativeFieldInfoPtr__defaultParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_defaultParent");
			MonoState.NativeFieldInfoPtr__customStateProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_customStateProperties");
			MonoState.NativeFieldInfoPtr__preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_preset");
			MonoState.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_properties");
			MonoState.NativeFieldInfoPtr__autoSetupExitListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_autoSetupExitListeners");
			MonoState.NativeFieldInfoPtr__exitListenerPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_exitListenerPriority");
			MonoState.NativeFieldInfoPtr__enableItemQuickMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_enableItemQuickMove");
			MonoState.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_flags");
			MonoState.NativeFieldInfoPtr__defaultInputPrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_defaultInputPrompts");
			MonoState.NativeFieldInfoPtr__subscribeToInputPromptModuleEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_subscribeToInputPromptModuleEvents");
			MonoState.NativeFieldInfoPtr_OnAddedToStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "OnAddedToStack");
			MonoState.NativeFieldInfoPtr_OnRemovedFromStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "OnRemovedFromStack");
			MonoState.NativeFieldInfoPtr_OnStateActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "OnStateActivate");
			MonoState.NativeFieldInfoPtr_OnStateDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "OnStateDeactivate");
			MonoState.NativeFieldInfoPtr_OnBecomeTopSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "OnBecomeTopSibling");
			MonoState.NativeFieldInfoPtr_OnNoLongerTopSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "OnNoLongerTopSibling");
			MonoState.NativeFieldInfoPtr__quickMoveSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_quickMoveSlots");
			MonoState.NativeFieldInfoPtr__inputHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "_inputHandler");
			MonoState.NativeMethodInfoPtr_get_IsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667014);
			MonoState.NativeMethodInfoPtr_get_IsAcceptingInput_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667015);
			MonoState.NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_StateProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667016);
			MonoState.NativeMethodInfoPtr_set_Properties_Public_set_Void_StateProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667017);
			MonoState.NativeMethodInfoPtr_get_Flags_Public_Virtual_Final_New_get_Il2CppStructArray_1_EFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667018);
			MonoState.NativeMethodInfoPtr_add_OnAddedToStack_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667019);
			MonoState.NativeMethodInfoPtr_remove_OnAddedToStack_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667020);
			MonoState.NativeMethodInfoPtr_add_OnRemovedFromStack_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667021);
			MonoState.NativeMethodInfoPtr_remove_OnRemovedFromStack_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667022);
			MonoState.NativeMethodInfoPtr_add_OnStateActivate_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667023);
			MonoState.NativeMethodInfoPtr_remove_OnStateActivate_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667024);
			MonoState.NativeMethodInfoPtr_add_OnStateDeactivate_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667025);
			MonoState.NativeMethodInfoPtr_remove_OnStateDeactivate_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667026);
			MonoState.NativeMethodInfoPtr_add_OnBecomeTopSibling_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667027);
			MonoState.NativeMethodInfoPtr_remove_OnBecomeTopSibling_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667028);
			MonoState.NativeMethodInfoPtr_add_OnNoLongerTopSibling_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667029);
			MonoState.NativeMethodInfoPtr_remove_OnNoLongerTopSibling_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667030);
			MonoState.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667031);
			MonoState.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667032);
			MonoState.NativeMethodInfoPtr_AssertDefaultParent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667033);
			MonoState.NativeMethodInfoPtr_OnActivate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667034);
			MonoState.NativeMethodInfoPtr_OnDeactivate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667035);
			MonoState.NativeMethodInfoPtr_InitializeDefaultParent_Public_Void_MonoStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667036);
			MonoState.NativeMethodInfoPtr_PushToDefaultParent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667037);
			MonoState.NativeMethodInfoPtr_PopFromDefaultParent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667038);
			MonoState.NativeMethodInfoPtr_RemoveFromDefaultParent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667039);
			MonoState.NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667040);
			MonoState.NativeMethodInfoPtr_NotifyAddedToStack_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667041);
			MonoState.NativeMethodInfoPtr_NotifyBecomeTopSibling_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667042);
			MonoState.NativeMethodInfoPtr_NotifyNoLongerTopSibling_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667043);
			MonoState.NativeMethodInfoPtr_SetQuickMoveSecondarySlots_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667044);
			MonoState.NativeMethodInfoPtr_OnExit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667045);
			MonoState.NativeMethodInfoPtr_CreateInputHandler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667046);
			MonoState.NativeMethodInfoPtr_AddFlag_Public_Void_EFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667047);
			MonoState.NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667048);
			MonoState.NativeMethodInfoPtr_LoadModule_Public_Void_String_EInputPromptPosition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667049);
			MonoState.NativeMethodInfoPtr_UnloadModule_Public_Void_InputPromptsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667050);
			MonoState.NativeMethodInfoPtr_UnloadModule_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667051);
			MonoState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667052);
			MonoState.NativeMethodInfoPtr_ScheduleOne_State_IState_get_name_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState>.NativeClassPtr, 100667053);
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000D8188 File Offset: 0x000D6388
		public unsafe virtual bool IsActive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 102572, RefRangeEnd = 102573, XrefRangeStart = 102571, XrefRangeEnd = 102572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_get_IsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x000D81C4 File Offset: 0x000D63C4
		public unsafe virtual bool IsAcceptingInput
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 102574, RefRangeEnd = 102616, XrefRangeStart = 102573, XrefRangeEnd = 102574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_get_IsAcceptingInput_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000D8200 File Offset: 0x000D6400
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x000D823C File Offset: 0x000D643C
		public unsafe virtual StateProperties Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102616, XrefRangeEnd = 102621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_StateProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 102621, RefRangeEnd = 102623, XrefRangeStart = 102621, XrefRangeEnd = 102621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_set_Properties_Public_set_Void_StateProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x000D827C File Offset: 0x000D647C
		public unsafe virtual Il2CppStructArray<IState.EFlag> Flags
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 21999, RefRangeEnd = 22015, XrefRangeStart = 21999, XrefRangeEnd = 22015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_get_Flags_Public_Virtual_Final_New_get_Il2CppStructArray_1_EFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IState.EFlag>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x000D82BC File Offset: 0x000D64BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 102627, RefRangeEnd = 102631, XrefRangeStart = 102623, XrefRangeEnd = 102627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnAddedToStack(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_add_OnAddedToStack_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x000D8300 File Offset: 0x000D6500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102631, XrefRangeEnd = 102635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnAddedToStack(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_remove_OnAddedToStack_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000D8344 File Offset: 0x000D6544
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 102639, RefRangeEnd = 102668, XrefRangeStart = 102635, XrefRangeEnd = 102639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRemovedFromStack(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_add_OnRemovedFromStack_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000D8388 File Offset: 0x000D6588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102668, XrefRangeEnd = 102672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRemovedFromStack(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_remove_OnRemovedFromStack_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x000D83CC File Offset: 0x000D65CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102672, XrefRangeEnd = 102676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnStateActivate(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_add_OnStateActivate_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x000D8410 File Offset: 0x000D6610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102676, XrefRangeEnd = 102680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnStateActivate(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_remove_OnStateActivate_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x000D8454 File Offset: 0x000D6654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102680, XrefRangeEnd = 102684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnStateDeactivate(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_add_OnStateDeactivate_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000D8498 File Offset: 0x000D6698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102684, XrefRangeEnd = 102688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnStateDeactivate(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_remove_OnStateDeactivate_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000D84DC File Offset: 0x000D66DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102692, RefRangeEnd = 102693, XrefRangeStart = 102688, XrefRangeEnd = 102692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnBecomeTopSibling(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_add_OnBecomeTopSibling_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000D8520 File Offset: 0x000D6720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102693, XrefRangeEnd = 102697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnBecomeTopSibling(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_remove_OnBecomeTopSibling_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x000D8564 File Offset: 0x000D6764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102701, RefRangeEnd = 102702, XrefRangeStart = 102697, XrefRangeEnd = 102701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnNoLongerTopSibling(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_add_OnNoLongerTopSibling_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x000D85A8 File Offset: 0x000D67A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102702, XrefRangeEnd = 102706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnNoLongerTopSibling(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_remove_OnNoLongerTopSibling_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x000D85EC File Offset: 0x000D67EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102707, RefRangeEnd = 102709, XrefRangeStart = 102706, XrefRangeEnd = 102707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoState.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x000D8628 File Offset: 0x000D6828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102709, XrefRangeEnd = 102730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoState.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x000D8664 File Offset: 0x000D6864
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssertDefaultParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_AssertDefaultParent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000D8698 File Offset: 0x000D6898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102779, RefRangeEnd = 102781, XrefRangeStart = 102730, XrefRangeEnd = 102779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoState.NativeMethodInfoPtr_OnActivate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x000D86D4 File Offset: 0x000D68D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102797, RefRangeEnd = 102798, XrefRangeStart = 102781, XrefRangeEnd = 102797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoState.NativeMethodInfoPtr_OnDeactivate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x000D8710 File Offset: 0x000D6910
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 102809, RefRangeEnd = 102848, XrefRangeStart = 102798, XrefRangeEnd = 102809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDefaultParent(MonoStateMachine parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_InitializeDefaultParent_Public_Void_MonoStateMachine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x000D8754 File Offset: 0x000D6954
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 102864, RefRangeEnd = 102917, XrefRangeStart = 102848, XrefRangeEnd = 102864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushToDefaultParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_PushToDefaultParent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000D8788 File Offset: 0x000D6988
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 102940, RefRangeEnd = 103014, XrefRangeStart = 102917, XrefRangeEnd = 102940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopFromDefaultParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_PopFromDefaultParent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x000D87BC File Offset: 0x000D69BC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 103048, RefRangeEnd = 103067, XrefRangeStart = 103014, XrefRangeEnd = 103048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromDefaultParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_RemoveFromDefaultParent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x000D87F0 File Offset: 0x000D69F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103067, RefRangeEnd = 103068, XrefRangeStart = 103067, XrefRangeEnd = 103067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyRemovedFromStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoState.NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000D882C File Offset: 0x000D6A2C
		[CallerCount(0)]
		public unsafe virtual void NotifyAddedToStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoState.NativeMethodInfoPtr_NotifyAddedToStack_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x000D8868 File Offset: 0x000D6A68
		[CallerCount(0)]
		public unsafe virtual void NotifyBecomeTopSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoState.NativeMethodInfoPtr_NotifyBecomeTopSibling_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x000D88A4 File Offset: 0x000D6AA4
		[CallerCount(0)]
		public unsafe virtual void NotifyNoLongerTopSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoState.NativeMethodInfoPtr_NotifyNoLongerTopSibling_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000D88E0 File Offset: 0x000D6AE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 103075, RefRangeEnd = 103079, XrefRangeStart = 103068, XrefRangeEnd = 103075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuickMoveSecondarySlots(List<ItemSlot> slots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_SetQuickMoveSecondarySlots_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x000D8924 File Offset: 0x000D6B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103079, XrefRangeEnd = 103082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnExit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_OnExit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x000D8968 File Offset: 0x000D6B68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 103096, RefRangeEnd = 103098, XrefRangeStart = 103082, XrefRangeEnd = 103096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateInputHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_CreateInputHandler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000D899C File Offset: 0x000D6B9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103117, RefRangeEnd = 103118, XrefRangeStart = 103098, XrefRangeEnd = 103117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFlag(IState.EFlag flag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_AddFlag_Public_Void_EFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000D89DC File Offset: 0x000D6BDC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 103124, RefRangeEnd = 103131, XrefRangeStart = 103118, XrefRangeEnd = 103124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(InputPromptsData module, string displayTextOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayTextOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x000D8A30 File Offset: 0x000D6C30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 103137, RefRangeEnd = 103141, XrefRangeStart = 103131, XrefRangeEnd = 103137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(string moduleId, EInputPromptPosition position = EInputPromptPosition.BottomLeftInGame, string displayTextOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(moduleId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayTextOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_LoadModule_Public_Void_String_EInputPromptPosition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000D8A94 File Offset: 0x000D6C94
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 103143, RefRangeEnd = 103151, XrefRangeStart = 103141, XrefRangeEnd = 103143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadModule(InputPromptsData module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_UnloadModule_Public_Void_InputPromptsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x000D8AD8 File Offset: 0x000D6CD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 103153, RefRangeEnd = 103156, XrefRangeStart = 103151, XrefRangeEnd = 103153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadModule(string moduleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(moduleId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_UnloadModule_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x000D8B1C File Offset: 0x000D6D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103172, RefRangeEnd = 103173, XrefRangeStart = 103156, XrefRangeEnd = 103172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x000D8B58 File Offset: 0x000D6D58
		public unsafe virtual string name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 48135, RefRangeEnd = 48145, XrefRangeStart = 48135, XrefRangeEnd = 48145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.NativeMethodInfoPtr_ScheduleOne_State_IState_get_name_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0000F239 File Offset: 0x0000D439
		public MonoState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001C31 RID: 7217 RVA: 0x000D8B90 File Offset: 0x000D6D90
		// (set) Token: 0x06001C32 RID: 7218 RVA: 0x0000F242 File Offset: 0x0000D442
		public unsafe MonoStateMachine _defaultParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__defaultParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoStateMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__defaultParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x000D8BC0 File Offset: 0x000D6DC0
		// (set) Token: 0x06001C34 RID: 7220 RVA: 0x0000F261 File Offset: 0x0000D461
		public unsafe bool _customStateProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__customStateProperties);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__customStateProperties)) = value;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001C35 RID: 7221 RVA: 0x000D8BE8 File Offset: 0x000D6DE8
		// (set) Token: 0x06001C36 RID: 7222 RVA: 0x0000F27C File Offset: 0x0000D47C
		public unsafe StateProperties.EPreset _preset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__preset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__preset)) = value;
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x000D8C10 File Offset: 0x000D6E10
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x0000F297 File Offset: 0x0000D497
		public unsafe StateProperties _properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__properties);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__properties)) = value;
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x000D8C38 File Offset: 0x000D6E38
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x0000F2B2 File Offset: 0x0000D4B2
		public unsafe bool _autoSetupExitListeners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__autoSetupExitListeners);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__autoSetupExitListeners)) = value;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x000D8C60 File Offset: 0x000D6E60
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x0000F2CD File Offset: 0x0000D4CD
		public unsafe int _exitListenerPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__exitListenerPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__exitListenerPriority)) = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x000D8C88 File Offset: 0x000D6E88
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		public unsafe bool _enableItemQuickMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__enableItemQuickMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__enableItemQuickMove)) = value;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x000D8CB0 File Offset: 0x000D6EB0
		// (set) Token: 0x06001C40 RID: 7232 RVA: 0x0000F303 File Offset: 0x0000D503
		public unsafe Il2CppStructArray<IState.EFlag> _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__flags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IState.EFlag>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__flags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x000D8CE0 File Offset: 0x000D6EE0
		// (set) Token: 0x06001C42 RID: 7234 RVA: 0x0000F322 File Offset: 0x0000D522
		public unsafe InputPromptsData _defaultInputPrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__defaultInputPrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__defaultInputPrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x000D8D10 File Offset: 0x000D6F10
		// (set) Token: 0x06001C44 RID: 7236 RVA: 0x0000F341 File Offset: 0x0000D541
		public unsafe bool _subscribeToInputPromptModuleEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__subscribeToInputPromptModuleEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__subscribeToInputPromptModuleEvents)) = value;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001C45 RID: 7237 RVA: 0x000D8D38 File Offset: 0x000D6F38
		// (set) Token: 0x06001C46 RID: 7238 RVA: 0x0000F35C File Offset: 0x0000D55C
		public unsafe Action OnAddedToStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnAddedToStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnAddedToStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x000D8D68 File Offset: 0x000D6F68
		// (set) Token: 0x06001C48 RID: 7240 RVA: 0x0000F37B File Offset: 0x0000D57B
		public unsafe Action OnRemovedFromStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnRemovedFromStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnRemovedFromStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x000D8D98 File Offset: 0x000D6F98
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x0000F39A File Offset: 0x0000D59A
		public unsafe Action OnStateActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnStateActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnStateActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x000D8DC8 File Offset: 0x000D6FC8
		// (set) Token: 0x06001C4C RID: 7244 RVA: 0x0000F3B9 File Offset: 0x0000D5B9
		public unsafe Action OnStateDeactivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnStateDeactivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnStateDeactivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x000D8DF8 File Offset: 0x000D6FF8
		// (set) Token: 0x06001C4E RID: 7246 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		public unsafe Action OnBecomeTopSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnBecomeTopSibling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnBecomeTopSibling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x000D8E28 File Offset: 0x000D7028
		// (set) Token: 0x06001C50 RID: 7248 RVA: 0x0000F3F7 File Offset: 0x0000D5F7
		public unsafe Action OnNoLongerTopSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnNoLongerTopSibling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr_OnNoLongerTopSibling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x000D8E58 File Offset: 0x000D7058
		// (set) Token: 0x06001C52 RID: 7250 RVA: 0x0000F416 File Offset: 0x0000D616
		public unsafe List<ItemSlot> _quickMoveSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__quickMoveSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__quickMoveSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x000D8E88 File Offset: 0x000D7088
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x0000F435 File Offset: 0x0000D635
		public unsafe StateInputHandler _inputHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__inputHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateInputHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.NativeFieldInfoPtr__inputHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeFieldInfoPtr__defaultParent;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeFieldInfoPtr__customStateProperties;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeFieldInfoPtr__preset;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeFieldInfoPtr__properties;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeFieldInfoPtr__autoSetupExitListeners;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeFieldInfoPtr__exitListenerPriority;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeFieldInfoPtr__enableItemQuickMove;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeFieldInfoPtr__defaultInputPrompts;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeFieldInfoPtr__subscribeToInputPromptModuleEvents;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeFieldInfoPtr_OnAddedToStack;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeFieldInfoPtr_OnRemovedFromStack;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeFieldInfoPtr_OnStateActivate;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeFieldInfoPtr_OnStateDeactivate;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeFieldInfoPtr_OnBecomeTopSibling;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeFieldInfoPtr_OnNoLongerTopSibling;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeFieldInfoPtr__quickMoveSlots;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeFieldInfoPtr__inputHandler;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingInput_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_StateProperties_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_set_Properties_Public_set_Void_StateProperties_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_Virtual_Final_New_get_Il2CppStructArray_1_EFlag_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAddedToStack_Public_add_Void_Action_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAddedToStack_Public_rem_Void_Action_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRemovedFromStack_Public_add_Void_Action_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRemovedFromStack_Public_rem_Void_Action_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_add_OnStateActivate_Public_add_Void_Action_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnStateActivate_Public_rem_Void_Action_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_add_OnStateDeactivate_Public_add_Void_Action_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnStateDeactivate_Public_rem_Void_Action_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_add_OnBecomeTopSibling_Public_add_Void_Action_0;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnBecomeTopSibling_Public_rem_Void_Action_0;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeMethodInfoPtr_add_OnNoLongerTopSibling_Public_add_Void_Action_0;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnNoLongerTopSibling_Public_rem_Void_Action_0;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr_AssertDefaultParent_Public_Void_0;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeMethodInfoPtr_OnActivate_Public_Virtual_New_Void_0;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr_OnDeactivate_Public_Virtual_New_Void_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDefaultParent_Public_Void_MonoStateMachine_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_PushToDefaultParent_Public_Void_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_PopFromDefaultParent_Public_Void_0;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromDefaultParent_Public_Void_0;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Virtual_New_Void_0;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAddedToStack_Public_Virtual_New_Void_0;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeMethodInfoPtr_NotifyBecomeTopSibling_Public_Virtual_New_Void_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr_NotifyNoLongerTopSibling_Public_Virtual_New_Void_0;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_SetQuickMoveSecondarySlots_Public_Void_List_1_ItemSlot_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_OnExit_Private_Void_ExitAction_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_CreateInputHandler_Private_Void_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_AddFlag_Public_Void_EFlag_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_String_0;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_String_EInputPromptPosition_String_0;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeMethodInfoPtr_UnloadModule_Public_Void_InputPromptsData_0;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr_UnloadModule_Public_Void_String_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleOne_State_IState_get_name_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0200094C RID: 2380
		[ObfuscatedName("ScheduleOne.State.MonoState+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D88F RID: 55439 RVA: 0x0035CDA4 File Offset: 0x0035AFA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<MonoState.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoState>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoState.__c__DisplayClass55_0>.NativeClassPtr);
				MonoState.__c__DisplayClass55_0.NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoState.__c__DisplayClass55_0>.NativeClassPtr, "flag");
				MonoState.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState.__c__DisplayClass55_0>.NativeClassPtr, 100667054);
				MonoState.__c__DisplayClass55_0.NativeMethodInfoPtr__AddFlag_b__0_Internal_Boolean_EFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoState.__c__DisplayClass55_0>.NativeClassPtr, 100667055);
			}

			// Token: 0x0600D890 RID: 55440 RVA: 0x0035CE0C File Offset: 0x0035B00C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoState.__c__DisplayClass55_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D891 RID: 55441 RVA: 0x0035CE48 File Offset: 0x0035B048
			[CallerCount(0)]
			public unsafe bool _AddFlag_b__0(IState.EFlag f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoState.__c__DisplayClass55_0.NativeMethodInfoPtr__AddFlag_b__0_Internal_Boolean_EFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D892 RID: 55442 RVA: 0x00065D59 File Offset: 0x00063F59
			public __c__DisplayClass55_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004224 RID: 16932
			// (get) Token: 0x0600D893 RID: 55443 RVA: 0x0035CE94 File Offset: 0x0035B094
			// (set) Token: 0x0600D894 RID: 55444 RVA: 0x00065D62 File Offset: 0x00063F62
			public unsafe IState.EFlag flag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.__c__DisplayClass55_0.NativeFieldInfoPtr_flag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoState.__c__DisplayClass55_0.NativeFieldInfoPtr_flag)) = value;
				}
			}

			// Token: 0x040093B7 RID: 37815
			private static readonly IntPtr NativeFieldInfoPtr_flag;

			// Token: 0x040093B8 RID: 37816
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093B9 RID: 37817
			private static readonly IntPtr NativeMethodInfoPtr__AddFlag_b__0_Internal_Boolean_EFlag_0;
		}
	}
}

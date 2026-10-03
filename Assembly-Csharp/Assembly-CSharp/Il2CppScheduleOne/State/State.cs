using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.State
{
	// Token: 0x02000128 RID: 296
	public class State : Object
	{
		// Token: 0x06001C64 RID: 7268 RVA: 0x000D92B4 File Offset: 0x000D74B4
		// Note: this type is marked as 'beforefieldinit'.
		static State()
		{
			Il2CppClassPointerStore<State>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.State", "State");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<State>.NativeClassPtr);
			State.NativeFieldInfoPtr__name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "<name>k__BackingField");
			State.NativeFieldInfoPtr__defaultParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "_defaultParent");
			State.NativeFieldInfoPtr__customStateProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "_customStateProperties");
			State.NativeFieldInfoPtr__preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "_preset");
			State.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "_properties");
			State.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "_flags");
			State.NativeFieldInfoPtr__autoSetupExitListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "_autoSetupExitListeners");
			State.NativeFieldInfoPtr__exitListenerPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "_exitListenerPriority");
			State.NativeFieldInfoPtr__enableItemQuickMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "_enableItemQuickMove");
			State.NativeFieldInfoPtr__defaultInputPrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "_defaultInputPrompts");
			State.NativeFieldInfoPtr_OnAddedToStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "OnAddedToStack");
			State.NativeFieldInfoPtr_OnRemovedFromStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "OnRemovedFromStack");
			State.NativeFieldInfoPtr_OnStateActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "OnStateActivate");
			State.NativeFieldInfoPtr_OnStateDeactivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "OnStateDeactivate");
			State.NativeFieldInfoPtr_OnBecomeTopSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "OnBecomeTopSibling");
			State.NativeFieldInfoPtr_OnNoLongerTopSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "OnNoLongerTopSibling");
			State.NativeFieldInfoPtr__quickMoveSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "_quickMoveSlots");
			State.NativeFieldInfoPtr__inputHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "_inputHandler");
			State.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667067);
			State.NativeMethodInfoPtr_set_name_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667068);
			State.NativeMethodInfoPtr_get_IsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667069);
			State.NativeMethodInfoPtr_get_IsAcceptingInput_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667070);
			State.NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_StateProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667071);
			State.NativeMethodInfoPtr_set_Properties_Public_set_Void_StateProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667072);
			State.NativeMethodInfoPtr_get_Flags_Public_Virtual_Final_New_get_Il2CppStructArray_1_EFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667073);
			State.NativeMethodInfoPtr_add_OnAddedToStack_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667074);
			State.NativeMethodInfoPtr_remove_OnAddedToStack_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667075);
			State.NativeMethodInfoPtr_add_OnRemovedFromStack_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667076);
			State.NativeMethodInfoPtr_remove_OnRemovedFromStack_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667077);
			State.NativeMethodInfoPtr_add_OnStateActivate_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667078);
			State.NativeMethodInfoPtr_remove_OnStateActivate_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667079);
			State.NativeMethodInfoPtr_add_OnStateDeactivate_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667080);
			State.NativeMethodInfoPtr_remove_OnStateDeactivate_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667081);
			State.NativeMethodInfoPtr_add_OnBecomeTopSibling_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667082);
			State.NativeMethodInfoPtr_remove_OnBecomeTopSibling_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667083);
			State.NativeMethodInfoPtr_add_OnNoLongerTopSibling_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667084);
			State.NativeMethodInfoPtr_remove_OnNoLongerTopSibling_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667085);
			State.NativeMethodInfoPtr__ctor_Public_Void_String_IStateMachine_EPreset_InputPromptsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667086);
			State.NativeMethodInfoPtr_EnableAutoExitListener_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667087);
			State.NativeMethodInfoPtr_EnableItemQuickMove_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667088);
			State.NativeMethodInfoPtr_OnActivate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667089);
			State.NativeMethodInfoPtr_OnDeactivate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667090);
			State.NativeMethodInfoPtr_InitializeDefaultParent_Public_Void_IStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667091);
			State.NativeMethodInfoPtr_PushToDefaultParent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667092);
			State.NativeMethodInfoPtr_PopFromDefaultParent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667093);
			State.NativeMethodInfoPtr_RemoveFromDefaultParent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667094);
			State.NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667095);
			State.NativeMethodInfoPtr_NotifyAddedToStack_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667096);
			State.NativeMethodInfoPtr_NotifyBecomeTopSibling_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667097);
			State.NativeMethodInfoPtr_NotifyNoLongerTopSibling_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667098);
			State.NativeMethodInfoPtr_OnExit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667099);
			State.NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667100);
			State.NativeMethodInfoPtr_LoadModule_Public_Void_String_EInputPromptPosition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667101);
			State.NativeMethodInfoPtr_UnloadModule_Public_Void_InputPromptsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667102);
			State.NativeMethodInfoPtr_UnloadModule_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<State>.NativeClassPtr, 100667103);
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x000D9730 File Offset: 0x000D7930
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x000D9768 File Offset: 0x000D7968
		public unsafe virtual string name
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_set_name_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x000D97AC File Offset: 0x000D79AC
		public unsafe virtual bool IsActive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 102572, RefRangeEnd = 102573, XrefRangeStart = 102572, XrefRangeEnd = 102573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_get_IsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x000D97E8 File Offset: 0x000D79E8
		public unsafe virtual bool IsAcceptingInput
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 102574, RefRangeEnd = 102616, XrefRangeStart = 102574, XrefRangeEnd = 102616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_get_IsAcceptingInput_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x000D9824 File Offset: 0x000D7A24
		// (set) Token: 0x06001C6A RID: 7274 RVA: 0x000D9860 File Offset: 0x000D7A60
		public unsafe virtual StateProperties Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103297, XrefRangeEnd = 103302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_StateProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 103302, RefRangeEnd = 103303, XrefRangeStart = 103302, XrefRangeEnd = 103302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_set_Properties_Public_set_Void_StateProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x000D98A0 File Offset: 0x000D7AA0
		public unsafe virtual Il2CppStructArray<IState.EFlag> Flags
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_get_Flags_Public_Virtual_Final_New_get_Il2CppStructArray_1_EFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IState.EFlag>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x000D98E0 File Offset: 0x000D7AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103303, XrefRangeEnd = 103307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnAddedToStack(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_add_OnAddedToStack_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x000D9924 File Offset: 0x000D7B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103307, XrefRangeEnd = 103311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnAddedToStack(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_remove_OnAddedToStack_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000D9968 File Offset: 0x000D7B68
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 103315, RefRangeEnd = 103324, XrefRangeStart = 103311, XrefRangeEnd = 103315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRemovedFromStack(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_add_OnRemovedFromStack_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x000D99AC File Offset: 0x000D7BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103328, RefRangeEnd = 103329, XrefRangeStart = 103324, XrefRangeEnd = 103328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRemovedFromStack(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_remove_OnRemovedFromStack_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x000D99F0 File Offset: 0x000D7BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103329, XrefRangeEnd = 103333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnStateActivate(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_add_OnStateActivate_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x000D9A34 File Offset: 0x000D7C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103333, XrefRangeEnd = 103337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnStateActivate(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_remove_OnStateActivate_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x000D9A78 File Offset: 0x000D7C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103337, XrefRangeEnd = 103341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnStateDeactivate(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_add_OnStateDeactivate_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x000D9ABC File Offset: 0x000D7CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103341, XrefRangeEnd = 103345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnStateDeactivate(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_remove_OnStateDeactivate_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x000D9B00 File Offset: 0x000D7D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103345, XrefRangeEnd = 103349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnBecomeTopSibling(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_add_OnBecomeTopSibling_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x000D9B44 File Offset: 0x000D7D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103349, XrefRangeEnd = 103353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnBecomeTopSibling(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_remove_OnBecomeTopSibling_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x000D9B88 File Offset: 0x000D7D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103353, XrefRangeEnd = 103357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnNoLongerTopSibling(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_add_OnNoLongerTopSibling_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x000D9BCC File Offset: 0x000D7DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103357, XrefRangeEnd = 103361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnNoLongerTopSibling(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_remove_OnNoLongerTopSibling_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x000D9C10 File Offset: 0x000D7E10
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 103421, RefRangeEnd = 103433, XrefRangeStart = 103361, XrefRangeEnd = 103421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe State(string name, IStateMachine defaultParent = null, StateProperties.EPreset preset = StateProperties.EPreset.Unenforced, InputPromptsData _defaultInputPrompts = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<State>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultParent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_defaultInputPrompts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr__ctor_Public_Void_String_IStateMachine_EPreset_InputPromptsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x000D9C90 File Offset: 0x000D7E90
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 103436, RefRangeEnd = 103444, XrefRangeStart = 103433, XrefRangeEnd = 103436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableAutoExitListener(int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_EnableAutoExitListener_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x000D9CD0 File Offset: 0x000D7ED0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 103445, RefRangeEnd = 103453, XrefRangeStart = 103444, XrefRangeEnd = 103445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableItemQuickMove(List<ItemSlot> quickMoveSlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(quickMoveSlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_EnableItemQuickMove_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x000D9D14 File Offset: 0x000D7F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103453, XrefRangeEnd = 103481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnActivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), State.NativeMethodInfoPtr_OnActivate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x000D9D50 File Offset: 0x000D7F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103481, XrefRangeEnd = 103497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), State.NativeMethodInfoPtr_OnDeactivate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x000D9D8C File Offset: 0x000D7F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103497, XrefRangeEnd = 103504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDefaultParent(IStateMachine parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_InitializeDefaultParent_Public_Void_IStateMachine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x000D9DD0 File Offset: 0x000D7FD0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 103516, RefRangeEnd = 103527, XrefRangeStart = 103504, XrefRangeEnd = 103516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushToDefaultParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_PushToDefaultParent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x000D9E04 File Offset: 0x000D8004
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 103547, RefRangeEnd = 103550, XrefRangeStart = 103527, XrefRangeEnd = 103547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopFromDefaultParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_PopFromDefaultParent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x000D9E38 File Offset: 0x000D8038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103550, XrefRangeEnd = 103562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromDefaultParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_RemoveFromDefaultParent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x000D9E6C File Offset: 0x000D806C
		[CallerCount(0)]
		public unsafe virtual void NotifyRemovedFromStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x000D9EA0 File Offset: 0x000D80A0
		[CallerCount(0)]
		public unsafe virtual void NotifyAddedToStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_NotifyAddedToStack_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x000D9ED4 File Offset: 0x000D80D4
		[CallerCount(0)]
		public unsafe virtual void NotifyBecomeTopSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_NotifyBecomeTopSibling_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x000D9F08 File Offset: 0x000D8108
		[CallerCount(0)]
		public unsafe virtual void NotifyNoLongerTopSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_NotifyNoLongerTopSibling_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x000D9F3C File Offset: 0x000D813C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103562, XrefRangeEnd = 103583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnExit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_OnExit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x000D9F80 File Offset: 0x000D8180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103583, XrefRangeEnd = 103589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(InputPromptsData module, string displayTextOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayTextOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x000D9FD4 File Offset: 0x000D81D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103595, RefRangeEnd = 103596, XrefRangeStart = 103589, XrefRangeEnd = 103595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(string moduleId, EInputPromptPosition position = EInputPromptPosition.BottomLeftInGame, string displayTextOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(moduleId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayTextOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_LoadModule_Public_Void_String_EInputPromptPosition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x000DA038 File Offset: 0x000D8238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103596, XrefRangeEnd = 103598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadModule(InputPromptsData module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_UnloadModule_Public_Void_InputPromptsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x000DA07C File Offset: 0x000D827C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103600, RefRangeEnd = 103601, XrefRangeStart = 103598, XrefRangeEnd = 103600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadModule(string moduleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(moduleId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(State.NativeMethodInfoPtr_UnloadModule_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0000F47C File Offset: 0x0000D67C
		public State(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x000DA0C0 File Offset: 0x000D82C0
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x0000F485 File Offset: 0x0000D685
		public unsafe string _name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001C8D RID: 7309 RVA: 0x000DA0E8 File Offset: 0x000D82E8
		// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		public unsafe IStateMachine _defaultParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__defaultParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStateMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__defaultParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x000DA118 File Offset: 0x000D8318
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x0000F4C3 File Offset: 0x0000D6C3
		public unsafe bool _customStateProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__customStateProperties);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__customStateProperties)) = value;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001C91 RID: 7313 RVA: 0x000DA140 File Offset: 0x000D8340
		// (set) Token: 0x06001C92 RID: 7314 RVA: 0x0000F4DE File Offset: 0x0000D6DE
		public unsafe StateProperties.EPreset _preset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__preset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__preset)) = value;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x000DA168 File Offset: 0x000D8368
		// (set) Token: 0x06001C94 RID: 7316 RVA: 0x0000F4F9 File Offset: 0x0000D6F9
		public unsafe StateProperties _properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__properties);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__properties)) = value;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001C95 RID: 7317 RVA: 0x000DA190 File Offset: 0x000D8390
		// (set) Token: 0x06001C96 RID: 7318 RVA: 0x0000F514 File Offset: 0x0000D714
		public unsafe Il2CppStructArray<IState.EFlag> _flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__flags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IState.EFlag>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__flags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001C97 RID: 7319 RVA: 0x000DA1C0 File Offset: 0x000D83C0
		// (set) Token: 0x06001C98 RID: 7320 RVA: 0x0000F533 File Offset: 0x0000D733
		public unsafe bool _autoSetupExitListeners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__autoSetupExitListeners);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__autoSetupExitListeners)) = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001C99 RID: 7321 RVA: 0x000DA1E8 File Offset: 0x000D83E8
		// (set) Token: 0x06001C9A RID: 7322 RVA: 0x0000F54E File Offset: 0x0000D74E
		public unsafe int _exitListenerPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__exitListenerPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__exitListenerPriority)) = value;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x000DA210 File Offset: 0x000D8410
		// (set) Token: 0x06001C9C RID: 7324 RVA: 0x0000F569 File Offset: 0x0000D769
		public unsafe bool _enableItemQuickMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__enableItemQuickMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__enableItemQuickMove)) = value;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x000DA238 File Offset: 0x000D8438
		// (set) Token: 0x06001C9E RID: 7326 RVA: 0x0000F584 File Offset: 0x0000D784
		public unsafe InputPromptsData _defaultInputPrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__defaultInputPrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__defaultInputPrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x000DA268 File Offset: 0x000D8468
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x0000F5A3 File Offset: 0x0000D7A3
		public unsafe Action OnAddedToStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnAddedToStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnAddedToStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x000DA298 File Offset: 0x000D8498
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x0000F5C2 File Offset: 0x0000D7C2
		public unsafe Action OnRemovedFromStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnRemovedFromStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnRemovedFromStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x000DA2C8 File Offset: 0x000D84C8
		// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x0000F5E1 File Offset: 0x0000D7E1
		public unsafe Action OnStateActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnStateActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnStateActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x000DA2F8 File Offset: 0x000D84F8
		// (set) Token: 0x06001CA6 RID: 7334 RVA: 0x0000F600 File Offset: 0x0000D800
		public unsafe Action OnStateDeactivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnStateDeactivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnStateDeactivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001CA7 RID: 7335 RVA: 0x000DA328 File Offset: 0x000D8528
		// (set) Token: 0x06001CA8 RID: 7336 RVA: 0x0000F61F File Offset: 0x0000D81F
		public unsafe Action OnBecomeTopSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnBecomeTopSibling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnBecomeTopSibling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x000DA358 File Offset: 0x000D8558
		// (set) Token: 0x06001CAA RID: 7338 RVA: 0x0000F63E File Offset: 0x0000D83E
		public unsafe Action OnNoLongerTopSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnNoLongerTopSibling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr_OnNoLongerTopSibling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001CAB RID: 7339 RVA: 0x000DA388 File Offset: 0x000D8588
		// (set) Token: 0x06001CAC RID: 7340 RVA: 0x0000F65D File Offset: 0x0000D85D
		public unsafe List<ItemSlot> _quickMoveSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__quickMoveSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__quickMoveSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001CAD RID: 7341 RVA: 0x000DA3B8 File Offset: 0x000D85B8
		// (set) Token: 0x06001CAE RID: 7342 RVA: 0x0000F67C File Offset: 0x0000D87C
		public unsafe StateInputHandler _inputHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__inputHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StateInputHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(State.NativeFieldInfoPtr__inputHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeFieldInfoPtr__name_k__BackingField;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeFieldInfoPtr__defaultParent;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeFieldInfoPtr__customStateProperties;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeFieldInfoPtr__preset;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeFieldInfoPtr__properties;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeFieldInfoPtr__flags;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeFieldInfoPtr__autoSetupExitListeners;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeFieldInfoPtr__exitListenerPriority;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeFieldInfoPtr__enableItemQuickMove;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeFieldInfoPtr__defaultInputPrompts;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeFieldInfoPtr_OnAddedToStack;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeFieldInfoPtr_OnRemovedFromStack;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeFieldInfoPtr_OnStateActivate;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeFieldInfoPtr_OnStateDeactivate;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeFieldInfoPtr_OnBecomeTopSibling;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeFieldInfoPtr_OnNoLongerTopSibling;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeFieldInfoPtr__quickMoveSlots;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeFieldInfoPtr__inputHandler;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Private_set_Void_String_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingInput_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_StateProperties_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr_set_Properties_Public_set_Void_StateProperties_0;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Public_Virtual_Final_New_get_Il2CppStructArray_1_EFlag_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAddedToStack_Public_add_Void_Action_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAddedToStack_Public_rem_Void_Action_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRemovedFromStack_Public_add_Void_Action_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRemovedFromStack_Public_rem_Void_Action_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr_add_OnStateActivate_Public_add_Void_Action_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnStateActivate_Public_rem_Void_Action_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_add_OnStateDeactivate_Public_add_Void_Action_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnStateDeactivate_Public_rem_Void_Action_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_add_OnBecomeTopSibling_Public_add_Void_Action_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnBecomeTopSibling_Public_rem_Void_Action_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_add_OnNoLongerTopSibling_Public_add_Void_Action_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnNoLongerTopSibling_Public_rem_Void_Action_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IStateMachine_EPreset_InputPromptsData_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_EnableAutoExitListener_Public_Void_Int32_0;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeMethodInfoPtr_EnableItemQuickMove_Public_Void_List_1_ItemSlot_0;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_OnActivate_Public_Virtual_New_Void_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_OnDeactivate_Public_Virtual_New_Void_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDefaultParent_Public_Void_IStateMachine_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr_PushToDefaultParent_Public_Void_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_PopFromDefaultParent_Public_Void_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromDefaultParent_Public_Void_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_NotifyRemovedFromStack_Public_Virtual_Final_New_Void_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAddedToStack_Public_Virtual_Final_New_Void_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_NotifyBecomeTopSibling_Public_Virtual_Final_New_Void_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_NotifyNoLongerTopSibling_Public_Virtual_Final_New_Void_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_OnExit_Private_Void_ExitAction_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_String_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_String_EInputPromptPosition_String_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_UnloadModule_Public_Void_InputPromptsData_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_UnloadModule_Public_Void_String_0;
	}
}

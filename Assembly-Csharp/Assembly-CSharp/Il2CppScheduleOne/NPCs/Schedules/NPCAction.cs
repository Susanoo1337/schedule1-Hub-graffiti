using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x02000695 RID: 1685
	[Serializable]
	public class NPCAction : NetworkBehaviour
	{
		// Token: 0x0600A44F RID: 42063 RVA: 0x002BA6B8 File Offset: 0x002B88B8
		// Note: this type is marked as 'beforefieldinit'.
		static NPCAction()
		{
			Il2CppClassPointerStore<NPCAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCAction>.NativeClassPtr);
			NPCAction.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			NPCAction.NativeFieldInfoPtr__HasStarted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "<HasStarted>k__BackingField");
			NPCAction.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "priority");
			NPCAction.NativeFieldInfoPtr__canUseUmbrella = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "_canUseUmbrella");
			NPCAction.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "StartTime");
			NPCAction.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "npc");
			NPCAction.NativeFieldInfoPtr_schedule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "schedule");
			NPCAction.NativeFieldInfoPtr_onEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "onEnded");
			NPCAction.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "consecutivePathingFailures");
			NPCAction.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted");
			NPCAction.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted");
			NPCAction.NativeMethodInfoPtr_get_ActionName_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685056);
			NPCAction.NativeMethodInfoPtr_get_IsEvent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685057);
			NPCAction.NativeMethodInfoPtr_get_IsSignal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685058);
			NPCAction.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685059);
			NPCAction.NativeMethodInfoPtr_get_HasStarted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685060);
			NPCAction.NativeMethodInfoPtr_set_HasStarted_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685061);
			NPCAction.NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685062);
			NPCAction.NativeMethodInfoPtr_get_movement_Protected_get_NPCMovement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685063);
			NPCAction.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685064);
			NPCAction.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685065);
			NPCAction.NativeMethodInfoPtr_GetReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685066);
			NPCAction.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685067);
			NPCAction.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685068);
			NPCAction.NativeMethodInfoPtr_Started_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685069);
			NPCAction.NativeMethodInfoPtr_LateStarted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685070);
			NPCAction.NativeMethodInfoPtr_JumpTo_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685071);
			NPCAction.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685072);
			NPCAction.NativeMethodInfoPtr_Interrupt_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685073);
			NPCAction.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685074);
			NPCAction.NativeMethodInfoPtr_ResumeFailed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685075);
			NPCAction.NativeMethodInfoPtr_Skipped_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685076);
			NPCAction.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685077);
			NPCAction.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685078);
			NPCAction.NativeMethodInfoPtr_OnActiveMinPass_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685079);
			NPCAction.NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685080);
			NPCAction.NativeMethodInfoPtr_MinPassed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685081);
			NPCAction.NativeMethodInfoPtr_ShouldStart_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685082);
			NPCAction.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685083);
			NPCAction.NativeMethodInfoPtr_GetTimeDescription_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685084);
			NPCAction.NativeMethodInfoPtr_GetEndTime_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685085);
			NPCAction.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685086);
			NPCAction.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685087);
			NPCAction.NativeMethodInfoPtr_SetStartTime_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685088);
			NPCAction.NativeMethodInfoPtr_SetCanUseUmbrella_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685089);
			NPCAction.NativeMethodInfoPtr_OnStart_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685090);
			NPCAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685091);
			NPCAction.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685092);
			NPCAction.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685093);
			NPCAction.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685094);
			NPCAction.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAction>.NativeClassPtr, 100685095);
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x0600A450 RID: 42064 RVA: 0x002BAAE4 File Offset: 0x002B8CE4
		public unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288507, XrefRangeEnd = 288509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_ActionName_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x0600A451 RID: 42065 RVA: 0x002BAB1C File Offset: 0x002B8D1C
		public unsafe bool IsEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288509, XrefRangeEnd = 288511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_IsEvent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x0600A452 RID: 42066 RVA: 0x002BAB58 File Offset: 0x002B8D58
		public unsafe bool IsSignal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288513, RefRangeEnd = 288514, XrefRangeStart = 288511, XrefRangeEnd = 288513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_IsSignal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x0600A453 RID: 42067 RVA: 0x002BAB94 File Offset: 0x002B8D94
		public unsafe bool IsActive
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 288518, RefRangeEnd = 288541, XrefRangeStart = 288514, XrefRangeEnd = 288518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x0600A454 RID: 42068 RVA: 0x002BABD0 File Offset: 0x002B8DD0
		// (set) Token: 0x0600A455 RID: 42069 RVA: 0x002BAC0C File Offset: 0x002B8E0C
		public unsafe bool HasStarted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_HasStarted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_set_HasStarted_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x0600A456 RID: 42070 RVA: 0x002BAC4C File Offset: 0x002B8E4C
		public unsafe virtual int Priority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x0600A457 RID: 42071 RVA: 0x002BAC94 File Offset: 0x002B8E94
		public unsafe NPCMovement movement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_get_movement_Protected_get_NPCMovement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr3) : null;
			}
		}

		// Token: 0x0600A458 RID: 42072 RVA: 0x002BACD4 File Offset: 0x002B8ED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 288542, RefRangeEnd = 288544, XrefRangeStart = 288541, XrefRangeEnd = 288542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A459 RID: 42073 RVA: 0x002BAD10 File Offset: 0x002B8F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288544, XrefRangeEnd = 288546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45A RID: 42074 RVA: 0x002BAD4C File Offset: 0x002B8F4C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 288561, RefRangeEnd = 288585, XrefRangeStart = 288546, XrefRangeEnd = 288561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetReferences()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_GetReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45B RID: 42075 RVA: 0x002BAD80 File Offset: 0x002B8F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288604, RefRangeEnd = 288605, XrefRangeStart = 288585, XrefRangeEnd = 288604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45C RID: 42076 RVA: 0x002BADBC File Offset: 0x002B8FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288605, XrefRangeEnd = 288618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45D RID: 42077 RVA: 0x002BADF0 File Offset: 0x002B8FF0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 288628, RefRangeEnd = 288634, XrefRangeStart = 288618, XrefRangeEnd = 288628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Started_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45E RID: 42078 RVA: 0x002BAE2C File Offset: 0x002B902C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 288644, RefRangeEnd = 288650, XrefRangeStart = 288634, XrefRangeEnd = 288644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_LateStarted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x002BAE68 File Offset: 0x002B9068
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 288660, RefRangeEnd = 288666, XrefRangeStart = 288650, XrefRangeEnd = 288660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_JumpTo_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x002BAEA4 File Offset: 0x002B90A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 288675, RefRangeEnd = 288680, XrefRangeStart = 288666, XrefRangeEnd = 288675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A461 RID: 42081 RVA: 0x002BAEE0 File Offset: 0x002B90E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 288695, RefRangeEnd = 288700, XrefRangeStart = 288680, XrefRangeEnd = 288695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Interrupt_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x002BAF1C File Offset: 0x002B911C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 288719, RefRangeEnd = 288729, XrefRangeStart = 288700, XrefRangeEnd = 288719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x002BAF58 File Offset: 0x002B9158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288729, XrefRangeEnd = 288743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResumeFailed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_ResumeFailed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A464 RID: 42084 RVA: 0x002BAF94 File Offset: 0x002B9194
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 288753, RefRangeEnd = 288761, XrefRangeStart = 288743, XrefRangeEnd = 288753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Skipped_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A465 RID: 42085 RVA: 0x002BAFD0 File Offset: 0x002B91D0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActiveUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A466 RID: 42086 RVA: 0x002BB00C File Offset: 0x002B920C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A467 RID: 42087 RVA: 0x002BB048 File Offset: 0x002B9248
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_OnActiveMinPass_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A468 RID: 42088 RVA: 0x002BB084 File Offset: 0x002B9284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288761, XrefRangeEnd = 288766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PendingMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A469 RID: 42089 RVA: 0x002BB0C0 File Offset: 0x002B92C0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_MinPassed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x002BB0FC File Offset: 0x002B92FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288766, XrefRangeEnd = 288768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_ShouldStart_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x002BB144 File Offset: 0x002B9344
		[CallerCount(0)]
		public unsafe virtual string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A46C RID: 42092 RVA: 0x002BB188 File Offset: 0x002B9388
		[CallerCount(0)]
		public unsafe virtual string GetTimeDescription()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_GetTimeDescription_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A46D RID: 42093 RVA: 0x002BB1CC File Offset: 0x002B93CC
		[CallerCount(0)]
		public unsafe virtual int GetEndTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_GetEndTime_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A46E RID: 42094 RVA: 0x002BB214 File Offset: 0x002B9414
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 288781, RefRangeEnd = 288807, XrefRangeStart = 288768, XrefRangeEnd = 288781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref teleportIfFail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A46F RID: 42095 RVA: 0x002BB260 File Offset: 0x002B9460
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 288819, RefRangeEnd = 288828, XrefRangeStart = 288807, XrefRangeEnd = 288819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x002BB2AC File Offset: 0x002B94AC
		[CallerCount(0)]
		public unsafe virtual void SetStartTime(int startTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_SetStartTime_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A471 RID: 42097 RVA: 0x002BB2F8 File Offset: 0x002B94F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288828, XrefRangeEnd = 288833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanUseUmbrella(bool canUse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref canUse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr_SetCanUseUmbrella_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A472 RID: 42098 RVA: 0x002BB338 File Offset: 0x002B9538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288833, XrefRangeEnd = 288838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_OnStart_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A473 RID: 42099 RVA: 0x002BB374 File Offset: 0x002B9574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288838, XrefRangeEnd = 288839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCAction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A474 RID: 42100 RVA: 0x002BB3B0 File Offset: 0x002B95B0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A475 RID: 42101 RVA: 0x002BB3EC File Offset: 0x002B95EC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x002BB428 File Offset: 0x002B9628
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x002BB464 File Offset: 0x002B9664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288839, XrefRangeEnd = 288840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAction.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x0004B2D9 File Offset: 0x000494D9
		public NPCAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003169 RID: 12649
		// (get) Token: 0x0600A479 RID: 42105 RVA: 0x002BB4A0 File Offset: 0x002B96A0
		// (set) Token: 0x0600A47A RID: 42106 RVA: 0x0004B2E2 File Offset: 0x000494E2
		public unsafe static int MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NPCAction.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCAction.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x0600A47B RID: 42107 RVA: 0x002BB4BC File Offset: 0x002B96BC
		// (set) Token: 0x0600A47C RID: 42108 RVA: 0x0004B2F0 File Offset: 0x000494F0
		public unsafe bool _HasStarted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__HasStarted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__HasStarted_k__BackingField)) = value;
			}
		}

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x0600A47D RID: 42109 RVA: 0x002BB4E4 File Offset: 0x002B96E4
		// (set) Token: 0x0600A47E RID: 42110 RVA: 0x0004B30B File Offset: 0x0004950B
		public unsafe int priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x1700316C RID: 12652
		// (get) Token: 0x0600A47F RID: 42111 RVA: 0x002BB50C File Offset: 0x002B970C
		// (set) Token: 0x0600A480 RID: 42112 RVA: 0x0004B326 File Offset: 0x00049526
		public unsafe bool _canUseUmbrella
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__canUseUmbrella);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr__canUseUmbrella)) = value;
			}
		}

		// Token: 0x1700316D RID: 12653
		// (get) Token: 0x0600A481 RID: 42113 RVA: 0x002BB534 File Offset: 0x002B9734
		// (set) Token: 0x0600A482 RID: 42114 RVA: 0x0004B341 File Offset: 0x00049541
		public unsafe int StartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x0600A483 RID: 42115 RVA: 0x002BB55C File Offset: 0x002B975C
		// (set) Token: 0x0600A484 RID: 42116 RVA: 0x0004B35C File Offset: 0x0004955C
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x0600A485 RID: 42117 RVA: 0x002BB58C File Offset: 0x002B978C
		// (set) Token: 0x0600A486 RID: 42118 RVA: 0x0004B37B File Offset: 0x0004957B
		public unsafe NPCScheduleManager schedule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_schedule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCScheduleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_schedule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x0600A487 RID: 42119 RVA: 0x002BB5BC File Offset: 0x002B97BC
		// (set) Token: 0x0600A488 RID: 42120 RVA: 0x0004B39A File Offset: 0x0004959A
		public unsafe Action onEnded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_onEnded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_onEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x0600A489 RID: 42121 RVA: 0x002BB5EC File Offset: 0x002B97EC
		// (set) Token: 0x0600A48A RID: 42122 RVA: 0x0004B3B9 File Offset: 0x000495B9
		public unsafe int consecutivePathingFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x0600A48B RID: 42123 RVA: 0x002BB614 File Offset: 0x002B9814
		// (set) Token: 0x0600A48C RID: 42124 RVA: 0x0004B3D4 File Offset: 0x000495D4
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x0600A48D RID: 42125 RVA: 0x002BB63C File Offset: 0x002B983C
		// (set) Token: 0x0600A48E RID: 42126 RVA: 0x0004B3EF File Offset: 0x000495EF
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAction.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007197 RID: 29079
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x04007198 RID: 29080
		private static readonly IntPtr NativeFieldInfoPtr__HasStarted_k__BackingField;

		// Token: 0x04007199 RID: 29081
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x0400719A RID: 29082
		private static readonly IntPtr NativeFieldInfoPtr__canUseUmbrella;

		// Token: 0x0400719B RID: 29083
		private static readonly IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x0400719C RID: 29084
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x0400719D RID: 29085
		private static readonly IntPtr NativeFieldInfoPtr_schedule;

		// Token: 0x0400719E RID: 29086
		private static readonly IntPtr NativeFieldInfoPtr_onEnded;

		// Token: 0x0400719F RID: 29087
		private static readonly IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x040071A0 RID: 29088
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040071A1 RID: 29089
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040071A2 RID: 29090
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Protected_get_String_0;

		// Token: 0x040071A3 RID: 29091
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEvent_Public_get_Boolean_0;

		// Token: 0x040071A4 RID: 29092
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSignal_Public_get_Boolean_0;

		// Token: 0x040071A5 RID: 29093
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x040071A6 RID: 29094
		private static readonly IntPtr NativeMethodInfoPtr_get_HasStarted_Public_get_Boolean_0;

		// Token: 0x040071A7 RID: 29095
		private static readonly IntPtr NativeMethodInfoPtr_set_HasStarted_Protected_set_Void_Boolean_0;

		// Token: 0x040071A8 RID: 29096
		private static readonly IntPtr NativeMethodInfoPtr_get_Priority_Public_Virtual_New_get_Int32_0;

		// Token: 0x040071A9 RID: 29097
		private static readonly IntPtr NativeMethodInfoPtr_get_movement_Protected_get_NPCMovement_0;

		// Token: 0x040071AA RID: 29098
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040071AB RID: 29099
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x040071AC RID: 29100
		private static readonly IntPtr NativeMethodInfoPtr_GetReferences_Private_Void_0;

		// Token: 0x040071AD RID: 29101
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x040071AE RID: 29102
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040071AF RID: 29103
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_New_Void_0;

		// Token: 0x040071B0 RID: 29104
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_New_Void_0;

		// Token: 0x040071B1 RID: 29105
		private static readonly IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_New_Void_0;

		// Token: 0x040071B2 RID: 29106
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_New_Void_0;

		// Token: 0x040071B3 RID: 29107
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_New_Void_0;

		// Token: 0x040071B4 RID: 29108
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0;

		// Token: 0x040071B5 RID: 29109
		private static readonly IntPtr NativeMethodInfoPtr_ResumeFailed_Public_Virtual_New_Void_0;

		// Token: 0x040071B6 RID: 29110
		private static readonly IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_New_Void_0;

		// Token: 0x040071B7 RID: 29111
		private static readonly IntPtr NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_New_Void_0;

		// Token: 0x040071B8 RID: 29112
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_New_Void_0;

		// Token: 0x040071B9 RID: 29113
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveMinPass_Public_Virtual_New_Void_0;

		// Token: 0x040071BA RID: 29114
		private static readonly IntPtr NativeMethodInfoPtr_PendingMinPassed_Public_Virtual_New_Void_0;

		// Token: 0x040071BB RID: 29115
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Public_Virtual_New_Void_0;

		// Token: 0x040071BC RID: 29116
		private static readonly IntPtr NativeMethodInfoPtr_ShouldStart_Public_Virtual_New_Boolean_0;

		// Token: 0x040071BD RID: 29117
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_0;

		// Token: 0x040071BE RID: 29118
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeDescription_Public_Abstract_Virtual_New_String_0;

		// Token: 0x040071BF RID: 29119
		private static readonly IntPtr NativeMethodInfoPtr_GetEndTime_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x040071C0 RID: 29120
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0;

		// Token: 0x040071C1 RID: 29121
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0;

		// Token: 0x040071C2 RID: 29122
		private static readonly IntPtr NativeMethodInfoPtr_SetStartTime_Public_Virtual_New_Void_Int32_0;

		// Token: 0x040071C3 RID: 29123
		private static readonly IntPtr NativeMethodInfoPtr_SetCanUseUmbrella_Protected_Void_Boolean_0;

		// Token: 0x040071C4 RID: 29124
		private static readonly IntPtr NativeMethodInfoPtr_OnStart_Protected_Virtual_New_Void_1;

		// Token: 0x040071C5 RID: 29125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040071C6 RID: 29126
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040071C7 RID: 29127
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040071C8 RID: 29128
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040071C9 RID: 29129
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}

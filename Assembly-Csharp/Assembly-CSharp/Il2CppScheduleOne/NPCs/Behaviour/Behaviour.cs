using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000656 RID: 1622
	public class Behaviour : NetworkBehaviour
	{
		// Token: 0x06009A6B RID: 39531 RVA: 0x00295160 File Offset: 0x00293360
		// Note: this type is marked as 'beforefieldinit'.
		static Behaviour()
		{
			Il2CppClassPointerStore<Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Behaviour>.NativeClassPtr);
			Behaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			Behaviour.NativeFieldInfoPtr_EnabledOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "EnabledOnAwake");
			Behaviour.NativeFieldInfoPtr__Enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<Enabled>k__BackingField");
			Behaviour.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "Name");
			Behaviour.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "Priority");
			Behaviour.NativeFieldInfoPtr__canUseUmbrellaDuringBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "_canUseUmbrellaDuringBehaviour");
			Behaviour.NativeFieldInfoPtr__Started_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<Started>k__BackingField");
			Behaviour.NativeFieldInfoPtr__Active_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<Active>k__BackingField");
			Behaviour.NativeFieldInfoPtr_BehaviourIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "BehaviourIndex");
			Behaviour.NativeFieldInfoPtr__beh_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "<beh>k__BackingField");
			Behaviour.NativeFieldInfoPtr_onEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onEnable");
			Behaviour.NativeFieldInfoPtr_onDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onDisable");
			Behaviour.NativeFieldInfoPtr_onBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onBegin");
			Behaviour.NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "onEnd");
			Behaviour.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "consecutivePathingFailures");
			Behaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted");
			Behaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BehaviourAssembly-CSharp.dll_Excuted");
			Behaviour.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683401);
			Behaviour.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683402);
			Behaviour.NativeMethodInfoPtr_get_Started_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683403);
			Behaviour.NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683404);
			Behaviour.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683405);
			Behaviour.NativeMethodInfoPtr_set_Active_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683406);
			Behaviour.NativeMethodInfoPtr_get_beh_Public_get_NPCBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683407);
			Behaviour.NativeMethodInfoPtr_set_beh_Private_set_Void_NPCBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683408);
			Behaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683409);
			Behaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683410);
			Behaviour.NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683411);
			Behaviour.NativeMethodInfoPtr_Enable_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683412);
			Behaviour.NativeMethodInfoPtr_Enable_Networked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683413);
			Behaviour.NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683414);
			Behaviour.NativeMethodInfoPtr_Disable_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683415);
			Behaviour.NativeMethodInfoPtr_Disable_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683416);
			Behaviour.NativeMethodInfoPtr_Activate_Server_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683417);
			Behaviour.NativeMethodInfoPtr_Activate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683418);
			Behaviour.NativeMethodInfoPtr_Deactivate_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683419);
			Behaviour.NativeMethodInfoPtr_Deactivate_Networked_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683420);
			Behaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683421);
			Behaviour.NativeMethodInfoPtr_Pause_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683422);
			Behaviour.NativeMethodInfoPtr_Pause_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683423);
			Behaviour.NativeMethodInfoPtr_Resume_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683424);
			Behaviour.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683425);
			Behaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683426);
			Behaviour.NativeMethodInfoPtr_BehaviourLateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683427);
			Behaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683428);
			Behaviour.NativeMethodInfoPtr_OnActiveUncappedMinutePass_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683429);
			Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683430);
			Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Virtual_New_Void_Vector3_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683431);
			Behaviour.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683432);
			Behaviour.NativeMethodInfoPtr_UpdateGameObjectName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683433);
			Behaviour.NativeMethodInfoPtr_SetCanUseUmbrellaDuringBehaviour_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683434);
			Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683435);
			Behaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683436);
			Behaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683437);
			Behaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683438);
			Behaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100683439);
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x06009A6C RID: 39532 RVA: 0x002955F0 File Offset: 0x002937F0
		// (set) Token: 0x06009A6D RID: 39533 RVA: 0x0029562C File Offset: 0x0029382C
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x06009A6E RID: 39534 RVA: 0x0029566C File Offset: 0x0029386C
		// (set) Token: 0x06009A6F RID: 39535 RVA: 0x002956A8 File Offset: 0x002938A8
		public unsafe bool Started
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Started_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x06009A70 RID: 39536 RVA: 0x002956E8 File Offset: 0x002938E8
		// (set) Token: 0x06009A71 RID: 39537 RVA: 0x00295724 File Offset: 0x00293924
		public unsafe bool Active
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_Active_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F45 RID: 12101
		// (get) Token: 0x06009A72 RID: 39538 RVA: 0x00295764 File Offset: 0x00293964
		// (set) Token: 0x06009A73 RID: 39539 RVA: 0x002957A4 File Offset: 0x002939A4
		public unsafe NPCBehaviour beh
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_beh_Public_get_NPCBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_beh_Private_set_Void_NPCBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002F46 RID: 12102
		// (get) Token: 0x06009A74 RID: 39540 RVA: 0x002957E8 File Offset: 0x002939E8
		public unsafe NPC Npc
		{
			[CallerCount(569)]
			[CachedScanResults(RefRangeStart = 274551, RefRangeEnd = 275120, XrefRangeStart = 274551, XrefRangeEnd = 274551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
		}

		// Token: 0x06009A75 RID: 39541 RVA: 0x00295828 File Offset: 0x00293A28
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 275124, RefRangeEnd = 275179, XrefRangeStart = 275120, XrefRangeEnd = 275124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A76 RID: 39542 RVA: 0x00295864 File Offset: 0x00293A64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 275187, RefRangeEnd = 275191, XrefRangeStart = 275179, XrefRangeEnd = 275187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A77 RID: 39543 RVA: 0x002958A0 File Offset: 0x00293AA0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 275193, RefRangeEnd = 275200, XrefRangeStart = 275191, XrefRangeEnd = 275193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Enable_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x002958D4 File Offset: 0x00293AD4
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 275203, RefRangeEnd = 275247, XrefRangeStart = 275200, XrefRangeEnd = 275203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable_Networked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Enable_Networked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A79 RID: 39545 RVA: 0x00295908 File Offset: 0x00293B08
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 275255, RefRangeEnd = 275276, XrefRangeStart = 275247, XrefRangeEnd = 275255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7A RID: 39546 RVA: 0x00295944 File Offset: 0x00293B44
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 275278, RefRangeEnd = 275294, XrefRangeStart = 275276, XrefRangeEnd = 275278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Disable_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7B RID: 39547 RVA: 0x00295978 File Offset: 0x00293B78
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 275297, RefRangeEnd = 275342, XrefRangeStart = 275294, XrefRangeEnd = 275297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Disable_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7C RID: 39548 RVA: 0x002959BC File Offset: 0x00293BBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275344, RefRangeEnd = 275346, XrefRangeStart = 275342, XrefRangeEnd = 275344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate_Server(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Activate_Server_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7D RID: 39549 RVA: 0x00295A00 File Offset: 0x00293C00
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 275358, RefRangeEnd = 275394, XrefRangeStart = 275346, XrefRangeEnd = 275358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Activate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7E RID: 39550 RVA: 0x00295A3C File Offset: 0x00293C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275394, XrefRangeEnd = 275396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Deactivate_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A7F RID: 39551 RVA: 0x00295A70 File Offset: 0x00293C70
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 275399, RefRangeEnd = 275414, XrefRangeStart = 275396, XrefRangeEnd = 275399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate_Networked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Deactivate_Networked_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x00295AB4 File Offset: 0x00293CB4
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 275429, RefRangeEnd = 275468, XrefRangeStart = 275414, XrefRangeEnd = 275429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A81 RID: 39553 RVA: 0x00295AF0 File Offset: 0x00293CF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275470, RefRangeEnd = 275471, XrefRangeStart = 275468, XrefRangeEnd = 275470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Pause_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A82 RID: 39554 RVA: 0x00295B24 File Offset: 0x00293D24
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 275485, RefRangeEnd = 275514, XrefRangeStart = 275471, XrefRangeEnd = 275485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Pause_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A83 RID: 39555 RVA: 0x00295B60 File Offset: 0x00293D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275516, RefRangeEnd = 275517, XrefRangeStart = 275514, XrefRangeEnd = 275516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_Resume_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A84 RID: 39556 RVA: 0x00295B94 File Offset: 0x00293D94
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 275529, RefRangeEnd = 275558, XrefRangeStart = 275517, XrefRangeEnd = 275529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A85 RID: 39557 RVA: 0x00295BD0 File Offset: 0x00293DD0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A86 RID: 39558 RVA: 0x00295C0C File Offset: 0x00293E0C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BehaviourLateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_BehaviourLateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A87 RID: 39559 RVA: 0x00295C48 File Offset: 0x00293E48
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A88 RID: 39560 RVA: 0x00295C84 File Offset: 0x00293E84
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnActiveUncappedMinutePass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_OnActiveUncappedMinutePass_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A89 RID: 39561 RVA: 0x00295CC0 File Offset: 0x00293EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275558, XrefRangeEnd = 275563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(ITransitEntity transitEntity, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transitEntity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref teleportIfFail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A8A RID: 39562 RVA: 0x00295D10 File Offset: 0x00293F10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275585, RefRangeEnd = 275586, XrefRangeStart = 275563, XrefRangeEnd = 275585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDestination(Vector3 position, bool teleportIfFail = true, float successThreshold = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref teleportIfFail;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref successThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_SetDestination_Protected_Virtual_New_Void_Vector3_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A8B RID: 39563 RVA: 0x00295D78 File Offset: 0x00293F78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275597, RefRangeEnd = 275599, XrefRangeStart = 275586, XrefRangeEnd = 275597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A8C RID: 39564 RVA: 0x00295DC4 File Offset: 0x00293FC4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateGameObjectName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_UpdateGameObjectName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A8D RID: 39565 RVA: 0x00295DF8 File Offset: 0x00293FF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 275600, RefRangeEnd = 275604, XrefRangeStart = 275599, XrefRangeEnd = 275600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanUseUmbrellaDuringBehaviour(bool canUse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref canUse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_SetCanUseUmbrellaDuringBehaviour_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A8E RID: 39566 RVA: 0x00295E38 File Offset: 0x00294038
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 275618, RefRangeEnd = 275665, XrefRangeStart = 275604, XrefRangeEnd = 275618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A8F RID: 39567 RVA: 0x00295E74 File Offset: 0x00294074
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 275665, RefRangeEnd = 275710, XrefRangeStart = 275665, XrefRangeEnd = 275665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A90 RID: 39568 RVA: 0x00295EB0 File Offset: 0x002940B0
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 275710, RefRangeEnd = 275755, XrefRangeStart = 275710, XrefRangeEnd = 275710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A91 RID: 39569 RVA: 0x00295EEC File Offset: 0x002940EC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A92 RID: 39570 RVA: 0x00295F28 File Offset: 0x00294128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275755, XrefRangeEnd = 275759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Behaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A93 RID: 39571 RVA: 0x00047E14 File Offset: 0x00046014
		public Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F31 RID: 12081
		// (get) Token: 0x06009A94 RID: 39572 RVA: 0x00295F64 File Offset: 0x00294164
		// (set) Token: 0x06009A95 RID: 39573 RVA: 0x00047E1D File Offset: 0x0004601D
		public unsafe static int MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Behaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Behaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x06009A96 RID: 39574 RVA: 0x00295F80 File Offset: 0x00294180
		// (set) Token: 0x06009A97 RID: 39575 RVA: 0x00047E2B File Offset: 0x0004602B
		public unsafe bool EnabledOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_EnabledOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_EnabledOnAwake)) = value;
			}
		}

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x06009A98 RID: 39576 RVA: 0x00295FA8 File Offset: 0x002941A8
		// (set) Token: 0x06009A99 RID: 39577 RVA: 0x00047E46 File Offset: 0x00046046
		public unsafe bool _Enabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Enabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Enabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x06009A9A RID: 39578 RVA: 0x00295FD0 File Offset: 0x002941D0
		// (set) Token: 0x06009A9B RID: 39579 RVA: 0x00047E61 File Offset: 0x00046061
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x06009A9C RID: 39580 RVA: 0x00295FF8 File Offset: 0x002941F8
		// (set) Token: 0x06009A9D RID: 39581 RVA: 0x00047E80 File Offset: 0x00046080
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x06009A9E RID: 39582 RVA: 0x00296020 File Offset: 0x00294220
		// (set) Token: 0x06009A9F RID: 39583 RVA: 0x00047E9B File Offset: 0x0004609B
		public unsafe bool _canUseUmbrellaDuringBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__canUseUmbrellaDuringBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__canUseUmbrellaDuringBehaviour)) = value;
			}
		}

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x06009AA0 RID: 39584 RVA: 0x00296048 File Offset: 0x00294248
		// (set) Token: 0x06009AA1 RID: 39585 RVA: 0x00047EB6 File Offset: 0x000460B6
		public unsafe bool _Started_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Started_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Started_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x06009AA2 RID: 39586 RVA: 0x00296070 File Offset: 0x00294270
		// (set) Token: 0x06009AA3 RID: 39587 RVA: 0x00047ED1 File Offset: 0x000460D1
		public unsafe bool _Active_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Active_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__Active_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F39 RID: 12089
		// (get) Token: 0x06009AA4 RID: 39588 RVA: 0x00296098 File Offset: 0x00294298
		// (set) Token: 0x06009AA5 RID: 39589 RVA: 0x00047EEC File Offset: 0x000460EC
		public unsafe int BehaviourIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_BehaviourIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_BehaviourIndex)) = value;
			}
		}

		// Token: 0x17002F3A RID: 12090
		// (get) Token: 0x06009AA6 RID: 39590 RVA: 0x002960C0 File Offset: 0x002942C0
		// (set) Token: 0x06009AA7 RID: 39591 RVA: 0x00047F07 File Offset: 0x00046107
		public unsafe NPCBehaviour _beh_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__beh_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr__beh_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3B RID: 12091
		// (get) Token: 0x06009AA8 RID: 39592 RVA: 0x002960F0 File Offset: 0x002942F0
		// (set) Token: 0x06009AA9 RID: 39593 RVA: 0x00047F26 File Offset: 0x00046126
		public unsafe UnityEvent onEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3C RID: 12092
		// (get) Token: 0x06009AAA RID: 39594 RVA: 0x00296120 File Offset: 0x00294320
		// (set) Token: 0x06009AAB RID: 39595 RVA: 0x00047F45 File Offset: 0x00046145
		public unsafe UnityEvent onDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onDisable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onDisable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3D RID: 12093
		// (get) Token: 0x06009AAC RID: 39596 RVA: 0x00296150 File Offset: 0x00294350
		// (set) Token: 0x06009AAD RID: 39597 RVA: 0x00047F64 File Offset: 0x00046164
		public unsafe UnityEvent onBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3E RID: 12094
		// (get) Token: 0x06009AAE RID: 39598 RVA: 0x00296180 File Offset: 0x00294380
		// (set) Token: 0x06009AAF RID: 39599 RVA: 0x00047F83 File Offset: 0x00046183
		public unsafe UnityEvent onEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_onEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F3F RID: 12095
		// (get) Token: 0x06009AB0 RID: 39600 RVA: 0x002961B0 File Offset: 0x002943B0
		// (set) Token: 0x06009AB1 RID: 39601 RVA: 0x00047FA2 File Offset: 0x000461A2
		public unsafe int consecutivePathingFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x17002F40 RID: 12096
		// (get) Token: 0x06009AB2 RID: 39602 RVA: 0x002961D8 File Offset: 0x002943D8
		// (set) Token: 0x06009AB3 RID: 39603 RVA: 0x00047FBD File Offset: 0x000461BD
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x06009AB4 RID: 39604 RVA: 0x00296200 File Offset: 0x00294400
		// (set) Token: 0x06009AB5 RID: 39605 RVA: 0x00047FD8 File Offset: 0x000461D8
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Behaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006A19 RID: 27161
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x04006A1A RID: 27162
		private static readonly IntPtr NativeFieldInfoPtr_EnabledOnAwake;

		// Token: 0x04006A1B RID: 27163
		private static readonly IntPtr NativeFieldInfoPtr__Enabled_k__BackingField;

		// Token: 0x04006A1C RID: 27164
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04006A1D RID: 27165
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04006A1E RID: 27166
		private static readonly IntPtr NativeFieldInfoPtr__canUseUmbrellaDuringBehaviour;

		// Token: 0x04006A1F RID: 27167
		private static readonly IntPtr NativeFieldInfoPtr__Started_k__BackingField;

		// Token: 0x04006A20 RID: 27168
		private static readonly IntPtr NativeFieldInfoPtr__Active_k__BackingField;

		// Token: 0x04006A21 RID: 27169
		private static readonly IntPtr NativeFieldInfoPtr_BehaviourIndex;

		// Token: 0x04006A22 RID: 27170
		private static readonly IntPtr NativeFieldInfoPtr__beh_k__BackingField;

		// Token: 0x04006A23 RID: 27171
		private static readonly IntPtr NativeFieldInfoPtr_onEnable;

		// Token: 0x04006A24 RID: 27172
		private static readonly IntPtr NativeFieldInfoPtr_onDisable;

		// Token: 0x04006A25 RID: 27173
		private static readonly IntPtr NativeFieldInfoPtr_onBegin;

		// Token: 0x04006A26 RID: 27174
		private static readonly IntPtr NativeFieldInfoPtr_onEnd;

		// Token: 0x04006A27 RID: 27175
		private static readonly IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x04006A28 RID: 27176
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006A29 RID: 27177
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006A2A RID: 27178
		private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_get_Boolean_0;

		// Token: 0x04006A2B RID: 27179
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Protected_set_Void_Boolean_0;

		// Token: 0x04006A2C RID: 27180
		private static readonly IntPtr NativeMethodInfoPtr_get_Started_Public_get_Boolean_0;

		// Token: 0x04006A2D RID: 27181
		private static readonly IntPtr NativeMethodInfoPtr_set_Started_Private_set_Void_Boolean_0;

		// Token: 0x04006A2E RID: 27182
		private static readonly IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;

		// Token: 0x04006A2F RID: 27183
		private static readonly IntPtr NativeMethodInfoPtr_set_Active_Private_set_Void_Boolean_0;

		// Token: 0x04006A30 RID: 27184
		private static readonly IntPtr NativeMethodInfoPtr_get_beh_Public_get_NPCBehaviour_0;

		// Token: 0x04006A31 RID: 27185
		private static readonly IntPtr NativeMethodInfoPtr_set_beh_Private_set_Void_NPCBehaviour_0;

		// Token: 0x04006A32 RID: 27186
		private static readonly IntPtr NativeMethodInfoPtr_get_Npc_Public_get_NPC_0;

		// Token: 0x04006A33 RID: 27187
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006A34 RID: 27188
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Virtual_New_Void_0;

		// Token: 0x04006A35 RID: 27189
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Server_Public_Void_0;

		// Token: 0x04006A36 RID: 27190
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Networked_Public_Void_0;

		// Token: 0x04006A37 RID: 27191
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_New_Void_0;

		// Token: 0x04006A38 RID: 27192
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Server_Public_Void_0;

		// Token: 0x04006A39 RID: 27193
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x04006A3A RID: 27194
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Server_Public_Void_NetworkConnection_0;

		// Token: 0x04006A3B RID: 27195
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_New_Void_0;

		// Token: 0x04006A3C RID: 27196
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Server_Public_Void_0;

		// Token: 0x04006A3D RID: 27197
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Networked_Public_Void_NetworkConnection_0;

		// Token: 0x04006A3E RID: 27198
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_New_Void_0;

		// Token: 0x04006A3F RID: 27199
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Server_Public_Void_0;

		// Token: 0x04006A40 RID: 27200
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_New_Void_0;

		// Token: 0x04006A41 RID: 27201
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Server_Public_Void_0;

		// Token: 0x04006A42 RID: 27202
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0;

		// Token: 0x04006A43 RID: 27203
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04006A44 RID: 27204
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourLateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04006A45 RID: 27205
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_New_Void_0;

		// Token: 0x04006A46 RID: 27206
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveUncappedMinutePass_Public_Virtual_New_Void_0;

		// Token: 0x04006A47 RID: 27207
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0;

		// Token: 0x04006A48 RID: 27208
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Protected_Virtual_New_Void_Vector3_Boolean_Single_0;

		// Token: 0x04006A49 RID: 27209
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0;

		// Token: 0x04006A4A RID: 27210
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGameObjectName_Private_Void_0;

		// Token: 0x04006A4B RID: 27211
		private static readonly IntPtr NativeMethodInfoPtr_SetCanUseUmbrellaDuringBehaviour_Public_Void_Boolean_0;

		// Token: 0x04006A4C RID: 27212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006A4D RID: 27213
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006A4E RID: 27214
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006A4F RID: 27215
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006A50 RID: 27216
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}

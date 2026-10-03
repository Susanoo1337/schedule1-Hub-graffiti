using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000667 RID: 1639
	public class GrowContainerBehaviour : Behaviour
	{
		// Token: 0x06009D26 RID: 40230 RVA: 0x0029F6C4 File Offset: 0x0029D8C4
		// Note: this type is marked as 'beforefieldinit'.
		static GrowContainerBehaviour()
		{
			Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "GrowContainerBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr);
			GrowContainerBehaviour.NativeFieldInfoPtr___growContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, "<_growContainer>k__BackingField");
			GrowContainerBehaviour.NativeFieldInfoPtr___currentState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, "<_currentState>k__BackingField");
			GrowContainerBehaviour.NativeFieldInfoPtr___botanist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, "<_botanist>k__BackingField");
			GrowContainerBehaviour.NativeFieldInfoPtr__walkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, "_walkRoutine");
			GrowContainerBehaviour.NativeFieldInfoPtr__grabRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, "_grabRoutine");
			GrowContainerBehaviour.NativeFieldInfoPtr__performActionRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, "_performActionRoutine");
			GrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.GrowContainerBehaviourAssembly-CSharp.dll_Excuted");
			GrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.GrowContainerBehaviourAssembly-CSharp.dll_Excuted");
			GrowContainerBehaviour.NativeMethodInfoPtr_get__growContainer_Protected_get_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683875);
			GrowContainerBehaviour.NativeMethodInfoPtr_set__growContainer_Private_set_Void_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683876);
			GrowContainerBehaviour.NativeMethodInfoPtr_get__currentState_Protected_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683877);
			GrowContainerBehaviour.NativeMethodInfoPtr_set__currentState_Private_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683878);
			GrowContainerBehaviour.NativeMethodInfoPtr_get__botanist_Protected_get_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683879);
			GrowContainerBehaviour.NativeMethodInfoPtr_set__botanist_Private_set_Void_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683880);
			GrowContainerBehaviour.NativeMethodInfoPtr_get__botanistConfiguration_Protected_get_BotanistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683881);
			GrowContainerBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683882);
			GrowContainerBehaviour.NativeMethodInfoPtr_AssignAndEnable_Public_Virtual_New_Void_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683883);
			GrowContainerBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683884);
			GrowContainerBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683885);
			GrowContainerBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683886);
			GrowContainerBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683887);
			GrowContainerBehaviour.NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_New_Boolean_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683888);
			GrowContainerBehaviour.NativeMethodInfoPtr_DoesBotanistHaveAccessToRequiredSupplies_Public_Boolean_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683889);
			GrowContainerBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683890);
			GrowContainerBehaviour.NativeMethodInfoPtr_OnStartPerformAction_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683891);
			GrowContainerBehaviour.NativeMethodInfoPtr_OnStopPerformAction_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683892);
			GrowContainerBehaviour.NativeMethodInfoPtr_GetGrowContainerLookPoint_Protected_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683893);
			GrowContainerBehaviour.NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_New_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683894);
			GrowContainerBehaviour.NativeMethodInfoPtr_GetTrashPrefab_Protected_Virtual_New_TrashItem_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683895);
			GrowContainerBehaviour.NativeMethodInfoPtr_OnActionSuccess_Protected_Abstract_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683896);
			GrowContainerBehaviour.NativeMethodInfoPtr_GetAnimationBool_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683897);
			GrowContainerBehaviour.NativeMethodInfoPtr_GetActionDuration_Protected_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683898);
			GrowContainerBehaviour.NativeMethodInfoPtr_WalkTo_Private_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683899);
			GrowContainerBehaviour.NativeMethodInfoPtr_GrabRequiredItemFromSupplies_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683900);
			GrowContainerBehaviour.NativeMethodInfoPtr_PerformAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683901);
			GrowContainerBehaviour.NativeMethodInfoPtr_CheckSuccess_Protected_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683902);
			GrowContainerBehaviour.NativeMethodInfoPtr_StopAllRoutines_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683903);
			GrowContainerBehaviour.NativeMethodInfoPtr_GetRequiredItemSuitableIDs_Protected_Virtual_New_Il2CppStringArray_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683904);
			GrowContainerBehaviour.NativeMethodInfoPtr_DoesTaskRequireItem_Private_Boolean_GrowContainer_byref_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683905);
			GrowContainerBehaviour.NativeMethodInfoPtr_IsRequiredItemInInventory_Private_Boolean_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683906);
			GrowContainerBehaviour.NativeMethodInfoPtr_DoSuppliesContainRequiredItem_Private_Boolean_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683907);
			GrowContainerBehaviour.NativeMethodInfoPtr_GetSuppliesSlotContainingRequiredItem_Private_ItemSlot_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683908);
			GrowContainerBehaviour.NativeMethodInfoPtr_GetItemSlotContainingRequiredItem_Protected_ItemSlot_IItemSlotOwner_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683909);
			GrowContainerBehaviour.NativeMethodInfoPtr_IsAtSupplies_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683910);
			GrowContainerBehaviour.NativeMethodInfoPtr_IsAtGrowContainer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683911);
			GrowContainerBehaviour.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683912);
			GrowContainerBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683913);
			GrowContainerBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683914);
			GrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683915);
			GrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683916);
			GrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683917);
			GrowContainerBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, 100683918);
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x06009D27 RID: 40231 RVA: 0x0029FB04 File Offset: 0x0029DD04
		// (set) Token: 0x06009D28 RID: 40232 RVA: 0x0029FB44 File Offset: 0x0029DD44
		public unsafe GrowContainer _growContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_get__growContainer_Protected_get_GrowContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GrowContainer>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_set__growContainer_Private_set_Void_GrowContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x06009D29 RID: 40233 RVA: 0x0029FB88 File Offset: 0x0029DD88
		// (set) Token: 0x06009D2A RID: 40234 RVA: 0x0029FBC4 File Offset: 0x0029DDC4
		public unsafe GrowContainerBehaviour.EState _currentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_get__currentState_Protected_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_set__currentState_Private_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x06009D2B RID: 40235 RVA: 0x0029FC04 File Offset: 0x0029DE04
		// (set) Token: 0x06009D2C RID: 40236 RVA: 0x0029FC44 File Offset: 0x0029DE44
		public unsafe Botanist _botanist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_get__botanist_Protected_get_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_set__botanist_Private_set_Void_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x06009D2D RID: 40237 RVA: 0x0029FC88 File Offset: 0x0029DE88
		public unsafe BotanistConfiguration _botanistConfiguration
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 279092, RefRangeEnd = 279098, XrefRangeStart = 279089, XrefRangeEnd = 279092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_get__botanistConfiguration_Protected_get_BotanistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BotanistConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x06009D2E RID: 40238 RVA: 0x0029FCC8 File Offset: 0x0029DEC8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 279103, RefRangeEnd = 279113, XrefRangeStart = 279098, XrefRangeEnd = 279103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D2F RID: 40239 RVA: 0x0029FD04 File Offset: 0x0029DF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279113, XrefRangeEnd = 279115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignAndEnable(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_AssignAndEnable_Public_Virtual_New_Void_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D30 RID: 40240 RVA: 0x0029FD54 File Offset: 0x0029DF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279115, XrefRangeEnd = 279116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D31 RID: 40241 RVA: 0x0029FD90 File Offset: 0x0029DF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279116, XrefRangeEnd = 279117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D32 RID: 40242 RVA: 0x0029FDCC File Offset: 0x0029DFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279117, XrefRangeEnd = 279119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D33 RID: 40243 RVA: 0x0029FE08 File Offset: 0x0029E008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279119, XrefRangeEnd = 279121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D34 RID: 40244 RVA: 0x0029FE44 File Offset: 0x0029E044
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 279130, RefRangeEnd = 279137, XrefRangeStart = 279121, XrefRangeEnd = 279130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_New_Boolean_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D35 RID: 40245 RVA: 0x0029FE9C File Offset: 0x0029E09C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 279138, RefRangeEnd = 279142, XrefRangeStart = 279137, XrefRangeEnd = 279138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesBotanistHaveAccessToRequiredSupplies(GrowContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_DoesBotanistHaveAccessToRequiredSupplies_Public_Boolean_GrowContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D36 RID: 40246 RVA: 0x0029FEEC File Offset: 0x0029E0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279142, XrefRangeEnd = 279169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D37 RID: 40247 RVA: 0x0029FF28 File Offset: 0x0029E128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279185, RefRangeEnd = 279186, XrefRangeStart = 279169, XrefRangeEnd = 279185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartPerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_OnStartPerformAction_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D38 RID: 40248 RVA: 0x0029FF64 File Offset: 0x0029E164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279199, RefRangeEnd = 279200, XrefRangeStart = 279186, XrefRangeEnd = 279199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStopPerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_OnStopPerformAction_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D39 RID: 40249 RVA: 0x0029FFA0 File Offset: 0x0029E1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279200, XrefRangeEnd = 279201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 GetGrowContainerLookPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_GetGrowContainerLookPoint_Protected_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D3A RID: 40250 RVA: 0x0029FFE8 File Offset: 0x0029E1E8
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AvatarEquippable GetActionEquippable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_New_AvatarEquippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
		}

		// Token: 0x06009D3B RID: 40251 RVA: 0x002A0034 File Offset: 0x0029E234
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TrashItem GetTrashPrefab(ItemInstance usedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(usedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_GetTrashPrefab_Protected_Virtual_New_TrashItem_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x06009D3C RID: 40252 RVA: 0x002A0090 File Offset: 0x0029E290
		[CallerCount(0)]
		public unsafe virtual void OnActionSuccess(ItemInstance usedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(usedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_OnActionSuccess_Protected_Abstract_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D3D RID: 40253 RVA: 0x002A00E0 File Offset: 0x0029E2E0
		[CallerCount(0)]
		public unsafe virtual string GetAnimationBool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_GetAnimationBool_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009D3E RID: 40254 RVA: 0x002A0124 File Offset: 0x0029E324
		[CallerCount(0)]
		public unsafe virtual float GetActionDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_GetActionDuration_Protected_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D3F RID: 40255 RVA: 0x002A016C File Offset: 0x0029E36C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279217, RefRangeEnd = 279218, XrefRangeStart = 279201, XrefRangeEnd = 279217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkTo(ITransitEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_WalkTo_Private_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D40 RID: 40256 RVA: 0x002A01B0 File Offset: 0x0029E3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279218, XrefRangeEnd = 279225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabRequiredItemFromSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_GrabRequiredItemFromSupplies_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D41 RID: 40257 RVA: 0x002A01E4 File Offset: 0x0029E3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279225, XrefRangeEnd = 279233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_PerformAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D42 RID: 40258 RVA: 0x002A0218 File Offset: 0x0029E418
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckSuccess(ItemInstance usedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(usedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_CheckSuccess_Protected_Virtual_New_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D43 RID: 40259 RVA: 0x002A0270 File Offset: 0x0029E470
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279239, RefRangeEnd = 279241, XrefRangeStart = 279233, XrefRangeEnd = 279239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllRoutines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_StopAllRoutines_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D44 RID: 40260 RVA: 0x002A02A4 File Offset: 0x0029E4A4
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStringArray GetRequiredItemSuitableIDs(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_GetRequiredItemSuitableIDs_Protected_Virtual_New_Il2CppStringArray_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06009D45 RID: 40261 RVA: 0x002A0300 File Offset: 0x0029E500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279241, XrefRangeEnd = 279242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesTaskRequireItem(GrowContainer growContainer, out Il2CppStringArray suitableItemIDs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_DoesTaskRequireItem_Private_Boolean_GrowContainer_byref_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			suitableItemIDs = ((intPtr4 == 0) ? null : new Il2CppStringArray(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06009D46 RID: 40262 RVA: 0x002A0370 File Offset: 0x0029E570
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279249, RefRangeEnd = 279251, XrefRangeStart = 279242, XrefRangeEnd = 279249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRequiredItemInInventory(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_IsRequiredItemInInventory_Private_Boolean_GrowContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D47 RID: 40263 RVA: 0x002A03C0 File Offset: 0x0029E5C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279267, RefRangeEnd = 279268, XrefRangeStart = 279251, XrefRangeEnd = 279267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoSuppliesContainRequiredItem(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_DoSuppliesContainRequiredItem_Private_Boolean_GrowContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D48 RID: 40264 RVA: 0x002A0410 File Offset: 0x0029E610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279268, XrefRangeEnd = 279277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlot GetSuppliesSlotContainingRequiredItem(Il2CppStringArray suitableItemIDs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(suitableItemIDs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_GetSuppliesSlotContainingRequiredItem_Private_ItemSlot_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x06009D49 RID: 40265 RVA: 0x002A0460 File Offset: 0x0029E660
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 279282, RefRangeEnd = 279286, XrefRangeStart = 279277, XrefRangeEnd = 279282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlot GetItemSlotContainingRequiredItem(IItemSlotOwner itemSlotOwner, Il2CppStringArray suitableItemIDs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlotOwner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(suitableItemIDs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_GetItemSlotContainingRequiredItem_Protected_ItemSlot_IItemSlotOwner_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x002A04C4 File Offset: 0x0029E6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279286, XrefRangeEnd = 279293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_IsAtSupplies_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D4B RID: 40267 RVA: 0x002A0500 File Offset: 0x0029E700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279293, XrefRangeEnd = 279302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtGrowContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_IsAtGrowContainer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D4C RID: 40268 RVA: 0x002A053C File Offset: 0x0029E73C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276250, RefRangeEnd = 276252, XrefRangeStart = 276250, XrefRangeEnd = 276252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrowContainerBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D4D RID: 40269 RVA: 0x002A0578 File Offset: 0x0029E778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279302, XrefRangeEnd = 279307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009D4E RID: 40270 RVA: 0x002A05B8 File Offset: 0x0029E7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279307, XrefRangeEnd = 279312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009D4F RID: 40271 RVA: 0x002A05F8 File Offset: 0x0029E7F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279313, RefRangeEnd = 279315, XrefRangeStart = 279312, XrefRangeEnd = 279313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D50 RID: 40272 RVA: 0x002A0634 File Offset: 0x0029E834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279316, RefRangeEnd = 279318, XrefRangeStart = 279315, XrefRangeEnd = 279316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D51 RID: 40273 RVA: 0x002A0670 File Offset: 0x0029E870
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D52 RID: 40274 RVA: 0x002A06AC File Offset: 0x0029E8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279318, XrefRangeEnd = 279323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainerBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D53 RID: 40275 RVA: 0x00048C48 File Offset: 0x00046E48
		public GrowContainerBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x06009D54 RID: 40276 RVA: 0x002A06E8 File Offset: 0x0029E8E8
		// (set) Token: 0x06009D55 RID: 40277 RVA: 0x00048C51 File Offset: 0x00046E51
		public unsafe GrowContainer __growContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr___growContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr___growContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x06009D56 RID: 40278 RVA: 0x002A0718 File Offset: 0x0029E918
		// (set) Token: 0x06009D57 RID: 40279 RVA: 0x00048C70 File Offset: 0x00046E70
		public unsafe GrowContainerBehaviour.EState __currentState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr___currentState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr___currentState_k__BackingField)) = value;
			}
		}

		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x06009D58 RID: 40280 RVA: 0x002A0740 File Offset: 0x0029E940
		// (set) Token: 0x06009D59 RID: 40281 RVA: 0x00048C8B File Offset: 0x00046E8B
		public unsafe Botanist __botanist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr___botanist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr___botanist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x06009D5A RID: 40282 RVA: 0x002A0770 File Offset: 0x0029E970
		// (set) Token: 0x06009D5B RID: 40283 RVA: 0x00048CAA File Offset: 0x00046EAA
		public unsafe Coroutine _walkRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr__walkRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr__walkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x06009D5C RID: 40284 RVA: 0x002A07A0 File Offset: 0x0029E9A0
		// (set) Token: 0x06009D5D RID: 40285 RVA: 0x00048CC9 File Offset: 0x00046EC9
		public unsafe Coroutine _grabRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr__grabRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr__grabRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x06009D5E RID: 40286 RVA: 0x002A07D0 File Offset: 0x0029E9D0
		// (set) Token: 0x06009D5F RID: 40287 RVA: 0x00048CE8 File Offset: 0x00046EE8
		public unsafe Coroutine _performActionRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr__performActionRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr__performActionRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x06009D60 RID: 40288 RVA: 0x002A0800 File Offset: 0x0029EA00
		// (set) Token: 0x06009D61 RID: 40289 RVA: 0x00048D07 File Offset: 0x00046F07
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x06009D62 RID: 40290 RVA: 0x002A0828 File Offset: 0x0029EA28
		// (set) Token: 0x06009D63 RID: 40291 RVA: 0x00048D22 File Offset: 0x00046F22
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006C30 RID: 27696
		private static readonly IntPtr NativeFieldInfoPtr___growContainer_k__BackingField;

		// Token: 0x04006C31 RID: 27697
		private static readonly IntPtr NativeFieldInfoPtr___currentState_k__BackingField;

		// Token: 0x04006C32 RID: 27698
		private static readonly IntPtr NativeFieldInfoPtr___botanist_k__BackingField;

		// Token: 0x04006C33 RID: 27699
		private static readonly IntPtr NativeFieldInfoPtr__walkRoutine;

		// Token: 0x04006C34 RID: 27700
		private static readonly IntPtr NativeFieldInfoPtr__grabRoutine;

		// Token: 0x04006C35 RID: 27701
		private static readonly IntPtr NativeFieldInfoPtr__performActionRoutine;

		// Token: 0x04006C36 RID: 27702
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006C37 RID: 27703
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006C38 RID: 27704
		private static readonly IntPtr NativeMethodInfoPtr_get__growContainer_Protected_get_GrowContainer_0;

		// Token: 0x04006C39 RID: 27705
		private static readonly IntPtr NativeMethodInfoPtr_set__growContainer_Private_set_Void_GrowContainer_0;

		// Token: 0x04006C3A RID: 27706
		private static readonly IntPtr NativeMethodInfoPtr_get__currentState_Protected_get_EState_0;

		// Token: 0x04006C3B RID: 27707
		private static readonly IntPtr NativeMethodInfoPtr_set__currentState_Private_set_Void_EState_0;

		// Token: 0x04006C3C RID: 27708
		private static readonly IntPtr NativeMethodInfoPtr_get__botanist_Protected_get_Botanist_0;

		// Token: 0x04006C3D RID: 27709
		private static readonly IntPtr NativeMethodInfoPtr_set__botanist_Private_set_Void_Botanist_0;

		// Token: 0x04006C3E RID: 27710
		private static readonly IntPtr NativeMethodInfoPtr_get__botanistConfiguration_Protected_get_BotanistConfiguration_0;

		// Token: 0x04006C3F RID: 27711
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006C40 RID: 27712
		private static readonly IntPtr NativeMethodInfoPtr_AssignAndEnable_Public_Virtual_New_Void_GrowContainer_0;

		// Token: 0x04006C41 RID: 27713
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04006C42 RID: 27714
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04006C43 RID: 27715
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x04006C44 RID: 27716
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04006C45 RID: 27717
		private static readonly IntPtr NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_New_Boolean_GrowContainer_0;

		// Token: 0x04006C46 RID: 27718
		private static readonly IntPtr NativeMethodInfoPtr_DoesBotanistHaveAccessToRequiredSupplies_Public_Boolean_GrowContainer_0;

		// Token: 0x04006C47 RID: 27719
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x04006C48 RID: 27720
		private static readonly IntPtr NativeMethodInfoPtr_OnStartPerformAction_Protected_Virtual_New_Void_0;

		// Token: 0x04006C49 RID: 27721
		private static readonly IntPtr NativeMethodInfoPtr_OnStopPerformAction_Protected_Virtual_New_Void_0;

		// Token: 0x04006C4A RID: 27722
		private static readonly IntPtr NativeMethodInfoPtr_GetGrowContainerLookPoint_Protected_Virtual_New_Vector3_0;

		// Token: 0x04006C4B RID: 27723
		private static readonly IntPtr NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_New_AvatarEquippable_0;

		// Token: 0x04006C4C RID: 27724
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashPrefab_Protected_Virtual_New_TrashItem_ItemInstance_0;

		// Token: 0x04006C4D RID: 27725
		private static readonly IntPtr NativeMethodInfoPtr_OnActionSuccess_Protected_Abstract_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04006C4E RID: 27726
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationBool_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x04006C4F RID: 27727
		private static readonly IntPtr NativeMethodInfoPtr_GetActionDuration_Protected_Abstract_Virtual_New_Single_0;

		// Token: 0x04006C50 RID: 27728
		private static readonly IntPtr NativeMethodInfoPtr_WalkTo_Private_Void_ITransitEntity_0;

		// Token: 0x04006C51 RID: 27729
		private static readonly IntPtr NativeMethodInfoPtr_GrabRequiredItemFromSupplies_Private_Void_0;

		// Token: 0x04006C52 RID: 27730
		private static readonly IntPtr NativeMethodInfoPtr_PerformAction_Private_Void_0;

		// Token: 0x04006C53 RID: 27731
		private static readonly IntPtr NativeMethodInfoPtr_CheckSuccess_Protected_Virtual_New_Boolean_ItemInstance_0;

		// Token: 0x04006C54 RID: 27732
		private static readonly IntPtr NativeMethodInfoPtr_StopAllRoutines_Private_Void_0;

		// Token: 0x04006C55 RID: 27733
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredItemSuitableIDs_Protected_Virtual_New_Il2CppStringArray_GrowContainer_0;

		// Token: 0x04006C56 RID: 27734
		private static readonly IntPtr NativeMethodInfoPtr_DoesTaskRequireItem_Private_Boolean_GrowContainer_byref_Il2CppStringArray_0;

		// Token: 0x04006C57 RID: 27735
		private static readonly IntPtr NativeMethodInfoPtr_IsRequiredItemInInventory_Private_Boolean_GrowContainer_0;

		// Token: 0x04006C58 RID: 27736
		private static readonly IntPtr NativeMethodInfoPtr_DoSuppliesContainRequiredItem_Private_Boolean_GrowContainer_0;

		// Token: 0x04006C59 RID: 27737
		private static readonly IntPtr NativeMethodInfoPtr_GetSuppliesSlotContainingRequiredItem_Private_ItemSlot_Il2CppStringArray_0;

		// Token: 0x04006C5A RID: 27738
		private static readonly IntPtr NativeMethodInfoPtr_GetItemSlotContainingRequiredItem_Protected_ItemSlot_IItemSlotOwner_Il2CppStringArray_0;

		// Token: 0x04006C5B RID: 27739
		private static readonly IntPtr NativeMethodInfoPtr_IsAtSupplies_Private_Boolean_0;

		// Token: 0x04006C5C RID: 27740
		private static readonly IntPtr NativeMethodInfoPtr_IsAtGrowContainer_Private_Boolean_0;

		// Token: 0x04006C5D RID: 27741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04006C5E RID: 27742
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006C5F RID: 27743
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04006C60 RID: 27744
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006C61 RID: 27745
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006C62 RID: 27746
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006C63 RID: 27747
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000C4F RID: 3151
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x0400A296 RID: 41622
			Idle,
			// Token: 0x0400A297 RID: 41623
			Walking,
			// Token: 0x0400A298 RID: 41624
			GrabbingSupplies,
			// Token: 0x0400A299 RID: 41625
			PerformingAction
		}

		// Token: 0x02000C50 RID: 3152
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.GrowContainerBehaviour+<<GrabRequiredItemFromSupplies>g__Routine|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F030 RID: 61488 RVA: 0x0039FFC0 File Offset: 0x0039E1C0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique()
			{
				Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, "<<GrabRequiredItemFromSupplies>g__Routine|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr, "<>1__state");
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr, "<>2__current");
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr, "<>4__this");
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr, 100683919);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr, 100683920);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr, 100683921);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr, 100683922);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr, 100683923);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr, 100683924);
			}

			// Token: 0x0600F031 RID: 61489 RVA: 0x003A00A0 File Offset: 0x0039E2A0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F032 RID: 61490 RVA: 0x003A00E8 File Offset: 0x0039E2E8
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F033 RID: 61491 RVA: 0x003A011C File Offset: 0x0039E31C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279003, XrefRangeEnd = 279025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048DB RID: 18651
			// (get) Token: 0x0600F034 RID: 61492 RVA: 0x003A0158 File Offset: 0x0039E358
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F035 RID: 61493 RVA: 0x003A0198 File Offset: 0x0039E398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279025, XrefRangeEnd = 279030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048DC RID: 18652
			// (get) Token: 0x0600F036 RID: 61494 RVA: 0x003A01CC File Offset: 0x0039E3CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F037 RID: 61495 RVA: 0x0007159A File Offset: 0x0006F79A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048D8 RID: 18648
			// (get) Token: 0x0600F038 RID: 61496 RVA: 0x003A020C File Offset: 0x0039E40C
			// (set) Token: 0x0600F039 RID: 61497 RVA: 0x000715A3 File Offset: 0x0006F7A3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048D9 RID: 18649
			// (get) Token: 0x0600F03A RID: 61498 RVA: 0x003A0234 File Offset: 0x0039E434
			// (set) Token: 0x0600F03B RID: 61499 RVA: 0x000715BE File Offset: 0x0006F7BE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048DA RID: 18650
			// (get) Token: 0x0600F03C RID: 61500 RVA: 0x003A0264 File Offset: 0x0039E464
			// (set) Token: 0x0600F03D RID: 61501 RVA: 0x000715DD File Offset: 0x0006F7DD
			public unsafe GrowContainerBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainerBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A29A RID: 41626
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A29B RID: 41627
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A29C RID: 41628
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A29D RID: 41629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A29E RID: 41630
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A29F RID: 41631
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A2A0 RID: 41632
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A2A1 RID: 41633
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A2A2 RID: 41634
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C51 RID: 3153
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.GrowContainerBehaviour+<<PerformAction>g__Routine|37_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F03E RID: 61502 RVA: 0x003A0294 File Offset: 0x0039E494
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique()
			{
				Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, "<<PerformAction>g__Routine|37_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr, "<>1__state");
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr, "<>2__current");
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr, "<>4__this");
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr__waitTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr, "<waitTime>5__2");
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr, 100683925);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr, 100683926);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr, 100683927);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr, 100683928);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr, 100683929);
				GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr, 100683930);
			}

			// Token: 0x0600F03F RID: 61503 RVA: 0x003A039C File Offset: 0x0039E59C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F040 RID: 61504 RVA: 0x003A03E4 File Offset: 0x0039E5E4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F041 RID: 61505 RVA: 0x003A0418 File Offset: 0x0039E618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279030, XrefRangeEnd = 279067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048E2 RID: 18658
			// (get) Token: 0x0600F042 RID: 61506 RVA: 0x003A0454 File Offset: 0x0039E654
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F043 RID: 61507 RVA: 0x003A0494 File Offset: 0x0039E694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279067, XrefRangeEnd = 279072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048E3 RID: 18659
			// (get) Token: 0x0600F044 RID: 61508 RVA: 0x003A04C8 File Offset: 0x0039E6C8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F045 RID: 61509 RVA: 0x000715FC File Offset: 0x0006F7FC
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048DD RID: 18653
			// (get) Token: 0x0600F046 RID: 61510 RVA: 0x003A0508 File Offset: 0x0039E708
			// (set) Token: 0x0600F047 RID: 61511 RVA: 0x00071605 File Offset: 0x0006F805
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048DE RID: 18654
			// (get) Token: 0x0600F048 RID: 61512 RVA: 0x003A0530 File Offset: 0x0039E730
			// (set) Token: 0x0600F049 RID: 61513 RVA: 0x00071620 File Offset: 0x0006F820
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048DF RID: 18655
			// (get) Token: 0x0600F04A RID: 61514 RVA: 0x003A0560 File Offset: 0x0039E760
			// (set) Token: 0x0600F04B RID: 61515 RVA: 0x0007163F File Offset: 0x0006F83F
			public unsafe GrowContainerBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainerBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048E0 RID: 18656
			// (get) Token: 0x0600F04C RID: 61516 RVA: 0x003A0590 File Offset: 0x0039E790
			// (set) Token: 0x0600F04D RID: 61517 RVA: 0x0007165E File Offset: 0x0006F85E
			public unsafe float _waitTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr__waitTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr__waitTime_5__2)) = value;
				}
			}

			// Token: 0x170048E1 RID: 18657
			// (get) Token: 0x0600F04E RID: 61518 RVA: 0x003A05B8 File Offset: 0x0039E7B8
			// (set) Token: 0x0600F04F RID: 61519 RVA: 0x00071679 File Offset: 0x0006F879
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400A2A3 RID: 41635
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A2A4 RID: 41636
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A2A5 RID: 41637
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A2A6 RID: 41638
			private static readonly IntPtr NativeFieldInfoPtr__waitTime_5__2;

			// Token: 0x0400A2A7 RID: 41639
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400A2A8 RID: 41640
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A2A9 RID: 41641
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A2AA RID: 41642
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A2AB RID: 41643
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A2AC RID: 41644
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A2AD RID: 41645
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C52 RID: 3154
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.GrowContainerBehaviour+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F050 RID: 61520 RVA: 0x003A05E0 File Offset: 0x0039E7E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrowContainerBehaviour>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0>.NativeClassPtr);
				GrowContainerBehaviour.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				GrowContainerBehaviour.__c__DisplayClass35_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0>.NativeClassPtr, "entity");
				GrowContainerBehaviour.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0>.NativeClassPtr, 100683931);
				GrowContainerBehaviour.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0>.NativeClassPtr, 100683932);
				GrowContainerBehaviour.__c__DisplayClass35_0.NativeMethodInfoPtr__WalkTo_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0>.NativeClassPtr, 100683933);
			}

			// Token: 0x0600F051 RID: 61521 RVA: 0x003A0670 File Offset: 0x0039E870
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F052 RID: 61522 RVA: 0x003A06AC File Offset: 0x0039E8AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279082, XrefRangeEnd = 279087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F053 RID: 61523 RVA: 0x003A06EC File Offset: 0x0039E8EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279087, XrefRangeEnd = 279089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _WalkTo_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.__c__DisplayClass35_0.NativeMethodInfoPtr__WalkTo_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F054 RID: 61524 RVA: 0x00071694 File Offset: 0x0006F894
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048E4 RID: 18660
			// (get) Token: 0x0600F055 RID: 61525 RVA: 0x003A0728 File Offset: 0x0039E928
			// (set) Token: 0x0600F056 RID: 61526 RVA: 0x0007169D File Offset: 0x0006F89D
			public unsafe GrowContainerBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainerBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048E5 RID: 18661
			// (get) Token: 0x0600F057 RID: 61527 RVA: 0x003A0758 File Offset: 0x0039E958
			// (set) Token: 0x0600F058 RID: 61528 RVA: 0x000716BC File Offset: 0x0006F8BC
			public unsafe ITransitEntity entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.__c__DisplayClass35_0.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.__c__DisplayClass35_0.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A2AE RID: 41646
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A2AF RID: 41647
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x0400A2B0 RID: 41648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A2B1 RID: 41649
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400A2B2 RID: 41650
			private static readonly IntPtr NativeMethodInfoPtr__WalkTo_b__1_Internal_Boolean_0;

			// Token: 0x02000DFE RID: 3582
			[ObfuscatedName("ScheduleOne.NPCs.Behaviour.GrowContainerBehaviour+<>c__DisplayClass35_0+<<WalkTo>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601022A RID: 66090 RVA: 0x003D4234 File Offset: 0x003D2434
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0>.NativeClassPtr, "<<WalkTo>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683934);
					GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683935);
					GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683936);
					GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683937);
					GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683938);
					GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683939);
				}

				// Token: 0x0601022B RID: 66091 RVA: 0x003D4314 File Offset: 0x003D2514
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601022C RID: 66092 RVA: 0x003D435C File Offset: 0x003D255C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601022D RID: 66093 RVA: 0x003D4390 File Offset: 0x003D2590
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279072, XrefRangeEnd = 279077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004ECB RID: 20171
				// (get) Token: 0x0601022E RID: 66094 RVA: 0x003D43CC File Offset: 0x003D25CC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601022F RID: 66095 RVA: 0x003D440C File Offset: 0x003D260C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279077, XrefRangeEnd = 279082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004ECC RID: 20172
				// (get) Token: 0x06010230 RID: 66096 RVA: 0x003D4440 File Offset: 0x003D2640
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010231 RID: 66097 RVA: 0x0007A616 File Offset: 0x00078816
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004EC8 RID: 20168
				// (get) Token: 0x06010232 RID: 66098 RVA: 0x003D4480 File Offset: 0x003D2680
				// (set) Token: 0x06010233 RID: 66099 RVA: 0x0007A61F File Offset: 0x0007881F
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004EC9 RID: 20169
				// (get) Token: 0x06010234 RID: 66100 RVA: 0x003D44A8 File Offset: 0x003D26A8
				// (set) Token: 0x06010235 RID: 66101 RVA: 0x0007A63A File Offset: 0x0007883A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004ECA RID: 20170
				// (get) Token: 0x06010236 RID: 66102 RVA: 0x003D44D8 File Offset: 0x003D26D8
				// (set) Token: 0x06010237 RID: 66103 RVA: 0x0007A659 File Offset: 0x00078859
				public unsafe GrowContainerBehaviour.__c__DisplayClass35_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainerBehaviour.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerBehaviour.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ADCE RID: 44494
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ADCF RID: 44495
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ADD0 RID: 44496
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ADD1 RID: 44497
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ADD2 RID: 44498
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ADD3 RID: 44499
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ADD4 RID: 44500
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ADD5 RID: 44501
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ADD6 RID: 44502
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x02000333 RID: 819
	public class InteractionManager : Singleton<InteractionManager>
	{
		// Token: 0x06004642 RID: 17986 RVA: 0x0016A514 File Offset: 0x00168714
		// Note: this type is marked as 'beforefieldinit'.
		static InteractionManager()
		{
			Il2CppClassPointerStore<InteractionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "InteractionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr);
			InteractionManager.NativeFieldInfoPtr_RayRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "RayRadius");
			InteractionManager.NativeFieldInfoPtr_MaxInteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "MaxInteractionRange");
			InteractionManager.NativeFieldInfoPtr_interaction_SearchMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interaction_SearchMask");
			InteractionManager.NativeFieldInfoPtr_rightClickRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "rightClickRange");
			InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<CanDestroy>k__BackingField");
			InteractionManager.NativeFieldInfoPtr__HoveredInteractableObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<HoveredInteractableObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr__HoveredValidInteractableObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<HoveredValidInteractableObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr__InteractedObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<InteractedObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr__InteractKeyStr_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<InteractKeyStr>k__BackingField");
			InteractionManager.NativeFieldInfoPtr_InteractInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "InteractInput");
			InteractionManager.NativeFieldInfoPtr_messageColor_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "messageColor_Default");
			InteractionManager.NativeFieldInfoPtr_iconColor_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Default");
			InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Default_Key");
			InteractionManager.NativeFieldInfoPtr_messageColor_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "messageColor_Invalid");
			InteractionManager.NativeFieldInfoPtr_iconColor_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Invalid");
			InteractionManager.NativeFieldInfoPtr_icon_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_Key");
			InteractionManager.NativeFieldInfoPtr_icon_LeftMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_LeftMouse");
			InteractionManager.NativeFieldInfoPtr_icon_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_Cross");
			InteractionManager.NativeFieldInfoPtr_interactCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactCooldown");
			InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "timeSinceLastInteractStart");
			InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "itemBeingDestroyed");
			InteractionManager.NativeFieldInfoPtr_destroyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "destroyTime");
			InteractionManager.NativeFieldInfoPtr__ray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "_ray");
			InteractionManager.NativeFieldInfoPtr__sphereCastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "_sphereCastHits");
			InteractionManager.NativeFieldInfoPtr__rayCastHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "_rayCastHits");
			InteractionManager.NativeFieldInfoPtr_timeToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "timeToDestroy");
			InteractionManager.NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672338);
			InteractionManager.NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672339);
			InteractionManager.NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672340);
			InteractionManager.NativeMethodInfoPtr_get_HoveredInteractableObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672341);
			InteractionManager.NativeMethodInfoPtr_set_HoveredInteractableObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672342);
			InteractionManager.NativeMethodInfoPtr_get_HoveredValidInteractableObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672343);
			InteractionManager.NativeMethodInfoPtr_set_HoveredValidInteractableObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672344);
			InteractionManager.NativeMethodInfoPtr_get_InteractedObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672345);
			InteractionManager.NativeMethodInfoPtr_set_InteractedObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672346);
			InteractionManager.NativeMethodInfoPtr_get_InteractKeyStr_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672347);
			InteractionManager.NativeMethodInfoPtr_set_InteractKeyStr_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672348);
			InteractionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672349);
			InteractionManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672350);
			InteractionManager.NativeMethodInfoPtr_LoadInteractKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672351);
			InteractionManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672352);
			InteractionManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672353);
			InteractionManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672354);
			InteractionManager.NativeMethodInfoPtr_DoCasts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672355);
			InteractionManager.NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672356);
			InteractionManager.NativeMethodInfoPtr_IsAnythingBlockingInteraction_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672357);
			InteractionManager.NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672358);
			InteractionManager.NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672359);
			InteractionManager.NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672360);
			InteractionManager.NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672361);
			InteractionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100672362);
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06004643 RID: 17987 RVA: 0x0016A940 File Offset: 0x00168B40
		public unsafe LayerMask Interaction_SearchMask
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 29072, RefRangeEnd = 29101, XrefRangeStart = 29072, XrefRangeEnd = 29101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06004644 RID: 17988 RVA: 0x0016A97C File Offset: 0x00168B7C
		// (set) Token: 0x06004645 RID: 17989 RVA: 0x0016A9B8 File Offset: 0x00168BB8
		public unsafe bool CanDestroy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06004646 RID: 17990 RVA: 0x0016A9F8 File Offset: 0x00168BF8
		// (set) Token: 0x06004647 RID: 17991 RVA: 0x0016AA38 File Offset: 0x00168C38
		public unsafe InteractableObject HoveredInteractableObject
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_HoveredInteractableObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_HoveredInteractableObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06004648 RID: 17992 RVA: 0x0016AA7C File Offset: 0x00168C7C
		// (set) Token: 0x06004649 RID: 17993 RVA: 0x0016AABC File Offset: 0x00168CBC
		public unsafe InteractableObject HoveredValidInteractableObject
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_HoveredValidInteractableObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_HoveredValidInteractableObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x0600464A RID: 17994 RVA: 0x0016AB00 File Offset: 0x00168D00
		// (set) Token: 0x0600464B RID: 17995 RVA: 0x0016AB40 File Offset: 0x00168D40
		public unsafe InteractableObject InteractedObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_InteractedObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_InteractedObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x0600464C RID: 17996 RVA: 0x0016AB84 File Offset: 0x00168D84
		// (set) Token: 0x0600464D RID: 17997 RVA: 0x0016ABBC File Offset: 0x00168DBC
		public unsafe string InteractKeyStr
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_InteractKeyStr_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_InteractKeyStr_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600464E RID: 17998 RVA: 0x0016AC00 File Offset: 0x00168E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165396, XrefRangeEnd = 165440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x0016AC3C File Offset: 0x00168E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165440, XrefRangeEnd = 165464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x0016AC78 File Offset: 0x00168E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165464, XrefRangeEnd = 165472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadInteractKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_LoadInteractKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x0016ACAC File Offset: 0x00168EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165472, XrefRangeEnd = 165473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x0016ACE0 File Offset: 0x00168EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165473, XrefRangeEnd = 165480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x0016AD1C File Offset: 0x00168F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165480, XrefRangeEnd = 165490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x0016AD58 File Offset: 0x00168F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165515, RefRangeEnd = 165516, XrefRangeStart = 165490, XrefRangeEnd = 165515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCasts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_DoCasts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x0016AD8C File Offset: 0x00168F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165516, XrefRangeEnd = 165654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x0016ADC8 File Offset: 0x00168FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165704, RefRangeEnd = 165706, XrefRangeStart = 165654, XrefRangeEnd = 165704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAnythingBlockingInteraction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_IsAnythingBlockingInteraction_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x0016AE04 File Offset: 0x00169004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165706, XrefRangeEnd = 165747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckInteraction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x0016AE40 File Offset: 0x00169040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165747, XrefRangeEnd = 165787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckRightClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x0016AE7C File Offset: 0x0016907C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165787, XrefRangeEnd = 165797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BuildableItem GetHoveredBuildableItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr3) : null;
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x0016AEC8 File Offset: 0x001690C8
		[CallerCount(0)]
		public unsafe void SetCanDestroy(bool canDestroy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref canDestroy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x0016AF08 File Offset: 0x00169108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165797, XrefRangeEnd = 165810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x000223FB File Offset: 0x000205FB
		public InteractionManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x0600465D RID: 18013 RVA: 0x0016AF44 File Offset: 0x00169144
		// (set) Token: 0x0600465E RID: 18014 RVA: 0x00022404 File Offset: 0x00020604
		public unsafe static float RayRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_RayRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_RayRadius, (void*)(&value));
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x0016AF60 File Offset: 0x00169160
		// (set) Token: 0x06004660 RID: 18016 RVA: 0x00022412 File Offset: 0x00020612
		public unsafe static float MaxInteractionRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_MaxInteractionRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_MaxInteractionRange, (void*)(&value));
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x06004661 RID: 18017 RVA: 0x0016AF7C File Offset: 0x0016917C
		// (set) Token: 0x06004662 RID: 18018 RVA: 0x00022420 File Offset: 0x00020620
		public unsafe LayerMask interaction_SearchMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_SearchMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_SearchMask)) = value;
			}
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06004663 RID: 18019 RVA: 0x0016AFA4 File Offset: 0x001691A4
		// (set) Token: 0x06004664 RID: 18020 RVA: 0x0002243B File Offset: 0x0002063B
		public unsafe float rightClickRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_rightClickRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_rightClickRange)) = value;
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x0016AFCC File Offset: 0x001691CC
		// (set) Token: 0x06004666 RID: 18022 RVA: 0x00022456 File Offset: 0x00020656
		public unsafe bool _CanDestroy_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField)) = value;
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x06004667 RID: 18023 RVA: 0x0016AFF4 File Offset: 0x001691F4
		// (set) Token: 0x06004668 RID: 18024 RVA: 0x00022471 File Offset: 0x00020671
		public unsafe InteractableObject _HoveredInteractableObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__HoveredInteractableObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__HoveredInteractableObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x06004669 RID: 18025 RVA: 0x0016B024 File Offset: 0x00169224
		// (set) Token: 0x0600466A RID: 18026 RVA: 0x00022490 File Offset: 0x00020690
		public unsafe InteractableObject _HoveredValidInteractableObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__HoveredValidInteractableObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__HoveredValidInteractableObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x0016B054 File Offset: 0x00169254
		// (set) Token: 0x0600466C RID: 18028 RVA: 0x000224AF File Offset: 0x000206AF
		public unsafe InteractableObject _InteractedObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__InteractedObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__InteractedObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x0600466D RID: 18029 RVA: 0x0016B084 File Offset: 0x00169284
		// (set) Token: 0x0600466E RID: 18030 RVA: 0x000224CE File Offset: 0x000206CE
		public unsafe string _InteractKeyStr_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__InteractKeyStr_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__InteractKeyStr_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x0600466F RID: 18031 RVA: 0x0016B0AC File Offset: 0x001692AC
		// (set) Token: 0x06004670 RID: 18032 RVA: 0x000224ED File Offset: 0x000206ED
		public unsafe InputActionReference InteractInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06004671 RID: 18033 RVA: 0x0016B0DC File Offset: 0x001692DC
		// (set) Token: 0x06004672 RID: 18034 RVA: 0x0002250C File Offset: 0x0002070C
		public unsafe Color messageColor_Default
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Default);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Default)) = value;
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06004673 RID: 18035 RVA: 0x0016B104 File Offset: 0x00169304
		// (set) Token: 0x06004674 RID: 18036 RVA: 0x00022527 File Offset: 0x00020727
		public unsafe Color iconColor_Default
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default)) = value;
			}
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x0016B12C File Offset: 0x0016932C
		// (set) Token: 0x06004676 RID: 18038 RVA: 0x00022542 File Offset: 0x00020742
		public unsafe Color iconColor_Default_Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key)) = value;
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x0016B154 File Offset: 0x00169354
		// (set) Token: 0x06004678 RID: 18040 RVA: 0x0002255D File Offset: 0x0002075D
		public unsafe Color messageColor_Invalid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Invalid)) = value;
			}
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06004679 RID: 18041 RVA: 0x0016B17C File Offset: 0x0016937C
		// (set) Token: 0x0600467A RID: 18042 RVA: 0x00022578 File Offset: 0x00020778
		public unsafe Color iconColor_Invalid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Invalid)) = value;
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x0600467B RID: 18043 RVA: 0x0016B1A4 File Offset: 0x001693A4
		// (set) Token: 0x0600467C RID: 18044 RVA: 0x00022593 File Offset: 0x00020793
		public unsafe Sprite icon_Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x0600467D RID: 18045 RVA: 0x0016B1D4 File Offset: 0x001693D4
		// (set) Token: 0x0600467E RID: 18046 RVA: 0x000225B2 File Offset: 0x000207B2
		public unsafe Sprite icon_LeftMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_LeftMouse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_LeftMouse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x0600467F RID: 18047 RVA: 0x0016B204 File Offset: 0x00169404
		// (set) Token: 0x06004680 RID: 18048 RVA: 0x000225D1 File Offset: 0x000207D1
		public unsafe Sprite icon_Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06004681 RID: 18049 RVA: 0x0016B234 File Offset: 0x00169434
		// (set) Token: 0x06004682 RID: 18050 RVA: 0x000225F0 File Offset: 0x000207F0
		public unsafe static float interactCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_interactCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_interactCooldown, (void*)(&value));
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06004683 RID: 18051 RVA: 0x0016B250 File Offset: 0x00169450
		// (set) Token: 0x06004684 RID: 18052 RVA: 0x000225FE File Offset: 0x000207FE
		public unsafe float timeSinceLastInteractStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart)) = value;
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06004685 RID: 18053 RVA: 0x0016B278 File Offset: 0x00169478
		// (set) Token: 0x06004686 RID: 18054 RVA: 0x00022619 File Offset: 0x00020819
		public unsafe BuildableItem itemBeingDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06004687 RID: 18055 RVA: 0x0016B2A8 File Offset: 0x001694A8
		// (set) Token: 0x06004688 RID: 18056 RVA: 0x00022638 File Offset: 0x00020838
		public unsafe float destroyTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_destroyTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_destroyTime)) = value;
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06004689 RID: 18057 RVA: 0x0016B2D0 File Offset: 0x001694D0
		// (set) Token: 0x0600468A RID: 18058 RVA: 0x00022653 File Offset: 0x00020853
		public unsafe Ray _ray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__ray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__ray)) = value;
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x0600468B RID: 18059 RVA: 0x0016B2F8 File Offset: 0x001694F8
		// (set) Token: 0x0600468C RID: 18060 RVA: 0x0002266E File Offset: 0x0002086E
		public unsafe Il2CppStructArray<RaycastHit> _sphereCastHits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__sphereCastHits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__sphereCastHits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x0600468D RID: 18061 RVA: 0x0016B328 File Offset: 0x00169528
		// (set) Token: 0x0600468E RID: 18062 RVA: 0x0002268D File Offset: 0x0002088D
		public unsafe Il2CppStructArray<RaycastHit> _rayCastHits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__rayCastHits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__rayCastHits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x0600468F RID: 18063 RVA: 0x0016B358 File Offset: 0x00169558
		// (set) Token: 0x06004690 RID: 18064 RVA: 0x000226AC File Offset: 0x000208AC
		public unsafe static float timeToDestroy
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_timeToDestroy, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_timeToDestroy, (void*)(&value));
			}
		}

		// Token: 0x04002FD6 RID: 12246
		private static readonly IntPtr NativeFieldInfoPtr_RayRadius;

		// Token: 0x04002FD7 RID: 12247
		private static readonly IntPtr NativeFieldInfoPtr_MaxInteractionRange;

		// Token: 0x04002FD8 RID: 12248
		private static readonly IntPtr NativeFieldInfoPtr_interaction_SearchMask;

		// Token: 0x04002FD9 RID: 12249
		private static readonly IntPtr NativeFieldInfoPtr_rightClickRange;

		// Token: 0x04002FDA RID: 12250
		private static readonly IntPtr NativeFieldInfoPtr__CanDestroy_k__BackingField;

		// Token: 0x04002FDB RID: 12251
		private static readonly IntPtr NativeFieldInfoPtr__HoveredInteractableObject_k__BackingField;

		// Token: 0x04002FDC RID: 12252
		private static readonly IntPtr NativeFieldInfoPtr__HoveredValidInteractableObject_k__BackingField;

		// Token: 0x04002FDD RID: 12253
		private static readonly IntPtr NativeFieldInfoPtr__InteractedObject_k__BackingField;

		// Token: 0x04002FDE RID: 12254
		private static readonly IntPtr NativeFieldInfoPtr__InteractKeyStr_k__BackingField;

		// Token: 0x04002FDF RID: 12255
		private static readonly IntPtr NativeFieldInfoPtr_InteractInput;

		// Token: 0x04002FE0 RID: 12256
		private static readonly IntPtr NativeFieldInfoPtr_messageColor_Default;

		// Token: 0x04002FE1 RID: 12257
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Default;

		// Token: 0x04002FE2 RID: 12258
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Default_Key;

		// Token: 0x04002FE3 RID: 12259
		private static readonly IntPtr NativeFieldInfoPtr_messageColor_Invalid;

		// Token: 0x04002FE4 RID: 12260
		private static readonly IntPtr NativeFieldInfoPtr_iconColor_Invalid;

		// Token: 0x04002FE5 RID: 12261
		private static readonly IntPtr NativeFieldInfoPtr_icon_Key;

		// Token: 0x04002FE6 RID: 12262
		private static readonly IntPtr NativeFieldInfoPtr_icon_LeftMouse;

		// Token: 0x04002FE7 RID: 12263
		private static readonly IntPtr NativeFieldInfoPtr_icon_Cross;

		// Token: 0x04002FE8 RID: 12264
		private static readonly IntPtr NativeFieldInfoPtr_interactCooldown;

		// Token: 0x04002FE9 RID: 12265
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastInteractStart;

		// Token: 0x04002FEA RID: 12266
		private static readonly IntPtr NativeFieldInfoPtr_itemBeingDestroyed;

		// Token: 0x04002FEB RID: 12267
		private static readonly IntPtr NativeFieldInfoPtr_destroyTime;

		// Token: 0x04002FEC RID: 12268
		private static readonly IntPtr NativeFieldInfoPtr__ray;

		// Token: 0x04002FED RID: 12269
		private static readonly IntPtr NativeFieldInfoPtr__sphereCastHits;

		// Token: 0x04002FEE RID: 12270
		private static readonly IntPtr NativeFieldInfoPtr__rayCastHits;

		// Token: 0x04002FEF RID: 12271
		private static readonly IntPtr NativeFieldInfoPtr_timeToDestroy;

		// Token: 0x04002FF0 RID: 12272
		private static readonly IntPtr NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0;

		// Token: 0x04002FF1 RID: 12273
		private static readonly IntPtr NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0;

		// Token: 0x04002FF2 RID: 12274
		private static readonly IntPtr NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0;

		// Token: 0x04002FF3 RID: 12275
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredInteractableObject_Public_get_InteractableObject_0;

		// Token: 0x04002FF4 RID: 12276
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredInteractableObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x04002FF5 RID: 12277
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredValidInteractableObject_Public_get_InteractableObject_0;

		// Token: 0x04002FF6 RID: 12278
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredValidInteractableObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x04002FF7 RID: 12279
		private static readonly IntPtr NativeMethodInfoPtr_get_InteractedObject_Public_get_InteractableObject_0;

		// Token: 0x04002FF8 RID: 12280
		private static readonly IntPtr NativeMethodInfoPtr_set_InteractedObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x04002FF9 RID: 12281
		private static readonly IntPtr NativeMethodInfoPtr_get_InteractKeyStr_Public_get_String_0;

		// Token: 0x04002FFA RID: 12282
		private static readonly IntPtr NativeMethodInfoPtr_set_InteractKeyStr_Protected_set_Void_String_0;

		// Token: 0x04002FFB RID: 12283
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002FFC RID: 12284
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04002FFD RID: 12285
		private static readonly IntPtr NativeMethodInfoPtr_LoadInteractKey_Private_Void_0;

		// Token: 0x04002FFE RID: 12286
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04002FFF RID: 12287
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04003000 RID: 12288
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04003001 RID: 12289
		private static readonly IntPtr NativeMethodInfoPtr_DoCasts_Private_Void_0;

		// Token: 0x04003002 RID: 12290
		private static readonly IntPtr NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0;

		// Token: 0x04003003 RID: 12291
		private static readonly IntPtr NativeMethodInfoPtr_IsAnythingBlockingInteraction_Public_Boolean_0;

		// Token: 0x04003004 RID: 12292
		private static readonly IntPtr NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0;

		// Token: 0x04003005 RID: 12293
		private static readonly IntPtr NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0;

		// Token: 0x04003006 RID: 12294
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0;

		// Token: 0x04003007 RID: 12295
		private static readonly IntPtr NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0;

		// Token: 0x04003008 RID: 12296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A63 RID: 2659
		[ObfuscatedName("ScheduleOne.Interaction.InteractionManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E0B0 RID: 57520 RVA: 0x00373A30 File Offset: 0x00371C30
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr);
				InteractionManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, "<>9");
				InteractionManager.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, "<>9__49_0");
				InteractionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, 100672365);
				InteractionManager.__c.NativeMethodInfoPtr__CheckHover_b__49_0_Internal_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, 100672366);
			}

			// Token: 0x0600E0B1 RID: 57521 RVA: 0x00373AAC File Offset: 0x00371CAC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0B2 RID: 57522 RVA: 0x00373AE8 File Offset: 0x00371CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165384, XrefRangeEnd = 165387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckHover_b__49_0(RaycastHit x, RaycastHit y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c.NativeMethodInfoPtr__CheckHover_b__49_0_Internal_Int32_RaycastHit_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E0B3 RID: 57523 RVA: 0x00069E28 File Offset: 0x00068028
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004465 RID: 17509
			// (get) Token: 0x0600E0B4 RID: 57524 RVA: 0x00373B40 File Offset: 0x00371D40
			// (set) Token: 0x0600E0B5 RID: 57525 RVA: 0x00069E31 File Offset: 0x00068031
			public unsafe static InteractionManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractionManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractionManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractionManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004466 RID: 17510
			// (get) Token: 0x0600E0B6 RID: 57526 RVA: 0x00373B68 File Offset: 0x00371D68
			// (set) Token: 0x0600E0B7 RID: 57527 RVA: 0x00069E43 File Offset: 0x00068043
			public unsafe static Comparison<RaycastHit> __9__49_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractionManager.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<RaycastHit>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractionManager.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098F4 RID: 39156
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040098F5 RID: 39157
			private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

			// Token: 0x040098F6 RID: 39158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098F7 RID: 39159
			private static readonly IntPtr NativeMethodInfoPtr__CheckHover_b__49_0_Internal_Int32_RaycastHit_RaycastHit_0;
		}

		// Token: 0x02000A64 RID: 2660
		[ObfuscatedName("ScheduleOne.Interaction.InteractionManager+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E0B8 RID: 57528 RVA: 0x00373B90 File Offset: 0x00371D90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<InteractionManager.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass49_0>.NativeClassPtr);
				InteractionManager.__c__DisplayClass49_0.NativeFieldInfoPtr_objectHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass49_0>.NativeClassPtr, "objectHits");
				InteractionManager.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass49_0>.NativeClassPtr, 100672367);
				InteractionManager.__c__DisplayClass49_0.NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass49_0>.NativeClassPtr, 100672368);
			}

			// Token: 0x0600E0B9 RID: 57529 RVA: 0x00373BF8 File Offset: 0x00371DF8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0BA RID: 57530 RVA: 0x00373C34 File Offset: 0x00371E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165387, XrefRangeEnd = 165396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckHover_b__1(InteractableObject x, InteractableObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c__DisplayClass49_0.NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E0BB RID: 57531 RVA: 0x00069E55 File Offset: 0x00068055
			public __c__DisplayClass49_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004467 RID: 17511
			// (get) Token: 0x0600E0BC RID: 57532 RVA: 0x00373C94 File Offset: 0x00371E94
			// (set) Token: 0x0600E0BD RID: 57533 RVA: 0x00069E5E File Offset: 0x0006805E
			public unsafe Dictionary<InteractableObject, RaycastHit> objectHits
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.__c__DisplayClass49_0.NativeFieldInfoPtr_objectHits);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<InteractableObject, RaycastHit>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.__c__DisplayClass49_0.NativeFieldInfoPtr_objectHits), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098F8 RID: 39160
			private static readonly IntPtr NativeFieldInfoPtr_objectHits;

			// Token: 0x040098F9 RID: 39161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098FA RID: 39162
			private static readonly IntPtr NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0;
		}
	}
}

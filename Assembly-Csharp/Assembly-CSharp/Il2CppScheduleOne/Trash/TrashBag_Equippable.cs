using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000488 RID: 1160
	public class TrashBag_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06006864 RID: 26724 RVA: 0x001E4104 File Offset: 0x001E2304
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBag_Equippable()
		{
			Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashBag_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr);
			TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "TRASH_CONTAINER_INTERACT_DISTANCE");
			TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "BAG_TRASH_TIME");
			TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PICKUP_RANGE");
			TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PICKUP_AREA_RADIUS");
			TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "<IsBaggingTrash>k__BackingField");
			TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "<IsPickingUpTrash>k__BackingField");
			TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PickupLookMask");
			TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "PickupAreaProjector");
			TrashBag_Equippable.NativeFieldInfoPtr_RustleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "RustleSound");
			TrashBag_Equippable.NativeFieldInfoPtr_BagSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "BagSound");
			TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_bagTrashTime");
			TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_baggedContainer");
			TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, "_pickupTrashTime");
			TrashBag_Equippable.NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676953);
			TrashBag_Equippable.NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676954);
			TrashBag_Equippable.NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676955);
			TrashBag_Equippable.NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676956);
			TrashBag_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676957);
			TrashBag_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676958);
			TrashBag_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676959);
			TrashBag_Equippable.NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676960);
			TrashBag_Equippable.NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676961);
			TrashBag_Equippable.NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676962);
			TrashBag_Equippable.NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676963);
			TrashBag_Equippable.NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676964);
			TrashBag_Equippable.NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676965);
			TrashBag_Equippable.NativeMethodInfoPtr_StartPickup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676966);
			TrashBag_Equippable.NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676967);
			TrashBag_Equippable.NativeMethodInfoPtr_ShowPrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676968);
			TrashBag_Equippable.NativeMethodInfoPtr_HidePrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676969);
			TrashBag_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr, 100676970);
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x06006865 RID: 26725 RVA: 0x001E43A0 File Offset: 0x001E25A0
		// (set) Token: 0x06006866 RID: 26726 RVA: 0x001E43DC File Offset: 0x001E25DC
		public unsafe bool IsBaggingTrash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06006867 RID: 26727 RVA: 0x001E441C File Offset: 0x001E261C
		// (set) Token: 0x06006868 RID: 26728 RVA: 0x001E4458 File Offset: 0x001E2658
		public unsafe bool IsPickingUpTrash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x001E4498 File Offset: 0x001E2698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216169, XrefRangeEnd = 216200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x001E44E8 File Offset: 0x001E26E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216200, XrefRangeEnd = 216214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x001E4524 File Offset: 0x001E2724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216214, XrefRangeEnd = 216288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashBag_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x001E4560 File Offset: 0x001E2760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216305, RefRangeEnd = 216306, XrefRangeStart = 216288, XrefRangeEnd = 216305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainer GetHoveredTrashContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr3) : null;
		}

		// Token: 0x0600686D RID: 26733 RVA: 0x001E45A0 File Offset: 0x001E27A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216311, RefRangeEnd = 216313, XrefRangeStart = 216306, XrefRangeEnd = 216311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RaycastLook(out RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x001E45EC File Offset: 0x001E27EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216317, RefRangeEnd = 216319, XrefRangeStart = 216313, XrefRangeEnd = 216317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPickupLocationValid(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x001E4638 File Offset: 0x001E2838
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216345, RefRangeEnd = 216348, XrefRangeStart = 216319, XrefRangeEnd = 216345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<TrashItem> GetTrashItemsAtPoint(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr3) : null;
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x001E4684 File Offset: 0x001E2884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216348, XrefRangeEnd = 216350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBagTrash(TrashContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x001E46C8 File Offset: 0x001E28C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216350, XrefRangeEnd = 216355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBagTrash(bool complete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x001E4708 File Offset: 0x001E2908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216355, XrefRangeEnd = 216356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPickup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StartPickup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x001E473C File Offset: 0x001E293C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216402, RefRangeEnd = 216403, XrefRangeStart = 216356, XrefRangeEnd = 216402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPickup(bool complete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x001E477C File Offset: 0x001E297C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216411, RefRangeEnd = 216414, XrefRangeStart = 216403, XrefRangeEnd = 216411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_ShowPrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x001E47B0 File Offset: 0x001E29B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216414, XrefRangeEnd = 216422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HidePrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr_HidePrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x001E47E4 File Offset: 0x001E29E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBag_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBag_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBag_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x000312E3 File Offset: 0x0002F4E3
		public TrashBag_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06006878 RID: 26744 RVA: 0x001E4820 File Offset: 0x001E2A20
		// (set) Token: 0x06006879 RID: 26745 RVA: 0x000312EC File Offset: 0x0002F4EC
		public unsafe static float TRASH_CONTAINER_INTERACT_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x0600687A RID: 26746 RVA: 0x001E483C File Offset: 0x001E2A3C
		// (set) Token: 0x0600687B RID: 26747 RVA: 0x000312FA File Offset: 0x0002F4FA
		public unsafe static float BAG_TRASH_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_BAG_TRASH_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x0600687C RID: 26748 RVA: 0x001E4858 File Offset: 0x001E2A58
		// (set) Token: 0x0600687D RID: 26749 RVA: 0x00031308 File Offset: 0x0002F508
		public unsafe static float PICKUP_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x0600687E RID: 26750 RVA: 0x001E4874 File Offset: 0x001E2A74
		// (set) Token: 0x0600687F RID: 26751 RVA: 0x00031316 File Offset: 0x0002F516
		public unsafe static float PICKUP_AREA_RADIUS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashBag_Equippable.NativeFieldInfoPtr_PICKUP_AREA_RADIUS, (void*)(&value));
			}
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06006880 RID: 26752 RVA: 0x001E4890 File Offset: 0x001E2A90
		// (set) Token: 0x06006881 RID: 26753 RVA: 0x00031324 File Offset: 0x0002F524
		public unsafe bool _IsBaggingTrash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsBaggingTrash_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x06006882 RID: 26754 RVA: 0x001E48B8 File Offset: 0x001E2AB8
		// (set) Token: 0x06006883 RID: 26755 RVA: 0x0003133F File Offset: 0x0002F53F
		public unsafe bool _IsPickingUpTrash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06006884 RID: 26756 RVA: 0x001E48E0 File Offset: 0x001E2AE0
		// (set) Token: 0x06006885 RID: 26757 RVA: 0x0003135A File Offset: 0x0002F55A
		public unsafe LayerMask PickupLookMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupLookMask)) = value;
			}
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06006886 RID: 26758 RVA: 0x001E4908 File Offset: 0x001E2B08
		// (set) Token: 0x06006887 RID: 26759 RVA: 0x00031375 File Offset: 0x0002F575
		public unsafe DecalProjector PickupAreaProjector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_PickupAreaProjector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06006888 RID: 26760 RVA: 0x001E4938 File Offset: 0x001E2B38
		// (set) Token: 0x06006889 RID: 26761 RVA: 0x00031394 File Offset: 0x0002F594
		public unsafe AudioSourceController RustleSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_RustleSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_RustleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x0600688A RID: 26762 RVA: 0x001E4968 File Offset: 0x001E2B68
		// (set) Token: 0x0600688B RID: 26763 RVA: 0x000313B3 File Offset: 0x0002F5B3
		public unsafe AudioSourceController BagSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_BagSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr_BagSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x0600688C RID: 26764 RVA: 0x001E4998 File Offset: 0x001E2B98
		// (set) Token: 0x0600688D RID: 26765 RVA: 0x000313D2 File Offset: 0x0002F5D2
		public unsafe float _bagTrashTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__bagTrashTime)) = value;
			}
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x0600688E RID: 26766 RVA: 0x001E49C0 File Offset: 0x001E2BC0
		// (set) Token: 0x0600688F RID: 26767 RVA: 0x000313ED File Offset: 0x0002F5ED
		public unsafe TrashContainer _baggedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__baggedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06006890 RID: 26768 RVA: 0x001E49F0 File Offset: 0x001E2BF0
		// (set) Token: 0x06006891 RID: 26769 RVA: 0x0003140C File Offset: 0x0002F60C
		public unsafe float _pickupTrashTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashBag_Equippable.NativeFieldInfoPtr__pickupTrashTime)) = value;
			}
		}

		// Token: 0x040047C7 RID: 18375
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_CONTAINER_INTERACT_DISTANCE;

		// Token: 0x040047C8 RID: 18376
		private static readonly IntPtr NativeFieldInfoPtr_BAG_TRASH_TIME;

		// Token: 0x040047C9 RID: 18377
		private static readonly IntPtr NativeFieldInfoPtr_PICKUP_RANGE;

		// Token: 0x040047CA RID: 18378
		private static readonly IntPtr NativeFieldInfoPtr_PICKUP_AREA_RADIUS;

		// Token: 0x040047CB RID: 18379
		private static readonly IntPtr NativeFieldInfoPtr__IsBaggingTrash_k__BackingField;

		// Token: 0x040047CC RID: 18380
		private static readonly IntPtr NativeFieldInfoPtr__IsPickingUpTrash_k__BackingField;

		// Token: 0x040047CD RID: 18381
		private static readonly IntPtr NativeFieldInfoPtr_PickupLookMask;

		// Token: 0x040047CE RID: 18382
		private static readonly IntPtr NativeFieldInfoPtr_PickupAreaProjector;

		// Token: 0x040047CF RID: 18383
		private static readonly IntPtr NativeFieldInfoPtr_RustleSound;

		// Token: 0x040047D0 RID: 18384
		private static readonly IntPtr NativeFieldInfoPtr_BagSound;

		// Token: 0x040047D1 RID: 18385
		private static readonly IntPtr NativeFieldInfoPtr__bagTrashTime;

		// Token: 0x040047D2 RID: 18386
		private static readonly IntPtr NativeFieldInfoPtr__baggedContainer;

		// Token: 0x040047D3 RID: 18387
		private static readonly IntPtr NativeFieldInfoPtr__pickupTrashTime;

		// Token: 0x040047D4 RID: 18388
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBaggingTrash_Public_get_Boolean_0;

		// Token: 0x040047D5 RID: 18389
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBaggingTrash_Private_set_Void_Boolean_0;

		// Token: 0x040047D6 RID: 18390
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPickingUpTrash_Public_get_Boolean_0;

		// Token: 0x040047D7 RID: 18391
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPickingUpTrash_Private_set_Void_Boolean_0;

		// Token: 0x040047D8 RID: 18392
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040047D9 RID: 18393
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040047DA RID: 18394
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040047DB RID: 18395
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredTrashContainer_Private_TrashContainer_0;

		// Token: 0x040047DC RID: 18396
		private static readonly IntPtr NativeMethodInfoPtr_RaycastLook_Private_Boolean_byref_RaycastHit_0;

		// Token: 0x040047DD RID: 18397
		private static readonly IntPtr NativeMethodInfoPtr_IsPickupLocationValid_Private_Boolean_RaycastHit_0;

		// Token: 0x040047DE RID: 18398
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashItemsAtPoint_Private_List_1_TrashItem_Vector3_0;

		// Token: 0x040047DF RID: 18399
		private static readonly IntPtr NativeMethodInfoPtr_StartBagTrash_Private_Void_TrashContainer_0;

		// Token: 0x040047E0 RID: 18400
		private static readonly IntPtr NativeMethodInfoPtr_StopBagTrash_Private_Void_Boolean_0;

		// Token: 0x040047E1 RID: 18401
		private static readonly IntPtr NativeMethodInfoPtr_StartPickup_Private_Void_0;

		// Token: 0x040047E2 RID: 18402
		private static readonly IntPtr NativeMethodInfoPtr_StopPickup_Private_Void_Boolean_0;

		// Token: 0x040047E3 RID: 18403
		private static readonly IntPtr NativeMethodInfoPtr_ShowPrompt_Private_Void_0;

		// Token: 0x040047E4 RID: 18404
		private static readonly IntPtr NativeMethodInfoPtr_HidePrompt_Private_Void_0;

		// Token: 0x040047E5 RID: 18405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

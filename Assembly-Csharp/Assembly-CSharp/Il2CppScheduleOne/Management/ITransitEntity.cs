using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002EE RID: 750
	public class ITransitEntity : Il2CppObjectBase
	{
		// Token: 0x06003B63 RID: 15203 RVA: 0x001432F0 File Offset: 0x001414F0
		// Note: this type is marked as 'beforefieldinit'.
		static ITransitEntity()
		{
			Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ITransitEntity");
			ITransitEntity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670903);
			ITransitEntity.NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670904);
			ITransitEntity.NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670905);
			ITransitEntity.NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670906);
			ITransitEntity.NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670907);
			ITransitEntity.NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670908);
			ITransitEntity.NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670909);
			ITransitEntity.NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670910);
			ITransitEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670911);
			ITransitEntity.NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670912);
			ITransitEntity.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670913);
			ITransitEntity.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670914);
			ITransitEntity.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670915);
			ITransitEntity.NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670916);
			ITransitEntity.NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670917);
			ITransitEntity.NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670918);
			ITransitEntity.NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670919);
			ITransitEntity.NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670920);
			ITransitEntity.NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670921);
			ITransitEntity.NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670922);
			ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670923);
			ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100670924);
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06003B64 RID: 15204 RVA: 0x001434D0 File Offset: 0x001416D0
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06003B65 RID: 15205 RVA: 0x00143514 File Offset: 0x00141714
		// (set) Token: 0x06003B66 RID: 15206 RVA: 0x00143560 File Offset: 0x00141760
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06003B67 RID: 15207 RVA: 0x001435B0 File Offset: 0x001417B0
		// (set) Token: 0x06003B68 RID: 15208 RVA: 0x001435FC File Offset: 0x001417FC
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06003B69 RID: 15209 RVA: 0x0014364C File Offset: 0x0014184C
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06003B6A RID: 15210 RVA: 0x00143698 File Offset: 0x00141898
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06003B6B RID: 15211 RVA: 0x001436E4 File Offset: 0x001418E4
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x06003B6C RID: 15212 RVA: 0x0014372C File Offset: 0x0014192C
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06003B6D RID: 15213 RVA: 0x00143774 File Offset: 0x00141974
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06003B6E RID: 15214 RVA: 0x001437BC File Offset: 0x001419BC
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x00143804 File Offset: 0x00141A04
		[CallerCount(0)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x00143850 File Offset: 0x00141A50
		[CallerCount(0)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x0014388C File Offset: 0x00141A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149982, XrefRangeEnd = 150016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItemIntoInput(ItemInstance item, NPC inserter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inserter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x001438EC File Offset: 0x00141AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150016, XrefRangeEnd = 150055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItemIntoOutput(ItemInstance item, NPC inserter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inserter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x0014394C File Offset: 0x00141B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150055, XrefRangeEnd = 150095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetInputCapacityForItem(ItemInstance item, NPC asker = null, bool checkPlayerFilters = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asker);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkPlayerFilters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x001439C4 File Offset: 0x00141BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150095, XrefRangeEnd = 150135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetOutputCapacityForItem(ItemInstance item, NPC asker = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x00143A30 File Offset: 0x00141C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150135, XrefRangeEnd = 150153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetOutputItemContainer(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x00143A8C File Offset: 0x00141C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150153, XrefRangeEnd = 150185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<ItemSlot> ReserveInputSlotsForItem(ItemInstance item, NetworkObject locker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x00143AFC File Offset: 0x00141CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150185, XrefRangeEnd = 150210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveSlotLocks(NetworkObject locker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(locker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x00143B4C File Offset: 0x00141D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150210, XrefRangeEnd = 150232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetFirstSlotContainingItem(string id, ITransitEntity.ESlotType searchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x06003B79 RID: 15225 RVA: 0x00143BB8 File Offset: 0x00141DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150232, XrefRangeEnd = 150252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetFirstSlotContainingTemplateItem(ItemInstance templateItem, ITransitEntity.ESlotType searchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(templateItem);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref searchType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x0001DACF File Offset: 0x0001BCCF
		public ITransitEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002810 RID: 10256
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002811 RID: 10257
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x04002812 RID: 10258
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04002813 RID: 10259
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x04002814 RID: 10260
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04002815 RID: 10261
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x04002816 RID: 10262
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04002817 RID: 10263
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002818 RID: 10264
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002819 RID: 10265
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400281A RID: 10266
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x0400281B RID: 10267
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0;

		// Token: 0x0400281C RID: 10268
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400281D RID: 10269
		private static readonly IntPtr NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0;

		// Token: 0x0400281E RID: 10270
		private static readonly IntPtr NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0;

		// Token: 0x0400281F RID: 10271
		private static readonly IntPtr NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_Boolean_0;

		// Token: 0x04002820 RID: 10272
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0;

		// Token: 0x04002821 RID: 10273
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0;

		// Token: 0x04002822 RID: 10274
		private static readonly IntPtr NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0;

		// Token: 0x04002823 RID: 10275
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0;

		// Token: 0x04002824 RID: 10276
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0;

		// Token: 0x04002825 RID: 10277
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0;

		// Token: 0x02000A34 RID: 2612
		[OriginalName("Assembly-CSharp.dll", "", "ESlotType")]
		public enum ESlotType
		{
			// Token: 0x04009800 RID: 38912
			Input,
			// Token: 0x04009801 RID: 38913
			Output,
			// Token: 0x04009802 RID: 38914
			Both
		}

		// Token: 0x02000A35 RID: 2613
		[ObfuscatedName("ScheduleOne.Management.ITransitEntity+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF30 RID: 57136 RVA: 0x0036F8AC File Offset: 0x0036DAAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr);
				ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, "item");
				ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, 100670925);
				ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, 100670926);
			}

			// Token: 0x0600DF31 RID: 57137 RVA: 0x0036F914 File Offset: 0x0036DB14
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF32 RID: 57138 RVA: 0x0036F950 File Offset: 0x0036DB50
			[CallerCount(0)]
			public unsafe bool _GetOutputItemContainer_b__0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF33 RID: 57139 RVA: 0x000691A5 File Offset: 0x000673A5
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F2 RID: 17394
			// (get) Token: 0x0600DF34 RID: 57140 RVA: 0x0036F9A0 File Offset: 0x0036DBA0
			// (set) Token: 0x0600DF35 RID: 57141 RVA: 0x000691AE File Offset: 0x000673AE
			public unsafe ItemInstance item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009803 RID: 38915
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04009804 RID: 38916
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009805 RID: 38917
			private static readonly IntPtr NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0;
		}
	}
}

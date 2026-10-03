using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Trash;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000660 RID: 1632
	public class ApplyAdditiveToGrowContainerBehaviour : GrowContainerBehaviour
	{
		// Token: 0x06009C35 RID: 39989 RVA: 0x0029BC48 File Offset: 0x00299E48
		// Note: this type is marked as 'beforefieldinit'.
		static ApplyAdditiveToGrowContainerBehaviour()
		{
			Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "ApplyAdditiveToGrowContainerBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr);
			ApplyAdditiveToGrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.ApplyAdditiveToGrowContainerBehaviourAssembly-CSharp.dll_Excuted");
			ApplyAdditiveToGrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.ApplyAdditiveToGrowContainerBehaviourAssembly-CSharp.dll_Excuted");
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683690);
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683691);
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683692);
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_GetRequiredItemSuitableIDs_Protected_Virtual_Il2CppStringArray_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683693);
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683694);
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683695);
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_GetTrashPrefab_Protected_Virtual_TrashItem_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683696);
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683697);
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683698);
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683699);
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683700);
			ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr, 100683701);
		}

		// Token: 0x06009C36 RID: 39990 RVA: 0x0029BD90 File Offset: 0x00299F90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 277878, RefRangeEnd = 277881, XrefRangeStart = 277878, XrefRangeEnd = 277881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetActionDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009C37 RID: 39991 RVA: 0x0029BDD8 File Offset: 0x00299FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277912, XrefRangeEnd = 277914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAnimationBool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009C38 RID: 39992 RVA: 0x0029BE1C File Offset: 0x0029A01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277914, XrefRangeEnd = 277917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AvatarEquippable GetActionEquippable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_AvatarEquippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
		}

		// Token: 0x06009C39 RID: 39993 RVA: 0x0029BE68 File Offset: 0x0029A068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277917, XrefRangeEnd = 277945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStringArray GetRequiredItemSuitableIDs(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_GetRequiredItemSuitableIDs_Protected_Virtual_Il2CppStringArray_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06009C3A RID: 39994 RVA: 0x0029BEC4 File Offset: 0x0029A0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277945, XrefRangeEnd = 277948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActionSuccess(ItemInstance usedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(usedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C3B RID: 39995 RVA: 0x0029BF14 File Offset: 0x0029A114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277948, XrefRangeEnd = 277953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009C3C RID: 39996 RVA: 0x0029BF6C File Offset: 0x0029A16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277953, XrefRangeEnd = 277962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TrashItem GetTrashPrefab(ItemInstance usedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(usedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_GetTrashPrefab_Protected_Virtual_TrashItem_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x06009C3D RID: 39997 RVA: 0x0029BFC8 File Offset: 0x0029A1C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276250, RefRangeEnd = 276252, XrefRangeStart = 276250, XrefRangeEnd = 276252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplyAdditiveToGrowContainerBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplyAdditiveToGrowContainerBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C3E RID: 39998 RVA: 0x0029C004 File Offset: 0x0029A204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C3F RID: 39999 RVA: 0x0029C040 File Offset: 0x0029A240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C40 RID: 40000 RVA: 0x0029C07C File Offset: 0x0029A27C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C41 RID: 40001 RVA: 0x0029C0B8 File Offset: 0x0029A2B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277911, RefRangeEnd = 277912, XrefRangeStart = 277911, XrefRangeEnd = 277912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ApplyAdditiveToGrowContainerBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009C42 RID: 40002 RVA: 0x000487FF File Offset: 0x000469FF
		public ApplyAdditiveToGrowContainerBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x06009C43 RID: 40003 RVA: 0x0029C0F4 File Offset: 0x0029A2F4
		// (set) Token: 0x06009C44 RID: 40004 RVA: 0x00048808 File Offset: 0x00046A08
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyAdditiveToGrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyAdditiveToGrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x06009C45 RID: 40005 RVA: 0x0029C11C File Offset: 0x0029A31C
		// (set) Token: 0x06009C46 RID: 40006 RVA: 0x00048823 File Offset: 0x00046A23
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyAdditiveToGrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ApplyAdditiveToGrowContainerBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006B74 RID: 27508
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006B75 RID: 27509
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006B76 RID: 27510
		private static readonly IntPtr NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0;

		// Token: 0x04006B77 RID: 27511
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0;

		// Token: 0x04006B78 RID: 27512
		private static readonly IntPtr NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_AvatarEquippable_0;

		// Token: 0x04006B79 RID: 27513
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredItemSuitableIDs_Protected_Virtual_Il2CppStringArray_GrowContainer_0;

		// Token: 0x04006B7A RID: 27514
		private static readonly IntPtr NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0;

		// Token: 0x04006B7B RID: 27515
		private static readonly IntPtr NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0;

		// Token: 0x04006B7C RID: 27516
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashPrefab_Protected_Virtual_TrashItem_ItemInstance_0;

		// Token: 0x04006B7D RID: 27517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006B7E RID: 27518
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006B7F RID: 27519
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006B80 RID: 27520
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006B81 RID: 27521
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Trash;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200066E RID: 1646
	public class SowSeedInPotBehaviour : GrowContainerBehaviour
	{
		// Token: 0x06009E3C RID: 40508 RVA: 0x002A3EBC File Offset: 0x002A20BC
		// Note: this type is marked as 'beforefieldinit'.
		static SowSeedInPotBehaviour()
		{
			Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "SowSeedInPotBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr);
			SowSeedInPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SowSeedInPotBehaviourAssembly-CSharp.dll_Excuted");
			SowSeedInPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SowSeedInPotBehaviourAssembly-CSharp.dll_Excuted");
			SowSeedInPotBehaviour.NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684108);
			SowSeedInPotBehaviour.NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684109);
			SowSeedInPotBehaviour.NativeMethodInfoPtr_OnStartPerformAction_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684110);
			SowSeedInPotBehaviour.NativeMethodInfoPtr_OnStopPerformAction_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684111);
			SowSeedInPotBehaviour.NativeMethodInfoPtr_GetRequiredItemSuitableIDs_Protected_Virtual_Il2CppStringArray_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684112);
			SowSeedInPotBehaviour.NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684113);
			SowSeedInPotBehaviour.NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684114);
			SowSeedInPotBehaviour.NativeMethodInfoPtr_GetTrashPrefab_Protected_Virtual_TrashItem_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684115);
			SowSeedInPotBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684116);
			SowSeedInPotBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684117);
			SowSeedInPotBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684118);
			SowSeedInPotBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684119);
			SowSeedInPotBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr, 100684120);
		}

		// Token: 0x06009E3D RID: 40509 RVA: 0x002A4018 File Offset: 0x002A2218
		[CallerCount(0)]
		public unsafe override float GetActionDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009E3E RID: 40510 RVA: 0x002A4060 File Offset: 0x002A2260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280437, XrefRangeEnd = 280439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAnimationBool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009E3F RID: 40511 RVA: 0x002A40A4 File Offset: 0x002A22A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280439, XrefRangeEnd = 280443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartPerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_OnStartPerformAction_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E40 RID: 40512 RVA: 0x002A40E0 File Offset: 0x002A22E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280443, XrefRangeEnd = 280447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStopPerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_OnStopPerformAction_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E41 RID: 40513 RVA: 0x002A411C File Offset: 0x002A231C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280447, XrefRangeEnd = 280455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStringArray GetRequiredItemSuitableIDs(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_GetRequiredItemSuitableIDs_Protected_Virtual_Il2CppStringArray_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06009E42 RID: 40514 RVA: 0x002A4178 File Offset: 0x002A2378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280455, XrefRangeEnd = 280459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActionSuccess(ItemInstance usedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(usedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x002A41C8 File Offset: 0x002A23C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280459, XrefRangeEnd = 280463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009E44 RID: 40516 RVA: 0x002A4220 File Offset: 0x002A2420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280463, XrefRangeEnd = 280470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override TrashItem GetTrashPrefab(ItemInstance usedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(usedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_GetTrashPrefab_Protected_Virtual_TrashItem_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr3) : null;
		}

		// Token: 0x06009E45 RID: 40517 RVA: 0x002A427C File Offset: 0x002A247C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280471, RefRangeEnd = 280472, XrefRangeStart = 280470, XrefRangeEnd = 280471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SowSeedInPotBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SowSeedInPotBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SowSeedInPotBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E46 RID: 40518 RVA: 0x002A42B8 File Offset: 0x002A24B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280472, XrefRangeEnd = 280473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E47 RID: 40519 RVA: 0x002A42F4 File Offset: 0x002A24F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280473, XrefRangeEnd = 280474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E48 RID: 40520 RVA: 0x002A4330 File Offset: 0x002A2530
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E49 RID: 40521 RVA: 0x002A436C File Offset: 0x002A256C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277911, RefRangeEnd = 277912, XrefRangeStart = 277911, XrefRangeEnd = 277912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SowSeedInPotBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x00049158 File Offset: 0x00047358
		public SowSeedInPotBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x06009E4B RID: 40523 RVA: 0x002A43A8 File Offset: 0x002A25A8
		// (set) Token: 0x06009E4C RID: 40524 RVA: 0x00049161 File Offset: 0x00047361
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedInPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedInPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x06009E4D RID: 40525 RVA: 0x002A43D0 File Offset: 0x002A25D0
		// (set) Token: 0x06009E4E RID: 40526 RVA: 0x0004917C File Offset: 0x0004737C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedInPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SowSeedInPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006D0C RID: 27916
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006D0D RID: 27917
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006D0E RID: 27918
		private static readonly IntPtr NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0;

		// Token: 0x04006D0F RID: 27919
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0;

		// Token: 0x04006D10 RID: 27920
		private static readonly IntPtr NativeMethodInfoPtr_OnStartPerformAction_Protected_Virtual_Void_0;

		// Token: 0x04006D11 RID: 27921
		private static readonly IntPtr NativeMethodInfoPtr_OnStopPerformAction_Protected_Virtual_Void_0;

		// Token: 0x04006D12 RID: 27922
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredItemSuitableIDs_Protected_Virtual_Il2CppStringArray_GrowContainer_0;

		// Token: 0x04006D13 RID: 27923
		private static readonly IntPtr NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0;

		// Token: 0x04006D14 RID: 27924
		private static readonly IntPtr NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0;

		// Token: 0x04006D15 RID: 27925
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashPrefab_Protected_Virtual_TrashItem_ItemInstance_0;

		// Token: 0x04006D16 RID: 27926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006D17 RID: 27927
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006D18 RID: 27928
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006D19 RID: 27929
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006D1A RID: 27930
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}

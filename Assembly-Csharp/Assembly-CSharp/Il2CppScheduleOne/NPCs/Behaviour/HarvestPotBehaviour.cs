using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000669 RID: 1641
	public class HarvestPotBehaviour : GrowContainerBehaviour
	{
		// Token: 0x06009D7E RID: 40318 RVA: 0x002A0F3C File Offset: 0x0029F13C
		// Note: this type is marked as 'beforefieldinit'.
		static HarvestPotBehaviour()
		{
			Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "HarvestPotBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr);
			HarvestPotBehaviour.NativeFieldInfoPtr_TrimmersEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, "TrimmersEquippable");
			HarvestPotBehaviour.NativeFieldInfoPtr__pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, "_pot");
			HarvestPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.HarvestPotBehaviourAssembly-CSharp.dll_Excuted");
			HarvestPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.HarvestPotBehaviourAssembly-CSharp.dll_Excuted");
			HarvestPotBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683956);
			HarvestPotBehaviour.NativeMethodInfoPtr_AssignAndEnable_Public_Virtual_Void_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683957);
			HarvestPotBehaviour.NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683958);
			HarvestPotBehaviour.NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683959);
			HarvestPotBehaviour.NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683960);
			HarvestPotBehaviour.NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683961);
			HarvestPotBehaviour.NativeMethodInfoPtr_GetQuantityToHarvest_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683962);
			HarvestPotBehaviour.NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683963);
			HarvestPotBehaviour.NativeMethodInfoPtr_CheckSuccess_Protected_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683964);
			HarvestPotBehaviour.NativeMethodInfoPtr_DoesPotHaveValidDestination_Public_Boolean_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683965);
			HarvestPotBehaviour.NativeMethodInfoPtr_GetDestinationCapacityForItem_Private_Int32_Pot_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683966);
			HarvestPotBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683967);
			HarvestPotBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683968);
			HarvestPotBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683969);
			HarvestPotBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683970);
			HarvestPotBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr, 100683971);
		}

		// Token: 0x06009D7F RID: 40319 RVA: 0x002A10FC File Offset: 0x0029F2FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277911, RefRangeEnd = 277912, XrefRangeStart = 277911, XrefRangeEnd = 277912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D80 RID: 40320 RVA: 0x002A1138 File Offset: 0x0029F338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279404, XrefRangeEnd = 279413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AssignAndEnable(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_AssignAndEnable_Public_Virtual_Void_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D81 RID: 40321 RVA: 0x002A1188 File Offset: 0x0029F388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279413, XrefRangeEnd = 279414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetActionDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D82 RID: 40322 RVA: 0x002A11D0 File Offset: 0x0029F3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279414, XrefRangeEnd = 279416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAnimationBool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009D83 RID: 40323 RVA: 0x002A1214 File Offset: 0x0029F414
		[CallerCount(0)]
		public unsafe override AvatarEquippable GetActionEquippable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_AvatarEquippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
		}

		// Token: 0x06009D84 RID: 40324 RVA: 0x002A1260 File Offset: 0x0029F460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279416, XrefRangeEnd = 279443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActionSuccess(ItemInstance usedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(usedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D85 RID: 40325 RVA: 0x002A12B0 File Offset: 0x0029F4B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279453, RefRangeEnd = 279455, XrefRangeStart = 279443, XrefRangeEnd = 279453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetQuantityToHarvest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPotBehaviour.NativeMethodInfoPtr_GetQuantityToHarvest_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D86 RID: 40326 RVA: 0x002A12EC File Offset: 0x0029F4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279455, XrefRangeEnd = 279461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D87 RID: 40327 RVA: 0x002A1344 File Offset: 0x0029F544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279461, XrefRangeEnd = 279462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckSuccess(ItemInstance usedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(usedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_CheckSuccess_Protected_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D88 RID: 40328 RVA: 0x002A139C File Offset: 0x0029F59C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279463, RefRangeEnd = 279464, XrefRangeStart = 279462, XrefRangeEnd = 279463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesPotHaveValidDestination(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPotBehaviour.NativeMethodInfoPtr_DoesPotHaveValidDestination_Public_Boolean_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D89 RID: 40329 RVA: 0x002A13EC File Offset: 0x0029F5EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 279478, RefRangeEnd = 279481, XrefRangeStart = 279464, XrefRangeEnd = 279478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDestinationCapacityForItem(Pot pot, ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPotBehaviour.NativeMethodInfoPtr_GetDestinationCapacityForItem_Private_Int32_Pot_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x002A144C File Offset: 0x0029F64C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276250, RefRangeEnd = 276252, XrefRangeStart = 276250, XrefRangeEnd = 276252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HarvestPotBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HarvestPotBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestPotBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x002A1488 File Offset: 0x0029F688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x002A14C4 File Offset: 0x0029F6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D8D RID: 40333 RVA: 0x002A1500 File Offset: 0x0029F700
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D8E RID: 40334 RVA: 0x002A153C File Offset: 0x0029F73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestPotBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D8F RID: 40335 RVA: 0x00048DBA File Offset: 0x00046FBA
		public HarvestPotBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x06009D90 RID: 40336 RVA: 0x002A1578 File Offset: 0x0029F778
		// (set) Token: 0x06009D91 RID: 40337 RVA: 0x00048DC3 File Offset: 0x00046FC3
		public unsafe AvatarEquippable TrimmersEquippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPotBehaviour.NativeFieldInfoPtr_TrimmersEquippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPotBehaviour.NativeFieldInfoPtr_TrimmersEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x06009D92 RID: 40338 RVA: 0x002A15A8 File Offset: 0x0029F7A8
		// (set) Token: 0x06009D93 RID: 40339 RVA: 0x00048DE2 File Offset: 0x00046FE2
		public unsafe Pot _pot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPotBehaviour.NativeFieldInfoPtr__pot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPotBehaviour.NativeFieldInfoPtr__pot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x06009D94 RID: 40340 RVA: 0x002A15D8 File Offset: 0x0029F7D8
		// (set) Token: 0x06009D95 RID: 40341 RVA: 0x00048E01 File Offset: 0x00047001
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x06009D96 RID: 40342 RVA: 0x002A1600 File Offset: 0x0029F800
		// (set) Token: 0x06009D97 RID: 40343 RVA: 0x00048E1C File Offset: 0x0004701C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestPotBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006C78 RID: 27768
		private static readonly IntPtr NativeFieldInfoPtr_TrimmersEquippable;

		// Token: 0x04006C79 RID: 27769
		private static readonly IntPtr NativeFieldInfoPtr__pot;

		// Token: 0x04006C7A RID: 27770
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006C7B RID: 27771
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006C7C RID: 27772
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006C7D RID: 27773
		private static readonly IntPtr NativeMethodInfoPtr_AssignAndEnable_Public_Virtual_Void_GrowContainer_0;

		// Token: 0x04006C7E RID: 27774
		private static readonly IntPtr NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0;

		// Token: 0x04006C7F RID: 27775
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0;

		// Token: 0x04006C80 RID: 27776
		private static readonly IntPtr NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_AvatarEquippable_0;

		// Token: 0x04006C81 RID: 27777
		private static readonly IntPtr NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0;

		// Token: 0x04006C82 RID: 27778
		private static readonly IntPtr NativeMethodInfoPtr_GetQuantityToHarvest_Private_Int32_0;

		// Token: 0x04006C83 RID: 27779
		private static readonly IntPtr NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0;

		// Token: 0x04006C84 RID: 27780
		private static readonly IntPtr NativeMethodInfoPtr_CheckSuccess_Protected_Virtual_Boolean_ItemInstance_0;

		// Token: 0x04006C85 RID: 27781
		private static readonly IntPtr NativeMethodInfoPtr_DoesPotHaveValidDestination_Public_Boolean_Pot_0;

		// Token: 0x04006C86 RID: 27782
		private static readonly IntPtr NativeMethodInfoPtr_GetDestinationCapacityForItem_Private_Int32_Pot_ItemInstance_0;

		// Token: 0x04006C87 RID: 27783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006C88 RID: 27784
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006C89 RID: 27785
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006C8A RID: 27786
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006C8B RID: 27787
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}

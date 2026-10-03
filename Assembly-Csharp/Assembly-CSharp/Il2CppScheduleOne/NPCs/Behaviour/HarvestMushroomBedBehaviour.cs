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
	// Token: 0x02000668 RID: 1640
	public class HarvestMushroomBedBehaviour : GrowContainerBehaviour
	{
		// Token: 0x06009D64 RID: 40292 RVA: 0x002A0850 File Offset: 0x0029EA50
		// Note: this type is marked as 'beforefieldinit'.
		static HarvestMushroomBedBehaviour()
		{
			Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "HarvestMushroomBedBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr);
			HarvestMushroomBedBehaviour.NativeFieldInfoPtr_TrimmersEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, "TrimmersEquippable");
			HarvestMushroomBedBehaviour.NativeFieldInfoPtr__bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, "_bed");
			HarvestMushroomBedBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.HarvestMushroomBedBehaviourAssembly-CSharp.dll_Excuted");
			HarvestMushroomBedBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.HarvestMushroomBedBehaviourAssembly-CSharp.dll_Excuted");
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683940);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_AssignAndEnable_Public_Virtual_Void_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683941);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683942);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683943);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683944);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683945);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_GetQuantityToHarvest_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683946);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683947);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_CheckSuccess_Protected_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683948);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_DoesMushroomBedHaveValidDestination_Public_Boolean_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683949);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_GetDestinationCapacityForItem_Private_Int32_MushroomBed_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683950);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683951);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683952);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683953);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683954);
			HarvestMushroomBedBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr, 100683955);
		}

		// Token: 0x06009D65 RID: 40293 RVA: 0x002A0A10 File Offset: 0x0029EC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277911, RefRangeEnd = 277912, XrefRangeStart = 277911, XrefRangeEnd = 277912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D66 RID: 40294 RVA: 0x002A0A4C File Offset: 0x0029EC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279323, XrefRangeEnd = 279332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AssignAndEnable(GrowContainer growContainer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(growContainer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_AssignAndEnable_Public_Virtual_Void_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D67 RID: 40295 RVA: 0x002A0A9C File Offset: 0x0029EC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279332, XrefRangeEnd = 279333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetActionDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D68 RID: 40296 RVA: 0x002A0AE4 File Offset: 0x0029ECE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279333, XrefRangeEnd = 279335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetAnimationBool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009D69 RID: 40297 RVA: 0x002A0B28 File Offset: 0x0029ED28
		[CallerCount(0)]
		public unsafe override AvatarEquippable GetActionEquippable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_AvatarEquippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
		}

		// Token: 0x06009D6A RID: 40298 RVA: 0x002A0B74 File Offset: 0x0029ED74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279335, XrefRangeEnd = 279359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActionSuccess(ItemInstance usedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(usedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D6B RID: 40299 RVA: 0x002A0BC4 File Offset: 0x0029EDC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 279370, RefRangeEnd = 279372, XrefRangeStart = 279359, XrefRangeEnd = 279370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetQuantityToHarvest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestMushroomBedBehaviour.NativeMethodInfoPtr_GetQuantityToHarvest_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D6C RID: 40300 RVA: 0x002A0C00 File Offset: 0x0029EE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279372, XrefRangeEnd = 279379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AreTaskConditionsMetForContainer(GrowContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D6D RID: 40301 RVA: 0x002A0C58 File Offset: 0x0029EE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279379, XrefRangeEnd = 279381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckSuccess(ItemInstance usedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(usedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_CheckSuccess_Protected_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D6E RID: 40302 RVA: 0x002A0CB0 File Offset: 0x0029EEB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279383, RefRangeEnd = 279384, XrefRangeStart = 279381, XrefRangeEnd = 279383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesMushroomBedHaveValidDestination(MushroomBed bed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestMushroomBedBehaviour.NativeMethodInfoPtr_DoesMushroomBedHaveValidDestination_Public_Boolean_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D6F RID: 40303 RVA: 0x002A0D00 File Offset: 0x0029EF00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 279398, RefRangeEnd = 279401, XrefRangeStart = 279384, XrefRangeEnd = 279398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDestinationCapacityForItem(MushroomBed bed, ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestMushroomBedBehaviour.NativeMethodInfoPtr_GetDestinationCapacityForItem_Private_Int32_MushroomBed_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009D70 RID: 40304 RVA: 0x002A0D60 File Offset: 0x0029EF60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276250, RefRangeEnd = 276252, XrefRangeStart = 276250, XrefRangeEnd = 276252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HarvestMushroomBedBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HarvestMushroomBedBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HarvestMushroomBedBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D71 RID: 40305 RVA: 0x002A0D9C File Offset: 0x0029EF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279401, XrefRangeEnd = 279402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D72 RID: 40306 RVA: 0x002A0DD8 File Offset: 0x0029EFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279402, XrefRangeEnd = 279403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D73 RID: 40307 RVA: 0x002A0E14 File Offset: 0x0029F014
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D74 RID: 40308 RVA: 0x002A0E50 File Offset: 0x0029F050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279403, XrefRangeEnd = 279404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HarvestMushroomBedBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D75 RID: 40309 RVA: 0x00048D3D File Offset: 0x00046F3D
		public HarvestMushroomBedBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x06009D76 RID: 40310 RVA: 0x002A0E8C File Offset: 0x0029F08C
		// (set) Token: 0x06009D77 RID: 40311 RVA: 0x00048D46 File Offset: 0x00046F46
		public unsafe AvatarEquippable TrimmersEquippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedBehaviour.NativeFieldInfoPtr_TrimmersEquippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedBehaviour.NativeFieldInfoPtr_TrimmersEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x06009D78 RID: 40312 RVA: 0x002A0EBC File Offset: 0x0029F0BC
		// (set) Token: 0x06009D79 RID: 40313 RVA: 0x00048D65 File Offset: 0x00046F65
		public unsafe MushroomBed _bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedBehaviour.NativeFieldInfoPtr__bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedBehaviour.NativeFieldInfoPtr__bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x06009D7A RID: 40314 RVA: 0x002A0EEC File Offset: 0x0029F0EC
		// (set) Token: 0x06009D7B RID: 40315 RVA: 0x00048D84 File Offset: 0x00046F84
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x06009D7C RID: 40316 RVA: 0x002A0F14 File Offset: 0x0029F114
		// (set) Token: 0x06009D7D RID: 40317 RVA: 0x00048D9F File Offset: 0x00046F9F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HarvestMushroomBedBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006C64 RID: 27748
		private static readonly IntPtr NativeFieldInfoPtr_TrimmersEquippable;

		// Token: 0x04006C65 RID: 27749
		private static readonly IntPtr NativeFieldInfoPtr__bed;

		// Token: 0x04006C66 RID: 27750
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006C67 RID: 27751
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006C68 RID: 27752
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006C69 RID: 27753
		private static readonly IntPtr NativeMethodInfoPtr_AssignAndEnable_Public_Virtual_Void_GrowContainer_0;

		// Token: 0x04006C6A RID: 27754
		private static readonly IntPtr NativeMethodInfoPtr_GetActionDuration_Protected_Virtual_Single_0;

		// Token: 0x04006C6B RID: 27755
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationBool_Protected_Virtual_String_0;

		// Token: 0x04006C6C RID: 27756
		private static readonly IntPtr NativeMethodInfoPtr_GetActionEquippable_Protected_Virtual_AvatarEquippable_0;

		// Token: 0x04006C6D RID: 27757
		private static readonly IntPtr NativeMethodInfoPtr_OnActionSuccess_Protected_Virtual_Void_ItemInstance_0;

		// Token: 0x04006C6E RID: 27758
		private static readonly IntPtr NativeMethodInfoPtr_GetQuantityToHarvest_Private_Int32_0;

		// Token: 0x04006C6F RID: 27759
		private static readonly IntPtr NativeMethodInfoPtr_AreTaskConditionsMetForContainer_Public_Virtual_Boolean_GrowContainer_0;

		// Token: 0x04006C70 RID: 27760
		private static readonly IntPtr NativeMethodInfoPtr_CheckSuccess_Protected_Virtual_Boolean_ItemInstance_0;

		// Token: 0x04006C71 RID: 27761
		private static readonly IntPtr NativeMethodInfoPtr_DoesMushroomBedHaveValidDestination_Public_Boolean_MushroomBed_0;

		// Token: 0x04006C72 RID: 27762
		private static readonly IntPtr NativeMethodInfoPtr_GetDestinationCapacityForItem_Private_Int32_MushroomBed_ItemInstance_0;

		// Token: 0x04006C73 RID: 27763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006C74 RID: 27764
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006C75 RID: 27765
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006C76 RID: 27766
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006C77 RID: 27767
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}

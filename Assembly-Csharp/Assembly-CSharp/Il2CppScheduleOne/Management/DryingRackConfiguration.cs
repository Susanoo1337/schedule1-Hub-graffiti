using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002D8 RID: 728
	public class DryingRackConfiguration : EntityConfiguration
	{
		// Token: 0x0600398C RID: 14732 RVA: 0x0013BF4C File Offset: 0x0013A14C
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackConfiguration()
		{
			Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "DryingRackConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr);
			DryingRackConfiguration.NativeFieldInfoPtr__Rack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, "<Rack>k__BackingField");
			DryingRackConfiguration.NativeFieldInfoPtr_AssignedBotanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, "AssignedBotanist");
			DryingRackConfiguration.NativeFieldInfoPtr_TargetQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, "TargetQuality");
			DryingRackConfiguration.NativeFieldInfoPtr_StartThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, "StartThreshold");
			DryingRackConfiguration.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, "Destination");
			DryingRackConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, "<DestinationRoute>k__BackingField");
			DryingRackConfiguration.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670644);
			DryingRackConfiguration.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670645);
			DryingRackConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670646);
			DryingRackConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670647);
			DryingRackConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670648);
			DryingRackConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670649);
			DryingRackConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670650);
			DryingRackConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670651);
			DryingRackConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670652);
			DryingRackConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670653);
			DryingRackConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670654);
			DryingRackConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670655);
			DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__12_0_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670656);
			DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__12_1_Private_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670657);
			DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__12_2_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670658);
			DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__12_3_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100670659);
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x0013C134 File Offset: 0x0013A334
		// (set) Token: 0x0600398E RID: 14734 RVA: 0x0013C174 File Offset: 0x0013A374
		public unsafe DryingRack Rack
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x0600398F RID: 14735 RVA: 0x0013C1B8 File Offset: 0x0013A3B8
		// (set) Token: 0x06003990 RID: 14736 RVA: 0x0013C1F8 File Offset: 0x0013A3F8
		public unsafe TransitRoute DestinationRoute
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 21999, RefRangeEnd = 22015, XrefRangeStart = 21999, XrefRangeEnd = 22015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x0013C23C File Offset: 0x0013A43C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 147672, RefRangeEnd = 147673, XrefRangeStart = 147589, XrefRangeEnd = 147672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, DryingRack rack) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x0013C2AC File Offset: 0x0013A4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147673, XrefRangeEnd = 147675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x0013C2E8 File Offset: 0x0013A4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147675, XrefRangeEnd = 147684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationChanged(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x0013C32C File Offset: 0x0013A52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147684, XrefRangeEnd = 147701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DestinationFilter(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x0013C394 File Offset: 0x0013A594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147701, XrefRangeEnd = 147702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x0013C3D0 File Offset: 0x0013A5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147702, XrefRangeEnd = 147703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x0013C40C File Offset: 0x0013A60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147703, XrefRangeEnd = 147707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x0013C454 File Offset: 0x0013A654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147707, XrefRangeEnd = 147716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0013C498 File Offset: 0x0013A698
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__12_0(NPC <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__12_0_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x0013C4DC File Offset: 0x0013A6DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__12_1(EQuality <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__12_1_Private_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x0013C51C File Offset: 0x0013A71C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__12_2(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__12_2_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x0013C560 File Offset: 0x0013A760
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__12_3(float <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__12_3_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x0001CF53 File Offset: 0x0001B153
		public DryingRackConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x0013C5A0 File Offset: 0x0013A7A0
		// (set) Token: 0x0600399F RID: 14751 RVA: 0x0001CF5C File Offset: 0x0001B15C
		public unsafe DryingRack _Rack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr__Rack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr__Rack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060039A0 RID: 14752 RVA: 0x0013C5D0 File Offset: 0x0013A7D0
		// (set) Token: 0x060039A1 RID: 14753 RVA: 0x0001CF7B File Offset: 0x0001B17B
		public unsafe NPCField AssignedBotanist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_AssignedBotanist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_AssignedBotanist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060039A2 RID: 14754 RVA: 0x0013C600 File Offset: 0x0013A800
		// (set) Token: 0x060039A3 RID: 14755 RVA: 0x0001CF9A File Offset: 0x0001B19A
		public unsafe QualityField TargetQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_TargetQuality);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_TargetQuality), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060039A4 RID: 14756 RVA: 0x0013C630 File Offset: 0x0013A830
		// (set) Token: 0x060039A5 RID: 14757 RVA: 0x0001CFB9 File Offset: 0x0001B1B9
		public unsafe NumberField StartThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_StartThreshold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_StartThreshold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060039A6 RID: 14758 RVA: 0x0013C660 File Offset: 0x0013A860
		// (set) Token: 0x060039A7 RID: 14759 RVA: 0x0001CFD8 File Offset: 0x0001B1D8
		public unsafe ObjectField Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x0013C690 File Offset: 0x0013A890
		// (set) Token: 0x060039A9 RID: 14761 RVA: 0x0001CFF7 File Offset: 0x0001B1F7
		public unsafe TransitRoute _DestinationRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026AC RID: 9900
		private static readonly IntPtr NativeFieldInfoPtr__Rack_k__BackingField;

		// Token: 0x040026AD RID: 9901
		private static readonly IntPtr NativeFieldInfoPtr_AssignedBotanist;

		// Token: 0x040026AE RID: 9902
		private static readonly IntPtr NativeFieldInfoPtr_TargetQuality;

		// Token: 0x040026AF RID: 9903
		private static readonly IntPtr NativeFieldInfoPtr_StartThreshold;

		// Token: 0x040026B0 RID: 9904
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x040026B1 RID: 9905
		private static readonly IntPtr NativeFieldInfoPtr__DestinationRoute_k__BackingField;

		// Token: 0x040026B2 RID: 9906
		private static readonly IntPtr NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0;

		// Token: 0x040026B3 RID: 9907
		private static readonly IntPtr NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0;

		// Token: 0x040026B4 RID: 9908
		private static readonly IntPtr NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0;

		// Token: 0x040026B5 RID: 9909
		private static readonly IntPtr NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0;

		// Token: 0x040026B6 RID: 9910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_DryingRack_0;

		// Token: 0x040026B7 RID: 9911
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x040026B8 RID: 9912
		private static readonly IntPtr NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0;

		// Token: 0x040026B9 RID: 9913
		private static readonly IntPtr NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0;

		// Token: 0x040026BA RID: 9914
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_Void_0;

		// Token: 0x040026BB RID: 9915
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0;

		// Token: 0x040026BC RID: 9916
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x040026BD RID: 9917
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x040026BE RID: 9918
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__12_0_Private_Void_NPC_0;

		// Token: 0x040026BF RID: 9919
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__12_1_Private_Void_EQuality_0;

		// Token: 0x040026C0 RID: 9920
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__12_2_Private_Void_BuildableItem_0;

		// Token: 0x040026C1 RID: 9921
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__12_3_Private_Void_Single_0;
	}
}

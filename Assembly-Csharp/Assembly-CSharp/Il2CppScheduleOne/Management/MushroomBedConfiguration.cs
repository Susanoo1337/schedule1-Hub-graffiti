using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002DC RID: 732
	public class MushroomBedConfiguration : EntityConfiguration
	{
		// Token: 0x06003A02 RID: 14850 RVA: 0x0013DD08 File Offset: 0x0013BF08
		// Note: this type is marked as 'beforefieldinit'.
		static MushroomBedConfiguration()
		{
			Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "MushroomBedConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr);
			MushroomBedConfiguration.NativeFieldInfoPtr__MushroomBed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, "<MushroomBed>k__BackingField");
			MushroomBedConfiguration.NativeFieldInfoPtr_Spawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, "Spawn");
			MushroomBedConfiguration.NativeFieldInfoPtr_Additive1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, "Additive1");
			MushroomBedConfiguration.NativeFieldInfoPtr_Additive2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, "Additive2");
			MushroomBedConfiguration.NativeFieldInfoPtr_Additive3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, "Additive3");
			MushroomBedConfiguration.NativeFieldInfoPtr_AssignedBotanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, "AssignedBotanist");
			MushroomBedConfiguration.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, "Destination");
			MushroomBedConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, "<DestinationRoute>k__BackingField");
			MushroomBedConfiguration.NativeMethodInfoPtr_get_MushroomBed_Public_get_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670710);
			MushroomBedConfiguration.NativeMethodInfoPtr_set_MushroomBed_Protected_set_Void_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670711);
			MushroomBedConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670712);
			MushroomBedConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670713);
			MushroomBedConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670714);
			MushroomBedConfiguration.NativeMethodInfoPtr_GetSelectedSeedIDs_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670715);
			MushroomBedConfiguration.NativeMethodInfoPtr_IsAdditiveSelected_Public_Boolean_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670716);
			MushroomBedConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670717);
			MushroomBedConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670718);
			MushroomBedConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670719);
			MushroomBedConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670720);
			MushroomBedConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670721);
			MushroomBedConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670722);
			MushroomBedConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670723);
			MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_0_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670724);
			MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_1_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670725);
			MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_2_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670726);
			MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_3_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670727);
			MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_4_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670728);
			MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_5_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, 100670729);
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06003A03 RID: 14851 RVA: 0x0013DF68 File Offset: 0x0013C168
		// (set) Token: 0x06003A04 RID: 14852 RVA: 0x0013DFA8 File Offset: 0x0013C1A8
		public unsafe MushroomBed MushroomBed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr_get_MushroomBed_Public_get_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr_set_MushroomBed_Protected_set_Void_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x06003A05 RID: 14853 RVA: 0x0013DFEC File Offset: 0x0013C1EC
		// (set) Token: 0x06003A06 RID: 14854 RVA: 0x0013E02C File Offset: 0x0013C22C
		public unsafe TransitRoute DestinationRoute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41608, RefRangeEnd = 41609, XrefRangeStart = 41608, XrefRangeEnd = 41609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A07 RID: 14855 RVA: 0x0013E070 File Offset: 0x0013C270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148151, RefRangeEnd = 148152, XrefRangeStart = 148035, XrefRangeEnd = 148151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MushroomBedConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, MushroomBed mushroomBed) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mushroomBed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A08 RID: 14856 RVA: 0x0013E0E0 File Offset: 0x0013C2E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148185, RefRangeEnd = 148186, XrefRangeStart = 148152, XrefRangeEnd = 148185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetSelectedSeedIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr_GetSelectedSeedIDs_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06003A09 RID: 14857 RVA: 0x0013E120 File Offset: 0x0013C320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148196, RefRangeEnd = 148197, XrefRangeStart = 148186, XrefRangeEnd = 148196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAdditiveSelected(ItemDefinition additive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(additive);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr_IsAdditiveSelected_Public_Boolean_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A0A RID: 14858 RVA: 0x0013E170 File Offset: 0x0013C370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148197, XrefRangeEnd = 148209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomBedConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x0013E1AC File Offset: 0x0013C3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148209, XrefRangeEnd = 148218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationChanged(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x0013E1F0 File Offset: 0x0013C3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148218, XrefRangeEnd = 148235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DestinationFilter(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x0013E258 File Offset: 0x0013C458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148235, XrefRangeEnd = 148236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomBedConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x0013E294 File Offset: 0x0013C494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148236, XrefRangeEnd = 148237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomBedConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x0013E2D0 File Offset: 0x0013C4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148237, XrefRangeEnd = 148256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomBedConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x0013E318 File Offset: 0x0013C518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148256, XrefRangeEnd = 148267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MushroomBedConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x0013E35C File Offset: 0x0013C55C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_0(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_0_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x0013E3A0 File Offset: 0x0013C5A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_1(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_1_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x0013E3E4 File Offset: 0x0013C5E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_2(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_2_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x0013E428 File Offset: 0x0013C628
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_3(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_3_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x0013E46C File Offset: 0x0013C66C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_4(NPC <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_4_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A16 RID: 14870 RVA: 0x0013E4B0 File Offset: 0x0013C6B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_5(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.NativeMethodInfoPtr___ctor_b__14_5_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A17 RID: 14871 RVA: 0x0001D20C File Offset: 0x0001B40C
		public MushroomBedConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x06003A18 RID: 14872 RVA: 0x0013E4F4 File Offset: 0x0013C6F4
		// (set) Token: 0x06003A19 RID: 14873 RVA: 0x0001D215 File Offset: 0x0001B415
		public unsafe MushroomBed _MushroomBed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr__MushroomBed_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr__MushroomBed_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x0013E524 File Offset: 0x0013C724
		// (set) Token: 0x06003A1B RID: 14875 RVA: 0x0001D234 File Offset: 0x0001B434
		public unsafe ItemField Spawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_Spawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_Spawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x06003A1C RID: 14876 RVA: 0x0013E554 File Offset: 0x0013C754
		// (set) Token: 0x06003A1D RID: 14877 RVA: 0x0001D253 File Offset: 0x0001B453
		public unsafe ItemField Additive1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_Additive1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_Additive1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x06003A1E RID: 14878 RVA: 0x0013E584 File Offset: 0x0013C784
		// (set) Token: 0x06003A1F RID: 14879 RVA: 0x0001D272 File Offset: 0x0001B472
		public unsafe ItemField Additive2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_Additive2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_Additive2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x06003A20 RID: 14880 RVA: 0x0013E5B4 File Offset: 0x0013C7B4
		// (set) Token: 0x06003A21 RID: 14881 RVA: 0x0001D291 File Offset: 0x0001B491
		public unsafe ItemField Additive3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_Additive3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_Additive3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06003A22 RID: 14882 RVA: 0x0013E5E4 File Offset: 0x0013C7E4
		// (set) Token: 0x06003A23 RID: 14883 RVA: 0x0001D2B0 File Offset: 0x0001B4B0
		public unsafe NPCField AssignedBotanist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_AssignedBotanist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_AssignedBotanist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x06003A24 RID: 14884 RVA: 0x0013E614 File Offset: 0x0013C814
		// (set) Token: 0x06003A25 RID: 14885 RVA: 0x0001D2CF File Offset: 0x0001B4CF
		public unsafe ObjectField Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06003A26 RID: 14886 RVA: 0x0013E644 File Offset: 0x0013C844
		// (set) Token: 0x06003A27 RID: 14887 RVA: 0x0001D2EE File Offset: 0x0001B4EE
		public unsafe TransitRoute _DestinationRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002704 RID: 9988
		private static readonly IntPtr NativeFieldInfoPtr__MushroomBed_k__BackingField;

		// Token: 0x04002705 RID: 9989
		private static readonly IntPtr NativeFieldInfoPtr_Spawn;

		// Token: 0x04002706 RID: 9990
		private static readonly IntPtr NativeFieldInfoPtr_Additive1;

		// Token: 0x04002707 RID: 9991
		private static readonly IntPtr NativeFieldInfoPtr_Additive2;

		// Token: 0x04002708 RID: 9992
		private static readonly IntPtr NativeFieldInfoPtr_Additive3;

		// Token: 0x04002709 RID: 9993
		private static readonly IntPtr NativeFieldInfoPtr_AssignedBotanist;

		// Token: 0x0400270A RID: 9994
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x0400270B RID: 9995
		private static readonly IntPtr NativeFieldInfoPtr__DestinationRoute_k__BackingField;

		// Token: 0x0400270C RID: 9996
		private static readonly IntPtr NativeMethodInfoPtr_get_MushroomBed_Public_get_MushroomBed_0;

		// Token: 0x0400270D RID: 9997
		private static readonly IntPtr NativeMethodInfoPtr_set_MushroomBed_Protected_set_Void_MushroomBed_0;

		// Token: 0x0400270E RID: 9998
		private static readonly IntPtr NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0;

		// Token: 0x0400270F RID: 9999
		private static readonly IntPtr NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0;

		// Token: 0x04002710 RID: 10000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_MushroomBed_0;

		// Token: 0x04002711 RID: 10001
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedSeedIDs_Public_Il2CppStringArray_0;

		// Token: 0x04002712 RID: 10002
		private static readonly IntPtr NativeMethodInfoPtr_IsAdditiveSelected_Public_Boolean_ItemDefinition_0;

		// Token: 0x04002713 RID: 10003
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04002714 RID: 10004
		private static readonly IntPtr NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002715 RID: 10005
		private static readonly IntPtr NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04002716 RID: 10006
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_Void_0;

		// Token: 0x04002717 RID: 10007
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0;

		// Token: 0x04002718 RID: 10008
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04002719 RID: 10009
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400271A RID: 10010
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_0_Private_Void_ItemDefinition_0;

		// Token: 0x0400271B RID: 10011
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_1_Private_Void_ItemDefinition_0;

		// Token: 0x0400271C RID: 10012
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_2_Private_Void_ItemDefinition_0;

		// Token: 0x0400271D RID: 10013
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_3_Private_Void_ItemDefinition_0;

		// Token: 0x0400271E RID: 10014
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_4_Private_Void_NPC_0;

		// Token: 0x0400271F RID: 10015
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_5_Private_Void_BuildableItem_0;

		// Token: 0x02000A31 RID: 2609
		[ObfuscatedName("ScheduleOne.Management.MushroomBedConfiguration+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600DF1A RID: 57114 RVA: 0x0036F4E8 File Offset: 0x0036D6E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MushroomBedConfiguration.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MushroomBedConfiguration>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomBedConfiguration.__c>.NativeClassPtr);
				MushroomBedConfiguration.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfiguration.__c>.NativeClassPtr, "<>9");
				MushroomBedConfiguration.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedConfiguration.__c>.NativeClassPtr, "<>9__15_0");
				MushroomBedConfiguration.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration.__c>.NativeClassPtr, 100670731);
				MushroomBedConfiguration.__c.NativeMethodInfoPtr__GetSelectedSeedIDs_b__15_0_Internal_String_ShroomSpawnDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedConfiguration.__c>.NativeClassPtr, 100670732);
			}

			// Token: 0x0600DF1B RID: 57115 RVA: 0x0036F564 File Offset: 0x0036D764
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomBedConfiguration.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF1C RID: 57116 RVA: 0x0036F5A0 File Offset: 0x0036D7A0
			[CallerCount(0)]
			public unsafe string _GetSelectedSeedIDs_b__15_0(ShroomSpawnDefinition s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedConfiguration.__c.NativeMethodInfoPtr__GetSelectedSeedIDs_b__15_0_Internal_String_ShroomSpawnDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DF1D RID: 57117 RVA: 0x00069123 File Offset: 0x00067323
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043ED RID: 17389
			// (get) Token: 0x0600DF1E RID: 57118 RVA: 0x0036F5E8 File Offset: 0x0036D7E8
			// (set) Token: 0x0600DF1F RID: 57119 RVA: 0x0006912C File Offset: 0x0006732C
			public unsafe static MushroomBedConfiguration.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MushroomBedConfiguration.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomBedConfiguration.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MushroomBedConfiguration.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043EE RID: 17390
			// (get) Token: 0x0600DF20 RID: 57120 RVA: 0x0036F610 File Offset: 0x0036D810
			// (set) Token: 0x0600DF21 RID: 57121 RVA: 0x0006913E File Offset: 0x0006733E
			public unsafe static Func<ShroomSpawnDefinition, string> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MushroomBedConfiguration.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ShroomSpawnDefinition, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MushroomBedConfiguration.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097F4 RID: 38900
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040097F5 RID: 38901
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040097F6 RID: 38902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097F7 RID: 38903
			private static readonly IntPtr NativeMethodInfoPtr__GetSelectedSeedIDs_b__15_0_Internal_String_ShroomSpawnDefinition_0;
		}
	}
}

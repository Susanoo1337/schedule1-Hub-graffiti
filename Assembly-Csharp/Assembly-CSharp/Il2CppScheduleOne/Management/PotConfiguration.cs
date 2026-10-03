using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002DF RID: 735
	public class PotConfiguration : EntityConfiguration
	{
		// Token: 0x06003A5F RID: 14943 RVA: 0x0013F42C File Offset: 0x0013D62C
		// Note: this type is marked as 'beforefieldinit'.
		static PotConfiguration()
		{
			Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "PotConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr);
			PotConfiguration.NativeFieldInfoPtr__Pot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "<Pot>k__BackingField");
			PotConfiguration.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "Seed");
			PotConfiguration.NativeFieldInfoPtr_Additive1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "Additive1");
			PotConfiguration.NativeFieldInfoPtr_Additive2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "Additive2");
			PotConfiguration.NativeFieldInfoPtr_Additive3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "Additive3");
			PotConfiguration.NativeFieldInfoPtr_AssignedBotanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "AssignedBotanist");
			PotConfiguration.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "Destination");
			PotConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "<DestinationRoute>k__BackingField");
			PotConfiguration.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670762);
			PotConfiguration.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670763);
			PotConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670764);
			PotConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670765);
			PotConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670766);
			PotConfiguration.NativeMethodInfoPtr_IsAdditiveSelected_Public_Boolean_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670767);
			PotConfiguration.NativeMethodInfoPtr_GetSelectedSeedIDs_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670768);
			PotConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670769);
			PotConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670770);
			PotConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670771);
			PotConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670772);
			PotConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670773);
			PotConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670774);
			PotConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670775);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_0_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670776);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_1_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670777);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_2_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670778);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_3_Private_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670779);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_4_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670780);
			PotConfiguration.NativeMethodInfoPtr___ctor_b__14_5_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, 100670781);
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06003A60 RID: 14944 RVA: 0x0013F68C File Offset: 0x0013D88C
		// (set) Token: 0x06003A61 RID: 14945 RVA: 0x0013F6CC File Offset: 0x0013D8CC
		public unsafe Pot Pot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06003A62 RID: 14946 RVA: 0x0013F710 File Offset: 0x0013D910
		// (set) Token: 0x06003A63 RID: 14947 RVA: 0x0013F750 File Offset: 0x0013D950
		public unsafe TransitRoute DestinationRoute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41608, RefRangeEnd = 41609, XrefRangeStart = 41608, XrefRangeEnd = 41609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x0013F794 File Offset: 0x0013D994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148778, RefRangeEnd = 148779, XrefRangeStart = 148662, XrefRangeEnd = 148778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Pot pot) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x0013F804 File Offset: 0x0013DA04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148789, RefRangeEnd = 148790, XrefRangeStart = 148779, XrefRangeEnd = 148789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAdditiveSelected(ItemDefinition additive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(additive);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_IsAdditiveSelected_Public_Boolean_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A66 RID: 14950 RVA: 0x0013F854 File Offset: 0x0013DA54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148823, RefRangeEnd = 148824, XrefRangeStart = 148790, XrefRangeEnd = 148823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetSelectedSeedIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_GetSelectedSeedIDs_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x0013F894 File Offset: 0x0013DA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148824, XrefRangeEnd = 148836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x0013F8D0 File Offset: 0x0013DAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148836, XrefRangeEnd = 148845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationChanged(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A69 RID: 14953 RVA: 0x0013F914 File Offset: 0x0013DB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148845, XrefRangeEnd = 148862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DestinationFilter(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003A6A RID: 14954 RVA: 0x0013F97C File Offset: 0x0013DB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x0013F9B8 File Offset: 0x0013DBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A6C RID: 14956 RVA: 0x0013F9F4 File Offset: 0x0013DBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148862, XrefRangeEnd = 148881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x0013FA3C File Offset: 0x0013DC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148881, XrefRangeEnd = 148892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x0013FA80 File Offset: 0x0013DC80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_0(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_0_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x0013FAC4 File Offset: 0x0013DCC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_1(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_1_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x0013FB08 File Offset: 0x0013DD08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_2(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_2_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x0013FB4C File Offset: 0x0013DD4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_3(ItemDefinition <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_3_Private_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x0013FB90 File Offset: 0x0013DD90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_4(NPC <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_4_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x0013FBD4 File Offset: 0x0013DDD4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100734, XrefRangeStart = 100729, XrefRangeEnd = 100734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_5(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.NativeMethodInfoPtr___ctor_b__14_5_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x0001D474 File Offset: 0x0001B674
		public PotConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x0013FC18 File Offset: 0x0013DE18
		// (set) Token: 0x06003A76 RID: 14966 RVA: 0x0001D47D File Offset: 0x0001B67D
		public unsafe Pot _Pot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr__Pot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr__Pot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06003A77 RID: 14967 RVA: 0x0013FC48 File Offset: 0x0013DE48
		// (set) Token: 0x06003A78 RID: 14968 RVA: 0x0001D49C File Offset: 0x0001B69C
		public unsafe ItemField Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06003A79 RID: 14969 RVA: 0x0013FC78 File Offset: 0x0013DE78
		// (set) Token: 0x06003A7A RID: 14970 RVA: 0x0001D4BB File Offset: 0x0001B6BB
		public unsafe ItemField Additive1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06003A7B RID: 14971 RVA: 0x0013FCA8 File Offset: 0x0013DEA8
		// (set) Token: 0x06003A7C RID: 14972 RVA: 0x0001D4DA File Offset: 0x0001B6DA
		public unsafe ItemField Additive2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x06003A7D RID: 14973 RVA: 0x0013FCD8 File Offset: 0x0013DED8
		// (set) Token: 0x06003A7E RID: 14974 RVA: 0x0001D4F9 File Offset: 0x0001B6F9
		public unsafe ItemField Additive3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Additive3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x06003A7F RID: 14975 RVA: 0x0013FD08 File Offset: 0x0013DF08
		// (set) Token: 0x06003A80 RID: 14976 RVA: 0x0001D518 File Offset: 0x0001B718
		public unsafe NPCField AssignedBotanist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_AssignedBotanist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_AssignedBotanist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x0013FD38 File Offset: 0x0013DF38
		// (set) Token: 0x06003A82 RID: 14978 RVA: 0x0001D537 File Offset: 0x0001B737
		public unsafe ObjectField Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06003A83 RID: 14979 RVA: 0x0013FD68 File Offset: 0x0013DF68
		// (set) Token: 0x06003A84 RID: 14980 RVA: 0x0001D556 File Offset: 0x0001B756
		public unsafe TransitRoute _DestinationRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002748 RID: 10056
		private static readonly IntPtr NativeFieldInfoPtr__Pot_k__BackingField;

		// Token: 0x04002749 RID: 10057
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x0400274A RID: 10058
		private static readonly IntPtr NativeFieldInfoPtr_Additive1;

		// Token: 0x0400274B RID: 10059
		private static readonly IntPtr NativeFieldInfoPtr_Additive2;

		// Token: 0x0400274C RID: 10060
		private static readonly IntPtr NativeFieldInfoPtr_Additive3;

		// Token: 0x0400274D RID: 10061
		private static readonly IntPtr NativeFieldInfoPtr_AssignedBotanist;

		// Token: 0x0400274E RID: 10062
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x0400274F RID: 10063
		private static readonly IntPtr NativeFieldInfoPtr__DestinationRoute_k__BackingField;

		// Token: 0x04002750 RID: 10064
		private static readonly IntPtr NativeMethodInfoPtr_get_Pot_Public_get_Pot_0;

		// Token: 0x04002751 RID: 10065
		private static readonly IntPtr NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0;

		// Token: 0x04002752 RID: 10066
		private static readonly IntPtr NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0;

		// Token: 0x04002753 RID: 10067
		private static readonly IntPtr NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0;

		// Token: 0x04002754 RID: 10068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Pot_0;

		// Token: 0x04002755 RID: 10069
		private static readonly IntPtr NativeMethodInfoPtr_IsAdditiveSelected_Public_Boolean_ItemDefinition_0;

		// Token: 0x04002756 RID: 10070
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedSeedIDs_Public_Il2CppStringArray_0;

		// Token: 0x04002757 RID: 10071
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04002758 RID: 10072
		private static readonly IntPtr NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002759 RID: 10073
		private static readonly IntPtr NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0;

		// Token: 0x0400275A RID: 10074
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_Void_0;

		// Token: 0x0400275B RID: 10075
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0;

		// Token: 0x0400275C RID: 10076
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x0400275D RID: 10077
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400275E RID: 10078
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_0_Private_Void_ItemDefinition_0;

		// Token: 0x0400275F RID: 10079
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_1_Private_Void_ItemDefinition_0;

		// Token: 0x04002760 RID: 10080
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_2_Private_Void_ItemDefinition_0;

		// Token: 0x04002761 RID: 10081
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_3_Private_Void_ItemDefinition_0;

		// Token: 0x04002762 RID: 10082
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_4_Private_Void_NPC_0;

		// Token: 0x04002763 RID: 10083
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_5_Private_Void_BuildableItem_0;

		// Token: 0x02000A32 RID: 2610
		[ObfuscatedName("ScheduleOne.Management.PotConfiguration+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600DF22 RID: 57122 RVA: 0x0036F638 File Offset: 0x0036D838
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PotConfiguration.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotConfiguration>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotConfiguration.__c>.NativeClassPtr);
				PotConfiguration.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration.__c>.NativeClassPtr, "<>9");
				PotConfiguration.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfiguration.__c>.NativeClassPtr, "<>9__16_0");
				PotConfiguration.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration.__c>.NativeClassPtr, 100670783);
				PotConfiguration.__c.NativeMethodInfoPtr__GetSelectedSeedIDs_b__16_0_Internal_String_SeedDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfiguration.__c>.NativeClassPtr, 100670784);
			}

			// Token: 0x0600DF23 RID: 57123 RVA: 0x0036F6B4 File Offset: 0x0036D8B4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotConfiguration.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF24 RID: 57124 RVA: 0x0036F6F0 File Offset: 0x0036D8F0
			[CallerCount(0)]
			public unsafe string _GetSelectedSeedIDs_b__16_0(SeedDefinition s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfiguration.__c.NativeMethodInfoPtr__GetSelectedSeedIDs_b__16_0_Internal_String_SeedDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DF25 RID: 57125 RVA: 0x00069150 File Offset: 0x00067350
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043EF RID: 17391
			// (get) Token: 0x0600DF26 RID: 57126 RVA: 0x0036F738 File Offset: 0x0036D938
			// (set) Token: 0x0600DF27 RID: 57127 RVA: 0x00069159 File Offset: 0x00067359
			public unsafe static PotConfiguration.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PotConfiguration.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotConfiguration.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PotConfiguration.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F0 RID: 17392
			// (get) Token: 0x0600DF28 RID: 57128 RVA: 0x0036F760 File Offset: 0x0036D960
			// (set) Token: 0x0600DF29 RID: 57129 RVA: 0x0006916B File Offset: 0x0006736B
			public unsafe static Func<SeedDefinition, string> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PotConfiguration.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SeedDefinition, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PotConfiguration.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097F8 RID: 38904
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040097F9 RID: 38905
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x040097FA RID: 38906
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097FB RID: 38907
			private static readonly IntPtr NativeMethodInfoPtr__GetSelectedSeedIDs_b__16_0_Internal_String_SeedDefinition_0;
		}
	}
}

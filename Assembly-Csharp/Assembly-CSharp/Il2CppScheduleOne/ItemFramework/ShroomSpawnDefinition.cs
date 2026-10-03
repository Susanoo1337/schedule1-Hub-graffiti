using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Product;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200035D RID: 861
	[Serializable]
	public class ShroomSpawnDefinition : StorableItemDefinition
	{
		// Token: 0x060048F8 RID: 18680 RVA: 0x001735E0 File Offset: 0x001717E0
		// Note: this type is marked as 'beforefieldinit'.
		static ShroomSpawnDefinition()
		{
			Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ShroomSpawnDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr);
			ShroomSpawnDefinition.NativeFieldInfoPtr__ColonyPrefab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, "<ColonyPrefab>k__BackingField");
			ShroomSpawnDefinition.NativeFieldInfoPtr__Shroom_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, "<Shroom>k__BackingField");
			ShroomSpawnDefinition.NativeFieldInfoPtr__ChunkPrefab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, "<ChunkPrefab>k__BackingField");
			ShroomSpawnDefinition.NativeFieldInfoPtr__MixTaskProjectorPrefab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, "<MixTaskProjectorPrefab>k__BackingField");
			ShroomSpawnDefinition.NativeMethodInfoPtr_get_ColonyPrefab_Public_get_ShroomColony_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, 100672651);
			ShroomSpawnDefinition.NativeMethodInfoPtr_set_ColonyPrefab_Private_set_Void_ShroomColony_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, 100672652);
			ShroomSpawnDefinition.NativeMethodInfoPtr_get_Shroom_Public_get_ShroomDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, 100672653);
			ShroomSpawnDefinition.NativeMethodInfoPtr_set_Shroom_Private_set_Void_ShroomDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, 100672654);
			ShroomSpawnDefinition.NativeMethodInfoPtr_get_ChunkPrefab_Public_get_SpawnChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, 100672655);
			ShroomSpawnDefinition.NativeMethodInfoPtr_set_ChunkPrefab_Private_set_Void_SpawnChunk_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, 100672656);
			ShroomSpawnDefinition.NativeMethodInfoPtr_get_MixTaskProjectorPrefab_Public_get_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, 100672657);
			ShroomSpawnDefinition.NativeMethodInfoPtr_set_MixTaskProjectorPrefab_Private_set_Void_DecalProjector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, 100672658);
			ShroomSpawnDefinition.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, 100672659);
			ShroomSpawnDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr, 100672660);
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x060048F9 RID: 18681 RVA: 0x00173728 File Offset: 0x00171928
		// (set) Token: 0x060048FA RID: 18682 RVA: 0x00173768 File Offset: 0x00171968
		public unsafe ShroomColony ColonyPrefab
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38421, RefRangeEnd = 38424, XrefRangeStart = 38421, XrefRangeEnd = 38424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomSpawnDefinition.NativeMethodInfoPtr_get_ColonyPrefab_Public_get_ShroomColony_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShroomColony>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomSpawnDefinition.NativeMethodInfoPtr_set_ColonyPrefab_Private_set_Void_ShroomColony_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016DE RID: 5854
		// (get) Token: 0x060048FB RID: 18683 RVA: 0x001737AC File Offset: 0x001719AC
		// (set) Token: 0x060048FC RID: 18684 RVA: 0x001737EC File Offset: 0x001719EC
		public unsafe ShroomDefinition Shroom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomSpawnDefinition.NativeMethodInfoPtr_get_Shroom_Public_get_ShroomDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShroomDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomSpawnDefinition.NativeMethodInfoPtr_set_Shroom_Private_set_Void_ShroomDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016DF RID: 5855
		// (get) Token: 0x060048FD RID: 18685 RVA: 0x00173830 File Offset: 0x00171A30
		// (set) Token: 0x060048FE RID: 18686 RVA: 0x00173870 File Offset: 0x00171A70
		public unsafe SpawnChunk ChunkPrefab
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomSpawnDefinition.NativeMethodInfoPtr_get_ChunkPrefab_Public_get_SpawnChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpawnChunk>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38427, RefRangeEnd = 38428, XrefRangeStart = 38427, XrefRangeEnd = 38428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomSpawnDefinition.NativeMethodInfoPtr_set_ChunkPrefab_Private_set_Void_SpawnChunk_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x060048FF RID: 18687 RVA: 0x001738B4 File Offset: 0x00171AB4
		// (set) Token: 0x06004900 RID: 18688 RVA: 0x001738F4 File Offset: 0x00171AF4
		public unsafe DecalProjector MixTaskProjectorPrefab
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomSpawnDefinition.NativeMethodInfoPtr_get_MixTaskProjectorPrefab_Public_get_DecalProjector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomSpawnDefinition.NativeMethodInfoPtr_set_MixTaskProjectorPrefab_Private_set_Void_DecalProjector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x00173938 File Offset: 0x00171B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomSpawnDefinition.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x00173974 File Offset: 0x00171B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166837, RefRangeEnd = 166838, XrefRangeStart = 166837, XrefRangeEnd = 166838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomSpawnDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomSpawnDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomSpawnDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x0002374B File Offset: 0x0002194B
		public ShroomSpawnDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016D9 RID: 5849
		// (get) Token: 0x06004904 RID: 18692 RVA: 0x001739B0 File Offset: 0x00171BB0
		// (set) Token: 0x06004905 RID: 18693 RVA: 0x00023754 File Offset: 0x00021954
		public unsafe ShroomColony _ColonyPrefab_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomSpawnDefinition.NativeFieldInfoPtr__ColonyPrefab_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShroomColony>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomSpawnDefinition.NativeFieldInfoPtr__ColonyPrefab_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016DA RID: 5850
		// (get) Token: 0x06004906 RID: 18694 RVA: 0x001739E0 File Offset: 0x00171BE0
		// (set) Token: 0x06004907 RID: 18695 RVA: 0x00023773 File Offset: 0x00021973
		public unsafe ShroomDefinition _Shroom_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomSpawnDefinition.NativeFieldInfoPtr__Shroom_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShroomDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomSpawnDefinition.NativeFieldInfoPtr__Shroom_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016DB RID: 5851
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x00173A10 File Offset: 0x00171C10
		// (set) Token: 0x06004909 RID: 18697 RVA: 0x00023792 File Offset: 0x00021992
		public unsafe SpawnChunk _ChunkPrefab_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomSpawnDefinition.NativeFieldInfoPtr__ChunkPrefab_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpawnChunk>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomSpawnDefinition.NativeFieldInfoPtr__ChunkPrefab_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x0600490A RID: 18698 RVA: 0x00173A40 File Offset: 0x00171C40
		// (set) Token: 0x0600490B RID: 18699 RVA: 0x000237B1 File Offset: 0x000219B1
		public unsafe DecalProjector _MixTaskProjectorPrefab_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomSpawnDefinition.NativeFieldInfoPtr__MixTaskProjectorPrefab_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomSpawnDefinition.NativeFieldInfoPtr__MixTaskProjectorPrefab_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400319A RID: 12698
		private static readonly IntPtr NativeFieldInfoPtr__ColonyPrefab_k__BackingField;

		// Token: 0x0400319B RID: 12699
		private static readonly IntPtr NativeFieldInfoPtr__Shroom_k__BackingField;

		// Token: 0x0400319C RID: 12700
		private static readonly IntPtr NativeFieldInfoPtr__ChunkPrefab_k__BackingField;

		// Token: 0x0400319D RID: 12701
		private static readonly IntPtr NativeFieldInfoPtr__MixTaskProjectorPrefab_k__BackingField;

		// Token: 0x0400319E RID: 12702
		private static readonly IntPtr NativeMethodInfoPtr_get_ColonyPrefab_Public_get_ShroomColony_0;

		// Token: 0x0400319F RID: 12703
		private static readonly IntPtr NativeMethodInfoPtr_set_ColonyPrefab_Private_set_Void_ShroomColony_0;

		// Token: 0x040031A0 RID: 12704
		private static readonly IntPtr NativeMethodInfoPtr_get_Shroom_Public_get_ShroomDefinition_0;

		// Token: 0x040031A1 RID: 12705
		private static readonly IntPtr NativeMethodInfoPtr_set_Shroom_Private_set_Void_ShroomDefinition_0;

		// Token: 0x040031A2 RID: 12706
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkPrefab_Public_get_SpawnChunk_0;

		// Token: 0x040031A3 RID: 12707
		private static readonly IntPtr NativeMethodInfoPtr_set_ChunkPrefab_Private_set_Void_SpawnChunk_0;

		// Token: 0x040031A4 RID: 12708
		private static readonly IntPtr NativeMethodInfoPtr_get_MixTaskProjectorPrefab_Public_get_DecalProjector_0;

		// Token: 0x040031A5 RID: 12709
		private static readonly IntPtr NativeMethodInfoPtr_set_MixTaskProjectorPrefab_Private_set_Void_DecalProjector_0;

		// Token: 0x040031A6 RID: 12710
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0;

		// Token: 0x040031A7 RID: 12711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

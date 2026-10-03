using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000520 RID: 1312
	[Serializable]
	public class SeedDefinition : StorableItemDefinition
	{
		// Token: 0x06007705 RID: 30469 RVA: 0x00211C54 File Offset: 0x0020FE54
		// Note: this type is marked as 'beforefieldinit'.
		static SeedDefinition()
		{
			Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "SeedDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr);
			SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, "FunctionSeedPrefab");
			SeedDefinition.NativeFieldInfoPtr_PlantPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, "PlantPrefab");
			SeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr, 100678581);
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x00211CC0 File Offset: 0x0020FEC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166837, RefRangeEnd = 166838, XrefRangeStart = 166837, XrefRangeEnd = 166838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SeedDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SeedDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SeedDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x00038D3E File Offset: 0x00036F3E
		public SeedDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x06007708 RID: 30472 RVA: 0x00211CFC File Offset: 0x0020FEFC
		// (set) Token: 0x06007709 RID: 30473 RVA: 0x00038D47 File Offset: 0x00036F47
		public unsafe FunctionalSeed FunctionSeedPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalSeed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_FunctionSeedPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x0600770A RID: 30474 RVA: 0x00211D2C File Offset: 0x0020FF2C
		// (set) Token: 0x0600770B RID: 30475 RVA: 0x00038D66 File Offset: 0x00036F66
		public unsafe Plant PlantPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_PlantPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SeedDefinition.NativeFieldInfoPtr_PlantPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400510D RID: 20749
		private static readonly IntPtr NativeFieldInfoPtr_FunctionSeedPrefab;

		// Token: 0x0400510E RID: 20750
		private static readonly IntPtr NativeFieldInfoPtr_PlantPrefab;

		// Token: 0x0400510F RID: 20751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

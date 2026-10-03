using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200035F RID: 863
	[Serializable]
	public class SporeSyringeDefinition : StorableItemDefinition
	{
		// Token: 0x06004918 RID: 18712 RVA: 0x00173CBC File Offset: 0x00171EBC
		// Note: this type is marked as 'beforefieldinit'.
		static SporeSyringeDefinition()
		{
			Il2CppClassPointerStore<SporeSyringeDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "SporeSyringeDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SporeSyringeDefinition>.NativeClassPtr);
			SporeSyringeDefinition.NativeFieldInfoPtr__SpawnDefinition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SporeSyringeDefinition>.NativeClassPtr, "<SpawnDefinition>k__BackingField");
			SporeSyringeDefinition.NativeMethodInfoPtr_get_SpawnDefinition_Public_get_ShroomSpawnDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeDefinition>.NativeClassPtr, 100672665);
			SporeSyringeDefinition.NativeMethodInfoPtr_set_SpawnDefinition_Private_set_Void_ShroomSpawnDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeDefinition>.NativeClassPtr, 100672666);
			SporeSyringeDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SporeSyringeDefinition>.NativeClassPtr, 100672667);
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06004919 RID: 18713 RVA: 0x00173D3C File Offset: 0x00171F3C
		// (set) Token: 0x0600491A RID: 18714 RVA: 0x00173D7C File Offset: 0x00171F7C
		public unsafe ShroomSpawnDefinition SpawnDefinition
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38421, RefRangeEnd = 38424, XrefRangeStart = 38421, XrefRangeEnd = 38424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeDefinition.NativeMethodInfoPtr_get_SpawnDefinition_Public_get_ShroomSpawnDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShroomSpawnDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeDefinition.NativeMethodInfoPtr_set_SpawnDefinition_Private_set_Void_ShroomSpawnDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x00173DC0 File Offset: 0x00171FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166837, RefRangeEnd = 166838, XrefRangeStart = 166837, XrefRangeEnd = 166838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SporeSyringeDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SporeSyringeDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SporeSyringeDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x00023832 File Offset: 0x00021A32
		public SporeSyringeDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x0600491D RID: 18717 RVA: 0x00173DFC File Offset: 0x00171FFC
		// (set) Token: 0x0600491E RID: 18718 RVA: 0x0002383B File Offset: 0x00021A3B
		public unsafe ShroomSpawnDefinition _SpawnDefinition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeDefinition.NativeFieldInfoPtr__SpawnDefinition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShroomSpawnDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SporeSyringeDefinition.NativeFieldInfoPtr__SpawnDefinition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031AF RID: 12719
		private static readonly IntPtr NativeFieldInfoPtr__SpawnDefinition_k__BackingField;

		// Token: 0x040031B0 RID: 12720
		private static readonly IntPtr NativeMethodInfoPtr_get_SpawnDefinition_Public_get_ShroomSpawnDefinition_0;

		// Token: 0x040031B1 RID: 12721
		private static readonly IntPtr NativeMethodInfoPtr_set_SpawnDefinition_Private_set_Void_ShroomSpawnDefinition_0;

		// Token: 0x040031B2 RID: 12722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

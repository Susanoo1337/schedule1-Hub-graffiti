using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200033F RID: 831
	[Serializable]
	public class BuildableItemDefinition : StorableItemDefinition
	{
		// Token: 0x0600477F RID: 18303 RVA: 0x0016DFEC File Offset: 0x0016C1EC
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItemDefinition()
		{
			Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "BuildableItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr);
			BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, "BuiltItem");
			BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, "BuildSoundType");
			BuildableItemDefinition.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, 100672451);
			BuildableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr, 100672452);
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x0016E06C File Offset: 0x0016C26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItemDefinition.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x0016E0A8 File Offset: 0x0016C2A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166837, RefRangeEnd = 166838, XrefRangeStart = 166836, XrefRangeEnd = 166837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x00022ECC File Offset: 0x000210CC
		public BuildableItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06004783 RID: 18307 RVA: 0x0016E0E4 File Offset: 0x0016C2E4
		// (set) Token: 0x06004784 RID: 18308 RVA: 0x00022ED5 File Offset: 0x000210D5
		public unsafe BuildableItem BuiltItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuiltItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06004785 RID: 18309 RVA: 0x0016E114 File Offset: 0x0016C314
		// (set) Token: 0x06004786 RID: 18310 RVA: 0x00022EF4 File Offset: 0x000210F4
		public unsafe BuildableItemDefinition.EBuildSoundType BuildSoundType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemDefinition.NativeFieldInfoPtr_BuildSoundType)) = value;
			}
		}

		// Token: 0x0400309C RID: 12444
		private static readonly IntPtr NativeFieldInfoPtr_BuiltItem;

		// Token: 0x0400309D RID: 12445
		private static readonly IntPtr NativeFieldInfoPtr_BuildSoundType;

		// Token: 0x0400309E RID: 12446
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0;

		// Token: 0x0400309F RID: 12447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A6A RID: 2666
		[OriginalName("Assembly-CSharp.dll", "", "EBuildSoundType")]
		public enum EBuildSoundType
		{
			// Token: 0x04009910 RID: 39184
			Cardboard,
			// Token: 0x04009911 RID: 39185
			Wood,
			// Token: 0x04009912 RID: 39186
			Metal
		}
	}
}

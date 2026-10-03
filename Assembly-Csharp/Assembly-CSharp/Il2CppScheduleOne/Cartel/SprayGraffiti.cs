using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Graffiti;
using Il2CppScheduleOne.Map;
using Il2CppSystem;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000445 RID: 1093
	public class SprayGraffiti : CartelActivity
	{
		// Token: 0x060062BD RID: 25277 RVA: 0x001D13C4 File Offset: 0x001CF5C4
		// Note: this type is marked as 'beforefieldinit'.
		static SprayGraffiti()
		{
			Il2CppClassPointerStore<SprayGraffiti>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "SprayGraffiti");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SprayGraffiti>.NativeClassPtr);
			SprayGraffiti.NativeFieldInfoPtr__minimumDistanceFromPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayGraffiti>.NativeClassPtr, "_minimumDistanceFromPlayers");
			SprayGraffiti.NativeFieldInfoPtr__validSpraySurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayGraffiti>.NativeClassPtr, "_validSpraySurface");
			SprayGraffiti.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayGraffiti>.NativeClassPtr, 100676259);
			SprayGraffiti.NativeMethodInfoPtr_SetSpraySurface_Public_Void_EMapRegion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayGraffiti>.NativeClassPtr, 100676260);
			SprayGraffiti.NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayGraffiti>.NativeClassPtr, 100676261);
			SprayGraffiti.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayGraffiti>.NativeClassPtr, 100676262);
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x001D146C File Offset: 0x001CF66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208295, XrefRangeEnd = 208306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsRegionValidForActivity(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SprayGraffiti.NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x001D14C0 File Offset: 0x001CF6C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208354, RefRangeEnd = 208356, XrefRangeStart = 208306, XrefRangeEnd = 208354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSpraySurface(EMapRegion region, bool overrideExisting = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideExisting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayGraffiti.NativeMethodInfoPtr_SetSpraySurface_Public_Void_EMapRegion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062C0 RID: 25280 RVA: 0x001D150C File Offset: 0x001CF70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208356, XrefRangeEnd = 208396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SprayGraffiti.NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x001D1558 File Offset: 0x001CF758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208396, XrefRangeEnd = 208397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SprayGraffiti() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SprayGraffiti>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayGraffiti.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x0002EA17 File Offset: 0x0002CC17
		public SprayGraffiti(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x060062C3 RID: 25283 RVA: 0x001D1594 File Offset: 0x001CF794
		// (set) Token: 0x060062C4 RID: 25284 RVA: 0x0002EA20 File Offset: 0x0002CC20
		public unsafe float _minimumDistanceFromPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayGraffiti.NativeFieldInfoPtr__minimumDistanceFromPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayGraffiti.NativeFieldInfoPtr__minimumDistanceFromPlayers)) = value;
			}
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x060062C5 RID: 25285 RVA: 0x001D15BC File Offset: 0x001CF7BC
		// (set) Token: 0x060062C6 RID: 25286 RVA: 0x0002EA3B File Offset: 0x0002CC3B
		public unsafe WorldSpraySurface _validSpraySurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayGraffiti.NativeFieldInfoPtr__validSpraySurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldSpraySurface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayGraffiti.NativeFieldInfoPtr__validSpraySurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400440B RID: 17419
		private static readonly IntPtr NativeFieldInfoPtr__minimumDistanceFromPlayers;

		// Token: 0x0400440C RID: 17420
		private static readonly IntPtr NativeFieldInfoPtr__validSpraySurface;

		// Token: 0x0400440D RID: 17421
		private static readonly IntPtr NativeMethodInfoPtr_IsRegionValidForActivity_Public_Virtual_Boolean_EMapRegion_0;

		// Token: 0x0400440E RID: 17422
		private static readonly IntPtr NativeMethodInfoPtr_SetSpraySurface_Public_Void_EMapRegion_Boolean_0;

		// Token: 0x0400440F RID: 17423
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_EMapRegion_0;

		// Token: 0x04004410 RID: 17424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B36 RID: 2870
		[ObfuscatedName("ScheduleOne.Cartel.SprayGraffiti+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600E6B3 RID: 59059 RVA: 0x00384850 File Offset: 0x00382A50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<SprayGraffiti.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SprayGraffiti>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SprayGraffiti.__c__DisplayClass3_0>.NativeClassPtr);
				SprayGraffiti.__c__DisplayClass3_0.NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SprayGraffiti.__c__DisplayClass3_0>.NativeClassPtr, "region");
				SprayGraffiti.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayGraffiti.__c__DisplayClass3_0>.NativeClassPtr, 100676263);
				SprayGraffiti.__c__DisplayClass3_0.NativeMethodInfoPtr__SetSpraySurface_b__0_Internal_Boolean_WorldSpraySurface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SprayGraffiti.__c__DisplayClass3_0>.NativeClassPtr, 100676264);
			}

			// Token: 0x0600E6B4 RID: 59060 RVA: 0x003848B8 File Offset: 0x00382AB8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SprayGraffiti.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayGraffiti.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6B5 RID: 59061 RVA: 0x003848F4 File Offset: 0x00382AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208294, XrefRangeEnd = 208295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetSpraySurface_b__0(WorldSpraySurface s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SprayGraffiti.__c__DisplayClass3_0.NativeMethodInfoPtr__SetSpraySurface_b__0_Internal_Boolean_WorldSpraySurface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6B6 RID: 59062 RVA: 0x0006CD2C File Offset: 0x0006AF2C
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004607 RID: 17927
			// (get) Token: 0x0600E6B7 RID: 59063 RVA: 0x00384944 File Offset: 0x00382B44
			// (set) Token: 0x0600E6B8 RID: 59064 RVA: 0x0006CD35 File Offset: 0x0006AF35
			public unsafe EMapRegion region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayGraffiti.__c__DisplayClass3_0.NativeFieldInfoPtr_region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SprayGraffiti.__c__DisplayClass3_0.NativeFieldInfoPtr_region)) = value;
				}
			}

			// Token: 0x04009CA0 RID: 40096
			private static readonly IntPtr NativeFieldInfoPtr_region;

			// Token: 0x04009CA1 RID: 40097
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CA2 RID: 40098
			private static readonly IntPtr NativeMethodInfoPtr__SetSpraySurface_b__0_Internal_Boolean_WorldSpraySurface_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000517 RID: 1303
	public class GrowingMushroom : MonoBehaviour
	{
		// Token: 0x06007657 RID: 30295 RVA: 0x0020FA94 File Offset: 0x0020DC94
		// Note: this type is marked as 'beforefieldinit'.
		static GrowingMushroom()
		{
			Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "GrowingMushroom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr);
			GrowingMushroom.NativeFieldInfoPtr_CapExpansionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, "CapExpansionThreshold");
			GrowingMushroom.NativeFieldInfoPtr_LateralScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, "LateralScaleMultiplier");
			GrowingMushroom.NativeFieldInfoPtr_VerticalScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, "VerticalScaleMultiplier");
			GrowingMushroom.NativeFieldInfoPtr_MaxCapExpansion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, "MaxCapExpansion");
			GrowingMushroom.NativeFieldInfoPtr__modelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, "_modelContainer");
			GrowingMushroom.NativeFieldInfoPtr__meshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, "_meshRenderers");
			GrowingMushroom.NativeFieldInfoPtr__harvestSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, "_harvestSound");
			GrowingMushroom.NativeFieldInfoPtr__parentColony = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, "_parentColony");
			GrowingMushroom.NativeFieldInfoPtr__alignmentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, "_alignmentIndex");
			GrowingMushroom.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, 100678521);
			GrowingMushroom.NativeMethodInfoPtr_Initialize_Public_Void_ShroomColony_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, 100678522);
			GrowingMushroom.NativeMethodInfoPtr_SetGrowthPercent_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, 100678523);
			GrowingMushroom.NativeMethodInfoPtr_Harvest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, 100678524);
			GrowingMushroom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr, 100678525);
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x0020FBDC File Offset: 0x0020DDDC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowingMushroom.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x0020FC10 File Offset: 0x0020DE10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229908, RefRangeEnd = 229909, XrefRangeStart = 229907, XrefRangeEnd = 229908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ShroomColony parentColony, int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentColony);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowingMushroom.NativeMethodInfoPtr_Initialize_Public_Void_ShroomColony_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x0020FC60 File Offset: 0x0020DE60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229918, RefRangeEnd = 229920, XrefRangeStart = 229909, XrefRangeEnd = 229918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrowthPercent(float percent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowingMushroom.NativeMethodInfoPtr_SetGrowthPercent_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x0020FCA0 File Offset: 0x0020DEA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229953, RefRangeEnd = 229954, XrefRangeStart = 229920, XrefRangeEnd = 229953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Harvest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowingMushroom.NativeMethodInfoPtr_Harvest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x0020FCD4 File Offset: 0x0020DED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229954, XrefRangeEnd = 229955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrowingMushroom() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowingMushroom>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowingMushroom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00038790 File Offset: 0x00036990
		public GrowingMushroom(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x0600765E RID: 30302 RVA: 0x0020FD10 File Offset: 0x0020DF10
		// (set) Token: 0x0600765F RID: 30303 RVA: 0x00038799 File Offset: 0x00036999
		public unsafe static float CapExpansionThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GrowingMushroom.NativeFieldInfoPtr_CapExpansionThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrowingMushroom.NativeFieldInfoPtr_CapExpansionThreshold, (void*)(&value));
			}
		}

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x06007660 RID: 30304 RVA: 0x0020FD2C File Offset: 0x0020DF2C
		// (set) Token: 0x06007661 RID: 30305 RVA: 0x000387A7 File Offset: 0x000369A7
		public unsafe float LateralScaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr_LateralScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr_LateralScaleMultiplier)) = value;
			}
		}

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x06007662 RID: 30306 RVA: 0x0020FD54 File Offset: 0x0020DF54
		// (set) Token: 0x06007663 RID: 30307 RVA: 0x000387C2 File Offset: 0x000369C2
		public unsafe float VerticalScaleMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr_VerticalScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr_VerticalScaleMultiplier)) = value;
			}
		}

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x06007664 RID: 30308 RVA: 0x0020FD7C File Offset: 0x0020DF7C
		// (set) Token: 0x06007665 RID: 30309 RVA: 0x000387DD File Offset: 0x000369DD
		public unsafe float MaxCapExpansion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr_MaxCapExpansion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr_MaxCapExpansion)) = value;
			}
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x06007666 RID: 30310 RVA: 0x0020FDA4 File Offset: 0x0020DFA4
		// (set) Token: 0x06007667 RID: 30311 RVA: 0x000387F8 File Offset: 0x000369F8
		public unsafe Transform _modelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr__modelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr__modelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x06007668 RID: 30312 RVA: 0x0020FDD4 File Offset: 0x0020DFD4
		// (set) Token: 0x06007669 RID: 30313 RVA: 0x00038817 File Offset: 0x00036A17
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> _meshRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr__meshRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr__meshRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x0600766A RID: 30314 RVA: 0x0020FE04 File Offset: 0x0020E004
		// (set) Token: 0x0600766B RID: 30315 RVA: 0x00038836 File Offset: 0x00036A36
		public unsafe AudioSourceController _harvestSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr__harvestSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr__harvestSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249C RID: 9372
		// (get) Token: 0x0600766C RID: 30316 RVA: 0x0020FE34 File Offset: 0x0020E034
		// (set) Token: 0x0600766D RID: 30317 RVA: 0x00038855 File Offset: 0x00036A55
		public unsafe ShroomColony _parentColony
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr__parentColony);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShroomColony>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr__parentColony), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x0600766E RID: 30318 RVA: 0x0020FE64 File Offset: 0x0020E064
		// (set) Token: 0x0600766F RID: 30319 RVA: 0x00038874 File Offset: 0x00036A74
		public unsafe int _alignmentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr__alignmentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowingMushroom.NativeFieldInfoPtr__alignmentIndex)) = value;
			}
		}

		// Token: 0x040050A1 RID: 20641
		private static readonly IntPtr NativeFieldInfoPtr_CapExpansionThreshold;

		// Token: 0x040050A2 RID: 20642
		private static readonly IntPtr NativeFieldInfoPtr_LateralScaleMultiplier;

		// Token: 0x040050A3 RID: 20643
		private static readonly IntPtr NativeFieldInfoPtr_VerticalScaleMultiplier;

		// Token: 0x040050A4 RID: 20644
		private static readonly IntPtr NativeFieldInfoPtr_MaxCapExpansion;

		// Token: 0x040050A5 RID: 20645
		private static readonly IntPtr NativeFieldInfoPtr__modelContainer;

		// Token: 0x040050A6 RID: 20646
		private static readonly IntPtr NativeFieldInfoPtr__meshRenderers;

		// Token: 0x040050A7 RID: 20647
		private static readonly IntPtr NativeFieldInfoPtr__harvestSound;

		// Token: 0x040050A8 RID: 20648
		private static readonly IntPtr NativeFieldInfoPtr__parentColony;

		// Token: 0x040050A9 RID: 20649
		private static readonly IntPtr NativeFieldInfoPtr__alignmentIndex;

		// Token: 0x040050AA RID: 20650
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040050AB RID: 20651
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ShroomColony_Int32_0;

		// Token: 0x040050AC RID: 20652
		private static readonly IntPtr NativeMethodInfoPtr_SetGrowthPercent_Public_Void_Single_0;

		// Token: 0x040050AD RID: 20653
		private static readonly IntPtr NativeMethodInfoPtr_Harvest_Public_Void_0;

		// Token: 0x040050AE RID: 20654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

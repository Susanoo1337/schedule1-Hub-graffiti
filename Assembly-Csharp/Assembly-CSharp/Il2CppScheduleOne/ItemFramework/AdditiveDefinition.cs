using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200033D RID: 829
	[Serializable]
	public class AdditiveDefinition : StorableItemDefinition
	{
		// Token: 0x0600475E RID: 18270 RVA: 0x0016D9D0 File Offset: 0x0016BBD0
		// Note: this type is marked as 'beforefieldinit'.
		static AdditiveDefinition()
		{
			Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "AdditiveDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr);
			AdditiveDefinition.NativeFieldInfoPtr__DisplayMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, "<DisplayMaterial>k__BackingField");
			AdditiveDefinition.NativeFieldInfoPtr__QualityChange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, "<QualityChange>k__BackingField");
			AdditiveDefinition.NativeFieldInfoPtr__YieldMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, "<YieldMultiplier>k__BackingField");
			AdditiveDefinition.NativeFieldInfoPtr__InstantGrowth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, "<InstantGrowth>k__BackingField");
			AdditiveDefinition.NativeMethodInfoPtr_get_DisplayMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100672440);
			AdditiveDefinition.NativeMethodInfoPtr_set_DisplayMaterial_Private_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100672441);
			AdditiveDefinition.NativeMethodInfoPtr_get_QualityChange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100672442);
			AdditiveDefinition.NativeMethodInfoPtr_set_QualityChange_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100672443);
			AdditiveDefinition.NativeMethodInfoPtr_get_YieldMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100672444);
			AdditiveDefinition.NativeMethodInfoPtr_set_YieldMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100672445);
			AdditiveDefinition.NativeMethodInfoPtr_get_InstantGrowth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100672446);
			AdditiveDefinition.NativeMethodInfoPtr_set_InstantGrowth_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100672447);
			AdditiveDefinition.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100672448);
			AdditiveDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr, 100672449);
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x0600475F RID: 18271 RVA: 0x0016DB18 File Offset: 0x0016BD18
		// (set) Token: 0x06004760 RID: 18272 RVA: 0x0016DB58 File Offset: 0x0016BD58
		public unsafe Material DisplayMaterial
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38421, RefRangeEnd = 38424, XrefRangeStart = 38421, XrefRangeEnd = 38424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr_get_DisplayMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr_set_DisplayMaterial_Private_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06004761 RID: 18273 RVA: 0x0016DB9C File Offset: 0x0016BD9C
		// (set) Token: 0x06004762 RID: 18274 RVA: 0x0016DBD8 File Offset: 0x0016BDD8
		public unsafe float QualityChange
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr_get_QualityChange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr_set_QualityChange_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x0016DC18 File Offset: 0x0016BE18
		// (set) Token: 0x06004764 RID: 18276 RVA: 0x0016DC54 File Offset: 0x0016BE54
		public unsafe float YieldMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr_get_YieldMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr_set_YieldMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06004765 RID: 18277 RVA: 0x0016DC94 File Offset: 0x0016BE94
		// (set) Token: 0x06004766 RID: 18278 RVA: 0x0016DCD0 File Offset: 0x0016BED0
		public unsafe float InstantGrowth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr_get_InstantGrowth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr_set_InstantGrowth_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x0016DD10 File Offset: 0x0016BF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166833, XrefRangeEnd = 166834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ValidateDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AdditiveDefinition.NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x0016DD4C File Offset: 0x0016BF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166834, XrefRangeEnd = 166835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdditiveDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditiveDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdditiveDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x00022DBB File Offset: 0x00020FBB
		public AdditiveDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x0016DD88 File Offset: 0x0016BF88
		// (set) Token: 0x0600476B RID: 18283 RVA: 0x00022DC4 File Offset: 0x00020FC4
		public unsafe Material _DisplayMaterial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr__DisplayMaterial_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr__DisplayMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x0016DDB8 File Offset: 0x0016BFB8
		// (set) Token: 0x0600476D RID: 18285 RVA: 0x00022DE3 File Offset: 0x00020FE3
		public unsafe float _QualityChange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr__QualityChange_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr__QualityChange_k__BackingField)) = value;
			}
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x0600476E RID: 18286 RVA: 0x0016DDE0 File Offset: 0x0016BFE0
		// (set) Token: 0x0600476F RID: 18287 RVA: 0x00022DFE File Offset: 0x00020FFE
		public unsafe float _YieldMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr__YieldMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr__YieldMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06004770 RID: 18288 RVA: 0x0016DE08 File Offset: 0x0016C008
		// (set) Token: 0x06004771 RID: 18289 RVA: 0x00022E19 File Offset: 0x00021019
		public unsafe float _InstantGrowth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr__InstantGrowth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdditiveDefinition.NativeFieldInfoPtr__InstantGrowth_k__BackingField)) = value;
			}
		}

		// Token: 0x04003088 RID: 12424
		private static readonly IntPtr NativeFieldInfoPtr__DisplayMaterial_k__BackingField;

		// Token: 0x04003089 RID: 12425
		private static readonly IntPtr NativeFieldInfoPtr__QualityChange_k__BackingField;

		// Token: 0x0400308A RID: 12426
		private static readonly IntPtr NativeFieldInfoPtr__YieldMultiplier_k__BackingField;

		// Token: 0x0400308B RID: 12427
		private static readonly IntPtr NativeFieldInfoPtr__InstantGrowth_k__BackingField;

		// Token: 0x0400308C RID: 12428
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayMaterial_Public_get_Material_0;

		// Token: 0x0400308D RID: 12429
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayMaterial_Private_set_Void_Material_0;

		// Token: 0x0400308E RID: 12430
		private static readonly IntPtr NativeMethodInfoPtr_get_QualityChange_Public_get_Single_0;

		// Token: 0x0400308F RID: 12431
		private static readonly IntPtr NativeMethodInfoPtr_set_QualityChange_Private_set_Void_Single_0;

		// Token: 0x04003090 RID: 12432
		private static readonly IntPtr NativeMethodInfoPtr_get_YieldMultiplier_Public_get_Single_0;

		// Token: 0x04003091 RID: 12433
		private static readonly IntPtr NativeMethodInfoPtr_set_YieldMultiplier_Private_set_Void_Single_0;

		// Token: 0x04003092 RID: 12434
		private static readonly IntPtr NativeMethodInfoPtr_get_InstantGrowth_Public_get_Single_0;

		// Token: 0x04003093 RID: 12435
		private static readonly IntPtr NativeMethodInfoPtr_set_InstantGrowth_Private_set_Void_Single_0;

		// Token: 0x04003094 RID: 12436
		private static readonly IntPtr NativeMethodInfoPtr_ValidateDefinition_Public_Virtual_Void_0;

		// Token: 0x04003095 RID: 12437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000569 RID: 1385
	public class MultiTypeVisualsSetter : MonoBehaviour
	{
		// Token: 0x06007EA3 RID: 32419 RVA: 0x0022ECAC File Offset: 0x0022CEAC
		// Note: this type is marked as 'beforefieldinit'.
		static MultiTypeVisualsSetter()
		{
			Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MultiTypeVisualsSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr);
			MultiTypeVisualsSetter.NativeFieldInfoPtr_WeedVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr, "WeedVisuals");
			MultiTypeVisualsSetter.NativeFieldInfoPtr_MethVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr, "MethVisuals");
			MultiTypeVisualsSetter.NativeFieldInfoPtr_CocaineVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr, "CocaineVisuals");
			MultiTypeVisualsSetter.NativeFieldInfoPtr_ShroomVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr, "ShroomVisuals");
			MultiTypeVisualsSetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr, 100679651);
			MultiTypeVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr, 100679652);
			MultiTypeVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr, 100679653);
			MultiTypeVisualsSetter.NativeMethodInfoPtr_ResetVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr, 100679654);
			MultiTypeVisualsSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr, 100679655);
		}

		// Token: 0x06007EA4 RID: 32420 RVA: 0x0022ED90 File Offset: 0x0022CF90
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiTypeVisualsSetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x0022EDC4 File Offset: 0x0022CFC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 242265, RefRangeEnd = 242269, XrefRangeStart = 242255, XrefRangeEnd = 242265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVisuals(ProductItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiTypeVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EA6 RID: 32422 RVA: 0x0022EE08 File Offset: 0x0022D008
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242295, RefRangeEnd = 242297, XrefRangeStart = 242269, XrefRangeEnd = 242295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVisuals(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiTypeVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EA7 RID: 32423 RVA: 0x0022EE4C File Offset: 0x0022D04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242297, XrefRangeEnd = 242306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiTypeVisualsSetter.NativeMethodInfoPtr_ResetVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x0022EE80 File Offset: 0x0022D080
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiTypeVisualsSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiTypeVisualsSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiTypeVisualsSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x0003C0FC File Offset: 0x0003A2FC
		public MultiTypeVisualsSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x06007EAA RID: 32426 RVA: 0x0022EEBC File Offset: 0x0022D0BC
		// (set) Token: 0x06007EAB RID: 32427 RVA: 0x0003C105 File Offset: 0x0003A305
		public unsafe WeedVisualsSetter WeedVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTypeVisualsSetter.NativeFieldInfoPtr_WeedVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedVisualsSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTypeVisualsSetter.NativeFieldInfoPtr_WeedVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x06007EAC RID: 32428 RVA: 0x0022EEEC File Offset: 0x0022D0EC
		// (set) Token: 0x06007EAD RID: 32429 RVA: 0x0003C124 File Offset: 0x0003A324
		public unsafe MethVisualsSetter MethVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTypeVisualsSetter.NativeFieldInfoPtr_MethVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethVisualsSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTypeVisualsSetter.NativeFieldInfoPtr_MethVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x06007EAE RID: 32430 RVA: 0x0022EF1C File Offset: 0x0022D11C
		// (set) Token: 0x06007EAF RID: 32431 RVA: 0x0003C143 File Offset: 0x0003A343
		public unsafe CocaineVisualsSetter CocaineVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTypeVisualsSetter.NativeFieldInfoPtr_CocaineVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineVisualsSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTypeVisualsSetter.NativeFieldInfoPtr_CocaineVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002720 RID: 10016
		// (get) Token: 0x06007EB0 RID: 32432 RVA: 0x0022EF4C File Offset: 0x0022D14C
		// (set) Token: 0x06007EB1 RID: 32433 RVA: 0x0003C162 File Offset: 0x0003A362
		public unsafe ShroomVisualsSetter ShroomVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTypeVisualsSetter.NativeFieldInfoPtr_ShroomVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShroomVisualsSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MultiTypeVisualsSetter.NativeFieldInfoPtr_ShroomVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400567D RID: 22141
		private static readonly IntPtr NativeFieldInfoPtr_WeedVisuals;

		// Token: 0x0400567E RID: 22142
		private static readonly IntPtr NativeFieldInfoPtr_MethVisuals;

		// Token: 0x0400567F RID: 22143
		private static readonly IntPtr NativeFieldInfoPtr_CocaineVisuals;

		// Token: 0x04005680 RID: 22144
		private static readonly IntPtr NativeFieldInfoPtr_ShroomVisuals;

		// Token: 0x04005681 RID: 22145
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005682 RID: 22146
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVisuals_Public_Void_ProductItemInstance_0;

		// Token: 0x04005683 RID: 22147
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVisuals_Public_Void_ProductDefinition_0;

		// Token: 0x04005684 RID: 22148
		private static readonly IntPtr NativeMethodInfoPtr_ResetVisuals_Private_Void_0;

		// Token: 0x04005685 RID: 22149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

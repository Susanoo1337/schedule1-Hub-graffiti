using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000509 RID: 1289
	public class FilledPackaging_Equippable : Product_Equippable
	{
		// Token: 0x0600745C RID: 29788 RVA: 0x00208C78 File Offset: 0x00206E78
		// Note: this type is marked as 'beforefieldinit'.
		static FilledPackaging_Equippable()
		{
			Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FilledPackaging_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr);
			FilledPackaging_Equippable.NativeFieldInfoPtr_MultiTypeVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr, "MultiTypeVisuals");
			FilledPackaging_Equippable.NativeMethodInfoPtr_ApplyProductVisuals_Protected_Virtual_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr, 100678286);
			FilledPackaging_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr, 100678287);
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x00208CE4 File Offset: 0x00206EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228219, XrefRangeEnd = 228221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyProductVisuals(ProductItemInstance product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilledPackaging_Equippable.NativeMethodInfoPtr_ApplyProductVisuals_Protected_Virtual_Void_ProductItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x00208D34 File Offset: 0x00206F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228221, XrefRangeEnd = 228222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilledPackaging_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackaging_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackaging_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x000377F0 File Offset: 0x000359F0
		public FilledPackaging_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x06007460 RID: 29792 RVA: 0x00208D70 File Offset: 0x00206F70
		// (set) Token: 0x06007461 RID: 29793 RVA: 0x000377F9 File Offset: 0x000359F9
		public unsafe MultiTypeVisualsSetter MultiTypeVisuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackaging_Equippable.NativeFieldInfoPtr_MultiTypeVisuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiTypeVisualsSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackaging_Equippable.NativeFieldInfoPtr_MultiTypeVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004F4A RID: 20298
		private static readonly IntPtr NativeFieldInfoPtr_MultiTypeVisuals;

		// Token: 0x04004F4B RID: 20299
		private static readonly IntPtr NativeMethodInfoPtr_ApplyProductVisuals_Protected_Virtual_Void_ProductItemInstance_0;

		// Token: 0x04004F4C RID: 20300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000568 RID: 1384
	public class MethVisualsSetter : ProductVisualsSetter
	{
		// Token: 0x06007E9D RID: 32413 RVA: 0x0022EB84 File Offset: 0x0022CD84
		// Note: this type is marked as 'beforefieldinit'.
		static MethVisualsSetter()
		{
			Il2CppClassPointerStore<MethVisualsSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MethVisualsSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethVisualsSetter>.NativeClassPtr);
			MethVisualsSetter.NativeFieldInfoPtr_CrystalMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethVisualsSetter>.NativeClassPtr, "CrystalMaterials");
			MethVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethVisualsSetter>.NativeClassPtr, 100679649);
			MethVisualsSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethVisualsSetter>.NativeClassPtr, 100679650);
		}

		// Token: 0x06007E9E RID: 32414 RVA: 0x0022EBF0 File Offset: 0x0022CDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242246, XrefRangeEnd = 242255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyVisuals(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E9F RID: 32415 RVA: 0x0022EC40 File Offset: 0x0022CE40
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethVisualsSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethVisualsSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethVisualsSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EA0 RID: 32416 RVA: 0x0003C0D4 File Offset: 0x0003A2D4
		public MethVisualsSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x06007EA1 RID: 32417 RVA: 0x0022EC7C File Offset: 0x0022CE7C
		// (set) Token: 0x06007EA2 RID: 32418 RVA: 0x0003C0DD File Offset: 0x0003A2DD
		public unsafe Il2CppReferenceArray<MeshRenderer> CrystalMaterials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethVisualsSetter.NativeFieldInfoPtr_CrystalMaterials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethVisualsSetter.NativeFieldInfoPtr_CrystalMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400567A RID: 22138
		private static readonly IntPtr NativeFieldInfoPtr_CrystalMaterials;

		// Token: 0x0400567B RID: 22139
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0;

		// Token: 0x0400567C RID: 22140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

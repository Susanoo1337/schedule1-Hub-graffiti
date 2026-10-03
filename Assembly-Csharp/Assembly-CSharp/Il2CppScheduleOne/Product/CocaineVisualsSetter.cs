using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000567 RID: 1383
	public class CocaineVisualsSetter : ProductVisualsSetter
	{
		// Token: 0x06007E97 RID: 32407 RVA: 0x0022EA5C File Offset: 0x0022CC5C
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineVisualsSetter()
		{
			Il2CppClassPointerStore<CocaineVisualsSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "CocaineVisualsSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineVisualsSetter>.NativeClassPtr);
			CocaineVisualsSetter.NativeFieldInfoPtr_RockMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineVisualsSetter>.NativeClassPtr, "RockMeshes");
			CocaineVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineVisualsSetter>.NativeClassPtr, 100679647);
			CocaineVisualsSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineVisualsSetter>.NativeClassPtr, 100679648);
		}

		// Token: 0x06007E98 RID: 32408 RVA: 0x0022EAC8 File Offset: 0x0022CCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242237, XrefRangeEnd = 242246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyVisuals(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineVisualsSetter.NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E99 RID: 32409 RVA: 0x0022EB18 File Offset: 0x0022CD18
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineVisualsSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineVisualsSetter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineVisualsSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x0003C0AC File Offset: 0x0003A2AC
		public CocaineVisualsSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700271B RID: 10011
		// (get) Token: 0x06007E9B RID: 32411 RVA: 0x0022EB54 File Offset: 0x0022CD54
		// (set) Token: 0x06007E9C RID: 32412 RVA: 0x0003C0B5 File Offset: 0x0003A2B5
		public unsafe Il2CppReferenceArray<MeshRenderer> RockMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineVisualsSetter.NativeFieldInfoPtr_RockMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineVisualsSetter.NativeFieldInfoPtr_RockMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005677 RID: 22135
		private static readonly IntPtr NativeFieldInfoPtr_RockMeshes;

		// Token: 0x04005678 RID: 22136
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVisuals_Public_Virtual_Void_ProductDefinition_0;

		// Token: 0x04005679 RID: 22137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

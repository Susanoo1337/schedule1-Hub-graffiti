using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200002B RID: 43
	public class RandomMaterial : MonoBehaviour
	{
		// Token: 0x060001FD RID: 509 RVA: 0x00081BE4 File Offset: 0x0007FDE4
		// Note: this type is marked as 'beforefieldinit'.
		static RandomMaterial()
		{
			Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RandomMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr);
			RandomMaterial.NativeFieldInfoPtr_targetRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr, "targetRenderer");
			RandomMaterial.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr, "materials");
			RandomMaterial.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr, 100663552);
			RandomMaterial.NativeMethodInfoPtr_ChangeMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr, 100663553);
			RandomMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr, 100663554);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00081C78 File Offset: 0x0007FE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67406, XrefRangeEnd = 67410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomMaterial.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00081CAC File Offset: 0x0007FEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomMaterial.NativeMethodInfoPtr_ChangeMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00081CE0 File Offset: 0x0007FEE0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002FCF File Offset: 0x000011CF
		public RandomMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00081D1C File Offset: 0x0007FF1C
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002FD8 File Offset: 0x000011D8
		public unsafe Renderer targetRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMaterial.NativeFieldInfoPtr_targetRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMaterial.NativeFieldInfoPtr_targetRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00081D4C File Offset: 0x0007FF4C
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002FF7 File Offset: 0x000011F7
		public unsafe Il2CppReferenceArray<Material> materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMaterial.NativeFieldInfoPtr_materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomMaterial.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeFieldInfoPtr_targetRenderer;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_materials;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_ChangeMaterial_Public_Void_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002B8 RID: 696
	public class Grave : MonoBehaviour
	{
		// Token: 0x060035FC RID: 13820 RVA: 0x0012ED60 File Offset: 0x0012CF60
		// Note: this type is marked as 'beforefieldinit'.
		static Grave()
		{
			Il2CppClassPointerStore<Grave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Grave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grave>.NativeClassPtr);
			Grave.NativeFieldInfoPtr_Surfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "Surfaces");
			Grave.NativeFieldInfoPtr_HeadstoneObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneObjects");
			Grave.NativeFieldInfoPtr_HeadstoneMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneMeshes");
			Grave.NativeFieldInfoPtr_HeadstoneMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneMaterials");
			Grave.NativeMethodInfoPtr_RandomizeGrave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave>.NativeClassPtr, 100670133);
			Grave.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave>.NativeClassPtr, 100670134);
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x0012EE08 File Offset: 0x0012D008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141830, XrefRangeEnd = 141841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeGrave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.NativeMethodInfoPtr_RandomizeGrave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x0012EE3C File Offset: 0x0012D03C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grave() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grave>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x0001B718 File Offset: 0x00019918
		public Grave(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06003600 RID: 13824 RVA: 0x0012EE78 File Offset: 0x0012D078
		// (set) Token: 0x06003601 RID: 13825 RVA: 0x0001B721 File Offset: 0x00019921
		public unsafe Il2CppReferenceArray<Grave.GraveSuface> Surfaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_Surfaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Grave.GraveSuface>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_Surfaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06003602 RID: 13826 RVA: 0x0012EEA8 File Offset: 0x0012D0A8
		// (set) Token: 0x06003603 RID: 13827 RVA: 0x0001B740 File Offset: 0x00019940
		public unsafe Il2CppReferenceArray<GameObject> HeadstoneObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x0012EED8 File Offset: 0x0012D0D8
		// (set) Token: 0x06003605 RID: 13829 RVA: 0x0001B75F File Offset: 0x0001995F
		public unsafe Il2CppReferenceArray<MeshRenderer> HeadstoneMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x0012EF08 File Offset: 0x0012D108
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x0001B77E File Offset: 0x0001997E
		public unsafe Il2CppReferenceArray<Material> HeadstoneMaterials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMaterials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002429 RID: 9257
		private static readonly IntPtr NativeFieldInfoPtr_Surfaces;

		// Token: 0x0400242A RID: 9258
		private static readonly IntPtr NativeFieldInfoPtr_HeadstoneObjects;

		// Token: 0x0400242B RID: 9259
		private static readonly IntPtr NativeFieldInfoPtr_HeadstoneMeshes;

		// Token: 0x0400242C RID: 9260
		private static readonly IntPtr NativeFieldInfoPtr_HeadstoneMaterials;

		// Token: 0x0400242D RID: 9261
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeGrave_Public_Void_0;

		// Token: 0x0400242E RID: 9262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A12 RID: 2578
		[Serializable]
		public class GraveSuface : Il2CppSystem.Object
		{
			// Token: 0x0600DE22 RID: 56866 RVA: 0x0036CAF4 File Offset: 0x0036ACF4
			// Note: this type is marked as 'beforefieldinit'.
			static GraveSuface()
			{
				Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Grave>.NativeClassPtr, "GraveSuface");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr);
				Grave.GraveSuface.NativeFieldInfoPtr_Object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Object");
				Grave.GraveSuface.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Mesh");
				Grave.GraveSuface.NativeFieldInfoPtr_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Materials");
				Grave.GraveSuface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, 100670135);
			}

			// Token: 0x0600DE23 RID: 56867 RVA: 0x0036CB70 File Offset: 0x0036AD70
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GraveSuface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.GraveSuface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE24 RID: 56868 RVA: 0x00068940 File Offset: 0x00066B40
			public GraveSuface(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A4 RID: 17316
			// (get) Token: 0x0600DE25 RID: 56869 RVA: 0x0036CBAC File Offset: 0x0036ADAC
			// (set) Token: 0x0600DE26 RID: 56870 RVA: 0x00068949 File Offset: 0x00066B49
			public unsafe GameObject Object
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Object);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Object), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A5 RID: 17317
			// (get) Token: 0x0600DE27 RID: 56871 RVA: 0x0036CBDC File Offset: 0x0036ADDC
			// (set) Token: 0x0600DE28 RID: 56872 RVA: 0x00068968 File Offset: 0x00066B68
			public unsafe MeshRenderer Mesh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Mesh);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A6 RID: 17318
			// (get) Token: 0x0600DE29 RID: 56873 RVA: 0x0036CC0C File Offset: 0x0036AE0C
			// (set) Token: 0x0600DE2A RID: 56874 RVA: 0x00068987 File Offset: 0x00066B87
			public unsafe Il2CppReferenceArray<Material> Materials
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Materials);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Materials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009759 RID: 38745
			private static readonly IntPtr NativeFieldInfoPtr_Object;

			// Token: 0x0400975A RID: 38746
			private static readonly IntPtr NativeFieldInfoPtr_Mesh;

			// Token: 0x0400975B RID: 38747
			private static readonly IntPtr NativeFieldInfoPtr_Materials;

			// Token: 0x0400975C RID: 38748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

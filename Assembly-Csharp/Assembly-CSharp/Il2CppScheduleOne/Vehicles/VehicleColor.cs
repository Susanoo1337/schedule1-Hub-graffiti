using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000D6 RID: 214
	public class VehicleColor : MonoBehaviour
	{
		// Token: 0x06001496 RID: 5270 RVA: 0x000C050C File Offset: 0x000BE70C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleColor()
		{
			Il2CppClassPointerStore<VehicleColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColor>.NativeClassPtr);
			VehicleColor.NativeFieldInfoPtr_BodyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColor>.NativeClassPtr, "BodyMeshes");
			VehicleColor.NativeFieldInfoPtr_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColor>.NativeClassPtr, "DefaultColor");
			VehicleColor.NativeFieldInfoPtr_displayedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColor>.NativeClassPtr, "displayedColor");
			VehicleColor.NativeFieldInfoPtr_initialColorApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColor>.NativeClassPtr, "initialColorApplied");
			VehicleColor.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColor>.NativeClassPtr, 100666241);
			VehicleColor.NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColor>.NativeClassPtr, 100666242);
			VehicleColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColor>.NativeClassPtr, 100666243);
			VehicleColor.NativeMethodInfoPtr__ApplyColor_b__6_0_Private_Boolean_VehicleColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColor>.NativeClassPtr, 100666244);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000C05DC File Offset: 0x000BE7DC
		[CallerCount(0)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColor.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x000C0610 File Offset: 0x000BE810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94289, XrefRangeEnd = 94324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyColor(EVehicleColor col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleColor.NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x000C065C File Offset: 0x000BE85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94324, XrefRangeEnd = 94325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleColor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x000C0698 File Offset: 0x000BE898
		[CallerCount(0)]
		public unsafe bool _ApplyColor_b__6_0(VehicleColors.VehicleColorData x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColor.NativeMethodInfoPtr__ApplyColor_b__6_0_Private_Boolean_VehicleColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0000B4F7 File Offset: 0x000096F7
		public VehicleColor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x000C06E8 File Offset: 0x000BE8E8
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x0000B500 File Offset: 0x00009700
		public unsafe Il2CppReferenceArray<VehicleColor.BodyMesh> BodyMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.NativeFieldInfoPtr_BodyMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehicleColor.BodyMesh>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.NativeFieldInfoPtr_BodyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x000C0718 File Offset: 0x000BE918
		// (set) Token: 0x0600149F RID: 5279 RVA: 0x0000B51F File Offset: 0x0000971F
		public unsafe EVehicleColor DefaultColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.NativeFieldInfoPtr_DefaultColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.NativeFieldInfoPtr_DefaultColor)) = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x000C0740 File Offset: 0x000BE940
		// (set) Token: 0x060014A1 RID: 5281 RVA: 0x0000B53A File Offset: 0x0000973A
		public unsafe EVehicleColor displayedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.NativeFieldInfoPtr_displayedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.NativeFieldInfoPtr_displayedColor)) = value;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x000C0768 File Offset: 0x000BE968
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x0000B555 File Offset: 0x00009755
		public unsafe bool initialColorApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.NativeFieldInfoPtr_initialColorApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.NativeFieldInfoPtr_initialColorApplied)) = value;
			}
		}

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeFieldInfoPtr_BodyMeshes;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeFieldInfoPtr_DefaultColor;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeFieldInfoPtr_displayedColor;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeFieldInfoPtr_initialColorApplied;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColor_Public_Virtual_New_Void_EVehicleColor_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr__ApplyColor_b__6_0_Private_Boolean_VehicleColorData_0;

		// Token: 0x0200091E RID: 2334
		[Serializable]
		public class BodyMesh : Il2CppSystem.Object
		{
			// Token: 0x0600D73D RID: 55101 RVA: 0x00359330 File Offset: 0x00357530
			// Note: this type is marked as 'beforefieldinit'.
			static BodyMesh()
			{
				Il2CppClassPointerStore<VehicleColor.BodyMesh>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleColor>.NativeClassPtr, "BodyMesh");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleColor.BodyMesh>.NativeClassPtr);
				VehicleColor.BodyMesh.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColor.BodyMesh>.NativeClassPtr, "Renderer");
				VehicleColor.BodyMesh.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleColor.BodyMesh>.NativeClassPtr, "MaterialIndex");
				VehicleColor.BodyMesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleColor.BodyMesh>.NativeClassPtr, 100666245);
			}

			// Token: 0x0600D73E RID: 55102 RVA: 0x00359398 File Offset: 0x00357598
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BodyMesh() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleColor.BodyMesh>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleColor.BodyMesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D73F RID: 55103 RVA: 0x00065200 File Offset: 0x00063400
			public BodyMesh(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041BC RID: 16828
			// (get) Token: 0x0600D740 RID: 55104 RVA: 0x003593D4 File Offset: 0x003575D4
			// (set) Token: 0x0600D741 RID: 55105 RVA: 0x00065209 File Offset: 0x00063409
			public unsafe MeshRenderer Renderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.BodyMesh.NativeFieldInfoPtr_Renderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.BodyMesh.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041BD RID: 16829
			// (get) Token: 0x0600D742 RID: 55106 RVA: 0x00359404 File Offset: 0x00357604
			// (set) Token: 0x0600D743 RID: 55107 RVA: 0x00065228 File Offset: 0x00063428
			public unsafe int MaterialIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.BodyMesh.NativeFieldInfoPtr_MaterialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleColor.BodyMesh.NativeFieldInfoPtr_MaterialIndex)) = value;
				}
			}

			// Token: 0x040092BB RID: 37563
			private static readonly IntPtr NativeFieldInfoPtr_Renderer;

			// Token: 0x040092BC RID: 37564
			private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

			// Token: 0x040092BD RID: 37565
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

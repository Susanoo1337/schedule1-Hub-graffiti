using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000068 RID: 104
	public class PolygonHelper : MonoBehaviour
	{
		// Token: 0x06000698 RID: 1688 RVA: 0x00005460 File Offset: 0x00003660
		// Note: this type is marked as 'beforefieldinit'.
		static PolygonHelper()
		{
			Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "PolygonHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr);
			PolygonHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr, 100664099);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x000900A4 File Offset: 0x0008E2A4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PolygonHelper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00005499 File Offset: 0x00003699
		public PolygonHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000886 RID: 2182
		[StructLayout(2)]
		public struct Plane2D
		{
			// Token: 0x0600D241 RID: 53825 RVA: 0x003493D0 File Offset: 0x003475D0
			// Note: this type is marked as 'beforefieldinit'.
			static Plane2D()
			{
				Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PolygonHelper>.NativeClassPtr, "Plane2D");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr);
				PolygonHelper.Plane2D.NativeFieldInfoPtr_normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, "normal");
				PolygonHelper.Plane2D.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, "distance");
				PolygonHelper.Plane2D.NativeMethodInfoPtr_Distance_Public_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664100);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_ClosestPoint_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664101);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_Intersect_Public_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664102);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_GetSide_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664103);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_FromPoints_Public_Static_Plane2D_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664104);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_FromNormalAndPoint_Public_Static_Plane2D_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664105);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_Flip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664106);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_CutConvex_Public_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664107);
				PolygonHelper.Plane2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, 100664108);
			}

			// Token: 0x0600D242 RID: 53826 RVA: 0x003494D8 File Offset: 0x003476D8
			[CallerCount(0)]
			public unsafe float Distance(Vector2 point)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_Distance_Public_Single_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D243 RID: 53827 RVA: 0x00349518 File Offset: 0x00347718
			[CallerCount(0)]
			public unsafe Vector2 ClosestPoint(Vector2 pt)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref pt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_ClosestPoint_Public_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D244 RID: 53828 RVA: 0x00349558 File Offset: 0x00347758
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 72043, RefRangeEnd = 72045, XrefRangeStart = 72041, XrefRangeEnd = 72043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 Intersect(Vector2 p1, Vector2 p2)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p1;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_Intersect_Public_Vector2_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D245 RID: 53829 RVA: 0x003495A4 File Offset: 0x003477A4
			[CallerCount(0)]
			public unsafe bool GetSide(Vector2 point)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_GetSide_Public_Boolean_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D246 RID: 53830 RVA: 0x003495E4 File Offset: 0x003477E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72046, RefRangeEnd = 72047, XrefRangeStart = 72045, XrefRangeEnd = 72046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PolygonHelper.Plane2D FromPoints(Vector3 p1, Vector3 p2)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p1;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_FromPoints_Public_Static_Plane2D_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D247 RID: 53831 RVA: 0x00349630 File Offset: 0x00347830
			[CallerCount(0)]
			public unsafe static PolygonHelper.Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref normalizedNormal;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_FromNormalAndPoint_Public_Static_Plane2D_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D248 RID: 53832 RVA: 0x0034967C File Offset: 0x0034787C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72047, RefRangeEnd = 72048, XrefRangeStart = 72047, XrefRangeEnd = 72047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Flip()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_Flip_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D249 RID: 53833 RVA: 0x003496A4 File Offset: 0x003478A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72069, RefRangeEnd = 72070, XrefRangeStart = 72048, XrefRangeEnd = 72069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<Vector2> CutConvex(Il2CppStructArray<Vector2> poly)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(poly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_CutConvex_Public_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}

			// Token: 0x0600D24A RID: 53834 RVA: 0x003496E8 File Offset: 0x003478E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72070, XrefRangeEnd = 72080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PolygonHelper.Plane2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D24B RID: 53835 RVA: 0x000637AE File Offset: 0x000619AE
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PolygonHelper.Plane2D>.NativeClassPtr, ref this));
			}

			// Token: 0x04008F42 RID: 36674
			private static readonly IntPtr NativeFieldInfoPtr_normal;

			// Token: 0x04008F43 RID: 36675
			private static readonly IntPtr NativeFieldInfoPtr_distance;

			// Token: 0x04008F44 RID: 36676
			private static readonly IntPtr NativeMethodInfoPtr_Distance_Public_Single_Vector2_0;

			// Token: 0x04008F45 RID: 36677
			private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Public_Vector2_Vector2_0;

			// Token: 0x04008F46 RID: 36678
			private static readonly IntPtr NativeMethodInfoPtr_Intersect_Public_Vector2_Vector2_Vector2_0;

			// Token: 0x04008F47 RID: 36679
			private static readonly IntPtr NativeMethodInfoPtr_GetSide_Public_Boolean_Vector2_0;

			// Token: 0x04008F48 RID: 36680
			private static readonly IntPtr NativeMethodInfoPtr_FromPoints_Public_Static_Plane2D_Vector3_Vector3_0;

			// Token: 0x04008F49 RID: 36681
			private static readonly IntPtr NativeMethodInfoPtr_FromNormalAndPoint_Public_Static_Plane2D_Vector3_Vector3_0;

			// Token: 0x04008F4A RID: 36682
			private static readonly IntPtr NativeMethodInfoPtr_Flip_Public_Void_0;

			// Token: 0x04008F4B RID: 36683
			private static readonly IntPtr NativeMethodInfoPtr_CutConvex_Public_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_Vector2_0;

			// Token: 0x04008F4C RID: 36684
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04008F4D RID: 36685
			[FieldOffset(0)]
			public Vector2 normal;

			// Token: 0x04008F4E RID: 36686
			[FieldOffset(8)]
			public float distance;
		}
	}
}

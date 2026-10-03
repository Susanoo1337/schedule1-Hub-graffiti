using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003EF RID: 1007
	public static class GeometryUtility : Il2CppSystem.Object
	{
		// Token: 0x060059C3 RID: 22979 RVA: 0x001B114C File Offset: 0x001AF34C
		// Note: this type is marked as 'beforefieldinit'.
		static GeometryUtility()
		{
			Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GeometryUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr);
			GeometryUtility.NativeMethodInfoPtr_TryGetIntersection_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100675042);
			GeometryUtility.NativeMethodInfoPtr_TryRayLineIntersection_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100675043);
			GeometryUtility.NativeMethodInfoPtr_LineIntersection_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100675044);
			GeometryUtility.NativeMethodInfoPtr_Cross_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100675045);
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x001B11CC File Offset: 0x001AF3CC
		[CallerCount(0)]
		public unsafe static bool TryGetIntersection(Vector2 p0, Vector2 d1, Vector2 q0, Vector2 d2, out Vector2 intersection, out float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &intersection;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_TryGetIntersection_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x001B1254 File Offset: 0x001AF454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194359, RefRangeEnd = 194360, XrefRangeStart = 194357, XrefRangeEnd = 194359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryRayLineIntersection(Vector2 p0, Vector2 d1, Vector2 r0, Vector2 d2, out Vector2 intersection, out float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p0;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r0;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &intersection;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_TryRayLineIntersection_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060059C6 RID: 22982 RVA: 0x001B12DC File Offset: 0x001AF4DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194361, RefRangeEnd = 194362, XrefRangeStart = 194360, XrefRangeEnd = 194361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LineIntersection(Vector2 p, Vector2 r, Vector2 a, Vector2 b, out float t, out float u)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref p;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &t;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &u;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_LineIntersection_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x001B1364 File Offset: 0x001AF564
		[CallerCount(0)]
		public unsafe static float Cross(Vector2 a, Vector2 b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_Cross_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x0002A8EB File Offset: 0x00028AEB
		public GeometryUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003D9F RID: 15775
		private static readonly IntPtr NativeMethodInfoPtr_TryGetIntersection_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_byref_Single_0;

		// Token: 0x04003DA0 RID: 15776
		private static readonly IntPtr NativeMethodInfoPtr_TryRayLineIntersection_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Vector2_byref_Single_0;

		// Token: 0x04003DA1 RID: 15777
		private static readonly IntPtr NativeMethodInfoPtr_LineIntersection_Public_Static_Boolean_Vector2_Vector2_Vector2_Vector2_byref_Single_byref_Single_0;

		// Token: 0x04003DA2 RID: 15778
		private static readonly IntPtr NativeMethodInfoPtr_Cross_Public_Static_Single_Vector2_Vector2_0;
	}
}

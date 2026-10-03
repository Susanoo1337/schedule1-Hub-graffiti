using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000083 RID: 131
	[StructLayout(2)]
	public struct Plane
	{
		// Token: 0x06000681 RID: 1665 RVA: 0x0002BC5C File Offset: 0x00029E5C
		// Note: this type is marked as 'beforefieldinit'.
		static Plane()
		{
			Il2CppClassPointerStore<Plane>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Plane");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Plane>.NativeClassPtr);
			Plane.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, "size");
			Plane.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, "m_Normal");
			Plane.NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, "m_Distance");
			Plane.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663988);
			Plane.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663989);
			Plane.NativeMethodInfoPtr_set_distance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663990);
			Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663991);
			Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663992);
			Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663993);
			Plane.NativeMethodInfoPtr_GetDistanceToPoint_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663994);
			Plane.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663995);
			Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663996);
			Plane.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100663997);
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0002BD90 File Offset: 0x00029F90
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00004FF8 File Offset: 0x000031F8
		public unsafe Vector3 normal
		{
			[CallerCount(133)]
			[CachedScanResults(RefRangeStart = 1218506, RefRangeEnd = 1218639, XrefRangeStart = 1218506, XrefRangeEnd = 1218639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Normal = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0002BDC0 File Offset: 0x00029FC0
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x0002BDF0 File Offset: 0x00029FF0
		public unsafe float distance
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 1222680, RefRangeEnd = 1222717, XrefRangeStart = 1222680, XrefRangeEnd = 1222717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_get_distance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 42819, RefRangeEnd = 42826, XrefRangeStart = 42819, XrefRangeEnd = 42826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_set_distance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0002BE24 File Offset: 0x0002A024
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1232827, RefRangeEnd = 1232831, XrefRangeStart = 1232826, XrefRangeEnd = 1232827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane(Vector3 inNormal, Vector3 inPoint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inNormal;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0002BE64 File Offset: 0x0002A064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232831, XrefRangeEnd = 1232832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane(Vector3 inNormal, float d)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inNormal;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0002BEA4 File Offset: 0x0002A0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232832, XrefRangeEnd = 1232833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane(Vector3 a, Vector3 b, Vector3 c)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0002BEF4 File Offset: 0x0002A0F4
		[CallerCount(0)]
		public unsafe float GetDistanceToPoint(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_GetDistanceToPoint_Public_Single_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0002BF34 File Offset: 0x0002A134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232833, XrefRangeEnd = 1232836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Raycast(Ray ray, out float enter)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ray;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &enter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0002BF80 File Offset: 0x0002A180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232836, XrefRangeEnd = 1232837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0002BFAC File Offset: 0x0002A1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232837, XrefRangeEnd = 1232862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00004FD8 File Offset: 0x000031D8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Plane>.NativeClassPtr, ref this));
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x0002BFFC File Offset: 0x0002A1FC
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00004FEA File Offset: 0x000031EA
		public unsafe static int size
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Plane.NativeFieldInfoPtr_size, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Plane.NativeFieldInfoPtr_size, (void*)(&value));
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00005002 File Offset: 0x00003202
		public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint)
		{
			this.m_Normal = Vector3.Normalize(inNormal);
			this.m_Distance = -Vector3.Dot(this.m_Normal, inPoint);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00005024 File Offset: 0x00003224
		public void Set3Points(Vector3 a, Vector3 b, Vector3 c)
		{
			this.m_Normal = Vector3.Normalize(Vector3.Cross(b - a, c - a));
			this.m_Distance = -Vector3.Dot(this.m_Normal, a);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00005058 File Offset: 0x00003258
		public void Flip()
		{
			this.m_Normal = -this.m_Normal;
			this.m_Distance = -this.m_Distance;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x0002C018 File Offset: 0x0002A218
		public Plane flipped
		{
			get
			{
				return new Plane(-this.m_Normal, -this.m_Distance);
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00005079 File Offset: 0x00003279
		public void Translate(Vector3 translation)
		{
			this.m_Distance += Vector3.Dot(this.m_Normal, translation);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0002C044 File Offset: 0x0002A244
		public static Plane Translate(Plane plane, Vector3 translation)
		{
			return new Plane(plane.m_Normal, plane.m_Distance += Vector3.Dot(plane.m_Normal, translation));
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0002C07C File Offset: 0x0002A27C
		public Vector3 ClosestPointOnPlane(Vector3 point)
		{
			float d = Vector3.Dot(this.m_Normal, point) + this.m_Distance;
			return point - this.m_Normal * d;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0002C0B4 File Offset: 0x0002A2B4
		public bool GetSide(Vector3 point)
		{
			return Vector3.Dot(this.m_Normal, point) + this.m_Distance > 0f;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0002C0E0 File Offset: 0x0002A2E0
		public bool SameSide(Vector3 inPt0, Vector3 inPt1)
		{
			float distanceToPoint = this.GetDistanceToPoint(inPt0);
			float distanceToPoint2 = this.GetDistanceToPoint(inPt1);
			return (distanceToPoint > 0f && distanceToPoint2 > 0f) || (distanceToPoint <= 0f && distanceToPoint2 <= 0f);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0002C12C File Offset: 0x0002A32C
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr_m_Normal;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeFieldInfoPtr_m_Distance;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector3_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_set_distance_Public_set_Void_Single_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_GetDistanceToPoint_Public_Single_Vector3_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000574 RID: 1396
		[FieldOffset(0)]
		public Vector3 m_Normal;

		// Token: 0x04000575 RID: 1397
		[FieldOffset(12)]
		public float m_Distance;
	}
}

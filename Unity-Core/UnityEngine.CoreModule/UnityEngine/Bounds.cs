using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000080 RID: 128
	[StructLayout(2)]
	public struct Bounds
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x0002A404 File Offset: 0x00028604
		// Note: this type is marked as 'beforefieldinit'.
		static Bounds()
		{
			Il2CppClassPointerStore<Bounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Bounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bounds>.NativeClassPtr);
			Bounds.NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bounds>.NativeClassPtr, "m_Center");
			Bounds.NativeFieldInfoPtr_m_Extents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bounds>.NativeClassPtr, "m_Extents");
			Bounds.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663940);
			Bounds.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663941);
			Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663942);
			Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663943);
			Bounds.NativeMethodInfoPtr_get_center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663944);
			Bounds.NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663945);
			Bounds.NativeMethodInfoPtr_get_size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663946);
			Bounds.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663947);
			Bounds.NativeMethodInfoPtr_get_extents_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663948);
			Bounds.NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663949);
			Bounds.NativeMethodInfoPtr_get_min_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663950);
			Bounds.NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663951);
			Bounds.NativeMethodInfoPtr_get_max_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663952);
			Bounds.NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663953);
			Bounds.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663954);
			Bounds.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663955);
			Bounds.NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663956);
			Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663957);
			Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663958);
			Bounds.NativeMethodInfoPtr_Expand_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663959);
			Bounds.NativeMethodInfoPtr_Expand_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663960);
			Bounds.NativeMethodInfoPtr_Intersects_Public_Boolean_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663961);
			Bounds.NativeMethodInfoPtr_IntersectRay_Public_Boolean_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663962);
			Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663963);
			Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663964);
			Bounds.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663965);
			Bounds.NativeMethodInfoPtr_SqrDistance_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663966);
			Bounds.NativeMethodInfoPtr_IntersectRayAABB_Private_Static_Boolean_Ray_Bounds_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663967);
			Bounds.NativeMethodInfoPtr_Contains_Injected_Private_Static_Boolean_byref_Bounds_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663968);
			Bounds.NativeMethodInfoPtr_SqrDistance_Injected_Private_Static_Single_byref_Bounds_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663969);
			Bounds.NativeMethodInfoPtr_IntersectRayAABB_Injected_Private_Static_Boolean_byref_Ray_byref_Bounds_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663970);
			Bounds.ClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<Bounds.ClosestPoint_InjectedDelegate>("UnityEngine.Bounds::ClosestPoint_Injected");
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0002A6D8 File Offset: 0x000288D8
		[CallerCount(0)]
		public unsafe Bounds(Vector3 center, Vector3 size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref center;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0002A718 File Offset: 0x00028918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232649, XrefRangeEnd = 1232655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0002A748 File Offset: 0x00028948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232655, XrefRangeEnd = 1232658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0002A78C File Offset: 0x0002898C
		[CallerCount(0)]
		public unsafe bool Equals(Bounds other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x0002A7CC File Offset: 0x000289CC
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x0002A7FC File Offset: 0x000289FC
		public unsafe Vector3 center
		{
			[CallerCount(133)]
			[CachedScanResults(RefRangeStart = 1218506, RefRangeEnd = 1218639, XrefRangeStart = 1218506, XrefRangeEnd = 1218639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_center_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1073031, RefRangeEnd = 1073048, XrefRangeStart = 1073031, XrefRangeEnd = 1073048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x0002A830 File Offset: 0x00028A30
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x0002A860 File Offset: 0x00028A60
		public unsafe Vector3 size
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_size_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0002A894 File Offset: 0x00028A94
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x0002A8C4 File Offset: 0x00028AC4
		public unsafe Vector3 extents
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 1232658, RefRangeEnd = 1232689, XrefRangeStart = 1232658, XrefRangeEnd = 1232658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_extents_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1218684, RefRangeEnd = 1218692, XrefRangeStart = 1218684, XrefRangeEnd = 1218692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0002A8F8 File Offset: 0x00028AF8
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x0002A928 File Offset: 0x00028B28
		public unsafe Vector3 min
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_min_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0002A95C File Offset: 0x00028B5C
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x0002A98C File Offset: 0x00028B8C
		public unsafe Vector3 max
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_max_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0002A9C0 File Offset: 0x00028BC0
		[CallerCount(0)]
		public unsafe static bool operator ==(Bounds lhs, Bounds rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0002AA0C File Offset: 0x00028C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232689, XrefRangeEnd = 1232690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Bounds lhs, Bounds rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0002AA58 File Offset: 0x00028C58
		[CallerCount(0)]
		public unsafe void SetMinMax(Vector3 min, Vector3 max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0002AA98 File Offset: 0x00028C98
		[CallerCount(0)]
		public unsafe void Encapsulate(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0002AACC File Offset: 0x00028CCC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1232690, RefRangeEnd = 1232697, XrefRangeStart = 1232690, XrefRangeEnd = 1232690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encapsulate(Bounds bounds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0002AB00 File Offset: 0x00028D00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1232697, RefRangeEnd = 1232699, XrefRangeStart = 1232697, XrefRangeEnd = 1232697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Expand(float amount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Expand_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0002AB34 File Offset: 0x00028D34
		[CallerCount(0)]
		public unsafe void Expand(Vector3 amount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Expand_Public_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0002AB68 File Offset: 0x00028D68
		[CallerCount(0)]
		public unsafe bool Intersects(Bounds bounds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Intersects_Public_Boolean_Bounds_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0002ABA8 File Offset: 0x00028DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232699, XrefRangeEnd = 1232701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IntersectRay(Ray ray)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ray;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_IntersectRay_Public_Boolean_Ray_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0002ABE8 File Offset: 0x00028DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232701, XrefRangeEnd = 1232702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0002AC14 File Offset: 0x00028E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232702, XrefRangeEnd = 1232727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0002AC64 File Offset: 0x00028E64
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1232729, RefRangeEnd = 1232745, XrefRangeStart = 1232727, XrefRangeEnd = 1232729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232747, RefRangeEnd = 1232748, XrefRangeStart = 1232745, XrefRangeEnd = 1232747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float SqrDistance(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_SqrDistance_Public_Single_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0002ACE4 File Offset: 0x00028EE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1232750, RefRangeEnd = 1232752, XrefRangeStart = 1232748, XrefRangeEnd = 1232750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ray;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_IntersectRayAABB_Private_Static_Boolean_Ray_Bounds_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0002AD40 File Offset: 0x00028F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232752, XrefRangeEnd = 1232754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Contains_Injected_Private_Static_Boolean_byref_Bounds_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0002AD8C File Offset: 0x00028F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232754, XrefRangeEnd = 1232756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_SqrDistance_Injected_Private_Static_Single_byref_Bounds_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0002ADD8 File Offset: 0x00028FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232756, XrefRangeEnd = 1232758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ray;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dist;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_IntersectRayAABB_Injected_Private_Static_Boolean_byref_Ray_byref_Bounds_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00004E8A File Offset: 0x0000308A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Bounds>.NativeClassPtr, ref this));
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0002AE34 File Offset: 0x00029034
		public bool IntersectRay(Ray ray, out float distance)
		{
			return Bounds.IntersectRayAABB(ray, this, out distance);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0002AE54 File Offset: 0x00029054
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0002AE70 File Offset: 0x00029070
		public Vector3 ClosestPoint(Vector3 point)
		{
			Vector3 result;
			Bounds.ClosestPoint_Injected(ref this, ref point, out result);
			return result;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00004E9C File Offset: 0x0000309C
		public static void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret)
		{
			Bounds.ClosestPoint_InjectedDelegateField(ref _unity_self, ref point, out ret);
		}

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeFieldInfoPtr_m_Center;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeFieldInfoPtr_m_Extents;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector3_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_get_extents_Public_get_Vector3_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_get_min_Public_get_Vector3_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_get_max_Public_get_Vector3_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_Expand_Public_Void_Single_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_Expand_Public_Void_Vector3_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_Bounds_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_IntersectRay_Public_Boolean_Ray_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_SqrDistance_Public_Single_Vector3_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_IntersectRayAABB_Private_Static_Boolean_Ray_Bounds_byref_Single_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Injected_Private_Static_Boolean_byref_Bounds_byref_Vector3_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_SqrDistance_Injected_Private_Static_Single_byref_Bounds_byref_Vector3_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_IntersectRayAABB_Injected_Private_Static_Boolean_byref_Ray_byref_Bounds_byref_Single_0;

		// Token: 0x0400054E RID: 1358
		[FieldOffset(0)]
		public Vector3 m_Center;

		// Token: 0x0400054F RID: 1359
		[FieldOffset(12)]
		public Vector3 m_Extents;

		// Token: 0x04000550 RID: 1360
		private static readonly Bounds.ClosestPoint_InjectedDelegate ClosestPoint_InjectedDelegateField;

		// Token: 0x020004E0 RID: 1248
		// (Invoke) Token: 0x06003274 RID: 12916
		private delegate void ClosestPoint_InjectedDelegate(IntPtr _unity_self, IntPtr point, [Out] IntPtr ret);
	}
}

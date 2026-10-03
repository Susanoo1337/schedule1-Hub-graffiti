using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Levelling
{
	// Token: 0x020002FF RID: 767
	[Serializable]
	[StructLayout(2)]
	public struct FullRank
	{
		// Token: 0x06003CB3 RID: 15539 RVA: 0x0014792C File Offset: 0x00145B2C
		// Note: this type is marked as 'beforefieldinit'.
		static FullRank()
		{
			Il2CppClassPointerStore<FullRank>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Levelling", "FullRank");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullRank>.NativeClassPtr);
			FullRank.NativeFieldInfoPtr_TIER_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullRank>.NativeClassPtr, "TIER_COUNT");
			FullRank.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullRank>.NativeClassPtr, "Rank");
			FullRank.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullRank>.NativeClassPtr, "Tier");
			FullRank.NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671047);
			FullRank.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671048);
			FullRank.NativeMethodInfoPtr_NextRank_Public_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671049);
			FullRank.NativeMethodInfoPtr_ToFloat_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671050);
			FullRank.NativeMethodInfoPtr_GetRankIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671051);
			FullRank.NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671052);
			FullRank.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671053);
			FullRank.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671054);
			FullRank.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671055);
			FullRank.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671056);
			FullRank.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671057);
			FullRank.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671058);
			FullRank.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671059);
			FullRank.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671060);
			FullRank.NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullRank>.NativeClassPtr, 100671061);
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x00147AC4 File Offset: 0x00145CC4
		[CallerCount(494)]
		[CachedScanResults(RefRangeStart = 60743, RefRangeEnd = 61237, XrefRangeStart = 60743, XrefRangeEnd = 61237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank(ERank rank, int tier)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x00147B04 File Offset: 0x00145D04
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 151411, RefRangeEnd = 151419, XrefRangeStart = 151395, XrefRangeEnd = 151411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x00147B30 File Offset: 0x00145D30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151419, RefRangeEnd = 151421, XrefRangeStart = 151419, XrefRangeEnd = 151419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullRank NextRank()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_NextRank_Public_FullRank_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x00147B60 File Offset: 0x00145D60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 151421, RefRangeEnd = 151426, XrefRangeStart = 151421, XrefRangeEnd = 151421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ToFloat()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_ToFloat_Public_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x00147B90 File Offset: 0x00145D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151426, RefRangeEnd = 151427, XrefRangeStart = 151426, XrefRangeEnd = 151426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRankIndex()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_GetRankIndex_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x00147BC0 File Offset: 0x00145DC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151443, RefRangeEnd = 151446, XrefRangeStart = 151427, XrefRangeEnd = 151443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(FullRank rank)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x00147BF8 File Offset: 0x00145DF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151446, RefRangeEnd = 151447, XrefRangeStart = 151446, XrefRangeEnd = 151446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x00147C44 File Offset: 0x00145E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151447, RefRangeEnd = 151448, XrefRangeStart = 151447, XrefRangeEnd = 151447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00147C90 File Offset: 0x00145E90
		[CallerCount(0)]
		public unsafe static bool operator <=(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x00147CDC File Offset: 0x00145EDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 151448, RefRangeEnd = 151452, XrefRangeStart = 151448, XrefRangeEnd = 151448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x00147D28 File Offset: 0x00145F28
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 54644, RefRangeEnd = 54657, XrefRangeStart = 54644, XrefRangeEnd = 54657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x00147D74 File Offset: 0x00145F74
		[CallerCount(0)]
		public unsafe static bool operator !=(FullRank a, FullRank b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x00147DC0 File Offset: 0x00145FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151452, XrefRangeEnd = 151455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x00147E04 File Offset: 0x00146004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151455, XrefRangeEnd = 151459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x00147E34 File Offset: 0x00146034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151459, RefRangeEnd = 151461, XrefRangeStart = 151459, XrefRangeEnd = 151459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(FullRank other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullRank.NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x0001E50F File Offset: 0x0001C70F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FullRank>.NativeClassPtr, ref this));
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06003CC4 RID: 15556 RVA: 0x00147E74 File Offset: 0x00146074
		// (set) Token: 0x06003CC5 RID: 15557 RVA: 0x0001E521 File Offset: 0x0001C721
		public unsafe static int TIER_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FullRank.NativeFieldInfoPtr_TIER_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FullRank.NativeFieldInfoPtr_TIER_COUNT, (void*)(&value));
			}
		}

		// Token: 0x040028E9 RID: 10473
		private static readonly IntPtr NativeFieldInfoPtr_TIER_COUNT;

		// Token: 0x040028EA RID: 10474
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x040028EB RID: 10475
		private static readonly IntPtr NativeFieldInfoPtr_Tier;

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ERank_Int32_0;

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeMethodInfoPtr_NextRank_Public_FullRank_0;

		// Token: 0x040028EF RID: 10479
		private static readonly IntPtr NativeMethodInfoPtr_ToFloat_Public_Single_0;

		// Token: 0x040028F0 RID: 10480
		private static readonly IntPtr NativeMethodInfoPtr_GetRankIndex_Public_Int32_0;

		// Token: 0x040028F1 RID: 10481
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_FullRank_0;

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x040028F5 RID: 10485
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FullRank_FullRank_0;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Int32_FullRank_0;

		// Token: 0x040028FB RID: 10491
		[FieldOffset(0)]
		public ERank Rank;

		// Token: 0x040028FC RID: 10492
		[FieldOffset(4)]
		public int Tier;
	}
}

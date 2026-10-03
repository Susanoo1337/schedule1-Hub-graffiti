using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000086 RID: 134
	[StructLayout(2)]
	public struct Rect
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x0002C640 File Offset: 0x0002A840
		// Note: this type is marked as 'beforefieldinit'.
		static Rect()
		{
			Il2CppClassPointerStore<Rect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Rect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rect>.NativeClassPtr);
			Rect.NativeFieldInfoPtr_m_XMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_XMin");
			Rect.NativeFieldInfoPtr_m_YMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_YMin");
			Rect.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_Width");
			Rect.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_Height");
			Rect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664011);
			Rect.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664012);
			Rect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664013);
			Rect.NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664014);
			Rect.NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664015);
			Rect.NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664016);
			Rect.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664017);
			Rect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664018);
			Rect.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664019);
			Rect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664020);
			Rect.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664021);
			Rect.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664022);
			Rect.NativeMethodInfoPtr_get_center_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664023);
			Rect.NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664024);
			Rect.NativeMethodInfoPtr_get_min_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664025);
			Rect.NativeMethodInfoPtr_set_min_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664026);
			Rect.NativeMethodInfoPtr_get_max_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664027);
			Rect.NativeMethodInfoPtr_set_max_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664028);
			Rect.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664029);
			Rect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664030);
			Rect.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664031);
			Rect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664032);
			Rect.NativeMethodInfoPtr_get_size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664033);
			Rect.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664034);
			Rect.NativeMethodInfoPtr_get_xMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664035);
			Rect.NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664036);
			Rect.NativeMethodInfoPtr_get_yMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664037);
			Rect.NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664038);
			Rect.NativeMethodInfoPtr_get_xMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664039);
			Rect.NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664040);
			Rect.NativeMethodInfoPtr_get_yMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664041);
			Rect.NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664042);
			Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664043);
			Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664044);
			Rect.NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664045);
			Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664046);
			Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664047);
			Rect.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664048);
			Rect.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664049);
			Rect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664050);
			Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664051);
			Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664052);
			Rect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664053);
			Rect.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664054);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0002CA30 File Offset: 0x0002AC30
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 450606, RefRangeEnd = 450617, XrefRangeStart = 450606, XrefRangeEnd = 450617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect(float x, float y, float width, float height)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0002CA8C File Offset: 0x0002AC8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 841613, RefRangeEnd = 841614, XrefRangeStart = 841613, XrefRangeEnd = 841614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect(Vector2 position, Vector2 size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0002CACC File Offset: 0x0002ACCC
		[CallerCount(0)]
		public unsafe Rect(Rect source)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0002CB00 File Offset: 0x0002AD00
		public unsafe static Rect zero
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 1232935, RefRangeEnd = 1232971, XrefRangeStart = 1232935, XrefRangeEnd = 1232935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0002CB30 File Offset: 0x0002AD30
		[CallerCount(0)]
		public unsafe static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xmin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ymin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xmax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ymax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0002CB98 File Offset: 0x0002AD98
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 450606, RefRangeEnd = 450617, XrefRangeStart = 450606, XrefRangeEnd = 450617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(float x, float y, float width, float height)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0002CBF4 File Offset: 0x0002ADF4
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x0002CC24 File Offset: 0x0002AE24
		public unsafe float x
		{
			[CallerCount(87)]
			[CachedScanResults(RefRangeStart = 1226696, RefRangeEnd = 1226783, XrefRangeStart = 1226696, XrefRangeEnd = 1226783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_x_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(39)]
			[CachedScanResults(RefRangeStart = 42756, RefRangeEnd = 42795, XrefRangeStart = 42756, XrefRangeEnd = 42795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0002CC58 File Offset: 0x0002AE58
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x0002CC88 File Offset: 0x0002AE88
		public unsafe float y
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 1219142, RefRangeEnd = 1219216, XrefRangeStart = 1219142, XrefRangeEnd = 1219216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_y_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 42795, RefRangeEnd = 42811, XrefRangeStart = 42795, XrefRangeEnd = 42811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0002CCBC File Offset: 0x0002AEBC
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x0002CCEC File Offset: 0x0002AEEC
		public unsafe Vector2 position
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 389084, RefRangeEnd = 389119, XrefRangeStart = 389084, XrefRangeEnd = 389119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0002CD20 File Offset: 0x0002AF20
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x0002CD50 File Offset: 0x0002AF50
		public unsafe Vector2 center
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_center_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0002CD84 File Offset: 0x0002AF84
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x0002CDB4 File Offset: 0x0002AFB4
		public unsafe Vector2 min
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_min_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_min_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0002CDE8 File Offset: 0x0002AFE8
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x0002CE18 File Offset: 0x0002B018
		public unsafe Vector2 max
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_max_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_max_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0002CE4C File Offset: 0x0002B04C
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x0002CE7C File Offset: 0x0002B07C
		public unsafe float width
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 1226783, RefRangeEnd = 1226824, XrefRangeStart = 1226783, XrefRangeEnd = 1226824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_width_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 42811, RefRangeEnd = 42819, XrefRangeStart = 42811, XrefRangeEnd = 42819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0002CEB0 File Offset: 0x0002B0B0
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x0002CEE0 File Offset: 0x0002B0E0
		public unsafe float height
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 1222680, RefRangeEnd = 1222717, XrefRangeStart = 1222680, XrefRangeEnd = 1222717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_height_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0002CF14 File Offset: 0x0002B114
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x0002CF44 File Offset: 0x0002B144
		public unsafe Vector2 size
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 34123, RefRangeEnd = 34125, XrefRangeStart = 34123, XrefRangeEnd = 34125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_size_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 841614, RefRangeEnd = 841615, XrefRangeStart = 841614, XrefRangeEnd = 841615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0002CF78 File Offset: 0x0002B178
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x0002CFA8 File Offset: 0x0002B1A8
		public unsafe float xMin
		{
			[CallerCount(87)]
			[CachedScanResults(RefRangeStart = 1226696, RefRangeEnd = 1226783, XrefRangeStart = 1226696, XrefRangeEnd = 1226783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_xMin_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x0002CFDC File Offset: 0x0002B1DC
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x0002D00C File Offset: 0x0002B20C
		public unsafe float yMin
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 1219142, RefRangeEnd = 1219216, XrefRangeStart = 1219142, XrefRangeEnd = 1219216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_yMin_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0002D040 File Offset: 0x0002B240
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x0002D070 File Offset: 0x0002B270
		public unsafe float xMax
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_xMax_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0002D0A4 File Offset: 0x0002B2A4
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x0002D0D4 File Offset: 0x0002B2D4
		public unsafe float yMax
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_yMax_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0002D108 File Offset: 0x0002B308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232971, RefRangeEnd = 1232972, XrefRangeStart = 1232971, XrefRangeEnd = 1232971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0002D148 File Offset: 0x0002B348
		[CallerCount(0)]
		public unsafe bool Contains(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0002D188 File Offset: 0x0002B388
		[CallerCount(0)]
		public unsafe static Rect OrderMinMax(Rect rect)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
		[CallerCount(0)]
		public unsafe bool Overlaps(Rect other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0002D208 File Offset: 0x0002B408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1232975, RefRangeEnd = 1232977, XrefRangeStart = 1232972, XrefRangeEnd = 1232975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Overlaps(Rect other, bool allowInverse)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowInverse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0002D254 File Offset: 0x0002B454
		[CallerCount(0)]
		public unsafe static bool operator !=(Rect lhs, Rect rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0002D2A0 File Offset: 0x0002B4A0
		[CallerCount(0)]
		public unsafe static bool operator ==(Rect lhs, Rect rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0002D2EC File Offset: 0x0002B4EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1232981, RefRangeEnd = 1232983, XrefRangeStart = 1232977, XrefRangeEnd = 1232981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0002D31C File Offset: 0x0002B51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232983, XrefRangeEnd = 1232991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0002D360 File Offset: 0x0002B560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232991, XrefRangeEnd = 1232995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Rect other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0002D3A0 File Offset: 0x0002B5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232995, XrefRangeEnd = 1232996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0002D3CC File Offset: 0x0002B5CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1233021, RefRangeEnd = 1233024, XrefRangeStart = 1232996, XrefRangeEnd = 1233021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000050D3 File Offset: 0x000032D3
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Rect>.NativeClassPtr, ref this));
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0002D41C File Offset: 0x0002B61C
		public bool Contains(Vector3 point, bool allowInverse)
		{
			bool flag = !allowInverse;
			bool result;
			if (flag)
			{
				result = this.Contains(point);
			}
			else
			{
				bool flag2 = (this.width < 0f && point.x <= this.xMin && point.x > this.xMax) || (this.width >= 0f && point.x >= this.xMin && point.x < this.xMax);
				bool flag3 = (this.height < 0f && point.y <= this.yMin && point.y > this.yMax) || (this.height >= 0f && point.y >= this.yMin && point.y < this.yMax);
				result = (flag2 && flag3);
			}
			return result;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0002D4FC File Offset: 0x0002B6FC
		public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates)
		{
			return new Vector2(Mathf.Lerp(rectangle.x, rectangle.xMax, normalizedRectCoordinates.x), Mathf.Lerp(rectangle.y, rectangle.yMax, normalizedRectCoordinates.y));
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0002D548 File Offset: 0x0002B748
		public static Vector2 PointToNormalized(Rect rectangle, Vector2 point)
		{
			return new Vector2(Mathf.InverseLerp(rectangle.x, rectangle.xMax, point.x), Mathf.InverseLerp(rectangle.y, rectangle.yMax, point.y));
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0002D594 File Offset: 0x0002B794
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0002D5B0 File Offset: 0x0002B7B0
		public float left
		{
			get
			{
				return this.m_XMin;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0002D5C8 File Offset: 0x0002B7C8
		public float right
		{
			get
			{
				return this.m_XMin + this.m_Width;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
		public float top
		{
			get
			{
				return this.m_YMin;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0002D600 File Offset: 0x0002B800
		public float bottom
		{
			get
			{
				return this.m_YMin + this.m_Height;
			}
		}

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr_m_XMin;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_m_YMin;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Rect_0;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector2_0;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeMethodInfoPtr_get_min_Public_get_Vector2_0;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_set_min_Public_set_Void_Vector2_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_get_max_Public_get_Vector2_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_set_max_Public_set_Void_Vector2_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Single_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector2_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeMethodInfoPtr_get_xMin_Public_get_Single_0;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_get_yMin_Public_get_Single_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_get_xMax_Public_get_Single_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr_get_yMax_Public_get_Single_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040005BB RID: 1467
		[FieldOffset(0)]
		public float m_XMin;

		// Token: 0x040005BC RID: 1468
		[FieldOffset(4)]
		public float m_YMin;

		// Token: 0x040005BD RID: 1469
		[FieldOffset(8)]
		public float m_Width;

		// Token: 0x040005BE RID: 1470
		[FieldOffset(12)]
		public float m_Height;
	}
}

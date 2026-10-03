using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000087 RID: 135
	[StructLayout(2)]
	public struct RectInt
	{
		// Token: 0x060006E6 RID: 1766 RVA: 0x0002D620 File Offset: 0x0002B820
		// Note: this type is marked as 'beforefieldinit'.
		static RectInt()
		{
			Il2CppClassPointerStore<RectInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RectInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectInt>.NativeClassPtr);
			RectInt.NativeFieldInfoPtr_m_XMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_XMin");
			RectInt.NativeFieldInfoPtr_m_YMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_YMin");
			RectInt.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_Width");
			RectInt.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_Height");
			RectInt.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664055);
			RectInt.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664056);
			RectInt.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664057);
			RectInt.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664058);
			RectInt.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664059);
			RectInt.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664060);
			RectInt.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664061);
			RectInt.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664062);
			RectInt.NativeMethodInfoPtr_get_xMin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664063);
			RectInt.NativeMethodInfoPtr_get_yMin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664064);
			RectInt.NativeMethodInfoPtr_get_xMax_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664065);
			RectInt.NativeMethodInfoPtr_get_yMax_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664066);
			RectInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664067);
			RectInt.NativeMethodInfoPtr_Overlaps_Public_Boolean_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664068);
			RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664069);
			RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664070);
			RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664071);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0002D7F4 File Offset: 0x0002B9F4
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x0002D824 File Offset: 0x0002BA24
		public unsafe int x
		{
			[CallerCount(261)]
			[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 54922, RefRangeEnd = 54944, XrefRangeStart = 54922, XrefRangeEnd = 54944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0002D858 File Offset: 0x0002BA58
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x0002D888 File Offset: 0x0002BA88
		public unsafe int y
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1233024, RefRangeEnd = 1233045, XrefRangeStart = 1233024, XrefRangeEnd = 1233024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 54944, RefRangeEnd = 54959, XrefRangeStart = 54944, XrefRangeEnd = 54959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x0002D8BC File Offset: 0x0002BABC
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x0002D8EC File Offset: 0x0002BAEC
		public unsafe int width
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1222651, RefRangeEnd = 1222680, XrefRangeStart = 1222651, XrefRangeEnd = 1222680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29176, RefRangeEnd = 29187, XrefRangeStart = 29176, XrefRangeEnd = 29187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x0002D920 File Offset: 0x0002BB20
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x0002D950 File Offset: 0x0002BB50
		public unsafe int height
		{
			[CallerCount(93)]
			[CachedScanResults(RefRangeStart = 1225947, RefRangeEnd = 1226040, XrefRangeStart = 1225947, XrefRangeEnd = 1226040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 29190, RefRangeEnd = 29194, XrefRangeStart = 29190, XrefRangeEnd = 29194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x0002D984 File Offset: 0x0002BB84
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x0002DC28 File Offset: 0x0002BE28
		public unsafe int xMin
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233045, XrefRangeEnd = 1233049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_xMin_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				int xMax = this.xMax;
				this.m_XMin = value;
				this.m_Width = xMax - this.m_XMin;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0002D9B4 File Offset: 0x0002BBB4
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x0002DC54 File Offset: 0x0002BE54
		public unsafe int yMin
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233049, XrefRangeEnd = 1233053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_yMin_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				int yMax = this.yMax;
				this.m_YMin = value;
				this.m_Height = yMax - this.m_YMin;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0002D9E4 File Offset: 0x0002BBE4
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00005135 File Offset: 0x00003335
		public unsafe int xMax
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233053, XrefRangeEnd = 1233057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_xMax_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value - this.m_XMin;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0002DA14 File Offset: 0x0002BC14
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x00005146 File Offset: 0x00003346
		public unsafe int yMax
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233057, XrefRangeEnd = 1233061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_yMax_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Height = value - this.m_YMin;
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0002DA44 File Offset: 0x0002BC44
		[CallerCount(276)]
		[CachedScanResults(RefRangeStart = 667373, RefRangeEnd = 667649, XrefRangeStart = 667373, XrefRangeEnd = 667649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectInt(int xMin, int yMin, int width, int height)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xMin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0002DAA0 File Offset: 0x0002BCA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1233093, RefRangeEnd = 1233094, XrefRangeStart = 1233061, XrefRangeEnd = 1233093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Overlaps(RectInt other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_Overlaps_Public_Boolean_RectInt_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0002DAE0 File Offset: 0x0002BCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233094, XrefRangeEnd = 1233095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0002DB0C File Offset: 0x0002BD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1233095, XrefRangeEnd = 1233117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0002DB5C File Offset: 0x0002BD5C
		[CallerCount(0)]
		public unsafe bool Equals(RectInt other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000050E5 File Offset: 0x000032E5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectInt>.NativeClassPtr, ref this));
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x0002DB9C File Offset: 0x0002BD9C
		public Vector2 center
		{
			get
			{
				return new Vector2((float)this.x + (float)this.m_Width / 2f, (float)this.y + (float)this.m_Height / 2f);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x0002DBE0 File Offset: 0x0002BDE0
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x000050F7 File Offset: 0x000032F7
		public Vector2Int min
		{
			get
			{
				return new Vector2Int(this.xMin, this.yMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0002DC04 File Offset: 0x0002BE04
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x00005116 File Offset: 0x00003316
		public Vector2Int max
		{
			get
			{
				return new Vector2Int(this.xMax, this.yMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0002DC80 File Offset: 0x0002BE80
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x00005157 File Offset: 0x00003357
		public Vector2Int position
		{
			get
			{
				return new Vector2Int(this.m_XMin, this.m_YMin);
			}
			set
			{
				this.m_XMin = value.x;
				this.m_YMin = value.y;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0002DCA4 File Offset: 0x0002BEA4
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00005174 File Offset: 0x00003374
		public Vector2Int size
		{
			get
			{
				return new Vector2Int(this.m_Width, this.m_Height);
			}
			set
			{
				this.m_Width = value.x;
				this.m_Height = value.y;
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00005191 File Offset: 0x00003391
		public void SetMinMax(Vector2Int minPosition, Vector2Int maxPosition)
		{
			this.min = minPosition;
			this.max = maxPosition;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0002DCC8 File Offset: 0x0002BEC8
		public void ClampToBounds(RectInt bounds)
		{
			this.position = new Vector2Int(Math.Max(Math.Min(bounds.xMax, this.position.x), bounds.xMin), Math.Max(Math.Min(bounds.yMax, this.position.y), bounds.yMin));
			this.size = new Vector2Int(Math.Min(bounds.xMax - this.position.x, this.size.x), Math.Min(bounds.yMax - this.position.y, this.size.y));
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0002DD8C File Offset: 0x0002BF8C
		public bool Contains(Vector2Int position)
		{
			return position.x >= this.xMin && position.y >= this.yMin && position.x < this.xMax && position.y < this.yMax;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0002DDFC File Offset: 0x0002BFFC
		public RectInt.PositionEnumerator allPositionsWithin
		{
			get
			{
				return new RectInt.PositionEnumerator(this.min, this.max);
			}
		}

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr_m_XMin;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeFieldInfoPtr_m_YMin;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeMethodInfoPtr_get_xMin_Public_get_Int32_0;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeMethodInfoPtr_get_yMin_Public_get_Int32_0;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeMethodInfoPtr_get_xMax_Public_get_Int32_0;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeMethodInfoPtr_get_yMax_Public_get_Int32_0;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_RectInt_0;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0;

		// Token: 0x040005D4 RID: 1492
		[FieldOffset(0)]
		public int m_XMin;

		// Token: 0x040005D5 RID: 1493
		[FieldOffset(4)]
		public int m_YMin;

		// Token: 0x040005D6 RID: 1494
		[FieldOffset(8)]
		public int m_Width;

		// Token: 0x040005D7 RID: 1495
		[FieldOffset(12)]
		public int m_Height;

		// Token: 0x020004E3 RID: 1251
		public struct PositionEnumerator
		{
		}
	}
}

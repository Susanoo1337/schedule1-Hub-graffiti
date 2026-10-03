using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000081 RID: 129
	[StructLayout(2)]
	public struct BoundsInt
	{
		// Token: 0x06000649 RID: 1609 RVA: 0x0002AE88 File Offset: 0x00029088
		// Note: this type is marked as 'beforefieldinit'.
		static BoundsInt()
		{
			Il2CppClassPointerStore<BoundsInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BoundsInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr);
			BoundsInt.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, "m_Position");
			BoundsInt.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, "m_Size");
			BoundsInt.NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100663971);
			BoundsInt.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100663972);
			BoundsInt.NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100663973);
			BoundsInt.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100663974);
			BoundsInt.NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100663975);
			BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100663976);
			BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100663977);
			BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100663978);
			BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100663979);
			BoundsInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100663980);
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x0002AFA8 File Offset: 0x000291A8
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x0002AFD8 File Offset: 0x000291D8
		public unsafe Vector3Int position
		{
			[CallerCount(133)]
			[CachedScanResults(RefRangeStart = 1218506, RefRangeEnd = 1218639, XrefRangeStart = 1218506, XrefRangeEnd = 1218639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x0002B00C File Offset: 0x0002920C
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x0002B03C File Offset: 0x0002923C
		public unsafe Vector3Int size
		{
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 1232658, RefRangeEnd = 1232689, XrefRangeStart = 1232658, XrefRangeEnd = 1232689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0002B070 File Offset: 0x00029270
		[CallerCount(0)]
		public unsafe BoundsInt(Vector3Int position, Vector3Int size)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0002B0B0 File Offset: 0x000292B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232758, XrefRangeEnd = 1232759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0002B0DC File Offset: 0x000292DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232759, XrefRangeEnd = 1232781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0002B12C File Offset: 0x0002932C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232781, XrefRangeEnd = 1232784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0002B170 File Offset: 0x00029370
		[CallerCount(0)]
		public unsafe bool Equals(BoundsInt other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0002B1B0 File Offset: 0x000293B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232784, XrefRangeEnd = 1232786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00004EAB File Offset: 0x000030AB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, ref this));
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0002B1E0 File Offset: 0x000293E0
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00004EBD File Offset: 0x000030BD
		public int x
		{
			get
			{
				return this.m_Position.x;
			}
			set
			{
				this.m_Position.x = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0002B200 File Offset: 0x00029400
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x00004ECD File Offset: 0x000030CD
		public int y
		{
			get
			{
				return this.m_Position.y;
			}
			set
			{
				this.m_Position.y = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0002B220 File Offset: 0x00029420
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x00004EDD File Offset: 0x000030DD
		public int z
		{
			get
			{
				return this.m_Position.z;
			}
			set
			{
				this.m_Position.z = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0002B240 File Offset: 0x00029440
		public Vector3 center
		{
			get
			{
				return new Vector3((float)this.x + (float)this.m_Size.x / 2f, (float)this.y + (float)this.m_Size.y / 2f, (float)this.z + (float)this.m_Size.z / 2f);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0002B2A8 File Offset: 0x000294A8
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x00004EED File Offset: 0x000030ED
		public Vector3Int min
		{
			get
			{
				return new Vector3Int(this.xMin, this.yMin, this.zMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
				this.zMin = value.z;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x0002B2D4 File Offset: 0x000294D4
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00004F1A File Offset: 0x0000311A
		public Vector3Int max
		{
			get
			{
				return new Vector3Int(this.xMax, this.yMax, this.zMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
				this.zMax = value.z;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0002B300 File Offset: 0x00029500
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x0002B33C File Offset: 0x0002953C
		public int xMin
		{
			get
			{
				return Math.Min(this.m_Position.x, this.m_Position.x + this.m_Size.x);
			}
			set
			{
				int xMax = this.xMax;
				this.m_Position.x = value;
				this.m_Size.x = xMax - this.m_Position.x;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x0002B378 File Offset: 0x00029578
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x0002B3B4 File Offset: 0x000295B4
		public int yMin
		{
			get
			{
				return Math.Min(this.m_Position.y, this.m_Position.y + this.m_Size.y);
			}
			set
			{
				int yMax = this.yMax;
				this.m_Position.y = value;
				this.m_Size.y = yMax - this.m_Position.y;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x0002B3F0 File Offset: 0x000295F0
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x0002B42C File Offset: 0x0002962C
		public int zMin
		{
			get
			{
				return Math.Min(this.m_Position.z, this.m_Position.z + this.m_Size.z);
			}
			set
			{
				int zMax = this.zMax;
				this.m_Position.z = value;
				this.m_Size.z = zMax - this.m_Position.z;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x0002B468 File Offset: 0x00029668
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00004F47 File Offset: 0x00003147
		public int xMax
		{
			get
			{
				return Math.Max(this.m_Position.x, this.m_Position.x + this.m_Size.x);
			}
			set
			{
				this.m_Size.x = value - this.m_Position.x;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x0002B4A4 File Offset: 0x000296A4
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00004F63 File Offset: 0x00003163
		public int yMax
		{
			get
			{
				return Math.Max(this.m_Position.y, this.m_Position.y + this.m_Size.y);
			}
			set
			{
				this.m_Size.y = value - this.m_Position.y;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0002B4E0 File Offset: 0x000296E0
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00004F7F File Offset: 0x0000317F
		public int zMax
		{
			get
			{
				return Math.Max(this.m_Position.z, this.m_Position.z + this.m_Size.z);
			}
			set
			{
				this.m_Size.z = value - this.m_Position.z;
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00004F9B File Offset: 0x0000319B
		public void SetMinMax(Vector3Int minPosition, Vector3Int maxPosition)
		{
			this.min = minPosition;
			this.max = maxPosition;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0002B51C File Offset: 0x0002971C
		public void ClampToBounds(BoundsInt bounds)
		{
			this.position = new Vector3Int(Math.Max(Math.Min(bounds.xMax, this.position.x), bounds.xMin), Math.Max(Math.Min(bounds.yMax, this.position.y), bounds.yMin), Math.Max(Math.Min(bounds.zMax, this.position.z), bounds.zMin));
			this.size = new Vector3Int(Math.Min(bounds.xMax - this.position.x, this.size.x), Math.Min(bounds.yMax - this.position.y, this.size.y), Math.Min(bounds.zMax - this.position.z, this.size.z));
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0002B630 File Offset: 0x00029830
		public bool Contains(Vector3Int position)
		{
			return position.x >= this.xMin && position.y >= this.yMin && position.z >= this.zMin && position.x < this.xMax && position.y < this.yMax && position.z < this.zMax;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0002B6A0 File Offset: 0x000298A0
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0002B6BC File Offset: 0x000298BC
		public static bool operator ==(BoundsInt lhs, BoundsInt rhs)
		{
			return lhs.m_Position == rhs.m_Position && lhs.m_Size == rhs.m_Size;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0002B6F8 File Offset: 0x000298F8
		public static bool operator !=(BoundsInt lhs, BoundsInt rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0002B714 File Offset: 0x00029914
		public BoundsInt.PositionEnumerator allPositionsWithin
		{
			get
			{
				return new BoundsInt.PositionEnumerator(this.min, this.max);
			}
		}

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_m_Size;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400055D RID: 1373
		[FieldOffset(0)]
		public Vector3Int m_Position;

		// Token: 0x0400055E RID: 1374
		[FieldOffset(12)]
		public Vector3Int m_Size;

		// Token: 0x020004E1 RID: 1249
		public struct PositionEnumerator
		{
		}
	}
}

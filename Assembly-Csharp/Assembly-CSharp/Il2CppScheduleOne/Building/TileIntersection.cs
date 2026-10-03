using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000463 RID: 1123
	public class TileIntersection : Object
	{
		// Token: 0x06006562 RID: 25954 RVA: 0x001DABEC File Offset: 0x001D8DEC
		// Note: this type is marked as 'beforefieldinit'.
		static TileIntersection()
		{
			Il2CppClassPointerStore<TileIntersection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "TileIntersection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr);
			TileIntersection.NativeFieldInfoPtr_footprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, "footprint");
			TileIntersection.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, "tile");
			TileIntersection.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileIntersection_TileIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, 100676611);
			TileIntersection.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileIntersection_TileIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, 100676612);
			TileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr, 100676613);
		}

		// Token: 0x06006563 RID: 25955 RVA: 0x001DAC80 File Offset: 0x001D8E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212198, XrefRangeEnd = 212205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TileIntersection a, TileIntersection b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileIntersection.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileIntersection_TileIntersection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x001DACD4 File Offset: 0x001D8ED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212212, RefRangeEnd = 212214, XrefRangeStart = 212205, XrefRangeEnd = 212212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TileIntersection a, TileIntersection b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileIntersection.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileIntersection_TileIntersection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x001DAD28 File Offset: 0x001D8F28
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileIntersection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileIntersection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileIntersection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x0002FB86 File Offset: 0x0002DD86
		public TileIntersection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06006567 RID: 25959 RVA: 0x001DAD64 File Offset: 0x001D8F64
		// (set) Token: 0x06006568 RID: 25960 RVA: 0x0002FB8F File Offset: 0x0002DD8F
		public unsafe FootprintTile footprint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_footprint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_footprint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06006569 RID: 25961 RVA: 0x001DAD94 File Offset: 0x001D8F94
		// (set) Token: 0x0600656A RID: 25962 RVA: 0x0002FBAE File Offset: 0x0002DDAE
		public unsafe Tile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileIntersection.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045DD RID: 17885
		private static readonly IntPtr NativeFieldInfoPtr_footprint;

		// Token: 0x040045DE RID: 17886
		private static readonly IntPtr NativeFieldInfoPtr_tile;

		// Token: 0x040045DF RID: 17887
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TileIntersection_TileIntersection_0;

		// Token: 0x040045E0 RID: 17888
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TileIntersection_TileIntersection_0;

		// Token: 0x040045E1 RID: 17889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

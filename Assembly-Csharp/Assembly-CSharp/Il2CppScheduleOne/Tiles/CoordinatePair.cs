using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000114 RID: 276
	public class CoordinatePair : Object
	{
		// Token: 0x06001ACB RID: 6859 RVA: 0x000D3904 File Offset: 0x000D1B04
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinatePair()
		{
			Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinatePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr);
			CoordinatePair.NativeFieldInfoPtr_coord1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr, "coord1");
			CoordinatePair.NativeFieldInfoPtr_coord2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr, "coord2");
			CoordinatePair.NativeMethodInfoPtr__ctor_Public_Void_Coordinate_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr, 100666876);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x000D3970 File Offset: 0x000D1B70
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 100943, RefRangeEnd = 100996, XrefRangeStart = 100940, XrefRangeEnd = 100943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoordinatePair(Coordinate _c1, Coordinate _c2) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinatePair>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_c1);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_c2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoordinatePair.NativeMethodInfoPtr__ctor_Public_Void_Coordinate_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0000E91D File Offset: 0x0000CB1D
		public CoordinatePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x000D39D0 File Offset: 0x000D1BD0
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x0000E926 File Offset: 0x0000CB26
		public unsafe Coordinate coord1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x000D3A00 File Offset: 0x000D1C00
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x0000E945 File Offset: 0x0000CB45
		public unsafe Coordinate coord2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinatePair.NativeFieldInfoPtr_coord2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeFieldInfoPtr_coord1;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeFieldInfoPtr_coord2;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Coordinate_Coordinate_0;
	}
}

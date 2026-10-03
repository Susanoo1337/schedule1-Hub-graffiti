using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000D0 RID: 208
	[Serializable]
	public class ParkData : Object
	{
		// Token: 0x06001419 RID: 5145 RVA: 0x000BEFB8 File Offset: 0x000BD1B8
		// Note: this type is marked as 'beforefieldinit'.
		static ParkData()
		{
			Il2CppClassPointerStore<ParkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ParkData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkData>.NativeClassPtr);
			ParkData.NativeFieldInfoPtr_lotGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "lotGUID");
			ParkData.NativeFieldInfoPtr_spotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "spotIndex");
			ParkData.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkData>.NativeClassPtr, "alignment");
			ParkData.NativeMethodInfoPtr__ctor_Public_Void_Guid_Int32_EParkingAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkData>.NativeClassPtr, 100666205);
			ParkData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkData>.NativeClassPtr, 100666206);
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x000BF04C File Offset: 0x000BD24C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93713, RefRangeEnd = 93715, XrefRangeStart = 93712, XrefRangeEnd = 93713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkData(Guid lotGUID, int spotIndex, EParkingAlignment alignment) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lotGUID;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkData.NativeMethodInfoPtr__ctor_Public_Void_Guid_Int32_EParkingAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x000BF0B0 File Offset: 0x000BD2B0
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x0000B0ED File Offset: 0x000092ED
		public ParkData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x000BF0EC File Offset: 0x000BD2EC
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x0000B0F6 File Offset: 0x000092F6
		public unsafe Guid lotGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_lotGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_lotGUID)) = value;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x000BF114 File Offset: 0x000BD314
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x0000B111 File Offset: 0x00009311
		public unsafe int spotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_spotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_spotIndex)) = value;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x000BF13C File Offset: 0x000BD33C
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x0000B12C File Offset: 0x0000932C
		public unsafe EParkingAlignment alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkData.NativeFieldInfoPtr_alignment)) = value;
			}
		}

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeFieldInfoPtr_lotGUID;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeFieldInfoPtr_spotIndex;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_Int32_EParkingAlignment_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

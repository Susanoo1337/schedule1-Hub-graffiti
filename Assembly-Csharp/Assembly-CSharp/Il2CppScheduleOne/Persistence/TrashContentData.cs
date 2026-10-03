using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001B3 RID: 435
	[Serializable]
	public class TrashContentData : Object
	{
		// Token: 0x06002B60 RID: 11104 RVA: 0x0010AA24 File Offset: 0x00108C24
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContentData()
		{
			Il2CppClassPointerStore<TrashContentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "TrashContentData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr);
			TrashContentData.NativeFieldInfoPtr_TrashIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, "TrashIDs");
			TrashContentData.NativeFieldInfoPtr_TrashQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, "TrashQuantities");
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668911);
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668912);
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668913);
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x0010AAB8 File Offset: 0x00108CB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127292, RefRangeEnd = 127294, XrefRangeStart = 127283, XrefRangeEnd = 127292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x0010AAF4 File Offset: 0x00108CF4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 100943, RefRangeEnd = 100996, XrefRangeStart = 100943, XrefRangeEnd = 100996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData(Il2CppStringArray trashIDs, Il2CppStructArray<int> trashQuantities) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashIDs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trashQuantities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x0010AB54 File Offset: 0x00108D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127357, RefRangeEnd = 127358, XrefRangeStart = 127294, XrefRangeEnd = 127357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData(List<TrashItem> trashItems) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItems);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x00016815 File Offset: 0x00014A15
		public TrashContentData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x0010ABA0 File Offset: 0x00108DA0
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x0001681E File Offset: 0x00014A1E
		public unsafe Il2CppStringArray TrashIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x0010ABD0 File Offset: 0x00108DD0
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x0001683D File Offset: 0x00014A3D
		public unsafe Il2CppStructArray<int> TrashQuantities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashQuantities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeFieldInfoPtr_TrashIDs;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeFieldInfoPtr_TrashQuantities;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0;
	}
}

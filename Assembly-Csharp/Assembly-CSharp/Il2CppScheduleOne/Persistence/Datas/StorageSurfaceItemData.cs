using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000257 RID: 599
	public class StorageSurfaceItemData : SurfaceItemData
	{
		// Token: 0x0600304E RID: 12366 RVA: 0x0011B51C File Offset: 0x0011971C
		// Note: this type is marked as 'beforefieldinit'.
		static StorageSurfaceItemData()
		{
			Il2CppClassPointerStore<StorageSurfaceItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "StorageSurfaceItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageSurfaceItemData>.NativeClassPtr);
			StorageSurfaceItemData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageSurfaceItemData>.NativeClassPtr, "Contents");
			StorageSurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageSurfaceItemData>.NativeClassPtr, 100669438);
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x0011B574 File Offset: 0x00119774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135158, RefRangeEnd = 135160, XrefRangeStart = 135158, XrefRangeEnd = 135160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageSurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot, ItemSet contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageSurfaceItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageSurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x00018C53 File Offset: 0x00016E53
		public StorageSurfaceItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06003051 RID: 12369 RVA: 0x0011B620 File Offset: 0x00119820
		// (set) Token: 0x06003052 RID: 12370 RVA: 0x00018C5C File Offset: 0x00016E5C
		public unsafe ItemSet Contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageSurfaceItemData.NativeFieldInfoPtr_Contents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageSurfaceItemData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002079 RID: 8313
		private static readonly IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x0400207A RID: 8314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_ItemSet_0;
	}
}

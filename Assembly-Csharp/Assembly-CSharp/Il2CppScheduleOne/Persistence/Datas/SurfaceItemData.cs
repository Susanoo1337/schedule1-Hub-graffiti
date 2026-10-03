using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000258 RID: 600
	[Serializable]
	public class SurfaceItemData : BuildableItemData
	{
		// Token: 0x06003053 RID: 12371 RVA: 0x0011B650 File Offset: 0x00119850
		// Note: this type is marked as 'beforefieldinit'.
		static SurfaceItemData()
		{
			Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SurfaceItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr);
			SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "ParentSurfaceGUID");
			SurfaceItemData.NativeFieldInfoPtr_RelativePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "RelativePosition");
			SurfaceItemData.NativeFieldInfoPtr_RelativeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "RelativeRotation");
			SurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, 100669439);
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x0011B6D0 File Offset: 0x001198D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135197, RefRangeEnd = 135198, XrefRangeStart = 135192, XrefRangeEnd = 135197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x00018C7B File Offset: 0x00016E7B
		public SurfaceItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06003056 RID: 12374 RVA: 0x0011B768 File Offset: 0x00119968
		// (set) Token: 0x06003057 RID: 12375 RVA: 0x00018C84 File Offset: 0x00016E84
		public unsafe string ParentSurfaceGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x0011B790 File Offset: 0x00119990
		// (set) Token: 0x06003059 RID: 12377 RVA: 0x00018CA3 File Offset: 0x00016EA3
		public unsafe Vector3 RelativePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativePosition)) = value;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x0011B7B8 File Offset: 0x001199B8
		// (set) Token: 0x0600305B RID: 12379 RVA: 0x00018CBE File Offset: 0x00016EBE
		public unsafe Quaternion RelativeRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativeRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativeRotation)) = value;
			}
		}

		// Token: 0x0400207B RID: 8315
		private static readonly IntPtr NativeFieldInfoPtr_ParentSurfaceGUID;

		// Token: 0x0400207C RID: 8316
		private static readonly IntPtr NativeFieldInfoPtr_RelativePosition;

		// Token: 0x0400207D RID: 8317
		private static readonly IntPtr NativeFieldInfoPtr_RelativeRotation;

		// Token: 0x0400207E RID: 8318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0;
	}
}

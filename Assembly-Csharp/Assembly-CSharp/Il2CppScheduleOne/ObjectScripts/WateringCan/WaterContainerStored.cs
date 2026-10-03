using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x020005C8 RID: 1480
	public class WaterContainerStored : StoredItem
	{
		// Token: 0x06008F9A RID: 36762 RVA: 0x0026E218 File Offset: 0x0026C418
		// Note: this type is marked as 'beforefieldinit'.
		static WaterContainerStored()
		{
			Il2CppClassPointerStore<WaterContainerStored>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "WaterContainerStored");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaterContainerStored>.NativeClassPtr);
			WaterContainerStored.NativeFieldInfoPtr__visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaterContainerStored>.NativeClassPtr, "_visuals");
			WaterContainerStored.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerStored>.NativeClassPtr, 100681910);
			WaterContainerStored.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerStored>.NativeClassPtr, 100681911);
			WaterContainerStored.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaterContainerStored>.NativeClassPtr, 100681912);
		}

		// Token: 0x06008F9B RID: 36763 RVA: 0x0026E298 File Offset: 0x0026C498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263498, XrefRangeEnd = 263508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerStored.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F9C RID: 36764 RVA: 0x0026E314 File Offset: 0x0026C514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263508, XrefRangeEnd = 263515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaterContainerStored.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F9D RID: 36765 RVA: 0x0026E350 File Offset: 0x0026C550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaterContainerStored() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaterContainerStored>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaterContainerStored.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F9E RID: 36766 RVA: 0x00043DC0 File Offset: 0x00041FC0
		public WaterContainerStored(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x06008F9F RID: 36767 RVA: 0x0026E38C File Offset: 0x0026C58C
		// (set) Token: 0x06008FA0 RID: 36768 RVA: 0x00043DC9 File Offset: 0x00041FC9
		public unsafe WaterContainerVisualizer _visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerStored.NativeFieldInfoPtr__visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterContainerVisualizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaterContainerStored.NativeFieldInfoPtr__visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400628F RID: 25231
		private static readonly IntPtr NativeFieldInfoPtr__visuals;

		// Token: 0x04006290 RID: 25232
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x04006291 RID: 25233
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04006292 RID: 25234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

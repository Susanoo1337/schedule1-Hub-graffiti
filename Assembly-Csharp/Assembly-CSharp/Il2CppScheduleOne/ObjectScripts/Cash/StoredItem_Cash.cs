using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x020005C3 RID: 1475
	public class StoredItem_Cash : StoredItem
	{
		// Token: 0x06008F49 RID: 36681 RVA: 0x0026D0D4 File Offset: 0x0026B2D4
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem_Cash()
		{
			Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "StoredItem_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr);
			StoredItem_Cash.NativeFieldInfoPtr_cashInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr, "cashInstance");
			StoredItem_Cash.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr, "Visuals");
			StoredItem_Cash.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr, 100681869);
			StoredItem_Cash.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr, 100681870);
			StoredItem_Cash.NativeMethodInfoPtr_RefreshShownBills_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr, 100681871);
			StoredItem_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr, 100681872);
		}

		// Token: 0x06008F4A RID: 36682 RVA: 0x0026D17C File Offset: 0x0026B37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263165, XrefRangeEnd = 263181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem_Cash.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F4B RID: 36683 RVA: 0x0026D1F8 File Offset: 0x0026B3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263181, XrefRangeEnd = 263189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem_Cash.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F4C RID: 36684 RVA: 0x0026D234 File Offset: 0x0026B434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263189, XrefRangeEnd = 263190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShownBills()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_Cash.NativeMethodInfoPtr_RefreshShownBills_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F4D RID: 36685 RVA: 0x0026D268 File Offset: 0x0026B468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem_Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F4E RID: 36686 RVA: 0x00043B89 File Offset: 0x00041D89
		public StoredItem_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x06008F4F RID: 36687 RVA: 0x0026D2A4 File Offset: 0x0026B4A4
		// (set) Token: 0x06008F50 RID: 36688 RVA: 0x00043B92 File Offset: 0x00041D92
		public unsafe CashInstance cashInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Cash.NativeFieldInfoPtr_cashInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Cash.NativeFieldInfoPtr_cashInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x06008F51 RID: 36689 RVA: 0x0026D2D4 File Offset: 0x0026B4D4
		// (set) Token: 0x06008F52 RID: 36690 RVA: 0x00043BB1 File Offset: 0x00041DB1
		public unsafe CashStackVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Cash.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashStackVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Cash.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400625B RID: 25179
		private static readonly IntPtr NativeFieldInfoPtr_cashInstance;

		// Token: 0x0400625C RID: 25180
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x0400625D RID: 25181
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x0400625E RID: 25182
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x0400625F RID: 25183
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownBills_Private_Void_0;

		// Token: 0x04006260 RID: 25184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

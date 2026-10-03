using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000355 RID: 853
	public class ItemRemover : MonoBehaviour
	{
		// Token: 0x0600484E RID: 18510 RVA: 0x00170D40 File Offset: 0x0016EF40
		// Note: this type is marked as 'beforefieldinit'.
		static ItemRemover()
		{
			Il2CppClassPointerStore<ItemRemover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemRemover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr);
			ItemRemover.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, "Item");
			ItemRemover.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, "Quantity");
			ItemRemover.NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, 100672553);
			ItemRemover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr, 100672554);
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x00170DC0 File Offset: 0x0016EFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167671, XrefRangeEnd = 167677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemRemover.NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004850 RID: 18512 RVA: 0x00170DF4 File Offset: 0x0016EFF4
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemRemover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemRemover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemRemover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004851 RID: 18513 RVA: 0x0002334E File Offset: 0x0002154E
		public ItemRemover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06004852 RID: 18514 RVA: 0x00170E30 File Offset: 0x0016F030
		// (set) Token: 0x06004853 RID: 18515 RVA: 0x00023357 File Offset: 0x00021557
		public unsafe ItemDefinition Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06004854 RID: 18516 RVA: 0x00170E60 File Offset: 0x0016F060
		// (set) Token: 0x06004855 RID: 18517 RVA: 0x00023376 File Offset: 0x00021576
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemRemover.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x04003121 RID: 12577
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x04003122 RID: 12578
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04003123 RID: 12579
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

		// Token: 0x04003124 RID: 12580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

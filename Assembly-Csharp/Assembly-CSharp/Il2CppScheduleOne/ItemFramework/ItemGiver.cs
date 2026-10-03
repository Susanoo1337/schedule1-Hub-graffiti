using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000350 RID: 848
	public class ItemGiver : MonoBehaviour
	{
		// Token: 0x0600480B RID: 18443 RVA: 0x00170044 File Offset: 0x0016E244
		// Note: this type is marked as 'beforefieldinit'.
		static ItemGiver()
		{
			Il2CppClassPointerStore<ItemGiver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemGiver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr);
			ItemGiver.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, "Item");
			ItemGiver.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, "Quantity");
			ItemGiver.NativeMethodInfoPtr_Give_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, 100672518);
			ItemGiver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr, 100672519);
		}

		// Token: 0x0600480C RID: 18444 RVA: 0x001700C4 File Offset: 0x0016E2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167286, XrefRangeEnd = 167292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Give()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemGiver.NativeMethodInfoPtr_Give_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x001700F8 File Offset: 0x0016E2F8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemGiver() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemGiver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemGiver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x000231C0 File Offset: 0x000213C0
		public ItemGiver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x00170134 File Offset: 0x0016E334
		// (set) Token: 0x06004810 RID: 18448 RVA: 0x000231C9 File Offset: 0x000213C9
		public unsafe ItemDefinition Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x00170164 File Offset: 0x0016E364
		// (set) Token: 0x06004812 RID: 18450 RVA: 0x000231E8 File Offset: 0x000213E8
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemGiver.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x040030F1 RID: 12529
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x040030F2 RID: 12530
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x040030F3 RID: 12531
		private static readonly IntPtr NativeMethodInfoPtr_Give_Public_Void_0;

		// Token: 0x040030F4 RID: 12532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

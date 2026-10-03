using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Items.Framework;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.UI.Items;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200034F RID: 847
	[Serializable]
	public class ItemDefinition : BaseItemDefinition
	{
		// Token: 0x060047FD RID: 18429 RVA: 0x0016FE14 File Offset: 0x0016E014
		// Note: this type is marked as 'beforefieldinit'.
		static ItemDefinition()
		{
			Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr);
			ItemDefinition.NativeFieldInfoPtr_AvailableInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "AvailableInDemo");
			ItemDefinition.NativeFieldInfoPtr_EquipMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "EquipMode");
			ItemDefinition.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "Equippable");
			ItemDefinition.NativeFieldInfoPtr_CustomItemUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "CustomItemUI");
			ItemDefinition.NativeFieldInfoPtr_CustomInfoContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, "CustomInfoContent");
			ItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Abstract_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, 100672516);
			ItemDefinition.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr, 100672517);
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x0016FED0 File Offset: 0x0016E0D0
		[CallerCount(0)]
		public unsafe virtual ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Abstract_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x0016FF28 File Offset: 0x0016E128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167285, XrefRangeEnd = 167286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemDefinition.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x00023124 File Offset: 0x00021324
		public ItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06004801 RID: 18433 RVA: 0x0016FF64 File Offset: 0x0016E164
		// (set) Token: 0x06004802 RID: 18434 RVA: 0x0002312D File Offset: 0x0002132D
		public unsafe bool AvailableInDemo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_AvailableInDemo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_AvailableInDemo)) = value;
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x0016FF8C File Offset: 0x0016E18C
		// (set) Token: 0x06004804 RID: 18436 RVA: 0x00023148 File Offset: 0x00021348
		public unsafe ItemDefinition.EEquipMode EquipMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_EquipMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_EquipMode)) = value;
			}
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x0016FFB4 File Offset: 0x0016E1B4
		// (set) Token: 0x06004806 RID: 18438 RVA: 0x00023163 File Offset: 0x00021363
		public unsafe Equippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06004807 RID: 18439 RVA: 0x0016FFE4 File Offset: 0x0016E1E4
		// (set) Token: 0x06004808 RID: 18440 RVA: 0x00023182 File Offset: 0x00021382
		public unsafe ItemUI CustomItemUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomItemUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomItemUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06004809 RID: 18441 RVA: 0x00170014 File Offset: 0x0016E214
		// (set) Token: 0x0600480A RID: 18442 RVA: 0x000231A1 File Offset: 0x000213A1
		public unsafe ItemInfoContent CustomInfoContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomInfoContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemDefinition.NativeFieldInfoPtr_CustomInfoContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030EA RID: 12522
		private static readonly IntPtr NativeFieldInfoPtr_AvailableInDemo;

		// Token: 0x040030EB RID: 12523
		private static readonly IntPtr NativeFieldInfoPtr_EquipMode;

		// Token: 0x040030EC RID: 12524
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x040030ED RID: 12525
		private static readonly IntPtr NativeFieldInfoPtr_CustomItemUI;

		// Token: 0x040030EE RID: 12526
		private static readonly IntPtr NativeFieldInfoPtr_CustomInfoContent;

		// Token: 0x040030EF RID: 12527
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Abstract_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x040030F0 RID: 12528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000A6C RID: 2668
		[OriginalName("Assembly-CSharp.dll", "", "EEquipMode")]
		public enum EEquipMode
		{
			// Token: 0x04009918 RID: 39192
			Legacy,
			// Token: 0x04009919 RID: 39193
			New
		}
	}
}

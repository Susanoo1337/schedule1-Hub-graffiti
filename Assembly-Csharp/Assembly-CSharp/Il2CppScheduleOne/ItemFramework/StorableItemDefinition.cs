using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.StationFramework;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000360 RID: 864
	[Serializable]
	public class StorableItemDefinition : ItemDefinition
	{
		// Token: 0x0600491F RID: 18719 RVA: 0x00173E2C File Offset: 0x0017202C
		// Note: this type is marked as 'beforefieldinit'.
		static StorableItemDefinition()
		{
			Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "StorableItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr);
			StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "BasePurchasePrice");
			StorableItemDefinition.NativeFieldInfoPtr_ShopCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "ShopCategories");
			StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "RequiresLevelToPurchase");
			StorableItemDefinition.NativeFieldInfoPtr_RequiredRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "RequiredRank");
			StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "ResellMultiplier");
			StorableItemDefinition.NativeFieldInfoPtr_StoredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "StoredItem");
			StorableItemDefinition.NativeFieldInfoPtr_PickpocketDifficultyMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "PickpocketDifficultyMultiplier");
			StorableItemDefinition.NativeFieldInfoPtr_StationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "StationItem");
			StorableItemDefinition.NativeFieldInfoPtr_CombatUtility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, "CombatUtility");
			StorableItemDefinition.NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100672668);
			StorableItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100672669);
			StorableItemDefinition.NativeMethodInfoPtr_GetIsUnlocked_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100672670);
			StorableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr, 100672671);
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x00173F60 File Offset: 0x00172160
		public unsafe bool IsUnlocked
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 142897, RefRangeEnd = 142934, XrefRangeStart = 142897, XrefRangeEnd = 142934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemDefinition.NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00173F9C File Offset: 0x0017219C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168832, XrefRangeEnd = 168836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x00173FF4 File Offset: 0x001721F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168836, XrefRangeEnd = 168837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetIsUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemDefinition.NativeMethodInfoPtr_GetIsUnlocked_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x0017403C File Offset: 0x0017223C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 168845, RefRangeEnd = 168861, XrefRangeStart = 168837, XrefRangeEnd = 168845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorableItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x0002385A File Offset: 0x00021A5A
		public StorableItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06004925 RID: 18725 RVA: 0x00174078 File Offset: 0x00172278
		// (set) Token: 0x06004926 RID: 18726 RVA: 0x00023863 File Offset: 0x00021A63
		public unsafe float BasePurchasePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_BasePurchasePrice)) = value;
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06004927 RID: 18727 RVA: 0x001740A0 File Offset: 0x001722A0
		// (set) Token: 0x06004928 RID: 18728 RVA: 0x0002387E File Offset: 0x00021A7E
		public unsafe List<ShopListing.CategoryInstance> ShopCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ShopCategories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopListing.CategoryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ShopCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06004929 RID: 18729 RVA: 0x001740D0 File Offset: 0x001722D0
		// (set) Token: 0x0600492A RID: 18730 RVA: 0x0002389D File Offset: 0x00021A9D
		public unsafe bool RequiresLevelToPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiresLevelToPurchase)) = value;
			}
		}

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x0600492B RID: 18731 RVA: 0x001740F8 File Offset: 0x001722F8
		// (set) Token: 0x0600492C RID: 18732 RVA: 0x000238B8 File Offset: 0x00021AB8
		public unsafe FullRank RequiredRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiredRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_RequiredRank)) = value;
			}
		}

		// Token: 0x170016EA RID: 5866
		// (get) Token: 0x0600492D RID: 18733 RVA: 0x00174120 File Offset: 0x00172320
		// (set) Token: 0x0600492E RID: 18734 RVA: 0x000238D3 File Offset: 0x00021AD3
		public unsafe float ResellMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_ResellMultiplier)) = value;
			}
		}

		// Token: 0x170016EB RID: 5867
		// (get) Token: 0x0600492F RID: 18735 RVA: 0x00174148 File Offset: 0x00172348
		// (set) Token: 0x06004930 RID: 18736 RVA: 0x000238EE File Offset: 0x00021AEE
		public unsafe StoredItem StoredItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StoredItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StoredItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06004931 RID: 18737 RVA: 0x00174178 File Offset: 0x00172378
		// (set) Token: 0x06004932 RID: 18738 RVA: 0x0002390D File Offset: 0x00021B0D
		public unsafe float PickpocketDifficultyMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_PickpocketDifficultyMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_PickpocketDifficultyMultiplier)) = value;
			}
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x001741A0 File Offset: 0x001723A0
		// (set) Token: 0x06004934 RID: 18740 RVA: 0x00023928 File Offset: 0x00021B28
		public unsafe StationItem StationItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StationItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_StationItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016EE RID: 5870
		// (get) Token: 0x06004935 RID: 18741 RVA: 0x001741D0 File Offset: 0x001723D0
		// (set) Token: 0x06004936 RID: 18742 RVA: 0x00023947 File Offset: 0x00021B47
		public unsafe float CombatUtility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_CombatUtility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorableItemDefinition.NativeFieldInfoPtr_CombatUtility)) = value;
			}
		}

		// Token: 0x040031B3 RID: 12723
		private static readonly IntPtr NativeFieldInfoPtr_BasePurchasePrice;

		// Token: 0x040031B4 RID: 12724
		private static readonly IntPtr NativeFieldInfoPtr_ShopCategories;

		// Token: 0x040031B5 RID: 12725
		private static readonly IntPtr NativeFieldInfoPtr_RequiresLevelToPurchase;

		// Token: 0x040031B6 RID: 12726
		private static readonly IntPtr NativeFieldInfoPtr_RequiredRank;

		// Token: 0x040031B7 RID: 12727
		private static readonly IntPtr NativeFieldInfoPtr_ResellMultiplier;

		// Token: 0x040031B8 RID: 12728
		private static readonly IntPtr NativeFieldInfoPtr_StoredItem;

		// Token: 0x040031B9 RID: 12729
		private static readonly IntPtr NativeFieldInfoPtr_PickpocketDifficultyMultiplier;

		// Token: 0x040031BA RID: 12730
		private static readonly IntPtr NativeFieldInfoPtr_StationItem;

		// Token: 0x040031BB RID: 12731
		private static readonly IntPtr NativeFieldInfoPtr_CombatUtility;

		// Token: 0x040031BC RID: 12732
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnlocked_Public_get_Boolean_0;

		// Token: 0x040031BD RID: 12733
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040031BE RID: 12734
		private static readonly IntPtr NativeMethodInfoPtr_GetIsUnlocked_Protected_Virtual_New_Boolean_0;

		// Token: 0x040031BF RID: 12735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

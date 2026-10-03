using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200055C RID: 1372
	[Serializable]
	public class ProductItemInstance : QualityItemInstance
	{
		// Token: 0x06007CC1 RID: 31937 RVA: 0x00226360 File Offset: 0x00224560
		// Note: this type is marked as 'beforefieldinit'.
		static ProductItemInstance()
		{
			Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr);
			ProductItemInstance.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "PackagingID");
			ProductItemInstance.NativeFieldInfoPtr_packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "packaging");
			ProductItemInstance.NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679303);
			ProductItemInstance.NativeMethodInfoPtr_get_Amount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679304);
			ProductItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679305);
			ProductItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679306);
			ProductItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679307);
			ProductItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679308);
			ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679309);
			ProductItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679310);
			ProductItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679311);
			ProductItemInstance.NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679312);
			ProductItemInstance.NativeMethodInfoPtr_GetEquippable_Private_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679313);
			ProductItemInstance.NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679314);
			ProductItemInstance.NativeMethodInfoPtr_GetIcon_Private_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679315);
			ProductItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679316);
			ProductItemInstance.NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679317);
			ProductItemInstance.NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679318);
			ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679319);
			ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679320);
			ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679321);
			ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679322);
			ProductItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679323);
			ProductItemInstance.NativeMethodInfoPtr_GetTotalAmount_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679324);
			ProductItemInstance.NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679325);
			ProductItemInstance.NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, 100679326);
		}

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x06007CC2 RID: 31938 RVA: 0x00226598 File Offset: 0x00224798
		public unsafe PackagingDefinition AppliedPackaging
		{
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 236891, RefRangeEnd = 236944, XrefRangeStart = 236866, XrefRangeEnd = 236891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x170026A4 RID: 9892
		// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x002265D8 File Offset: 0x002247D8
		public unsafe int Amount
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 236950, RefRangeEnd = 236977, XrefRangeStart = 236944, XrefRangeEnd = 236950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_get_Amount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170026A5 RID: 9893
		// (get) Token: 0x06007CC4 RID: 31940 RVA: 0x00226614 File Offset: 0x00224814
		public unsafe override string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 236993, RefRangeEnd = 236994, XrefRangeStart = 236977, XrefRangeEnd = 236993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170026A6 RID: 9894
		// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x00226658 File Offset: 0x00224858
		public unsafe override Equippable Equippable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236994, XrefRangeEnd = 237001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
			}
		}

		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x06007CC6 RID: 31942 RVA: 0x002266A4 File Offset: 0x002248A4
		public unsafe override StoredItem StoredItem
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237001, XrefRangeEnd = 237008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr3) : null;
			}
		}

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x06007CC7 RID: 31943 RVA: 0x002266F0 File Offset: 0x002248F0
		public unsafe override Sprite Icon
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237008, XrefRangeEnd = 237021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x06007CC8 RID: 31944 RVA: 0x0022673C File Offset: 0x0022493C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 237034, RefRangeEnd = 237049, XrefRangeStart = 237021, XrefRangeEnd = 237034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemInstance(ItemDefinition definition, int quantity, EQuality quality, PackagingDefinition _packaging = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_packaging);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CC9 RID: 31945 RVA: 0x002267B8 File Offset: 0x002249B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237049, XrefRangeEnd = 237071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkQuantities;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007CCA RID: 31946 RVA: 0x00226820 File Offset: 0x00224A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237071, XrefRangeEnd = 237077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007CCB RID: 31947 RVA: 0x00226878 File Offset: 0x00224A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237077, XrefRangeEnd = 237088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPackaging(PackagingDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CCC RID: 31948 RVA: 0x002268C8 File Offset: 0x00224AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable GetEquippable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetEquippable_Private_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x00226908 File Offset: 0x00224B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem GetStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr3) : null;
		}

		// Token: 0x06007CCE RID: 31950 RVA: 0x00226948 File Offset: 0x00224B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237088, XrefRangeEnd = 237101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetIcon_Private_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06007CCF RID: 31951 RVA: 0x00226988 File Offset: 0x00224B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237101, XrefRangeEnd = 237109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06007CD0 RID: 31952 RVA: 0x002269D4 File Offset: 0x00224BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237109, XrefRangeEnd = 237117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetAddictiveness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007CD1 RID: 31953 RVA: 0x00226A1C File Offset: 0x00224C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237143, RefRangeEnd = 237144, XrefRangeStart = 237117, XrefRangeEnd = 237143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSimilarity(ProductDefinition other, EQuality otherQuality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref otherQuality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007CD2 RID: 31954 RVA: 0x00226A78 File Offset: 0x00224C78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237182, RefRangeEnd = 237186, XrefRangeStart = 237144, XrefRangeEnd = 237182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffectsToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x00226AC8 File Offset: 0x00224CC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237224, RefRangeEnd = 237228, XrefRangeStart = 237186, XrefRangeEnd = 237224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearEffectsFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD4 RID: 31956 RVA: 0x00226B18 File Offset: 0x00224D18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237266, RefRangeEnd = 237270, XrefRangeStart = 237228, XrefRangeEnd = 237266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffectsToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD5 RID: 31957 RVA: 0x00226B68 File Offset: 0x00224D68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237308, RefRangeEnd = 237312, XrefRangeStart = 237270, XrefRangeEnd = 237308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearEffectsFromPlayer(Player Player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(Player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x00226BB8 File Offset: 0x00224DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237312, XrefRangeEnd = 237323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007CD7 RID: 31959 RVA: 0x00226C00 File Offset: 0x00224E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237323, XrefRangeEnd = 237325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetTotalAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_GetTotalAmount_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007CD8 RID: 31960 RVA: 0x00226C48 File Offset: 0x00224E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237325, XrefRangeEnd = 237328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Writer writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD9 RID: 31961 RVA: 0x00226C98 File Offset: 0x00224E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237328, XrefRangeEnd = 237333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Read(Reader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInstance.NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CDA RID: 31962 RVA: 0x0003B6EB File Offset: 0x000398EB
		public ProductItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026A1 RID: 9889
		// (get) Token: 0x06007CDB RID: 31963 RVA: 0x00226CE8 File Offset: 0x00224EE8
		// (set) Token: 0x06007CDC RID: 31964 RVA: 0x0003B6F4 File Offset: 0x000398F4
		public unsafe string PackagingID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_PackagingID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170026A2 RID: 9890
		// (get) Token: 0x06007CDD RID: 31965 RVA: 0x00226D10 File Offset: 0x00224F10
		// (set) Token: 0x06007CDE RID: 31966 RVA: 0x0003B713 File Offset: 0x00039913
		public unsafe PackagingDefinition packaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_packaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInstance.NativeFieldInfoPtr_packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400550E RID: 21774
		private static readonly IntPtr NativeFieldInfoPtr_PackagingID;

		// Token: 0x0400550F RID: 21775
		private static readonly IntPtr NativeFieldInfoPtr_packaging;

		// Token: 0x04005510 RID: 21776
		private static readonly IntPtr NativeMethodInfoPtr_get_AppliedPackaging_Public_get_PackagingDefinition_0;

		// Token: 0x04005511 RID: 21777
		private static readonly IntPtr NativeMethodInfoPtr_get_Amount_Public_get_Int32_0;

		// Token: 0x04005512 RID: 21778
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04005513 RID: 21779
		private static readonly IntPtr NativeMethodInfoPtr_get_Equippable_Public_Virtual_get_Equippable_0;

		// Token: 0x04005514 RID: 21780
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredItem_Public_Virtual_get_StoredItem_0;

		// Token: 0x04005515 RID: 21781
		private static readonly IntPtr NativeMethodInfoPtr_get_Icon_Public_Virtual_get_Sprite_0;

		// Token: 0x04005516 RID: 21782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_PackagingDefinition_0;

		// Token: 0x04005517 RID: 21783
		private static readonly IntPtr NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0;

		// Token: 0x04005518 RID: 21784
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005519 RID: 21785
		private static readonly IntPtr NativeMethodInfoPtr_SetPackaging_Public_Virtual_New_Void_PackagingDefinition_0;

		// Token: 0x0400551A RID: 21786
		private static readonly IntPtr NativeMethodInfoPtr_GetEquippable_Private_Equippable_0;

		// Token: 0x0400551B RID: 21787
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredItem_Private_StoredItem_0;

		// Token: 0x0400551C RID: 21788
		private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Private_Sprite_0;

		// Token: 0x0400551D RID: 21789
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x0400551E RID: 21790
		private static readonly IntPtr NativeMethodInfoPtr_GetAddictiveness_Public_Virtual_New_Single_0;

		// Token: 0x0400551F RID: 21791
		private static readonly IntPtr NativeMethodInfoPtr_GetSimilarity_Public_Single_ProductDefinition_EQuality_0;

		// Token: 0x04005520 RID: 21792
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToNPC_Public_Virtual_New_Void_NPC_0;

		// Token: 0x04005521 RID: 21793
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromNPC_Public_Virtual_New_Void_NPC_0;

		// Token: 0x04005522 RID: 21794
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffectsToPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x04005523 RID: 21795
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffectsFromPlayer_Public_Virtual_New_Void_Player_0;

		// Token: 0x04005524 RID: 21796
		private static readonly IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0;

		// Token: 0x04005525 RID: 21797
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalAmount_Public_Virtual_Int32_0;

		// Token: 0x04005526 RID: 21798
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0;

		// Token: 0x04005527 RID: 21799
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0;

		// Token: 0x02000BCA RID: 3018
		[ObfuscatedName("ScheduleOne.Product.ProductItemInstance+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EB9C RID: 60316 RVA: 0x00392A78 File Offset: 0x00390C78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductItemInstance>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr);
				ProductItemInstance.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__24_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__25_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__26_0");
				ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, "<>9__27_0");
				ProductItemInstance.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679328);
				ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToNPC_b__24_0_Internal_Int32_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679329);
				ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromNPC_b__25_0_Internal_Int32_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679330);
				ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToPlayer_b__26_0_Internal_Int32_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679331);
				ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromPlayer_b__27_0_Internal_Int32_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr, 100679332);
			}

			// Token: 0x0600EB9D RID: 60317 RVA: 0x00392B6C File Offset: 0x00390D6C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInstance.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB9E RID: 60318 RVA: 0x00392BA8 File Offset: 0x00390DA8
			[CallerCount(0)]
			public unsafe int _ApplyEffectsToNPC_b__24_0(Effect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToNPC_b__24_0_Internal_Int32_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB9F RID: 60319 RVA: 0x00392BF8 File Offset: 0x00390DF8
			[CallerCount(0)]
			public unsafe int _ClearEffectsFromNPC_b__25_0(Effect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromNPC_b__25_0_Internal_Int32_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EBA0 RID: 60320 RVA: 0x00392C48 File Offset: 0x00390E48
			[CallerCount(0)]
			public unsafe int _ApplyEffectsToPlayer_b__26_0(Effect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ApplyEffectsToPlayer_b__26_0_Internal_Int32_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EBA1 RID: 60321 RVA: 0x00392C98 File Offset: 0x00390E98
			[CallerCount(0)]
			public unsafe int _ClearEffectsFromPlayer_b__27_0(Effect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInstance.__c.NativeMethodInfoPtr__ClearEffectsFromPlayer_b__27_0_Internal_Int32_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EBA2 RID: 60322 RVA: 0x0006F268 File Offset: 0x0006D468
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004776 RID: 18294
			// (get) Token: 0x0600EBA3 RID: 60323 RVA: 0x00392CE8 File Offset: 0x00390EE8
			// (set) Token: 0x0600EBA4 RID: 60324 RVA: 0x0006F271 File Offset: 0x0006D471
			public unsafe static ProductItemInstance.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004777 RID: 18295
			// (get) Token: 0x0600EBA5 RID: 60325 RVA: 0x00392D10 File Offset: 0x00390F10
			// (set) Token: 0x0600EBA6 RID: 60326 RVA: 0x0006F283 File Offset: 0x0006D483
			public unsafe static Func<Effect, int> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Effect, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004778 RID: 18296
			// (get) Token: 0x0600EBA7 RID: 60327 RVA: 0x00392D38 File Offset: 0x00390F38
			// (set) Token: 0x0600EBA8 RID: 60328 RVA: 0x0006F295 File Offset: 0x0006D495
			public unsafe static Func<Effect, int> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Effect, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004779 RID: 18297
			// (get) Token: 0x0600EBA9 RID: 60329 RVA: 0x00392D60 File Offset: 0x00390F60
			// (set) Token: 0x0600EBAA RID: 60330 RVA: 0x0006F2A7 File Offset: 0x0006D4A7
			public unsafe static Func<Effect, int> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Effect, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700477A RID: 18298
			// (get) Token: 0x0600EBAB RID: 60331 RVA: 0x00392D88 File Offset: 0x00390F88
			// (set) Token: 0x0600EBAC RID: 60332 RVA: 0x0006F2B9 File Offset: 0x0006D4B9
			public unsafe static Func<Effect, int> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Effect, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProductItemInstance.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009F9A RID: 40858
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009F9B RID: 40859
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04009F9C RID: 40860
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x04009F9D RID: 40861
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04009F9E RID: 40862
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04009F9F RID: 40863
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009FA0 RID: 40864
			private static readonly IntPtr NativeMethodInfoPtr__ApplyEffectsToNPC_b__24_0_Internal_Int32_Effect_0;

			// Token: 0x04009FA1 RID: 40865
			private static readonly IntPtr NativeMethodInfoPtr__ClearEffectsFromNPC_b__25_0_Internal_Int32_Effect_0;

			// Token: 0x04009FA2 RID: 40866
			private static readonly IntPtr NativeMethodInfoPtr__ApplyEffectsToPlayer_b__26_0_Internal_Int32_Effect_0;

			// Token: 0x04009FA3 RID: 40867
			private static readonly IntPtr NativeMethodInfoPtr__ClearEffectsFromPlayer_b__27_0_Internal_Int32_Effect_0;
		}
	}
}

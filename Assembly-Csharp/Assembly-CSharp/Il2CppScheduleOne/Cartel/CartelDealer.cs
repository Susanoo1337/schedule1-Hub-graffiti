using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Product.Packaging;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x0200044A RID: 1098
	public class CartelDealer : Dealer
	{
		// Token: 0x0600634A RID: 25418 RVA: 0x001D34EC File Offset: 0x001D16EC
		// Note: this type is marked as 'beforefieldinit'.
		static CartelDealer()
		{
			Il2CppClassPointerStore<CartelDealer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelDealer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr);
			CartelDealer.NativeFieldInfoPtr_DEALER_DEFEATED_INFLUENCE_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "DEALER_DEFEATED_INFLUENCE_CHANGE");
			CartelDealer.NativeFieldInfoPtr_PRODUCT_COUNT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "PRODUCT_COUNT_MIN");
			CartelDealer.NativeFieldInfoPtr_PRODUCT_COUNT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "PRODUCT_COUNT_MAX");
			CartelDealer.NativeFieldInfoPtr_PRODUCT_QUANTITY_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "PRODUCT_QUANTITY_MIN");
			CartelDealer.NativeFieldInfoPtr_PRODUCT_QUANTITY_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "PRODUCT_QUANTITY_MAX");
			CartelDealer.NativeFieldInfoPtr__IsAcceptingDeals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "<IsAcceptingDeals>k__BackingField");
			CartelDealer.NativeFieldInfoPtr_RandomProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "RandomProducts");
			CartelDealer.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "ProductQuality");
			CartelDealer.NativeFieldInfoPtr_DefaultPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "DefaultPackaging");
			CartelDealer.NativeFieldInfoPtr_appearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "appearance");
			CartelDealer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Cartel.CartelDealerAssembly-CSharp.dll_Excuted");
			CartelDealer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Cartel.CartelDealerAssembly-CSharp.dll_Excuted");
			CartelDealer.NativeMethodInfoPtr_get_IsAcceptingDeals_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676346);
			CartelDealer.NativeMethodInfoPtr_set_IsAcceptingDeals_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676347);
			CartelDealer.NativeMethodInfoPtr_get_GoonPool_Private_get_GoonPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676348);
			CartelDealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676349);
			CartelDealer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676350);
			CartelDealer.NativeMethodInfoPtr_RandomizeInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676351);
			CartelDealer.NativeMethodInfoPtr_RandomizeAppearance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676352);
			CartelDealer.NativeMethodInfoPtr_ConfigureGoonSettings_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676353);
			CartelDealer.NativeMethodInfoPtr_SetIsAcceptingDeals_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676354);
			CartelDealer.NativeMethodInfoPtr_CanCurrentlyAcceptDeal_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676355);
			CartelDealer.NativeMethodInfoPtr_DiedOrKnockedOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676356);
			CartelDealer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676357);
			CartelDealer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676358);
			CartelDealer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676359);
			CartelDealer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676360);
			CartelDealer.NativeMethodInfoPtr_RpcWriter___Observers_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676361);
			CartelDealer.NativeMethodInfoPtr_RpcLogic___ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676362);
			CartelDealer.NativeMethodInfoPtr_RpcReader___Observers_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676363);
			CartelDealer.NativeMethodInfoPtr_RpcWriter___Target_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676364);
			CartelDealer.NativeMethodInfoPtr_RpcReader___Target_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676365);
			CartelDealer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr, 100676366);
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x0600634B RID: 25419 RVA: 0x001D37B0 File Offset: 0x001D19B0
		// (set) Token: 0x0600634C RID: 25420 RVA: 0x001D37EC File Offset: 0x001D19EC
		public unsafe bool IsAcceptingDeals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_get_IsAcceptingDeals_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_set_IsAcceptingDeals_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x0600634D RID: 25421 RVA: 0x001D382C File Offset: 0x001D1A2C
		public unsafe GoonPool GoonPool
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 209269, RefRangeEnd = 209277, XrefRangeStart = 209265, XrefRangeEnd = 209269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_get_GoonPool_Private_get_GoonPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoonPool>(intPtr3) : null;
			}
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x001D386C File Offset: 0x001D1A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209277, XrefRangeEnd = 209286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelDealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x001D38A8 File Offset: 0x001D1AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209286, XrefRangeEnd = 209289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelDealer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x001D38F8 File Offset: 0x001D1AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209289, XrefRangeEnd = 209298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_RandomizeInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x001D392C File Offset: 0x001D1B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209298, XrefRangeEnd = 209304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_RandomizeAppearance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006352 RID: 25426 RVA: 0x001D3960 File Offset: 0x001D1B60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209345, RefRangeEnd = 209348, XrefRangeStart = 209304, XrefRangeEnd = 209345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureGoonSettings(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_ConfigureGoonSettings_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x001D39C4 File Offset: 0x001D1BC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209372, RefRangeEnd = 209374, XrefRangeStart = 209348, XrefRangeEnd = 209372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsAcceptingDeals(bool accepting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref accepting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_SetIsAcceptingDeals_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006354 RID: 25428 RVA: 0x001D3A04 File Offset: 0x001D1C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209375, RefRangeEnd = 209376, XrefRangeStart = 209374, XrefRangeEnd = 209375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCurrentlyAcceptDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_CanCurrentlyAcceptDeal_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006355 RID: 25429 RVA: 0x001D3A40 File Offset: 0x001D1C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209376, XrefRangeEnd = 209384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DiedOrKnockedOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_DiedOrKnockedOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006356 RID: 25430 RVA: 0x001D3A74 File Offset: 0x001D1C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209384, XrefRangeEnd = 209388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelDealer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelDealer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006357 RID: 25431 RVA: 0x001D3AB0 File Offset: 0x001D1CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209388, XrefRangeEnd = 209402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelDealer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006358 RID: 25432 RVA: 0x001D3AEC File Offset: 0x001D1CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209402, XrefRangeEnd = 209403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelDealer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006359 RID: 25433 RVA: 0x001D3B28 File Offset: 0x001D1D28
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelDealer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600635A RID: 25434 RVA: 0x001D3B64 File Offset: 0x001D1D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209403, XrefRangeEnd = 209414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_RpcWriter___Observers_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600635B RID: 25435 RVA: 0x001D3BC8 File Offset: 0x001D1DC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209428, RefRangeEnd = 209431, XrefRangeStart = 209414, XrefRangeEnd = 209428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_RpcLogic___ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600635C RID: 25436 RVA: 0x001D3C2C File Offset: 0x001D1E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209431, XrefRangeEnd = 209436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_RpcReader___Observers_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600635D RID: 25437 RVA: 0x001D3C7C File Offset: 0x001D1E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209436, XrefRangeEnd = 209447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_RpcWriter___Target_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600635E RID: 25438 RVA: 0x001D3CE0 File Offset: 0x001D1EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209447, XrefRangeEnd = 209452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealer.NativeMethodInfoPtr_RpcReader___Target_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600635F RID: 25439 RVA: 0x001D3D30 File Offset: 0x001D1F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209452, XrefRangeEnd = 209453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelDealer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006360 RID: 25440 RVA: 0x0002ED57 File Offset: 0x0002CF57
		public CartelDealer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x06006361 RID: 25441 RVA: 0x001D3D6C File Offset: 0x001D1F6C
		// (set) Token: 0x06006362 RID: 25442 RVA: 0x0002ED60 File Offset: 0x0002CF60
		public unsafe static float DEALER_DEFEATED_INFLUENCE_CHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CartelDealer.NativeFieldInfoPtr_DEALER_DEFEATED_INFLUENCE_CHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelDealer.NativeFieldInfoPtr_DEALER_DEFEATED_INFLUENCE_CHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x06006363 RID: 25443 RVA: 0x001D3D88 File Offset: 0x001D1F88
		// (set) Token: 0x06006364 RID: 25444 RVA: 0x0002ED6E File Offset: 0x0002CF6E
		public unsafe static int PRODUCT_COUNT_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelDealer.NativeFieldInfoPtr_PRODUCT_COUNT_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelDealer.NativeFieldInfoPtr_PRODUCT_COUNT_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x06006365 RID: 25445 RVA: 0x001D3DA4 File Offset: 0x001D1FA4
		// (set) Token: 0x06006366 RID: 25446 RVA: 0x0002ED7C File Offset: 0x0002CF7C
		public unsafe static int PRODUCT_COUNT_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelDealer.NativeFieldInfoPtr_PRODUCT_COUNT_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelDealer.NativeFieldInfoPtr_PRODUCT_COUNT_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x06006367 RID: 25447 RVA: 0x001D3DC0 File Offset: 0x001D1FC0
		// (set) Token: 0x06006368 RID: 25448 RVA: 0x0002ED8A File Offset: 0x0002CF8A
		public unsafe static int PRODUCT_QUANTITY_MIN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelDealer.NativeFieldInfoPtr_PRODUCT_QUANTITY_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelDealer.NativeFieldInfoPtr_PRODUCT_QUANTITY_MIN, (void*)(&value));
			}
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x06006369 RID: 25449 RVA: 0x001D3DDC File Offset: 0x001D1FDC
		// (set) Token: 0x0600636A RID: 25450 RVA: 0x0002ED98 File Offset: 0x0002CF98
		public unsafe static int PRODUCT_QUANTITY_MAX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelDealer.NativeFieldInfoPtr_PRODUCT_QUANTITY_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelDealer.NativeFieldInfoPtr_PRODUCT_QUANTITY_MAX, (void*)(&value));
			}
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x0600636B RID: 25451 RVA: 0x001D3DF8 File Offset: 0x001D1FF8
		// (set) Token: 0x0600636C RID: 25452 RVA: 0x0002EDA6 File Offset: 0x0002CFA6
		public unsafe bool _IsAcceptingDeals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr__IsAcceptingDeals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr__IsAcceptingDeals_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x0600636D RID: 25453 RVA: 0x001D3E20 File Offset: 0x001D2020
		// (set) Token: 0x0600636E RID: 25454 RVA: 0x0002EDC1 File Offset: 0x0002CFC1
		public unsafe Il2CppReferenceArray<ProductDefinition> RandomProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_RandomProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_RandomProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x0600636F RID: 25455 RVA: 0x001D3E50 File Offset: 0x001D2050
		// (set) Token: 0x06006370 RID: 25456 RVA: 0x0002EDE0 File Offset: 0x0002CFE0
		public unsafe EQuality ProductQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x06006371 RID: 25457 RVA: 0x001D3E78 File Offset: 0x001D2078
		// (set) Token: 0x06006372 RID: 25458 RVA: 0x0002EDFB File Offset: 0x0002CFFB
		public unsafe PackagingDefinition DefaultPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_DefaultPackaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_DefaultPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x06006373 RID: 25459 RVA: 0x001D3EA8 File Offset: 0x001D20A8
		// (set) Token: 0x06006374 RID: 25460 RVA: 0x0002EE1A File Offset: 0x0002D01A
		public unsafe CartelGoonAppearance appearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_appearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelGoonAppearance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_appearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x06006375 RID: 25461 RVA: 0x001D3ED8 File Offset: 0x001D20D8
		// (set) Token: 0x06006376 RID: 25462 RVA: 0x0002EE39 File Offset: 0x0002D039
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x06006377 RID: 25463 RVA: 0x001D3F00 File Offset: 0x001D2100
		// (set) Token: 0x06006378 RID: 25464 RVA: 0x0002EE54 File Offset: 0x0002D054
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004471 RID: 17521
		private static readonly IntPtr NativeFieldInfoPtr_DEALER_DEFEATED_INFLUENCE_CHANGE;

		// Token: 0x04004472 RID: 17522
		private static readonly IntPtr NativeFieldInfoPtr_PRODUCT_COUNT_MIN;

		// Token: 0x04004473 RID: 17523
		private static readonly IntPtr NativeFieldInfoPtr_PRODUCT_COUNT_MAX;

		// Token: 0x04004474 RID: 17524
		private static readonly IntPtr NativeFieldInfoPtr_PRODUCT_QUANTITY_MIN;

		// Token: 0x04004475 RID: 17525
		private static readonly IntPtr NativeFieldInfoPtr_PRODUCT_QUANTITY_MAX;

		// Token: 0x04004476 RID: 17526
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingDeals_k__BackingField;

		// Token: 0x04004477 RID: 17527
		private static readonly IntPtr NativeFieldInfoPtr_RandomProducts;

		// Token: 0x04004478 RID: 17528
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x04004479 RID: 17529
		private static readonly IntPtr NativeFieldInfoPtr_DefaultPackaging;

		// Token: 0x0400447A RID: 17530
		private static readonly IntPtr NativeFieldInfoPtr_appearance;

		// Token: 0x0400447B RID: 17531
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400447C RID: 17532
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400447D RID: 17533
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingDeals_Public_get_Boolean_0;

		// Token: 0x0400447E RID: 17534
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingDeals_Private_set_Void_Boolean_0;

		// Token: 0x0400447F RID: 17535
		private static readonly IntPtr NativeMethodInfoPtr_get_GoonPool_Private_get_GoonPool_0;

		// Token: 0x04004480 RID: 17536
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004481 RID: 17537
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004482 RID: 17538
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeInventory_Public_Void_0;

		// Token: 0x04004483 RID: 17539
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeAppearance_Public_Void_0;

		// Token: 0x04004484 RID: 17540
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureGoonSettings_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0;

		// Token: 0x04004485 RID: 17541
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAcceptingDeals_Public_Void_Boolean_0;

		// Token: 0x04004486 RID: 17542
		private static readonly IntPtr NativeMethodInfoPtr_CanCurrentlyAcceptDeal_Public_Boolean_0;

		// Token: 0x04004487 RID: 17543
		private static readonly IntPtr NativeMethodInfoPtr_DiedOrKnockedOut_Private_Void_0;

		// Token: 0x04004488 RID: 17544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004489 RID: 17545
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400448A RID: 17546
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400448B RID: 17547
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400448C RID: 17548
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0;

		// Token: 0x0400448D RID: 17549
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0;

		// Token: 0x0400448E RID: 17550
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400448F RID: 17551
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0;

		// Token: 0x04004490 RID: 17552
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004491 RID: 17553
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}

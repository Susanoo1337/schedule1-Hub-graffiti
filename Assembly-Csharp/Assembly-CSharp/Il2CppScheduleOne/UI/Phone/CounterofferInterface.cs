using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GamepadInput;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020007A5 RID: 1957
	public class CounterofferInterface : MonoBehaviour
	{
		// Token: 0x0600BD52 RID: 48466 RVA: 0x00308C60 File Offset: 0x00306E60
		// Note: this type is marked as 'beforefieldinit'.
		static CounterofferInterface()
		{
			Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CounterofferInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr);
			CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "COUNTEROFFER_SUCCESS_XP");
			CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CounterofferInterface.NativeFieldInfoPtr_MinQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MinQuantity");
			CounterofferInterface.NativeFieldInfoPtr_MaxQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MaxQuantity");
			CounterofferInterface.NativeFieldInfoPtr_MinPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MinPrice");
			CounterofferInterface.NativeFieldInfoPtr_MaxPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "MaxPrice");
			CounterofferInterface.NativeFieldInfoPtr_IconAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "IconAlignment");
			CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductEntryPrefab");
			CounterofferInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "Container");
			CounterofferInterface.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "TitleLabel");
			CounterofferInterface.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ConfirmButton");
			CounterofferInterface.NativeFieldInfoPtr_ProductIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductIcon");
			CounterofferInterface.NativeFieldInfoPtr_ProductLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductLabel");
			CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "FairPriceLabel");
			CounterofferInterface.NativeFieldInfoPtr_ProductSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductSelector");
			CounterofferInterface.NativeFieldInfoPtr_ProductAmountInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "ProductAmountInput");
			CounterofferInterface.NativeFieldInfoPtr_PriceSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "PriceSelector");
			CounterofferInterface.NativeFieldInfoPtr__productAmountInputRamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "_productAmountInputRamp");
			CounterofferInterface.NativeFieldInfoPtr_uiScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "uiScreen");
			CounterofferInterface.NativeFieldInfoPtr_uiPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "uiPanel");
			CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "orderConfirmedCallback");
			CounterofferInterface.NativeFieldInfoPtr_selectedProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "selectedProduct");
			CounterofferInterface.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "quantity");
			CounterofferInterface.NativeFieldInfoPtr_productEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "productEntries");
			CounterofferInterface.NativeFieldInfoPtr_mouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "mouseUp");
			CounterofferInterface.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "conversation");
			CounterofferInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100687992);
			CounterofferInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100687993);
			CounterofferInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100687994);
			CounterofferInterface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100687995);
			CounterofferInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100687996);
			CounterofferInterface.NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100687997);
			CounterofferInterface.NativeMethodInfoPtr_DelaySelectPanel_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100687998);
			CounterofferInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100687999);
			CounterofferInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100688000);
			CounterofferInterface.NativeMethodInfoPtr_Send_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100688001);
			CounterofferInterface.NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100688002);
			CounterofferInterface.NativeMethodInfoPtr_ApplyFairPrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100688003);
			CounterofferInterface.NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100688004);
			CounterofferInterface.NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100688005);
			CounterofferInterface.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100688006);
			CounterofferInterface.NativeMethodInfoPtr_ChangeQuantity_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100688007);
			CounterofferInterface.NativeMethodInfoPtr_UpdateQuantityLabel_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100688008);
			CounterofferInterface.NativeMethodInfoPtr_OpenProductSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100688009);
			CounterofferInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, 100688010);
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x0600BD53 RID: 48467 RVA: 0x00309014 File Offset: 0x00307214
		// (set) Token: 0x0600BD54 RID: 48468 RVA: 0x00309050 File Offset: 0x00307250
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BD55 RID: 48469 RVA: 0x00309090 File Offset: 0x00307290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315470, XrefRangeEnd = 315500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD56 RID: 48470 RVA: 0x003090C4 File Offset: 0x003072C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315500, XrefRangeEnd = 315528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD57 RID: 48471 RVA: 0x003090F8 File Offset: 0x003072F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315528, XrefRangeEnd = 315558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD58 RID: 48472 RVA: 0x0030912C File Offset: 0x0030732C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315595, RefRangeEnd = 315596, XrefRangeStart = 315558, XrefRangeEnd = 315595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ProductDefinition product, int quantity, float price, MSGConversation _conversation, Action<ProductDefinition, int, float> _orderConfirmedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_conversation);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_orderConfirmedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD59 RID: 48473 RVA: 0x003091B0 File Offset: 0x003073B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315596, XrefRangeEnd = 315601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelaySelectPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_DelaySelectPanel_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600BD5A RID: 48474 RVA: 0x003091F0 File Offset: 0x003073F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 315623, RefRangeEnd = 315626, XrefRangeStart = 315601, XrefRangeEnd = 315623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD5B RID: 48475 RVA: 0x00309224 File Offset: 0x00307424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315626, XrefRangeEnd = 315631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD5C RID: 48476 RVA: 0x00309268 File Offset: 0x00307468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315631, XrefRangeEnd = 315634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Send()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_Send_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD5D RID: 48477 RVA: 0x0030929C File Offset: 0x0030749C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 315642, RefRangeEnd = 315646, XrefRangeStart = 315634, XrefRangeEnd = 315642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFairPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD5E RID: 48478 RVA: 0x003092D0 File Offset: 0x003074D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315646, XrefRangeEnd = 315648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFairPrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_ApplyFairPrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD5F RID: 48479 RVA: 0x00309304 File Offset: 0x00307504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315648, XrefRangeEnd = 315655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProduct(ProductDefinition newProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newProduct);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD60 RID: 48480 RVA: 0x00309348 File Offset: 0x00307548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315655, XrefRangeEnd = 315658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayProduct(ProductDefinition tempProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tempProduct);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD61 RID: 48481 RVA: 0x0030938C File Offset: 0x0030758C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315658, XrefRangeEnd = 315664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD62 RID: 48482 RVA: 0x003093CC File Offset: 0x003075CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315664, XrefRangeEnd = 315668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_ChangeQuantity_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD63 RID: 48483 RVA: 0x00309410 File Offset: 0x00307610
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 315673, RefRangeEnd = 315678, XrefRangeStart = 315668, XrefRangeEnd = 315673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateQuantityLabel(string productName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_UpdateQuantityLabel_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD64 RID: 48484 RVA: 0x00309454 File Offset: 0x00307654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315678, XrefRangeEnd = 315683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenProductSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr_OpenProductSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD65 RID: 48485 RVA: 0x00309488 File Offset: 0x00307688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315683, XrefRangeEnd = 315691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CounterofferInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD66 RID: 48486 RVA: 0x00058458 File Offset: 0x00056658
		public CounterofferInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x0600BD67 RID: 48487 RVA: 0x003094C4 File Offset: 0x003076C4
		// (set) Token: 0x0600BD68 RID: 48488 RVA: 0x00058461 File Offset: 0x00056661
		public unsafe static int COUNTEROFFER_SUCCESS_XP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP, (void*)(&value));
			}
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x0600BD69 RID: 48489 RVA: 0x003094E0 File Offset: 0x003076E0
		// (set) Token: 0x0600BD6A RID: 48490 RVA: 0x0005846F File Offset: 0x0005666F
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x0600BD6B RID: 48491 RVA: 0x00309508 File Offset: 0x00307708
		// (set) Token: 0x0600BD6C RID: 48492 RVA: 0x0005848A File Offset: 0x0005668A
		public unsafe static int MinQuantity
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MinQuantity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MinQuantity, (void*)(&value));
			}
		}

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x0600BD6D RID: 48493 RVA: 0x00309524 File Offset: 0x00307724
		// (set) Token: 0x0600BD6E RID: 48494 RVA: 0x00058498 File Offset: 0x00056698
		public unsafe int MaxQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_MaxQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_MaxQuantity)) = value;
			}
		}

		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x0600BD6F RID: 48495 RVA: 0x0030954C File Offset: 0x0030774C
		// (set) Token: 0x0600BD70 RID: 48496 RVA: 0x000584B3 File Offset: 0x000566B3
		public unsafe static float MinPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MinPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MinPrice, (void*)(&value));
			}
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x0600BD71 RID: 48497 RVA: 0x00309568 File Offset: 0x00307768
		// (set) Token: 0x0600BD72 RID: 48498 RVA: 0x000584C1 File Offset: 0x000566C1
		public unsafe static float MaxPrice
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CounterofferInterface.NativeFieldInfoPtr_MaxPrice, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterofferInterface.NativeFieldInfoPtr_MaxPrice, (void*)(&value));
			}
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x0600BD73 RID: 48499 RVA: 0x00309584 File Offset: 0x00307784
		// (set) Token: 0x0600BD74 RID: 48500 RVA: 0x000584CF File Offset: 0x000566CF
		public unsafe float IconAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_IconAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_IconAlignment)) = value;
			}
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x0600BD75 RID: 48501 RVA: 0x003095AC File Offset: 0x003077AC
		// (set) Token: 0x0600BD76 RID: 48502 RVA: 0x000584EA File Offset: 0x000566EA
		public unsafe GameObject ProductEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x0600BD77 RID: 48503 RVA: 0x003095DC File Offset: 0x003077DC
		// (set) Token: 0x0600BD78 RID: 48504 RVA: 0x00058509 File Offset: 0x00056709
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x0600BD79 RID: 48505 RVA: 0x0030960C File Offset: 0x0030780C
		// (set) Token: 0x0600BD7A RID: 48506 RVA: 0x00058528 File Offset: 0x00056728
		public unsafe Text TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x0600BD7B RID: 48507 RVA: 0x0030963C File Offset: 0x0030783C
		// (set) Token: 0x0600BD7C RID: 48508 RVA: 0x00058547 File Offset: 0x00056747
		public unsafe Button ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x0600BD7D RID: 48509 RVA: 0x0030966C File Offset: 0x0030786C
		// (set) Token: 0x0600BD7E RID: 48510 RVA: 0x00058566 File Offset: 0x00056766
		public unsafe Image ProductIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x0600BD7F RID: 48511 RVA: 0x0030969C File Offset: 0x0030789C
		// (set) Token: 0x0600BD80 RID: 48512 RVA: 0x00058585 File Offset: 0x00056785
		public unsafe Text ProductLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x0600BD81 RID: 48513 RVA: 0x003096CC File Offset: 0x003078CC
		// (set) Token: 0x0600BD82 RID: 48514 RVA: 0x000585A4 File Offset: 0x000567A4
		public unsafe Text FairPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_FairPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x0600BD83 RID: 48515 RVA: 0x003096FC File Offset: 0x003078FC
		// (set) Token: 0x0600BD84 RID: 48516 RVA: 0x000585C3 File Offset: 0x000567C3
		public unsafe CounterOfferProductSelector ProductSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x0600BD85 RID: 48517 RVA: 0x0030972C File Offset: 0x0030792C
		// (set) Token: 0x0600BD86 RID: 48518 RVA: 0x000585E2 File Offset: 0x000567E2
		public unsafe InputField ProductAmountInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductAmountInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_ProductAmountInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x0600BD87 RID: 48519 RVA: 0x0030975C File Offset: 0x0030795C
		// (set) Token: 0x0600BD88 RID: 48520 RVA: 0x00058601 File Offset: 0x00056801
		public unsafe AmountSelector PriceSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_PriceSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmountSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_PriceSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x0600BD89 RID: 48521 RVA: 0x0030978C File Offset: 0x0030798C
		// (set) Token: 0x0600BD8A RID: 48522 RVA: 0x00058620 File Offset: 0x00056820
		public unsafe InputValueRamp _productAmountInputRamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr__productAmountInputRamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputValueRamp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr__productAmountInputRamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x0600BD8B RID: 48523 RVA: 0x003097BC File Offset: 0x003079BC
		// (set) Token: 0x0600BD8C RID: 48524 RVA: 0x0005863F File Offset: 0x0005683F
		public unsafe UIScreen uiScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_uiScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_uiScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x0600BD8D RID: 48525 RVA: 0x003097EC File Offset: 0x003079EC
		// (set) Token: 0x0600BD8E RID: 48526 RVA: 0x0005865E File Offset: 0x0005685E
		public unsafe UIPanel uiPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_uiPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_uiPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x0600BD8F RID: 48527 RVA: 0x0030981C File Offset: 0x00307A1C
		// (set) Token: 0x0600BD90 RID: 48528 RVA: 0x0005867D File Offset: 0x0005687D
		public unsafe Action<ProductDefinition, int, float> orderConfirmedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition, int, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_orderConfirmedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x0600BD91 RID: 48529 RVA: 0x0030984C File Offset: 0x00307A4C
		// (set) Token: 0x0600BD92 RID: 48530 RVA: 0x0005869C File Offset: 0x0005689C
		public unsafe ProductDefinition selectedProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_selectedProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_selectedProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x0600BD93 RID: 48531 RVA: 0x0030987C File Offset: 0x00307A7C
		// (set) Token: 0x0600BD94 RID: 48532 RVA: 0x000586BB File Offset: 0x000568BB
		public unsafe int quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_quantity)) = value;
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x0600BD95 RID: 48533 RVA: 0x003098A4 File Offset: 0x00307AA4
		// (set) Token: 0x0600BD96 RID: 48534 RVA: 0x000586D6 File Offset: 0x000568D6
		public unsafe Dictionary<ProductDefinition, RectTransform> productEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_productEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_productEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x0600BD97 RID: 48535 RVA: 0x003098D4 File Offset: 0x00307AD4
		// (set) Token: 0x0600BD98 RID: 48536 RVA: 0x000586F5 File Offset: 0x000568F5
		public unsafe bool mouseUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_mouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_mouseUp)) = value;
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x0600BD99 RID: 48537 RVA: 0x003098FC File Offset: 0x00307AFC
		// (set) Token: 0x0600BD9A RID: 48538 RVA: 0x00058710 File Offset: 0x00056910
		public unsafe MSGConversation conversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_conversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040081AE RID: 33198
		private static readonly IntPtr NativeFieldInfoPtr_COUNTEROFFER_SUCCESS_XP;

		// Token: 0x040081AF RID: 33199
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040081B0 RID: 33200
		private static readonly IntPtr NativeFieldInfoPtr_MinQuantity;

		// Token: 0x040081B1 RID: 33201
		private static readonly IntPtr NativeFieldInfoPtr_MaxQuantity;

		// Token: 0x040081B2 RID: 33202
		private static readonly IntPtr NativeFieldInfoPtr_MinPrice;

		// Token: 0x040081B3 RID: 33203
		private static readonly IntPtr NativeFieldInfoPtr_MaxPrice;

		// Token: 0x040081B4 RID: 33204
		private static readonly IntPtr NativeFieldInfoPtr_IconAlignment;

		// Token: 0x040081B5 RID: 33205
		private static readonly IntPtr NativeFieldInfoPtr_ProductEntryPrefab;

		// Token: 0x040081B6 RID: 33206
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040081B7 RID: 33207
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x040081B8 RID: 33208
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x040081B9 RID: 33209
		private static readonly IntPtr NativeFieldInfoPtr_ProductIcon;

		// Token: 0x040081BA RID: 33210
		private static readonly IntPtr NativeFieldInfoPtr_ProductLabel;

		// Token: 0x040081BB RID: 33211
		private static readonly IntPtr NativeFieldInfoPtr_FairPriceLabel;

		// Token: 0x040081BC RID: 33212
		private static readonly IntPtr NativeFieldInfoPtr_ProductSelector;

		// Token: 0x040081BD RID: 33213
		private static readonly IntPtr NativeFieldInfoPtr_ProductAmountInput;

		// Token: 0x040081BE RID: 33214
		private static readonly IntPtr NativeFieldInfoPtr_PriceSelector;

		// Token: 0x040081BF RID: 33215
		private static readonly IntPtr NativeFieldInfoPtr__productAmountInputRamp;

		// Token: 0x040081C0 RID: 33216
		private static readonly IntPtr NativeFieldInfoPtr_uiScreen;

		// Token: 0x040081C1 RID: 33217
		private static readonly IntPtr NativeFieldInfoPtr_uiPanel;

		// Token: 0x040081C2 RID: 33218
		private static readonly IntPtr NativeFieldInfoPtr_orderConfirmedCallback;

		// Token: 0x040081C3 RID: 33219
		private static readonly IntPtr NativeFieldInfoPtr_selectedProduct;

		// Token: 0x040081C4 RID: 33220
		private static readonly IntPtr NativeFieldInfoPtr_quantity;

		// Token: 0x040081C5 RID: 33221
		private static readonly IntPtr NativeFieldInfoPtr_productEntries;

		// Token: 0x040081C6 RID: 33222
		private static readonly IntPtr NativeFieldInfoPtr_mouseUp;

		// Token: 0x040081C7 RID: 33223
		private static readonly IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x040081C8 RID: 33224
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040081C9 RID: 33225
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040081CA RID: 33226
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040081CB RID: 33227
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040081CC RID: 33228
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040081CD RID: 33229
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ProductDefinition_Int32_Single_MSGConversation_Action_3_ProductDefinition_Int32_Single_0;

		// Token: 0x040081CE RID: 33230
		private static readonly IntPtr NativeMethodInfoPtr_DelaySelectPanel_Private_IEnumerator_0;

		// Token: 0x040081CF RID: 33231
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040081D0 RID: 33232
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x040081D1 RID: 33233
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Void_0;

		// Token: 0x040081D2 RID: 33234
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFairPrice_Private_Void_0;

		// Token: 0x040081D3 RID: 33235
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFairPrice_Private_Void_0;

		// Token: 0x040081D4 RID: 33236
		private static readonly IntPtr NativeMethodInfoPtr_SetProduct_Private_Void_ProductDefinition_0;

		// Token: 0x040081D5 RID: 33237
		private static readonly IntPtr NativeMethodInfoPtr_DisplayProduct_Private_Void_ProductDefinition_0;

		// Token: 0x040081D6 RID: 33238
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_Single_0;

		// Token: 0x040081D7 RID: 33239
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_String_0;

		// Token: 0x040081D8 RID: 33240
		private static readonly IntPtr NativeMethodInfoPtr_UpdateQuantityLabel_Private_Void_String_0;

		// Token: 0x040081D9 RID: 33241
		private static readonly IntPtr NativeMethodInfoPtr_OpenProductSelector_Public_Void_0;

		// Token: 0x040081DA RID: 33242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D19 RID: 3353
		[ObfuscatedName("ScheduleOne.UI.Phone.CounterofferInterface+<DelaySelectPanel>d__33")]
		public sealed class _DelaySelectPanel_d__33 : Il2CppSystem.Object
		{
			// Token: 0x0600F81D RID: 63517 RVA: 0x003B6E44 File Offset: 0x003B5044
			// Note: this type is marked as 'beforefieldinit'.
			static _DelaySelectPanel_d__33()
			{
				Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterofferInterface>.NativeClassPtr, "<DelaySelectPanel>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr);
				CounterofferInterface._DelaySelectPanel_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr, "<>1__state");
				CounterofferInterface._DelaySelectPanel_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr, "<>2__current");
				CounterofferInterface._DelaySelectPanel_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr, "<>4__this");
				CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr, 100688011);
				CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr, 100688012);
				CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr, 100688013);
				CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr, 100688014);
				CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr, 100688015);
				CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr, 100688016);
			}

			// Token: 0x0600F81E RID: 63518 RVA: 0x003B6F24 File Offset: 0x003B5124
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelaySelectPanel_d__33(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterofferInterface._DelaySelectPanel_d__33>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F81F RID: 63519 RVA: 0x003B6F6C File Offset: 0x003B516C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F820 RID: 63520 RVA: 0x003B6FA0 File Offset: 0x003B51A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315464, XrefRangeEnd = 315465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004B6E RID: 19310
			// (get) Token: 0x0600F821 RID: 63521 RVA: 0x003B6FDC File Offset: 0x003B51DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F822 RID: 63522 RVA: 0x003B701C File Offset: 0x003B521C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315465, XrefRangeEnd = 315470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B6F RID: 19311
			// (get) Token: 0x0600F823 RID: 63523 RVA: 0x003B7050 File Offset: 0x003B5250
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterofferInterface._DelaySelectPanel_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F824 RID: 63524 RVA: 0x00075517 File Offset: 0x00073717
			public _DelaySelectPanel_d__33(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B6B RID: 19307
			// (get) Token: 0x0600F825 RID: 63525 RVA: 0x003B7090 File Offset: 0x003B5290
			// (set) Token: 0x0600F826 RID: 63526 RVA: 0x00075520 File Offset: 0x00073720
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface._DelaySelectPanel_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface._DelaySelectPanel_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B6C RID: 19308
			// (get) Token: 0x0600F827 RID: 63527 RVA: 0x003B70B8 File Offset: 0x003B52B8
			// (set) Token: 0x0600F828 RID: 63528 RVA: 0x0007553B File Offset: 0x0007373B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface._DelaySelectPanel_d__33.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface._DelaySelectPanel_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B6D RID: 19309
			// (get) Token: 0x0600F829 RID: 63529 RVA: 0x003B70E8 File Offset: 0x003B52E8
			// (set) Token: 0x0600F82A RID: 63530 RVA: 0x0007555A File Offset: 0x0007375A
			public unsafe CounterofferInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface._DelaySelectPanel_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterofferInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterofferInterface._DelaySelectPanel_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7B9 RID: 42937
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A7BA RID: 42938
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A7BB RID: 42939
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7BC RID: 42940
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A7BD RID: 42941
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A7BE RID: 42942
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A7BF RID: 42943
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A7C0 RID: 42944
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A7C1 RID: 42945
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

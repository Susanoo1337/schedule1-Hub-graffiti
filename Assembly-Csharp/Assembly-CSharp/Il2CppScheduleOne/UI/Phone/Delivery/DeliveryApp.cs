using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020007B1 RID: 1969
	public class DeliveryApp : App<DeliveryApp>
	{
		// Token: 0x0600BF92 RID: 49042 RVA: 0x0030F9E8 File Offset: 0x0030DBE8
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryApp()
		{
			Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr);
			DeliveryApp.NativeFieldInfoPtr_deliveryShops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "deliveryShops");
			DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "OrderSubmittedAnim");
			DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "OrderSubmittedSound");
			DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "StatusDisplayContainer");
			DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "NoDeliveriesIndicator");
			DeliveryApp.NativeFieldInfoPtr_NoPastDeliveriesIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "NoPastDeliveriesIndicator");
			DeliveryApp.NativeFieldInfoPtr__deliveryReceiptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_deliveryReceiptPrefab");
			DeliveryApp.NativeFieldInfoPtr_PastDeliveriesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "PastDeliveriesContainer");
			DeliveryApp.NativeFieldInfoPtr__tabController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_tabController");
			DeliveryApp.NativeFieldInfoPtr_shopListCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "shopListCanvas");
			DeliveryApp.NativeFieldInfoPtr_orderCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "orderCanvas");
			DeliveryApp.NativeFieldInfoPtr__shopElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_shopElements");
			DeliveryApp.NativeFieldInfoPtr_shopPanelWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "shopPanelWidth");
			DeliveryApp.NativeFieldInfoPtr_shopTransitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "shopTransitionDuration");
			DeliveryApp.NativeFieldInfoPtr__deliveryStatusDisplayPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_deliveryStatusDisplayPrefab");
			DeliveryApp.NativeFieldInfoPtr__deliveryScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_deliveryScreen");
			DeliveryApp.NativeFieldInfoPtr__listingPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_listingPanel");
			DeliveryApp.NativeFieldInfoPtr__activeOrdersPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_activeOrdersPanel");
			DeliveryApp.NativeFieldInfoPtr__pastOrdersPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_pastOrdersPanel");
			DeliveryApp.NativeFieldInfoPtr_statusDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "statusDisplays");
			DeliveryApp.NativeFieldInfoPtr__pastDeliveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_pastDeliveries");
			DeliveryApp.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "started");
			DeliveryApp.NativeFieldInfoPtr__shopPanels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_shopPanels");
			DeliveryApp.NativeFieldInfoPtr__shopPanelInitialAnchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_shopPanelInitialAnchors");
			DeliveryApp.NativeFieldInfoPtr__shopTransitionCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "_shopTransitionCoroutine");
			DeliveryApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688267);
			DeliveryApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688268);
			DeliveryApp.NativeMethodInfoPtr_OpenShop_Public_Void_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688269);
			DeliveryApp.NativeMethodInfoPtr_CloseShop_Public_Void_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688270);
			DeliveryApp.NativeMethodInfoPtr_DoShopTransitionRoutine_Private_IEnumerator_Single_Int32_List_1_RectTransform_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688271);
			DeliveryApp.NativeMethodInfoPtr_OnExit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688272);
			DeliveryApp.NativeMethodInfoPtr_SetCanvasInteraction_Private_Void_CanvasGroup_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688273);
			DeliveryApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688274);
			DeliveryApp.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688275);
			DeliveryApp.NativeMethodInfoPtr_OnSubmitOrder_Public_Void_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688276);
			DeliveryApp.NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688277);
			DeliveryApp.NativeMethodInfoPtr_Reorder_Public_Void_DeliveryReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688278);
			DeliveryApp.NativeMethodInfoPtr_CanReorder_Public_Boolean_DeliveryReceipt_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688279);
			DeliveryApp.NativeMethodInfoPtr_GetDeliveryCost_Public_Single_DeliveryReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688280);
			DeliveryApp.NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688281);
			DeliveryApp.NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688282);
			DeliveryApp.NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688283);
			DeliveryApp.NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688284);
			DeliveryApp.NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688285);
			DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688286);
			DeliveryApp.NativeMethodInfoPtr_SetIsAvailable_Public_Void_ShopInterface_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688287);
			DeliveryApp.NativeMethodInfoPtr_OnTabChange_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688288);
			DeliveryApp.NativeMethodInfoPtr_UpdateActiveDeliveries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688289);
			DeliveryApp.NativeMethodInfoPtr_UpdatePastDeliveries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688290);
			DeliveryApp.NativeMethodInfoPtr_IsValidReceipt_Private_Boolean_DeliveryReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688291);
			DeliveryApp.NativeMethodInfoPtr_RefreshNotifications_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688292);
			DeliveryApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688293);
			DeliveryApp.NativeMethodInfoPtr__Start_b__26_2_Private_Void_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, 100688294);
		}

		// Token: 0x0600BF93 RID: 49043 RVA: 0x0030FE3C File Offset: 0x0030E03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318409, XrefRangeEnd = 318419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF94 RID: 49044 RVA: 0x0030FE78 File Offset: 0x0030E078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318419, XrefRangeEnd = 318611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF95 RID: 49045 RVA: 0x0030FEB4 File Offset: 0x0030E0B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318640, RefRangeEnd = 318641, XrefRangeStart = 318611, XrefRangeEnd = 318640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenShop(DeliveryShop shop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_OpenShop_Public_Void_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF96 RID: 49046 RVA: 0x0030FEF8 File Offset: 0x0030E0F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318669, RefRangeEnd = 318671, XrefRangeStart = 318641, XrefRangeEnd = 318669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseShop(DeliveryShop shop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_CloseShop_Public_Void_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF97 RID: 49047 RVA: 0x0030FF3C File Offset: 0x0030E13C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318678, RefRangeEnd = 318680, XrefRangeStart = 318671, XrefRangeEnd = 318678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoShopTransitionRoutine(float duration, int direction, List<RectTransform> panels, Action onComplete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panels);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_DoShopTransitionRoutine_Private_IEnumerator_Single_Int32_List_1_RectTransform_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600BF98 RID: 49048 RVA: 0x0030FFBC File Offset: 0x0030E1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318680, XrefRangeEnd = 318701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_OnExit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF99 RID: 49049 RVA: 0x0031000C File Offset: 0x0030E20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318701, XrefRangeEnd = 318703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasInteraction(CanvasGroup canvas, bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_SetCanvasInteraction_Private_Void_CanvasGroup_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF9A RID: 49050 RVA: 0x0031005C File Offset: 0x0030E25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318703, XrefRangeEnd = 318726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF9B RID: 49051 RVA: 0x003100A8 File Offset: 0x0030E2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318726, XrefRangeEnd = 318743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF9C RID: 49052 RVA: 0x003100DC File Offset: 0x0030E2DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318746, RefRangeEnd = 318747, XrefRangeStart = 318743, XrefRangeEnd = 318746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmitOrder(DeliveryShop shop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_OnSubmitOrder_Public_Void_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF9D RID: 49053 RVA: 0x00310120 File Offset: 0x0030E320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318749, RefRangeEnd = 318750, XrefRangeStart = 318747, XrefRangeEnd = 318749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOrderSubmittedAnim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF9E RID: 49054 RVA: 0x00310154 File Offset: 0x0030E354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318750, XrefRangeEnd = 318759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reorder(DeliveryReceipt receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_Reorder_Public_Void_DeliveryReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF9F RID: 49055 RVA: 0x00310198 File Offset: 0x0030E398
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318776, RefRangeEnd = 318778, XrefRangeStart = 318759, XrefRangeEnd = 318776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanReorder(DeliveryReceipt receipt, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_CanReorder_Public_Boolean_DeliveryReceipt_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600BFA0 RID: 49056 RVA: 0x00310200 File Offset: 0x0030E400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318791, RefRangeEnd = 318792, XrefRangeStart = 318778, XrefRangeEnd = 318791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDeliveryCost(DeliveryReceipt receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_GetDeliveryCost_Public_Single_DeliveryReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BFA1 RID: 49057 RVA: 0x00310250 File Offset: 0x0030E450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318811, RefRangeEnd = 318812, XrefRangeStart = 318792, XrefRangeEnd = 318811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDeliveryStatusDisplay(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFA2 RID: 49058 RVA: 0x00310294 File Offset: 0x0030E494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318812, XrefRangeEnd = 318844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeliveryCompleted(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFA3 RID: 49059 RVA: 0x003102D8 File Offset: 0x0030E4D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318873, RefRangeEnd = 318875, XrefRangeStart = 318844, XrefRangeEnd = 318873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortStatusDisplays()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x0031030C File Offset: 0x0030E50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318875, XrefRangeEnd = 318879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNoDeliveriesIndicator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFA5 RID: 49061 RVA: 0x00310340 File Offset: 0x0030E540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318879, XrefRangeEnd = 318900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RefreshLayoutGroupsImmediateAndRecursive(GameObject root)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFA6 RID: 49062 RVA: 0x00310378 File Offset: 0x0030E578
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 318915, RefRangeEnd = 318921, XrefRangeStart = 318900, XrefRangeEnd = 318915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryShop GetShop(string shopName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shopName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr3) : null;
		}

		// Token: 0x0600BFA7 RID: 49063 RVA: 0x003103C8 File Offset: 0x0030E5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318921, XrefRangeEnd = 318950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsAvailable(ShopInterface matchingShop, bool available)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchingShop);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref available;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_SetIsAvailable_Public_Void_ShopInterface_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFA8 RID: 49064 RVA: 0x00310418 File Offset: 0x0030E618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318950, XrefRangeEnd = 318963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTabChange(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_OnTabChange_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFA9 RID: 49065 RVA: 0x00310458 File Offset: 0x0030E658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318963, XrefRangeEnd = 318969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActiveDeliveries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_UpdateActiveDeliveries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFAA RID: 49066 RVA: 0x0031048C File Offset: 0x0030E68C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319003, RefRangeEnd = 319005, XrefRangeStart = 318969, XrefRangeEnd = 319003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePastDeliveries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_UpdatePastDeliveries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFAB RID: 49067 RVA: 0x003104C0 File Offset: 0x0030E6C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319024, RefRangeEnd = 319025, XrefRangeStart = 319005, XrefRangeEnd = 319024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValidReceipt(DeliveryReceipt receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_IsValidReceipt_Private_Boolean_DeliveryReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BFAC RID: 49068 RVA: 0x00310510 File Offset: 0x0030E710
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 319051, RefRangeEnd = 319054, XrefRangeStart = 319025, XrefRangeEnd = 319051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr_RefreshNotifications_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFAD RID: 49069 RVA: 0x00310544 File Offset: 0x0030E744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319054, XrefRangeEnd = 319074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFAE RID: 49070 RVA: 0x00310580 File Offset: 0x0030E780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319074, XrefRangeEnd = 319076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__26_2(UIPanel p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.NativeMethodInfoPtr__Start_b__26_2_Private_Void_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFAF RID: 49071 RVA: 0x000599C4 File Offset: 0x00057BC4
		public DeliveryApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170039ED RID: 14829
		// (get) Token: 0x0600BFB0 RID: 49072 RVA: 0x003105C4 File Offset: 0x0030E7C4
		// (set) Token: 0x0600BFB1 RID: 49073 RVA: 0x000599CD File Offset: 0x00057BCD
		public unsafe List<DeliveryShop> deliveryShops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_deliveryShops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryShop>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_deliveryShops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039EE RID: 14830
		// (get) Token: 0x0600BFB2 RID: 49074 RVA: 0x003105F4 File Offset: 0x0030E7F4
		// (set) Token: 0x0600BFB3 RID: 49075 RVA: 0x000599EC File Offset: 0x00057BEC
		public unsafe Animation OrderSubmittedAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x0600BFB4 RID: 49076 RVA: 0x00310624 File Offset: 0x0030E824
		// (set) Token: 0x0600BFB5 RID: 49077 RVA: 0x00059A0B File Offset: 0x00057C0B
		public unsafe AudioSourceController OrderSubmittedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_OrderSubmittedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x0600BFB6 RID: 49078 RVA: 0x00310654 File Offset: 0x0030E854
		// (set) Token: 0x0600BFB7 RID: 49079 RVA: 0x00059A2A File Offset: 0x00057C2A
		public unsafe RectTransform StatusDisplayContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_StatusDisplayContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x0600BFB8 RID: 49080 RVA: 0x00310684 File Offset: 0x0030E884
		// (set) Token: 0x0600BFB9 RID: 49081 RVA: 0x00059A49 File Offset: 0x00057C49
		public unsafe GameObject NoDeliveriesIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_NoDeliveriesIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x0600BFBA RID: 49082 RVA: 0x003106B4 File Offset: 0x0030E8B4
		// (set) Token: 0x0600BFBB RID: 49083 RVA: 0x00059A68 File Offset: 0x00057C68
		public unsafe GameObject NoPastDeliveriesIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_NoPastDeliveriesIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_NoPastDeliveriesIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x0600BFBC RID: 49084 RVA: 0x003106E4 File Offset: 0x0030E8E4
		// (set) Token: 0x0600BFBD RID: 49085 RVA: 0x00059A87 File Offset: 0x00057C87
		public unsafe DeliveryReceiptDisplay _deliveryReceiptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__deliveryReceiptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryReceiptDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__deliveryReceiptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x0600BFBE RID: 49086 RVA: 0x00310714 File Offset: 0x0030E914
		// (set) Token: 0x0600BFBF RID: 49087 RVA: 0x00059AA6 File Offset: 0x00057CA6
		public unsafe RectTransform PastDeliveriesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_PastDeliveriesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_PastDeliveriesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x0600BFC0 RID: 49088 RVA: 0x00310744 File Offset: 0x0030E944
		// (set) Token: 0x0600BFC1 RID: 49089 RVA: 0x00059AC5 File Offset: 0x00057CC5
		public unsafe TabController _tabController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__tabController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TabController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__tabController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039F6 RID: 14838
		// (get) Token: 0x0600BFC2 RID: 49090 RVA: 0x00310774 File Offset: 0x0030E974
		// (set) Token: 0x0600BFC3 RID: 49091 RVA: 0x00059AE4 File Offset: 0x00057CE4
		public unsafe CanvasGroup shopListCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_shopListCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_shopListCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x0600BFC4 RID: 49092 RVA: 0x003107A4 File Offset: 0x0030E9A4
		// (set) Token: 0x0600BFC5 RID: 49093 RVA: 0x00059B03 File Offset: 0x00057D03
		public unsafe CanvasGroup orderCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_orderCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_orderCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039F8 RID: 14840
		// (get) Token: 0x0600BFC6 RID: 49094 RVA: 0x003107D4 File Offset: 0x0030E9D4
		// (set) Token: 0x0600BFC7 RID: 49095 RVA: 0x00059B22 File Offset: 0x00057D22
		public unsafe List<DeliveryApp.DeliveryShopElement> _shopElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__shopElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryApp.DeliveryShopElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__shopElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039F9 RID: 14841
		// (get) Token: 0x0600BFC8 RID: 49096 RVA: 0x00310804 File Offset: 0x0030EA04
		// (set) Token: 0x0600BFC9 RID: 49097 RVA: 0x00059B41 File Offset: 0x00057D41
		public unsafe float shopPanelWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_shopPanelWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_shopPanelWidth)) = value;
			}
		}

		// Token: 0x170039FA RID: 14842
		// (get) Token: 0x0600BFCA RID: 49098 RVA: 0x0031082C File Offset: 0x0030EA2C
		// (set) Token: 0x0600BFCB RID: 49099 RVA: 0x00059B5C File Offset: 0x00057D5C
		public unsafe float shopTransitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_shopTransitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_shopTransitionDuration)) = value;
			}
		}

		// Token: 0x170039FB RID: 14843
		// (get) Token: 0x0600BFCC RID: 49100 RVA: 0x00310854 File Offset: 0x0030EA54
		// (set) Token: 0x0600BFCD RID: 49101 RVA: 0x00059B77 File Offset: 0x00057D77
		public unsafe DeliveryStatusDisplay _deliveryStatusDisplayPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__deliveryStatusDisplayPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryStatusDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__deliveryStatusDisplayPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039FC RID: 14844
		// (get) Token: 0x0600BFCE RID: 49102 RVA: 0x00310884 File Offset: 0x0030EA84
		// (set) Token: 0x0600BFCF RID: 49103 RVA: 0x00059B96 File Offset: 0x00057D96
		public unsafe UIScreen _deliveryScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__deliveryScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__deliveryScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039FD RID: 14845
		// (get) Token: 0x0600BFD0 RID: 49104 RVA: 0x003108B4 File Offset: 0x0030EAB4
		// (set) Token: 0x0600BFD1 RID: 49105 RVA: 0x00059BB5 File Offset: 0x00057DB5
		public unsafe UIPanel _listingPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__listingPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__listingPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x0600BFD2 RID: 49106 RVA: 0x003108E4 File Offset: 0x0030EAE4
		// (set) Token: 0x0600BFD3 RID: 49107 RVA: 0x00059BD4 File Offset: 0x00057DD4
		public unsafe UIPanel _activeOrdersPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__activeOrdersPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__activeOrdersPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x0600BFD4 RID: 49108 RVA: 0x00310914 File Offset: 0x0030EB14
		// (set) Token: 0x0600BFD5 RID: 49109 RVA: 0x00059BF3 File Offset: 0x00057DF3
		public unsafe UIPanel _pastOrdersPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__pastOrdersPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__pastOrdersPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x0600BFD6 RID: 49110 RVA: 0x00310944 File Offset: 0x0030EB44
		// (set) Token: 0x0600BFD7 RID: 49111 RVA: 0x00059C12 File Offset: 0x00057E12
		public unsafe List<DeliveryStatusDisplay> statusDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_statusDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryStatusDisplay>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_statusDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x0600BFD8 RID: 49112 RVA: 0x00310974 File Offset: 0x0030EB74
		// (set) Token: 0x0600BFD9 RID: 49113 RVA: 0x00059C31 File Offset: 0x00057E31
		public unsafe Il2CppReferenceArray<DeliveryReceiptDisplay> _pastDeliveries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__pastDeliveries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryReceiptDisplay>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__pastDeliveries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x0600BFDA RID: 49114 RVA: 0x003109A4 File Offset: 0x0030EBA4
		// (set) Token: 0x0600BFDB RID: 49115 RVA: 0x00059C50 File Offset: 0x00057E50
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x0600BFDC RID: 49116 RVA: 0x003109CC File Offset: 0x0030EBCC
		// (set) Token: 0x0600BFDD RID: 49117 RVA: 0x00059C6B File Offset: 0x00057E6B
		public unsafe List<RectTransform> _shopPanels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__shopPanels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__shopPanels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A04 RID: 14852
		// (get) Token: 0x0600BFDE RID: 49118 RVA: 0x003109FC File Offset: 0x0030EBFC
		// (set) Token: 0x0600BFDF RID: 49119 RVA: 0x00059C8A File Offset: 0x00057E8A
		public unsafe List<Vector2> _shopPanelInitialAnchors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__shopPanelInitialAnchors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__shopPanelInitialAnchors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A05 RID: 14853
		// (get) Token: 0x0600BFE0 RID: 49120 RVA: 0x00310A2C File Offset: 0x0030EC2C
		// (set) Token: 0x0600BFE1 RID: 49121 RVA: 0x00059CA9 File Offset: 0x00057EA9
		public unsafe Coroutine _shopTransitionCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__shopTransitionCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.NativeFieldInfoPtr__shopTransitionCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400831E RID: 33566
		private static readonly IntPtr NativeFieldInfoPtr_deliveryShops;

		// Token: 0x0400831F RID: 33567
		private static readonly IntPtr NativeFieldInfoPtr_OrderSubmittedAnim;

		// Token: 0x04008320 RID: 33568
		private static readonly IntPtr NativeFieldInfoPtr_OrderSubmittedSound;

		// Token: 0x04008321 RID: 33569
		private static readonly IntPtr NativeFieldInfoPtr_StatusDisplayContainer;

		// Token: 0x04008322 RID: 33570
		private static readonly IntPtr NativeFieldInfoPtr_NoDeliveriesIndicator;

		// Token: 0x04008323 RID: 33571
		private static readonly IntPtr NativeFieldInfoPtr_NoPastDeliveriesIndicator;

		// Token: 0x04008324 RID: 33572
		private static readonly IntPtr NativeFieldInfoPtr__deliveryReceiptPrefab;

		// Token: 0x04008325 RID: 33573
		private static readonly IntPtr NativeFieldInfoPtr_PastDeliveriesContainer;

		// Token: 0x04008326 RID: 33574
		private static readonly IntPtr NativeFieldInfoPtr__tabController;

		// Token: 0x04008327 RID: 33575
		private static readonly IntPtr NativeFieldInfoPtr_shopListCanvas;

		// Token: 0x04008328 RID: 33576
		private static readonly IntPtr NativeFieldInfoPtr_orderCanvas;

		// Token: 0x04008329 RID: 33577
		private static readonly IntPtr NativeFieldInfoPtr__shopElements;

		// Token: 0x0400832A RID: 33578
		private static readonly IntPtr NativeFieldInfoPtr_shopPanelWidth;

		// Token: 0x0400832B RID: 33579
		private static readonly IntPtr NativeFieldInfoPtr_shopTransitionDuration;

		// Token: 0x0400832C RID: 33580
		private static readonly IntPtr NativeFieldInfoPtr__deliveryStatusDisplayPrefab;

		// Token: 0x0400832D RID: 33581
		private static readonly IntPtr NativeFieldInfoPtr__deliveryScreen;

		// Token: 0x0400832E RID: 33582
		private static readonly IntPtr NativeFieldInfoPtr__listingPanel;

		// Token: 0x0400832F RID: 33583
		private static readonly IntPtr NativeFieldInfoPtr__activeOrdersPanel;

		// Token: 0x04008330 RID: 33584
		private static readonly IntPtr NativeFieldInfoPtr__pastOrdersPanel;

		// Token: 0x04008331 RID: 33585
		private static readonly IntPtr NativeFieldInfoPtr_statusDisplays;

		// Token: 0x04008332 RID: 33586
		private static readonly IntPtr NativeFieldInfoPtr__pastDeliveries;

		// Token: 0x04008333 RID: 33587
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x04008334 RID: 33588
		private static readonly IntPtr NativeFieldInfoPtr__shopPanels;

		// Token: 0x04008335 RID: 33589
		private static readonly IntPtr NativeFieldInfoPtr__shopPanelInitialAnchors;

		// Token: 0x04008336 RID: 33590
		private static readonly IntPtr NativeFieldInfoPtr__shopTransitionCoroutine;

		// Token: 0x04008337 RID: 33591
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008338 RID: 33592
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04008339 RID: 33593
		private static readonly IntPtr NativeMethodInfoPtr_OpenShop_Public_Void_DeliveryShop_0;

		// Token: 0x0400833A RID: 33594
		private static readonly IntPtr NativeMethodInfoPtr_CloseShop_Public_Void_DeliveryShop_0;

		// Token: 0x0400833B RID: 33595
		private static readonly IntPtr NativeMethodInfoPtr_DoShopTransitionRoutine_Private_IEnumerator_Single_Int32_List_1_RectTransform_Action_0;

		// Token: 0x0400833C RID: 33596
		private static readonly IntPtr NativeMethodInfoPtr_OnExit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x0400833D RID: 33597
		private static readonly IntPtr NativeMethodInfoPtr_SetCanvasInteraction_Private_Void_CanvasGroup_Boolean_0;

		// Token: 0x0400833E RID: 33598
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400833F RID: 33599
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x04008340 RID: 33600
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmitOrder_Public_Void_DeliveryShop_0;

		// Token: 0x04008341 RID: 33601
		private static readonly IntPtr NativeMethodInfoPtr_PlayOrderSubmittedAnim_Public_Void_0;

		// Token: 0x04008342 RID: 33602
		private static readonly IntPtr NativeMethodInfoPtr_Reorder_Public_Void_DeliveryReceipt_0;

		// Token: 0x04008343 RID: 33603
		private static readonly IntPtr NativeMethodInfoPtr_CanReorder_Public_Boolean_DeliveryReceipt_byref_String_0;

		// Token: 0x04008344 RID: 33604
		private static readonly IntPtr NativeMethodInfoPtr_GetDeliveryCost_Public_Single_DeliveryReceipt_0;

		// Token: 0x04008345 RID: 33605
		private static readonly IntPtr NativeMethodInfoPtr_CreateDeliveryStatusDisplay_Private_Void_DeliveryInstance_0;

		// Token: 0x04008346 RID: 33606
		private static readonly IntPtr NativeMethodInfoPtr_DeliveryCompleted_Private_Void_DeliveryInstance_0;

		// Token: 0x04008347 RID: 33607
		private static readonly IntPtr NativeMethodInfoPtr_SortStatusDisplays_Private_Void_0;

		// Token: 0x04008348 RID: 33608
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNoDeliveriesIndicator_Private_Void_0;

		// Token: 0x04008349 RID: 33609
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLayoutGroupsImmediateAndRecursive_Public_Static_Void_GameObject_0;

		// Token: 0x0400834A RID: 33610
		private static readonly IntPtr NativeMethodInfoPtr_GetShop_Public_DeliveryShop_String_0;

		// Token: 0x0400834B RID: 33611
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAvailable_Public_Void_ShopInterface_Boolean_0;

		// Token: 0x0400834C RID: 33612
		private static readonly IntPtr NativeMethodInfoPtr_OnTabChange_Private_Void_Int32_0;

		// Token: 0x0400834D RID: 33613
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActiveDeliveries_Private_Void_0;

		// Token: 0x0400834E RID: 33614
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePastDeliveries_Private_Void_0;

		// Token: 0x0400834F RID: 33615
		private static readonly IntPtr NativeMethodInfoPtr_IsValidReceipt_Private_Boolean_DeliveryReceipt_0;

		// Token: 0x04008350 RID: 33616
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNotifications_Private_Void_0;

		// Token: 0x04008351 RID: 33617
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04008352 RID: 33618
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_2_Private_Void_UIPanel_0;

		// Token: 0x02000D2E RID: 3374
		[Serializable]
		public class DeliveryShopElement : Il2CppSystem.Object
		{
			// Token: 0x0600F90C RID: 63756 RVA: 0x003B9A38 File Offset: 0x003B7C38
			// Note: this type is marked as 'beforefieldinit'.
			static DeliveryShopElement()
			{
				Il2CppClassPointerStore<DeliveryApp.DeliveryShopElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "DeliveryShopElement");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.DeliveryShopElement>.NativeClassPtr);
				DeliveryApp.DeliveryShopElement.NativeFieldInfoPtr_Shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.DeliveryShopElement>.NativeClassPtr, "Shop");
				DeliveryApp.DeliveryShopElement.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.DeliveryShopElement>.NativeClassPtr, "Button");
				DeliveryApp.DeliveryShopElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.DeliveryShopElement>.NativeClassPtr, 100688295);
			}

			// Token: 0x0600F90D RID: 63757 RVA: 0x003B9AA0 File Offset: 0x003B7CA0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeliveryShopElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.DeliveryShopElement>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.DeliveryShopElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F90E RID: 63758 RVA: 0x00075C89 File Offset: 0x00073E89
			public DeliveryShopElement(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BBA RID: 19386
			// (get) Token: 0x0600F90F RID: 63759 RVA: 0x003B9ADC File Offset: 0x003B7CDC
			// (set) Token: 0x0600F910 RID: 63760 RVA: 0x00075C92 File Offset: 0x00073E92
			public unsafe DeliveryShop Shop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.DeliveryShopElement.NativeFieldInfoPtr_Shop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.DeliveryShopElement.NativeFieldInfoPtr_Shop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BBB RID: 19387
			// (get) Token: 0x0600F911 RID: 63761 RVA: 0x003B9B0C File Offset: 0x003B7D0C
			// (set) Token: 0x0600F912 RID: 63762 RVA: 0x00075CB1 File Offset: 0x00073EB1
			public unsafe Button Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.DeliveryShopElement.NativeFieldInfoPtr_Button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.DeliveryShopElement.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A844 RID: 43076
			private static readonly IntPtr NativeFieldInfoPtr_Shop;

			// Token: 0x0400A845 RID: 43077
			private static readonly IntPtr NativeFieldInfoPtr_Button;

			// Token: 0x0400A846 RID: 43078
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000D2F RID: 3375
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F913 RID: 63763 RVA: 0x003B9B3C File Offset: 0x003B7D3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr);
				DeliveryApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, "<>9");
				DeliveryApp.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, "<>9__26_0");
				DeliveryApp.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, "<>9__29_0");
				DeliveryApp.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, "<>9__41_0");
				DeliveryApp.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, "<>9__50_0");
				DeliveryApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, 100688297);
				DeliveryApp.__c.NativeMethodInfoPtr__Start_b__26_0_Internal_Vector2_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, 100688298);
				DeliveryApp.__c.NativeMethodInfoPtr__DoShopTransitionRoutine_b__29_0_Internal_Vector2_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, 100688299);
				DeliveryApp.__c.NativeMethodInfoPtr__SortStatusDisplays_b__41_0_Internal_Int32_DeliveryStatusDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, 100688300);
				DeliveryApp.__c.NativeMethodInfoPtr__RefreshNotifications_b__50_0_Internal_Boolean_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr, 100688301);
			}

			// Token: 0x0600F914 RID: 63764 RVA: 0x003B9C30 File Offset: 0x003B7E30
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F915 RID: 63765 RVA: 0x003B9C6C File Offset: 0x003B7E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318278, XrefRangeEnd = 318280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _Start_b__26_0(RectTransform p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c.NativeMethodInfoPtr__Start_b__26_0_Internal_Vector2_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F916 RID: 63766 RVA: 0x003B9CBC File Offset: 0x003B7EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _DoShopTransitionRoutine_b__29_0(RectTransform p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c.NativeMethodInfoPtr__DoShopTransitionRoutine_b__29_0_Internal_Vector2_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F917 RID: 63767 RVA: 0x003B9D0C File Offset: 0x003B7F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318280, XrefRangeEnd = 318282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortStatusDisplays_b__41_0(DeliveryStatusDisplay d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c.NativeMethodInfoPtr__SortStatusDisplays_b__41_0_Internal_Int32_DeliveryStatusDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F918 RID: 63768 RVA: 0x003B9D5C File Offset: 0x003B7F5C
			[CallerCount(0)]
			public unsafe bool _RefreshNotifications_b__50_0(DeliveryInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c.NativeMethodInfoPtr__RefreshNotifications_b__50_0_Internal_Boolean_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F919 RID: 63769 RVA: 0x00075CD0 File Offset: 0x00073ED0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BBC RID: 19388
			// (get) Token: 0x0600F91A RID: 63770 RVA: 0x003B9DAC File Offset: 0x003B7FAC
			// (set) Token: 0x0600F91B RID: 63771 RVA: 0x00075CD9 File Offset: 0x00073ED9
			public unsafe static DeliveryApp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BBD RID: 19389
			// (get) Token: 0x0600F91C RID: 63772 RVA: 0x003B9DD4 File Offset: 0x003B7FD4
			// (set) Token: 0x0600F91D RID: 63773 RVA: 0x00075CEB File Offset: 0x00073EEB
			public unsafe static Func<RectTransform, Vector2> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryApp.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RectTransform, Vector2>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryApp.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BBE RID: 19390
			// (get) Token: 0x0600F91E RID: 63774 RVA: 0x003B9DFC File Offset: 0x003B7FFC
			// (set) Token: 0x0600F91F RID: 63775 RVA: 0x00075CFD File Offset: 0x00073EFD
			public unsafe static Func<RectTransform, Vector2> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryApp.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RectTransform, Vector2>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryApp.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BBF RID: 19391
			// (get) Token: 0x0600F920 RID: 63776 RVA: 0x003B9E24 File Offset: 0x003B8024
			// (set) Token: 0x0600F921 RID: 63777 RVA: 0x00075D0F File Offset: 0x00073F0F
			public unsafe static Func<DeliveryStatusDisplay, int> __9__41_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryApp.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeliveryStatusDisplay, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryApp.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BC0 RID: 19392
			// (get) Token: 0x0600F922 RID: 63778 RVA: 0x003B9E4C File Offset: 0x003B804C
			// (set) Token: 0x0600F923 RID: 63779 RVA: 0x00075D21 File Offset: 0x00073F21
			public unsafe static Func<DeliveryInstance, bool> __9__50_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryApp.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeliveryInstance, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryApp.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A847 RID: 43079
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A848 RID: 43080
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x0400A849 RID: 43081
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400A84A RID: 43082
			private static readonly IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x0400A84B RID: 43083
			private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

			// Token: 0x0400A84C RID: 43084
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A84D RID: 43085
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_0_Internal_Vector2_RectTransform_0;

			// Token: 0x0400A84E RID: 43086
			private static readonly IntPtr NativeMethodInfoPtr__DoShopTransitionRoutine_b__29_0_Internal_Vector2_RectTransform_0;

			// Token: 0x0400A84F RID: 43087
			private static readonly IntPtr NativeMethodInfoPtr__SortStatusDisplays_b__41_0_Internal_Int32_DeliveryStatusDisplay_0;

			// Token: 0x0400A850 RID: 43088
			private static readonly IntPtr NativeMethodInfoPtr__RefreshNotifications_b__50_0_Internal_Boolean_DeliveryInstance_0;
		}

		// Token: 0x02000D30 RID: 3376
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F924 RID: 63780 RVA: 0x003B9E74 File Offset: 0x003B8074
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass26_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass26_0.NativeFieldInfoPtr_shopElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass26_0>.NativeClassPtr, "shopElement");
				DeliveryApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				DeliveryApp.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass26_0>.NativeClassPtr, 100688302);
				DeliveryApp.__c__DisplayClass26_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass26_0>.NativeClassPtr, 100688303);
			}

			// Token: 0x0600F925 RID: 63781 RVA: 0x003B9EF0 File Offset: 0x003B80F0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F926 RID: 63782 RVA: 0x003B9F2C File Offset: 0x003B812C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318282, XrefRangeEnd = 318284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass26_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F927 RID: 63783 RVA: 0x00075D33 File Offset: 0x00073F33
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BC1 RID: 19393
			// (get) Token: 0x0600F928 RID: 63784 RVA: 0x003B9F60 File Offset: 0x003B8160
			// (set) Token: 0x0600F929 RID: 63785 RVA: 0x00075D3C File Offset: 0x00073F3C
			public unsafe DeliveryApp.DeliveryShopElement shopElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass26_0.NativeFieldInfoPtr_shopElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp.DeliveryShopElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass26_0.NativeFieldInfoPtr_shopElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BC2 RID: 19394
			// (get) Token: 0x0600F92A RID: 63786 RVA: 0x003B9F90 File Offset: 0x003B8190
			// (set) Token: 0x0600F92B RID: 63787 RVA: 0x00075D5B File Offset: 0x00073F5B
			public unsafe DeliveryApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A851 RID: 43089
			private static readonly IntPtr NativeFieldInfoPtr_shopElement;

			// Token: 0x0400A852 RID: 43090
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A853 RID: 43091
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A854 RID: 43092
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_0;
		}

		// Token: 0x02000D31 RID: 3377
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F92C RID: 63788 RVA: 0x003B9FC0 File Offset: 0x003B81C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass27_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				DeliveryApp.__c__DisplayClass27_0.NativeFieldInfoPtr_shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass27_0>.NativeClassPtr, "shop");
				DeliveryApp.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass27_0>.NativeClassPtr, 100688304);
				DeliveryApp.__c__DisplayClass27_0.NativeMethodInfoPtr__OpenShop_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass27_0>.NativeClassPtr, 100688305);
			}

			// Token: 0x0600F92D RID: 63789 RVA: 0x003BA03C File Offset: 0x003B823C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F92E RID: 63790 RVA: 0x003BA078 File Offset: 0x003B8278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318284, XrefRangeEnd = 318293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenShop_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass27_0.NativeMethodInfoPtr__OpenShop_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F92F RID: 63791 RVA: 0x00075D7A File Offset: 0x00073F7A
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BC3 RID: 19395
			// (get) Token: 0x0600F930 RID: 63792 RVA: 0x003BA0AC File Offset: 0x003B82AC
			// (set) Token: 0x0600F931 RID: 63793 RVA: 0x00075D83 File Offset: 0x00073F83
			public unsafe DeliveryApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BC4 RID: 19396
			// (get) Token: 0x0600F932 RID: 63794 RVA: 0x003BA0DC File Offset: 0x003B82DC
			// (set) Token: 0x0600F933 RID: 63795 RVA: 0x00075DA2 File Offset: 0x00073FA2
			public unsafe DeliveryShop shop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass27_0.NativeFieldInfoPtr_shop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass27_0.NativeFieldInfoPtr_shop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A855 RID: 43093
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A856 RID: 43094
			private static readonly IntPtr NativeFieldInfoPtr_shop;

			// Token: 0x0400A857 RID: 43095
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A858 RID: 43096
			private static readonly IntPtr NativeMethodInfoPtr__OpenShop_b__0_Internal_Void_0;
		}

		// Token: 0x02000D32 RID: 3378
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F934 RID: 63796 RVA: 0x003BA10C File Offset: 0x003B830C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass28_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				DeliveryApp.__c__DisplayClass28_0.NativeFieldInfoPtr_shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass28_0>.NativeClassPtr, "shop");
				DeliveryApp.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass28_0>.NativeClassPtr, 100688306);
				DeliveryApp.__c__DisplayClass28_0.NativeMethodInfoPtr__CloseShop_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass28_0>.NativeClassPtr, 100688307);
			}

			// Token: 0x0600F935 RID: 63797 RVA: 0x003BA188 File Offset: 0x003B8388
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F936 RID: 63798 RVA: 0x003BA1C4 File Offset: 0x003B83C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318293, XrefRangeEnd = 318297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CloseShop_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass28_0.NativeMethodInfoPtr__CloseShop_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F937 RID: 63799 RVA: 0x00075DC1 File Offset: 0x00073FC1
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BC5 RID: 19397
			// (get) Token: 0x0600F938 RID: 63800 RVA: 0x003BA1F8 File Offset: 0x003B83F8
			// (set) Token: 0x0600F939 RID: 63801 RVA: 0x00075DCA File Offset: 0x00073FCA
			public unsafe DeliveryApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BC6 RID: 19398
			// (get) Token: 0x0600F93A RID: 63802 RVA: 0x003BA228 File Offset: 0x003B8428
			// (set) Token: 0x0600F93B RID: 63803 RVA: 0x00075DE9 File Offset: 0x00073FE9
			public unsafe DeliveryShop shop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass28_0.NativeFieldInfoPtr_shop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass28_0.NativeFieldInfoPtr_shop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A859 RID: 43097
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A85A RID: 43098
			private static readonly IntPtr NativeFieldInfoPtr_shop;

			// Token: 0x0400A85B RID: 43099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A85C RID: 43100
			private static readonly IntPtr NativeMethodInfoPtr__CloseShop_b__0_Internal_Void_0;
		}

		// Token: 0x02000D33 RID: 3379
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F93C RID: 63804 RVA: 0x003BA258 File Offset: 0x003B8458
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass40_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass40_0.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass40_0>.NativeClassPtr, "instance");
				DeliveryApp.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass40_0>.NativeClassPtr, 100688308);
				DeliveryApp.__c__DisplayClass40_0.NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass40_0>.NativeClassPtr, 100688309);
			}

			// Token: 0x0600F93D RID: 63805 RVA: 0x003BA2C0 File Offset: 0x003B84C0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F93E RID: 63806 RVA: 0x003BA2FC File Offset: 0x003B84FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318297, XrefRangeEnd = 318299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeliveryCompleted_b__0(DeliveryStatusDisplay d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass40_0.NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F93F RID: 63807 RVA: 0x00075E08 File Offset: 0x00074008
			public __c__DisplayClass40_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BC7 RID: 19399
			// (get) Token: 0x0600F940 RID: 63808 RVA: 0x003BA34C File Offset: 0x003B854C
			// (set) Token: 0x0600F941 RID: 63809 RVA: 0x00075E11 File Offset: 0x00074011
			public unsafe DeliveryInstance instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass40_0.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass40_0.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A85D RID: 43101
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x0400A85E RID: 43102
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A85F RID: 43103
			private static readonly IntPtr NativeMethodInfoPtr__DeliveryCompleted_b__0_Internal_Boolean_DeliveryStatusDisplay_0;
		}

		// Token: 0x02000D34 RID: 3380
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F942 RID: 63810 RVA: 0x003BA37C File Offset: 0x003B857C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass44_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass44_0.NativeFieldInfoPtr_shopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass44_0>.NativeClassPtr, "shopName");
				DeliveryApp.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass44_0>.NativeClassPtr, 100688310);
				DeliveryApp.__c__DisplayClass44_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass44_0>.NativeClassPtr, 100688311);
			}

			// Token: 0x0600F943 RID: 63811 RVA: 0x003BA3E4 File Offset: 0x003B85E4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F944 RID: 63812 RVA: 0x003BA420 File Offset: 0x003B8620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318299, XrefRangeEnd = 318301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetShop_b__0(DeliveryShop x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass44_0.NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F945 RID: 63813 RVA: 0x00075E30 File Offset: 0x00074030
			public __c__DisplayClass44_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BC8 RID: 19400
			// (get) Token: 0x0600F946 RID: 63814 RVA: 0x003BA470 File Offset: 0x003B8670
			// (set) Token: 0x0600F947 RID: 63815 RVA: 0x00075E39 File Offset: 0x00074039
			public unsafe string shopName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass44_0.NativeFieldInfoPtr_shopName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass44_0.NativeFieldInfoPtr_shopName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A860 RID: 43104
			private static readonly IntPtr NativeFieldInfoPtr_shopName;

			// Token: 0x0400A861 RID: 43105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A862 RID: 43106
			private static readonly IntPtr NativeMethodInfoPtr__GetShop_b__0_Internal_Boolean_DeliveryShop_0;
		}

		// Token: 0x02000D35 RID: 3381
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass45_0")]
		public sealed class __c__DisplayClass45_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F948 RID: 63816 RVA: 0x003BA498 File Offset: 0x003B8698
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass45_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass45_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass45_0.NativeFieldInfoPtr_matchingShop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass45_0>.NativeClassPtr, "matchingShop");
				DeliveryApp.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass45_0>.NativeClassPtr, 100688312);
				DeliveryApp.__c__DisplayClass45_0.NativeMethodInfoPtr__SetIsAvailable_b__0_Internal_Boolean_DeliveryShopElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass45_0>.NativeClassPtr, 100688313);
			}

			// Token: 0x0600F949 RID: 63817 RVA: 0x003BA500 File Offset: 0x003B8700
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass45_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F94A RID: 63818 RVA: 0x003BA53C File Offset: 0x003B873C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318301, XrefRangeEnd = 318334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetIsAvailable_b__0(DeliveryApp.DeliveryShopElement x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass45_0.NativeMethodInfoPtr__SetIsAvailable_b__0_Internal_Boolean_DeliveryShopElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F94B RID: 63819 RVA: 0x00075E58 File Offset: 0x00074058
			public __c__DisplayClass45_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BC9 RID: 19401
			// (get) Token: 0x0600F94C RID: 63820 RVA: 0x003BA58C File Offset: 0x003B878C
			// (set) Token: 0x0600F94D RID: 63821 RVA: 0x00075E61 File Offset: 0x00074061
			public unsafe ShopInterface matchingShop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass45_0.NativeFieldInfoPtr_matchingShop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass45_0.NativeFieldInfoPtr_matchingShop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A863 RID: 43107
			private static readonly IntPtr NativeFieldInfoPtr_matchingShop;

			// Token: 0x0400A864 RID: 43108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A865 RID: 43109
			private static readonly IntPtr NativeMethodInfoPtr__SetIsAvailable_b__0_Internal_Boolean_DeliveryShopElement_0;
		}

		// Token: 0x02000D36 RID: 3382
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F94E RID: 63822 RVA: 0x003BA5BC File Offset: 0x003B87BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass49_0>.NativeClassPtr);
				DeliveryApp.__c__DisplayClass49_0.NativeFieldInfoPtr_receipt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass49_0>.NativeClassPtr, "receipt");
				DeliveryApp.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass49_0>.NativeClassPtr, 100688314);
				DeliveryApp.__c__DisplayClass49_0.NativeMethodInfoPtr__IsValidReceipt_b__0_Internal_Boolean_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass49_0>.NativeClassPtr, 100688315);
			}

			// Token: 0x0600F94F RID: 63823 RVA: 0x003BA624 File Offset: 0x003B8824
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F950 RID: 63824 RVA: 0x003BA660 File Offset: 0x003B8860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsValidReceipt_b__0(DeliveryInstance d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp.__c__DisplayClass49_0.NativeMethodInfoPtr__IsValidReceipt_b__0_Internal_Boolean_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F951 RID: 63825 RVA: 0x00075E80 File Offset: 0x00074080
			public __c__DisplayClass49_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BCA RID: 19402
			// (get) Token: 0x0600F952 RID: 63826 RVA: 0x003BA6B0 File Offset: 0x003B88B0
			// (set) Token: 0x0600F953 RID: 63827 RVA: 0x00075E89 File Offset: 0x00074089
			public unsafe DeliveryReceipt receipt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass49_0.NativeFieldInfoPtr_receipt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryReceipt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp.__c__DisplayClass49_0.NativeFieldInfoPtr_receipt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A866 RID: 43110
			private static readonly IntPtr NativeFieldInfoPtr_receipt;

			// Token: 0x0400A867 RID: 43111
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A868 RID: 43112
			private static readonly IntPtr NativeMethodInfoPtr__IsValidReceipt_b__0_Internal_Boolean_DeliveryInstance_0;
		}

		// Token: 0x02000D37 RID: 3383
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryApp+<DoShopTransitionRoutine>d__29")]
		public sealed class _DoShopTransitionRoutine_d__29 : Il2CppSystem.Object
		{
			// Token: 0x0600F954 RID: 63828 RVA: 0x003BA6E0 File Offset: 0x003B88E0
			// Note: this type is marked as 'beforefieldinit'.
			static _DoShopTransitionRoutine_d__29()
			{
				Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryApp>.NativeClassPtr, "<DoShopTransitionRoutine>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr);
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, "<>1__state");
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, "<>2__current");
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_panels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, "panels");
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, "<>4__this");
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, "direction");
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, "duration");
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, "onComplete");
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr__elapsedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, "<elapsedTime>5__2");
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr__startPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, "<startPos>5__3");
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr__targetPos_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, "<targetPos>5__4");
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, 100688316);
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, 100688317);
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, 100688318);
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, 100688319);
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, 100688320);
				DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr, 100688321);
			}

			// Token: 0x0600F955 RID: 63829 RVA: 0x003BA84C File Offset: 0x003B8A4C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoShopTransitionRoutine_d__29(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryApp._DoShopTransitionRoutine_d__29>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F956 RID: 63830 RVA: 0x003BA894 File Offset: 0x003B8A94
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F957 RID: 63831 RVA: 0x003BA8C8 File Offset: 0x003B8AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318334, XrefRangeEnd = 318404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004BD5 RID: 19413
			// (get) Token: 0x0600F958 RID: 63832 RVA: 0x003BA904 File Offset: 0x003B8B04
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F959 RID: 63833 RVA: 0x003BA944 File Offset: 0x003B8B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318404, XrefRangeEnd = 318409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004BD6 RID: 19414
			// (get) Token: 0x0600F95A RID: 63834 RVA: 0x003BA978 File Offset: 0x003B8B78
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryApp._DoShopTransitionRoutine_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F95B RID: 63835 RVA: 0x00075EA8 File Offset: 0x000740A8
			public _DoShopTransitionRoutine_d__29(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BCB RID: 19403
			// (get) Token: 0x0600F95C RID: 63836 RVA: 0x003BA9B8 File Offset: 0x003B8BB8
			// (set) Token: 0x0600F95D RID: 63837 RVA: 0x00075EB1 File Offset: 0x000740B1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004BCC RID: 19404
			// (get) Token: 0x0600F95E RID: 63838 RVA: 0x003BA9E0 File Offset: 0x003B8BE0
			// (set) Token: 0x0600F95F RID: 63839 RVA: 0x00075ECC File Offset: 0x000740CC
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BCD RID: 19405
			// (get) Token: 0x0600F960 RID: 63840 RVA: 0x003BAA10 File Offset: 0x003B8C10
			// (set) Token: 0x0600F961 RID: 63841 RVA: 0x00075EEB File Offset: 0x000740EB
			public unsafe List<RectTransform> panels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_panels);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_panels), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BCE RID: 19406
			// (get) Token: 0x0600F962 RID: 63842 RVA: 0x003BAA40 File Offset: 0x003B8C40
			// (set) Token: 0x0600F963 RID: 63843 RVA: 0x00075F0A File Offset: 0x0007410A
			public unsafe DeliveryApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BCF RID: 19407
			// (get) Token: 0x0600F964 RID: 63844 RVA: 0x003BAA70 File Offset: 0x003B8C70
			// (set) Token: 0x0600F965 RID: 63845 RVA: 0x00075F29 File Offset: 0x00074129
			public unsafe int direction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_direction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_direction)) = value;
				}
			}

			// Token: 0x17004BD0 RID: 19408
			// (get) Token: 0x0600F966 RID: 63846 RVA: 0x003BAA98 File Offset: 0x003B8C98
			// (set) Token: 0x0600F967 RID: 63847 RVA: 0x00075F44 File Offset: 0x00074144
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004BD1 RID: 19409
			// (get) Token: 0x0600F968 RID: 63848 RVA: 0x003BAAC0 File Offset: 0x003B8CC0
			// (set) Token: 0x0600F969 RID: 63849 RVA: 0x00075F5F File Offset: 0x0007415F
			public unsafe Action onComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_onComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BD2 RID: 19410
			// (get) Token: 0x0600F96A RID: 63850 RVA: 0x003BAAF0 File Offset: 0x003B8CF0
			// (set) Token: 0x0600F96B RID: 63851 RVA: 0x00075F7E File Offset: 0x0007417E
			public unsafe float _elapsedTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr__elapsedTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr__elapsedTime_5__2)) = value;
				}
			}

			// Token: 0x17004BD3 RID: 19411
			// (get) Token: 0x0600F96C RID: 63852 RVA: 0x003BAB18 File Offset: 0x003B8D18
			// (set) Token: 0x0600F96D RID: 63853 RVA: 0x00075F99 File Offset: 0x00074199
			public unsafe List<Vector2> _startPos_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr__startPos_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr__startPos_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BD4 RID: 19412
			// (get) Token: 0x0600F96E RID: 63854 RVA: 0x003BAB48 File Offset: 0x003B8D48
			// (set) Token: 0x0600F96F RID: 63855 RVA: 0x00075FB8 File Offset: 0x000741B8
			public unsafe List<Vector2> _targetPos_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr__targetPos_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryApp._DoShopTransitionRoutine_d__29.NativeFieldInfoPtr__targetPos_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A869 RID: 43113
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A86A RID: 43114
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A86B RID: 43115
			private static readonly IntPtr NativeFieldInfoPtr_panels;

			// Token: 0x0400A86C RID: 43116
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A86D RID: 43117
			private static readonly IntPtr NativeFieldInfoPtr_direction;

			// Token: 0x0400A86E RID: 43118
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A86F RID: 43119
			private static readonly IntPtr NativeFieldInfoPtr_onComplete;

			// Token: 0x0400A870 RID: 43120
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__2;

			// Token: 0x0400A871 RID: 43121
			private static readonly IntPtr NativeFieldInfoPtr__startPos_5__3;

			// Token: 0x0400A872 RID: 43122
			private static readonly IntPtr NativeFieldInfoPtr__targetPos_5__4;

			// Token: 0x0400A873 RID: 43123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A874 RID: 43124
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A875 RID: 43125
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A876 RID: 43126
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A877 RID: 43127
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A878 RID: 43128
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

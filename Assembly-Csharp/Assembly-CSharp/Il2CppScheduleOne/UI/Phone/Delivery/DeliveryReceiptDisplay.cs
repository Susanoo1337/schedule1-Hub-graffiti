using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Items;
using Il2CppScheduleOne.UI.Tooltips;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020007B2 RID: 1970
	public class DeliveryReceiptDisplay : MonoBehaviour
	{
		// Token: 0x0600BFE2 RID: 49122 RVA: 0x00310A5C File Offset: 0x0030EC5C
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryReceiptDisplay()
		{
			Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryReceiptDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr);
			DeliveryReceiptDisplay.NativeFieldInfoPtr_ItemEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "ItemEntryPrefab");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__DestinationLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_DestinationLabel");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__loadingDockLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_loadingDockLabel");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__shopLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_shopLabel");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__shopDescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_shopDescriptionLabel");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__ItemEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_ItemEntryContainer");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__ReorderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_ReorderButton");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__ReorderTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_ReorderTooltip");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__reorderPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_reorderPriceLabel");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__maxItemsShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_maxItemsShown");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__generalColorFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_generalColorFont");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__shopTextColorFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_shopTextColorFont");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_selectable");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__receipt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_receipt");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__itemEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_itemEntries");
			DeliveryReceiptDisplay.NativeFieldInfoPtr__onSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, "_onSelect");
			DeliveryReceiptDisplay.NativeMethodInfoPtr_get_ReorderButton_Public_get_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688322);
			DeliveryReceiptDisplay.NativeMethodInfoPtr_get_Receipt_Public_get_DeliveryReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688323);
			DeliveryReceiptDisplay.NativeMethodInfoPtr_get_Selectable_Public_get_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688324);
			DeliveryReceiptDisplay.NativeMethodInfoPtr_Initialise_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688325);
			DeliveryReceiptDisplay.NativeMethodInfoPtr_Set_Public_Void_DeliveryReceipt_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688326);
			DeliveryReceiptDisplay.NativeMethodInfoPtr_SetTooltip_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688327);
			DeliveryReceiptDisplay.NativeMethodInfoPtr_SetActiveTooltip_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688328);
			DeliveryReceiptDisplay.NativeMethodInfoPtr_ForceActiveTooltip_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688329);
			DeliveryReceiptDisplay.NativeMethodInfoPtr_SubscribeToOnSelect_Public_Void_Action_1_DeliveryReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688330);
			DeliveryReceiptDisplay.NativeMethodInfoPtr_UnsubscribeFromOnSelect_Public_Void_Action_1_DeliveryReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688331);
			DeliveryReceiptDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688332);
			DeliveryReceiptDisplay.NativeMethodInfoPtr__Initialise_b__22_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688333);
			DeliveryReceiptDisplay.NativeMethodInfoPtr__Initialise_b__22_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688334);
			DeliveryReceiptDisplay.NativeMethodInfoPtr__Initialise_b__22_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr, 100688335);
		}

		// Token: 0x17003A16 RID: 14870
		// (get) Token: 0x0600BFE3 RID: 49123 RVA: 0x00310CE4 File Offset: 0x0030EEE4
		public unsafe Button ReorderButton
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr_get_ReorderButton_Public_get_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Button>(intPtr3) : null;
			}
		}

		// Token: 0x17003A17 RID: 14871
		// (get) Token: 0x0600BFE4 RID: 49124 RVA: 0x00310D24 File Offset: 0x0030EF24
		public unsafe DeliveryReceipt Receipt
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 41637, RefRangeEnd = 41647, XrefRangeStart = 41637, XrefRangeEnd = 41647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr_get_Receipt_Public_get_DeliveryReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryReceipt>(intPtr3) : null;
			}
		}

		// Token: 0x17003A18 RID: 14872
		// (get) Token: 0x0600BFE5 RID: 49125 RVA: 0x00310D64 File Offset: 0x0030EF64
		public unsafe UISelectable Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr_get_Selectable_Public_get_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
			}
		}

		// Token: 0x0600BFE6 RID: 49126 RVA: 0x00310DA4 File Offset: 0x0030EFA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319113, RefRangeEnd = 319114, XrefRangeStart = 319076, XrefRangeEnd = 319113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialise()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr_Initialise_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFE7 RID: 49127 RVA: 0x00310DD8 File Offset: 0x0030EFD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319145, RefRangeEnd = 319146, XrefRangeStart = 319114, XrefRangeEnd = 319145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(DeliveryReceipt receipt, float deliveryCost, bool canAfford)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deliveryCost;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAfford;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr_Set_Public_Void_DeliveryReceipt_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFE8 RID: 49128 RVA: 0x00310E38 File Offset: 0x0030F038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319148, RefRangeEnd = 319149, XrefRangeStart = 319146, XrefRangeEnd = 319148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTooltip(string tooltip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr_SetTooltip_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFE9 RID: 49129 RVA: 0x00310E7C File Offset: 0x0030F07C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319151, RefRangeEnd = 319152, XrefRangeStart = 319149, XrefRangeEnd = 319151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveTooltip(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr_SetActiveTooltip_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFEA RID: 49130 RVA: 0x00310EBC File Offset: 0x0030F0BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319161, RefRangeEnd = 319162, XrefRangeStart = 319152, XrefRangeEnd = 319161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceActiveTooltip(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr_ForceActiveTooltip_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFEB RID: 49131 RVA: 0x00310EFC File Offset: 0x0030F0FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319172, RefRangeEnd = 319173, XrefRangeStart = 319162, XrefRangeEnd = 319172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToOnSelect(Action<DeliveryReceipt> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr_SubscribeToOnSelect_Public_Void_Action_1_DeliveryReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFEC RID: 49132 RVA: 0x00310F40 File Offset: 0x0030F140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319173, XrefRangeEnd = 319183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromOnSelect(Action<DeliveryReceipt> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr_UnsubscribeFromOnSelect_Public_Void_Action_1_DeliveryReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFED RID: 49133 RVA: 0x00310F84 File Offset: 0x0030F184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319183, XrefRangeEnd = 319184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryReceiptDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryReceiptDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFEE RID: 49134 RVA: 0x00310FC0 File Offset: 0x0030F1C0
		[CallerCount(0)]
		public unsafe void _Initialise_b__22_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr__Initialise_b__22_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFEF RID: 49135 RVA: 0x00310FF4 File Offset: 0x0030F1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319184, XrefRangeEnd = 319186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialise_b__22_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr__Initialise_b__22_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x00311028 File Offset: 0x0030F228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319186, XrefRangeEnd = 319192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialise_b__22_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceiptDisplay.NativeMethodInfoPtr__Initialise_b__22_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BFF1 RID: 49137 RVA: 0x00059CC8 File Offset: 0x00057EC8
		public DeliveryReceiptDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003A06 RID: 14854
		// (get) Token: 0x0600BFF2 RID: 49138 RVA: 0x0031105C File Offset: 0x0030F25C
		// (set) Token: 0x0600BFF3 RID: 49139 RVA: 0x00059CD1 File Offset: 0x00057ED1
		public unsafe ItemEntryUI ItemEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr_ItemEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemEntryUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr_ItemEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A07 RID: 14855
		// (get) Token: 0x0600BFF4 RID: 49140 RVA: 0x0031108C File Offset: 0x0030F28C
		// (set) Token: 0x0600BFF5 RID: 49141 RVA: 0x00059CF0 File Offset: 0x00057EF0
		public unsafe Text _DestinationLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__DestinationLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__DestinationLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x0600BFF6 RID: 49142 RVA: 0x003110BC File Offset: 0x0030F2BC
		// (set) Token: 0x0600BFF7 RID: 49143 RVA: 0x00059D0F File Offset: 0x00057F0F
		public unsafe Text _loadingDockLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__loadingDockLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__loadingDockLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x0600BFF8 RID: 49144 RVA: 0x003110EC File Offset: 0x0030F2EC
		// (set) Token: 0x0600BFF9 RID: 49145 RVA: 0x00059D2E File Offset: 0x00057F2E
		public unsafe Text _shopLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__shopLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__shopLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x0600BFFA RID: 49146 RVA: 0x0031111C File Offset: 0x0030F31C
		// (set) Token: 0x0600BFFB RID: 49147 RVA: 0x00059D4D File Offset: 0x00057F4D
		public unsafe Text _shopDescriptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__shopDescriptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__shopDescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x0600BFFC RID: 49148 RVA: 0x0031114C File Offset: 0x0030F34C
		// (set) Token: 0x0600BFFD RID: 49149 RVA: 0x00059D6C File Offset: 0x00057F6C
		public unsafe RectTransform _ItemEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__ItemEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__ItemEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x0600BFFE RID: 49150 RVA: 0x0031117C File Offset: 0x0030F37C
		// (set) Token: 0x0600BFFF RID: 49151 RVA: 0x00059D8B File Offset: 0x00057F8B
		public unsafe Button _ReorderButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__ReorderButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__ReorderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x0600C000 RID: 49152 RVA: 0x003111AC File Offset: 0x0030F3AC
		// (set) Token: 0x0600C001 RID: 49153 RVA: 0x00059DAA File Offset: 0x00057FAA
		public unsafe Tooltip _ReorderTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__ReorderTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__ReorderTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x0600C002 RID: 49154 RVA: 0x003111DC File Offset: 0x0030F3DC
		// (set) Token: 0x0600C003 RID: 49155 RVA: 0x00059DC9 File Offset: 0x00057FC9
		public unsafe Text _reorderPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__reorderPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__reorderPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x0600C004 RID: 49156 RVA: 0x0031120C File Offset: 0x0030F40C
		// (set) Token: 0x0600C005 RID: 49157 RVA: 0x00059DE8 File Offset: 0x00057FE8
		public unsafe int _maxItemsShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__maxItemsShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__maxItemsShown)) = value;
			}
		}

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x0600C006 RID: 49158 RVA: 0x00311234 File Offset: 0x0030F434
		// (set) Token: 0x0600C007 RID: 49159 RVA: 0x00059E03 File Offset: 0x00058003
		public unsafe ColorFont _generalColorFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__generalColorFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__generalColorFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x0600C008 RID: 49160 RVA: 0x00311264 File Offset: 0x0030F464
		// (set) Token: 0x0600C009 RID: 49161 RVA: 0x00059E22 File Offset: 0x00058022
		public unsafe ColorFont _shopTextColorFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__shopTextColorFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__shopTextColorFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A12 RID: 14866
		// (get) Token: 0x0600C00A RID: 49162 RVA: 0x00311294 File Offset: 0x0030F494
		// (set) Token: 0x0600C00B RID: 49163 RVA: 0x00059E41 File Offset: 0x00058041
		public unsafe UISelectable _selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A13 RID: 14867
		// (get) Token: 0x0600C00C RID: 49164 RVA: 0x003112C4 File Offset: 0x0030F4C4
		// (set) Token: 0x0600C00D RID: 49165 RVA: 0x00059E60 File Offset: 0x00058060
		public unsafe DeliveryReceipt _receipt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__receipt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryReceipt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__receipt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A14 RID: 14868
		// (get) Token: 0x0600C00E RID: 49166 RVA: 0x003112F4 File Offset: 0x0030F4F4
		// (set) Token: 0x0600C00F RID: 49167 RVA: 0x00059E7F File Offset: 0x0005807F
		public unsafe Il2CppReferenceArray<ItemEntryUI> _itemEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__itemEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemEntryUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__itemEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A15 RID: 14869
		// (get) Token: 0x0600C010 RID: 49168 RVA: 0x00311324 File Offset: 0x0030F524
		// (set) Token: 0x0600C011 RID: 49169 RVA: 0x00059E9E File Offset: 0x0005809E
		public unsafe Action<DeliveryReceipt> _onSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__onSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DeliveryReceipt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceiptDisplay.NativeFieldInfoPtr__onSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008353 RID: 33619
		private static readonly IntPtr NativeFieldInfoPtr_ItemEntryPrefab;

		// Token: 0x04008354 RID: 33620
		private static readonly IntPtr NativeFieldInfoPtr__DestinationLabel;

		// Token: 0x04008355 RID: 33621
		private static readonly IntPtr NativeFieldInfoPtr__loadingDockLabel;

		// Token: 0x04008356 RID: 33622
		private static readonly IntPtr NativeFieldInfoPtr__shopLabel;

		// Token: 0x04008357 RID: 33623
		private static readonly IntPtr NativeFieldInfoPtr__shopDescriptionLabel;

		// Token: 0x04008358 RID: 33624
		private static readonly IntPtr NativeFieldInfoPtr__ItemEntryContainer;

		// Token: 0x04008359 RID: 33625
		private static readonly IntPtr NativeFieldInfoPtr__ReorderButton;

		// Token: 0x0400835A RID: 33626
		private static readonly IntPtr NativeFieldInfoPtr__ReorderTooltip;

		// Token: 0x0400835B RID: 33627
		private static readonly IntPtr NativeFieldInfoPtr__reorderPriceLabel;

		// Token: 0x0400835C RID: 33628
		private static readonly IntPtr NativeFieldInfoPtr__maxItemsShown;

		// Token: 0x0400835D RID: 33629
		private static readonly IntPtr NativeFieldInfoPtr__generalColorFont;

		// Token: 0x0400835E RID: 33630
		private static readonly IntPtr NativeFieldInfoPtr__shopTextColorFont;

		// Token: 0x0400835F RID: 33631
		private static readonly IntPtr NativeFieldInfoPtr__selectable;

		// Token: 0x04008360 RID: 33632
		private static readonly IntPtr NativeFieldInfoPtr__receipt;

		// Token: 0x04008361 RID: 33633
		private static readonly IntPtr NativeFieldInfoPtr__itemEntries;

		// Token: 0x04008362 RID: 33634
		private static readonly IntPtr NativeFieldInfoPtr__onSelect;

		// Token: 0x04008363 RID: 33635
		private static readonly IntPtr NativeMethodInfoPtr_get_ReorderButton_Public_get_Button_0;

		// Token: 0x04008364 RID: 33636
		private static readonly IntPtr NativeMethodInfoPtr_get_Receipt_Public_get_DeliveryReceipt_0;

		// Token: 0x04008365 RID: 33637
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_get_UISelectable_0;

		// Token: 0x04008366 RID: 33638
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Void_0;

		// Token: 0x04008367 RID: 33639
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_DeliveryReceipt_Single_Boolean_0;

		// Token: 0x04008368 RID: 33640
		private static readonly IntPtr NativeMethodInfoPtr_SetTooltip_Public_Void_String_0;

		// Token: 0x04008369 RID: 33641
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveTooltip_Public_Void_Boolean_0;

		// Token: 0x0400836A RID: 33642
		private static readonly IntPtr NativeMethodInfoPtr_ForceActiveTooltip_Public_Void_Boolean_0;

		// Token: 0x0400836B RID: 33643
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToOnSelect_Public_Void_Action_1_DeliveryReceipt_0;

		// Token: 0x0400836C RID: 33644
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromOnSelect_Public_Void_Action_1_DeliveryReceipt_0;

		// Token: 0x0400836D RID: 33645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400836E RID: 33646
		private static readonly IntPtr NativeMethodInfoPtr__Initialise_b__22_0_Private_Void_0;

		// Token: 0x0400836F RID: 33647
		private static readonly IntPtr NativeMethodInfoPtr__Initialise_b__22_1_Private_Void_0;

		// Token: 0x04008370 RID: 33648
		private static readonly IntPtr NativeMethodInfoPtr__Initialise_b__22_2_Private_Void_0;
	}
}

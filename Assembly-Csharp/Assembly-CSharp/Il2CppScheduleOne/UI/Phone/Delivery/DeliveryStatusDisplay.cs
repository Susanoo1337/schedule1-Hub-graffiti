using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.Items;
using Il2CppScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020007B4 RID: 1972
	public class DeliveryStatusDisplay : MonoBehaviour
	{
		// Token: 0x0600C065 RID: 49253 RVA: 0x00312510 File Offset: 0x00310710
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryStatusDisplay()
		{
			Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryStatusDisplay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr);
			DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "<DeliveryInstance>k__BackingField");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ItemEntryPrefab");
			DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "DestinationLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr__loadingDockLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "_loadingDockLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ShopLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr__shopDescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "_shopDescriptionLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusImage");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusLabel");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusTooltip");
			DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "ItemEntryContainer");
			DeliveryStatusDisplay.NativeFieldInfoPtr_FlashAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "FlashAnimation");
			DeliveryStatusDisplay.NativeFieldInfoPtr_FlashObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "FlashObject");
			DeliveryStatusDisplay.NativeFieldInfoPtr__maxItemsShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "_maxItemsShown");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Transit");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Waiting");
			DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "StatusColor_Arrived");
			DeliveryStatusDisplay.NativeFieldInfoPtr__selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "_selectable");
			DeliveryStatusDisplay.NativeFieldInfoPtr__shopTextColorFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, "_shopTextColorFont");
			DeliveryStatusDisplay.NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100688380);
			DeliveryStatusDisplay.NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100688381);
			DeliveryStatusDisplay.NativeMethodInfoPtr_get_Selectable_Public_get_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100688382);
			DeliveryStatusDisplay.NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100688383);
			DeliveryStatusDisplay.NativeMethodInfoPtr_RefreshStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100688384);
			DeliveryStatusDisplay.NativeMethodInfoPtr_Flash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100688385);
			DeliveryStatusDisplay.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100688386);
			DeliveryStatusDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr, 100688387);
		}

		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x0600C066 RID: 49254 RVA: 0x00312748 File Offset: 0x00310948
		// (set) Token: 0x0600C067 RID: 49255 RVA: 0x00312788 File Offset: 0x00310988
		public unsafe DeliveryInstance DeliveryInstance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x0600C068 RID: 49256 RVA: 0x003127CC File Offset: 0x003109CC
		public unsafe UISelectable Selectable
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38421, RefRangeEnd = 38424, XrefRangeStart = 38421, XrefRangeEnd = 38424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_get_Selectable_Public_get_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
			}
		}

		// Token: 0x0600C069 RID: 49257 RVA: 0x0031280C File Offset: 0x00310A0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319912, RefRangeEnd = 319913, XrefRangeStart = 319889, XrefRangeEnd = 319912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignDelivery(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C06A RID: 49258 RVA: 0x00312850 File Offset: 0x00310A50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 319925, RefRangeEnd = 319928, XrefRangeStart = 319913, XrefRangeEnd = 319925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_RefreshStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C06B RID: 49259 RVA: 0x00312884 File Offset: 0x00310A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319930, RefRangeEnd = 319931, XrefRangeStart = 319928, XrefRangeEnd = 319930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_Flash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C06C RID: 49260 RVA: 0x003128B8 File Offset: 0x00310AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319931, XrefRangeEnd = 319934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C06D RID: 49261 RVA: 0x003128EC File Offset: 0x00310AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319934, XrefRangeEnd = 319935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryStatusDisplay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryStatusDisplay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryStatusDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C06E RID: 49262 RVA: 0x0005A160 File Offset: 0x00058360
		public DeliveryStatusDisplay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003A33 RID: 14899
		// (get) Token: 0x0600C06F RID: 49263 RVA: 0x00312928 File Offset: 0x00310B28
		// (set) Token: 0x0600C070 RID: 49264 RVA: 0x0005A169 File Offset: 0x00058369
		public unsafe DeliveryInstance _DeliveryInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__DeliveryInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x0600C071 RID: 49265 RVA: 0x00312958 File Offset: 0x00310B58
		// (set) Token: 0x0600C072 RID: 49266 RVA: 0x0005A188 File Offset: 0x00058388
		public unsafe ItemEntryUI ItemEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemEntryUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x0600C073 RID: 49267 RVA: 0x00312988 File Offset: 0x00310B88
		// (set) Token: 0x0600C074 RID: 49268 RVA: 0x0005A1A7 File Offset: 0x000583A7
		public unsafe Text DestinationLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_DestinationLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x0600C075 RID: 49269 RVA: 0x003129B8 File Offset: 0x00310BB8
		// (set) Token: 0x0600C076 RID: 49270 RVA: 0x0005A1C6 File Offset: 0x000583C6
		public unsafe Text _loadingDockLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__loadingDockLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__loadingDockLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x0600C077 RID: 49271 RVA: 0x003129E8 File Offset: 0x00310BE8
		// (set) Token: 0x0600C078 RID: 49272 RVA: 0x0005A1E5 File Offset: 0x000583E5
		public unsafe Text ShopLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ShopLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x0600C079 RID: 49273 RVA: 0x00312A18 File Offset: 0x00310C18
		// (set) Token: 0x0600C07A RID: 49274 RVA: 0x0005A204 File Offset: 0x00058404
		public unsafe Text _shopDescriptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__shopDescriptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__shopDescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x0600C07B RID: 49275 RVA: 0x00312A48 File Offset: 0x00310C48
		// (set) Token: 0x0600C07C RID: 49276 RVA: 0x0005A223 File Offset: 0x00058423
		public unsafe Image StatusImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x0600C07D RID: 49277 RVA: 0x00312A78 File Offset: 0x00310C78
		// (set) Token: 0x0600C07E RID: 49278 RVA: 0x0005A242 File Offset: 0x00058442
		public unsafe Text StatusLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x0600C07F RID: 49279 RVA: 0x00312AA8 File Offset: 0x00310CA8
		// (set) Token: 0x0600C080 RID: 49280 RVA: 0x0005A261 File Offset: 0x00058461
		public unsafe Tooltip StatusTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x0600C081 RID: 49281 RVA: 0x00312AD8 File Offset: 0x00310CD8
		// (set) Token: 0x0600C082 RID: 49282 RVA: 0x0005A280 File Offset: 0x00058480
		public unsafe RectTransform ItemEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_ItemEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x0600C083 RID: 49283 RVA: 0x00312B08 File Offset: 0x00310D08
		// (set) Token: 0x0600C084 RID: 49284 RVA: 0x0005A29F File Offset: 0x0005849F
		public unsafe Animation FlashAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_FlashAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_FlashAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x0600C085 RID: 49285 RVA: 0x00312B38 File Offset: 0x00310D38
		// (set) Token: 0x0600C086 RID: 49286 RVA: 0x0005A2BE File Offset: 0x000584BE
		public unsafe GameObject FlashObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_FlashObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_FlashObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A3F RID: 14911
		// (get) Token: 0x0600C087 RID: 49287 RVA: 0x00312B68 File Offset: 0x00310D68
		// (set) Token: 0x0600C088 RID: 49288 RVA: 0x0005A2DD File Offset: 0x000584DD
		public unsafe int _maxItemsShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__maxItemsShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__maxItemsShown)) = value;
			}
		}

		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x0600C089 RID: 49289 RVA: 0x00312B90 File Offset: 0x00310D90
		// (set) Token: 0x0600C08A RID: 49290 RVA: 0x0005A2F8 File Offset: 0x000584F8
		public unsafe Color StatusColor_Transit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Transit)) = value;
			}
		}

		// Token: 0x17003A41 RID: 14913
		// (get) Token: 0x0600C08B RID: 49291 RVA: 0x00312BB8 File Offset: 0x00310DB8
		// (set) Token: 0x0600C08C RID: 49292 RVA: 0x0005A313 File Offset: 0x00058513
		public unsafe Color StatusColor_Waiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Waiting)) = value;
			}
		}

		// Token: 0x17003A42 RID: 14914
		// (get) Token: 0x0600C08D RID: 49293 RVA: 0x00312BE0 File Offset: 0x00310DE0
		// (set) Token: 0x0600C08E RID: 49294 RVA: 0x0005A32E File Offset: 0x0005852E
		public unsafe Color StatusColor_Arrived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr_StatusColor_Arrived)) = value;
			}
		}

		// Token: 0x17003A43 RID: 14915
		// (get) Token: 0x0600C08F RID: 49295 RVA: 0x00312C08 File Offset: 0x00310E08
		// (set) Token: 0x0600C090 RID: 49296 RVA: 0x0005A349 File Offset: 0x00058549
		public unsafe UISelectable _selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A44 RID: 14916
		// (get) Token: 0x0600C091 RID: 49297 RVA: 0x00312C38 File Offset: 0x00310E38
		// (set) Token: 0x0600C092 RID: 49298 RVA: 0x0005A368 File Offset: 0x00058568
		public unsafe ColorFont _shopTextColorFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__shopTextColorFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryStatusDisplay.NativeFieldInfoPtr__shopTextColorFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040083AC RID: 33708
		private static readonly IntPtr NativeFieldInfoPtr__DeliveryInstance_k__BackingField;

		// Token: 0x040083AD RID: 33709
		private static readonly IntPtr NativeFieldInfoPtr_ItemEntryPrefab;

		// Token: 0x040083AE RID: 33710
		private static readonly IntPtr NativeFieldInfoPtr_DestinationLabel;

		// Token: 0x040083AF RID: 33711
		private static readonly IntPtr NativeFieldInfoPtr__loadingDockLabel;

		// Token: 0x040083B0 RID: 33712
		private static readonly IntPtr NativeFieldInfoPtr_ShopLabel;

		// Token: 0x040083B1 RID: 33713
		private static readonly IntPtr NativeFieldInfoPtr__shopDescriptionLabel;

		// Token: 0x040083B2 RID: 33714
		private static readonly IntPtr NativeFieldInfoPtr_StatusImage;

		// Token: 0x040083B3 RID: 33715
		private static readonly IntPtr NativeFieldInfoPtr_StatusLabel;

		// Token: 0x040083B4 RID: 33716
		private static readonly IntPtr NativeFieldInfoPtr_StatusTooltip;

		// Token: 0x040083B5 RID: 33717
		private static readonly IntPtr NativeFieldInfoPtr_ItemEntryContainer;

		// Token: 0x040083B6 RID: 33718
		private static readonly IntPtr NativeFieldInfoPtr_FlashAnimation;

		// Token: 0x040083B7 RID: 33719
		private static readonly IntPtr NativeFieldInfoPtr_FlashObject;

		// Token: 0x040083B8 RID: 33720
		private static readonly IntPtr NativeFieldInfoPtr__maxItemsShown;

		// Token: 0x040083B9 RID: 33721
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Transit;

		// Token: 0x040083BA RID: 33722
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Waiting;

		// Token: 0x040083BB RID: 33723
		private static readonly IntPtr NativeFieldInfoPtr_StatusColor_Arrived;

		// Token: 0x040083BC RID: 33724
		private static readonly IntPtr NativeFieldInfoPtr__selectable;

		// Token: 0x040083BD RID: 33725
		private static readonly IntPtr NativeFieldInfoPtr__shopTextColorFont;

		// Token: 0x040083BE RID: 33726
		private static readonly IntPtr NativeMethodInfoPtr_get_DeliveryInstance_Public_get_DeliveryInstance_0;

		// Token: 0x040083BF RID: 33727
		private static readonly IntPtr NativeMethodInfoPtr_set_DeliveryInstance_Private_set_Void_DeliveryInstance_0;

		// Token: 0x040083C0 RID: 33728
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_get_UISelectable_0;

		// Token: 0x040083C1 RID: 33729
		private static readonly IntPtr NativeMethodInfoPtr_AssignDelivery_Public_Void_DeliveryInstance_0;

		// Token: 0x040083C2 RID: 33730
		private static readonly IntPtr NativeMethodInfoPtr_RefreshStatus_Public_Void_0;

		// Token: 0x040083C3 RID: 33731
		private static readonly IntPtr NativeMethodInfoPtr_Flash_Public_Void_0;

		// Token: 0x040083C4 RID: 33732
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040083C5 RID: 33733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GamepadInput;
using Il2CppScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020007B5 RID: 1973
	public class ListingEntry : MonoBehaviour
	{
		// Token: 0x0600C093 RID: 49299 RVA: 0x00312C68 File Offset: 0x00310E68
		// Note: this type is marked as 'beforefieldinit'.
		static ListingEntry()
		{
			Il2CppClassPointerStore<ListingEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "ListingEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr);
			ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "<MatchingListing>k__BackingField");
			ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "<SelectedQuantity>k__BackingField");
			ListingEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "Icon");
			ListingEntry.NativeFieldInfoPtr_ItemNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "ItemNameLabel");
			ListingEntry.NativeFieldInfoPtr_ItemPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "ItemPriceLabel");
			ListingEntry.NativeFieldInfoPtr_QuantityInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "QuantityInput");
			ListingEntry.NativeFieldInfoPtr_IncrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "IncrementButton");
			ListingEntry.NativeFieldInfoPtr_DecrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "DecrementButton");
			ListingEntry.NativeFieldInfoPtr_LockedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "LockedContainer");
			ListingEntry.NativeFieldInfoPtr_onQuantityChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "onQuantityChanged");
			ListingEntry.NativeFieldInfoPtr__inputValueRamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, "_inputValueRamp");
			ListingEntry.NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688388);
			ListingEntry.NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688389);
			ListingEntry.NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688390);
			ListingEntry.NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688391);
			ListingEntry.NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688392);
			ListingEntry.NativeMethodInfoPtr_RefreshLocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688393);
			ListingEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688394);
			ListingEntry.NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688395);
			ListingEntry.NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688396);
			ListingEntry.NativeMethodInfoPtr_ValidateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688397);
			ListingEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688398);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688399);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688400);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688401);
			ListingEntry.NativeMethodInfoPtr__Initialize_b__17_3_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr, 100688402);
		}

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x0600C094 RID: 49300 RVA: 0x00312EA0 File Offset: 0x003110A0
		// (set) Token: 0x0600C095 RID: 49301 RVA: 0x00312EE0 File Offset: 0x003110E0
		public unsafe ShopListing MatchingListing
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003A53 RID: 14931
		// (get) Token: 0x0600C096 RID: 49302 RVA: 0x00312F24 File Offset: 0x00311124
		// (set) Token: 0x0600C097 RID: 49303 RVA: 0x00312F60 File Offset: 0x00311160
		public unsafe int SelectedQuantity
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 29072, RefRangeEnd = 29101, XrefRangeStart = 29072, XrefRangeEnd = 29101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29101, RefRangeEnd = 29102, XrefRangeStart = 29101, XrefRangeEnd = 29102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C098 RID: 49304 RVA: 0x00312FA0 File Offset: 0x003111A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319990, RefRangeEnd = 319991, XrefRangeStart = 319935, XrefRangeEnd = 319990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ShopListing match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C099 RID: 49305 RVA: 0x00312FE4 File Offset: 0x003111E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319991, XrefRangeEnd = 319997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_RefreshLocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C09A RID: 49306 RVA: 0x00313018 File Offset: 0x00311218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320002, RefRangeEnd = 320003, XrefRangeStart = 319997, XrefRangeEnd = 320002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int quant, bool notify = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quant;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C09B RID: 49307 RVA: 0x00313064 File Offset: 0x00311264
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 320008, RefRangeEnd = 320011, XrefRangeStart = 320003, XrefRangeEnd = 320008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C09C RID: 49308 RVA: 0x003130A4 File Offset: 0x003112A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320011, XrefRangeEnd = 320016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnQuantityInputSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C09D RID: 49309 RVA: 0x003130E8 File Offset: 0x003112E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320016, XrefRangeEnd = 320025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr_ValidateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C09E RID: 49310 RVA: 0x0031311C File Offset: 0x0031131C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListingEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListingEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C09F RID: 49311 RVA: 0x00313158 File Offset: 0x00311358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320025, XrefRangeEnd = 320034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_0(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0A0 RID: 49312 RVA: 0x0031319C File Offset: 0x0031139C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320034, XrefRangeEnd = 320035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0A1 RID: 49313 RVA: 0x003131D0 File Offset: 0x003113D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320035, XrefRangeEnd = 320036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0A2 RID: 49314 RVA: 0x00313204 File Offset: 0x00311404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320036, XrefRangeEnd = 320037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__17_3(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingEntry.NativeMethodInfoPtr__Initialize_b__17_3_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0A3 RID: 49315 RVA: 0x0005A387 File Offset: 0x00058587
		public ListingEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x0600C0A4 RID: 49316 RVA: 0x00313244 File Offset: 0x00311444
		// (set) Token: 0x0600C0A5 RID: 49317 RVA: 0x0005A390 File Offset: 0x00058590
		public unsafe ShopListing _MatchingListing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__MatchingListing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x0600C0A6 RID: 49318 RVA: 0x00313274 File Offset: 0x00311474
		// (set) Token: 0x0600C0A7 RID: 49319 RVA: 0x0005A3AF File Offset: 0x000585AF
		public unsafe int _SelectedQuantity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__SelectedQuantity_k__BackingField)) = value;
			}
		}

		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x0600C0A8 RID: 49320 RVA: 0x0031329C File Offset: 0x0031149C
		// (set) Token: 0x0600C0A9 RID: 49321 RVA: 0x0005A3CA File Offset: 0x000585CA
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x0600C0AA RID: 49322 RVA: 0x003132CC File Offset: 0x003114CC
		// (set) Token: 0x0600C0AB RID: 49323 RVA: 0x0005A3E9 File Offset: 0x000585E9
		public unsafe Text ItemNameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemNameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x0600C0AC RID: 49324 RVA: 0x003132FC File Offset: 0x003114FC
		// (set) Token: 0x0600C0AD RID: 49325 RVA: 0x0005A408 File Offset: 0x00058608
		public unsafe Text ItemPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_ItemPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A4C RID: 14924
		// (get) Token: 0x0600C0AE RID: 49326 RVA: 0x0031332C File Offset: 0x0031152C
		// (set) Token: 0x0600C0AF RID: 49327 RVA: 0x0005A427 File Offset: 0x00058627
		public unsafe InputField QuantityInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_QuantityInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_QuantityInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A4D RID: 14925
		// (get) Token: 0x0600C0B0 RID: 49328 RVA: 0x0031335C File Offset: 0x0031155C
		// (set) Token: 0x0600C0B1 RID: 49329 RVA: 0x0005A446 File Offset: 0x00058646
		public unsafe Button IncrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_IncrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_IncrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x0600C0B2 RID: 49330 RVA: 0x0031338C File Offset: 0x0031158C
		// (set) Token: 0x0600C0B3 RID: 49331 RVA: 0x0005A465 File Offset: 0x00058665
		public unsafe Button DecrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_DecrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_DecrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x0600C0B4 RID: 49332 RVA: 0x003133BC File Offset: 0x003115BC
		// (set) Token: 0x0600C0B5 RID: 49333 RVA: 0x0005A484 File Offset: 0x00058684
		public unsafe RectTransform LockedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_LockedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_LockedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x0600C0B6 RID: 49334 RVA: 0x003133EC File Offset: 0x003115EC
		// (set) Token: 0x0600C0B7 RID: 49335 RVA: 0x0005A4A3 File Offset: 0x000586A3
		public unsafe UnityEvent onQuantityChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_onQuantityChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr_onQuantityChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x0600C0B8 RID: 49336 RVA: 0x0031341C File Offset: 0x0031161C
		// (set) Token: 0x0600C0B9 RID: 49337 RVA: 0x0005A4C2 File Offset: 0x000586C2
		public unsafe InputValueRamp _inputValueRamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__inputValueRamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputValueRamp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingEntry.NativeFieldInfoPtr__inputValueRamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040083C6 RID: 33734
		private static readonly IntPtr NativeFieldInfoPtr__MatchingListing_k__BackingField;

		// Token: 0x040083C7 RID: 33735
		private static readonly IntPtr NativeFieldInfoPtr__SelectedQuantity_k__BackingField;

		// Token: 0x040083C8 RID: 33736
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x040083C9 RID: 33737
		private static readonly IntPtr NativeFieldInfoPtr_ItemNameLabel;

		// Token: 0x040083CA RID: 33738
		private static readonly IntPtr NativeFieldInfoPtr_ItemPriceLabel;

		// Token: 0x040083CB RID: 33739
		private static readonly IntPtr NativeFieldInfoPtr_QuantityInput;

		// Token: 0x040083CC RID: 33740
		private static readonly IntPtr NativeFieldInfoPtr_IncrementButton;

		// Token: 0x040083CD RID: 33741
		private static readonly IntPtr NativeFieldInfoPtr_DecrementButton;

		// Token: 0x040083CE RID: 33742
		private static readonly IntPtr NativeFieldInfoPtr_LockedContainer;

		// Token: 0x040083CF RID: 33743
		private static readonly IntPtr NativeFieldInfoPtr_onQuantityChanged;

		// Token: 0x040083D0 RID: 33744
		private static readonly IntPtr NativeFieldInfoPtr__inputValueRamp;

		// Token: 0x040083D1 RID: 33745
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchingListing_Public_get_ShopListing_0;

		// Token: 0x040083D2 RID: 33746
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchingListing_Private_set_Void_ShopListing_0;

		// Token: 0x040083D3 RID: 33747
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedQuantity_Public_get_Int32_0;

		// Token: 0x040083D4 RID: 33748
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedQuantity_Private_set_Void_Int32_0;

		// Token: 0x040083D5 RID: 33749
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ShopListing_0;

		// Token: 0x040083D6 RID: 33750
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLocked_Public_Void_0;

		// Token: 0x040083D7 RID: 33751
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x040083D8 RID: 33752
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Private_Void_Int32_0;

		// Token: 0x040083D9 RID: 33753
		private static readonly IntPtr NativeMethodInfoPtr_OnQuantityInputSubmitted_Private_Void_String_0;

		// Token: 0x040083DA RID: 33754
		private static readonly IntPtr NativeMethodInfoPtr_ValidateInput_Private_Void_0;

		// Token: 0x040083DB RID: 33755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040083DC RID: 33756
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_0_Private_Void_String_0;

		// Token: 0x040083DD RID: 33757
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_1_Private_Void_0;

		// Token: 0x040083DE RID: 33758
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_2_Private_Void_0;

		// Token: 0x040083DF RID: 33759
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_3_Private_Void_Single_0;
	}
}

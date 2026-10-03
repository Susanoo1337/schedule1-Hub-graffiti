using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Events;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x02000570 RID: 1392
	public class ProductEntry : MonoBehaviour
	{
		// Token: 0x06007EF2 RID: 32498 RVA: 0x0022FE5C File Offset: 0x0022E05C
		// Note: this type is marked as 'beforefieldinit'.
		static ProductEntry()
		{
			Il2CppClassPointerStore<ProductEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr);
			ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "<Definition>k__BackingField");
			ProductEntry.NativeFieldInfoPtr_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "SelectedColor");
			ProductEntry.NativeFieldInfoPtr_DeselectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "DeselectedColor");
			ProductEntry.NativeFieldInfoPtr_FavouritedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouritedColor");
			ProductEntry.NativeFieldInfoPtr_UnfavouritedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "UnfavouritedColor");
			ProductEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Button");
			ProductEntry.NativeFieldInfoPtr_Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Frame");
			ProductEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Icon");
			ProductEntry.NativeFieldInfoPtr_Tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Tick");
			ProductEntry.NativeFieldInfoPtr_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Cross");
			ProductEntry.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Trigger");
			ProductEntry.NativeFieldInfoPtr_FavouriteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouriteButton");
			ProductEntry.NativeFieldInfoPtr_ListingButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "ListingButton");
			ProductEntry.NativeFieldInfoPtr_MoveToDetailsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "MoveToDetailsButton");
			ProductEntry.NativeFieldInfoPtr_FavouriteIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouriteIcon");
			ProductEntry.NativeFieldInfoPtr_Outline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Outline");
			ProductEntry.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "onHovered");
			ProductEntry.NativeFieldInfoPtr_destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "destroyed");
			ProductEntry.NativeFieldInfoPtr_onListed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "onListed");
			ProductEntry.NativeFieldInfoPtr__onMovedToDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "_onMovedToDetails");
			ProductEntry.NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679690);
			ProductEntry.NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679691);
			ProductEntry.NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679692);
			ProductEntry.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679693);
			ProductEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679694);
			ProductEntry.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679695);
			ProductEntry.NativeMethodInfoPtr_FavouriteClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679696);
			ProductEntry.NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679697);
			ProductEntry.NativeMethodInfoPtr_UpdateListed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679698);
			ProductEntry.NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679699);
			ProductEntry.NativeMethodInfoPtr_UpdateFavourited_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679700);
			ProductEntry.NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679701);
			ProductEntry.NativeMethodInfoPtr_SetSelection_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679702);
			ProductEntry.NativeMethodInfoPtr_ListProductEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679703);
			ProductEntry.NativeMethodInfoPtr_SubscribeToListed_Public_Void_Action_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679704);
			ProductEntry.NativeMethodInfoPtr_UnsubscribeFromListed_Public_Void_Action_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679705);
			ProductEntry.NativeMethodInfoPtr_SubscribeToMoveToDetails_Public_Void_BasicEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679706);
			ProductEntry.NativeMethodInfoPtr_UnsubscribeFromMoveToDetails_Public_Void_BasicEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679707);
			ProductEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679708);
			ProductEntry.NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679709);
			ProductEntry.NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679710);
		}

		// Token: 0x17002741 RID: 10049
		// (get) Token: 0x06007EF3 RID: 32499 RVA: 0x002301C0 File Offset: 0x0022E3C0
		// (set) Token: 0x06007EF4 RID: 32500 RVA: 0x00230200 File Offset: 0x0022E400
		public unsafe ProductDefinition Definition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007EF5 RID: 32501 RVA: 0x00230244 File Offset: 0x0022E444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242846, RefRangeEnd = 242848, XrefRangeStart = 242710, XrefRangeEnd = 242846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EF6 RID: 32502 RVA: 0x00230288 File Offset: 0x0022E488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 242856, RefRangeEnd = 242857, XrefRangeStart = 242848, XrefRangeEnd = 242856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EF7 RID: 32503 RVA: 0x002302BC File Offset: 0x0022E4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242857, XrefRangeEnd = 242935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EF8 RID: 32504 RVA: 0x002302F0 File Offset: 0x0022E4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242935, XrefRangeEnd = 242942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EF9 RID: 32505 RVA: 0x00230324 File Offset: 0x0022E524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242942, XrefRangeEnd = 242958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FavouriteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_FavouriteClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EFA RID: 32506 RVA: 0x00230358 File Offset: 0x0022E558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242958, XrefRangeEnd = 242963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductListedOrDelisted(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x0023039C File Offset: 0x0022E59C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 242982, RefRangeEnd = 242988, XrefRangeStart = 242963, XrefRangeEnd = 242982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateListed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateListed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EFC RID: 32508 RVA: 0x002303D0 File Offset: 0x0022E5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242988, XrefRangeEnd = 242993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductFavouritedOrUnFavourited(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EFD RID: 32509 RVA: 0x00230414 File Offset: 0x0022E614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243008, RefRangeEnd = 243010, XrefRangeStart = 242993, XrefRangeEnd = 243008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFavourited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateFavourited_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EFE RID: 32510 RVA: 0x00230448 File Offset: 0x0022E648
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243032, RefRangeEnd = 243035, XrefRangeStart = 243010, XrefRangeEnd = 243032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDiscovered(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007EFF RID: 32511 RVA: 0x0023048C File Offset: 0x0022E68C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 243037, RefRangeEnd = 243040, XrefRangeStart = 243035, XrefRangeEnd = 243037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelection(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_SetSelection_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F00 RID: 32512 RVA: 0x002304CC File Offset: 0x0022E6CC
		[CallerCount(0)]
		public unsafe void ListProductEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_ListProductEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x00230500 File Offset: 0x0022E700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243050, RefRangeEnd = 243052, XrefRangeStart = 243040, XrefRangeEnd = 243050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToListed(Action<ProductDefinition> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_SubscribeToListed_Public_Void_Action_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F02 RID: 32514 RVA: 0x00230544 File Offset: 0x0022E744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243062, RefRangeEnd = 243063, XrefRangeStart = 243052, XrefRangeEnd = 243062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromListed(Action<ProductDefinition> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UnsubscribeFromListed_Public_Void_Action_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F03 RID: 32515 RVA: 0x00230588 File Offset: 0x0022E788
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243071, RefRangeEnd = 243073, XrefRangeStart = 243063, XrefRangeEnd = 243071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToMoveToDetails(BasicEvent callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_SubscribeToMoveToDetails_Public_Void_BasicEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x002305CC File Offset: 0x0022E7CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243081, RefRangeEnd = 243082, XrefRangeStart = 243073, XrefRangeEnd = 243081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromMoveToDetails(BasicEvent callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UnsubscribeFromMoveToDetails_Public_Void_BasicEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F05 RID: 32517 RVA: 0x00230610 File Offset: 0x0022E810
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x0023064C File Offset: 0x0022E84C
		[CallerCount(0)]
		public unsafe void _Initialize_b__23_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F07 RID: 32519 RVA: 0x00230680 File Offset: 0x0022E880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243082, XrefRangeEnd = 243084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__23_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F08 RID: 32520 RVA: 0x0003C31B File Offset: 0x0003A51B
		public ProductEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700272D RID: 10029
		// (get) Token: 0x06007F09 RID: 32521 RVA: 0x002306C4 File Offset: 0x0022E8C4
		// (set) Token: 0x06007F0A RID: 32522 RVA: 0x0003C324 File Offset: 0x0003A524
		public unsafe ProductDefinition _Definition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700272E RID: 10030
		// (get) Token: 0x06007F0B RID: 32523 RVA: 0x002306F4 File Offset: 0x0022E8F4
		// (set) Token: 0x06007F0C RID: 32524 RVA: 0x0003C343 File Offset: 0x0003A543
		public unsafe Color SelectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_SelectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_SelectedColor)) = value;
			}
		}

		// Token: 0x1700272F RID: 10031
		// (get) Token: 0x06007F0D RID: 32525 RVA: 0x0023071C File Offset: 0x0022E91C
		// (set) Token: 0x06007F0E RID: 32526 RVA: 0x0003C35E File Offset: 0x0003A55E
		public unsafe Color DeselectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_DeselectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_DeselectedColor)) = value;
			}
		}

		// Token: 0x17002730 RID: 10032
		// (get) Token: 0x06007F0F RID: 32527 RVA: 0x00230744 File Offset: 0x0022E944
		// (set) Token: 0x06007F10 RID: 32528 RVA: 0x0003C379 File Offset: 0x0003A579
		public unsafe Color FavouritedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouritedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouritedColor)) = value;
			}
		}

		// Token: 0x17002731 RID: 10033
		// (get) Token: 0x06007F11 RID: 32529 RVA: 0x0023076C File Offset: 0x0022E96C
		// (set) Token: 0x06007F12 RID: 32530 RVA: 0x0003C394 File Offset: 0x0003A594
		public unsafe Color UnfavouritedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_UnfavouritedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_UnfavouritedColor)) = value;
			}
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x06007F13 RID: 32531 RVA: 0x00230794 File Offset: 0x0022E994
		// (set) Token: 0x06007F14 RID: 32532 RVA: 0x0003C3AF File Offset: 0x0003A5AF
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x06007F15 RID: 32533 RVA: 0x002307C4 File Offset: 0x0022E9C4
		// (set) Token: 0x06007F16 RID: 32534 RVA: 0x0003C3CE File Offset: 0x0003A5CE
		public unsafe Image Frame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Frame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Frame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x06007F17 RID: 32535 RVA: 0x002307F4 File Offset: 0x0022E9F4
		// (set) Token: 0x06007F18 RID: 32536 RVA: 0x0003C3ED File Offset: 0x0003A5ED
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x06007F19 RID: 32537 RVA: 0x00230824 File Offset: 0x0022EA24
		// (set) Token: 0x06007F1A RID: 32538 RVA: 0x0003C40C File Offset: 0x0003A60C
		public unsafe RectTransform Tick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Tick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Tick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x06007F1B RID: 32539 RVA: 0x00230854 File Offset: 0x0022EA54
		// (set) Token: 0x06007F1C RID: 32540 RVA: 0x0003C42B File Offset: 0x0003A62B
		public unsafe RectTransform Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x06007F1D RID: 32541 RVA: 0x00230884 File Offset: 0x0022EA84
		// (set) Token: 0x06007F1E RID: 32542 RVA: 0x0003C44A File Offset: 0x0003A64A
		public unsafe EventTrigger Trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002738 RID: 10040
		// (get) Token: 0x06007F1F RID: 32543 RVA: 0x002308B4 File Offset: 0x0022EAB4
		// (set) Token: 0x06007F20 RID: 32544 RVA: 0x0003C469 File Offset: 0x0003A669
		public unsafe Button FavouriteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002739 RID: 10041
		// (get) Token: 0x06007F21 RID: 32545 RVA: 0x002308E4 File Offset: 0x0022EAE4
		// (set) Token: 0x06007F22 RID: 32546 RVA: 0x0003C488 File Offset: 0x0003A688
		public unsafe Button ListingButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_ListingButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_ListingButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x06007F23 RID: 32547 RVA: 0x00230914 File Offset: 0x0022EB14
		// (set) Token: 0x06007F24 RID: 32548 RVA: 0x0003C4A7 File Offset: 0x0003A6A7
		public unsafe Button MoveToDetailsButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_MoveToDetailsButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_MoveToDetailsButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x06007F25 RID: 32549 RVA: 0x00230944 File Offset: 0x0022EB44
		// (set) Token: 0x06007F26 RID: 32550 RVA: 0x0003C4C6 File Offset: 0x0003A6C6
		public unsafe Image FavouriteIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x06007F27 RID: 32551 RVA: 0x00230974 File Offset: 0x0022EB74
		// (set) Token: 0x06007F28 RID: 32552 RVA: 0x0003C4E5 File Offset: 0x0003A6E5
		public unsafe GameObject Outline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Outline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Outline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x06007F29 RID: 32553 RVA: 0x002309A4 File Offset: 0x0022EBA4
		// (set) Token: 0x06007F2A RID: 32554 RVA: 0x0003C504 File Offset: 0x0003A704
		public unsafe UnityEvent onHovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_onHovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x06007F2B RID: 32555 RVA: 0x002309D4 File Offset: 0x0022EBD4
		// (set) Token: 0x06007F2C RID: 32556 RVA: 0x0003C523 File Offset: 0x0003A723
		public unsafe bool destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_destroyed)) = value;
			}
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x06007F2D RID: 32557 RVA: 0x002309FC File Offset: 0x0022EBFC
		// (set) Token: 0x06007F2E RID: 32558 RVA: 0x0003C53E File Offset: 0x0003A73E
		public unsafe Action<ProductDefinition> onListed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_onListed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_onListed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002740 RID: 10048
		// (get) Token: 0x06007F2F RID: 32559 RVA: 0x00230A2C File Offset: 0x0022EC2C
		// (set) Token: 0x06007F30 RID: 32560 RVA: 0x0003C55D File Offset: 0x0003A75D
		public unsafe BasicEvent _onMovedToDetails
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr__onMovedToDetails);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr__onMovedToDetails), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040056AE RID: 22190
		private static readonly IntPtr NativeFieldInfoPtr__Definition_k__BackingField;

		// Token: 0x040056AF RID: 22191
		private static readonly IntPtr NativeFieldInfoPtr_SelectedColor;

		// Token: 0x040056B0 RID: 22192
		private static readonly IntPtr NativeFieldInfoPtr_DeselectedColor;

		// Token: 0x040056B1 RID: 22193
		private static readonly IntPtr NativeFieldInfoPtr_FavouritedColor;

		// Token: 0x040056B2 RID: 22194
		private static readonly IntPtr NativeFieldInfoPtr_UnfavouritedColor;

		// Token: 0x040056B3 RID: 22195
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040056B4 RID: 22196
		private static readonly IntPtr NativeFieldInfoPtr_Frame;

		// Token: 0x040056B5 RID: 22197
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x040056B6 RID: 22198
		private static readonly IntPtr NativeFieldInfoPtr_Tick;

		// Token: 0x040056B7 RID: 22199
		private static readonly IntPtr NativeFieldInfoPtr_Cross;

		// Token: 0x040056B8 RID: 22200
		private static readonly IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x040056B9 RID: 22201
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteButton;

		// Token: 0x040056BA RID: 22202
		private static readonly IntPtr NativeFieldInfoPtr_ListingButton;

		// Token: 0x040056BB RID: 22203
		private static readonly IntPtr NativeFieldInfoPtr_MoveToDetailsButton;

		// Token: 0x040056BC RID: 22204
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteIcon;

		// Token: 0x040056BD RID: 22205
		private static readonly IntPtr NativeFieldInfoPtr_Outline;

		// Token: 0x040056BE RID: 22206
		private static readonly IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x040056BF RID: 22207
		private static readonly IntPtr NativeFieldInfoPtr_destroyed;

		// Token: 0x040056C0 RID: 22208
		private static readonly IntPtr NativeFieldInfoPtr_onListed;

		// Token: 0x040056C1 RID: 22209
		private static readonly IntPtr NativeFieldInfoPtr__onMovedToDetails;

		// Token: 0x040056C2 RID: 22210
		private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0;

		// Token: 0x040056C3 RID: 22211
		private static readonly IntPtr NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0;

		// Token: 0x040056C4 RID: 22212
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0;

		// Token: 0x040056C5 RID: 22213
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040056C6 RID: 22214
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040056C7 RID: 22215
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x040056C8 RID: 22216
		private static readonly IntPtr NativeMethodInfoPtr_FavouriteClicked_Public_Void_0;

		// Token: 0x040056C9 RID: 22217
		private static readonly IntPtr NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0;

		// Token: 0x040056CA RID: 22218
		private static readonly IntPtr NativeMethodInfoPtr_UpdateListed_Public_Void_0;

		// Token: 0x040056CB RID: 22219
		private static readonly IntPtr NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0;

		// Token: 0x040056CC RID: 22220
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFavourited_Public_Void_0;

		// Token: 0x040056CD RID: 22221
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0;

		// Token: 0x040056CE RID: 22222
		private static readonly IntPtr NativeMethodInfoPtr_SetSelection_Public_Void_Boolean_0;

		// Token: 0x040056CF RID: 22223
		private static readonly IntPtr NativeMethodInfoPtr_ListProductEvent_Private_Void_0;

		// Token: 0x040056D0 RID: 22224
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToListed_Public_Void_Action_1_ProductDefinition_0;

		// Token: 0x040056D1 RID: 22225
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromListed_Public_Void_Action_1_ProductDefinition_0;

		// Token: 0x040056D2 RID: 22226
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToMoveToDetails_Public_Void_BasicEvent_0;

		// Token: 0x040056D3 RID: 22227
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromMoveToDetails_Public_Void_BasicEvent_0;

		// Token: 0x040056D4 RID: 22228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040056D5 RID: 22229
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__23_0_Private_Void_0;

		// Token: 0x040056D6 RID: 22230
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__23_1_Private_Void_BaseEventData_0;
	}
}

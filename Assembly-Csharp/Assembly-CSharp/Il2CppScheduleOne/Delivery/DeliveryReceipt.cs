using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200041B RID: 1051
	[Serializable]
	public class DeliveryReceipt : Object
	{
		// Token: 0x06005CCF RID: 23759 RVA: 0x001BB530 File Offset: 0x001B9730
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryReceipt()
		{
			Il2CppClassPointerStore<DeliveryReceipt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryReceipt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryReceipt>.NativeClassPtr);
			DeliveryReceipt.NativeFieldInfoPtr_DeliveryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceipt>.NativeClassPtr, "DeliveryID");
			DeliveryReceipt.NativeFieldInfoPtr_StoreName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceipt>.NativeClassPtr, "StoreName");
			DeliveryReceipt.NativeFieldInfoPtr_DestinationCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceipt>.NativeClassPtr, "DestinationCode");
			DeliveryReceipt.NativeFieldInfoPtr_LoadingDockIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceipt>.NativeClassPtr, "LoadingDockIndex");
			DeliveryReceipt.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryReceipt>.NativeClassPtr, "Items");
			DeliveryReceipt.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceipt>.NativeClassPtr, 100675428);
			DeliveryReceipt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryReceipt>.NativeClassPtr, 100675429);
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x001BB5EC File Offset: 0x001B97EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199187, XrefRangeEnd = 199192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryReceipt(string deliveryID, string storeName, string destinationCode, int loadingDockIndex, Il2CppReferenceArray<StringIntPair> items) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(destinationCode);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadingDockIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceipt.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x001BB67C File Offset: 0x001B987C
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryReceipt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryReceipt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x0002BF52 File Offset: 0x0002A152
		public DeliveryReceipt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06005CD3 RID: 23763 RVA: 0x001BB6B8 File Offset: 0x001B98B8
		// (set) Token: 0x06005CD4 RID: 23764 RVA: 0x0002BF5B File Offset: 0x0002A15B
		public unsafe string DeliveryID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceipt.NativeFieldInfoPtr_DeliveryID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceipt.NativeFieldInfoPtr_DeliveryID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06005CD5 RID: 23765 RVA: 0x001BB6E0 File Offset: 0x001B98E0
		// (set) Token: 0x06005CD6 RID: 23766 RVA: 0x0002BF7A File Offset: 0x0002A17A
		public unsafe string StoreName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceipt.NativeFieldInfoPtr_StoreName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceipt.NativeFieldInfoPtr_StoreName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06005CD7 RID: 23767 RVA: 0x001BB708 File Offset: 0x001B9908
		// (set) Token: 0x06005CD8 RID: 23768 RVA: 0x0002BF99 File Offset: 0x0002A199
		public unsafe string DestinationCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceipt.NativeFieldInfoPtr_DestinationCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceipt.NativeFieldInfoPtr_DestinationCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06005CD9 RID: 23769 RVA: 0x001BB730 File Offset: 0x001B9930
		// (set) Token: 0x06005CDA RID: 23770 RVA: 0x0002BFB8 File Offset: 0x0002A1B8
		public unsafe int LoadingDockIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceipt.NativeFieldInfoPtr_LoadingDockIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceipt.NativeFieldInfoPtr_LoadingDockIndex)) = value;
			}
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x06005CDB RID: 23771 RVA: 0x001BB758 File Offset: 0x001B9958
		// (set) Token: 0x06005CDC RID: 23772 RVA: 0x0002BFD3 File Offset: 0x0002A1D3
		public unsafe Il2CppReferenceArray<StringIntPair> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceipt.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryReceipt.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FB1 RID: 16305
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryID;

		// Token: 0x04003FB2 RID: 16306
		private static readonly IntPtr NativeFieldInfoPtr_StoreName;

		// Token: 0x04003FB3 RID: 16307
		private static readonly IntPtr NativeFieldInfoPtr_DestinationCode;

		// Token: 0x04003FB4 RID: 16308
		private static readonly IntPtr NativeFieldInfoPtr_LoadingDockIndex;

		// Token: 0x04003FB5 RID: 16309
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04003FB6 RID: 16310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Int32_Il2CppReferenceArray_1_StringIntPair_0;

		// Token: 0x04003FB7 RID: 16311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

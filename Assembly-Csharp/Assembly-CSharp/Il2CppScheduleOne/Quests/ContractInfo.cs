using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Product;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200013D RID: 317
	[Serializable]
	public class ContractInfo : Object
	{
		// Token: 0x06001FC4 RID: 8132 RVA: 0x000E3224 File Offset: 0x000E1424
		// Note: this type is marked as 'beforefieldinit'.
		static ContractInfo()
		{
			Il2CppClassPointerStore<ContractInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "ContractInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr);
			ContractInfo.NativeFieldInfoPtr_Payment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "Payment");
			ContractInfo.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "Products");
			ContractInfo.NativeFieldInfoPtr_DeliveryLocationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "DeliveryLocationGUID");
			ContractInfo.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "DeliveryWindow");
			ContractInfo.NativeFieldInfoPtr_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "Expires");
			ContractInfo.NativeFieldInfoPtr_ExpiresAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "ExpiresAfter");
			ContractInfo.NativeFieldInfoPtr_PickupScheduleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "PickupScheduleIndex");
			ContractInfo.NativeFieldInfoPtr_IsCounterOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "IsCounterOffer");
			ContractInfo.NativeFieldInfoPtr__DeliveryLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, "<DeliveryLocation>k__BackingField");
			ContractInfo.NativeMethodInfoPtr_get_DeliveryLocation_Public_get_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667414);
			ContractInfo.NativeMethodInfoPtr_set_DeliveryLocation_Private_set_Void_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667415);
			ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_ProductList_String_QuestWindowConfig_Boolean_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667416);
			ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667417);
			ContractInfo.NativeMethodInfoPtr_ProcessMessage_Public_DialogueChain_DialogueChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr, 100667418);
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x000E336C File Offset: 0x000E156C
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x000E33AC File Offset: 0x000E15AC
		public unsafe DeliveryLocation DeliveryLocation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr_get_DeliveryLocation_Public_get_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr_set_DeliveryLocation_Private_set_Void_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x000E33F0 File Offset: 0x000E15F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107505, RefRangeEnd = 107507, XrefRangeStart = 107490, XrefRangeEnd = 107505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo(float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, int expiresAfter, int pickupScheduleIndex, bool isCounterOffer) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payment;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expires;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiresAfter;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCounterOffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_Single_ProductList_String_QuestWindowConfig_Boolean_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x000E34A8 File Offset: 0x000E16A8
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000E34E4 File Offset: 0x000E16E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107581, RefRangeEnd = 107584, XrefRangeStart = 107507, XrefRangeEnd = 107581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueChain ProcessMessage(DialogueChain messageChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractInfo.NativeMethodInfoPtr_ProcessMessage_Public_DialogueChain_DialogueChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueChain>(intPtr3) : null;
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0001120D File Offset: 0x0000F40D
		public ContractInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x000E3534 File Offset: 0x000E1734
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x00011216 File Offset: 0x0000F416
		public unsafe float Payment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Payment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Payment)) = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x000E355C File Offset: 0x000E175C
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x00011231 File Offset: 0x0000F431
		public unsafe ProductList Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x000E358C File Offset: 0x000E178C
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x00011250 File Offset: 0x0000F450
		public unsafe string DeliveryLocationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryLocationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryLocationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x000E35B4 File Offset: 0x000E17B4
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0001126F File Offset: 0x0000F46F
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x000E35E4 File Offset: 0x000E17E4
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0001128E File Offset: 0x0000F48E
		public unsafe bool Expires
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_Expires)) = value;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x000E360C File Offset: 0x000E180C
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x000112A9 File Offset: 0x0000F4A9
		public unsafe int ExpiresAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_ExpiresAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_ExpiresAfter)) = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x000E3634 File Offset: 0x000E1834
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x000112C4 File Offset: 0x0000F4C4
		public unsafe int PickupScheduleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_PickupScheduleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_PickupScheduleIndex)) = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x000E365C File Offset: 0x000E185C
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x000112DF File Offset: 0x0000F4DF
		public unsafe bool IsCounterOffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_IsCounterOffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr_IsCounterOffer)) = value;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x000E3684 File Offset: 0x000E1884
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x000112FA File Offset: 0x0000F4FA
		public unsafe DeliveryLocation _DeliveryLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr__DeliveryLocation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractInfo.NativeFieldInfoPtr__DeliveryLocation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeFieldInfoPtr_Payment;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryLocationGUID;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeFieldInfoPtr_Expires;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeFieldInfoPtr_ExpiresAfter;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeFieldInfoPtr_PickupScheduleIndex;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeFieldInfoPtr_IsCounterOffer;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeFieldInfoPtr__DeliveryLocation_k__BackingField;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeMethodInfoPtr_get_DeliveryLocation_Public_get_DeliveryLocation_0;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeMethodInfoPtr_set_DeliveryLocation_Private_set_Void_DeliveryLocation_0;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_ProductList_String_QuestWindowConfig_Boolean_Int32_Int32_Boolean_0;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessage_Public_DialogueChain_DialogueChain_0;
	}
}

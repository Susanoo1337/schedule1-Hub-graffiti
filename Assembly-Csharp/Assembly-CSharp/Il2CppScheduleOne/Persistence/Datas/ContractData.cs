using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000266 RID: 614
	[Serializable]
	public class ContractData : QuestData
	{
		// Token: 0x060030D0 RID: 12496 RVA: 0x0011CD00 File Offset: 0x0011AF00
		// Note: this type is marked as 'beforefieldinit'.
		static ContractData()
		{
			Il2CppClassPointerStore<ContractData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ContractData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractData>.NativeClassPtr);
			ContractData.NativeFieldInfoPtr_CustomerGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "CustomerGUID");
			ContractData.NativeFieldInfoPtr_Payment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "Payment");
			ContractData.NativeFieldInfoPtr_ProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "ProductList");
			ContractData.NativeFieldInfoPtr_DeliveryLocationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "DeliveryLocationGUID");
			ContractData.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "DeliveryWindow");
			ContractData.NativeFieldInfoPtr_PickupScheduleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "PickupScheduleIndex");
			ContractData.NativeFieldInfoPtr_AcceptTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractData>.NativeClassPtr, "AcceptTime");
			ContractData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractData>.NativeClassPtr, 100669454);
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x0011CDD0 File Offset: 0x0011AFD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135273, RefRangeEnd = 135274, XrefRangeStart = 135262, XrefRangeEnd = 135273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractData(string guid, EQuestState state, bool isTracked, string title, string desc, bool isTimed, GameDateTimeData expiry, Il2CppReferenceArray<QuestEntryData> entries, string customerGUID, float payment, ProductList productList, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTimeData acceptTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTracked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(desc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTimed;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expiry);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(customerGUID);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptTime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractData.NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x000191C0 File Offset: 0x000173C0
		public ContractData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x060030D3 RID: 12499 RVA: 0x0011CF14 File Offset: 0x0011B114
		// (set) Token: 0x060030D4 RID: 12500 RVA: 0x000191C9 File Offset: 0x000173C9
		public unsafe string CustomerGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_CustomerGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_CustomerGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x060030D5 RID: 12501 RVA: 0x0011CF3C File Offset: 0x0011B13C
		// (set) Token: 0x060030D6 RID: 12502 RVA: 0x000191E8 File Offset: 0x000173E8
		public unsafe float Payment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_Payment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_Payment)) = value;
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x060030D7 RID: 12503 RVA: 0x0011CF64 File Offset: 0x0011B164
		// (set) Token: 0x060030D8 RID: 12504 RVA: 0x00019203 File Offset: 0x00017403
		public unsafe ProductList ProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_ProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_ProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x0011CF94 File Offset: 0x0011B194
		// (set) Token: 0x060030DA RID: 12506 RVA: 0x00019222 File Offset: 0x00017422
		public unsafe string DeliveryLocationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryLocationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryLocationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x0011CFBC File Offset: 0x0011B1BC
		// (set) Token: 0x060030DC RID: 12508 RVA: 0x00019241 File Offset: 0x00017441
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x060030DD RID: 12509 RVA: 0x0011CFEC File Offset: 0x0011B1EC
		// (set) Token: 0x060030DE RID: 12510 RVA: 0x00019260 File Offset: 0x00017460
		public unsafe int PickupScheduleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_PickupScheduleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_PickupScheduleIndex)) = value;
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x060030DF RID: 12511 RVA: 0x0011D014 File Offset: 0x0011B214
		// (set) Token: 0x060030E0 RID: 12512 RVA: 0x0001927B File Offset: 0x0001747B
		public unsafe GameDateTimeData AcceptTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_AcceptTime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDateTimeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractData.NativeFieldInfoPtr_AcceptTime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeFieldInfoPtr_CustomerGUID;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeFieldInfoPtr_Payment;

		// Token: 0x040020B5 RID: 8373
		private static readonly IntPtr NativeFieldInfoPtr_ProductList;

		// Token: 0x040020B6 RID: 8374
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryLocationGUID;

		// Token: 0x040020B7 RID: 8375
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x040020B8 RID: 8376
		private static readonly IntPtr NativeFieldInfoPtr_PickupScheduleIndex;

		// Token: 0x040020B9 RID: 8377
		private static readonly IntPtr NativeFieldInfoPtr_AcceptTime;

		// Token: 0x040020BA RID: 8378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuestState_Boolean_String_String_Boolean_GameDateTimeData_Il2CppReferenceArray_1_QuestEntryData_String_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTimeData_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000202 RID: 514
	public class CustomerData : SaveData
	{
		// Token: 0x06002DA4 RID: 11684 RVA: 0x001137E4 File Offset: 0x001119E4
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerData()
		{
			Il2CppClassPointerStore<CustomerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CustomerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerData>.NativeClassPtr);
			CustomerData.NativeFieldInfoPtr_Dependence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "Dependence");
			CustomerData.NativeFieldInfoPtr_ProductAffinities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "ProductAffinities");
			CustomerData.NativeFieldInfoPtr_TimeSinceLastDealCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSinceLastDealCompleted");
			CustomerData.NativeFieldInfoPtr_TimeSinceLastDealOffered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSinceLastDealOffered");
			CustomerData.NativeFieldInfoPtr_OfferedDeals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OfferedDeals");
			CustomerData.NativeFieldInfoPtr_CompletedDeals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "CompletedDeals");
			CustomerData.NativeFieldInfoPtr_IsContractOffered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "IsContractOffered");
			CustomerData.NativeFieldInfoPtr_OfferedContract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OfferedContract");
			CustomerData.NativeFieldInfoPtr_OfferedContractTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OfferedContractTime");
			CustomerData.NativeFieldInfoPtr_TimeSincePlayerApproached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSincePlayerApproached");
			CustomerData.NativeFieldInfoPtr_TimeSinceInstantDealOffered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "TimeSinceInstantDealOffered");
			CustomerData.NativeFieldInfoPtr_HasBeenRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "HasBeenRecommended");
			CustomerData.NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStructArray_1_Single_Int32_Int32_Int32_Int32_Boolean_ContractInfo_GameDateTime_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100669317);
			CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100669318);
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x0011392C File Offset: 0x00111B2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134343, RefRangeEnd = 134344, XrefRangeStart = 134340, XrefRangeEnd = 134343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData(float dependence, Il2CppStructArray<float> productAffinities, int timeSinceLastDealCompleted, int timeSinceLastDealOffered, int offeredDeals, int completedDeals, bool isContractOffered, ContractInfo offeredContract, GameDateTime offeredTime, int timeSincePlayerApproached, int timeSinceInstantDealOffered, bool hasBeenRecommended) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dependence;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productAffinities);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSinceLastDealCompleted;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSinceLastDealOffered;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offeredDeals;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completedDeals;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isContractOffered;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(offeredContract);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offeredTime;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSincePlayerApproached;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSinceInstantDealOffered;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeenRecommended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStructArray_1_Single_Int32_Int32_Int32_Int32_Boolean_ContractInfo_GameDateTime_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00113A1C File Offset: 0x00111C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134345, RefRangeEnd = 134346, XrefRangeStart = 134344, XrefRangeEnd = 134345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x0001710B File Offset: 0x0001530B
		public CustomerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x00113A58 File Offset: 0x00111C58
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x00017114 File Offset: 0x00015314
		public unsafe float Dependence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Dependence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Dependence)) = value;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x00113A80 File Offset: 0x00111C80
		// (set) Token: 0x06002DAB RID: 11691 RVA: 0x0001712F File Offset: 0x0001532F
		public unsafe Il2CppStructArray<float> ProductAffinities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_ProductAffinities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_ProductAffinities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06002DAC RID: 11692 RVA: 0x00113AB0 File Offset: 0x00111CB0
		// (set) Token: 0x06002DAD RID: 11693 RVA: 0x0001714E File Offset: 0x0001534E
		public unsafe int TimeSinceLastDealCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealCompleted)) = value;
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06002DAE RID: 11694 RVA: 0x00113AD8 File Offset: 0x00111CD8
		// (set) Token: 0x06002DAF RID: 11695 RVA: 0x00017169 File Offset: 0x00015369
		public unsafe int TimeSinceLastDealOffered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealOffered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceLastDealOffered)) = value;
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06002DB0 RID: 11696 RVA: 0x00113B00 File Offset: 0x00111D00
		// (set) Token: 0x06002DB1 RID: 11697 RVA: 0x00017184 File Offset: 0x00015384
		public unsafe int OfferedDeals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedDeals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedDeals)) = value;
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x00113B28 File Offset: 0x00111D28
		// (set) Token: 0x06002DB3 RID: 11699 RVA: 0x0001719F File Offset: 0x0001539F
		public unsafe int CompletedDeals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CompletedDeals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CompletedDeals)) = value;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x00113B50 File Offset: 0x00111D50
		// (set) Token: 0x06002DB5 RID: 11701 RVA: 0x000171BA File Offset: 0x000153BA
		public unsafe bool IsContractOffered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_IsContractOffered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_IsContractOffered)) = value;
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002DB6 RID: 11702 RVA: 0x00113B78 File Offset: 0x00111D78
		// (set) Token: 0x06002DB7 RID: 11703 RVA: 0x000171D5 File Offset: 0x000153D5
		public unsafe ContractInfo OfferedContract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x00113BA8 File Offset: 0x00111DA8
		// (set) Token: 0x06002DB9 RID: 11705 RVA: 0x000171F4 File Offset: 0x000153F4
		public unsafe GameDateTime OfferedContractTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContractTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OfferedContractTime)) = value;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002DBA RID: 11706 RVA: 0x00113BD0 File Offset: 0x00111DD0
		// (set) Token: 0x06002DBB RID: 11707 RVA: 0x0001720F File Offset: 0x0001540F
		public unsafe int TimeSincePlayerApproached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSincePlayerApproached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSincePlayerApproached)) = value;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002DBC RID: 11708 RVA: 0x00113BF8 File Offset: 0x00111DF8
		// (set) Token: 0x06002DBD RID: 11709 RVA: 0x0001722A File Offset: 0x0001542A
		public unsafe int TimeSinceInstantDealOffered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceInstantDealOffered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_TimeSinceInstantDealOffered)) = value;
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002DBE RID: 11710 RVA: 0x00113C20 File Offset: 0x00111E20
		// (set) Token: 0x06002DBF RID: 11711 RVA: 0x00017245 File Offset: 0x00015445
		public unsafe bool HasBeenRecommended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_HasBeenRecommended);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_HasBeenRecommended)) = value;
			}
		}

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeFieldInfoPtr_Dependence;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeFieldInfoPtr_ProductAffinities;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceLastDealCompleted;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceLastDealOffered;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeFieldInfoPtr_OfferedDeals;

		// Token: 0x04001F48 RID: 8008
		private static readonly IntPtr NativeFieldInfoPtr_CompletedDeals;

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeFieldInfoPtr_IsContractOffered;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeFieldInfoPtr_OfferedContract;

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeFieldInfoPtr_OfferedContractTime;

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeFieldInfoPtr_TimeSincePlayerApproached;

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceInstantDealOffered;

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeFieldInfoPtr_HasBeenRecommended;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Il2CppStructArray_1_Single_Int32_Int32_Int32_Int32_Boolean_ContractInfo_GameDateTime_Int32_Int32_Boolean_0;

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

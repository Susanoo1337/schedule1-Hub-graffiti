using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Cartel;
using Il2CppScheduleOne.Map;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000201 RID: 513
	[Serializable]
	public class CartelData : SaveData
	{
		// Token: 0x06002D93 RID: 11667 RVA: 0x00113538 File Offset: 0x00111738
		// Note: this type is marked as 'beforefieldinit'.
		static CartelData()
		{
			Il2CppClassPointerStore<CartelData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CartelData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelData>.NativeClassPtr);
			CartelData.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelData>.NativeClassPtr, "Status");
			CartelData.NativeFieldInfoPtr_HoursSinceStatusChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelData>.NativeClassPtr, "HoursSinceStatusChange");
			CartelData.NativeFieldInfoPtr_RegionInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelData>.NativeClassPtr, "RegionInfluence");
			CartelData.NativeFieldInfoPtr_HoursUntilNextGlobalActivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelData>.NativeClassPtr, "HoursUntilNextGlobalActivity");
			CartelData.NativeFieldInfoPtr_RegionalActivityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelData>.NativeClassPtr, "RegionalActivityData");
			CartelData.NativeFieldInfoPtr_ActiveCartelDeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelData>.NativeClassPtr, "ActiveCartelDeal");
			CartelData.NativeFieldInfoPtr_HoursUntilNextDealRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelData>.NativeClassPtr, "HoursUntilNextDealRequest");
			CartelData.NativeMethodInfoPtr__ctor_Public_Void_ECartelStatus_Int32_Il2CppReferenceArray_1_RegionInfluenceData_Int32_Il2CppReferenceArray_1_CartelRegionalActivityData_CartelDealInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelData>.NativeClassPtr, 100669315);
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00113608 File Offset: 0x00111808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134338, RefRangeEnd = 134340, XrefRangeStart = 134334, XrefRangeEnd = 134338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelData(ECartelStatus status, int hoursSinceStatusChange, Il2CppReferenceArray<CartelInfluence.RegionInfluenceData> regionInfluence, int hoursUntilNextGlobalActivity, Il2CppReferenceArray<CartelRegionalActivityData> regionalActivityData, CartelDealInfo activeCartelDeal, int hoursUntilNextDealRequest) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hoursSinceStatusChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(regionInfluence);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hoursUntilNextGlobalActivity;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(regionalActivityData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeCartelDeal);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hoursUntilNextDealRequest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelData.NativeMethodInfoPtr__ctor_Public_Void_ECartelStatus_Int32_Il2CppReferenceArray_1_RegionInfluenceData_Int32_Il2CppReferenceArray_1_CartelRegionalActivityData_CartelDealInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x00017039 File Offset: 0x00015239
		public CartelData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x001136B4 File Offset: 0x001118B4
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x00017042 File Offset: 0x00015242
		public unsafe ECartelStatus Status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_Status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_Status)) = value;
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x001136DC File Offset: 0x001118DC
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x0001705D File Offset: 0x0001525D
		public unsafe int HoursSinceStatusChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_HoursSinceStatusChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_HoursSinceStatusChange)) = value;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x00113704 File Offset: 0x00111904
		// (set) Token: 0x06002D9B RID: 11675 RVA: 0x00017078 File Offset: 0x00015278
		public unsafe Il2CppReferenceArray<CartelInfluence.RegionInfluenceData> RegionInfluence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_RegionInfluence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CartelInfluence.RegionInfluenceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_RegionInfluence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x00113734 File Offset: 0x00111934
		// (set) Token: 0x06002D9D RID: 11677 RVA: 0x00017097 File Offset: 0x00015297
		public unsafe int HoursUntilNextGlobalActivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_HoursUntilNextGlobalActivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_HoursUntilNextGlobalActivity)) = value;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x0011375C File Offset: 0x0011195C
		// (set) Token: 0x06002D9F RID: 11679 RVA: 0x000170B2 File Offset: 0x000152B2
		public unsafe Il2CppReferenceArray<CartelRegionalActivityData> RegionalActivityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_RegionalActivityData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CartelRegionalActivityData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_RegionalActivityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x0011378C File Offset: 0x0011198C
		// (set) Token: 0x06002DA1 RID: 11681 RVA: 0x000170D1 File Offset: 0x000152D1
		public unsafe CartelDealInfo ActiveCartelDeal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_ActiveCartelDeal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelDealInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_ActiveCartelDeal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x001137BC File Offset: 0x001119BC
		// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x000170F0 File Offset: 0x000152F0
		public unsafe int HoursUntilNextDealRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_HoursUntilNextDealRequest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelData.NativeFieldInfoPtr_HoursUntilNextDealRequest)) = value;
			}
		}

		// Token: 0x04001F3B RID: 7995
		private static readonly IntPtr NativeFieldInfoPtr_Status;

		// Token: 0x04001F3C RID: 7996
		private static readonly IntPtr NativeFieldInfoPtr_HoursSinceStatusChange;

		// Token: 0x04001F3D RID: 7997
		private static readonly IntPtr NativeFieldInfoPtr_RegionInfluence;

		// Token: 0x04001F3E RID: 7998
		private static readonly IntPtr NativeFieldInfoPtr_HoursUntilNextGlobalActivity;

		// Token: 0x04001F3F RID: 7999
		private static readonly IntPtr NativeFieldInfoPtr_RegionalActivityData;

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeFieldInfoPtr_ActiveCartelDeal;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeFieldInfoPtr_HoursUntilNextDealRequest;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ECartelStatus_Int32_Il2CppReferenceArray_1_RegionInfluenceData_Int32_Il2CppReferenceArray_1_CartelRegionalActivityData_CartelDealInfo_Int32_0;

		// Token: 0x020009E6 RID: 2534
		[Serializable]
		public class RegionIntDict : SerializableDictionary<EMapRegion, int>
		{
			// Token: 0x0600DCD3 RID: 56531 RVA: 0x00067E9D File Offset: 0x0006609D
			// Note: this type is marked as 'beforefieldinit'.
			static RegionIntDict()
			{
				Il2CppClassPointerStore<CartelData.RegionIntDict>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelData>.NativeClassPtr, "RegionIntDict");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelData.RegionIntDict>.NativeClassPtr);
				CartelData.RegionIntDict.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelData.RegionIntDict>.NativeClassPtr, 100669316);
			}

			// Token: 0x0600DCD4 RID: 56532 RVA: 0x00368F40 File Offset: 0x00367140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134331, XrefRangeEnd = 134334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RegionIntDict() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelData.RegionIntDict>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelData.RegionIntDict.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCD5 RID: 56533 RVA: 0x00067ED1 File Offset: 0x000660D1
			public RegionIntDict(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009696 RID: 38550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

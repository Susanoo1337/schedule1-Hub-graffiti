using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000391 RID: 913
	[Serializable]
	public class CustomerData : ScriptableObject
	{
		// Token: 0x0600521E RID: 21022 RVA: 0x00196908 File Offset: 0x00194B08
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerData()
		{
			Il2CppClassPointerStore<CustomerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerData>.NativeClassPtr);
			CustomerData.NativeFieldInfoPtr_DefaultAffinityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "DefaultAffinityData");
			CustomerData.NativeFieldInfoPtr_PreferredProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "PreferredProperties");
			CustomerData.NativeFieldInfoPtr_MinWeeklySpend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinWeeklySpend");
			CustomerData.NativeFieldInfoPtr_MaxWeeklySpend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxWeeklySpend");
			CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinOrdersPerWeek");
			CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxOrdersPerWeek");
			CustomerData.NativeFieldInfoPtr_OrderTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "OrderTime");
			CustomerData.NativeFieldInfoPtr_PreferredOrderDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "PreferredOrderDay");
			CustomerData.NativeFieldInfoPtr_Standards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "Standards");
			CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "CanBeDirectlyApproached");
			CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "GuaranteeFirstSampleSuccess");
			CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MinMutualRelationRequirement");
			CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "MaxMutualRelationRequirement");
			CustomerData.NativeFieldInfoPtr_CallPoliceChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "CallPoliceChance");
			CustomerData.NativeFieldInfoPtr_DependenceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "DependenceMultiplier");
			CustomerData.NativeFieldInfoPtr_BaseAddiction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "BaseAddiction");
			CustomerData.NativeFieldInfoPtr_onChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, "onChanged");
			CustomerData.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674036);
			CustomerData.NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674037);
			CustomerData.NativeMethodInfoPtr_GetOrderDays_Public_Void_Single_Single_List_1_EDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674038);
			CustomerData.NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674039);
			CustomerData.NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674040);
			CustomerData.NativeMethodInfoPtr_RandomizeFavouriteEffects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674041);
			CustomerData.NativeMethodInfoPtr_RandomizeTiming_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674042);
			CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerData>.NativeClassPtr, 100674043);
		}

		// Token: 0x0600521F RID: 21023 RVA: 0x00196B2C File Offset: 0x00194D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183291, XrefRangeEnd = 183297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x00196B60 File Offset: 0x00194D60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183297, RefRangeEnd = 183299, XrefRangeStart = 183297, XrefRangeEnd = 183297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetQualityScalar(EQuality quality)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x00196BA0 File Offset: 0x00194DA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 183307, RefRangeEnd = 183311, XrefRangeStart = 183299, XrefRangeEnd = 183307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOrderDays(float dependence, float normalizedRelationship, List<EDay> days)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dependence;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedRelationship;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(days);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetOrderDays_Public_Void_Single_Single_List_1_EDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x00196C00 File Offset: 0x00194E00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 183318, RefRangeEnd = 183321, XrefRangeStart = 183311, XrefRangeEnd = 183318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAdjustedWeeklySpend(float normalizedRelationship)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedRelationship;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x00196C4C File Offset: 0x00194E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183321, XrefRangeEnd = 183369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeAffinities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00196C80 File Offset: 0x00194E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183369, XrefRangeEnd = 183415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeFavouriteEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeFavouriteEffects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x00196CB4 File Offset: 0x00194EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183415, XrefRangeEnd = 183422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeTiming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr_RandomizeTiming_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x00196CE8 File Offset: 0x00194EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183422, XrefRangeEnd = 183430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x000270B8 File Offset: 0x000252B8
		public CustomerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06005228 RID: 21032 RVA: 0x00196D24 File Offset: 0x00194F24
		// (set) Token: 0x06005229 RID: 21033 RVA: 0x000270C1 File Offset: 0x000252C1
		public unsafe CustomerAffinityData DefaultAffinityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DefaultAffinityData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerAffinityData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DefaultAffinityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x0600522A RID: 21034 RVA: 0x00196D54 File Offset: 0x00194F54
		// (set) Token: 0x0600522B RID: 21035 RVA: 0x000270E0 File Offset: 0x000252E0
		public unsafe List<Effect> PreferredProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Effect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x00196D84 File Offset: 0x00194F84
		// (set) Token: 0x0600522D RID: 21037 RVA: 0x000270FF File Offset: 0x000252FF
		public unsafe float MinWeeklySpend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinWeeklySpend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinWeeklySpend)) = value;
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x0600522E RID: 21038 RVA: 0x00196DAC File Offset: 0x00194FAC
		// (set) Token: 0x0600522F RID: 21039 RVA: 0x0002711A File Offset: 0x0002531A
		public unsafe float MaxWeeklySpend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxWeeklySpend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxWeeklySpend)) = value;
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06005230 RID: 21040 RVA: 0x00196DD4 File Offset: 0x00194FD4
		// (set) Token: 0x06005231 RID: 21041 RVA: 0x00027135 File Offset: 0x00025335
		public unsafe int MinOrdersPerWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinOrdersPerWeek)) = value;
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06005232 RID: 21042 RVA: 0x00196DFC File Offset: 0x00194FFC
		// (set) Token: 0x06005233 RID: 21043 RVA: 0x00027150 File Offset: 0x00025350
		public unsafe int MaxOrdersPerWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxOrdersPerWeek)) = value;
			}
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x06005234 RID: 21044 RVA: 0x00196E24 File Offset: 0x00195024
		// (set) Token: 0x06005235 RID: 21045 RVA: 0x0002716B File Offset: 0x0002536B
		public unsafe int OrderTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OrderTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_OrderTime)) = value;
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x06005236 RID: 21046 RVA: 0x00196E4C File Offset: 0x0019504C
		// (set) Token: 0x06005237 RID: 21047 RVA: 0x00027186 File Offset: 0x00025386
		public unsafe EDay PreferredOrderDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredOrderDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_PreferredOrderDay)) = value;
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x06005238 RID: 21048 RVA: 0x00196E74 File Offset: 0x00195074
		// (set) Token: 0x06005239 RID: 21049 RVA: 0x000271A1 File Offset: 0x000253A1
		public unsafe ECustomerStandard Standards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Standards);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_Standards)) = value;
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x0600523A RID: 21050 RVA: 0x00196E9C File Offset: 0x0019509C
		// (set) Token: 0x0600523B RID: 21051 RVA: 0x000271BC File Offset: 0x000253BC
		public unsafe bool CanBeDirectlyApproached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CanBeDirectlyApproached)) = value;
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x0600523C RID: 21052 RVA: 0x00196EC4 File Offset: 0x001950C4
		// (set) Token: 0x0600523D RID: 21053 RVA: 0x000271D7 File Offset: 0x000253D7
		public unsafe bool GuaranteeFirstSampleSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_GuaranteeFirstSampleSuccess)) = value;
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x0600523E RID: 21054 RVA: 0x00196EEC File Offset: 0x001950EC
		// (set) Token: 0x0600523F RID: 21055 RVA: 0x000271F2 File Offset: 0x000253F2
		public unsafe float MinMutualRelationRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MinMutualRelationRequirement)) = value;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06005240 RID: 21056 RVA: 0x00196F14 File Offset: 0x00195114
		// (set) Token: 0x06005241 RID: 21057 RVA: 0x0002720D File Offset: 0x0002540D
		public unsafe float MaxMutualRelationRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_MaxMutualRelationRequirement)) = value;
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06005242 RID: 21058 RVA: 0x00196F3C File Offset: 0x0019513C
		// (set) Token: 0x06005243 RID: 21059 RVA: 0x00027228 File Offset: 0x00025428
		public unsafe float CallPoliceChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CallPoliceChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_CallPoliceChance)) = value;
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06005244 RID: 21060 RVA: 0x00196F64 File Offset: 0x00195164
		// (set) Token: 0x06005245 RID: 21061 RVA: 0x00027243 File Offset: 0x00025443
		public unsafe float DependenceMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DependenceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_DependenceMultiplier)) = value;
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x06005246 RID: 21062 RVA: 0x00196F8C File Offset: 0x0019518C
		// (set) Token: 0x06005247 RID: 21063 RVA: 0x0002725E File Offset: 0x0002545E
		public unsafe float BaseAddiction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_BaseAddiction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_BaseAddiction)) = value;
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x06005248 RID: 21064 RVA: 0x00196FB4 File Offset: 0x001951B4
		// (set) Token: 0x06005249 RID: 21065 RVA: 0x00027279 File Offset: 0x00025479
		public unsafe Action onChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_onChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerData.NativeFieldInfoPtr_onChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003864 RID: 14436
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAffinityData;

		// Token: 0x04003865 RID: 14437
		private static readonly IntPtr NativeFieldInfoPtr_PreferredProperties;

		// Token: 0x04003866 RID: 14438
		private static readonly IntPtr NativeFieldInfoPtr_MinWeeklySpend;

		// Token: 0x04003867 RID: 14439
		private static readonly IntPtr NativeFieldInfoPtr_MaxWeeklySpend;

		// Token: 0x04003868 RID: 14440
		private static readonly IntPtr NativeFieldInfoPtr_MinOrdersPerWeek;

		// Token: 0x04003869 RID: 14441
		private static readonly IntPtr NativeFieldInfoPtr_MaxOrdersPerWeek;

		// Token: 0x0400386A RID: 14442
		private static readonly IntPtr NativeFieldInfoPtr_OrderTime;

		// Token: 0x0400386B RID: 14443
		private static readonly IntPtr NativeFieldInfoPtr_PreferredOrderDay;

		// Token: 0x0400386C RID: 14444
		private static readonly IntPtr NativeFieldInfoPtr_Standards;

		// Token: 0x0400386D RID: 14445
		private static readonly IntPtr NativeFieldInfoPtr_CanBeDirectlyApproached;

		// Token: 0x0400386E RID: 14446
		private static readonly IntPtr NativeFieldInfoPtr_GuaranteeFirstSampleSuccess;

		// Token: 0x0400386F RID: 14447
		private static readonly IntPtr NativeFieldInfoPtr_MinMutualRelationRequirement;

		// Token: 0x04003870 RID: 14448
		private static readonly IntPtr NativeFieldInfoPtr_MaxMutualRelationRequirement;

		// Token: 0x04003871 RID: 14449
		private static readonly IntPtr NativeFieldInfoPtr_CallPoliceChance;

		// Token: 0x04003872 RID: 14450
		private static readonly IntPtr NativeFieldInfoPtr_DependenceMultiplier;

		// Token: 0x04003873 RID: 14451
		private static readonly IntPtr NativeFieldInfoPtr_BaseAddiction;

		// Token: 0x04003874 RID: 14452
		private static readonly IntPtr NativeFieldInfoPtr_onChanged;

		// Token: 0x04003875 RID: 14453
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003876 RID: 14454
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityScalar_Public_Static_Single_EQuality_0;

		// Token: 0x04003877 RID: 14455
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderDays_Public_Void_Single_Single_List_1_EDay_0;

		// Token: 0x04003878 RID: 14456
		private static readonly IntPtr NativeMethodInfoPtr_GetAdjustedWeeklySpend_Public_Single_Single_0;

		// Token: 0x04003879 RID: 14457
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeAffinities_Public_Void_0;

		// Token: 0x0400387A RID: 14458
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeFavouriteEffects_Public_Void_0;

		// Token: 0x0400387B RID: 14459
		private static readonly IntPtr NativeMethodInfoPtr_RandomizeTiming_Public_Void_0;

		// Token: 0x0400387C RID: 14460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

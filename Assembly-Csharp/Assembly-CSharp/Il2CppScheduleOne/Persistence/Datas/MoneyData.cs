using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000237 RID: 567
	[Serializable]
	public class MoneyData : SaveData
	{
		// Token: 0x06002F30 RID: 12080 RVA: 0x00117DF0 File Offset: 0x00115FF0
		// Note: this type is marked as 'beforefieldinit'.
		static MoneyData()
		{
			Il2CppClassPointerStore<MoneyData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MoneyData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoneyData>.NativeClassPtr);
			MoneyData.NativeFieldInfoPtr_OnlineBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "OnlineBalance");
			MoneyData.NativeFieldInfoPtr_Networth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "Networth");
			MoneyData.NativeFieldInfoPtr_LifetimeEarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "LifetimeEarnings");
			MoneyData.NativeFieldInfoPtr_WeeklyDepositSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, "WeeklyDepositSum");
			MoneyData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoneyData>.NativeClassPtr, 100669404);
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00117E84 File Offset: 0x00116084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 134988, RefRangeEnd = 134989, XrefRangeStart = 134987, XrefRangeEnd = 134988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoneyData(float onlineBalance, float netWorth, float lifetimeEarnings, float weeklyDepositSum) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoneyData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlineBalance;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref netWorth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetimeEarnings;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weeklyDepositSum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoneyData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x0001807D File Offset: 0x0001627D
		public MoneyData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x00117EF8 File Offset: 0x001160F8
		// (set) Token: 0x06002F34 RID: 12084 RVA: 0x00018086 File Offset: 0x00016286
		public unsafe float OnlineBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_OnlineBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_OnlineBalance)) = value;
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06002F35 RID: 12085 RVA: 0x00117F20 File Offset: 0x00116120
		// (set) Token: 0x06002F36 RID: 12086 RVA: 0x000180A1 File Offset: 0x000162A1
		public unsafe float Networth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_Networth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_Networth)) = value;
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x00117F48 File Offset: 0x00116148
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x000180BC File Offset: 0x000162BC
		public unsafe float LifetimeEarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_LifetimeEarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_LifetimeEarnings)) = value;
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x00117F70 File Offset: 0x00116170
		// (set) Token: 0x06002F3A RID: 12090 RVA: 0x000180D7 File Offset: 0x000162D7
		public unsafe float WeeklyDepositSum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_WeeklyDepositSum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoneyData.NativeFieldInfoPtr_WeeklyDepositSum)) = value;
			}
		}

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeFieldInfoPtr_OnlineBalance;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeFieldInfoPtr_Networth;

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeFieldInfoPtr_LifetimeEarnings;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeFieldInfoPtr_WeeklyDepositSum;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
	}
}

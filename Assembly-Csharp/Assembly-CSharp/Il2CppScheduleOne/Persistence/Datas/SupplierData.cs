using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000243 RID: 579
	[Serializable]
	public class SupplierData : NPCData
	{
		// Token: 0x06002FA1 RID: 12193 RVA: 0x00119260 File Offset: 0x00117460
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierData()
		{
			Il2CppClassPointerStore<SupplierData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SupplierData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierData>.NativeClassPtr);
			SupplierData.NativeFieldInfoPtr_timeSinceMeetingStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "timeSinceMeetingStart");
			SupplierData.NativeFieldInfoPtr_timeSinceLastMeetingEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "timeSinceLastMeetingEnd");
			SupplierData.NativeFieldInfoPtr_debt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "debt");
			SupplierData.NativeFieldInfoPtr_minsUntilDeadDropReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "minsUntilDeadDropReady");
			SupplierData.NativeFieldInfoPtr_deaddropItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "deaddropItems");
			SupplierData.NativeFieldInfoPtr_debtReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, "debtReminderSent");
			SupplierData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_Int32_Il2CppReferenceArray_1_StringIntPair_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierData>.NativeClassPtr, 100669417);
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x0011931C File Offset: 0x0011751C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135044, RefRangeEnd = 135045, XrefRangeStart = 135041, XrefRangeEnd = 135044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierData(string id, int _timeSinceMeetingStart, int _timeSinceLastMeetingEnd, float _debt, int _minsUntilDeadDropReady, Il2CppReferenceArray<StringIntPair> _deaddropItems, bool _debtReminderSent) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _timeSinceMeetingStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _timeSinceLastMeetingEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _debt;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _minsUntilDeadDropReady;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_deaddropItems);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _debtReminderSent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_Int32_Il2CppReferenceArray_1_StringIntPair_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x00018533 File Offset: 0x00016733
		public SupplierData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06002FA4 RID: 12196 RVA: 0x001193C0 File Offset: 0x001175C0
		// (set) Token: 0x06002FA5 RID: 12197 RVA: 0x0001853C File Offset: 0x0001673C
		public unsafe int timeSinceMeetingStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceMeetingStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceMeetingStart)) = value;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06002FA6 RID: 12198 RVA: 0x001193E8 File Offset: 0x001175E8
		// (set) Token: 0x06002FA7 RID: 12199 RVA: 0x00018557 File Offset: 0x00016757
		public unsafe int timeSinceLastMeetingEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceLastMeetingEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_timeSinceLastMeetingEnd)) = value;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06002FA8 RID: 12200 RVA: 0x00119410 File Offset: 0x00117610
		// (set) Token: 0x06002FA9 RID: 12201 RVA: 0x00018572 File Offset: 0x00016772
		public unsafe float debt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debt)) = value;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06002FAA RID: 12202 RVA: 0x00119438 File Offset: 0x00117638
		// (set) Token: 0x06002FAB RID: 12203 RVA: 0x0001858D File Offset: 0x0001678D
		public unsafe int minsUntilDeadDropReady
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_minsUntilDeadDropReady);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_minsUntilDeadDropReady)) = value;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06002FAC RID: 12204 RVA: 0x00119460 File Offset: 0x00117660
		// (set) Token: 0x06002FAD RID: 12205 RVA: 0x000185A8 File Offset: 0x000167A8
		public unsafe Il2CppReferenceArray<StringIntPair> deaddropItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_deaddropItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_deaddropItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x00119490 File Offset: 0x00117690
		// (set) Token: 0x06002FAF RID: 12207 RVA: 0x000185C7 File Offset: 0x000167C7
		public unsafe bool debtReminderSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debtReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierData.NativeFieldInfoPtr_debtReminderSent)) = value;
			}
		}

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceMeetingStart;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastMeetingEnd;

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeFieldInfoPtr_debt;

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeFieldInfoPtr_minsUntilDeadDropReady;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeFieldInfoPtr_deaddropItems;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeFieldInfoPtr_debtReminderSent;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_Single_Int32_Il2CppReferenceArray_1_StringIntPair_Boolean_0;
	}
}

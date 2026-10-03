using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026A RID: 618
	public class QuestManagerData : SaveData
	{
		// Token: 0x06003101 RID: 12545 RVA: 0x0011D5FC File Offset: 0x0011B7FC
		// Note: this type is marked as 'beforefieldinit'.
		static QuestManagerData()
		{
			Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QuestManagerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr);
			QuestManagerData.NativeFieldInfoPtr_Quests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr, "Quests");
			QuestManagerData.NativeFieldInfoPtr_Contracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr, "Contracts");
			QuestManagerData.NativeFieldInfoPtr_DeaddropQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr, "DeaddropQuests");
			QuestManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_QuestData_Il2CppReferenceArray_1_ContractData_Il2CppReferenceArray_1_DeaddropQuestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr, 100669459);
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x0011D67C File Offset: 0x0011B87C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 134792, RefRangeEnd = 134797, XrefRangeStart = 134792, XrefRangeEnd = 134797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestManagerData(Il2CppReferenceArray<QuestData> quests, Il2CppReferenceArray<ContractData> contracts, Il2CppReferenceArray<DeaddropQuestData> deaddropQuests) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestManagerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(quests);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contracts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deaddropQuests);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_QuestData_Il2CppReferenceArray_1_ContractData_Il2CppReferenceArray_1_DeaddropQuestData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x000193FA File Offset: 0x000175FA
		public QuestManagerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x0011D6EC File Offset: 0x0011B8EC
		// (set) Token: 0x06003105 RID: 12549 RVA: 0x00019403 File Offset: 0x00017603
		public unsafe Il2CppReferenceArray<QuestData> Quests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_Quests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_Quests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x0011D71C File Offset: 0x0011B91C
		// (set) Token: 0x06003107 RID: 12551 RVA: 0x00019422 File Offset: 0x00017622
		public unsafe Il2CppReferenceArray<ContractData> Contracts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_Contracts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ContractData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_Contracts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x0011D74C File Offset: 0x0011B94C
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x00019441 File Offset: 0x00017641
		public unsafe Il2CppReferenceArray<DeaddropQuestData> DeaddropQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_DeaddropQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeaddropQuestData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManagerData.NativeFieldInfoPtr_DeaddropQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020CA RID: 8394
		private static readonly IntPtr NativeFieldInfoPtr_Quests;

		// Token: 0x040020CB RID: 8395
		private static readonly IntPtr NativeFieldInfoPtr_Contracts;

		// Token: 0x040020CC RID: 8396
		private static readonly IntPtr NativeFieldInfoPtr_DeaddropQuests;

		// Token: 0x040020CD RID: 8397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_QuestData_Il2CppReferenceArray_1_ContractData_Il2CppReferenceArray_1_DeaddropQuestData_0;
	}
}

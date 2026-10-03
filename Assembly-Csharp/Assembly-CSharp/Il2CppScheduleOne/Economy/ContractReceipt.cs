using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.GameTime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200038D RID: 909
	[Serializable]
	public class ContractReceipt : Object
	{
		// Token: 0x06005096 RID: 20630 RVA: 0x00190434 File Offset: 0x0018E634
		// Note: this type is marked as 'beforefieldinit'.
		static ContractReceipt()
		{
			Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "ContractReceipt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr);
			ContractReceipt.NativeFieldInfoPtr_ReceiptId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr, "ReceiptId");
			ContractReceipt.NativeFieldInfoPtr_CompletedBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr, "CompletedBy");
			ContractReceipt.NativeFieldInfoPtr_CustomerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr, "CustomerId");
			ContractReceipt.NativeFieldInfoPtr_CompletionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr, "CompletionTime");
			ContractReceipt.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr, "Items");
			ContractReceipt.NativeFieldInfoPtr_AmountPaid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr, "AmountPaid");
			ContractReceipt.NativeMethodInfoPtr__ctor_Public_Void_Int32_EContractParty_String_GameDateTime_Il2CppReferenceArray_1_StringIntPair_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr, 100673746);
			ContractReceipt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr, 100673747);
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x00190504 File Offset: 0x0018E704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179219, XrefRangeEnd = 179222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractReceipt(int receiptId, EContractParty completedBy, string customerID, GameDateTime completionTime, Il2CppReferenceArray<StringIntPair> items, float amountPaid) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref receiptId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completedBy;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(customerID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completionTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amountPaid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractReceipt.NativeMethodInfoPtr__ctor_Public_Void_Int32_EContractParty_String_GameDateTime_Il2CppReferenceArray_1_StringIntPair_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005098 RID: 20632 RVA: 0x0019059C File Offset: 0x0018E79C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179231, RefRangeEnd = 179232, XrefRangeStart = 179222, XrefRangeEnd = 179231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractReceipt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractReceipt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005099 RID: 20633 RVA: 0x0002695B File Offset: 0x00024B5B
		public ContractReceipt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x0600509A RID: 20634 RVA: 0x001905D8 File Offset: 0x0018E7D8
		// (set) Token: 0x0600509B RID: 20635 RVA: 0x00026964 File Offset: 0x00024B64
		public unsafe int ReceiptId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_ReceiptId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_ReceiptId)) = value;
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x0600509C RID: 20636 RVA: 0x00190600 File Offset: 0x0018E800
		// (set) Token: 0x0600509D RID: 20637 RVA: 0x0002697F File Offset: 0x00024B7F
		public unsafe EContractParty CompletedBy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_CompletedBy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_CompletedBy)) = value;
			}
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x0600509E RID: 20638 RVA: 0x00190628 File Offset: 0x0018E828
		// (set) Token: 0x0600509F RID: 20639 RVA: 0x0002699A File Offset: 0x00024B9A
		public unsafe string CustomerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_CustomerId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_CustomerId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x060050A0 RID: 20640 RVA: 0x00190650 File Offset: 0x0018E850
		// (set) Token: 0x060050A1 RID: 20641 RVA: 0x000269B9 File Offset: 0x00024BB9
		public unsafe GameDateTime CompletionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_CompletionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_CompletionTime)) = value;
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x060050A2 RID: 20642 RVA: 0x00190678 File Offset: 0x0018E878
		// (set) Token: 0x060050A3 RID: 20643 RVA: 0x000269D4 File Offset: 0x00024BD4
		public unsafe Il2CppReferenceArray<StringIntPair> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x060050A4 RID: 20644 RVA: 0x001906A8 File Offset: 0x0018E8A8
		// (set) Token: 0x060050A5 RID: 20645 RVA: 0x000269F3 File Offset: 0x00024BF3
		public unsafe float AmountPaid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_AmountPaid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContractReceipt.NativeFieldInfoPtr_AmountPaid)) = value;
			}
		}

		// Token: 0x04003732 RID: 14130
		private static readonly IntPtr NativeFieldInfoPtr_ReceiptId;

		// Token: 0x04003733 RID: 14131
		private static readonly IntPtr NativeFieldInfoPtr_CompletedBy;

		// Token: 0x04003734 RID: 14132
		private static readonly IntPtr NativeFieldInfoPtr_CustomerId;

		// Token: 0x04003735 RID: 14133
		private static readonly IntPtr NativeFieldInfoPtr_CompletionTime;

		// Token: 0x04003736 RID: 14134
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04003737 RID: 14135
		private static readonly IntPtr NativeFieldInfoPtr_AmountPaid;

		// Token: 0x04003738 RID: 14136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_EContractParty_String_GameDateTime_Il2CppReferenceArray_1_StringIntPair_Single_0;

		// Token: 0x04003739 RID: 14137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

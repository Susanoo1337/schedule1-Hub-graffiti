using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x020002AD RID: 685
	public class Transaction : Object
	{
		// Token: 0x0600351C RID: 13596 RVA: 0x0012C318 File Offset: 0x0012A518
		// Note: this type is marked as 'beforefieldinit'.
		static Transaction()
		{
			Il2CppClassPointerStore<Transaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "Transaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transaction>.NativeClassPtr);
			Transaction.NativeFieldInfoPtr_transaction_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "transaction_Name");
			Transaction.NativeFieldInfoPtr_unit_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "unit_Amount");
			Transaction.NativeFieldInfoPtr_quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "quantity");
			Transaction.NativeFieldInfoPtr_transaction_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, "transaction_Note");
			Transaction.NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100670047);
			Transaction.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100670048);
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x0600351D RID: 13597 RVA: 0x0012C3C0 File Offset: 0x0012A5C0
		public unsafe float total_Amount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x0012C3FC File Offset: 0x0012A5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141201, XrefRangeEnd = 141209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transaction>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_transaction_Name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _unit_Amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _quantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_transaction_Note);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x0001AF90 File Offset: 0x00019190
		public Transaction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06003520 RID: 13600 RVA: 0x0012C478 File Offset: 0x0012A678
		// (set) Token: 0x06003521 RID: 13601 RVA: 0x0001AF99 File Offset: 0x00019199
		public unsafe string transaction_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x06003522 RID: 13602 RVA: 0x0012C4A0 File Offset: 0x0012A6A0
		// (set) Token: 0x06003523 RID: 13603 RVA: 0x0001AFB8 File Offset: 0x000191B8
		public unsafe float unit_Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_unit_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_unit_Amount)) = value;
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x06003524 RID: 13604 RVA: 0x0012C4C8 File Offset: 0x0012A6C8
		// (set) Token: 0x06003525 RID: 13605 RVA: 0x0001AFD3 File Offset: 0x000191D3
		public unsafe float quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_quantity)) = value;
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x0012C4F0 File Offset: 0x0012A6F0
		// (set) Token: 0x06003527 RID: 13607 RVA: 0x0001AFEE File Offset: 0x000191EE
		public unsafe string transaction_Note
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Note);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transaction.NativeFieldInfoPtr_transaction_Note), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002396 RID: 9110
		private static readonly IntPtr NativeFieldInfoPtr_transaction_Name;

		// Token: 0x04002397 RID: 9111
		private static readonly IntPtr NativeFieldInfoPtr_unit_Amount;

		// Token: 0x04002398 RID: 9112
		private static readonly IntPtr NativeFieldInfoPtr_quantity;

		// Token: 0x04002399 RID: 9113
		private static readonly IntPtr NativeFieldInfoPtr_transaction_Note;

		// Token: 0x0400239A RID: 9114
		private static readonly IntPtr NativeMethodInfoPtr_get_total_Amount_Public_get_Single_0;

		// Token: 0x0400239B RID: 9115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_String_0;
	}
}

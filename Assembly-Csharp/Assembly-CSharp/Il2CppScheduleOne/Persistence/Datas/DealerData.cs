using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200023F RID: 575
	public class DealerData : NPCData
	{
		// Token: 0x06002F6D RID: 12141 RVA: 0x00118994 File Offset: 0x00116B94
		// Note: this type is marked as 'beforefieldinit'.
		static DealerData()
		{
			Il2CppClassPointerStore<DealerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DealerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerData>.NativeClassPtr);
			DealerData.NativeFieldInfoPtr_Recruited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "Recruited");
			DealerData.NativeFieldInfoPtr_AssignedCustomerIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "AssignedCustomerIDs");
			DealerData.NativeFieldInfoPtr_ActiveContractGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "ActiveContractGUIDs");
			DealerData.NativeFieldInfoPtr_Cash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "Cash");
			DealerData.NativeFieldInfoPtr_OverflowItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "OverflowItems");
			DealerData.NativeFieldInfoPtr_HasBeenRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerData>.NativeClassPtr, "HasBeenRecommended");
			DealerData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStringArray_Il2CppStringArray_Single_ItemSet_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerData>.NativeClassPtr, 100669413);
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00118A50 File Offset: 0x00116C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135022, RefRangeEnd = 135023, XrefRangeStart = 135017, XrefRangeEnd = 135022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerData(string id, bool recruited, Il2CppStringArray assignedCustomerIDs, Il2CppStringArray activeContractGUIDs, float cash, ItemSet overflowItems, bool hasBeenRecommended) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recruited;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assignedCustomerIDs);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeContractGUIDs);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cash;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overflowItems);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeenRecommended;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerData.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStringArray_Il2CppStringArray_Single_ItemSet_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x000182C7 File Offset: 0x000164C7
		public DealerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x00118B00 File Offset: 0x00116D00
		// (set) Token: 0x06002F71 RID: 12145 RVA: 0x000182D0 File Offset: 0x000164D0
		public unsafe bool Recruited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Recruited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Recruited)) = value;
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x00118B28 File Offset: 0x00116D28
		// (set) Token: 0x06002F73 RID: 12147 RVA: 0x000182EB File Offset: 0x000164EB
		public unsafe Il2CppStringArray AssignedCustomerIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_AssignedCustomerIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_AssignedCustomerIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x00118B58 File Offset: 0x00116D58
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x0001830A File Offset: 0x0001650A
		public unsafe Il2CppStringArray ActiveContractGUIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_ActiveContractGUIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_ActiveContractGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x00118B88 File Offset: 0x00116D88
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x00018329 File Offset: 0x00016529
		public unsafe float Cash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Cash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_Cash)) = value;
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x00118BB0 File Offset: 0x00116DB0
		// (set) Token: 0x06002F79 RID: 12153 RVA: 0x00018344 File Offset: 0x00016544
		public unsafe ItemSet OverflowItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_OverflowItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_OverflowItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06002F7A RID: 12154 RVA: 0x00118BE0 File Offset: 0x00116DE0
		// (set) Token: 0x06002F7B RID: 12155 RVA: 0x00018363 File Offset: 0x00016563
		public unsafe bool HasBeenRecommended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_HasBeenRecommended);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerData.NativeFieldInfoPtr_HasBeenRecommended)) = value;
			}
		}

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeFieldInfoPtr_Recruited;

		// Token: 0x04002015 RID: 8213
		private static readonly IntPtr NativeFieldInfoPtr_AssignedCustomerIDs;

		// Token: 0x04002016 RID: 8214
		private static readonly IntPtr NativeFieldInfoPtr_ActiveContractGUIDs;

		// Token: 0x04002017 RID: 8215
		private static readonly IntPtr NativeFieldInfoPtr_Cash;

		// Token: 0x04002018 RID: 8216
		private static readonly IntPtr NativeFieldInfoPtr_OverflowItems;

		// Token: 0x04002019 RID: 8217
		private static readonly IntPtr NativeFieldInfoPtr_HasBeenRecommended;

		// Token: 0x0400201A RID: 8218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Il2CppStringArray_Il2CppStringArray_Single_ItemSet_Boolean_0;
	}
}

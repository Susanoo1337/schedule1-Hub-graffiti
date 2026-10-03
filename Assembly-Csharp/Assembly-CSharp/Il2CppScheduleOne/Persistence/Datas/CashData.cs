using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200020C RID: 524
	[Serializable]
	public class CashData : ItemData
	{
		// Token: 0x06002E24 RID: 11812 RVA: 0x0011508C File Offset: 0x0011328C
		// Note: this type is marked as 'beforefieldinit'.
		static CashData()
		{
			Il2CppClassPointerStore<CashData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CashData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CashData>.NativeClassPtr);
			CashData.NativeFieldInfoPtr_CashBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CashData>.NativeClassPtr, "CashBalance");
			CashData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CashData>.NativeClassPtr, 100669360);
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x001150E4 File Offset: 0x001132E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134753, RefRangeEnd = 134755, XrefRangeStart = 134751, XrefRangeEnd = 134753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CashData(string iD, int quantity, float cashBalance) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CashData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cashBalance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CashData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x000175CA File Offset: 0x000157CA
		public CashData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x0011514C File Offset: 0x0011334C
		// (set) Token: 0x06002E28 RID: 11816 RVA: 0x000175D3 File Offset: 0x000157D3
		public unsafe float CashBalance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashData.NativeFieldInfoPtr_CashBalance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CashData.NativeFieldInfoPtr_CashBalance)) = value;
			}
		}

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeFieldInfoPtr_CashBalance;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Single_0;
	}
}

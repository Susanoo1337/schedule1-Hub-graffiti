using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000210 RID: 528
	[Serializable]
	public class ItemData : SaveData
	{
		// Token: 0x06002E36 RID: 11830 RVA: 0x001153C4 File Offset: 0x001135C4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemData()
		{
			Il2CppClassPointerStore<ItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemData>.NativeClassPtr);
			ItemData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "ID");
			ItemData.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemData>.NativeClassPtr, "Quantity");
			ItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemData>.NativeClassPtr, 100669364);
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x00115430 File Offset: 0x00113630
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 134770, RefRangeEnd = 134777, XrefRangeStart = 134768, XrefRangeEnd = 134770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemData(string iD, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x00017678 File Offset: 0x00015878
		public ItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x0011548C File Offset: 0x0011368C
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x00017681 File Offset: 0x00015881
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x001154B4 File Offset: 0x001136B4
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x000176A0 File Offset: 0x000158A0
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemData.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x04001F8F RID: 8079
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04001F90 RID: 8080
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04001F91 RID: 8081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
	}
}

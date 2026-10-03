using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000224 RID: 548
	[Serializable]
	public class ItemFieldData : Object
	{
		// Token: 0x06002EAF RID: 11951 RVA: 0x0011681C File Offset: 0x00114A1C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFieldData()
		{
			Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr);
			ItemFieldData.NativeFieldInfoPtr_ItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr, "ItemID");
			ItemFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr, 100669385);
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x00116874 File Offset: 0x00114A74
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19776, RefRangeEnd = 19979, XrefRangeStart = 19776, XrefRangeEnd = 19979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldData(string itemID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00017B8E File Offset: 0x00015D8E
		public ItemFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x001168C0 File Offset: 0x00114AC0
		// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x00017B97 File Offset: 0x00015D97
		public unsafe string ItemID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldData.NativeFieldInfoPtr_ItemID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldData.NativeFieldInfoPtr_ItemID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeFieldInfoPtr_ItemID;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}

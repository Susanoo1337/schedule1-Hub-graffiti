using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026F RID: 623
	[Serializable]
	public class ShopManagerData : SaveData
	{
		// Token: 0x0600313B RID: 12603 RVA: 0x0011DF08 File Offset: 0x0011C108
		// Note: this type is marked as 'beforefieldinit'.
		static ShopManagerData()
		{
			Il2CppClassPointerStore<ShopManagerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ShopManagerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopManagerData>.NativeClassPtr);
			ShopManagerData.NativeFieldInfoPtr_Shops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopManagerData>.NativeClassPtr, "Shops");
			ShopManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ShopData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopManagerData>.NativeClassPtr, 100669467);
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x0011DF60 File Offset: 0x0011C160
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 134314, RefRangeEnd = 134323, XrefRangeStart = 134314, XrefRangeEnd = 134323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopManagerData(Il2CppReferenceArray<ShopData> shops) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopManagerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shops);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ShopData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x00019651 File Offset: 0x00017851
		public ShopManagerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x0011DFAC File Offset: 0x0011C1AC
		// (set) Token: 0x0600313F RID: 12607 RVA: 0x0001965A File Offset: 0x0001785A
		public unsafe Il2CppReferenceArray<ShopData> Shops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopManagerData.NativeFieldInfoPtr_Shops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ShopData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopManagerData.NativeFieldInfoPtr_Shops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020E6 RID: 8422
		private static readonly IntPtr NativeFieldInfoPtr_Shops;

		// Token: 0x040020E7 RID: 8423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ShopData_0;
	}
}

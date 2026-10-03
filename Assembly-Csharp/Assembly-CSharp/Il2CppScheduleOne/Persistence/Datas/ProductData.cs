using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000261 RID: 609
	[Serializable]
	public class ProductData : SaveData
	{
		// Token: 0x06003091 RID: 12433 RVA: 0x0011C214 File Offset: 0x0011A414
		// Note: this type is marked as 'beforefieldinit'.
		static ProductData()
		{
			Il2CppClassPointerStore<ProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductData>.NativeClassPtr);
			ProductData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "Name");
			ProductData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "ID");
			ProductData.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "DrugType");
			ProductData.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "Properties");
			ProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductData>.NativeClassPtr, 100669449);
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x0011C2A8 File Offset: 0x0011A4A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135241, RefRangeEnd = 135242, XrefRangeStart = 135237, XrefRangeEnd = 135241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductData(string name, string id, EDrugType drugType, Il2CppStringArray properties) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x00018EB7 File Offset: 0x000170B7
		public ProductData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06003094 RID: 12436 RVA: 0x0011C328 File Offset: 0x0011A528
		// (set) Token: 0x06003095 RID: 12437 RVA: 0x00018EC0 File Offset: 0x000170C0
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06003096 RID: 12438 RVA: 0x0011C350 File Offset: 0x0011A550
		// (set) Token: 0x06003097 RID: 12439 RVA: 0x00018EDF File Offset: 0x000170DF
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06003098 RID: 12440 RVA: 0x0011C378 File Offset: 0x0011A578
		// (set) Token: 0x06003099 RID: 12441 RVA: 0x00018EFE File Offset: 0x000170FE
		public unsafe EDrugType DrugType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x0600309A RID: 12442 RVA: 0x0011C3A0 File Offset: 0x0011A5A0
		// (set) Token: 0x0600309B RID: 12443 RVA: 0x00018F19 File Offset: 0x00017119
		public unsafe Il2CppStringArray Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002096 RID: 8342
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002097 RID: 8343
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04002098 RID: 8344
		private static readonly IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x04002099 RID: 8345
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x0400209A RID: 8346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0;
	}
}

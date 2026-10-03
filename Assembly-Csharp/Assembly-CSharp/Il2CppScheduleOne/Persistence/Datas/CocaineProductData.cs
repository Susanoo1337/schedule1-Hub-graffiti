using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200025F RID: 607
	[Serializable]
	public class CocaineProductData : ProductData
	{
		// Token: 0x06003087 RID: 12423 RVA: 0x0011BFDC File Offset: 0x0011A1DC
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineProductData()
		{
			Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CocaineProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr);
			CocaineProductData.NativeFieldInfoPtr_AppearanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr, "AppearanceSettings");
			CocaineProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr, 100669447);
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x0011C034 File Offset: 0x0011A234
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 135233, RefRangeEnd = 135237, XrefRangeStart = 135228, XrefRangeEnd = 135233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineProductData(string name, string id, EDrugType drugType, Il2CppStringArray properties, CocaineAppearanceSettings appearanceSettings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearanceSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003089 RID: 12425 RVA: 0x00018E67 File Offset: 0x00017067
		public CocaineProductData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x0011C0C8 File Offset: 0x0011A2C8
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x00018E70 File Offset: 0x00017070
		public unsafe CocaineAppearanceSettings AppearanceSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineProductData.NativeFieldInfoPtr_AppearanceSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineProductData.NativeFieldInfoPtr_AppearanceSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002092 RID: 8338
		private static readonly IntPtr NativeFieldInfoPtr_AppearanceSettings;

		// Token: 0x04002093 RID: 8339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_CocaineAppearanceSettings_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000263 RID: 611
	[Serializable]
	public class WeedProductData : ProductData
	{
		// Token: 0x060030A1 RID: 12449 RVA: 0x0011C4EC File Offset: 0x0011A6EC
		// Note: this type is marked as 'beforefieldinit'.
		static WeedProductData()
		{
			Il2CppClassPointerStore<WeedProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WeedProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedProductData>.NativeClassPtr);
			WeedProductData.NativeFieldInfoPtr_AppearanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedProductData>.NativeClassPtr, "AppearanceSettings");
			WeedProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_WeedAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedProductData>.NativeClassPtr, 100669451);
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x0011C544 File Offset: 0x0011A744
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 135233, RefRangeEnd = 135237, XrefRangeStart = 135233, XrefRangeEnd = 135237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedProductData(string name, string id, EDrugType drugType, Il2CppStringArray properties, WeedAppearanceSettings appearanceSettings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedProductData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearanceSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_WeedAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030A3 RID: 12451 RVA: 0x00018F60 File Offset: 0x00017160
		public WeedProductData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x0011C5D8 File Offset: 0x0011A7D8
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x00018F69 File Offset: 0x00017169
		public unsafe WeedAppearanceSettings AppearanceSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedProductData.NativeFieldInfoPtr_AppearanceSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeedAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedProductData.NativeFieldInfoPtr_AppearanceSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400209D RID: 8349
		private static readonly IntPtr NativeFieldInfoPtr_AppearanceSettings;

		// Token: 0x0400209E RID: 8350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_WeedAppearanceSettings_0;
	}
}

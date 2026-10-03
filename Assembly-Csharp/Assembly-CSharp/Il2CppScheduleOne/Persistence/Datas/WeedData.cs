using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000219 RID: 537
	[Serializable]
	public class WeedData : ProductItemData
	{
		// Token: 0x06002E63 RID: 11875 RVA: 0x00017877 File Offset: 0x00015A77
		// Note: this type is marked as 'beforefieldinit'.
		static WeedData()
		{
			Il2CppClassPointerStore<WeedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WeedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedData>.NativeClassPtr);
			WeedData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedData>.NativeClassPtr, 100669373);
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00115B3C File Offset: 0x00113D3C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 134763, RefRangeEnd = 134768, XrefRangeStart = 134763, XrefRangeEnd = 134768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x000178B0 File Offset: 0x00015AB0
		public WeedData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000216 RID: 534
	[Serializable]
	public class ShroomData : ProductItemData
	{
		// Token: 0x06002E56 RID: 11862 RVA: 0x000177E9 File Offset: 0x000159E9
		// Note: this type is marked as 'beforefieldinit'.
		static ShroomData()
		{
			Il2CppClassPointerStore<ShroomData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ShroomData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomData>.NativeClassPtr);
			ShroomData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomData>.NativeClassPtr, 100669370);
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x001158E0 File Offset: 0x00113AE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 134763, RefRangeEnd = 134768, XrefRangeStart = 134763, XrefRangeEnd = 134768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00017822 File Offset: 0x00015A22
		public ShroomData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}

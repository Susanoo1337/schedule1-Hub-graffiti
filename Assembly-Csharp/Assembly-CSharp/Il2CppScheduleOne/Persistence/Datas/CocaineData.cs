using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200020E RID: 526
	[Serializable]
	public class CocaineData : ProductItemData
	{
		// Token: 0x06002E2E RID: 11822 RVA: 0x00017612 File Offset: 0x00015812
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineData()
		{
			Il2CppClassPointerStore<CocaineData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CocaineData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineData>.NativeClassPtr);
			CocaineData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineData>.NativeClassPtr, 100669362);
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x0011525C File Offset: 0x0011345C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 134763, RefRangeEnd = 134768, XrefRangeStart = 134759, XrefRangeEnd = 134763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x0001764B File Offset: 0x0001584B
		public CocaineData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}

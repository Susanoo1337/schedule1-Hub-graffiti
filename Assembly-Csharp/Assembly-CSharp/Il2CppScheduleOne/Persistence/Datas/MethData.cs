using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000212 RID: 530
	[Serializable]
	public class MethData : ProductItemData
	{
		// Token: 0x06002E40 RID: 11840 RVA: 0x000176FD File Offset: 0x000158FD
		// Note: this type is marked as 'beforefieldinit'.
		static MethData()
		{
			Il2CppClassPointerStore<MethData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MethData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethData>.NativeClassPtr);
			MethData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethData>.NativeClassPtr, 100669366);
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x00115518 File Offset: 0x00113718
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 134763, RefRangeEnd = 134768, XrefRangeStart = 134763, XrefRangeEnd = 134768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x00017736 File Offset: 0x00015936
		public MethData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F93 RID: 8083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}

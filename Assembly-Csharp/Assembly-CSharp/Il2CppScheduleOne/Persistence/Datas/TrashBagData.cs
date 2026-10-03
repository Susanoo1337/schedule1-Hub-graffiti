using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000275 RID: 629
	public class TrashBagData : TrashItemData
	{
		// Token: 0x0600316F RID: 12655 RVA: 0x00019853 File Offset: 0x00017A53
		// Note: this type is marked as 'beforefieldinit'.
		static TrashBagData()
		{
			Il2CppClassPointerStore<TrashBagData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashBagData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashBagData>.NativeClassPtr);
			TrashBagData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashBagData>.NativeClassPtr, 100669475);
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x0011E778 File Offset: 0x0011C978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135503, RefRangeEnd = 135504, XrefRangeStart = 135488, XrefRangeEnd = 135503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashBagData(string trashID, string guid, Vector3 position, Quaternion rotation, TrashContentData contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashBagData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashBagData.NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x0001988C File Offset: 0x00017A8C
		public TrashBagData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040020FE RID: 8446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Vector3_Quaternion_TrashContentData_0;
	}
}

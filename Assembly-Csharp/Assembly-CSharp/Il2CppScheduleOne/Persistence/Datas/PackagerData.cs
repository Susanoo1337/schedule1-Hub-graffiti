using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000242 RID: 578
	[Serializable]
	public class PackagerData : EmployeeData
	{
		// Token: 0x06002F9C RID: 12188 RVA: 0x001190EC File Offset: 0x001172EC
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerData()
		{
			Il2CppClassPointerStore<PackagerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PackagerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerData>.NativeClassPtr);
			PackagerData.NativeFieldInfoPtr_MoveItemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerData>.NativeClassPtr, "MoveItemData");
			PackagerData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerData>.NativeClassPtr, 100669416);
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x00119144 File Offset: 0x00117344
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 135013, RefRangeEnd = 135017, XrefRangeStart = 135013, XrefRangeEnd = 135017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerData(string id, string assignedProperty, string firstName, string lastName, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday, MoveItemData moveItemData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assignedProperty);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paidForToday;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveItemData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x0001850B File Offset: 0x0001670B
		public PackagerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x00119230 File Offset: 0x00117430
		// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x00018514 File Offset: 0x00016714
		public unsafe MoveItemData MoveItemData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerData.NativeFieldInfoPtr_MoveItemData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerData.NativeFieldInfoPtr_MoveItemData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeFieldInfoPtr_MoveItemData;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_MoveItemData_0;
	}
}

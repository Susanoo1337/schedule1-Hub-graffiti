using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000240 RID: 576
	[Serializable]
	public class EmployeeData : NPCData
	{
		// Token: 0x06002F7C RID: 12156 RVA: 0x00118C08 File Offset: 0x00116E08
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeData()
		{
			Il2CppClassPointerStore<EmployeeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "EmployeeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr);
			EmployeeData.NativeFieldInfoPtr_AssignedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "AssignedProperty");
			EmployeeData.NativeFieldInfoPtr_FirstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "FirstName");
			EmployeeData.NativeFieldInfoPtr_LastName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "LastName");
			EmployeeData.NativeFieldInfoPtr_IsMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "IsMale");
			EmployeeData.NativeFieldInfoPtr_AppearanceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "AppearanceIndex");
			EmployeeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "Position");
			EmployeeData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "Rotation");
			EmployeeData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "GUID");
			EmployeeData.NativeFieldInfoPtr_PaidForToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "PaidForToday");
			EmployeeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, 100669414);
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00118D00 File Offset: 0x00116F00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135030, RefRangeEnd = 135031, XrefRangeStart = 135023, XrefRangeEnd = 135030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeData(string id, string assignedProperty, string firstName, string lastName, bool isMale, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assignedProperty);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paidForToday;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x0001837E File Offset: 0x0001657E
		public EmployeeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06002F7F RID: 12159 RVA: 0x00118DD8 File Offset: 0x00116FD8
		// (set) Token: 0x06002F80 RID: 12160 RVA: 0x00018387 File Offset: 0x00016587
		public unsafe string AssignedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AssignedProperty);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AssignedProperty), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06002F81 RID: 12161 RVA: 0x00118E00 File Offset: 0x00117000
		// (set) Token: 0x06002F82 RID: 12162 RVA: 0x000183A6 File Offset: 0x000165A6
		public unsafe string FirstName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_FirstName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_FirstName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06002F83 RID: 12163 RVA: 0x00118E28 File Offset: 0x00117028
		// (set) Token: 0x06002F84 RID: 12164 RVA: 0x000183C5 File Offset: 0x000165C5
		public unsafe string LastName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_LastName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_LastName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x00118E50 File Offset: 0x00117050
		// (set) Token: 0x06002F86 RID: 12166 RVA: 0x000183E4 File Offset: 0x000165E4
		public unsafe bool IsMale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_IsMale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_IsMale)) = value;
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x00118E78 File Offset: 0x00117078
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x000183FF File Offset: 0x000165FF
		public unsafe int AppearanceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AppearanceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AppearanceIndex)) = value;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x00118EA0 File Offset: 0x001170A0
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x0001841A File Offset: 0x0001661A
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06002F8B RID: 12171 RVA: 0x00118EC8 File Offset: 0x001170C8
		// (set) Token: 0x06002F8C RID: 12172 RVA: 0x00018435 File Offset: 0x00016635
		public unsafe Quaternion Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06002F8D RID: 12173 RVA: 0x00118EF0 File Offset: 0x001170F0
		// (set) Token: 0x06002F8E RID: 12174 RVA: 0x00018450 File Offset: 0x00016650
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06002F8F RID: 12175 RVA: 0x00118F18 File Offset: 0x00117118
		// (set) Token: 0x06002F90 RID: 12176 RVA: 0x0001846F File Offset: 0x0001666F
		public unsafe bool PaidForToday
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_PaidForToday);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_PaidForToday)) = value;
			}
		}

		// Token: 0x0400201B RID: 8219
		private static readonly IntPtr NativeFieldInfoPtr_AssignedProperty;

		// Token: 0x0400201C RID: 8220
		private static readonly IntPtr NativeFieldInfoPtr_FirstName;

		// Token: 0x0400201D RID: 8221
		private static readonly IntPtr NativeFieldInfoPtr_LastName;

		// Token: 0x0400201E RID: 8222
		private static readonly IntPtr NativeFieldInfoPtr_IsMale;

		// Token: 0x0400201F RID: 8223
		private static readonly IntPtr NativeFieldInfoPtr_AppearanceIndex;

		// Token: 0x04002020 RID: 8224
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04002021 RID: 8225
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04002022 RID: 8226
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002023 RID: 8227
		private static readonly IntPtr NativeFieldInfoPtr_PaidForToday;

		// Token: 0x04002024 RID: 8228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0;
	}
}

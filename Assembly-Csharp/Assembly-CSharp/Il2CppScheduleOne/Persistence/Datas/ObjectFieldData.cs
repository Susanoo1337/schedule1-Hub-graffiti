using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200022A RID: 554
	[Serializable]
	public class ObjectFieldData : Object
	{
		// Token: 0x06002ED7 RID: 11991 RVA: 0x00116EE0 File Offset: 0x001150E0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectFieldData()
		{
			Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ObjectFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr);
			ObjectFieldData.NativeFieldInfoPtr_ObjectGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr, "ObjectGUID");
			ObjectFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr, 100669391);
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00116F38 File Offset: 0x00115138
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19776, RefRangeEnd = 19979, XrefRangeStart = 19776, XrefRangeEnd = 19979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectFieldData(string objectGUID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00017D15 File Offset: 0x00015F15
		public ObjectFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06002EDA RID: 11994 RVA: 0x00116F84 File Offset: 0x00115184
		// (set) Token: 0x06002EDB RID: 11995 RVA: 0x00017D1E File Offset: 0x00015F1E
		public unsafe string ObjectGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldData.NativeFieldInfoPtr_ObjectGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldData.NativeFieldInfoPtr_ObjectGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeFieldInfoPtr_ObjectGUID;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}

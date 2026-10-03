using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200022B RID: 555
	[Serializable]
	public class ObjectListFieldData : Object
	{
		// Token: 0x06002EDC RID: 11996 RVA: 0x00116FAC File Offset: 0x001151AC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListFieldData()
		{
			Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ObjectListFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr);
			ObjectListFieldData.NativeFieldInfoPtr_ObjectGUIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr, "ObjectGUIDs");
			ObjectListFieldData.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr, 100669392);
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00117004 File Offset: 0x00115204
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19776, RefRangeEnd = 19979, XrefRangeStart = 19776, XrefRangeEnd = 19979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListFieldData(List<string> objectGUIDs) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectGUIDs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListFieldData.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x00017D3D File Offset: 0x00015F3D
		public ObjectListFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x00117050 File Offset: 0x00115250
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x00017D46 File Offset: 0x00015F46
		public unsafe List<string> ObjectGUIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldData.NativeFieldInfoPtr_ObjectGUIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListFieldData.NativeFieldInfoPtr_ObjectGUIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeFieldInfoPtr_ObjectGUIDs;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;
	}
}

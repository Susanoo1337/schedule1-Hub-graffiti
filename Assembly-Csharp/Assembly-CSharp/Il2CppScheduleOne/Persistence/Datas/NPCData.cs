using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200023A RID: 570
	public class NPCData : SaveData
	{
		// Token: 0x06002F4E RID: 12110 RVA: 0x001182C4 File Offset: 0x001164C4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCData()
		{
			Il2CppClassPointerStore<NPCData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCData>.NativeClassPtr);
			NPCData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "ID");
			NPCData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100669408);
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x0011831C File Offset: 0x0011651C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 134314, RefRangeEnd = 134323, XrefRangeStart = 134314, XrefRangeEnd = 134323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCData(string id) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x000181B2 File Offset: 0x000163B2
		public NPCData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06002F51 RID: 12113 RVA: 0x00118368 File Offset: 0x00116568
		// (set) Token: 0x06002F52 RID: 12114 RVA: 0x000181BB File Offset: 0x000163BB
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}

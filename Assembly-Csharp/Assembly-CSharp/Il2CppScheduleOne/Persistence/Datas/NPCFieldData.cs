using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000228 RID: 552
	[Serializable]
	public class NPCFieldData : Object
	{
		// Token: 0x06002ECD RID: 11981 RVA: 0x00116D4C File Offset: 0x00114F4C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCFieldData()
		{
			Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr);
			NPCFieldData.NativeFieldInfoPtr_NPCGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr, "NPCGuid");
			NPCFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr, 100669389);
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x00116DA4 File Offset: 0x00114FA4
		[CallerCount(203)]
		[CachedScanResults(RefRangeStart = 19776, RefRangeEnd = 19979, XrefRangeStart = 19776, XrefRangeEnd = 19979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldData(string npcGuid) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcGuid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00017CC9 File Offset: 0x00015EC9
		public NPCFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x00116DF0 File Offset: 0x00114FF0
		// (set) Token: 0x06002ED1 RID: 11985 RVA: 0x00017CD2 File Offset: 0x00015ED2
		public unsafe string NPCGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldData.NativeFieldInfoPtr_NPCGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldData.NativeFieldInfoPtr_NPCGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeFieldInfoPtr_NPCGuid;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}

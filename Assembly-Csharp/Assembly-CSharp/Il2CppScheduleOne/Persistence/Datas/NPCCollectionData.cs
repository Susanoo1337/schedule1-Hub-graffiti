using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000239 RID: 569
	public class NPCCollectionData : SaveData
	{
		// Token: 0x06002F49 RID: 12105 RVA: 0x001181F0 File Offset: 0x001163F0
		// Note: this type is marked as 'beforefieldinit'.
		static NPCCollectionData()
		{
			Il2CppClassPointerStore<NPCCollectionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCCollectionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCCollectionData>.NativeClassPtr);
			NPCCollectionData.NativeFieldInfoPtr_NPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCCollectionData>.NativeClassPtr, "NPCs");
			NPCCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCCollectionData>.NativeClassPtr, 100669407);
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00118248 File Offset: 0x00116448
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 134314, RefRangeEnd = 134323, XrefRangeStart = 134314, XrefRangeEnd = 134323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCCollectionData(Il2CppReferenceArray<DynamicSaveData> npcs) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCCollectionData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCCollectionData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DynamicSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x0001818A File Offset: 0x0001638A
		public NPCCollectionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06002F4C RID: 12108 RVA: 0x00118294 File Offset: 0x00116494
		// (set) Token: 0x06002F4D RID: 12109 RVA: 0x00018193 File Offset: 0x00016393
		public unsafe Il2CppReferenceArray<DynamicSaveData> NPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCCollectionData.NativeFieldInfoPtr_NPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCCollectionData.NativeFieldInfoPtr_NPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeFieldInfoPtr_NPCs;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DynamicSaveData_0;
	}
}

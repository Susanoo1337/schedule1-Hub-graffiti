using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027E RID: 638
	[Serializable]
	public class WorldStorageEntitiesData : SaveData
	{
		// Token: 0x060031B9 RID: 12729 RVA: 0x0011F374 File Offset: 0x0011D574
		// Note: this type is marked as 'beforefieldinit'.
		static WorldStorageEntitiesData()
		{
			Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WorldStorageEntitiesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr);
			WorldStorageEntitiesData.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr, "Entities");
			WorldStorageEntitiesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_WorldStorageEntityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr, 100669485);
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x0011F3CC File Offset: 0x0011D5CC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 134314, RefRangeEnd = 134323, XrefRangeStart = 134314, XrefRangeEnd = 134323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldStorageEntitiesData(Il2CppReferenceArray<WorldStorageEntityData> entities) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldStorageEntitiesData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntitiesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_WorldStorageEntityData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x00019B92 File Offset: 0x00017D92
		public WorldStorageEntitiesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x0011F418 File Offset: 0x0011D618
		// (set) Token: 0x060031BD RID: 12733 RVA: 0x00019B9B File Offset: 0x00017D9B
		public unsafe Il2CppReferenceArray<WorldStorageEntityData> Entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntitiesData.NativeFieldInfoPtr_Entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WorldStorageEntityData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntitiesData.NativeFieldInfoPtr_Entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400211F RID: 8479
		private static readonly IntPtr NativeFieldInfoPtr_Entities;

		// Token: 0x04002120 RID: 8480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_WorldStorageEntityData_0;
	}
}

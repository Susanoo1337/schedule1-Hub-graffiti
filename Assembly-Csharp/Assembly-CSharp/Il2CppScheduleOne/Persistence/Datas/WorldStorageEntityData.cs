using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027F RID: 639
	[Serializable]
	public class WorldStorageEntityData : SaveData
	{
		// Token: 0x060031BE RID: 12734 RVA: 0x0011F448 File Offset: 0x0011D648
		// Note: this type is marked as 'beforefieldinit'.
		static WorldStorageEntityData()
		{
			Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WorldStorageEntityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr);
			WorldStorageEntityData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, "GUID");
			WorldStorageEntityData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, "Contents");
			WorldStorageEntityData.NativeFieldInfoPtr_LastContentChangeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, "LastContentChangeTime");
			WorldStorageEntityData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, 100669486);
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x0011F4C8 File Offset: 0x0011D6C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135558, RefRangeEnd = 135559, XrefRangeStart = 135554, XrefRangeEnd = 135558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldStorageEntityData(Guid guid, ItemSet contents, GameDateTime lastContentChangeTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastContentChangeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntityData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00019BBA File Offset: 0x00017DBA
		public WorldStorageEntityData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x0011F530 File Offset: 0x0011D730
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x00019BC3 File Offset: 0x00017DC3
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x0011F558 File Offset: 0x0011D758
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x00019BE2 File Offset: 0x00017DE2
		public unsafe ItemSet Contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_Contents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x0011F588 File Offset: 0x0011D788
		// (set) Token: 0x060031C6 RID: 12742 RVA: 0x00019C01 File Offset: 0x00017E01
		public unsafe GameDateTime LastContentChangeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_LastContentChangeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_LastContentChangeTime)) = value;
			}
		}

		// Token: 0x04002121 RID: 8481
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002122 RID: 8482
		private static readonly IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x04002123 RID: 8483
		private static readonly IntPtr NativeFieldInfoPtr_LastContentChangeTime;

		// Token: 0x04002124 RID: 8484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_GameDateTime_0;
	}
}

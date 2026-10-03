using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000246 RID: 582
	[Serializable]
	public class BuildableItemData : SaveData
	{
		// Token: 0x06002FBA RID: 12218 RVA: 0x00119710 File Offset: 0x00117910
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItemData()
		{
			Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BuildableItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr);
			BuildableItemData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "GUID");
			BuildableItemData.NativeFieldInfoPtr_ItemString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "ItemString");
			BuildableItemData.NativeFieldInfoPtr_LoadOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "LoadOrder");
			BuildableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, 100669420);
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x00119790 File Offset: 0x00117990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135071, RefRangeEnd = 135072, XrefRangeStart = 135067, XrefRangeEnd = 135071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemData(Guid guid, ItemInstance item, int loadOrder) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x0001862E File Offset: 0x0001682E
		public BuildableItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06002FBD RID: 12221 RVA: 0x001197F8 File Offset: 0x001179F8
		// (set) Token: 0x06002FBE RID: 12222 RVA: 0x00018637 File Offset: 0x00016837
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06002FBF RID: 12223 RVA: 0x00119820 File Offset: 0x00117A20
		// (set) Token: 0x06002FC0 RID: 12224 RVA: 0x00018656 File Offset: 0x00016856
		public unsafe string ItemString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_ItemString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_ItemString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06002FC1 RID: 12225 RVA: 0x00119848 File Offset: 0x00117A48
		// (set) Token: 0x06002FC2 RID: 12226 RVA: 0x00018675 File Offset: 0x00016875
		public unsafe int LoadOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_LoadOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_LoadOrder)) = value;
			}
		}

		// Token: 0x04002037 RID: 8247
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002038 RID: 8248
		private static readonly IntPtr NativeFieldInfoPtr_ItemString;

		// Token: 0x04002039 RID: 8249
		private static readonly IntPtr NativeFieldInfoPtr_LoadOrder;

		// Token: 0x0400203A RID: 8250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0;
	}
}

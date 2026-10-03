using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001F8 RID: 504
	public class StorageSurfaceItemLoader : SurfaceItemLoader
	{
		// Token: 0x06002D50 RID: 11600 RVA: 0x001123F4 File Offset: 0x001105F4
		// Note: this type is marked as 'beforefieldinit'.
		static StorageSurfaceItemLoader()
		{
			Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "StorageSurfaceItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr);
			StorageSurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr, 100669278);
			StorageSurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr, 100669279);
			StorageSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr, 100669280);
			StorageSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr, 100669281);
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x00112474 File Offset: 0x00110674
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133713, XrefRangeEnd = 133720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageSurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x001124B8 File Offset: 0x001106B8
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 132040, RefRangeEnd = 132062, XrefRangeStart = 132040, XrefRangeEnd = 132062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageSurfaceItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageSurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x001124F4 File Offset: 0x001106F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133720, XrefRangeEnd = 133743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x00112544 File Offset: 0x00110744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133743, XrefRangeEnd = 133803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00016F2E File Offset: 0x0001512E
		public StorageSurfaceItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;
	}
}

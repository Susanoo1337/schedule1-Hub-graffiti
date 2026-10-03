using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001FB RID: 507
	public class ToggleableSurfaceItemLoader : SurfaceItemLoader
	{
		// Token: 0x06002D64 RID: 11620 RVA: 0x0011299C File Offset: 0x00110B9C
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableSurfaceItemLoader()
		{
			Il2CppClassPointerStore<ToggleableSurfaceItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ToggleableSurfaceItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableSurfaceItemLoader>.NativeClassPtr);
			ToggleableSurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItemLoader>.NativeClassPtr, 100669292);
			ToggleableSurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItemLoader>.NativeClassPtr, 100669293);
			ToggleableSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItemLoader>.NativeClassPtr, 100669294);
			ToggleableSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItemLoader>.NativeClassPtr, 100669295);
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x00112A1C File Offset: 0x00110C1C
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133939, XrefRangeEnd = 133946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002D66 RID: 11622 RVA: 0x00112A60 File Offset: 0x00110C60
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 132040, RefRangeEnd = 132062, XrefRangeStart = 132040, XrefRangeEnd = 132062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableSurfaceItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableSurfaceItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x00112A9C File Offset: 0x00110C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133946, XrefRangeEnd = 133971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x00112AEC File Offset: 0x00110CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133971, XrefRangeEnd = 134025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00016F49 File Offset: 0x00015149
		public ToggleableSurfaceItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;
	}
}

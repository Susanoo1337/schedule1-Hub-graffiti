using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001F9 RID: 505
	public class SurfaceItemLoader : BuildableItemLoader
	{
		// Token: 0x06002D56 RID: 11606 RVA: 0x00112594 File Offset: 0x00110794
		// Note: this type is marked as 'beforefieldinit'.
		static SurfaceItemLoader()
		{
			Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "SurfaceItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr);
			SurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr, 100669282);
			SurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr, 100669283);
			SurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr, 100669284);
			SurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr, 100669285);
			SurfaceItemLoader.NativeMethodInfoPtr_LoadAndCreate_Protected_SurfaceItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr, 100669286);
			SurfaceItemLoader.NativeMethodInfoPtr_LoadAndCreate_Protected_SurfaceItem_SurfaceItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr, 100669287);
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002D57 RID: 11607 RVA: 0x0011263C File Offset: 0x0011083C
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133803, XrefRangeEnd = 133810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x00112680 File Offset: 0x00110880
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 132040, RefRangeEnd = 132062, XrefRangeStart = 132040, XrefRangeEnd = 132062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x001126BC File Offset: 0x001108BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133810, XrefRangeEnd = 133811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x0011270C File Offset: 0x0011090C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133811, XrefRangeEnd = 133838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x0011275C File Offset: 0x0011095C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 133842, RefRangeEnd = 133846, XrefRangeStart = 133838, XrefRangeEnd = 133842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItem LoadAndCreate(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItemLoader.NativeMethodInfoPtr_LoadAndCreate_Protected_SurfaceItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr3) : null;
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x001127AC File Offset: 0x001109AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133846, XrefRangeEnd = 133854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItem LoadAndCreate(SurfaceItemData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItemLoader.NativeMethodInfoPtr_LoadAndCreate_Protected_SurfaceItem_SurfaceItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr3) : null;
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x00016F37 File Offset: 0x00015137
		public SurfaceItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndCreate_Protected_SurfaceItem_String_0;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndCreate_Protected_SurfaceItem_SurfaceItemData_0;
	}
}

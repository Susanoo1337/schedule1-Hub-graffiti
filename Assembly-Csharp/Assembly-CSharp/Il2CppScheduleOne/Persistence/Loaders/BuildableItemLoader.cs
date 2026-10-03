using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001E8 RID: 488
	public class BuildableItemLoader : Loader
	{
		// Token: 0x06002CEA RID: 11498 RVA: 0x001107B0 File Offset: 0x0010E9B0
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItemLoader()
		{
			Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "BuildableItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr);
			BuildableItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100669174);
			BuildableItemLoader.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100669175);
			BuildableItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100669176);
			BuildableItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100669177);
			BuildableItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100669178);
			BuildableItemLoader.NativeMethodInfoPtr_GetBuildableItemData_Public_BuildableItemData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100669179);
			BuildableItemLoader.NativeMethodInfoPtr_GetData_Protected_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr, 100669180);
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x0011086C File Offset: 0x0010EA6C
		public unsafe virtual string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131553, XrefRangeEnd = 131560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x06002CEC RID: 11500 RVA: 0x001108B0 File Offset: 0x0010EAB0
		public unsafe virtual int LoadOrder
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItemLoader.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x001108F8 File Offset: 0x0010EAF8
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 131571, RefRangeEnd = 131590, XrefRangeStart = 131560, XrefRangeEnd = 131571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00110934 File Offset: 0x0010EB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131590, XrefRangeEnd = 131602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x00110984 File Offset: 0x0010EB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131602, XrefRangeEnd = 131619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(DynamicSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x001109D4 File Offset: 0x0010EBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131619, XrefRangeEnd = 131622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemData GetBuildableItemData(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemLoader.NativeMethodInfoPtr_GetBuildableItemData_Public_BuildableItemData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr3) : null;
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00110A24 File Offset: 0x0010EC24
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 131626, RefRangeEnd = 131645, XrefRangeStart = 131622, XrefRangeEnd = 131626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetData<T>(string mainPath) where T : BuildableItemData
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemLoader.MethodInfoStoreGeneric_GetData_Protected_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00016E9E File Offset: 0x0001509E
		public BuildableItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_New_get_String_0;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_DynamicSaveData_0;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeMethodInfoPtr_GetBuildableItemData_Public_BuildableItemData_String_0;

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Protected_T_String_0;

		// Token: 0x020009D4 RID: 2516
		private sealed class MethodInfoStoreGeneric_GetData_Protected_T_String_0<T>
		{
			// Token: 0x04009651 RID: 38481
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BuildableItemLoader.NativeMethodInfoPtr_GetData_Protected_T_String_0, Il2CppClassPointerStore<BuildableItemLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}

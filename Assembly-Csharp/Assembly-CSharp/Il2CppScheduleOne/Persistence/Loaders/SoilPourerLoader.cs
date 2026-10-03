using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001F6 RID: 502
	public class SoilPourerLoader : GridItemLoader
	{
		// Token: 0x06002D45 RID: 11589 RVA: 0x00112118 File Offset: 0x00110318
		// Note: this type is marked as 'beforefieldinit'.
		static SoilPourerLoader()
		{
			Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "SoilPourerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr);
			SoilPourerLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr, 100669269);
			SoilPourerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr, 100669270);
			SoilPourerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr, 100669271);
			SoilPourerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr, 100669272);
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002D46 RID: 11590 RVA: 0x00112198 File Offset: 0x00110398
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133516, XrefRangeEnd = 133523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourerLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x001121DC File Offset: 0x001103DC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 132040, RefRangeEnd = 132062, XrefRangeStart = 132040, XrefRangeEnd = 132062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilPourerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x00112218 File Offset: 0x00110418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133523, XrefRangeEnd = 133548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x00112268 File Offset: 0x00110468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133548, XrefRangeEnd = 133607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x00016F1C File Offset: 0x0001511C
		public SoilPourerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;
	}
}

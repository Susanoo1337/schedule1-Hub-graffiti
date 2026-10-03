using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001D7 RID: 471
	public class VehicleLoader : Loader
	{
		// Token: 0x06002C95 RID: 11413 RVA: 0x0010F280 File Offset: 0x0010D480
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleLoader()
		{
			Il2CppClassPointerStore<VehicleLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "VehicleLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleLoader>.NativeClassPtr);
			VehicleLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLoader>.NativeClassPtr, 100669083);
			VehicleLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLoader>.NativeClassPtr, 100669084);
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x0010F2D8 File Offset: 0x0010D4D8
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x0010F314 File Offset: 0x0010D514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130107, XrefRangeEnd = 130131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x00016E05 File Offset: 0x00015005
		public VehicleLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E97 RID: 7831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}

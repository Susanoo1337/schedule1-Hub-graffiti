using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001BB RID: 443
	public class CartelLoader : Loader
	{
		// Token: 0x06002C15 RID: 11285 RVA: 0x0010D298 File Offset: 0x0010B498
		// Note: this type is marked as 'beforefieldinit'.
		static CartelLoader()
		{
			Il2CppClassPointerStore<CartelLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "CartelLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelLoader>.NativeClassPtr);
			CartelLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelLoader>.NativeClassPtr, 100668994);
			CartelLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelLoader>.NativeClassPtr, 100668995);
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x0010D2F0 File Offset: 0x0010B4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128260, XrefRangeEnd = 128408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x0010D340 File Offset: 0x0010B540
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x00016D09 File Offset: 0x00014F09
		public CartelLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

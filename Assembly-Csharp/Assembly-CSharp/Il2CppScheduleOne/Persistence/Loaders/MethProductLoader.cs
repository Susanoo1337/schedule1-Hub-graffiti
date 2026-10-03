using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001C5 RID: 453
	public class MethProductLoader : Loader
	{
		// Token: 0x06002C48 RID: 11336 RVA: 0x0010E060 File Offset: 0x0010C260
		// Note: this type is marked as 'beforefieldinit'.
		static MethProductLoader()
		{
			Il2CppClassPointerStore<MethProductLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "MethProductLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethProductLoader>.NativeClassPtr);
			MethProductLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethProductLoader>.NativeClassPtr, 100669025);
			MethProductLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethProductLoader>.NativeClassPtr, 100669026);
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x0010E0B8 File Offset: 0x0010C2B8
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethProductLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethProductLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethProductLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x0010E0F4 File Offset: 0x0010C2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128826, XrefRangeEnd = 128843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethProductLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x00016D63 File Offset: 0x00014F63
		public MethProductLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E6E RID: 7790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}

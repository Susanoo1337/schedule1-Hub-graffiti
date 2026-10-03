using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001D2 RID: 466
	public class ShroomProductLoader : Loader
	{
		// Token: 0x06002C81 RID: 11393 RVA: 0x0010EE0C File Offset: 0x0010D00C
		// Note: this type is marked as 'beforefieldinit'.
		static ShroomProductLoader()
		{
			Il2CppClassPointerStore<ShroomProductLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ShroomProductLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomProductLoader>.NativeClassPtr);
			ShroomProductLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomProductLoader>.NativeClassPtr, 100669073);
			ShroomProductLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomProductLoader>.NativeClassPtr, 100669074);
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x0010EE64 File Offset: 0x0010D064
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomProductLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomProductLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomProductLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0010EEA0 File Offset: 0x0010D0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129853, XrefRangeEnd = 129870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomProductLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x00016DD8 File Offset: 0x00014FD8
		public ShroomProductLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E8D RID: 7821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E8E RID: 7822
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}

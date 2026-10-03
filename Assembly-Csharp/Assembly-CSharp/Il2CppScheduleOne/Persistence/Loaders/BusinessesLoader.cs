using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001B9 RID: 441
	public class BusinessesLoader : Loader
	{
		// Token: 0x06002C0D RID: 11277 RVA: 0x0010D0D0 File Offset: 0x0010B2D0
		// Note: this type is marked as 'beforefieldinit'.
		static BusinessesLoader()
		{
			Il2CppClassPointerStore<BusinessesLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "BusinessesLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BusinessesLoader>.NativeClassPtr);
			BusinessesLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessesLoader>.NativeClassPtr, 100668990);
			BusinessesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessesLoader>.NativeClassPtr, 100668991);
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x0010D128 File Offset: 0x0010B328
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BusinessesLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BusinessesLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessesLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x0010D164 File Offset: 0x0010B364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128200, XrefRangeEnd = 128236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BusinessesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x00016CF7 File Offset: 0x00014EF7
		public BusinessesLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}

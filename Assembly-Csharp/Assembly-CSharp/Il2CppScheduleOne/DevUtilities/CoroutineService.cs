using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x020003EC RID: 1004
	public class CoroutineService : PersistentSingleton<CoroutineService>
	{
		// Token: 0x06005977 RID: 22903 RVA: 0x0002A6BE File Offset: 0x000288BE
		// Note: this type is marked as 'beforefieldinit'.
		static CoroutineService()
		{
			Il2CppClassPointerStore<CoroutineService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CoroutineService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr);
			CoroutineService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr, 100675006);
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x001B00E4 File Offset: 0x001AE2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194048, XrefRangeEnd = 194051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoroutineService() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoroutineService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x0002A6F7 File Offset: 0x000288F7
		public CoroutineService(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003D6A RID: 15722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

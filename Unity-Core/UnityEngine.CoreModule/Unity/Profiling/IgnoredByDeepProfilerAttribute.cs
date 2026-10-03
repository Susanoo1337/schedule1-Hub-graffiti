using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Profiling
{
	// Token: 0x02000018 RID: 24
	public sealed class IgnoredByDeepProfilerAttribute : Attribute
	{
		// Token: 0x06000099 RID: 153 RVA: 0x000024E5 File Offset: 0x000006E5
		// Note: this type is marked as 'beforefieldinit'.
		static IgnoredByDeepProfilerAttribute()
		{
			Il2CppClassPointerStore<IgnoredByDeepProfilerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "IgnoredByDeepProfilerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IgnoredByDeepProfilerAttribute>.NativeClassPtr);
			IgnoredByDeepProfilerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IgnoredByDeepProfilerAttribute>.NativeClassPtr, 100663368);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0001A61C File Offset: 0x0001881C
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IgnoredByDeepProfilerAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IgnoredByDeepProfilerAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IgnoredByDeepProfilerAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000251E File Offset: 0x0000071E
		public IgnoredByDeepProfilerAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

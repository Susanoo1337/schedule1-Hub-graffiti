using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000148 RID: 328
	public class ScriptingRuntime : Object
	{
		// Token: 0x0600190D RID: 6413 RVA: 0x0000C413 File Offset: 0x0000A613
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptingRuntime()
		{
			Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptingRuntime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr);
			ScriptingRuntime.NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr, 100665956);
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x0006B0F4 File Offset: 0x000692F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1260699, RefRangeEnd = 1260701, XrefRangeStart = 1260697, XrefRangeEnd = 1260699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetAllUserAssemblies()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingRuntime.NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x0000C44C File Offset: 0x0000A64C
		public ScriptingRuntime(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0;
	}
}

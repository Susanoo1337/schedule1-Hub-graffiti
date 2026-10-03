using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000155 RID: 341
	public sealed class WaitForFixedUpdate : YieldInstruction
	{
		// Token: 0x060019B4 RID: 6580 RVA: 0x0000C718 File Offset: 0x0000A918
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForFixedUpdate()
		{
			Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForFixedUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr);
			WaitForFixedUpdate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr, 100666058);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0006DA40 File Offset: 0x0006BC40
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForFixedUpdate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForFixedUpdate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x0000C751 File Offset: 0x0000A951
		public WaitForFixedUpdate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

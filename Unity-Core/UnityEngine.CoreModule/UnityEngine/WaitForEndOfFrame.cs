using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000154 RID: 340
	public sealed class WaitForEndOfFrame : YieldInstruction
	{
		// Token: 0x060019B1 RID: 6577 RVA: 0x0000C6D6 File Offset: 0x0000A8D6
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForEndOfFrame()
		{
			Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForEndOfFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr);
			WaitForEndOfFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr, 100666057);
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0006DA04 File Offset: 0x0006BC04
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForEndOfFrame() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForEndOfFrame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForEndOfFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0000C70F File Offset: 0x0000A90F
		public WaitForEndOfFrame(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

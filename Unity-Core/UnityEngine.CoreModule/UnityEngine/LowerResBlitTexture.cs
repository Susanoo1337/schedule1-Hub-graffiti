using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000160 RID: 352
	public class LowerResBlitTexture : Object
	{
		// Token: 0x06001A59 RID: 6745 RVA: 0x0000CD50 File Offset: 0x0000AF50
		// Note: this type is marked as 'beforefieldinit'.
		static LowerResBlitTexture()
		{
			Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LowerResBlitTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr);
			LowerResBlitTexture.NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr, 100666114);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0006F894 File Offset: 0x0006DA94
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LowerResBlitTextureDontStripMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowerResBlitTexture.NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0000CD89 File Offset: 0x0000AF89
		public LowerResBlitTexture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040015C0 RID: 5568
		private static readonly IntPtr NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000161 RID: 353
	public class PreloadData : Object
	{
		// Token: 0x06001A5C RID: 6748 RVA: 0x0000CD92 File Offset: 0x0000AF92
		// Note: this type is marked as 'beforefieldinit'.
		static PreloadData()
		{
			Il2CppClassPointerStore<PreloadData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PreloadData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreloadData>.NativeClassPtr);
			PreloadData.NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadData>.NativeClassPtr, 100666115);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0006F8C8 File Offset: 0x0006DAC8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreloadDataDontStripMe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreloadData.NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0000CDCB File Offset: 0x0000AFCB
		public PreloadData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040015C1 RID: 5569
		private static readonly IntPtr NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0;
	}
}

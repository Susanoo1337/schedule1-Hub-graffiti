using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D
{
	// Token: 0x02000178 RID: 376
	public static class PixelPerfectRendering : Object
	{
		// Token: 0x06001D02 RID: 7426 RVA: 0x00078418 File Offset: 0x00076618
		// Note: this type is marked as 'beforefieldinit'.
		static PixelPerfectRendering()
		{
			Il2CppClassPointerStore<PixelPerfectRendering>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "PixelPerfectRendering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PixelPerfectRendering>.NativeClassPtr);
			PixelPerfectRendering.NativeMethodInfoPtr_set_pixelSnapSpacing_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PixelPerfectRendering>.NativeClassPtr, 100666434);
			PixelPerfectRendering.get_pixelSnapSpacingDelegateField = IL2CPP.ResolveICall<PixelPerfectRendering.get_pixelSnapSpacingDelegate>("UnityEngine.U2D.PixelPerfectRendering::get_pixelSnapSpacing");
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0000DA24 File Offset: 0x0000BC24
		// (set) Token: 0x06001D03 RID: 7427 RVA: 0x0007846C File Offset: 0x0007666C
		public unsafe static float pixelSnapSpacing
		{
			get
			{
				return PixelPerfectRendering.get_pixelSnapSpacingDelegateField();
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1282222, RefRangeEnd = 1282224, XrefRangeStart = 1282220, XrefRangeEnd = 1282222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PixelPerfectRendering.NativeMethodInfoPtr_set_pixelSnapSpacing_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x0000DA1B File Offset: 0x0000BC1B
		public PixelPerfectRendering(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040017E6 RID: 6118
		private static readonly IntPtr NativeMethodInfoPtr_set_pixelSnapSpacing_Public_Static_set_Void_Single_0;

		// Token: 0x040017E7 RID: 6119
		private static readonly PixelPerfectRendering.get_pixelSnapSpacingDelegate get_pixelSnapSpacingDelegateField;

		// Token: 0x020009BD RID: 2493
		// (Invoke) Token: 0x06003BFB RID: 15355
		private delegate float get_pixelSnapSpacingDelegate();
	}
}

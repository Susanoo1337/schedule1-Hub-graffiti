using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020001E6 RID: 486
	public static class CameraEventUtils : Object
	{
		// Token: 0x0600217D RID: 8573 RVA: 0x0000F65C File Offset: 0x0000D85C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraEventUtils()
		{
			Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CameraEventUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr);
			CameraEventUtils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr, 100666948);
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00087DA4 File Offset: 0x00085FA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1287294, RefRangeEnd = 1287296, XrefRangeStart = 1287294, XrefRangeEnd = 1287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(CameraEvent value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraEventUtils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x0000F695 File Offset: 0x0000D895
		public CameraEventUtils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001B73 RID: 7027
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0;

		// Token: 0x04001B74 RID: 7028
		public const CameraEvent k_MinimumValue = CameraEvent.BeforeDepthTexture;

		// Token: 0x04001B75 RID: 7029
		public const CameraEvent k_MaximumValue = CameraEvent.AfterHaloAndLensFlares;
	}
}

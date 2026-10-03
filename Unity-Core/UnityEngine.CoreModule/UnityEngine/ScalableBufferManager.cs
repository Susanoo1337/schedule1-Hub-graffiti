using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000098 RID: 152
	public static class ScalableBufferManager : Object
	{
		// Token: 0x06000939 RID: 2361 RVA: 0x00034B28 File Offset: 0x00032D28
		// Note: this type is marked as 'beforefieldinit'.
		static ScalableBufferManager()
		{
			Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScalableBufferManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr);
			ScalableBufferManager.NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664244);
			ScalableBufferManager.NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664245);
			ScalableBufferManager.NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664246);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00034B94 File Offset: 0x00032D94
		public unsafe static float widthScaleFactor
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1234315, RefRangeEnd = 1234324, XrefRangeStart = 1234313, XrefRangeEnd = 1234315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableBufferManager.NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00034BC4 File Offset: 0x00032DC4
		public unsafe static float heightScaleFactor
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1234326, RefRangeEnd = 1234335, XrefRangeStart = 1234324, XrefRangeEnd = 1234326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableBufferManager.NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00034BF4 File Offset: 0x00032DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234335, XrefRangeEnd = 1234337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResizeBuffers(float widthScale, float heightScale)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref widthScale;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableBufferManager.NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00005F75 File Offset: 0x00004175
		public ScalableBufferManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0;
	}
}

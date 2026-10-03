using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A3 RID: 163
	public sealed class ImageEffectAllowedInSceneView : Attribute
	{
		// Token: 0x06000A57 RID: 2647 RVA: 0x0000692B File Offset: 0x00004B2B
		// Note: this type is marked as 'beforefieldinit'.
		static ImageEffectAllowedInSceneView()
		{
			Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ImageEffectAllowedInSceneView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr);
			ImageEffectAllowedInSceneView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr, 100664303);
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0003709C File Offset: 0x0003529C
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageEffectAllowedInSceneView() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageEffectAllowedInSceneView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageEffectAllowedInSceneView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00006964 File Offset: 0x00004B64
		public ImageEffectAllowedInSceneView(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

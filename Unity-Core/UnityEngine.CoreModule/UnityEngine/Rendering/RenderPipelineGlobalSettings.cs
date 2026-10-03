using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000231 RID: 561
	public class RenderPipelineGlobalSettings : ScriptableObject
	{
		// Token: 0x0600260A RID: 9738 RVA: 0x00011532 File Offset: 0x0000F732
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipelineGlobalSettings()
		{
			Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineGlobalSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr);
			RenderPipelineGlobalSettings.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100667385);
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00097AB4 File Offset: 0x00095CB4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 79617, RefRangeEnd = 79648, XrefRangeStart = 79617, XrefRangeEnd = 79648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipelineGlobalSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineGlobalSettings.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x0001156B File Offset: 0x0000F76B
		public RenderPipelineGlobalSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002097 RID: 8343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}

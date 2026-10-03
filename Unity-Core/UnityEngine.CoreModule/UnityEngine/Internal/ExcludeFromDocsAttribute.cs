using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Internal
{
	// Token: 0x020001D1 RID: 465
	[Serializable]
	public class ExcludeFromDocsAttribute : Attribute
	{
		// Token: 0x06002120 RID: 8480 RVA: 0x0000F513 File Offset: 0x0000D713
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromDocsAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Internal", "ExcludeFromDocsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr);
			ExcludeFromDocsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr, 100666917);
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00086A58 File Offset: 0x00084C58
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromDocsAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromDocsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x0000F54C File Offset: 0x0000D74C
		public ExcludeFromDocsAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting
{
	// Token: 0x020001AD RID: 429
	public class AlwaysLinkAssemblyAttribute : Attribute
	{
		// Token: 0x06001FBE RID: 8126 RVA: 0x0000EAD2 File Offset: 0x0000CCD2
		// Note: this type is marked as 'beforefieldinit'.
		static AlwaysLinkAssemblyAttribute()
		{
			Il2CppClassPointerStore<AlwaysLinkAssemblyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting", "AlwaysLinkAssemblyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlwaysLinkAssemblyAttribute>.NativeClassPtr);
			AlwaysLinkAssemblyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AlwaysLinkAssemblyAttribute>.NativeClassPtr, 100666768);
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x00082700 File Offset: 0x00080900
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AlwaysLinkAssemblyAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlwaysLinkAssemblyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AlwaysLinkAssemblyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0000EB0B File Offset: 0x0000CD0B
		public AlwaysLinkAssemblyAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040019CC RID: 6604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting
{
	// Token: 0x020001AF RID: 431
	public class RequireImplementorsAttribute : Attribute
	{
		// Token: 0x06001FC4 RID: 8132 RVA: 0x0000EB56 File Offset: 0x0000CD56
		// Note: this type is marked as 'beforefieldinit'.
		static RequireImplementorsAttribute()
		{
			Il2CppClassPointerStore<RequireImplementorsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting", "RequireImplementorsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequireImplementorsAttribute>.NativeClassPtr);
			RequireImplementorsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireImplementorsAttribute>.NativeClassPtr, 100666770);
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00082778 File Offset: 0x00080978
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequireImplementorsAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireImplementorsAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequireImplementorsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x0000EB8F File Offset: 0x0000CD8F
		public RequireImplementorsAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040019CE RID: 6606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

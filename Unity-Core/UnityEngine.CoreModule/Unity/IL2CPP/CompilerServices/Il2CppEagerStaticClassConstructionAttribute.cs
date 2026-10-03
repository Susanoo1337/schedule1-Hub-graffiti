using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IL2CPP.CompilerServices
{
	// Token: 0x02000017 RID: 23
	public class Il2CppEagerStaticClassConstructionAttribute : Attribute
	{
		// Token: 0x06000096 RID: 150 RVA: 0x000024A3 File Offset: 0x000006A3
		// Note: this type is marked as 'beforefieldinit'.
		static Il2CppEagerStaticClassConstructionAttribute()
		{
			Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IL2CPP.CompilerServices", "Il2CppEagerStaticClassConstructionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr);
			Il2CppEagerStaticClassConstructionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr, 100663367);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0001A5E0 File Offset: 0x000187E0
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppEagerStaticClassConstructionAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppEagerStaticClassConstructionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000024DC File Offset: 0x000006DC
		public Il2CppEagerStaticClassConstructionAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000138 RID: 312
	public class ExcludeFromObjectFactoryAttribute : Attribute
	{
		// Token: 0x0600183B RID: 6203 RVA: 0x0000C09E File Offset: 0x0000A29E
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromObjectFactoryAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExcludeFromObjectFactoryAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr);
			ExcludeFromObjectFactoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr, 100665842);
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00067E54 File Offset: 0x00066054
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromObjectFactoryAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromObjectFactoryAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromObjectFactoryAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0000C0D7 File Offset: 0x0000A2D7
		public ExcludeFromObjectFactoryAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004F RID: 79
	public sealed class NativeSetThreadIndexAttribute : Attribute
	{
		// Token: 0x06000299 RID: 665 RVA: 0x00003562 File Offset: 0x00001762
		// Note: this type is marked as 'beforefieldinit'.
		static NativeSetThreadIndexAttribute()
		{
			Il2CppClassPointerStore<NativeSetThreadIndexAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeSetThreadIndexAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeSetThreadIndexAttribute>.NativeClassPtr);
			NativeSetThreadIndexAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeSetThreadIndexAttribute>.NativeClassPtr, 100663536);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001F5F8 File Offset: 0x0001D7F8
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeSetThreadIndexAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeSetThreadIndexAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeSetThreadIndexAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000359B File Offset: 0x0000179B
		public NativeSetThreadIndexAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

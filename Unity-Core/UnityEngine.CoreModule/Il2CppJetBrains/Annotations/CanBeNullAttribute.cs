using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppJetBrains.Annotations
{
	// Token: 0x0200005B RID: 91
	public sealed class CanBeNullAttribute : Attribute
	{
		// Token: 0x06000308 RID: 776 RVA: 0x00003862 File Offset: 0x00001A62
		// Note: this type is marked as 'beforefieldinit'.
		static CanBeNullAttribute()
		{
			Il2CppClassPointerStore<CanBeNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "CanBeNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanBeNullAttribute>.NativeClassPtr);
			CanBeNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanBeNullAttribute>.NativeClassPtr, 100663598);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00021058 File Offset: 0x0001F258
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanBeNullAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanBeNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanBeNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000389B File Offset: 0x00001A9B
		public CanBeNullAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

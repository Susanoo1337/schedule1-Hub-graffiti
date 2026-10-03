using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200015C RID: 348
	public sealed class PreferBinarySerialization : Attribute
	{
		// Token: 0x060019D6 RID: 6614 RVA: 0x0000C8AB File Offset: 0x0000AAAB
		// Note: this type is marked as 'beforefieldinit'.
		static PreferBinarySerialization()
		{
			Il2CppClassPointerStore<PreferBinarySerialization>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PreferBinarySerialization");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreferBinarySerialization>.NativeClassPtr);
			PreferBinarySerialization.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreferBinarySerialization>.NativeClassPtr, 100666070);
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0006DF70 File Offset: 0x0006C170
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreferBinarySerialization() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreferBinarySerialization>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PreferBinarySerialization.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		public PreferBinarySerialization(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

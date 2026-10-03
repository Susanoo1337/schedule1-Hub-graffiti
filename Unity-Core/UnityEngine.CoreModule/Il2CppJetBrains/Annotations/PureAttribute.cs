using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppJetBrains.Annotations
{
	// Token: 0x02000061 RID: 97
	public sealed class PureAttribute : Attribute
	{
		// Token: 0x0600031B RID: 795 RVA: 0x00003977 File Offset: 0x00001B77
		// Note: this type is marked as 'beforefieldinit'.
		static PureAttribute()
		{
			Il2CppClassPointerStore<PureAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "PureAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PureAttribute>.NativeClassPtr);
			PureAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PureAttribute>.NativeClassPtr, 100663603);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00021270 File Offset: 0x0001F470
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PureAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PureAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PureAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000039B0 File Offset: 0x00001BB0
		public PureAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

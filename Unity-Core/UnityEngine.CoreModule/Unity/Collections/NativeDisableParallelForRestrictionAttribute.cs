using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x0200003B RID: 59
	public sealed class NativeDisableParallelForRestrictionAttribute : Attribute
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x00003128 File Offset: 0x00001328
		// Note: this type is marked as 'beforefieldinit'.
		static NativeDisableParallelForRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeDisableParallelForRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr);
			NativeDisableParallelForRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr, 100663439);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0001D184 File Offset: 0x0001B384
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeDisableParallelForRestrictionAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeDisableParallelForRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00003161 File Offset: 0x00001361
		public NativeDisableParallelForRestrictionAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

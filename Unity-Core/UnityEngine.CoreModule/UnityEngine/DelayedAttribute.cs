using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000114 RID: 276
	public sealed class DelayedAttribute : PropertyAttribute
	{
		// Token: 0x060016BF RID: 5823 RVA: 0x0000B6B5 File Offset: 0x000098B5
		// Note: this type is marked as 'beforefieldinit'.
		static DelayedAttribute()
		{
			Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DelayedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr);
			DelayedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr, 100665681);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x000631EC File Offset: 0x000613EC
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelayedAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelayedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x0000B6EE File Offset: 0x000098EE
		public DelayedAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

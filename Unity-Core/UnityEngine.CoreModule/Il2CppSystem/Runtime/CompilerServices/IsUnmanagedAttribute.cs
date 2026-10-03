using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000003 RID: 3
	public sealed class IsUnmanagedAttribute : Attribute
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002092 File Offset: 0x00000292
		// Note: this type is marked as 'beforefieldinit'.
		static IsUnmanagedAttribute()
		{
			Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "System.Runtime.CompilerServices", "IsUnmanagedAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr);
			IsUnmanagedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr, 100663298);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0001894C File Offset: 0x00016B4C
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IsUnmanagedAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IsUnmanagedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020CB File Offset: 0x000002CB
		public IsUnmanagedAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

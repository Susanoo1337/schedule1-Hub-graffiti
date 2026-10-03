using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000051 RID: 81
	public class WriteAccessRequiredAttribute : Attribute
	{
		// Token: 0x0600029E RID: 670 RVA: 0x000035D2 File Offset: 0x000017D2
		// Note: this type is marked as 'beforefieldinit'.
		static WriteAccessRequiredAttribute()
		{
			Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "WriteAccessRequiredAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr);
			WriteAccessRequiredAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr, 100663537);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0001F634 File Offset: 0x0001D834
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteAccessRequiredAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteAccessRequiredAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteAccessRequiredAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000360B File Offset: 0x0000180B
		public WriteAccessRequiredAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

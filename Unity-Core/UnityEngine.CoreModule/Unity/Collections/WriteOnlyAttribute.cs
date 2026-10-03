using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000037 RID: 55
	public sealed class WriteOnlyAttribute : Attribute
	{
		// Token: 0x060001EE RID: 494 RVA: 0x0000305C File Offset: 0x0000125C
		// Note: this type is marked as 'beforefieldinit'.
		static WriteOnlyAttribute()
		{
			Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "WriteOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr);
			WriteOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr, 100663438);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0001D148 File Offset: 0x0001B348
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteOnlyAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteOnlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00003095 File Offset: 0x00001295
		public WriteOnlyAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x0200004E RID: 78
	public sealed class NativeContainerSupportsDeferredConvertListToArray : Attribute
	{
		// Token: 0x06000296 RID: 662 RVA: 0x00003520 File Offset: 0x00001720
		// Note: this type is marked as 'beforefieldinit'.
		static NativeContainerSupportsDeferredConvertListToArray()
		{
			Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeContainerSupportsDeferredConvertListToArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr);
			NativeContainerSupportsDeferredConvertListToArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr, 100663535);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001F5BC File Offset: 0x0001D7BC
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeContainerSupportsDeferredConvertListToArray() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerSupportsDeferredConvertListToArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeContainerSupportsDeferredConvertListToArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00003559 File Offset: 0x00001759
		public NativeContainerSupportsDeferredConvertListToArray(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

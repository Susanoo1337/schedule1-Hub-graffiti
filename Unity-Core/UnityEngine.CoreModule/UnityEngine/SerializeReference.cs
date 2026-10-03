using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200015B RID: 347
	public sealed class SerializeReference : Attribute
	{
		// Token: 0x060019D3 RID: 6611 RVA: 0x0000C869 File Offset: 0x0000AA69
		// Note: this type is marked as 'beforefieldinit'.
		static SerializeReference()
		{
			Il2CppClassPointerStore<SerializeReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SerializeReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeReference>.NativeClassPtr);
			SerializeReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeReference>.NativeClassPtr, 100666069);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x0006DF34 File Offset: 0x0006C134
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializeReference() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializeReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0000C8A2 File Offset: 0x0000AAA2
		public SerializeReference(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

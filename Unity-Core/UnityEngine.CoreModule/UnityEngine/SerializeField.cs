using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200015A RID: 346
	public sealed class SerializeField : Attribute
	{
		// Token: 0x060019D0 RID: 6608 RVA: 0x0000C827 File Offset: 0x0000AA27
		// Note: this type is marked as 'beforefieldinit'.
		static SerializeField()
		{
			Il2CppClassPointerStore<SerializeField>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SerializeField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializeField>.NativeClassPtr);
			SerializeField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializeField>.NativeClassPtr, 100666068);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0006DEF8 File Offset: 0x0006C0F8
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializeField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializeField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializeField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0000C860 File Offset: 0x0000AA60
		public SerializeField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

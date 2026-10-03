using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200014A RID: 330
	public class SelectionBaseAttribute : Attribute
	{
		// Token: 0x06001913 RID: 6419 RVA: 0x0000C497 File Offset: 0x0000A697
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionBaseAttribute()
		{
			Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SelectionBaseAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr);
			SelectionBaseAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr, 100665958);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0006B158 File Offset: 0x00069358
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionBaseAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionBaseAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionBaseAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		public SelectionBaseAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000128 RID: 296
	public sealed class HideInCallstackAttribute : Attribute
	{
		// Token: 0x06001793 RID: 6035 RVA: 0x0000BC37 File Offset: 0x00009E37
		// Note: this type is marked as 'beforefieldinit'.
		static HideInCallstackAttribute()
		{
			Il2CppClassPointerStore<HideInCallstackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HideInCallstackAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideInCallstackAttribute>.NativeClassPtr);
			HideInCallstackAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideInCallstackAttribute>.NativeClassPtr, 100665765);
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00065B14 File Offset: 0x00063D14
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HideInCallstackAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideInCallstackAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideInCallstackAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0000BC70 File Offset: 0x00009E70
		public HideInCallstackAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

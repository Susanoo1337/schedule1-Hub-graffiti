using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000127 RID: 295
	public sealed class HideInInspector : Attribute
	{
		// Token: 0x06001790 RID: 6032 RVA: 0x0000BBF5 File Offset: 0x00009DF5
		// Note: this type is marked as 'beforefieldinit'.
		static HideInInspector()
		{
			Il2CppClassPointerStore<HideInInspector>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HideInInspector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr);
			HideInInspector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr, 100665764);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00065AD8 File Offset: 0x00063CD8
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HideInInspector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideInInspector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideInInspector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0000BC2E File Offset: 0x00009E2E
		public HideInInspector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

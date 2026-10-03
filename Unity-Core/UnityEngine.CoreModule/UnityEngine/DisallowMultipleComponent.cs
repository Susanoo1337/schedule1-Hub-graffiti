using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000120 RID: 288
	public sealed class DisallowMultipleComponent : Attribute
	{
		// Token: 0x06001759 RID: 5977 RVA: 0x0000B9AE File Offset: 0x00009BAE
		// Note: this type is marked as 'beforefieldinit'.
		static DisallowMultipleComponent()
		{
			Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DisallowMultipleComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr);
			DisallowMultipleComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr, 100665750);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00065244 File Offset: 0x00063444
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisallowMultipleComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisallowMultipleComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0000B9E7 File Offset: 0x00009BE7
		public DisallowMultipleComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

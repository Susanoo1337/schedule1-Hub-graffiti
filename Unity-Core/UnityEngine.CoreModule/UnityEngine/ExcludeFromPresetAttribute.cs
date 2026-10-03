using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200012C RID: 300
	public class ExcludeFromPresetAttribute : Attribute
	{
		// Token: 0x060017A8 RID: 6056 RVA: 0x0000BD2D File Offset: 0x00009F2D
		// Note: this type is marked as 'beforefieldinit'.
		static ExcludeFromPresetAttribute()
		{
			Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExcludeFromPresetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr);
			ExcludeFromPresetAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr, 100665770);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00065DF8 File Offset: 0x00063FF8
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExcludeFromPresetAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromPresetAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExcludeFromPresetAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x0000BD66 File Offset: 0x00009F66
		public ExcludeFromPresetAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

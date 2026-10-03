using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000052 RID: 82
	public sealed class NativeDisableUnsafePtrRestrictionAttribute : Attribute
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x00003614 File Offset: 0x00001814
		// Note: this type is marked as 'beforefieldinit'.
		static NativeDisableUnsafePtrRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeDisableUnsafePtrRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr);
			NativeDisableUnsafePtrRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr, 100663538);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0001F670 File Offset: 0x0001D870
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeDisableUnsafePtrRestrictionAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeDisableUnsafePtrRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeDisableUnsafePtrRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000364D File Offset: 0x0000184D
		public NativeDisableUnsafePtrRestrictionAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

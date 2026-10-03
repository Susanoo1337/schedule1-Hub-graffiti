using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x02000053 RID: 83
	public sealed class NativeDisableContainerSafetyRestrictionAttribute : Attribute
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x00003656 File Offset: 0x00001856
		// Note: this type is marked as 'beforefieldinit'.
		static NativeDisableContainerSafetyRestrictionAttribute()
		{
			Il2CppClassPointerStore<NativeDisableContainerSafetyRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "NativeDisableContainerSafetyRestrictionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeDisableContainerSafetyRestrictionAttribute>.NativeClassPtr);
			NativeDisableContainerSafetyRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeDisableContainerSafetyRestrictionAttribute>.NativeClassPtr, 100663539);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0001F6AC File Offset: 0x0001D8AC
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeDisableContainerSafetyRestrictionAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeDisableContainerSafetyRestrictionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeDisableContainerSafetyRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000368F File Offset: 0x0000188F
		public NativeDisableContainerSafetyRestrictionAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

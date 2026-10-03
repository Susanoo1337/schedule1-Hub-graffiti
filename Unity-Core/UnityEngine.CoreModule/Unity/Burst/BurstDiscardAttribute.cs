using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000059 RID: 89
	public class BurstDiscardAttribute : Attribute
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x0000380B File Offset: 0x00001A0B
		// Note: this type is marked as 'beforefieldinit'.
		static BurstDiscardAttribute()
		{
			Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Burst", "BurstDiscardAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr);
			BurstDiscardAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr, 100663588);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00020C54 File Offset: 0x0001EE54
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstDiscardAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstDiscardAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstDiscardAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00003844 File Offset: 0x00001A44
		public BurstDiscardAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

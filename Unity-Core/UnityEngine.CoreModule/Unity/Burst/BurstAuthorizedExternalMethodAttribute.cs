using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x02000058 RID: 88
	public class BurstAuthorizedExternalMethodAttribute : Attribute
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x000037C9 File Offset: 0x000019C9
		// Note: this type is marked as 'beforefieldinit'.
		static BurstAuthorizedExternalMethodAttribute()
		{
			Il2CppClassPointerStore<BurstAuthorizedExternalMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Burst", "BurstAuthorizedExternalMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstAuthorizedExternalMethodAttribute>.NativeClassPtr);
			BurstAuthorizedExternalMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstAuthorizedExternalMethodAttribute>.NativeClassPtr, 100663587);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00020C18 File Offset: 0x0001EE18
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstAuthorizedExternalMethodAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstAuthorizedExternalMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstAuthorizedExternalMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003802 File Offset: 0x00001A02
		public BurstAuthorizedExternalMethodAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

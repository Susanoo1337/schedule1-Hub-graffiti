using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppJetBrains.Annotations
{
	// Token: 0x0200005C RID: 92
	public sealed class NotNullAttribute : Attribute
	{
		// Token: 0x0600030B RID: 779 RVA: 0x000038A4 File Offset: 0x00001AA4
		// Note: this type is marked as 'beforefieldinit'.
		static NotNullAttribute()
		{
			Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "NotNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr);
			NotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr, 100663599);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00021094 File Offset: 0x0001F294
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotNullAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000038DD File Offset: 0x00001ADD
		public NotNullAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

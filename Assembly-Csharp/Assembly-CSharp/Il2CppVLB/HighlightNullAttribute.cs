using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000060 RID: 96
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x000052C5 File Offset: 0x000034C5
		// Note: this type is marked as 'beforefieldinit'.
		static HighlightNullAttribute()
		{
			Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "HighlightNullAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr);
			HighlightNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr, 100664004);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0008EA1C File Offset: 0x0008CC1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66195, RefRangeEnd = 66198, XrefRangeStart = 66195, XrefRangeEnd = 66198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HighlightNullAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HighlightNullAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HighlightNullAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000052FE File Offset: 0x000034FE
		public HighlightNullAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

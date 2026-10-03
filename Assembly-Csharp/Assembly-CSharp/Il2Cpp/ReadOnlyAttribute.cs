using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000017 RID: 23
	public class ReadOnlyAttribute : PropertyAttribute
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00002AAD File Offset: 0x00000CAD
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyAttribute()
		{
			Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ReadOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr);
			ReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, 100663416);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0007F284 File Offset: 0x0007D484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66195, RefRangeEnd = 66198, XrefRangeStart = 66194, XrefRangeEnd = 66195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002AE6 File Offset: 0x00000CE6
		public ReadOnlyAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

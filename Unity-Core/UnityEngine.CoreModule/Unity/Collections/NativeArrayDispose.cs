using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000040 RID: 64
	[StructLayout(2)]
	public struct NativeArrayDispose
	{
		// Token: 0x06000245 RID: 581 RVA: 0x0001E658 File Offset: 0x0001C858
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayDispose()
		{
			Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayDispose");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr);
			NativeArrayDispose.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, "m_Buffer");
			NativeArrayDispose.NativeFieldInfoPtr_m_AllocatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, "m_AllocatorLabel");
			NativeArrayDispose.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, 100663494);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0001E6C4 File Offset: 0x0001C8C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225881, RefRangeEnd = 1225882, XrefRangeStart = 1225879, XrefRangeEnd = 1225881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayDispose.NativeMethodInfoPtr_Dispose_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000329F File Offset: 0x0000149F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, ref this));
		}

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocatorLabel;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x040001D3 RID: 467
		[FieldOffset(0)]
		public IntPtr m_Buffer;

		// Token: 0x040001D4 RID: 468
		[FieldOffset(8)]
		public Allocator m_AllocatorLabel;
	}
}

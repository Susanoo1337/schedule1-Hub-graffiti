using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000144 RID: 324
	[StructLayout(2)]
	public struct RangeInt
	{
		// Token: 0x060018F5 RID: 6389 RVA: 0x0006AB78 File Offset: 0x00068D78
		// Note: this type is marked as 'beforefieldinit'.
		static RangeInt()
		{
			Il2CppClassPointerStore<RangeInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RangeInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeInt>.NativeClassPtr);
			RangeInt.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, "start");
			RangeInt.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, "length");
			RangeInt.NativeMethodInfoPtr_get_end_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, 100665944);
			RangeInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, 100665945);
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0006ABF8 File Offset: 0x00068DF8
		public unsafe int end
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1260507, RefRangeEnd = 1260510, XrefRangeStart = 1260507, XrefRangeEnd = 1260507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeInt.NativeMethodInfoPtr_get_end_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0006AC28 File Offset: 0x00068E28
		[CallerCount(494)]
		[CachedScanResults(RefRangeStart = 60743, RefRangeEnd = 61237, XrefRangeStart = 60743, XrefRangeEnd = 61237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeInt(int start, int length)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0000C3B0 File Offset: 0x0000A5B0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RangeInt>.NativeClassPtr, ref this));
		}

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_get_end_Public_get_Int32_0;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040014D4 RID: 5332
		[FieldOffset(0)]
		public int start;

		// Token: 0x040014D5 RID: 5333
		[FieldOffset(4)]
		public int length;
	}
}

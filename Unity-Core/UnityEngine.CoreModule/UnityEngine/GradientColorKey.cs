using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F4 RID: 244
	[StructLayout(2)]
	public struct GradientColorKey
	{
		// Token: 0x06001378 RID: 4984 RVA: 0x00056BF4 File Offset: 0x00054DF4
		// Note: this type is marked as 'beforefieldinit'.
		static GradientColorKey()
		{
			Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GradientColorKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr);
			GradientColorKey.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, "color");
			GradientColorKey.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, "time");
			GradientColorKey.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, 100665254);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x00056C60 File Offset: 0x00054E60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1242449, RefRangeEnd = 1242454, XrefRangeStart = 1242449, XrefRangeEnd = 1242449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientColorKey(Color col, float time)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientColorKey.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0000A7B6 File Offset: 0x000089B6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, ref this));
		}

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0;

		// Token: 0x0400110F RID: 4367
		[FieldOffset(0)]
		public Color color;

		// Token: 0x04001110 RID: 4368
		[FieldOffset(16)]
		public float time;
	}
}

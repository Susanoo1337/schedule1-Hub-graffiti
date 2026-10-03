using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000F5 RID: 245
	[StructLayout(2)]
	public struct GradientAlphaKey
	{
		// Token: 0x0600137B RID: 4987 RVA: 0x00056CA0 File Offset: 0x00054EA0
		// Note: this type is marked as 'beforefieldinit'.
		static GradientAlphaKey()
		{
			Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GradientAlphaKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr);
			GradientAlphaKey.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, "alpha");
			GradientAlphaKey.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, "time");
			GradientAlphaKey.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, 100665255);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00056D0C File Offset: 0x00054F0C
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 71922, RefRangeEnd = 71952, XrefRangeStart = 71922, XrefRangeEnd = 71952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientAlphaKey(float alpha, float time)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientAlphaKey.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0000A7C8 File Offset: 0x000089C8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, ref this));
		}

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeFieldInfoPtr_alpha;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeFieldInfoPtr_time;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04001114 RID: 4372
		[FieldOffset(0)]
		public float alpha;

		// Token: 0x04001115 RID: 4373
		[FieldOffset(4)]
		public float time;
	}
}

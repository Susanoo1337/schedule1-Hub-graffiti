using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x02000290 RID: 656
	public static class NoiseUtility : Il2CppSystem.Object
	{
		// Token: 0x0600322D RID: 12845 RVA: 0x00019DEA File Offset: 0x00017FEA
		// Note: this type is marked as 'beforefieldinit'.
		static NoiseUtility()
		{
			Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "NoiseUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr);
			NoiseUtility.NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr, 100669540);
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x00120CB8 File Offset: 0x0011EEB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136098, RefRangeEnd = 136100, XrefRangeStart = 136044, XrefRangeEnd = 136098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EmitNoise(Vector3 origin, ENoiseType type, float range, GameObject source = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref range;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoiseUtility.NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x00019E23 File Offset: 0x00018023
		public NoiseUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002165 RID: 8549
		private static readonly IntPtr NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0;
	}
}

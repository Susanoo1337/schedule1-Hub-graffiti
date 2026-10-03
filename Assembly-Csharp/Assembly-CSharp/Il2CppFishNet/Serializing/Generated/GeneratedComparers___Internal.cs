using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppFishNet.Serializing.Generated
{
	// Token: 0x02000846 RID: 2118
	[StructLayout(3, CharSet = 4)]
	public static class GeneratedComparers___Internal : Object
	{
		// Token: 0x0600CE5B RID: 52827 RVA: 0x000620BF File Offset: 0x000602BF
		// Note: this type is marked as 'beforefieldinit'.
		static GeneratedComparers___Internal()
		{
			Il2CppClassPointerStore<GeneratedComparers___Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishNet.Serializing.Generated", "GeneratedComparers___Internal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratedComparers___Internal>.NativeClassPtr);
			GeneratedComparers___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedComparers___Internal>.NativeClassPtr, 100689844);
		}

		// Token: 0x0600CE5C RID: 52828 RVA: 0x0033CF88 File Offset: 0x0033B188
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeOnce()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedComparers___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE5D RID: 52829 RVA: 0x000620F8 File Offset: 0x000602F8
		public GeneratedComparers___Internal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04008C77 RID: 35959
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0;
	}
}

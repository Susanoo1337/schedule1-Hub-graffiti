using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200084A RID: 2122
	[ObfuscatedName("$BurstDirectCallInitializer")]
	public static class ObjectPrivateAbstractSealedInVo0 : Object
	{
		// Token: 0x0600CF4E RID: 53070 RVA: 0x0006211C File Offset: 0x0006031C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectPrivateAbstractSealedInVo0()
		{
			Il2CppClassPointerStore<ObjectPrivateAbstractSealedInVo0>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "$BurstDirectCallInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPrivateAbstractSealedInVo0>.NativeClassPtr);
			ObjectPrivateAbstractSealedInVo0.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPrivateAbstractSealedInVo0>.NativeClassPtr, 100690079);
		}

		// Token: 0x0600CF4F RID: 53071 RVA: 0x00342158 File Offset: 0x00340358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341698, XrefRangeEnd = 341706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPrivateAbstractSealedInVo0.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CF50 RID: 53072 RVA: 0x00062155 File Offset: 0x00060355
		public ObjectPrivateAbstractSealedInVo0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04008D62 RID: 36194
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;
	}
}

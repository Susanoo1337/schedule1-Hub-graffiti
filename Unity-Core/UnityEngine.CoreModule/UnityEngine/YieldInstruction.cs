using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000159 RID: 345
	public class YieldInstruction : Object
	{
		// Token: 0x060019CD RID: 6605 RVA: 0x0000C7E5 File Offset: 0x0000A9E5
		// Note: this type is marked as 'beforefieldinit'.
		static YieldInstruction()
		{
			Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "YieldInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr);
			YieldInstruction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr, 100666067);
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x0006DEBC File Offset: 0x0006C0BC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YieldInstruction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YieldInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YieldInstruction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x0000C81E File Offset: 0x0000AA1E
		public YieldInstruction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

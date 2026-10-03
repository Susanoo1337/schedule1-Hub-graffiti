using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.State
{
	// Token: 0x02000123 RID: 291
	public class InGameStateMachine : MonoStateMachine
	{
		// Token: 0x06001BEC RID: 7148 RVA: 0x000D7508 File Offset: 0x000D5708
		// Note: this type is marked as 'beforefieldinit'.
		static InGameStateMachine()
		{
			Il2CppClassPointerStore<InGameStateMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.State", "InGameStateMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InGameStateMachine>.NativeClassPtr);
			InGameStateMachine.NativeMethodInfoPtr_PopUntilDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameStateMachine>.NativeClassPtr, 100666993);
			InGameStateMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameStateMachine>.NativeClassPtr, 100666994);
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x000D7560 File Offset: 0x000D5760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102504, RefRangeEnd = 102505, XrefRangeStart = 102472, XrefRangeEnd = 102504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopUntilDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameStateMachine.NativeMethodInfoPtr_PopUntilDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x000D7594 File Offset: 0x000D5794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102528, RefRangeEnd = 102529, XrefRangeStart = 102505, XrefRangeEnd = 102528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InGameStateMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InGameStateMachine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InGameStateMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x0000F21E File Offset: 0x0000D41E
		public InGameStateMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_PopUntilDefault_Public_Void_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

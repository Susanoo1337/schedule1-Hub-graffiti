using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000125 RID: 293
	public sealed class ExecuteInEditMode : Attribute
	{
		// Token: 0x0600178A RID: 6026 RVA: 0x0000BB71 File Offset: 0x00009D71
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteInEditMode()
		{
			Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExecuteInEditMode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr);
			ExecuteInEditMode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr, 100665762);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00065A60 File Offset: 0x00063C60
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteInEditMode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteInEditMode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteInEditMode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0000BBAA File Offset: 0x00009DAA
		public ExecuteInEditMode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

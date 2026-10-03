using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000126 RID: 294
	public sealed class ExecuteAlways : Attribute
	{
		// Token: 0x0600178D RID: 6029 RVA: 0x0000BBB3 File Offset: 0x00009DB3
		// Note: this type is marked as 'beforefieldinit'.
		static ExecuteAlways()
		{
			Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExecuteAlways");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr);
			ExecuteAlways.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr, 100665763);
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00065A9C File Offset: 0x00063C9C
		[CallerCount(207)]
		[CachedScanResults(RefRangeStart = 360552, RefRangeEnd = 360759, XrefRangeStart = 360552, XrefRangeEnd = 360759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecuteAlways() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecuteAlways>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecuteAlways.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0000BBEC File Offset: 0x00009DEC
		public ExecuteAlways(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

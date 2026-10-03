using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000041 RID: 65
	[StructLayout(2)]
	public struct NativeArrayDisposeJob
	{
		// Token: 0x06000248 RID: 584 RVA: 0x0001E6EC File Offset: 0x0001C8EC
		// Note: this type is marked as 'beforefieldinit'.
		static NativeArrayDisposeJob()
		{
			Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayDisposeJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr);
			NativeArrayDisposeJob.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, "Data");
			NativeArrayDisposeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, 100663495);
			NativeArrayDisposeJob.NativeMethodInfoPtr_RegisterNativeArrayDisposeJobReflectionData_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, 100663496);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001E758 File Offset: 0x0001C958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225881, RefRangeEnd = 1225882, XrefRangeStart = 1225881, XrefRangeEnd = 1225882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Execute()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayDisposeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001E780 File Offset: 0x0001C980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225882, XrefRangeEnd = 1225885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterNativeArrayDisposeJobReflectionData()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeArrayDisposeJob.NativeMethodInfoPtr_RegisterNativeArrayDisposeJobReflectionData_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000032B1 File Offset: 0x000014B1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, ref this));
		}

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_Data;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_RegisterNativeArrayDisposeJobReflectionData_Internal_Static_Void_0;

		// Token: 0x040001D8 RID: 472
		[FieldOffset(0)]
		public NativeArrayDispose Data;
	}
}

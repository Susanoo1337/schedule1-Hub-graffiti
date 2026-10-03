using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000277 RID: 631
	public class BuiltinRuntimeReflectionSystem : Object
	{
		// Token: 0x06002B37 RID: 11063 RVA: 0x000A8578 File Offset: 0x000A6778
		// Note: this type is marked as 'beforefieldinit'.
		static BuiltinRuntimeReflectionSystem()
		{
			Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "BuiltinRuntimeReflectionSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100667949);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100667950);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100667951);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100667952);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100667953);
			BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100667954);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x000A8620 File Offset: 0x000A6820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294354, XrefRangeEnd = 1294356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TickRealtimeProbes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x000A865C File Offset: 0x000A685C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x000A8690 File Offset: 0x000A6890
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref disposing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x000A86D0 File Offset: 0x000A68D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BuiltinUpdate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x000A8700 File Offset: 0x000A6900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294356, XrefRangeEnd = 1294360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuiltinRuntimeReflectionSystem>(intPtr3) : null;
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x000A8734 File Offset: 0x000A6934
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuiltinRuntimeReflectionSystem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x00013001 File Offset: 0x00011201
		public BuiltinRuntimeReflectionSystem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400252E RID: 9518
		private static readonly IntPtr NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400252F RID: 9519
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002530 RID: 9520
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04002531 RID: 9521
		private static readonly IntPtr NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0;

		// Token: 0x04002532 RID: 9522
		private static readonly IntPtr NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0;

		// Token: 0x04002533 RID: 9523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

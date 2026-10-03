using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000279 RID: 633
	public static class ScriptableRuntimeReflectionSystemSettings : Object
	{
		// Token: 0x06002B42 RID: 11074 RVA: 0x000A87B8 File Offset: 0x000A69B8
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRuntimeReflectionSystemSettings()
		{
			Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "ScriptableRuntimeReflectionSystemSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr);
			ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, "s_Instance");
			ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100667956);
			ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100667957);
			ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100667958);
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x000A890C File Offset: 0x000A6B0C
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x000A8838 File Offset: 0x000A6A38
		public unsafe static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
		{
			get
			{
				return ScriptableRuntimeReflectionSystemSettings.s_Instance.implementation;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294360, XrefRangeEnd = 1294377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x000A8870 File Offset: 0x000A6A70
		public unsafe static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294377, XrefRangeEnd = 1294381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableRuntimeReflectionSystemWrapper>(intPtr3) : null;
			}
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x000A88A4 File Offset: 0x000A6AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294381, XrefRangeEnd = 1294391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScriptingDirtyReflectionSystemInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x00013042 File Offset: 0x00011242
		public ScriptableRuntimeReflectionSystemSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x000A88CC File Offset: 0x000A6ACC
		// (set) Token: 0x06002B48 RID: 11080 RVA: 0x0001304B File Offset: 0x0001124B
		public unsafe static ScriptableRuntimeReflectionSystemWrapper s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRuntimeReflectionSystemWrapper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x000A88F4 File Offset: 0x000A6AF4
		// (set) Token: 0x06002B4A RID: 11082 RVA: 0x0001305D File Offset: 0x0001125D
		public static IScriptableRuntimeReflectionSystem system
		{
			get
			{
				return ScriptableRuntimeReflectionSystemSettings.Internal_ScriptableRuntimeReflectionSystemSettings_system;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04002535 RID: 9525
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04002536 RID: 9526
		private static readonly IntPtr NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0;

		// Token: 0x04002537 RID: 9527
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0;

		// Token: 0x04002538 RID: 9528
		private static readonly IntPtr NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0;
	}
}

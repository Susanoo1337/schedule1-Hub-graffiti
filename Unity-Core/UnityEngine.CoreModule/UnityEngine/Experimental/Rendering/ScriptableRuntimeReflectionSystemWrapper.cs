using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x0200027A RID: 634
	public class ScriptableRuntimeReflectionSystemWrapper : Object
	{
		// Token: 0x06002B4C RID: 11084 RVA: 0x000A8928 File Offset: 0x000A6B28
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableRuntimeReflectionSystemWrapper()
		{
			Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "ScriptableRuntimeReflectionSystemWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr);
			ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, "<implementation>k__BackingField");
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100667960);
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100667961);
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100667962);
			ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100667963);
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x000A89BC File Offset: 0x000A6BBC
		// (set) Token: 0x06002B4E RID: 11086 RVA: 0x000A89FC File Offset: 0x000A6BFC
		public unsafe IScriptableRuntimeReflectionSystem implementation
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IScriptableRuntimeReflectionSystem>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000A8A40 File Offset: 0x000A6C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1294391, XrefRangeEnd = 1294392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out bool result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x000A8A80 File Offset: 0x000A6C80
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableRuntimeReflectionSystemWrapper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x0001306A File Offset: 0x0001126A
		public ScriptableRuntimeReflectionSystemWrapper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000A8ABC File Offset: 0x000A6CBC
		// (set) Token: 0x06002B53 RID: 11091 RVA: 0x00013073 File Offset: 0x00011273
		public unsafe IScriptableRuntimeReflectionSystem _implementation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IScriptableRuntimeReflectionSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002539 RID: 9529
		private static readonly IntPtr NativeFieldInfoPtr__implementation_k__BackingField;

		// Token: 0x0400253A RID: 9530
		private static readonly IntPtr NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0;

		// Token: 0x0400253B RID: 9531
		private static readonly IntPtr NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0;

		// Token: 0x0400253C RID: 9532
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0;

		// Token: 0x0400253D RID: 9533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

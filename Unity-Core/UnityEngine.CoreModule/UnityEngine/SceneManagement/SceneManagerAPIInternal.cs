using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001B3 RID: 435
	public static class SceneManagerAPIInternal : Object
	{
		// Token: 0x06002007 RID: 8199 RVA: 0x00083298 File Offset: 0x00081498
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManagerAPIInternal()
		{
			Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManagerAPIInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr);
			SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100666792);
			SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100666793);
			SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegateField = IL2CPP.ResolveICall<SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::GetNumScenesInBuildSettings");
			SceneManagerAPIInternal.UnloadSceneNameIndexInternalDelegateField = IL2CPP.ResolveICall<SceneManagerAPIInternal.UnloadSceneNameIndexInternalDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::UnloadSceneNameIndexInternal");
			SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegateField = IL2CPP.ResolveICall<SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::GetSceneByBuildIndex_Injected");
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00083320 File Offset: 0x00081520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286088, XrefRangeEnd = 1286090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustCompleteNextFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00083390 File Offset: 0x00081590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286090, XrefRangeEnd = 1286092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustCompleteNextFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x0000ED8B File Offset: 0x0000CF8B
		public SceneManagerAPIInternal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0000ED94 File Offset: 0x0000CF94
		public static int GetNumScenesInBuildSettings()
		{
			return SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegateField();
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00083400 File Offset: 0x00081600
		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			Scene result;
			SceneManagerAPIInternal.GetSceneByBuildIndex_Injected(buildIndex, out result);
			return result;
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00083418 File Offset: 0x00081618
		public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			IntPtr intPtr = SceneManagerAPIInternal.UnloadSceneNameIndexInternalDelegateField(IL2CPP.ManagedStringToIl2Cpp(sceneName), sceneBuildIndex, immediately, options, out outSuccess);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		public static void GetSceneByBuildIndex_Injected(int buildIndex, out Scene ret)
		{
			SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegateField(buildIndex, out ret);
		}

		// Token: 0x040019F7 RID: 6647
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

		// Token: 0x040019F8 RID: 6648
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_AsyncOperation_String_Int32_byref_LoadSceneParameters_Boolean_0;

		// Token: 0x040019F9 RID: 6649
		private static readonly SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegate GetNumScenesInBuildSettingsDelegateField;

		// Token: 0x040019FA RID: 6650
		private static readonly SceneManagerAPIInternal.UnloadSceneNameIndexInternalDelegate UnloadSceneNameIndexInternalDelegateField;

		// Token: 0x040019FB RID: 6651
		private static readonly SceneManagerAPIInternal.GetSceneByBuildIndex_InjectedDelegate GetSceneByBuildIndex_InjectedDelegateField;

		// Token: 0x02000A24 RID: 2596
		// (Invoke) Token: 0x06003D17 RID: 15639
		private delegate int GetNumScenesInBuildSettingsDelegate();

		// Token: 0x02000A25 RID: 2597
		// (Invoke) Token: 0x06003D19 RID: 15641
		private delegate IntPtr UnloadSceneNameIndexInternalDelegate(IntPtr sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, [Out] IntPtr outSuccess);

		// Token: 0x02000A26 RID: 2598
		// (Invoke) Token: 0x06003D1B RID: 15643
		private delegate void GetSceneByBuildIndex_InjectedDelegate(int buildIndex, [Out] IntPtr ret);
	}
}

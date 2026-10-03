using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Events;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001B5 RID: 437
	public class SceneManager : Object
	{
		// Token: 0x0600201E RID: 8222 RVA: 0x000836DC File Offset: 0x000818DC
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManager()
		{
			Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
			SceneManager.NativeFieldInfoPtr_s_AllowLoadScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "s_AllowLoadScene");
			SceneManager.NativeFieldInfoPtr_sceneLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "sceneLoaded");
			SceneManager.NativeFieldInfoPtr_sceneUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "sceneUnloaded");
			SceneManager.NativeFieldInfoPtr_activeSceneChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "activeSceneChanged");
			SceneManager.NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666800);
			SceneManager.NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666801);
			SceneManager.NativeMethodInfoPtr_SetActiveScene_Public_Static_Boolean_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666802);
			SceneManager.NativeMethodInfoPtr_GetSceneByName_Public_Static_Scene_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666803);
			SceneManager.NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666804);
			SceneManager.NativeMethodInfoPtr_CreateScene_Public_Static_Scene_String_CreateSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666805);
			SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Private_Static_AsyncOperation_Scene_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666806);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666807);
			SceneManager.NativeMethodInfoPtr_MoveGameObjectToScene_Public_Static_Void_GameObject_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666808);
			SceneManager.NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666809);
			SceneManager.NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666810);
			SceneManager.NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666811);
			SceneManager.NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666812);
			SceneManager.NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666813);
			SceneManager.NativeMethodInfoPtr_add_activeSceneChanged_Public_Static_add_Void_UnityAction_2_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666814);
			SceneManager.NativeMethodInfoPtr_remove_activeSceneChanged_Public_Static_rem_Void_UnityAction_2_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666815);
			SceneManager.NativeMethodInfoPtr_CreateScene_Public_Static_Scene_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666816);
			SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666817);
			SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666818);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666819);
			SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666820);
			SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666821);
			SceneManager.NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666822);
			SceneManager.NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666823);
			SceneManager.NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666824);
			SceneManager.NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666826);
			SceneManager.NativeMethodInfoPtr_SetActiveScene_Injected_Private_Static_Boolean_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666827);
			SceneManager.NativeMethodInfoPtr_GetSceneByName_Injected_Private_Static_Void_String_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666828);
			SceneManager.NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666829);
			SceneManager.NativeMethodInfoPtr_CreateScene_Injected_Private_Static_Void_String_byref_CreateSceneParameters_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666830);
			SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Injected_Private_Static_AsyncOperation_byref_Scene_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666831);
			SceneManager.NativeMethodInfoPtr_MoveGameObjectToScene_Injected_Private_Static_Void_GameObject_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666832);
			SceneManager.get_loadedSceneCountDelegateField = IL2CPP.ResolveICall<SceneManager.get_loadedSceneCountDelegate>("UnityEngine.SceneManagement.SceneManager::get_loadedSceneCount");
			SceneManager.CanSetAsActiveScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.CanSetAsActiveScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::CanSetAsActiveScene_Injected");
			SceneManager.GetSceneByPath_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.GetSceneByPath_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::GetSceneByPath_Injected");
			SceneManager.UnloadSceneInternal_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.UnloadSceneInternal_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::UnloadSceneInternal_Injected");
			SceneManager.MergeScenes_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.MergeScenes_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MergeScenes_Injected");
			SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MoveGameObjectsToSceneByInstanceId_Injected");
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x0600201F RID: 8223 RVA: 0x00083A38 File Offset: 0x00081C38
		public unsafe static int sceneCount
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1286112, RefRangeEnd = 1286121, XrefRangeStart = 1286110, XrefRangeEnd = 1286112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00083A68 File Offset: 0x00081C68
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1286126, RefRangeEnd = 1286146, XrefRangeStart = 1286121, XrefRangeEnd = 1286126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene GetActiveScene()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00083A98 File Offset: 0x00081C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1286151, RefRangeEnd = 1286152, XrefRangeStart = 1286146, XrefRangeEnd = 1286151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetActiveScene(Scene scene)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_SetActiveScene_Public_Static_Boolean_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00083AD8 File Offset: 0x00081CD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1286157, RefRangeEnd = 1286160, XrefRangeStart = 1286152, XrefRangeEnd = 1286157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene GetSceneByName(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneByName_Public_Static_Scene_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00083B1C File Offset: 0x00081D1C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1286165, RefRangeEnd = 1286174, XrefRangeStart = 1286160, XrefRangeEnd = 1286165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene GetSceneAt(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00083B5C File Offset: 0x00081D5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1286179, RefRangeEnd = 1286181, XrefRangeStart = 1286174, XrefRangeEnd = 1286179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene CreateScene(string sceneName, CreateSceneParameters parameters)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_CreateScene_Public_Static_Scene_String_CreateSceneParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00083BAC File Offset: 0x00081DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286181, XrefRangeEnd = 1286186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scene;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Private_Static_AsyncOperation_Scene_UnloadSceneOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00083BFC File Offset: 0x00081DFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1286194, RefRangeEnd = 1286198, XrefRangeStart = 1286186, XrefRangeEnd = 1286194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sceneBuildIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustCompleteNextFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00083C6C File Offset: 0x00081E6C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1286203, RefRangeEnd = 1286216, XrefRangeStart = 1286198, XrefRangeEnd = 1286203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveGameObjectToScene(GameObject go, Scene scene)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_MoveGameObjectToScene_Public_Static_Void_GameObject_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00083CB0 File Offset: 0x00081EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286216, XrefRangeEnd = 1286221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadFirstScene_Internal(bool async)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref async;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00083CF0 File Offset: 0x00081EF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1286234, RefRangeEnd = 1286238, XrefRangeStart = 1286221, XrefRangeEnd = 1286234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_sceneLoaded(UnityEngine.Events.UnityAction<Scene, LoadSceneMode> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00083D28 File Offset: 0x00081F28
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1286251, RefRangeEnd = 1286255, XrefRangeStart = 1286238, XrefRangeEnd = 1286251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_sceneLoaded(UnityEngine.Events.UnityAction<Scene, LoadSceneMode> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00083D60 File Offset: 0x00081F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1286268, RefRangeEnd = 1286270, XrefRangeStart = 1286255, XrefRangeEnd = 1286268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_sceneUnloaded(UnityEngine.Events.UnityAction<Scene> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00083D98 File Offset: 0x00081F98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1286283, RefRangeEnd = 1286285, XrefRangeStart = 1286270, XrefRangeEnd = 1286283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_sceneUnloaded(UnityEngine.Events.UnityAction<Scene> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00083DD0 File Offset: 0x00081FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1286298, RefRangeEnd = 1286299, XrefRangeStart = 1286285, XrefRangeEnd = 1286298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_activeSceneChanged(UnityEngine.Events.UnityAction<Scene, Scene> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_activeSceneChanged_Public_Static_add_Void_UnityAction_2_Scene_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00083E08 File Offset: 0x00082008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286299, XrefRangeEnd = 1286312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_activeSceneChanged(UnityEngine.Events.UnityAction<Scene, Scene> value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_activeSceneChanged_Public_Static_rem_Void_UnityAction_2_Scene_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00083E40 File Offset: 0x00082040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1286320, RefRangeEnd = 1286321, XrefRangeStart = 1286312, XrefRangeEnd = 1286320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene CreateScene(string sceneName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_CreateScene_Public_Static_Scene_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00083E84 File Offset: 0x00082084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1286335, RefRangeEnd = 1286336, XrefRangeStart = 1286321, XrefRangeEnd = 1286335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadScene(string sceneName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00083EBC File Offset: 0x000820BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286336, XrefRangeEnd = 1286347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00083F0C File Offset: 0x0008210C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1286354, RefRangeEnd = 1286356, XrefRangeStart = 1286347, XrefRangeEnd = 1286354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsync(string sceneName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00083F50 File Offset: 0x00082150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1286360, RefRangeEnd = 1286361, XrefRangeStart = 1286356, XrefRangeEnd = 1286360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parameters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00083FA4 File Offset: 0x000821A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1286369, RefRangeEnd = 1286372, XrefRangeStart = 1286361, XrefRangeEnd = 1286369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadSceneAsync(Scene scene)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00083FE4 File Offset: 0x000821E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286372, XrefRangeEnd = 1286378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scene;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00084024 File Offset: 0x00082224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286378, XrefRangeEnd = 1286384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_SceneUnloaded(Scene scene)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref scene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x00084058 File Offset: 0x00082258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286384, XrefRangeEnd = 1286390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previousActiveScene;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newActiveScene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00084098 File Offset: 0x00082298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286390, XrefRangeEnd = 1286392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetActiveScene_Injected(out Scene ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x000840CC File Offset: 0x000822CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286392, XrefRangeEnd = 1286394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetActiveScene_Injected(ref Scene scene)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &scene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_SetActiveScene_Injected_Private_Static_Boolean_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x0008410C File Offset: 0x0008230C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286394, XrefRangeEnd = 1286396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSceneByName_Injected(string name, out Scene ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneByName_Injected_Private_Static_Void_String_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00084150 File Offset: 0x00082350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286396, XrefRangeEnd = 1286398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSceneAt_Injected(int index, out Scene ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x00084190 File Offset: 0x00082390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286398, XrefRangeEnd = 1286400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &parameters;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_CreateScene_Injected_Private_Static_Void_String_byref_CreateSceneParameters_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000841E4 File Offset: 0x000823E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286400, XrefRangeEnd = 1286402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &scene;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Injected_Private_Static_AsyncOperation_byref_Scene_UnloadSceneOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x00084234 File Offset: 0x00082434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286402, XrefRangeEnd = 1286404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &scene;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_MoveGameObjectToScene_Injected_Private_Static_Void_GameObject_byref_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0000EE00 File Offset: 0x0000D000
		public SceneManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x00084278 File Offset: 0x00082478
		// (set) Token: 0x06002041 RID: 8257 RVA: 0x0000EE09 File Offset: 0x0000D009
		public unsafe static bool s_AllowLoadScene
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_s_AllowLoadScene, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_s_AllowLoadScene, (void*)(&value));
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x00084294 File Offset: 0x00082494
		// (set) Token: 0x06002043 RID: 8259 RVA: 0x0000EE17 File Offset: 0x0000D017
		public unsafe static UnityEngine.Events.UnityAction<Scene, LoadSceneMode> sceneLoaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_sceneLoaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene, LoadSceneMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_sceneLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x000842BC File Offset: 0x000824BC
		// (set) Token: 0x06002045 RID: 8261 RVA: 0x0000EE29 File Offset: 0x0000D029
		public unsafe static UnityEngine.Events.UnityAction<Scene> sceneUnloaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_sceneUnloaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_sceneUnloaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x000842E4 File Offset: 0x000824E4
		// (set) Token: 0x06002047 RID: 8263 RVA: 0x0000EE3B File Offset: 0x0000D03B
		public unsafe static UnityEngine.Events.UnityAction<Scene, Scene> activeSceneChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_activeSceneChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction<Scene, Scene>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_activeSceneChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x0000EE4D File Offset: 0x0000D04D
		public static int loadedSceneCount
		{
			get
			{
				return SceneManager.get_loadedSceneCountDelegateField();
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x0008430C File Offset: 0x0008250C
		public static int sceneCountInBuildSettings
		{
			get
			{
				return SceneManagerAPI.ActiveAPI.GetNumScenesInBuildSettings();
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0000EE59 File Offset: 0x0000D059
		public static bool CanSetAsActiveScene(Scene scene)
		{
			return SceneManager.CanSetAsActiveScene_Injected(ref scene);
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00084328 File Offset: 0x00082528
		public static Scene GetSceneByPath(string scenePath)
		{
			Scene result;
			SceneManager.GetSceneByPath_Injected(scenePath, out result);
			return result;
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00084340 File Offset: 0x00082540
		public static Scene GetSceneByBuildIndex(int buildIndex)
		{
			return SceneManagerAPI.ActiveAPI.GetSceneByBuildIndex(buildIndex);
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x0000EE62 File Offset: 0x0000D062
		public static bool UnloadSceneInternal(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneInternal_Injected(ref scene, options);
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00084360 File Offset: 0x00082560
		public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
		{
			bool flag = !SceneManager.s_AllowLoadScene;
			AsyncOperation result;
			if (flag)
			{
				outSuccess = false;
				result = null;
			}
			else
			{
				result = SceneManagerAPI.ActiveAPI.UnloadSceneAsyncByNameOrIndex(sceneName, sceneBuildIndex, immediately, options, out outSuccess);
			}
			return result;
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0000EE6C File Offset: 0x0000D06C
		public static void MergeScenes(Scene sourceScene, Scene destinationScene)
		{
			SceneManager.MergeScenes_Injected(ref sourceScene, ref destinationScene);
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x0000EE77 File Offset: 0x0000D077
		public static void MoveGameObjectsToSceneByInstanceId(IntPtr instanceIds, int instanceCount, Scene scene)
		{
			SceneManager.MoveGameObjectsToSceneByInstanceId_Injected(instanceIds, instanceCount, ref scene);
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00084398 File Offset: 0x00082598
		public static void MoveGameObjectsToScene(Unity.Collections.NativeArray<int> instanceIDs, Scene scene)
		{
			bool flag = !instanceIDs.IsCreated;
			if (flag)
			{
				throw new ArgumentException("NativeArray is uninitialized", "instanceIDs");
			}
			bool flag2 = instanceIDs.Length == 0;
			if (!flag2)
			{
				SceneManager.MoveGameObjectsToSceneByInstanceId((IntPtr)instanceIDs.GetUnsafeReadOnlyPtr<int>(), instanceIDs.Length, scene);
			}
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x0000EE82 File Offset: 0x0000D082
		public static Il2CppStructArray<Scene> GetAllScenes()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x000843F0 File Offset: 0x000825F0
		public static void LoadScene(string sceneName, LoadSceneMode mode)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(mode);
			SceneManager.LoadScene(sceneName, parameters);
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00084410 File Offset: 0x00082610
		public static void LoadScene(int sceneBuildIndex, LoadSceneMode mode)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(mode);
			SceneManager.LoadScene(sceneBuildIndex, parameters);
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00084430 File Offset: 0x00082630
		public static void LoadScene(int sceneBuildIndex)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
			SceneManager.LoadScene(sceneBuildIndex, parameters);
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00084450 File Offset: 0x00082650
		public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			SceneManager.LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, parameters, true);
			return SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00084478 File Offset: 0x00082678
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(mode);
			return SceneManager.LoadSceneAsync(sceneBuildIndex, parameters);
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0008449C File Offset: 0x0008269C
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
			return SceneManager.LoadSceneAsync(sceneBuildIndex, parameters);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000844C0 File Offset: 0x000826C0
		public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneParameters parameters)
		{
			return SceneManager.LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, parameters, false);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x000844DC File Offset: 0x000826DC
		public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode)
		{
			LoadSceneParameters parameters = new LoadSceneParameters(mode);
			return SceneManager.LoadSceneAsync(sceneName, parameters);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00084500 File Offset: 0x00082700
		public static bool UnloadScene(Scene scene)
		{
			return SceneManager.UnloadSceneInternal(scene, UnloadSceneOptions.None);
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0008451C File Offset: 0x0008271C
		public static bool UnloadScene(int sceneBuildIndex)
		{
			bool result;
			SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, true, UnloadSceneOptions.None, out result);
			return result;
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00084540 File Offset: 0x00082740
		public static bool UnloadScene(string sceneName)
		{
			bool result;
			SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, true, UnloadSceneOptions.None, out result);
			return result;
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x00084560 File Offset: 0x00082760
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, UnloadSceneOptions.None, out flag);
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00084584 File Offset: 0x00082784
		public static AsyncOperation UnloadSceneAsync(string sceneName)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, UnloadSceneOptions.None, out flag);
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x000845A4 File Offset: 0x000827A4
		public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex, UnloadSceneOptions options)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, options, out flag);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000845C8 File Offset: 0x000827C8
		public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options)
		{
			bool flag;
			return SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, options, out flag);
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000845E8 File Offset: 0x000827E8
		public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneAsyncInternal(scene, options);
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x0000EE8F File Offset: 0x0000D08F
		public static bool CanSetAsActiveScene_Injected(ref Scene scene)
		{
			return SceneManager.CanSetAsActiveScene_InjectedDelegateField(ref scene);
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x0000EE9C File Offset: 0x0000D09C
		public static void GetSceneByPath_Injected(string scenePath, out Scene ret)
		{
			SceneManager.GetSceneByPath_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(scenePath), out ret);
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x0000EEAF File Offset: 0x0000D0AF
		public static bool UnloadSceneInternal_Injected(ref Scene scene, UnloadSceneOptions options)
		{
			return SceneManager.UnloadSceneInternal_InjectedDelegateField(ref scene, options);
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x0000EEBD File Offset: 0x0000D0BD
		public static void MergeScenes_Injected(ref Scene sourceScene, ref Scene destinationScene)
		{
			SceneManager.MergeScenes_InjectedDelegateField(ref sourceScene, ref destinationScene);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0000EECB File Offset: 0x0000D0CB
		public static void MoveGameObjectsToSceneByInstanceId_Injected(IntPtr instanceIds, int instanceCount, ref Scene scene)
		{
			SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegateField(instanceIds, instanceCount, ref scene);
		}

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeFieldInfoPtr_s_AllowLoadScene;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeFieldInfoPtr_sceneLoaded;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeFieldInfoPtr_sceneUnloaded;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeFieldInfoPtr_activeSceneChanged;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveScene_Public_Static_Boolean_Scene_0;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneByName_Public_Static_Scene_String_0;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeMethodInfoPtr_CreateScene_Public_Static_Scene_String_CreateSceneParameters_0;

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsyncInternal_Private_Static_AsyncOperation_Scene_UnloadSceneOptions_0;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeMethodInfoPtr_MoveGameObjectToScene_Public_Static_Void_GameObject_Scene_0;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeMethodInfoPtr_add_activeSceneChanged_Public_Static_add_Void_UnityAction_2_Scene_Scene_0;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeMethodInfoPtr_remove_activeSceneChanged_Public_Static_rem_Void_UnityAction_2_Scene_Scene_0;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeMethodInfoPtr_CreateScene_Public_Static_Scene_String_0;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0;

		// Token: 0x04001A1A RID: 6682
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_0;

		// Token: 0x04001A1B RID: 6683
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0;

		// Token: 0x04001A1C RID: 6684
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_0;

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveScene_Injected_Private_Static_Boolean_byref_Scene_0;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneByName_Injected_Private_Static_Void_String_byref_Scene_0;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeMethodInfoPtr_CreateScene_Injected_Private_Static_Void_String_byref_CreateSceneParameters_byref_Scene_0;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeMethodInfoPtr_UnloadSceneAsyncInternal_Injected_Private_Static_AsyncOperation_byref_Scene_UnloadSceneOptions_0;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeMethodInfoPtr_MoveGameObjectToScene_Injected_Private_Static_Void_GameObject_byref_Scene_0;

		// Token: 0x04001A27 RID: 6695
		private static readonly SceneManager.get_loadedSceneCountDelegate get_loadedSceneCountDelegateField;

		// Token: 0x04001A28 RID: 6696
		private static readonly SceneManager.CanSetAsActiveScene_InjectedDelegate CanSetAsActiveScene_InjectedDelegateField;

		// Token: 0x04001A29 RID: 6697
		private static readonly SceneManager.GetSceneByPath_InjectedDelegate GetSceneByPath_InjectedDelegateField;

		// Token: 0x04001A2A RID: 6698
		private static readonly SceneManager.UnloadSceneInternal_InjectedDelegate UnloadSceneInternal_InjectedDelegateField;

		// Token: 0x04001A2B RID: 6699
		private static readonly SceneManager.MergeScenes_InjectedDelegate MergeScenes_InjectedDelegateField;

		// Token: 0x04001A2C RID: 6700
		private static readonly SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegate MoveGameObjectsToSceneByInstanceId_InjectedDelegateField;

		// Token: 0x02000A27 RID: 2599
		// (Invoke) Token: 0x06003D1D RID: 15645
		private delegate int get_loadedSceneCountDelegate();

		// Token: 0x02000A28 RID: 2600
		// (Invoke) Token: 0x06003D1F RID: 15647
		private delegate bool CanSetAsActiveScene_InjectedDelegate(IntPtr scene);

		// Token: 0x02000A29 RID: 2601
		// (Invoke) Token: 0x06003D21 RID: 15649
		private delegate void GetSceneByPath_InjectedDelegate(IntPtr scenePath, [Out] IntPtr ret);

		// Token: 0x02000A2A RID: 2602
		// (Invoke) Token: 0x06003D23 RID: 15651
		private delegate bool UnloadSceneInternal_InjectedDelegate(IntPtr scene, UnloadSceneOptions options);

		// Token: 0x02000A2B RID: 2603
		// (Invoke) Token: 0x06003D25 RID: 15653
		private delegate void MergeScenes_InjectedDelegate(IntPtr sourceScene, IntPtr destinationScene);

		// Token: 0x02000A2C RID: 2604
		// (Invoke) Token: 0x06003D27 RID: 15655
		private delegate void MoveGameObjectsToSceneByInstanceId_InjectedDelegate(IntPtr instanceIds, int instanceCount, IntPtr scene);
	}
}

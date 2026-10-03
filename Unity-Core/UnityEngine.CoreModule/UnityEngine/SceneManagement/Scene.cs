using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.SceneManagement
{
	// Token: 0x020001B2 RID: 434
	[Serializable]
	[StructLayout(2)]
	public struct Scene
	{
		// Token: 0x06001FE1 RID: 8161 RVA: 0x00082B80 File Offset: 0x00080D80
		// Note: this type is marked as 'beforefieldinit'.
		static Scene()
		{
			Il2CppClassPointerStore<Scene>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "Scene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scene>.NativeClassPtr);
			Scene.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scene>.NativeClassPtr, "m_Handle");
			Scene.NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666774);
			Scene.NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666775);
			Scene.NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666776);
			Scene.NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666777);
			Scene.NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666778);
			Scene.NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666779);
			Scene.NativeMethodInfoPtr_get_handle_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666780);
			Scene.NativeMethodInfoPtr_get_guid_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666781);
			Scene.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666782);
			Scene.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666783);
			Scene.NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666784);
			Scene.NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666785);
			Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666786);
			Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666787);
			Scene.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666788);
			Scene.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666789);
			Scene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666790);
			Scene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100666791);
			Scene.GetPathInternalDelegateField = IL2CPP.ResolveICall<Scene.GetPathInternalDelegate>("UnityEngine.SceneManagement.Scene::GetPathInternal");
			Scene.SetPathAndGUIDInternalDelegateField = IL2CPP.ResolveICall<Scene.SetPathAndGUIDInternalDelegate>("UnityEngine.SceneManagement.Scene::SetPathAndGUIDInternal");
			Scene.SetNameInternalDelegateField = IL2CPP.ResolveICall<Scene.SetNameInternalDelegate>("UnityEngine.SceneManagement.Scene::SetNameInternal");
			Scene.IsSubSceneDelegateField = IL2CPP.ResolveICall<Scene.IsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::IsSubScene");
			Scene.SetIsSubSceneDelegateField = IL2CPP.ResolveICall<Scene.SetIsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::SetIsSubScene");
			Scene.GetLoadingStateInternalDelegateField = IL2CPP.ResolveICall<Scene.GetLoadingStateInternalDelegate>("UnityEngine.SceneManagement.Scene::GetLoadingStateInternal");
			Scene.GetIsDirtyInternalDelegateField = IL2CPP.ResolveICall<Scene.GetIsDirtyInternalDelegate>("UnityEngine.SceneManagement.Scene::GetIsDirtyInternal");
			Scene.GetDirtyIDDelegateField = IL2CPP.ResolveICall<Scene.GetDirtyIDDelegate>("UnityEngine.SceneManagement.Scene::GetDirtyID");
			Scene.GetBuildIndexInternalDelegateField = IL2CPP.ResolveICall<Scene.GetBuildIndexInternalDelegate>("UnityEngine.SceneManagement.Scene::GetBuildIndexInternal");
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00082DB4 File Offset: 0x00080FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285925, XrefRangeEnd = 1285927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidInternal(int sceneHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sceneHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00082DF4 File Offset: 0x00080FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285927, XrefRangeEnd = 1285929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNameInternal(int sceneHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sceneHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00082E2C File Offset: 0x0008102C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285929, XrefRangeEnd = 1285931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetGUIDInternal(int sceneHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sceneHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00082E64 File Offset: 0x00081064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285931, XrefRangeEnd = 1285933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetIsLoadedInternal(int sceneHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sceneHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00082EA4 File Offset: 0x000810A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285933, XrefRangeEnd = 1285935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetRootCountInternal(int sceneHandle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sceneHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00082EE4 File Offset: 0x000810E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285935, XrefRangeEnd = 1285937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRootGameObjectsInternal(int sceneHandle, Object resultRootList)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sceneHandle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultRootList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x00082F28 File Offset: 0x00081128
		public unsafe int handle
		{
			[CallerCount(261)]
			[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_handle_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x00082F58 File Offset: 0x00081158
		public unsafe string guid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285937, XrefRangeEnd = 1285939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_guid_Internal_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00082F84 File Offset: 0x00081184
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1285941, RefRangeEnd = 1285970, XrefRangeStart = 1285939, XrefRangeEnd = 1285941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x00082FB4 File Offset: 0x000811B4
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x0000ED5A File Offset: 0x0000CF5A
		public unsafe string name
		{
			[CallerCount(52)]
			[CachedScanResults(RefRangeStart = 1285972, RefRangeEnd = 1286024, XrefRangeStart = 1285970, XrefRangeEnd = 1285972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_name_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				Scene.SetNameInternal(this.handle, value);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x00082FE0 File Offset: 0x000811E0
		public unsafe bool isLoaded
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1286026, RefRangeEnd = 1286034, XrefRangeStart = 1286024, XrefRangeEnd = 1286026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x00083010 File Offset: 0x00081210
		public unsafe int rootCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286034, XrefRangeEnd = 1286036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00083040 File Offset: 0x00081240
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1286049, RefRangeEnd = 1286053, XrefRangeStart = 1286036, XrefRangeEnd = 1286049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<GameObject> GetRootGameObjects()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr3) : null;
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x00083074 File Offset: 0x00081274
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1286077, RefRangeEnd = 1286080, XrefRangeStart = 1286053, XrefRangeEnd = 1286077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRootGameObjects(List<GameObject> rootGameObjects)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootGameObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x000830AC File Offset: 0x000812AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1246094, RefRangeEnd = 1246100, XrefRangeStart = 1246094, XrefRangeEnd = 1246100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Scene lhs, Scene rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scene_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x000830F8 File Offset: 0x000812F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1286080, RefRangeEnd = 1286085, XrefRangeStart = 1286080, XrefRangeEnd = 1286080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Scene lhs, Scene rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Scene_Scene_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x00083144 File Offset: 0x00081344
		[CallerCount(261)]
		[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00083174 File Offset: 0x00081374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286085, XrefRangeEnd = 1286088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0000ECCD File Offset: 0x0000CECD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scene>.NativeClassPtr, ref this));
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x000831B8 File Offset: 0x000813B8
		public static string GetPathInternal(int sceneHandle)
		{
			IntPtr intPtr = Scene.GetPathInternalDelegateField(sceneHandle);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0000ECDF File Offset: 0x0000CEDF
		public static void SetPathAndGUIDInternal(int sceneHandle, string path, string guid)
		{
			Scene.SetPathAndGUIDInternalDelegateField(sceneHandle, IL2CPP.ManagedStringToIl2Cpp(path), IL2CPP.ManagedStringToIl2Cpp(guid));
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
		public static void SetNameInternal(int sceneHandle, string name)
		{
			Scene.SetNameInternalDelegateField(sceneHandle, IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0000ED0B File Offset: 0x0000CF0B
		public static bool IsSubScene(int sceneHandle)
		{
			return Scene.IsSubSceneDelegateField(sceneHandle);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0000ED18 File Offset: 0x0000CF18
		public static void SetIsSubScene(int sceneHandle, bool value)
		{
			Scene.SetIsSubSceneDelegateField(sceneHandle, value);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0000ED26 File Offset: 0x0000CF26
		public static Scene.LoadingState GetLoadingStateInternal(int sceneHandle)
		{
			return Scene.GetLoadingStateInternalDelegateField(sceneHandle);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x0000ED33 File Offset: 0x0000CF33
		public static bool GetIsDirtyInternal(int sceneHandle)
		{
			return Scene.GetIsDirtyInternalDelegateField(sceneHandle);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0000ED40 File Offset: 0x0000CF40
		public static int GetDirtyID(int sceneHandle)
		{
			return Scene.GetDirtyIDDelegateField(sceneHandle);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x0000ED4D File Offset: 0x0000CF4D
		public static int GetBuildIndexInternal(int sceneHandle)
		{
			return Scene.GetBuildIndexInternalDelegateField(sceneHandle);
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x000831D8 File Offset: 0x000813D8
		public Scene.LoadingState loadingState
		{
			get
			{
				return Scene.GetLoadingStateInternal(this.handle);
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x000831F8 File Offset: 0x000813F8
		public string path
		{
			get
			{
				return Scene.GetPathInternal(this.handle);
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x00083218 File Offset: 0x00081418
		public int buildIndex
		{
			get
			{
				return Scene.GetBuildIndexInternal(this.handle);
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x00083238 File Offset: 0x00081438
		public bool isDirty
		{
			get
			{
				return Scene.GetIsDirtyInternal(this.handle);
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x00083258 File Offset: 0x00081458
		public int dirtyID
		{
			get
			{
				return Scene.GetDirtyID(this.handle);
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x00083278 File Offset: 0x00081478
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x0000ED6A File Offset: 0x0000CF6A
		public bool isSubScene
		{
			get
			{
				return Scene.IsSubScene(this.handle);
			}
			set
			{
				Scene.SetIsSubScene(this.handle, value);
			}
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0000ED7A File Offset: 0x0000CF7A
		public void SetPathAndGuid(string path, string guid)
		{
			Scene.SetPathAndGUIDInternal(this.m_Handle, path, guid);
		}

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0;

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr_get_handle_Public_get_Int32_0;

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeMethodInfoPtr_get_guid_Internal_get_String_0;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scene_Scene_0;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Scene_Scene_0;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040019ED RID: 6637
		[FieldOffset(0)]
		public int m_Handle;

		// Token: 0x040019EE RID: 6638
		private static readonly Scene.GetPathInternalDelegate GetPathInternalDelegateField;

		// Token: 0x040019EF RID: 6639
		private static readonly Scene.SetPathAndGUIDInternalDelegate SetPathAndGUIDInternalDelegateField;

		// Token: 0x040019F0 RID: 6640
		private static readonly Scene.SetNameInternalDelegate SetNameInternalDelegateField;

		// Token: 0x040019F1 RID: 6641
		private static readonly Scene.IsSubSceneDelegate IsSubSceneDelegateField;

		// Token: 0x040019F2 RID: 6642
		private static readonly Scene.SetIsSubSceneDelegate SetIsSubSceneDelegateField;

		// Token: 0x040019F3 RID: 6643
		private static readonly Scene.GetLoadingStateInternalDelegate GetLoadingStateInternalDelegateField;

		// Token: 0x040019F4 RID: 6644
		private static readonly Scene.GetIsDirtyInternalDelegate GetIsDirtyInternalDelegateField;

		// Token: 0x040019F5 RID: 6645
		private static readonly Scene.GetDirtyIDDelegate GetDirtyIDDelegateField;

		// Token: 0x040019F6 RID: 6646
		private static readonly Scene.GetBuildIndexInternalDelegate GetBuildIndexInternalDelegateField;

		// Token: 0x02000A1A RID: 2586
		public enum LoadingState
		{
			// Token: 0x04002BA3 RID: 11171
			NotLoaded,
			// Token: 0x04002BA4 RID: 11172
			Loading,
			// Token: 0x04002BA5 RID: 11173
			Loaded,
			// Token: 0x04002BA6 RID: 11174
			Unloading
		}

		// Token: 0x02000A1B RID: 2587
		// (Invoke) Token: 0x06003D05 RID: 15621
		private delegate IntPtr GetPathInternalDelegate(int sceneHandle);

		// Token: 0x02000A1C RID: 2588
		// (Invoke) Token: 0x06003D07 RID: 15623
		private delegate void SetPathAndGUIDInternalDelegate(int sceneHandle, IntPtr path, IntPtr guid);

		// Token: 0x02000A1D RID: 2589
		// (Invoke) Token: 0x06003D09 RID: 15625
		private delegate void SetNameInternalDelegate(int sceneHandle, IntPtr name);

		// Token: 0x02000A1E RID: 2590
		// (Invoke) Token: 0x06003D0B RID: 15627
		private delegate bool IsSubSceneDelegate(int sceneHandle);

		// Token: 0x02000A1F RID: 2591
		// (Invoke) Token: 0x06003D0D RID: 15629
		private delegate void SetIsSubSceneDelegate(int sceneHandle, bool value);

		// Token: 0x02000A20 RID: 2592
		// (Invoke) Token: 0x06003D0F RID: 15631
		private delegate Scene.LoadingState GetLoadingStateInternalDelegate(int sceneHandle);

		// Token: 0x02000A21 RID: 2593
		// (Invoke) Token: 0x06003D11 RID: 15633
		private delegate bool GetIsDirtyInternalDelegate(int sceneHandle);

		// Token: 0x02000A22 RID: 2594
		// (Invoke) Token: 0x06003D13 RID: 15635
		private delegate int GetDirtyIDDelegate(int sceneHandle);

		// Token: 0x02000A23 RID: 2595
		// (Invoke) Token: 0x06003D15 RID: 15637
		private delegate int GetBuildIndexInternalDelegate(int sceneHandle);
	}
}

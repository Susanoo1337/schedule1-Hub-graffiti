using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x0200013B RID: 315
	public sealed class GameObject : Object
	{
		// Token: 0x06001843 RID: 6211 RVA: 0x00067ECC File Offset: 0x000660CC
		// Note: this type is marked as 'beforefieldinit'.
		static GameObject()
		{
			Il2CppClassPointerStore<GameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GameObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObject>.NativeClassPtr);
			GameObject.NativeMethodInfoPtr_CreatePrimitive_Public_Static_GameObject_PrimitiveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665844);
			GameObject.NativeMethodInfoPtr_GetComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665845);
			GameObject.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665846);
			GameObject.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665847);
			GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665848);
			GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665849);
			GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665850);
			GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665851);
			GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665852);
			GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665853);
			GameObject.NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665854);
			GameObject.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665855);
			GameObject.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665856);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665857);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665858);
			GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665859);
			GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665860);
			GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665861);
			GameObject.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665862);
			GameObject.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665863);
			GameObject.NativeMethodInfoPtr_TryGetComponentInternal_Internal_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665864);
			GameObject.NativeMethodInfoPtr_TryGetComponentFastPath_Internal_Void_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665865);
			GameObject.NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665866);
			GameObject.NativeMethodInfoPtr_AddComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665867);
			GameObject.NativeMethodInfoPtr_AddComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665868);
			GameObject.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665869);
			GameObject.NativeMethodInfoPtr_get_layer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665870);
			GameObject.NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665871);
			GameObject.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665872);
			GameObject.NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665873);
			GameObject.NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665874);
			GameObject.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665875);
			GameObject.NativeMethodInfoPtr_set_isStatic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665876);
			GameObject.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665877);
			GameObject.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665878);
			GameObject.NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665879);
			GameObject.NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665880);
			GameObject.NativeMethodInfoPtr_FindGameObjectsWithTag_Public_Static_Il2CppReferenceArray_1_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665881);
			GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665882);
			GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665883);
			GameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665884);
			GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665885);
			GameObject.NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665886);
			GameObject.NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665887);
			GameObject.NativeMethodInfoPtr_get_scene_Public_get_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665888);
			GameObject.NativeMethodInfoPtr_get_sceneCullingMask_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665889);
			GameObject.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665890);
			GameObject.NativeMethodInfoPtr_get_scene_Injected_Private_Void_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObject>.NativeClassPtr, 100665891);
			GameObject.GetComponentByNameDelegateField = IL2CPP.ResolveICall<GameObject.GetComponentByNameDelegate>("UnityEngine.GameObject::GetComponentByName");
			GameObject.GetComponentByNameWithCaseDelegateField = IL2CPP.ResolveICall<GameObject.GetComponentByNameWithCaseDelegate>("UnityEngine.GameObject::GetComponentByNameWithCase");
			GameObject.AddComponentInternalDelegateField = IL2CPP.ResolveICall<GameObject.AddComponentInternalDelegate>("UnityEngine.GameObject::AddComponentInternal");
			GameObject.GetComponentCountDelegateField = IL2CPP.ResolveICall<GameObject.GetComponentCountDelegate>("UnityEngine.GameObject::GetComponentCount");
			GameObject.QueryComponentAtIndexDelegateField = IL2CPP.ResolveICall<GameObject.QueryComponentAtIndexDelegate>("UnityEngine.GameObject::QueryComponentAtIndex");
			GameObject.GetComponentIndexDelegateField = IL2CPP.ResolveICall<GameObject.GetComponentIndexDelegate>("UnityEngine.GameObject::GetComponentIndex");
			GameObject.get_activeDelegateField = IL2CPP.ResolveICall<GameObject.get_activeDelegate>("UnityEngine.GameObject::get_active");
			GameObject.set_activeDelegateField = IL2CPP.ResolveICall<GameObject.set_activeDelegate>("UnityEngine.GameObject::set_active");
			GameObject.SetActiveRecursivelyDelegateField = IL2CPP.ResolveICall<GameObject.SetActiveRecursivelyDelegate>("UnityEngine.GameObject::SetActiveRecursively");
			GameObject.get_isStaticBatchableDelegateField = IL2CPP.ResolveICall<GameObject.get_isStaticBatchableDelegate>("UnityEngine.GameObject::get_isStaticBatchable");
			GameObject.SendMessageUpwardsDelegateField = IL2CPP.ResolveICall<GameObject.SendMessageUpwardsDelegate>("UnityEngine.GameObject::SendMessageUpwards");
			GameObject.BroadcastMessageDelegateField = IL2CPP.ResolveICall<GameObject.BroadcastMessageDelegate>("UnityEngine.GameObject::BroadcastMessage");
			GameObject.SetGameObjectsActiveDelegateField = IL2CPP.ResolveICall<GameObject.SetGameObjectsActiveDelegate>("UnityEngine.GameObject::SetGameObjectsActive");
			GameObject.InstantiateGameObjects_InjectedDelegateField = IL2CPP.ResolveICall<GameObject.InstantiateGameObjects_InjectedDelegate>("UnityEngine.GameObject::InstantiateGameObjects_Injected");
			GameObject.GetScene_InjectedDelegateField = IL2CPP.ResolveICall<GameObject.GetScene_InjectedDelegate>("UnityEngine.GameObject::GetScene_Injected");
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x000683A0 File Offset: 0x000665A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1256350, RefRangeEnd = 1256354, XrefRangeStart = 1256348, XrefRangeEnd = 1256350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreatePrimitive(PrimitiveType type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_CreatePrimitive_Public_Static_GameObject_PrimitiveType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x000683E0 File Offset: 0x000665E0
		[CallerCount(337)]
		[CachedScanResults(RefRangeStart = 1256360, RefRangeEnd = 1256697, XrefRangeStart = 1256354, XrefRangeEnd = 1256360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0006841C File Offset: 0x0006661C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256697, XrefRangeEnd = 1256699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponent(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0006846C File Offset: 0x0006666C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256701, RefRangeEnd = 1256702, XrefRangeStart = 1256699, XrefRangeEnd = 1256701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oneFurtherThanResultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x000684BC File Offset: 0x000666BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1256704, RefRangeEnd = 1256706, XrefRangeStart = 1256702, XrefRangeEnd = 1256704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInChildren(Type type, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0006851C File Offset: 0x0006671C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1256714, RefRangeEnd = 1256721, XrefRangeStart = 1256706, XrefRangeEnd = 1256714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00068558 File Offset: 0x00066758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256728, RefRangeEnd = 1256729, XrefRangeStart = 1256721, XrefRangeEnd = 1256728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInChildren<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x000685A0 File Offset: 0x000667A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1256731, RefRangeEnd = 1256733, XrefRangeStart = 1256729, XrefRangeEnd = 1256731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInParent(Type type, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00068600 File Offset: 0x00066800
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1256741, RefRangeEnd = 1256752, XrefRangeStart = 1256733, XrefRangeEnd = 1256741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInParent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0006863C File Offset: 0x0006683C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256752, XrefRangeEnd = 1256759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInParent<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentInParent_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00068684 File Offset: 0x00066884
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1256761, RefRangeEnd = 1256768, XrefRangeStart = 1256759, XrefRangeEnd = 1256761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, Object resultList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSearchTypeAsArrayReturnType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recursive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reverse;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00068720 File Offset: 0x00066920
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1256775, RefRangeEnd = 1256789, XrefRangeStart = 1256768, XrefRangeEnd = 1256775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponents<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00068758 File Offset: 0x00066958
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1256795, RefRangeEnd = 1256800, XrefRangeStart = 1256789, XrefRangeEnd = 1256795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponents<T>(List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0006879C File Offset: 0x0006699C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1256807, RefRangeEnd = 1256828, XrefRangeStart = 1256800, XrefRangeEnd = 1256807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x000687E0 File Offset: 0x000669E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1256834, RefRangeEnd = 1256837, XrefRangeStart = 1256828, XrefRangeEnd = 1256834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00068830 File Offset: 0x00066A30
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1256845, RefRangeEnd = 1256869, XrefRangeStart = 1256837, XrefRangeEnd = 1256845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00068868 File Offset: 0x00066A68
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1256875, RefRangeEnd = 1256884, XrefRangeStart = 1256869, XrefRangeEnd = 1256875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x000688B8 File Offset: 0x00066AB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1256891, RefRangeEnd = 1256893, XrefRangeStart = 1256884, XrefRangeEnd = 1256891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x000688FC File Offset: 0x00066AFC
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1256900, RefRangeEnd = 1256930, XrefRangeStart = 1256893, XrefRangeEnd = 1256900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetComponent<T>(out T component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref component;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00068988 File Offset: 0x00066B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256930, XrefRangeEnd = 1256943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetComponent(Type type, out Component component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			component = ((intPtr4 == 0) ? null : new Component(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x000689F8 File Offset: 0x00066BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256943, XrefRangeEnd = 1256945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component TryGetComponentInternal(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_TryGetComponentInternal_Internal_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00068A48 File Offset: 0x00066C48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1256947, RefRangeEnd = 1256948, XrefRangeStart = 1256945, XrefRangeEnd = 1256947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oneFurtherThanResultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_TryGetComponentFastPath_Internal_Void_Type_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00068A98 File Offset: 0x00066C98
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1256950, RefRangeEnd = 1256956, XrefRangeStart = 1256948, XrefRangeEnd = 1256950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component Internal_AddComponentWithType(Type componentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00068AE8 File Offset: 0x00066CE8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1256950, RefRangeEnd = 1256956, XrefRangeStart = 1256950, XrefRangeEnd = 1256956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component AddComponent(Type componentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(componentType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_AddComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00068B38 File Offset: 0x00066D38
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 1256965, RefRangeEnd = 1257149, XrefRangeStart = 1256956, XrefRangeEnd = 1256965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T AddComponent<T>() where T : Component
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.MethodInfoStoreGeneric_AddComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x00068B74 File Offset: 0x00066D74
		public unsafe Transform transform
		{
			[CallerCount(341)]
			[CachedScanResults(RefRangeStart = 1257151, RefRangeEnd = 1257492, XrefRangeStart = 1257149, XrefRangeEnd = 1257151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x00068BB4 File Offset: 0x00066DB4
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x00068BF0 File Offset: 0x00066DF0
		public unsafe int layer
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 1257494, RefRangeEnd = 1257539, XrefRangeStart = 1257492, XrefRangeEnd = 1257494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_layer_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 1257541, RefRangeEnd = 1257568, XrefRangeStart = 1257539, XrefRangeEnd = 1257541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00068C30 File Offset: 0x00066E30
		[CallerCount(1234)]
		[CachedScanResults(RefRangeStart = 1257570, RefRangeEnd = 1258804, XrefRangeStart = 1257568, XrefRangeEnd = 1257570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x00068C70 File Offset: 0x00066E70
		public unsafe bool activeSelf
		{
			[CallerCount(59)]
			[CachedScanResults(RefRangeStart = 1258806, RefRangeEnd = 1258865, XrefRangeStart = 1258804, XrefRangeEnd = 1258806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x00068CAC File Offset: 0x00066EAC
		public unsafe bool activeInHierarchy
		{
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 1258867, RefRangeEnd = 1258946, XrefRangeStart = 1258865, XrefRangeEnd = 1258867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x00068CE8 File Offset: 0x00066EE8
		// (set) Token: 0x06001864 RID: 6244 RVA: 0x00068D24 File Offset: 0x00066F24
		public unsafe bool isStatic
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1258948, RefRangeEnd = 1258955, XrefRangeStart = 1258946, XrefRangeEnd = 1258948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1258957, RefRangeEnd = 1258958, XrefRangeStart = 1258955, XrefRangeEnd = 1258957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_set_isStatic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x00068D64 File Offset: 0x00066F64
		// (set) Token: 0x06001866 RID: 6246 RVA: 0x00068D9C File Offset: 0x00066F9C
		public unsafe string tag
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1258960, RefRangeEnd = 1258965, XrefRangeStart = 1258958, XrefRangeEnd = 1258960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1258967, RefRangeEnd = 1258971, XrefRangeStart = 1258965, XrefRangeEnd = 1258967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_set_tag_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x00068DE0 File Offset: 0x00066FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258973, RefRangeEnd = 1258974, XrefRangeStart = 1258971, XrefRangeEnd = 1258973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00068E30 File Offset: 0x00067030
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1258976, RefRangeEnd = 1258979, XrefRangeStart = 1258974, XrefRangeEnd = 1258976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject FindGameObjectWithTag(string tag)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00068E74 File Offset: 0x00067074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258981, RefRangeEnd = 1258982, XrefRangeStart = 1258979, XrefRangeEnd = 1258981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<GameObject> FindGameObjectsWithTag(string tag)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_FindGameObjectsWithTag_Public_Static_Il2CppReferenceArray_1_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr3) : null;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00068EB8 File Offset: 0x000670B8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1258984, RefRangeEnd = 1258996, XrefRangeStart = 1258982, XrefRangeEnd = 1258984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string methodName, Object value, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00068F1C File Offset: 0x0006711C
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1259002, RefRangeEnd = 1259055, XrefRangeStart = 1258996, XrefRangeEnd = 1259002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00068F68 File Offset: 0x00067168
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1259061, RefRangeEnd = 1259078, XrefRangeStart = 1259055, XrefRangeEnd = 1259061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00068FA4 File Offset: 0x000671A4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1259087, RefRangeEnd = 1259099, XrefRangeStart = 1259078, XrefRangeEnd = 1259087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject(string name, [Optional] Il2CppReferenceArray<Type> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<Type>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObject>.NativeClassPtr));
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00069010 File Offset: 0x00067210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259099, XrefRangeEnd = 1259101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreateGameObject(GameObject self, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00069058 File Offset: 0x00067258
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1259103, RefRangeEnd = 1259115, XrefRangeStart = 1259101, XrefRangeEnd = 1259103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject Find(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x0006909C File Offset: 0x0006729C
		public unsafe UnityEngine.SceneManagement.Scene scene
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 1259117, RefRangeEnd = 1259141, XrefRangeStart = 1259115, XrefRangeEnd = 1259117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_scene_Public_get_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x000690D8 File Offset: 0x000672D8
		public unsafe ulong sceneCullingMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259143, RefRangeEnd = 1259144, XrefRangeStart = 1259141, XrefRangeEnd = 1259143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_sceneCullingMask_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00069114 File Offset: 0x00067314
		public unsafe GameObject gameObject
		{
			[CallerCount(217)]
			[CachedScanResults(RefRangeStart = 533113, RefRangeEnd = 533330, XrefRangeStart = 533113, XrefRangeEnd = 533330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00069154 File Offset: 0x00067354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259144, XrefRangeEnd = 1259146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_scene_Injected(out UnityEngine.SceneManagement.Scene ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObject.NativeMethodInfoPtr_get_scene_Injected_Private_Void_byref_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0000C150 File Offset: 0x0000A350
		public GameObject(string name, params Type[] components) : this(name, new Il2CppReferenceArray<Type>(components))
		{
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0000C15F File Offset: 0x0000A35F
		public GameObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00069194 File Offset: 0x00067394
		public Component GetComponentByName(string type)
		{
			IntPtr intPtr = GameObject.GetComponentByNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x000691C8 File Offset: 0x000673C8
		public Component GetComponentByNameWithCase(string type, bool caseSensitive)
		{
			IntPtr intPtr = GameObject.GetComponentByNameWithCaseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(type), caseSensitive);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x000691FC File Offset: 0x000673FC
		public Component GetComponent(string type)
		{
			return this.GetComponentByName(type);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00069218 File Offset: 0x00067418
		public Component GetComponentInChildren(Type type)
		{
			return this.GetComponentInChildren(type, false);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00069234 File Offset: 0x00067434
		public Component GetComponentInParent(Type type)
		{
			return this.GetComponentInParent(type, false);
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00069250 File Offset: 0x00067450
		public Il2CppReferenceArray<Component> GetComponents(Type type)
		{
			return this.GetComponentsInternal(type, false, false, true, false, null).Cast<Il2CppReferenceArray<Component>>();
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0000C168 File Offset: 0x0000A368
		public void GetComponents(Type type, List<Component> results)
		{
			this.GetComponentsInternal(type, false, false, true, false, results);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00069274 File Offset: 0x00067474
		public Il2CppReferenceArray<Component> GetComponentsInChildren(Type type)
		{
			bool includeInactive = false;
			return this.GetComponentsInChildren(type, includeInactive);
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00069290 File Offset: 0x00067490
		public Il2CppReferenceArray<Component> GetComponentsInChildren(Type type, bool includeInactive)
		{
			return this.GetComponentsInternal(type, false, true, includeInactive, false, null).Cast<Il2CppReferenceArray<Component>>();
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x0000C178 File Offset: 0x0000A378
		public void GetComponentsInChildren<T>(List<T> results)
		{
			this.GetComponentsInChildren<T>(false, results);
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000692B4 File Offset: 0x000674B4
		public Il2CppReferenceArray<Component> GetComponentsInParent(Type type)
		{
			bool includeInactive = false;
			return this.GetComponentsInParent(type, includeInactive);
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x000692D0 File Offset: 0x000674D0
		public Il2CppReferenceArray<Component> GetComponentsInParent(Type type, bool includeInactive)
		{
			return this.GetComponentsInternal(type, false, true, includeInactive, true, null).Cast<Il2CppReferenceArray<Component>>();
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x000692F4 File Offset: 0x000674F4
		public Il2CppArrayBase<T> GetComponentsInParent<T>()
		{
			return this.GetComponentsInParent<T>(false);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00069310 File Offset: 0x00067510
		public static GameObject FindWithTag(string tag)
		{
			return GameObject.FindGameObjectWithTag(tag);
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x0000C184 File Offset: 0x0000A384
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
			this.SendMessageUpwards(methodName, null, options);
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0000C191 File Offset: 0x0000A391
		public void SendMessage(string methodName, SendMessageOptions options)
		{
			this.SendMessage(methodName, null, options);
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x0000C19E File Offset: 0x0000A39E
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
			this.BroadcastMessage(methodName, null, options);
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00069328 File Offset: 0x00067528
		public Component AddComponentInternal(string className)
		{
			IntPtr intPtr = GameObject.AddComponentInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(className));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0000C1AB File Offset: 0x0000A3AB
		public int GetComponentCount()
		{
			return GameObject.GetComponentCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0006935C File Offset: 0x0006755C
		public Component QueryComponentAtIndex(int index)
		{
			IntPtr intPtr = GameObject.QueryComponentAtIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0006938C File Offset: 0x0006758C
		public Component GetComponentAtIndex(int index)
		{
			bool flag = index < 0 || index >= this.GetComponentCount();
			if (flag)
			{
				throw new ArgumentOutOfRangeException("index", "Valid range is 0 to GetComponentCount() - 1.");
			}
			return this.QueryComponentAtIndex(index);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x000693CC File Offset: 0x000675CC
		public T GetComponentAtIndex<T>(int index) where T : Component
		{
			T t = this.GetComponentAtIndex(index).Cast<T>();
			bool flag = t == null;
			if (flag)
			{
				throw new InvalidCastException();
			}
			return t;
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0000C1BD File Offset: 0x0000A3BD
		public int GetComponentIndex(Component component)
		{
			return GameObject.GetComponentIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(component));
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x0000C1D5 File Offset: 0x0000A3D5
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x0000C1E7 File Offset: 0x0000A3E7
		public bool active
		{
			get
			{
				return GameObject.get_activeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				GameObject.set_activeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0000C1FA File Offset: 0x0000A3FA
		public void SetActiveRecursively(bool state)
		{
			GameObject.SetActiveRecursivelyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), state);
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x0000C20D File Offset: 0x0000A40D
		public bool isStaticBatchable
		{
			get
			{
				return GameObject.get_isStaticBatchableDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0000C21F File Offset: 0x0000A41F
		public void SendMessageUpwards(string methodName, Object value, SendMessageOptions options)
		{
			GameObject.SendMessageUpwardsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(methodName), IL2CPP.Il2CppObjectBaseToPtr(value), options);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00069404 File Offset: 0x00067604
		public void SendMessageUpwards(string methodName, Object value)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.SendMessageUpwards(methodName, value, options);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00069420 File Offset: 0x00067620
		public void SendMessageUpwards(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			Object value = null;
			this.SendMessageUpwards(methodName, value, options);
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0006943C File Offset: 0x0006763C
		public void SendMessage(string methodName, Object value)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.SendMessage(methodName, value, options);
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00069458 File Offset: 0x00067658
		public void SendMessage(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			Object value = null;
			this.SendMessage(methodName, value, options);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0000C23E File Offset: 0x0000A43E
		public void BroadcastMessage(string methodName, Object parameter, SendMessageOptions options)
		{
			GameObject.BroadcastMessageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(methodName), IL2CPP.Il2CppObjectBaseToPtr(parameter), options);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00069474 File Offset: 0x00067674
		public void BroadcastMessage(string methodName, Object parameter)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			this.BroadcastMessage(methodName, parameter, options);
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00069490 File Offset: 0x00067690
		public void BroadcastMessage(string methodName)
		{
			SendMessageOptions options = SendMessageOptions.RequireReceiver;
			Object parameter = null;
			this.BroadcastMessage(methodName, parameter, options);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0000C25D File Offset: 0x0000A45D
		public static void SetGameObjectsActive(IntPtr instanceIds, int instanceCount, bool active)
		{
			GameObject.SetGameObjectsActiveDelegateField(instanceIds, instanceCount, active);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x000694AC File Offset: 0x000676AC
		public static void SetGameObjectsActive(Unity.Collections.NativeArray<int> instanceIDs, bool active)
		{
			bool flag = !instanceIDs.IsCreated;
			if (flag)
			{
				throw new ArgumentException("NativeArray is uninitialized", "instanceIDs");
			}
			bool flag2 = instanceIDs.Length == 0;
			if (!flag2)
			{
				GameObject.SetGameObjectsActive((IntPtr)instanceIDs.GetUnsafeReadOnlyPtr<int>(), instanceIDs.Length, active);
			}
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00069504 File Offset: 0x00067704
		public unsafe static void SetGameObjectsActive(ReadOnlySpan<int> instanceIDs, bool active)
		{
			bool flag = instanceIDs.Length == 0;
			if (!flag)
			{
				fixed (int* pinnableReference = instanceIDs.GetPinnableReference())
				{
					int* value = pinnableReference;
					GameObject.SetGameObjectsActive((IntPtr)((void*)value), instanceIDs.Length, active);
				}
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0000C26C File Offset: 0x0000A46C
		public static void InstantiateGameObjects(int sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, UnityEngine.SceneManagement.Scene destinationScene)
		{
			GameObject.InstantiateGameObjects_Injected(sourceInstanceID, newInstanceIDs, newTransformInstanceIDs, count, ref destinationScene);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00069548 File Offset: 0x00067748
		public static void InstantiateGameObjects(int sourceInstanceID, int count, Unity.Collections.NativeArray<int> newInstanceIDs, Unity.Collections.NativeArray<int> newTransformInstanceIDs, [Optional] UnityEngine.SceneManagement.Scene destinationScene)
		{
			bool flag = !newInstanceIDs.IsCreated;
			if (flag)
			{
				throw new ArgumentException("NativeArray is uninitialized", "newInstanceIDs");
			}
			bool flag2 = !newTransformInstanceIDs.IsCreated;
			if (flag2)
			{
				throw new ArgumentException("NativeArray is uninitialized", "newTransformInstanceIDs");
			}
			bool flag3 = count == 0;
			if (!flag3)
			{
				bool flag4 = count != newInstanceIDs.Length || count != newTransformInstanceIDs.Length;
				if (flag4)
				{
					throw new ArgumentException("Size mismatch! Both arrays must already be the size of count.");
				}
				GameObject.InstantiateGameObjects(sourceInstanceID, (IntPtr)newInstanceIDs.GetUnsafeReadOnlyPtr<int>(), (IntPtr)newTransformInstanceIDs.GetUnsafeReadOnlyPtr<int>(), newInstanceIDs.Length, destinationScene);
			}
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000695EC File Offset: 0x000677EC
		public static UnityEngine.SceneManagement.Scene GetScene(int instanceID)
		{
			UnityEngine.SceneManagement.Scene result;
			GameObject.GetScene_Injected(instanceID, out result);
			return result;
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0000C279 File Offset: 0x0000A479
		public static void InstantiateGameObjects_Injected(int sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, ref UnityEngine.SceneManagement.Scene destinationScene)
		{
			GameObject.InstantiateGameObjects_InjectedDelegateField(sourceInstanceID, newInstanceIDs, newTransformInstanceIDs, count, ref destinationScene);
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0000C28B File Offset: 0x0000A48B
		public static void GetScene_Injected(int instanceID, out UnityEngine.SceneManagement.Scene ret)
		{
			GameObject.GetScene_InjectedDelegateField(instanceID, out ret);
		}

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr_CreatePrimitive_Public_Static_GameObject_PrimitiveType_0;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_T_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_Component_Type_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_0;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_0;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInternal_Private_Array_Type_Boolean_Boolean_Boolean_Boolean_Object_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponentInternal_Internal_Component_Type_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponentFastPath_Internal_Void_Type_IntPtr_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_Internal_AddComponentWithType_Private_Component_Type_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Component_Type_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_T_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_get_layer_Public_get_Int32_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_set_layer_Public_set_Void_Int32_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr_get_activeSelf_Public_get_Boolean_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr_get_activeInHierarchy_Public_get_Boolean_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr_set_isStatic_Public_set_Void_Boolean_0;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr_set_tag_Public_set_Void_String_0;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr_FindGameObjectWithTag_Public_Static_GameObject_String_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr_FindGameObjectsWithTag_Public_Static_Il2CppReferenceArray_1_GameObject_String_0;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400147A RID: 5242
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateGameObject_Private_Static_Void_GameObject_String_0;

		// Token: 0x0400147B RID: 5243
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_GameObject_String_0;

		// Token: 0x0400147C RID: 5244
		private static readonly IntPtr NativeMethodInfoPtr_get_scene_Public_get_Scene_0;

		// Token: 0x0400147D RID: 5245
		private static readonly IntPtr NativeMethodInfoPtr_get_sceneCullingMask_Public_get_UInt64_0;

		// Token: 0x0400147E RID: 5246
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		// Token: 0x0400147F RID: 5247
		private static readonly IntPtr NativeMethodInfoPtr_get_scene_Injected_Private_Void_byref_Scene_0;

		// Token: 0x04001480 RID: 5248
		private static readonly GameObject.GetComponentByNameDelegate GetComponentByNameDelegateField;

		// Token: 0x04001481 RID: 5249
		private static readonly GameObject.GetComponentByNameWithCaseDelegate GetComponentByNameWithCaseDelegateField;

		// Token: 0x04001482 RID: 5250
		private static readonly GameObject.AddComponentInternalDelegate AddComponentInternalDelegateField;

		// Token: 0x04001483 RID: 5251
		private static readonly GameObject.GetComponentCountDelegate GetComponentCountDelegateField;

		// Token: 0x04001484 RID: 5252
		private static readonly GameObject.QueryComponentAtIndexDelegate QueryComponentAtIndexDelegateField;

		// Token: 0x04001485 RID: 5253
		private static readonly GameObject.GetComponentIndexDelegate GetComponentIndexDelegateField;

		// Token: 0x04001486 RID: 5254
		private static readonly GameObject.get_activeDelegate get_activeDelegateField;

		// Token: 0x04001487 RID: 5255
		private static readonly GameObject.set_activeDelegate set_activeDelegateField;

		// Token: 0x04001488 RID: 5256
		private static readonly GameObject.SetActiveRecursivelyDelegate SetActiveRecursivelyDelegateField;

		// Token: 0x04001489 RID: 5257
		private static readonly GameObject.get_isStaticBatchableDelegate get_isStaticBatchableDelegateField;

		// Token: 0x0400148A RID: 5258
		private static readonly GameObject.SendMessageUpwardsDelegate SendMessageUpwardsDelegateField;

		// Token: 0x0400148B RID: 5259
		private static readonly GameObject.BroadcastMessageDelegate BroadcastMessageDelegateField;

		// Token: 0x0400148C RID: 5260
		private static readonly GameObject.SetGameObjectsActiveDelegate SetGameObjectsActiveDelegateField;

		// Token: 0x0400148D RID: 5261
		private static readonly GameObject.InstantiateGameObjects_InjectedDelegate InstantiateGameObjects_InjectedDelegateField;

		// Token: 0x0400148E RID: 5262
		private static readonly GameObject.GetScene_InjectedDelegate GetScene_InjectedDelegateField;

		// Token: 0x020008C7 RID: 2247
		private sealed class MethodInfoStoreGeneric_GetComponent_Public_T_0<T>
		{
			// Token: 0x04002B26 RID: 11046
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008C8 RID: 2248
		private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>
		{
			// Token: 0x04002B27 RID: 11047
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008C9 RID: 2249
		private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>
		{
			// Token: 0x04002B28 RID: 11048
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008CA RID: 2250
		private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>
		{
			// Token: 0x04002B29 RID: 11049
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008CB RID: 2251
		private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_Boolean_0<T>
		{
			// Token: 0x04002B2A RID: 11050
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentInParent_Public_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008CC RID: 2252
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002B2B RID: 11051
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008CD RID: 2253
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>
		{
			// Token: 0x04002B2C RID: 11052
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008CE RID: 2254
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04002B2D RID: 11053
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008CF RID: 2255
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04002B2E RID: 11054
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008D0 RID: 2256
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002B2F RID: 11055
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008D1 RID: 2257
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04002B30 RID: 11056
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008D2 RID: 2258
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04002B31 RID: 11057
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008D3 RID: 2259
		private sealed class MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x04002B32 RID: 11058
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008D4 RID: 2260
		private sealed class MethodInfoStoreGeneric_AddComponent_Public_T_0<T>
		{
			// Token: 0x04002B33 RID: 11059
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObject.NativeMethodInfoPtr_AddComponent_Public_T_0, Il2CppClassPointerStore<GameObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008D5 RID: 2261
		// (Invoke) Token: 0x06003A27 RID: 14887
		private delegate IntPtr GetComponentByNameDelegate(IntPtr @this, IntPtr type);

		// Token: 0x020008D6 RID: 2262
		// (Invoke) Token: 0x06003A29 RID: 14889
		private delegate IntPtr GetComponentByNameWithCaseDelegate(IntPtr @this, IntPtr type, bool caseSensitive);

		// Token: 0x020008D7 RID: 2263
		// (Invoke) Token: 0x06003A2B RID: 14891
		private delegate IntPtr AddComponentInternalDelegate(IntPtr @this, IntPtr className);

		// Token: 0x020008D8 RID: 2264
		// (Invoke) Token: 0x06003A2D RID: 14893
		private delegate int GetComponentCountDelegate(IntPtr @this);

		// Token: 0x020008D9 RID: 2265
		// (Invoke) Token: 0x06003A2F RID: 14895
		private delegate IntPtr QueryComponentAtIndexDelegate(IntPtr @this, int index);

		// Token: 0x020008DA RID: 2266
		// (Invoke) Token: 0x06003A31 RID: 14897
		private delegate int GetComponentIndexDelegate(IntPtr @this, IntPtr component);

		// Token: 0x020008DB RID: 2267
		// (Invoke) Token: 0x06003A33 RID: 14899
		private delegate bool get_activeDelegate(IntPtr @this);

		// Token: 0x020008DC RID: 2268
		// (Invoke) Token: 0x06003A35 RID: 14901
		private delegate void set_activeDelegate(IntPtr @this, bool value);

		// Token: 0x020008DD RID: 2269
		// (Invoke) Token: 0x06003A37 RID: 14903
		private delegate void SetActiveRecursivelyDelegate(IntPtr @this, bool state);

		// Token: 0x020008DE RID: 2270
		// (Invoke) Token: 0x06003A39 RID: 14905
		private delegate bool get_isStaticBatchableDelegate(IntPtr @this);

		// Token: 0x020008DF RID: 2271
		// (Invoke) Token: 0x06003A3B RID: 14907
		private delegate void SendMessageUpwardsDelegate(IntPtr @this, IntPtr methodName, IntPtr value, SendMessageOptions options);

		// Token: 0x020008E0 RID: 2272
		// (Invoke) Token: 0x06003A3D RID: 14909
		private delegate void BroadcastMessageDelegate(IntPtr @this, IntPtr methodName, IntPtr parameter, SendMessageOptions options);

		// Token: 0x020008E1 RID: 2273
		// (Invoke) Token: 0x06003A3F RID: 14911
		private delegate void SetGameObjectsActiveDelegate(IntPtr instanceIds, int instanceCount, bool active);

		// Token: 0x020008E2 RID: 2274
		// (Invoke) Token: 0x06003A41 RID: 14913
		private delegate void InstantiateGameObjects_InjectedDelegate(int sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, IntPtr destinationScene);

		// Token: 0x020008E3 RID: 2275
		// (Invoke) Token: 0x06003A43 RID: 14915
		private delegate void GetScene_InjectedDelegate(int instanceID, [Out] IntPtr ret);
	}
}

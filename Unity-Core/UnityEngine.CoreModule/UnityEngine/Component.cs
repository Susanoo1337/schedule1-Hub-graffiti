using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000132 RID: 306
	public class Component : Object
	{
		// Token: 0x060017D4 RID: 6100 RVA: 0x0006678C File Offset: 0x0006498C
		// Note: this type is marked as 'beforefieldinit'.
		static Component()
		{
			Il2CppClassPointerStore<Component>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Component");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Component>.NativeClassPtr);
			Component.NativeMethodInfoPtr_get_transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665788);
			Component.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665789);
			Component.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665790);
			Component.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665791);
			Component.NativeMethodInfoPtr_GetComponent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665792);
			Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665793);
			Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665794);
			Component.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665795);
			Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665796);
			Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665797);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665798);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665799);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665800);
			Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665801);
			Component.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665802);
			Component.NativeMethodInfoPtr_GetComponentInParent_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665803);
			Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665804);
			Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665805);
			Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665806);
			Component.NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665807);
			Component.NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665808);
			Component.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665809);
			Component.NativeMethodInfoPtr_get_tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665810);
			Component.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665811);
			Component.NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665812);
			Component.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665813);
			Component.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_Object_SendMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665814);
			Component.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Component>.NativeClassPtr, 100665815);
			Component.GetComponentDelegateField = IL2CPP.ResolveICall<Component.GetComponentDelegate>("UnityEngine.Component::GetComponent");
			Component.GetComponentIndexDelegateField = IL2CPP.ResolveICall<Component.GetComponentIndexDelegate>("UnityEngine.Component::GetComponentIndex");
			Component.SendMessageUpwardsDelegateField = IL2CPP.ResolveICall<Component.SendMessageUpwardsDelegate>("UnityEngine.Component::SendMessageUpwards");
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x00066A1C File Offset: 0x00064C1C
		public unsafe Transform transform
		{
			[CallerCount(3266)]
			[CachedScanResults(RefRangeStart = 1248899, RefRangeEnd = 1252165, XrefRangeStart = 1248897, XrefRangeEnd = 1248899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00066A5C File Offset: 0x00064C5C
		public unsafe GameObject gameObject
		{
			[CallerCount(2065)]
			[CachedScanResults(RefRangeStart = 1252167, RefRangeEnd = 1254232, XrefRangeStart = 1252165, XrefRangeEnd = 1252167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00066A9C File Offset: 0x00064C9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1254237, RefRangeEnd = 1254242, XrefRangeStart = 1254232, XrefRangeEnd = 1254237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponent(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponent_Public_Component_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00066AEC File Offset: 0x00064CEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1254244, RefRangeEnd = 1254245, XrefRangeStart = 1254242, XrefRangeEnd = 1254244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oneFurtherThanResultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x00066B3C File Offset: 0x00064D3C
		[CallerCount(1090)]
		[CachedScanResults(RefRangeStart = 1254251, RefRangeEnd = 1255341, XrefRangeStart = 1254245, XrefRangeEnd = 1254251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x00066B78 File Offset: 0x00064D78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1255356, RefRangeEnd = 1255357, XrefRangeStart = 1255341, XrefRangeEnd = 1255356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetComponent(Type type, out Component component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			component = ((intPtr4 == 0) ? null : new Component(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00066BE8 File Offset: 0x00064DE8
		[CallerCount(47)]
		[CachedScanResults(RefRangeStart = 1255363, RefRangeEnd = 1255410, XrefRangeStart = 1255357, XrefRangeEnd = 1255363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				component = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00066C74 File Offset: 0x00064E74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1255415, RefRangeEnd = 1255417, XrefRangeStart = 1255410, XrefRangeEnd = 1255415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInChildren(Type t, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00066CD4 File Offset: 0x00064ED4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1255424, RefRangeEnd = 1255429, XrefRangeStart = 1255417, XrefRangeEnd = 1255424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInChildren<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00066D1C File Offset: 0x00064F1C
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 1255436, RefRangeEnd = 1255476, XrefRangeStart = 1255429, XrefRangeEnd = 1255436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00066D58 File Offset: 0x00064F58
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1255480, RefRangeEnd = 1255498, XrefRangeStart = 1255476, XrefRangeEnd = 1255480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00066D9C File Offset: 0x00064F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1255502, RefRangeEnd = 1255504, XrefRangeStart = 1255498, XrefRangeEnd = 1255502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInChildren<T>(bool includeInactive, List<T> result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00066DEC File Offset: 0x00064FEC
		[CallerCount(95)]
		[CachedScanResults(RefRangeStart = 1255509, RefRangeEnd = 1255604, XrefRangeStart = 1255504, XrefRangeEnd = 1255509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInChildren<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00066E24 File Offset: 0x00065024
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1255609, RefRangeEnd = 1255614, XrefRangeStart = 1255604, XrefRangeEnd = 1255609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInChildren<T>(List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00066E68 File Offset: 0x00065068
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1255619, RefRangeEnd = 1255620, XrefRangeStart = 1255614, XrefRangeEnd = 1255619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component GetComponentInParent(Type t, bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Component>(intPtr3) : null;
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00066EC8 File Offset: 0x000650C8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 1255627, RefRangeEnd = 1255831, XrefRangeStart = 1255620, XrefRangeEnd = 1255627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetComponentInParent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00066F04 File Offset: 0x00065104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1255835, RefRangeEnd = 1255837, XrefRangeStart = 1255831, XrefRangeEnd = 1255835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>(bool includeInactive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00066F48 File Offset: 0x00065148
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1255841, RefRangeEnd = 1255847, XrefRangeStart = 1255837, XrefRangeEnd = 1255841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00066F98 File Offset: 0x00065198
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1255852, RefRangeEnd = 1255855, XrefRangeStart = 1255847, XrefRangeEnd = 1255852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponentsInParent<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00066FD0 File Offset: 0x000651D0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1255857, RefRangeEnd = 1255866, XrefRangeStart = 1255855, XrefRangeEnd = 1255857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponentsForListInternal(Type searchType, Object resultList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchType);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00067024 File Offset: 0x00065224
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1255857, RefRangeEnd = 1255866, XrefRangeStart = 1255857, XrefRangeEnd = 1255866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponents(Type type, List<Component> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00067078 File Offset: 0x00065278
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1255875, RefRangeEnd = 1255885, XrefRangeStart = 1255866, XrefRangeEnd = 1255875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetComponents<T>(List<T> results)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x000670BC File Offset: 0x000652BC
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x0000BE65 File Offset: 0x0000A065
		public unsafe string tag
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1255890, RefRangeEnd = 1255895, XrefRangeStart = 1255885, XrefRangeEnd = 1255890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_get_tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.gameObject.tag = value;
			}
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x000670F4 File Offset: 0x000652F4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1255902, RefRangeEnd = 1255914, XrefRangeStart = 1255895, XrefRangeEnd = 1255902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> GetComponents<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0006712C File Offset: 0x0006532C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1255919, RefRangeEnd = 1255924, XrefRangeStart = 1255914, XrefRangeEnd = 1255919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareTag(string tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x0006717C File Offset: 0x0006537C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1255926, RefRangeEnd = 1255928, XrefRangeStart = 1255924, XrefRangeEnd = 1255926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(string methodName, Object value, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x000671E0 File Offset: 0x000653E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1255930, RefRangeEnd = 1255932, XrefRangeStart = 1255928, XrefRangeEnd = 1255930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BroadcastMessage(string methodName, Object parameter, SendMessageOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_Object_SendMessageOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00067244 File Offset: 0x00065444
		[CallerCount(1012)]
		[CachedScanResults(RefRangeStart = 1247777, RefRangeEnd = 1248789, XrefRangeStart = 1247777, XrefRangeEnd = 1248789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Component() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Component>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Component.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0000BE5C File Offset: 0x0000A05C
		public Component(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00067280 File Offset: 0x00065480
		public Component GetComponent(string type)
		{
			IntPtr intPtr = Component.GetComponentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x000672B4 File Offset: 0x000654B4
		public Component GetComponentInChildren(Type t)
		{
			return this.GetComponentInChildren(t, false);
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x000672D0 File Offset: 0x000654D0
		public Il2CppReferenceArray<Component> GetComponentsInChildren(Type t, bool includeInactive)
		{
			return this.gameObject.GetComponentsInChildren(t, includeInactive);
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x000672F0 File Offset: 0x000654F0
		public Il2CppReferenceArray<Component> GetComponentsInChildren(Type t)
		{
			return this.gameObject.GetComponentsInChildren(t, false);
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00067310 File Offset: 0x00065510
		public Component GetComponentInParent(Type t)
		{
			return this.gameObject.GetComponentInParent(t, false);
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00067330 File Offset: 0x00065530
		public T GetComponentInParent<T>(bool includeInactive)
		{
			return this.GetComponentInParent(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), includeInactive).Cast<T>();
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00067358 File Offset: 0x00065558
		public Il2CppReferenceArray<Component> GetComponentsInParent(Type t, bool includeInactive)
		{
			return this.gameObject.GetComponentsInParent(t, includeInactive);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00067378 File Offset: 0x00065578
		public Il2CppReferenceArray<Component> GetComponentsInParent(Type t)
		{
			return this.GetComponentsInParent(t, false);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00067394 File Offset: 0x00065594
		public Il2CppReferenceArray<Component> GetComponents(Type type)
		{
			return this.gameObject.GetComponents(type);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0000BE74 File Offset: 0x0000A074
		public int GetComponentIndex()
		{
			return Component.GetComponentIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0000BE86 File Offset: 0x0000A086
		public void SendMessageUpwards(string methodName, Object value, SendMessageOptions options)
		{
			Component.SendMessageUpwardsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(methodName), IL2CPP.Il2CppObjectBaseToPtr(value), options);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0000BEA5 File Offset: 0x0000A0A5
		public void SendMessageUpwards(string methodName, Object value)
		{
			this.SendMessageUpwards(methodName, value, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x0000BEB2 File Offset: 0x0000A0B2
		public void SendMessageUpwards(string methodName)
		{
			this.SendMessageUpwards(methodName, null, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x0000BEBF File Offset: 0x0000A0BF
		public void SendMessageUpwards(string methodName, SendMessageOptions options)
		{
			this.SendMessageUpwards(methodName, null, options);
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x0000BECC File Offset: 0x0000A0CC
		public void SendMessage(string methodName, Object value)
		{
			this.SendMessage(methodName, value, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x0000BED9 File Offset: 0x0000A0D9
		public void SendMessage(string methodName)
		{
			this.SendMessage(methodName, null, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001803 RID: 6147 RVA: 0x0000BEE6 File Offset: 0x0000A0E6
		public void SendMessage(string methodName, SendMessageOptions options)
		{
			this.SendMessage(methodName, null, options);
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x0000BEF3 File Offset: 0x0000A0F3
		public void BroadcastMessage(string methodName, Object parameter)
		{
			this.BroadcastMessage(methodName, parameter, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x0000BF00 File Offset: 0x0000A100
		public void BroadcastMessage(string methodName)
		{
			this.BroadcastMessage(methodName, null, SendMessageOptions.RequireReceiver);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x0000BF0D File Offset: 0x0000A10D
		public void BroadcastMessage(string methodName, SendMessageOptions options)
		{
			this.BroadcastMessage(methodName, null, options);
		}

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Transform_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_Component_Type_0;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentFastPath_Internal_Void_Type_IntPtr_0;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeMethodInfoPtr_GetComponent_Public_T_0;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_Type_byref_Component_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_Component_Type_Boolean_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInChildren_Public_T_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_Component_Type_Boolean_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentInParent_Public_T_0;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsForListInternal_Private_Void_Type_Object_0;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_Type_List_1_Component_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_get_tag_Public_get_String_0;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_CompareTag_Public_Boolean_String_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_String_Object_SendMessageOptions_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_Object_SendMessageOptions_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001430 RID: 5168
		private static readonly Component.GetComponentDelegate GetComponentDelegateField;

		// Token: 0x04001431 RID: 5169
		private static readonly Component.GetComponentIndexDelegate GetComponentIndexDelegateField;

		// Token: 0x04001432 RID: 5170
		private static readonly Component.SendMessageUpwardsDelegate SendMessageUpwardsDelegateField;

		// Token: 0x020008B0 RID: 2224
		private sealed class MethodInfoStoreGeneric_GetComponent_Public_T_0<T>
		{
			// Token: 0x04002B03 RID: 11011
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponent_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008B1 RID: 2225
		private sealed class MethodInfoStoreGeneric_TryGetComponent_Public_Boolean_byref_T_0<T>
		{
			// Token: 0x04002B04 RID: 11012
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_TryGetComponent_Public_Boolean_byref_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008B2 RID: 2226
		private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_Boolean_0<T>
		{
			// Token: 0x04002B05 RID: 11013
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008B3 RID: 2227
		private sealed class MethodInfoStoreGeneric_GetComponentInChildren_Public_T_0<T>
		{
			// Token: 0x04002B06 RID: 11014
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInChildren_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008B4 RID: 2228
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04002B07 RID: 11015
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008B5 RID: 2229
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04002B08 RID: 11016
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008B6 RID: 2230
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002B09 RID: 11017
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008B7 RID: 2231
		private sealed class MethodInfoStoreGeneric_GetComponentsInChildren_Public_Void_List_1_T_0<T>
		{
			// Token: 0x04002B0A RID: 11018
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInChildren_Public_Void_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008B8 RID: 2232
		private sealed class MethodInfoStoreGeneric_GetComponentInParent_Public_T_0<T>
		{
			// Token: 0x04002B0B RID: 11019
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentInParent_Public_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008B9 RID: 2233
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04002B0C RID: 11020
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008BA RID: 2234
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Void_Boolean_List_1_T_0<T>
		{
			// Token: 0x04002B0D RID: 11021
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Void_Boolean_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008BB RID: 2235
		private sealed class MethodInfoStoreGeneric_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002B0E RID: 11022
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponentsInParent_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008BC RID: 2236
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Void_List_1_T_0<T>
		{
			// Token: 0x04002B0F RID: 11023
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponents_Public_Void_List_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008BD RID: 2237
		private sealed class MethodInfoStoreGeneric_GetComponents_Public_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002B10 RID: 11024
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Component.NativeMethodInfoPtr_GetComponents_Public_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Component>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008BE RID: 2238
		// (Invoke) Token: 0x060039F2 RID: 14834
		private delegate IntPtr GetComponentDelegate(IntPtr @this, IntPtr type);

		// Token: 0x020008BF RID: 2239
		// (Invoke) Token: 0x060039F4 RID: 14836
		private delegate int GetComponentIndexDelegate(IntPtr @this);

		// Token: 0x020008C0 RID: 2240
		// (Invoke) Token: 0x060039F6 RID: 14838
		private delegate void SendMessageUpwardsDelegate(IntPtr @this, IntPtr methodName, IntPtr value, SendMessageOptions options);
	}
}

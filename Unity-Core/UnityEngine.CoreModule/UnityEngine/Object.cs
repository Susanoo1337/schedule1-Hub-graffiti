using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x02000152 RID: 338
	public class Object : Object
	{
		// Token: 0x06001945 RID: 6469 RVA: 0x0006BCE4 File Offset: 0x00069EE4
		// Note: this type is marked as 'beforefieldinit'.
		static Object()
		{
			Il2CppClassPointerStore<Object>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Object");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Object>.NativeClassPtr);
			Object.NativeFieldInfoPtr_m_CachedPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "m_CachedPtr");
			Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "OffsetOfInstanceIDInCPlusPlusObject");
			Object.NativeFieldInfoPtr_objectIsNullMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "objectIsNullMessage");
			Object.NativeFieldInfoPtr_cloneDestroyedMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Object>.NativeClassPtr, "cloneDestroyedMessage");
			Object.NativeMethodInfoPtr_GetInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665991);
			Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665992);
			Object.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665993);
			Object.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665994);
			Object.NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665995);
			Object.NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665996);
			Object.NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665997);
			Object.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665998);
			Object.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100665999);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666000);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666001);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666002);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666003);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666004);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666005);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666006);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666007);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666008);
			Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666009);
			Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666010);
			Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666011);
			Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666012);
			Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666013);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666014);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666015);
			Object.NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666016);
			Object.NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666017);
			Object.NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666018);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666019);
			Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666020);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666021);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666022);
			Object.NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666023);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666024);
			Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666025);
			Object.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666026);
			Object.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666027);
			Object.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666028);
			Object.NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666029);
			Object.NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666030);
			Object.NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666031);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Private_Static_Object_Object_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666032);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Private_Static_Object_Object_Transform_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666033);
			Object.NativeMethodInfoPtr_ToString_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666034);
			Object.NativeMethodInfoPtr_GetName_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666035);
			Object.NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666036);
			Object.NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666037);
			Object.NativeMethodInfoPtr_ForceLoadFromInstanceID_Internal_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666038);
			Object.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666039);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666041);
			Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Injected_Private_Static_Object_Object_Transform_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Object>.NativeClassPtr, 100666042);
			Object.FindObjectsByTypeDelegateField = IL2CPP.ResolveICall<Object.FindObjectsByTypeDelegate>("UnityEngine.Object::FindObjectsByType");
			Object.FindObjectsOfTypeIncludingAssetsDelegateField = IL2CPP.ResolveICall<Object.FindObjectsOfTypeIncludingAssetsDelegate>("UnityEngine.Object::FindObjectsOfTypeIncludingAssets");
			Object.CurrentThreadIsMainThreadDelegateField = IL2CPP.ResolveICall<Object.CurrentThreadIsMainThreadDelegate>("UnityEngine.Object::CurrentThreadIsMainThread");
			Object.IsPersistentDelegateField = IL2CPP.ResolveICall<Object.IsPersistentDelegate>("UnityEngine.Object::IsPersistent");
			Object.DoesObjectWithInstanceIDExistDelegateField = IL2CPP.ResolveICall<Object.DoesObjectWithInstanceIDExistDelegate>("UnityEngine.Object::DoesObjectWithInstanceIDExist");
			Object.MarkDirtyDelegateField = IL2CPP.ResolveICall<Object.MarkDirtyDelegate>("UnityEngine.Object::MarkDirty");
			Object.Internal_CloneSingleWithScene_InjectedDelegateField = IL2CPP.ResolveICall<Object.Internal_CloneSingleWithScene_InjectedDelegate>("UnityEngine.Object::Internal_CloneSingleWithScene_Injected");
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0006C1CC File Offset: 0x0006A3CC
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 1261024, RefRangeEnd = 1261251, XrefRangeStart = 1261009, XrefRangeEnd = 1261024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInstanceID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0006C208 File Offset: 0x0006A408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261251, XrefRangeEnd = 1261252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0006C250 File Offset: 0x0006A450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261252, XrefRangeEnd = 1261265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0006C2A8 File Offset: 0x0006A4A8
		[CallerCount(582)]
		[CachedScanResults(RefRangeStart = 1261272, RefRangeEnd = 1261854, XrefRangeStart = 1261265, XrefRangeEnd = 1261272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator bool(Object exists)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exists);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0006C2EC File Offset: 0x0006A4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261854, XrefRangeEnd = 1261855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareBaseObjects(Object lhs, Object rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lhs);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rhs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0006C340 File Offset: 0x0006A540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261855, XrefRangeEnd = 1261857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNativeObjectAlive(Object o)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0006C384 File Offset: 0x0006A584
		[CallerCount(179)]
		[CachedScanResults(RefRangeStart = 666825, RefRangeEnd = 667004, XrefRangeStart = 666825, XrefRangeEnd = 667004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetCachedPtr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x0006C3C0 File Offset: 0x0006A5C0
		// (set) Token: 0x0600194E RID: 6478 RVA: 0x0006C3F8 File Offset: 0x0006A5F8
		public unsafe string name
		{
			[CallerCount(608)]
			[CachedScanResults(RefRangeStart = 1261862, RefRangeEnd = 1262470, XrefRangeStart = 1261857, XrefRangeEnd = 1261862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(142)]
			[CachedScanResults(RefRangeStart = 1262475, RefRangeEnd = 1262617, XrefRangeStart = 1262470, XrefRangeEnd = 1262475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x0006C43C File Offset: 0x0006A63C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262637, RefRangeEnd = 1262639, XrefRangeStart = 1262617, XrefRangeEnd = 1262637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x0006C49C File Offset: 0x0006A69C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1262668, RefRangeEnd = 1262669, XrefRangeStart = 1262639, XrefRangeEnd = 1262668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x0006C510 File Offset: 0x0006A710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1262682, RefRangeEnd = 1262683, XrefRangeStart = 1262669, XrefRangeEnd = 1262682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x0006C554 File Offset: 0x0006A754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1262687, RefRangeEnd = 1262689, XrefRangeStart = 1262683, XrefRangeEnd = 1262687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Transform parent)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x0006C5AC File Offset: 0x0006A7AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1262727, RefRangeEnd = 1262730, XrefRangeStart = 1262689, XrefRangeEnd = 1262727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantiateInWorldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0006C610 File Offset: 0x0006A810
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 1262742, RefRangeEnd = 1262801, XrefRangeStart = 1262730, XrefRangeEnd = 1262742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original) where T : Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = original;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref original;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0006C69C File Offset: 0x0006A89C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1262807, RefRangeEnd = 1262821, XrefRangeStart = 1262801, XrefRangeEnd = 1262807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = original;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref original;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x0006C744 File Offset: 0x0006A944
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1262827, RefRangeEnd = 1262832, XrefRangeStart = 1262821, XrefRangeEnd = 1262827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Vector3 position, Quaternion rotation, Transform parent) where T : Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = original;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref original;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x0006C7FC File Offset: 0x0006A9FC
		[CallerCount(152)]
		[CachedScanResults(RefRangeStart = 1262842, RefRangeEnd = 1262994, XrefRangeStart = 1262832, XrefRangeEnd = 1262842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Transform parent) where T : Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = original;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref original;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0006C898 File Offset: 0x0006AA98
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1263000, RefRangeEnd = 1263007, XrefRangeStart = 1262994, XrefRangeEnd = 1263000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) where T : Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = original;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref original;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0006C944 File Offset: 0x0006AB44
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1263009, RefRangeEnd = 1263027, XrefRangeStart = 1263007, XrefRangeEnd = 1263009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj, float t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0006C988 File Offset: 0x0006AB88
		[CallerCount(185)]
		[CachedScanResults(RefRangeStart = 1263032, RefRangeEnd = 1263217, XrefRangeStart = 1263027, XrefRangeEnd = 1263032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Destroy(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x0006C9C0 File Offset: 0x0006ABC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1263219, RefRangeEnd = 1263221, XrefRangeStart = 1263217, XrefRangeEnd = 1263219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImmediate(Object obj, bool allowDestroyingAssets)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowDestroyingAssets;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x0006CA04 File Offset: 0x0006AC04
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 1263226, RefRangeEnd = 1263324, XrefRangeStart = 1263221, XrefRangeEnd = 1263226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyImmediate(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x0006CA3C File Offset: 0x0006AC3C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1263329, RefRangeEnd = 1263337, XrefRangeStart = 1263324, XrefRangeEnd = 1263329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfType(Type type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x0006CA80 File Offset: 0x0006AC80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1263339, RefRangeEnd = 1263343, XrefRangeStart = 1263337, XrefRangeEnd = 1263339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfType(Type type, bool includeInactive)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x0006CAD4 File Offset: 0x0006ACD4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1263345, RefRangeEnd = 1263359, XrefRangeStart = 1263343, XrefRangeEnd = 1263345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DontDestroyOnLoad(Object target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x0006CB0C File Offset: 0x0006AD0C
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x0006CB48 File Offset: 0x0006AD48
		public unsafe HideFlags hideFlags
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 1263361, RefRangeEnd = 1263385, XrefRangeStart = 1263359, XrefRangeEnd = 1263361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(108)]
			[CachedScanResults(RefRangeStart = 1263387, RefRangeEnd = 1263495, XrefRangeStart = 1263385, XrefRangeEnd = 1263387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x0006CB88 File Offset: 0x0006AD88
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1263505, RefRangeEnd = 1263519, XrefRangeStart = 1263495, XrefRangeEnd = 1263505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FindObjectsOfType<T>() where T : Object
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0006CBB4 File Offset: 0x0006ADB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1263529, RefRangeEnd = 1263532, XrefRangeStart = 1263519, XrefRangeEnd = 1263529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> FindObjectsOfType<T>(bool includeInactive) where T : Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x0006CBEC File Offset: 0x0006ADEC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1263542, RefRangeEnd = 1263552, XrefRangeStart = 1263532, XrefRangeEnd = 1263542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindObjectOfType<T>() where T : Object
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x0006CC1C File Offset: 0x0006AE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1263552, XrefRangeEnd = 1263562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindObjectOfType<T>(bool includeInactive) where T : Object
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0006CC58 File Offset: 0x0006AE58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1263567, RefRangeEnd = 1263568, XrefRangeStart = 1263562, XrefRangeEnd = 1263567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckNullArgument(Object arg, string message)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x0006CCA0 File Offset: 0x0006AEA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1263573, RefRangeEnd = 1263574, XrefRangeStart = 1263568, XrefRangeEnd = 1263573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectOfType(Type type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x0006CCE4 File Offset: 0x0006AEE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1263579, RefRangeEnd = 1263582, XrefRangeStart = 1263574, XrefRangeEnd = 1263579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectOfType(Type type, bool includeInactive)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x0006CD38 File Offset: 0x0006AF38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1263587, RefRangeEnd = 1263589, XrefRangeStart = 1263582, XrefRangeEnd = 1263587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Object.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x0006CD7C File Offset: 0x0006AF7C
		[CallerCount(3727)]
		[CachedScanResults(RefRangeStart = 1263595, RefRangeEnd = 1267322, XrefRangeStart = 1263589, XrefRangeEnd = 1263595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Object x, Object y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0006CDD0 File Offset: 0x0006AFD0
		[CallerCount(3914)]
		[CachedScanResults(RefRangeStart = 1267328, RefRangeEnd = 1271242, XrefRangeStart = 1267322, XrefRangeEnd = 1267328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Object x, Object y)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0006CE24 File Offset: 0x0006B024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271242, XrefRangeEnd = 1271244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetOffsetOfInstanceIDInCPlusPlusObject()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0006CE54 File Offset: 0x0006B054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1271246, RefRangeEnd = 1271247, XrefRangeStart = 1271244, XrefRangeEnd = 1271246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingle(Object data)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x0006CE98 File Offset: 0x0006B098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271247, XrefRangeEnd = 1271249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x0006CEFC File Offset: 0x0006B0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271249, XrefRangeEnd = 1271254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Private_Static_Object_Object_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0006CF5C File Offset: 0x0006B15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271254, XrefRangeEnd = 1271259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingleWithParent(Object data, Transform parent, Vector3 pos, Quaternion rot)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Private_Static_Object_Object_Transform_Vector3_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x0006CFD0 File Offset: 0x0006B1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271259, XrefRangeEnd = 1271263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToString(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_ToString_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x0006D00C File Offset: 0x0006B20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271263, XrefRangeEnd = 1271265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_GetName_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x0006D048 File Offset: 0x0006B248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271265, XrefRangeEnd = 1271267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetName(Object obj, string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x0006D090 File Offset: 0x0006B290
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1271269, RefRangeEnd = 1271277, XrefRangeStart = 1271267, XrefRangeEnd = 1271269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FindObjectFromInstanceID(int instanceID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref instanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x0006D0D0 File Offset: 0x0006B2D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1271279, RefRangeEnd = 1271282, XrefRangeStart = 1271277, XrefRangeEnd = 1271279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ForceLoadFromInstanceID(int instanceID)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref instanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_ForceLoadFromInstanceID_Internal_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x0006D110 File Offset: 0x0006B310
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Object>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x0006D14C File Offset: 0x0006B34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271282, XrefRangeEnd = 1271284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingle_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x0006D1AC File Offset: 0x0006B3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271284, XrefRangeEnd = 1271286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Internal_InstantiateSingleWithParent_Injected(Object data, Transform parent, ref Vector3 pos, ref Quaternion rot)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Object.NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Injected_Private_Static_Object_Object_Transform_byref_Vector3_byref_Quaternion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x0000C57D File Offset: 0x0000A77D
		public Object(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600197A RID: 6522 RVA: 0x0006D220 File Offset: 0x0006B420
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x0000C586 File Offset: 0x0000A786
		public unsafe IntPtr m_CachedPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object.NativeFieldInfoPtr_m_CachedPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Object.NativeFieldInfoPtr_m_CachedPtr)) = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x0006D248 File Offset: 0x0006B448
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x0000C5A1 File Offset: 0x0000A7A1
		public unsafe static int OffsetOfInstanceIDInCPlusPlusObject
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject, (void*)(&value));
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x0006D264 File Offset: 0x0006B464
		// (set) Token: 0x0600197F RID: 6527 RVA: 0x0000C5AF File Offset: 0x0000A7AF
		public unsafe static string objectIsNullMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_objectIsNullMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_objectIsNullMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x0006D284 File Offset: 0x0006B484
		// (set) Token: 0x06001981 RID: 6529 RVA: 0x0000C5C1 File Offset: 0x0000A7C1
		public unsafe static string cloneDestroyedMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Object.NativeFieldInfoPtr_cloneDestroyedMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Object.NativeFieldInfoPtr_cloneDestroyedMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x0006D2A4 File Offset: 0x0006B4A4
		public void EnsureRunningOnMainThread()
		{
			bool flag = !Object.CurrentThreadIsMainThread();
			if (flag)
			{
				throw new InvalidOperationException("EnsureRunningOnMainThread can only be called from the main thread");
			}
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x0006D2CC File Offset: 0x0006B4CC
		public static Object Instantiate(Object original, UnityEngine.SceneManagement.Scene scene)
		{
			Object.CheckNullArgument(original, "The Object you want to instantiate is null.");
			Object @object = Object.Internal_CloneSingleWithScene(original, scene);
			bool flag = @object == null;
			if (flag)
			{
				throw new UnityException("Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.");
			}
			return @object;
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0006D30C File Offset: 0x0006B50C
		public static Il2CppReferenceArray<Object> FindObjectsByType(Type type, FindObjectsSortMode sortMode)
		{
			return Object.FindObjectsByType(type, FindObjectsInactive.Exclude, sortMode);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x0006D328 File Offset: 0x0006B528
		public static Il2CppReferenceArray<Object> FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode)
		{
			IntPtr intPtr = Object.FindObjectsByTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type), findObjectsInactive, sortMode);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x0000C5D3 File Offset: 0x0000A7D3
		public static void DestroyObject(Object obj, float t)
		{
			Object.Destroy(obj, t);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x0006D358 File Offset: 0x0006B558
		public static void DestroyObject(Object obj)
		{
			float t = 0f;
			Object.Destroy(obj, t);
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x0006D374 File Offset: 0x0006B574
		public static Il2CppReferenceArray<Object> FindSceneObjectsOfType(Type type)
		{
			return Object.FindObjectsOfType(type);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0006D38C File Offset: 0x0006B58C
		public static Il2CppReferenceArray<Object> FindObjectsOfTypeIncludingAssets(Type type)
		{
			IntPtr intPtr = Object.FindObjectsOfTypeIncludingAssetsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(type));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0006D3B8 File Offset: 0x0006B5B8
		public static Il2CppArrayBase<T> FindObjectsByType<T>(FindObjectsSortMode sortMode) where T : Object
		{
			return Resources.ConvertObjects<T>(Object.FindObjectsByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), FindObjectsInactive.Exclude, sortMode));
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0006D3E0 File Offset: 0x0006B5E0
		public static Il2CppArrayBase<T> FindObjectsByType<T>(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) where T : Object
		{
			return Resources.ConvertObjects<T>(Object.FindObjectsByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), findObjectsInactive, sortMode));
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0006D408 File Offset: 0x0006B608
		public static T FindFirstObjectByType<T>() where T : Object
		{
			return Object.FindFirstObjectByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), FindObjectsInactive.Exclude).Cast<T>();
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0006D430 File Offset: 0x0006B630
		public static T FindAnyObjectByType<T>() where T : Object
		{
			return Object.FindAnyObjectByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), FindObjectsInactive.Exclude).Cast<T>();
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0006D458 File Offset: 0x0006B658
		public static T FindFirstObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
		{
			return Object.FindFirstObjectByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), findObjectsInactive).Cast<T>();
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0006D480 File Offset: 0x0006B680
		public static T FindAnyObjectByType<T>(FindObjectsInactive findObjectsInactive) where T : Object
		{
			return Object.FindAnyObjectByType(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), findObjectsInactive).Cast<T>();
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0006D4A8 File Offset: 0x0006B6A8
		public static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type type)
		{
			return Resources.FindObjectsOfTypeAll(type);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0000C5DE File Offset: 0x0000A7DE
		public static Object FindFirstObjectByType(Type type)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0000C5EB File Offset: 0x0000A7EB
		public static Object FindAnyObjectByType(Type type)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0000C5F8 File Offset: 0x0000A7F8
		public static Object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0000C605 File Offset: 0x0000A805
		public static Object FindAnyObjectByType(Type type, FindObjectsInactive findObjectsInactive)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x0000C612 File Offset: 0x0000A812
		public static bool CurrentThreadIsMainThread()
		{
			return Object.CurrentThreadIsMainThreadDelegateField();
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0000C61E File Offset: 0x0000A81E
		public static Object Internal_CloneSingleWithScene(Object data, UnityEngine.SceneManagement.Scene scene)
		{
			return Object.Internal_CloneSingleWithScene_Injected(data, ref scene);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0000C628 File Offset: 0x0000A828
		public static bool IsPersistent(Object obj)
		{
			return Object.IsPersistentDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0000C63A File Offset: 0x0000A83A
		public static bool DoesObjectWithInstanceIDExist(int instanceID)
		{
			return Object.DoesObjectWithInstanceIDExistDelegateField(instanceID);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0000C647 File Offset: 0x0000A847
		public void MarkDirty()
		{
			Object.MarkDirtyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0006D4C0 File Offset: 0x0006B6C0
		public static Object Internal_CloneSingleWithScene_Injected(Object data, ref UnityEngine.SceneManagement.Scene scene)
		{
			IntPtr intPtr = Object.Internal_CloneSingleWithScene_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(data), ref scene);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedPtr;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeFieldInfoPtr_OffsetOfInstanceIDInCPlusPlusObject;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeFieldInfoPtr_objectIsNullMessage;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeFieldInfoPtr_cloneDestroyedMessage;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_GetInstanceID_Public_Int32_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_Object_0;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_CompareBaseObjects_Private_Static_Boolean_Object_Object_0;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeMethodInfoPtr_IsNativeObjectAlive_Private_Static_Boolean_Object_0;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedPtr_Private_IntPtr_0;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_0;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Vector3_Quaternion_Transform_0;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_0;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_0;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Object_Object_Transform_Boolean_0;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_0;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_Transform_0;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_Single_0;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Object_0;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_Boolean_0;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr_DestroyImmediate_Public_Static_Void_Object_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001533 RID: 5427
		private static readonly IntPtr NativeMethodInfoPtr_DontDestroyOnLoad_Public_Static_Void_Object_0;

		// Token: 0x04001534 RID: 5428
		private static readonly IntPtr NativeMethodInfoPtr_get_hideFlags_Public_get_HideFlags_0;

		// Token: 0x04001535 RID: 5429
		private static readonly IntPtr NativeMethodInfoPtr_set_hideFlags_Public_set_Void_HideFlags_0;

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0;

		// Token: 0x04001537 RID: 5431
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_Boolean_0;

		// Token: 0x04001538 RID: 5432
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0;

		// Token: 0x04001539 RID: 5433
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_Boolean_0;

		// Token: 0x0400153A RID: 5434
		private static readonly IntPtr NativeMethodInfoPtr_CheckNullArgument_Private_Static_Void_Object_String_0;

		// Token: 0x0400153B RID: 5435
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_0;

		// Token: 0x0400153C RID: 5436
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectOfType_Public_Static_Object_Type_Boolean_0;

		// Token: 0x0400153D RID: 5437
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400153E RID: 5438
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Object_Object_0;

		// Token: 0x0400153F RID: 5439
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Object_Object_0;

		// Token: 0x04001540 RID: 5440
		private static readonly IntPtr NativeMethodInfoPtr_GetOffsetOfInstanceIDInCPlusPlusObject_Private_Static_Int32_0;

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingle_Private_Static_Object_Object_0;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CloneSingleWithParent_Private_Static_Object_Object_Transform_Boolean_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingle_Private_Static_Object_Object_Vector3_Quaternion_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Private_Static_Object_Object_Transform_Vector3_Quaternion_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Private_Static_String_Object_0;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Private_Static_String_Object_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Private_Static_Void_Object_String_0;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectFromInstanceID_Internal_Static_Object_Int32_0;

		// Token: 0x04001549 RID: 5449
		private static readonly IntPtr NativeMethodInfoPtr_ForceLoadFromInstanceID_Internal_Static_Object_Int32_0;

		// Token: 0x0400154A RID: 5450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400154B RID: 5451
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingle_Injected_Private_Static_Object_Object_byref_Vector3_byref_Quaternion_0;

		// Token: 0x0400154C RID: 5452
		private static readonly IntPtr NativeMethodInfoPtr_Internal_InstantiateSingleWithParent_Injected_Private_Static_Object_Object_Transform_byref_Vector3_byref_Quaternion_0;

		// Token: 0x0400154D RID: 5453
		private static readonly Object.FindObjectsByTypeDelegate FindObjectsByTypeDelegateField;

		// Token: 0x0400154E RID: 5454
		private static readonly Object.FindObjectsOfTypeIncludingAssetsDelegate FindObjectsOfTypeIncludingAssetsDelegateField;

		// Token: 0x0400154F RID: 5455
		private static readonly Object.CurrentThreadIsMainThreadDelegate CurrentThreadIsMainThreadDelegateField;

		// Token: 0x04001550 RID: 5456
		private static readonly Object.IsPersistentDelegate IsPersistentDelegateField;

		// Token: 0x04001551 RID: 5457
		private static readonly Object.DoesObjectWithInstanceIDExistDelegate DoesObjectWithInstanceIDExistDelegateField;

		// Token: 0x04001552 RID: 5458
		private static readonly Object.MarkDirtyDelegate MarkDirtyDelegateField;

		// Token: 0x04001553 RID: 5459
		private static readonly Object.Internal_CloneSingleWithScene_InjectedDelegate Internal_CloneSingleWithScene_InjectedDelegateField;

		// Token: 0x020008F2 RID: 2290
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_0<T>
		{
			// Token: 0x04002B45 RID: 11077
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008F3 RID: 2291
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_0<T>
		{
			// Token: 0x04002B46 RID: 11078
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008F4 RID: 2292
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Vector3_Quaternion_Transform_0<T>
		{
			// Token: 0x04002B47 RID: 11079
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Vector3_Quaternion_Transform_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008F5 RID: 2293
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_0<T>
		{
			// Token: 0x04002B48 RID: 11080
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008F6 RID: 2294
		private sealed class MethodInfoStoreGeneric_Instantiate_Public_Static_T_T_Transform_Boolean_0<T>
		{
			// Token: 0x04002B49 RID: 11081
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_Instantiate_Public_Static_T_T_Transform_Boolean_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008F7 RID: 2295
		private sealed class MethodInfoStoreGeneric_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04002B4A RID: 11082
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008F8 RID: 2296
		private sealed class MethodInfoStoreGeneric_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_Boolean_0<T>
		{
			// Token: 0x04002B4B RID: 11083
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectsOfType_Public_Static_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008F9 RID: 2297
		private sealed class MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_0<T>
		{
			// Token: 0x04002B4C RID: 11084
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008FA RID: 2298
		private sealed class MethodInfoStoreGeneric_FindObjectOfType_Public_Static_T_Boolean_0<T>
		{
			// Token: 0x04002B4D RID: 11085
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Object.NativeMethodInfoPtr_FindObjectOfType_Public_Static_T_Boolean_0, Il2CppClassPointerStore<Object>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008FB RID: 2299
		// (Invoke) Token: 0x06003A6A RID: 14954
		private delegate IntPtr FindObjectsByTypeDelegate(IntPtr type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode);

		// Token: 0x020008FC RID: 2300
		// (Invoke) Token: 0x06003A6C RID: 14956
		private delegate IntPtr FindObjectsOfTypeIncludingAssetsDelegate(IntPtr type);

		// Token: 0x020008FD RID: 2301
		// (Invoke) Token: 0x06003A6E RID: 14958
		private delegate bool CurrentThreadIsMainThreadDelegate();

		// Token: 0x020008FE RID: 2302
		// (Invoke) Token: 0x06003A70 RID: 14960
		private delegate bool IsPersistentDelegate(IntPtr obj);

		// Token: 0x020008FF RID: 2303
		// (Invoke) Token: 0x06003A72 RID: 14962
		private delegate bool DoesObjectWithInstanceIDExistDelegate(int instanceID);

		// Token: 0x02000900 RID: 2304
		// (Invoke) Token: 0x06003A74 RID: 14964
		private delegate void MarkDirtyDelegate(IntPtr @this);

		// Token: 0x02000901 RID: 2305
		// (Invoke) Token: 0x06003A76 RID: 14966
		private delegate IntPtr Internal_CloneSingleWithScene_InjectedDelegate(IntPtr data, IntPtr scene);
	}
}

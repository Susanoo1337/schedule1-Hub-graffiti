using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine
{
	// Token: 0x0200016F RID: 367
	public class Transform : Component
	{
		// Token: 0x06001BF0 RID: 7152 RVA: 0x000745C4 File Offset: 0x000727C4
		// Note: this type is marked as 'beforefieldinit'.
		static Transform()
		{
			Il2CppClassPointerStore<Transform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Transform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transform>.NativeClassPtr);
			Transform.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666296);
			Transform.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666297);
			Transform.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666298);
			Transform.NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666299);
			Transform.NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666300);
			Transform.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666301);
			Transform.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666302);
			Transform.NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666303);
			Transform.NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666304);
			Transform.NativeMethodInfoPtr_get_right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666305);
			Transform.NativeMethodInfoPtr_get_up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666306);
			Transform.NativeMethodInfoPtr_set_up_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666307);
			Transform.NativeMethodInfoPtr_get_forward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666308);
			Transform.NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666309);
			Transform.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666310);
			Transform.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666311);
			Transform.NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666312);
			Transform.NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666313);
			Transform.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666314);
			Transform.NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666315);
			Transform.NativeMethodInfoPtr_get_parent_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666316);
			Transform.NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666317);
			Transform.NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666318);
			Transform.NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666319);
			Transform.NativeMethodInfoPtr_GetParent_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666320);
			Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666321);
			Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666322);
			Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666323);
			Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666324);
			Transform.NativeMethodInfoPtr_SetPositionAndRotation_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666325);
			Transform.NativeMethodInfoPtr_SetLocalPositionAndRotation_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666326);
			Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666327);
			Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666328);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666329);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666330);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666331);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666332);
			Transform.NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666333);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666334);
			Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666335);
			Transform.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666336);
			Transform.NativeMethodInfoPtr_LookAt_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666337);
			Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666338);
			Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666339);
			Transform.NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666340);
			Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666341);
			Transform.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666342);
			Transform.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666343);
			Transform.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666344);
			Transform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666345);
			Transform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666346);
			Transform.NativeMethodInfoPtr_get_root_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666347);
			Transform.NativeMethodInfoPtr_GetRoot_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666348);
			Transform.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666349);
			Transform.NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666350);
			Transform.NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666351);
			Transform.NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666352);
			Transform.NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666353);
			Transform.NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666354);
			Transform.NativeMethodInfoPtr_Find_Public_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666355);
			Transform.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666356);
			Transform.NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666357);
			Transform.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666358);
			Transform.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666359);
			Transform.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666360);
			Transform.NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666361);
			Transform.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666362);
			Transform.NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666363);
			Transform.NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666364);
			Transform.NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666365);
			Transform.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666366);
			Transform.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666367);
			Transform.NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666368);
			Transform.NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666369);
			Transform.NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666370);
			Transform.NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666371);
			Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666372);
			Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666373);
			Transform.NativeMethodInfoPtr_SetPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666374);
			Transform.NativeMethodInfoPtr_SetLocalPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666375);
			Transform.NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666376);
			Transform.NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666377);
			Transform.NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666378);
			Transform.NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666379);
			Transform.NativeMethodInfoPtr_TransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666380);
			Transform.NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666381);
			Transform.NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666382);
			Transform.NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666383);
			Transform.NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666384);
			Transform.GetRotationOrderInternalDelegateField = IL2CPP.ResolveICall<Transform.GetRotationOrderInternalDelegate>("UnityEngine.Transform::GetRotationOrderInternal");
			Transform.SetRotationOrderInternalDelegateField = IL2CPP.ResolveICall<Transform.SetRotationOrderInternalDelegate>("UnityEngine.Transform::SetRotationOrderInternal");
			Transform.GetPositionAndRotationDelegateField = IL2CPP.ResolveICall<Transform.GetPositionAndRotationDelegate>("UnityEngine.Transform::GetPositionAndRotation");
			Transform.GetLocalPositionAndRotationDelegateField = IL2CPP.ResolveICall<Transform.GetLocalPositionAndRotationDelegate>("UnityEngine.Transform::GetLocalPositionAndRotation");
			Transform.TransformDirectionsDelegateField = IL2CPP.ResolveICall<Transform.TransformDirectionsDelegate>("UnityEngine.Transform::TransformDirections");
			Transform.InverseTransformDirectionsDelegateField = IL2CPP.ResolveICall<Transform.InverseTransformDirectionsDelegate>("UnityEngine.Transform::InverseTransformDirections");
			Transform.TransformVectorsDelegateField = IL2CPP.ResolveICall<Transform.TransformVectorsDelegate>("UnityEngine.Transform::TransformVectors");
			Transform.InverseTransformVectorsDelegateField = IL2CPP.ResolveICall<Transform.InverseTransformVectorsDelegate>("UnityEngine.Transform::InverseTransformVectors");
			Transform.TransformPointsDelegateField = IL2CPP.ResolveICall<Transform.TransformPointsDelegate>("UnityEngine.Transform::TransformPoints");
			Transform.InverseTransformPointsDelegateField = IL2CPP.ResolveICall<Transform.InverseTransformPointsDelegate>("UnityEngine.Transform::InverseTransformPoints");
			Transform.DetachChildrenDelegateField = IL2CPP.ResolveICall<Transform.DetachChildrenDelegate>("UnityEngine.Transform::DetachChildren");
			Transform.MoveAfterSiblingDelegateField = IL2CPP.ResolveICall<Transform.MoveAfterSiblingDelegate>("UnityEngine.Transform::MoveAfterSibling");
			Transform.SendTransformChangedScaleDelegateField = IL2CPP.ResolveICall<Transform.SendTransformChangedScaleDelegate>("UnityEngine.Transform::SendTransformChangedScale");
			Transform.GetChildCountDelegateField = IL2CPP.ResolveICall<Transform.GetChildCountDelegate>("UnityEngine.Transform::GetChildCount");
			Transform.internal_getHierarchyCapacityDelegateField = IL2CPP.ResolveICall<Transform.internal_getHierarchyCapacityDelegate>("UnityEngine.Transform::internal_getHierarchyCapacity");
			Transform.internal_setHierarchyCapacityDelegateField = IL2CPP.ResolveICall<Transform.internal_setHierarchyCapacityDelegate>("UnityEngine.Transform::internal_setHierarchyCapacity");
			Transform.internal_getHierarchyCountDelegateField = IL2CPP.ResolveICall<Transform.internal_getHierarchyCountDelegate>("UnityEngine.Transform::internal_getHierarchyCount");
			Transform.IsNonUniformScaleTransformDelegateField = IL2CPP.ResolveICall<Transform.IsNonUniformScaleTransformDelegate>("UnityEngine.Transform::IsNonUniformScaleTransform");
			Transform.SetConstrainProportionsScaleDelegateField = IL2CPP.ResolveICall<Transform.SetConstrainProportionsScaleDelegate>("UnityEngine.Transform::SetConstrainProportionsScale");
			Transform.IsConstrainProportionsScaleDelegateField = IL2CPP.ResolveICall<Transform.IsConstrainProportionsScaleDelegate>("UnityEngine.Transform::IsConstrainProportionsScale");
			Transform.GetLocalEulerAngles_InjectedDelegateField = IL2CPP.ResolveICall<Transform.GetLocalEulerAngles_InjectedDelegate>("UnityEngine.Transform::GetLocalEulerAngles_Injected");
			Transform.SetLocalEulerAngles_InjectedDelegateField = IL2CPP.ResolveICall<Transform.SetLocalEulerAngles_InjectedDelegate>("UnityEngine.Transform::SetLocalEulerAngles_Injected");
			Transform.SetLocalEulerHint_InjectedDelegateField = IL2CPP.ResolveICall<Transform.SetLocalEulerHint_InjectedDelegate>("UnityEngine.Transform::SetLocalEulerHint_Injected");
			Transform.RotateAround_InjectedDelegateField = IL2CPP.ResolveICall<Transform.RotateAround_InjectedDelegate>("UnityEngine.Transform::RotateAround_Injected");
			Transform.RotateAroundLocal_InjectedDelegateField = IL2CPP.ResolveICall<Transform.RotateAroundLocal_InjectedDelegate>("UnityEngine.Transform::RotateAroundLocal_Injected");
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00074E60 File Offset: 0x00073060
		[CallerCount(1012)]
		[CachedScanResults(RefRangeStart = 1247777, RefRangeEnd = 1248789, XrefRangeStart = 1247777, XrefRangeEnd = 1248789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x00074E9C File Offset: 0x0007309C
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x00074ED8 File Offset: 0x000730D8
		public unsafe Vector3 position
		{
			[CallerCount(2558)]
			[CachedScanResults(RefRangeStart = 1274716, RefRangeEnd = 1277274, XrefRangeStart = 1274714, XrefRangeEnd = 1274716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(402)]
			[CachedScanResults(RefRangeStart = 1277276, RefRangeEnd = 1277678, XrefRangeStart = 1277274, XrefRangeEnd = 1277276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00074F18 File Offset: 0x00073118
		// (set) Token: 0x06001BF5 RID: 7157 RVA: 0x00074F54 File Offset: 0x00073154
		public unsafe Vector3 localPosition
		{
			[CallerCount(294)]
			[CachedScanResults(RefRangeStart = 1277680, RefRangeEnd = 1277974, XrefRangeStart = 1277678, XrefRangeEnd = 1277680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(166)]
			[CachedScanResults(RefRangeStart = 1277976, RefRangeEnd = 1278142, XrefRangeStart = 1277974, XrefRangeEnd = 1277976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x00074F94 File Offset: 0x00073194
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x00074FD0 File Offset: 0x000731D0
		public unsafe Vector3 eulerAngles
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1278146, RefRangeEnd = 1278168, XrefRangeStart = 1278142, XrefRangeEnd = 1278146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1278171, RefRangeEnd = 1278184, XrefRangeStart = 1278168, XrefRangeEnd = 1278171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x00075010 File Offset: 0x00073210
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x0007504C File Offset: 0x0007324C
		public unsafe Vector3 localEulerAngles
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 1278188, RefRangeEnd = 1278213, XrefRangeStart = 1278184, XrefRangeEnd = 1278188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 1278216, RefRangeEnd = 1278242, XrefRangeStart = 1278213, XrefRangeEnd = 1278216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x0007508C File Offset: 0x0007328C
		// (set) Token: 0x06001C4E RID: 7246 RVA: 0x0000D371 File Offset: 0x0000B571
		public unsafe Vector3 right
		{
			[CallerCount(67)]
			[CachedScanResults(RefRangeStart = 1278247, RefRangeEnd = 1278314, XrefRangeStart = 1278242, XrefRangeEnd = 1278247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.rotation = Quaternion.FromToRotation(Vector3.right, value);
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x000750C8 File Offset: 0x000732C8
		// (set) Token: 0x06001BFC RID: 7164 RVA: 0x00075104 File Offset: 0x00073304
		public unsafe Vector3 up
		{
			[CallerCount(152)]
			[CachedScanResults(RefRangeStart = 1278319, RefRangeEnd = 1278471, XrefRangeStart = 1278314, XrefRangeEnd = 1278319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1278476, RefRangeEnd = 1278483, XrefRangeStart = 1278471, XrefRangeEnd = 1278476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_up_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x00075144 File Offset: 0x00073344
		// (set) Token: 0x06001BFE RID: 7166 RVA: 0x00075180 File Offset: 0x00073380
		public unsafe Vector3 forward
		{
			[CallerCount(271)]
			[CachedScanResults(RefRangeStart = 1278488, RefRangeEnd = 1278759, XrefRangeStart = 1278483, XrefRangeEnd = 1278488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_forward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 1278762, RefRangeEnd = 1278772, XrefRangeStart = 1278759, XrefRangeEnd = 1278762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x000751C0 File Offset: 0x000733C0
		// (set) Token: 0x06001C00 RID: 7168 RVA: 0x000751FC File Offset: 0x000733FC
		public unsafe Quaternion rotation
		{
			[CallerCount(805)]
			[CachedScanResults(RefRangeStart = 1278774, RefRangeEnd = 1279579, XrefRangeStart = 1278772, XrefRangeEnd = 1278774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(279)]
			[CachedScanResults(RefRangeStart = 1279581, RefRangeEnd = 1279860, XrefRangeStart = 1279579, XrefRangeEnd = 1279581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001C01 RID: 7169 RVA: 0x0007523C File Offset: 0x0007343C
		// (set) Token: 0x06001C02 RID: 7170 RVA: 0x00075278 File Offset: 0x00073478
		public unsafe Quaternion localRotation
		{
			[CallerCount(158)]
			[CachedScanResults(RefRangeStart = 1279862, RefRangeEnd = 1280020, XrefRangeStart = 1279860, XrefRangeEnd = 1279862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(167)]
			[CachedScanResults(RefRangeStart = 1280022, RefRangeEnd = 1280189, XrefRangeStart = 1280020, XrefRangeEnd = 1280022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x000752B8 File Offset: 0x000734B8
		// (set) Token: 0x06001C04 RID: 7172 RVA: 0x000752F4 File Offset: 0x000734F4
		public unsafe Vector3 localScale
		{
			[CallerCount(168)]
			[CachedScanResults(RefRangeStart = 1280191, RefRangeEnd = 1280359, XrefRangeStart = 1280189, XrefRangeEnd = 1280191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(135)]
			[CachedScanResults(RefRangeStart = 1280361, RefRangeEnd = 1280496, XrefRangeStart = 1280359, XrefRangeEnd = 1280361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x00075334 File Offset: 0x00073534
		// (set) Token: 0x06001C06 RID: 7174 RVA: 0x00075374 File Offset: 0x00073574
		public unsafe Transform parent
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 1280498, RefRangeEnd = 1280681, XrefRangeStart = 1280496, XrefRangeEnd = 1280498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_parent_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 1280690, RefRangeEnd = 1280728, XrefRangeStart = 1280681, XrefRangeEnd = 1280690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001C07 RID: 7175 RVA: 0x000753B8 File Offset: 0x000735B8
		// (set) Token: 0x06001C08 RID: 7176 RVA: 0x000753F8 File Offset: 0x000735F8
		public unsafe Transform parentInternal
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 1280498, RefRangeEnd = 1280681, XrefRangeStart = 1280498, XrefRangeEnd = 1280681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 1280730, RefRangeEnd = 1280803, XrefRangeStart = 1280728, XrefRangeEnd = 1280730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0007543C File Offset: 0x0007363C
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 1280498, RefRangeEnd = 1280681, XrefRangeStart = 1280498, XrefRangeEnd = 1280681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetParent_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0007547C File Offset: 0x0007367C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 1280730, RefRangeEnd = 1280803, XrefRangeStart = 1280730, XrefRangeEnd = 1280803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Transform p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x000754C0 File Offset: 0x000736C0
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1280805, RefRangeEnd = 1280838, XrefRangeStart = 1280803, XrefRangeEnd = 1280805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Transform parent, bool worldPositionStays)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x00075510 File Offset: 0x00073710
		public unsafe Matrix4x4 worldToLocalMatrix
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1280840, RefRangeEnd = 1280848, XrefRangeStart = 1280838, XrefRangeEnd = 1280840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x0007554C File Offset: 0x0007374C
		public unsafe Matrix4x4 localToWorldMatrix
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 1280850, RefRangeEnd = 1280873, XrefRangeStart = 1280848, XrefRangeEnd = 1280850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00075588 File Offset: 0x00073788
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1280875, RefRangeEnd = 1280883, XrefRangeStart = 1280873, XrefRangeEnd = 1280875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetPositionAndRotation_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x000755D4 File Offset: 0x000737D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1280885, RefRangeEnd = 1280886, XrefRangeStart = 1280883, XrefRangeEnd = 1280885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref localPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetLocalPositionAndRotation_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00075620 File Offset: 0x00073820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280894, RefRangeEnd = 1280896, XrefRangeStart = 1280886, XrefRangeEnd = 1280894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(Vector3 translation, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref translation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0007566C File Offset: 0x0007386C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1280902, RefRangeEnd = 1280903, XrefRangeStart = 1280896, XrefRangeEnd = 1280902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(Vector3 translation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref translation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x000756AC File Offset: 0x000738AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1280918, RefRangeEnd = 1280922, XrefRangeStart = 1280903, XrefRangeEnd = 1280918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 eulers, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eulers;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x000756F8 File Offset: 0x000738F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280923, RefRangeEnd = 1280925, XrefRangeStart = 1280922, XrefRangeEnd = 1280923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 eulers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref eulers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00075738 File Offset: 0x00073938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1280926, RefRangeEnd = 1280927, XrefRangeStart = 1280925, XrefRangeEnd = 1280926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xAngle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zAngle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000757A0 File Offset: 0x000739A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280928, RefRangeEnd = 1280930, XrefRangeStart = 1280927, XrefRangeEnd = 1280928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(float xAngle, float yAngle, float zAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xAngle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref zAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000757FC File Offset: 0x000739FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280930, XrefRangeEnd = 1280932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAroundInternal(Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref axis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00075848 File Offset: 0x00073A48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1280934, RefRangeEnd = 1280937, XrefRangeStart = 1280932, XrefRangeEnd = 1280934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 axis, float angle, Space relativeTo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref axis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x000758A4 File Offset: 0x00073AA4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1280943, RefRangeEnd = 1280954, XrefRangeStart = 1280937, XrefRangeEnd = 1280943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref axis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x000758F0 File Offset: 0x00073AF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1280962, RefRangeEnd = 1280963, XrefRangeStart = 1280954, XrefRangeEnd = 1280962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0007594C File Offset: 0x00073B4C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1280979, RefRangeEnd = 1280994, XrefRangeStart = 1280963, XrefRangeEnd = 1280979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_LookAt_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00075990 File Offset: 0x00073B90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280996, RefRangeEnd = 1280998, XrefRangeStart = 1280994, XrefRangeEnd = 1280996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000759DC File Offset: 0x00073BDC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1281002, RefRangeEnd = 1281012, XrefRangeStart = 1280998, XrefRangeEnd = 1281002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00075A1C File Offset: 0x00073C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281012, XrefRangeEnd = 1281014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00075A68 File Offset: 0x00073C68
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1281016, RefRangeEnd = 1281040, XrefRangeStart = 1281014, XrefRangeEnd = 1281016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00075AB4 File Offset: 0x00073CB4
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1281042, RefRangeEnd = 1281075, XrefRangeStart = 1281040, XrefRangeEnd = 1281042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x00075B00 File Offset: 0x00073D00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1281077, RefRangeEnd = 1281080, XrefRangeStart = 1281075, XrefRangeEnd = 1281077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00075B4C File Offset: 0x00073D4C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1281082, RefRangeEnd = 1281092, XrefRangeStart = 1281080, XrefRangeEnd = 1281082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x00075B98 File Offset: 0x00073D98
		[CallerCount(151)]
		[CachedScanResults(RefRangeStart = 1281094, RefRangeEnd = 1281245, XrefRangeStart = 1281092, XrefRangeEnd = 1281094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00075BE4 File Offset: 0x00073DE4
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 1281247, RefRangeEnd = 1281373, XrefRangeStart = 1281245, XrefRangeEnd = 1281247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformPoint(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00075C30 File Offset: 0x00073E30
		public unsafe Transform root
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1281375, RefRangeEnd = 1281376, XrefRangeStart = 1281373, XrefRangeEnd = 1281375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_root_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00075C70 File Offset: 0x00073E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281375, RefRangeEnd = 1281376, XrefRangeStart = 1281375, XrefRangeEnd = 1281376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetRoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetRoot_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00075CB0 File Offset: 0x00073EB0
		public unsafe int childCount
		{
			[CallerCount(71)]
			[CachedScanResults(RefRangeStart = 1281378, RefRangeEnd = 1281449, XrefRangeStart = 1281376, XrefRangeEnd = 1281378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_childCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00075CEC File Offset: 0x00073EEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1281451, RefRangeEnd = 1281457, XrefRangeStart = 1281449, XrefRangeEnd = 1281451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAsFirstSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00075D20 File Offset: 0x00073F20
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1281459, RefRangeEnd = 1281477, XrefRangeStart = 1281457, XrefRangeEnd = 1281459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAsLastSibling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00075D54 File Offset: 0x00073F54
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1281479, RefRangeEnd = 1281491, XrefRangeStart = 1281477, XrefRangeEnd = 1281479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSiblingIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x00075D94 File Offset: 0x00073F94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1281493, RefRangeEnd = 1281498, XrefRangeStart = 1281491, XrefRangeEnd = 1281493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSiblingIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00075DD0 File Offset: 0x00073FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281498, XrefRangeEnd = 1281500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActiveOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x00075E34 File Offset: 0x00074034
		[CallerCount(206)]
		[CachedScanResults(RefRangeStart = 1281508, RefRangeEnd = 1281714, XrefRangeStart = 1281500, XrefRangeEnd = 1281508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform Find(string n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Find_Public_Transform_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001C2D RID: 7213 RVA: 0x00075E84 File Offset: 0x00074084
		public unsafe Vector3 lossyScale
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 1281716, RefRangeEnd = 1281761, XrefRangeStart = 1281714, XrefRangeEnd = 1281716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00075EC0 File Offset: 0x000740C0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1281763, RefRangeEnd = 1281780, XrefRangeStart = 1281761, XrefRangeEnd = 1281763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChildOf(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001C2F RID: 7215 RVA: 0x00075F10 File Offset: 0x00074110
		// (set) Token: 0x06001C30 RID: 7216 RVA: 0x00075F4C File Offset: 0x0007414C
		public unsafe bool hasChanged
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1281782, RefRangeEnd = 1281786, XrefRangeStart = 1281780, XrefRangeEnd = 1281782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1281788, RefRangeEnd = 1281789, XrefRangeStart = 1281786, XrefRangeEnd = 1281788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00075F8C File Offset: 0x0007418C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1281794, RefRangeEnd = 1281804, XrefRangeStart = 1281789, XrefRangeEnd = 1281794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00075FCC File Offset: 0x000741CC
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 1281806, RefRangeEnd = 1281883, XrefRangeStart = 1281804, XrefRangeEnd = 1281806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetChild(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00076018 File Offset: 0x00074218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281883, XrefRangeEnd = 1281885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_position_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00076058 File Offset: 0x00074258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281885, XrefRangeEnd = 1281887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_position_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00076098 File Offset: 0x00074298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281887, XrefRangeEnd = 1281889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localPosition_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x000760D8 File Offset: 0x000742D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281889, XrefRangeEnd = 1281891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localPosition_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00076118 File Offset: 0x00074318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281891, XrefRangeEnd = 1281893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rotation_Injected(out Quaternion ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00076158 File Offset: 0x00074358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281893, XrefRangeEnd = 1281895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_rotation_Injected(ref Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00076198 File Offset: 0x00074398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281895, XrefRangeEnd = 1281897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localRotation_Injected(out Quaternion ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x000761D8 File Offset: 0x000743D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281897, XrefRangeEnd = 1281899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localRotation_Injected(ref Quaternion value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00076218 File Offset: 0x00074418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281899, XrefRangeEnd = 1281901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localScale_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00076258 File Offset: 0x00074458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281901, XrefRangeEnd = 1281903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_localScale_Injected(ref Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00076298 File Offset: 0x00074498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281903, XrefRangeEnd = 1281905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_worldToLocalMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x000762D8 File Offset: 0x000744D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281905, XrefRangeEnd = 1281907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_localToWorldMatrix_Injected(out Matrix4x4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00076318 File Offset: 0x00074518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281907, XrefRangeEnd = 1281909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00076364 File Offset: 0x00074564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281909, XrefRangeEnd = 1281911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPositionAndRotation_Injected(ref Vector3 localPosition, ref Quaternion localRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &localPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &localRotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_SetLocalPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x000763B0 File Offset: 0x000745B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281911, XrefRangeEnd = 1281913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAroundInternal_Injected(ref Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &axis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x000763FC File Offset: 0x000745FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281913, XrefRangeEnd = 1281915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &worldPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00076448 File Offset: 0x00074648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281915, XrefRangeEnd = 1281917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &direction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00076494 File Offset: 0x00074694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281917, XrefRangeEnd = 1281919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &direction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x000764E0 File Offset: 0x000746E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281919, XrefRangeEnd = 1281921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformVector_Injected(ref Vector3 vector, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &vector;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0007652C File Offset: 0x0007472C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281921, XrefRangeEnd = 1281923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &vector;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00076578 File Offset: 0x00074778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281923, XrefRangeEnd = 1281925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransformPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x000765C4 File Offset: 0x000747C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281925, XrefRangeEnd = 1281927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00076610 File Offset: 0x00074810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281927, XrefRangeEnd = 1281929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_lossyScale_Injected(out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0000D353 File Offset: 0x0000B553
		public Transform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00076650 File Offset: 0x00074850
		public Vector3 GetLocalEulerAngles(RotationOrder order)
		{
			Vector3 result;
			this.GetLocalEulerAngles_Injected(order, out result);
			return result;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0000D35C File Offset: 0x0000B55C
		public void SetLocalEulerAngles(Vector3 euler, RotationOrder order)
		{
			this.SetLocalEulerAngles_Injected(ref euler, order);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0000D367 File Offset: 0x0000B567
		public void SetLocalEulerHint(Vector3 euler)
		{
			this.SetLocalEulerHint_Injected(ref euler);
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00076668 File Offset: 0x00074868
		// (set) Token: 0x06001C50 RID: 7248 RVA: 0x0000D386 File Offset: 0x0000B586
		public RotationOrder rotationOrder
		{
			get
			{
				return (RotationOrder)this.GetRotationOrderInternal();
			}
			set
			{
				this.SetRotationOrderInternal(value);
			}
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0000D391 File Offset: 0x0000B591
		public int GetRotationOrderInternal()
		{
			return Transform.GetRotationOrderInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0000D3A3 File Offset: 0x0000B5A3
		public void SetRotationOrderInternal(RotationOrder rotationOrder)
		{
			Transform.SetRotationOrderInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), rotationOrder);
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0000D3B6 File Offset: 0x0000B5B6
		public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation)
		{
			Transform.GetPositionAndRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out position, out rotation);
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0000D3CA File Offset: 0x0000B5CA
		public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation)
		{
			Transform.GetLocalPositionAndRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out localPosition, out localRotation);
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0000D3DE File Offset: 0x0000B5DE
		public void Translate(float x, float y, float z, Space relativeTo)
		{
			this.Translate(new Vector3(x, y, z), relativeTo);
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0000D3F2 File Offset: 0x0000B5F2
		public void Translate(float x, float y, float z)
		{
			this.Translate(new Vector3(x, y, z), Space.Self);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00076680 File Offset: 0x00074880
		public void Translate(Vector3 translation, Transform relativeTo)
		{
			bool flag = relativeTo;
			if (flag)
			{
				this.position += relativeTo.TransformDirection(translation);
			}
			else
			{
				this.position += translation;
			}
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0000D405 File Offset: 0x0000B605
		public void Translate(float x, float y, float z, Transform relativeTo)
		{
			this.Translate(new Vector3(x, y, z), relativeTo);
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x000766C8 File Offset: 0x000748C8
		public void LookAt(Transform target, Vector3 worldUp)
		{
			bool flag = target;
			if (flag)
			{
				this.LookAt(target.position, worldUp);
			}
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x000766F0 File Offset: 0x000748F0
		public Vector3 TransformDirection(float x, float y, float z)
		{
			return this.TransformDirection(new Vector3(x, y, z));
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0000D419 File Offset: 0x0000B619
		public unsafe void TransformDirections(Vector3* directions, int count, Vector3* transformedDirections, int transformedCount)
		{
			Transform.TransformDirectionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), directions, count, transformedDirections, transformedCount);
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00076710 File Offset: 0x00074910
		public unsafe void TransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections)
		{
			bool flag = directions.Length != transformedDirections.Length;
			if (flag)
			{
				throw new InvalidOperationException("Both spans passed to Transform.TransformDirections() must be the same length");
			}
			fixed (Vector3* pinnableReference = directions.GetPinnableReference())
			{
				Vector3* directions2 = pinnableReference;
				fixed (Vector3* pinnableReference2 = transformedDirections.GetPinnableReference())
				{
					Vector3* transformedDirections2 = pinnableReference2;
					this.TransformDirections(directions2, directions.Length, transformedDirections2, transformedDirections.Length);
				}
			}
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0000D430 File Offset: 0x0000B630
		public void TransformDirections(Span<Vector3> directions)
		{
			this.TransformDirections(directions, directions);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0007677C File Offset: 0x0007497C
		public Vector3 InverseTransformDirection(float x, float y, float z)
		{
			return this.InverseTransformDirection(new Vector3(x, y, z));
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0000D441 File Offset: 0x0000B641
		public unsafe void InverseTransformDirections(Vector3* directions, int count, Vector3* transformedDirections, int transformedCount)
		{
			Transform.InverseTransformDirectionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), directions, count, transformedDirections, transformedCount);
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x0007679C File Offset: 0x0007499C
		public unsafe void InverseTransformDirections(ReadOnlySpan<Vector3> directions, Span<Vector3> transformedDirections)
		{
			bool flag = directions.Length != transformedDirections.Length;
			if (flag)
			{
				throw new InvalidOperationException("Both spans passed to Transform.InverseTransformDirections() must be the same length");
			}
			fixed (Vector3* pinnableReference = directions.GetPinnableReference())
			{
				Vector3* directions2 = pinnableReference;
				fixed (Vector3* pinnableReference2 = transformedDirections.GetPinnableReference())
				{
					Vector3* transformedDirections2 = pinnableReference2;
					this.InverseTransformDirections(directions2, directions.Length, transformedDirections2, transformedDirections.Length);
				}
			}
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x0000D458 File Offset: 0x0000B658
		public void InverseTransformDirections(Span<Vector3> directions)
		{
			this.InverseTransformDirections(directions, directions);
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x00076808 File Offset: 0x00074A08
		public Vector3 TransformVector(float x, float y, float z)
		{
			return this.TransformVector(new Vector3(x, y, z));
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0000D469 File Offset: 0x0000B669
		public unsafe void TransformVectors(Vector3* vectors, int count, Vector3* transformedVectors, int transformedCount)
		{
			Transform.TransformVectorsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), vectors, count, transformedVectors, transformedCount);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00076828 File Offset: 0x00074A28
		public unsafe void TransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors)
		{
			bool flag = vectors.Length != transformedVectors.Length;
			if (flag)
			{
				throw new InvalidOperationException("Both spans passed to Transform.TransformVectors() must be the same length");
			}
			fixed (Vector3* pinnableReference = vectors.GetPinnableReference())
			{
				Vector3* vectors2 = pinnableReference;
				fixed (Vector3* pinnableReference2 = transformedVectors.GetPinnableReference())
				{
					Vector3* transformedVectors2 = pinnableReference2;
					this.TransformVectors(vectors2, vectors.Length, transformedVectors2, transformedVectors.Length);
				}
			}
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0000D480 File Offset: 0x0000B680
		public void TransformVectors(Span<Vector3> vectors)
		{
			this.TransformVectors(vectors, vectors);
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00076894 File Offset: 0x00074A94
		public Vector3 InverseTransformVector(float x, float y, float z)
		{
			return this.InverseTransformVector(new Vector3(x, y, z));
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0000D491 File Offset: 0x0000B691
		public unsafe void InverseTransformVectors(Vector3* vectors, int count, Vector3* transformedVectors, int transformedCount)
		{
			Transform.InverseTransformVectorsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), vectors, count, transformedVectors, transformedCount);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x000768B4 File Offset: 0x00074AB4
		public unsafe void InverseTransformVectors(ReadOnlySpan<Vector3> vectors, Span<Vector3> transformedVectors)
		{
			bool flag = vectors.Length != transformedVectors.Length;
			if (flag)
			{
				throw new InvalidOperationException("Both spans passed to Transform.InverseTransformVectors() must be the same length");
			}
			fixed (Vector3* pinnableReference = vectors.GetPinnableReference())
			{
				Vector3* vectors2 = pinnableReference;
				fixed (Vector3* pinnableReference2 = transformedVectors.GetPinnableReference())
				{
					Vector3* transformedVectors2 = pinnableReference2;
					this.InverseTransformVectors(vectors2, vectors.Length, transformedVectors2, transformedVectors.Length);
				}
			}
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0000D4A8 File Offset: 0x0000B6A8
		public void InverseTransformVectors(Span<Vector3> vectors)
		{
			this.InverseTransformVectors(vectors, vectors);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00076920 File Offset: 0x00074B20
		public Vector3 TransformPoint(float x, float y, float z)
		{
			return this.TransformPoint(new Vector3(x, y, z));
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0000D4B9 File Offset: 0x0000B6B9
		public unsafe void TransformPoints(Vector3* positions, int count, Vector3* transformedPositions, int transformedCount)
		{
			Transform.TransformPointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, count, transformedPositions, transformedCount);
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00076940 File Offset: 0x00074B40
		public unsafe void TransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions)
		{
			bool flag = positions.Length != transformedPositions.Length;
			if (flag)
			{
				throw new InvalidOperationException("Both spans passed to Transform.TransformPoints() must be the same length");
			}
			fixed (Vector3* pinnableReference = positions.GetPinnableReference())
			{
				Vector3* positions2 = pinnableReference;
				fixed (Vector3* pinnableReference2 = transformedPositions.GetPinnableReference())
				{
					Vector3* transformedPositions2 = pinnableReference2;
					this.TransformPoints(positions2, positions.Length, transformedPositions2, transformedPositions.Length);
				}
			}
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		public void TransformPoints(Span<Vector3> positions)
		{
			this.TransformPoints(positions, positions);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000769AC File Offset: 0x00074BAC
		public Vector3 InverseTransformPoint(float x, float y, float z)
		{
			return this.InverseTransformPoint(new Vector3(x, y, z));
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0000D4E1 File Offset: 0x0000B6E1
		public unsafe void InverseTransformPoints(Vector3* positions, int count, Vector3* transformedPositions, int transformedCount)
		{
			Transform.InverseTransformPointsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), positions, count, transformedPositions, transformedCount);
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x000769CC File Offset: 0x00074BCC
		public unsafe void InverseTransformPoints(ReadOnlySpan<Vector3> positions, Span<Vector3> transformedPositions)
		{
			bool flag = positions.Length != transformedPositions.Length;
			if (flag)
			{
				throw new InvalidOperationException("Both spans passed to Transform.InverseTransformPoints() must be the same length");
			}
			fixed (Vector3* pinnableReference = positions.GetPinnableReference())
			{
				Vector3* positions2 = pinnableReference;
				fixed (Vector3* pinnableReference2 = transformedPositions.GetPinnableReference())
				{
					Vector3* transformedPositions2 = pinnableReference2;
					this.InverseTransformPoints(positions2, positions.Length, transformedPositions2, transformedPositions.Length);
				}
			}
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0000D4F8 File Offset: 0x0000B6F8
		public void InverseTransformPoints(Span<Vector3> positions)
		{
			this.InverseTransformPoints(positions, positions);
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0000D509 File Offset: 0x0000B709
		public void DetachChildren()
		{
			Transform.DetachChildrenDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0000D51B File Offset: 0x0000B71B
		public void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty)
		{
			Transform.MoveAfterSiblingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(transform), notifyEditorAndMarkDirty);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0000D534 File Offset: 0x0000B734
		public void SendTransformChangedScale()
		{
			Transform.SendTransformChangedScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00076A38 File Offset: 0x00074C38
		public Transform FindChild(string n)
		{
			return this.Find(n);
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0000D546 File Offset: 0x0000B746
		public void RotateAround(Vector3 axis, float angle)
		{
			this.RotateAround_Injected(ref axis, angle);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0000D551 File Offset: 0x0000B751
		public void RotateAroundLocal(Vector3 axis, float angle)
		{
			this.RotateAroundLocal_Injected(ref axis, angle);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0000D55C File Offset: 0x0000B75C
		public int GetChildCount()
		{
			return Transform.GetChildCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00076A54 File Offset: 0x00074C54
		// (set) Token: 0x06001C7A RID: 7290 RVA: 0x0000D56E File Offset: 0x0000B76E
		public int hierarchyCapacity
		{
			get
			{
				return this.internal_getHierarchyCapacity();
			}
			set
			{
				this.internal_setHierarchyCapacity(value);
			}
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0000D579 File Offset: 0x0000B779
		public int internal_getHierarchyCapacity()
		{
			return Transform.internal_getHierarchyCapacityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0000D58B File Offset: 0x0000B78B
		public void internal_setHierarchyCapacity(int value)
		{
			Transform.internal_setHierarchyCapacityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x00076A6C File Offset: 0x00074C6C
		public int hierarchyCount
		{
			get
			{
				return this.internal_getHierarchyCount();
			}
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0000D59E File Offset: 0x0000B79E
		public int internal_getHierarchyCount()
		{
			return Transform.internal_getHierarchyCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
		public bool IsNonUniformScaleTransform()
		{
			return Transform.IsNonUniformScaleTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001C80 RID: 7296 RVA: 0x0000D5C2 File Offset: 0x0000B7C2
		// (set) Token: 0x06001C81 RID: 7297 RVA: 0x0000D5CA File Offset: 0x0000B7CA
		public bool constrainProportionsScale
		{
			get
			{
				return this.IsConstrainProportionsScale();
			}
			set
			{
				this.SetConstrainProportionsScale(value);
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0000D5D4 File Offset: 0x0000B7D4
		public void SetConstrainProportionsScale(bool isLinked)
		{
			Transform.SetConstrainProportionsScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), isLinked);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0000D5E7 File Offset: 0x0000B7E7
		public bool IsConstrainProportionsScale()
		{
			return Transform.IsConstrainProportionsScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0000D5F9 File Offset: 0x0000B7F9
		public void GetLocalEulerAngles_Injected(RotationOrder order, out Vector3 ret)
		{
			Transform.GetLocalEulerAngles_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), order, out ret);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0000D60D File Offset: 0x0000B80D
		public void SetLocalEulerAngles_Injected(ref Vector3 euler, RotationOrder order)
		{
			Transform.SetLocalEulerAngles_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref euler, order);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0000D621 File Offset: 0x0000B821
		public void SetLocalEulerHint_Injected(ref Vector3 euler)
		{
			Transform.SetLocalEulerHint_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref euler);
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0000D634 File Offset: 0x0000B834
		public void RotateAround_Injected(ref Vector3 axis, float angle)
		{
			Transform.RotateAround_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref axis, angle);
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0000D648 File Offset: 0x0000B848
		public void RotateAroundLocal_Injected(ref Vector3 axis, float angle)
		{
			Transform.RotateAroundLocal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref axis, angle);
		}

		// Token: 0x04001715 RID: 5909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001716 RID: 5910
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

		// Token: 0x04001717 RID: 5911
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

		// Token: 0x04001718 RID: 5912
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0;

		// Token: 0x04001719 RID: 5913
		private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0;

		// Token: 0x0400171A RID: 5914
		private static readonly IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

		// Token: 0x0400171B RID: 5915
		private static readonly IntPtr NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x0400171C RID: 5916
		private static readonly IntPtr NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0;

		// Token: 0x0400171D RID: 5917
		private static readonly IntPtr NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0;

		// Token: 0x0400171E RID: 5918
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_get_Vector3_0;

		// Token: 0x0400171F RID: 5919
		private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_get_Vector3_0;

		// Token: 0x04001720 RID: 5920
		private static readonly IntPtr NativeMethodInfoPtr_set_up_Public_set_Void_Vector3_0;

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeMethodInfoPtr_get_forward_Public_get_Vector3_0;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0;

		// Token: 0x04001723 RID: 5923
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

		// Token: 0x04001724 RID: 5924
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001725 RID: 5925
		private static readonly IntPtr NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0;

		// Token: 0x04001726 RID: 5926
		private static readonly IntPtr NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0;

		// Token: 0x04001727 RID: 5927
		private static readonly IntPtr NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0;

		// Token: 0x04001728 RID: 5928
		private static readonly IntPtr NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0;

		// Token: 0x04001729 RID: 5929
		private static readonly IntPtr NativeMethodInfoPtr_get_parent_Public_get_Transform_0;

		// Token: 0x0400172A RID: 5930
		private static readonly IntPtr NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0;

		// Token: 0x0400172B RID: 5931
		private static readonly IntPtr NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0;

		// Token: 0x0400172C RID: 5932
		private static readonly IntPtr NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0;

		// Token: 0x0400172D RID: 5933
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Private_Transform_0;

		// Token: 0x0400172E RID: 5934
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Transform_0;

		// Token: 0x0400172F RID: 5935
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0;

		// Token: 0x04001730 RID: 5936
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04001731 RID: 5937
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04001732 RID: 5938
		private static readonly IntPtr NativeMethodInfoPtr_SetPositionAndRotation_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04001733 RID: 5939
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPositionAndRotation_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04001734 RID: 5940
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0;

		// Token: 0x04001735 RID: 5941
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_0;

		// Token: 0x04001736 RID: 5942
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0;

		// Token: 0x04001737 RID: 5943
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0;

		// Token: 0x04001738 RID: 5944
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_Space_0;

		// Token: 0x04001739 RID: 5945
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0;

		// Token: 0x0400173A RID: 5946
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0;

		// Token: 0x0400173B RID: 5947
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0;

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Transform_0;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0;

		// Token: 0x04001740 RID: 5952
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0;

		// Token: 0x04001741 RID: 5953
		private static readonly IntPtr NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0;

		// Token: 0x04001742 RID: 5954
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x04001743 RID: 5955
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x04001744 RID: 5956
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0;

		// Token: 0x04001745 RID: 5957
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0;

		// Token: 0x04001746 RID: 5958
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x04001747 RID: 5959
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x04001748 RID: 5960
		private static readonly IntPtr NativeMethodInfoPtr_get_root_Public_get_Transform_0;

		// Token: 0x04001749 RID: 5961
		private static readonly IntPtr NativeMethodInfoPtr_GetRoot_Private_Transform_0;

		// Token: 0x0400174A RID: 5962
		private static readonly IntPtr NativeMethodInfoPtr_get_childCount_Public_get_Int32_0;

		// Token: 0x0400174B RID: 5963
		private static readonly IntPtr NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0;

		// Token: 0x0400174C RID: 5964
		private static readonly IntPtr NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0;

		// Token: 0x0400174D RID: 5965
		private static readonly IntPtr NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0;

		// Token: 0x0400174E RID: 5966
		private static readonly IntPtr NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0;

		// Token: 0x0400174F RID: 5967
		private static readonly IntPtr NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Static_Transform_Transform_String_Boolean_0;

		// Token: 0x04001750 RID: 5968
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Transform_String_0;

		// Token: 0x04001751 RID: 5969
		private static readonly IntPtr NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0;

		// Token: 0x04001752 RID: 5970
		private static readonly IntPtr NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0;

		// Token: 0x04001753 RID: 5971
		private static readonly IntPtr NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0;

		// Token: 0x04001754 RID: 5972
		private static readonly IntPtr NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0;

		// Token: 0x04001755 RID: 5973
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001756 RID: 5974
		private static readonly IntPtr NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0;

		// Token: 0x04001757 RID: 5975
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001758 RID: 5976
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeMethodInfoPtr_get_localPosition_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeMethodInfoPtr_set_localPosition_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeMethodInfoPtr_get_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeMethodInfoPtr_set_rotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeMethodInfoPtr_get_localRotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeMethodInfoPtr_set_localRotation_Injected_Private_Void_byref_Quaternion_0;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeMethodInfoPtr_get_localScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeMethodInfoPtr_set_localScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Void_byref_Matrix4x4_0;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr_SetPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPositionAndRotation_Injected_Private_Void_byref_Vector3_byref_Quaternion_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Void_byref_Vector3_Single_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Void_byref_Vector3_byref_Vector3_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_get_lossyScale_Injected_Private_Void_byref_Vector3_0;

		// Token: 0x0400176E RID: 5998
		private static readonly Transform.GetRotationOrderInternalDelegate GetRotationOrderInternalDelegateField;

		// Token: 0x0400176F RID: 5999
		private static readonly Transform.SetRotationOrderInternalDelegate SetRotationOrderInternalDelegateField;

		// Token: 0x04001770 RID: 6000
		private static readonly Transform.GetPositionAndRotationDelegate GetPositionAndRotationDelegateField;

		// Token: 0x04001771 RID: 6001
		private static readonly Transform.GetLocalPositionAndRotationDelegate GetLocalPositionAndRotationDelegateField;

		// Token: 0x04001772 RID: 6002
		private static readonly Transform.TransformDirectionsDelegate TransformDirectionsDelegateField;

		// Token: 0x04001773 RID: 6003
		private static readonly Transform.InverseTransformDirectionsDelegate InverseTransformDirectionsDelegateField;

		// Token: 0x04001774 RID: 6004
		private static readonly Transform.TransformVectorsDelegate TransformVectorsDelegateField;

		// Token: 0x04001775 RID: 6005
		private static readonly Transform.InverseTransformVectorsDelegate InverseTransformVectorsDelegateField;

		// Token: 0x04001776 RID: 6006
		private static readonly Transform.TransformPointsDelegate TransformPointsDelegateField;

		// Token: 0x04001777 RID: 6007
		private static readonly Transform.InverseTransformPointsDelegate InverseTransformPointsDelegateField;

		// Token: 0x04001778 RID: 6008
		private static readonly Transform.DetachChildrenDelegate DetachChildrenDelegateField;

		// Token: 0x04001779 RID: 6009
		private static readonly Transform.MoveAfterSiblingDelegate MoveAfterSiblingDelegateField;

		// Token: 0x0400177A RID: 6010
		private static readonly Transform.SendTransformChangedScaleDelegate SendTransformChangedScaleDelegateField;

		// Token: 0x0400177B RID: 6011
		private static readonly Transform.GetChildCountDelegate GetChildCountDelegateField;

		// Token: 0x0400177C RID: 6012
		private static readonly Transform.internal_getHierarchyCapacityDelegate internal_getHierarchyCapacityDelegateField;

		// Token: 0x0400177D RID: 6013
		private static readonly Transform.internal_setHierarchyCapacityDelegate internal_setHierarchyCapacityDelegateField;

		// Token: 0x0400177E RID: 6014
		private static readonly Transform.internal_getHierarchyCountDelegate internal_getHierarchyCountDelegateField;

		// Token: 0x0400177F RID: 6015
		private static readonly Transform.IsNonUniformScaleTransformDelegate IsNonUniformScaleTransformDelegateField;

		// Token: 0x04001780 RID: 6016
		private static readonly Transform.SetConstrainProportionsScaleDelegate SetConstrainProportionsScaleDelegateField;

		// Token: 0x04001781 RID: 6017
		private static readonly Transform.IsConstrainProportionsScaleDelegate IsConstrainProportionsScaleDelegateField;

		// Token: 0x04001782 RID: 6018
		private static readonly Transform.GetLocalEulerAngles_InjectedDelegate GetLocalEulerAngles_InjectedDelegateField;

		// Token: 0x04001783 RID: 6019
		private static readonly Transform.SetLocalEulerAngles_InjectedDelegate SetLocalEulerAngles_InjectedDelegateField;

		// Token: 0x04001784 RID: 6020
		private static readonly Transform.SetLocalEulerHint_InjectedDelegate SetLocalEulerHint_InjectedDelegateField;

		// Token: 0x04001785 RID: 6021
		private static readonly Transform.RotateAround_InjectedDelegate RotateAround_InjectedDelegateField;

		// Token: 0x04001786 RID: 6022
		private static readonly Transform.RotateAroundLocal_InjectedDelegate RotateAroundLocal_InjectedDelegateField;

		// Token: 0x0200097D RID: 2429
		public class Enumerator : Object
		{
			// Token: 0x06003B72 RID: 15218 RVA: 0x000B3118 File Offset: 0x000B1318
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Transform>.NativeClassPtr, "Enumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr);
				Transform.Enumerator.NativeFieldInfoPtr_outer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, "outer");
				Transform.Enumerator.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, "currentIndex");
				Transform.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100666385);
				Transform.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100666386);
				Transform.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100666387);
				Transform.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr, 100666388);
			}

			// Token: 0x06003B73 RID: 15219 RVA: 0x000B31BC File Offset: 0x000B13BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 807172, RefRangeEnd = 807173, XrefRangeStart = 807172, XrefRangeEnd = 807173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(Transform outer) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transform.Enumerator>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(outer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A26 RID: 2598
			// (get) Token: 0x06003B74 RID: 15220 RVA: 0x000B3208 File Offset: 0x000B1408
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274709, XrefRangeEnd = 1274712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003B75 RID: 15221 RVA: 0x000B3248 File Offset: 0x000B1448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274712, XrefRangeEnd = 1274714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003B76 RID: 15222 RVA: 0x000B3284 File Offset: 0x000B1484
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Transform.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003B77 RID: 15223 RVA: 0x00016065 File Offset: 0x00014265
			public Enumerator(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17000A24 RID: 2596
			// (get) Token: 0x06003B78 RID: 15224 RVA: 0x000B32B8 File Offset: 0x000B14B8
			// (set) Token: 0x06003B79 RID: 15225 RVA: 0x0001606E File Offset: 0x0001426E
			public unsafe Transform outer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_outer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_outer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A25 RID: 2597
			// (get) Token: 0x06003B7A RID: 15226 RVA: 0x000B32E8 File Offset: 0x000B14E8
			// (set) Token: 0x06003B7B RID: 15227 RVA: 0x0001608D File Offset: 0x0001428D
			public unsafe int currentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_currentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Transform.Enumerator.NativeFieldInfoPtr_currentIndex)) = value;
				}
			}

			// Token: 0x04002B63 RID: 11107
			private static readonly IntPtr NativeFieldInfoPtr_outer;

			// Token: 0x04002B64 RID: 11108
			private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

			// Token: 0x04002B65 RID: 11109
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Transform_0;

			// Token: 0x04002B66 RID: 11110
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04002B67 RID: 11111
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002B68 RID: 11112
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200097E RID: 2430
		// (Invoke) Token: 0x06003B7D RID: 15229
		private delegate int GetRotationOrderInternalDelegate(IntPtr @this);

		// Token: 0x0200097F RID: 2431
		// (Invoke) Token: 0x06003B7F RID: 15231
		private delegate void SetRotationOrderInternalDelegate(IntPtr @this, RotationOrder rotationOrder);

		// Token: 0x02000980 RID: 2432
		// (Invoke) Token: 0x06003B81 RID: 15233
		private delegate void GetPositionAndRotationDelegate(IntPtr @this, [Out] IntPtr position, [Out] IntPtr rotation);

		// Token: 0x02000981 RID: 2433
		// (Invoke) Token: 0x06003B83 RID: 15235
		private delegate void GetLocalPositionAndRotationDelegate(IntPtr @this, [Out] IntPtr localPosition, [Out] IntPtr localRotation);

		// Token: 0x02000982 RID: 2434
		// (Invoke) Token: 0x06003B85 RID: 15237
		private delegate void TransformDirectionsDelegate(IntPtr @this, IntPtr directions, int count, IntPtr transformedDirections, int transformedCount);

		// Token: 0x02000983 RID: 2435
		// (Invoke) Token: 0x06003B87 RID: 15239
		private delegate void InverseTransformDirectionsDelegate(IntPtr @this, IntPtr directions, int count, IntPtr transformedDirections, int transformedCount);

		// Token: 0x02000984 RID: 2436
		// (Invoke) Token: 0x06003B89 RID: 15241
		private delegate void TransformVectorsDelegate(IntPtr @this, IntPtr vectors, int count, IntPtr transformedVectors, int transformedCount);

		// Token: 0x02000985 RID: 2437
		// (Invoke) Token: 0x06003B8B RID: 15243
		private delegate void InverseTransformVectorsDelegate(IntPtr @this, IntPtr vectors, int count, IntPtr transformedVectors, int transformedCount);

		// Token: 0x02000986 RID: 2438
		// (Invoke) Token: 0x06003B8D RID: 15245
		private delegate void TransformPointsDelegate(IntPtr @this, IntPtr positions, int count, IntPtr transformedPositions, int transformedCount);

		// Token: 0x02000987 RID: 2439
		// (Invoke) Token: 0x06003B8F RID: 15247
		private delegate void InverseTransformPointsDelegate(IntPtr @this, IntPtr positions, int count, IntPtr transformedPositions, int transformedCount);

		// Token: 0x02000988 RID: 2440
		// (Invoke) Token: 0x06003B91 RID: 15249
		private delegate void DetachChildrenDelegate(IntPtr @this);

		// Token: 0x02000989 RID: 2441
		// (Invoke) Token: 0x06003B93 RID: 15251
		private delegate void MoveAfterSiblingDelegate(IntPtr @this, IntPtr transform, bool notifyEditorAndMarkDirty);

		// Token: 0x0200098A RID: 2442
		// (Invoke) Token: 0x06003B95 RID: 15253
		private delegate void SendTransformChangedScaleDelegate(IntPtr @this);

		// Token: 0x0200098B RID: 2443
		// (Invoke) Token: 0x06003B97 RID: 15255
		private delegate int GetChildCountDelegate(IntPtr @this);

		// Token: 0x0200098C RID: 2444
		// (Invoke) Token: 0x06003B99 RID: 15257
		private delegate int internal_getHierarchyCapacityDelegate(IntPtr @this);

		// Token: 0x0200098D RID: 2445
		// (Invoke) Token: 0x06003B9B RID: 15259
		private delegate void internal_setHierarchyCapacityDelegate(IntPtr @this, int value);

		// Token: 0x0200098E RID: 2446
		// (Invoke) Token: 0x06003B9D RID: 15261
		private delegate int internal_getHierarchyCountDelegate(IntPtr @this);

		// Token: 0x0200098F RID: 2447
		// (Invoke) Token: 0x06003B9F RID: 15263
		private delegate bool IsNonUniformScaleTransformDelegate(IntPtr @this);

		// Token: 0x02000990 RID: 2448
		// (Invoke) Token: 0x06003BA1 RID: 15265
		private delegate void SetConstrainProportionsScaleDelegate(IntPtr @this, bool isLinked);

		// Token: 0x02000991 RID: 2449
		// (Invoke) Token: 0x06003BA3 RID: 15267
		private delegate bool IsConstrainProportionsScaleDelegate(IntPtr @this);

		// Token: 0x02000992 RID: 2450
		// (Invoke) Token: 0x06003BA5 RID: 15269
		private delegate void GetLocalEulerAngles_InjectedDelegate(IntPtr @this, RotationOrder order, [Out] IntPtr ret);

		// Token: 0x02000993 RID: 2451
		// (Invoke) Token: 0x06003BA7 RID: 15271
		private delegate void SetLocalEulerAngles_InjectedDelegate(IntPtr @this, IntPtr euler, RotationOrder order);

		// Token: 0x02000994 RID: 2452
		// (Invoke) Token: 0x06003BA9 RID: 15273
		private delegate void SetLocalEulerHint_InjectedDelegate(IntPtr @this, IntPtr euler);

		// Token: 0x02000995 RID: 2453
		// (Invoke) Token: 0x06003BAB RID: 15275
		private delegate void RotateAround_InjectedDelegate(IntPtr @this, IntPtr axis, float angle);

		// Token: 0x02000996 RID: 2454
		// (Invoke) Token: 0x06003BAD RID: 15277
		private delegate void RotateAroundLocal_InjectedDelegate(IntPtr @this, IntPtr axis, float angle);
	}
}

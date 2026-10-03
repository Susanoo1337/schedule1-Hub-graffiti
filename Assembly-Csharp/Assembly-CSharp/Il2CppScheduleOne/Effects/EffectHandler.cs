using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Effects
{
	// Token: 0x020006A4 RID: 1700
	public class EffectHandler : MonoBehaviour
	{
		// Token: 0x0600A5CA RID: 42442 RVA: 0x002BFB8C File Offset: 0x002BDD8C
		// Note: this type is marked as 'beforefieldinit'.
		static EffectHandler()
		{
			Il2CppClassPointerStore<EffectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Effects", "EffectHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr);
			EffectHandler.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, "_id");
			EffectHandler.NativeFieldInfoPtr__scaleToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, "_scaleToParent");
			EffectHandler.NativeFieldInfoPtr__positionToParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, "_positionToParent");
			EffectHandler.NativeFieldInfoPtr__activeByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, "_activeByDefault");
			EffectHandler.NativeFieldInfoPtr__delayDeactivateCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, "_delayDeactivateCoroutine");
			EffectHandler.NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685277);
			EffectHandler.NativeMethodInfoPtr_Deactivate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685278);
			EffectHandler.NativeMethodInfoPtr_SetNumericParameter_Public_Abstract_Virtual_New_Void_String_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685279);
			EffectHandler.NativeMethodInfoPtr_SetNumericParameterForAll_Public_Abstract_Virtual_New_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685280);
			EffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Abstract_Virtual_New_Void_String_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685281);
			EffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Abstract_Virtual_New_Void_String_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685282);
			EffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Abstract_Virtual_New_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685283);
			EffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Abstract_Virtual_New_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685284);
			EffectHandler.NativeMethodInfoPtr_SetColorParameterForAll_Public_Abstract_Virtual_New_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685285);
			EffectHandler.NativeMethodInfoPtr_get_Id_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685286);
			EffectHandler.NativeMethodInfoPtr_get_ScaleToParent_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685287);
			EffectHandler.NativeMethodInfoPtr_get_PositionToParent_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685288);
			EffectHandler.NativeMethodInfoPtr_Initialise_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685289);
			EffectHandler.NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685290);
			EffectHandler.NativeMethodInfoPtr_SetSize_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685291);
			EffectHandler.NativeMethodInfoPtr_DelayDeactivate_Public_Void_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685292);
			EffectHandler.NativeMethodInfoPtr_DoDelayDeactivate_Private_IEnumerator_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685293);
			EffectHandler.NativeMethodInfoPtr_AddPrefixToVariableName_Protected_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685294);
			EffectHandler.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, 100685295);
		}

		// Token: 0x0600A5CB RID: 42443 RVA: 0x002BFD9C File Offset: 0x002BDF9C
		[CallerCount(0)]
		public unsafe virtual void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x002BFDD8 File Offset: 0x002BDFD8
		[CallerCount(0)]
		public unsafe virtual void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_Deactivate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5CD RID: 42445 RVA: 0x002BFE14 File Offset: 0x002BE014
		[CallerCount(0)]
		public unsafe virtual void SetNumericParameter(string effectName, string variable, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_SetNumericParameter_Public_Abstract_Virtual_New_Void_String_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5CE RID: 42446 RVA: 0x002BFE84 File Offset: 0x002BE084
		[CallerCount(0)]
		public unsafe virtual void SetNumericParameterForAll(string variable, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_SetNumericParameterForAll_Public_Abstract_Virtual_New_Void_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5CF RID: 42447 RVA: 0x002BFEE0 File Offset: 0x002BE0E0
		[CallerCount(0)]
		public unsafe virtual void SetVectorParameter(string effectName, string variable, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Abstract_Virtual_New_Void_String_String_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D0 RID: 42448 RVA: 0x002BFF50 File Offset: 0x002BE150
		[CallerCount(0)]
		public unsafe virtual void SetVectorParameter(string effectName, string variable, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_SetVectorParameter_Public_Abstract_Virtual_New_Void_String_String_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D1 RID: 42449 RVA: 0x002BFFC0 File Offset: 0x002BE1C0
		[CallerCount(0)]
		public unsafe virtual void SetVectorParameterForAll(string variable, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Abstract_Virtual_New_Void_String_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x002C001C File Offset: 0x002BE21C
		[CallerCount(0)]
		public unsafe virtual void SetVectorParameterForAll(string variable, Vector2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_SetVectorParameterForAll_Public_Abstract_Virtual_New_Void_String_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x002C0078 File Offset: 0x002BE278
		[CallerCount(0)]
		public unsafe virtual void SetColorParameterForAll(string variable, Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_SetColorParameterForAll_Public_Abstract_Virtual_New_Void_String_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170031C9 RID: 12745
		// (get) Token: 0x0600A5D4 RID: 42452 RVA: 0x002C00D4 File Offset: 0x002BE2D4
		public unsafe virtual string Id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_get_Id_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170031CA RID: 12746
		// (get) Token: 0x0600A5D5 RID: 42453 RVA: 0x002C0118 File Offset: 0x002BE318
		public unsafe virtual bool ScaleToParent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_get_ScaleToParent_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170031CB RID: 12747
		// (get) Token: 0x0600A5D6 RID: 42454 RVA: 0x002C0160 File Offset: 0x002BE360
		public unsafe virtual bool PositionToParent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_get_PositionToParent_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x002C01A8 File Offset: 0x002BE3A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289717, RefRangeEnd = 289718, XrefRangeStart = 289717, XrefRangeEnd = 289717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialise()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EffectHandler.NativeMethodInfoPtr_Initialise_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x002C01E4 File Offset: 0x002BE3E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289720, RefRangeEnd = 289723, XrefRangeStart = 289718, XrefRangeEnd = 289720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler.NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x002C0224 File Offset: 0x002BE424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289725, RefRangeEnd = 289726, XrefRangeStart = 289723, XrefRangeEnd = 289725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSize(Vector3 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler.NativeMethodInfoPtr_SetSize_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5DA RID: 42458 RVA: 0x002C0264 File Offset: 0x002BE464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289735, RefRangeEnd = 289737, XrefRangeStart = 289726, XrefRangeEnd = 289735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayDeactivate(float duration, Action onComplete = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler.NativeMethodInfoPtr_DelayDeactivate_Public_Void_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5DB RID: 42459 RVA: 0x002C02B4 File Offset: 0x002BE4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289737, XrefRangeEnd = 289743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoDelayDeactivate(float duration, Action onComplete = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler.NativeMethodInfoPtr_DoDelayDeactivate_Private_IEnumerator_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x002C0314 File Offset: 0x002BE514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289748, RefRangeEnd = 289750, XrefRangeStart = 289743, XrefRangeEnd = 289748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AddPrefixToVariableName(string variable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler.NativeMethodInfoPtr_AddPrefixToVariableName_Protected_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600A5DD RID: 42461 RVA: 0x002C035C File Offset: 0x002BE55C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289751, RefRangeEnd = 289753, XrefRangeStart = 289750, XrefRangeEnd = 289751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EffectHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5DE RID: 42462 RVA: 0x0004BB5C File Offset: 0x00049D5C
		public EffectHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031C4 RID: 12740
		// (get) Token: 0x0600A5DF RID: 42463 RVA: 0x002C0398 File Offset: 0x002BE598
		// (set) Token: 0x0600A5E0 RID: 42464 RVA: 0x0004BB65 File Offset: 0x00049D65
		public unsafe string _id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler.NativeFieldInfoPtr__id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler.NativeFieldInfoPtr__id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170031C5 RID: 12741
		// (get) Token: 0x0600A5E1 RID: 42465 RVA: 0x002C03C0 File Offset: 0x002BE5C0
		// (set) Token: 0x0600A5E2 RID: 42466 RVA: 0x0004BB84 File Offset: 0x00049D84
		public unsafe bool _scaleToParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler.NativeFieldInfoPtr__scaleToParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler.NativeFieldInfoPtr__scaleToParent)) = value;
			}
		}

		// Token: 0x170031C6 RID: 12742
		// (get) Token: 0x0600A5E3 RID: 42467 RVA: 0x002C03E8 File Offset: 0x002BE5E8
		// (set) Token: 0x0600A5E4 RID: 42468 RVA: 0x0004BB9F File Offset: 0x00049D9F
		public unsafe bool _positionToParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler.NativeFieldInfoPtr__positionToParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler.NativeFieldInfoPtr__positionToParent)) = value;
			}
		}

		// Token: 0x170031C7 RID: 12743
		// (get) Token: 0x0600A5E5 RID: 42469 RVA: 0x002C0410 File Offset: 0x002BE610
		// (set) Token: 0x0600A5E6 RID: 42470 RVA: 0x0004BBBA File Offset: 0x00049DBA
		public unsafe bool _activeByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler.NativeFieldInfoPtr__activeByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler.NativeFieldInfoPtr__activeByDefault)) = value;
			}
		}

		// Token: 0x170031C8 RID: 12744
		// (get) Token: 0x0600A5E7 RID: 42471 RVA: 0x002C0438 File Offset: 0x002BE638
		// (set) Token: 0x0600A5E8 RID: 42472 RVA: 0x0004BBD5 File Offset: 0x00049DD5
		public unsafe Coroutine _delayDeactivateCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler.NativeFieldInfoPtr__delayDeactivateCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler.NativeFieldInfoPtr__delayDeactivateCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040072AB RID: 29355
		private static readonly IntPtr NativeFieldInfoPtr__id;

		// Token: 0x040072AC RID: 29356
		private static readonly IntPtr NativeFieldInfoPtr__scaleToParent;

		// Token: 0x040072AD RID: 29357
		private static readonly IntPtr NativeFieldInfoPtr__positionToParent;

		// Token: 0x040072AE RID: 29358
		private static readonly IntPtr NativeFieldInfoPtr__activeByDefault;

		// Token: 0x040072AF RID: 29359
		private static readonly IntPtr NativeFieldInfoPtr__delayDeactivateCoroutine;

		// Token: 0x040072B0 RID: 29360
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040072B1 RID: 29361
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040072B2 RID: 29362
		private static readonly IntPtr NativeMethodInfoPtr_SetNumericParameter_Public_Abstract_Virtual_New_Void_String_String_Single_0;

		// Token: 0x040072B3 RID: 29363
		private static readonly IntPtr NativeMethodInfoPtr_SetNumericParameterForAll_Public_Abstract_Virtual_New_Void_String_Single_0;

		// Token: 0x040072B4 RID: 29364
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameter_Public_Abstract_Virtual_New_Void_String_String_Vector3_0;

		// Token: 0x040072B5 RID: 29365
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameter_Public_Abstract_Virtual_New_Void_String_String_Vector2_0;

		// Token: 0x040072B6 RID: 29366
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameterForAll_Public_Abstract_Virtual_New_Void_String_Vector3_0;

		// Token: 0x040072B7 RID: 29367
		private static readonly IntPtr NativeMethodInfoPtr_SetVectorParameterForAll_Public_Abstract_Virtual_New_Void_String_Vector2_0;

		// Token: 0x040072B8 RID: 29368
		private static readonly IntPtr NativeMethodInfoPtr_SetColorParameterForAll_Public_Abstract_Virtual_New_Void_String_Color_0;

		// Token: 0x040072B9 RID: 29369
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_Virtual_New_get_String_0;

		// Token: 0x040072BA RID: 29370
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleToParent_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040072BB RID: 29371
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionToParent_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040072BC RID: 29372
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Virtual_New_Void_0;

		// Token: 0x040072BD RID: 29373
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0;

		// Token: 0x040072BE RID: 29374
		private static readonly IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Vector3_0;

		// Token: 0x040072BF RID: 29375
		private static readonly IntPtr NativeMethodInfoPtr_DelayDeactivate_Public_Void_Single_Action_0;

		// Token: 0x040072C0 RID: 29376
		private static readonly IntPtr NativeMethodInfoPtr_DoDelayDeactivate_Private_IEnumerator_Single_Action_0;

		// Token: 0x040072C1 RID: 29377
		private static readonly IntPtr NativeMethodInfoPtr_AddPrefixToVariableName_Protected_String_String_0;

		// Token: 0x040072C2 RID: 29378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000C75 RID: 3189
		[ObfuscatedName("ScheduleOne.Effects.EffectHandler+<DoDelayDeactivate>d__24")]
		public sealed class _DoDelayDeactivate_d__24 : Il2CppSystem.Object
		{
			// Token: 0x0600F1E6 RID: 61926 RVA: 0x003A535C File Offset: 0x003A355C
			// Note: this type is marked as 'beforefieldinit'.
			static _DoDelayDeactivate_d__24()
			{
				Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EffectHandler>.NativeClassPtr, "<DoDelayDeactivate>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr);
				EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr, "<>1__state");
				EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr, "<>2__current");
				EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr, "duration");
				EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr, "<>4__this");
				EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr, "onComplete");
				EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr, 100685296);
				EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr, 100685297);
				EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr, 100685298);
				EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr, 100685299);
				EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr, 100685300);
				EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr, 100685301);
			}

			// Token: 0x0600F1E7 RID: 61927 RVA: 0x003A5464 File Offset: 0x003A3664
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoDelayDeactivate_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectHandler._DoDelayDeactivate_d__24>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1E8 RID: 61928 RVA: 0x003A54AC File Offset: 0x003A36AC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1E9 RID: 61929 RVA: 0x003A54E0 File Offset: 0x003A36E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289707, XrefRangeEnd = 289712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004977 RID: 18807
			// (get) Token: 0x0600F1EA RID: 61930 RVA: 0x003A551C File Offset: 0x003A371C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F1EB RID: 61931 RVA: 0x003A555C File Offset: 0x003A375C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289712, XrefRangeEnd = 289717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004978 RID: 18808
			// (get) Token: 0x0600F1EC RID: 61932 RVA: 0x003A5590 File Offset: 0x003A3790
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EffectHandler._DoDelayDeactivate_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F1ED RID: 61933 RVA: 0x000722AC File Offset: 0x000704AC
			public _DoDelayDeactivate_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004972 RID: 18802
			// (get) Token: 0x0600F1EE RID: 61934 RVA: 0x003A55D0 File Offset: 0x003A37D0
			// (set) Token: 0x0600F1EF RID: 61935 RVA: 0x000722B5 File Offset: 0x000704B5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004973 RID: 18803
			// (get) Token: 0x0600F1F0 RID: 61936 RVA: 0x003A55F8 File Offset: 0x003A37F8
			// (set) Token: 0x0600F1F1 RID: 61937 RVA: 0x000722D0 File Offset: 0x000704D0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004974 RID: 18804
			// (get) Token: 0x0600F1F2 RID: 61938 RVA: 0x003A5628 File Offset: 0x003A3828
			// (set) Token: 0x0600F1F3 RID: 61939 RVA: 0x000722EF File Offset: 0x000704EF
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004975 RID: 18805
			// (get) Token: 0x0600F1F4 RID: 61940 RVA: 0x003A5650 File Offset: 0x003A3850
			// (set) Token: 0x0600F1F5 RID: 61941 RVA: 0x0007230A File Offset: 0x0007050A
			public unsafe EffectHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004976 RID: 18806
			// (get) Token: 0x0600F1F6 RID: 61942 RVA: 0x003A5680 File Offset: 0x003A3880
			// (set) Token: 0x0600F1F7 RID: 61943 RVA: 0x00072329 File Offset: 0x00070529
			public unsafe Action onComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr_onComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EffectHandler._DoDelayDeactivate_d__24.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3BA RID: 41914
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A3BB RID: 41915
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A3BC RID: 41916
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A3BD RID: 41917
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A3BE RID: 41918
			private static readonly IntPtr NativeFieldInfoPtr_onComplete;

			// Token: 0x0400A3BF RID: 41919
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A3C0 RID: 41920
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A3C1 RID: 41921
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A3C2 RID: 41922
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A3C3 RID: 41923
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A3C4 RID: 41924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

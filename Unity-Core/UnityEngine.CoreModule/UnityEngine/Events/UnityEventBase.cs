using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020001A1 RID: 417
	[Serializable]
	public class UnityEventBase : Object
	{
		// Token: 0x06001F33 RID: 7987 RVA: 0x0007F624 File Offset: 0x0007D824
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventBase()
		{
			Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEventBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr);
			UnityEventBase.NativeFieldInfoPtr_m_Calls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, "m_Calls");
			UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, "m_PersistentCalls");
			UnityEventBase.NativeFieldInfoPtr_m_CallsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, "m_CallsDirty");
			UnityEventBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666687);
			UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666688);
			UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666689);
			UnityEventBase.NativeMethodInfoPtr_FindMethod_Impl_Protected_MethodInfo_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666690);
			UnityEventBase.NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666691);
			UnityEventBase.NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666692);
			UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666693);
			UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666694);
			UnityEventBase.NativeMethodInfoPtr_GetCallsCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666695);
			UnityEventBase.NativeMethodInfoPtr_GetPersistentEventCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666696);
			UnityEventBase.NativeMethodInfoPtr_GetPersistentTarget_Public_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666697);
			UnityEventBase.NativeMethodInfoPtr_GetPersistentMethodName_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666698);
			UnityEventBase.NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666699);
			UnityEventBase.NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666700);
			UnityEventBase.NativeMethodInfoPtr_SetPersistentListenerState_Public_Void_Int32_UnityEventCallState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666701);
			UnityEventBase.NativeMethodInfoPtr_GetPersistentListenerState_Public_UnityEventCallState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666702);
			UnityEventBase.NativeMethodInfoPtr_AddListener_Protected_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666703);
			UnityEventBase.NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666704);
			UnityEventBase.NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666705);
			UnityEventBase.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666706);
			UnityEventBase.NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666707);
			UnityEventBase.NativeMethodInfoPtr_Invoke_Protected_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666708);
			UnityEventBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666709);
			UnityEventBase.NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Object_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666710);
			UnityEventBase.NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100666711);
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x0007F884 File Offset: 0x0007DA84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1283654, RefRangeEnd = 1283659, XrefRangeStart = 1283619, XrefRangeEnd = 1283654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventBase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x0007F8C0 File Offset: 0x0007DAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283659, XrefRangeEnd = 1283660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x0007F8F4 File Offset: 0x0007DAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x0007F928 File Offset: 0x0007DB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283660, XrefRangeEnd = 1283662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo FindMethod_Impl(string name, Object targetObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_FindMethod_Impl_Protected_MethodInfo_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x0007F98C File Offset: 0x0007DB8C
		[CallerCount(0)]
		public unsafe virtual MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetObjType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEventBase.NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x0007F9FC File Offset: 0x0007DBFC
		[CallerCount(0)]
		public unsafe virtual BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEventBase.NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x0007FA6C File Offset: 0x0007DC6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1283693, RefRangeEnd = 1283694, XrefRangeStart = 1283662, XrefRangeEnd = 1283693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo FindMethod(PersistentCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x0007FABC File Offset: 0x0007DCBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1283745, RefRangeEnd = 1283746, XrefRangeStart = 1283694, XrefRangeEnd = 1283745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listenerType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x0007FB40 File Offset: 0x0007DD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283746, XrefRangeEnd = 1283747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCallsCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetCallsCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x0007FB7C File Offset: 0x0007DD7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1283748, RefRangeEnd = 1283749, XrefRangeStart = 1283747, XrefRangeEnd = 1283748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPersistentEventCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetPersistentEventCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x0007FBB8 File Offset: 0x0007DDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283749, XrefRangeEnd = 1283752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetPersistentTarget(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetPersistentTarget_Public_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x0007FC04 File Offset: 0x0007DE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283752, XrefRangeEnd = 1283756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPersistentMethodName(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetPersistentMethodName_Public_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x0007FC48 File Offset: 0x0007DE48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1283765, RefRangeEnd = 1283768, XrefRangeStart = 1283756, XrefRangeEnd = 1283765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DirtyPersistentCalls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x0007FC7C File Offset: 0x0007DE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283768, XrefRangeEnd = 1283769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildPersistentCallsIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x0007FCB0 File Offset: 0x0007DEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283769, XrefRangeEnd = 1283774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPersistentListenerState(int index, UnityEventCallState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_SetPersistentListenerState_Public_Void_Int32_UnityEventCallState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x0007FCFC File Offset: 0x0007DEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283774, XrefRangeEnd = 1283778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventCallState GetPersistentListenerState(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetPersistentListenerState_Public_UnityEventCallState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x0007FD48 File Offset: 0x0007DF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283778, XrefRangeEnd = 1283780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_AddListener_Protected_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x0007FD9C File Offset: 0x0007DF9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1283782, RefRangeEnd = 1283788, XrefRangeStart = 1283780, XrefRangeEnd = 1283782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCall(BaseInvokableCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x0007FDE0 File Offset: 0x0007DFE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1283790, RefRangeEnd = 1283795, XrefRangeStart = 1283788, XrefRangeEnd = 1283790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveListener(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x0007FE34 File Offset: 0x0007E034
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1283804, RefRangeEnd = 1283814, XrefRangeStart = 1283795, XrefRangeEnd = 1283804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAllListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x0007FE68 File Offset: 0x0007E068
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1283822, RefRangeEnd = 1283828, XrefRangeStart = 1283814, XrefRangeEnd = 1283822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<BaseInvokableCall> PrepareInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr3) : null;
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x0007FEA8 File Offset: 0x0007E0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283828, XrefRangeEnd = 1283834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Il2CppReferenceArray<Object> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_Invoke_Protected_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x0007FEEC File Offset: 0x0007E0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283834, XrefRangeEnd = 1283840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEventBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0007FF30 File Offset: 0x0007E130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283840, XrefRangeEnd = 1283843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetValidMethodInfo(Object obj, string functionName, Il2CppReferenceArray<Type> argumentTypes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(functionName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Object_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0007FF98 File Offset: 0x0007E198
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1283859, RefRangeEnd = 1283885, XrefRangeStart = 1283843, XrefRangeEnd = 1283859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Il2CppReferenceArray<Type> argumentTypes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(functionName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x0000E890 File Offset: 0x0000CA90
		public UnityEventBase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00080000 File Offset: 0x0007E200
		// (set) Token: 0x06001F4F RID: 8015 RVA: 0x0000E899 File Offset: 0x0000CA99
		public unsafe InvokableCallList m_Calls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_Calls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvokableCallList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_Calls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x00080030 File Offset: 0x0007E230
		// (set) Token: 0x06001F51 RID: 8017 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		public unsafe PersistentCallGroup m_PersistentCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PersistentCallGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001F52 RID: 8018 RVA: 0x00080060 File Offset: 0x0007E260
		// (set) Token: 0x06001F53 RID: 8019 RVA: 0x0000E8D7 File Offset: 0x0000CAD7
		public unsafe bool m_CallsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_CallsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_CallsDirty)) = value;
			}
		}

		// Token: 0x04001972 RID: 6514
		private static readonly IntPtr NativeFieldInfoPtr_m_Calls;

		// Token: 0x04001973 RID: 6515
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCalls;

		// Token: 0x04001974 RID: 6516
		private static readonly IntPtr NativeFieldInfoPtr_m_CallsDirty;

		// Token: 0x04001975 RID: 6517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001976 RID: 6518
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001977 RID: 6519
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001978 RID: 6520
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_MethodInfo_String_Object_0;

		// Token: 0x04001979 RID: 6521
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0;

		// Token: 0x0400197A RID: 6522
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0;

		// Token: 0x0400197B RID: 6523
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0;

		// Token: 0x0400197C RID: 6524
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0;

		// Token: 0x0400197D RID: 6525
		private static readonly IntPtr NativeMethodInfoPtr_GetCallsCount_Internal_Int32_0;

		// Token: 0x0400197E RID: 6526
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentEventCount_Public_Int32_0;

		// Token: 0x0400197F RID: 6527
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentTarget_Public_Object_Int32_0;

		// Token: 0x04001980 RID: 6528
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentMethodName_Public_String_Int32_0;

		// Token: 0x04001981 RID: 6529
		private static readonly IntPtr NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0;

		// Token: 0x04001982 RID: 6530
		private static readonly IntPtr NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0;

		// Token: 0x04001983 RID: 6531
		private static readonly IntPtr NativeMethodInfoPtr_SetPersistentListenerState_Public_Void_Int32_UnityEventCallState_0;

		// Token: 0x04001984 RID: 6532
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentListenerState_Public_UnityEventCallState_Int32_0;

		// Token: 0x04001985 RID: 6533
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Protected_Void_Object_MethodInfo_0;

		// Token: 0x04001986 RID: 6534
		private static readonly IntPtr NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0;

		// Token: 0x04001987 RID: 6535
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0;

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Protected_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Object_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x0200019E RID: 414
	[Serializable]
	public class PersistentCall : Object
	{
		// Token: 0x06001EED RID: 7917 RVA: 0x0007E30C File Offset: 0x0007C50C
		// Note: this type is marked as 'beforefieldinit'.
		static PersistentCall()
		{
			Il2CppClassPointerStore<PersistentCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "PersistentCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr);
			PersistentCall.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_Target");
			PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_TargetAssemblyTypeName");
			PersistentCall.NativeFieldInfoPtr_m_MethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_MethodName");
			PersistentCall.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_Mode");
			PersistentCall.NativeFieldInfoPtr_m_Arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_Arguments");
			PersistentCall.NativeFieldInfoPtr_m_CallState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_CallState");
			PersistentCall.NativeMethodInfoPtr_get_target_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666645);
			PersistentCall.NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666646);
			PersistentCall.NativeMethodInfoPtr_get_methodName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666647);
			PersistentCall.NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666648);
			PersistentCall.NativeMethodInfoPtr_set_mode_Public_set_Void_PersistentListenerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666649);
			PersistentCall.NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666650);
			PersistentCall.NativeMethodInfoPtr_get_callState_Public_get_UnityEventCallState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666651);
			PersistentCall.NativeMethodInfoPtr_set_callState_Public_set_Void_UnityEventCallState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666652);
			PersistentCall.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666653);
			PersistentCall.NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666654);
			PersistentCall.NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666655);
			PersistentCall.NativeMethodInfoPtr_RegisterPersistentListener_Public_Void_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666656);
			PersistentCall.NativeMethodInfoPtr_UnregisterPersistentListener_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666657);
			PersistentCall.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666658);
			PersistentCall.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666659);
			PersistentCall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100666660);
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x0007E4F4 File Offset: 0x0007C6F4
		public unsafe Object target
		{
			[CallerCount(179)]
			[CachedScanResults(RefRangeStart = 666825, RefRangeEnd = 667004, XrefRangeStart = 666825, XrefRangeEnd = 667004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_target_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0007E534 File Offset: 0x0007C734
		public unsafe string targetAssemblyTypeName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1283215, RefRangeEnd = 1283218, XrefRangeStart = 1283207, XrefRangeEnd = 1283215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x0007E56C File Offset: 0x0007C76C
		public unsafe string methodName
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 668022, RefRangeEnd = 668056, XrefRangeStart = 668022, XrefRangeEnd = 668056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_methodName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x0007E5A4 File Offset: 0x0007C7A4
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x0007E5E0 File Offset: 0x0007C7E0
		public unsafe PersistentListenerMode mode
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1283218, RefRangeEnd = 1283240, XrefRangeStart = 1283218, XrefRangeEnd = 1283218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29101, RefRangeEnd = 29102, XrefRangeStart = 29101, XrefRangeEnd = 29102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_set_mode_Public_set_Void_PersistentListenerMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0007E620 File Offset: 0x0007C820
		public unsafe ArgumentCache arguments
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentCache>(intPtr3) : null;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x0007E660 File Offset: 0x0007C860
		// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x0007E69C File Offset: 0x0007C89C
		public unsafe UnityEventCallState callState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_callState_Public_get_UnityEventCallState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_set_callState_Public_set_Void_UnityEventCallState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x0007E6DC File Offset: 0x0007C8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283240, XrefRangeEnd = 1283242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0007E718 File Offset: 0x0007C918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1283286, RefRangeEnd = 1283287, XrefRangeStart = 1283242, XrefRangeEnd = 1283286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(theEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0007E768 File Offset: 0x0007C968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1283347, RefRangeEnd = 1283348, XrefRangeStart = 1283287, XrefRangeEnd = 1283347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0007E7D0 File Offset: 0x0007C9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283348, XrefRangeEnd = 1283353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterPersistentListener(Object ttarget, Type targetType, string mmethodName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ttarget);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mmethodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_RegisterPersistentListener_Public_Void_Object_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0007E838 File Offset: 0x0007CA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283353, XrefRangeEnd = 1283359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterPersistentListener()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_UnregisterPersistentListener_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0007E86C File Offset: 0x0007CA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x0007E8A0 File Offset: 0x0007CAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x0007E8D4 File Offset: 0x0007CAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283359, XrefRangeEnd = 1283365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PersistentCall() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x0000E72C File Offset: 0x0000C92C
		public PersistentCall(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x0007E910 File Offset: 0x0007CB10
		// (set) Token: 0x06001F00 RID: 7936 RVA: 0x0000E735 File Offset: 0x0000C935
		public unsafe Object m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x0007E940 File Offset: 0x0007CB40
		// (set) Token: 0x06001F02 RID: 7938 RVA: 0x0000E754 File Offset: 0x0000C954
		public unsafe string m_TargetAssemblyTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x0007E968 File Offset: 0x0007CB68
		// (set) Token: 0x06001F04 RID: 7940 RVA: 0x0000E773 File Offset: 0x0000C973
		public unsafe string m_MethodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_MethodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_MethodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x0007E990 File Offset: 0x0007CB90
		// (set) Token: 0x06001F06 RID: 7942 RVA: 0x0000E792 File Offset: 0x0000C992
		public unsafe PersistentListenerMode m_Mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Mode)) = value;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x0007E9B8 File Offset: 0x0007CBB8
		// (set) Token: 0x06001F08 RID: 7944 RVA: 0x0000E7AD File Offset: 0x0000C9AD
		public unsafe ArgumentCache m_Arguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Arguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArgumentCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Arguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x0007E9E8 File Offset: 0x0007CBE8
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x0000E7CC File Offset: 0x0000C9CC
		public unsafe UnityEventCallState m_CallState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_CallState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_CallState)) = value;
			}
		}

		// Token: 0x0400193D RID: 6461
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x0400193E RID: 6462
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetAssemblyTypeName;

		// Token: 0x0400193F RID: 6463
		private static readonly IntPtr NativeFieldInfoPtr_m_MethodName;

		// Token: 0x04001940 RID: 6464
		private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

		// Token: 0x04001941 RID: 6465
		private static readonly IntPtr NativeFieldInfoPtr_m_Arguments;

		// Token: 0x04001942 RID: 6466
		private static readonly IntPtr NativeFieldInfoPtr_m_CallState;

		// Token: 0x04001943 RID: 6467
		private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_get_Object_0;

		// Token: 0x04001944 RID: 6468
		private static readonly IntPtr NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0;

		// Token: 0x04001945 RID: 6469
		private static readonly IntPtr NativeMethodInfoPtr_get_methodName_Public_get_String_0;

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeMethodInfoPtr_set_mode_Public_set_Void_PersistentListenerMode_0;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr_get_callState_Public_get_UnityEventCallState_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr_set_callState_Public_set_Void_UnityEventCallState_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr_RegisterPersistentListener_Public_Void_Object_Type_String_0;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterPersistentListener_Public_Void_0;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

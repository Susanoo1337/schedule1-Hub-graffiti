using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x0200025F RID: 607
	[StructLayout(2)]
	public struct PlayableOutputHandle
	{
		// Token: 0x06002A72 RID: 10866 RVA: 0x000A55C8 File Offset: 0x000A37C8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableOutputHandle()
		{
			Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableOutputHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr);
			PlayableOutputHandle.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Handle");
			PlayableOutputHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Version");
			PlayableOutputHandle.NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Null");
			PlayableOutputHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667853);
			PlayableOutputHandle.NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667854);
			PlayableOutputHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667855);
			PlayableOutputHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667856);
			PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667857);
			PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667858);
			PlayableOutputHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667859);
			PlayableOutputHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667860);
			PlayableOutputHandle.NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667861);
			PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667862);
			PlayableOutputHandle.NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667863);
			PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667864);
			PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667865);
			PlayableOutputHandle.NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667866);
			PlayableOutputHandle.NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667867);
			PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667868);
			PlayableOutputHandle.NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667869);
			PlayableOutputHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667871);
			PlayableOutputHandle.NativeMethodInfoPtr_GetPlayableOutputType_Injected_Private_Static_Type_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667872);
			PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667873);
			PlayableOutputHandle.NativeMethodInfoPtr_SetUserData_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667874);
			PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667875);
			PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667876);
			PlayableOutputHandle.NativeMethodInfoPtr_GetSourceOutputPort_Injected_Private_Static_Int32_byref_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667877);
			PlayableOutputHandle.NativeMethodInfoPtr_SetWeight_Injected_Private_Static_Void_byref_PlayableOutputHandle_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667878);
			PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667879);
			PlayableOutputHandle.NativeMethodInfoPtr_AddNotificationReceiver_Injected_Private_Static_Void_byref_PlayableOutputHandle_INotificationReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100667880);
			PlayableOutputHandle.IsNull_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.IsNull_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::IsNull_Injected");
			PlayableOutputHandle.GetReferenceObject_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetReferenceObject_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetReferenceObject_Injected");
			PlayableOutputHandle.GetUserData_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetUserData_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetUserData_Injected");
			PlayableOutputHandle.GetWeight_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetWeight_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetWeight_Injected");
			PlayableOutputHandle.GetNotificationReceivers_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetNotificationReceivers_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetNotificationReceivers_Injected");
			PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::RemoveNotificationReceiver_Injected");
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06002A73 RID: 10867 RVA: 0x000A58AC File Offset: 0x000A3AAC
		public unsafe static PlayableOutputHandle Null
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1293672, RefRangeEnd = 1293674, XrefRangeStart = 1293668, XrefRangeEnd = 1293672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x000A58DC File Offset: 0x000A3ADC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1293684, RefRangeEnd = 1293693, XrefRangeStart = 1293674, XrefRangeEnd = 1293684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayableOutputOfType<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.MethodInfoStoreGeneric_IsPlayableOutputOfType_Internal_Boolean_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x000A590C File Offset: 0x000A3B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x000A593C File Offset: 0x000A3B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293693, XrefRangeEnd = 1293698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x000A5988 File Offset: 0x000A3B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293698, XrefRangeEnd = 1293707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x000A59CC File Offset: 0x000A3BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293707, XrefRangeEnd = 1293712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableOutputHandle other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x000A5A0C File Offset: 0x000A3C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lhs;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x000A5A58 File Offset: 0x000A3C58
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1293717, RefRangeEnd = 1293725, XrefRangeStart = 1293712, XrefRangeEnd = 1293717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x000A5A88 File Offset: 0x000A3C88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1293730, RefRangeEnd = 1293732, XrefRangeStart = 1293725, XrefRangeEnd = 1293730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetPlayableOutputType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x000A5ABC File Offset: 0x000A3CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293737, RefRangeEnd = 1293738, XrefRangeStart = 1293732, XrefRangeEnd = 1293737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReferenceObject(Object target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x000A5AF4 File Offset: 0x000A3CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293743, RefRangeEnd = 1293744, XrefRangeStart = 1293738, XrefRangeEnd = 1293743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUserData(Object target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x000A5B2C File Offset: 0x000A3D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293749, RefRangeEnd = 1293750, XrefRangeStart = 1293744, XrefRangeEnd = 1293749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableHandle GetSourcePlayable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x000A5B5C File Offset: 0x000A3D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293755, RefRangeEnd = 1293756, XrefRangeStart = 1293750, XrefRangeEnd = 1293755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSourcePlayable(PlayableHandle target, int port)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref target;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x000A5B9C File Offset: 0x000A3D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293761, RefRangeEnd = 1293762, XrefRangeStart = 1293756, XrefRangeEnd = 1293761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSourceOutputPort()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x000A5BCC File Offset: 0x000A3DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293769, RefRangeEnd = 1293770, XrefRangeStart = 1293762, XrefRangeEnd = 1293769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWeight(float weight)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x000A5C00 File Offset: 0x000A3E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293775, RefRangeEnd = 1293776, XrefRangeStart = 1293770, XrefRangeEnd = 1293775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushNotification(PlayableHandle origin, INotification notification, Object context)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notification);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x000A5C58 File Offset: 0x000A3E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1293781, RefRangeEnd = 1293782, XrefRangeStart = 1293776, XrefRangeEnd = 1293781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNotificationReceiver(INotificationReceiver receiver)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receiver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x000A5C90 File Offset: 0x000A3E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293782, XrefRangeEnd = 1293784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x000A5CD0 File Offset: 0x000A3ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293784, XrefRangeEnd = 1293786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetPlayableOutputType_Injected_Private_Static_Type_byref_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x000A5D10 File Offset: 0x000A3F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293786, XrefRangeEnd = 1293788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, Object target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x000A5D54 File Offset: 0x000A3F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293788, XrefRangeEnd = 1293790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetUserData_Injected(ref PlayableOutputHandle _unity_self, Object target)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetUserData_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x000A5D98 File Offset: 0x000A3F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293790, XrefRangeEnd = 1293792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x000A5DD8 File Offset: 0x000A3FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293792, XrefRangeEnd = 1293794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x000A5E28 File Offset: 0x000A4028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293794, XrefRangeEnd = 1293796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetSourceOutputPort_Injected_Private_Static_Int32_byref_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x000A5E68 File Offset: 0x000A4068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293796, XrefRangeEnd = 1293798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWeight_Injected(ref PlayableOutputHandle _unity_self, float weight)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_SetWeight_Injected_Private_Static_Void_byref_PlayableOutputHandle_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8C RID: 10892 RVA: 0x000A5EA8 File Offset: 0x000A40A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293798, XrefRangeEnd = 1293800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, Object context)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notification);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x000A5F0C File Offset: 0x000A410C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1293800, XrefRangeEnd = 1293802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &_unity_self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(receiver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_AddNotificationReceiver_Injected_Private_Static_Void_byref_PlayableOutputHandle_INotificationReceiver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8E RID: 10894 RVA: 0x00012CDB File Offset: 0x00010EDB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x000A5F50 File Offset: 0x000A4150
		// (set) Token: 0x06002A90 RID: 10896 RVA: 0x00012CED File Offset: 0x00010EED
		public unsafe static PlayableOutputHandle m_Null
		{
			get
			{
				PlayableOutputHandle result;
				IL2CPP.il2cpp_field_static_get_value(PlayableOutputHandle.NativeFieldInfoPtr_m_Null, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableOutputHandle.NativeFieldInfoPtr_m_Null, (void*)(&value));
			}
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x000A5F6C File Offset: 0x000A416C
		public static bool operator !=(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			return !PlayableOutputHandle.CompareVersion(lhs, rhs);
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x00012CFB File Offset: 0x00010EFB
		public bool IsNull()
		{
			return PlayableOutputHandle.IsNull_Injected(ref this);
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x00012D03 File Offset: 0x00010F03
		public Object GetReferenceObject()
		{
			return PlayableOutputHandle.GetReferenceObject_Injected(ref this);
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x00012D0B File Offset: 0x00010F0B
		public Object GetUserData()
		{
			return PlayableOutputHandle.GetUserData_Injected(ref this);
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x00012D13 File Offset: 0x00010F13
		public float GetWeight()
		{
			return PlayableOutputHandle.GetWeight_Injected(ref this);
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x00012D1B File Offset: 0x00010F1B
		public Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers()
		{
			return PlayableOutputHandle.GetNotificationReceivers_Injected(ref this);
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x00012D23 File Offset: 0x00010F23
		public void RemoveNotificationReceiver(INotificationReceiver receiver)
		{
			PlayableOutputHandle.RemoveNotificationReceiver_Injected(ref this, receiver);
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x00012D2C File Offset: 0x00010F2C
		public static bool IsNull_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.IsNull_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x000A5F88 File Offset: 0x000A4188
		public static Object GetReferenceObject_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetReferenceObject_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x000A5FB0 File Offset: 0x000A41B0
		public static Object GetUserData_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetUserData_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x00012D39 File Offset: 0x00010F39
		public static float GetWeight_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.GetWeight_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x000A5FD8 File Offset: 0x000A41D8
		public static Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetNotificationReceivers_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<INotificationReceiver>>(intPtr2) : null;
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x00012D46 File Offset: 0x00010F46
		public static void RemoveNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver)
		{
			PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(receiver));
		}

		// Token: 0x040023E2 RID: 9186
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040023E3 RID: 9187
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x040023E4 RID: 9188
		private static readonly IntPtr NativeFieldInfoPtr_m_Null;

		// Token: 0x040023E5 RID: 9189
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0;

		// Token: 0x040023E6 RID: 9190
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0;

		// Token: 0x040023E7 RID: 9191
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040023E8 RID: 9192
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;

		// Token: 0x040023E9 RID: 9193
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040023EA RID: 9194
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0;

		// Token: 0x040023EB RID: 9195
		private static readonly IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;

		// Token: 0x040023EC RID: 9196
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_0;

		// Token: 0x040023ED RID: 9197
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableOutputType_Internal_Type_0;

		// Token: 0x040023EE RID: 9198
		private static readonly IntPtr NativeMethodInfoPtr_SetReferenceObject_Internal_Void_Object_0;

		// Token: 0x040023EF RID: 9199
		private static readonly IntPtr NativeMethodInfoPtr_SetUserData_Internal_Void_Object_0;

		// Token: 0x040023F0 RID: 9200
		private static readonly IntPtr NativeMethodInfoPtr_GetSourcePlayable_Internal_PlayableHandle_0;

		// Token: 0x040023F1 RID: 9201
		private static readonly IntPtr NativeMethodInfoPtr_SetSourcePlayable_Internal_Void_PlayableHandle_Int32_0;

		// Token: 0x040023F2 RID: 9202
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceOutputPort_Internal_Int32_0;

		// Token: 0x040023F3 RID: 9203
		private static readonly IntPtr NativeMethodInfoPtr_SetWeight_Internal_Void_Single_0;

		// Token: 0x040023F4 RID: 9204
		private static readonly IntPtr NativeMethodInfoPtr_PushNotification_Internal_Void_PlayableHandle_INotification_Object_0;

		// Token: 0x040023F5 RID: 9205
		private static readonly IntPtr NativeMethodInfoPtr_AddNotificationReceiver_Internal_Void_INotificationReceiver_0;

		// Token: 0x040023F6 RID: 9206
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableOutputHandle_0;

		// Token: 0x040023F7 RID: 9207
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableOutputType_Injected_Private_Static_Type_byref_PlayableOutputHandle_0;

		// Token: 0x040023F8 RID: 9208
		private static readonly IntPtr NativeMethodInfoPtr_SetReferenceObject_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0;

		// Token: 0x040023F9 RID: 9209
		private static readonly IntPtr NativeMethodInfoPtr_SetUserData_Injected_Private_Static_Void_byref_PlayableOutputHandle_Object_0;

		// Token: 0x040023FA RID: 9210
		private static readonly IntPtr NativeMethodInfoPtr_GetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_0;

		// Token: 0x040023FB RID: 9211
		private static readonly IntPtr NativeMethodInfoPtr_SetSourcePlayable_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_Int32_0;

		// Token: 0x040023FC RID: 9212
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceOutputPort_Injected_Private_Static_Int32_byref_PlayableOutputHandle_0;

		// Token: 0x040023FD RID: 9213
		private static readonly IntPtr NativeMethodInfoPtr_SetWeight_Injected_Private_Static_Void_byref_PlayableOutputHandle_Single_0;

		// Token: 0x040023FE RID: 9214
		private static readonly IntPtr NativeMethodInfoPtr_PushNotification_Injected_Private_Static_Void_byref_PlayableOutputHandle_byref_PlayableHandle_INotification_Object_0;

		// Token: 0x040023FF RID: 9215
		private static readonly IntPtr NativeMethodInfoPtr_AddNotificationReceiver_Injected_Private_Static_Void_byref_PlayableOutputHandle_INotificationReceiver_0;

		// Token: 0x04002400 RID: 9216
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x04002401 RID: 9217
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x04002402 RID: 9218
		private static readonly PlayableOutputHandle.IsNull_InjectedDelegate IsNull_InjectedDelegateField;

		// Token: 0x04002403 RID: 9219
		private static readonly PlayableOutputHandle.GetReferenceObject_InjectedDelegate GetReferenceObject_InjectedDelegateField;

		// Token: 0x04002404 RID: 9220
		private static readonly PlayableOutputHandle.GetUserData_InjectedDelegate GetUserData_InjectedDelegateField;

		// Token: 0x04002405 RID: 9221
		private static readonly PlayableOutputHandle.GetWeight_InjectedDelegate GetWeight_InjectedDelegateField;

		// Token: 0x04002406 RID: 9222
		private static readonly PlayableOutputHandle.GetNotificationReceivers_InjectedDelegate GetNotificationReceivers_InjectedDelegateField;

		// Token: 0x04002407 RID: 9223
		private static readonly PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegate RemoveNotificationReceiver_InjectedDelegateField;

		// Token: 0x02000BDF RID: 3039
		private sealed class MethodInfoStoreGeneric_IsPlayableOutputOfType_Internal_Boolean_0<T>
		{
			// Token: 0x04002C1F RID: 11295
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutputHandle.NativeMethodInfoPtr_IsPlayableOutputOfType_Internal_Boolean_0, Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000BE0 RID: 3040
		// (Invoke) Token: 0x06004085 RID: 16517
		private delegate bool IsNull_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BE1 RID: 3041
		// (Invoke) Token: 0x06004087 RID: 16519
		private delegate IntPtr GetReferenceObject_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BE2 RID: 3042
		// (Invoke) Token: 0x06004089 RID: 16521
		private delegate IntPtr GetUserData_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BE3 RID: 3043
		// (Invoke) Token: 0x0600408B RID: 16523
		private delegate float GetWeight_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BE4 RID: 3044
		// (Invoke) Token: 0x0600408D RID: 16525
		private delegate IntPtr GetNotificationReceivers_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000BE5 RID: 3045
		// (Invoke) Token: 0x0600408F RID: 16527
		private delegate void RemoveNotificationReceiver_InjectedDelegate(IntPtr _unity_self, IntPtr receiver);
	}
}

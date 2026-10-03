using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020001A7 RID: 423
	[Serializable]
	public class UnityEvent<T0, T1> : UnityEventBase
	{
		// Token: 0x06001F85 RID: 8069 RVA: 0x00080F1C File Offset: 0x0007F11C
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEvent()
		{
			Il2CppClassPointerStore<UnityEvent<T0, T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEvent`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEvent<T0, T1>>.NativeClassPtr);
			UnityEvent<T0, T1>.NativeFieldInfoPtr_m_InvokeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEvent<T0, T1>>.NativeClassPtr, "m_InvokeArray");
			UnityEvent<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1>>.NativeClassPtr, 100666738);
			UnityEvent<T0, T1>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_2_T0_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1>>.NativeClassPtr, 100666739);
			UnityEvent<T0, T1>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_2_T0_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1>>.NativeClassPtr, 100666740);
			UnityEvent<T0, T1>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1>>.NativeClassPtr, 100666741);
			UnityEvent<T0, T1>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1>>.NativeClassPtr, 100666742);
			UnityEvent<T0, T1>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_2_T0_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1>>.NativeClassPtr, 100666743);
			UnityEvent<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1>>.NativeClassPtr, 100666744);
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0008103C File Offset: 0x0007F23C
		[CallerCount(89)]
		[CachedScanResults(RefRangeStart = 1284934, RefRangeEnd = 1285023, XrefRangeStart = 1284934, XrefRangeEnd = 1285023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEvent<T0, T1>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00081078 File Offset: 0x0007F278
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1285543, RefRangeEnd = 1285546, XrefRangeStart = 1285517, XrefRangeEnd = 1285543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(UnityAction<T0, T1> call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_2_T0_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x000810BC File Offset: 0x0007F2BC
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1285335, RefRangeEnd = 1285370, XrefRangeStart = 1285335, XrefRangeEnd = 1285370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveListener(UnityAction<T0, T1> call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_2_T0_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00081100 File Offset: 0x0007F300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285546, XrefRangeEnd = 1285622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetObjType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent<T0, T1>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00081170 File Offset: 0x0007F370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285622, XrefRangeEnd = 1285625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent<T0, T1>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x000811E0 File Offset: 0x0007F3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285625, XrefRangeEnd = 1285630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseInvokableCall GetDelegate(UnityAction<T0, T1> action)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_2_T0_T1_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00081224 File Offset: 0x0007F424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1285657, RefRangeEnd = 1285658, XrefRangeStart = 1285630, XrefRangeEnd = 1285657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T0 arg0, T1 arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T0 ptr4;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				if (!(t is string))
				{
					ref T0 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref arg0;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T1 ptr7;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				if (!(t2 is string))
				{
					ref T1 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
					if (ref ptr6 != null)
					{
						ptr7 = ref ptr6;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
						{
							ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
						}
					}
				}
				else
				{
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref arg1;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x0000E9D2 File Offset: 0x0000CBD2
		public UnityEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001F8E RID: 8078 RVA: 0x00081310 File Offset: 0x0007F510
		// (set) Token: 0x06001F8F RID: 8079 RVA: 0x0000E9DB File Offset: 0x0000CBDB
		public unsafe Il2CppReferenceArray<Object> m_InvokeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent<T0, T1>.NativeFieldInfoPtr_m_InvokeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent<T0, T1>.NativeFieldInfoPtr_m_InvokeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019AA RID: 6570
		private static readonly IntPtr NativeFieldInfoPtr_m_InvokeArray;

		// Token: 0x040019AB RID: 6571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019AC RID: 6572
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_2_T0_T1_0;

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_2_T0_T1_0;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_2_T0_T1_0;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_0;
	}
}

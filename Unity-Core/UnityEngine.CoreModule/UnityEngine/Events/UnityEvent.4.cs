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
	// Token: 0x020001A9 RID: 425
	[Serializable]
	public class UnityEvent<T0, T1, T2> : UnityEventBase
	{
		// Token: 0x06001F99 RID: 8089 RVA: 0x0008177C File Offset: 0x0007F97C
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEvent()
		{
			Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEvent`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr);
			UnityEvent<T0, T1, T2>.NativeFieldInfoPtr_m_InvokeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, "m_InvokeArray");
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100666749);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_3_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100666750);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_3_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100666751);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100666752);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100666753);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_3_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100666754);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100666755);
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x000818AC File Offset: 0x0007FAAC
		[CallerCount(89)]
		[CachedScanResults(RefRangeStart = 1284934, RefRangeEnd = 1285023, XrefRangeStart = 1284934, XrefRangeEnd = 1285023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x000818E8 File Offset: 0x0007FAE8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1285697, RefRangeEnd = 1285705, XrefRangeStart = 1285666, XrefRangeEnd = 1285697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(UnityAction<T0, T1, T2> call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_3_T0_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x0008192C File Offset: 0x0007FB2C
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1285335, RefRangeEnd = 1285370, XrefRangeStart = 1285335, XrefRangeEnd = 1285370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveListener(UnityAction<T0, T1, T2> call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_3_T0_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x00081970 File Offset: 0x0007FB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285705, XrefRangeEnd = 1285756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetObjType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x000819E0 File Offset: 0x0007FBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285756, XrefRangeEnd = 1285759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00081A50 File Offset: 0x0007FC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285759, XrefRangeEnd = 1285764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_3_T0_T1_T2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x00081A94 File Offset: 0x0007FC94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1285794, RefRangeEnd = 1285798, XrefRangeStart = 1285764, XrefRangeEnd = 1285794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T0 arg0, T1 arg1, T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
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
			IntPtr* ptr8 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T2 ptr10;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				if (!(t3 is string))
				{
					ref T2 ptr9 = ptr10 = IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase);
					if (ref ptr9 != null)
					{
						ptr10 = ref ptr9;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr9)))
						{
							ptr10 = IL2CPP.il2cpp_object_unbox(ref ptr9);
						}
					}
				}
				else
				{
					ptr10 = IL2CPP.ManagedStringToIl2Cpp(t3 as string);
				}
			}
			else
			{
				ptr10 = ref arg2;
			}
			*ptr8 = ref ptr10;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x0000EA2A File Offset: 0x0000CC2A
		public UnityEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x00081BDC File Offset: 0x0007FDDC
		// (set) Token: 0x06001FA3 RID: 8099 RVA: 0x0000EA33 File Offset: 0x0000CC33
		public unsafe Il2CppReferenceArray<Object> m_InvokeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent<T0, T1, T2>.NativeFieldInfoPtr_m_InvokeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent<T0, T1, T2>.NativeFieldInfoPtr_m_InvokeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeFieldInfoPtr_m_InvokeArray;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_3_T0_T1_T2_0;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_3_T0_T1_T2_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_3_T0_T1_T2_0;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_T2_0;
	}
}

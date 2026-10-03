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
	// Token: 0x020001A5 RID: 421
	[Serializable]
	public class UnityEvent<T0> : UnityEventBase
	{
		// Token: 0x06001F71 RID: 8049 RVA: 0x000807F8 File Offset: 0x0007E9F8
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEvent()
		{
			Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEvent`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr);
			UnityEvent<T0>.NativeFieldInfoPtr_m_InvokeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, "m_InvokeArray");
			UnityEvent<T0>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100666727);
			UnityEvent<T0>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100666728);
			UnityEvent<T0>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_1_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100666729);
			UnityEvent<T0>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100666730);
			UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100666731);
			UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_1_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100666732);
			UnityEvent<T0>.NativeMethodInfoPtr_Invoke_Public_Void_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100666733);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00080904 File Offset: 0x0007EB04
		[CallerCount(89)]
		[CachedScanResults(RefRangeStart = 1284934, RefRangeEnd = 1285023, XrefRangeStart = 1284932, XrefRangeEnd = 1284934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00080940 File Offset: 0x0007EB40
		[CallerCount(230)]
		[CachedScanResults(RefRangeStart = 1285102, RefRangeEnd = 1285332, XrefRangeStart = 1285023, XrefRangeEnd = 1285102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(UnityAction<T0> call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00080984 File Offset: 0x0007EB84
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 1285335, RefRangeEnd = 1285370, XrefRangeStart = 1285332, XrefRangeEnd = 1285335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveListener(UnityAction<T0> call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_1_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x000809C8 File Offset: 0x0007EBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285370, XrefRangeEnd = 1285468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetObjType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent<T0>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00080A38 File Offset: 0x0007EC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285468, XrefRangeEnd = 1285471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00080AA8 File Offset: 0x0007ECA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285471, XrefRangeEnd = 1285476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseInvokableCall GetDelegate(UnityAction<T0> action)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_1_T0_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00080AEC File Offset: 0x0007ECEC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1285499, RefRangeEnd = 1285507, XrefRangeStart = 1285476, XrefRangeEnd = 1285499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T0 arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
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
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_Invoke_Public_Void_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x0000E97A File Offset: 0x0000CB7A
		public UnityEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001F7A RID: 8058 RVA: 0x00080B7C File Offset: 0x0007ED7C
		// (set) Token: 0x06001F7B RID: 8059 RVA: 0x0000E983 File Offset: 0x0000CB83
		public unsafe Il2CppReferenceArray<Object> m_InvokeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent<T0>.NativeFieldInfoPtr_m_InvokeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent<T0>.NativeFieldInfoPtr_m_InvokeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400199E RID: 6558
		private static readonly IntPtr NativeFieldInfoPtr_m_InvokeArray;

		// Token: 0x0400199F RID: 6559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019A0 RID: 6560
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_T0_0;

		// Token: 0x040019A1 RID: 6561
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_1_T0_0;

		// Token: 0x040019A2 RID: 6562
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0;

		// Token: 0x040019A3 RID: 6563
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0;

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_1_T0_0;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T0_0;
	}
}

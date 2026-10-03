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
	// Token: 0x0200019B RID: 411
	public class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall
	{
		// Token: 0x06001EDB RID: 7899 RVA: 0x0007DAD0 File Offset: 0x0007BCD0
		// Note: this type is marked as 'beforefieldinit'.
		static InvokableCall()
		{
			Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "InvokableCall`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr);
			InvokableCall<T1, T2, T3, T4>.NativeFieldInfoPtr_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr, "Delegate");
			InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_4_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr, 100666635);
			InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_4_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr, 100666636);
			InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr, 100666637);
			InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_4_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr, 100666638);
			InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr, 100666639);
			InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr, 100666640);
			InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr, 100666641);
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0007DC14 File Offset: 0x0007BE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Delegate(UnityAction<T1, T2, T3, T4> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_4_T1_T2_T3_T4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x0007DC58 File Offset: 0x0007BE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Delegate(UnityAction<T1, T2, T3, T4> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_4_T1_T2_T3_T4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0007DC9C File Offset: 0x0007BE9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1283178, RefRangeEnd = 1283179, XrefRangeStart = 1283148, XrefRangeEnd = 1283178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(Object target, MethodInfo theFunction) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x0007DCFC File Offset: 0x0007BEFC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1283060, RefRangeEnd = 1283066, XrefRangeStart = 1283060, XrefRangeEnd = 1283066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(UnityAction<T1, T2, T3, T4> action) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall<T1, T2, T3, T4>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_4_T1_T2_T3_T4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0007DD48 File Offset: 0x0007BF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283179, XrefRangeEnd = 1283196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Invoke(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0007DD98 File Offset: 0x0007BF98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1283197, RefRangeEnd = 1283198, XrefRangeStart = 1283196, XrefRangeEnd = 1283197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T1 args0, T2 args1, T3 args2, T4 args3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = args0;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref args0;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T2 ptr7;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = args1;
				if (!(t2 is string))
				{
					ref T2 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
				ptr7 = ref args1;
			}
			*ptr5 = ref ptr7;
			IntPtr* ptr8 = ptr + checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T3 ptr10;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = args2;
				if (!(t3 is string))
				{
					ref T3 ptr9 = ptr10 = IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase);
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
				ptr10 = ref args2;
			}
			*ptr8 = ref ptr10;
			IntPtr* ptr11 = ptr + checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T4 ptr13;
			if (!typeof(T4).IsValueType)
			{
				T4 t4 = args3;
				if (!(t4 is string))
				{
					ref T4 ptr12 = ptr13 = IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase);
					if (ref ptr12 != null)
					{
						ptr13 = ref ptr12;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr12)))
						{
							ptr13 = IL2CPP.il2cpp_object_unbox(ref ptr12);
						}
					}
				}
				else
				{
					ptr13 = IL2CPP.ManagedStringToIl2Cpp(t4 as string);
				}
			}
			else
			{
				ptr13 = ref args3;
			}
			*ptr11 = ref ptr13;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_T3_T4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x0007DF40 File Offset: 0x0007C140
		[CallerCount(0)]
		public unsafe override bool Find(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall<T1, T2, T3, T4>.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x0000E6FB File Offset: 0x0000C8FB
		public InvokableCall(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x0007DFAC File Offset: 0x0007C1AC
		// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x0000E704 File Offset: 0x0000C904
		public unsafe UnityAction<T1, T2, T3, T4> Delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall<T1, T2, T3, T4>.NativeFieldInfoPtr_Delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<T1, T2, T3, T4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall<T1, T2, T3, T4>.NativeFieldInfoPtr_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeFieldInfoPtr_Delegate;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_4_T1_T2_T3_T4_0;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_4_T1_T2_T3_T4_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityAction_4_T1_T2_T3_T4_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_T3_T4_0;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0;
	}
}

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
	// Token: 0x02000199 RID: 409
	public class InvokableCall<T1, T2> : BaseInvokableCall
	{
		// Token: 0x06001EC5 RID: 7877 RVA: 0x0007D20C File Offset: 0x0007B40C
		// Note: this type is marked as 'beforefieldinit'.
		static InvokableCall()
		{
			Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "InvokableCall`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr);
			InvokableCall<T1, T2>.NativeFieldInfoPtr_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, "Delegate");
			InvokableCall<T1, T2>.NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100666621);
			InvokableCall<T1, T2>.NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100666622);
			InvokableCall<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100666623);
			InvokableCall<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100666624);
			InvokableCall<T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100666625);
			InvokableCall<T1, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100666626);
			InvokableCall<T1, T2>.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100666627);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x0007D32C File Offset: 0x0007B52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Delegate(UnityAction<T1, T2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2>.NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_2_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0007D370 File Offset: 0x0007B570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Delegate(UnityAction<T1, T2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2>.NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_2_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x0007D3B4 File Offset: 0x0007B5B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1283053, RefRangeEnd = 1283054, XrefRangeStart = 1283023, XrefRangeEnd = 1283053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(Object target, MethodInfo theFunction) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x0007D414 File Offset: 0x0007B614
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1283060, RefRangeEnd = 1283066, XrefRangeStart = 1283054, XrefRangeEnd = 1283060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(UnityAction<T1, T2> action) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_2_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x0007D460 File Offset: 0x0007B660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1283066, XrefRangeEnd = 1283073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Invoke(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall<T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x0007D4B0 File Offset: 0x0007B6B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1283074, RefRangeEnd = 1283075, XrefRangeStart = 1283073, XrefRangeEnd = 1283074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T1 args0, T2 args1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
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
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0007D59C File Offset: 0x0007B79C
		[CallerCount(0)]
		public unsafe override bool Find(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall<T1, T2>.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x0000E6AB File Offset: 0x0000C8AB
		public InvokableCall(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x0007D608 File Offset: 0x0007B808
		// (set) Token: 0x06001ECF RID: 7887 RVA: 0x0000E6B4 File Offset: 0x0000C8B4
		public unsafe UnityAction<T1, T2> Delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall<T1, T2>.NativeFieldInfoPtr_Delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<T1, T2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall<T1, T2>.NativeFieldInfoPtr_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeFieldInfoPtr_Delegate;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_2_T1_T2_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_2_T1_T2_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityAction_2_T1_T2_0;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_0;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0;
	}
}

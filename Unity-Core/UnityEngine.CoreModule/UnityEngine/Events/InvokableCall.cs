using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x02000197 RID: 407
	public class InvokableCall : BaseInvokableCall
	{
		// Token: 0x06001EAF RID: 7855 RVA: 0x0007CB24 File Offset: 0x0007AD24
		// Note: this type is marked as 'beforefieldinit'.
		static InvokableCall()
		{
			Il2CppClassPointerStore<InvokableCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "InvokableCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr);
			InvokableCall.NativeFieldInfoPtr_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, "Delegate");
			InvokableCall.NativeMethodInfoPtr_add_Delegate_Private_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100666607);
			InvokableCall.NativeMethodInfoPtr_remove_Delegate_Private_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100666608);
			InvokableCall.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100666609);
			InvokableCall.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100666610);
			InvokableCall.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100666611);
			InvokableCall.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100666612);
			InvokableCall.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100666613);
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x0007CBF4 File Offset: 0x0007ADF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1282821, RefRangeEnd = 1282825, XrefRangeStart = 1282817, XrefRangeEnd = 1282821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Delegate(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall.NativeMethodInfoPtr_add_Delegate_Private_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x0007CC38 File Offset: 0x0007AE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282825, XrefRangeEnd = 1282829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Delegate(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall.NativeMethodInfoPtr_remove_Delegate_Private_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x0007CC7C File Offset: 0x0007AE7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1282863, RefRangeEnd = 1282865, XrefRangeStart = 1282829, XrefRangeEnd = 1282863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(Object target, MethodInfo theFunction) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x0007CCDC File Offset: 0x0007AEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1282865, XrefRangeEnd = 1282867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(UnityAction action) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0007CD28 File Offset: 0x0007AF28
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1282871, RefRangeEnd = 1282877, XrefRangeStart = 1282867, XrefRangeEnd = 1282871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Invoke(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x0007CD78 File Offset: 0x0007AF78
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1282871, RefRangeEnd = 1282877, XrefRangeStart = 1282871, XrefRangeEnd = 1282877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x0007CDAC File Offset: 0x0007AFAC
		[CallerCount(0)]
		public unsafe override bool Find(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x0000E65B File Offset: 0x0000C85B
		public InvokableCall(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x0007CE18 File Offset: 0x0007B018
		// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x0000E664 File Offset: 0x0000C864
		public unsafe UnityAction Delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall.NativeFieldInfoPtr_Delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall.NativeFieldInfoPtr_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeFieldInfoPtr_Delegate;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr_add_Delegate_Private_add_Void_UnityAction_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_remove_Delegate_Private_rem_Void_UnityAction_0;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityAction_0;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0;
	}
}

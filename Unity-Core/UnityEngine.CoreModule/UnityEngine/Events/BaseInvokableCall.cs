using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x02000196 RID: 406
	public class BaseInvokableCall : Object
	{
		// Token: 0x06001EA7 RID: 7847 RVA: 0x0007C8A8 File Offset: 0x0007AAA8
		// Note: this type is marked as 'beforefieldinit'.
		static BaseInvokableCall()
		{
			Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "BaseInvokableCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr);
			BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100666601);
			BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100666602);
			BaseInvokableCall.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100666603);
			BaseInvokableCall.NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100666604);
			BaseInvokableCall.NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100666605);
			BaseInvokableCall.NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100666606);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0007C950 File Offset: 0x0007AB50
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInvokableCall() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0007C98C File Offset: 0x0007AB8C
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1282772, RefRangeEnd = 1282792, XrefRangeStart = 1282768, XrefRangeEnd = 1282772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInvokableCall(Object target, MethodInfo function) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x0007C9EC File Offset: 0x0007ABEC
		[CallerCount(0)]
		public unsafe virtual void Invoke(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInvokableCall.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x0007CA3C File Offset: 0x0007AC3C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1282795, RefRangeEnd = 1282805, XrefRangeStart = 1282792, XrefRangeEnd = 1282795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowOnInvalidArg<T>(Object arg)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.MethodInfoStoreGeneric_ThrowOnInvalidArg_Protected_Static_Void_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0007CA74 File Offset: 0x0007AC74
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1282809, RefRangeEnd = 1282817, XrefRangeStart = 1282805, XrefRangeEnd = 1282809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllowInvoke(Delegate @delegate)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@delegate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x0007CAB8 File Offset: 0x0007ACB8
		[CallerCount(0)]
		public unsafe virtual bool Find(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseInvokableCall.NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x0000E652 File Offset: 0x0000C852
		public BaseInvokableCall(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001907 RID: 6407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001908 RID: 6408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0;

		// Token: 0x04001909 RID: 6409
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400190A RID: 6410
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0;

		// Token: 0x0400190B RID: 6411
		private static readonly IntPtr NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0;

		// Token: 0x0400190C RID: 6412
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0;

		// Token: 0x02000A19 RID: 2585
		private sealed class MethodInfoStoreGeneric_ThrowOnInvalidArg_Protected_Static_Void_Object_0<T>
		{
			// Token: 0x04002BA1 RID: 11169
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseInvokableCall.NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0, Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}

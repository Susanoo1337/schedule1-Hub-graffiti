using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x020002A2 RID: 674
	public sealed class ResponseCallback : MulticastDelegate
	{
		// Token: 0x06003336 RID: 13110 RVA: 0x00124B74 File Offset: 0x00122D74
		// Note: this type is marked as 'beforefieldinit'.
		static ResponseCallback()
		{
			Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "ResponseCallback");
			ResponseCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr, 100669719);
			ResponseCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr, 100669720);
			ResponseCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr, 100669721);
			ResponseCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr, 100669722);
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00124BEC File Offset: 0x00122DEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 73307, RefRangeEnd = 73313, XrefRangeStart = 73307, XrefRangeEnd = 73313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResponseCallback(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResponseCallback>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00124C48 File Offset: 0x00122E48
		[CallerCount(0)]
		public unsafe void Invoke(string responseLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(responseLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00124C8C File Offset: 0x00122E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71797, XrefRangeEnd = 71798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(string responseLabel, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(responseLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x00124D00 File Offset: 0x00122F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResponseCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x0001A3C0 File Offset: 0x000185C0
		public ResponseCallback(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x0001A3C9 File Offset: 0x000185C9
		public static implicit operator ResponseCallback(Action<string> A_0)
		{
			return DelegateSupport.ConvertDelegate<ResponseCallback>(A_0);
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x0001A3D1 File Offset: 0x000185D1
		public static ResponseCallback operator +(ResponseCallback A_0, ResponseCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ResponseCallback>();
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x0001A3DF File Offset: 0x000185DF
		public static ResponseCallback operator -(ResponseCallback A_0, ResponseCallback A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<ResponseCallback>();
			}
			return result;
		}

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

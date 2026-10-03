using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Events
{
	// Token: 0x020005C9 RID: 1481
	public sealed class BasicEvent : MulticastDelegate
	{
		// Token: 0x06008FA1 RID: 36769 RVA: 0x0026E3BC File Offset: 0x0026C5BC
		// Note: this type is marked as 'beforefieldinit'.
		static BasicEvent()
		{
			Il2CppClassPointerStore<BasicEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Events", "BasicEvent");
			BasicEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicEvent>.NativeClassPtr, 100681913);
			BasicEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicEvent>.NativeClassPtr, 100681914);
			BasicEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicEvent>.NativeClassPtr, 100681915);
			BasicEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicEvent>.NativeClassPtr, 100681916);
		}

		// Token: 0x06008FA2 RID: 36770 RVA: 0x0026E434 File Offset: 0x0026C634
		[CallerCount(1472)]
		[CachedScanResults(RefRangeStart = 20074, RefRangeEnd = 21546, XrefRangeStart = 20074, XrefRangeEnd = 21546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicEvent(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FA3 RID: 36771 RVA: 0x0026E490 File Offset: 0x0026C690
		[CallerCount(0)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FA4 RID: 36772 RVA: 0x0026E4C4 File Offset: 0x0026C6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06008FA5 RID: 36773 RVA: 0x0026E528 File Offset: 0x0026C728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FA6 RID: 36774 RVA: 0x00043DE8 File Offset: 0x00041FE8
		public BasicEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06008FA7 RID: 36775 RVA: 0x00043DF1 File Offset: 0x00041FF1
		public static implicit operator BasicEvent(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<BasicEvent>(A_0);
		}

		// Token: 0x06008FA8 RID: 36776 RVA: 0x00043DF9 File Offset: 0x00041FF9
		public static BasicEvent operator +(BasicEvent A_0, BasicEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<BasicEvent>();
		}

		// Token: 0x06008FA9 RID: 36777 RVA: 0x00043E07 File Offset: 0x00042007
		public static BasicEvent operator -(BasicEvent A_0, BasicEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<BasicEvent>();
			}
			return result;
		}

		// Token: 0x04006293 RID: 25235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04006294 RID: 25236
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		// Token: 0x04006295 RID: 25237
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04006296 RID: 25238
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

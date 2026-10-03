using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000760 RID: 1888
	public sealed class TabSelectedEvent : MulticastDelegate
	{
		// Token: 0x0600B816 RID: 47126 RVA: 0x002F8C3C File Offset: 0x002F6E3C
		// Note: this type is marked as 'beforefieldinit'.
		static TabSelectedEvent()
		{
			Il2CppClassPointerStore<TabSelectedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TabSelectedEvent");
			TabSelectedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabSelectedEvent>.NativeClassPtr, 100687384);
			TabSelectedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabSelectedEvent>.NativeClassPtr, 100687385);
			TabSelectedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabSelectedEvent>.NativeClassPtr, 100687386);
			TabSelectedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabSelectedEvent>.NativeClassPtr, 100687387);
		}

		// Token: 0x0600B817 RID: 47127 RVA: 0x002F8CB4 File Offset: 0x002F6EB4
		[CallerCount(152)]
		[CachedScanResults(RefRangeStart = 95930, RefRangeEnd = 96082, XrefRangeStart = 95930, XrefRangeEnd = 96082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TabSelectedEvent(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabSelectedEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabSelectedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x002F8D10 File Offset: 0x002F6F10
		[CallerCount(0)]
		public unsafe void Invoke(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabSelectedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x002F8D50 File Offset: 0x002F6F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308857, XrefRangeEnd = 308861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(int index, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabSelectedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600B81A RID: 47130 RVA: 0x002F8DC0 File Offset: 0x002F6FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabSelectedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B81B RID: 47131 RVA: 0x000558C6 File Offset: 0x00053AC6
		public TabSelectedEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600B81C RID: 47132 RVA: 0x000558CF File Offset: 0x00053ACF
		public static implicit operator TabSelectedEvent(Action<int> A_0)
		{
			return DelegateSupport.ConvertDelegate<TabSelectedEvent>(A_0);
		}

		// Token: 0x0600B81D RID: 47133 RVA: 0x000558D7 File Offset: 0x00053AD7
		public static TabSelectedEvent operator +(TabSelectedEvent A_0, TabSelectedEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<TabSelectedEvent>();
		}

		// Token: 0x0600B81E RID: 47134 RVA: 0x000558E5 File Offset: 0x00053AE5
		public static TabSelectedEvent operator -(TabSelectedEvent A_0, TabSelectedEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<TabSelectedEvent>();
			}
			return result;
		}

		// Token: 0x04007E6A RID: 32362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04007E6B RID: 32363
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04007E6C RID: 32364
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

		// Token: 0x04007E6D RID: 32365
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

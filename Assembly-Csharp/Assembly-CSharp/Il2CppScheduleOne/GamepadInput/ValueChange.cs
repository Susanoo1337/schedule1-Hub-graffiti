using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.GamepadInput
{
	// Token: 0x0200070C RID: 1804
	public sealed class ValueChange : MulticastDelegate
	{
		// Token: 0x0600AE17 RID: 44567 RVA: 0x002DB098 File Offset: 0x002D9298
		// Note: this type is marked as 'beforefieldinit'.
		static ValueChange()
		{
			Il2CppClassPointerStore<ValueChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GamepadInput", "ValueChange");
			ValueChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueChange>.NativeClassPtr, 100686233);
			ValueChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueChange>.NativeClassPtr, 100686234);
			ValueChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueChange>.NativeClassPtr, 100686235);
			ValueChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueChange>.NativeClassPtr, 100686236);
		}

		// Token: 0x0600AE18 RID: 44568 RVA: 0x002DB110 File Offset: 0x002D9310
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 297782, RefRangeEnd = 297878, XrefRangeStart = 297779, XrefRangeEnd = 297782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueChange(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueChange>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE19 RID: 44569 RVA: 0x002DB16C File Offset: 0x002D936C
		[CallerCount(0)]
		public unsafe void Invoke(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE1A RID: 44570 RVA: 0x002DB1AC File Offset: 0x002D93AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297878, XrefRangeEnd = 297882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(float value, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600AE1B RID: 44571 RVA: 0x002DB21C File Offset: 0x002D941C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AE1C RID: 44572 RVA: 0x0004FB74 File Offset: 0x0004DD74
		public ValueChange(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600AE1D RID: 44573 RVA: 0x0004FB7D File Offset: 0x0004DD7D
		public static implicit operator ValueChange(Action<float> A_0)
		{
			return DelegateSupport.ConvertDelegate<ValueChange>(A_0);
		}

		// Token: 0x0600AE1E RID: 44574 RVA: 0x0004FB85 File Offset: 0x0004DD85
		public static ValueChange operator +(ValueChange A_0, ValueChange A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ValueChange>();
		}

		// Token: 0x0600AE1F RID: 44575 RVA: 0x0004FB93 File Offset: 0x0004DD93
		public static ValueChange operator -(ValueChange A_0, ValueChange A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<ValueChange>();
			}
			return result;
		}

		// Token: 0x0400782B RID: 30763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400782C RID: 30764
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400782D RID: 30765
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_AsyncCallback_Object_0;

		// Token: 0x0400782E RID: 30766
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

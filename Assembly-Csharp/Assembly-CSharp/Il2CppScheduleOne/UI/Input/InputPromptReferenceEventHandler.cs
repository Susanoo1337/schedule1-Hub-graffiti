using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x0200080A RID: 2058
	public sealed class InputPromptReferenceEventHandler : MulticastDelegate
	{
		// Token: 0x0600C81A RID: 51226 RVA: 0x0032977C File Offset: 0x0032797C
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptReferenceEventHandler()
		{
			Il2CppClassPointerStore<InputPromptReferenceEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptReferenceEventHandler");
			InputPromptReferenceEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptReferenceEventHandler>.NativeClassPtr, 100689173);
			InputPromptReferenceEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_InputPromptReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptReferenceEventHandler>.NativeClassPtr, 100689174);
			InputPromptReferenceEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_InputPromptReference_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptReferenceEventHandler>.NativeClassPtr, 100689175);
			InputPromptReferenceEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptReferenceEventHandler>.NativeClassPtr, 100689176);
		}

		// Token: 0x0600C81B RID: 51227 RVA: 0x003297F4 File Offset: 0x003279F4
		[CallerCount(628)]
		[CachedScanResults(RefRangeStart = 71168, RefRangeEnd = 71796, XrefRangeStart = 71168, XrefRangeEnd = 71796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptReferenceEventHandler(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptReferenceEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptReferenceEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C81C RID: 51228 RVA: 0x00329850 File Offset: 0x00327A50
		[CallerCount(0)]
		public unsafe void Invoke(InputPromptReference moduleRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(moduleRef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptReferenceEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_InputPromptReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C81D RID: 51229 RVA: 0x00329894 File Offset: 0x00327A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71797, XrefRangeEnd = 71798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(InputPromptReference moduleRef, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(moduleRef);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptReferenceEventHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_InputPromptReference_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600C81E RID: 51230 RVA: 0x00329908 File Offset: 0x00327B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptReferenceEventHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C81F RID: 51231 RVA: 0x0005E9B0 File Offset: 0x0005CBB0
		public InputPromptReferenceEventHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600C820 RID: 51232 RVA: 0x0005E9B9 File Offset: 0x0005CBB9
		public static implicit operator InputPromptReferenceEventHandler(Action<InputPromptReference> A_0)
		{
			return DelegateSupport.ConvertDelegate<InputPromptReferenceEventHandler>(A_0);
		}

		// Token: 0x0600C821 RID: 51233 RVA: 0x0005E9C1 File Offset: 0x0005CBC1
		public static InputPromptReferenceEventHandler operator +(InputPromptReferenceEventHandler A_0, InputPromptReferenceEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<InputPromptReferenceEventHandler>();
		}

		// Token: 0x0600C822 RID: 51234 RVA: 0x0005E9CF File Offset: 0x0005CBCF
		public static InputPromptReferenceEventHandler operator -(InputPromptReferenceEventHandler A_0, InputPromptReferenceEventHandler A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<InputPromptReferenceEventHandler>();
			}
			return result;
		}

		// Token: 0x04008861 RID: 34913
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04008862 RID: 34914
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_InputPromptReference_0;

		// Token: 0x04008863 RID: 34915
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_InputPromptReference_AsyncCallback_Object_0;

		// Token: 0x04008864 RID: 34916
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

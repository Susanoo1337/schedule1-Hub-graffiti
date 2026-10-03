using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000726 RID: 1830
	public sealed class CyclerEvent : MulticastDelegate
	{
		// Token: 0x0600B062 RID: 45154 RVA: 0x002E1C0C File Offset: 0x002DFE0C
		// Note: this type is marked as 'beforefieldinit'.
		static CyclerEvent()
		{
			Il2CppClassPointerStore<CyclerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CyclerEvent");
			CyclerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerEvent>.NativeClassPtr, 100686493);
			CyclerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerEvent>.NativeClassPtr, 100686494);
			CyclerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerEvent>.NativeClassPtr, 100686495);
			CyclerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerEvent>.NativeClassPtr, 100686496);
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x002E1C84 File Offset: 0x002DFE84
		[CallerCount(152)]
		[CachedScanResults(RefRangeStart = 95930, RefRangeEnd = 96082, XrefRangeStart = 95930, XrefRangeEnd = 96082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CyclerEvent(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CyclerEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B064 RID: 45156 RVA: 0x002E1CE0 File Offset: 0x002DFEE0
		[CallerCount(0)]
		public unsafe void Invoke(int dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x002E1D20 File Offset: 0x002DFF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299958, XrefRangeEnd = 299962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(int dir, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x002E1D90 File Offset: 0x002DFF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B067 RID: 45159 RVA: 0x00050FF6 File Offset: 0x0004F1F6
		public CyclerEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600B068 RID: 45160 RVA: 0x00050FFF File Offset: 0x0004F1FF
		public static implicit operator CyclerEvent(Action<int> A_0)
		{
			return DelegateSupport.ConvertDelegate<CyclerEvent>(A_0);
		}

		// Token: 0x0600B069 RID: 45161 RVA: 0x00051007 File Offset: 0x0004F207
		public static CyclerEvent operator +(CyclerEvent A_0, CyclerEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<CyclerEvent>();
		}

		// Token: 0x0600B06A RID: 45162 RVA: 0x00051015 File Offset: 0x0004F215
		public static CyclerEvent operator -(CyclerEvent A_0, CyclerEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<CyclerEvent>();
			}
			return result;
		}

		// Token: 0x04007993 RID: 31123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04007994 RID: 31124
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04007995 RID: 31125
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

		// Token: 0x04007996 RID: 31126
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

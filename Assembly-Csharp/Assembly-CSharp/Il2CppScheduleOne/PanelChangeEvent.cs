using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x020000AE RID: 174
	public sealed class PanelChangeEvent : MulticastDelegate
	{
		// Token: 0x06000F78 RID: 3960 RVA: 0x000AEC08 File Offset: 0x000ACE08
		// Note: this type is marked as 'beforefieldinit'.
		static PanelChangeEvent()
		{
			Il2CppClassPointerStore<PanelChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "PanelChangeEvent");
			PanelChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangeEvent>.NativeClassPtr, 100665257);
			PanelChangeEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIPanel_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangeEvent>.NativeClassPtr, 100665258);
			PanelChangeEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIPanel_UIPanel_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangeEvent>.NativeClassPtr, 100665259);
			PanelChangeEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelChangeEvent>.NativeClassPtr, 100665260);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x000AEC80 File Offset: 0x000ACE80
		[CallerCount(469)]
		[CachedScanResults(RefRangeStart = 82922, RefRangeEnd = 83391, XrefRangeStart = 82912, XrefRangeEnd = 82922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PanelChangeEvent(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelChangeEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000AECDC File Offset: 0x000ACEDC
		[CallerCount(0)]
		public unsafe void Invoke(UIPanel previousPanel, UIPanel newPanel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousPanel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newPanel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangeEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIPanel_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x000AED30 File Offset: 0x000ACF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(UIPanel previousPanel, UIPanel newPanel, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousPanel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newPanel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangeEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIPanel_UIPanel_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x000AEDB8 File Offset: 0x000ACFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelChangeEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x000092F2 File Offset: 0x000074F2
		public PanelChangeEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000092FB File Offset: 0x000074FB
		public static implicit operator PanelChangeEvent(Action<UIPanel, UIPanel> A_0)
		{
			return DelegateSupport.ConvertDelegate<PanelChangeEvent>(A_0);
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x00009303 File Offset: 0x00007503
		public static PanelChangeEvent operator +(PanelChangeEvent A_0, PanelChangeEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PanelChangeEvent>();
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00009311 File Offset: 0x00007511
		public static PanelChangeEvent operator -(PanelChangeEvent A_0, PanelChangeEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<PanelChangeEvent>();
			}
			return result;
		}

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIPanel_UIPanel_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIPanel_UIPanel_AsyncCallback_Object_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

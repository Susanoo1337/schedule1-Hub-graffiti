using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppLiquidVolumeFX
{
	// Token: 0x02000080 RID: 128
	public sealed class PropertiesChangedEvent : MulticastDelegate
	{
		// Token: 0x06000969 RID: 2409 RVA: 0x0009A218 File Offset: 0x00098418
		// Note: this type is marked as 'beforefieldinit'.
		static PropertiesChangedEvent()
		{
			Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "LiquidVolumeFX", "PropertiesChangedEvent");
			PropertiesChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100664507);
			PropertiesChangedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LiquidVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100664508);
			PropertiesChangedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LiquidVolume_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100664509);
			PropertiesChangedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr, 100664510);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0009A290 File Offset: 0x00098490
		[CallerCount(628)]
		[CachedScanResults(RefRangeStart = 71168, RefRangeEnd = 71796, XrefRangeStart = 71168, XrefRangeEnd = 71796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertiesChangedEvent(Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertiesChangedEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0009A2EC File Offset: 0x000984EC
		[CallerCount(0)]
		public unsafe void Invoke(LiquidVolume lv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LiquidVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0009A330 File Offset: 0x00098530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71797, XrefRangeEnd = 71798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(LiquidVolume lv, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lv);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LiquidVolume_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0009A3A4 File Offset: 0x000985A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesChangedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0000650B File Offset: 0x0000470B
		public PropertiesChangedEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00006514 File Offset: 0x00004714
		public static implicit operator PropertiesChangedEvent(Action<LiquidVolume> A_0)
		{
			return DelegateSupport.ConvertDelegate<PropertiesChangedEvent>(A_0);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0000651C File Offset: 0x0000471C
		public static PropertiesChangedEvent operator +(PropertiesChangedEvent A_0, PropertiesChangedEvent A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PropertiesChangedEvent>();
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0000652A File Offset: 0x0000472A
		public static PropertiesChangedEvent operator -(PropertiesChangedEvent A_0, PropertiesChangedEvent A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<PropertiesChangedEvent>();
			}
			return result;
		}

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LiquidVolume_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LiquidVolume_AsyncCallback_Object_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}

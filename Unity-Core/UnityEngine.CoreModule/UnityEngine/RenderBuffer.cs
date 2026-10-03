using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000094 RID: 148
	[StructLayout(2)]
	public struct RenderBuffer
	{
		// Token: 0x06000824 RID: 2084 RVA: 0x00030B0C File Offset: 0x0002ED0C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderBuffer()
		{
			Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr);
			RenderBuffer.NativeFieldInfoPtr_m_RenderTextureInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, "m_RenderTextureInstanceID");
			RenderBuffer.NativeFieldInfoPtr_m_BufferPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, "m_BufferPtr");
			RenderBuffer.SetLoadAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.SetLoadAction_InjectedDelegate>("UnityEngine.RenderBuffer::SetLoadAction_Injected");
			RenderBuffer.SetStoreAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.SetStoreAction_InjectedDelegate>("UnityEngine.RenderBuffer::SetStoreAction_Injected");
			RenderBuffer.GetLoadAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetLoadAction_InjectedDelegate>("UnityEngine.RenderBuffer::GetLoadAction_Injected");
			RenderBuffer.GetStoreAction_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetStoreAction_InjectedDelegate>("UnityEngine.RenderBuffer::GetStoreAction_Injected");
			RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegateField = IL2CPP.ResolveICall<RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegate>("UnityEngine.RenderBuffer::GetNativeRenderBufferPtr_Injected");
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00005984 File Offset: 0x00003B84
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderBuffer>.NativeClassPtr, ref this));
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00005996 File Offset: 0x00003B96
		public void SetLoadAction(UnityEngine.Rendering.RenderBufferLoadAction action)
		{
			RenderBuffer.SetLoadAction_Injected(ref this, action);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0000599F File Offset: 0x00003B9F
		public void SetStoreAction(UnityEngine.Rendering.RenderBufferStoreAction action)
		{
			RenderBuffer.SetStoreAction_Injected(ref this, action);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000059A8 File Offset: 0x00003BA8
		public UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction()
		{
			return RenderBuffer.GetLoadAction_Injected(ref this);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000059B0 File Offset: 0x00003BB0
		public UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction()
		{
			return RenderBuffer.GetStoreAction_Injected(ref this);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000059B8 File Offset: 0x00003BB8
		public IntPtr GetNativeRenderBufferPtr()
		{
			return RenderBuffer.GetNativeRenderBufferPtr_Injected(ref this);
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00030BB0 File Offset: 0x0002EDB0
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x000059C0 File Offset: 0x00003BC0
		public UnityEngine.Rendering.RenderBufferLoadAction loadAction
		{
			get
			{
				return this.GetLoadAction();
			}
			set
			{
				this.SetLoadAction(value);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00030BC8 File Offset: 0x0002EDC8
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x000059CB File Offset: 0x00003BCB
		public UnityEngine.Rendering.RenderBufferStoreAction storeAction
		{
			get
			{
				return this.GetStoreAction();
			}
			set
			{
				this.SetStoreAction(value);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000059D6 File Offset: 0x00003BD6
		public static void SetLoadAction_Injected(ref RenderBuffer _unity_self, UnityEngine.Rendering.RenderBufferLoadAction action)
		{
			RenderBuffer.SetLoadAction_InjectedDelegateField(ref _unity_self, action);
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000059E4 File Offset: 0x00003BE4
		public static void SetStoreAction_Injected(ref RenderBuffer _unity_self, UnityEngine.Rendering.RenderBufferStoreAction action)
		{
			RenderBuffer.SetStoreAction_InjectedDelegateField(ref _unity_self, action);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000059F2 File Offset: 0x00003BF2
		public static UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction_Injected(ref RenderBuffer _unity_self)
		{
			return RenderBuffer.GetLoadAction_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000059FF File Offset: 0x00003BFF
		public static UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction_Injected(ref RenderBuffer _unity_self)
		{
			return RenderBuffer.GetStoreAction_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00005A0C File Offset: 0x00003C0C
		public static IntPtr GetNativeRenderBufferPtr_Injected(ref RenderBuffer _unity_self)
		{
			return RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderTextureInstanceID;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferPtr;

		// Token: 0x04000686 RID: 1670
		[FieldOffset(0)]
		public int m_RenderTextureInstanceID;

		// Token: 0x04000687 RID: 1671
		[FieldOffset(8)]
		public IntPtr m_BufferPtr;

		// Token: 0x04000688 RID: 1672
		private static readonly RenderBuffer.SetLoadAction_InjectedDelegate SetLoadAction_InjectedDelegateField;

		// Token: 0x04000689 RID: 1673
		private static readonly RenderBuffer.SetStoreAction_InjectedDelegate SetStoreAction_InjectedDelegateField;

		// Token: 0x0400068A RID: 1674
		private static readonly RenderBuffer.GetLoadAction_InjectedDelegate GetLoadAction_InjectedDelegateField;

		// Token: 0x0400068B RID: 1675
		private static readonly RenderBuffer.GetStoreAction_InjectedDelegate GetStoreAction_InjectedDelegateField;

		// Token: 0x0400068C RID: 1676
		private static readonly RenderBuffer.GetNativeRenderBufferPtr_InjectedDelegate GetNativeRenderBufferPtr_InjectedDelegateField;

		// Token: 0x02000524 RID: 1316
		// (Invoke) Token: 0x06003302 RID: 13058
		private delegate void SetLoadAction_InjectedDelegate(IntPtr _unity_self, UnityEngine.Rendering.RenderBufferLoadAction action);

		// Token: 0x02000525 RID: 1317
		// (Invoke) Token: 0x06003304 RID: 13060
		private delegate void SetStoreAction_InjectedDelegate(IntPtr _unity_self, UnityEngine.Rendering.RenderBufferStoreAction action);

		// Token: 0x02000526 RID: 1318
		// (Invoke) Token: 0x06003306 RID: 13062
		private delegate UnityEngine.Rendering.RenderBufferLoadAction GetLoadAction_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000527 RID: 1319
		// (Invoke) Token: 0x06003308 RID: 13064
		private delegate UnityEngine.Rendering.RenderBufferStoreAction GetStoreAction_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000528 RID: 1320
		// (Invoke) Token: 0x0600330A RID: 13066
		private delegate IntPtr GetNativeRenderBufferPtr_InjectedDelegate(IntPtr _unity_self);
	}
}

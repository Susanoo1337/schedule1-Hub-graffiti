using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000206 RID: 518
	public class OnDemandRendering : Object
	{
		// Token: 0x060021F9 RID: 8697 RVA: 0x000899E8 File Offset: 0x00087BE8
		// Note: this type is marked as 'beforefieldinit'.
		static OnDemandRendering()
		{
			Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "OnDemandRendering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr);
			OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, "m_RenderFrameInterval");
			OnDemandRendering.NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100667023);
			OnDemandRendering.NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100667024);
			OnDemandRendering.GetEffectiveRenderFrameRateDelegateField = IL2CPP.ResolveICall<OnDemandRendering.GetEffectiveRenderFrameRateDelegate>("UnityEngine.Rendering.OnDemandRendering::GetEffectiveRenderFrameRate");
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x00089A64 File Offset: 0x00087C64
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x0000F877 File Offset: 0x0000DA77
		public unsafe static int renderFrameInterval
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288077, XrefRangeEnd = 1288081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandRendering.NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				OnDemandRendering.m_RenderFrameInterval = Math.Max(1, value);
			}
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00089A94 File Offset: 0x00087C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288081, XrefRangeEnd = 1288088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRenderFrameInterval(out int frameInterval)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &frameInterval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandRendering.NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x0000F860 File Offset: 0x0000DA60
		public OnDemandRendering(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x00089AC8 File Offset: 0x00087CC8
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x0000F869 File Offset: 0x0000DA69
		public unsafe static int m_RenderFrameInterval
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval, (void*)(&value));
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x00089AE4 File Offset: 0x00087CE4
		public static bool willCurrentFrameRender
		{
			get
			{
				return Time.frameCount % OnDemandRendering.renderFrameInterval == 0;
			}
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x0000F886 File Offset: 0x0000DA86
		public static float GetEffectiveRenderFrameRate()
		{
			return OnDemandRendering.GetEffectiveRenderFrameRateDelegateField();
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x00089B04 File Offset: 0x00087D04
		public static int effectiveRenderFrameRate
		{
			get
			{
				float effectiveRenderFrameRate = OnDemandRendering.GetEffectiveRenderFrameRate();
				bool flag = (double)effectiveRenderFrameRate <= 0.0;
				int result;
				if (flag)
				{
					result = (int)effectiveRenderFrameRate;
				}
				else
				{
					result = (int)(effectiveRenderFrameRate + 0.5f);
				}
				return result;
			}
		}

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderFrameInterval;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0;

		// Token: 0x04001CD4 RID: 7380
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0;

		// Token: 0x04001CD5 RID: 7381
		private static readonly OnDemandRendering.GetEffectiveRenderFrameRateDelegate GetEffectiveRenderFrameRateDelegateField;

		// Token: 0x02000AF0 RID: 2800
		// (Invoke) Token: 0x06003EC6 RID: 16070
		private delegate float GetEffectiveRenderFrameRateDelegate();
	}
}

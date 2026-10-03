using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000234 RID: 564
	[StructLayout(2)]
	public struct RenderStateBlock
	{
		// Token: 0x06002664 RID: 9828 RVA: 0x000987F4 File Offset: 0x000969F4
		// Note: this type is marked as 'beforefieldinit'.
		static RenderStateBlock()
		{
			Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderStateBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr);
			RenderStateBlock.NativeFieldInfoPtr_m_BlendState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_BlendState");
			RenderStateBlock.NativeFieldInfoPtr_m_RasterState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_RasterState");
			RenderStateBlock.NativeFieldInfoPtr_m_DepthState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_DepthState");
			RenderStateBlock.NativeFieldInfoPtr_m_StencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_StencilState");
			RenderStateBlock.NativeFieldInfoPtr_m_StencilReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_StencilReference");
			RenderStateBlock.NativeFieldInfoPtr_m_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, "m_Mask");
			RenderStateBlock.NativeMethodInfoPtr__ctor_Public_Void_RenderStateMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667413);
			RenderStateBlock.NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667414);
			RenderStateBlock.NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667415);
			RenderStateBlock.NativeMethodInfoPtr_get_depthState_Public_get_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667416);
			RenderStateBlock.NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667417);
			RenderStateBlock.NativeMethodInfoPtr_get_stencilState_Public_get_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667418);
			RenderStateBlock.NativeMethodInfoPtr_set_stencilState_Public_set_Void_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667419);
			RenderStateBlock.NativeMethodInfoPtr_get_stencilReference_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667420);
			RenderStateBlock.NativeMethodInfoPtr_set_stencilReference_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667421);
			RenderStateBlock.NativeMethodInfoPtr_get_mask_Public_get_RenderStateMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667422);
			RenderStateBlock.NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667423);
			RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667424);
			RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667425);
			RenderStateBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100667426);
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000989B4 File Offset: 0x00096BB4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1291147, RefRangeEnd = 1291153, XrefRangeStart = 1291137, XrefRangeEnd = 1291147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderStateBlock(RenderStateMask mask)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr__ctor_Public_Void_RenderStateMask_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x00098C94 File Offset: 0x00096E94
		// (set) Token: 0x06002666 RID: 9830 RVA: 0x000989E8 File Offset: 0x00096BE8
		public unsafe BlendState blendState
		{
			get
			{
				return this.m_BlendState;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1291153, RefRangeEnd = 1291154, XrefRangeStart = 1291153, XrefRangeEnd = 1291153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002675 RID: 9845 RVA: 0x00098CAC File Offset: 0x00096EAC
		// (set) Token: 0x06002667 RID: 9831 RVA: 0x00098A1C File Offset: 0x00096C1C
		public unsafe RasterState rasterState
		{
			get
			{
				return this.m_RasterState;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1291154, RefRangeEnd = 1291155, XrefRangeStart = 1291154, XrefRangeEnd = 1291154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x00098A50 File Offset: 0x00096C50
		// (set) Token: 0x06002669 RID: 9833 RVA: 0x00098A80 File Offset: 0x00096C80
		public unsafe DepthState depthState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1291155, RefRangeEnd = 1291156, XrefRangeStart = 1291155, XrefRangeEnd = 1291155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_get_depthState_Public_get_DepthState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1291156, RefRangeEnd = 1291159, XrefRangeStart = 1291156, XrefRangeEnd = 1291156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x0600266A RID: 9834 RVA: 0x00098AB4 File Offset: 0x00096CB4
		// (set) Token: 0x0600266B RID: 9835 RVA: 0x00098AE4 File Offset: 0x00096CE4
		public unsafe StencilState stencilState
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1291159, RefRangeEnd = 1291161, XrefRangeStart = 1291159, XrefRangeEnd = 1291159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_get_stencilState_Public_get_StencilState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1291161, RefRangeEnd = 1291167, XrefRangeStart = 1291161, XrefRangeEnd = 1291161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_stencilState_Public_set_Void_StencilState_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600266C RID: 9836 RVA: 0x00098B18 File Offset: 0x00096D18
		// (set) Token: 0x0600266D RID: 9837 RVA: 0x00098B48 File Offset: 0x00096D48
		public unsafe int stencilReference
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1291167, RefRangeEnd = 1291168, XrefRangeStart = 1291167, XrefRangeEnd = 1291167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_get_stencilReference_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 399906, RefRangeEnd = 399911, XrefRangeStart = 399906, XrefRangeEnd = 399911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_stencilReference_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x00098B7C File Offset: 0x00096D7C
		// (set) Token: 0x0600266F RID: 9839 RVA: 0x00098BAC File Offset: 0x00096DAC
		public unsafe RenderStateMask mask
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1291168, RefRangeEnd = 1291175, XrefRangeStart = 1291168, XrefRangeEnd = 1291168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_get_mask_Public_get_RenderStateMask_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 63934, RefRangeEnd = 63943, XrefRangeStart = 63934, XrefRangeEnd = 63943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00098BE0 File Offset: 0x00096DE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1291182, RefRangeEnd = 1291183, XrefRangeStart = 1291175, XrefRangeEnd = 1291182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(RenderStateBlock other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00098C20 File Offset: 0x00096E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291183, XrefRangeEnd = 1291187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00098C64 File Offset: 0x00096E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291187, XrefRangeEnd = 1291194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x000117AC File Offset: 0x0000F9AC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, ref this));
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00098CC4 File Offset: 0x00096EC4
		public static bool operator ==(RenderStateBlock left, RenderStateBlock right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00098CE0 File Offset: 0x00096EE0
		public static bool operator !=(RenderStateBlock left, RenderStateBlock right)
		{
			return !left.Equals(right);
		}

		// Token: 0x040020C8 RID: 8392
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendState;

		// Token: 0x040020C9 RID: 8393
		private static readonly IntPtr NativeFieldInfoPtr_m_RasterState;

		// Token: 0x040020CA RID: 8394
		private static readonly IntPtr NativeFieldInfoPtr_m_DepthState;

		// Token: 0x040020CB RID: 8395
		private static readonly IntPtr NativeFieldInfoPtr_m_StencilState;

		// Token: 0x040020CC RID: 8396
		private static readonly IntPtr NativeFieldInfoPtr_m_StencilReference;

		// Token: 0x040020CD RID: 8397
		private static readonly IntPtr NativeFieldInfoPtr_m_Mask;

		// Token: 0x040020CE RID: 8398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderStateMask_0;

		// Token: 0x040020CF RID: 8399
		private static readonly IntPtr NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0;

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0;

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeMethodInfoPtr_get_depthState_Public_get_DepthState_0;

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeMethodInfoPtr_get_stencilState_Public_get_StencilState_0;

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeMethodInfoPtr_set_stencilState_Public_set_Void_StencilState_0;

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeMethodInfoPtr_get_stencilReference_Public_get_Int32_0;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeMethodInfoPtr_set_stencilReference_Public_set_Void_Int32_0;

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeMethodInfoPtr_get_mask_Public_get_RenderStateMask_0;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0;

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040020DB RID: 8411
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040020DC RID: 8412
		[FieldOffset(0)]
		public BlendState m_BlendState;

		// Token: 0x040020DD RID: 8413
		[FieldOffset(68)]
		public RasterState m_RasterState;

		// Token: 0x040020DE RID: 8414
		[FieldOffset(84)]
		public DepthState m_DepthState;

		// Token: 0x040020DF RID: 8415
		[FieldOffset(86)]
		public StencilState m_StencilState;

		// Token: 0x040020E0 RID: 8416
		[FieldOffset(100)]
		public int m_StencilReference;

		// Token: 0x040020E1 RID: 8417
		[FieldOffset(104)]
		public RenderStateMask m_Mask;
	}
}

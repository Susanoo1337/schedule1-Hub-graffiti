using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000213 RID: 531
	[StructLayout(2)]
	public struct BatchFilterSettings
	{
		// Token: 0x06002434 RID: 9268 RVA: 0x00091A68 File Offset: 0x0008FC68
		// Note: this type is marked as 'beforefieldinit'.
		static BatchFilterSettings()
		{
			Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchFilterSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr);
			BatchFilterSettings.NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "renderingLayerMask");
			BatchFilterSettings.NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "layer");
			BatchFilterSettings.NativeFieldInfoPtr_m_motionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_motionMode");
			BatchFilterSettings.NativeFieldInfoPtr_m_shadowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_shadowMode");
			BatchFilterSettings.NativeFieldInfoPtr_m_receiveShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_receiveShadows");
			BatchFilterSettings.NativeFieldInfoPtr_m_staticShadowCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_staticShadowCaster");
			BatchFilterSettings.NativeFieldInfoPtr_m_allDepthSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, "m_allDepthSorted");
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x00010AE1 File Offset: 0x0000ECE1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002436 RID: 9270 RVA: 0x00010AF3 File Offset: 0x0000ECF3
		// (set) Token: 0x06002437 RID: 9271 RVA: 0x00010AFB File Offset: 0x0000ECFB
		public MotionVectorGenerationMode motionMode
		{
			get
			{
				return (MotionVectorGenerationMode)this.m_motionMode;
			}
			set
			{
				this.m_motionMode = (byte)value;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x00010B05 File Offset: 0x0000ED05
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x00010B0D File Offset: 0x0000ED0D
		public ShadowCastingMode shadowCastingMode
		{
			get
			{
				return (ShadowCastingMode)this.m_shadowMode;
			}
			set
			{
				this.m_shadowMode = (byte)value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x00010B17 File Offset: 0x0000ED17
		// (set) Token: 0x0600243B RID: 9275 RVA: 0x00010B22 File Offset: 0x0000ED22
		public bool receiveShadows
		{
			get
			{
				return this.m_receiveShadows > 0;
			}
			set
			{
				this.m_receiveShadows = (value ? 1 : 0);
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x00010B32 File Offset: 0x0000ED32
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x00010B3D File Offset: 0x0000ED3D
		public bool staticShadowCaster
		{
			get
			{
				return this.m_staticShadowCaster > 0;
			}
			set
			{
				this.m_staticShadowCaster = (value ? 1 : 0);
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600243E RID: 9278 RVA: 0x00010B4D File Offset: 0x0000ED4D
		// (set) Token: 0x0600243F RID: 9279 RVA: 0x00010B58 File Offset: 0x0000ED58
		public bool allDepthSorted
		{
			get
			{
				return this.m_allDepthSorted > 0;
			}
			set
			{
				this.m_allDepthSorted = (value ? 1 : 0);
			}
		}

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeFieldInfoPtr_renderingLayerMask;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeFieldInfoPtr_layer;

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeFieldInfoPtr_m_motionMode;

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeFieldInfoPtr_m_shadowMode;

		// Token: 0x04001E4D RID: 7757
		private static readonly IntPtr NativeFieldInfoPtr_m_receiveShadows;

		// Token: 0x04001E4E RID: 7758
		private static readonly IntPtr NativeFieldInfoPtr_m_staticShadowCaster;

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeFieldInfoPtr_m_allDepthSorted;

		// Token: 0x04001E50 RID: 7760
		[FieldOffset(0)]
		public uint renderingLayerMask;

		// Token: 0x04001E51 RID: 7761
		[FieldOffset(4)]
		public byte layer;

		// Token: 0x04001E52 RID: 7762
		[FieldOffset(5)]
		public byte m_motionMode;

		// Token: 0x04001E53 RID: 7763
		[FieldOffset(6)]
		public byte m_shadowMode;

		// Token: 0x04001E54 RID: 7764
		[FieldOffset(7)]
		public byte m_receiveShadows;

		// Token: 0x04001E55 RID: 7765
		[FieldOffset(8)]
		public byte m_staticShadowCaster;

		// Token: 0x04001E56 RID: 7766
		[FieldOffset(9)]
		public byte m_allDepthSorted;
	}
}

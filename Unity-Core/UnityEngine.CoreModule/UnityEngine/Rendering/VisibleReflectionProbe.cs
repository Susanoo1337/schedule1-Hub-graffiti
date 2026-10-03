using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000243 RID: 579
	[StructLayout(2)]
	public struct VisibleReflectionProbe
	{
		// Token: 0x0600281F RID: 10271 RVA: 0x0009DDA0 File Offset: 0x0009BFA0
		// Note: this type is marked as 'beforefieldinit'.
		static VisibleReflectionProbe()
		{
			Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "VisibleReflectionProbe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr);
			VisibleReflectionProbe.NativeFieldInfoPtr_m_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_Bounds");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_LocalToWorldMatrix");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_HdrData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_HdrData");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_Center");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_BlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_BlendDistance");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_Importance");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_BoxProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_BoxProjection");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_InstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_InstanceId");
			VisibleReflectionProbe.NativeFieldInfoPtr_m_TextureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_TextureId");
			VisibleReflectionProbe.NativeMethodInfoPtr_get_texture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100667609);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_reflectionProbe_Public_get_ReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100667610);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100667611);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100667612);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_hdrData_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100667613);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_blendDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100667614);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_importance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100667615);
			VisibleReflectionProbe.NativeMethodInfoPtr_get_isBoxProjection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100667616);
			VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100667617);
			VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100667618);
			VisibleReflectionProbe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100667619);
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x0009DF60 File Offset: 0x0009C160
		public unsafe Texture texture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1292296, RefRangeEnd = 1292297, XrefRangeStart = 1292291, XrefRangeEnd = 1292296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_texture_Public_get_Texture_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x0009DF94 File Offset: 0x0009C194
		public unsafe ReflectionProbe reflectionProbe
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1292302, RefRangeEnd = 1292305, XrefRangeStart = 1292297, XrefRangeEnd = 1292302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_reflectionProbe_Public_get_ReflectionProbe_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionProbe>(intPtr3) : null;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x0009DFC8 File Offset: 0x0009C1C8
		// (set) Token: 0x0600282C RID: 10284 RVA: 0x00012029 File Offset: 0x00010229
		public unsafe Bounds bounds
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1292305, RefRangeEnd = 1292317, XrefRangeStart = 1292305, XrefRangeEnd = 1292305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Bounds = value;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x0009DFF8 File Offset: 0x0009C1F8
		// (set) Token: 0x0600282D RID: 10285 RVA: 0x00012033 File Offset: 0x00010233
		public unsafe Matrix4x4 localToWorldMatrix
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1292317, RefRangeEnd = 1292320, XrefRangeStart = 1292317, XrefRangeEnd = 1292317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_LocalToWorldMatrix = value;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x0009E028 File Offset: 0x0009C228
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x0001203D File Offset: 0x0001023D
		public unsafe Vector4 hdrData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1292320, RefRangeEnd = 1292322, XrefRangeStart = 1292320, XrefRangeEnd = 1292320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_hdrData_Public_get_Vector4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_HdrData = value;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x0009E058 File Offset: 0x0009C258
		// (set) Token: 0x06002831 RID: 10289 RVA: 0x00012051 File Offset: 0x00010251
		public unsafe float blendDistance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1292322, RefRangeEnd = 1292323, XrefRangeStart = 1292322, XrefRangeEnd = 1292322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_blendDistance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BlendDistance = value;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x0009E088 File Offset: 0x0009C288
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x0001205B File Offset: 0x0001025B
		public unsafe int importance
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1292323, RefRangeEnd = 1292328, XrefRangeStart = 1292323, XrefRangeEnd = 1292323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_importance_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Importance = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06002827 RID: 10279 RVA: 0x0009E0B8 File Offset: 0x0009C2B8
		// (set) Token: 0x06002833 RID: 10291 RVA: 0x00012065 File Offset: 0x00010265
		public unsafe bool isBoxProjection
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1292332, RefRangeEnd = 1292333, XrefRangeStart = 1292328, XrefRangeEnd = 1292332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_get_isBoxProjection_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoxProjection = Convert.ToInt32(value);
			}
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x0009E0E8 File Offset: 0x0009C2E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292336, RefRangeEnd = 1292337, XrefRangeStart = 1292333, XrefRangeEnd = 1292336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(VisibleReflectionProbe other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x0009E128 File Offset: 0x0009C328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292337, XrefRangeEnd = 1292341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x0009E16C File Offset: 0x0009C36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1292341, XrefRangeEnd = 1292356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x00012017 File Offset: 0x00010217
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, ref this));
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x0009E19C File Offset: 0x0009C39C
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x00012047 File Offset: 0x00010247
		public Vector3 center
		{
			get
			{
				return this.m_Center;
			}
			set
			{
				this.m_Center = value;
			}
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x0009E1B4 File Offset: 0x0009C3B4
		public static bool operator ==(VisibleReflectionProbe left, VisibleReflectionProbe right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x0009E1D0 File Offset: 0x0009C3D0
		public static bool operator !=(VisibleReflectionProbe left, VisibleReflectionProbe right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeFieldInfoPtr_m_Bounds;

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalToWorldMatrix;

		// Token: 0x0400223A RID: 8762
		private static readonly IntPtr NativeFieldInfoPtr_m_HdrData;

		// Token: 0x0400223B RID: 8763
		private static readonly IntPtr NativeFieldInfoPtr_m_Center;

		// Token: 0x0400223C RID: 8764
		private static readonly IntPtr NativeFieldInfoPtr_m_BlendDistance;

		// Token: 0x0400223D RID: 8765
		private static readonly IntPtr NativeFieldInfoPtr_m_Importance;

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeFieldInfoPtr_m_BoxProjection;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceId;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeFieldInfoPtr_m_TextureId;

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture_0;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeMethodInfoPtr_get_reflectionProbe_Public_get_ReflectionProbe_0;

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04002244 RID: 8772
		private static readonly IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04002245 RID: 8773
		private static readonly IntPtr NativeMethodInfoPtr_get_hdrData_Public_get_Vector4_0;

		// Token: 0x04002246 RID: 8774
		private static readonly IntPtr NativeMethodInfoPtr_get_blendDistance_Public_get_Single_0;

		// Token: 0x04002247 RID: 8775
		private static readonly IntPtr NativeMethodInfoPtr_get_importance_Public_get_Int32_0;

		// Token: 0x04002248 RID: 8776
		private static readonly IntPtr NativeMethodInfoPtr_get_isBoxProjection_Public_get_Boolean_0;

		// Token: 0x04002249 RID: 8777
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0;

		// Token: 0x0400224A RID: 8778
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400224B RID: 8779
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400224C RID: 8780
		[FieldOffset(0)]
		public Bounds m_Bounds;

		// Token: 0x0400224D RID: 8781
		[FieldOffset(24)]
		public Matrix4x4 m_LocalToWorldMatrix;

		// Token: 0x0400224E RID: 8782
		[FieldOffset(88)]
		public Vector4 m_HdrData;

		// Token: 0x0400224F RID: 8783
		[FieldOffset(104)]
		public Vector3 m_Center;

		// Token: 0x04002250 RID: 8784
		[FieldOffset(116)]
		public float m_BlendDistance;

		// Token: 0x04002251 RID: 8785
		[FieldOffset(120)]
		public int m_Importance;

		// Token: 0x04002252 RID: 8786
		[FieldOffset(124)]
		public int m_BoxProjection;

		// Token: 0x04002253 RID: 8787
		[FieldOffset(128)]
		public int m_InstanceId;

		// Token: 0x04002254 RID: 8788
		[FieldOffset(132)]
		public int m_TextureId;
	}
}

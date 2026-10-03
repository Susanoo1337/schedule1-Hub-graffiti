using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200023A RID: 570
	[StructLayout(2)]
	public struct ShadowSplitData
	{
		// Token: 0x0600271C RID: 10012 RVA: 0x0009B34C File Offset: 0x0009954C
		// Note: this type is marked as 'beforefieldinit'.
		static ShadowSplitData()
		{
			Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShadowSplitData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr);
			ShadowSplitData.NativeFieldInfoPtr_k_MaximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "k_MaximumCullingPlaneCount");
			ShadowSplitData.NativeFieldInfoPtr_maximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "maximumCullingPlaneCount");
			ShadowSplitData.NativeFieldInfoPtr_m_CullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingPlaneCount");
			ShadowSplitData.NativeFieldInfoPtr_m_CullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingPlanes");
			ShadowSplitData.NativeFieldInfoPtr_m_CullingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingSphere");
			ShadowSplitData.NativeFieldInfoPtr_m_ShadowCascadeBlendCullingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_ShadowCascadeBlendCullingFactor");
			ShadowSplitData.NativeFieldInfoPtr_m_CullingNearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingNearPlane");
			ShadowSplitData.NativeFieldInfoPtr_m_CullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingMatrix");
			ShadowSplitData.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100667516);
			ShadowSplitData.NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100667517);
			ShadowSplitData.NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100667518);
			ShadowSplitData.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100667519);
			ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100667520);
			ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100667521);
			ShadowSplitData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100667522);
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x0009B4A8 File Offset: 0x000996A8
		// (set) Token: 0x06002729 RID: 10025 RVA: 0x0009B668 File Offset: 0x00099868
		public unsafe int cullingPlaneCount
		{
			[CallerCount(261)]
			[CachedScanResults(RefRangeStart = 1218881, RefRangeEnd = 1219142, XrefRangeStart = 1218881, XrefRangeEnd = 1219142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value < 0 || value > 10;
				if (flag)
				{
					throw new ArgumentException(String.Format("Value should range from {0} to ShadowSplitData.maximumCullingPlaneCount ({1}), but was {2}.", 0, 10, value));
				}
				this.m_CullingPlaneCount = value;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x0009B4D8 File Offset: 0x000996D8
		// (set) Token: 0x0600272A RID: 10026 RVA: 0x00011A61 File Offset: 0x0000FC61
		public unsafe Vector4 cullingSphere
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1291856, RefRangeEnd = 1291857, XrefRangeStart = 1291856, XrefRangeEnd = 1291856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_CullingSphere = value;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x0009B6E0 File Offset: 0x000998E0
		// (set) Token: 0x0600271F RID: 10015 RVA: 0x0009B508 File Offset: 0x00099708
		public unsafe float shadowCascadeBlendCullingFactor
		{
			get
			{
				return this.m_ShadowCascadeBlendCullingFactor;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1291857, RefRangeEnd = 1291859, XrefRangeStart = 1291857, XrefRangeEnd = 1291857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x0009B53C File Offset: 0x0009973C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291862, RefRangeEnd = 1291864, XrefRangeStart = 1291859, XrefRangeEnd = 1291862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane GetCullingPlane(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x0009B57C File Offset: 0x0009977C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1291877, RefRangeEnd = 1291879, XrefRangeStart = 1291864, XrefRangeEnd = 1291877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ShadowSplitData other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x0009B5BC File Offset: 0x000997BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291879, XrefRangeEnd = 1291885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x0009B600 File Offset: 0x00099800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1291885, XrefRangeEnd = 1291889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00011A33 File Offset: 0x0000FC33
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, ref this));
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x0009B630 File Offset: 0x00099830
		// (set) Token: 0x06002726 RID: 10022 RVA: 0x00011A45 File Offset: 0x0000FC45
		public unsafe static int k_MaximumCullingPlaneCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShadowSplitData.NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowSplitData.NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*)(&value));
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x0009B64C File Offset: 0x0009984C
		// (set) Token: 0x06002728 RID: 10024 RVA: 0x00011A53 File Offset: 0x0000FC53
		public unsafe static int maximumCullingPlaneCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShadowSplitData.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShadowSplitData.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*)(&value));
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x0009B6B0 File Offset: 0x000998B0
		// (set) Token: 0x0600272C RID: 10028 RVA: 0x00011A6B File Offset: 0x0000FC6B
		public Matrix4x4 cullingMatrix
		{
			get
			{
				return this.m_CullingMatrix;
			}
			set
			{
				this.m_CullingMatrix = value;
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x0009B6C8 File Offset: 0x000998C8
		// (set) Token: 0x0600272E RID: 10030 RVA: 0x00011A75 File Offset: 0x0000FC75
		public float cullingNearPlane
		{
			get
			{
				return this.m_CullingNearPlane;
			}
			set
			{
				this.m_CullingNearPlane = value;
			}
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00011A7F File Offset: 0x0000FC7F
		public void SetCullingPlane(int index, Plane plane)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0009B6F8 File Offset: 0x000998F8
		public static bool operator ==(ShadowSplitData left, ShadowSplitData right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0009B714 File Offset: 0x00099914
		public static bool operator !=(ShadowSplitData left, ShadowSplitData right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04002168 RID: 8552
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumCullingPlaneCount;

		// Token: 0x04002169 RID: 8553
		private static readonly IntPtr NativeFieldInfoPtr_maximumCullingPlaneCount;

		// Token: 0x0400216A RID: 8554
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingPlaneCount;

		// Token: 0x0400216B RID: 8555
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingPlanes;

		// Token: 0x0400216C RID: 8556
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingSphere;

		// Token: 0x0400216D RID: 8557
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowCascadeBlendCullingFactor;

		// Token: 0x0400216E RID: 8558
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingNearPlane;

		// Token: 0x0400216F RID: 8559
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingMatrix;

		// Token: 0x04002170 RID: 8560
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0;

		// Token: 0x04002171 RID: 8561
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0;

		// Token: 0x04002172 RID: 8562
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0;

		// Token: 0x04002173 RID: 8563
		private static readonly IntPtr NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0;

		// Token: 0x04002174 RID: 8564
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0;

		// Token: 0x04002175 RID: 8565
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002176 RID: 8566
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002177 RID: 8567
		[FieldOffset(0)]
		public int m_CullingPlaneCount;

		// Token: 0x04002178 RID: 8568
		[FieldOffset(4)]
		public ShadowSplitData._m_CullingPlanes_e__FixedBuffer m_CullingPlanes;

		// Token: 0x04002179 RID: 8569
		[FieldOffset(164)]
		public Vector4 m_CullingSphere;

		// Token: 0x0400217A RID: 8570
		[FieldOffset(180)]
		public float m_ShadowCascadeBlendCullingFactor;

		// Token: 0x0400217B RID: 8571
		[FieldOffset(184)]
		public float m_CullingNearPlane;

		// Token: 0x0400217C RID: 8572
		[FieldOffset(188)]
		public Matrix4x4 m_CullingMatrix;

		// Token: 0x02000B72 RID: 2930
		[ObfuscatedName("UnityEngine.Rendering.ShadowSplitData+<m_CullingPlanes>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _m_CullingPlanes_e__FixedBuffer
		{
			// Token: 0x06003FD0 RID: 16336 RVA: 0x000186AA File Offset: 0x000168AA
			// Note: this type is marked as 'beforefieldinit'.
			static _m_CullingPlanes_e__FixedBuffer()
			{
				Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "<m_CullingPlanes>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr);
				ShadowSplitData._m_CullingPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003FD1 RID: 16337 RVA: 0x000186DE File Offset: 0x000168DE
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002BE5 RID: 11237
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002BE6 RID: 11238
			[FieldOffset(0)]
			public byte FixedElementField;
		}
	}
}

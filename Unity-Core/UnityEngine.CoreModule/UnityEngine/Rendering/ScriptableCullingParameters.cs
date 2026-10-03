using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000220 RID: 544
	[StructLayout(2)]
	public struct ScriptableCullingParameters
	{
		// Token: 0x060024E4 RID: 9444 RVA: 0x0009367C File Offset: 0x0009187C
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableCullingParameters()
		{
			Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ScriptableCullingParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr);
			ScriptableCullingParameters.NativeFieldInfoPtr_m_IsOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_IsOrthographic");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_LODParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_LODParameters");
			ScriptableCullingParameters.NativeFieldInfoPtr_k_MaximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_MaximumCullingPlaneCount");
			ScriptableCullingParameters.NativeFieldInfoPtr_maximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "maximumCullingPlaneCount");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingPlanes");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingPlaneCount");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingMask");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_SceneMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_SceneMask");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_ViewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ViewID");
			ScriptableCullingParameters.NativeFieldInfoPtr_k_LayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_LayerCount");
			ScriptableCullingParameters.NativeFieldInfoPtr_layerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "layerCount");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_LayerFarCullDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_LayerFarCullDistances");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_LayerCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_LayerCull");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingMatrix");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_Origin");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_ShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ShadowDistance");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_ShadowNearPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ShadowNearPlaneOffset");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingOptions");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_ReflectionProbeSortingCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ReflectionProbeSortingCriteria");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_CameraProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CameraProperties");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_AccurateOcclusionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_AccurateOcclusionThreshold");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_MaximumPortalCullingJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_MaximumPortalCullingJobs");
			ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountLowerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_CullingJobCountLowerLimit");
			ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountUpperLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_CullingJobCountUpperLimit");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_StereoViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_StereoViewMatrix");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_StereoProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_StereoProjectionMatrix");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_StereoSeparationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_StereoSeparationDistance");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_maximumVisibleLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_maximumVisibleLights");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_ConservativeEnclosingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ConservativeEnclosingSphere");
			ScriptableCullingParameters.NativeFieldInfoPtr_m_NumIterationsEnclosingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_NumIterationsEnclosingSphere");
			ScriptableCullingParameters.NativeMethodInfoPtr_set_maximumVisibleLights_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667240);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667241);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667242);
			ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667243);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667244);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667245);
			ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667246);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667247);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_reflectionProbeSortingCriteria_Public_set_Void_ReflectionProbeSortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667248);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoViewMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667249);
			ScriptableCullingParameters.NativeMethodInfoPtr_get_stereoProjectionMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667250);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoProjectionMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667251);
			ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoSeparationDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667252);
			ScriptableCullingParameters.NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667253);
			ScriptableCullingParameters.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667254);
			ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667255);
			ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667256);
			ScriptableCullingParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100667257);
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06002504 RID: 9476 RVA: 0x00093EE0 File Offset: 0x000920E0
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x00093A6C File Offset: 0x00091C6C
		public unsafe int maximumVisibleLights
		{
			get
			{
				return this.m_maximumVisibleLights;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1290253, RefRangeEnd = 1290255, XrefRangeStart = 1290253, XrefRangeEnd = 1290253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_maximumVisibleLights_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06002505 RID: 9477 RVA: 0x00093EF8 File Offset: 0x000920F8
		// (set) Token: 0x060024E6 RID: 9446 RVA: 0x00093AA0 File Offset: 0x00091CA0
		public unsafe bool conservativeEnclosingSphere
		{
			get
			{
				return this.m_ConservativeEnclosingSphere;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290255, RefRangeEnd = 1290256, XrefRangeStart = 1290255, XrefRangeEnd = 1290255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06002506 RID: 9478 RVA: 0x00093F10 File Offset: 0x00092110
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x00093AD4 File Offset: 0x00091CD4
		public unsafe int numIterationsEnclosingSphere
		{
			get
			{
				return this.m_NumIterationsEnclosingSphere;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290256, RefRangeEnd = 1290257, XrefRangeStart = 1290256, XrefRangeEnd = 1290256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x00093B08 File Offset: 0x00091D08
		// (set) Token: 0x06002507 RID: 9479 RVA: 0x00093F28 File Offset: 0x00092128
		public unsafe int cullingPlaneCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290257, RefRangeEnd = 1290258, XrefRangeStart = 1290257, XrefRangeEnd = 1290257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value < 0 || value > 10;
				if (flag)
				{
					throw new ArgumentOutOfRangeException(String.Format("{0} was {1}, but must be at least 0 and less than {2}", "value", value, 10));
				}
				this.m_CullingPlaneCount = value;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x00093F70 File Offset: 0x00092170
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x00093B38 File Offset: 0x00091D38
		public unsafe bool isOrthographic
		{
			get
			{
				return Convert.ToBoolean(this.m_IsOrthographic);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290262, RefRangeEnd = 1290263, XrefRangeStart = 1290258, XrefRangeEnd = 1290262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x00093FF0 File Offset: 0x000921F0
		// (set) Token: 0x060024EA RID: 9450 RVA: 0x00093B6C File Offset: 0x00091D6C
		public unsafe float shadowDistance
		{
			get
			{
				return this.m_ShadowDistance;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1290263, RefRangeEnd = 1290265, XrefRangeStart = 1290263, XrefRangeEnd = 1290263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x00093BA0 File Offset: 0x00091DA0
		// (set) Token: 0x060024EC RID: 9452 RVA: 0x00093BD0 File Offset: 0x00091DD0
		public unsafe CullingOptions cullingOptions
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1290265, RefRangeEnd = 1290271, XrefRangeStart = 1290265, XrefRangeEnd = 1290265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 263230, RefRangeEnd = 263237, XrefRangeStart = 263230, XrefRangeEnd = 263237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x00094020 File Offset: 0x00092220
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x00093C04 File Offset: 0x00091E04
		public unsafe ReflectionProbeSortingCriteria reflectionProbeSortingCriteria
		{
			get
			{
				return this.m_ReflectionProbeSortingCriteria;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290271, RefRangeEnd = 1290272, XrefRangeStart = 1290271, XrefRangeEnd = 1290271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_reflectionProbeSortingCriteria_Public_set_Void_ReflectionProbeSortingCriteria_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x00094050 File Offset: 0x00092250
		// (set) Token: 0x060024EE RID: 9454 RVA: 0x00093C38 File Offset: 0x00091E38
		public unsafe Matrix4x4 stereoViewMatrix
		{
			get
			{
				return this.m_StereoViewMatrix;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290272, RefRangeEnd = 1290273, XrefRangeStart = 1290272, XrefRangeEnd = 1290272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoViewMatrix_Public_set_Void_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x00093C6C File Offset: 0x00091E6C
		// (set) Token: 0x060024F0 RID: 9456 RVA: 0x00093C9C File Offset: 0x00091E9C
		public unsafe Matrix4x4 stereoProjectionMatrix
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_get_stereoProjectionMatrix_Public_get_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290273, RefRangeEnd = 1290274, XrefRangeStart = 1290273, XrefRangeEnd = 1290273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoProjectionMatrix_Public_set_Void_Matrix4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x00094068 File Offset: 0x00092268
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x00093CD0 File Offset: 0x00091ED0
		public unsafe float stereoSeparationDistance
		{
			get
			{
				return this.m_StereoSeparationDistance;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290274, RefRangeEnd = 1290275, XrefRangeStart = 1290274, XrefRangeEnd = 1290274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_stereoSeparationDistance_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00093D04 File Offset: 0x00091F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290275, RefRangeEnd = 1290277, XrefRangeStart = 1290275, XrefRangeEnd = 1290275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetLayerCullingDistance(int layerIndex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref layerIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00093D44 File Offset: 0x00091F44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1290280, RefRangeEnd = 1290283, XrefRangeStart = 1290277, XrefRangeEnd = 1290280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane GetCullingPlane(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00093D84 File Offset: 0x00091F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290301, RefRangeEnd = 1290302, XrefRangeStart = 1290283, XrefRangeEnd = 1290301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ScriptableCullingParameters other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x00093DC4 File Offset: 0x00091FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290302, XrefRangeEnd = 1290309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00093E08 File Offset: 0x00092008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290309, XrefRangeEnd = 1290329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x000110FD File Offset: 0x0000F2FD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, ref this));
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x00093E38 File Offset: 0x00092038
		// (set) Token: 0x060024F9 RID: 9465 RVA: 0x0001110F File Offset: 0x0000F30F
		public unsafe static int k_MaximumCullingPlaneCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*)(&value));
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060024FA RID: 9466 RVA: 0x00093E54 File Offset: 0x00092054
		// (set) Token: 0x060024FB RID: 9467 RVA: 0x0001111D File Offset: 0x0000F31D
		public unsafe static int maximumCullingPlaneCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*)(&value));
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060024FC RID: 9468 RVA: 0x00093E70 File Offset: 0x00092070
		// (set) Token: 0x060024FD RID: 9469 RVA: 0x0001112B File Offset: 0x0000F32B
		public unsafe static int k_LayerCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_LayerCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_LayerCount, (void*)(&value));
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x00093E8C File Offset: 0x0009208C
		// (set) Token: 0x060024FF RID: 9471 RVA: 0x00011139 File Offset: 0x0000F339
		public unsafe static int layerCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_layerCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_layerCount, (void*)(&value));
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x00093EA8 File Offset: 0x000920A8
		// (set) Token: 0x06002501 RID: 9473 RVA: 0x00011147 File Offset: 0x0000F347
		public unsafe static int k_CullingJobCountLowerLimit
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountLowerLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountLowerLimit, (void*)(&value));
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06002502 RID: 9474 RVA: 0x00093EC4 File Offset: 0x000920C4
		// (set) Token: 0x06002503 RID: 9475 RVA: 0x00011155 File Offset: 0x0000F355
		public unsafe static int k_CullingJobCountUpperLimit
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountUpperLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_k_CullingJobCountUpperLimit, (void*)(&value));
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x00093F90 File Offset: 0x00092190
		// (set) Token: 0x0600250A RID: 9482 RVA: 0x00011163 File Offset: 0x0000F363
		public LODParameters lodParameters
		{
			get
			{
				return this.m_LODParameters;
			}
			set
			{
				this.m_LODParameters = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x0600250B RID: 9483 RVA: 0x00093FA8 File Offset: 0x000921A8
		// (set) Token: 0x0600250C RID: 9484 RVA: 0x0001116D File Offset: 0x0000F36D
		public uint cullingMask
		{
			get
			{
				return this.m_CullingMask;
			}
			set
			{
				this.m_CullingMask = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x00093FC0 File Offset: 0x000921C0
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x00011177 File Offset: 0x0000F377
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

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x00093FD8 File Offset: 0x000921D8
		// (set) Token: 0x06002510 RID: 9488 RVA: 0x00011181 File Offset: 0x0000F381
		public Vector3 origin
		{
			get
			{
				return this.m_Origin;
			}
			set
			{
				this.m_Origin = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x00094008 File Offset: 0x00092208
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x0001118B File Offset: 0x0000F38B
		public float shadowNearPlaneOffset
		{
			get
			{
				return this.m_ShadowNearPlaneOffset;
			}
			set
			{
				this.m_ShadowNearPlaneOffset = value;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x00094038 File Offset: 0x00092238
		// (set) Token: 0x06002516 RID: 9494 RVA: 0x00011195 File Offset: 0x0000F395
		public CameraProperties cameraProperties
		{
			get
			{
				return this.m_CameraProperties;
			}
			set
			{
				this.m_CameraProperties = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x00094080 File Offset: 0x00092280
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x0001119F File Offset: 0x0000F39F
		public float accurateOcclusionThreshold
		{
			get
			{
				return this.m_AccurateOcclusionThreshold;
			}
			set
			{
				this.m_AccurateOcclusionThreshold = Mathf.Max(-1f, value);
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x00094098 File Offset: 0x00092298
		// (set) Token: 0x0600251C RID: 9500 RVA: 0x000111B3 File Offset: 0x0000F3B3
		public int maximumPortalCullingJobs
		{
			get
			{
				return this.m_MaximumPortalCullingJobs;
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x000940B0 File Offset: 0x000922B0
		public static int cullingJobsLowerLimit
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x000940C4 File Offset: 0x000922C4
		public static int cullingJobsUpperLimit
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000111C0 File Offset: 0x0000F3C0
		public void SetLayerCullingDistance(int layerIndex, float distance)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000111CD File Offset: 0x0000F3CD
		public void SetCullingPlane(int index, Plane plane)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x000940D8 File Offset: 0x000922D8
		public static bool operator ==(ScriptableCullingParameters left, ScriptableCullingParameters right)
		{
			return left.Equals(right);
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x000940F4 File Offset: 0x000922F4
		public static bool operator !=(ScriptableCullingParameters left, ScriptableCullingParameters right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeFieldInfoPtr_m_IsOrthographic;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeFieldInfoPtr_m_LODParameters;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumCullingPlaneCount;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeFieldInfoPtr_maximumCullingPlaneCount;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingPlanes;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingPlaneCount;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingMask;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeFieldInfoPtr_m_SceneMask;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeFieldInfoPtr_m_ViewID;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeFieldInfoPtr_k_LayerCount;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeFieldInfoPtr_layerCount;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeFieldInfoPtr_m_LayerFarCullDistances;

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeFieldInfoPtr_m_LayerCull;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingMatrix;

		// Token: 0x04001F60 RID: 8032
		private static readonly IntPtr NativeFieldInfoPtr_m_Origin;

		// Token: 0x04001F61 RID: 8033
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowDistance;

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowNearPlaneOffset;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingOptions;

		// Token: 0x04001F64 RID: 8036
		private static readonly IntPtr NativeFieldInfoPtr_m_ReflectionProbeSortingCriteria;

		// Token: 0x04001F65 RID: 8037
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraProperties;

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeFieldInfoPtr_m_AccurateOcclusionThreshold;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeFieldInfoPtr_m_MaximumPortalCullingJobs;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeFieldInfoPtr_k_CullingJobCountLowerLimit;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeFieldInfoPtr_k_CullingJobCountUpperLimit;

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeFieldInfoPtr_m_StereoViewMatrix;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeFieldInfoPtr_m_StereoProjectionMatrix;

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeFieldInfoPtr_m_StereoSeparationDistance;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeFieldInfoPtr_m_maximumVisibleLights;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeFieldInfoPtr_m_ConservativeEnclosingSphere;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeFieldInfoPtr_m_NumIterationsEnclosingSphere;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeMethodInfoPtr_set_maximumVisibleLights_Public_set_Void_Int32_0;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0;

		// Token: 0x04001F72 RID: 8050
		private static readonly IntPtr NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0;

		// Token: 0x04001F73 RID: 8051
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0;

		// Token: 0x04001F74 RID: 8052
		private static readonly IntPtr NativeMethodInfoPtr_set_isOrthographic_Public_set_Void_Boolean_0;

		// Token: 0x04001F75 RID: 8053
		private static readonly IntPtr NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0;

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0;

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeMethodInfoPtr_set_reflectionProbeSortingCriteria_Public_set_Void_ReflectionProbeSortingCriteria_0;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoViewMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoProjectionMatrix_Public_get_Matrix4x4_0;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoProjectionMatrix_Public_set_Void_Matrix4x4_0;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeMethodInfoPtr_set_stereoSeparationDistance_Public_set_Void_Single_0;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001F82 RID: 8066
		[FieldOffset(0)]
		public int m_IsOrthographic;

		// Token: 0x04001F83 RID: 8067
		[FieldOffset(4)]
		public LODParameters m_LODParameters;

		// Token: 0x04001F84 RID: 8068
		[FieldOffset(32)]
		public ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer m_CullingPlanes;

		// Token: 0x04001F85 RID: 8069
		[FieldOffset(192)]
		public int m_CullingPlaneCount;

		// Token: 0x04001F86 RID: 8070
		[FieldOffset(196)]
		public uint m_CullingMask;

		// Token: 0x04001F87 RID: 8071
		[FieldOffset(200)]
		public ulong m_SceneMask;

		// Token: 0x04001F88 RID: 8072
		[FieldOffset(208)]
		public ulong m_ViewID;

		// Token: 0x04001F89 RID: 8073
		[FieldOffset(216)]
		public ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer m_LayerFarCullDistances;

		// Token: 0x04001F8A RID: 8074
		[FieldOffset(344)]
		public int m_LayerCull;

		// Token: 0x04001F8B RID: 8075
		[FieldOffset(348)]
		public Matrix4x4 m_CullingMatrix;

		// Token: 0x04001F8C RID: 8076
		[FieldOffset(412)]
		public Vector3 m_Origin;

		// Token: 0x04001F8D RID: 8077
		[FieldOffset(424)]
		public float m_ShadowDistance;

		// Token: 0x04001F8E RID: 8078
		[FieldOffset(428)]
		public float m_ShadowNearPlaneOffset;

		// Token: 0x04001F8F RID: 8079
		[FieldOffset(432)]
		public CullingOptions m_CullingOptions;

		// Token: 0x04001F90 RID: 8080
		[FieldOffset(436)]
		public ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria;

		// Token: 0x04001F91 RID: 8081
		[FieldOffset(440)]
		public CameraProperties m_CameraProperties;

		// Token: 0x04001F92 RID: 8082
		[FieldOffset(1432)]
		public float m_AccurateOcclusionThreshold;

		// Token: 0x04001F93 RID: 8083
		[FieldOffset(1436)]
		public int m_MaximumPortalCullingJobs;

		// Token: 0x04001F94 RID: 8084
		[FieldOffset(1440)]
		public Matrix4x4 m_StereoViewMatrix;

		// Token: 0x04001F95 RID: 8085
		[FieldOffset(1504)]
		public Matrix4x4 m_StereoProjectionMatrix;

		// Token: 0x04001F96 RID: 8086
		[FieldOffset(1568)]
		public float m_StereoSeparationDistance;

		// Token: 0x04001F97 RID: 8087
		[FieldOffset(1572)]
		public int m_maximumVisibleLights;

		// Token: 0x04001F98 RID: 8088
		[FieldOffset(1576)]
		[MarshalAs(4)]
		public bool m_ConservativeEnclosingSphere;

		// Token: 0x04001F99 RID: 8089
		[FieldOffset(1580)]
		public int m_NumIterationsEnclosingSphere;

		// Token: 0x02000B5F RID: 2911
		[ObfuscatedName("UnityEngine.Rendering.ScriptableCullingParameters+<m_CullingPlanes>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _m_CullingPlanes_e__FixedBuffer
		{
			// Token: 0x06003FA8 RID: 16296 RVA: 0x0001855F File Offset: 0x0001675F
			// Note: this type is marked as 'beforefieldinit'.
			static _m_CullingPlanes_e__FixedBuffer()
			{
				Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "<m_CullingPlanes>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr);
				ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003FA9 RID: 16297 RVA: 0x00018593 File Offset: 0x00016793
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002BD3 RID: 11219
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002BD4 RID: 11220
			[FieldOffset(0)]
			public byte FixedElementField;
		}

		// Token: 0x02000B60 RID: 2912
		[ObfuscatedName("UnityEngine.Rendering.ScriptableCullingParameters+<m_LayerFarCullDistances>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _m_LayerFarCullDistances_e__FixedBuffer
		{
			// Token: 0x06003FAA RID: 16298 RVA: 0x000185A5 File Offset: 0x000167A5
			// Note: this type is marked as 'beforefieldinit'.
			static _m_LayerFarCullDistances_e__FixedBuffer()
			{
				Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "<m_LayerFarCullDistances>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr);
				ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003FAB RID: 16299 RVA: 0x000185D9 File Offset: 0x000167D9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002BD5 RID: 11221
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002BD6 RID: 11222
			[FieldOffset(0)]
			public float FixedElementField;
		}
	}
}

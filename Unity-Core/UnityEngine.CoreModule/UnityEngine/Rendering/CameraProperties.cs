using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200021E RID: 542
	[StructLayout(2)]
	public struct CameraProperties
	{
		// Token: 0x060024D5 RID: 9429 RVA: 0x00093198 File Offset: 0x00091398
		// Note: this type is marked as 'beforefieldinit'.
		static CameraProperties()
		{
			Il2CppClassPointerStore<CameraProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CameraProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr);
			CameraProperties.NativeFieldInfoPtr_k_NumLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "k_NumLayers");
			CameraProperties.NativeFieldInfoPtr_screenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "screenRect");
			CameraProperties.NativeFieldInfoPtr_viewDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "viewDir");
			CameraProperties.NativeFieldInfoPtr_projectionNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "projectionNear");
			CameraProperties.NativeFieldInfoPtr_projectionFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "projectionFar");
			CameraProperties.NativeFieldInfoPtr_cameraNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraNear");
			CameraProperties.NativeFieldInfoPtr_cameraFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraFar");
			CameraProperties.NativeFieldInfoPtr_cameraAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraAspect");
			CameraProperties.NativeFieldInfoPtr_cameraToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraToWorld");
			CameraProperties.NativeFieldInfoPtr_actualWorldToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "actualWorldToClip");
			CameraProperties.NativeFieldInfoPtr_cameraClipToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraClipToWorld");
			CameraProperties.NativeFieldInfoPtr_cameraWorldToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraWorldToClip");
			CameraProperties.NativeFieldInfoPtr_implicitProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "implicitProjection");
			CameraProperties.NativeFieldInfoPtr_stereoWorldToClipLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "stereoWorldToClipLeft");
			CameraProperties.NativeFieldInfoPtr_stereoWorldToClipRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "stereoWorldToClipRight");
			CameraProperties.NativeFieldInfoPtr_worldToCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "worldToCamera");
			CameraProperties.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "up");
			CameraProperties.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "right");
			CameraProperties.NativeFieldInfoPtr_transformDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "transformDirection");
			CameraProperties.NativeFieldInfoPtr_cameraEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraEuler");
			CameraProperties.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "velocity");
			CameraProperties.NativeFieldInfoPtr_farPlaneWorldSpaceLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "farPlaneWorldSpaceLength");
			CameraProperties.NativeFieldInfoPtr_rendererCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "rendererCount");
			CameraProperties.NativeFieldInfoPtr_k_PlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "k_PlaneCount");
			CameraProperties.NativeFieldInfoPtr_m_ShadowCullPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "m_ShadowCullPlanes");
			CameraProperties.NativeFieldInfoPtr_m_CameraCullPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "m_CameraCullPlanes");
			CameraProperties.NativeFieldInfoPtr_baseFarDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "baseFarDistance");
			CameraProperties.NativeFieldInfoPtr_shadowCullCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "shadowCullCenter");
			CameraProperties.NativeFieldInfoPtr_layerCullDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "layerCullDistances");
			CameraProperties.NativeFieldInfoPtr_layerCullSpherical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "layerCullSpherical");
			CameraProperties.NativeFieldInfoPtr_coreCameraValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "coreCameraValues");
			CameraProperties.NativeFieldInfoPtr_cameraType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraType");
			CameraProperties.NativeFieldInfoPtr_projectionIsOblique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "projectionIsOblique");
			CameraProperties.NativeFieldInfoPtr_isImplicitProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "isImplicitProjectionMatrix");
			CameraProperties.NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100667235);
			CameraProperties.NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100667236);
			CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100667237);
			CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100667238);
			CameraProperties.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100667239);
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x000934D4 File Offset: 0x000916D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1290162, RefRangeEnd = 1290165, XrefRangeStart = 1290162, XrefRangeEnd = 1290162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane GetShadowCullingPlane(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00093514 File Offset: 0x00091714
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1290165, RefRangeEnd = 1290168, XrefRangeStart = 1290165, XrefRangeEnd = 1290165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane GetCameraCullingPlane(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00093554 File Offset: 0x00091754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290202, RefRangeEnd = 1290203, XrefRangeStart = 1290168, XrefRangeEnd = 1290202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CameraProperties other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x00093594 File Offset: 0x00091794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290203, XrefRangeEnd = 1290207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000935D8 File Offset: 0x000917D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290252, RefRangeEnd = 1290253, XrefRangeStart = 1290207, XrefRangeEnd = 1290252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000110B5 File Offset: 0x0000F2B5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, ref this));
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x00093608 File Offset: 0x00091808
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x000110C7 File Offset: 0x0000F2C7
		public unsafe static int k_NumLayers
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CameraProperties.NativeFieldInfoPtr_k_NumLayers, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraProperties.NativeFieldInfoPtr_k_NumLayers, (void*)(&value));
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x00093624 File Offset: 0x00091824
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x000110D5 File Offset: 0x0000F2D5
		public unsafe static int k_PlaneCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CameraProperties.NativeFieldInfoPtr_k_PlaneCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraProperties.NativeFieldInfoPtr_k_PlaneCount, (void*)(&value));
			}
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x000110E3 File Offset: 0x0000F2E3
		public void SetShadowCullingPlane(int index, Plane plane)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000110F0 File Offset: 0x0000F2F0
		public void SetCameraCullingPlane(int index, Plane plane)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00093640 File Offset: 0x00091840
		public static bool operator ==(CameraProperties left, CameraProperties right)
		{
			return left.Equals(right);
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x0009365C File Offset: 0x0009185C
		public static bool operator !=(CameraProperties left, CameraProperties right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04001F02 RID: 7938
		private static readonly IntPtr NativeFieldInfoPtr_k_NumLayers;

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeFieldInfoPtr_screenRect;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeFieldInfoPtr_viewDir;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeFieldInfoPtr_projectionNear;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeFieldInfoPtr_projectionFar;

		// Token: 0x04001F07 RID: 7943
		private static readonly IntPtr NativeFieldInfoPtr_cameraNear;

		// Token: 0x04001F08 RID: 7944
		private static readonly IntPtr NativeFieldInfoPtr_cameraFar;

		// Token: 0x04001F09 RID: 7945
		private static readonly IntPtr NativeFieldInfoPtr_cameraAspect;

		// Token: 0x04001F0A RID: 7946
		private static readonly IntPtr NativeFieldInfoPtr_cameraToWorld;

		// Token: 0x04001F0B RID: 7947
		private static readonly IntPtr NativeFieldInfoPtr_actualWorldToClip;

		// Token: 0x04001F0C RID: 7948
		private static readonly IntPtr NativeFieldInfoPtr_cameraClipToWorld;

		// Token: 0x04001F0D RID: 7949
		private static readonly IntPtr NativeFieldInfoPtr_cameraWorldToClip;

		// Token: 0x04001F0E RID: 7950
		private static readonly IntPtr NativeFieldInfoPtr_implicitProjection;

		// Token: 0x04001F0F RID: 7951
		private static readonly IntPtr NativeFieldInfoPtr_stereoWorldToClipLeft;

		// Token: 0x04001F10 RID: 7952
		private static readonly IntPtr NativeFieldInfoPtr_stereoWorldToClipRight;

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeFieldInfoPtr_worldToCamera;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeFieldInfoPtr_up;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeFieldInfoPtr_transformDirection;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeFieldInfoPtr_cameraEuler;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeFieldInfoPtr_farPlaneWorldSpaceLength;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeFieldInfoPtr_rendererCount;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeFieldInfoPtr_k_PlaneCount;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeFieldInfoPtr_m_ShadowCullPlanes;

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeFieldInfoPtr_m_CameraCullPlanes;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeFieldInfoPtr_baseFarDistance;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeFieldInfoPtr_shadowCullCenter;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeFieldInfoPtr_layerCullDistances;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeFieldInfoPtr_layerCullSpherical;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeFieldInfoPtr_coreCameraValues;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeFieldInfoPtr_cameraType;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeFieldInfoPtr_projectionIsOblique;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeFieldInfoPtr_isImplicitProjectionMatrix;

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0;

		// Token: 0x04001F25 RID: 7973
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0;

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0;

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001F29 RID: 7977
		[FieldOffset(0)]
		public Rect screenRect;

		// Token: 0x04001F2A RID: 7978
		[FieldOffset(16)]
		public Vector3 viewDir;

		// Token: 0x04001F2B RID: 7979
		[FieldOffset(28)]
		public float projectionNear;

		// Token: 0x04001F2C RID: 7980
		[FieldOffset(32)]
		public float projectionFar;

		// Token: 0x04001F2D RID: 7981
		[FieldOffset(36)]
		public float cameraNear;

		// Token: 0x04001F2E RID: 7982
		[FieldOffset(40)]
		public float cameraFar;

		// Token: 0x04001F2F RID: 7983
		[FieldOffset(44)]
		public float cameraAspect;

		// Token: 0x04001F30 RID: 7984
		[FieldOffset(48)]
		public Matrix4x4 cameraToWorld;

		// Token: 0x04001F31 RID: 7985
		[FieldOffset(112)]
		public Matrix4x4 actualWorldToClip;

		// Token: 0x04001F32 RID: 7986
		[FieldOffset(176)]
		public Matrix4x4 cameraClipToWorld;

		// Token: 0x04001F33 RID: 7987
		[FieldOffset(240)]
		public Matrix4x4 cameraWorldToClip;

		// Token: 0x04001F34 RID: 7988
		[FieldOffset(304)]
		public Matrix4x4 implicitProjection;

		// Token: 0x04001F35 RID: 7989
		[FieldOffset(368)]
		public Matrix4x4 stereoWorldToClipLeft;

		// Token: 0x04001F36 RID: 7990
		[FieldOffset(432)]
		public Matrix4x4 stereoWorldToClipRight;

		// Token: 0x04001F37 RID: 7991
		[FieldOffset(496)]
		public Matrix4x4 worldToCamera;

		// Token: 0x04001F38 RID: 7992
		[FieldOffset(560)]
		public Vector3 up;

		// Token: 0x04001F39 RID: 7993
		[FieldOffset(572)]
		public Vector3 right;

		// Token: 0x04001F3A RID: 7994
		[FieldOffset(584)]
		public Vector3 transformDirection;

		// Token: 0x04001F3B RID: 7995
		[FieldOffset(596)]
		public Vector3 cameraEuler;

		// Token: 0x04001F3C RID: 7996
		[FieldOffset(608)]
		public Vector3 velocity;

		// Token: 0x04001F3D RID: 7997
		[FieldOffset(620)]
		public float farPlaneWorldSpaceLength;

		// Token: 0x04001F3E RID: 7998
		[FieldOffset(624)]
		public uint rendererCount;

		// Token: 0x04001F3F RID: 7999
		[FieldOffset(628)]
		public CameraProperties._m_ShadowCullPlanes_e__FixedBuffer m_ShadowCullPlanes;

		// Token: 0x04001F40 RID: 8000
		[FieldOffset(724)]
		public CameraProperties._m_CameraCullPlanes_e__FixedBuffer m_CameraCullPlanes;

		// Token: 0x04001F41 RID: 8001
		[FieldOffset(820)]
		public float baseFarDistance;

		// Token: 0x04001F42 RID: 8002
		[FieldOffset(824)]
		public Vector3 shadowCullCenter;

		// Token: 0x04001F43 RID: 8003
		[FieldOffset(836)]
		public CameraProperties._layerCullDistances_e__FixedBuffer layerCullDistances;

		// Token: 0x04001F44 RID: 8004
		[FieldOffset(964)]
		public int layerCullSpherical;

		// Token: 0x04001F45 RID: 8005
		[FieldOffset(968)]
		public CoreCameraValues coreCameraValues;

		// Token: 0x04001F46 RID: 8006
		[FieldOffset(980)]
		public uint cameraType;

		// Token: 0x04001F47 RID: 8007
		[FieldOffset(984)]
		public int projectionIsOblique;

		// Token: 0x04001F48 RID: 8008
		[FieldOffset(988)]
		public int isImplicitProjectionMatrix;

		// Token: 0x02000B5C RID: 2908
		[ObfuscatedName("UnityEngine.Rendering.CameraProperties+<layerCullDistances>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _layerCullDistances_e__FixedBuffer
		{
			// Token: 0x06003FA2 RID: 16290 RVA: 0x0001848D File Offset: 0x0001668D
			// Note: this type is marked as 'beforefieldinit'.
			static _layerCullDistances_e__FixedBuffer()
			{
				Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<layerCullDistances>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr);
				CameraProperties._layerCullDistances_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003FA3 RID: 16291 RVA: 0x000184C1 File Offset: 0x000166C1
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002BCD RID: 11213
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002BCE RID: 11214
			[FieldOffset(0)]
			public float FixedElementField;
		}

		// Token: 0x02000B5D RID: 2909
		[ObfuscatedName("UnityEngine.Rendering.CameraProperties+<m_CameraCullPlanes>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _m_CameraCullPlanes_e__FixedBuffer
		{
			// Token: 0x06003FA4 RID: 16292 RVA: 0x000184D3 File Offset: 0x000166D3
			// Note: this type is marked as 'beforefieldinit'.
			static _m_CameraCullPlanes_e__FixedBuffer()
			{
				Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<m_CameraCullPlanes>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr);
				CameraProperties._m_CameraCullPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003FA5 RID: 16293 RVA: 0x00018507 File Offset: 0x00016707
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002BCF RID: 11215
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002BD0 RID: 11216
			[FieldOffset(0)]
			public byte FixedElementField;
		}

		// Token: 0x02000B5E RID: 2910
		[ObfuscatedName("UnityEngine.Rendering.CameraProperties+<m_ShadowCullPlanes>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _m_ShadowCullPlanes_e__FixedBuffer
		{
			// Token: 0x06003FA6 RID: 16294 RVA: 0x00018519 File Offset: 0x00016719
			// Note: this type is marked as 'beforefieldinit'.
			static _m_ShadowCullPlanes_e__FixedBuffer()
			{
				Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<m_ShadowCullPlanes>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr);
				CameraProperties._m_ShadowCullPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003FA7 RID: 16295 RVA: 0x0001854D File Offset: 0x0001674D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002BD1 RID: 11217
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002BD2 RID: 11218
			[FieldOffset(0)]
			public byte FixedElementField;
		}
	}
}

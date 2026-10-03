using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000079 RID: 121
	public class VolumetricDustParticles : MonoBehaviour
	{
		// Token: 0x060008E0 RID: 2272 RVA: 0x0009806C File Offset: 0x0009626C
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricDustParticles()
		{
			Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricDustParticles");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr);
			VolumetricDustParticles.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "ClassName");
			VolumetricDustParticles.NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "alpha");
			VolumetricDustParticles.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "size");
			VolumetricDustParticles.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "direction");
			VolumetricDustParticles.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "velocity");
			VolumetricDustParticles.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "speed");
			VolumetricDustParticles.NativeFieldInfoPtr_density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "density");
			VolumetricDustParticles.NativeFieldInfoPtr_spawnDistanceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "spawnDistanceRange");
			VolumetricDustParticles.NativeFieldInfoPtr_spawnMinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "spawnMinDistance");
			VolumetricDustParticles.NativeFieldInfoPtr_spawnMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "spawnMaxDistance");
			VolumetricDustParticles.NativeFieldInfoPtr_cullingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "cullingEnabled");
			VolumetricDustParticles.NativeFieldInfoPtr_cullingMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "cullingMaxDistance");
			VolumetricDustParticles.NativeFieldInfoPtr__isCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "<isCulled>k__BackingField");
			VolumetricDustParticles.NativeFieldInfoPtr_m_AlphaAdditionalRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_AlphaAdditionalRuntime");
			VolumetricDustParticles.NativeFieldInfoPtr_m_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_Particles");
			VolumetricDustParticles.NativeFieldInfoPtr_m_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_Renderer");
			VolumetricDustParticles.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_Material");
			VolumetricDustParticles.NativeFieldInfoPtr_m_GradientCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_GradientCached");
			VolumetricDustParticles.NativeFieldInfoPtr_m_RuntimePropertiesDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_RuntimePropertiesDirty");
			VolumetricDustParticles.NativeFieldInfoPtr_ms_NoMainCameraLogged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "ms_NoMainCameraLogged");
			VolumetricDustParticles.NativeFieldInfoPtr_ms_MainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "ms_MainCamera");
			VolumetricDustParticles.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "m_Master");
			VolumetricDustParticles.NativeMethodInfoPtr_get_isCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664439);
			VolumetricDustParticles.NativeMethodInfoPtr_set_isCulled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664440);
			VolumetricDustParticles.NativeMethodInfoPtr_get_alphaAdditionalRuntime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664441);
			VolumetricDustParticles.NativeMethodInfoPtr_set_alphaAdditionalRuntime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664442);
			VolumetricDustParticles.NativeMethodInfoPtr_get_particlesAreInstantiated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664443);
			VolumetricDustParticles.NativeMethodInfoPtr_get_particlesCurrentCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664444);
			VolumetricDustParticles.NativeMethodInfoPtr_get_particlesMaxCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664445);
			VolumetricDustParticles.NativeMethodInfoPtr_get_mainCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664446);
			VolumetricDustParticles.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664447);
			VolumetricDustParticles.NativeMethodInfoPtr_InstantiateParticleSystem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664448);
			VolumetricDustParticles.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664449);
			VolumetricDustParticles.NativeMethodInfoPtr_SetActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664450);
			VolumetricDustParticles.NativeMethodInfoPtr_SetActiveAndPlay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664451);
			VolumetricDustParticles.NativeMethodInfoPtr_Play_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664452);
			VolumetricDustParticles.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664453);
			VolumetricDustParticles.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664454);
			VolumetricDustParticles.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664455);
			VolumetricDustParticles.NativeMethodInfoPtr_SetParticleProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664456);
			VolumetricDustParticles.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664457);
			VolumetricDustParticles.NativeMethodInfoPtr_UpdateCulling_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664458);
			VolumetricDustParticles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, 100664459);
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x000983F8 File Offset: 0x000965F8
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x00098434 File Offset: 0x00096634
		public unsafe bool isCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_isCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_set_isCulled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00098474 File Offset: 0x00096674
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x000984B0 File Offset: 0x000966B0
		public unsafe float alphaAdditionalRuntime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_alphaAdditionalRuntime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74443, RefRangeEnd = 74444, XrefRangeStart = 74443, XrefRangeEnd = 74443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_set_alphaAdditionalRuntime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x000984F0 File Offset: 0x000966F0
		public unsafe bool particlesAreInstantiated
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74444, XrefRangeEnd = 74448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_particlesAreInstantiated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0009852C File Offset: 0x0009672C
		public unsafe int particlesCurrentCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74448, XrefRangeEnd = 74453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_particlesCurrentCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00098568 File Offset: 0x00096768
		public unsafe int particlesMaxCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74453, XrefRangeEnd = 74459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_particlesMaxCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x000985A4 File Offset: 0x000967A4
		public unsafe Camera mainCamera
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 74489, RefRangeEnd = 74491, XrefRangeStart = 74459, XrefRangeEnd = 74489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_get_mainCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000985E4 File Offset: 0x000967E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74491, XrefRangeEnd = 74500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00098618 File Offset: 0x00096818
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74540, RefRangeEnd = 74541, XrefRangeStart = 74500, XrefRangeEnd = 74540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstantiateParticleSystem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_InstantiateParticleSystem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0009864C File Offset: 0x0009684C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74541, XrefRangeEnd = 74542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00098680 File Offset: 0x00096880
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 74548, RefRangeEnd = 74551, XrefRangeStart = 74542, XrefRangeEnd = 74548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_SetActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x000986C0 File Offset: 0x000968C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74559, RefRangeEnd = 74561, XrefRangeStart = 74551, XrefRangeEnd = 74559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveAndPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_SetActiveAndPlay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x000986F4 File Offset: 0x000968F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74561, XrefRangeEnd = 74568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_Play_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00098728 File Offset: 0x00096928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74568, XrefRangeEnd = 74569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0009875C File Offset: 0x0009695C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74569, XrefRangeEnd = 74585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00098790 File Offset: 0x00096990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74585, XrefRangeEnd = 74602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000987C4 File Offset: 0x000969C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 74803, RefRangeEnd = 74806, XrefRangeStart = 74602, XrefRangeEnd = 74803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticleProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_SetParticleProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000987F8 File Offset: 0x000969F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74806, XrefRangeEnd = 74808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref serializedVersion;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00098844 File Offset: 0x00096A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74856, RefRangeEnd = 74857, XrefRangeStart = 74808, XrefRangeEnd = 74856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr_UpdateCulling_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00098878 File Offset: 0x00096A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74857, XrefRangeEnd = 74868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricDustParticles() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000061AD File Offset: 0x000043AD
		public VolumetricDustParticles(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x000988B4 File Offset: 0x00096AB4
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x000061B6 File Offset: 0x000043B6
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x000988D4 File Offset: 0x00096AD4
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x000061C8 File Offset: 0x000043C8
		public unsafe float alpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_alpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_alpha)) = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x000988FC File Offset: 0x00096AFC
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x000061E3 File Offset: 0x000043E3
		public unsafe float size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00098924 File Offset: 0x00096B24
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x000061FE File Offset: 0x000043FE
		public unsafe ParticlesDirection direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_direction)) = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x0009894C File Offset: 0x00096B4C
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00006219 File Offset: 0x00004419
		public unsafe Vector3 velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_velocity)) = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00098974 File Offset: 0x00096B74
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00006234 File Offset: 0x00004434
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x0009899C File Offset: 0x00096B9C
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x0000624F File Offset: 0x0000444F
		public unsafe float density
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_density);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_density)) = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x000989C4 File Offset: 0x00096BC4
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x0000626A File Offset: 0x0000446A
		public unsafe MinMaxRangeFloat spawnDistanceRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnDistanceRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnDistanceRange)) = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x000989EC File Offset: 0x00096BEC
		// (set) Token: 0x06000908 RID: 2312 RVA: 0x00006285 File Offset: 0x00004485
		public unsafe float spawnMinDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMinDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMinDistance)) = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00098A14 File Offset: 0x00096C14
		// (set) Token: 0x0600090A RID: 2314 RVA: 0x000062A0 File Offset: 0x000044A0
		public unsafe float spawnMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_spawnMaxDistance)) = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00098A3C File Offset: 0x00096C3C
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x000062BB File Offset: 0x000044BB
		public unsafe bool cullingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingEnabled)) = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x00098A64 File Offset: 0x00096C64
		// (set) Token: 0x0600090E RID: 2318 RVA: 0x000062D6 File Offset: 0x000044D6
		public unsafe float cullingMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_cullingMaxDistance)) = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x00098A8C File Offset: 0x00096C8C
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x000062F1 File Offset: 0x000044F1
		public unsafe bool _isCulled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr__isCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr__isCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00098AB4 File Offset: 0x00096CB4
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x0000630C File Offset: 0x0000450C
		public unsafe float m_AlphaAdditionalRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_AlphaAdditionalRuntime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_AlphaAdditionalRuntime)) = value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x00098ADC File Offset: 0x00096CDC
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00006327 File Offset: 0x00004527
		public unsafe ParticleSystem m_Particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00098B0C File Offset: 0x00096D0C
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00006346 File Offset: 0x00004546
		public unsafe ParticleSystemRenderer m_Renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystemRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00098B3C File Offset: 0x00096D3C
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00006365 File Offset: 0x00004565
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00098B6C File Offset: 0x00096D6C
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00006384 File Offset: 0x00004584
		public unsafe Gradient m_GradientCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_GradientCached);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_GradientCached), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x00098B9C File Offset: 0x00096D9C
		// (set) Token: 0x0600091C RID: 2332 RVA: 0x000063A3 File Offset: 0x000045A3
		public unsafe bool m_RuntimePropertiesDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_RuntimePropertiesDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_RuntimePropertiesDirty)) = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x00098BC4 File Offset: 0x00096DC4
		// (set) Token: 0x0600091E RID: 2334 RVA: 0x000063BE File Offset: 0x000045BE
		public unsafe static bool ms_NoMainCameraLogged
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_NoMainCameraLogged, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_NoMainCameraLogged, (void*)(&value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00098BE0 File Offset: 0x00096DE0
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x000063CC File Offset: 0x000045CC
		public unsafe static Camera ms_MainCamera
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_MainCamera, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.NativeFieldInfoPtr_ms_MainCamera, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00098C08 File Offset: 0x00096E08
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x000063DE File Offset: 0x000045DE
		public unsafe VolumetricLightBeamAbstractBase m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamAbstractBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricDustParticles.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeFieldInfoPtr_alpha;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr_direction;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeFieldInfoPtr_density;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr_spawnDistanceRange;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeFieldInfoPtr_spawnMinDistance;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeFieldInfoPtr_spawnMaxDistance;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeFieldInfoPtr_cullingEnabled;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeFieldInfoPtr_cullingMaxDistance;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeFieldInfoPtr__isCulled_k__BackingField;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeFieldInfoPtr_m_AlphaAdditionalRuntime;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeFieldInfoPtr_m_Particles;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeFieldInfoPtr_m_Renderer;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeFieldInfoPtr_m_GradientCached;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeFieldInfoPtr_m_RuntimePropertiesDirty;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeFieldInfoPtr_ms_NoMainCameraLogged;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeFieldInfoPtr_ms_MainCamera;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_get_isCulled_Public_get_Boolean_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_set_isCulled_Private_set_Void_Boolean_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_get_alphaAdditionalRuntime_Public_get_Single_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_set_alphaAdditionalRuntime_Public_set_Void_Single_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_get_particlesAreInstantiated_Public_get_Boolean_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_get_particlesCurrentCount_Public_get_Int32_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_get_particlesMaxCount_Public_get_Int32_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_get_mainCamera_Public_get_Camera_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateParticleSystem_Private_Void_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Private_Void_Boolean_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveAndPlay_Private_Void_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_SetParticleProperties_Private_Void_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_HandleBackwardCompatibility_Private_Void_Int32_Int32_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCulling_Private_Void_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200089D RID: 2205
		[ObfuscatedName("VLB.VolumetricDustParticles+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D30B RID: 54027 RVA: 0x0034B3B8 File Offset: 0x003495B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumetricDustParticles>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr);
				VolumetricDustParticles.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr, "<>9");
				VolumetricDustParticles.__c.NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr, "<>9__37_0");
				VolumetricDustParticles.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr, 100664461);
				VolumetricDustParticles.__c.NativeMethodInfoPtr__InstantiateParticleSystem_b__37_0_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr, 100664462);
			}

			// Token: 0x0600D30C RID: 54028 RVA: 0x0034B434 File Offset: 0x00349634
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricDustParticles.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D30D RID: 54029 RVA: 0x0034B470 File Offset: 0x00349670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74430, XrefRangeEnd = 74443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstantiateParticleSystem_b__37_0(ParticleSystem ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricDustParticles.__c.NativeMethodInfoPtr__InstantiateParticleSystem_b__37_0_Internal_Void_ParticleSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D30E RID: 54030 RVA: 0x00063CD9 File Offset: 0x00061ED9
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004026 RID: 16422
			// (get) Token: 0x0600D30F RID: 54031 RVA: 0x0034B4B4 File Offset: 0x003496B4
			// (set) Token: 0x0600D310 RID: 54032 RVA: 0x00063CE2 File Offset: 0x00061EE2
			public unsafe static VolumetricDustParticles.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricDustParticles.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004027 RID: 16423
			// (get) Token: 0x0600D311 RID: 54033 RVA: 0x0034B4DC File Offset: 0x003496DC
			// (set) Token: 0x0600D312 RID: 54034 RVA: 0x00063CF4 File Offset: 0x00061EF4
			public unsafe static Action<ParticleSystem> __9__37_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumetricDustParticles.__c.NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumetricDustParticles.__c.NativeFieldInfoPtr___9__37_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FCD RID: 36813
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008FCE RID: 36814
			private static readonly IntPtr NativeFieldInfoPtr___9__37_0;

			// Token: 0x04008FCF RID: 36815
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FD0 RID: 36816
			private static readonly IntPtr NativeMethodInfoPtr__InstantiateParticleSystem_b__37_0_Internal_Void_ParticleSystem_0;
		}
	}
}

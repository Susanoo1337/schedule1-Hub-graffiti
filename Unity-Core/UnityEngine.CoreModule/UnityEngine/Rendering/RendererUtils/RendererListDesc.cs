using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RendererUtils
{
	// Token: 0x0200024A RID: 586
	public sealed class RendererListDesc : ValueType
	{
		// Token: 0x060028BA RID: 10426 RVA: 0x0009F4EC File Offset: 0x0009D6EC
		// Note: this type is marked as 'beforefieldinit'.
		static RendererListDesc()
		{
			Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering.RendererUtils", "RendererListDesc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr);
			RendererListDesc.NativeFieldInfoPtr_sortingCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "sortingCriteria");
			RendererListDesc.NativeFieldInfoPtr_rendererConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "rendererConfiguration");
			RendererListDesc.NativeFieldInfoPtr_renderQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "renderQueueRange");
			RendererListDesc.NativeFieldInfoPtr_stateBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "stateBlock");
			RendererListDesc.NativeFieldInfoPtr_overrideShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideShader");
			RendererListDesc.NativeFieldInfoPtr_overrideMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideMaterial");
			RendererListDesc.NativeFieldInfoPtr_excludeObjectMotionVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "excludeObjectMotionVectors");
			RendererListDesc.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "layerMask");
			RendererListDesc.NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "renderingLayerMask");
			RendererListDesc.NativeFieldInfoPtr_overrideMaterialPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideMaterialPassIndex");
			RendererListDesc.NativeFieldInfoPtr_overrideShaderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideShaderPassIndex");
			RendererListDesc.NativeFieldInfoPtr__cullingResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<cullingResult>k__BackingField");
			RendererListDesc.NativeFieldInfoPtr__camera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<camera>k__BackingField");
			RendererListDesc.NativeFieldInfoPtr__passName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<passName>k__BackingField");
			RendererListDesc.NativeFieldInfoPtr__passNames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<passNames>k__BackingField");
			RendererListDesc.NativeFieldInfoPtr_s_EmptyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "s_EmptyName");
			RendererListDesc.NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100667646);
			RendererListDesc.NativeMethodInfoPtr_get_camera_Internal_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100667647);
			RendererListDesc.NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100667648);
			RendererListDesc.NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100667649);
			RendererListDesc.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100667650);
			RendererListDesc.NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100667651);
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x0009F6D4 File Offset: 0x0009D8D4
		// (set) Token: 0x060028E3 RID: 10467 RVA: 0x000125E7 File Offset: 0x000107E7
		public unsafe CullingResults cullingResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._cullingResult_k__BackingField = value;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x0009F718 File Offset: 0x0009D918
		// (set) Token: 0x060028E4 RID: 10468 RVA: 0x000125F0 File Offset: 0x000107F0
		public unsafe Camera camera
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38421, RefRangeEnd = 38424, XrefRangeStart = 38421, XrefRangeEnd = 38424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_camera_Internal_get_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			set
			{
				this._camera_k__BackingField = value;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x0009F75C File Offset: 0x0009D95C
		// (set) Token: 0x060028E5 RID: 10469 RVA: 0x000125F9 File Offset: 0x000107F9
		public unsafe ShaderTagId passName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._passName_k__BackingField = value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x060028BE RID: 10430 RVA: 0x0009F7A0 File Offset: 0x0009D9A0
		// (set) Token: 0x060028E6 RID: 10470 RVA: 0x00012602 File Offset: 0x00010802
		public unsafe Il2CppStructArray<ShaderTagId> passNames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(intPtr3) : null;
			}
			set
			{
				this._passNames_k__BackingField = value;
			}
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0009F7E4 File Offset: 0x0009D9E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292474, RefRangeEnd = 1292475, XrefRangeStart = 1292462, XrefRangeEnd = 1292474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0009F828 File Offset: 0x0009DA28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1292559, RefRangeEnd = 1292560, XrefRangeStart = 1292475, XrefRangeEnd = 1292559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RendererListParams ConvertToParameters([In] ref RendererListDesc desc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(desc));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new RendererListParams(pointer);
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x00012406 File Offset: 0x00010606
		public RendererListDesc(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x0001240F File Offset: 0x0001060F
		public RendererListDesc() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr))
		{
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x0009F86C File Offset: 0x0009DA6C
		// (set) Token: 0x060028C4 RID: 10436 RVA: 0x00012421 File Offset: 0x00010621
		public unsafe SortingCriteria sortingCriteria
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_sortingCriteria);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_sortingCriteria)) = value;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x060028C5 RID: 10437 RVA: 0x0009F894 File Offset: 0x0009DA94
		// (set) Token: 0x060028C6 RID: 10438 RVA: 0x0001243C File Offset: 0x0001063C
		public unsafe PerObjectData rendererConfiguration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_rendererConfiguration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_rendererConfiguration)) = value;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x0009F8BC File Offset: 0x0009DABC
		// (set) Token: 0x060028C8 RID: 10440 RVA: 0x00012457 File Offset: 0x00010657
		public unsafe RenderQueueRange renderQueueRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderQueueRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderQueueRange)) = value;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x0009F8E4 File Offset: 0x0009DAE4
		// (set) Token: 0x060028CA RID: 10442 RVA: 0x00012472 File Offset: 0x00010672
		public Nullable<RenderStateBlock> stateBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_stateBlock);
				return new Nullable<RenderStateBlock>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<RenderStateBlock>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_stateBlock), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<RenderStateBlock>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x0009F914 File Offset: 0x0009DB14
		// (set) Token: 0x060028CC RID: 10444 RVA: 0x000124A0 File Offset: 0x000106A0
		public unsafe Shader overrideShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x0009F944 File Offset: 0x0009DB44
		// (set) Token: 0x060028CE RID: 10446 RVA: 0x000124BF File Offset: 0x000106BF
		public unsafe Material overrideMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x0009F974 File Offset: 0x0009DB74
		// (set) Token: 0x060028D0 RID: 10448 RVA: 0x000124DE File Offset: 0x000106DE
		public unsafe bool excludeObjectMotionVectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_excludeObjectMotionVectors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_excludeObjectMotionVectors)) = value;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x0009F99C File Offset: 0x0009DB9C
		// (set) Token: 0x060028D2 RID: 10450 RVA: 0x000124F9 File Offset: 0x000106F9
		public unsafe int layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_layerMask)) = value;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x0009F9C4 File Offset: 0x0009DBC4
		// (set) Token: 0x060028D4 RID: 10452 RVA: 0x00012514 File Offset: 0x00010714
		public unsafe uint renderingLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderingLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderingLayerMask)) = value;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x0009F9EC File Offset: 0x0009DBEC
		// (set) Token: 0x060028D6 RID: 10454 RVA: 0x0001252F File Offset: 0x0001072F
		public unsafe int overrideMaterialPassIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterialPassIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterialPassIndex)) = value;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x0009FA14 File Offset: 0x0009DC14
		// (set) Token: 0x060028D8 RID: 10456 RVA: 0x0001254A File Offset: 0x0001074A
		public unsafe int overrideShaderPassIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShaderPassIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShaderPassIndex)) = value;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x0009FA3C File Offset: 0x0009DC3C
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x00012565 File Offset: 0x00010765
		public unsafe CullingResults _cullingResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__cullingResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__cullingResult_k__BackingField)) = value;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x0009FA64 File Offset: 0x0009DC64
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x00012580 File Offset: 0x00010780
		public unsafe Camera _camera_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__camera_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__camera_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x0009FA94 File Offset: 0x0009DC94
		// (set) Token: 0x060028DE RID: 10462 RVA: 0x0001259F File Offset: 0x0001079F
		public unsafe ShaderTagId _passName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passName_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passName_k__BackingField)) = value;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x0009FABC File Offset: 0x0009DCBC
		// (set) Token: 0x060028E0 RID: 10464 RVA: 0x000125BA File Offset: 0x000107BA
		public unsafe Il2CppStructArray<ShaderTagId> _passNames_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passNames_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passNames_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x0009FAEC File Offset: 0x0009DCEC
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x000125D9 File Offset: 0x000107D9
		public unsafe static ShaderTagId s_EmptyName
		{
			get
			{
				ShaderTagId result;
				IL2CPP.il2cpp_field_static_get_value(RendererListDesc.NativeFieldInfoPtr_s_EmptyName, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererListDesc.NativeFieldInfoPtr_s_EmptyName, (void*)(&value));
			}
		}

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeFieldInfoPtr_sortingCriteria;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeFieldInfoPtr_rendererConfiguration;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeFieldInfoPtr_renderQueueRange;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeFieldInfoPtr_stateBlock;

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeFieldInfoPtr_overrideShader;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeFieldInfoPtr_overrideMaterial;

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeFieldInfoPtr_excludeObjectMotionVectors;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeFieldInfoPtr_renderingLayerMask;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeFieldInfoPtr_overrideMaterialPassIndex;

		// Token: 0x040022B7 RID: 8887
		private static readonly IntPtr NativeFieldInfoPtr_overrideShaderPassIndex;

		// Token: 0x040022B8 RID: 8888
		private static readonly IntPtr NativeFieldInfoPtr__cullingResult_k__BackingField;

		// Token: 0x040022B9 RID: 8889
		private static readonly IntPtr NativeFieldInfoPtr__camera_k__BackingField;

		// Token: 0x040022BA RID: 8890
		private static readonly IntPtr NativeFieldInfoPtr__passName_k__BackingField;

		// Token: 0x040022BB RID: 8891
		private static readonly IntPtr NativeFieldInfoPtr__passNames_k__BackingField;

		// Token: 0x040022BC RID: 8892
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyName;

		// Token: 0x040022BD RID: 8893
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0;

		// Token: 0x040022BE RID: 8894
		private static readonly IntPtr NativeMethodInfoPtr_get_camera_Internal_get_Camera_0;

		// Token: 0x040022BF RID: 8895
		private static readonly IntPtr NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0;

		// Token: 0x040022C0 RID: 8896
		private static readonly IntPtr NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0;

		// Token: 0x040022C1 RID: 8897
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x040022C2 RID: 8898
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0;
	}
}

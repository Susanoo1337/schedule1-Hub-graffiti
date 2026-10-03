using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000224 RID: 548
	[StructLayout(2)]
	public struct DrawingSettings
	{
		// Token: 0x0600255A RID: 9562 RVA: 0x00095078 File Offset: 0x00093278
		// Note: this type is marked as 'beforefieldinit'.
		static DrawingSettings()
		{
			Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "DrawingSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr);
			DrawingSettings.NativeFieldInfoPtr_maxShaderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "maxShaderPasses");
			DrawingSettings.NativeFieldInfoPtr_m_SortingSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_SortingSettings");
			DrawingSettings.NativeFieldInfoPtr_shaderPassNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "shaderPassNames");
			DrawingSettings.NativeFieldInfoPtr_m_PerObjectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_PerObjectData");
			DrawingSettings.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_Flags");
			DrawingSettings.NativeFieldInfoPtr_m_OverrideShaderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideShaderID");
			DrawingSettings.NativeFieldInfoPtr_m_OverrideShaderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideShaderPassIndex");
			DrawingSettings.NativeFieldInfoPtr_m_OverrideMaterialInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideMaterialInstanceId");
			DrawingSettings.NativeFieldInfoPtr_m_OverrideMaterialPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_OverrideMaterialPassIndex");
			DrawingSettings.NativeFieldInfoPtr_m_fallbackMaterialInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_fallbackMaterialInstanceId");
			DrawingSettings.NativeFieldInfoPtr_m_MainLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_MainLightIndex");
			DrawingSettings.NativeFieldInfoPtr_m_UseSrpBatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "m_UseSrpBatcher");
			DrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667291);
			DrawingSettings.NativeMethodInfoPtr_get_sortingSettings_Public_get_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667292);
			DrawingSettings.NativeMethodInfoPtr_set_sortingSettings_Public_set_Void_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667293);
			DrawingSettings.NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667294);
			DrawingSettings.NativeMethodInfoPtr_set_enableDynamicBatching_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667295);
			DrawingSettings.NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667296);
			DrawingSettings.NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667297);
			DrawingSettings.NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667298);
			DrawingSettings.NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667299);
			DrawingSettings.NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667300);
			DrawingSettings.NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667301);
			DrawingSettings.NativeMethodInfoPtr_set_mainLightIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667302);
			DrawingSettings.NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667303);
			DrawingSettings.NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667304);
			DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667305);
			DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667306);
			DrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667307);
			DrawingSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100667308);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00095300 File Offset: 0x00093500
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1290452, RefRangeEnd = 1290456, XrefRangeStart = 1290446, XrefRangeEnd = 1290452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawingSettings(ShaderTagId shaderPassName, SortingSettings sortingSettings)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shaderPassName;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sortingSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x00095340 File Offset: 0x00093540
		// (set) Token: 0x0600255D RID: 9565 RVA: 0x00095370 File Offset: 0x00093570
		public unsafe SortingSettings sortingSettings
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1290456, RefRangeEnd = 1290458, XrefRangeStart = 1290456, XrefRangeEnd = 1290456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_get_sortingSettings_Public_get_SortingSettings_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1290458, RefRangeEnd = 1290461, XrefRangeStart = 1290458, XrefRangeEnd = 1290458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_sortingSettings_Public_set_Void_SortingSettings_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x00095720 File Offset: 0x00093920
		// (set) Token: 0x0600255E RID: 9566 RVA: 0x000953A4 File Offset: 0x000935A4
		public unsafe PerObjectData perObjectData
		{
			get
			{
				return this.m_PerObjectData;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1143808, RefRangeEnd = 1143817, XrefRangeStart = 1143808, XrefRangeEnd = 1143817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x00095738 File Offset: 0x00093938
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x000953D8 File Offset: 0x000935D8
		public unsafe bool enableDynamicBatching
		{
			get
			{
				return (this.m_Flags & DrawRendererFlags.EnableDynamicBatching) > DrawRendererFlags.None;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1290461, RefRangeEnd = 1290463, XrefRangeStart = 1290461, XrefRangeEnd = 1290461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_enableDynamicBatching_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x00095758 File Offset: 0x00093958
		// (set) Token: 0x06002560 RID: 9568 RVA: 0x0009540C File Offset: 0x0009360C
		public unsafe bool enableInstancing
		{
			get
			{
				return (this.m_Flags & DrawRendererFlags.EnableInstancing) > DrawRendererFlags.None;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1290463, RefRangeEnd = 1290465, XrefRangeStart = 1290463, XrefRangeEnd = 1290463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06002573 RID: 9587 RVA: 0x00095778 File Offset: 0x00093978
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x00095440 File Offset: 0x00093640
		public unsafe Material overrideMaterial
		{
			get
			{
				return (this.m_OverrideMaterialInstanceId != 0) ? Object.FindObjectFromInstanceID(this.m_OverrideMaterialInstanceId).TryCast<Material>() : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1290466, RefRangeEnd = 1290472, XrefRangeStart = 1290465, XrefRangeEnd = 1290466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x000957A8 File Offset: 0x000939A8
		// (set) Token: 0x06002562 RID: 9570 RVA: 0x00095478 File Offset: 0x00093678
		public unsafe Shader overrideShader
		{
			get
			{
				return (this.m_OverrideShaderID != 0) ? Object.FindObjectFromInstanceID(this.m_OverrideShaderID).TryCast<Shader>() : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1290473, RefRangeEnd = 1290475, XrefRangeStart = 1290472, XrefRangeEnd = 1290473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x000957D8 File Offset: 0x000939D8
		// (set) Token: 0x06002563 RID: 9571 RVA: 0x000954B0 File Offset: 0x000936B0
		public unsafe int overrideMaterialPassIndex
		{
			get
			{
				return this.m_OverrideMaterialPassIndex;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 894495, RefRangeEnd = 894499, XrefRangeStart = 894495, XrefRangeEnd = 894499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000957F0 File Offset: 0x000939F0
		// (set) Token: 0x06002564 RID: 9572 RVA: 0x000954E4 File Offset: 0x000936E4
		public unsafe int overrideShaderPassIndex
		{
			get
			{
				return this.m_OverrideShaderPassIndex;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 371651, RefRangeEnd = 371653, XrefRangeStart = 371651, XrefRangeEnd = 371653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x00095808 File Offset: 0x00093A08
		// (set) Token: 0x06002565 RID: 9573 RVA: 0x00095518 File Offset: 0x00093718
		public unsafe Material fallbackMaterial
		{
			get
			{
				return (this.m_fallbackMaterialInstanceId != 0) ? Object.FindObjectFromInstanceID(this.m_fallbackMaterialInstanceId).TryCast<Material>() : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290476, RefRangeEnd = 1290477, XrefRangeStart = 1290475, XrefRangeEnd = 1290476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x00095838 File Offset: 0x00093A38
		// (set) Token: 0x06002566 RID: 9574 RVA: 0x00095550 File Offset: 0x00093750
		public unsafe int mainLightIndex
		{
			get
			{
				return this.m_MainLightIndex;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45077, RefRangeEnd = 45078, XrefRangeStart = 45077, XrefRangeEnd = 45078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_mainLightIndex_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00095584 File Offset: 0x00093784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290482, RefRangeEnd = 1290484, XrefRangeStart = 1290477, XrefRangeEnd = 1290482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderTagId GetShaderPassName(int index)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x000955C4 File Offset: 0x000937C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1290489, RefRangeEnd = 1290496, XrefRangeStart = 1290484, XrefRangeEnd = 1290489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderPassName(int index, ShaderTagId shaderPassName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shaderPassName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x00095604 File Offset: 0x00093804
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1290505, RefRangeEnd = 1290508, XrefRangeStart = 1290496, XrefRangeEnd = 1290505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(DrawingSettings other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x00095644 File Offset: 0x00093844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290508, XrefRangeEnd = 1290514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00095688 File Offset: 0x00093888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290514, XrefRangeEnd = 1290515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x000956B8 File Offset: 0x000938B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290515, XrefRangeEnd = 1290519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(DrawingSettings left, DrawingSettings right)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x000112BA File Offset: 0x0000F4BA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, ref this));
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x00095704 File Offset: 0x00093904
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x000112CC File Offset: 0x0000F4CC
		public unsafe static int maxShaderPasses
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DrawingSettings.NativeFieldInfoPtr_maxShaderPasses, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DrawingSettings.NativeFieldInfoPtr_maxShaderPasses, (void*)(&value));
			}
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x00095850 File Offset: 0x00093A50
		public static bool operator !=(DrawingSettings left, DrawingSettings right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeFieldInfoPtr_maxShaderPasses;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingSettings;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeFieldInfoPtr_shaderPassNames;

		// Token: 0x04001FD5 RID: 8149
		private static readonly IntPtr NativeFieldInfoPtr_m_PerObjectData;

		// Token: 0x04001FD6 RID: 8150
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x04001FD7 RID: 8151
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideShaderID;

		// Token: 0x04001FD8 RID: 8152
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideShaderPassIndex;

		// Token: 0x04001FD9 RID: 8153
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideMaterialInstanceId;

		// Token: 0x04001FDA RID: 8154
		private static readonly IntPtr NativeFieldInfoPtr_m_OverrideMaterialPassIndex;

		// Token: 0x04001FDB RID: 8155
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackMaterialInstanceId;

		// Token: 0x04001FDC RID: 8156
		private static readonly IntPtr NativeFieldInfoPtr_m_MainLightIndex;

		// Token: 0x04001FDD RID: 8157
		private static readonly IntPtr NativeFieldInfoPtr_m_UseSrpBatcher;

		// Token: 0x04001FDE RID: 8158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0;

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingSettings_Public_get_SortingSettings_0;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingSettings_Public_set_Void_SortingSettings_0;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0;

		// Token: 0x04001FE2 RID: 8162
		private static readonly IntPtr NativeMethodInfoPtr_set_enableDynamicBatching_Public_set_Void_Boolean_0;

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeMethodInfoPtr_set_mainLightIndex_Public_set_Void_Int32_0;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0;

		// Token: 0x04001FF0 RID: 8176
		[FieldOffset(0)]
		public SortingSettings m_SortingSettings;

		// Token: 0x04001FF1 RID: 8177
		[FieldOffset(96)]
		public DrawingSettings._shaderPassNames_e__FixedBuffer shaderPassNames;

		// Token: 0x04001FF2 RID: 8178
		[FieldOffset(160)]
		public PerObjectData m_PerObjectData;

		// Token: 0x04001FF3 RID: 8179
		[FieldOffset(164)]
		public DrawRendererFlags m_Flags;

		// Token: 0x04001FF4 RID: 8180
		[FieldOffset(168)]
		public int m_OverrideShaderID;

		// Token: 0x04001FF5 RID: 8181
		[FieldOffset(172)]
		public int m_OverrideShaderPassIndex;

		// Token: 0x04001FF6 RID: 8182
		[FieldOffset(176)]
		public int m_OverrideMaterialInstanceId;

		// Token: 0x04001FF7 RID: 8183
		[FieldOffset(180)]
		public int m_OverrideMaterialPassIndex;

		// Token: 0x04001FF8 RID: 8184
		[FieldOffset(184)]
		public int m_fallbackMaterialInstanceId;

		// Token: 0x04001FF9 RID: 8185
		[FieldOffset(188)]
		public int m_MainLightIndex;

		// Token: 0x04001FFA RID: 8186
		[FieldOffset(192)]
		public int m_UseSrpBatcher;

		// Token: 0x04001FFB RID: 8187
		public const int kMaxShaderPasses = 16;

		// Token: 0x02000B66 RID: 2918
		[ObfuscatedName("UnityEngine.Rendering.DrawingSettings+<shaderPassNames>e__FixedBuffer")]
		[StructLayout(2)]
		public struct _shaderPassNames_e__FixedBuffer
		{
			// Token: 0x06003FB5 RID: 16309 RVA: 0x000185EB File Offset: 0x000167EB
			// Note: this type is marked as 'beforefieldinit'.
			static _shaderPassNames_e__FixedBuffer()
			{
				Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "<shaderPassNames>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr);
				DrawingSettings._shaderPassNames_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			// Token: 0x06003FB6 RID: 16310 RVA: 0x0001861F File Offset: 0x0001681F
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr, ref this));
			}

			// Token: 0x04002BD8 RID: 11224
			private static readonly IntPtr NativeFieldInfoPtr_FixedElementField;

			// Token: 0x04002BD9 RID: 11225
			[FieldOffset(0)]
			public int FixedElementField;
		}
	}
}

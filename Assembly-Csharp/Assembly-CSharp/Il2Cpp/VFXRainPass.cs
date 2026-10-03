using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2Cpp
{
	// Token: 0x0200000A RID: 10
	public class VFXRainPass : ScriptableRenderPass
	{
		// Token: 0x06000067 RID: 103 RVA: 0x0007CC14 File Offset: 0x0007AE14
		// Note: this type is marked as 'beforefieldinit'.
		static VFXRainPass()
		{
			Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VFXRainPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr);
			VFXRainPass.NativeFieldInfoPtr__cameraColorTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr, "_cameraColorTarget");
			VFXRainPass.NativeFieldInfoPtr__cameraDepthTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr, "_cameraDepthTarget");
			VFXRainPass.NativeFieldInfoPtr__layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr, "_layerMask");
			VFXRainPass.NativeFieldInfoPtr__filteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr, "_filteringSettings");
			VFXRainPass.NativeFieldInfoPtr__shaderTagIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr, "_shaderTagIds");
			VFXRainPass.NativeMethodInfoPtr_Setup_Public_Void_Settings_RTHandle_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr, 100663331);
			VFXRainPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr, 100663332);
			VFXRainPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr, 100663333);
			VFXRainPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr, 100663334);
			VFXRainPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr, 100663335);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0007CD0C File Offset: 0x0007AF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65029, XrefRangeEnd = 65040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(VFXRainFeature.Settings settings, RTHandle cameraColorTarget, RTHandle cameraDepthTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraColorTarget);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraDepthTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXRainPass.NativeMethodInfoPtr_Setup_Public_Void_Settings_RTHandle_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0007CD74 File Offset: 0x0007AF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65040, XrefRangeEnd = 65041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXRainPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0007CDDC File Offset: 0x0007AFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65041, XrefRangeEnd = 65074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXRainPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0007CE40 File Offset: 0x0007B040
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXRainPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0007CE74 File Offset: 0x0007B074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65074, XrefRangeEnd = 65078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXRainPass() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXRainPass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXRainPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000023A4 File Offset: 0x000005A4
		public VFXRainPass(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0007CEB0 File Offset: 0x0007B0B0
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000023AD File Offset: 0x000005AD
		public unsafe RTHandle _cameraColorTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainPass.NativeFieldInfoPtr__cameraColorTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainPass.NativeFieldInfoPtr__cameraColorTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0007CEE0 File Offset: 0x0007B0E0
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000023CC File Offset: 0x000005CC
		public unsafe RTHandle _cameraDepthTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainPass.NativeFieldInfoPtr__cameraDepthTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainPass.NativeFieldInfoPtr__cameraDepthTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0007CF10 File Offset: 0x0007B110
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000023EB File Offset: 0x000005EB
		public unsafe LayerMask _layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainPass.NativeFieldInfoPtr__layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainPass.NativeFieldInfoPtr__layerMask)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0007CF38 File Offset: 0x0007B138
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002406 File Offset: 0x00000606
		public unsafe FilteringSettings _filteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainPass.NativeFieldInfoPtr__filteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainPass.NativeFieldInfoPtr__filteringSettings)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0007CF60 File Offset: 0x0007B160
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002421 File Offset: 0x00000621
		public unsafe static Il2CppStructArray<ShaderTagId> _shaderTagIds
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VFXRainPass.NativeFieldInfoPtr__shaderTagIds, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VFXRainPass.NativeFieldInfoPtr__shaderTagIds, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr__cameraColorTarget;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr__cameraDepthTarget;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr__layerMask;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr__filteringSettings;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr__shaderTagIds;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_Settings_RTHandle_RTHandle_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

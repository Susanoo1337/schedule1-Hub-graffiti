using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2Cpp
{
	// Token: 0x0200000C RID: 12
	public class ScheduleOneFogPass : ScriptableRenderPass
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0007D27C File Offset: 0x0007B47C
		// Note: this type is marked as 'beforefieldinit'.
		static ScheduleOneFogPass()
		{
			Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScheduleOneFogPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr);
			ScheduleOneFogPass.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, "_material");
			ScheduleOneFogPass.NativeFieldInfoPtr__cameraColorTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, "_cameraColorTarget");
			ScheduleOneFogPass.NativeFieldInfoPtr__tempTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, "_tempTexture");
			ScheduleOneFogPass.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, "_color");
			ScheduleOneFogPass.NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, "_start");
			ScheduleOneFogPass.NativeFieldInfoPtr__end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, "_end");
			ScheduleOneFogPass.NativeFieldInfoPtr__density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, "_density");
			ScheduleOneFogPass.NativeFieldInfoPtr__blurStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, "_blurStrength");
			ScheduleOneFogPass.NativeFieldInfoPtr__startHeightFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, "_startHeightFade");
			ScheduleOneFogPass.NativeFieldInfoPtr__endHeightFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, "_endHeightFade");
			ScheduleOneFogPass.NativeMethodInfoPtr__ctor_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, 100663343);
			ScheduleOneFogPass.NativeMethodInfoPtr_Setup_Public_Void_Settings_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, 100663344);
			ScheduleOneFogPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, 100663345);
			ScheduleOneFogPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, 100663346);
			ScheduleOneFogPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr, 100663347);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0007D3D8 File Offset: 0x0007B5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65129, XrefRangeEnd = 65134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScheduleOneFogPass(Material material) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduleOneFogPass>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduleOneFogPass.NativeMethodInfoPtr__ctor_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0007D424 File Offset: 0x0007B624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65134, XrefRangeEnd = 65136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(ScheduleOneFogFeature.Settings settings, RTHandle cameraColorTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameraColorTarget);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduleOneFogPass.NativeMethodInfoPtr_Setup_Public_Void_Settings_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0007D478 File Offset: 0x0007B678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65136, XrefRangeEnd = 65143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduleOneFogPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0007D4E0 File Offset: 0x0007B6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65143, XrefRangeEnd = 65200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref context;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduleOneFogPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0007D544 File Offset: 0x0007B744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65200, XrefRangeEnd = 65201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduleOneFogPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002499 File Offset: 0x00000699
		public ScheduleOneFogPass(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0007D578 File Offset: 0x0007B778
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000024A2 File Offset: 0x000006A2
		public unsafe Material _material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0007D5A8 File Offset: 0x0007B7A8
		// (set) Token: 0x0600008F RID: 143 RVA: 0x000024C1 File Offset: 0x000006C1
		public unsafe RTHandle _cameraColorTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__cameraColorTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__cameraColorTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0007D5D8 File Offset: 0x0007B7D8
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000024E0 File Offset: 0x000006E0
		public unsafe RTHandle _tempTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__tempTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__tempTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0007D608 File Offset: 0x0007B808
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000024FF File Offset: 0x000006FF
		public unsafe Color _color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__color)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0007D630 File Offset: 0x0007B830
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000251A File Offset: 0x0000071A
		public unsafe float _start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__start)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0007D658 File Offset: 0x0007B858
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002535 File Offset: 0x00000735
		public unsafe float _end
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__end);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__end)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0007D680 File Offset: 0x0007B880
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002550 File Offset: 0x00000750
		public unsafe float _density
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__density);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__density)) = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0007D6A8 File Offset: 0x0007B8A8
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000256B File Offset: 0x0000076B
		public unsafe float _blurStrength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__blurStrength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__blurStrength)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0007D6D0 File Offset: 0x0007B8D0
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002586 File Offset: 0x00000786
		public unsafe float _startHeightFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__startHeightFade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__startHeightFade)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0007D6F8 File Offset: 0x0007B8F8
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000025A1 File Offset: 0x000007A1
		public unsafe float _endHeightFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__endHeightFade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogPass.NativeFieldInfoPtr__endHeightFade)) = value;
			}
		}

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr__material;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr__cameraColorTarget;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr__tempTexture;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr__color;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr__start;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr__end;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr__density;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr__blurStrength;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr__startHeightFade;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr__endHeightFade;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Void_Settings_RTHandle_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
	}
}

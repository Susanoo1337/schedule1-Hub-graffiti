using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2Cpp
{
	// Token: 0x02000009 RID: 9
	public class VFXRainFeature : ScriptableRendererFeature
	{
		// Token: 0x0600005C RID: 92 RVA: 0x0007C964 File Offset: 0x0007AB64
		// Note: this type is marked as 'beforefieldinit'.
		static VFXRainFeature()
		{
			Il2CppClassPointerStore<VFXRainFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "VFXRainFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXRainFeature>.NativeClassPtr);
			VFXRainFeature.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXRainFeature>.NativeClassPtr, "_settings");
			VFXRainFeature.NativeFieldInfoPtr__pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXRainFeature>.NativeClassPtr, "_pass");
			VFXRainFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRainFeature>.NativeClassPtr, 100663325);
			VFXRainFeature.NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRainFeature>.NativeClassPtr, 100663326);
			VFXRainFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRainFeature>.NativeClassPtr, 100663327);
			VFXRainFeature.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRainFeature>.NativeClassPtr, 100663328);
			VFXRainFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRainFeature>.NativeClassPtr, 100663329);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0007CA20 File Offset: 0x0007AC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64992, XrefRangeEnd = 65000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXRainFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0007CA5C File Offset: 0x0007AC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65000, XrefRangeEnd = 65013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetupRenderPasses(ScriptableRenderer renderer, [In] ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXRainFeature.NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0007CAC4 File Offset: 0x0007ACC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65013, XrefRangeEnd = 65014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXRainFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0007CB2C File Offset: 0x0007AD2C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 65014, RefRangeEnd = 65022, XrefRangeStart = 65014, XrefRangeEnd = 65014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref disposing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VFXRainFeature.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0007CB78 File Offset: 0x0007AD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65022, XrefRangeEnd = 65029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXRainFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXRainFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXRainFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000235D File Offset: 0x0000055D
		public VFXRainFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0007CBB4 File Offset: 0x0007ADB4
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002366 File Offset: 0x00000566
		public unsafe VFXRainFeature.Settings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainFeature.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXRainFeature.Settings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainFeature.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0007CBE4 File Offset: 0x0007ADE4
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002385 File Offset: 0x00000585
		public unsafe VFXRainPass _pass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainFeature.NativeFieldInfoPtr__pass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXRainPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainFeature.NativeFieldInfoPtr__pass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr__pass;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200084C RID: 2124
		[Serializable]
		public class Settings : Il2CppSystem.Object
		{
			// Token: 0x0600CF51 RID: 53073 RVA: 0x00342180 File Offset: 0x00340380
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<VFXRainFeature.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VFXRainFeature>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXRainFeature.Settings>.NativeClassPtr);
				VFXRainFeature.Settings.NativeFieldInfoPtr_RenderPassEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXRainFeature.Settings>.NativeClassPtr, "RenderPassEvent");
				VFXRainFeature.Settings.NativeFieldInfoPtr_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXRainFeature.Settings>.NativeClassPtr, "LayerMask");
				VFXRainFeature.Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXRainFeature.Settings>.NativeClassPtr, 100663330);
			}

			// Token: 0x0600CF52 RID: 53074 RVA: 0x003421E8 File Offset: 0x003403E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64990, XrefRangeEnd = 64992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Settings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXRainFeature.Settings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXRainFeature.Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF53 RID: 53075 RVA: 0x0006215E File Offset: 0x0006035E
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EC2 RID: 16066
			// (get) Token: 0x0600CF54 RID: 53076 RVA: 0x00342224 File Offset: 0x00340424
			// (set) Token: 0x0600CF55 RID: 53077 RVA: 0x00062167 File Offset: 0x00060367
			public unsafe RenderPassEvent RenderPassEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainFeature.Settings.NativeFieldInfoPtr_RenderPassEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainFeature.Settings.NativeFieldInfoPtr_RenderPassEvent)) = value;
				}
			}

			// Token: 0x17003EC3 RID: 16067
			// (get) Token: 0x0600CF56 RID: 53078 RVA: 0x0034224C File Offset: 0x0034044C
			// (set) Token: 0x0600CF57 RID: 53079 RVA: 0x00062182 File Offset: 0x00060382
			public unsafe LayerMask LayerMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainFeature.Settings.NativeFieldInfoPtr_LayerMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXRainFeature.Settings.NativeFieldInfoPtr_LayerMask)) = value;
				}
			}

			// Token: 0x04008D66 RID: 36198
			private static readonly IntPtr NativeFieldInfoPtr_RenderPassEvent;

			// Token: 0x04008D67 RID: 36199
			private static readonly IntPtr NativeFieldInfoPtr_LayerMask;

			// Token: 0x04008D68 RID: 36200
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

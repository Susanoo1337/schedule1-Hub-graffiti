using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Il2Cpp
{
	// Token: 0x02000019 RID: 25
	public class GrabScreenFeature : ScriptableRendererFeature
	{
		// Token: 0x0600013E RID: 318 RVA: 0x0007F3D0 File Offset: 0x0007D5D0
		// Note: this type is marked as 'beforefieldinit'.
		static GrabScreenFeature()
		{
			Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GrabScreenFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr);
			GrabScreenFeature.NativeFieldInfoPtr_grabPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr, "grabPass");
			GrabScreenFeature.NativeFieldInfoPtr_renderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr, "renderPass");
			GrabScreenFeature.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr, "settings");
			GrabScreenFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr, 100663420);
			GrabScreenFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr, 100663421);
			GrabScreenFeature.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr, 100663422);
			GrabScreenFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr, 100663423);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0007F48C File Offset: 0x0007D68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66293, XrefRangeEnd = 66308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrabScreenFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0007F4C8 File Offset: 0x0007D6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66308, XrefRangeEnd = 66311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrabScreenFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0007F530 File Offset: 0x0007D730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66311, XrefRangeEnd = 66312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref disposing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrabScreenFeature.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0007F57C File Offset: 0x0007D77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66312, XrefRangeEnd = 66322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrabScreenFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrabScreenFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public GrabScreenFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0007F5B8 File Offset: 0x0007D7B8
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00002B01 File Offset: 0x00000D01
		public unsafe GrabScreenFeature.GrabPass grabPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.NativeFieldInfoPtr_grabPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrabScreenFeature.GrabPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.NativeFieldInfoPtr_grabPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0007F5E8 File Offset: 0x0007D7E8
		// (set) Token: 0x06000147 RID: 327 RVA: 0x00002B20 File Offset: 0x00000D20
		public unsafe GrabScreenFeature.RenderPass renderPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.NativeFieldInfoPtr_renderPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrabScreenFeature.RenderPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.NativeFieldInfoPtr_renderPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0007F618 File Offset: 0x0007D818
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00002B3F File Offset: 0x00000D3F
		public unsafe GrabScreenFeature.Settings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrabScreenFeature.Settings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_grabPass;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_renderPass;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000856 RID: 2134
		[Serializable]
		public class Settings : Il2CppSystem.Object
		{
			// Token: 0x0600CFC5 RID: 53189 RVA: 0x003433F0 File Offset: 0x003415F0
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<GrabScreenFeature.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrabScreenFeature.Settings>.NativeClassPtr);
				GrabScreenFeature.Settings.NativeFieldInfoPtr_TextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature.Settings>.NativeClassPtr, "TextureName");
				GrabScreenFeature.Settings.NativeFieldInfoPtr_RenderPassEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature.Settings>.NativeClassPtr, "RenderPassEvent");
				GrabScreenFeature.Settings.NativeFieldInfoPtr_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature.Settings>.NativeClassPtr, "LayerMask");
				GrabScreenFeature.Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabScreenFeature.Settings>.NativeClassPtr, 100663424);
			}

			// Token: 0x0600CFC6 RID: 53190 RVA: 0x0034346C File Offset: 0x0034166C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66198, XrefRangeEnd = 66203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Settings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrabScreenFeature.Settings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrabScreenFeature.Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFC7 RID: 53191 RVA: 0x000625CF File Offset: 0x000607CF
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EED RID: 16109
			// (get) Token: 0x0600CFC8 RID: 53192 RVA: 0x003434A8 File Offset: 0x003416A8
			// (set) Token: 0x0600CFC9 RID: 53193 RVA: 0x000625D8 File Offset: 0x000607D8
			public unsafe string TextureName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.Settings.NativeFieldInfoPtr_TextureName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.Settings.NativeFieldInfoPtr_TextureName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003EEE RID: 16110
			// (get) Token: 0x0600CFCA RID: 53194 RVA: 0x003434D0 File Offset: 0x003416D0
			// (set) Token: 0x0600CFCB RID: 53195 RVA: 0x000625F7 File Offset: 0x000607F7
			public unsafe RenderPassEvent RenderPassEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.Settings.NativeFieldInfoPtr_RenderPassEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.Settings.NativeFieldInfoPtr_RenderPassEvent)) = value;
				}
			}

			// Token: 0x17003EEF RID: 16111
			// (get) Token: 0x0600CFCC RID: 53196 RVA: 0x003434F8 File Offset: 0x003416F8
			// (set) Token: 0x0600CFCD RID: 53197 RVA: 0x00062612 File Offset: 0x00060812
			public unsafe LayerMask LayerMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.Settings.NativeFieldInfoPtr_LayerMask);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.Settings.NativeFieldInfoPtr_LayerMask)) = value;
				}
			}

			// Token: 0x04008DAB RID: 36267
			private static readonly IntPtr NativeFieldInfoPtr_TextureName;

			// Token: 0x04008DAC RID: 36268
			private static readonly IntPtr NativeFieldInfoPtr_RenderPassEvent;

			// Token: 0x04008DAD RID: 36269
			private static readonly IntPtr NativeFieldInfoPtr_LayerMask;

			// Token: 0x04008DAE RID: 36270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000857 RID: 2135
		public class GrabPass : ScriptableRenderPass
		{
			// Token: 0x0600CFCE RID: 53198 RVA: 0x00343520 File Offset: 0x00341720
			// Note: this type is marked as 'beforefieldinit'.
			static GrabPass()
			{
				Il2CppClassPointerStore<GrabScreenFeature.GrabPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr, "GrabPass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrabScreenFeature.GrabPass>.NativeClassPtr);
				GrabScreenFeature.GrabPass.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature.GrabPass>.NativeClassPtr, "settings");
				GrabScreenFeature.GrabPass.NativeFieldInfoPtr_m_GrabbedTextureHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature.GrabPass>.NativeClassPtr, "m_GrabbedTextureHandle");
				GrabScreenFeature.GrabPass.NativeFieldInfoPtr_m_CameraColorHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature.GrabPass>.NativeClassPtr, "m_CameraColorHandle");
				GrabScreenFeature.GrabPass.NativeMethodInfoPtr__ctor_Public_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabScreenFeature.GrabPass>.NativeClassPtr, 100663425);
				GrabScreenFeature.GrabPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabScreenFeature.GrabPass>.NativeClassPtr, 100663426);
				GrabScreenFeature.GrabPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabScreenFeature.GrabPass>.NativeClassPtr, 100663427);
				GrabScreenFeature.GrabPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabScreenFeature.GrabPass>.NativeClassPtr, 100663428);
			}

			// Token: 0x0600CFCF RID: 53199 RVA: 0x003435D8 File Offset: 0x003417D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66203, XrefRangeEnd = 66208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GrabPass(GrabScreenFeature.Settings s) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrabScreenFeature.GrabPass>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrabScreenFeature.GrabPass.NativeMethodInfoPtr__ctor_Public_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFD0 RID: 53200 RVA: 0x00343624 File Offset: 0x00341824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66208, XrefRangeEnd = 66217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrabScreenFeature.GrabPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFD1 RID: 53201 RVA: 0x0034368C File Offset: 0x0034188C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66217, XrefRangeEnd = 66234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref context;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrabScreenFeature.GrabPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFD2 RID: 53202 RVA: 0x003436F0 File Offset: 0x003418F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66234, XrefRangeEnd = 66235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrabScreenFeature.GrabPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFD3 RID: 53203 RVA: 0x0006262D File Offset: 0x0006082D
			public GrabPass(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF0 RID: 16112
			// (get) Token: 0x0600CFD4 RID: 53204 RVA: 0x00343724 File Offset: 0x00341924
			// (set) Token: 0x0600CFD5 RID: 53205 RVA: 0x00062636 File Offset: 0x00060836
			public unsafe GrabScreenFeature.Settings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.GrabPass.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrabScreenFeature.Settings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.GrabPass.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EF1 RID: 16113
			// (get) Token: 0x0600CFD6 RID: 53206 RVA: 0x00343754 File Offset: 0x00341954
			// (set) Token: 0x0600CFD7 RID: 53207 RVA: 0x00062655 File Offset: 0x00060855
			public unsafe RTHandle m_GrabbedTextureHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.GrabPass.NativeFieldInfoPtr_m_GrabbedTextureHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.GrabPass.NativeFieldInfoPtr_m_GrabbedTextureHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EF2 RID: 16114
			// (get) Token: 0x0600CFD8 RID: 53208 RVA: 0x00343784 File Offset: 0x00341984
			// (set) Token: 0x0600CFD9 RID: 53209 RVA: 0x00062674 File Offset: 0x00060874
			public unsafe RTHandle m_CameraColorHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.GrabPass.NativeFieldInfoPtr_m_CameraColorHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.GrabPass.NativeFieldInfoPtr_m_CameraColorHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DAF RID: 36271
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x04008DB0 RID: 36272
			private static readonly IntPtr NativeFieldInfoPtr_m_GrabbedTextureHandle;

			// Token: 0x04008DB1 RID: 36273
			private static readonly IntPtr NativeFieldInfoPtr_m_CameraColorHandle;

			// Token: 0x04008DB2 RID: 36274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Settings_0;

			// Token: 0x04008DB3 RID: 36275
			private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

			// Token: 0x04008DB4 RID: 36276
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

			// Token: 0x04008DB5 RID: 36277
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
		}

		// Token: 0x02000858 RID: 2136
		public class RenderPass : ScriptableRenderPass
		{
			// Token: 0x0600CFDA RID: 53210 RVA: 0x003437B4 File Offset: 0x003419B4
			// Note: this type is marked as 'beforefieldinit'.
			static RenderPass()
			{
				Il2CppClassPointerStore<GrabScreenFeature.RenderPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrabScreenFeature>.NativeClassPtr, "RenderPass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrabScreenFeature.RenderPass>.NativeClassPtr);
				GrabScreenFeature.RenderPass.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature.RenderPass>.NativeClassPtr, "settings");
				GrabScreenFeature.RenderPass.NativeFieldInfoPtr_m_ShaderTagIdList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature.RenderPass>.NativeClassPtr, "m_ShaderTagIdList");
				GrabScreenFeature.RenderPass.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature.RenderPass>.NativeClassPtr, "m_FilteringSettings");
				GrabScreenFeature.RenderPass.NativeFieldInfoPtr_m_RenderStateBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabScreenFeature.RenderPass>.NativeClassPtr, "m_RenderStateBlock");
				GrabScreenFeature.RenderPass.NativeMethodInfoPtr__ctor_Public_Void_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabScreenFeature.RenderPass>.NativeClassPtr, 100663429);
				GrabScreenFeature.RenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrabScreenFeature.RenderPass>.NativeClassPtr, 100663430);
			}

			// Token: 0x0600CFDB RID: 53211 RVA: 0x00343858 File Offset: 0x00341A58
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 66276, RefRangeEnd = 66277, XrefRangeStart = 66235, XrefRangeEnd = 66276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RenderPass(GrabScreenFeature.Settings settings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrabScreenFeature.RenderPass>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrabScreenFeature.RenderPass.NativeMethodInfoPtr__ctor_Public_Void_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFDC RID: 53212 RVA: 0x003438A4 File Offset: 0x00341AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66277, XrefRangeEnd = 66293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref context;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrabScreenFeature.RenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFDD RID: 53213 RVA: 0x00062693 File Offset: 0x00060893
			public RenderPass(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EF3 RID: 16115
			// (get) Token: 0x0600CFDE RID: 53214 RVA: 0x00343908 File Offset: 0x00341B08
			// (set) Token: 0x0600CFDF RID: 53215 RVA: 0x0006269C File Offset: 0x0006089C
			public unsafe GrabScreenFeature.Settings settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.RenderPass.NativeFieldInfoPtr_settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrabScreenFeature.Settings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.RenderPass.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EF4 RID: 16116
			// (get) Token: 0x0600CFE0 RID: 53216 RVA: 0x00343938 File Offset: 0x00341B38
			// (set) Token: 0x0600CFE1 RID: 53217 RVA: 0x000626BB File Offset: 0x000608BB
			public unsafe List<ShaderTagId> m_ShaderTagIdList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.RenderPass.NativeFieldInfoPtr_m_ShaderTagIdList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.RenderPass.NativeFieldInfoPtr_m_ShaderTagIdList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EF5 RID: 16117
			// (get) Token: 0x0600CFE2 RID: 53218 RVA: 0x00343968 File Offset: 0x00341B68
			// (set) Token: 0x0600CFE3 RID: 53219 RVA: 0x000626DA File Offset: 0x000608DA
			public unsafe FilteringSettings m_FilteringSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.RenderPass.NativeFieldInfoPtr_m_FilteringSettings);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.RenderPass.NativeFieldInfoPtr_m_FilteringSettings)) = value;
				}
			}

			// Token: 0x17003EF6 RID: 16118
			// (get) Token: 0x0600CFE4 RID: 53220 RVA: 0x00343990 File Offset: 0x00341B90
			// (set) Token: 0x0600CFE5 RID: 53221 RVA: 0x000626F5 File Offset: 0x000608F5
			public unsafe RenderStateBlock m_RenderStateBlock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.RenderPass.NativeFieldInfoPtr_m_RenderStateBlock);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrabScreenFeature.RenderPass.NativeFieldInfoPtr_m_RenderStateBlock)) = value;
				}
			}

			// Token: 0x04008DB6 RID: 36278
			private static readonly IntPtr NativeFieldInfoPtr_settings;

			// Token: 0x04008DB7 RID: 36279
			private static readonly IntPtr NativeFieldInfoPtr_m_ShaderTagIdList;

			// Token: 0x04008DB8 RID: 36280
			private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

			// Token: 0x04008DB9 RID: 36281
			private static readonly IntPtr NativeFieldInfoPtr_m_RenderStateBlock;

			// Token: 0x04008DBA RID: 36282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Settings_0;

			// Token: 0x04008DBB RID: 36283
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;
		}
	}
}

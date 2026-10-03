using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000E3 RID: 227
	public sealed class CustomRenderTexture : RenderTexture
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x00051C48 File Offset: 0x0004FE48
		// Note: this type is marked as 'beforefieldinit'.
		static CustomRenderTexture()
		{
			Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CustomRenderTexture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr);
			CustomRenderTexture.Internal_CreateCustomRenderTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.Internal_CreateCustomRenderTextureDelegate>("UnityEngine.CustomRenderTexture::Internal_CreateCustomRenderTexture");
			CustomRenderTexture.TriggerUpdateDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.TriggerUpdateDelegate>("UnityEngine.CustomRenderTexture::TriggerUpdate");
			CustomRenderTexture.TriggerInitializationDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.TriggerInitializationDelegate>("UnityEngine.CustomRenderTexture::TriggerInitialization");
			CustomRenderTexture.ClearUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.ClearUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::ClearUpdateZones");
			CustomRenderTexture.get_materialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_materialDelegate>("UnityEngine.CustomRenderTexture::get_material");
			CustomRenderTexture.set_materialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_materialDelegate>("UnityEngine.CustomRenderTexture::set_material");
			CustomRenderTexture.get_initializationMaterialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationMaterialDelegate>("UnityEngine.CustomRenderTexture::get_initializationMaterial");
			CustomRenderTexture.set_initializationMaterialDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationMaterialDelegate>("UnityEngine.CustomRenderTexture::set_initializationMaterial");
			CustomRenderTexture.get_initializationTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationTextureDelegate>("UnityEngine.CustomRenderTexture::get_initializationTexture");
			CustomRenderTexture.set_initializationTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationTextureDelegate>("UnityEngine.CustomRenderTexture::set_initializationTexture");
			CustomRenderTexture.GetUpdateZonesInternalDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.GetUpdateZonesInternalDelegate>("UnityEngine.CustomRenderTexture::GetUpdateZonesInternal");
			CustomRenderTexture.GetDoubleBufferRenderTextureDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.GetDoubleBufferRenderTextureDelegate>("UnityEngine.CustomRenderTexture::GetDoubleBufferRenderTexture");
			CustomRenderTexture.EnsureDoubleBufferConsistencyDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.EnsureDoubleBufferConsistencyDelegate>("UnityEngine.CustomRenderTexture::EnsureDoubleBufferConsistency");
			CustomRenderTexture.get_initializationSourceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationSourceDelegate>("UnityEngine.CustomRenderTexture::get_initializationSource");
			CustomRenderTexture.set_initializationSourceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationSourceDelegate>("UnityEngine.CustomRenderTexture::set_initializationSource");
			CustomRenderTexture.get_updateModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updateModeDelegate>("UnityEngine.CustomRenderTexture::get_updateMode");
			CustomRenderTexture.set_updateModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updateModeDelegate>("UnityEngine.CustomRenderTexture::set_updateMode");
			CustomRenderTexture.get_initializationModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationModeDelegate>("UnityEngine.CustomRenderTexture::get_initializationMode");
			CustomRenderTexture.set_initializationModeDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationModeDelegate>("UnityEngine.CustomRenderTexture::set_initializationMode");
			CustomRenderTexture.get_updateZoneSpaceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updateZoneSpaceDelegate>("UnityEngine.CustomRenderTexture::get_updateZoneSpace");
			CustomRenderTexture.set_updateZoneSpaceDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updateZoneSpaceDelegate>("UnityEngine.CustomRenderTexture::set_updateZoneSpace");
			CustomRenderTexture.get_shaderPassDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_shaderPassDelegate>("UnityEngine.CustomRenderTexture::get_shaderPass");
			CustomRenderTexture.set_shaderPassDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_shaderPassDelegate>("UnityEngine.CustomRenderTexture::set_shaderPass");
			CustomRenderTexture.get_cubemapFaceMaskDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_cubemapFaceMaskDelegate>("UnityEngine.CustomRenderTexture::get_cubemapFaceMask");
			CustomRenderTexture.set_cubemapFaceMaskDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_cubemapFaceMaskDelegate>("UnityEngine.CustomRenderTexture::set_cubemapFaceMask");
			CustomRenderTexture.get_doubleBufferedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_doubleBufferedDelegate>("UnityEngine.CustomRenderTexture::get_doubleBuffered");
			CustomRenderTexture.set_doubleBufferedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_doubleBufferedDelegate>("UnityEngine.CustomRenderTexture::set_doubleBuffered");
			CustomRenderTexture.get_wrapUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_wrapUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::get_wrapUpdateZones");
			CustomRenderTexture.set_wrapUpdateZonesDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_wrapUpdateZonesDelegate>("UnityEngine.CustomRenderTexture::set_wrapUpdateZones");
			CustomRenderTexture.get_updatePeriodDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_updatePeriodDelegate>("UnityEngine.CustomRenderTexture::get_updatePeriod");
			CustomRenderTexture.set_updatePeriodDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_updatePeriodDelegate>("UnityEngine.CustomRenderTexture::set_updatePeriod");
			CustomRenderTexture.get_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.get_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationColor_Injected");
			CustomRenderTexture.set_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<CustomRenderTexture.set_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationColor_Injected");
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0000A297 File Offset: 0x00008497
		public CustomRenderTexture(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0000A2A0 File Offset: 0x000084A0
		public static void Internal_CreateCustomRenderTexture(CustomRenderTexture rt)
		{
			CustomRenderTexture.Internal_CreateCustomRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rt));
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0000A2B2 File Offset: 0x000084B2
		public void TriggerUpdate(int count)
		{
			CustomRenderTexture.TriggerUpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), count);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0000A2C5 File Offset: 0x000084C5
		public void Update(int count)
		{
			CustomRenderTextureManager.InvokeTriggerUpdate(this, count);
			this.TriggerUpdate(count);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0000A2D8 File Offset: 0x000084D8
		public void Update()
		{
			this.Update(1);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0000A2E3 File Offset: 0x000084E3
		public void TriggerInitialization()
		{
			CustomRenderTexture.TriggerInitializationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0000A2F5 File Offset: 0x000084F5
		public void Initialize()
		{
			this.TriggerInitialization();
			CustomRenderTextureManager.InvokeTriggerInitialize(this);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0000A306 File Offset: 0x00008506
		public void ClearUpdateZones()
		{
			CustomRenderTexture.ClearUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00051E68 File Offset: 0x00050068
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x0000A318 File Offset: 0x00008518
		public Material material
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00051E94 File Offset: 0x00050094
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x0000A330 File Offset: 0x00008530
		public Material initializationMaterial
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_initializationMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_initializationMaterialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x00051EC0 File Offset: 0x000500C0
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x0000A348 File Offset: 0x00008548
		public Texture initializationTexture
		{
			get
			{
				IntPtr intPtr = CustomRenderTexture.get_initializationTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				CustomRenderTexture.set_initializationTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0000A360 File Offset: 0x00008560
		public void GetUpdateZonesInternal(Object updateZones)
		{
			CustomRenderTexture.GetUpdateZonesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(updateZones));
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00051EEC File Offset: 0x000500EC
		public RenderTexture GetDoubleBufferRenderTexture()
		{
			IntPtr intPtr = CustomRenderTexture.GetDoubleBufferRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0000A378 File Offset: 0x00008578
		public void EnsureDoubleBufferConsistency()
		{
			CustomRenderTexture.EnsureDoubleBufferConsistencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x0000A38A File Offset: 0x0000858A
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x0000A39C File Offset: 0x0000859C
		public CustomRenderTextureInitializationSource initializationSource
		{
			get
			{
				return CustomRenderTexture.get_initializationSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_initializationSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x00051F18 File Offset: 0x00050118
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x0000A3AF File Offset: 0x000085AF
		public Color initializationColor
		{
			get
			{
				Color result;
				this.get_initializationColor_Injected(out result);
				return result;
			}
			set
			{
				this.set_initializationColor_Injected(ref value);
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x0000A3B9 File Offset: 0x000085B9
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x0000A3CB File Offset: 0x000085CB
		public CustomRenderTextureUpdateMode updateMode
		{
			get
			{
				return CustomRenderTexture.get_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updateModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x0000A3DE File Offset: 0x000085DE
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x0000A3F0 File Offset: 0x000085F0
		public CustomRenderTextureUpdateMode initializationMode
		{
			get
			{
				return CustomRenderTexture.get_initializationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_initializationModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x0000A403 File Offset: 0x00008603
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x0000A415 File Offset: 0x00008615
		public CustomRenderTextureUpdateZoneSpace updateZoneSpace
		{
			get
			{
				return CustomRenderTexture.get_updateZoneSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updateZoneSpaceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x0000A428 File Offset: 0x00008628
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x0000A43A File Offset: 0x0000863A
		public int shaderPass
		{
			get
			{
				return CustomRenderTexture.get_shaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_shaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x0000A44D File Offset: 0x0000864D
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x0000A45F File Offset: 0x0000865F
		public uint cubemapFaceMask
		{
			get
			{
				return CustomRenderTexture.get_cubemapFaceMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_cubemapFaceMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0000A472 File Offset: 0x00008672
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x0000A484 File Offset: 0x00008684
		public bool doubleBuffered
		{
			get
			{
				return CustomRenderTexture.get_doubleBufferedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_doubleBufferedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0000A497 File Offset: 0x00008697
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x0000A4A9 File Offset: 0x000086A9
		public bool wrapUpdateZones
		{
			get
			{
				return CustomRenderTexture.get_wrapUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_wrapUpdateZonesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x0000A4BC File Offset: 0x000086BC
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x0000A4CE File Offset: 0x000086CE
		public float updatePeriod
		{
			get
			{
				return CustomRenderTexture.get_updatePeriodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CustomRenderTexture.set_updatePeriodDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0000A4E1 File Offset: 0x000086E1
		public void get_initializationColor_Injected(out Color ret)
		{
			CustomRenderTexture.get_initializationColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0000A4F4 File Offset: 0x000086F4
		public void set_initializationColor_Injected(ref Color value)
		{
			CustomRenderTexture.set_initializationColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000EAD RID: 3757
		private static readonly CustomRenderTexture.Internal_CreateCustomRenderTextureDelegate Internal_CreateCustomRenderTextureDelegateField;

		// Token: 0x04000EAE RID: 3758
		private static readonly CustomRenderTexture.TriggerUpdateDelegate TriggerUpdateDelegateField;

		// Token: 0x04000EAF RID: 3759
		private static readonly CustomRenderTexture.TriggerInitializationDelegate TriggerInitializationDelegateField;

		// Token: 0x04000EB0 RID: 3760
		private static readonly CustomRenderTexture.ClearUpdateZonesDelegate ClearUpdateZonesDelegateField;

		// Token: 0x04000EB1 RID: 3761
		private static readonly CustomRenderTexture.get_materialDelegate get_materialDelegateField;

		// Token: 0x04000EB2 RID: 3762
		private static readonly CustomRenderTexture.set_materialDelegate set_materialDelegateField;

		// Token: 0x04000EB3 RID: 3763
		private static readonly CustomRenderTexture.get_initializationMaterialDelegate get_initializationMaterialDelegateField;

		// Token: 0x04000EB4 RID: 3764
		private static readonly CustomRenderTexture.set_initializationMaterialDelegate set_initializationMaterialDelegateField;

		// Token: 0x04000EB5 RID: 3765
		private static readonly CustomRenderTexture.get_initializationTextureDelegate get_initializationTextureDelegateField;

		// Token: 0x04000EB6 RID: 3766
		private static readonly CustomRenderTexture.set_initializationTextureDelegate set_initializationTextureDelegateField;

		// Token: 0x04000EB7 RID: 3767
		private static readonly CustomRenderTexture.GetUpdateZonesInternalDelegate GetUpdateZonesInternalDelegateField;

		// Token: 0x04000EB8 RID: 3768
		private static readonly CustomRenderTexture.GetDoubleBufferRenderTextureDelegate GetDoubleBufferRenderTextureDelegateField;

		// Token: 0x04000EB9 RID: 3769
		private static readonly CustomRenderTexture.EnsureDoubleBufferConsistencyDelegate EnsureDoubleBufferConsistencyDelegateField;

		// Token: 0x04000EBA RID: 3770
		private static readonly CustomRenderTexture.get_initializationSourceDelegate get_initializationSourceDelegateField;

		// Token: 0x04000EBB RID: 3771
		private static readonly CustomRenderTexture.set_initializationSourceDelegate set_initializationSourceDelegateField;

		// Token: 0x04000EBC RID: 3772
		private static readonly CustomRenderTexture.get_updateModeDelegate get_updateModeDelegateField;

		// Token: 0x04000EBD RID: 3773
		private static readonly CustomRenderTexture.set_updateModeDelegate set_updateModeDelegateField;

		// Token: 0x04000EBE RID: 3774
		private static readonly CustomRenderTexture.get_initializationModeDelegate get_initializationModeDelegateField;

		// Token: 0x04000EBF RID: 3775
		private static readonly CustomRenderTexture.set_initializationModeDelegate set_initializationModeDelegateField;

		// Token: 0x04000EC0 RID: 3776
		private static readonly CustomRenderTexture.get_updateZoneSpaceDelegate get_updateZoneSpaceDelegateField;

		// Token: 0x04000EC1 RID: 3777
		private static readonly CustomRenderTexture.set_updateZoneSpaceDelegate set_updateZoneSpaceDelegateField;

		// Token: 0x04000EC2 RID: 3778
		private static readonly CustomRenderTexture.get_shaderPassDelegate get_shaderPassDelegateField;

		// Token: 0x04000EC3 RID: 3779
		private static readonly CustomRenderTexture.set_shaderPassDelegate set_shaderPassDelegateField;

		// Token: 0x04000EC4 RID: 3780
		private static readonly CustomRenderTexture.get_cubemapFaceMaskDelegate get_cubemapFaceMaskDelegateField;

		// Token: 0x04000EC5 RID: 3781
		private static readonly CustomRenderTexture.set_cubemapFaceMaskDelegate set_cubemapFaceMaskDelegateField;

		// Token: 0x04000EC6 RID: 3782
		private static readonly CustomRenderTexture.get_doubleBufferedDelegate get_doubleBufferedDelegateField;

		// Token: 0x04000EC7 RID: 3783
		private static readonly CustomRenderTexture.set_doubleBufferedDelegate set_doubleBufferedDelegateField;

		// Token: 0x04000EC8 RID: 3784
		private static readonly CustomRenderTexture.get_wrapUpdateZonesDelegate get_wrapUpdateZonesDelegateField;

		// Token: 0x04000EC9 RID: 3785
		private static readonly CustomRenderTexture.set_wrapUpdateZonesDelegate set_wrapUpdateZonesDelegateField;

		// Token: 0x04000ECA RID: 3786
		private static readonly CustomRenderTexture.get_updatePeriodDelegate get_updatePeriodDelegateField;

		// Token: 0x04000ECB RID: 3787
		private static readonly CustomRenderTexture.set_updatePeriodDelegate set_updatePeriodDelegateField;

		// Token: 0x04000ECC RID: 3788
		private static readonly CustomRenderTexture.get_initializationColor_InjectedDelegate get_initializationColor_InjectedDelegateField;

		// Token: 0x04000ECD RID: 3789
		private static readonly CustomRenderTexture.set_initializationColor_InjectedDelegate set_initializationColor_InjectedDelegateField;

		// Token: 0x0200084B RID: 2123
		// (Invoke) Token: 0x06003928 RID: 14632
		private delegate void Internal_CreateCustomRenderTextureDelegate(IntPtr rt);

		// Token: 0x0200084C RID: 2124
		// (Invoke) Token: 0x0600392A RID: 14634
		private delegate void TriggerUpdateDelegate(IntPtr @this, int count);

		// Token: 0x0200084D RID: 2125
		// (Invoke) Token: 0x0600392C RID: 14636
		private delegate void TriggerInitializationDelegate(IntPtr @this);

		// Token: 0x0200084E RID: 2126
		// (Invoke) Token: 0x0600392E RID: 14638
		private delegate void ClearUpdateZonesDelegate(IntPtr @this);

		// Token: 0x0200084F RID: 2127
		// (Invoke) Token: 0x06003930 RID: 14640
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000850 RID: 2128
		// (Invoke) Token: 0x06003932 RID: 14642
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000851 RID: 2129
		// (Invoke) Token: 0x06003934 RID: 14644
		private delegate IntPtr get_initializationMaterialDelegate(IntPtr @this);

		// Token: 0x02000852 RID: 2130
		// (Invoke) Token: 0x06003936 RID: 14646
		private delegate void set_initializationMaterialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000853 RID: 2131
		// (Invoke) Token: 0x06003938 RID: 14648
		private delegate IntPtr get_initializationTextureDelegate(IntPtr @this);

		// Token: 0x02000854 RID: 2132
		// (Invoke) Token: 0x0600393A RID: 14650
		private delegate void set_initializationTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000855 RID: 2133
		// (Invoke) Token: 0x0600393C RID: 14652
		private delegate void GetUpdateZonesInternalDelegate(IntPtr @this, IntPtr updateZones);

		// Token: 0x02000856 RID: 2134
		// (Invoke) Token: 0x0600393E RID: 14654
		private delegate IntPtr GetDoubleBufferRenderTextureDelegate(IntPtr @this);

		// Token: 0x02000857 RID: 2135
		// (Invoke) Token: 0x06003940 RID: 14656
		private delegate void EnsureDoubleBufferConsistencyDelegate(IntPtr @this);

		// Token: 0x02000858 RID: 2136
		// (Invoke) Token: 0x06003942 RID: 14658
		private delegate CustomRenderTextureInitializationSource get_initializationSourceDelegate(IntPtr @this);

		// Token: 0x02000859 RID: 2137
		// (Invoke) Token: 0x06003944 RID: 14660
		private delegate void set_initializationSourceDelegate(IntPtr @this, CustomRenderTextureInitializationSource value);

		// Token: 0x0200085A RID: 2138
		// (Invoke) Token: 0x06003946 RID: 14662
		private delegate CustomRenderTextureUpdateMode get_updateModeDelegate(IntPtr @this);

		// Token: 0x0200085B RID: 2139
		// (Invoke) Token: 0x06003948 RID: 14664
		private delegate void set_updateModeDelegate(IntPtr @this, CustomRenderTextureUpdateMode value);

		// Token: 0x0200085C RID: 2140
		// (Invoke) Token: 0x0600394A RID: 14666
		private delegate CustomRenderTextureUpdateMode get_initializationModeDelegate(IntPtr @this);

		// Token: 0x0200085D RID: 2141
		// (Invoke) Token: 0x0600394C RID: 14668
		private delegate void set_initializationModeDelegate(IntPtr @this, CustomRenderTextureUpdateMode value);

		// Token: 0x0200085E RID: 2142
		// (Invoke) Token: 0x0600394E RID: 14670
		private delegate CustomRenderTextureUpdateZoneSpace get_updateZoneSpaceDelegate(IntPtr @this);

		// Token: 0x0200085F RID: 2143
		// (Invoke) Token: 0x06003950 RID: 14672
		private delegate void set_updateZoneSpaceDelegate(IntPtr @this, CustomRenderTextureUpdateZoneSpace value);

		// Token: 0x02000860 RID: 2144
		// (Invoke) Token: 0x06003952 RID: 14674
		private delegate int get_shaderPassDelegate(IntPtr @this);

		// Token: 0x02000861 RID: 2145
		// (Invoke) Token: 0x06003954 RID: 14676
		private delegate void set_shaderPassDelegate(IntPtr @this, int value);

		// Token: 0x02000862 RID: 2146
		// (Invoke) Token: 0x06003956 RID: 14678
		private delegate uint get_cubemapFaceMaskDelegate(IntPtr @this);

		// Token: 0x02000863 RID: 2147
		// (Invoke) Token: 0x06003958 RID: 14680
		private delegate void set_cubemapFaceMaskDelegate(IntPtr @this, uint value);

		// Token: 0x02000864 RID: 2148
		// (Invoke) Token: 0x0600395A RID: 14682
		private delegate bool get_doubleBufferedDelegate(IntPtr @this);

		// Token: 0x02000865 RID: 2149
		// (Invoke) Token: 0x0600395C RID: 14684
		private delegate void set_doubleBufferedDelegate(IntPtr @this, bool value);

		// Token: 0x02000866 RID: 2150
		// (Invoke) Token: 0x0600395E RID: 14686
		private delegate bool get_wrapUpdateZonesDelegate(IntPtr @this);

		// Token: 0x02000867 RID: 2151
		// (Invoke) Token: 0x06003960 RID: 14688
		private delegate void set_wrapUpdateZonesDelegate(IntPtr @this, bool value);

		// Token: 0x02000868 RID: 2152
		// (Invoke) Token: 0x06003962 RID: 14690
		private delegate float get_updatePeriodDelegate(IntPtr @this);

		// Token: 0x02000869 RID: 2153
		// (Invoke) Token: 0x06003964 RID: 14692
		private delegate void set_updatePeriodDelegate(IntPtr @this, float value);

		// Token: 0x0200086A RID: 2154
		// (Invoke) Token: 0x06003966 RID: 14694
		private delegate void get_initializationColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200086B RID: 2155
		// (Invoke) Token: 0x06003968 RID: 14696
		private delegate void set_initializationColor_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}

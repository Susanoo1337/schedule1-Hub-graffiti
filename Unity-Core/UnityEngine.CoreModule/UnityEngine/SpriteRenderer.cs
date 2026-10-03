using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace UnityEngine
{
	// Token: 0x02000170 RID: 368
	public sealed class SpriteRenderer : Renderer
	{
		// Token: 0x06001C89 RID: 7305 RVA: 0x00076A84 File Offset: 0x00074C84
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteRenderer()
		{
			Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SpriteRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr);
			SpriteRenderer.NativeFieldInfoPtr_m_SpriteChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, "m_SpriteChangeEvent");
			SpriteRenderer.NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100666389);
			SpriteRenderer.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100666390);
			SpriteRenderer.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100666391);
			SpriteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100666392);
			SpriteRenderer.get_shouldSupportTilingDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_shouldSupportTilingDelegate>("UnityEngine.SpriteRenderer::get_shouldSupportTiling");
			SpriteRenderer.get_hasSpriteChangeEventsDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_hasSpriteChangeEventsDelegate>("UnityEngine.SpriteRenderer::get_hasSpriteChangeEvents");
			SpriteRenderer.set_hasSpriteChangeEventsDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_hasSpriteChangeEventsDelegate>("UnityEngine.SpriteRenderer::set_hasSpriteChangeEvents");
			SpriteRenderer.get_drawModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_drawModeDelegate>("UnityEngine.SpriteRenderer::get_drawMode");
			SpriteRenderer.set_drawModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_drawModeDelegate>("UnityEngine.SpriteRenderer::set_drawMode");
			SpriteRenderer.get_adaptiveModeThresholdDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_adaptiveModeThresholdDelegate>("UnityEngine.SpriteRenderer::get_adaptiveModeThreshold");
			SpriteRenderer.set_adaptiveModeThresholdDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_adaptiveModeThresholdDelegate>("UnityEngine.SpriteRenderer::set_adaptiveModeThreshold");
			SpriteRenderer.get_tileModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_tileModeDelegate>("UnityEngine.SpriteRenderer::get_tileMode");
			SpriteRenderer.set_tileModeDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_tileModeDelegate>("UnityEngine.SpriteRenderer::set_tileMode");
			SpriteRenderer.get_maskInteractionDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_maskInteractionDelegate>("UnityEngine.SpriteRenderer::get_maskInteraction");
			SpriteRenderer.set_maskInteractionDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_maskInteractionDelegate>("UnityEngine.SpriteRenderer::set_maskInteraction");
			SpriteRenderer.get_flipXDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_flipXDelegate>("UnityEngine.SpriteRenderer::get_flipX");
			SpriteRenderer.set_flipXDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_flipXDelegate>("UnityEngine.SpriteRenderer::set_flipX");
			SpriteRenderer.get_flipYDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_flipYDelegate>("UnityEngine.SpriteRenderer::get_flipY");
			SpriteRenderer.set_flipYDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_flipYDelegate>("UnityEngine.SpriteRenderer::set_flipY");
			SpriteRenderer.get_spriteSortPointDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_spriteSortPointDelegate>("UnityEngine.SpriteRenderer::get_spriteSortPoint");
			SpriteRenderer.set_spriteSortPointDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_spriteSortPointDelegate>("UnityEngine.SpriteRenderer::set_spriteSortPoint");
			SpriteRenderer.GetCurrentMeshDataPtrDelegateField = IL2CPP.ResolveICall<SpriteRenderer.GetCurrentMeshDataPtrDelegate>("UnityEngine.SpriteRenderer::GetCurrentMeshDataPtr");
			SpriteRenderer.GetSecondaryTexturePropertiesDelegateField = IL2CPP.ResolveICall<SpriteRenderer.GetSecondaryTexturePropertiesDelegate>("UnityEngine.SpriteRenderer::GetSecondaryTextureProperties");
			SpriteRenderer.get_size_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_size_InjectedDelegate>("UnityEngine.SpriteRenderer::get_size_Injected");
			SpriteRenderer.set_size_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_size_InjectedDelegate>("UnityEngine.SpriteRenderer::set_size_Injected");
			SpriteRenderer.get_color_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.get_color_InjectedDelegate>("UnityEngine.SpriteRenderer::get_color_Injected");
			SpriteRenderer.set_color_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.set_color_InjectedDelegate>("UnityEngine.SpriteRenderer::set_color_Injected");
			SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegateField = IL2CPP.ResolveICall<SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegate>("UnityEngine.SpriteRenderer::Internal_GetSpriteBounds_Injected");
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00076C80 File Offset: 0x00074E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281929, XrefRangeEnd = 1281936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeSpriteChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001C8B RID: 7307 RVA: 0x00076CB4 File Offset: 0x00074EB4
		// (set) Token: 0x06001C8C RID: 7308 RVA: 0x00076CF4 File Offset: 0x00074EF4
		public unsafe Sprite sprite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281936, XrefRangeEnd = 1281938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1281940, RefRangeEnd = 1281943, XrefRangeStart = 1281938, XrefRangeEnd = 1281940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00076D38 File Offset: 0x00074F38
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 34977, RefRangeEnd = 34989, XrefRangeStart = 34977, XrefRangeEnd = 34989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0000D65C File Offset: 0x0000B85C
		public SpriteRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00076D74 File Offset: 0x00074F74
		// (set) Token: 0x06001C90 RID: 7312 RVA: 0x0000D665 File Offset: 0x0000B865
		public unsafe UnityEngine.Events.UnityEvent<SpriteRenderer> m_SpriteChangeEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRenderer.NativeFieldInfoPtr_m_SpriteChangeEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityEvent<SpriteRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteRenderer.NativeFieldInfoPtr_m_SpriteChangeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00076DA4 File Offset: 0x00074FA4
		public void RegisterSpriteChangeCallback(UnityEngine.Events.UnityAction<SpriteRenderer> callback)
		{
			bool flag = this.m_SpriteChangeEvent == null;
			if (flag)
			{
				this.m_SpriteChangeEvent = new UnityEngine.Events.UnityEvent<SpriteRenderer>();
			}
			this.m_SpriteChangeEvent.AddListener(callback);
			this.hasSpriteChangeEvents = true;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00076DE0 File Offset: 0x00074FE0
		public void UnregisterSpriteChangeCallback(UnityEngine.Events.UnityAction<SpriteRenderer> callback)
		{
			bool flag = this.m_SpriteChangeEvent != null;
			if (flag)
			{
				this.m_SpriteChangeEvent.RemoveListener(callback);
				bool flag2 = this.m_SpriteChangeEvent.GetCallsCount() == 0;
				if (flag2)
				{
					this.hasSpriteChangeEvents = false;
				}
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x0000D684 File Offset: 0x0000B884
		public bool shouldSupportTiling
		{
			get
			{
				return SpriteRenderer.get_shouldSupportTilingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x0000D696 File Offset: 0x0000B896
		// (set) Token: 0x06001C95 RID: 7317 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		public bool hasSpriteChangeEvents
		{
			get
			{
				return SpriteRenderer.get_hasSpriteChangeEventsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_hasSpriteChangeEventsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001C96 RID: 7318 RVA: 0x0000D6BB File Offset: 0x0000B8BB
		// (set) Token: 0x06001C97 RID: 7319 RVA: 0x0000D6CD File Offset: 0x0000B8CD
		public SpriteDrawMode drawMode
		{
			get
			{
				return SpriteRenderer.get_drawModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_drawModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001C98 RID: 7320 RVA: 0x00076E24 File Offset: 0x00075024
		// (set) Token: 0x06001C99 RID: 7321 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		public Vector2 size
		{
			get
			{
				Vector2 result;
				this.get_size_Injected(out result);
				return result;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001C9A RID: 7322 RVA: 0x0000D6EA File Offset: 0x0000B8EA
		// (set) Token: 0x06001C9B RID: 7323 RVA: 0x0000D6FC File Offset: 0x0000B8FC
		public float adaptiveModeThreshold
		{
			get
			{
				return SpriteRenderer.get_adaptiveModeThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_adaptiveModeThresholdDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001C9C RID: 7324 RVA: 0x0000D70F File Offset: 0x0000B90F
		// (set) Token: 0x06001C9D RID: 7325 RVA: 0x0000D721 File Offset: 0x0000B921
		public SpriteTileMode tileMode
		{
			get
			{
				return SpriteRenderer.get_tileModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_tileModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x00076E3C File Offset: 0x0007503C
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x0000D734 File Offset: 0x0000B934
		public Color color
		{
			get
			{
				Color result;
				this.get_color_Injected(out result);
				return result;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x0000D73E File Offset: 0x0000B93E
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x0000D750 File Offset: 0x0000B950
		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return SpriteRenderer.get_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_maskInteractionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x0000D763 File Offset: 0x0000B963
		// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x0000D775 File Offset: 0x0000B975
		public bool flipX
		{
			get
			{
				return SpriteRenderer.get_flipXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_flipXDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x0000D788 File Offset: 0x0000B988
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x0000D79A File Offset: 0x0000B99A
		public bool flipY
		{
			get
			{
				return SpriteRenderer.get_flipYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_flipYDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x0000D7AD File Offset: 0x0000B9AD
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x0000D7BF File Offset: 0x0000B9BF
		public SpriteSortPoint spriteSortPoint
		{
			get
			{
				return SpriteRenderer.get_spriteSortPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				SpriteRenderer.set_spriteSortPointDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0000D7D2 File Offset: 0x0000B9D2
		public IntPtr GetCurrentMeshDataPtr()
		{
			return SpriteRenderer.GetCurrentMeshDataPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00076E54 File Offset: 0x00075054
		public Bounds Internal_GetSpriteBounds(SpriteDrawMode mode)
		{
			Bounds result;
			this.Internal_GetSpriteBounds_Injected(mode, out result);
			return result;
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		public void GetSecondaryTextureProperties(MaterialPropertyBlock mbp)
		{
			SpriteRenderer.GetSecondaryTexturePropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(mbp));
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00076E6C File Offset: 0x0007506C
		public Bounds GetSpriteBounds()
		{
			return this.Internal_GetSpriteBounds(this.drawMode);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0000D7FC File Offset: 0x0000B9FC
		public void get_size_Injected(out Vector2 ret)
		{
			SpriteRenderer.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0000D80F File Offset: 0x0000BA0F
		public void set_size_Injected(ref Vector2 value)
		{
			SpriteRenderer.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0000D822 File Offset: 0x0000BA22
		public void get_color_Injected(out Color ret)
		{
			SpriteRenderer.get_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0000D835 File Offset: 0x0000BA35
		public void set_color_Injected(ref Color value)
		{
			SpriteRenderer.set_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0000D848 File Offset: 0x0000BA48
		public void Internal_GetSpriteBounds_Injected(SpriteDrawMode mode, out Bounds ret)
		{
			SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), mode, out ret);
		}

		// Token: 0x04001787 RID: 6023
		private static readonly IntPtr NativeFieldInfoPtr_m_SpriteChangeEvent;

		// Token: 0x04001788 RID: 6024
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0;

		// Token: 0x04001789 RID: 6025
		private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400178C RID: 6028
		private static readonly SpriteRenderer.get_shouldSupportTilingDelegate get_shouldSupportTilingDelegateField;

		// Token: 0x0400178D RID: 6029
		private static readonly SpriteRenderer.get_hasSpriteChangeEventsDelegate get_hasSpriteChangeEventsDelegateField;

		// Token: 0x0400178E RID: 6030
		private static readonly SpriteRenderer.set_hasSpriteChangeEventsDelegate set_hasSpriteChangeEventsDelegateField;

		// Token: 0x0400178F RID: 6031
		private static readonly SpriteRenderer.get_drawModeDelegate get_drawModeDelegateField;

		// Token: 0x04001790 RID: 6032
		private static readonly SpriteRenderer.set_drawModeDelegate set_drawModeDelegateField;

		// Token: 0x04001791 RID: 6033
		private static readonly SpriteRenderer.get_adaptiveModeThresholdDelegate get_adaptiveModeThresholdDelegateField;

		// Token: 0x04001792 RID: 6034
		private static readonly SpriteRenderer.set_adaptiveModeThresholdDelegate set_adaptiveModeThresholdDelegateField;

		// Token: 0x04001793 RID: 6035
		private static readonly SpriteRenderer.get_tileModeDelegate get_tileModeDelegateField;

		// Token: 0x04001794 RID: 6036
		private static readonly SpriteRenderer.set_tileModeDelegate set_tileModeDelegateField;

		// Token: 0x04001795 RID: 6037
		private static readonly SpriteRenderer.get_maskInteractionDelegate get_maskInteractionDelegateField;

		// Token: 0x04001796 RID: 6038
		private static readonly SpriteRenderer.set_maskInteractionDelegate set_maskInteractionDelegateField;

		// Token: 0x04001797 RID: 6039
		private static readonly SpriteRenderer.get_flipXDelegate get_flipXDelegateField;

		// Token: 0x04001798 RID: 6040
		private static readonly SpriteRenderer.set_flipXDelegate set_flipXDelegateField;

		// Token: 0x04001799 RID: 6041
		private static readonly SpriteRenderer.get_flipYDelegate get_flipYDelegateField;

		// Token: 0x0400179A RID: 6042
		private static readonly SpriteRenderer.set_flipYDelegate set_flipYDelegateField;

		// Token: 0x0400179B RID: 6043
		private static readonly SpriteRenderer.get_spriteSortPointDelegate get_spriteSortPointDelegateField;

		// Token: 0x0400179C RID: 6044
		private static readonly SpriteRenderer.set_spriteSortPointDelegate set_spriteSortPointDelegateField;

		// Token: 0x0400179D RID: 6045
		private static readonly SpriteRenderer.GetCurrentMeshDataPtrDelegate GetCurrentMeshDataPtrDelegateField;

		// Token: 0x0400179E RID: 6046
		private static readonly SpriteRenderer.GetSecondaryTexturePropertiesDelegate GetSecondaryTexturePropertiesDelegateField;

		// Token: 0x0400179F RID: 6047
		private static readonly SpriteRenderer.get_size_InjectedDelegate get_size_InjectedDelegateField;

		// Token: 0x040017A0 RID: 6048
		private static readonly SpriteRenderer.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x040017A1 RID: 6049
		private static readonly SpriteRenderer.get_color_InjectedDelegate get_color_InjectedDelegateField;

		// Token: 0x040017A2 RID: 6050
		private static readonly SpriteRenderer.set_color_InjectedDelegate set_color_InjectedDelegateField;

		// Token: 0x040017A3 RID: 6051
		private static readonly SpriteRenderer.Internal_GetSpriteBounds_InjectedDelegate Internal_GetSpriteBounds_InjectedDelegateField;

		// Token: 0x02000997 RID: 2455
		// (Invoke) Token: 0x06003BAF RID: 15279
		private delegate bool get_shouldSupportTilingDelegate(IntPtr @this);

		// Token: 0x02000998 RID: 2456
		// (Invoke) Token: 0x06003BB1 RID: 15281
		private delegate bool get_hasSpriteChangeEventsDelegate(IntPtr @this);

		// Token: 0x02000999 RID: 2457
		// (Invoke) Token: 0x06003BB3 RID: 15283
		private delegate void set_hasSpriteChangeEventsDelegate(IntPtr @this, bool value);

		// Token: 0x0200099A RID: 2458
		// (Invoke) Token: 0x06003BB5 RID: 15285
		private delegate SpriteDrawMode get_drawModeDelegate(IntPtr @this);

		// Token: 0x0200099B RID: 2459
		// (Invoke) Token: 0x06003BB7 RID: 15287
		private delegate void set_drawModeDelegate(IntPtr @this, SpriteDrawMode value);

		// Token: 0x0200099C RID: 2460
		// (Invoke) Token: 0x06003BB9 RID: 15289
		private delegate float get_adaptiveModeThresholdDelegate(IntPtr @this);

		// Token: 0x0200099D RID: 2461
		// (Invoke) Token: 0x06003BBB RID: 15291
		private delegate void set_adaptiveModeThresholdDelegate(IntPtr @this, float value);

		// Token: 0x0200099E RID: 2462
		// (Invoke) Token: 0x06003BBD RID: 15293
		private delegate SpriteTileMode get_tileModeDelegate(IntPtr @this);

		// Token: 0x0200099F RID: 2463
		// (Invoke) Token: 0x06003BBF RID: 15295
		private delegate void set_tileModeDelegate(IntPtr @this, SpriteTileMode value);

		// Token: 0x020009A0 RID: 2464
		// (Invoke) Token: 0x06003BC1 RID: 15297
		private delegate SpriteMaskInteraction get_maskInteractionDelegate(IntPtr @this);

		// Token: 0x020009A1 RID: 2465
		// (Invoke) Token: 0x06003BC3 RID: 15299
		private delegate void set_maskInteractionDelegate(IntPtr @this, SpriteMaskInteraction value);

		// Token: 0x020009A2 RID: 2466
		// (Invoke) Token: 0x06003BC5 RID: 15301
		private delegate bool get_flipXDelegate(IntPtr @this);

		// Token: 0x020009A3 RID: 2467
		// (Invoke) Token: 0x06003BC7 RID: 15303
		private delegate void set_flipXDelegate(IntPtr @this, bool value);

		// Token: 0x020009A4 RID: 2468
		// (Invoke) Token: 0x06003BC9 RID: 15305
		private delegate bool get_flipYDelegate(IntPtr @this);

		// Token: 0x020009A5 RID: 2469
		// (Invoke) Token: 0x06003BCB RID: 15307
		private delegate void set_flipYDelegate(IntPtr @this, bool value);

		// Token: 0x020009A6 RID: 2470
		// (Invoke) Token: 0x06003BCD RID: 15309
		private delegate SpriteSortPoint get_spriteSortPointDelegate(IntPtr @this);

		// Token: 0x020009A7 RID: 2471
		// (Invoke) Token: 0x06003BCF RID: 15311
		private delegate void set_spriteSortPointDelegate(IntPtr @this, SpriteSortPoint value);

		// Token: 0x020009A8 RID: 2472
		// (Invoke) Token: 0x06003BD1 RID: 15313
		private delegate IntPtr GetCurrentMeshDataPtrDelegate(IntPtr @this);

		// Token: 0x020009A9 RID: 2473
		// (Invoke) Token: 0x06003BD3 RID: 15315
		private delegate void GetSecondaryTexturePropertiesDelegate(IntPtr @this, IntPtr mbp);

		// Token: 0x020009AA RID: 2474
		// (Invoke) Token: 0x06003BD5 RID: 15317
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020009AB RID: 2475
		// (Invoke) Token: 0x06003BD7 RID: 15319
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020009AC RID: 2476
		// (Invoke) Token: 0x06003BD9 RID: 15321
		private delegate void get_color_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020009AD RID: 2477
		// (Invoke) Token: 0x06003BDB RID: 15323
		private delegate void set_color_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x020009AE RID: 2478
		// (Invoke) Token: 0x06003BDD RID: 15325
		private delegate void Internal_GetSpriteBounds_InjectedDelegate(IntPtr @this, SpriteDrawMode mode, [Out] IntPtr ret);
	}
}

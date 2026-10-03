using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000412 RID: 1042
	[Serializable]
	public class GraphicsSettings : Object
	{
		// Token: 0x06005B8E RID: 23438 RVA: 0x001B6EA0 File Offset: 0x001B50A0
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsSettings()
		{
			Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GraphicsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr);
			GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "GraphicsQuality");
			GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "AntiAliasingMode");
			GraphicsSettings.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "FOV");
			GraphicsSettings.NativeFieldInfoPtr_SSAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "SSAO");
			GraphicsSettings.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "GodRays");
			GraphicsSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100675252);
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x001B6F48 File Offset: 0x001B5148
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x0002B5C9 File Offset: 0x000297C9
		public GraphicsSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06005B91 RID: 23441 RVA: 0x001B6F84 File Offset: 0x001B5184
		// (set) Token: 0x06005B92 RID: 23442 RVA: 0x0002B5D2 File Offset: 0x000297D2
		public unsafe GraphicsSettings.EGraphicsQuality GraphicsQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality)) = value;
			}
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06005B93 RID: 23443 RVA: 0x001B6FAC File Offset: 0x001B51AC
		// (set) Token: 0x06005B94 RID: 23444 RVA: 0x0002B5ED File Offset: 0x000297ED
		public unsafe GraphicsSettings.EAntiAliasingMode AntiAliasingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode)) = value;
			}
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06005B95 RID: 23445 RVA: 0x001B6FD4 File Offset: 0x001B51D4
		// (set) Token: 0x06005B96 RID: 23446 RVA: 0x0002B608 File Offset: 0x00029808
		public unsafe float FOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FOV)) = value;
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06005B97 RID: 23447 RVA: 0x001B6FFC File Offset: 0x001B51FC
		// (set) Token: 0x06005B98 RID: 23448 RVA: 0x0002B623 File Offset: 0x00029823
		public unsafe bool SSAO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_SSAO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_SSAO)) = value;
			}
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06005B99 RID: 23449 RVA: 0x001B7024 File Offset: 0x001B5224
		// (set) Token: 0x06005B9A RID: 23450 RVA: 0x0002B63E File Offset: 0x0002983E
		public unsafe bool GodRays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GodRays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GodRays)) = value;
			}
		}

		// Token: 0x04003ECB RID: 16075
		private static readonly IntPtr NativeFieldInfoPtr_GraphicsQuality;

		// Token: 0x04003ECC RID: 16076
		private static readonly IntPtr NativeFieldInfoPtr_AntiAliasingMode;

		// Token: 0x04003ECD RID: 16077
		private static readonly IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x04003ECE RID: 16078
		private static readonly IntPtr NativeFieldInfoPtr_SSAO;

		// Token: 0x04003ECF RID: 16079
		private static readonly IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x04003ED0 RID: 16080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF7 RID: 2807
		[OriginalName("Assembly-CSharp.dll", "", "EAntiAliasingMode")]
		public enum EAntiAliasingMode
		{
			// Token: 0x04009B98 RID: 39832
			Off,
			// Token: 0x04009B99 RID: 39833
			FXAA,
			// Token: 0x04009B9A RID: 39834
			SMAA
		}

		// Token: 0x02000AF8 RID: 2808
		[OriginalName("Assembly-CSharp.dll", "", "EGraphicsQuality")]
		public enum EGraphicsQuality
		{
			// Token: 0x04009B9C RID: 39836
			Low,
			// Token: 0x04009B9D RID: 39837
			Medium,
			// Token: 0x04009B9E RID: 39838
			High,
			// Token: 0x04009B9F RID: 39839
			Ultra
		}
	}
}

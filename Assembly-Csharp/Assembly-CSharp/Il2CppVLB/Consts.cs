using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200003F RID: 63
	public static class Consts : Il2CppSystem.Object
	{
		// Token: 0x0600047D RID: 1149 RVA: 0x0000486E File Offset: 0x00002A6E
		// Note: this type is marked as 'beforefieldinit'.
		static Consts()
		{
			Il2CppClassPointerStore<Consts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Consts");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts>.NativeClassPtr);
			Consts.NativeFieldInfoPtr_PluginFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts>.NativeClassPtr, "PluginFolder");
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000048A7 File Offset: 0x00002AA7
		public Consts(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00088740 File Offset: 0x00086940
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x000048B0 File Offset: 0x00002AB0
		public unsafe static string PluginFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Consts.NativeFieldInfoPtr_PluginFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Consts.NativeFieldInfoPtr_PluginFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr_PluginFolder;

		// Token: 0x02000866 RID: 2150
		public static class Help : Il2CppSystem.Object
		{
			// Token: 0x0600D091 RID: 53393 RVA: 0x00345968 File Offset: 0x00343B68
			// Note: this type is marked as 'beforefieldinit'.
			static Help()
			{
				Il2CppClassPointerStore<Consts.Help>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Help");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr);
				Consts.Help.NativeFieldInfoPtr_UrlBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlBase");
				Consts.Help.NativeFieldInfoPtr_UrlSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlSuffix");
				Consts.Help.NativeFieldInfoPtr_UrlDustParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlDustParticles");
				Consts.Help.NativeFieldInfoPtr_UrlTriggerZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlTriggerZone");
				Consts.Help.NativeFieldInfoPtr_UrlEffectFlicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlEffectFlicker");
				Consts.Help.NativeFieldInfoPtr_UrlEffectPulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlEffectPulse");
				Consts.Help.NativeFieldInfoPtr_UrlEffectFromProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlEffectFromProfile");
				Consts.Help.NativeFieldInfoPtr_UrlConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "UrlConfig");
			}

			// Token: 0x0600D092 RID: 53394 RVA: 0x00062C1C File Offset: 0x00060E1C
			public Help(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F2E RID: 16174
			// (get) Token: 0x0600D093 RID: 53395 RVA: 0x00345A34 File Offset: 0x00343C34
			// (set) Token: 0x0600D094 RID: 53396 RVA: 0x00062C25 File Offset: 0x00060E25
			public unsafe static string UrlBase
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlBase, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlBase, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F2F RID: 16175
			// (get) Token: 0x0600D095 RID: 53397 RVA: 0x00345A54 File Offset: 0x00343C54
			// (set) Token: 0x0600D096 RID: 53398 RVA: 0x00062C37 File Offset: 0x00060E37
			public unsafe static string UrlSuffix
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlSuffix, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlSuffix, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F30 RID: 16176
			// (get) Token: 0x0600D097 RID: 53399 RVA: 0x00345A74 File Offset: 0x00343C74
			// (set) Token: 0x0600D098 RID: 53400 RVA: 0x00062C49 File Offset: 0x00060E49
			public unsafe static string UrlDustParticles
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlDustParticles, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlDustParticles, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F31 RID: 16177
			// (get) Token: 0x0600D099 RID: 53401 RVA: 0x00345A94 File Offset: 0x00343C94
			// (set) Token: 0x0600D09A RID: 53402 RVA: 0x00062C5B File Offset: 0x00060E5B
			public unsafe static string UrlTriggerZone
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlTriggerZone, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlTriggerZone, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F32 RID: 16178
			// (get) Token: 0x0600D09B RID: 53403 RVA: 0x00345AB4 File Offset: 0x00343CB4
			// (set) Token: 0x0600D09C RID: 53404 RVA: 0x00062C6D File Offset: 0x00060E6D
			public unsafe static string UrlEffectFlicker
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFlicker, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFlicker, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F33 RID: 16179
			// (get) Token: 0x0600D09D RID: 53405 RVA: 0x00345AD4 File Offset: 0x00343CD4
			// (set) Token: 0x0600D09E RID: 53406 RVA: 0x00062C7F File Offset: 0x00060E7F
			public unsafe static string UrlEffectPulse
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlEffectPulse, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlEffectPulse, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F34 RID: 16180
			// (get) Token: 0x0600D09F RID: 53407 RVA: 0x00345AF4 File Offset: 0x00343CF4
			// (set) Token: 0x0600D0A0 RID: 53408 RVA: 0x00062C91 File Offset: 0x00060E91
			public unsafe static string UrlEffectFromProfile
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFromProfile, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlEffectFromProfile, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F35 RID: 16181
			// (get) Token: 0x0600D0A1 RID: 53409 RVA: 0x00345B14 File Offset: 0x00343D14
			// (set) Token: 0x0600D0A2 RID: 53410 RVA: 0x00062CA3 File Offset: 0x00060EA3
			public unsafe static string UrlConfig
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Help.NativeFieldInfoPtr_UrlConfig, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Help.NativeFieldInfoPtr_UrlConfig, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008E21 RID: 36385
			private static readonly IntPtr NativeFieldInfoPtr_UrlBase;

			// Token: 0x04008E22 RID: 36386
			private static readonly IntPtr NativeFieldInfoPtr_UrlSuffix;

			// Token: 0x04008E23 RID: 36387
			private static readonly IntPtr NativeFieldInfoPtr_UrlDustParticles;

			// Token: 0x04008E24 RID: 36388
			private static readonly IntPtr NativeFieldInfoPtr_UrlTriggerZone;

			// Token: 0x04008E25 RID: 36389
			private static readonly IntPtr NativeFieldInfoPtr_UrlEffectFlicker;

			// Token: 0x04008E26 RID: 36390
			private static readonly IntPtr NativeFieldInfoPtr_UrlEffectPulse;

			// Token: 0x04008E27 RID: 36391
			private static readonly IntPtr NativeFieldInfoPtr_UrlEffectFromProfile;

			// Token: 0x04008E28 RID: 36392
			private static readonly IntPtr NativeFieldInfoPtr_UrlConfig;

			// Token: 0x02000D9F RID: 3487
			public static class SD : Il2CppSystem.Object
			{
				// Token: 0x0600FCC0 RID: 64704 RVA: 0x003C41D0 File Offset: 0x003C23D0
				// Note: this type is marked as 'beforefieldinit'.
				static SD()
				{
					Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "SD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr);
					Consts.Help.SD.NativeFieldInfoPtr_UrlBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlBeam");
					Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlDynamicOcclusionRaycasting");
					Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlDynamicOcclusionDepthBuffer");
					Consts.Help.SD.NativeFieldInfoPtr_UrlSkewingHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.SD>.NativeClassPtr, "UrlSkewingHandle");
				}

				// Token: 0x0600FCC1 RID: 64705 RVA: 0x00077ABB File Offset: 0x00075CBB
				public SD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004CC2 RID: 19650
				// (get) Token: 0x0600FCC2 RID: 64706 RVA: 0x003C424C File Offset: 0x003C244C
				// (set) Token: 0x0600FCC3 RID: 64707 RVA: 0x00077AC4 File Offset: 0x00075CC4
				public unsafe static string UrlBeam
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlBeam, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlBeam, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004CC3 RID: 19651
				// (get) Token: 0x0600FCC4 RID: 64708 RVA: 0x003C426C File Offset: 0x003C246C
				// (set) Token: 0x0600FCC5 RID: 64709 RVA: 0x00077AD6 File Offset: 0x00075CD6
				public unsafe static string UrlDynamicOcclusionRaycasting
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004CC4 RID: 19652
				// (get) Token: 0x0600FCC6 RID: 64710 RVA: 0x003C428C File Offset: 0x003C248C
				// (set) Token: 0x0600FCC7 RID: 64711 RVA: 0x00077AE8 File Offset: 0x00075CE8
				public unsafe static string UrlDynamicOcclusionDepthBuffer
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004CC5 RID: 19653
				// (get) Token: 0x0600FCC8 RID: 64712 RVA: 0x003C42AC File Offset: 0x003C24AC
				// (set) Token: 0x0600FCC9 RID: 64713 RVA: 0x00077AFA File Offset: 0x00075CFA
				public unsafe static string UrlSkewingHandle
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.SD.NativeFieldInfoPtr_UrlSkewingHandle, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.SD.NativeFieldInfoPtr_UrlSkewingHandle, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400AA67 RID: 43623
				private static readonly IntPtr NativeFieldInfoPtr_UrlBeam;

				// Token: 0x0400AA68 RID: 43624
				private static readonly IntPtr NativeFieldInfoPtr_UrlDynamicOcclusionRaycasting;

				// Token: 0x0400AA69 RID: 43625
				private static readonly IntPtr NativeFieldInfoPtr_UrlDynamicOcclusionDepthBuffer;

				// Token: 0x0400AA6A RID: 43626
				private static readonly IntPtr NativeFieldInfoPtr_UrlSkewingHandle;
			}

			// Token: 0x02000DA0 RID: 3488
			public static class HD : Il2CppSystem.Object
			{
				// Token: 0x0600FCCA RID: 64714 RVA: 0x003C42CC File Offset: 0x003C24CC
				// Note: this type is marked as 'beforefieldinit'.
				static HD()
				{
					Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Help>.NativeClassPtr, "HD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr);
					Consts.Help.HD.NativeFieldInfoPtr_UrlBeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlBeam");
					Consts.Help.HD.NativeFieldInfoPtr_UrlShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlShadow");
					Consts.Help.HD.NativeFieldInfoPtr_UrlCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlCookie");
					Consts.Help.HD.NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Help.HD>.NativeClassPtr, "UrlTrackRealtimeChangesOnLight");
				}

				// Token: 0x0600FCCB RID: 64715 RVA: 0x00077B0C File Offset: 0x00075D0C
				public HD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004CC6 RID: 19654
				// (get) Token: 0x0600FCCC RID: 64716 RVA: 0x003C4348 File Offset: 0x003C2548
				// (set) Token: 0x0600FCCD RID: 64717 RVA: 0x00077B15 File Offset: 0x00075D15
				public unsafe static string UrlBeam
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlBeam, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlBeam, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004CC7 RID: 19655
				// (get) Token: 0x0600FCCE RID: 64718 RVA: 0x003C4368 File Offset: 0x003C2568
				// (set) Token: 0x0600FCCF RID: 64719 RVA: 0x00077B27 File Offset: 0x00075D27
				public unsafe static string UrlShadow
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlShadow, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlShadow, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004CC8 RID: 19656
				// (get) Token: 0x0600FCD0 RID: 64720 RVA: 0x003C4388 File Offset: 0x003C2588
				// (set) Token: 0x0600FCD1 RID: 64721 RVA: 0x00077B39 File Offset: 0x00075D39
				public unsafe static string UrlCookie
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlCookie, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlCookie, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004CC9 RID: 19657
				// (get) Token: 0x0600FCD2 RID: 64722 RVA: 0x003C43A8 File Offset: 0x003C25A8
				// (set) Token: 0x0600FCD3 RID: 64723 RVA: 0x00077B4B File Offset: 0x00075D4B
				public unsafe static string UrlTrackRealtimeChangesOnLight
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Help.HD.NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight, (void*)(&intPtr));
						return IL2CPP.Il2CppStringToManaged(intPtr);
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Help.HD.NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight, IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400AA6B RID: 43627
				private static readonly IntPtr NativeFieldInfoPtr_UrlBeam;

				// Token: 0x0400AA6C RID: 43628
				private static readonly IntPtr NativeFieldInfoPtr_UrlShadow;

				// Token: 0x0400AA6D RID: 43629
				private static readonly IntPtr NativeFieldInfoPtr_UrlCookie;

				// Token: 0x0400AA6E RID: 43630
				private static readonly IntPtr NativeFieldInfoPtr_UrlTrackRealtimeChangesOnLight;
			}
		}

		// Token: 0x02000867 RID: 2151
		public static class Internal : Il2CppSystem.Object
		{
			// Token: 0x0600D0A3 RID: 53411 RVA: 0x00345B34 File Offset: 0x00343D34
			// Note: this type is marked as 'beforefieldinit'.
			static Internal()
			{
				Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Internal");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr);
				Consts.Internal.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr, "ProceduralObjectsVisibleInEditor");
				Consts.Internal.NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts.Internal>.NativeClassPtr, 100663730);
			}

			// Token: 0x17003F37 RID: 16183
			// (get) Token: 0x0600D0A4 RID: 53412 RVA: 0x00345B88 File Offset: 0x00343D88
			public unsafe static HideFlags ProceduralObjectsHideFlags
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 69365, RefRangeEnd = 69368, XrefRangeStart = 69361, XrefRangeEnd = 69365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.Internal.NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600D0A5 RID: 53413 RVA: 0x00062CB5 File Offset: 0x00060EB5
			public Internal(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F36 RID: 16182
			// (get) Token: 0x0600D0A6 RID: 53414 RVA: 0x00345BB8 File Offset: 0x00343DB8
			// (set) Token: 0x0600D0A7 RID: 53415 RVA: 0x00062CBE File Offset: 0x00060EBE
			public unsafe static bool ProceduralObjectsVisibleInEditor
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Internal.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Internal.NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor, (void*)(&value));
				}
			}

			// Token: 0x04008E29 RID: 36393
			private static readonly IntPtr NativeFieldInfoPtr_ProceduralObjectsVisibleInEditor;

			// Token: 0x04008E2A RID: 36394
			private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralObjectsHideFlags_Public_Static_get_HideFlags_0;
		}

		// Token: 0x02000868 RID: 2152
		public static class Beam : Il2CppSystem.Object
		{
			// Token: 0x0600D0A8 RID: 53416 RVA: 0x00345BD4 File Offset: 0x00343DD4
			// Note: this type is marked as 'beforefieldinit'.
			static Beam()
			{
				Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Beam");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr);
				Consts.Beam.NativeFieldInfoPtr_FlatColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FlatColor");
				Consts.Beam.NativeFieldInfoPtr_ColorModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ColorModeDefault");
				Consts.Beam.NativeFieldInfoPtr_MultiplierDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "MultiplierDefault");
				Consts.Beam.NativeFieldInfoPtr_MultiplierMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "MultiplierMin");
				Consts.Beam.NativeFieldInfoPtr_IntensityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "IntensityDefault");
				Consts.Beam.NativeFieldInfoPtr_IntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "IntensityMin");
				Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HDRPExposureWeightDefault");
				Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HDRPExposureWeightMin");
				Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HDRPExposureWeightMax");
				Consts.Beam.NativeFieldInfoPtr_SpotAngleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SpotAngleDefault");
				Consts.Beam.NativeFieldInfoPtr_SpotAngleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SpotAngleMin");
				Consts.Beam.NativeFieldInfoPtr_SpotAngleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SpotAngleMax");
				Consts.Beam.NativeFieldInfoPtr_ConeRadiusStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ConeRadiusStart");
				Consts.Beam.NativeFieldInfoPtr_GeomMeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomMeshType");
				Consts.Beam.NativeFieldInfoPtr_GeomSidesDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSidesDefault");
				Consts.Beam.NativeFieldInfoPtr_GeomSidesMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSidesMin");
				Consts.Beam.NativeFieldInfoPtr_GeomSidesMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSidesMax");
				Consts.Beam.NativeFieldInfoPtr_GeomSegmentsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSegmentsDefault");
				Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSegmentsMin");
				Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomSegmentsMax");
				Consts.Beam.NativeFieldInfoPtr_GeomCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "GeomCap");
				Consts.Beam.NativeFieldInfoPtr_ScalableDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ScalableDefault");
				Consts.Beam.NativeFieldInfoPtr_AttenuationEquationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationEquationDefault");
				Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationCustomBlendingDefault");
				Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationCustomBlendingMin");
				Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "AttenuationCustomBlendingMax");
				Consts.Beam.NativeFieldInfoPtr_FallOffStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FallOffStart");
				Consts.Beam.NativeFieldInfoPtr_FallOffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FallOffEnd");
				Consts.Beam.NativeFieldInfoPtr_FallOffDistancesMinThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FallOffDistancesMinThreshold");
				Consts.Beam.NativeFieldInfoPtr_DepthBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "DepthBlendDistance");
				Consts.Beam.NativeFieldInfoPtr_CameraClippingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "CameraClippingDistance");
				Consts.Beam.NativeFieldInfoPtr_NoiseModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseModeDefault");
				Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseIntensityMin");
				Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseIntensityMax");
				Consts.Beam.NativeFieldInfoPtr_NoiseIntensityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseIntensityDefault");
				Consts.Beam.NativeFieldInfoPtr_NoiseScaleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseScaleMin");
				Consts.Beam.NativeFieldInfoPtr_NoiseScaleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseScaleMax");
				Consts.Beam.NativeFieldInfoPtr_NoiseScaleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseScaleDefault");
				Consts.Beam.NativeFieldInfoPtr_NoiseVelocityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "NoiseVelocityDefault");
				Consts.Beam.NativeFieldInfoPtr_BlendingModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "BlendingModeDefault");
				Consts.Beam.NativeFieldInfoPtr_ShaderAccuracyDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "ShaderAccuracyDefault");
				Consts.Beam.NativeFieldInfoPtr_FadeOutBeginDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FadeOutBeginDefault");
				Consts.Beam.NativeFieldInfoPtr_FadeOutEndDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "FadeOutEndDefault");
				Consts.Beam.NativeFieldInfoPtr_DimensionsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "DimensionsDefault");
			}

			// Token: 0x0600D0A9 RID: 53417 RVA: 0x00062CCC File Offset: 0x00060ECC
			public Beam(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F38 RID: 16184
			// (get) Token: 0x0600D0AA RID: 53418 RVA: 0x00345F70 File Offset: 0x00344170
			// (set) Token: 0x0600D0AB RID: 53419 RVA: 0x00062CD5 File Offset: 0x00060ED5
			public unsafe static Color FlatColor
			{
				get
				{
					Color result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FlatColor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FlatColor, (void*)(&value));
				}
			}

			// Token: 0x17003F39 RID: 16185
			// (get) Token: 0x0600D0AC RID: 53420 RVA: 0x00345F8C File Offset: 0x0034418C
			// (set) Token: 0x0600D0AD RID: 53421 RVA: 0x00062CE3 File Offset: 0x00060EE3
			public unsafe static ColorMode ColorModeDefault
			{
				get
				{
					ColorMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ColorModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ColorModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F3A RID: 16186
			// (get) Token: 0x0600D0AE RID: 53422 RVA: 0x00345FA8 File Offset: 0x003441A8
			// (set) Token: 0x0600D0AF RID: 53423 RVA: 0x00062CF1 File Offset: 0x00060EF1
			public unsafe static float MultiplierDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_MultiplierDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_MultiplierDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F3B RID: 16187
			// (get) Token: 0x0600D0B0 RID: 53424 RVA: 0x00345FC4 File Offset: 0x003441C4
			// (set) Token: 0x0600D0B1 RID: 53425 RVA: 0x00062CFF File Offset: 0x00060EFF
			public unsafe static float MultiplierMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_MultiplierMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_MultiplierMin, (void*)(&value));
				}
			}

			// Token: 0x17003F3C RID: 16188
			// (get) Token: 0x0600D0B2 RID: 53426 RVA: 0x00345FE0 File Offset: 0x003441E0
			// (set) Token: 0x0600D0B3 RID: 53427 RVA: 0x00062D0D File Offset: 0x00060F0D
			public unsafe static float IntensityDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_IntensityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_IntensityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F3D RID: 16189
			// (get) Token: 0x0600D0B4 RID: 53428 RVA: 0x00345FFC File Offset: 0x003441FC
			// (set) Token: 0x0600D0B5 RID: 53429 RVA: 0x00062D1B File Offset: 0x00060F1B
			public unsafe static float IntensityMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_IntensityMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_IntensityMin, (void*)(&value));
				}
			}

			// Token: 0x17003F3E RID: 16190
			// (get) Token: 0x0600D0B6 RID: 53430 RVA: 0x00346018 File Offset: 0x00344218
			// (set) Token: 0x0600D0B7 RID: 53431 RVA: 0x00062D29 File Offset: 0x00060F29
			public unsafe static float HDRPExposureWeightDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F3F RID: 16191
			// (get) Token: 0x0600D0B8 RID: 53432 RVA: 0x00346034 File Offset: 0x00344234
			// (set) Token: 0x0600D0B9 RID: 53433 RVA: 0x00062D37 File Offset: 0x00060F37
			public unsafe static float HDRPExposureWeightMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMin, (void*)(&value));
				}
			}

			// Token: 0x17003F40 RID: 16192
			// (get) Token: 0x0600D0BA RID: 53434 RVA: 0x00346050 File Offset: 0x00344250
			// (set) Token: 0x0600D0BB RID: 53435 RVA: 0x00062D45 File Offset: 0x00060F45
			public unsafe static float HDRPExposureWeightMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_HDRPExposureWeightMax, (void*)(&value));
				}
			}

			// Token: 0x17003F41 RID: 16193
			// (get) Token: 0x0600D0BC RID: 53436 RVA: 0x0034606C File Offset: 0x0034426C
			// (set) Token: 0x0600D0BD RID: 53437 RVA: 0x00062D53 File Offset: 0x00060F53
			public unsafe static float SpotAngleDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F42 RID: 16194
			// (get) Token: 0x0600D0BE RID: 53438 RVA: 0x00346088 File Offset: 0x00344288
			// (set) Token: 0x0600D0BF RID: 53439 RVA: 0x00062D61 File Offset: 0x00060F61
			public unsafe static float SpotAngleMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMin, (void*)(&value));
				}
			}

			// Token: 0x17003F43 RID: 16195
			// (get) Token: 0x0600D0C0 RID: 53440 RVA: 0x003460A4 File Offset: 0x003442A4
			// (set) Token: 0x0600D0C1 RID: 53441 RVA: 0x00062D6F File Offset: 0x00060F6F
			public unsafe static float SpotAngleMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_SpotAngleMax, (void*)(&value));
				}
			}

			// Token: 0x17003F44 RID: 16196
			// (get) Token: 0x0600D0C2 RID: 53442 RVA: 0x003460C0 File Offset: 0x003442C0
			// (set) Token: 0x0600D0C3 RID: 53443 RVA: 0x00062D7D File Offset: 0x00060F7D
			public unsafe static float ConeRadiusStart
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ConeRadiusStart, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ConeRadiusStart, (void*)(&value));
				}
			}

			// Token: 0x17003F45 RID: 16197
			// (get) Token: 0x0600D0C4 RID: 53444 RVA: 0x003460DC File Offset: 0x003442DC
			// (set) Token: 0x0600D0C5 RID: 53445 RVA: 0x00062D8B File Offset: 0x00060F8B
			public unsafe static MeshType GeomMeshType
			{
				get
				{
					MeshType result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomMeshType, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomMeshType, (void*)(&value));
				}
			}

			// Token: 0x17003F46 RID: 16198
			// (get) Token: 0x0600D0C6 RID: 53446 RVA: 0x003460F8 File Offset: 0x003442F8
			// (set) Token: 0x0600D0C7 RID: 53447 RVA: 0x00062D99 File Offset: 0x00060F99
			public unsafe static int GeomSidesDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F47 RID: 16199
			// (get) Token: 0x0600D0C8 RID: 53448 RVA: 0x00346114 File Offset: 0x00344314
			// (set) Token: 0x0600D0C9 RID: 53449 RVA: 0x00062DA7 File Offset: 0x00060FA7
			public unsafe static int GeomSidesMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMin, (void*)(&value));
				}
			}

			// Token: 0x17003F48 RID: 16200
			// (get) Token: 0x0600D0CA RID: 53450 RVA: 0x00346130 File Offset: 0x00344330
			// (set) Token: 0x0600D0CB RID: 53451 RVA: 0x00062DB5 File Offset: 0x00060FB5
			public unsafe static int GeomSidesMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSidesMax, (void*)(&value));
				}
			}

			// Token: 0x17003F49 RID: 16201
			// (get) Token: 0x0600D0CC RID: 53452 RVA: 0x0034614C File Offset: 0x0034434C
			// (set) Token: 0x0600D0CD RID: 53453 RVA: 0x00062DC3 File Offset: 0x00060FC3
			public unsafe static int GeomSegmentsDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F4A RID: 16202
			// (get) Token: 0x0600D0CE RID: 53454 RVA: 0x00346168 File Offset: 0x00344368
			// (set) Token: 0x0600D0CF RID: 53455 RVA: 0x00062DD1 File Offset: 0x00060FD1
			public unsafe static int GeomSegmentsMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMin, (void*)(&value));
				}
			}

			// Token: 0x17003F4B RID: 16203
			// (get) Token: 0x0600D0D0 RID: 53456 RVA: 0x00346184 File Offset: 0x00344384
			// (set) Token: 0x0600D0D1 RID: 53457 RVA: 0x00062DDF File Offset: 0x00060FDF
			public unsafe static int GeomSegmentsMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomSegmentsMax, (void*)(&value));
				}
			}

			// Token: 0x17003F4C RID: 16204
			// (get) Token: 0x0600D0D2 RID: 53458 RVA: 0x003461A0 File Offset: 0x003443A0
			// (set) Token: 0x0600D0D3 RID: 53459 RVA: 0x00062DED File Offset: 0x00060FED
			public unsafe static bool GeomCap
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_GeomCap, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_GeomCap, (void*)(&value));
				}
			}

			// Token: 0x17003F4D RID: 16205
			// (get) Token: 0x0600D0D4 RID: 53460 RVA: 0x003461BC File Offset: 0x003443BC
			// (set) Token: 0x0600D0D5 RID: 53461 RVA: 0x00062DFB File Offset: 0x00060FFB
			public unsafe static bool ScalableDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ScalableDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ScalableDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F4E RID: 16206
			// (get) Token: 0x0600D0D6 RID: 53462 RVA: 0x003461D8 File Offset: 0x003443D8
			// (set) Token: 0x0600D0D7 RID: 53463 RVA: 0x00062E09 File Offset: 0x00061009
			public unsafe static AttenuationEquation AttenuationEquationDefault
			{
				get
				{
					AttenuationEquation result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F4F RID: 16207
			// (get) Token: 0x0600D0D8 RID: 53464 RVA: 0x003461F4 File Offset: 0x003443F4
			// (set) Token: 0x0600D0D9 RID: 53465 RVA: 0x00062E17 File Offset: 0x00061017
			public unsafe static float AttenuationCustomBlendingDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F50 RID: 16208
			// (get) Token: 0x0600D0DA RID: 53466 RVA: 0x00346210 File Offset: 0x00344410
			// (set) Token: 0x0600D0DB RID: 53467 RVA: 0x00062E25 File Offset: 0x00061025
			public unsafe static float AttenuationCustomBlendingMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMin, (void*)(&value));
				}
			}

			// Token: 0x17003F51 RID: 16209
			// (get) Token: 0x0600D0DC RID: 53468 RVA: 0x0034622C File Offset: 0x0034442C
			// (set) Token: 0x0600D0DD RID: 53469 RVA: 0x00062E33 File Offset: 0x00061033
			public unsafe static float AttenuationCustomBlendingMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_AttenuationCustomBlendingMax, (void*)(&value));
				}
			}

			// Token: 0x17003F52 RID: 16210
			// (get) Token: 0x0600D0DE RID: 53470 RVA: 0x00346248 File Offset: 0x00344448
			// (set) Token: 0x0600D0DF RID: 53471 RVA: 0x00062E41 File Offset: 0x00061041
			public unsafe static float FallOffStart
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FallOffStart, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FallOffStart, (void*)(&value));
				}
			}

			// Token: 0x17003F53 RID: 16211
			// (get) Token: 0x0600D0E0 RID: 53472 RVA: 0x00346264 File Offset: 0x00344464
			// (set) Token: 0x0600D0E1 RID: 53473 RVA: 0x00062E4F File Offset: 0x0006104F
			public unsafe static float FallOffEnd
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FallOffEnd, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FallOffEnd, (void*)(&value));
				}
			}

			// Token: 0x17003F54 RID: 16212
			// (get) Token: 0x0600D0E2 RID: 53474 RVA: 0x00346280 File Offset: 0x00344480
			// (set) Token: 0x0600D0E3 RID: 53475 RVA: 0x00062E5D File Offset: 0x0006105D
			public unsafe static float FallOffDistancesMinThreshold
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FallOffDistancesMinThreshold, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FallOffDistancesMinThreshold, (void*)(&value));
				}
			}

			// Token: 0x17003F55 RID: 16213
			// (get) Token: 0x0600D0E4 RID: 53476 RVA: 0x0034629C File Offset: 0x0034449C
			// (set) Token: 0x0600D0E5 RID: 53477 RVA: 0x00062E6B File Offset: 0x0006106B
			public unsafe static float DepthBlendDistance
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&value));
				}
			}

			// Token: 0x17003F56 RID: 16214
			// (get) Token: 0x0600D0E6 RID: 53478 RVA: 0x003462B8 File Offset: 0x003444B8
			// (set) Token: 0x0600D0E7 RID: 53479 RVA: 0x00062E79 File Offset: 0x00061079
			public unsafe static float CameraClippingDistance
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_CameraClippingDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_CameraClippingDistance, (void*)(&value));
				}
			}

			// Token: 0x17003F57 RID: 16215
			// (get) Token: 0x0600D0E8 RID: 53480 RVA: 0x003462D4 File Offset: 0x003444D4
			// (set) Token: 0x0600D0E9 RID: 53481 RVA: 0x00062E87 File Offset: 0x00061087
			public unsafe static NoiseMode NoiseModeDefault
			{
				get
				{
					NoiseMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F58 RID: 16216
			// (get) Token: 0x0600D0EA RID: 53482 RVA: 0x003462F0 File Offset: 0x003444F0
			// (set) Token: 0x0600D0EB RID: 53483 RVA: 0x00062E95 File Offset: 0x00061095
			public unsafe static float NoiseIntensityMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMin, (void*)(&value));
				}
			}

			// Token: 0x17003F59 RID: 16217
			// (get) Token: 0x0600D0EC RID: 53484 RVA: 0x0034630C File Offset: 0x0034450C
			// (set) Token: 0x0600D0ED RID: 53485 RVA: 0x00062EA3 File Offset: 0x000610A3
			public unsafe static float NoiseIntensityMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityMax, (void*)(&value));
				}
			}

			// Token: 0x17003F5A RID: 16218
			// (get) Token: 0x0600D0EE RID: 53486 RVA: 0x00346328 File Offset: 0x00344528
			// (set) Token: 0x0600D0EF RID: 53487 RVA: 0x00062EB1 File Offset: 0x000610B1
			public unsafe static float NoiseIntensityDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseIntensityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F5B RID: 16219
			// (get) Token: 0x0600D0F0 RID: 53488 RVA: 0x00346344 File Offset: 0x00344544
			// (set) Token: 0x0600D0F1 RID: 53489 RVA: 0x00062EBF File Offset: 0x000610BF
			public unsafe static float NoiseScaleMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMin, (void*)(&value));
				}
			}

			// Token: 0x17003F5C RID: 16220
			// (get) Token: 0x0600D0F2 RID: 53490 RVA: 0x00346360 File Offset: 0x00344560
			// (set) Token: 0x0600D0F3 RID: 53491 RVA: 0x00062ECD File Offset: 0x000610CD
			public unsafe static float NoiseScaleMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleMax, (void*)(&value));
				}
			}

			// Token: 0x17003F5D RID: 16221
			// (get) Token: 0x0600D0F4 RID: 53492 RVA: 0x0034637C File Offset: 0x0034457C
			// (set) Token: 0x0600D0F5 RID: 53493 RVA: 0x00062EDB File Offset: 0x000610DB
			public unsafe static float NoiseScaleDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseScaleDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F5E RID: 16222
			// (get) Token: 0x0600D0F6 RID: 53494 RVA: 0x00346398 File Offset: 0x00344598
			// (set) Token: 0x0600D0F7 RID: 53495 RVA: 0x00062EE9 File Offset: 0x000610E9
			public unsafe static Vector3 NoiseVelocityDefault
			{
				get
				{
					Vector3 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_NoiseVelocityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_NoiseVelocityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F5F RID: 16223
			// (get) Token: 0x0600D0F8 RID: 53496 RVA: 0x003463B4 File Offset: 0x003445B4
			// (set) Token: 0x0600D0F9 RID: 53497 RVA: 0x00062EF7 File Offset: 0x000610F7
			public unsafe static BlendingMode BlendingModeDefault
			{
				get
				{
					BlendingMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_BlendingModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_BlendingModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F60 RID: 16224
			// (get) Token: 0x0600D0FA RID: 53498 RVA: 0x003463D0 File Offset: 0x003445D0
			// (set) Token: 0x0600D0FB RID: 53499 RVA: 0x00062F05 File Offset: 0x00061105
			public unsafe static ShaderAccuracy ShaderAccuracyDefault
			{
				get
				{
					ShaderAccuracy result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_ShaderAccuracyDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_ShaderAccuracyDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F61 RID: 16225
			// (get) Token: 0x0600D0FC RID: 53500 RVA: 0x003463EC File Offset: 0x003445EC
			// (set) Token: 0x0600D0FD RID: 53501 RVA: 0x00062F13 File Offset: 0x00061113
			public unsafe static float FadeOutBeginDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FadeOutBeginDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FadeOutBeginDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F62 RID: 16226
			// (get) Token: 0x0600D0FE RID: 53502 RVA: 0x00346408 File Offset: 0x00344608
			// (set) Token: 0x0600D0FF RID: 53503 RVA: 0x00062F21 File Offset: 0x00061121
			public unsafe static float FadeOutEndDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_FadeOutEndDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_FadeOutEndDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F63 RID: 16227
			// (get) Token: 0x0600D100 RID: 53504 RVA: 0x00346424 File Offset: 0x00344624
			// (set) Token: 0x0600D101 RID: 53505 RVA: 0x00062F2F File Offset: 0x0006112F
			public unsafe static Dimensions DimensionsDefault
			{
				get
				{
					Dimensions result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Beam.NativeFieldInfoPtr_DimensionsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Beam.NativeFieldInfoPtr_DimensionsDefault, (void*)(&value));
				}
			}

			// Token: 0x04008E2B RID: 36395
			private static readonly IntPtr NativeFieldInfoPtr_FlatColor;

			// Token: 0x04008E2C RID: 36396
			private static readonly IntPtr NativeFieldInfoPtr_ColorModeDefault;

			// Token: 0x04008E2D RID: 36397
			private static readonly IntPtr NativeFieldInfoPtr_MultiplierDefault;

			// Token: 0x04008E2E RID: 36398
			private static readonly IntPtr NativeFieldInfoPtr_MultiplierMin;

			// Token: 0x04008E2F RID: 36399
			private static readonly IntPtr NativeFieldInfoPtr_IntensityDefault;

			// Token: 0x04008E30 RID: 36400
			private static readonly IntPtr NativeFieldInfoPtr_IntensityMin;

			// Token: 0x04008E31 RID: 36401
			private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeightDefault;

			// Token: 0x04008E32 RID: 36402
			private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeightMin;

			// Token: 0x04008E33 RID: 36403
			private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeightMax;

			// Token: 0x04008E34 RID: 36404
			private static readonly IntPtr NativeFieldInfoPtr_SpotAngleDefault;

			// Token: 0x04008E35 RID: 36405
			private static readonly IntPtr NativeFieldInfoPtr_SpotAngleMin;

			// Token: 0x04008E36 RID: 36406
			private static readonly IntPtr NativeFieldInfoPtr_SpotAngleMax;

			// Token: 0x04008E37 RID: 36407
			private static readonly IntPtr NativeFieldInfoPtr_ConeRadiusStart;

			// Token: 0x04008E38 RID: 36408
			private static readonly IntPtr NativeFieldInfoPtr_GeomMeshType;

			// Token: 0x04008E39 RID: 36409
			private static readonly IntPtr NativeFieldInfoPtr_GeomSidesDefault;

			// Token: 0x04008E3A RID: 36410
			private static readonly IntPtr NativeFieldInfoPtr_GeomSidesMin;

			// Token: 0x04008E3B RID: 36411
			private static readonly IntPtr NativeFieldInfoPtr_GeomSidesMax;

			// Token: 0x04008E3C RID: 36412
			private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsDefault;

			// Token: 0x04008E3D RID: 36413
			private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsMin;

			// Token: 0x04008E3E RID: 36414
			private static readonly IntPtr NativeFieldInfoPtr_GeomSegmentsMax;

			// Token: 0x04008E3F RID: 36415
			private static readonly IntPtr NativeFieldInfoPtr_GeomCap;

			// Token: 0x04008E40 RID: 36416
			private static readonly IntPtr NativeFieldInfoPtr_ScalableDefault;

			// Token: 0x04008E41 RID: 36417
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationEquationDefault;

			// Token: 0x04008E42 RID: 36418
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationCustomBlendingDefault;

			// Token: 0x04008E43 RID: 36419
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationCustomBlendingMin;

			// Token: 0x04008E44 RID: 36420
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationCustomBlendingMax;

			// Token: 0x04008E45 RID: 36421
			private static readonly IntPtr NativeFieldInfoPtr_FallOffStart;

			// Token: 0x04008E46 RID: 36422
			private static readonly IntPtr NativeFieldInfoPtr_FallOffEnd;

			// Token: 0x04008E47 RID: 36423
			private static readonly IntPtr NativeFieldInfoPtr_FallOffDistancesMinThreshold;

			// Token: 0x04008E48 RID: 36424
			private static readonly IntPtr NativeFieldInfoPtr_DepthBlendDistance;

			// Token: 0x04008E49 RID: 36425
			private static readonly IntPtr NativeFieldInfoPtr_CameraClippingDistance;

			// Token: 0x04008E4A RID: 36426
			private static readonly IntPtr NativeFieldInfoPtr_NoiseModeDefault;

			// Token: 0x04008E4B RID: 36427
			private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityMin;

			// Token: 0x04008E4C RID: 36428
			private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityMax;

			// Token: 0x04008E4D RID: 36429
			private static readonly IntPtr NativeFieldInfoPtr_NoiseIntensityDefault;

			// Token: 0x04008E4E RID: 36430
			private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleMin;

			// Token: 0x04008E4F RID: 36431
			private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleMax;

			// Token: 0x04008E50 RID: 36432
			private static readonly IntPtr NativeFieldInfoPtr_NoiseScaleDefault;

			// Token: 0x04008E51 RID: 36433
			private static readonly IntPtr NativeFieldInfoPtr_NoiseVelocityDefault;

			// Token: 0x04008E52 RID: 36434
			private static readonly IntPtr NativeFieldInfoPtr_BlendingModeDefault;

			// Token: 0x04008E53 RID: 36435
			private static readonly IntPtr NativeFieldInfoPtr_ShaderAccuracyDefault;

			// Token: 0x04008E54 RID: 36436
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutBeginDefault;

			// Token: 0x04008E55 RID: 36437
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutEndDefault;

			// Token: 0x04008E56 RID: 36438
			private static readonly IntPtr NativeFieldInfoPtr_DimensionsDefault;

			// Token: 0x02000DA1 RID: 3489
			public static class SD : Il2CppSystem.Object
			{
				// Token: 0x0600FCD4 RID: 64724 RVA: 0x003C43C8 File Offset: 0x003C25C8
				// Note: this type is marked as 'beforefieldinit'.
				static SD()
				{
					Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "SD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr);
					Consts.Beam.SD.NativeFieldInfoPtr_FresnelPowMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "FresnelPowMaxValue");
					Consts.Beam.SD.NativeFieldInfoPtr_FresnelPow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "FresnelPow");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareFrontalDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareFrontalDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareBehindDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareBehindDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareMin");
					Consts.Beam.SD.NativeFieldInfoPtr_GlareMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "GlareMax");
					Consts.Beam.SD.NativeFieldInfoPtr_TiltDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "TiltDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "SkewingLocalForwardDirectionDefault");
					Consts.Beam.SD.NativeFieldInfoPtr_ClippingPlaneTransformDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.SD>.NativeClassPtr, "ClippingPlaneTransformDefault");
				}

				// Token: 0x0600FCD5 RID: 64725 RVA: 0x00077B5D File Offset: 0x00075D5D
				public SD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004CCA RID: 19658
				// (get) Token: 0x0600FCD6 RID: 64726 RVA: 0x003C44A8 File Offset: 0x003C26A8
				// (set) Token: 0x0600FCD7 RID: 64727 RVA: 0x00077B66 File Offset: 0x00075D66
				public unsafe static float FresnelPowMaxValue
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPowMaxValue, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPowMaxValue, (void*)(&value));
					}
				}

				// Token: 0x17004CCB RID: 19659
				// (get) Token: 0x0600FCD8 RID: 64728 RVA: 0x003C44C4 File Offset: 0x003C26C4
				// (set) Token: 0x0600FCD9 RID: 64729 RVA: 0x00077B74 File Offset: 0x00075D74
				public unsafe static float FresnelPow
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&value));
					}
				}

				// Token: 0x17004CCC RID: 19660
				// (get) Token: 0x0600FCDA RID: 64730 RVA: 0x003C44E0 File Offset: 0x003C26E0
				// (set) Token: 0x0600FCDB RID: 64731 RVA: 0x00077B82 File Offset: 0x00075D82
				public unsafe static float GlareFrontalDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareFrontalDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareFrontalDefault, (void*)(&value));
					}
				}

				// Token: 0x17004CCD RID: 19661
				// (get) Token: 0x0600FCDC RID: 64732 RVA: 0x003C44FC File Offset: 0x003C26FC
				// (set) Token: 0x0600FCDD RID: 64733 RVA: 0x00077B90 File Offset: 0x00075D90
				public unsafe static float GlareBehindDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareBehindDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareBehindDefault, (void*)(&value));
					}
				}

				// Token: 0x17004CCE RID: 19662
				// (get) Token: 0x0600FCDE RID: 64734 RVA: 0x003C4518 File Offset: 0x003C2718
				// (set) Token: 0x0600FCDF RID: 64735 RVA: 0x00077B9E File Offset: 0x00075D9E
				public unsafe static float GlareMin
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMin, (void*)(&value));
					}
				}

				// Token: 0x17004CCF RID: 19663
				// (get) Token: 0x0600FCE0 RID: 64736 RVA: 0x003C4534 File Offset: 0x003C2734
				// (set) Token: 0x0600FCE1 RID: 64737 RVA: 0x00077BAC File Offset: 0x00075DAC
				public unsafe static float GlareMax
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMax, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_GlareMax, (void*)(&value));
					}
				}

				// Token: 0x17004CD0 RID: 19664
				// (get) Token: 0x0600FCE2 RID: 64738 RVA: 0x003C4550 File Offset: 0x003C2750
				// (set) Token: 0x0600FCE3 RID: 64739 RVA: 0x00077BBA File Offset: 0x00075DBA
				public unsafe static Vector2 TiltDefault
				{
					get
					{
						Vector2 result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_TiltDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_TiltDefault, (void*)(&value));
					}
				}

				// Token: 0x17004CD1 RID: 19665
				// (get) Token: 0x0600FCE4 RID: 64740 RVA: 0x003C456C File Offset: 0x003C276C
				// (set) Token: 0x0600FCE5 RID: 64741 RVA: 0x00077BC8 File Offset: 0x00075DC8
				public unsafe static Vector3 SkewingLocalForwardDirectionDefault
				{
					get
					{
						Vector3 result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault, (void*)(&value));
					}
				}

				// Token: 0x17004CD2 RID: 19666
				// (get) Token: 0x0600FCE6 RID: 64742 RVA: 0x003C4588 File Offset: 0x003C2788
				// (set) Token: 0x0600FCE7 RID: 64743 RVA: 0x00077BD6 File Offset: 0x00075DD6
				public unsafe static Transform ClippingPlaneTransformDefault
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.SD.NativeFieldInfoPtr_ClippingPlaneTransformDefault, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.SD.NativeFieldInfoPtr_ClippingPlaneTransformDefault, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AA6F RID: 43631
				private static readonly IntPtr NativeFieldInfoPtr_FresnelPowMaxValue;

				// Token: 0x0400AA70 RID: 43632
				private static readonly IntPtr NativeFieldInfoPtr_FresnelPow;

				// Token: 0x0400AA71 RID: 43633
				private static readonly IntPtr NativeFieldInfoPtr_GlareFrontalDefault;

				// Token: 0x0400AA72 RID: 43634
				private static readonly IntPtr NativeFieldInfoPtr_GlareBehindDefault;

				// Token: 0x0400AA73 RID: 43635
				private static readonly IntPtr NativeFieldInfoPtr_GlareMin;

				// Token: 0x0400AA74 RID: 43636
				private static readonly IntPtr NativeFieldInfoPtr_GlareMax;

				// Token: 0x0400AA75 RID: 43637
				private static readonly IntPtr NativeFieldInfoPtr_TiltDefault;

				// Token: 0x0400AA76 RID: 43638
				private static readonly IntPtr NativeFieldInfoPtr_SkewingLocalForwardDirectionDefault;

				// Token: 0x0400AA77 RID: 43639
				private static readonly IntPtr NativeFieldInfoPtr_ClippingPlaneTransformDefault;
			}

			// Token: 0x02000DA2 RID: 3490
			public static class HD : Il2CppSystem.Object
			{
				// Token: 0x0600FCE8 RID: 64744 RVA: 0x003C45B0 File Offset: 0x003C27B0
				// Note: this type is marked as 'beforefieldinit'.
				static HD()
				{
					Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Beam>.NativeClassPtr, "HD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr);
					Consts.Beam.HD.NativeFieldInfoPtr_AttenuationEquationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "AttenuationEquationDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "SideSoftnessDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "SideSoftnessMin");
					Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "SideSoftnessMax");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFactorDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFactorMin");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFrameRateDefault");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFrameRateMin");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringFrameRateMax");
					Consts.Beam.HD.NativeFieldInfoPtr_JitteringLerpRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Beam.HD>.NativeClassPtr, "JitteringLerpRange");
				}

				// Token: 0x0600FCE9 RID: 64745 RVA: 0x00077BE8 File Offset: 0x00075DE8
				public HD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004CD3 RID: 19667
				// (get) Token: 0x0600FCEA RID: 64746 RVA: 0x003C46A4 File Offset: 0x003C28A4
				// (set) Token: 0x0600FCEB RID: 64747 RVA: 0x00077BF1 File Offset: 0x00075DF1
				public unsafe static AttenuationEquationHD AttenuationEquationDefault
				{
					get
					{
						AttenuationEquationHD result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_AttenuationEquationDefault, (void*)(&value));
					}
				}

				// Token: 0x17004CD4 RID: 19668
				// (get) Token: 0x0600FCEC RID: 64748 RVA: 0x003C46C0 File Offset: 0x003C28C0
				// (set) Token: 0x0600FCED RID: 64749 RVA: 0x00077BFF File Offset: 0x00075DFF
				public unsafe static float SideSoftnessDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessDefault, (void*)(&value));
					}
				}

				// Token: 0x17004CD5 RID: 19669
				// (get) Token: 0x0600FCEE RID: 64750 RVA: 0x003C46DC File Offset: 0x003C28DC
				// (set) Token: 0x0600FCEF RID: 64751 RVA: 0x00077C0D File Offset: 0x00075E0D
				public unsafe static float SideSoftnessMin
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMin, (void*)(&value));
					}
				}

				// Token: 0x17004CD6 RID: 19670
				// (get) Token: 0x0600FCF0 RID: 64752 RVA: 0x003C46F8 File Offset: 0x003C28F8
				// (set) Token: 0x0600FCF1 RID: 64753 RVA: 0x00077C1B File Offset: 0x00075E1B
				public unsafe static float SideSoftnessMax
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMax, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_SideSoftnessMax, (void*)(&value));
					}
				}

				// Token: 0x17004CD7 RID: 19671
				// (get) Token: 0x0600FCF2 RID: 64754 RVA: 0x003C4714 File Offset: 0x003C2914
				// (set) Token: 0x0600FCF3 RID: 64755 RVA: 0x00077C29 File Offset: 0x00075E29
				public unsafe static float JitteringFactorDefault
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorDefault, (void*)(&value));
					}
				}

				// Token: 0x17004CD8 RID: 19672
				// (get) Token: 0x0600FCF4 RID: 64756 RVA: 0x003C4730 File Offset: 0x003C2930
				// (set) Token: 0x0600FCF5 RID: 64757 RVA: 0x00077C37 File Offset: 0x00075E37
				public unsafe static float JitteringFactorMin
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFactorMin, (void*)(&value));
					}
				}

				// Token: 0x17004CD9 RID: 19673
				// (get) Token: 0x0600FCF6 RID: 64758 RVA: 0x003C474C File Offset: 0x003C294C
				// (set) Token: 0x0600FCF7 RID: 64759 RVA: 0x00077C45 File Offset: 0x00075E45
				public unsafe static int JitteringFrameRateDefault
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateDefault, (void*)(&value));
					}
				}

				// Token: 0x17004CDA RID: 19674
				// (get) Token: 0x0600FCF8 RID: 64760 RVA: 0x003C4768 File Offset: 0x003C2968
				// (set) Token: 0x0600FCF9 RID: 64761 RVA: 0x00077C53 File Offset: 0x00075E53
				public unsafe static int JitteringFrameRateMin
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMin, (void*)(&value));
					}
				}

				// Token: 0x17004CDB RID: 19675
				// (get) Token: 0x0600FCFA RID: 64762 RVA: 0x003C4784 File Offset: 0x003C2984
				// (set) Token: 0x0600FCFB RID: 64763 RVA: 0x00077C61 File Offset: 0x00075E61
				public unsafe static int JitteringFrameRateMax
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMax, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringFrameRateMax, (void*)(&value));
					}
				}

				// Token: 0x17004CDC RID: 19676
				// (get) Token: 0x0600FCFC RID: 64764 RVA: 0x003C47A0 File Offset: 0x003C29A0
				// (set) Token: 0x0600FCFD RID: 64765 RVA: 0x00077C6F File Offset: 0x00075E6F
				public unsafe static MinMaxRangeFloat JitteringLerpRange
				{
					get
					{
						MinMaxRangeFloat result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringLerpRange, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Beam.HD.NativeFieldInfoPtr_JitteringLerpRange, (void*)(&value));
					}
				}

				// Token: 0x0400AA78 RID: 43640
				private static readonly IntPtr NativeFieldInfoPtr_AttenuationEquationDefault;

				// Token: 0x0400AA79 RID: 43641
				private static readonly IntPtr NativeFieldInfoPtr_SideSoftnessDefault;

				// Token: 0x0400AA7A RID: 43642
				private static readonly IntPtr NativeFieldInfoPtr_SideSoftnessMin;

				// Token: 0x0400AA7B RID: 43643
				private static readonly IntPtr NativeFieldInfoPtr_SideSoftnessMax;

				// Token: 0x0400AA7C RID: 43644
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFactorDefault;

				// Token: 0x0400AA7D RID: 43645
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFactorMin;

				// Token: 0x0400AA7E RID: 43646
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFrameRateDefault;

				// Token: 0x0400AA7F RID: 43647
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFrameRateMin;

				// Token: 0x0400AA80 RID: 43648
				private static readonly IntPtr NativeFieldInfoPtr_JitteringFrameRateMax;

				// Token: 0x0400AA81 RID: 43649
				private static readonly IntPtr NativeFieldInfoPtr_JitteringLerpRange;
			}
		}

		// Token: 0x02000869 RID: 2153
		public static class DustParticles : Il2CppSystem.Object
		{
			// Token: 0x0600D102 RID: 53506 RVA: 0x00346440 File Offset: 0x00344640
			// Note: this type is marked as 'beforefieldinit'.
			static DustParticles()
			{
				Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DustParticles");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr);
				Consts.DustParticles.NativeFieldInfoPtr_AlphaDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "AlphaDefault");
				Consts.DustParticles.NativeFieldInfoPtr_SizeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "SizeDefault");
				Consts.DustParticles.NativeFieldInfoPtr_DirectionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DirectionDefault");
				Consts.DustParticles.NativeFieldInfoPtr_VelocityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "VelocityDefault");
				Consts.DustParticles.NativeFieldInfoPtr_DensityDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DensityDefault");
				Consts.DustParticles.NativeFieldInfoPtr_DensityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DensityMin");
				Consts.DustParticles.NativeFieldInfoPtr_DensityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "DensityMax");
				Consts.DustParticles.NativeFieldInfoPtr_SpawnDistanceRangeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "SpawnDistanceRangeDefault");
				Consts.DustParticles.NativeFieldInfoPtr_CullingEnabledDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "CullingEnabledDefault");
				Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "CullingMaxDistanceDefault");
				Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DustParticles>.NativeClassPtr, "CullingMaxDistanceMin");
			}

			// Token: 0x0600D103 RID: 53507 RVA: 0x00062F3D File Offset: 0x0006113D
			public DustParticles(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F64 RID: 16228
			// (get) Token: 0x0600D104 RID: 53508 RVA: 0x00346548 File Offset: 0x00344748
			// (set) Token: 0x0600D105 RID: 53509 RVA: 0x00062F46 File Offset: 0x00061146
			public unsafe static float AlphaDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_AlphaDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_AlphaDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F65 RID: 16229
			// (get) Token: 0x0600D106 RID: 53510 RVA: 0x00346564 File Offset: 0x00344764
			// (set) Token: 0x0600D107 RID: 53511 RVA: 0x00062F54 File Offset: 0x00061154
			public unsafe static float SizeDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_SizeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_SizeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F66 RID: 16230
			// (get) Token: 0x0600D108 RID: 53512 RVA: 0x00346580 File Offset: 0x00344780
			// (set) Token: 0x0600D109 RID: 53513 RVA: 0x00062F62 File Offset: 0x00061162
			public unsafe static ParticlesDirection DirectionDefault
			{
				get
				{
					ParticlesDirection result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DirectionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DirectionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F67 RID: 16231
			// (get) Token: 0x0600D10A RID: 53514 RVA: 0x0034659C File Offset: 0x0034479C
			// (set) Token: 0x0600D10B RID: 53515 RVA: 0x00062F70 File Offset: 0x00061170
			public unsafe static Vector3 VelocityDefault
			{
				get
				{
					Vector3 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_VelocityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_VelocityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F68 RID: 16232
			// (get) Token: 0x0600D10C RID: 53516 RVA: 0x003465B8 File Offset: 0x003447B8
			// (set) Token: 0x0600D10D RID: 53517 RVA: 0x00062F7E File Offset: 0x0006117E
			public unsafe static float DensityDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DensityDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DensityDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F69 RID: 16233
			// (get) Token: 0x0600D10E RID: 53518 RVA: 0x003465D4 File Offset: 0x003447D4
			// (set) Token: 0x0600D10F RID: 53519 RVA: 0x00062F8C File Offset: 0x0006118C
			public unsafe static float DensityMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMin, (void*)(&value));
				}
			}

			// Token: 0x17003F6A RID: 16234
			// (get) Token: 0x0600D110 RID: 53520 RVA: 0x003465F0 File Offset: 0x003447F0
			// (set) Token: 0x0600D111 RID: 53521 RVA: 0x00062F9A File Offset: 0x0006119A
			public unsafe static float DensityMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_DensityMax, (void*)(&value));
				}
			}

			// Token: 0x17003F6B RID: 16235
			// (get) Token: 0x0600D112 RID: 53522 RVA: 0x0034660C File Offset: 0x0034480C
			// (set) Token: 0x0600D113 RID: 53523 RVA: 0x00062FA8 File Offset: 0x000611A8
			public unsafe static MinMaxRangeFloat SpawnDistanceRangeDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_SpawnDistanceRangeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_SpawnDistanceRangeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F6C RID: 16236
			// (get) Token: 0x0600D114 RID: 53524 RVA: 0x00346628 File Offset: 0x00344828
			// (set) Token: 0x0600D115 RID: 53525 RVA: 0x00062FB6 File Offset: 0x000611B6
			public unsafe static bool CullingEnabledDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_CullingEnabledDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_CullingEnabledDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F6D RID: 16237
			// (get) Token: 0x0600D116 RID: 53526 RVA: 0x00346644 File Offset: 0x00344844
			// (set) Token: 0x0600D117 RID: 53527 RVA: 0x00062FC4 File Offset: 0x000611C4
			public unsafe static float CullingMaxDistanceDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F6E RID: 16238
			// (get) Token: 0x0600D118 RID: 53528 RVA: 0x00346660 File Offset: 0x00344860
			// (set) Token: 0x0600D119 RID: 53529 RVA: 0x00062FD2 File Offset: 0x000611D2
			public unsafe static float CullingMaxDistanceMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DustParticles.NativeFieldInfoPtr_CullingMaxDistanceMin, (void*)(&value));
				}
			}

			// Token: 0x04008E57 RID: 36439
			private static readonly IntPtr NativeFieldInfoPtr_AlphaDefault;

			// Token: 0x04008E58 RID: 36440
			private static readonly IntPtr NativeFieldInfoPtr_SizeDefault;

			// Token: 0x04008E59 RID: 36441
			private static readonly IntPtr NativeFieldInfoPtr_DirectionDefault;

			// Token: 0x04008E5A RID: 36442
			private static readonly IntPtr NativeFieldInfoPtr_VelocityDefault;

			// Token: 0x04008E5B RID: 36443
			private static readonly IntPtr NativeFieldInfoPtr_DensityDefault;

			// Token: 0x04008E5C RID: 36444
			private static readonly IntPtr NativeFieldInfoPtr_DensityMin;

			// Token: 0x04008E5D RID: 36445
			private static readonly IntPtr NativeFieldInfoPtr_DensityMax;

			// Token: 0x04008E5E RID: 36446
			private static readonly IntPtr NativeFieldInfoPtr_SpawnDistanceRangeDefault;

			// Token: 0x04008E5F RID: 36447
			private static readonly IntPtr NativeFieldInfoPtr_CullingEnabledDefault;

			// Token: 0x04008E60 RID: 36448
			private static readonly IntPtr NativeFieldInfoPtr_CullingMaxDistanceDefault;

			// Token: 0x04008E61 RID: 36449
			private static readonly IntPtr NativeFieldInfoPtr_CullingMaxDistanceMin;
		}

		// Token: 0x0200086A RID: 2154
		public static class DynOcclusion : Il2CppSystem.Object
		{
			// Token: 0x0600D11A RID: 53530 RVA: 0x0034667C File Offset: 0x0034487C
			// Note: this type is marked as 'beforefieldinit'.
			static DynOcclusion()
			{
				Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "DynOcclusion");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr);
				Consts.DynOcclusion.NativeFieldInfoPtr_LayerMaskDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "LayerMaskDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_UpdateRateDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "UpdateRateDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_WaitFramesCountDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "WaitFramesCountDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingDimensionsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingDimensionsDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingConsiderTriggersDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingConsiderTriggersDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinOccluderAreaDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinSurfaceRatioDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinSurfaceRatioMin");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMinSurfaceRatioMax");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMaxSurfaceDotDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMaxSurfaceAngleMin");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingMaxSurfaceAngleMax");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingPlaneAlignmentDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneOffsetDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingPlaneOffsetDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "RaycastingFadeDistanceToSurfaceDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "DepthBufferDepthMapResolutionDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "DepthBufferOcclusionCullingDefault");
				Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.DynOcclusion>.NativeClassPtr, "DepthBufferFadeDistanceToSurfaceDefault");
			}

			// Token: 0x0600D11B RID: 53531 RVA: 0x00062FE0 File Offset: 0x000611E0
			public DynOcclusion(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F6F RID: 16239
			// (get) Token: 0x0600D11C RID: 53532 RVA: 0x00346810 File Offset: 0x00344A10
			// (set) Token: 0x0600D11D RID: 53533 RVA: 0x00062FE9 File Offset: 0x000611E9
			public unsafe static LayerMask LayerMaskDefault
			{
				get
				{
					LayerMask result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F70 RID: 16240
			// (get) Token: 0x0600D11E RID: 53534 RVA: 0x0034682C File Offset: 0x00344A2C
			// (set) Token: 0x0600D11F RID: 53535 RVA: 0x00062FF7 File Offset: 0x000611F7
			public unsafe static DynamicOcclusionUpdateRate UpdateRateDefault
			{
				get
				{
					DynamicOcclusionUpdateRate result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F71 RID: 16241
			// (get) Token: 0x0600D120 RID: 53536 RVA: 0x00346848 File Offset: 0x00344A48
			// (set) Token: 0x0600D121 RID: 53537 RVA: 0x00063005 File Offset: 0x00061205
			public unsafe static int WaitFramesCountDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F72 RID: 16242
			// (get) Token: 0x0600D122 RID: 53538 RVA: 0x00346864 File Offset: 0x00344A64
			// (set) Token: 0x0600D123 RID: 53539 RVA: 0x00063013 File Offset: 0x00061213
			public unsafe static Dimensions RaycastingDimensionsDefault
			{
				get
				{
					Dimensions result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingDimensionsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingDimensionsDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F73 RID: 16243
			// (get) Token: 0x0600D124 RID: 53540 RVA: 0x00346880 File Offset: 0x00344A80
			// (set) Token: 0x0600D125 RID: 53541 RVA: 0x00063021 File Offset: 0x00061221
			public unsafe static bool RaycastingConsiderTriggersDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingConsiderTriggersDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingConsiderTriggersDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F74 RID: 16244
			// (get) Token: 0x0600D126 RID: 53542 RVA: 0x0034689C File Offset: 0x00344A9C
			// (set) Token: 0x0600D127 RID: 53543 RVA: 0x0006302F File Offset: 0x0006122F
			public unsafe static float RaycastingMinOccluderAreaDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F75 RID: 16245
			// (get) Token: 0x0600D128 RID: 53544 RVA: 0x003468B8 File Offset: 0x00344AB8
			// (set) Token: 0x0600D129 RID: 53545 RVA: 0x0006303D File Offset: 0x0006123D
			public unsafe static float RaycastingMinSurfaceRatioDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F76 RID: 16246
			// (get) Token: 0x0600D12A RID: 53546 RVA: 0x003468D4 File Offset: 0x00344AD4
			// (set) Token: 0x0600D12B RID: 53547 RVA: 0x0006304B File Offset: 0x0006124B
			public unsafe static float RaycastingMinSurfaceRatioMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin, (void*)(&value));
				}
			}

			// Token: 0x17003F77 RID: 16247
			// (get) Token: 0x0600D12C RID: 53548 RVA: 0x003468F0 File Offset: 0x00344AF0
			// (set) Token: 0x0600D12D RID: 53549 RVA: 0x00063059 File Offset: 0x00061259
			public unsafe static float RaycastingMinSurfaceRatioMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax, (void*)(&value));
				}
			}

			// Token: 0x17003F78 RID: 16248
			// (get) Token: 0x0600D12E RID: 53550 RVA: 0x0034690C File Offset: 0x00344B0C
			// (set) Token: 0x0600D12F RID: 53551 RVA: 0x00063067 File Offset: 0x00061267
			public unsafe static float RaycastingMaxSurfaceDotDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F79 RID: 16249
			// (get) Token: 0x0600D130 RID: 53552 RVA: 0x00346928 File Offset: 0x00344B28
			// (set) Token: 0x0600D131 RID: 53553 RVA: 0x00063075 File Offset: 0x00061275
			public unsafe static float RaycastingMaxSurfaceAngleMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin, (void*)(&value));
				}
			}

			// Token: 0x17003F7A RID: 16250
			// (get) Token: 0x0600D132 RID: 53554 RVA: 0x00346944 File Offset: 0x00344B44
			// (set) Token: 0x0600D133 RID: 53555 RVA: 0x00063083 File Offset: 0x00061283
			public unsafe static float RaycastingMaxSurfaceAngleMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax, (void*)(&value));
				}
			}

			// Token: 0x17003F7B RID: 16251
			// (get) Token: 0x0600D134 RID: 53556 RVA: 0x00346960 File Offset: 0x00344B60
			// (set) Token: 0x0600D135 RID: 53557 RVA: 0x00063091 File Offset: 0x00061291
			public unsafe static PlaneAlignment RaycastingPlaneAlignmentDefault
			{
				get
				{
					PlaneAlignment result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F7C RID: 16252
			// (get) Token: 0x0600D136 RID: 53558 RVA: 0x0034697C File Offset: 0x00344B7C
			// (set) Token: 0x0600D137 RID: 53559 RVA: 0x0006309F File Offset: 0x0006129F
			public unsafe static float RaycastingPlaneOffsetDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneOffsetDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingPlaneOffsetDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F7D RID: 16253
			// (get) Token: 0x0600D138 RID: 53560 RVA: 0x00346998 File Offset: 0x00344B98
			// (set) Token: 0x0600D139 RID: 53561 RVA: 0x000630AD File Offset: 0x000612AD
			public unsafe static float RaycastingFadeDistanceToSurfaceDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F7E RID: 16254
			// (get) Token: 0x0600D13A RID: 53562 RVA: 0x003469B4 File Offset: 0x00344BB4
			// (set) Token: 0x0600D13B RID: 53563 RVA: 0x000630BB File Offset: 0x000612BB
			public unsafe static int DepthBufferDepthMapResolutionDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F7F RID: 16255
			// (get) Token: 0x0600D13C RID: 53564 RVA: 0x003469D0 File Offset: 0x00344BD0
			// (set) Token: 0x0600D13D RID: 53565 RVA: 0x000630C9 File Offset: 0x000612C9
			public unsafe static bool DepthBufferOcclusionCullingDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F80 RID: 16256
			// (get) Token: 0x0600D13E RID: 53566 RVA: 0x003469EC File Offset: 0x00344BEC
			// (set) Token: 0x0600D13F RID: 53567 RVA: 0x000630D7 File Offset: 0x000612D7
			public unsafe static float DepthBufferFadeDistanceToSurfaceDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.DynOcclusion.NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault, (void*)(&value));
				}
			}

			// Token: 0x04008E62 RID: 36450
			private static readonly IntPtr NativeFieldInfoPtr_LayerMaskDefault;

			// Token: 0x04008E63 RID: 36451
			private static readonly IntPtr NativeFieldInfoPtr_UpdateRateDefault;

			// Token: 0x04008E64 RID: 36452
			private static readonly IntPtr NativeFieldInfoPtr_WaitFramesCountDefault;

			// Token: 0x04008E65 RID: 36453
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingDimensionsDefault;

			// Token: 0x04008E66 RID: 36454
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingConsiderTriggersDefault;

			// Token: 0x04008E67 RID: 36455
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinOccluderAreaDefault;

			// Token: 0x04008E68 RID: 36456
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinSurfaceRatioDefault;

			// Token: 0x04008E69 RID: 36457
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinSurfaceRatioMin;

			// Token: 0x04008E6A RID: 36458
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMinSurfaceRatioMax;

			// Token: 0x04008E6B RID: 36459
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMaxSurfaceDotDefault;

			// Token: 0x04008E6C RID: 36460
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMin;

			// Token: 0x04008E6D RID: 36461
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingMaxSurfaceAngleMax;

			// Token: 0x04008E6E RID: 36462
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingPlaneAlignmentDefault;

			// Token: 0x04008E6F RID: 36463
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingPlaneOffsetDefault;

			// Token: 0x04008E70 RID: 36464
			private static readonly IntPtr NativeFieldInfoPtr_RaycastingFadeDistanceToSurfaceDefault;

			// Token: 0x04008E71 RID: 36465
			private static readonly IntPtr NativeFieldInfoPtr_DepthBufferDepthMapResolutionDefault;

			// Token: 0x04008E72 RID: 36466
			private static readonly IntPtr NativeFieldInfoPtr_DepthBufferOcclusionCullingDefault;

			// Token: 0x04008E73 RID: 36467
			private static readonly IntPtr NativeFieldInfoPtr_DepthBufferFadeDistanceToSurfaceDefault;
		}

		// Token: 0x0200086B RID: 2155
		public static class Effects : Il2CppSystem.Object
		{
			// Token: 0x0600D140 RID: 53568 RVA: 0x00346A08 File Offset: 0x00344C08
			// Note: this type is marked as 'beforefieldinit'.
			static Effects()
			{
				Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Effects");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr);
				Consts.Effects.NativeFieldInfoPtr_ComponentsToChangeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "ComponentsToChangeDefault");
				Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnDisableDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "RestoreIntensityOnDisableDefault");
				Consts.Effects.NativeFieldInfoPtr_FrequencyDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "FrequencyDefault");
				Consts.Effects.NativeFieldInfoPtr_PerformPausesDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "PerformPausesDefault");
				Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnPauseDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "RestoreIntensityOnPauseDefault");
				Consts.Effects.NativeFieldInfoPtr_FlickeringDurationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "FlickeringDurationDefault");
				Consts.Effects.NativeFieldInfoPtr_PauseDurationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "PauseDurationDefault");
				Consts.Effects.NativeFieldInfoPtr_IntensityAmplitudeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "IntensityAmplitudeDefault");
				Consts.Effects.NativeFieldInfoPtr_SmoothingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Effects>.NativeClassPtr, "SmoothingDefault");
			}

			// Token: 0x0600D141 RID: 53569 RVA: 0x000630E5 File Offset: 0x000612E5
			public Effects(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F81 RID: 16257
			// (get) Token: 0x0600D142 RID: 53570 RVA: 0x00346AE8 File Offset: 0x00344CE8
			// (set) Token: 0x0600D143 RID: 53571 RVA: 0x000630EE File Offset: 0x000612EE
			public unsafe static EffectAbstractBase.ComponentsToChange ComponentsToChangeDefault
			{
				get
				{
					EffectAbstractBase.ComponentsToChange result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_ComponentsToChangeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_ComponentsToChangeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F82 RID: 16258
			// (get) Token: 0x0600D144 RID: 53572 RVA: 0x00346B04 File Offset: 0x00344D04
			// (set) Token: 0x0600D145 RID: 53573 RVA: 0x000630FC File Offset: 0x000612FC
			public unsafe static bool RestoreIntensityOnDisableDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnDisableDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnDisableDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F83 RID: 16259
			// (get) Token: 0x0600D146 RID: 53574 RVA: 0x00346B20 File Offset: 0x00344D20
			// (set) Token: 0x0600D147 RID: 53575 RVA: 0x0006310A File Offset: 0x0006130A
			public unsafe static float FrequencyDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_FrequencyDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_FrequencyDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F84 RID: 16260
			// (get) Token: 0x0600D148 RID: 53576 RVA: 0x00346B3C File Offset: 0x00344D3C
			// (set) Token: 0x0600D149 RID: 53577 RVA: 0x00063118 File Offset: 0x00061318
			public unsafe static bool PerformPausesDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_PerformPausesDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_PerformPausesDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F85 RID: 16261
			// (get) Token: 0x0600D14A RID: 53578 RVA: 0x00346B58 File Offset: 0x00344D58
			// (set) Token: 0x0600D14B RID: 53579 RVA: 0x00063126 File Offset: 0x00061326
			public unsafe static bool RestoreIntensityOnPauseDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnPauseDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_RestoreIntensityOnPauseDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F86 RID: 16262
			// (get) Token: 0x0600D14C RID: 53580 RVA: 0x00346B74 File Offset: 0x00344D74
			// (set) Token: 0x0600D14D RID: 53581 RVA: 0x00063134 File Offset: 0x00061334
			public unsafe static MinMaxRangeFloat FlickeringDurationDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_FlickeringDurationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_FlickeringDurationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F87 RID: 16263
			// (get) Token: 0x0600D14E RID: 53582 RVA: 0x00346B90 File Offset: 0x00344D90
			// (set) Token: 0x0600D14F RID: 53583 RVA: 0x00063142 File Offset: 0x00061342
			public unsafe static MinMaxRangeFloat PauseDurationDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_PauseDurationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_PauseDurationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F88 RID: 16264
			// (get) Token: 0x0600D150 RID: 53584 RVA: 0x00346BAC File Offset: 0x00344DAC
			// (set) Token: 0x0600D151 RID: 53585 RVA: 0x00063150 File Offset: 0x00061350
			public unsafe static MinMaxRangeFloat IntensityAmplitudeDefault
			{
				get
				{
					MinMaxRangeFloat result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_IntensityAmplitudeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_IntensityAmplitudeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F89 RID: 16265
			// (get) Token: 0x0600D152 RID: 53586 RVA: 0x00346BC8 File Offset: 0x00344DC8
			// (set) Token: 0x0600D153 RID: 53587 RVA: 0x0006315E File Offset: 0x0006135E
			public unsafe static float SmoothingDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Effects.NativeFieldInfoPtr_SmoothingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Effects.NativeFieldInfoPtr_SmoothingDefault, (void*)(&value));
				}
			}

			// Token: 0x04008E74 RID: 36468
			private static readonly IntPtr NativeFieldInfoPtr_ComponentsToChangeDefault;

			// Token: 0x04008E75 RID: 36469
			private static readonly IntPtr NativeFieldInfoPtr_RestoreIntensityOnDisableDefault;

			// Token: 0x04008E76 RID: 36470
			private static readonly IntPtr NativeFieldInfoPtr_FrequencyDefault;

			// Token: 0x04008E77 RID: 36471
			private static readonly IntPtr NativeFieldInfoPtr_PerformPausesDefault;

			// Token: 0x04008E78 RID: 36472
			private static readonly IntPtr NativeFieldInfoPtr_RestoreIntensityOnPauseDefault;

			// Token: 0x04008E79 RID: 36473
			private static readonly IntPtr NativeFieldInfoPtr_FlickeringDurationDefault;

			// Token: 0x04008E7A RID: 36474
			private static readonly IntPtr NativeFieldInfoPtr_PauseDurationDefault;

			// Token: 0x04008E7B RID: 36475
			private static readonly IntPtr NativeFieldInfoPtr_IntensityAmplitudeDefault;

			// Token: 0x04008E7C RID: 36476
			private static readonly IntPtr NativeFieldInfoPtr_SmoothingDefault;
		}

		// Token: 0x0200086C RID: 2156
		public static class Shadow : Il2CppSystem.Object
		{
			// Token: 0x0600D154 RID: 53588 RVA: 0x00346BE4 File Offset: 0x00344DE4
			// Note: this type is marked as 'beforefieldinit'.
			static Shadow()
			{
				Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Shadow");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr);
				Consts.Shadow.NativeFieldInfoPtr_StrengthDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "StrengthDefault");
				Consts.Shadow.NativeFieldInfoPtr_StrengthMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "StrengthMin");
				Consts.Shadow.NativeFieldInfoPtr_StrengthMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "StrengthMax");
				Consts.Shadow.NativeFieldInfoPtr_LayerMaskDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "LayerMaskDefault");
				Consts.Shadow.NativeFieldInfoPtr_UpdateRateDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "UpdateRateDefault");
				Consts.Shadow.NativeFieldInfoPtr_WaitFramesCountDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "WaitFramesCountDefault");
				Consts.Shadow.NativeFieldInfoPtr_DepthMapResolutionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "DepthMapResolutionDefault");
				Consts.Shadow.NativeFieldInfoPtr_OcclusionCullingDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, "OcclusionCullingDefault");
				Consts.Shadow.NativeMethodInfoPtr_GetErrorChangeRuntimeDepthMapResolution_Public_Static_String_VolumetricShadowHD_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Consts.Shadow>.NativeClassPtr, 100663738);
			}

			// Token: 0x0600D155 RID: 53589 RVA: 0x00346CC4 File Offset: 0x00344EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69368, XrefRangeEnd = 69376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetErrorChangeRuntimeDepthMapResolution(VolumetricShadowHD comp)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Consts.Shadow.NativeMethodInfoPtr_GetErrorChangeRuntimeDepthMapResolution_Public_Static_String_VolumetricShadowHD_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D156 RID: 53590 RVA: 0x0006316C File Offset: 0x0006136C
			public Shadow(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F8A RID: 16266
			// (get) Token: 0x0600D157 RID: 53591 RVA: 0x00346D00 File Offset: 0x00344F00
			// (set) Token: 0x0600D158 RID: 53592 RVA: 0x00063175 File Offset: 0x00061375
			public unsafe static float StrengthDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_StrengthDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_StrengthDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F8B RID: 16267
			// (get) Token: 0x0600D159 RID: 53593 RVA: 0x00346D1C File Offset: 0x00344F1C
			// (set) Token: 0x0600D15A RID: 53594 RVA: 0x00063183 File Offset: 0x00061383
			public unsafe static float StrengthMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMin, (void*)(&value));
				}
			}

			// Token: 0x17003F8C RID: 16268
			// (get) Token: 0x0600D15B RID: 53595 RVA: 0x00346D38 File Offset: 0x00344F38
			// (set) Token: 0x0600D15C RID: 53596 RVA: 0x00063191 File Offset: 0x00061391
			public unsafe static float StrengthMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_StrengthMax, (void*)(&value));
				}
			}

			// Token: 0x17003F8D RID: 16269
			// (get) Token: 0x0600D15D RID: 53597 RVA: 0x00346D54 File Offset: 0x00344F54
			// (set) Token: 0x0600D15E RID: 53598 RVA: 0x0006319F File Offset: 0x0006139F
			public unsafe static LayerMask LayerMaskDefault
			{
				get
				{
					LayerMask result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_LayerMaskDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F8E RID: 16270
			// (get) Token: 0x0600D15F RID: 53599 RVA: 0x00346D70 File Offset: 0x00344F70
			// (set) Token: 0x0600D160 RID: 53600 RVA: 0x000631AD File Offset: 0x000613AD
			public unsafe static ShadowUpdateRate UpdateRateDefault
			{
				get
				{
					ShadowUpdateRate result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_UpdateRateDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F8F RID: 16271
			// (get) Token: 0x0600D161 RID: 53601 RVA: 0x00346D8C File Offset: 0x00344F8C
			// (set) Token: 0x0600D162 RID: 53602 RVA: 0x000631BB File Offset: 0x000613BB
			public unsafe static int WaitFramesCountDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_WaitFramesCountDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F90 RID: 16272
			// (get) Token: 0x0600D163 RID: 53603 RVA: 0x00346DA8 File Offset: 0x00344FA8
			// (set) Token: 0x0600D164 RID: 53604 RVA: 0x000631C9 File Offset: 0x000613C9
			public unsafe static int DepthMapResolutionDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_DepthMapResolutionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_DepthMapResolutionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F91 RID: 16273
			// (get) Token: 0x0600D165 RID: 53605 RVA: 0x00346DC4 File Offset: 0x00344FC4
			// (set) Token: 0x0600D166 RID: 53606 RVA: 0x000631D7 File Offset: 0x000613D7
			public unsafe static bool OcclusionCullingDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Shadow.NativeFieldInfoPtr_OcclusionCullingDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Shadow.NativeFieldInfoPtr_OcclusionCullingDefault, (void*)(&value));
				}
			}

			// Token: 0x04008E7D RID: 36477
			private static readonly IntPtr NativeFieldInfoPtr_StrengthDefault;

			// Token: 0x04008E7E RID: 36478
			private static readonly IntPtr NativeFieldInfoPtr_StrengthMin;

			// Token: 0x04008E7F RID: 36479
			private static readonly IntPtr NativeFieldInfoPtr_StrengthMax;

			// Token: 0x04008E80 RID: 36480
			private static readonly IntPtr NativeFieldInfoPtr_LayerMaskDefault;

			// Token: 0x04008E81 RID: 36481
			private static readonly IntPtr NativeFieldInfoPtr_UpdateRateDefault;

			// Token: 0x04008E82 RID: 36482
			private static readonly IntPtr NativeFieldInfoPtr_WaitFramesCountDefault;

			// Token: 0x04008E83 RID: 36483
			private static readonly IntPtr NativeFieldInfoPtr_DepthMapResolutionDefault;

			// Token: 0x04008E84 RID: 36484
			private static readonly IntPtr NativeFieldInfoPtr_OcclusionCullingDefault;

			// Token: 0x04008E85 RID: 36485
			private static readonly IntPtr NativeMethodInfoPtr_GetErrorChangeRuntimeDepthMapResolution_Public_Static_String_VolumetricShadowHD_0;
		}

		// Token: 0x0200086D RID: 2157
		public static class Cookie : Il2CppSystem.Object
		{
			// Token: 0x0600D167 RID: 53607 RVA: 0x00346DE0 File Offset: 0x00344FE0
			// Note: this type is marked as 'beforefieldinit'.
			static Cookie()
			{
				Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Cookie");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr);
				Consts.Cookie.NativeFieldInfoPtr_ContributionDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ContributionDefault");
				Consts.Cookie.NativeFieldInfoPtr_ContributionMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ContributionMin");
				Consts.Cookie.NativeFieldInfoPtr_ContributionMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ContributionMax");
				Consts.Cookie.NativeFieldInfoPtr_CookieTextureDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "CookieTextureDefault");
				Consts.Cookie.NativeFieldInfoPtr_ChannelDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ChannelDefault");
				Consts.Cookie.NativeFieldInfoPtr_NegativeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "NegativeDefault");
				Consts.Cookie.NativeFieldInfoPtr_TranslationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "TranslationDefault");
				Consts.Cookie.NativeFieldInfoPtr_RotationDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "RotationDefault");
				Consts.Cookie.NativeFieldInfoPtr_ScaleDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Cookie>.NativeClassPtr, "ScaleDefault");
			}

			// Token: 0x0600D168 RID: 53608 RVA: 0x000631E5 File Offset: 0x000613E5
			public Cookie(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F92 RID: 16274
			// (get) Token: 0x0600D169 RID: 53609 RVA: 0x00346EC0 File Offset: 0x003450C0
			// (set) Token: 0x0600D16A RID: 53610 RVA: 0x000631EE File Offset: 0x000613EE
			public unsafe static float ContributionDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ContributionDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ContributionDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F93 RID: 16275
			// (get) Token: 0x0600D16B RID: 53611 RVA: 0x00346EDC File Offset: 0x003450DC
			// (set) Token: 0x0600D16C RID: 53612 RVA: 0x000631FC File Offset: 0x000613FC
			public unsafe static float ContributionMin
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMin, (void*)(&value));
				}
			}

			// Token: 0x17003F94 RID: 16276
			// (get) Token: 0x0600D16D RID: 53613 RVA: 0x00346EF8 File Offset: 0x003450F8
			// (set) Token: 0x0600D16E RID: 53614 RVA: 0x0006320A File Offset: 0x0006140A
			public unsafe static float ContributionMax
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ContributionMax, (void*)(&value));
				}
			}

			// Token: 0x17003F95 RID: 16277
			// (get) Token: 0x0600D16F RID: 53615 RVA: 0x00346F14 File Offset: 0x00345114
			// (set) Token: 0x0600D170 RID: 53616 RVA: 0x00063218 File Offset: 0x00061418
			public unsafe static Texture CookieTextureDefault
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_CookieTextureDefault, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_CookieTextureDefault, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F96 RID: 16278
			// (get) Token: 0x0600D171 RID: 53617 RVA: 0x00346F3C File Offset: 0x0034513C
			// (set) Token: 0x0600D172 RID: 53618 RVA: 0x0006322A File Offset: 0x0006142A
			public unsafe static CookieChannel ChannelDefault
			{
				get
				{
					CookieChannel result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ChannelDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ChannelDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F97 RID: 16279
			// (get) Token: 0x0600D173 RID: 53619 RVA: 0x00346F58 File Offset: 0x00345158
			// (set) Token: 0x0600D174 RID: 53620 RVA: 0x00063238 File Offset: 0x00061438
			public unsafe static bool NegativeDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_NegativeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_NegativeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F98 RID: 16280
			// (get) Token: 0x0600D175 RID: 53621 RVA: 0x00346F74 File Offset: 0x00345174
			// (set) Token: 0x0600D176 RID: 53622 RVA: 0x00063246 File Offset: 0x00061446
			public unsafe static Vector2 TranslationDefault
			{
				get
				{
					Vector2 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_TranslationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_TranslationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F99 RID: 16281
			// (get) Token: 0x0600D177 RID: 53623 RVA: 0x00346F90 File Offset: 0x00345190
			// (set) Token: 0x0600D178 RID: 53624 RVA: 0x00063254 File Offset: 0x00061454
			public unsafe static float RotationDefault
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_RotationDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_RotationDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F9A RID: 16282
			// (get) Token: 0x0600D179 RID: 53625 RVA: 0x00346FAC File Offset: 0x003451AC
			// (set) Token: 0x0600D17A RID: 53626 RVA: 0x00063262 File Offset: 0x00061462
			public unsafe static Vector2 ScaleDefault
			{
				get
				{
					Vector2 result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Cookie.NativeFieldInfoPtr_ScaleDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Cookie.NativeFieldInfoPtr_ScaleDefault, (void*)(&value));
				}
			}

			// Token: 0x04008E86 RID: 36486
			private static readonly IntPtr NativeFieldInfoPtr_ContributionDefault;

			// Token: 0x04008E87 RID: 36487
			private static readonly IntPtr NativeFieldInfoPtr_ContributionMin;

			// Token: 0x04008E88 RID: 36488
			private static readonly IntPtr NativeFieldInfoPtr_ContributionMax;

			// Token: 0x04008E89 RID: 36489
			private static readonly IntPtr NativeFieldInfoPtr_CookieTextureDefault;

			// Token: 0x04008E8A RID: 36490
			private static readonly IntPtr NativeFieldInfoPtr_ChannelDefault;

			// Token: 0x04008E8B RID: 36491
			private static readonly IntPtr NativeFieldInfoPtr_NegativeDefault;

			// Token: 0x04008E8C RID: 36492
			private static readonly IntPtr NativeFieldInfoPtr_TranslationDefault;

			// Token: 0x04008E8D RID: 36493
			private static readonly IntPtr NativeFieldInfoPtr_RotationDefault;

			// Token: 0x04008E8E RID: 36494
			private static readonly IntPtr NativeFieldInfoPtr_ScaleDefault;
		}

		// Token: 0x0200086E RID: 2158
		public static class Config : Il2CppSystem.Object
		{
			// Token: 0x0600D17B RID: 53627 RVA: 0x00346FC8 File Offset: 0x003451C8
			// Note: this type is marked as 'beforefieldinit'.
			static Config()
			{
				Il2CppClassPointerStore<Consts.Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts>.NativeClassPtr, "Config");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr);
				Consts.Config.NativeFieldInfoPtr_GeometryOverrideLayerDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryOverrideLayerDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryLayerIDDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryLayerIDDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryTagDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryTagDefault");
				Consts.Config.NativeFieldInfoPtr_FadeOutCameraTagDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "FadeOutCameraTagDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryRenderQueueDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryRenderQueueDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryRenderPipelineDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryRenderPipelineDefault");
				Consts.Config.NativeFieldInfoPtr_GeometryRenderingModeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "GeometryRenderingModeDefault");
				Consts.Config.NativeFieldInfoPtr_Noise3DSizeDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "Noise3DSizeDefault");
				Consts.Config.NativeFieldInfoPtr_DitheringFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "DitheringFactor");
				Consts.Config.NativeFieldInfoPtr_UseLightColorTemperatureDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "UseLightColorTemperatureDefault");
				Consts.Config.NativeFieldInfoPtr_FeatureEnabledDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "FeatureEnabledDefault");
				Consts.Config.NativeFieldInfoPtr_FeatureEnabledColorGradientDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "FeatureEnabledColorGradientDefault");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSidesDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSidesDefault");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSidesMin");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSidesMax");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSegmentsDefault");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSegmentsMin");
				Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "SharedMeshSegmentsMax");
			}

			// Token: 0x0600D17C RID: 53628 RVA: 0x00063270 File Offset: 0x00061470
			public Config(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F9B RID: 16283
			// (get) Token: 0x0600D17D RID: 53629 RVA: 0x0034715C File Offset: 0x0034535C
			// (set) Token: 0x0600D17E RID: 53630 RVA: 0x00063279 File Offset: 0x00061479
			public unsafe static bool GeometryOverrideLayerDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryOverrideLayerDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryOverrideLayerDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F9C RID: 16284
			// (get) Token: 0x0600D17F RID: 53631 RVA: 0x00347178 File Offset: 0x00345378
			// (set) Token: 0x0600D180 RID: 53632 RVA: 0x00063287 File Offset: 0x00061487
			public unsafe static int GeometryLayerIDDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryLayerIDDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryLayerIDDefault, (void*)(&value));
				}
			}

			// Token: 0x17003F9D RID: 16285
			// (get) Token: 0x0600D181 RID: 53633 RVA: 0x00347194 File Offset: 0x00345394
			// (set) Token: 0x0600D182 RID: 53634 RVA: 0x00063295 File Offset: 0x00061495
			public unsafe static string GeometryTagDefault
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryTagDefault, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryTagDefault, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F9E RID: 16286
			// (get) Token: 0x0600D183 RID: 53635 RVA: 0x003471B4 File Offset: 0x003453B4
			// (set) Token: 0x0600D184 RID: 53636 RVA: 0x000632A7 File Offset: 0x000614A7
			public unsafe static string FadeOutCameraTagDefault
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_FadeOutCameraTagDefault, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_FadeOutCameraTagDefault, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003F9F RID: 16287
			// (get) Token: 0x0600D185 RID: 53637 RVA: 0x003471D4 File Offset: 0x003453D4
			// (set) Token: 0x0600D186 RID: 53638 RVA: 0x000632B9 File Offset: 0x000614B9
			public unsafe static RenderQueue GeometryRenderQueueDefault
			{
				get
				{
					RenderQueue result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&value));
				}
			}

			// Token: 0x17003FA0 RID: 16288
			// (get) Token: 0x0600D187 RID: 53639 RVA: 0x003471F0 File Offset: 0x003453F0
			// (set) Token: 0x0600D188 RID: 53640 RVA: 0x000632C7 File Offset: 0x000614C7
			public unsafe static RenderPipeline GeometryRenderPipelineDefault
			{
				get
				{
					RenderPipeline result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderPipelineDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderPipelineDefault, (void*)(&value));
				}
			}

			// Token: 0x17003FA1 RID: 16289
			// (get) Token: 0x0600D189 RID: 53641 RVA: 0x0034720C File Offset: 0x0034540C
			// (set) Token: 0x0600D18A RID: 53642 RVA: 0x000632D5 File Offset: 0x000614D5
			public unsafe static RenderingMode GeometryRenderingModeDefault
			{
				get
				{
					RenderingMode result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderingModeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_GeometryRenderingModeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003FA2 RID: 16290
			// (get) Token: 0x0600D18B RID: 53643 RVA: 0x00347228 File Offset: 0x00345428
			// (set) Token: 0x0600D18C RID: 53644 RVA: 0x000632E3 File Offset: 0x000614E3
			public unsafe static int Noise3DSizeDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_Noise3DSizeDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_Noise3DSizeDefault, (void*)(&value));
				}
			}

			// Token: 0x17003FA3 RID: 16291
			// (get) Token: 0x0600D18D RID: 53645 RVA: 0x00347244 File Offset: 0x00345444
			// (set) Token: 0x0600D18E RID: 53646 RVA: 0x000632F1 File Offset: 0x000614F1
			public unsafe static float DitheringFactor
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_DitheringFactor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_DitheringFactor, (void*)(&value));
				}
			}

			// Token: 0x17003FA4 RID: 16292
			// (get) Token: 0x0600D18F RID: 53647 RVA: 0x00347260 File Offset: 0x00345460
			// (set) Token: 0x0600D190 RID: 53648 RVA: 0x000632FF File Offset: 0x000614FF
			public unsafe static bool UseLightColorTemperatureDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_UseLightColorTemperatureDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_UseLightColorTemperatureDefault, (void*)(&value));
				}
			}

			// Token: 0x17003FA5 RID: 16293
			// (get) Token: 0x0600D191 RID: 53649 RVA: 0x0034727C File Offset: 0x0034547C
			// (set) Token: 0x0600D192 RID: 53650 RVA: 0x0006330D File Offset: 0x0006150D
			public unsafe static bool FeatureEnabledDefault
			{
				get
				{
					bool result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledDefault, (void*)(&value));
				}
			}

			// Token: 0x17003FA6 RID: 16294
			// (get) Token: 0x0600D193 RID: 53651 RVA: 0x00347298 File Offset: 0x00345498
			// (set) Token: 0x0600D194 RID: 53652 RVA: 0x0006331B File Offset: 0x0006151B
			public unsafe static FeatureEnabledColorGradient FeatureEnabledColorGradientDefault
			{
				get
				{
					FeatureEnabledColorGradient result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledColorGradientDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_FeatureEnabledColorGradientDefault, (void*)(&value));
				}
			}

			// Token: 0x17003FA7 RID: 16295
			// (get) Token: 0x0600D195 RID: 53653 RVA: 0x003472B4 File Offset: 0x003454B4
			// (set) Token: 0x0600D196 RID: 53654 RVA: 0x00063329 File Offset: 0x00061529
			public unsafe static int SharedMeshSidesDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesDefault, (void*)(&value));
				}
			}

			// Token: 0x17003FA8 RID: 16296
			// (get) Token: 0x0600D197 RID: 53655 RVA: 0x003472D0 File Offset: 0x003454D0
			// (set) Token: 0x0600D198 RID: 53656 RVA: 0x00063337 File Offset: 0x00061537
			public unsafe static int SharedMeshSidesMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMin, (void*)(&value));
				}
			}

			// Token: 0x17003FA9 RID: 16297
			// (get) Token: 0x0600D199 RID: 53657 RVA: 0x003472EC File Offset: 0x003454EC
			// (set) Token: 0x0600D19A RID: 53658 RVA: 0x00063345 File Offset: 0x00061545
			public unsafe static int SharedMeshSidesMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSidesMax, (void*)(&value));
				}
			}

			// Token: 0x17003FAA RID: 16298
			// (get) Token: 0x0600D19B RID: 53659 RVA: 0x00347308 File Offset: 0x00345508
			// (set) Token: 0x0600D19C RID: 53660 RVA: 0x00063353 File Offset: 0x00061553
			public unsafe static int SharedMeshSegmentsDefault
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsDefault, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsDefault, (void*)(&value));
				}
			}

			// Token: 0x17003FAB RID: 16299
			// (get) Token: 0x0600D19D RID: 53661 RVA: 0x00347324 File Offset: 0x00345524
			// (set) Token: 0x0600D19E RID: 53662 RVA: 0x00063361 File Offset: 0x00061561
			public unsafe static int SharedMeshSegmentsMin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMin, (void*)(&value));
				}
			}

			// Token: 0x17003FAC RID: 16300
			// (get) Token: 0x0600D19F RID: 53663 RVA: 0x00347340 File Offset: 0x00345540
			// (set) Token: 0x0600D1A0 RID: 53664 RVA: 0x0006336F File Offset: 0x0006156F
			public unsafe static int SharedMeshSegmentsMax
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMax, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Consts.Config.NativeFieldInfoPtr_SharedMeshSegmentsMax, (void*)(&value));
				}
			}

			// Token: 0x04008E8F RID: 36495
			private static readonly IntPtr NativeFieldInfoPtr_GeometryOverrideLayerDefault;

			// Token: 0x04008E90 RID: 36496
			private static readonly IntPtr NativeFieldInfoPtr_GeometryLayerIDDefault;

			// Token: 0x04008E91 RID: 36497
			private static readonly IntPtr NativeFieldInfoPtr_GeometryTagDefault;

			// Token: 0x04008E92 RID: 36498
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutCameraTagDefault;

			// Token: 0x04008E93 RID: 36499
			private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderQueueDefault;

			// Token: 0x04008E94 RID: 36500
			private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderPipelineDefault;

			// Token: 0x04008E95 RID: 36501
			private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderingModeDefault;

			// Token: 0x04008E96 RID: 36502
			private static readonly IntPtr NativeFieldInfoPtr_Noise3DSizeDefault;

			// Token: 0x04008E97 RID: 36503
			private static readonly IntPtr NativeFieldInfoPtr_DitheringFactor;

			// Token: 0x04008E98 RID: 36504
			private static readonly IntPtr NativeFieldInfoPtr_UseLightColorTemperatureDefault;

			// Token: 0x04008E99 RID: 36505
			private static readonly IntPtr NativeFieldInfoPtr_FeatureEnabledDefault;

			// Token: 0x04008E9A RID: 36506
			private static readonly IntPtr NativeFieldInfoPtr_FeatureEnabledColorGradientDefault;

			// Token: 0x04008E9B RID: 36507
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSidesDefault;

			// Token: 0x04008E9C RID: 36508
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSidesMin;

			// Token: 0x04008E9D RID: 36509
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSidesMax;

			// Token: 0x04008E9E RID: 36510
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSegmentsDefault;

			// Token: 0x04008E9F RID: 36511
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSegmentsMin;

			// Token: 0x04008EA0 RID: 36512
			private static readonly IntPtr NativeFieldInfoPtr_SharedMeshSegmentsMax;

			// Token: 0x02000DA3 RID: 3491
			public static class HD : Il2CppSystem.Object
			{
				// Token: 0x0600FCFE RID: 64766 RVA: 0x003C47BC File Offset: 0x003C29BC
				// Note: this type is marked as 'beforefieldinit'.
				static HD()
				{
					Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Consts.Config>.NativeClassPtr, "HD");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr);
					Consts.Config.HD.NativeFieldInfoPtr_GeometryRenderQueueDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr, "GeometryRenderQueueDefault");
					Consts.Config.HD.NativeFieldInfoPtr_CameraBlendingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr, "CameraBlendingDistance");
					Consts.Config.HD.NativeFieldInfoPtr_RaymarchingQualitiesStepsMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Consts.Config.HD>.NativeClassPtr, "RaymarchingQualitiesStepsMin");
				}

				// Token: 0x0600FCFF RID: 64767 RVA: 0x00077C7D File Offset: 0x00075E7D
				public HD(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004CDD RID: 19677
				// (get) Token: 0x0600FD00 RID: 64768 RVA: 0x003C4824 File Offset: 0x003C2A24
				// (set) Token: 0x0600FD01 RID: 64769 RVA: 0x00077C86 File Offset: 0x00075E86
				public unsafe static RenderQueue GeometryRenderQueueDefault
				{
					get
					{
						RenderQueue result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Config.HD.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Config.HD.NativeFieldInfoPtr_GeometryRenderQueueDefault, (void*)(&value));
					}
				}

				// Token: 0x17004CDE RID: 19678
				// (get) Token: 0x0600FD02 RID: 64770 RVA: 0x003C4840 File Offset: 0x003C2A40
				// (set) Token: 0x0600FD03 RID: 64771 RVA: 0x00077C94 File Offset: 0x00075E94
				public unsafe static float CameraBlendingDistance
				{
					get
					{
						float result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Config.HD.NativeFieldInfoPtr_CameraBlendingDistance, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Config.HD.NativeFieldInfoPtr_CameraBlendingDistance, (void*)(&value));
					}
				}

				// Token: 0x17004CDF RID: 19679
				// (get) Token: 0x0600FD04 RID: 64772 RVA: 0x003C485C File Offset: 0x003C2A5C
				// (set) Token: 0x0600FD05 RID: 64773 RVA: 0x00077CA2 File Offset: 0x00075EA2
				public unsafe static int RaymarchingQualitiesStepsMin
				{
					get
					{
						int result;
						IL2CPP.il2cpp_field_static_get_value(Consts.Config.HD.NativeFieldInfoPtr_RaymarchingQualitiesStepsMin, (void*)(&result));
						return result;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Consts.Config.HD.NativeFieldInfoPtr_RaymarchingQualitiesStepsMin, (void*)(&value));
					}
				}

				// Token: 0x0400AA82 RID: 43650
				private static readonly IntPtr NativeFieldInfoPtr_GeometryRenderQueueDefault;

				// Token: 0x0400AA83 RID: 43651
				private static readonly IntPtr NativeFieldInfoPtr_CameraBlendingDistance;

				// Token: 0x0400AA84 RID: 43652
				private static readonly IntPtr NativeFieldInfoPtr_RaymarchingQualitiesStepsMin;
			}
		}
	}
}

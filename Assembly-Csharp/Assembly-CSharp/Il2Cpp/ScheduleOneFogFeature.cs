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
	// Token: 0x0200000B RID: 11
	public class ScheduleOneFogFeature : ScriptableRendererFeature
	{
		// Token: 0x06000078 RID: 120 RVA: 0x0007CF88 File Offset: 0x0007B188
		// Note: this type is marked as 'beforefieldinit'.
		static ScheduleOneFogFeature()
		{
			Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScheduleOneFogFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr);
			ScheduleOneFogFeature.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr, "_settings");
			ScheduleOneFogFeature.NativeFieldInfoPtr__pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr, "_pass");
			ScheduleOneFogFeature.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr, "_material");
			ScheduleOneFogFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr, 100663337);
			ScheduleOneFogFeature.NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr, 100663338);
			ScheduleOneFogFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr, 100663339);
			ScheduleOneFogFeature.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr, 100663340);
			ScheduleOneFogFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr, 100663341);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0007D058 File Offset: 0x0007B258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65079, XrefRangeEnd = 65107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduleOneFogFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0007D094 File Offset: 0x0007B294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65107, XrefRangeEnd = 65113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetupRenderPasses(ScriptableRenderer renderer, [In] ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduleOneFogFeature.NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0007D0FC File Offset: 0x0007B2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65113, XrefRangeEnd = 65118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduleOneFogFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0007D164 File Offset: 0x0007B364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65118, XrefRangeEnd = 65123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref disposing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduleOneFogFeature.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0007D1B0 File Offset: 0x0007B3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65123, XrefRangeEnd = 65129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScheduleOneFogFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduleOneFogFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002433 File Offset: 0x00000633
		public ScheduleOneFogFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0007D1EC File Offset: 0x0007B3EC
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000243C File Offset: 0x0000063C
		public unsafe ScheduleOneFogFeature.Settings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScheduleOneFogFeature.Settings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0007D21C File Offset: 0x0007B41C
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000245B File Offset: 0x0000065B
		public unsafe ScheduleOneFogPass _pass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.NativeFieldInfoPtr__pass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScheduleOneFogPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.NativeFieldInfoPtr__pass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0007D24C File Offset: 0x0007B44C
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0000247A File Offset: 0x0000067A
		public unsafe Material _material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.NativeFieldInfoPtr__material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr__pass;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr__material;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_SetupRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200084D RID: 2125
		[Serializable]
		public class Settings : Il2CppSystem.Object
		{
			// Token: 0x0600CF58 RID: 53080 RVA: 0x00342274 File Offset: 0x00340474
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScheduleOneFogFeature>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr);
				ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_RenderPassEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr, "RenderPassEvent");
				ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr, "Shader");
				ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr, "Color");
				ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr, "Start");
				ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr, "End");
				ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr, "Density");
				ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_BlurStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr, "BlurStrength");
				ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_StartHeightFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr, "StartHeightFade");
				ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_EndHeightFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr, "EndHeightFade");
				ScheduleOneFogFeature.Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr, 100663342);
			}

			// Token: 0x0600CF59 RID: 53081 RVA: 0x00342368 File Offset: 0x00340568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65078, XrefRangeEnd = 65079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Settings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduleOneFogFeature.Settings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduleOneFogFeature.Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CF5A RID: 53082 RVA: 0x0006219D File Offset: 0x0006039D
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EC4 RID: 16068
			// (get) Token: 0x0600CF5B RID: 53083 RVA: 0x003423A4 File Offset: 0x003405A4
			// (set) Token: 0x0600CF5C RID: 53084 RVA: 0x000621A6 File Offset: 0x000603A6
			public unsafe RenderPassEvent RenderPassEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_RenderPassEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_RenderPassEvent)) = value;
				}
			}

			// Token: 0x17003EC5 RID: 16069
			// (get) Token: 0x0600CF5D RID: 53085 RVA: 0x003423CC File Offset: 0x003405CC
			// (set) Token: 0x0600CF5E RID: 53086 RVA: 0x000621C1 File Offset: 0x000603C1
			public unsafe Shader Shader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Shader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Shader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EC6 RID: 16070
			// (get) Token: 0x0600CF5F RID: 53087 RVA: 0x003423FC File Offset: 0x003405FC
			// (set) Token: 0x0600CF60 RID: 53088 RVA: 0x000621E0 File Offset: 0x000603E0
			public unsafe Color Color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x17003EC7 RID: 16071
			// (get) Token: 0x0600CF61 RID: 53089 RVA: 0x00342424 File Offset: 0x00340624
			// (set) Token: 0x0600CF62 RID: 53090 RVA: 0x000621FB File Offset: 0x000603FB
			public unsafe float Start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Start)) = value;
				}
			}

			// Token: 0x17003EC8 RID: 16072
			// (get) Token: 0x0600CF63 RID: 53091 RVA: 0x0034244C File Offset: 0x0034064C
			// (set) Token: 0x0600CF64 RID: 53092 RVA: 0x00062216 File Offset: 0x00060416
			public unsafe float End
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_End);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_End)) = value;
				}
			}

			// Token: 0x17003EC9 RID: 16073
			// (get) Token: 0x0600CF65 RID: 53093 RVA: 0x00342474 File Offset: 0x00340674
			// (set) Token: 0x0600CF66 RID: 53094 RVA: 0x00062231 File Offset: 0x00060431
			public unsafe float Density
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Density);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_Density)) = value;
				}
			}

			// Token: 0x17003ECA RID: 16074
			// (get) Token: 0x0600CF67 RID: 53095 RVA: 0x0034249C File Offset: 0x0034069C
			// (set) Token: 0x0600CF68 RID: 53096 RVA: 0x0006224C File Offset: 0x0006044C
			public unsafe float BlurStrength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_BlurStrength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_BlurStrength)) = value;
				}
			}

			// Token: 0x17003ECB RID: 16075
			// (get) Token: 0x0600CF69 RID: 53097 RVA: 0x003424C4 File Offset: 0x003406C4
			// (set) Token: 0x0600CF6A RID: 53098 RVA: 0x00062267 File Offset: 0x00060467
			public unsafe float StartHeightFade
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_StartHeightFade);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_StartHeightFade)) = value;
				}
			}

			// Token: 0x17003ECC RID: 16076
			// (get) Token: 0x0600CF6B RID: 53099 RVA: 0x003424EC File Offset: 0x003406EC
			// (set) Token: 0x0600CF6C RID: 53100 RVA: 0x00062282 File Offset: 0x00060482
			public unsafe float EndHeightFade
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_EndHeightFade);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduleOneFogFeature.Settings.NativeFieldInfoPtr_EndHeightFade)) = value;
				}
			}

			// Token: 0x04008D69 RID: 36201
			private static readonly IntPtr NativeFieldInfoPtr_RenderPassEvent;

			// Token: 0x04008D6A RID: 36202
			private static readonly IntPtr NativeFieldInfoPtr_Shader;

			// Token: 0x04008D6B RID: 36203
			private static readonly IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x04008D6C RID: 36204
			private static readonly IntPtr NativeFieldInfoPtr_Start;

			// Token: 0x04008D6D RID: 36205
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x04008D6E RID: 36206
			private static readonly IntPtr NativeFieldInfoPtr_Density;

			// Token: 0x04008D6F RID: 36207
			private static readonly IntPtr NativeFieldInfoPtr_BlurStrength;

			// Token: 0x04008D70 RID: 36208
			private static readonly IntPtr NativeFieldInfoPtr_StartHeightFade;

			// Token: 0x04008D71 RID: 36209
			private static readonly IntPtr NativeFieldInfoPtr_EndHeightFade;

			// Token: 0x04008D72 RID: 36210
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

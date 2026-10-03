using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x0200038A RID: 906
	public class PsychedelicFullScreenFeature : ScriptableRendererFeature
	{
		// Token: 0x06005058 RID: 20568 RVA: 0x0018F90C File Offset: 0x0018DB0C
		// Note: this type is marked as 'beforefieldinit'.
		static PsychedelicFullScreenFeature()
		{
			Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "PsychedelicFullScreenFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr);
			PsychedelicFullScreenFeature.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, "_settings");
			PsychedelicFullScreenFeature.NativeFieldInfoPtr_BLEND_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, "BLEND_ID");
			PsychedelicFullScreenFeature.NativeFieldInfoPtr_NOISE_SCALE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, "NOISE_SCALE_ID");
			PsychedelicFullScreenFeature.NativeFieldInfoPtr_PAN_SPEED_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, "PAN_SPEED_ID");
			PsychedelicFullScreenFeature.NativeFieldInfoPtr_DOES_BOUNCE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, "DOES_BOUNCE_ID");
			PsychedelicFullScreenFeature.NativeFieldInfoPtr_AMPLITUDE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, "AMPLITUDE_ID");
			PsychedelicFullScreenFeature.NativeFieldInfoPtr__psychedelicPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, "_psychedelicPass");
			PsychedelicFullScreenFeature.NativeMethodInfoPtr_get_FeatureSettings_Public_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, 100673722);
			PsychedelicFullScreenFeature.NativeMethodInfoPtr_get_ActiveMaterialProperties_Public_get_MaterialProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, 100673723);
			PsychedelicFullScreenFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, 100673724);
			PsychedelicFullScreenFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, 100673725);
			PsychedelicFullScreenFeature.NativeMethodInfoPtr_SetActiveMaterialProperties_Public_Void_MaterialProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, 100673726);
			PsychedelicFullScreenFeature.NativeMethodInfoPtr_PrintMaterialValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, 100673727);
			PsychedelicFullScreenFeature.NativeMethodInfoPtr_GetMaterialPreset_Public_PsychedelicFullScreenData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, 100673728);
			PsychedelicFullScreenFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, 100673729);
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x06005059 RID: 20569 RVA: 0x0018FA68 File Offset: 0x0018DC68
		public unsafe PsychedelicFullScreenFeature.Settings FeatureSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenFeature.NativeMethodInfoPtr_get_FeatureSettings_Public_get_Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature.Settings>(intPtr3) : null;
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x0600505A RID: 20570 RVA: 0x0018FAA8 File Offset: 0x0018DCA8
		public unsafe PsychedelicFullScreenFeature.MaterialProperties ActiveMaterialProperties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenFeature.NativeMethodInfoPtr_get_ActiveMaterialProperties_Public_get_MaterialProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature.MaterialProperties>(intPtr3) : null;
			}
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x0018FAE8 File Offset: 0x0018DCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179080, XrefRangeEnd = 179091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Create()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PsychedelicFullScreenFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x0018FB24 File Offset: 0x0018DD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179091, XrefRangeEnd = 179103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PsychedelicFullScreenFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x0018FB8C File Offset: 0x0018DD8C
		[CallerCount(0)]
		public unsafe void SetActiveMaterialProperties(PsychedelicFullScreenFeature.MaterialProperties properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenFeature.NativeMethodInfoPtr_SetActiveMaterialProperties_Public_Void_MaterialProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x0018FBD0 File Offset: 0x0018DDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179103, XrefRangeEnd = 179116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintMaterialValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenFeature.NativeMethodInfoPtr_PrintMaterialValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x0018FC04 File Offset: 0x0018DE04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 179127, RefRangeEnd = 179129, XrefRangeStart = 179116, XrefRangeEnd = 179127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PsychedelicFullScreenData GetMaterialPreset(string presetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(presetName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenFeature.NativeMethodInfoPtr_GetMaterialPreset_Public_PsychedelicFullScreenData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenData>(intPtr3) : null;
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x0018FC54 File Offset: 0x0018DE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179129, XrefRangeEnd = 179139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PsychedelicFullScreenFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x000267A1 File Offset: 0x000249A1
		public PsychedelicFullScreenFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x06005062 RID: 20578 RVA: 0x0018FC90 File Offset: 0x0018DE90
		// (set) Token: 0x06005063 RID: 20579 RVA: 0x000267AA File Offset: 0x000249AA
		public unsafe PsychedelicFullScreenFeature.Settings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature.Settings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x0018FCC0 File Offset: 0x0018DEC0
		// (set) Token: 0x06005065 RID: 20581 RVA: 0x000267C9 File Offset: 0x000249C9
		public unsafe static int BLEND_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PsychedelicFullScreenFeature.NativeFieldInfoPtr_BLEND_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PsychedelicFullScreenFeature.NativeFieldInfoPtr_BLEND_ID, (void*)(&value));
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x06005066 RID: 20582 RVA: 0x0018FCDC File Offset: 0x0018DEDC
		// (set) Token: 0x06005067 RID: 20583 RVA: 0x000267D7 File Offset: 0x000249D7
		public unsafe static int NOISE_SCALE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PsychedelicFullScreenFeature.NativeFieldInfoPtr_NOISE_SCALE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PsychedelicFullScreenFeature.NativeFieldInfoPtr_NOISE_SCALE_ID, (void*)(&value));
			}
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x0018FCF8 File Offset: 0x0018DEF8
		// (set) Token: 0x06005069 RID: 20585 RVA: 0x000267E5 File Offset: 0x000249E5
		public unsafe static int PAN_SPEED_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PsychedelicFullScreenFeature.NativeFieldInfoPtr_PAN_SPEED_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PsychedelicFullScreenFeature.NativeFieldInfoPtr_PAN_SPEED_ID, (void*)(&value));
			}
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x0600506A RID: 20586 RVA: 0x0018FD14 File Offset: 0x0018DF14
		// (set) Token: 0x0600506B RID: 20587 RVA: 0x000267F3 File Offset: 0x000249F3
		public unsafe static int DOES_BOUNCE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PsychedelicFullScreenFeature.NativeFieldInfoPtr_DOES_BOUNCE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PsychedelicFullScreenFeature.NativeFieldInfoPtr_DOES_BOUNCE_ID, (void*)(&value));
			}
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x0600506C RID: 20588 RVA: 0x0018FD30 File Offset: 0x0018DF30
		// (set) Token: 0x0600506D RID: 20589 RVA: 0x00026801 File Offset: 0x00024A01
		public unsafe static int AMPLITUDE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PsychedelicFullScreenFeature.NativeFieldInfoPtr_AMPLITUDE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PsychedelicFullScreenFeature.NativeFieldInfoPtr_AMPLITUDE_ID, (void*)(&value));
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x0600506E RID: 20590 RVA: 0x0018FD4C File Offset: 0x0018DF4C
		// (set) Token: 0x0600506F RID: 20591 RVA: 0x0002680F File Offset: 0x00024A0F
		public unsafe PsychedelicFullScreenPass _psychedelicPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.NativeFieldInfoPtr__psychedelicPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.NativeFieldInfoPtr__psychedelicPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400370D RID: 14093
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x0400370E RID: 14094
		private static readonly IntPtr NativeFieldInfoPtr_BLEND_ID;

		// Token: 0x0400370F RID: 14095
		private static readonly IntPtr NativeFieldInfoPtr_NOISE_SCALE_ID;

		// Token: 0x04003710 RID: 14096
		private static readonly IntPtr NativeFieldInfoPtr_PAN_SPEED_ID;

		// Token: 0x04003711 RID: 14097
		private static readonly IntPtr NativeFieldInfoPtr_DOES_BOUNCE_ID;

		// Token: 0x04003712 RID: 14098
		private static readonly IntPtr NativeFieldInfoPtr_AMPLITUDE_ID;

		// Token: 0x04003713 RID: 14099
		private static readonly IntPtr NativeFieldInfoPtr__psychedelicPass;

		// Token: 0x04003714 RID: 14100
		private static readonly IntPtr NativeMethodInfoPtr_get_FeatureSettings_Public_get_Settings_0;

		// Token: 0x04003715 RID: 14101
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveMaterialProperties_Public_get_MaterialProperties_0;

		// Token: 0x04003716 RID: 14102
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

		// Token: 0x04003717 RID: 14103
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

		// Token: 0x04003718 RID: 14104
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveMaterialProperties_Public_Void_MaterialProperties_0;

		// Token: 0x04003719 RID: 14105
		private static readonly IntPtr NativeMethodInfoPtr_PrintMaterialValue_Public_Void_0;

		// Token: 0x0400371A RID: 14106
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterialPreset_Public_PsychedelicFullScreenData_String_0;

		// Token: 0x0400371B RID: 14107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A91 RID: 2705
		[Serializable]
		public class Settings : Il2CppSystem.Object
		{
			// Token: 0x0600E228 RID: 57896 RVA: 0x00377C9C File Offset: 0x00375E9C
			// Note: this type is marked as 'beforefieldinit'.
			static Settings()
			{
				Il2CppClassPointerStore<PsychedelicFullScreenFeature.Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, "Settings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PsychedelicFullScreenFeature.Settings>.NativeClassPtr);
				PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_profilerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.Settings>.NativeClassPtr, "profilerTag");
				PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_renderPassEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.Settings>.NativeClassPtr, "renderPassEvent");
				PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_passMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.Settings>.NativeClassPtr, "passMaterial");
				PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_ActiveProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.Settings>.NativeClassPtr, "ActiveProperties");
				PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_MaterialPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.Settings>.NativeClassPtr, "MaterialPresets");
				PsychedelicFullScreenFeature.Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature.Settings>.NativeClassPtr, 100673731);
			}

			// Token: 0x0600E229 RID: 57897 RVA: 0x00377D40 File Offset: 0x00375F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179068, XrefRangeEnd = 179073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Settings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PsychedelicFullScreenFeature.Settings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenFeature.Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E22A RID: 57898 RVA: 0x0006A95F File Offset: 0x00068B5F
			public Settings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044D3 RID: 17619
			// (get) Token: 0x0600E22B RID: 57899 RVA: 0x00377D7C File Offset: 0x00375F7C
			// (set) Token: 0x0600E22C RID: 57900 RVA: 0x0006A968 File Offset: 0x00068B68
			public unsafe string profilerTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_profilerTag);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_profilerTag), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044D4 RID: 17620
			// (get) Token: 0x0600E22D RID: 57901 RVA: 0x00377DA4 File Offset: 0x00375FA4
			// (set) Token: 0x0600E22E RID: 57902 RVA: 0x0006A987 File Offset: 0x00068B87
			public unsafe RenderPassEvent renderPassEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_renderPassEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_renderPassEvent)) = value;
				}
			}

			// Token: 0x170044D5 RID: 17621
			// (get) Token: 0x0600E22F RID: 57903 RVA: 0x00377DCC File Offset: 0x00375FCC
			// (set) Token: 0x0600E230 RID: 57904 RVA: 0x0006A9A2 File Offset: 0x00068BA2
			public unsafe Material passMaterial
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_passMaterial);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_passMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D6 RID: 17622
			// (get) Token: 0x0600E231 RID: 57905 RVA: 0x00377DFC File Offset: 0x00375FFC
			// (set) Token: 0x0600E232 RID: 57906 RVA: 0x0006A9C1 File Offset: 0x00068BC1
			public unsafe PsychedelicFullScreenFeature.MaterialProperties ActiveProperties
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_ActiveProperties);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature.MaterialProperties>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_ActiveProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044D7 RID: 17623
			// (get) Token: 0x0600E233 RID: 57907 RVA: 0x00377E2C File Offset: 0x0037602C
			// (set) Token: 0x0600E234 RID: 57908 RVA: 0x0006A9E0 File Offset: 0x00068BE0
			public unsafe List<PsychedelicFullScreenFeature.MaterialPropertyPreset> MaterialPresets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_MaterialPresets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PsychedelicFullScreenFeature.MaterialPropertyPreset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.Settings.NativeFieldInfoPtr_MaterialPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099E2 RID: 39394
			private static readonly IntPtr NativeFieldInfoPtr_profilerTag;

			// Token: 0x040099E3 RID: 39395
			private static readonly IntPtr NativeFieldInfoPtr_renderPassEvent;

			// Token: 0x040099E4 RID: 39396
			private static readonly IntPtr NativeFieldInfoPtr_passMaterial;

			// Token: 0x040099E5 RID: 39397
			private static readonly IntPtr NativeFieldInfoPtr_ActiveProperties;

			// Token: 0x040099E6 RID: 39398
			private static readonly IntPtr NativeFieldInfoPtr_MaterialPresets;

			// Token: 0x040099E7 RID: 39399
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A92 RID: 2706
		[Serializable]
		public class MaterialPropertyPreset : Il2CppSystem.Object
		{
			// Token: 0x0600E235 RID: 57909 RVA: 0x00377E5C File Offset: 0x0037605C
			// Note: this type is marked as 'beforefieldinit'.
			static MaterialPropertyPreset()
			{
				Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialPropertyPreset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, "MaterialPropertyPreset");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialPropertyPreset>.NativeClassPtr);
				PsychedelicFullScreenFeature.MaterialPropertyPreset.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialPropertyPreset>.NativeClassPtr, "Name");
				PsychedelicFullScreenFeature.MaterialPropertyPreset.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialPropertyPreset>.NativeClassPtr, "Data");
				PsychedelicFullScreenFeature.MaterialPropertyPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialPropertyPreset>.NativeClassPtr, 100673732);
			}

			// Token: 0x0600E236 RID: 57910 RVA: 0x00377EC4 File Offset: 0x003760C4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MaterialPropertyPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialPropertyPreset>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenFeature.MaterialPropertyPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E237 RID: 57911 RVA: 0x0006A9FF File Offset: 0x00068BFF
			public MaterialPropertyPreset(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044D8 RID: 17624
			// (get) Token: 0x0600E238 RID: 57912 RVA: 0x00377F00 File Offset: 0x00376100
			// (set) Token: 0x0600E239 RID: 57913 RVA: 0x0006AA08 File Offset: 0x00068C08
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialPropertyPreset.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialPropertyPreset.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044D9 RID: 17625
			// (get) Token: 0x0600E23A RID: 57914 RVA: 0x00377F28 File Offset: 0x00376128
			// (set) Token: 0x0600E23B RID: 57915 RVA: 0x0006AA27 File Offset: 0x00068C27
			public unsafe PsychedelicFullScreenData Data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialPropertyPreset.NativeFieldInfoPtr_Data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialPropertyPreset.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099E8 RID: 39400
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x040099E9 RID: 39401
			private static readonly IntPtr NativeFieldInfoPtr_Data;

			// Token: 0x040099EA RID: 39402
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A93 RID: 2707
		[Serializable]
		public class MaterialProperties : Il2CppSystem.Object
		{
			// Token: 0x0600E23C RID: 57916 RVA: 0x00377F58 File Offset: 0x00376158
			// Note: this type is marked as 'beforefieldinit'.
			static MaterialProperties()
			{
				Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PsychedelicFullScreenFeature>.NativeClassPtr, "MaterialProperties");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialProperties>.NativeClassPtr);
				PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_NoiseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialProperties>.NativeClassPtr, "NoiseScale");
				PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_Blend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialProperties>.NativeClassPtr, "Blend");
				PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_PanSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialProperties>.NativeClassPtr, "PanSpeed");
				PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_DoesBounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialProperties>.NativeClassPtr, "DoesBounce");
				PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_Amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialProperties>.NativeClassPtr, "Amplitude");
				PsychedelicFullScreenFeature.MaterialProperties.NativeMethodInfoPtr_Clone_Public_MaterialProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialProperties>.NativeClassPtr, 100673733);
				PsychedelicFullScreenFeature.MaterialProperties.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialProperties>.NativeClassPtr, 100673734);
			}

			// Token: 0x0600E23D RID: 57917 RVA: 0x00378010 File Offset: 0x00376210
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 179077, RefRangeEnd = 179078, XrefRangeStart = 179073, XrefRangeEnd = 179077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PsychedelicFullScreenFeature.MaterialProperties Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenFeature.MaterialProperties.NativeMethodInfoPtr_Clone_Public_MaterialProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PsychedelicFullScreenFeature.MaterialProperties>(intPtr3) : null;
			}

			// Token: 0x0600E23E RID: 57918 RVA: 0x00378050 File Offset: 0x00376250
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 179079, RefRangeEnd = 179080, XrefRangeStart = 179078, XrefRangeEnd = 179079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MaterialProperties() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PsychedelicFullScreenFeature.MaterialProperties>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PsychedelicFullScreenFeature.MaterialProperties.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E23F RID: 57919 RVA: 0x0006AA46 File Offset: 0x00068C46
			public MaterialProperties(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044DA RID: 17626
			// (get) Token: 0x0600E240 RID: 57920 RVA: 0x0037808C File Offset: 0x0037628C
			// (set) Token: 0x0600E241 RID: 57921 RVA: 0x0006AA4F File Offset: 0x00068C4F
			public unsafe float NoiseScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_NoiseScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_NoiseScale)) = value;
				}
			}

			// Token: 0x170044DB RID: 17627
			// (get) Token: 0x0600E242 RID: 57922 RVA: 0x003780B4 File Offset: 0x003762B4
			// (set) Token: 0x0600E243 RID: 57923 RVA: 0x0006AA6A File Offset: 0x00068C6A
			public unsafe float Blend
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_Blend);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_Blend)) = value;
				}
			}

			// Token: 0x170044DC RID: 17628
			// (get) Token: 0x0600E244 RID: 57924 RVA: 0x003780DC File Offset: 0x003762DC
			// (set) Token: 0x0600E245 RID: 57925 RVA: 0x0006AA85 File Offset: 0x00068C85
			public unsafe Vector2 PanSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_PanSpeed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_PanSpeed)) = value;
				}
			}

			// Token: 0x170044DD RID: 17629
			// (get) Token: 0x0600E246 RID: 57926 RVA: 0x00378104 File Offset: 0x00376304
			// (set) Token: 0x0600E247 RID: 57927 RVA: 0x0006AAA0 File Offset: 0x00068CA0
			public unsafe bool DoesBounce
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_DoesBounce);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_DoesBounce)) = value;
				}
			}

			// Token: 0x170044DE RID: 17630
			// (get) Token: 0x0600E248 RID: 57928 RVA: 0x0037812C File Offset: 0x0037632C
			// (set) Token: 0x0600E249 RID: 57929 RVA: 0x0006AABB File Offset: 0x00068CBB
			public unsafe float Amplitude
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_Amplitude);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PsychedelicFullScreenFeature.MaterialProperties.NativeFieldInfoPtr_Amplitude)) = value;
				}
			}

			// Token: 0x040099EB RID: 39403
			private static readonly IntPtr NativeFieldInfoPtr_NoiseScale;

			// Token: 0x040099EC RID: 39404
			private static readonly IntPtr NativeFieldInfoPtr_Blend;

			// Token: 0x040099ED RID: 39405
			private static readonly IntPtr NativeFieldInfoPtr_PanSpeed;

			// Token: 0x040099EE RID: 39406
			private static readonly IntPtr NativeFieldInfoPtr_DoesBounce;

			// Token: 0x040099EF RID: 39407
			private static readonly IntPtr NativeFieldInfoPtr_Amplitude;

			// Token: 0x040099F0 RID: 39408
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_MaterialProperties_0;

			// Token: 0x040099F1 RID: 39409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

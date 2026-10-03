using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace Il2CppScheduleOne.Weather
{
	// Token: 0x020006D7 RID: 1751
	public class MaskController : MonoBehaviour
	{
		// Token: 0x0600A8BC RID: 43196 RVA: 0x002CA3F0 File Offset: 0x002C85F0
		// Note: this type is marked as 'beforefieldinit'.
		static MaskController()
		{
			Il2CppClassPointerStore<MaskController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Weather", "MaskController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskController>.NativeClassPtr);
			MaskController.NativeFieldInfoPtr__wetMaskShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_wetMaskShader");
			MaskController.NativeFieldInfoPtr__maskDownsampleShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_maskDownsampleShader");
			MaskController.NativeFieldInfoPtr__wetMaskTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_wetMaskTexture");
			MaskController.NativeFieldInfoPtr__worldSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_worldSize");
			MaskController.NativeFieldInfoPtr__wetMaskResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_wetMaskResolution");
			MaskController.NativeFieldInfoPtr__wetGrowthRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_wetGrowthRate");
			MaskController.NativeFieldInfoPtr__wetDecayRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_wetDecayRate");
			MaskController.NativeFieldInfoPtr__sunEvapMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_sunEvapMultiplier");
			MaskController.NativeFieldInfoPtr__wetnessGrowthCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_wetnessGrowthCurve");
			MaskController.NativeFieldInfoPtr__heightMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_heightMask");
			MaskController.NativeFieldInfoPtr__downsampledResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_downsampledResolution");
			MaskController.NativeFieldInfoPtr__minMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_minMaxHeight");
			MaskController.NativeFieldInfoPtr__debugTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_debugTexture");
			MaskController.NativeFieldInfoPtr__weatherVolumeOrigins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_weatherVolumeOrigins");
			MaskController.NativeFieldInfoPtr__weatherRainValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_weatherRainValues");
			MaskController.NativeFieldInfoPtr__weatherSunValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_weatherSunValues");
			MaskController.NativeFieldInfoPtr__volumeOriginsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_volumeOriginsBuffer");
			MaskController.NativeFieldInfoPtr__volumeRainBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_volumeRainBuffer");
			MaskController.NativeFieldInfoPtr__volumeSunBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_volumeSunBuffer");
			MaskController.NativeFieldInfoPtr__heightConversionCo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_heightConversionCo");
			MaskController.NativeFieldInfoPtr__heightMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "_heightMap");
			MaskController.NativeMethodInfoPtr_get_WorldSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController>.NativeClassPtr, 100685664);
			MaskController.NativeMethodInfoPtr_get_HeightMapResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController>.NativeClassPtr, 100685665);
			MaskController.NativeMethodInfoPtr_get_HeightMap_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController>.NativeClassPtr, 100685666);
			MaskController.NativeMethodInfoPtr_get_MinMaxHeight_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController>.NativeClassPtr, 100685667);
			MaskController.NativeMethodInfoPtr_Initialise_Public_Void_Int32_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController>.NativeClassPtr, 100685668);
			MaskController.NativeMethodInfoPtr_RunWetMaskShader_Public_Void_List_1_WeatherVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController>.NativeClassPtr, 100685669);
			MaskController.NativeMethodInfoPtr_ConvertHeightToArray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController>.NativeClassPtr, 100685670);
			MaskController.NativeMethodInfoPtr_DoHeightConversionRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController>.NativeClassPtr, 100685671);
			MaskController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController>.NativeClassPtr, 100685672);
			MaskController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController>.NativeClassPtr, 100685673);
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600A8BD RID: 43197 RVA: 0x002CA68C File Offset: 0x002C888C
		public unsafe float WorldSize
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 292574, RefRangeEnd = 292577, XrefRangeStart = 292574, XrefRangeEnd = 292574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.NativeMethodInfoPtr_get_WorldSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003280 RID: 12928
		// (get) Token: 0x0600A8BE RID: 43198 RVA: 0x002CA6C8 File Offset: 0x002C88C8
		public unsafe int HeightMapResolution
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 44557, RefRangeEnd = 44560, XrefRangeStart = 44557, XrefRangeEnd = 44560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.NativeMethodInfoPtr_get_HeightMapResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003281 RID: 12929
		// (get) Token: 0x0600A8BF RID: 43199 RVA: 0x002CA704 File Offset: 0x002C8904
		public unsafe Il2CppStructArray<float> HeightMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.NativeMethodInfoPtr_get_HeightMap_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600A8C0 RID: 43200 RVA: 0x002CA744 File Offset: 0x002C8944
		public unsafe Vector2 MinMaxHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.NativeMethodInfoPtr_get_MinMaxHeight_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x002CA780 File Offset: 0x002C8980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292646, RefRangeEnd = 292648, XrefRangeStart = 292577, XrefRangeEnd = 292646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialise(int weatherVolumeCount, float blendAmount, Vector3 weatherVolumeSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weatherVolumeCount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendAmount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weatherVolumeSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.NativeMethodInfoPtr_Initialise_Public_Void_Int32_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8C2 RID: 43202 RVA: 0x002CA7DC File Offset: 0x002C89DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292684, RefRangeEnd = 292685, XrefRangeStart = 292648, XrefRangeEnd = 292684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunWetMaskShader(List<WeatherVolume> weatherVolumes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weatherVolumes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.NativeMethodInfoPtr_RunWetMaskShader_Public_Void_List_1_WeatherVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8C3 RID: 43203 RVA: 0x002CA820 File Offset: 0x002C8A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292693, RefRangeEnd = 292695, XrefRangeStart = 292685, XrefRangeEnd = 292693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConvertHeightToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.NativeMethodInfoPtr_ConvertHeightToArray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8C4 RID: 43204 RVA: 0x002CA854 File Offset: 0x002C8A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292695, XrefRangeEnd = 292700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoHeightConversionRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.NativeMethodInfoPtr_DoHeightConversionRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A8C5 RID: 43205 RVA: 0x002CA894 File Offset: 0x002C8A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292700, XrefRangeEnd = 292706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x002CA8C8 File Offset: 0x002C8AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292706, XrefRangeEnd = 292709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaskController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x0004CD8D File Offset: 0x0004AF8D
		public MaskController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600A8C8 RID: 43208 RVA: 0x002CA904 File Offset: 0x002C8B04
		// (set) Token: 0x0600A8C9 RID: 43209 RVA: 0x0004CD96 File Offset: 0x0004AF96
		public unsafe ComputeShader _wetMaskShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetMaskShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetMaskShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600A8CA RID: 43210 RVA: 0x002CA934 File Offset: 0x002C8B34
		// (set) Token: 0x0600A8CB RID: 43211 RVA: 0x0004CDB5 File Offset: 0x0004AFB5
		public unsafe ComputeShader _maskDownsampleShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__maskDownsampleShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__maskDownsampleShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326C RID: 12908
		// (get) Token: 0x0600A8CC RID: 43212 RVA: 0x002CA964 File Offset: 0x002C8B64
		// (set) Token: 0x0600A8CD RID: 43213 RVA: 0x0004CDD4 File Offset: 0x0004AFD4
		public unsafe RenderTexture _wetMaskTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetMaskTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetMaskTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700326D RID: 12909
		// (get) Token: 0x0600A8CE RID: 43214 RVA: 0x002CA994 File Offset: 0x002C8B94
		// (set) Token: 0x0600A8CF RID: 43215 RVA: 0x0004CDF3 File Offset: 0x0004AFF3
		public unsafe int _worldSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__worldSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__worldSize)) = value;
			}
		}

		// Token: 0x1700326E RID: 12910
		// (get) Token: 0x0600A8D0 RID: 43216 RVA: 0x002CA9BC File Offset: 0x002C8BBC
		// (set) Token: 0x0600A8D1 RID: 43217 RVA: 0x0004CE0E File Offset: 0x0004B00E
		public unsafe int _wetMaskResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetMaskResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetMaskResolution)) = value;
			}
		}

		// Token: 0x1700326F RID: 12911
		// (get) Token: 0x0600A8D2 RID: 43218 RVA: 0x002CA9E4 File Offset: 0x002C8BE4
		// (set) Token: 0x0600A8D3 RID: 43219 RVA: 0x0004CE29 File Offset: 0x0004B029
		public unsafe float _wetGrowthRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetGrowthRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetGrowthRate)) = value;
			}
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600A8D4 RID: 43220 RVA: 0x002CAA0C File Offset: 0x002C8C0C
		// (set) Token: 0x0600A8D5 RID: 43221 RVA: 0x0004CE44 File Offset: 0x0004B044
		public unsafe float _wetDecayRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetDecayRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetDecayRate)) = value;
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600A8D6 RID: 43222 RVA: 0x002CAA34 File Offset: 0x002C8C34
		// (set) Token: 0x0600A8D7 RID: 43223 RVA: 0x0004CE5F File Offset: 0x0004B05F
		public unsafe float _sunEvapMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__sunEvapMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__sunEvapMultiplier)) = value;
			}
		}

		// Token: 0x17003272 RID: 12914
		// (get) Token: 0x0600A8D8 RID: 43224 RVA: 0x002CAA5C File Offset: 0x002C8C5C
		// (set) Token: 0x0600A8D9 RID: 43225 RVA: 0x0004CE7A File Offset: 0x0004B07A
		public unsafe AnimationCurve _wetnessGrowthCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetnessGrowthCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__wetnessGrowthCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003273 RID: 12915
		// (get) Token: 0x0600A8DA RID: 43226 RVA: 0x002CAA8C File Offset: 0x002C8C8C
		// (set) Token: 0x0600A8DB RID: 43227 RVA: 0x0004CE99 File Offset: 0x0004B099
		public unsafe Texture2D _heightMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__heightMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__heightMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003274 RID: 12916
		// (get) Token: 0x0600A8DC RID: 43228 RVA: 0x002CAABC File Offset: 0x002C8CBC
		// (set) Token: 0x0600A8DD RID: 43229 RVA: 0x0004CEB8 File Offset: 0x0004B0B8
		public unsafe int _downsampledResolution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__downsampledResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__downsampledResolution)) = value;
			}
		}

		// Token: 0x17003275 RID: 12917
		// (get) Token: 0x0600A8DE RID: 43230 RVA: 0x002CAAE4 File Offset: 0x002C8CE4
		// (set) Token: 0x0600A8DF RID: 43231 RVA: 0x0004CED3 File Offset: 0x0004B0D3
		public unsafe Vector2 _minMaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__minMaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__minMaxHeight)) = value;
			}
		}

		// Token: 0x17003276 RID: 12918
		// (get) Token: 0x0600A8E0 RID: 43232 RVA: 0x002CAB0C File Offset: 0x002C8D0C
		// (set) Token: 0x0600A8E1 RID: 43233 RVA: 0x0004CEEE File Offset: 0x0004B0EE
		public unsafe RenderTexture _debugTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__debugTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__debugTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003277 RID: 12919
		// (get) Token: 0x0600A8E2 RID: 43234 RVA: 0x002CAB3C File Offset: 0x002C8D3C
		// (set) Token: 0x0600A8E3 RID: 43235 RVA: 0x0004CF0D File Offset: 0x0004B10D
		public unsafe Il2CppStructArray<Vector2> _weatherVolumeOrigins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__weatherVolumeOrigins);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__weatherVolumeOrigins), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003278 RID: 12920
		// (get) Token: 0x0600A8E4 RID: 43236 RVA: 0x002CAB6C File Offset: 0x002C8D6C
		// (set) Token: 0x0600A8E5 RID: 43237 RVA: 0x0004CF2C File Offset: 0x0004B12C
		public unsafe Il2CppStructArray<float> _weatherRainValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__weatherRainValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__weatherRainValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003279 RID: 12921
		// (get) Token: 0x0600A8E6 RID: 43238 RVA: 0x002CAB9C File Offset: 0x002C8D9C
		// (set) Token: 0x0600A8E7 RID: 43239 RVA: 0x0004CF4B File Offset: 0x0004B14B
		public unsafe Il2CppStructArray<float> _weatherSunValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__weatherSunValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__weatherSunValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700327A RID: 12922
		// (get) Token: 0x0600A8E8 RID: 43240 RVA: 0x002CABCC File Offset: 0x002C8DCC
		// (set) Token: 0x0600A8E9 RID: 43241 RVA: 0x0004CF6A File Offset: 0x0004B16A
		public unsafe ComputeBuffer _volumeOriginsBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__volumeOriginsBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__volumeOriginsBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600A8EA RID: 43242 RVA: 0x002CABFC File Offset: 0x002C8DFC
		// (set) Token: 0x0600A8EB RID: 43243 RVA: 0x0004CF89 File Offset: 0x0004B189
		public unsafe ComputeBuffer _volumeRainBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__volumeRainBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__volumeRainBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700327C RID: 12924
		// (get) Token: 0x0600A8EC RID: 43244 RVA: 0x002CAC2C File Offset: 0x002C8E2C
		// (set) Token: 0x0600A8ED RID: 43245 RVA: 0x0004CFA8 File Offset: 0x0004B1A8
		public unsafe ComputeBuffer _volumeSunBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__volumeSunBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__volumeSunBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700327D RID: 12925
		// (get) Token: 0x0600A8EE RID: 43246 RVA: 0x002CAC5C File Offset: 0x002C8E5C
		// (set) Token: 0x0600A8EF RID: 43247 RVA: 0x0004CFC7 File Offset: 0x0004B1C7
		public unsafe Coroutine _heightConversionCo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__heightConversionCo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__heightConversionCo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700327E RID: 12926
		// (get) Token: 0x0600A8F0 RID: 43248 RVA: 0x002CAC8C File Offset: 0x002C8E8C
		// (set) Token: 0x0600A8F1 RID: 43249 RVA: 0x0004CFE6 File Offset: 0x0004B1E6
		public unsafe Il2CppStructArray<float> _heightMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__heightMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.NativeFieldInfoPtr__heightMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040074A5 RID: 29861
		private static readonly IntPtr NativeFieldInfoPtr__wetMaskShader;

		// Token: 0x040074A6 RID: 29862
		private static readonly IntPtr NativeFieldInfoPtr__maskDownsampleShader;

		// Token: 0x040074A7 RID: 29863
		private static readonly IntPtr NativeFieldInfoPtr__wetMaskTexture;

		// Token: 0x040074A8 RID: 29864
		private static readonly IntPtr NativeFieldInfoPtr__worldSize;

		// Token: 0x040074A9 RID: 29865
		private static readonly IntPtr NativeFieldInfoPtr__wetMaskResolution;

		// Token: 0x040074AA RID: 29866
		private static readonly IntPtr NativeFieldInfoPtr__wetGrowthRate;

		// Token: 0x040074AB RID: 29867
		private static readonly IntPtr NativeFieldInfoPtr__wetDecayRate;

		// Token: 0x040074AC RID: 29868
		private static readonly IntPtr NativeFieldInfoPtr__sunEvapMultiplier;

		// Token: 0x040074AD RID: 29869
		private static readonly IntPtr NativeFieldInfoPtr__wetnessGrowthCurve;

		// Token: 0x040074AE RID: 29870
		private static readonly IntPtr NativeFieldInfoPtr__heightMask;

		// Token: 0x040074AF RID: 29871
		private static readonly IntPtr NativeFieldInfoPtr__downsampledResolution;

		// Token: 0x040074B0 RID: 29872
		private static readonly IntPtr NativeFieldInfoPtr__minMaxHeight;

		// Token: 0x040074B1 RID: 29873
		private static readonly IntPtr NativeFieldInfoPtr__debugTexture;

		// Token: 0x040074B2 RID: 29874
		private static readonly IntPtr NativeFieldInfoPtr__weatherVolumeOrigins;

		// Token: 0x040074B3 RID: 29875
		private static readonly IntPtr NativeFieldInfoPtr__weatherRainValues;

		// Token: 0x040074B4 RID: 29876
		private static readonly IntPtr NativeFieldInfoPtr__weatherSunValues;

		// Token: 0x040074B5 RID: 29877
		private static readonly IntPtr NativeFieldInfoPtr__volumeOriginsBuffer;

		// Token: 0x040074B6 RID: 29878
		private static readonly IntPtr NativeFieldInfoPtr__volumeRainBuffer;

		// Token: 0x040074B7 RID: 29879
		private static readonly IntPtr NativeFieldInfoPtr__volumeSunBuffer;

		// Token: 0x040074B8 RID: 29880
		private static readonly IntPtr NativeFieldInfoPtr__heightConversionCo;

		// Token: 0x040074B9 RID: 29881
		private static readonly IntPtr NativeFieldInfoPtr__heightMap;

		// Token: 0x040074BA RID: 29882
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldSize_Public_get_Single_0;

		// Token: 0x040074BB RID: 29883
		private static readonly IntPtr NativeMethodInfoPtr_get_HeightMapResolution_Public_get_Int32_0;

		// Token: 0x040074BC RID: 29884
		private static readonly IntPtr NativeMethodInfoPtr_get_HeightMap_Public_get_Il2CppStructArray_1_Single_0;

		// Token: 0x040074BD RID: 29885
		private static readonly IntPtr NativeMethodInfoPtr_get_MinMaxHeight_Public_get_Vector2_0;

		// Token: 0x040074BE RID: 29886
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Public_Void_Int32_Single_Vector3_0;

		// Token: 0x040074BF RID: 29887
		private static readonly IntPtr NativeMethodInfoPtr_RunWetMaskShader_Public_Void_List_1_WeatherVolume_0;

		// Token: 0x040074C0 RID: 29888
		private static readonly IntPtr NativeMethodInfoPtr_ConvertHeightToArray_Public_Void_0;

		// Token: 0x040074C1 RID: 29889
		private static readonly IntPtr NativeMethodInfoPtr_DoHeightConversionRoutine_Private_IEnumerator_0;

		// Token: 0x040074C2 RID: 29890
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040074C3 RID: 29891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C85 RID: 3205
		[ObfuscatedName("ScheduleOne.Weather.MaskController+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F25F RID: 62047 RVA: 0x003A6894 File Offset: 0x003A4A94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<MaskController.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskController.__c__DisplayClass32_0>.NativeClassPtr);
				MaskController.__c__DisplayClass32_0.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController.__c__DisplayClass32_0>.NativeClassPtr, "request");
				MaskController.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController.__c__DisplayClass32_0>.NativeClassPtr, 100685674);
				MaskController.__c__DisplayClass32_0.NativeMethodInfoPtr__DoHeightConversionRoutine_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController.__c__DisplayClass32_0>.NativeClassPtr, 100685675);
			}

			// Token: 0x0600F260 RID: 62048 RVA: 0x003A68FC File Offset: 0x003A4AFC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskController.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F261 RID: 62049 RVA: 0x003A6938 File Offset: 0x003A4B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292528, XrefRangeEnd = 292529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DoHeightConversionRoutine_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController.__c__DisplayClass32_0.NativeMethodInfoPtr__DoHeightConversionRoutine_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F262 RID: 62050 RVA: 0x0007261F File Offset: 0x0007081F
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004990 RID: 18832
			// (get) Token: 0x0600F263 RID: 62051 RVA: 0x003A6974 File Offset: 0x003A4B74
			// (set) Token: 0x0600F264 RID: 62052 RVA: 0x00072628 File Offset: 0x00070828
			public unsafe AsyncGPUReadbackRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.__c__DisplayClass32_0.NativeFieldInfoPtr_request);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController.__c__DisplayClass32_0.NativeFieldInfoPtr_request)) = value;
				}
			}

			// Token: 0x0400A3F9 RID: 41977
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x0400A3FA RID: 41978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A3FB RID: 41979
			private static readonly IntPtr NativeMethodInfoPtr__DoHeightConversionRoutine_b__0_Internal_Boolean_0;
		}

		// Token: 0x02000C86 RID: 3206
		[ObfuscatedName("ScheduleOne.Weather.MaskController+<DoHeightConversionRoutine>d__32")]
		public sealed class _DoHeightConversionRoutine_d__32 : Il2CppSystem.Object
		{
			// Token: 0x0600F265 RID: 62053 RVA: 0x003A699C File Offset: 0x003A4B9C
			// Note: this type is marked as 'beforefieldinit'.
			static _DoHeightConversionRoutine_d__32()
			{
				Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaskController>.NativeClassPtr, "<DoHeightConversionRoutine>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr);
				MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr, "<>1__state");
				MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr, "<>2__current");
				MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr, "<>4__this");
				MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr, "<>8__1");
				MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr__heightBuffer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr, "<heightBuffer>5__2");
				MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr, 100685676);
				MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr, 100685677);
				MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr, 100685678);
				MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr, 100685679);
				MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr, 100685680);
				MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr, 100685681);
			}

			// Token: 0x0600F266 RID: 62054 RVA: 0x003A6AA4 File Offset: 0x003A4CA4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoHeightConversionRoutine_d__32(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskController._DoHeightConversionRoutine_d__32>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F267 RID: 62055 RVA: 0x003A6AEC File Offset: 0x003A4CEC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F268 RID: 62056 RVA: 0x003A6B20 File Offset: 0x003A4D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292529, XrefRangeEnd = 292569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004996 RID: 18838
			// (get) Token: 0x0600F269 RID: 62057 RVA: 0x003A6B5C File Offset: 0x003A4D5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F26A RID: 62058 RVA: 0x003A6B9C File Offset: 0x003A4D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292569, XrefRangeEnd = 292574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004997 RID: 18839
			// (get) Token: 0x0600F26B RID: 62059 RVA: 0x003A6BD0 File Offset: 0x003A4DD0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaskController._DoHeightConversionRoutine_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F26C RID: 62060 RVA: 0x00072643 File Offset: 0x00070843
			public _DoHeightConversionRoutine_d__32(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004991 RID: 18833
			// (get) Token: 0x0600F26D RID: 62061 RVA: 0x003A6C10 File Offset: 0x003A4E10
			// (set) Token: 0x0600F26E RID: 62062 RVA: 0x0007264C File Offset: 0x0007084C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004992 RID: 18834
			// (get) Token: 0x0600F26F RID: 62063 RVA: 0x003A6C38 File Offset: 0x003A4E38
			// (set) Token: 0x0600F270 RID: 62064 RVA: 0x00072667 File Offset: 0x00070867
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004993 RID: 18835
			// (get) Token: 0x0600F271 RID: 62065 RVA: 0x003A6C68 File Offset: 0x003A4E68
			// (set) Token: 0x0600F272 RID: 62066 RVA: 0x00072686 File Offset: 0x00070886
			public unsafe MaskController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004994 RID: 18836
			// (get) Token: 0x0600F273 RID: 62067 RVA: 0x003A6C98 File Offset: 0x003A4E98
			// (set) Token: 0x0600F274 RID: 62068 RVA: 0x000726A5 File Offset: 0x000708A5
			public unsafe MaskController.__c__DisplayClass32_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaskController.__c__DisplayClass32_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004995 RID: 18837
			// (get) Token: 0x0600F275 RID: 62069 RVA: 0x003A6CC8 File Offset: 0x003A4EC8
			// (set) Token: 0x0600F276 RID: 62070 RVA: 0x000726C4 File Offset: 0x000708C4
			public unsafe ComputeBuffer _heightBuffer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr__heightBuffer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaskController._DoHeightConversionRoutine_d__32.NativeFieldInfoPtr__heightBuffer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A3FC RID: 41980
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A3FD RID: 41981
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A3FE RID: 41982
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A3FF RID: 41983
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400A400 RID: 41984
			private static readonly IntPtr NativeFieldInfoPtr__heightBuffer_5__2;

			// Token: 0x0400A401 RID: 41985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A402 RID: 41986
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A403 RID: 41987
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A404 RID: 41988
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A405 RID: 41989
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A406 RID: 41990
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

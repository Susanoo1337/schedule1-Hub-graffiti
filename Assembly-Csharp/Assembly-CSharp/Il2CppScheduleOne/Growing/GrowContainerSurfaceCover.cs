using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000516 RID: 1302
	public class GrowContainerSurfaceCover : MonoBehaviour
	{
		// Token: 0x06007612 RID: 30226 RVA: 0x0020EE3C File Offset: 0x0020D03C
		// Note: this type is marked as 'beforefieldinit'.
		static GrowContainerSurfaceCover()
		{
			Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "GrowContainerSurfaceCover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr);
			GrowContainerSurfaceCover.NativeFieldInfoPtr_TextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "TextureSize");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_PourRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "PourRadius");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_UpdatesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "UpdatesPerSecond");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_CoveredPixelThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "CoveredPixelThreshold");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "Delay");
			GrowContainerSurfaceCover.NativeFieldInfoPtr__CurrentCoverage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "<CurrentCoverage>k__BackingField");
			GrowContainerSurfaceCover.NativeFieldInfoPtr__UseApplyOverTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "<UseApplyOverTime>k__BackingField");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_SuccessfulCoverageThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "SuccessfulCoverageThreshold");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_GrowContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "GrowContainer");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_MeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "MeshRenderer");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_PourMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "PourMask");
			GrowContainerSurfaceCover.NativeFieldInfoPtr__applyPoutOverTimeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "_applyPoutOverTimeDuration");
			GrowContainerSurfaceCover.NativeFieldInfoPtr__applyPoutOverTimeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "_applyPoutOverTimeCurve");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_onSufficientCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "onSufficientCoverage");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_queued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "queued");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_queuedWorldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "queuedWorldPos");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_mainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "mainTex");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_tempTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "tempTex");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_relative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "relative");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_vector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "vector2");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_normalizedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "normalizedOffset");
			GrowContainerSurfaceCover.NativeFieldInfoPtr_originPixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "originPixel");
			GrowContainerSurfaceCover.NativeFieldInfoPtr__pourApplicationStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "_pourApplicationStrength");
			GrowContainerSurfaceCover.NativeMethodInfoPtr_get_CurrentCoverage_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678480);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_set_CurrentCoverage_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678481);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_get_PourApplicationStrength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678482);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_set_PourApplicationStrength_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678483);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_get_UseApplyOverTime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678484);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_set_UseApplyOverTime_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678485);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_get__sideLength_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678486);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678487);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678488);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678489);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678490);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678491);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678492);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678493);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_Blank_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678494);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678495);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678496);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_ApplyPourOverTime_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678497);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678498);
			GrowContainerSurfaceCover.NativeMethodInfoPtr_GetCoverage_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678499);
			GrowContainerSurfaceCover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, 100678500);
		}

		// Token: 0x17002491 RID: 9361
		// (get) Token: 0x06007613 RID: 30227 RVA: 0x0020F1DC File Offset: 0x0020D3DC
		// (set) Token: 0x06007614 RID: 30228 RVA: 0x0020F218 File Offset: 0x0020D418
		public unsafe float CurrentCoverage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_get_CurrentCoverage_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29040, RefRangeEnd = 29041, XrefRangeStart = 29040, XrefRangeEnd = 29041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_set_CurrentCoverage_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002492 RID: 9362
		// (get) Token: 0x06007615 RID: 30229 RVA: 0x0020F258 File Offset: 0x0020D458
		// (set) Token: 0x06007616 RID: 30230 RVA: 0x0020F294 File Offset: 0x0020D494
		public unsafe float PourApplicationStrength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_get_PourApplicationStrength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_set_PourApplicationStrength_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x06007617 RID: 30231 RVA: 0x0020F2D4 File Offset: 0x0020D4D4
		// (set) Token: 0x06007618 RID: 30232 RVA: 0x0020F310 File Offset: 0x0020D510
		public unsafe bool UseApplyOverTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_get_UseApplyOverTime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_set_UseApplyOverTime_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x06007619 RID: 30233 RVA: 0x0020F350 File Offset: 0x0020D550
		public unsafe float _sideLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229810, XrefRangeEnd = 229811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_get__sideLength_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x0020F38C File Offset: 0x0020D58C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x0020F3C0 File Offset: 0x0020D5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229811, XrefRangeEnd = 229817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x0020F3F4 File Offset: 0x0020D5F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 229826, RefRangeEnd = 229829, XrefRangeStart = 229817, XrefRangeEnd = 229826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureAppearance(Color col, float transparency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transparency;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x0020F440 File Offset: 0x0020D640
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229830, RefRangeEnd = 229832, XrefRangeStart = 229829, XrefRangeEnd = 229830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x0020F474 File Offset: 0x0020D674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229832, RefRangeEnd = 229834, XrefRangeStart = 229832, XrefRangeEnd = 229832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueuePour(Vector3 worldSpacePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldSpacePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x0020F4B4 File Offset: 0x0020D6B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229834, RefRangeEnd = 229835, XrefRangeStart = 229834, XrefRangeEnd = 229834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNormalizedProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x0020F4F0 File Offset: 0x0020D6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229835, XrefRangeEnd = 229840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CheckQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007621 RID: 30241 RVA: 0x0020F530 File Offset: 0x0020D730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229865, RefRangeEnd = 229866, XrefRangeStart = 229840, XrefRangeEnd = 229865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_Blank_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007622 RID: 30242 RVA: 0x0020F564 File Offset: 0x0020D764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229866, XrefRangeEnd = 229878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayedApplyPour(Vector3 worldSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x0020F5A4 File Offset: 0x0020D7A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229894, RefRangeEnd = 229895, XrefRangeStart = 229878, XrefRangeEnd = 229894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPour(Vector3 worldSpace, bool applyOverTime = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldSpace;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyOverTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x0020F5F0 File Offset: 0x0020D7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229895, XrefRangeEnd = 229900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ApplyPourOverTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_ApplyPourOverTime_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x0020F630 File Offset: 0x0020D830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229901, RefRangeEnd = 229903, XrefRangeStart = 229900, XrefRangeEnd = 229901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPourMaskValue(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x0020F688 File Offset: 0x0020D888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229903, XrefRangeEnd = 229904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCoverage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr_GetCoverage_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x0020F6C4 File Offset: 0x0020D8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229904, XrefRangeEnd = 229907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrowContainerSurfaceCover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x0003853F File Offset: 0x0003673F
		public GrowContainerSurfaceCover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x06007629 RID: 30249 RVA: 0x0020F700 File Offset: 0x0020D900
		// (set) Token: 0x0600762A RID: 30250 RVA: 0x00038548 File Offset: 0x00036748
		public unsafe static int TextureSize
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GrowContainerSurfaceCover.NativeFieldInfoPtr_TextureSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrowContainerSurfaceCover.NativeFieldInfoPtr_TextureSize, (void*)(&value));
			}
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x0600762B RID: 30251 RVA: 0x0020F71C File Offset: 0x0020D91C
		// (set) Token: 0x0600762C RID: 30252 RVA: 0x00038556 File Offset: 0x00036756
		public unsafe static int PourRadius
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GrowContainerSurfaceCover.NativeFieldInfoPtr_PourRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrowContainerSurfaceCover.NativeFieldInfoPtr_PourRadius, (void*)(&value));
			}
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x0600762D RID: 30253 RVA: 0x0020F738 File Offset: 0x0020D938
		// (set) Token: 0x0600762E RID: 30254 RVA: 0x00038564 File Offset: 0x00036764
		public unsafe static int UpdatesPerSecond
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(GrowContainerSurfaceCover.NativeFieldInfoPtr_UpdatesPerSecond, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrowContainerSurfaceCover.NativeFieldInfoPtr_UpdatesPerSecond, (void*)(&value));
			}
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x0600762F RID: 30255 RVA: 0x0020F754 File Offset: 0x0020D954
		// (set) Token: 0x06007630 RID: 30256 RVA: 0x00038572 File Offset: 0x00036772
		public unsafe static float CoveredPixelThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GrowContainerSurfaceCover.NativeFieldInfoPtr_CoveredPixelThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrowContainerSurfaceCover.NativeFieldInfoPtr_CoveredPixelThreshold, (void*)(&value));
			}
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x06007631 RID: 30257 RVA: 0x0020F770 File Offset: 0x0020D970
		// (set) Token: 0x06007632 RID: 30258 RVA: 0x00038580 File Offset: 0x00036780
		public unsafe static float Delay
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GrowContainerSurfaceCover.NativeFieldInfoPtr_Delay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrowContainerSurfaceCover.NativeFieldInfoPtr_Delay, (void*)(&value));
			}
		}

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x06007633 RID: 30259 RVA: 0x0020F78C File Offset: 0x0020D98C
		// (set) Token: 0x06007634 RID: 30260 RVA: 0x0003858E File Offset: 0x0003678E
		public unsafe float _CurrentCoverage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr__CurrentCoverage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr__CurrentCoverage_k__BackingField)) = value;
			}
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x06007635 RID: 30261 RVA: 0x0020F7B4 File Offset: 0x0020D9B4
		// (set) Token: 0x06007636 RID: 30262 RVA: 0x000385A9 File Offset: 0x000367A9
		public unsafe bool _UseApplyOverTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr__UseApplyOverTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr__UseApplyOverTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x06007637 RID: 30263 RVA: 0x0020F7DC File Offset: 0x0020D9DC
		// (set) Token: 0x06007638 RID: 30264 RVA: 0x000385C4 File Offset: 0x000367C4
		public unsafe float SuccessfulCoverageThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_SuccessfulCoverageThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_SuccessfulCoverageThreshold)) = value;
			}
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x06007639 RID: 30265 RVA: 0x0020F804 File Offset: 0x0020DA04
		// (set) Token: 0x0600763A RID: 30266 RVA: 0x000385DF File Offset: 0x000367DF
		public unsafe GrowContainer GrowContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_GrowContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_GrowContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x0600763B RID: 30267 RVA: 0x0020F834 File Offset: 0x0020DA34
		// (set) Token: 0x0600763C RID: 30268 RVA: 0x000385FE File Offset: 0x000367FE
		public unsafe MeshRenderer MeshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_MeshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_MeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x0600763D RID: 30269 RVA: 0x0020F864 File Offset: 0x0020DA64
		// (set) Token: 0x0600763E RID: 30270 RVA: 0x0003861D File Offset: 0x0003681D
		public unsafe Texture2D PourMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_PourMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_PourMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x0600763F RID: 30271 RVA: 0x0020F894 File Offset: 0x0020DA94
		// (set) Token: 0x06007640 RID: 30272 RVA: 0x0003863C File Offset: 0x0003683C
		public unsafe float _applyPoutOverTimeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr__applyPoutOverTimeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr__applyPoutOverTimeDuration)) = value;
			}
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x06007641 RID: 30273 RVA: 0x0020F8BC File Offset: 0x0020DABC
		// (set) Token: 0x06007642 RID: 30274 RVA: 0x00038657 File Offset: 0x00036857
		public unsafe AnimationCurve _applyPoutOverTimeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr__applyPoutOverTimeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr__applyPoutOverTimeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002487 RID: 9351
		// (get) Token: 0x06007643 RID: 30275 RVA: 0x0020F8EC File Offset: 0x0020DAEC
		// (set) Token: 0x06007644 RID: 30276 RVA: 0x00038676 File Offset: 0x00036876
		public unsafe UnityEvent onSufficientCoverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_onSufficientCoverage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_onSufficientCoverage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002488 RID: 9352
		// (get) Token: 0x06007645 RID: 30277 RVA: 0x0020F91C File Offset: 0x0020DB1C
		// (set) Token: 0x06007646 RID: 30278 RVA: 0x00038695 File Offset: 0x00036895
		public unsafe bool queued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_queued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_queued)) = value;
			}
		}

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x06007647 RID: 30279 RVA: 0x0020F944 File Offset: 0x0020DB44
		// (set) Token: 0x06007648 RID: 30280 RVA: 0x000386B0 File Offset: 0x000368B0
		public unsafe Vector3 queuedWorldPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_queuedWorldPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_queuedWorldPos)) = value;
			}
		}

		// Token: 0x1700248A RID: 9354
		// (get) Token: 0x06007649 RID: 30281 RVA: 0x0020F96C File Offset: 0x0020DB6C
		// (set) Token: 0x0600764A RID: 30282 RVA: 0x000386CB File Offset: 0x000368CB
		public unsafe Texture2D mainTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_mainTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_mainTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x0600764B RID: 30283 RVA: 0x0020F99C File Offset: 0x0020DB9C
		// (set) Token: 0x0600764C RID: 30284 RVA: 0x000386EA File Offset: 0x000368EA
		public unsafe Texture2D tempTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_tempTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_tempTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700248C RID: 9356
		// (get) Token: 0x0600764D RID: 30285 RVA: 0x0020F9CC File Offset: 0x0020DBCC
		// (set) Token: 0x0600764E RID: 30286 RVA: 0x00038709 File Offset: 0x00036909
		public unsafe Vector3 relative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_relative);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_relative)) = value;
			}
		}

		// Token: 0x1700248D RID: 9357
		// (get) Token: 0x0600764F RID: 30287 RVA: 0x0020F9F4 File Offset: 0x0020DBF4
		// (set) Token: 0x06007650 RID: 30288 RVA: 0x00038724 File Offset: 0x00036924
		public unsafe Vector2 vector2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_vector2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_vector2)) = value;
			}
		}

		// Token: 0x1700248E RID: 9358
		// (get) Token: 0x06007651 RID: 30289 RVA: 0x0020FA1C File Offset: 0x0020DC1C
		// (set) Token: 0x06007652 RID: 30290 RVA: 0x0003873F File Offset: 0x0003693F
		public unsafe Vector2 normalizedOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_normalizedOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_normalizedOffset)) = value;
			}
		}

		// Token: 0x1700248F RID: 9359
		// (get) Token: 0x06007653 RID: 30291 RVA: 0x0020FA44 File Offset: 0x0020DC44
		// (set) Token: 0x06007654 RID: 30292 RVA: 0x0003875A File Offset: 0x0003695A
		public unsafe Vector2 originPixel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_originPixel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr_originPixel)) = value;
			}
		}

		// Token: 0x17002490 RID: 9360
		// (get) Token: 0x06007655 RID: 30293 RVA: 0x0020FA6C File Offset: 0x0020DC6C
		// (set) Token: 0x06007656 RID: 30294 RVA: 0x00038775 File Offset: 0x00036975
		public unsafe float _pourApplicationStrength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr__pourApplicationStrength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.NativeFieldInfoPtr__pourApplicationStrength)) = value;
			}
		}

		// Token: 0x04005075 RID: 20597
		private static readonly IntPtr NativeFieldInfoPtr_TextureSize;

		// Token: 0x04005076 RID: 20598
		private static readonly IntPtr NativeFieldInfoPtr_PourRadius;

		// Token: 0x04005077 RID: 20599
		private static readonly IntPtr NativeFieldInfoPtr_UpdatesPerSecond;

		// Token: 0x04005078 RID: 20600
		private static readonly IntPtr NativeFieldInfoPtr_CoveredPixelThreshold;

		// Token: 0x04005079 RID: 20601
		private static readonly IntPtr NativeFieldInfoPtr_Delay;

		// Token: 0x0400507A RID: 20602
		private static readonly IntPtr NativeFieldInfoPtr__CurrentCoverage_k__BackingField;

		// Token: 0x0400507B RID: 20603
		private static readonly IntPtr NativeFieldInfoPtr__UseApplyOverTime_k__BackingField;

		// Token: 0x0400507C RID: 20604
		private static readonly IntPtr NativeFieldInfoPtr_SuccessfulCoverageThreshold;

		// Token: 0x0400507D RID: 20605
		private static readonly IntPtr NativeFieldInfoPtr_GrowContainer;

		// Token: 0x0400507E RID: 20606
		private static readonly IntPtr NativeFieldInfoPtr_MeshRenderer;

		// Token: 0x0400507F RID: 20607
		private static readonly IntPtr NativeFieldInfoPtr_PourMask;

		// Token: 0x04005080 RID: 20608
		private static readonly IntPtr NativeFieldInfoPtr__applyPoutOverTimeDuration;

		// Token: 0x04005081 RID: 20609
		private static readonly IntPtr NativeFieldInfoPtr__applyPoutOverTimeCurve;

		// Token: 0x04005082 RID: 20610
		private static readonly IntPtr NativeFieldInfoPtr_onSufficientCoverage;

		// Token: 0x04005083 RID: 20611
		private static readonly IntPtr NativeFieldInfoPtr_queued;

		// Token: 0x04005084 RID: 20612
		private static readonly IntPtr NativeFieldInfoPtr_queuedWorldPos;

		// Token: 0x04005085 RID: 20613
		private static readonly IntPtr NativeFieldInfoPtr_mainTex;

		// Token: 0x04005086 RID: 20614
		private static readonly IntPtr NativeFieldInfoPtr_tempTex;

		// Token: 0x04005087 RID: 20615
		private static readonly IntPtr NativeFieldInfoPtr_relative;

		// Token: 0x04005088 RID: 20616
		private static readonly IntPtr NativeFieldInfoPtr_vector2;

		// Token: 0x04005089 RID: 20617
		private static readonly IntPtr NativeFieldInfoPtr_normalizedOffset;

		// Token: 0x0400508A RID: 20618
		private static readonly IntPtr NativeFieldInfoPtr_originPixel;

		// Token: 0x0400508B RID: 20619
		private static readonly IntPtr NativeFieldInfoPtr__pourApplicationStrength;

		// Token: 0x0400508C RID: 20620
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCoverage_Public_get_Single_0;

		// Token: 0x0400508D RID: 20621
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentCoverage_Private_set_Void_Single_0;

		// Token: 0x0400508E RID: 20622
		private static readonly IntPtr NativeMethodInfoPtr_get_PourApplicationStrength_Public_get_Single_0;

		// Token: 0x0400508F RID: 20623
		private static readonly IntPtr NativeMethodInfoPtr_set_PourApplicationStrength_Public_set_Void_Single_0;

		// Token: 0x04005090 RID: 20624
		private static readonly IntPtr NativeMethodInfoPtr_get_UseApplyOverTime_Public_get_Boolean_0;

		// Token: 0x04005091 RID: 20625
		private static readonly IntPtr NativeMethodInfoPtr_set_UseApplyOverTime_Public_set_Void_Boolean_0;

		// Token: 0x04005092 RID: 20626
		private static readonly IntPtr NativeMethodInfoPtr_get__sideLength_Private_get_Single_0;

		// Token: 0x04005093 RID: 20627
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005094 RID: 20628
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005095 RID: 20629
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0;

		// Token: 0x04005096 RID: 20630
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04005097 RID: 20631
		private static readonly IntPtr NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0;

		// Token: 0x04005098 RID: 20632
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0;

		// Token: 0x04005099 RID: 20633
		private static readonly IntPtr NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0;

		// Token: 0x0400509A RID: 20634
		private static readonly IntPtr NativeMethodInfoPtr_Blank_Private_Void_0;

		// Token: 0x0400509B RID: 20635
		private static readonly IntPtr NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0;

		// Token: 0x0400509C RID: 20636
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_Boolean_0;

		// Token: 0x0400509D RID: 20637
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPourOverTime_Private_IEnumerator_0;

		// Token: 0x0400509E RID: 20638
		private static readonly IntPtr NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0;

		// Token: 0x0400509F RID: 20639
		private static readonly IntPtr NativeMethodInfoPtr_GetCoverage_Private_Single_0;

		// Token: 0x040050A0 RID: 20640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BAC RID: 2988
		[ObfuscatedName("ScheduleOne.Growing.GrowContainerSurfaceCover+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EAA7 RID: 60071 RVA: 0x0038FE08 File Offset: 0x0038E008
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0>.NativeClassPtr);
				GrowContainerSurfaceCover.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0>.NativeClassPtr, "<>4__this");
				GrowContainerSurfaceCover.__c__DisplayClass42_0.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0>.NativeClassPtr, "worldSpace");
				GrowContainerSurfaceCover.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0>.NativeClassPtr, 100678501);
				GrowContainerSurfaceCover.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0>.NativeClassPtr, 100678502);
			}

			// Token: 0x0600EAA8 RID: 60072 RVA: 0x0038FE84 File Offset: 0x0038E084
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EAA9 RID: 60073 RVA: 0x0038FEC0 File Offset: 0x0038E0C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229748, XrefRangeEnd = 229753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EAAA RID: 60074 RVA: 0x0006EB2B File Offset: 0x0006CD2B
			public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700472C RID: 18220
			// (get) Token: 0x0600EAAB RID: 60075 RVA: 0x0038FF00 File Offset: 0x0038E100
			// (set) Token: 0x0600EAAC RID: 60076 RVA: 0x0006EB34 File Offset: 0x0006CD34
			public unsafe GrowContainerSurfaceCover __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainerSurfaceCover>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700472D RID: 18221
			// (get) Token: 0x0600EAAD RID: 60077 RVA: 0x0038FF30 File Offset: 0x0038E130
			// (set) Token: 0x0600EAAE RID: 60078 RVA: 0x0006EB53 File Offset: 0x0006CD53
			public unsafe Vector3 worldSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.__c__DisplayClass42_0.NativeFieldInfoPtr_worldSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.__c__DisplayClass42_0.NativeFieldInfoPtr_worldSpace)) = value;
				}
			}

			// Token: 0x04009F09 RID: 40713
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009F0A RID: 40714
			private static readonly IntPtr NativeFieldInfoPtr_worldSpace;

			// Token: 0x04009F0B RID: 40715
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F0C RID: 40716
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DEA RID: 3562
			[ObfuscatedName("ScheduleOne.Growing.GrowContainerSurfaceCover+<>c__DisplayClass42_0+<<DelayedApplyPour>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060100EC RID: 65772 RVA: 0x003D0530 File Offset: 0x003CE730
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0>.NativeClassPtr, "<<DelayedApplyPour>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678503);
					GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678504);
					GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678505);
					GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678506);
					GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678507);
					GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678508);
				}

				// Token: 0x060100ED RID: 65773 RVA: 0x003D0610 File Offset: 0x003CE810
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100EE RID: 65774 RVA: 0x003D0658 File Offset: 0x003CE858
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100EF RID: 65775 RVA: 0x003D068C File Offset: 0x003CE88C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229738, XrefRangeEnd = 229743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E54 RID: 20052
				// (get) Token: 0x060100F0 RID: 65776 RVA: 0x003D06C8 File Offset: 0x003CE8C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100F1 RID: 65777 RVA: 0x003D0708 File Offset: 0x003CE908
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229743, XrefRangeEnd = 229748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E55 RID: 20053
				// (get) Token: 0x060100F2 RID: 65778 RVA: 0x003D073C File Offset: 0x003CE93C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100F3 RID: 65779 RVA: 0x00079C6D File Offset: 0x00077E6D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E51 RID: 20049
				// (get) Token: 0x060100F4 RID: 65780 RVA: 0x003D077C File Offset: 0x003CE97C
				// (set) Token: 0x060100F5 RID: 65781 RVA: 0x00079C76 File Offset: 0x00077E76
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E52 RID: 20050
				// (get) Token: 0x060100F6 RID: 65782 RVA: 0x003D07A4 File Offset: 0x003CE9A4
				// (set) Token: 0x060100F7 RID: 65783 RVA: 0x00079C91 File Offset: 0x00077E91
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E53 RID: 20051
				// (get) Token: 0x060100F8 RID: 65784 RVA: 0x003D07D4 File Offset: 0x003CE9D4
				// (set) Token: 0x060100F9 RID: 65785 RVA: 0x00079CB0 File Offset: 0x00077EB0
				public unsafe GrowContainerSurfaceCover.__c__DisplayClass42_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainerSurfaceCover.__c__DisplayClass42_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AD07 RID: 44295
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AD08 RID: 44296
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AD09 RID: 44297
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AD0A RID: 44298
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AD0B RID: 44299
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD0C RID: 44300
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AD0D RID: 44301
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AD0E RID: 44302
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD0F RID: 44303
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BAD RID: 2989
		[ObfuscatedName("ScheduleOne.Growing.GrowContainerSurfaceCover+<ApplyPourOverTime>d__44")]
		public sealed class _ApplyPourOverTime_d__44 : Il2CppSystem.Object
		{
			// Token: 0x0600EAAF RID: 60079 RVA: 0x0038FF58 File Offset: 0x0038E158
			// Note: this type is marked as 'beforefieldinit'.
			static _ApplyPourOverTime_d__44()
			{
				Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "<ApplyPourOverTime>d__44");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr);
				GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr, "<>1__state");
				GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr, "<>2__current");
				GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr, "<>4__this");
				GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr__pixels_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr, "<pixels>5__2");
				GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr__elapasedTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr, "<elapasedTime>5__3");
				GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr, 100678509);
				GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr, 100678510);
				GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr, 100678511);
				GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr, 100678512);
				GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr, 100678513);
				GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr, 100678514);
			}

			// Token: 0x0600EAB0 RID: 60080 RVA: 0x00390060 File Offset: 0x0038E260
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ApplyPourOverTime_d__44(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerSurfaceCover._ApplyPourOverTime_d__44>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EAB1 RID: 60081 RVA: 0x003900A8 File Offset: 0x0038E2A8
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EAB2 RID: 60082 RVA: 0x003900DC File Offset: 0x0038E2DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229753, XrefRangeEnd = 229776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004733 RID: 18227
			// (get) Token: 0x0600EAB3 RID: 60083 RVA: 0x00390118 File Offset: 0x0038E318
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EAB4 RID: 60084 RVA: 0x00390158 File Offset: 0x0038E358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229776, XrefRangeEnd = 229781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004734 RID: 18228
			// (get) Token: 0x0600EAB5 RID: 60085 RVA: 0x0039018C File Offset: 0x0038E38C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EAB6 RID: 60086 RVA: 0x0006EB6E File Offset: 0x0006CD6E
			public _ApplyPourOverTime_d__44(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700472E RID: 18222
			// (get) Token: 0x0600EAB7 RID: 60087 RVA: 0x003901CC File Offset: 0x0038E3CC
			// (set) Token: 0x0600EAB8 RID: 60088 RVA: 0x0006EB77 File Offset: 0x0006CD77
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700472F RID: 18223
			// (get) Token: 0x0600EAB9 RID: 60089 RVA: 0x003901F4 File Offset: 0x0038E3F4
			// (set) Token: 0x0600EABA RID: 60090 RVA: 0x0006EB92 File Offset: 0x0006CD92
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004730 RID: 18224
			// (get) Token: 0x0600EABB RID: 60091 RVA: 0x00390224 File Offset: 0x0038E424
			// (set) Token: 0x0600EABC RID: 60092 RVA: 0x0006EBB1 File Offset: 0x0006CDB1
			public unsafe GrowContainerSurfaceCover __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainerSurfaceCover>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004731 RID: 18225
			// (get) Token: 0x0600EABD RID: 60093 RVA: 0x00390254 File Offset: 0x0038E454
			// (set) Token: 0x0600EABE RID: 60094 RVA: 0x0006EBD0 File Offset: 0x0006CDD0
			public unsafe Il2CppStructArray<Color> _pixels_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr__pixels_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr__pixels_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004732 RID: 18226
			// (get) Token: 0x0600EABF RID: 60095 RVA: 0x00390284 File Offset: 0x0038E484
			// (set) Token: 0x0600EAC0 RID: 60096 RVA: 0x0006EBEF File Offset: 0x0006CDEF
			public unsafe float _elapasedTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr__elapasedTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._ApplyPourOverTime_d__44.NativeFieldInfoPtr__elapasedTime_5__3)) = value;
				}
			}

			// Token: 0x04009F0D RID: 40717
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009F0E RID: 40718
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009F0F RID: 40719
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009F10 RID: 40720
			private static readonly IntPtr NativeFieldInfoPtr__pixels_5__2;

			// Token: 0x04009F11 RID: 40721
			private static readonly IntPtr NativeFieldInfoPtr__elapasedTime_5__3;

			// Token: 0x04009F12 RID: 40722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009F13 RID: 40723
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009F14 RID: 40724
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009F15 RID: 40725
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009F16 RID: 40726
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009F17 RID: 40727
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BAE RID: 2990
		[ObfuscatedName("ScheduleOne.Growing.GrowContainerSurfaceCover+<CheckQueue>d__40")]
		public sealed class _CheckQueue_d__40 : Il2CppSystem.Object
		{
			// Token: 0x0600EAC1 RID: 60097 RVA: 0x003902AC File Offset: 0x0038E4AC
			// Note: this type is marked as 'beforefieldinit'.
			static _CheckQueue_d__40()
			{
				Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrowContainerSurfaceCover>.NativeClassPtr, "<CheckQueue>d__40");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr);
				GrowContainerSurfaceCover._CheckQueue_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr, "<>1__state");
				GrowContainerSurfaceCover._CheckQueue_d__40.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr, "<>2__current");
				GrowContainerSurfaceCover._CheckQueue_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr, "<>4__this");
				GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr, 100678515);
				GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr, 100678516);
				GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr, 100678517);
				GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr, 100678518);
				GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr, 100678519);
				GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr, 100678520);
			}

			// Token: 0x0600EAC2 RID: 60098 RVA: 0x0039038C File Offset: 0x0038E58C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CheckQueue_d__40(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerSurfaceCover._CheckQueue_d__40>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EAC3 RID: 60099 RVA: 0x003903D4 File Offset: 0x0038E5D4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EAC4 RID: 60100 RVA: 0x00390408 File Offset: 0x0038E608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229781, XrefRangeEnd = 229805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004738 RID: 18232
			// (get) Token: 0x0600EAC5 RID: 60101 RVA: 0x00390444 File Offset: 0x0038E644
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EAC6 RID: 60102 RVA: 0x00390484 File Offset: 0x0038E684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229805, XrefRangeEnd = 229810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004739 RID: 18233
			// (get) Token: 0x0600EAC7 RID: 60103 RVA: 0x003904B8 File Offset: 0x0038E6B8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerSurfaceCover._CheckQueue_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EAC8 RID: 60104 RVA: 0x0006EC0A File Offset: 0x0006CE0A
			public _CheckQueue_d__40(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004735 RID: 18229
			// (get) Token: 0x0600EAC9 RID: 60105 RVA: 0x003904F8 File Offset: 0x0038E6F8
			// (set) Token: 0x0600EACA RID: 60106 RVA: 0x0006EC13 File Offset: 0x0006CE13
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._CheckQueue_d__40.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._CheckQueue_d__40.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004736 RID: 18230
			// (get) Token: 0x0600EACB RID: 60107 RVA: 0x00390520 File Offset: 0x0038E720
			// (set) Token: 0x0600EACC RID: 60108 RVA: 0x0006EC2E File Offset: 0x0006CE2E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._CheckQueue_d__40.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._CheckQueue_d__40.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004737 RID: 18231
			// (get) Token: 0x0600EACD RID: 60109 RVA: 0x00390550 File Offset: 0x0038E750
			// (set) Token: 0x0600EACE RID: 60110 RVA: 0x0006EC4D File Offset: 0x0006CE4D
			public unsafe GrowContainerSurfaceCover __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._CheckQueue_d__40.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainerSurfaceCover>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerSurfaceCover._CheckQueue_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009F18 RID: 40728
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009F19 RID: 40729
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009F1A RID: 40730
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009F1B RID: 40731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009F1C RID: 40732
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009F1D RID: 40733
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009F1E RID: 40734
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009F1F RID: 40735
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009F20 RID: 40736
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.State;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Graffiti
{
	// Token: 0x02000370 RID: 880
	public class SpraySurfaceInteraction : MonoBehaviour
	{
		// Token: 0x06004AC1 RID: 19137 RVA: 0x00179FA0 File Offset: 0x001781A0
		// Note: this type is marked as 'beforefieldinit'.
		static SpraySurfaceInteraction()
		{
			Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Graffiti", "SpraySurfaceInteraction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr);
			SpraySurfaceInteraction.NativeFieldInfoPtr_CameraLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "CameraLerpTime");
			SpraySurfaceInteraction.NativeFieldInfoPtr_MaxPixelsBeforeNewStroke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "MaxPixelsBeforeNewStroke");
			SpraySurfaceInteraction.NativeFieldInfoPtr_ManhattanDistanceBetweenPaintedPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "ManhattanDistanceBetweenPaintedPixels");
			SpraySurfaceInteraction.NativeFieldInfoPtr_FixedPaintedPixelLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "FixedPaintedPixelLimit");
			SpraySurfaceInteraction.NativeFieldInfoPtr_CanvasPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "CanvasPadding");
			SpraySurfaceInteraction.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "<IsOpen>k__BackingField");
			SpraySurfaceInteraction.NativeFieldInfoPtr_SpraySurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "SpraySurface");
			SpraySurfaceInteraction.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "IntObj");
			SpraySurfaceInteraction.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "CameraPosition");
			SpraySurfaceInteraction.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "Canvas");
			SpraySurfaceInteraction.NativeFieldInfoPtr_SprayImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "SprayImg");
			SpraySurfaceInteraction.NativeFieldInfoPtr_SpraySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "SpraySound");
			SpraySurfaceInteraction.NativeFieldInfoPtr_CleanSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "CleanSound");
			SpraySurfaceInteraction.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "State");
			SpraySurfaceInteraction.NativeFieldInfoPtr__allowDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "_allowDraw");
			SpraySurfaceInteraction.NativeFieldInfoPtr_PaintedPixelLimitMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "PaintedPixelLimitMultiplier");
			SpraySurfaceInteraction.NativeFieldInfoPtr_selectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "selectedColor");
			SpraySurfaceInteraction.NativeFieldInfoPtr_selectedStrokeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "selectedStrokeSize");
			SpraySurfaceInteraction.NativeFieldInfoPtr_lastPaintedPixelCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "lastPaintedPixelCoord");
			SpraySurfaceInteraction.NativeFieldInfoPtr_paintedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "paintedLastFrame");
			SpraySurfaceInteraction.NativeFieldInfoPtr_currentStrokePixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "currentStrokePixels");
			SpraySurfaceInteraction.NativeFieldInfoPtr_isPaintingStroke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "isPaintingStroke");
			SpraySurfaceInteraction.NativeFieldInfoPtr_timeSinceStrokeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, "timeSinceStrokeStart");
			SpraySurfaceInteraction.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672889);
			SpraySurfaceInteraction.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672890);
			SpraySurfaceInteraction.NativeMethodInfoPtr_get_confirmationPanelOpen_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672891);
			SpraySurfaceInteraction.NativeMethodInfoPtr_get__paintedPixelLimit_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672892);
			SpraySurfaceInteraction.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672893);
			SpraySurfaceInteraction.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672894);
			SpraySurfaceInteraction.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672895);
			SpraySurfaceInteraction.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672896);
			SpraySurfaceInteraction.NativeMethodInfoPtr_ResizeCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672897);
			SpraySurfaceInteraction.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672898);
			SpraySurfaceInteraction.NativeMethodInfoPtr_UpdateCursor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672899);
			SpraySurfaceInteraction.NativeMethodInfoPtr_UpdateSpraySound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672900);
			SpraySurfaceInteraction.NativeMethodInfoPtr_CheckCameraInBounds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672901);
			SpraySurfaceInteraction.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672902);
			SpraySurfaceInteraction.NativeMethodInfoPtr_StartStroke_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672903);
			SpraySurfaceInteraction.NativeMethodInfoPtr_EndStroke_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672904);
			SpraySurfaceInteraction.NativeMethodInfoPtr_IsPointerOverSurface_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672905);
			SpraySurfaceInteraction.NativeMethodInfoPtr_GetCursorPositionOnSurface_Private_Boolean_byref_UInt16_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672906);
			SpraySurfaceInteraction.NativeMethodInfoPtr_GetCursorRay_Private_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672907);
			SpraySurfaceInteraction.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672908);
			SpraySurfaceInteraction.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672909);
			SpraySurfaceInteraction.NativeMethodInfoPtr_UseGraffitiCleaner_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672910);
			SpraySurfaceInteraction.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672911);
			SpraySurfaceInteraction.NativeMethodInfoPtr_Open_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672912);
			SpraySurfaceInteraction.NativeMethodInfoPtr_DoneClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672913);
			SpraySurfaceInteraction.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672914);
			SpraySurfaceInteraction.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672915);
			SpraySurfaceInteraction.NativeMethodInfoPtr_EquippedSlotChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672916);
			SpraySurfaceInteraction.NativeMethodInfoPtr_SetColor_Private_Void_ESprayColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672917);
			SpraySurfaceInteraction.NativeMethodInfoPtr_SetStrokeSize_Private_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672918);
			SpraySurfaceInteraction.NativeMethodInfoPtr_UpdateRemainingPaintIndicator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672919);
			SpraySurfaceInteraction.NativeMethodInfoPtr_Undo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672920);
			SpraySurfaceInteraction.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672921);
			SpraySurfaceInteraction.NativeMethodInfoPtr_IsSprayCanEquipped_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672922);
			SpraySurfaceInteraction.NativeMethodInfoPtr_IsGraffitiCleanerEquipped_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672923);
			SpraySurfaceInteraction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr, 100672924);
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x0017A46C File Offset: 0x0017866C
		// (set) Token: 0x06004AC3 RID: 19139 RVA: 0x0017A4A8 File Offset: 0x001786A8
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06004AC4 RID: 19140 RVA: 0x0017A4E8 File Offset: 0x001786E8
		public unsafe bool confirmationPanelOpen
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 170514, RefRangeEnd = 170518, XrefRangeStart = 170507, XrefRangeEnd = 170514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_get_confirmationPanelOpen_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06004AC5 RID: 19141 RVA: 0x0017A524 File Offset: 0x00178724
		public unsafe int _paintedPixelLimit
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170518, XrefRangeEnd = 170519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_get__paintedPixelLimit_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x0017A560 File Offset: 0x00178760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170519, XrefRangeEnd = 170556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x0017A594 File Offset: 0x00178794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170556, XrefRangeEnd = 170584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x0017A5C8 File Offset: 0x001787C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170624, RefRangeEnd = 170625, XrefRangeStart = 170584, XrefRangeEnd = 170624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x0017A5FC File Offset: 0x001787FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170625, XrefRangeEnd = 170645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x0017A630 File Offset: 0x00178830
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170672, RefRangeEnd = 170673, XrefRangeStart = 170645, XrefRangeEnd = 170672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_ResizeCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x0017A664 File Offset: 0x00178864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170673, XrefRangeEnd = 170694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x0017A698 File Offset: 0x00178898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170694, XrefRangeEnd = 170702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_UpdateCursor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x0017A6CC File Offset: 0x001788CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170706, RefRangeEnd = 170708, XrefRangeStart = 170702, XrefRangeEnd = 170706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpraySound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_UpdateSpraySound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x0017A700 File Offset: 0x00178900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170740, RefRangeEnd = 170741, XrefRangeStart = 170708, XrefRangeEnd = 170740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCameraInBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_CheckCameraInBounds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x0017A734 File Offset: 0x00178934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170741, XrefRangeEnd = 170801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x0017A768 File Offset: 0x00178968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170827, RefRangeEnd = 170829, XrefRangeStart = 170801, XrefRangeEnd = 170827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartStroke(bool recordHistory = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref recordHistory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_StartStroke_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x0017A7A8 File Offset: 0x001789A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 170874, RefRangeEnd = 170879, XrefRangeStart = 170829, XrefRangeEnd = 170874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndStroke(bool stopSpraySound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stopSpraySound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_EndStroke_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD2 RID: 19154 RVA: 0x0017A7E8 File Offset: 0x001789E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170879, XrefRangeEnd = 170889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointerOverSurface()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_IsPointerOverSurface_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x0017A824 File Offset: 0x00178A24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 170922, RefRangeEnd = 170925, XrefRangeStart = 170889, XrefRangeEnd = 170922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCursorPositionOnSurface(out ushort pixelX, out ushort pixelY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &pixelX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pixelY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_GetCursorPositionOnSurface_Private_Boolean_byref_UInt16_byref_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x0017A87C File Offset: 0x00178A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170925, XrefRangeEnd = 170934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray GetCursorRay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_GetCursorRay_Private_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x0017A8B8 File Offset: 0x00178AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170934, XrefRangeEnd = 170948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x0017A8EC File Offset: 0x00178AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170948, XrefRangeEnd = 170962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x0017A920 File Offset: 0x00178B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170962, XrefRangeEnd = 170974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UseGraffitiCleaner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_UseGraffitiCleaner_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x0017A954 File Offset: 0x00178B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170974, XrefRangeEnd = 170982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x0017A998 File Offset: 0x00178B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170982, XrefRangeEnd = 171133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_Open_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x0017A9CC File Offset: 0x00178BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171133, XrefRangeEnd = 171147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoneClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_DoneClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x0017AA00 File Offset: 0x00178C00
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 98818, RefRangeEnd = 98823, XrefRangeStart = 98818, XrefRangeEnd = 98823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x0017AA34 File Offset: 0x00178C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171147, XrefRangeEnd = 171272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x0017AA68 File Offset: 0x00178C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171272, XrefRangeEnd = 171281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EquippedSlotChanged(int equippedSlotIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref equippedSlotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_EquippedSlotChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x0017AAA8 File Offset: 0x00178CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171281, XrefRangeEnd = 171284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(ESprayColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_SetColor_Private_Void_ESprayColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x0017AAE8 File Offset: 0x00178CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171284, XrefRangeEnd = 171296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStrokeSize(byte strokeSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref strokeSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_SetStrokeSize_Private_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x0017AB28 File Offset: 0x00178D28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171304, RefRangeEnd = 171306, XrefRangeStart = 171296, XrefRangeEnd = 171304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRemainingPaintIndicator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_UpdateRemainingPaintIndicator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x0017AB5C File Offset: 0x00178D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171306, XrefRangeEnd = 171337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_Undo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x0017AB90 File Offset: 0x00178D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171337, XrefRangeEnd = 171350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x0017ABC4 File Offset: 0x00178DC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 171356, RefRangeEnd = 171359, XrefRangeStart = 171350, XrefRangeEnd = 171356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSprayCanEquipped()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_IsSprayCanEquipped_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x0017ABF4 File Offset: 0x00178DF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 171365, RefRangeEnd = 171367, XrefRangeStart = 171359, XrefRangeEnd = 171365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGraffitiCleanerEquipped()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr_IsGraffitiCleanerEquipped_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x0017AC24 File Offset: 0x00178E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 171367, XrefRangeEnd = 171375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpraySurfaceInteraction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpraySurfaceInteraction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpraySurfaceInteraction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x0002420C File Offset: 0x0002240C
		public SpraySurfaceInteraction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x0017AC60 File Offset: 0x00178E60
		// (set) Token: 0x06004AE8 RID: 19176 RVA: 0x00024215 File Offset: 0x00022415
		public unsafe static float CameraLerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpraySurfaceInteraction.NativeFieldInfoPtr_CameraLerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpraySurfaceInteraction.NativeFieldInfoPtr_CameraLerpTime, (void*)(&value));
			}
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06004AE9 RID: 19177 RVA: 0x0017AC7C File Offset: 0x00178E7C
		// (set) Token: 0x06004AEA RID: 19178 RVA: 0x00024223 File Offset: 0x00022423
		public unsafe static int MaxPixelsBeforeNewStroke
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpraySurfaceInteraction.NativeFieldInfoPtr_MaxPixelsBeforeNewStroke, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpraySurfaceInteraction.NativeFieldInfoPtr_MaxPixelsBeforeNewStroke, (void*)(&value));
			}
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06004AEB RID: 19179 RVA: 0x0017AC98 File Offset: 0x00178E98
		// (set) Token: 0x06004AEC RID: 19180 RVA: 0x00024231 File Offset: 0x00022431
		public unsafe static int ManhattanDistanceBetweenPaintedPixels
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpraySurfaceInteraction.NativeFieldInfoPtr_ManhattanDistanceBetweenPaintedPixels, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpraySurfaceInteraction.NativeFieldInfoPtr_ManhattanDistanceBetweenPaintedPixels, (void*)(&value));
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06004AED RID: 19181 RVA: 0x0017ACB4 File Offset: 0x00178EB4
		// (set) Token: 0x06004AEE RID: 19182 RVA: 0x0002423F File Offset: 0x0002243F
		public unsafe static int FixedPaintedPixelLimit
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpraySurfaceInteraction.NativeFieldInfoPtr_FixedPaintedPixelLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpraySurfaceInteraction.NativeFieldInfoPtr_FixedPaintedPixelLimit, (void*)(&value));
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06004AEF RID: 19183 RVA: 0x0017ACD0 File Offset: 0x00178ED0
		// (set) Token: 0x06004AF0 RID: 19184 RVA: 0x0002424D File Offset: 0x0002244D
		public unsafe static int CanvasPadding
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SpraySurfaceInteraction.NativeFieldInfoPtr_CanvasPadding, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpraySurfaceInteraction.NativeFieldInfoPtr_CanvasPadding, (void*)(&value));
			}
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06004AF1 RID: 19185 RVA: 0x0017ACEC File Offset: 0x00178EEC
		// (set) Token: 0x06004AF2 RID: 19186 RVA: 0x0002425B File Offset: 0x0002245B
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06004AF3 RID: 19187 RVA: 0x0017AD14 File Offset: 0x00178F14
		// (set) Token: 0x06004AF4 RID: 19188 RVA: 0x00024276 File Offset: 0x00022476
		public unsafe SpraySurface SpraySurface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_SpraySurface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpraySurface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_SpraySurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06004AF5 RID: 19189 RVA: 0x0017AD44 File Offset: 0x00178F44
		// (set) Token: 0x06004AF6 RID: 19190 RVA: 0x00024295 File Offset: 0x00022495
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06004AF7 RID: 19191 RVA: 0x0017AD74 File Offset: 0x00178F74
		// (set) Token: 0x06004AF8 RID: 19192 RVA: 0x000242B4 File Offset: 0x000224B4
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06004AF9 RID: 19193 RVA: 0x0017ADA4 File Offset: 0x00178FA4
		// (set) Token: 0x06004AFA RID: 19194 RVA: 0x000242D3 File Offset: 0x000224D3
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x06004AFB RID: 19195 RVA: 0x0017ADD4 File Offset: 0x00178FD4
		// (set) Token: 0x06004AFC RID: 19196 RVA: 0x000242F2 File Offset: 0x000224F2
		public unsafe Image SprayImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_SprayImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_SprayImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x06004AFD RID: 19197 RVA: 0x0017AE04 File Offset: 0x00179004
		// (set) Token: 0x06004AFE RID: 19198 RVA: 0x00024311 File Offset: 0x00022511
		public unsafe AudioSourceController SpraySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_SpraySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_SpraySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06004AFF RID: 19199 RVA: 0x0017AE34 File Offset: 0x00179034
		// (set) Token: 0x06004B00 RID: 19200 RVA: 0x00024330 File Offset: 0x00022530
		public unsafe AudioSourceController CleanSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_CleanSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_CleanSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x06004B01 RID: 19201 RVA: 0x0017AE64 File Offset: 0x00179064
		// (set) Token: 0x06004B02 RID: 19202 RVA: 0x0002434F File Offset: 0x0002254F
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06004B03 RID: 19203 RVA: 0x0017AE94 File Offset: 0x00179094
		// (set) Token: 0x06004B04 RID: 19204 RVA: 0x0002436E File Offset: 0x0002256E
		public unsafe bool _allowDraw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr__allowDraw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr__allowDraw)) = value;
			}
		}

		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x06004B05 RID: 19205 RVA: 0x0017AEBC File Offset: 0x001790BC
		// (set) Token: 0x06004B06 RID: 19206 RVA: 0x00024389 File Offset: 0x00022589
		public unsafe float PaintedPixelLimitMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_PaintedPixelLimitMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_PaintedPixelLimitMultiplier)) = value;
			}
		}

		// Token: 0x17001774 RID: 6004
		// (get) Token: 0x06004B07 RID: 19207 RVA: 0x0017AEE4 File Offset: 0x001790E4
		// (set) Token: 0x06004B08 RID: 19208 RVA: 0x000243A4 File Offset: 0x000225A4
		public unsafe ESprayColor selectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_selectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_selectedColor)) = value;
			}
		}

		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06004B09 RID: 19209 RVA: 0x0017AF0C File Offset: 0x0017910C
		// (set) Token: 0x06004B0A RID: 19210 RVA: 0x000243BF File Offset: 0x000225BF
		public unsafe byte selectedStrokeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_selectedStrokeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_selectedStrokeSize)) = value;
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06004B0B RID: 19211 RVA: 0x0017AF34 File Offset: 0x00179134
		// (set) Token: 0x06004B0C RID: 19212 RVA: 0x000243DA File Offset: 0x000225DA
		public unsafe UShort2 lastPaintedPixelCoord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_lastPaintedPixelCoord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_lastPaintedPixelCoord)) = value;
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06004B0D RID: 19213 RVA: 0x0017AF5C File Offset: 0x0017915C
		// (set) Token: 0x06004B0E RID: 19214 RVA: 0x000243F5 File Offset: 0x000225F5
		public unsafe bool paintedLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_paintedLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_paintedLastFrame)) = value;
			}
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x06004B0F RID: 19215 RVA: 0x0017AF84 File Offset: 0x00179184
		// (set) Token: 0x06004B10 RID: 19216 RVA: 0x00024410 File Offset: 0x00022610
		public unsafe List<UShort2> currentStrokePixels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_currentStrokePixels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UShort2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_currentStrokePixels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x06004B11 RID: 19217 RVA: 0x0017AFB4 File Offset: 0x001791B4
		// (set) Token: 0x06004B12 RID: 19218 RVA: 0x0002442F File Offset: 0x0002262F
		public unsafe bool isPaintingStroke
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_isPaintingStroke);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_isPaintingStroke)) = value;
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06004B13 RID: 19219 RVA: 0x0017AFDC File Offset: 0x001791DC
		// (set) Token: 0x06004B14 RID: 19220 RVA: 0x0002444A File Offset: 0x0002264A
		public unsafe float timeSinceStrokeStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_timeSinceStrokeStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpraySurfaceInteraction.NativeFieldInfoPtr_timeSinceStrokeStart)) = value;
			}
		}

		// Token: 0x040032E9 RID: 13033
		private static readonly IntPtr NativeFieldInfoPtr_CameraLerpTime;

		// Token: 0x040032EA RID: 13034
		private static readonly IntPtr NativeFieldInfoPtr_MaxPixelsBeforeNewStroke;

		// Token: 0x040032EB RID: 13035
		private static readonly IntPtr NativeFieldInfoPtr_ManhattanDistanceBetweenPaintedPixels;

		// Token: 0x040032EC RID: 13036
		private static readonly IntPtr NativeFieldInfoPtr_FixedPaintedPixelLimit;

		// Token: 0x040032ED RID: 13037
		private static readonly IntPtr NativeFieldInfoPtr_CanvasPadding;

		// Token: 0x040032EE RID: 13038
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040032EF RID: 13039
		private static readonly IntPtr NativeFieldInfoPtr_SpraySurface;

		// Token: 0x040032F0 RID: 13040
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040032F1 RID: 13041
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x040032F2 RID: 13042
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040032F3 RID: 13043
		private static readonly IntPtr NativeFieldInfoPtr_SprayImg;

		// Token: 0x040032F4 RID: 13044
		private static readonly IntPtr NativeFieldInfoPtr_SpraySound;

		// Token: 0x040032F5 RID: 13045
		private static readonly IntPtr NativeFieldInfoPtr_CleanSound;

		// Token: 0x040032F6 RID: 13046
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040032F7 RID: 13047
		private static readonly IntPtr NativeFieldInfoPtr__allowDraw;

		// Token: 0x040032F8 RID: 13048
		private static readonly IntPtr NativeFieldInfoPtr_PaintedPixelLimitMultiplier;

		// Token: 0x040032F9 RID: 13049
		private static readonly IntPtr NativeFieldInfoPtr_selectedColor;

		// Token: 0x040032FA RID: 13050
		private static readonly IntPtr NativeFieldInfoPtr_selectedStrokeSize;

		// Token: 0x040032FB RID: 13051
		private static readonly IntPtr NativeFieldInfoPtr_lastPaintedPixelCoord;

		// Token: 0x040032FC RID: 13052
		private static readonly IntPtr NativeFieldInfoPtr_paintedLastFrame;

		// Token: 0x040032FD RID: 13053
		private static readonly IntPtr NativeFieldInfoPtr_currentStrokePixels;

		// Token: 0x040032FE RID: 13054
		private static readonly IntPtr NativeFieldInfoPtr_isPaintingStroke;

		// Token: 0x040032FF RID: 13055
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStrokeStart;

		// Token: 0x04003300 RID: 13056
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04003301 RID: 13057
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04003302 RID: 13058
		private static readonly IntPtr NativeMethodInfoPtr_get_confirmationPanelOpen_Private_get_Boolean_0;

		// Token: 0x04003303 RID: 13059
		private static readonly IntPtr NativeMethodInfoPtr_get__paintedPixelLimit_Private_get_Int32_0;

		// Token: 0x04003304 RID: 13060
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003305 RID: 13061
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003306 RID: 13062
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x04003307 RID: 13063
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04003308 RID: 13064
		private static readonly IntPtr NativeMethodInfoPtr_ResizeCanvas_Private_Void_0;

		// Token: 0x04003309 RID: 13065
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400330A RID: 13066
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCursor_Private_Void_0;

		// Token: 0x0400330B RID: 13067
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpraySound_Private_Void_0;

		// Token: 0x0400330C RID: 13068
		private static readonly IntPtr NativeMethodInfoPtr_CheckCameraInBounds_Private_Void_0;

		// Token: 0x0400330D RID: 13069
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400330E RID: 13070
		private static readonly IntPtr NativeMethodInfoPtr_StartStroke_Private_Void_Boolean_0;

		// Token: 0x0400330F RID: 13071
		private static readonly IntPtr NativeMethodInfoPtr_EndStroke_Private_Void_Boolean_0;

		// Token: 0x04003310 RID: 13072
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverSurface_Private_Boolean_0;

		// Token: 0x04003311 RID: 13073
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorPositionOnSurface_Private_Boolean_byref_UInt16_byref_UInt16_0;

		// Token: 0x04003312 RID: 13074
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorRay_Private_Ray_0;

		// Token: 0x04003313 RID: 13075
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04003314 RID: 13076
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04003315 RID: 13077
		private static readonly IntPtr NativeMethodInfoPtr_UseGraffitiCleaner_Private_Void_0;

		// Token: 0x04003316 RID: 13078
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04003317 RID: 13079
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Void_0;

		// Token: 0x04003318 RID: 13080
		private static readonly IntPtr NativeMethodInfoPtr_DoneClicked_Private_Void_0;

		// Token: 0x04003319 RID: 13081
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x0400331A RID: 13082
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x0400331B RID: 13083
		private static readonly IntPtr NativeMethodInfoPtr_EquippedSlotChanged_Private_Void_Int32_0;

		// Token: 0x0400331C RID: 13084
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Private_Void_ESprayColor_0;

		// Token: 0x0400331D RID: 13085
		private static readonly IntPtr NativeMethodInfoPtr_SetStrokeSize_Private_Void_Byte_0;

		// Token: 0x0400331E RID: 13086
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRemainingPaintIndicator_Private_Void_0;

		// Token: 0x0400331F RID: 13087
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Void_0;

		// Token: 0x04003320 RID: 13088
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x04003321 RID: 13089
		private static readonly IntPtr NativeMethodInfoPtr_IsSprayCanEquipped_Private_Static_Boolean_0;

		// Token: 0x04003322 RID: 13090
		private static readonly IntPtr NativeMethodInfoPtr_IsGraffitiCleanerEquipped_Private_Static_Boolean_0;

		// Token: 0x04003323 RID: 13091
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

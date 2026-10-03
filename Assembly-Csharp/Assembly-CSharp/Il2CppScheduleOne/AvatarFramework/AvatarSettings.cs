using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000498 RID: 1176
	[Serializable]
	public class AvatarSettings : ScriptableObject
	{
		// Token: 0x06006B42 RID: 27458 RVA: 0x001EE898 File Offset: 0x001ECA98
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSettings()
		{
			Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "AvatarSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr);
			AvatarSettings.NativeFieldInfoPtr_SkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "SkinColor");
			AvatarSettings.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Height");
			AvatarSettings.NativeFieldInfoPtr_Gender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Gender");
			AvatarSettings.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "Weight");
			AvatarSettings.NativeFieldInfoPtr_HairPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "HairPath");
			AvatarSettings.NativeFieldInfoPtr_HairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "HairColor");
			AvatarSettings.NativeFieldInfoPtr_EyebrowScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowScale");
			AvatarSettings.NativeFieldInfoPtr_EyebrowThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowThickness");
			AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowRestingHeight");
			AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyebrowRestingAngle");
			AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LeftEyeLidColor");
			AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "RightEyeLidColor");
			AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LeftEyeRestingState");
			AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "RightEyeRestingState");
			AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyeballMaterialIdentifier");
			AvatarSettings.NativeFieldInfoPtr_EyeBallTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "EyeBallTint");
			AvatarSettings.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "PupilDilation");
			AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "FaceLayerSettings");
			AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "BodyLayerSettings");
			AvatarSettings.NativeFieldInfoPtr_AccessorySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "AccessorySettings");
			AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "UseCombinedLayer");
			AvatarSettings.NativeFieldInfoPtr_CombinedLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "CombinedLayer");
			AvatarSettings.NativeFieldInfoPtr_ImpostorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "ImpostorTexture");
			AvatarSettings.NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677325);
			AvatarSettings.NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677326);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677327);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677328);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677329);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677330);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677331);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677332);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677333);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677334);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677335);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677336);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677337);
			AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677338);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677339);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677340);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677341);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677342);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677343);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677344);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677345);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677346);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677347);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677348);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677349);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677350);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer7Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677351);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer7Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677352);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer8Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677353);
			AvatarSettings.NativeMethodInfoPtr_get_BodyLayer8Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677354);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677355);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677356);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677357);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677358);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677359);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677360);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677361);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677362);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677363);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677364);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677365);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677366);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677367);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677368);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677369);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677370);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677371);
			AvatarSettings.NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677372);
			AvatarSettings.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677373);
			AvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677374);
			AvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, 100677375);
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x06006B43 RID: 27459 RVA: 0x001EEE90 File Offset: 0x001ED090
		public unsafe float UpperEyelidRestingPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x06006B44 RID: 27460 RVA: 0x001EEECC File Offset: 0x001ED0CC
		public unsafe float LowerEyelidRestingPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x06006B45 RID: 27461 RVA: 0x001EEF08 File Offset: 0x001ED108
		public unsafe string FaceLayer1Path
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 220498, RefRangeEnd = 220500, XrefRangeStart = 220494, XrefRangeEnd = 220498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170020EE RID: 8430
		// (get) Token: 0x06006B46 RID: 27462 RVA: 0x001EEF40 File Offset: 0x001ED140
		public unsafe Color FaceLayer1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220500, XrefRangeEnd = 220504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x06006B47 RID: 27463 RVA: 0x001EEF7C File Offset: 0x001ED17C
		public unsafe string FaceLayer2Path
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 220508, RefRangeEnd = 220512, XrefRangeStart = 220504, XrefRangeEnd = 220508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x06006B48 RID: 27464 RVA: 0x001EEFB4 File Offset: 0x001ED1B4
		public unsafe Color FaceLayer2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220512, XrefRangeEnd = 220516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x06006B49 RID: 27465 RVA: 0x001EEFF0 File Offset: 0x001ED1F0
		public unsafe string FaceLayer3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220516, XrefRangeEnd = 220520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x06006B4A RID: 27466 RVA: 0x001EF028 File Offset: 0x001ED228
		public unsafe Color FaceLayer3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220520, XrefRangeEnd = 220524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06006B4B RID: 27467 RVA: 0x001EF064 File Offset: 0x001ED264
		public unsafe string FaceLayer4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220524, XrefRangeEnd = 220528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06006B4C RID: 27468 RVA: 0x001EF09C File Offset: 0x001ED29C
		public unsafe Color FaceLayer4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220528, XrefRangeEnd = 220532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x06006B4D RID: 27469 RVA: 0x001EF0D8 File Offset: 0x001ED2D8
		public unsafe string FaceLayer5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220532, XrefRangeEnd = 220536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x06006B4E RID: 27470 RVA: 0x001EF110 File Offset: 0x001ED310
		public unsafe Color FaceLayer5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220536, XrefRangeEnd = 220540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x06006B4F RID: 27471 RVA: 0x001EF14C File Offset: 0x001ED34C
		public unsafe string FaceLayer6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220540, XrefRangeEnd = 220544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x06006B50 RID: 27472 RVA: 0x001EF184 File Offset: 0x001ED384
		public unsafe Color FaceLayer6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220544, XrefRangeEnd = 220548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x06006B51 RID: 27473 RVA: 0x001EF1C0 File Offset: 0x001ED3C0
		public unsafe string BodyLayer1Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220548, XrefRangeEnd = 220552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x06006B52 RID: 27474 RVA: 0x001EF1F8 File Offset: 0x001ED3F8
		public unsafe Color BodyLayer1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220552, XrefRangeEnd = 220556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x06006B53 RID: 27475 RVA: 0x001EF234 File Offset: 0x001ED434
		public unsafe string BodyLayer2Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220556, XrefRangeEnd = 220560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06006B54 RID: 27476 RVA: 0x001EF26C File Offset: 0x001ED46C
		public unsafe Color BodyLayer2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220560, XrefRangeEnd = 220564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06006B55 RID: 27477 RVA: 0x001EF2A8 File Offset: 0x001ED4A8
		public unsafe string BodyLayer3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220564, XrefRangeEnd = 220568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x06006B56 RID: 27478 RVA: 0x001EF2E0 File Offset: 0x001ED4E0
		public unsafe Color BodyLayer3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220568, XrefRangeEnd = 220572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x06006B57 RID: 27479 RVA: 0x001EF31C File Offset: 0x001ED51C
		public unsafe string BodyLayer4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220572, XrefRangeEnd = 220576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x06006B58 RID: 27480 RVA: 0x001EF354 File Offset: 0x001ED554
		public unsafe Color BodyLayer4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220576, XrefRangeEnd = 220580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x06006B59 RID: 27481 RVA: 0x001EF390 File Offset: 0x001ED590
		public unsafe string BodyLayer5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220580, XrefRangeEnd = 220584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06006B5A RID: 27482 RVA: 0x001EF3C8 File Offset: 0x001ED5C8
		public unsafe Color BodyLayer5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220584, XrefRangeEnd = 220588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06006B5B RID: 27483 RVA: 0x001EF404 File Offset: 0x001ED604
		public unsafe string BodyLayer6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220588, XrefRangeEnd = 220592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x06006B5C RID: 27484 RVA: 0x001EF43C File Offset: 0x001ED63C
		public unsafe Color BodyLayer6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220592, XrefRangeEnd = 220596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06006B5D RID: 27485 RVA: 0x001EF478 File Offset: 0x001ED678
		public unsafe string BodyLayer7Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220596, XrefRangeEnd = 220600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer7Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x06006B5E RID: 27486 RVA: 0x001EF4B0 File Offset: 0x001ED6B0
		public unsafe Color BodyLayer7Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220600, XrefRangeEnd = 220604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer7Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x06006B5F RID: 27487 RVA: 0x001EF4EC File Offset: 0x001ED6EC
		public unsafe string BodyLayer8Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220604, XrefRangeEnd = 220608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer8Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x06006B60 RID: 27488 RVA: 0x001EF524 File Offset: 0x001ED724
		public unsafe Color BodyLayer8Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220608, XrefRangeEnd = 220612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_BodyLayer8Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x06006B61 RID: 27489 RVA: 0x001EF560 File Offset: 0x001ED760
		public unsafe string Accessory1Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220612, XrefRangeEnd = 220616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06006B62 RID: 27490 RVA: 0x001EF598 File Offset: 0x001ED798
		public unsafe Color Accessory1Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220616, XrefRangeEnd = 220620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06006B63 RID: 27491 RVA: 0x001EF5D4 File Offset: 0x001ED7D4
		public unsafe string Accessory2Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220620, XrefRangeEnd = 220624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06006B64 RID: 27492 RVA: 0x001EF60C File Offset: 0x001ED80C
		public unsafe Color Accessory2Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220624, XrefRangeEnd = 220628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06006B65 RID: 27493 RVA: 0x001EF648 File Offset: 0x001ED848
		public unsafe string Accessory3Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220628, XrefRangeEnd = 220632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x06006B66 RID: 27494 RVA: 0x001EF680 File Offset: 0x001ED880
		public unsafe Color Accessory3Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220632, XrefRangeEnd = 220636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x06006B67 RID: 27495 RVA: 0x001EF6BC File Offset: 0x001ED8BC
		public unsafe string Accessory4Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220636, XrefRangeEnd = 220640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x06006B68 RID: 27496 RVA: 0x001EF6F4 File Offset: 0x001ED8F4
		public unsafe Color Accessory4Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220640, XrefRangeEnd = 220644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x06006B69 RID: 27497 RVA: 0x001EF730 File Offset: 0x001ED930
		public unsafe string Accessory5Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220644, XrefRangeEnd = 220648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x06006B6A RID: 27498 RVA: 0x001EF768 File Offset: 0x001ED968
		public unsafe Color Accessory5Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220648, XrefRangeEnd = 220652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06006B6B RID: 27499 RVA: 0x001EF7A4 File Offset: 0x001ED9A4
		public unsafe string Accessory6Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220652, XrefRangeEnd = 220656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x06006B6C RID: 27500 RVA: 0x001EF7DC File Offset: 0x001ED9DC
		public unsafe Color Accessory6Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220656, XrefRangeEnd = 220660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x001EF818 File Offset: 0x001EDA18
		public unsafe string Accessory7Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220660, XrefRangeEnd = 220664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x06006B6E RID: 27502 RVA: 0x001EF850 File Offset: 0x001EDA50
		public unsafe Color Accessory7Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220664, XrefRangeEnd = 220668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06006B6F RID: 27503 RVA: 0x001EF88C File Offset: 0x001EDA8C
		public unsafe string Accessory8Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220668, XrefRangeEnd = 220672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06006B70 RID: 27504 RVA: 0x001EF8C4 File Offset: 0x001EDAC4
		public unsafe Color Accessory8Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220672, XrefRangeEnd = 220676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x06006B71 RID: 27505 RVA: 0x001EF900 File Offset: 0x001EDB00
		public unsafe string Accessory9Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220676, XrefRangeEnd = 220680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x06006B72 RID: 27506 RVA: 0x001EF938 File Offset: 0x001EDB38
		public unsafe Color Accessory9Color
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220680, XrefRangeEnd = 220684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700211B RID: 8475
		public unsafe Il2CppSystem.Object this[string propertyName]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 220690, RefRangeEnd = 220693, XrefRangeStart = 220684, XrefRangeEnd = 220690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr_get_Item_Public_get_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x001EF9C4 File Offset: 0x001EDBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220693, XrefRangeEnd = 220694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarSettings.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x001EFA14 File Offset: 0x001EDC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220694, XrefRangeEnd = 220714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006B76 RID: 27510 RVA: 0x0003283D File Offset: 0x00030A3D
		public AvatarSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x06006B77 RID: 27511 RVA: 0x001EFA50 File Offset: 0x001EDC50
		// (set) Token: 0x06006B78 RID: 27512 RVA: 0x00032846 File Offset: 0x00030A46
		public unsafe Color SkinColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_SkinColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_SkinColor)) = value;
			}
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x06006B79 RID: 27513 RVA: 0x001EFA78 File Offset: 0x001EDC78
		// (set) Token: 0x06006B7A RID: 27514 RVA: 0x00032861 File Offset: 0x00030A61
		public unsafe float Height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Height)) = value;
			}
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x06006B7B RID: 27515 RVA: 0x001EFAA0 File Offset: 0x001EDCA0
		// (set) Token: 0x06006B7C RID: 27516 RVA: 0x0003287C File Offset: 0x00030A7C
		public unsafe float Gender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Gender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Gender)) = value;
			}
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x06006B7D RID: 27517 RVA: 0x001EFAC8 File Offset: 0x001EDCC8
		// (set) Token: 0x06006B7E RID: 27518 RVA: 0x00032897 File Offset: 0x00030A97
		public unsafe float Weight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Weight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_Weight)) = value;
			}
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x06006B7F RID: 27519 RVA: 0x001EFAF0 File Offset: 0x001EDCF0
		// (set) Token: 0x06006B80 RID: 27520 RVA: 0x000328B2 File Offset: 0x00030AB2
		public unsafe string HairPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x06006B81 RID: 27521 RVA: 0x001EFB18 File Offset: 0x001EDD18
		// (set) Token: 0x06006B82 RID: 27522 RVA: 0x000328D1 File Offset: 0x00030AD1
		public unsafe Color HairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_HairColor)) = value;
			}
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x06006B83 RID: 27523 RVA: 0x001EFB40 File Offset: 0x001EDD40
		// (set) Token: 0x06006B84 RID: 27524 RVA: 0x000328EC File Offset: 0x00030AEC
		public unsafe float EyebrowScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowScale)) = value;
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x06006B85 RID: 27525 RVA: 0x001EFB68 File Offset: 0x001EDD68
		// (set) Token: 0x06006B86 RID: 27526 RVA: 0x00032907 File Offset: 0x00030B07
		public unsafe float EyebrowThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowThickness)) = value;
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x06006B87 RID: 27527 RVA: 0x001EFB90 File Offset: 0x001EDD90
		// (set) Token: 0x06006B88 RID: 27528 RVA: 0x00032922 File Offset: 0x00030B22
		public unsafe float EyebrowRestingHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingHeight)) = value;
			}
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x06006B89 RID: 27529 RVA: 0x001EFBB8 File Offset: 0x001EDDB8
		// (set) Token: 0x06006B8A RID: 27530 RVA: 0x0003293D File Offset: 0x00030B3D
		public unsafe float EyebrowRestingAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyebrowRestingAngle)) = value;
			}
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x06006B8B RID: 27531 RVA: 0x001EFBE0 File Offset: 0x001EDDE0
		// (set) Token: 0x06006B8C RID: 27532 RVA: 0x00032958 File Offset: 0x00030B58
		public unsafe Color LeftEyeLidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeLidColor)) = value;
			}
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x06006B8D RID: 27533 RVA: 0x001EFC08 File Offset: 0x001EDE08
		// (set) Token: 0x06006B8E RID: 27534 RVA: 0x00032973 File Offset: 0x00030B73
		public unsafe Color RightEyeLidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeLidColor)) = value;
			}
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x06006B8F RID: 27535 RVA: 0x001EFC30 File Offset: 0x001EDE30
		// (set) Token: 0x06006B90 RID: 27536 RVA: 0x0003298E File Offset: 0x00030B8E
		public unsafe Eye.EyeLidConfiguration LeftEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_LeftEyeRestingState)) = value;
			}
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x06006B91 RID: 27537 RVA: 0x001EFC58 File Offset: 0x001EDE58
		// (set) Token: 0x06006B92 RID: 27538 RVA: 0x000329A9 File Offset: 0x00030BA9
		public unsafe Eye.EyeLidConfiguration RightEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_RightEyeRestingState)) = value;
			}
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x06006B93 RID: 27539 RVA: 0x001EFC80 File Offset: 0x001EDE80
		// (set) Token: 0x06006B94 RID: 27540 RVA: 0x000329C4 File Offset: 0x00030BC4
		public unsafe string EyeballMaterialIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeballMaterialIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x06006B95 RID: 27541 RVA: 0x001EFCA8 File Offset: 0x001EDEA8
		// (set) Token: 0x06006B96 RID: 27542 RVA: 0x000329E3 File Offset: 0x00030BE3
		public unsafe Color EyeBallTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeBallTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_EyeBallTint)) = value;
			}
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x06006B97 RID: 27543 RVA: 0x001EFCD0 File Offset: 0x001EDED0
		// (set) Token: 0x06006B98 RID: 27544 RVA: 0x000329FE File Offset: 0x00030BFE
		public unsafe float PupilDilation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x06006B99 RID: 27545 RVA: 0x001EFCF8 File Offset: 0x001EDEF8
		// (set) Token: 0x06006B9A RID: 27546 RVA: 0x00032A19 File Offset: 0x00030C19
		public unsafe List<AvatarSettings.LayerSetting> FaceLayerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.LayerSetting>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_FaceLayerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x06006B9B RID: 27547 RVA: 0x001EFD28 File Offset: 0x001EDF28
		// (set) Token: 0x06006B9C RID: 27548 RVA: 0x00032A38 File Offset: 0x00030C38
		public unsafe List<AvatarSettings.LayerSetting> BodyLayerSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.LayerSetting>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_BodyLayerSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x06006B9D RID: 27549 RVA: 0x001EFD58 File Offset: 0x001EDF58
		// (set) Token: 0x06006B9E RID: 27550 RVA: 0x00032A57 File Offset: 0x00030C57
		public unsafe List<AvatarSettings.AccessorySetting> AccessorySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_AccessorySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarSettings.AccessorySetting>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_AccessorySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x06006B9F RID: 27551 RVA: 0x001EFD88 File Offset: 0x001EDF88
		// (set) Token: 0x06006BA0 RID: 27552 RVA: 0x00032A76 File Offset: 0x00030C76
		public unsafe bool UseCombinedLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_UseCombinedLayer)) = value;
			}
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x06006BA1 RID: 27553 RVA: 0x001EFDB0 File Offset: 0x001EDFB0
		// (set) Token: 0x06006BA2 RID: 27554 RVA: 0x00032A91 File Offset: 0x00030C91
		public unsafe AvatarLayer CombinedLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_CombinedLayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarLayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_CombinedLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x06006BA3 RID: 27555 RVA: 0x001EFDE0 File Offset: 0x001EDFE0
		// (set) Token: 0x06006BA4 RID: 27556 RVA: 0x00032AB0 File Offset: 0x00030CB0
		public unsafe Texture2D ImpostorTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_ImpostorTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.NativeFieldInfoPtr_ImpostorTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049C6 RID: 18886
		private static readonly IntPtr NativeFieldInfoPtr_SkinColor;

		// Token: 0x040049C7 RID: 18887
		private static readonly IntPtr NativeFieldInfoPtr_Height;

		// Token: 0x040049C8 RID: 18888
		private static readonly IntPtr NativeFieldInfoPtr_Gender;

		// Token: 0x040049C9 RID: 18889
		private static readonly IntPtr NativeFieldInfoPtr_Weight;

		// Token: 0x040049CA RID: 18890
		private static readonly IntPtr NativeFieldInfoPtr_HairPath;

		// Token: 0x040049CB RID: 18891
		private static readonly IntPtr NativeFieldInfoPtr_HairColor;

		// Token: 0x040049CC RID: 18892
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowScale;

		// Token: 0x040049CD RID: 18893
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowThickness;

		// Token: 0x040049CE RID: 18894
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingHeight;

		// Token: 0x040049CF RID: 18895
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowRestingAngle;

		// Token: 0x040049D0 RID: 18896
		private static readonly IntPtr NativeFieldInfoPtr_LeftEyeLidColor;

		// Token: 0x040049D1 RID: 18897
		private static readonly IntPtr NativeFieldInfoPtr_RightEyeLidColor;

		// Token: 0x040049D2 RID: 18898
		private static readonly IntPtr NativeFieldInfoPtr_LeftEyeRestingState;

		// Token: 0x040049D3 RID: 18899
		private static readonly IntPtr NativeFieldInfoPtr_RightEyeRestingState;

		// Token: 0x040049D4 RID: 18900
		private static readonly IntPtr NativeFieldInfoPtr_EyeballMaterialIdentifier;

		// Token: 0x040049D5 RID: 18901
		private static readonly IntPtr NativeFieldInfoPtr_EyeBallTint;

		// Token: 0x040049D6 RID: 18902
		private static readonly IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x040049D7 RID: 18903
		private static readonly IntPtr NativeFieldInfoPtr_FaceLayerSettings;

		// Token: 0x040049D8 RID: 18904
		private static readonly IntPtr NativeFieldInfoPtr_BodyLayerSettings;

		// Token: 0x040049D9 RID: 18905
		private static readonly IntPtr NativeFieldInfoPtr_AccessorySettings;

		// Token: 0x040049DA RID: 18906
		private static readonly IntPtr NativeFieldInfoPtr_UseCombinedLayer;

		// Token: 0x040049DB RID: 18907
		private static readonly IntPtr NativeFieldInfoPtr_CombinedLayer;

		// Token: 0x040049DC RID: 18908
		private static readonly IntPtr NativeFieldInfoPtr_ImpostorTexture;

		// Token: 0x040049DD RID: 18909
		private static readonly IntPtr NativeMethodInfoPtr_get_UpperEyelidRestingPosition_Public_get_Single_0;

		// Token: 0x040049DE RID: 18910
		private static readonly IntPtr NativeMethodInfoPtr_get_LowerEyelidRestingPosition_Public_get_Single_0;

		// Token: 0x040049DF RID: 18911
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer1Path_Public_get_String_0;

		// Token: 0x040049E0 RID: 18912
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer1Color_Public_get_Color_0;

		// Token: 0x040049E1 RID: 18913
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer2Path_Public_get_String_0;

		// Token: 0x040049E2 RID: 18914
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer2Color_Public_get_Color_0;

		// Token: 0x040049E3 RID: 18915
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer3Path_Public_get_String_0;

		// Token: 0x040049E4 RID: 18916
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer3Color_Public_get_Color_0;

		// Token: 0x040049E5 RID: 18917
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer4Path_Public_get_String_0;

		// Token: 0x040049E6 RID: 18918
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer4Color_Public_get_Color_0;

		// Token: 0x040049E7 RID: 18919
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer5Path_Public_get_String_0;

		// Token: 0x040049E8 RID: 18920
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer5Color_Public_get_Color_0;

		// Token: 0x040049E9 RID: 18921
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer6Path_Public_get_String_0;

		// Token: 0x040049EA RID: 18922
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceLayer6Color_Public_get_Color_0;

		// Token: 0x040049EB RID: 18923
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer1Path_Public_get_String_0;

		// Token: 0x040049EC RID: 18924
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer1Color_Public_get_Color_0;

		// Token: 0x040049ED RID: 18925
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer2Path_Public_get_String_0;

		// Token: 0x040049EE RID: 18926
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer2Color_Public_get_Color_0;

		// Token: 0x040049EF RID: 18927
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer3Path_Public_get_String_0;

		// Token: 0x040049F0 RID: 18928
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer3Color_Public_get_Color_0;

		// Token: 0x040049F1 RID: 18929
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer4Path_Public_get_String_0;

		// Token: 0x040049F2 RID: 18930
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer4Color_Public_get_Color_0;

		// Token: 0x040049F3 RID: 18931
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer5Path_Public_get_String_0;

		// Token: 0x040049F4 RID: 18932
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer5Color_Public_get_Color_0;

		// Token: 0x040049F5 RID: 18933
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer6Path_Public_get_String_0;

		// Token: 0x040049F6 RID: 18934
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer6Color_Public_get_Color_0;

		// Token: 0x040049F7 RID: 18935
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer7Path_Public_get_String_0;

		// Token: 0x040049F8 RID: 18936
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer7Color_Public_get_Color_0;

		// Token: 0x040049F9 RID: 18937
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer8Path_Public_get_String_0;

		// Token: 0x040049FA RID: 18938
		private static readonly IntPtr NativeMethodInfoPtr_get_BodyLayer8Color_Public_get_Color_0;

		// Token: 0x040049FB RID: 18939
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory1Path_Public_get_String_0;

		// Token: 0x040049FC RID: 18940
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory1Color_Public_get_Color_0;

		// Token: 0x040049FD RID: 18941
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory2Path_Public_get_String_0;

		// Token: 0x040049FE RID: 18942
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory2Color_Public_get_Color_0;

		// Token: 0x040049FF RID: 18943
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory3Path_Public_get_String_0;

		// Token: 0x04004A00 RID: 18944
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory3Color_Public_get_Color_0;

		// Token: 0x04004A01 RID: 18945
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory4Path_Public_get_String_0;

		// Token: 0x04004A02 RID: 18946
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory4Color_Public_get_Color_0;

		// Token: 0x04004A03 RID: 18947
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory5Path_Public_get_String_0;

		// Token: 0x04004A04 RID: 18948
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory5Color_Public_get_Color_0;

		// Token: 0x04004A05 RID: 18949
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory6Path_Public_get_String_0;

		// Token: 0x04004A06 RID: 18950
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory6Color_Public_get_Color_0;

		// Token: 0x04004A07 RID: 18951
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory7Path_Public_get_String_0;

		// Token: 0x04004A08 RID: 18952
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory7Color_Public_get_Color_0;

		// Token: 0x04004A09 RID: 18953
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory8Path_Public_get_String_0;

		// Token: 0x04004A0A RID: 18954
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory8Color_Public_get_Color_0;

		// Token: 0x04004A0B RID: 18955
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory9Path_Public_get_String_0;

		// Token: 0x04004A0C RID: 18956
		private static readonly IntPtr NativeMethodInfoPtr_get_Accessory9Color_Public_get_Color_0;

		// Token: 0x04004A0D RID: 18957
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_String_0;

		// Token: 0x04004A0E RID: 18958
		private static readonly IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;

		// Token: 0x04004A0F RID: 18959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B62 RID: 2914
		[Serializable]
		public sealed class LayerSetting : ValueType
		{
			// Token: 0x0600E83D RID: 59453 RVA: 0x00389004 File Offset: 0x00387204
			// Note: this type is marked as 'beforefieldinit'.
			static LayerSetting()
			{
				Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "LayerSetting");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr);
				AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr, "layerPath");
				AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr, "layerTint");
			}

			// Token: 0x0600E83E RID: 59454 RVA: 0x0006D850 File Offset: 0x0006BA50
			public LayerSetting(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E83F RID: 59455 RVA: 0x0006D859 File Offset: 0x0006BA59
			public LayerSetting() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings.LayerSetting>.NativeClassPtr))
			{
			}

			// Token: 0x17004678 RID: 18040
			// (get) Token: 0x0600E840 RID: 59456 RVA: 0x00389058 File Offset: 0x00387258
			// (set) Token: 0x0600E841 RID: 59457 RVA: 0x0006D86B File Offset: 0x0006BA6B
			public unsafe string layerPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004679 RID: 18041
			// (get) Token: 0x0600E842 RID: 59458 RVA: 0x00389080 File Offset: 0x00387280
			// (set) Token: 0x0600E843 RID: 59459 RVA: 0x0006D88A File Offset: 0x0006BA8A
			public unsafe Color layerTint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.LayerSetting.NativeFieldInfoPtr_layerTint)) = value;
				}
			}

			// Token: 0x04009D8C RID: 40332
			private static readonly IntPtr NativeFieldInfoPtr_layerPath;

			// Token: 0x04009D8D RID: 40333
			private static readonly IntPtr NativeFieldInfoPtr_layerTint;
		}

		// Token: 0x02000B63 RID: 2915
		[Serializable]
		public class AccessorySetting : Il2CppSystem.Object
		{
			// Token: 0x0600E844 RID: 59460 RVA: 0x003890A8 File Offset: 0x003872A8
			// Note: this type is marked as 'beforefieldinit'.
			static AccessorySetting()
			{
				Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSettings>.NativeClassPtr, "AccessorySetting");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr);
				AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, "path");
				AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, "color");
				AvatarSettings.AccessorySetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr, 100677376);
			}

			// Token: 0x0600E845 RID: 59461 RVA: 0x00389110 File Offset: 0x00387310
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccessorySetting() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSettings.AccessorySetting>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSettings.AccessorySetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E846 RID: 59462 RVA: 0x0006D8A5 File Offset: 0x0006BAA5
			public AccessorySetting(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700467A RID: 18042
			// (get) Token: 0x0600E847 RID: 59463 RVA: 0x0038914C File Offset: 0x0038734C
			// (set) Token: 0x0600E848 RID: 59464 RVA: 0x0006D8AE File Offset: 0x0006BAAE
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700467B RID: 18043
			// (get) Token: 0x0600E849 RID: 59465 RVA: 0x00389174 File Offset: 0x00387374
			// (set) Token: 0x0600E84A RID: 59466 RVA: 0x0006D8CD File Offset: 0x0006BACD
			public unsafe Color color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSettings.AccessorySetting.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04009D8E RID: 40334
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04009D8F RID: 40335
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04009D90 RID: 40336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}

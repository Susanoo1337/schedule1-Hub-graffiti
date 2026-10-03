using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.AvatarFramework.Emotions;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.AvatarFramework.Impostors;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000494 RID: 1172
	public class Avatar : MonoBehaviour
	{
		// Token: 0x06006A17 RID: 27159 RVA: 0x001EACB0 File Offset: 0x001E8EB0
		// Note: this type is marked as 'beforefieldinit'.
		static Avatar()
		{
			Il2CppClassPointerStore<Avatar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Avatar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar>.NativeClassPtr);
			Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MAX_ACCESSORIES");
			Avatar.NativeFieldInfoPtr_CombinedLayersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "CombinedLayersEnabled");
			Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "DEFAULT_SMOOTHNESS");
			Avatar.NativeFieldInfoPtr_maleShoulderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "maleShoulderScale");
			Avatar.NativeFieldInfoPtr_femaleShoulderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "femaleShoulderScale");
			Avatar.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Animation");
			Avatar.NativeFieldInfoPtr_LookController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LookController");
			Avatar.NativeFieldInfoPtr_BodyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "BodyMeshes");
			Avatar.NativeFieldInfoPtr_ShapeKeyMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "ShapeKeyMeshes");
			Avatar.NativeFieldInfoPtr_FaceMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "FaceMesh");
			Avatar.NativeFieldInfoPtr_Eyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Eyes");
			Avatar.NativeFieldInfoPtr_EyeBrows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "EyeBrows");
			Avatar.NativeFieldInfoPtr_BodyContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "BodyContainer");
			Avatar.NativeFieldInfoPtr_Armature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Armature");
			Avatar.NativeFieldInfoPtr_LeftShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LeftShoulder");
			Avatar.NativeFieldInfoPtr_RightShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RightShoulder");
			Avatar.NativeFieldInfoPtr_HeadBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "HeadBone");
			Avatar.NativeFieldInfoPtr_HipBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "HipBone");
			Avatar.NativeFieldInfoPtr_LeftFootBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LeftFootBone");
			Avatar.NativeFieldInfoPtr_RightFootBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RightFootBone");
			Avatar.NativeFieldInfoPtr_RagdollRBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RagdollRBs");
			Avatar.NativeFieldInfoPtr_RagdollColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "RagdollColliders");
			Avatar.NativeFieldInfoPtr_MiddleSpineRB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MiddleSpineRB");
			Avatar.NativeFieldInfoPtr_ImpactForceRBs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "ImpactForceRBs");
			Avatar.NativeFieldInfoPtr_EmotionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "EmotionManager");
			Avatar.NativeFieldInfoPtr_Effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Effects");
			Avatar.NativeFieldInfoPtr_MiddleSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "MiddleSpine");
			Avatar.NativeFieldInfoPtr_LowerSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LowerSpine");
			Avatar.NativeFieldInfoPtr_LowestSpine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "LowestSpine");
			Avatar.NativeFieldInfoPtr_Impostor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "Impostor");
			Avatar.NativeFieldInfoPtr_BloodParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "BloodParticles");
			Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "DefaultAvatarMaterial");
			Avatar.NativeFieldInfoPtr_UseCombinedLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "UseCombinedLayer");
			Avatar.NativeFieldInfoPtr_onRagdollChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "onRagdollChange");
			Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<Ragdolled>k__BackingField");
			Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<CurrentEquippable>k__BackingField");
			Avatar.NativeFieldInfoPtr_appliedGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedGender");
			Avatar.NativeFieldInfoPtr_appliedWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedWeight");
			Avatar.NativeFieldInfoPtr_appliedHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedHair");
			Avatar.NativeFieldInfoPtr_appliedHairColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedHairColor");
			Avatar.NativeFieldInfoPtr_appliedAccessories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "appliedAccessories");
			Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "wearingHairBlockingAccessory");
			Avatar.NativeFieldInfoPtr_additionalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "additionalWeight");
			Avatar.NativeFieldInfoPtr_additionalGender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "additionalGender");
			Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<CurrentSettings>k__BackingField");
			Avatar.NativeFieldInfoPtr_onSettingsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "onSettingsLoaded");
			Avatar.NativeFieldInfoPtr_originalHipPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "originalHipPos");
			Avatar.NativeFieldInfoPtr_usingCombinedLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "usingCombinedLayer");
			Avatar.NativeFieldInfoPtr_blockEyeFaceLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "blockEyeFaceLayers");
			Avatar.NativeFieldInfoPtr__appliedSkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "_appliedSkinColor");
			Avatar.NativeFieldInfoPtr__appliedEmissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "_appliedEmissionColor");
			Avatar.NativeMethodInfoPtr_get_RightHandContainer_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677196);
			Avatar.NativeMethodInfoPtr_get_LeftHandContainer_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677197);
			Avatar.NativeMethodInfoPtr_get_RightHandAlignmentPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677198);
			Avatar.NativeMethodInfoPtr_get_LeftHandAlignmentPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677199);
			Avatar.NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677200);
			Avatar.NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677201);
			Avatar.NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677202);
			Avatar.NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677203);
			Avatar.NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677204);
			Avatar.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677205);
			Avatar.NativeMethodInfoPtr_get_CenterPointTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677206);
			Avatar.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677207);
			Avatar.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677208);
			Avatar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677209);
			Avatar.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677210);
			Avatar.NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677211);
			Avatar.NativeMethodInfoPtr_SetEmission_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677212);
			Avatar.NativeMethodInfoPtr_IsMale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677213);
			Avatar.NativeMethodInfoPtr_IsWhite_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677214);
			Avatar.NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677215);
			Avatar.NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677216);
			Avatar.NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677217);
			Avatar.NativeMethodInfoPtr_SetAnimationBool_Public_Virtual_Final_New_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677218);
			Avatar.NativeMethodInfoPtr_SetAnimationTrigger_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677219);
			Avatar.NativeMethodInfoPtr_ApplyCurrentShapeKeys_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677220);
			Avatar.NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677221);
			Avatar.NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677222);
			Avatar.NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677223);
			Avatar.NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677224);
			Avatar.NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677225);
			Avatar.NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677226);
			Avatar.NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677227);
			Avatar.NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677228);
			Avatar.NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677229);
			Avatar.NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677230);
			Avatar.NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677231);
			Avatar.NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677232);
			Avatar.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677233);
			Avatar.NativeMethodInfoPtr_ResetHairColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677234);
			Avatar.NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677235);
			Avatar.NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677236);
			Avatar.NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677237);
			Avatar.NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677238);
			Avatar.NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677239);
			Avatar.NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677240);
			Avatar.NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677241);
			Avatar.NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677242);
			Avatar.NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677243);
			Avatar.NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677244);
			Avatar.NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677245);
			Avatar.NativeMethodInfoPtr_DestroyAccessories_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677246);
			Avatar.NativeMethodInfoPtr_EnableRagdoll_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677247);
			Avatar.NativeMethodInfoPtr_DisableRagdoll_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677248);
			Avatar.NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Private_Void_Boolean_Boolean_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677249);
			Avatar.NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677250);
			Avatar.NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677251);
			Avatar.NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677252);
			Avatar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100677253);
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x06006A18 RID: 27160 RVA: 0x001EB564 File Offset: 0x001E9764
		public unsafe virtual Transform RightHandContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_RightHandContainer_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x06006A19 RID: 27161 RVA: 0x001EB5A4 File Offset: 0x001E97A4
		public unsafe virtual Transform LeftHandContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_LeftHandContainer_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x06006A1A RID: 27162 RVA: 0x001EB5E4 File Offset: 0x001E97E4
		public unsafe virtual Transform RightHandAlignmentPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_RightHandAlignmentPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x06006A1B RID: 27163 RVA: 0x001EB624 File Offset: 0x001E9824
		public unsafe virtual Transform LeftHandAlignmentPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_LeftHandAlignmentPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06006A1C RID: 27164 RVA: 0x001EB664 File Offset: 0x001E9864
		// (set) Token: 0x06006A1D RID: 27165 RVA: 0x001EB6A0 File Offset: 0x001E98A0
		public unsafe bool Ragdolled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06006A1E RID: 27166 RVA: 0x001EB6E0 File Offset: 0x001E98E0
		// (set) Token: 0x06006A1F RID: 27167 RVA: 0x001EB720 File Offset: 0x001E9920
		public unsafe AvatarEquippable CurrentEquippable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219024, XrefRangeEnd = 219025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x06006A20 RID: 27168 RVA: 0x001EB764 File Offset: 0x001E9964
		// (set) Token: 0x06006A21 RID: 27169 RVA: 0x001EB7A4 File Offset: 0x001E99A4
		public unsafe AvatarSettings CurrentSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x06006A22 RID: 27170 RVA: 0x001EB7E8 File Offset: 0x001E99E8
		public unsafe Transform CenterPointTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CenterPointTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x06006A23 RID: 27171 RVA: 0x001EB828 File Offset: 0x001E9A28
		public unsafe Vector3 CenterPoint
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 219027, RefRangeEnd = 219091, XrefRangeStart = 219025, XrefRangeEnd = 219027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x001EB864 File Offset: 0x001E9A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219091, XrefRangeEnd = 219101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x001EB8A0 File Offset: 0x001E9AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219101, XrefRangeEnd = 219106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A26 RID: 27174 RVA: 0x001EB8DC File Offset: 0x001E9ADC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 219110, RefRangeEnd = 219116, XrefRangeStart = 219106, XrefRangeEnd = 219110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x001EB91C File Offset: 0x001E9B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219116, XrefRangeEnd = 219121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMugshot(Action<Texture2D> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x001EB960 File Offset: 0x001E9B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219121, XrefRangeEnd = 219129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEmission(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetEmission_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x001EB9A0 File Offset: 0x001E9BA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 219133, RefRangeEnd = 219137, XrefRangeStart = 219129, XrefRangeEnd = 219133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_IsMale_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x001EB9DC File Offset: 0x001E9BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219137, XrefRangeEnd = 219141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWhite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_IsWhite_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x001EBA18 File Offset: 0x001E9C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219148, RefRangeEnd = 219149, XrefRangeStart = 219141, XrefRangeEnd = 219148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFormalAddress(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capitalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006A2C RID: 27180 RVA: 0x001EBA5C File Offset: 0x001E9C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219156, RefRangeEnd = 219157, XrefRangeStart = 219149, XrefRangeEnd = 219156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetThirdPersonAddress(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capitalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x001EBAA0 File Offset: 0x001E9CA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219164, RefRangeEnd = 219165, XrefRangeStart = 219157, XrefRangeEnd = 219164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetThirdPersonPronoun(bool capitalized = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capitalized;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006A2E RID: 27182 RVA: 0x001EBAE4 File Offset: 0x001E9CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219165, XrefRangeEnd = 219167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAnimationBool(string name, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetAnimationBool_Public_Virtual_Final_New_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A2F RID: 27183 RVA: 0x001EBB34 File Offset: 0x001E9D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219167, XrefRangeEnd = 219169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAnimationTrigger(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetAnimationTrigger_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x001EBB78 File Offset: 0x001E9D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219169, XrefRangeEnd = 219171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyCurrentShapeKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyCurrentShapeKeys_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A31 RID: 27185 RVA: 0x001EBBAC File Offset: 0x001E9DAC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 219198, RefRangeEnd = 219206, XrefRangeStart = 219171, XrefRangeEnd = 219198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyShapeKeys(float gender, float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gender;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A32 RID: 27186 RVA: 0x001EBBF8 File Offset: 0x001E9DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219206, XrefRangeEnd = 219210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFeetShrunk(bool shrink, float reduction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shrink;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reduction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x001EBC44 File Offset: 0x001E9E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219210, XrefRangeEnd = 219214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWearingHairBlockingAccessory(bool blocked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blocked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x001EBC84 File Offset: 0x001E9E84
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 219253, RefRangeEnd = 219269, XrefRangeStart = 219214, XrefRangeEnd = 219253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAvatarSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x001EBCC8 File Offset: 0x001E9EC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 219309, RefRangeEnd = 219313, XrefRangeStart = 219269, XrefRangeEnd = 219309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadNakedSettings(AvatarSettings settings, bool keepOldLayers, int maxLayerOrder = 19)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keepOldLayers;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLayerOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x001EBD28 File Offset: 0x001E9F28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 219317, RefRangeEnd = 219322, XrefRangeStart = 219313, XrefRangeEnd = 219317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyBodySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x001EBD6C File Offset: 0x001E9F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219322, XrefRangeEnd = 219324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAdditionalWeight(float weight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A38 RID: 27192 RVA: 0x001EBDAC File Offset: 0x001E9FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219324, XrefRangeEnd = 219326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAdditionalGender(float gender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gender;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A39 RID: 27193 RVA: 0x001EBDEC File Offset: 0x001E9FEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219348, RefRangeEnd = 219349, XrefRangeStart = 219326, XrefRangeEnd = 219348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSkinColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x001EBE2C File Offset: 0x001EA02C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 219375, RefRangeEnd = 219381, XrefRangeStart = 219349, XrefRangeEnd = 219375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyHairSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x001EBE70 File Offset: 0x001EA070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219387, RefRangeEnd = 219389, XrefRangeStart = 219381, XrefRangeEnd = 219387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHairVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x001EBEB0 File Offset: 0x001EA0B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 219397, RefRangeEnd = 219402, XrefRangeStart = 219389, XrefRangeEnd = 219397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyHairColorSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A3D RID: 27197 RVA: 0x001EBEF4 File Offset: 0x001EA0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219402, XrefRangeEnd = 219416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideHairColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x001EBF34 File Offset: 0x001EA134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219430, RefRangeEnd = 219431, XrefRangeStart = 219416, XrefRangeEnd = 219430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHairColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ResetHairColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x001EBF68 File Offset: 0x001EA168
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 219435, RefRangeEnd = 219439, XrefRangeStart = 219431, XrefRangeEnd = 219435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeBallSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A40 RID: 27200 RVA: 0x001EBFAC File Offset: 0x001EA1AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 219441, RefRangeEnd = 219445, XrefRangeStart = 219439, XrefRangeEnd = 219441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeLidSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A41 RID: 27201 RVA: 0x001EBFF0 File Offset: 0x001EA1F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 219453, RefRangeEnd = 219457, XrefRangeStart = 219445, XrefRangeEnd = 219453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyeLidColorSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x001EC034 File Offset: 0x001EA234
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 219459, RefRangeEnd = 219463, XrefRangeStart = 219457, XrefRangeEnd = 219459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEyebrowSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x001EC078 File Offset: 0x001EA278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219468, RefRangeEnd = 219469, XrefRangeStart = 219463, XrefRangeEnd = 219468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlockEyeFaceLayers(bool block)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x001EC0B8 File Offset: 0x001EA2B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 219563, RefRangeEnd = 219570, XrefRangeStart = 219469, XrefRangeEnd = 219563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFaceLayerSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x001EC0FC File Offset: 0x001EA2FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 219598, RefRangeEnd = 219606, XrefRangeStart = 219570, XrefRangeEnd = 219598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceLayer(int index, string assetPath, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x001EC15C File Offset: 0x001EA35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219606, XrefRangeEnd = 219621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceTexture(Texture2D tex, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x001EC1AC File Offset: 0x001EA3AC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 219706, RefRangeEnd = 219713, XrefRangeStart = 219621, XrefRangeEnd = 219706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyBodyLayerSettings(AvatarSettings settings, int maxOrder = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x001EC1FC File Offset: 0x001EA3FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219762, RefRangeEnd = 219764, XrefRangeStart = 219713, XrefRangeEnd = 219762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBodyLayer(int index, string assetPath, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x001EC25C File Offset: 0x001EA45C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 219840, RefRangeEnd = 219843, XrefRangeStart = 219764, XrefRangeEnd = 219840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAccessorySettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x001EC2A0 File Offset: 0x001EA4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219843, XrefRangeEnd = 219852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyAccessories()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_DestroyAccessories_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x001EC2D4 File Offset: 0x001EA4D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219867, RefRangeEnd = 219869, XrefRangeStart = 219852, XrefRangeEnd = 219867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableRagdoll(Vector3 forcePoint = default(Vector3), Vector3 forceDir = default(Vector3))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_EnableRagdoll_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x001EC320 File Offset: 0x001EA520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219879, RefRangeEnd = 219881, XrefRangeStart = 219869, XrefRangeEnd = 219879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableRagdoll(bool playStandUpAnim = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref playStandUpAnim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_DisableRagdoll_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x001EC360 File Offset: 0x001EA560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219881, XrefRangeEnd = 219897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRagdollPhysicsEnabled(bool ragdollEnabled, bool wait, bool playStandUpAnim = true, Vector3 forcePoint = default(Vector3), Vector3 forceDir = default(Vector3))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ragdollEnabled;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wait;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playStandUpAnim;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Private_Void_Boolean_Boolean_Boolean_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x001EC3D8 File Offset: 0x001EA5D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 219914, RefRangeEnd = 219917, XrefRangeStart = 219897, XrefRangeEnd = 219914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRagdollForce(Vector3 forcePoint, Vector3 forceDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref forcePoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x001EC424 File Offset: 0x001EA624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219917, XrefRangeEnd = 219941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AvatarEquippable SetEquippable(string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x001EC480 File Offset: 0x001EA680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219941, XrefRangeEnd = 219952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReceiveEquippableMessage(string message, Il2CppSystem.Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Avatar.NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x001EC4E0 File Offset: 0x001EA6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219952, XrefRangeEnd = 219959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Avatar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A52 RID: 27218 RVA: 0x00031D5F File Offset: 0x0002FF5F
		public Avatar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700206C RID: 8300
		// (get) Token: 0x06006A53 RID: 27219 RVA: 0x001EC51C File Offset: 0x001EA71C
		// (set) Token: 0x06006A54 RID: 27220 RVA: 0x00031D68 File Offset: 0x0002FF68
		public unsafe static int MAX_ACCESSORIES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_MAX_ACCESSORIES, (void*)(&value));
			}
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x06006A55 RID: 27221 RVA: 0x001EC538 File Offset: 0x001EA738
		// (set) Token: 0x06006A56 RID: 27222 RVA: 0x00031D76 File Offset: 0x0002FF76
		public unsafe static bool CombinedLayersEnabled
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_CombinedLayersEnabled, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_CombinedLayersEnabled, (void*)(&value));
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x06006A57 RID: 27223 RVA: 0x001EC554 File Offset: 0x001EA754
		// (set) Token: 0x06006A58 RID: 27224 RVA: 0x00031D84 File Offset: 0x0002FF84
		public unsafe static float DEFAULT_SMOOTHNESS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_DEFAULT_SMOOTHNESS, (void*)(&value));
			}
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x06006A59 RID: 27225 RVA: 0x001EC570 File Offset: 0x001EA770
		// (set) Token: 0x06006A5A RID: 27226 RVA: 0x00031D92 File Offset: 0x0002FF92
		public unsafe static float maleShoulderScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_maleShoulderScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_maleShoulderScale, (void*)(&value));
			}
		}

		// Token: 0x17002070 RID: 8304
		// (get) Token: 0x06006A5B RID: 27227 RVA: 0x001EC58C File Offset: 0x001EA78C
		// (set) Token: 0x06006A5C RID: 27228 RVA: 0x00031DA0 File Offset: 0x0002FFA0
		public unsafe static float femaleShoulderScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Avatar.NativeFieldInfoPtr_femaleShoulderScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Avatar.NativeFieldInfoPtr_femaleShoulderScale, (void*)(&value));
			}
		}

		// Token: 0x17002071 RID: 8305
		// (get) Token: 0x06006A5D RID: 27229 RVA: 0x001EC5A8 File Offset: 0x001EA7A8
		// (set) Token: 0x06006A5E RID: 27230 RVA: 0x00031DAE File Offset: 0x0002FFAE
		public unsafe AvatarAnimation Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002072 RID: 8306
		// (get) Token: 0x06006A5F RID: 27231 RVA: 0x001EC5D8 File Offset: 0x001EA7D8
		// (set) Token: 0x06006A60 RID: 27232 RVA: 0x00031DCD File Offset: 0x0002FFCD
		public unsafe AvatarLookController LookController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LookController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarLookController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LookController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x06006A61 RID: 27233 RVA: 0x001EC608 File Offset: 0x001EA808
		// (set) Token: 0x06006A62 RID: 27234 RVA: 0x00031DEC File Offset: 0x0002FFEC
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> BodyMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x06006A63 RID: 27235 RVA: 0x001EC638 File Offset: 0x001EA838
		// (set) Token: 0x06006A64 RID: 27236 RVA: 0x00031E0B File Offset: 0x0003000B
		public unsafe Il2CppReferenceArray<SkinnedMeshRenderer> ShapeKeyMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_ShapeKeyMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkinnedMeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_ShapeKeyMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06006A65 RID: 27237 RVA: 0x001EC668 File Offset: 0x001EA868
		// (set) Token: 0x06006A66 RID: 27238 RVA: 0x00031E2A File Offset: 0x0003002A
		public unsafe SkinnedMeshRenderer FaceMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_FaceMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_FaceMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06006A67 RID: 27239 RVA: 0x001EC698 File Offset: 0x001EA898
		// (set) Token: 0x06006A68 RID: 27240 RVA: 0x00031E49 File Offset: 0x00030049
		public unsafe EyeController Eyes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Eyes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Eyes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x06006A69 RID: 27241 RVA: 0x001EC6C8 File Offset: 0x001EA8C8
		// (set) Token: 0x06006A6A RID: 27242 RVA: 0x00031E68 File Offset: 0x00030068
		public unsafe EyebrowController EyeBrows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EyeBrows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyebrowController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EyeBrows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002078 RID: 8312
		// (get) Token: 0x06006A6B RID: 27243 RVA: 0x001EC6F8 File Offset: 0x001EA8F8
		// (set) Token: 0x06006A6C RID: 27244 RVA: 0x00031E87 File Offset: 0x00030087
		public unsafe Transform BodyContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BodyContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002079 RID: 8313
		// (get) Token: 0x06006A6D RID: 27245 RVA: 0x001EC728 File Offset: 0x001EA928
		// (set) Token: 0x06006A6E RID: 27246 RVA: 0x00031EA6 File Offset: 0x000300A6
		public unsafe Transform Armature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Armature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Armature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207A RID: 8314
		// (get) Token: 0x06006A6F RID: 27247 RVA: 0x001EC758 File Offset: 0x001EA958
		// (set) Token: 0x06006A70 RID: 27248 RVA: 0x00031EC5 File Offset: 0x000300C5
		public unsafe Transform LeftShoulder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LeftShoulder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LeftShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207B RID: 8315
		// (get) Token: 0x06006A71 RID: 27249 RVA: 0x001EC788 File Offset: 0x001EA988
		// (set) Token: 0x06006A72 RID: 27250 RVA: 0x00031EE4 File Offset: 0x000300E4
		public unsafe Transform RightShoulder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RightShoulder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RightShoulder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207C RID: 8316
		// (get) Token: 0x06006A73 RID: 27251 RVA: 0x001EC7B8 File Offset: 0x001EA9B8
		// (set) Token: 0x06006A74 RID: 27252 RVA: 0x00031F03 File Offset: 0x00030103
		public unsafe Transform HeadBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HeadBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HeadBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207D RID: 8317
		// (get) Token: 0x06006A75 RID: 27253 RVA: 0x001EC7E8 File Offset: 0x001EA9E8
		// (set) Token: 0x06006A76 RID: 27254 RVA: 0x00031F22 File Offset: 0x00030122
		public unsafe Transform HipBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HipBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_HipBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207E RID: 8318
		// (get) Token: 0x06006A77 RID: 27255 RVA: 0x001EC818 File Offset: 0x001EAA18
		// (set) Token: 0x06006A78 RID: 27256 RVA: 0x00031F41 File Offset: 0x00030141
		public unsafe Transform LeftFootBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LeftFootBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LeftFootBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x06006A79 RID: 27257 RVA: 0x001EC848 File Offset: 0x001EAA48
		// (set) Token: 0x06006A7A RID: 27258 RVA: 0x00031F60 File Offset: 0x00030160
		public unsafe Transform RightFootBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RightFootBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RightFootBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x06006A7B RID: 27259 RVA: 0x001EC878 File Offset: 0x001EAA78
		// (set) Token: 0x06006A7C RID: 27260 RVA: 0x00031F7F File Offset: 0x0003017F
		public unsafe Il2CppReferenceArray<Rigidbody> RagdollRBs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollRBs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Rigidbody>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollRBs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x06006A7D RID: 27261 RVA: 0x001EC8A8 File Offset: 0x001EAAA8
		// (set) Token: 0x06006A7E RID: 27262 RVA: 0x00031F9E File Offset: 0x0003019E
		public unsafe Il2CppReferenceArray<Collider> RagdollColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_RagdollColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x06006A7F RID: 27263 RVA: 0x001EC8D8 File Offset: 0x001EAAD8
		// (set) Token: 0x06006A80 RID: 27264 RVA: 0x00031FBD File Offset: 0x000301BD
		public unsafe Rigidbody MiddleSpineRB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpineRB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpineRB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x06006A81 RID: 27265 RVA: 0x001EC908 File Offset: 0x001EAB08
		// (set) Token: 0x06006A82 RID: 27266 RVA: 0x00031FDC File Offset: 0x000301DC
		public unsafe Il2CppReferenceArray<Rigidbody> ImpactForceRBs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_ImpactForceRBs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Rigidbody>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_ImpactForceRBs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x06006A83 RID: 27267 RVA: 0x001EC938 File Offset: 0x001EAB38
		// (set) Token: 0x06006A84 RID: 27268 RVA: 0x00031FFB File Offset: 0x000301FB
		public unsafe AvatarEmotionManager EmotionManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EmotionManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_EmotionManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x06006A85 RID: 27269 RVA: 0x001EC968 File Offset: 0x001EAB68
		// (set) Token: 0x06006A86 RID: 27270 RVA: 0x0003201A File Offset: 0x0003021A
		public unsafe AvatarEffects Effects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Effects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEffects>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Effects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x06006A87 RID: 27271 RVA: 0x001EC998 File Offset: 0x001EAB98
		// (set) Token: 0x06006A88 RID: 27272 RVA: 0x00032039 File Offset: 0x00030239
		public unsafe Transform MiddleSpine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_MiddleSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x06006A89 RID: 27273 RVA: 0x001EC9C8 File Offset: 0x001EABC8
		// (set) Token: 0x06006A8A RID: 27274 RVA: 0x00032058 File Offset: 0x00030258
		public unsafe Transform LowerSpine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowerSpine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowerSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x06006A8B RID: 27275 RVA: 0x001EC9F8 File Offset: 0x001EABF8
		// (set) Token: 0x06006A8C RID: 27276 RVA: 0x00032077 File Offset: 0x00030277
		public unsafe Transform LowestSpine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowestSpine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_LowestSpine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002089 RID: 8329
		// (get) Token: 0x06006A8D RID: 27277 RVA: 0x001ECA28 File Offset: 0x001EAC28
		// (set) Token: 0x06006A8E RID: 27278 RVA: 0x00032096 File Offset: 0x00030296
		public unsafe AvatarImpostor Impostor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Impostor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarImpostor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_Impostor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700208A RID: 8330
		// (get) Token: 0x06006A8F RID: 27279 RVA: 0x001ECA58 File Offset: 0x001EAC58
		// (set) Token: 0x06006A90 RID: 27280 RVA: 0x000320B5 File Offset: 0x000302B5
		public unsafe ParticleSystem BloodParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BloodParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_BloodParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700208B RID: 8331
		// (get) Token: 0x06006A91 RID: 27281 RVA: 0x001ECA88 File Offset: 0x001EAC88
		// (set) Token: 0x06006A92 RID: 27282 RVA: 0x000320D4 File Offset: 0x000302D4
		public unsafe Material DefaultAvatarMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_DefaultAvatarMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06006A93 RID: 27283 RVA: 0x001ECAB8 File Offset: 0x001EACB8
		// (set) Token: 0x06006A94 RID: 27284 RVA: 0x000320F3 File Offset: 0x000302F3
		public unsafe bool UseCombinedLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_UseCombinedLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_UseCombinedLayer)) = value;
			}
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06006A95 RID: 27285 RVA: 0x001ECAE0 File Offset: 0x001EACE0
		// (set) Token: 0x06006A96 RID: 27286 RVA: 0x0003210E File Offset: 0x0003030E
		public unsafe UnityEvent<bool, bool, bool> onRagdollChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onRagdollChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool, bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onRagdollChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700208E RID: 8334
		// (get) Token: 0x06006A97 RID: 27287 RVA: 0x001ECB10 File Offset: 0x001EAD10
		// (set) Token: 0x06006A98 RID: 27288 RVA: 0x0003212D File Offset: 0x0003032D
		public unsafe bool _Ragdolled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__Ragdolled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700208F RID: 8335
		// (get) Token: 0x06006A99 RID: 27289 RVA: 0x001ECB38 File Offset: 0x001EAD38
		// (set) Token: 0x06006A9A RID: 27290 RVA: 0x00032148 File Offset: 0x00030348
		public unsafe AvatarEquippable _CurrentEquippable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentEquippable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002090 RID: 8336
		// (get) Token: 0x06006A9B RID: 27291 RVA: 0x001ECB68 File Offset: 0x001EAD68
		// (set) Token: 0x06006A9C RID: 27292 RVA: 0x00032167 File Offset: 0x00030367
		public unsafe float appliedGender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedGender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedGender)) = value;
			}
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x06006A9D RID: 27293 RVA: 0x001ECB90 File Offset: 0x001EAD90
		// (set) Token: 0x06006A9E RID: 27294 RVA: 0x00032182 File Offset: 0x00030382
		public unsafe float appliedWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedWeight)) = value;
			}
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x06006A9F RID: 27295 RVA: 0x001ECBB8 File Offset: 0x001EADB8
		// (set) Token: 0x06006AA0 RID: 27296 RVA: 0x0003219D File Offset: 0x0003039D
		public unsafe Hair appliedHair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hair>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x06006AA1 RID: 27297 RVA: 0x001ECBE8 File Offset: 0x001EADE8
		// (set) Token: 0x06006AA2 RID: 27298 RVA: 0x000321BC File Offset: 0x000303BC
		public unsafe Color appliedHairColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHairColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedHairColor)) = value;
			}
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x06006AA3 RID: 27299 RVA: 0x001ECC10 File Offset: 0x001EAE10
		// (set) Token: 0x06006AA4 RID: 27300 RVA: 0x000321D7 File Offset: 0x000303D7
		public unsafe Il2CppReferenceArray<Accessory> appliedAccessories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedAccessories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Accessory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_appliedAccessories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x06006AA5 RID: 27301 RVA: 0x001ECC40 File Offset: 0x001EAE40
		// (set) Token: 0x06006AA6 RID: 27302 RVA: 0x000321F6 File Offset: 0x000303F6
		public unsafe bool wearingHairBlockingAccessory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_wearingHairBlockingAccessory)) = value;
			}
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x06006AA7 RID: 27303 RVA: 0x001ECC68 File Offset: 0x001EAE68
		// (set) Token: 0x06006AA8 RID: 27304 RVA: 0x00032211 File Offset: 0x00030411
		public unsafe float additionalWeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalWeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalWeight)) = value;
			}
		}

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x06006AA9 RID: 27305 RVA: 0x001ECC90 File Offset: 0x001EAE90
		// (set) Token: 0x06006AAA RID: 27306 RVA: 0x0003222C File Offset: 0x0003042C
		public unsafe float additionalGender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalGender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_additionalGender)) = value;
			}
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x06006AAB RID: 27307 RVA: 0x001ECCB8 File Offset: 0x001EAEB8
		// (set) Token: 0x06006AAC RID: 27308 RVA: 0x00032247 File Offset: 0x00030447
		public unsafe AvatarSettings _CurrentSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__CurrentSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x06006AAD RID: 27309 RVA: 0x001ECCE8 File Offset: 0x001EAEE8
		// (set) Token: 0x06006AAE RID: 27310 RVA: 0x00032266 File Offset: 0x00030466
		public unsafe UnityEvent onSettingsLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onSettingsLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_onSettingsLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x06006AAF RID: 27311 RVA: 0x001ECD18 File Offset: 0x001EAF18
		// (set) Token: 0x06006AB0 RID: 27312 RVA: 0x00032285 File Offset: 0x00030485
		public unsafe Vector3 originalHipPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_originalHipPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_originalHipPos)) = value;
			}
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x06006AB1 RID: 27313 RVA: 0x001ECD40 File Offset: 0x001EAF40
		// (set) Token: 0x06006AB2 RID: 27314 RVA: 0x000322A0 File Offset: 0x000304A0
		public unsafe bool usingCombinedLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_usingCombinedLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_usingCombinedLayer)) = value;
			}
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06006AB3 RID: 27315 RVA: 0x001ECD68 File Offset: 0x001EAF68
		// (set) Token: 0x06006AB4 RID: 27316 RVA: 0x000322BB File Offset: 0x000304BB
		public unsafe bool blockEyeFaceLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_blockEyeFaceLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr_blockEyeFaceLayers)) = value;
			}
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x06006AB5 RID: 27317 RVA: 0x001ECD90 File Offset: 0x001EAF90
		// (set) Token: 0x06006AB6 RID: 27318 RVA: 0x000322D6 File Offset: 0x000304D6
		public unsafe Color _appliedSkinColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__appliedSkinColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__appliedSkinColor)) = value;
			}
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x06006AB7 RID: 27319 RVA: 0x001ECDB8 File Offset: 0x001EAFB8
		// (set) Token: 0x06006AB8 RID: 27320 RVA: 0x000322F1 File Offset: 0x000304F1
		public unsafe Color _appliedEmissionColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__appliedEmissionColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.NativeFieldInfoPtr__appliedEmissionColor)) = value;
			}
		}

		// Token: 0x04004902 RID: 18690
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ACCESSORIES;

		// Token: 0x04004903 RID: 18691
		private static readonly IntPtr NativeFieldInfoPtr_CombinedLayersEnabled;

		// Token: 0x04004904 RID: 18692
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SMOOTHNESS;

		// Token: 0x04004905 RID: 18693
		private static readonly IntPtr NativeFieldInfoPtr_maleShoulderScale;

		// Token: 0x04004906 RID: 18694
		private static readonly IntPtr NativeFieldInfoPtr_femaleShoulderScale;

		// Token: 0x04004907 RID: 18695
		private static readonly IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x04004908 RID: 18696
		private static readonly IntPtr NativeFieldInfoPtr_LookController;

		// Token: 0x04004909 RID: 18697
		private static readonly IntPtr NativeFieldInfoPtr_BodyMeshes;

		// Token: 0x0400490A RID: 18698
		private static readonly IntPtr NativeFieldInfoPtr_ShapeKeyMeshes;

		// Token: 0x0400490B RID: 18699
		private static readonly IntPtr NativeFieldInfoPtr_FaceMesh;

		// Token: 0x0400490C RID: 18700
		private static readonly IntPtr NativeFieldInfoPtr_Eyes;

		// Token: 0x0400490D RID: 18701
		private static readonly IntPtr NativeFieldInfoPtr_EyeBrows;

		// Token: 0x0400490E RID: 18702
		private static readonly IntPtr NativeFieldInfoPtr_BodyContainer;

		// Token: 0x0400490F RID: 18703
		private static readonly IntPtr NativeFieldInfoPtr_Armature;

		// Token: 0x04004910 RID: 18704
		private static readonly IntPtr NativeFieldInfoPtr_LeftShoulder;

		// Token: 0x04004911 RID: 18705
		private static readonly IntPtr NativeFieldInfoPtr_RightShoulder;

		// Token: 0x04004912 RID: 18706
		private static readonly IntPtr NativeFieldInfoPtr_HeadBone;

		// Token: 0x04004913 RID: 18707
		private static readonly IntPtr NativeFieldInfoPtr_HipBone;

		// Token: 0x04004914 RID: 18708
		private static readonly IntPtr NativeFieldInfoPtr_LeftFootBone;

		// Token: 0x04004915 RID: 18709
		private static readonly IntPtr NativeFieldInfoPtr_RightFootBone;

		// Token: 0x04004916 RID: 18710
		private static readonly IntPtr NativeFieldInfoPtr_RagdollRBs;

		// Token: 0x04004917 RID: 18711
		private static readonly IntPtr NativeFieldInfoPtr_RagdollColliders;

		// Token: 0x04004918 RID: 18712
		private static readonly IntPtr NativeFieldInfoPtr_MiddleSpineRB;

		// Token: 0x04004919 RID: 18713
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForceRBs;

		// Token: 0x0400491A RID: 18714
		private static readonly IntPtr NativeFieldInfoPtr_EmotionManager;

		// Token: 0x0400491B RID: 18715
		private static readonly IntPtr NativeFieldInfoPtr_Effects;

		// Token: 0x0400491C RID: 18716
		private static readonly IntPtr NativeFieldInfoPtr_MiddleSpine;

		// Token: 0x0400491D RID: 18717
		private static readonly IntPtr NativeFieldInfoPtr_LowerSpine;

		// Token: 0x0400491E RID: 18718
		private static readonly IntPtr NativeFieldInfoPtr_LowestSpine;

		// Token: 0x0400491F RID: 18719
		private static readonly IntPtr NativeFieldInfoPtr_Impostor;

		// Token: 0x04004920 RID: 18720
		private static readonly IntPtr NativeFieldInfoPtr_BloodParticles;

		// Token: 0x04004921 RID: 18721
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAvatarMaterial;

		// Token: 0x04004922 RID: 18722
		private static readonly IntPtr NativeFieldInfoPtr_UseCombinedLayer;

		// Token: 0x04004923 RID: 18723
		private static readonly IntPtr NativeFieldInfoPtr_onRagdollChange;

		// Token: 0x04004924 RID: 18724
		private static readonly IntPtr NativeFieldInfoPtr__Ragdolled_k__BackingField;

		// Token: 0x04004925 RID: 18725
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEquippable_k__BackingField;

		// Token: 0x04004926 RID: 18726
		private static readonly IntPtr NativeFieldInfoPtr_appliedGender;

		// Token: 0x04004927 RID: 18727
		private static readonly IntPtr NativeFieldInfoPtr_appliedWeight;

		// Token: 0x04004928 RID: 18728
		private static readonly IntPtr NativeFieldInfoPtr_appliedHair;

		// Token: 0x04004929 RID: 18729
		private static readonly IntPtr NativeFieldInfoPtr_appliedHairColor;

		// Token: 0x0400492A RID: 18730
		private static readonly IntPtr NativeFieldInfoPtr_appliedAccessories;

		// Token: 0x0400492B RID: 18731
		private static readonly IntPtr NativeFieldInfoPtr_wearingHairBlockingAccessory;

		// Token: 0x0400492C RID: 18732
		private static readonly IntPtr NativeFieldInfoPtr_additionalWeight;

		// Token: 0x0400492D RID: 18733
		private static readonly IntPtr NativeFieldInfoPtr_additionalGender;

		// Token: 0x0400492E RID: 18734
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSettings_k__BackingField;

		// Token: 0x0400492F RID: 18735
		private static readonly IntPtr NativeFieldInfoPtr_onSettingsLoaded;

		// Token: 0x04004930 RID: 18736
		private static readonly IntPtr NativeFieldInfoPtr_originalHipPos;

		// Token: 0x04004931 RID: 18737
		private static readonly IntPtr NativeFieldInfoPtr_usingCombinedLayer;

		// Token: 0x04004932 RID: 18738
		private static readonly IntPtr NativeFieldInfoPtr_blockEyeFaceLayers;

		// Token: 0x04004933 RID: 18739
		private static readonly IntPtr NativeFieldInfoPtr__appliedSkinColor;

		// Token: 0x04004934 RID: 18740
		private static readonly IntPtr NativeFieldInfoPtr__appliedEmissionColor;

		// Token: 0x04004935 RID: 18741
		private static readonly IntPtr NativeMethodInfoPtr_get_RightHandContainer_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04004936 RID: 18742
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftHandContainer_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04004937 RID: 18743
		private static readonly IntPtr NativeMethodInfoPtr_get_RightHandAlignmentPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04004938 RID: 18744
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftHandAlignmentPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04004939 RID: 18745
		private static readonly IntPtr NativeMethodInfoPtr_get_Ragdolled_Public_get_Boolean_0;

		// Token: 0x0400493A RID: 18746
		private static readonly IntPtr NativeMethodInfoPtr_set_Ragdolled_Protected_set_Void_Boolean_0;

		// Token: 0x0400493B RID: 18747
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEquippable_Public_get_AvatarEquippable_0;

		// Token: 0x0400493C RID: 18748
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEquippable_Protected_set_Void_AvatarEquippable_0;

		// Token: 0x0400493D RID: 18749
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSettings_Public_get_AvatarSettings_0;

		// Token: 0x0400493E RID: 18750
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_AvatarSettings_0;

		// Token: 0x0400493F RID: 18751
		private static readonly IntPtr NativeMethodInfoPtr_get_CenterPointTransform_Public_get_Transform_0;

		// Token: 0x04004940 RID: 18752
		private static readonly IntPtr NativeMethodInfoPtr_get_CenterPoint_Public_get_Vector3_0;

		// Token: 0x04004941 RID: 18753
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004942 RID: 18754
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004943 RID: 18755
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04004944 RID: 18756
		private static readonly IntPtr NativeMethodInfoPtr_GetMugshot_Public_Void_Action_1_Texture2D_0;

		// Token: 0x04004945 RID: 18757
		private static readonly IntPtr NativeMethodInfoPtr_SetEmission_Public_Void_Color_0;

		// Token: 0x04004946 RID: 18758
		private static readonly IntPtr NativeMethodInfoPtr_IsMale_Public_Boolean_0;

		// Token: 0x04004947 RID: 18759
		private static readonly IntPtr NativeMethodInfoPtr_IsWhite_Public_Boolean_0;

		// Token: 0x04004948 RID: 18760
		private static readonly IntPtr NativeMethodInfoPtr_GetFormalAddress_Public_String_Boolean_0;

		// Token: 0x04004949 RID: 18761
		private static readonly IntPtr NativeMethodInfoPtr_GetThirdPersonAddress_Public_String_Boolean_0;

		// Token: 0x0400494A RID: 18762
		private static readonly IntPtr NativeMethodInfoPtr_GetThirdPersonPronoun_Public_String_Boolean_0;

		// Token: 0x0400494B RID: 18763
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationBool_Public_Virtual_Final_New_Void_String_Boolean_0;

		// Token: 0x0400494C RID: 18764
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimationTrigger_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x0400494D RID: 18765
		private static readonly IntPtr NativeMethodInfoPtr_ApplyCurrentShapeKeys_Private_Void_0;

		// Token: 0x0400494E RID: 18766
		private static readonly IntPtr NativeMethodInfoPtr_ApplyShapeKeys_Private_Void_Single_Single_0;

		// Token: 0x0400494F RID: 18767
		private static readonly IntPtr NativeMethodInfoPtr_SetFeetShrunk_Private_Void_Boolean_Single_0;

		// Token: 0x04004950 RID: 18768
		private static readonly IntPtr NativeMethodInfoPtr_SetWearingHairBlockingAccessory_Private_Void_Boolean_0;

		// Token: 0x04004951 RID: 18769
		private static readonly IntPtr NativeMethodInfoPtr_LoadAvatarSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04004952 RID: 18770
		private static readonly IntPtr NativeMethodInfoPtr_LoadNakedSettings_Public_Void_AvatarSettings_Boolean_Int32_0;

		// Token: 0x04004953 RID: 18771
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBodySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04004954 RID: 18772
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditionalWeight_Public_Void_Single_0;

		// Token: 0x04004955 RID: 18773
		private static readonly IntPtr NativeMethodInfoPtr_SetAdditionalGender_Public_Void_Single_0;

		// Token: 0x04004956 RID: 18774
		private static readonly IntPtr NativeMethodInfoPtr_SetSkinColor_Public_Void_Color_0;

		// Token: 0x04004957 RID: 18775
		private static readonly IntPtr NativeMethodInfoPtr_ApplyHairSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04004958 RID: 18776
		private static readonly IntPtr NativeMethodInfoPtr_SetHairVisible_Public_Void_Boolean_0;

		// Token: 0x04004959 RID: 18777
		private static readonly IntPtr NativeMethodInfoPtr_ApplyHairColorSettings_Public_Void_AvatarSettings_0;

		// Token: 0x0400495A RID: 18778
		private static readonly IntPtr NativeMethodInfoPtr_OverrideHairColor_Public_Void_Color_0;

		// Token: 0x0400495B RID: 18779
		private static readonly IntPtr NativeMethodInfoPtr_ResetHairColor_Public_Void_0;

		// Token: 0x0400495C RID: 18780
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyeBallSettings_Public_Void_AvatarSettings_0;

		// Token: 0x0400495D RID: 18781
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyeLidSettings_Public_Void_AvatarSettings_0;

		// Token: 0x0400495E RID: 18782
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyeLidColorSettings_Public_Void_AvatarSettings_0;

		// Token: 0x0400495F RID: 18783
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEyebrowSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04004960 RID: 18784
		private static readonly IntPtr NativeMethodInfoPtr_SetBlockEyeFaceLayers_Public_Void_Boolean_0;

		// Token: 0x04004961 RID: 18785
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFaceLayerSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04004962 RID: 18786
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceLayer_Private_Void_Int32_String_Color_0;

		// Token: 0x04004963 RID: 18787
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceTexture_Public_Void_Texture2D_Color_0;

		// Token: 0x04004964 RID: 18788
		private static readonly IntPtr NativeMethodInfoPtr_ApplyBodyLayerSettings_Public_Void_AvatarSettings_Int32_0;

		// Token: 0x04004965 RID: 18789
		private static readonly IntPtr NativeMethodInfoPtr_SetBodyLayer_Private_Void_Int32_String_Color_0;

		// Token: 0x04004966 RID: 18790
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAccessorySettings_Public_Void_AvatarSettings_0;

		// Token: 0x04004967 RID: 18791
		private static readonly IntPtr NativeMethodInfoPtr_DestroyAccessories_Private_Void_0;

		// Token: 0x04004968 RID: 18792
		private static readonly IntPtr NativeMethodInfoPtr_EnableRagdoll_Public_Void_Vector3_Vector3_0;

		// Token: 0x04004969 RID: 18793
		private static readonly IntPtr NativeMethodInfoPtr_DisableRagdoll_Public_Void_Boolean_0;

		// Token: 0x0400496A RID: 18794
		private static readonly IntPtr NativeMethodInfoPtr_SetRagdollPhysicsEnabled_Private_Void_Boolean_Boolean_Boolean_Vector3_Vector3_0;

		// Token: 0x0400496B RID: 18795
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRagdollForce_Public_Void_Vector3_Vector3_0;

		// Token: 0x0400496C RID: 18796
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippable_Public_Virtual_New_AvatarEquippable_String_0;

		// Token: 0x0400496D RID: 18797
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveEquippableMessage_Public_Virtual_New_Void_String_Object_0;

		// Token: 0x0400496E RID: 18798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B5D RID: 2909
		[ObfuscatedName("ScheduleOne.AvatarFramework.Avatar+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E803 RID: 59395 RVA: 0x0038850C File Offset: 0x0038670C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr);
				Avatar.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9");
				Avatar.__c.NativeFieldInfoPtr___9__104_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9__104_0");
				Avatar.__c.NativeFieldInfoPtr___9__107_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, "<>9__107_0");
				Avatar.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100677256);
				Avatar.__c.NativeMethodInfoPtr__ApplyFaceLayerSettings_b__104_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100677257);
				Avatar.__c.NativeMethodInfoPtr__ApplyBodyLayerSettings_b__107_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr, 100677258);
			}

			// Token: 0x0600E804 RID: 59396 RVA: 0x003885B0 File Offset: 0x003867B0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E805 RID: 59397 RVA: 0x003885EC File Offset: 0x003867EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218936, XrefRangeEnd = 218939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ApplyFaceLayerSettings_b__104_0(Tuple<FaceLayer, Color> x, Tuple<FaceLayer, Color> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ApplyFaceLayerSettings_b__104_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E806 RID: 59398 RVA: 0x0038864C File Offset: 0x0038684C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218939, XrefRangeEnd = 218942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ApplyBodyLayerSettings_b__107_0(Tuple<AvatarLayer, Color> x, Tuple<AvatarLayer, Color> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c.NativeMethodInfoPtr__ApplyBodyLayerSettings_b__107_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E807 RID: 59399 RVA: 0x0006D6B0 File Offset: 0x0006B8B0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004666 RID: 18022
			// (get) Token: 0x0600E808 RID: 59400 RVA: 0x003886AC File Offset: 0x003868AC
			// (set) Token: 0x0600E809 RID: 59401 RVA: 0x0006D6B9 File Offset: 0x0006B8B9
			public unsafe static Avatar.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004667 RID: 18023
			// (get) Token: 0x0600E80A RID: 59402 RVA: 0x003886D4 File Offset: 0x003868D4
			// (set) Token: 0x0600E80B RID: 59403 RVA: 0x0006D6CB File Offset: 0x0006B8CB
			public unsafe static Comparison<Tuple<FaceLayer, Color>> __9__104_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9__104_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Tuple<FaceLayer, Color>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9__104_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004668 RID: 18024
			// (get) Token: 0x0600E80C RID: 59404 RVA: 0x003886FC File Offset: 0x003868FC
			// (set) Token: 0x0600E80D RID: 59405 RVA: 0x0006D6DD File Offset: 0x0006B8DD
			public unsafe static Comparison<Tuple<AvatarLayer, Color>> __9__107_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Avatar.__c.NativeFieldInfoPtr___9__107_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Tuple<AvatarLayer, Color>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Avatar.__c.NativeFieldInfoPtr___9__107_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009D6A RID: 40298
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009D6B RID: 40299
			private static readonly IntPtr NativeFieldInfoPtr___9__104_0;

			// Token: 0x04009D6C RID: 40300
			private static readonly IntPtr NativeFieldInfoPtr___9__107_0;

			// Token: 0x04009D6D RID: 40301
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D6E RID: 40302
			private static readonly IntPtr NativeMethodInfoPtr__ApplyFaceLayerSettings_b__104_0_Internal_Int32_Tuple_2_FaceLayer_Color_Tuple_2_FaceLayer_Color_0;

			// Token: 0x04009D6F RID: 40303
			private static readonly IntPtr NativeMethodInfoPtr__ApplyBodyLayerSettings_b__107_0_Internal_Int32_Tuple_2_AvatarLayer_Color_Tuple_2_AvatarLayer_Color_0;
		}

		// Token: 0x02000B5E RID: 2910
		[ObfuscatedName("ScheduleOne.AvatarFramework.Avatar+<>c__DisplayClass113_0")]
		public sealed class __c__DisplayClass113_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E80E RID: 59406 RVA: 0x00388724 File Offset: 0x00386924
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass113_0()
			{
				Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<>c__DisplayClass113_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0>.NativeClassPtr);
				Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr_ragdollEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0>.NativeClassPtr, "ragdollEnabled");
				Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0>.NativeClassPtr, "<>4__this");
				Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr_forceDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0>.NativeClassPtr, "forceDir");
				Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr_forcePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0>.NativeClassPtr, "forcePoint");
				Avatar.__c__DisplayClass113_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0>.NativeClassPtr, 100677259);
				Avatar.__c__DisplayClass113_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0>.NativeClassPtr, 100677260);
				Avatar.__c__DisplayClass113_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0>.NativeClassPtr, 100677261);
			}

			// Token: 0x0600E80F RID: 59407 RVA: 0x003887DC File Offset: 0x003869DC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass113_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c__DisplayClass113_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E810 RID: 59408 RVA: 0x00388818 File Offset: 0x00386A18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218948, XrefRangeEnd = 218953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c__DisplayClass113_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E811 RID: 59409 RVA: 0x00388858 File Offset: 0x00386A58
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 219017, RefRangeEnd = 219020, XrefRangeStart = 218953, XrefRangeEnd = 219017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_0(bool enabled)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c__DisplayClass113_0.NativeMethodInfoPtr_Method_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E812 RID: 59410 RVA: 0x0006D6EF File Offset: 0x0006B8EF
			public __c__DisplayClass113_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004669 RID: 18025
			// (get) Token: 0x0600E813 RID: 59411 RVA: 0x00388898 File Offset: 0x00386A98
			// (set) Token: 0x0600E814 RID: 59412 RVA: 0x0006D6F8 File Offset: 0x0006B8F8
			public unsafe bool ragdollEnabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr_ragdollEnabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr_ragdollEnabled)) = value;
				}
			}

			// Token: 0x1700466A RID: 18026
			// (get) Token: 0x0600E815 RID: 59413 RVA: 0x003888C0 File Offset: 0x00386AC0
			// (set) Token: 0x0600E816 RID: 59414 RVA: 0x0006D713 File Offset: 0x0006B913
			public unsafe Avatar __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700466B RID: 18027
			// (get) Token: 0x0600E817 RID: 59415 RVA: 0x003888F0 File Offset: 0x00386AF0
			// (set) Token: 0x0600E818 RID: 59416 RVA: 0x0006D732 File Offset: 0x0006B932
			public unsafe Vector3 forceDir
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr_forceDir);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr_forceDir)) = value;
				}
			}

			// Token: 0x1700466C RID: 18028
			// (get) Token: 0x0600E819 RID: 59417 RVA: 0x00388918 File Offset: 0x00386B18
			// (set) Token: 0x0600E81A RID: 59418 RVA: 0x0006D74D File Offset: 0x0006B94D
			public unsafe Vector3 forcePoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr_forcePoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.NativeFieldInfoPtr_forcePoint)) = value;
				}
			}

			// Token: 0x04009D70 RID: 40304
			private static readonly IntPtr NativeFieldInfoPtr_ragdollEnabled;

			// Token: 0x04009D71 RID: 40305
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009D72 RID: 40306
			private static readonly IntPtr NativeFieldInfoPtr_forceDir;

			// Token: 0x04009D73 RID: 40307
			private static readonly IntPtr NativeFieldInfoPtr_forcePoint;

			// Token: 0x04009D74 RID: 40308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D75 RID: 40309
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009D76 RID: 40310
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_0;

			// Token: 0x02000DDE RID: 3550
			[ObfuscatedName("ScheduleOne.AvatarFramework.Avatar+<>c__DisplayClass113_0+<<SetRagdollPhysicsEnabled>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010028 RID: 65576 RVA: 0x003CDFF0 File Offset: 0x003CC1F0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0>.NativeClassPtr, "<<SetRagdollPhysicsEnabled>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677262);
					Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677263);
					Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677264);
					Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677265);
					Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677266);
					Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677267);
				}

				// Token: 0x06010029 RID: 65577 RVA: 0x003CE0D0 File Offset: 0x003CC2D0
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601002A RID: 65578 RVA: 0x003CE118 File Offset: 0x003CC318
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601002B RID: 65579 RVA: 0x003CE14C File Offset: 0x003CC34C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218942, XrefRangeEnd = 218943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E0A RID: 19978
				// (get) Token: 0x0601002C RID: 65580 RVA: 0x003CE188 File Offset: 0x003CC388
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601002D RID: 65581 RVA: 0x003CE1C8 File Offset: 0x003CC3C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218943, XrefRangeEnd = 218948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E0B RID: 19979
				// (get) Token: 0x0601002E RID: 65582 RVA: 0x003CE1FC File Offset: 0x003CC3FC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601002F RID: 65583 RVA: 0x00079657 File Offset: 0x00077857
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E07 RID: 19975
				// (get) Token: 0x06010030 RID: 65584 RVA: 0x003CE23C File Offset: 0x003CC43C
				// (set) Token: 0x06010031 RID: 65585 RVA: 0x00079660 File Offset: 0x00077860
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E08 RID: 19976
				// (get) Token: 0x06010032 RID: 65586 RVA: 0x003CE264 File Offset: 0x003CC464
				// (set) Token: 0x06010033 RID: 65587 RVA: 0x0007967B File Offset: 0x0007787B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E09 RID: 19977
				// (get) Token: 0x06010034 RID: 65588 RVA: 0x003CE294 File Offset: 0x003CC494
				// (set) Token: 0x06010035 RID: 65589 RVA: 0x0007969A File Offset: 0x0007789A
				public unsafe Avatar.__c__DisplayClass113_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar.__c__DisplayClass113_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass113_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AC8D RID: 44173
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC8E RID: 44174
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC8F RID: 44175
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC90 RID: 44176
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC91 RID: 44177
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC92 RID: 44178
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC93 RID: 44179
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC94 RID: 44180
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC95 RID: 44181
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B5F RID: 2911
		[ObfuscatedName("ScheduleOne.AvatarFramework.Avatar+<>c__DisplayClass114_0")]
		public sealed class __c__DisplayClass114_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E81B RID: 59419 RVA: 0x00388940 File Offset: 0x00386B40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass114_0()
			{
				Il2CppClassPointerStore<Avatar.__c__DisplayClass114_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Avatar>.NativeClassPtr, "<>c__DisplayClass114_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar.__c__DisplayClass114_0>.NativeClassPtr);
				Avatar.__c__DisplayClass114_0.NativeFieldInfoPtr_forcePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Avatar.__c__DisplayClass114_0>.NativeClassPtr, "forcePoint");
				Avatar.__c__DisplayClass114_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c__DisplayClass114_0>.NativeClassPtr, 100677268);
				Avatar.__c__DisplayClass114_0.NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal_Single_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar.__c__DisplayClass114_0>.NativeClassPtr, 100677269);
			}

			// Token: 0x0600E81C RID: 59420 RVA: 0x003889A8 File Offset: 0x00386BA8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass114_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar.__c__DisplayClass114_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c__DisplayClass114_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E81D RID: 59421 RVA: 0x003889E4 File Offset: 0x00386BE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219020, XrefRangeEnd = 219024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ApplyRagdollForce_b__0(Rigidbody rb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.__c__DisplayClass114_0.NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal_Single_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E81E RID: 59422 RVA: 0x0006D768 File Offset: 0x0006B968
			public __c__DisplayClass114_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700466D RID: 18029
			// (get) Token: 0x0600E81F RID: 59423 RVA: 0x00388A34 File Offset: 0x00386C34
			// (set) Token: 0x0600E820 RID: 59424 RVA: 0x0006D771 File Offset: 0x0006B971
			public unsafe Vector3 forcePoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass114_0.NativeFieldInfoPtr_forcePoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Avatar.__c__DisplayClass114_0.NativeFieldInfoPtr_forcePoint)) = value;
				}
			}

			// Token: 0x04009D77 RID: 40311
			private static readonly IntPtr NativeFieldInfoPtr_forcePoint;

			// Token: 0x04009D78 RID: 40312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D79 RID: 40313
			private static readonly IntPtr NativeMethodInfoPtr__ApplyRagdollForce_b__0_Internal_Single_Rigidbody_0;
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x020004A6 RID: 1190
	public class AvatarEmotionManager : MonoBehaviour
	{
		// Token: 0x06006CCE RID: 27854 RVA: 0x001F3114 File Offset: 0x001F1314
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEmotionManager()
		{
			Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "AvatarEmotionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr);
			AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE_SQR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "MAX_UPDATE_DISTANCE_SQR");
			AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<CurrentEmotion>k__BackingField");
			AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<CurrentEmotionPreset>k__BackingField");
			AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EmotionPresetList");
			AvatarEmotionManager.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "Avatar");
			AvatarEmotionManager.NativeFieldInfoPtr_EyeController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EyeController");
			AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EyebrowController");
			AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "activeEmotionOverride");
			AvatarEmotionManager.NativeFieldInfoPtr_overrideStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "overrideStack");
			AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "neutralPreset");
			AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "emotionLerpRoutine");
			AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "emotionRemovalRoutines");
			AvatarEmotionManager.NativeFieldInfoPtr_tempIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "tempIndex");
			AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677491);
			AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677492);
			AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677493);
			AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677494);
			AvatarEmotionManager.NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677495);
			AvatarEmotionManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677496);
			AvatarEmotionManager.NativeMethodInfoPtr_UpdateEmotion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677497);
			AvatarEmotionManager.NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677498);
			AvatarEmotionManager.NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677499);
			AvatarEmotionManager.NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677500);
			AvatarEmotionManager.NativeMethodInfoPtr_ClearOverrides_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677501);
			AvatarEmotionManager.NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677502);
			AvatarEmotionManager.NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677503);
			AvatarEmotionManager.NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677504);
			AvatarEmotionManager.NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677505);
			AvatarEmotionManager.NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677506);
			AvatarEmotionManager.NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677507);
			AvatarEmotionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100677508);
		}

		// Token: 0x1700218E RID: 8590
		// (get) Token: 0x06006CCF RID: 27855 RVA: 0x001F33B0 File Offset: 0x001F15B0
		// (set) Token: 0x06006CD0 RID: 27856 RVA: 0x001F33E8 File Offset: 0x001F15E8
		public unsafe string CurrentEmotion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x06006CD1 RID: 27857 RVA: 0x001F342C File Offset: 0x001F162C
		// (set) Token: 0x06006CD2 RID: 27858 RVA: 0x001F346C File Offset: 0x001F166C
		public unsafe AvatarEmotionPreset CurrentEmotionPreset
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x06006CD3 RID: 27859 RVA: 0x001F34B0 File Offset: 0x001F16B0
		public unsafe bool IsSwitchingEmotion
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 221391, RefRangeEnd = 221394, XrefRangeStart = 221391, XrefRangeEnd = 221391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006CD4 RID: 27860 RVA: 0x001F34EC File Offset: 0x001F16EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221394, XrefRangeEnd = 221421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x001F3520 File Offset: 0x001F1720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221421, XrefRangeEnd = 221478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEmotion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_UpdateEmotion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x001F3554 File Offset: 0x001F1754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221501, RefRangeEnd = 221503, XrefRangeStart = 221478, XrefRangeEnd = 221501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureNeutralFace(Texture2D faceTex, float restingBrowHeight, float restingBrowAngle, Eye.EyeLidConfiguration leftEyelidConfig, Eye.EyeLidConfiguration rightEyelidConfig)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(faceTex);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restingBrowHeight;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restingBrowAngle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftEyelidConfig;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightEyelidConfig;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x001F35D0 File Offset: 0x001F17D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221503, XrefRangeEnd = 221546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddEmotionOverride(string emotionName, string overrideLabel, float duration = 0f, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotionName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEmotionManager.NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x001F364C File Offset: 0x001F184C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 221564, RefRangeEnd = 221589, XrefRangeStart = 221546, XrefRangeEnd = 221564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEmotionOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x001F3690 File Offset: 0x001F1890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221597, RefRangeEnd = 221599, XrefRangeStart = 221589, XrefRangeEnd = 221597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOverrides()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ClearOverrides_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x001F36C4 File Offset: 0x001F18C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221615, RefRangeEnd = 221617, XrefRangeStart = 221599, XrefRangeEnd = 221615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRemovalRoutine(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CDB RID: 27867 RVA: 0x001F3708 File Offset: 0x001F1908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221617, XrefRangeEnd = 221641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmotionOverride GetHighestPriorityOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmotionOverride>(intPtr3) : null;
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x001F3748 File Offset: 0x001F1948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221641, XrefRangeEnd = 221661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpEmotion(AvatarEmotionPreset preset, float animationTime = 0.2f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref animationTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CDD RID: 27869 RVA: 0x001F3798 File Offset: 0x001F1998
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221685, RefRangeEnd = 221687, XrefRangeStart = 221661, XrefRangeEnd = 221685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEmotion(AvatarEmotionPreset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x001F37DC File Offset: 0x001F19DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221688, RefRangeEnd = 221689, XrefRangeStart = 221687, XrefRangeEnd = 221688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasEmotion(string emotion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x001F382C File Offset: 0x001F1A2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221704, RefRangeEnd = 221706, XrefRangeStart = 221689, XrefRangeEnd = 221704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionPreset GetEmotion(string emotion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr3) : null;
		}

		// Token: 0x06006CE0 RID: 27872 RVA: 0x001F387C File Offset: 0x001F1A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221706, XrefRangeEnd = 221732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CE1 RID: 27873 RVA: 0x00033586 File Offset: 0x00031786
		public AvatarEmotionManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06006CE2 RID: 27874 RVA: 0x001F38B8 File Offset: 0x001F1AB8
		// (set) Token: 0x06006CE3 RID: 27875 RVA: 0x0003358F File Offset: 0x0003178F
		public unsafe static float MAX_UPDATE_DISTANCE_SQR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE_SQR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE_SQR, (void*)(&value));
			}
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06006CE4 RID: 27876 RVA: 0x001F38D4 File Offset: 0x001F1AD4
		// (set) Token: 0x06006CE5 RID: 27877 RVA: 0x0003359D File Offset: 0x0003179D
		public unsafe string _CurrentEmotion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06006CE6 RID: 27878 RVA: 0x001F38FC File Offset: 0x001F1AFC
		// (set) Token: 0x06006CE7 RID: 27879 RVA: 0x000335BC File Offset: 0x000317BC
		public unsafe AvatarEmotionPreset _CurrentEmotionPreset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06006CE8 RID: 27880 RVA: 0x001F392C File Offset: 0x001F1B2C
		// (set) Token: 0x06006CE9 RID: 27881 RVA: 0x000335DB File Offset: 0x000317DB
		public unsafe List<AvatarEmotionPreset> EmotionPresetList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarEmotionPreset>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x06006CEA RID: 27882 RVA: 0x001F395C File Offset: 0x001F1B5C
		// (set) Token: 0x06006CEB RID: 27883 RVA: 0x000335FA File Offset: 0x000317FA
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x06006CEC RID: 27884 RVA: 0x001F398C File Offset: 0x001F1B8C
		// (set) Token: 0x06006CED RID: 27885 RVA: 0x00033619 File Offset: 0x00031819
		public unsafe EyeController EyeController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyeController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyeController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x06006CEE RID: 27886 RVA: 0x001F39BC File Offset: 0x001F1BBC
		// (set) Token: 0x06006CEF RID: 27887 RVA: 0x00033638 File Offset: 0x00031838
		public unsafe EyebrowController EyebrowController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyebrowController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x06006CF0 RID: 27888 RVA: 0x001F39EC File Offset: 0x001F1BEC
		// (set) Token: 0x06006CF1 RID: 27889 RVA: 0x00033657 File Offset: 0x00031857
		public unsafe EmotionOverride activeEmotionOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmotionOverride>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x06006CF2 RID: 27890 RVA: 0x001F3A1C File Offset: 0x001F1C1C
		// (set) Token: 0x06006CF3 RID: 27891 RVA: 0x00033676 File Offset: 0x00031876
		public unsafe List<EmotionOverride> overrideStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_overrideStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmotionOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_overrideStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06006CF4 RID: 27892 RVA: 0x001F3A4C File Offset: 0x001F1C4C
		// (set) Token: 0x06006CF5 RID: 27893 RVA: 0x00033695 File Offset: 0x00031895
		public unsafe AvatarEmotionPreset neutralPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06006CF6 RID: 27894 RVA: 0x001F3A7C File Offset: 0x001F1C7C
		// (set) Token: 0x06006CF7 RID: 27895 RVA: 0x000336B4 File Offset: 0x000318B4
		public unsafe Coroutine emotionLerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218C RID: 8588
		// (get) Token: 0x06006CF8 RID: 27896 RVA: 0x001F3AAC File Offset: 0x001F1CAC
		// (set) Token: 0x06006CF9 RID: 27897 RVA: 0x000336D3 File Offset: 0x000318D3
		public unsafe Dictionary<string, Coroutine> emotionRemovalRoutines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Coroutine>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700218D RID: 8589
		// (get) Token: 0x06006CFA RID: 27898 RVA: 0x001F3ADC File Offset: 0x001F1CDC
		// (set) Token: 0x06006CFB RID: 27899 RVA: 0x000336F2 File Offset: 0x000318F2
		public unsafe int tempIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_tempIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_tempIndex)) = value;
			}
		}

		// Token: 0x04004ABF RID: 19135
		private static readonly IntPtr NativeFieldInfoPtr_MAX_UPDATE_DISTANCE_SQR;

		// Token: 0x04004AC0 RID: 19136
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEmotion_k__BackingField;

		// Token: 0x04004AC1 RID: 19137
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField;

		// Token: 0x04004AC2 RID: 19138
		private static readonly IntPtr NativeFieldInfoPtr_EmotionPresetList;

		// Token: 0x04004AC3 RID: 19139
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04004AC4 RID: 19140
		private static readonly IntPtr NativeFieldInfoPtr_EyeController;

		// Token: 0x04004AC5 RID: 19141
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowController;

		// Token: 0x04004AC6 RID: 19142
		private static readonly IntPtr NativeFieldInfoPtr_activeEmotionOverride;

		// Token: 0x04004AC7 RID: 19143
		private static readonly IntPtr NativeFieldInfoPtr_overrideStack;

		// Token: 0x04004AC8 RID: 19144
		private static readonly IntPtr NativeFieldInfoPtr_neutralPreset;

		// Token: 0x04004AC9 RID: 19145
		private static readonly IntPtr NativeFieldInfoPtr_emotionLerpRoutine;

		// Token: 0x04004ACA RID: 19146
		private static readonly IntPtr NativeFieldInfoPtr_emotionRemovalRoutines;

		// Token: 0x04004ACB RID: 19147
		private static readonly IntPtr NativeFieldInfoPtr_tempIndex;

		// Token: 0x04004ACC RID: 19148
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0;

		// Token: 0x04004ACD RID: 19149
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0;

		// Token: 0x04004ACE RID: 19150
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0;

		// Token: 0x04004ACF RID: 19151
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0;

		// Token: 0x04004AD0 RID: 19152
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0;

		// Token: 0x04004AD1 RID: 19153
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004AD2 RID: 19154
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEmotion_Public_Void_0;

		// Token: 0x04004AD3 RID: 19155
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0;

		// Token: 0x04004AD4 RID: 19156
		private static readonly IntPtr NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0;

		// Token: 0x04004AD5 RID: 19157
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0;

		// Token: 0x04004AD6 RID: 19158
		private static readonly IntPtr NativeMethodInfoPtr_ClearOverrides_Public_Void_0;

		// Token: 0x04004AD7 RID: 19159
		private static readonly IntPtr NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0;

		// Token: 0x04004AD8 RID: 19160
		private static readonly IntPtr NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0;

		// Token: 0x04004AD9 RID: 19161
		private static readonly IntPtr NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0;

		// Token: 0x04004ADA RID: 19162
		private static readonly IntPtr NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0;

		// Token: 0x04004ADB RID: 19163
		private static readonly IntPtr NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0;

		// Token: 0x04004ADC RID: 19164
		private static readonly IntPtr NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0;

		// Token: 0x04004ADD RID: 19165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B6A RID: 2922
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E882 RID: 59522 RVA: 0x00389B2C File Offset: 0x00387D2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr);
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__21_0");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__23_0");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__28_0");
				AvatarEmotionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100677510);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100677511);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__ConfigureNeutralFace_b__23_0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100677512);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__GetHighestPriorityOverride_b__28_0_Internal_Int32_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100677513);
			}

			// Token: 0x0600E883 RID: 59523 RVA: 0x00389BF8 File Offset: 0x00387DF8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E884 RID: 59524 RVA: 0x00389C34 File Offset: 0x00387E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221345, XrefRangeEnd = 221349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__21_0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E885 RID: 59525 RVA: 0x00389C84 File Offset: 0x00387E84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221349, XrefRangeEnd = 221353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ConfigureNeutralFace_b__23_0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__ConfigureNeutralFace_b__23_0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E886 RID: 59526 RVA: 0x00389CD4 File Offset: 0x00387ED4
			[CallerCount(0)]
			public unsafe int _GetHighestPriorityOverride_b__28_0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__GetHighestPriorityOverride_b__28_0_Internal_Int32_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E887 RID: 59527 RVA: 0x0006DACF File Offset: 0x0006BCCF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700468D RID: 18061
			// (get) Token: 0x0600E888 RID: 59528 RVA: 0x00389D24 File Offset: 0x00387F24
			// (set) Token: 0x0600E889 RID: 59529 RVA: 0x0006DAD8 File Offset: 0x0006BCD8
			public unsafe static AvatarEmotionManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700468E RID: 18062
			// (get) Token: 0x0600E88A RID: 59530 RVA: 0x00389D4C File Offset: 0x00387F4C
			// (set) Token: 0x0600E88B RID: 59531 RVA: 0x0006DAEA File Offset: 0x0006BCEA
			public unsafe static Predicate<AvatarEmotionPreset> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AvatarEmotionPreset>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700468F RID: 18063
			// (get) Token: 0x0600E88C RID: 59532 RVA: 0x00389D74 File Offset: 0x00387F74
			// (set) Token: 0x0600E88D RID: 59533 RVA: 0x0006DAFC File Offset: 0x0006BCFC
			public unsafe static Predicate<AvatarEmotionPreset> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AvatarEmotionPreset>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004690 RID: 18064
			// (get) Token: 0x0600E88E RID: 59534 RVA: 0x00389D9C File Offset: 0x00387F9C
			// (set) Token: 0x0600E88F RID: 59535 RVA: 0x0006DB0E File Offset: 0x0006BD0E
			public unsafe static Func<EmotionOverride, int> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EmotionOverride, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009DB6 RID: 40374
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009DB7 RID: 40375
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x04009DB8 RID: 40376
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04009DB9 RID: 40377
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x04009DBA RID: 40378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009DBB RID: 40379
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0;

			// Token: 0x04009DBC RID: 40380
			private static readonly IntPtr NativeMethodInfoPtr__ConfigureNeutralFace_b__23_0_Internal_Boolean_AvatarEmotionPreset_0;

			// Token: 0x04009DBD RID: 40381
			private static readonly IntPtr NativeMethodInfoPtr__GetHighestPriorityOverride_b__28_0_Internal_Int32_EmotionOverride_0;
		}

		// Token: 0x02000B6B RID: 2923
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E890 RID: 59536 RVA: 0x00389DC4 File Offset: 0x00387FC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass24_0.NativeFieldInfoPtr_overrideLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0>.NativeClassPtr, "overrideLabel");
				AvatarEmotionManager.__c__DisplayClass24_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0>.NativeClassPtr, "duration");
				AvatarEmotionManager.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
				AvatarEmotionManager.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0>.NativeClassPtr, 100677514);
				AvatarEmotionManager.__c__DisplayClass24_0.NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0>.NativeClassPtr, 100677515);
				AvatarEmotionManager.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0>.NativeClassPtr, 100677516);
			}

			// Token: 0x0600E891 RID: 59537 RVA: 0x00389E68 File Offset: 0x00388068
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E892 RID: 59538 RVA: 0x00389EA4 File Offset: 0x003880A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221363, XrefRangeEnd = 221367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddEmotionOverride_b__0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass24_0.NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E893 RID: 59539 RVA: 0x00389EF4 File Offset: 0x003880F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221367, XrefRangeEnd = 221372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E894 RID: 59540 RVA: 0x0006DB20 File Offset: 0x0006BD20
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004691 RID: 18065
			// (get) Token: 0x0600E895 RID: 59541 RVA: 0x00389F34 File Offset: 0x00388134
			// (set) Token: 0x0600E896 RID: 59542 RVA: 0x0006DB29 File Offset: 0x0006BD29
			public unsafe string overrideLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.NativeFieldInfoPtr_overrideLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.NativeFieldInfoPtr_overrideLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004692 RID: 18066
			// (get) Token: 0x0600E897 RID: 59543 RVA: 0x00389F5C File Offset: 0x0038815C
			// (set) Token: 0x0600E898 RID: 59544 RVA: 0x0006DB48 File Offset: 0x0006BD48
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004693 RID: 18067
			// (get) Token: 0x0600E899 RID: 59545 RVA: 0x00389F84 File Offset: 0x00388184
			// (set) Token: 0x0600E89A RID: 59546 RVA: 0x0006DB63 File Offset: 0x0006BD63
			public unsafe AvatarEmotionManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009DBE RID: 40382
			private static readonly IntPtr NativeFieldInfoPtr_overrideLabel;

			// Token: 0x04009DBF RID: 40383
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04009DC0 RID: 40384
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009DC1 RID: 40385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009DC2 RID: 40386
			private static readonly IntPtr NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0;

			// Token: 0x04009DC3 RID: 40387
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DE2 RID: 3554
			[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass24_0+<<AddEmotionOverride>g__RemoveEmotionAfterDuration|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601006C RID: 65644 RVA: 0x003CECA8 File Offset: 0x003CCEA8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0>.NativeClassPtr, "<<AddEmotionOverride>g__RemoveEmotionAfterDuration|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677517);
					AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677518);
					AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677519);
					AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677520);
					AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677521);
					AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677522);
				}

				// Token: 0x0601006D RID: 65645 RVA: 0x003CED88 File Offset: 0x003CCF88
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601006E RID: 65646 RVA: 0x003CEDD0 File Offset: 0x003CCFD0
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601006F RID: 65647 RVA: 0x003CEE04 File Offset: 0x003CD004
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221353, XrefRangeEnd = 221358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E24 RID: 20004
				// (get) Token: 0x06010070 RID: 65648 RVA: 0x003CEE40 File Offset: 0x003CD040
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010071 RID: 65649 RVA: 0x003CEE80 File Offset: 0x003CD080
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221358, XrefRangeEnd = 221363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E25 RID: 20005
				// (get) Token: 0x06010072 RID: 65650 RVA: 0x003CEEB4 File Offset: 0x003CD0B4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010073 RID: 65651 RVA: 0x00079881 File Offset: 0x00077A81
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E21 RID: 20001
				// (get) Token: 0x06010074 RID: 65652 RVA: 0x003CEEF4 File Offset: 0x003CD0F4
				// (set) Token: 0x06010075 RID: 65653 RVA: 0x0007988A File Offset: 0x00077A8A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E22 RID: 20002
				// (get) Token: 0x06010076 RID: 65654 RVA: 0x003CEF1C File Offset: 0x003CD11C
				// (set) Token: 0x06010077 RID: 65655 RVA: 0x000798A5 File Offset: 0x00077AA5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E23 RID: 20003
				// (get) Token: 0x06010078 RID: 65656 RVA: 0x003CEF4C File Offset: 0x003CD14C
				// (set) Token: 0x06010079 RID: 65657 RVA: 0x000798C4 File Offset: 0x00077AC4
				public unsafe AvatarEmotionManager.__c__DisplayClass24_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c__DisplayClass24_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ACB7 RID: 44215
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ACB8 RID: 44216
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ACB9 RID: 44217
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ACBA RID: 44218
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ACBB RID: 44219
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACBC RID: 44220
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ACBD RID: 44221
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ACBE RID: 44222
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACBF RID: 44223
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B6C RID: 2924
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E89B RID: 59547 RVA: 0x00389FB4 File Offset: 0x003881B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "label");
				AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, 100677523);
				AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, 100677524);
			}

			// Token: 0x0600E89C RID: 59548 RVA: 0x0038A01C File Offset: 0x0038821C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E89D RID: 59549 RVA: 0x0038A058 File Offset: 0x00388258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveEmotionOverride_b__0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E89E RID: 59550 RVA: 0x0006DB82 File Offset: 0x0006BD82
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004694 RID: 18068
			// (get) Token: 0x0600E89F RID: 59551 RVA: 0x0038A0A8 File Offset: 0x003882A8
			// (set) Token: 0x0600E8A0 RID: 59552 RVA: 0x0006DB8B File Offset: 0x0006BD8B
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009DC4 RID: 40388
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009DC5 RID: 40389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009DC6 RID: 40390
			private static readonly IntPtr NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0;
		}

		// Token: 0x02000B6D RID: 2925
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E8A1 RID: 59553 RVA: 0x0038A0D0 File Offset: 0x003882D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				AvatarEmotionManager.__c__DisplayClass29_0.NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0>.NativeClassPtr, "preset");
				AvatarEmotionManager.__c__DisplayClass29_0.NativeFieldInfoPtr_animationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0>.NativeClassPtr, "animationTime");
				AvatarEmotionManager.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0>.NativeClassPtr, 100677525);
				AvatarEmotionManager.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0>.NativeClassPtr, 100677526);
			}

			// Token: 0x0600E8A2 RID: 59554 RVA: 0x0038A160 File Offset: 0x00388360
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8A3 RID: 59555 RVA: 0x0038A19C File Offset: 0x0038839C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221386, XrefRangeEnd = 221391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E8A4 RID: 59556 RVA: 0x0006DBAA File Offset: 0x0006BDAA
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004695 RID: 18069
			// (get) Token: 0x0600E8A5 RID: 59557 RVA: 0x0038A1DC File Offset: 0x003883DC
			// (set) Token: 0x0600E8A6 RID: 59558 RVA: 0x0006DBB3 File Offset: 0x0006BDB3
			public unsafe AvatarEmotionManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004696 RID: 18070
			// (get) Token: 0x0600E8A7 RID: 59559 RVA: 0x0038A20C File Offset: 0x0038840C
			// (set) Token: 0x0600E8A8 RID: 59560 RVA: 0x0006DBD2 File Offset: 0x0006BDD2
			public unsafe AvatarEmotionPreset preset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.NativeFieldInfoPtr_preset);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.NativeFieldInfoPtr_preset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004697 RID: 18071
			// (get) Token: 0x0600E8A9 RID: 59561 RVA: 0x0038A23C File Offset: 0x0038843C
			// (set) Token: 0x0600E8AA RID: 59562 RVA: 0x0006DBF1 File Offset: 0x0006BDF1
			public unsafe float animationTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.NativeFieldInfoPtr_animationTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.NativeFieldInfoPtr_animationTime)) = value;
				}
			}

			// Token: 0x04009DC7 RID: 40391
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009DC8 RID: 40392
			private static readonly IntPtr NativeFieldInfoPtr_preset;

			// Token: 0x04009DC9 RID: 40393
			private static readonly IntPtr NativeFieldInfoPtr_animationTime;

			// Token: 0x04009DCA RID: 40394
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009DCB RID: 40395
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DE3 RID: 3555
			[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass29_0+<<LerpEmotion>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601007A RID: 65658 RVA: 0x003CEF7C File Offset: 0x003CD17C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0>.NativeClassPtr, "<<LerpEmotion>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr);
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<startPreset>5__2");
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<timeStep>5__3");
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<i>5__4");
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100677527);
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100677528);
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100677529);
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100677530);
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100677531);
					AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100677532);
				}

				// Token: 0x0601007B RID: 65659 RVA: 0x003CF098 File Offset: 0x003CD298
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601007C RID: 65660 RVA: 0x003CF0E0 File Offset: 0x003CD2E0
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601007D RID: 65661 RVA: 0x003CF114 File Offset: 0x003CD314
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221372, XrefRangeEnd = 221381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E2C RID: 20012
				// (get) Token: 0x0601007E RID: 65662 RVA: 0x003CF150 File Offset: 0x003CD350
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601007F RID: 65663 RVA: 0x003CF190 File Offset: 0x003CD390
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221381, XrefRangeEnd = 221386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E2D RID: 20013
				// (get) Token: 0x06010080 RID: 65664 RVA: 0x003CF1C4 File Offset: 0x003CD3C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010081 RID: 65665 RVA: 0x000798E3 File Offset: 0x00077AE3
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E26 RID: 20006
				// (get) Token: 0x06010082 RID: 65666 RVA: 0x003CF204 File Offset: 0x003CD404
				// (set) Token: 0x06010083 RID: 65667 RVA: 0x000798EC File Offset: 0x00077AEC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E27 RID: 20007
				// (get) Token: 0x06010084 RID: 65668 RVA: 0x003CF22C File Offset: 0x003CD42C
				// (set) Token: 0x06010085 RID: 65669 RVA: 0x00079907 File Offset: 0x00077B07
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E28 RID: 20008
				// (get) Token: 0x06010086 RID: 65670 RVA: 0x003CF25C File Offset: 0x003CD45C
				// (set) Token: 0x06010087 RID: 65671 RVA: 0x00079926 File Offset: 0x00077B26
				public unsafe AvatarEmotionManager.__c__DisplayClass29_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c__DisplayClass29_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E29 RID: 20009
				// (get) Token: 0x06010088 RID: 65672 RVA: 0x003CF28C File Offset: 0x003CD48C
				// (set) Token: 0x06010089 RID: 65673 RVA: 0x00079945 File Offset: 0x00077B45
				public unsafe AvatarEmotionPreset _startPreset_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E2A RID: 20010
				// (get) Token: 0x0601008A RID: 65674 RVA: 0x003CF2BC File Offset: 0x003CD4BC
				// (set) Token: 0x0601008B RID: 65675 RVA: 0x00079964 File Offset: 0x00077B64
				public unsafe float _timeStep_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3)) = value;
					}
				}

				// Token: 0x17004E2B RID: 20011
				// (get) Token: 0x0601008C RID: 65676 RVA: 0x003CF2E4 File Offset: 0x003CD4E4
				// (set) Token: 0x0601008D RID: 65677 RVA: 0x0007997F File Offset: 0x00077B7F
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x0400ACC0 RID: 44224
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ACC1 RID: 44225
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ACC2 RID: 44226
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ACC3 RID: 44227
				private static readonly IntPtr NativeFieldInfoPtr__startPreset_5__2;

				// Token: 0x0400ACC4 RID: 44228
				private static readonly IntPtr NativeFieldInfoPtr__timeStep_5__3;

				// Token: 0x0400ACC5 RID: 44229
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400ACC6 RID: 44230
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ACC7 RID: 44231
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACC8 RID: 44232
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ACC9 RID: 44233
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ACCA RID: 44234
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACCB RID: 44235
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B6E RID: 2926
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E8AB RID: 59563 RVA: 0x0038A264 File Offset: 0x00388464
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass32_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass32_0.NativeFieldInfoPtr_emotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass32_0>.NativeClassPtr, "emotion");
				AvatarEmotionManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass32_0>.NativeClassPtr, 100677533);
				AvatarEmotionManager.__c__DisplayClass32_0.NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass32_0>.NativeClassPtr, 100677534);
			}

			// Token: 0x0600E8AC RID: 59564 RVA: 0x0038A2CC File Offset: 0x003884CC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8AD RID: 59565 RVA: 0x0038A308 File Offset: 0x00388508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEmotion_b__0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass32_0.NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E8AE RID: 59566 RVA: 0x0006DC0C File Offset: 0x0006BE0C
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004698 RID: 18072
			// (get) Token: 0x0600E8AF RID: 59567 RVA: 0x0038A358 File Offset: 0x00388558
			// (set) Token: 0x0600E8B0 RID: 59568 RVA: 0x0006DC15 File Offset: 0x0006BE15
			public unsafe string emotion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass32_0.NativeFieldInfoPtr_emotion);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass32_0.NativeFieldInfoPtr_emotion), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009DCC RID: 40396
			private static readonly IntPtr NativeFieldInfoPtr_emotion;

			// Token: 0x04009DCD RID: 40397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009DCE RID: 40398
			private static readonly IntPtr NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0;
		}
	}
}

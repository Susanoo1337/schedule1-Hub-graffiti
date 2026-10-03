using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x020004AE RID: 1198
	public class CustomizationManager : Singleton<CustomizationManager>
	{
		// Token: 0x06006D51 RID: 27985 RVA: 0x001F4B6C File Offset: 0x001F2D6C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomizationManager()
		{
			Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "CustomizationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr);
			CustomizationManager.NativeFieldInfoPtr_AppearancesFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "AppearancesFolderPath");
			CustomizationManager.NativeFieldInfoPtr_TemplateAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "TemplateAvatar");
			CustomizationManager.NativeFieldInfoPtr_SaveInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "SaveInputField");
			CustomizationManager.NativeFieldInfoPtr_LoadInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "LoadInputField");
			CustomizationManager.NativeFieldInfoPtr_GenerateCombinedLayerToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "GenerateCombinedLayerToggle");
			CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "OnAvatarSettingsChanged");
			CustomizationManager.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "DefaultSettings");
			CustomizationManager.NativeFieldInfoPtr_isEditingOriginal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "isEditingOriginal");
			CustomizationManager.NativeFieldInfoPtr_loadedSettingsAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "loadedSettingsAssetPath");
			CustomizationManager.NativeFieldInfoPtr_ActiveSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "ActiveSettings");
			CustomizationManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677570);
			CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677571);
			CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677572);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677573);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677574);
			CustomizationManager.NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677575);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677576);
			CustomizationManager.NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677577);
			CustomizationManager.NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677578);
			CustomizationManager.NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677579);
			CustomizationManager.NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677580);
			CustomizationManager.NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677581);
			CustomizationManager.NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677582);
			CustomizationManager.NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677583);
			CustomizationManager.NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677584);
			CustomizationManager.NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677585);
			CustomizationManager.NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677586);
			CustomizationManager.NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677587);
			CustomizationManager.NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677588);
			CustomizationManager.NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677589);
			CustomizationManager.NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677590);
			CustomizationManager.NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677591);
			CustomizationManager.NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677592);
			CustomizationManager.NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677593);
			CustomizationManager.NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677594);
			CustomizationManager.NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677595);
			CustomizationManager.NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677596);
			CustomizationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100677597);
		}

		// Token: 0x06006D52 RID: 27986 RVA: 0x001F4E94 File Offset: 0x001F3094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221990, XrefRangeEnd = 222000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomizationManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D53 RID: 27987 RVA: 0x001F4ED0 File Offset: 0x001F30D0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSettings(string assetName, string assetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x001F4F24 File Offset: 0x001F3124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222000, XrefRangeEnd = 222012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D55 RID: 27989 RVA: 0x001F4F58 File Offset: 0x001F3158
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 222032, RefRangeEnd = 222035, XrefRangeStart = 222012, XrefRangeEnd = 222032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings(AvatarSettings loadedSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadedSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x001F4F9C File Offset: 0x001F319C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222035, XrefRangeEnd = 222037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings(string path, bool editOriginal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref editOriginal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x001F4FEC File Offset: 0x001F31EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222037, XrefRangeEnd = 222044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDefaultSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D58 RID: 27992 RVA: 0x001F5030 File Offset: 0x001F3230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222044, XrefRangeEnd = 222057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D59 RID: 27993 RVA: 0x001F5064 File Offset: 0x001F3264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222057, XrefRangeEnd = 222059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenderChanged(float genderScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref genderScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x001F50A4 File Offset: 0x001F32A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222059, XrefRangeEnd = 222061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WeightChanged(float weightScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref weightScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x001F50E4 File Offset: 0x001F32E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222061, XrefRangeEnd = 222063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HeightChanged(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x001F5124 File Offset: 0x001F3324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222063, XrefRangeEnd = 222067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkinColorChanged(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x001F5164 File Offset: 0x001F3364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222067, XrefRangeEnd = 222077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairChanged(Accessory newHair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newHair);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x001F51A8 File Offset: 0x001F33A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222077, XrefRangeEnd = 222079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairColorChanged(Color newCol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newCol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x001F51E8 File Offset: 0x001F33E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222079, XrefRangeEnd = 222081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyeBallTintChanged(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x001F5228 File Offset: 0x001F3428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222081, XrefRangeEnd = 222083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpperEyeLidRestingPositionChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x001F5268 File Offset: 0x001F3468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222083, XrefRangeEnd = 222085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LowerEyeLidRestingPositionChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D62 RID: 28002 RVA: 0x001F52A8 File Offset: 0x001F34A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222085, XrefRangeEnd = 222087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowScaleChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D63 RID: 28003 RVA: 0x001F52E8 File Offset: 0x001F34E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222087, XrefRangeEnd = 222089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowThicknessChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x001F5328 File Offset: 0x001F3528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222089, XrefRangeEnd = 222091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowRestingHeightChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x001F5368 File Offset: 0x001F3568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222091, XrefRangeEnd = 222093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowRestingAngleChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x001F53A8 File Offset: 0x001F35A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222093, XrefRangeEnd = 222095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PupilDilationChanged(float dilation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dilation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x001F53E8 File Offset: 0x001F35E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222095, XrefRangeEnd = 222110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceLayerChanged(FaceLayer layer, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x001F5438 File Offset: 0x001F3638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222110, XrefRangeEnd = 222118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceLayerColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D69 RID: 28009 RVA: 0x001F5484 File Offset: 0x001F3684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222118, XrefRangeEnd = 222133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyLayerChanged(AvatarLayer layer, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6A RID: 28010 RVA: 0x001F54D4 File Offset: 0x001F36D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222133, XrefRangeEnd = 222141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyLayerColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x001F5520 File Offset: 0x001F3720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222141, XrefRangeEnd = 222180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryChanged(Accessory acc, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(acc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x001F5570 File Offset: 0x001F3770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222180, XrefRangeEnd = 222193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x001F55BC File Offset: 0x001F37BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222193, XrefRangeEnd = 222199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomizationManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x000339CA File Offset: 0x00031BCA
		public CustomizationManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x06006D6F RID: 28015 RVA: 0x001F55F8 File Offset: 0x001F37F8
		// (set) Token: 0x06006D70 RID: 28016 RVA: 0x000339D3 File Offset: 0x00031BD3
		public unsafe static string AppearancesFolderPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CustomizationManager.NativeFieldInfoPtr_AppearancesFolderPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomizationManager.NativeFieldInfoPtr_AppearancesFolderPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x06006D71 RID: 28017 RVA: 0x001F5618 File Offset: 0x001F3818
		// (set) Token: 0x06006D72 RID: 28018 RVA: 0x000339E5 File Offset: 0x00031BE5
		public unsafe Avatar TemplateAvatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_TemplateAvatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_TemplateAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x06006D73 RID: 28019 RVA: 0x001F5648 File Offset: 0x001F3848
		// (set) Token: 0x06006D74 RID: 28020 RVA: 0x00033A04 File Offset: 0x00031C04
		public unsafe TMP_InputField SaveInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_SaveInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_SaveInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x06006D75 RID: 28021 RVA: 0x001F5678 File Offset: 0x001F3878
		// (set) Token: 0x06006D76 RID: 28022 RVA: 0x00033A23 File Offset: 0x00031C23
		public unsafe TMP_InputField LoadInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_LoadInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_LoadInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x06006D77 RID: 28023 RVA: 0x001F56A8 File Offset: 0x001F38A8
		// (set) Token: 0x06006D78 RID: 28024 RVA: 0x00033A42 File Offset: 0x00031C42
		public unsafe Toggle GenerateCombinedLayerToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_GenerateCombinedLayerToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_GenerateCombinedLayerToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x06006D79 RID: 28025 RVA: 0x001F56D8 File Offset: 0x001F38D8
		// (set) Token: 0x06006D7A RID: 28026 RVA: 0x00033A61 File Offset: 0x00031C61
		public unsafe CustomizationManager.AvatarSettingsChanged OnAvatarSettingsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomizationManager.AvatarSettingsChanged>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x06006D7B RID: 28027 RVA: 0x001F5708 File Offset: 0x001F3908
		// (set) Token: 0x06006D7C RID: 28028 RVA: 0x00033A80 File Offset: 0x00031C80
		public unsafe AvatarSettings DefaultSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_DefaultSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x06006D7D RID: 28029 RVA: 0x001F5738 File Offset: 0x001F3938
		// (set) Token: 0x06006D7E RID: 28030 RVA: 0x00033A9F File Offset: 0x00031C9F
		public unsafe bool isEditingOriginal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_isEditingOriginal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_isEditingOriginal)) = value;
			}
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x06006D7F RID: 28031 RVA: 0x001F5760 File Offset: 0x001F3960
		// (set) Token: 0x06006D80 RID: 28032 RVA: 0x00033ABA File Offset: 0x00031CBA
		public unsafe string loadedSettingsAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_loadedSettingsAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_loadedSettingsAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170021B0 RID: 8624
		// (get) Token: 0x06006D81 RID: 28033 RVA: 0x001F5788 File Offset: 0x001F3988
		// (set) Token: 0x06006D82 RID: 28034 RVA: 0x00033AD9 File Offset: 0x00031CD9
		public unsafe AvatarSettings ActiveSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_ActiveSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_ActiveSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B0F RID: 19215
		private static readonly IntPtr NativeFieldInfoPtr_AppearancesFolderPath;

		// Token: 0x04004B10 RID: 19216
		private static readonly IntPtr NativeFieldInfoPtr_TemplateAvatar;

		// Token: 0x04004B11 RID: 19217
		private static readonly IntPtr NativeFieldInfoPtr_SaveInputField;

		// Token: 0x04004B12 RID: 19218
		private static readonly IntPtr NativeFieldInfoPtr_LoadInputField;

		// Token: 0x04004B13 RID: 19219
		private static readonly IntPtr NativeFieldInfoPtr_GenerateCombinedLayerToggle;

		// Token: 0x04004B14 RID: 19220
		private static readonly IntPtr NativeFieldInfoPtr_OnAvatarSettingsChanged;

		// Token: 0x04004B15 RID: 19221
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04004B16 RID: 19222
		private static readonly IntPtr NativeFieldInfoPtr_isEditingOriginal;

		// Token: 0x04004B17 RID: 19223
		private static readonly IntPtr NativeFieldInfoPtr_loadedSettingsAssetPath;

		// Token: 0x04004B18 RID: 19224
		private static readonly IntPtr NativeFieldInfoPtr_ActiveSettings;

		// Token: 0x04004B19 RID: 19225
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004B1A RID: 19226
		private static readonly IntPtr NativeMethodInfoPtr_CreateSettings_Public_Void_String_String_0;

		// Token: 0x04004B1B RID: 19227
		private static readonly IntPtr NativeMethodInfoPtr_CreateSettings_Public_Void_0;

		// Token: 0x04004B1C RID: 19228
		private static readonly IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04004B1D RID: 19229
		private static readonly IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0;

		// Token: 0x04004B1E RID: 19230
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0;

		// Token: 0x04004B1F RID: 19231
		private static readonly IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_0;

		// Token: 0x04004B20 RID: 19232
		private static readonly IntPtr NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0;

		// Token: 0x04004B21 RID: 19233
		private static readonly IntPtr NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0;

		// Token: 0x04004B22 RID: 19234
		private static readonly IntPtr NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0;

		// Token: 0x04004B23 RID: 19235
		private static readonly IntPtr NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0;

		// Token: 0x04004B24 RID: 19236
		private static readonly IntPtr NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0;

		// Token: 0x04004B25 RID: 19237
		private static readonly IntPtr NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0;

		// Token: 0x04004B26 RID: 19238
		private static readonly IntPtr NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0;

		// Token: 0x04004B27 RID: 19239
		private static readonly IntPtr NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0;

		// Token: 0x04004B28 RID: 19240
		private static readonly IntPtr NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0;

		// Token: 0x04004B29 RID: 19241
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0;

		// Token: 0x04004B2A RID: 19242
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0;

		// Token: 0x04004B2B RID: 19243
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0;

		// Token: 0x04004B2C RID: 19244
		private static readonly IntPtr NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0;

		// Token: 0x04004B2D RID: 19245
		private static readonly IntPtr NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0;

		// Token: 0x04004B2E RID: 19246
		private static readonly IntPtr NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0;

		// Token: 0x04004B2F RID: 19247
		private static readonly IntPtr NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04004B30 RID: 19248
		private static readonly IntPtr NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0;

		// Token: 0x04004B31 RID: 19249
		private static readonly IntPtr NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04004B32 RID: 19250
		private static readonly IntPtr NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0;

		// Token: 0x04004B33 RID: 19251
		private static readonly IntPtr NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04004B34 RID: 19252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B73 RID: 2931
		public sealed class AvatarSettingsChanged : MulticastDelegate
		{
			// Token: 0x0600E8CB RID: 59595 RVA: 0x0038A854 File Offset: 0x00388A54
			// Note: this type is marked as 'beforefieldinit'.
			static AvatarSettingsChanged()
			{
				Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "AvatarSettingsChanged");
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100677598);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100677599);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100677600);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100677601);
			}

			// Token: 0x0600E8CC RID: 59596 RVA: 0x0038A8C8 File Offset: 0x00388AC8
			[CallerCount(628)]
			[CachedScanResults(RefRangeStart = 71168, RefRangeEnd = 71796, XrefRangeStart = 71168, XrefRangeEnd = 71796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AvatarSettingsChanged(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8CD RID: 59597 RVA: 0x0038A924 File Offset: 0x00388B24
			[CallerCount(0)]
			public unsafe void Invoke(AvatarSettings settings)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8CE RID: 59598 RVA: 0x0038A968 File Offset: 0x00388B68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71797, XrefRangeEnd = 71798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AvatarSettings settings, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600E8CF RID: 59599 RVA: 0x0038A9DC File Offset: 0x00388BDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8D0 RID: 59600 RVA: 0x0006DCEF File Offset: 0x0006BEEF
			public AvatarSettingsChanged(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E8D1 RID: 59601 RVA: 0x0006DCF8 File Offset: 0x0006BEF8
			public static implicit operator CustomizationManager.AvatarSettingsChanged(Action<AvatarSettings> A_0)
			{
				return DelegateSupport.ConvertDelegate<CustomizationManager.AvatarSettingsChanged>(A_0);
			}

			// Token: 0x0600E8D2 RID: 59602 RVA: 0x0006DD00 File Offset: 0x0006BF00
			public static CustomizationManager.AvatarSettingsChanged operator +(CustomizationManager.AvatarSettingsChanged A_0, CustomizationManager.AvatarSettingsChanged A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<CustomizationManager.AvatarSettingsChanged>();
			}

			// Token: 0x0600E8D3 RID: 59603 RVA: 0x0006DD0E File Offset: 0x0006BF0E
			public static CustomizationManager.AvatarSettingsChanged operator -(CustomizationManager.AvatarSettingsChanged A_0, CustomizationManager.AvatarSettingsChanged A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<CustomizationManager.AvatarSettingsChanged>();
				}
				return result;
			}

			// Token: 0x04009DDC RID: 40412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009DDD RID: 40413
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0;

			// Token: 0x04009DDE RID: 40414
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0;

			// Token: 0x04009DDF RID: 40415
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}

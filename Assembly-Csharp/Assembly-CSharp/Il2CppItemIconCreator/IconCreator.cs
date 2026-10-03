using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppItemIconCreator
{
	// Token: 0x02000087 RID: 135
	public class IconCreator : MonoBehaviour
	{
		// Token: 0x06000B87 RID: 2951 RVA: 0x000A0EC4 File Offset: 0x0009F0C4
		// Note: this type is marked as 'beforefieldinit'.
		static IconCreator()
		{
			Il2CppClassPointerStore<IconCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ItemIconCreator", "IconCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconCreator>.NativeClassPtr);
			IconCreator.NativeFieldInfoPtr_isCreatingIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "isCreatingIcons");
			IconCreator.NativeFieldInfoPtr_useDafaultName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "useDafaultName");
			IconCreator.NativeFieldInfoPtr_includeResolutionInFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "includeResolutionInFileName");
			IconCreator.NativeFieldInfoPtr_iconFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "iconFileName");
			IconCreator.NativeFieldInfoPtr_pathLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "pathLocation");
			IconCreator.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "mode");
			IconCreator.NativeFieldInfoPtr_folderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "folderName");
			IconCreator.NativeFieldInfoPtr_useTransparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "useTransparency");
			IconCreator.NativeFieldInfoPtr_lookAtObjectCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "lookAtObjectCenter");
			IconCreator.NativeFieldInfoPtr_dynamicFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "dynamicFov");
			IconCreator.NativeFieldInfoPtr_fovOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "fovOffset");
			IconCreator.NativeFieldInfoPtr_finalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "finalPath");
			IconCreator.NativeFieldInfoPtr_mousePostion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "mousePostion");
			IconCreator.NativeFieldInfoPtr_nextIconKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "nextIconKey");
			IconCreator.NativeFieldInfoPtr_CanMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "CanMove");
			IconCreator.NativeFieldInfoPtr_preview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "preview");
			IconCreator.NativeFieldInfoPtr_whiteCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "whiteCam");
			IconCreator.NativeFieldInfoPtr_blackCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "blackCam");
			IconCreator.NativeFieldInfoPtr_mainCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "mainCam");
			IconCreator.NativeFieldInfoPtr_texBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "texBlack");
			IconCreator.NativeFieldInfoPtr_texWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "texWhite");
			IconCreator.NativeFieldInfoPtr_finalTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "finalTexture");
			IconCreator.NativeFieldInfoPtr_originalClearFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "originalClearFlags");
			IconCreator.NativeFieldInfoPtr_currentObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "currentObject");
			IconCreator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664742);
			IconCreator.NativeMethodInfoPtr_Initialize_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664743);
			IconCreator.NativeMethodInfoPtr_DeleteCameras_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664744);
			IconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664745);
			IconCreator.NativeMethodInfoPtr_CaptureFrame_Protected_IEnumerator_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664746);
			IconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664747);
			IconCreator.NativeMethodInfoPtr_RenderCamToTexture_Private_Void_Camera_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664748);
			IconCreator.NativeMethodInfoPtr_CreateBlackAndWhiteCameras_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664749);
			IconCreator.NativeMethodInfoPtr_CreateNewFolderForIcons_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664750);
			IconCreator.NativeMethodInfoPtr_GetFinalFolder_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664751);
			IconCreator.NativeMethodInfoPtr_WriteScreenImageToTexture_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664752);
			IconCreator.NativeMethodInfoPtr_CalculateOutputTexture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664753);
			IconCreator.NativeMethodInfoPtr_SavePng_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664754);
			IconCreator.NativeMethodInfoPtr_GetFileName_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664755);
			IconCreator.NativeMethodInfoPtr_CacheAndInitialiseFields_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664756);
			IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664757);
			IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664758);
			IconCreator.NativeMethodInfoPtr_LookAtTargetCenter_Protected_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664759);
			IconCreator.NativeMethodInfoPtr_GetTargetFov_Private_Single_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664760);
			IconCreator.NativeMethodInfoPtr_GetRenderers_Private_List_1_Renderer_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664761);
			IconCreator.NativeMethodInfoPtr_GetMeshCenter_Private_Vector3_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664762);
			IconCreator.NativeMethodInfoPtr_RevealInFinder_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664763);
			IconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664764);
			IconCreator.NativeMethodInfoPtr_GetBaseLocation_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664765);
			IconCreator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664766);
			IconCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, 100664767);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x000A12DC File Offset: 0x0009F4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77383, XrefRangeEnd = 77407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x000A1310 File Offset: 0x0009F510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77442, RefRangeEnd = 77443, XrefRangeStart = 77407, XrefRangeEnd = 77442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_Initialize_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000A1344 File Offset: 0x0009F544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77458, RefRangeEnd = 77459, XrefRangeStart = 77443, XrefRangeEnd = 77458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteCameras()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_DeleteCameras_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x000A1378 File Offset: 0x0009F578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77459, XrefRangeEnd = 77465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BuildIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconCreator.NativeMethodInfoPtr_BuildIcons_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000A13B4 File Offset: 0x0009F5B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77471, RefRangeEnd = 77473, XrefRangeStart = 77465, XrefRangeEnd = 77471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CaptureFrame(string objectName, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CaptureFrame_Protected_IEnumerator_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000A1414 File Offset: 0x0009F614
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77492, RefRangeEnd = 77494, XrefRangeStart = 77473, XrefRangeEnd = 77492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconCreator.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000A1450 File Offset: 0x0009F650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77502, RefRangeEnd = 77503, XrefRangeStart = 77494, XrefRangeEnd = 77502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderCamToTexture(Camera cam, Texture2D tex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_RenderCamToTexture_Private_Void_Camera_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000A14A4 File Offset: 0x0009F6A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77537, RefRangeEnd = 77538, XrefRangeStart = 77503, XrefRangeEnd = 77537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateBlackAndWhiteCameras()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CreateBlackAndWhiteCameras_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000A14D8 File Offset: 0x0009F6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77538, XrefRangeEnd = 77562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateNewFolderForIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CreateNewFolderForIcons_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000A150C File Offset: 0x0009F70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77562, XrefRangeEnd = 77565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFinalFolder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetFinalFolder_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000A1544 File Offset: 0x0009F744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77565, XrefRangeEnd = 77570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteScreenImageToTexture(Texture2D tex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_WriteScreenImageToTexture_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000A1588 File Offset: 0x0009F788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77570, XrefRangeEnd = 77577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateOutputTexture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CalculateOutputTexture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000A15BC File Offset: 0x0009F7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77577, XrefRangeEnd = 77603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SavePng(string name, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_SavePng_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x000A160C File Offset: 0x0009F80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77603, XrefRangeEnd = 77616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetFileName(string name, int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetFileName_Public_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000A1664 File Offset: 0x0009F864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77616, XrefRangeEnd = 77636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheAndInitialiseFields()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_CacheAndInitialiseFields_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x000A1698 File Offset: 0x0009F898
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77641, RefRangeEnd = 77645, XrefRangeStart = 77636, XrefRangeEnd = 77641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFOV(GameObject targetItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x000A16DC File Offset: 0x0009F8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77645, XrefRangeEnd = 77652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFOV(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_UpdateFOV_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x000A171C File Offset: 0x0009F91C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 77666, RefRangeEnd = 77670, XrefRangeStart = 77652, XrefRangeEnd = 77666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAtTargetCenter(GameObject targetItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_LookAtTargetCenter_Protected_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000A1760 File Offset: 0x0009F960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77725, RefRangeEnd = 77726, XrefRangeStart = 77670, XrefRangeEnd = 77725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTargetFov(GameObject a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetTargetFov_Private_Single_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000A17B0 File Offset: 0x0009F9B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77747, RefRangeEnd = 77749, XrefRangeStart = 77726, XrefRangeEnd = 77747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Renderer> GetRenderers(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetRenderers_Private_List_1_Renderer_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Renderer>>(intPtr3) : null;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000A1800 File Offset: 0x0009FA00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 77760, RefRangeEnd = 77761, XrefRangeStart = 77749, XrefRangeEnd = 77760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetMeshCenter(GameObject a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetMeshCenter_Private_Vector3_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x000A1850 File Offset: 0x0009FA50
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RevealInFinder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_RevealInFinder_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000A1884 File Offset: 0x0009FA84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 77772, RefRangeEnd = 77774, XrefRangeStart = 77761, XrefRangeEnd = 77772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconCreator.NativeMethodInfoPtr_CheckConditions_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x000A18CC File Offset: 0x0009FACC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 77778, RefRangeEnd = 77781, XrefRangeStart = 77774, XrefRangeEnd = 77778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetBaseLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_GetBaseLocation_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000A1904 File Offset: 0x0009FB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77781, XrefRangeEnd = 77789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000A1938 File Offset: 0x0009FB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77789, XrefRangeEnd = 77794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IconCreator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x00007541 File Offset: 0x00005741
		public IconCreator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x000A1974 File Offset: 0x0009FB74
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x0000754A File Offset: 0x0000574A
		public unsafe bool isCreatingIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_isCreatingIcons);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_isCreatingIcons)) = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x000A199C File Offset: 0x0009FB9C
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00007565 File Offset: 0x00005765
		public unsafe bool useDafaultName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useDafaultName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useDafaultName)) = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x000A19C4 File Offset: 0x0009FBC4
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00007580 File Offset: 0x00005780
		public unsafe bool includeResolutionInFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_includeResolutionInFileName);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_includeResolutionInFileName)) = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x000A19EC File Offset: 0x0009FBEC
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x0000759B File Offset: 0x0000579B
		public unsafe string iconFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_iconFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_iconFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x000A1A14 File Offset: 0x0009FC14
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x000075BA File Offset: 0x000057BA
		public unsafe IconCreator.SaveLocation pathLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_pathLocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_pathLocation)) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000BAD RID: 2989 RVA: 0x000A1A3C File Offset: 0x0009FC3C
		// (set) Token: 0x06000BAE RID: 2990 RVA: 0x000075D5 File Offset: 0x000057D5
		public unsafe IconCreator.Mode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x000A1A64 File Offset: 0x0009FC64
		// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x000075F0 File Offset: 0x000057F0
		public unsafe string folderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_folderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_folderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x000A1A8C File Offset: 0x0009FC8C
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x0000760F File Offset: 0x0000580F
		public unsafe bool useTransparency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useTransparency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_useTransparency)) = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x000A1AB4 File Offset: 0x0009FCB4
		// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x0000762A File Offset: 0x0000582A
		public unsafe bool lookAtObjectCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_lookAtObjectCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_lookAtObjectCenter)) = value;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x000A1ADC File Offset: 0x0009FCDC
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x00007645 File Offset: 0x00005845
		public unsafe bool dynamicFov
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_dynamicFov);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_dynamicFov)) = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x000A1B04 File Offset: 0x0009FD04
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x00007660 File Offset: 0x00005860
		public unsafe float fovOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_fovOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_fovOffset)) = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x000A1B2C File Offset: 0x0009FD2C
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x0000767B File Offset: 0x0000587B
		public unsafe string finalPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x000A1B54 File Offset: 0x0009FD54
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x0000769A File Offset: 0x0000589A
		public unsafe Vector3 mousePostion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mousePostion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mousePostion)) = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x000A1B7C File Offset: 0x0009FD7C
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x000076B5 File Offset: 0x000058B5
		public unsafe KeyCode nextIconKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_nextIconKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_nextIconKey)) = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x000A1BA4 File Offset: 0x0009FDA4
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x000076D0 File Offset: 0x000058D0
		public unsafe bool CanMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_CanMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_CanMove)) = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x000A1BCC File Offset: 0x0009FDCC
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x000076EB File Offset: 0x000058EB
		public unsafe bool preview
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_preview);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_preview)) = value;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x00007706 File Offset: 0x00005906
		public unsafe Camera whiteCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_whiteCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_whiteCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x000A1C24 File Offset: 0x0009FE24
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x00007725 File Offset: 0x00005925
		public unsafe Camera blackCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_blackCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_blackCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x000A1C54 File Offset: 0x0009FE54
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x00007744 File Offset: 0x00005944
		public unsafe Camera mainCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mainCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_mainCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x000A1C84 File Offset: 0x0009FE84
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00007763 File Offset: 0x00005963
		public unsafe Texture2D texBlack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texBlack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texBlack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x000A1CB4 File Offset: 0x0009FEB4
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00007782 File Offset: 0x00005982
		public unsafe Texture2D texWhite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texWhite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_texWhite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x000A1CE4 File Offset: 0x0009FEE4
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x000077A1 File Offset: 0x000059A1
		public unsafe Texture2D finalTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_finalTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x000A1D14 File Offset: 0x0009FF14
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x000077C0 File Offset: 0x000059C0
		public unsafe CameraClearFlags originalClearFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_originalClearFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_originalClearFlags)) = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x000A1D3C File Offset: 0x0009FF3C
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x000077DB File Offset: 0x000059DB
		public unsafe Transform currentObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_currentObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator.NativeFieldInfoPtr_currentObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeFieldInfoPtr_isCreatingIcons;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeFieldInfoPtr_useDafaultName;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeFieldInfoPtr_includeResolutionInFileName;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeFieldInfoPtr_iconFileName;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeFieldInfoPtr_pathLocation;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeFieldInfoPtr_folderName;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeFieldInfoPtr_useTransparency;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeFieldInfoPtr_lookAtObjectCenter;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeFieldInfoPtr_dynamicFov;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeFieldInfoPtr_fovOffset;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeFieldInfoPtr_finalPath;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeFieldInfoPtr_mousePostion;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeFieldInfoPtr_nextIconKey;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeFieldInfoPtr_CanMove;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeFieldInfoPtr_preview;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeFieldInfoPtr_whiteCam;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeFieldInfoPtr_blackCam;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeFieldInfoPtr_mainCam;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeFieldInfoPtr_texBlack;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeFieldInfoPtr_texWhite;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeFieldInfoPtr_finalTexture;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeFieldInfoPtr_originalClearFlags;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeFieldInfoPtr_currentObject;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Void_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_DeleteCameras_Protected_Void_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_BuildIcons_Public_Virtual_New_Void_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_CaptureFrame_Protected_IEnumerator_String_Int32_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_RenderCamToTexture_Private_Void_Camera_Texture2D_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_CreateBlackAndWhiteCameras_Private_Void_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewFolderForIcons_Protected_Void_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_GetFinalFolder_Public_String_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_WriteScreenImageToTexture_Private_Void_Texture2D_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_CalculateOutputTexture_Private_Void_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_SavePng_Private_Void_String_Int32_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_String_String_Int32_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_CacheAndInitialiseFields_Private_Void_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFOV_Protected_Void_GameObject_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFOV_Protected_Void_Single_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_LookAtTargetCenter_Protected_Void_GameObject_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetFov_Private_Single_GameObject_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderers_Private_List_1_Renderer_GameObject_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshCenter_Private_Vector3_GameObject_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_RevealInFinder_Protected_Void_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_CheckConditions_Public_Virtual_New_Boolean_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseLocation_Private_String_0;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008A5 RID: 2213
		[OriginalName("Assembly-CSharp.dll", "", "SaveLocation")]
		public enum SaveLocation
		{
			// Token: 0x0400902D RID: 36909
			persistentDataPath,
			// Token: 0x0400902E RID: 36910
			dataPath,
			// Token: 0x0400902F RID: 36911
			projectFolder,
			// Token: 0x04009030 RID: 36912
			custom
		}

		// Token: 0x020008A6 RID: 2214
		[OriginalName("Assembly-CSharp.dll", "", "Mode")]
		public enum Mode
		{
			// Token: 0x04009032 RID: 36914
			Automatic,
			// Token: 0x04009033 RID: 36915
			Manual
		}

		// Token: 0x020008A7 RID: 2215
		[ObfuscatedName("ItemIconCreator.IconCreator+<CaptureFrame>d__30")]
		public sealed class _CaptureFrame_d__30 : Il2CppSystem.Object
		{
			// Token: 0x0600D3BE RID: 54206 RVA: 0x0034C904 File Offset: 0x0034AB04
			// Note: this type is marked as 'beforefieldinit'.
			static _CaptureFrame_d__30()
			{
				Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconCreator>.NativeClassPtr, "<CaptureFrame>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr);
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "<>1__state");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "<>2__current");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "<>4__this");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_objectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "objectName");
				IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, "i");
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100664768);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100664769);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100664770);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100664771);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100664772);
				IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr, 100664773);
			}

			// Token: 0x0600D3BF RID: 54207 RVA: 0x0034CA0C File Offset: 0x0034AC0C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CaptureFrame_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconCreator._CaptureFrame_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3C0 RID: 54208 RVA: 0x0034CA54 File Offset: 0x0034AC54
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3C1 RID: 54209 RVA: 0x0034CA88 File Offset: 0x0034AC88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77336, XrefRangeEnd = 77378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004076 RID: 16502
			// (get) Token: 0x0600D3C2 RID: 54210 RVA: 0x0034CAC4 File Offset: 0x0034ACC4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3C3 RID: 54211 RVA: 0x0034CB04 File Offset: 0x0034AD04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77378, XrefRangeEnd = 77383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004077 RID: 16503
			// (get) Token: 0x0600D3C4 RID: 54212 RVA: 0x0034CB38 File Offset: 0x0034AD38
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreator._CaptureFrame_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3C5 RID: 54213 RVA: 0x00064229 File Offset: 0x00062429
			public _CaptureFrame_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004071 RID: 16497
			// (get) Token: 0x0600D3C6 RID: 54214 RVA: 0x0034CB78 File Offset: 0x0034AD78
			// (set) Token: 0x0600D3C7 RID: 54215 RVA: 0x00064232 File Offset: 0x00062432
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004072 RID: 16498
			// (get) Token: 0x0600D3C8 RID: 54216 RVA: 0x0034CBA0 File Offset: 0x0034ADA0
			// (set) Token: 0x0600D3C9 RID: 54217 RVA: 0x0006424D File Offset: 0x0006244D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004073 RID: 16499
			// (get) Token: 0x0600D3CA RID: 54218 RVA: 0x0034CBD0 File Offset: 0x0034ADD0
			// (set) Token: 0x0600D3CB RID: 54219 RVA: 0x0006426C File Offset: 0x0006246C
			public unsafe IconCreator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconCreator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004074 RID: 16500
			// (get) Token: 0x0600D3CC RID: 54220 RVA: 0x0034CC00 File Offset: 0x0034AE00
			// (set) Token: 0x0600D3CD RID: 54221 RVA: 0x0006428B File Offset: 0x0006248B
			public unsafe string objectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_objectName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_objectName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004075 RID: 16501
			// (get) Token: 0x0600D3CE RID: 54222 RVA: 0x0034CC28 File Offset: 0x0034AE28
			// (set) Token: 0x0600D3CF RID: 54223 RVA: 0x000642AA File Offset: 0x000624AA
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreator._CaptureFrame_d__30.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x04009034 RID: 36916
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009035 RID: 36917
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009036 RID: 36918
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009037 RID: 36919
			private static readonly IntPtr NativeFieldInfoPtr_objectName;

			// Token: 0x04009038 RID: 36920
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04009039 RID: 36921
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400903A RID: 36922
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400903B RID: 36923
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400903C RID: 36924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400903D RID: 36925
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400903E RID: 36926
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

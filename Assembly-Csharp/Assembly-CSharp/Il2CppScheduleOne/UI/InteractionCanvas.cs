using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200073C RID: 1852
	public class InteractionCanvas : Singleton<InteractionCanvas>
	{
		// Token: 0x0600B31A RID: 45850 RVA: 0x002EA1E8 File Offset: 0x002E83E8
		// Note: this type is marked as 'beforefieldinit'.
		static InteractionCanvas()
		{
			Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "InteractionCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr);
			InteractionCanvas.NativeFieldInfoPtr_DisplayScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "DisplayScaleMultiplier");
			InteractionCanvas.NativeFieldInfoPtr_DisplayScale3DBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "DisplayScale3DBlend");
			InteractionCanvas.NativeFieldInfoPtr__DisplayScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "<DisplayScale>k__BackingField");
			InteractionCanvas.NativeFieldInfoPtr_DefaultMessageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "DefaultMessageColor");
			InteractionCanvas.NativeFieldInfoPtr_DefaultIconColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "DefaultIconColor");
			InteractionCanvas.NativeFieldInfoPtr_DefaultKeyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "DefaultKeyColor");
			InteractionCanvas.NativeFieldInfoPtr_InvalidMessageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "InvalidMessageColor");
			InteractionCanvas.NativeFieldInfoPtr_InvalidIconColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "InvalidIconColor");
			InteractionCanvas.NativeFieldInfoPtr_KeyIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "KeyIcon");
			InteractionCanvas.NativeFieldInfoPtr_LeftMouseIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "LeftMouseIcon");
			InteractionCanvas.NativeFieldInfoPtr_CrossIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "CrossIcon");
			InteractionCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "Canvas");
			InteractionCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "Container");
			InteractionCanvas.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "Icon");
			InteractionCanvas.NativeFieldInfoPtr_IconText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "IconText");
			InteractionCanvas.NativeFieldInfoPtr_MessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "MessageText");
			InteractionCanvas.NativeFieldInfoPtr_Layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "Layout");
			InteractionCanvas.NativeFieldInfoPtr_WSLabelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "WSLabelContainer");
			InteractionCanvas.NativeFieldInfoPtr_BackgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "BackgroundImage");
			InteractionCanvas.NativeFieldInfoPtr_WSLabelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "WSLabelPrefab");
			InteractionCanvas.NativeFieldInfoPtr__interactionDisplayEnabledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "_interactionDisplayEnabledThisFrame");
			InteractionCanvas.NativeFieldInfoPtr__displayScaleLerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "_displayScaleLerpRoutine");
			InteractionCanvas.NativeFieldInfoPtr__currentDescriptorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "_currentDescriptorData");
			InteractionCanvas.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "_isActive");
			InteractionCanvas.NativeFieldInfoPtr_ActiveWSlabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "ActiveWSlabels");
			InteractionCanvas.NativeMethodInfoPtr_get_DisplayScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686815);
			InteractionCanvas.NativeMethodInfoPtr_set_DisplayScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686816);
			InteractionCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686817);
			InteractionCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686818);
			InteractionCanvas.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686819);
			InteractionCanvas.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686820);
			InteractionCanvas.NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_String_Color_Sprite_Color_String_Single_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686821);
			InteractionCanvas.NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686822);
			InteractionCanvas.NativeMethodInfoPtr_SetIcon_Public_Void_Sprite_Color_String_Single_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686823);
			InteractionCanvas.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686824);
			InteractionCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686825);
			InteractionCanvas.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, 100686826);
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x0600B31B RID: 45851 RVA: 0x002EA4FC File Offset: 0x002E86FC
		// (set) Token: 0x0600B31C RID: 45852 RVA: 0x002EA538 File Offset: 0x002E8738
		public unsafe float DisplayScale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55725, RefRangeEnd = 55726, XrefRangeStart = 55725, XrefRangeEnd = 55726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.NativeMethodInfoPtr_get_DisplayScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.NativeMethodInfoPtr_set_DisplayScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B31D RID: 45853 RVA: 0x002EA578 File Offset: 0x002E8778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302608, XrefRangeEnd = 302611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x002EA5B4 File Offset: 0x002E87B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302611, XrefRangeEnd = 302624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x002EA5E8 File Offset: 0x002E87E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302624, XrefRangeEnd = 302630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionCanvas.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B320 RID: 45856 RVA: 0x002EA624 File Offset: 0x002E8824
		[CallerCount(0)]
		public unsafe void SetActive(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B321 RID: 45857 RVA: 0x002EA664 File Offset: 0x002E8864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302630, XrefRangeEnd = 302660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableInteractionDisplay(Vector3 position, string message, Color messageColor, Sprite sprite, Color spriteColor, string spriteText, float spritePixelMultiplier, Vector2 spriteSize, bool enableBackdrop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref messageColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spriteColor;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spriteText);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spritePixelMultiplier;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spriteSize;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableBackdrop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_String_Color_Sprite_Color_String_Single_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B322 RID: 45858 RVA: 0x002EA724 File Offset: 0x002E8924
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302668, RefRangeEnd = 302670, XrefRangeStart = 302660, XrefRangeEnd = 302668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpDisplayScale(float endScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B323 RID: 45859 RVA: 0x002EA764 File Offset: 0x002E8964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302679, RefRangeEnd = 302680, XrefRangeStart = 302670, XrefRangeEnd = 302679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIcon(Sprite sprite, Color spriteColor, string spriteText, float spritePixelMultiplier, Vector2 spriteSize, bool enableBackdrop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spriteColor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spriteText);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spritePixelMultiplier;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spriteSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableBackdrop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.NativeMethodInfoPtr_SetIcon_Public_Void_Sprite_Color_String_Single_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B324 RID: 45860 RVA: 0x002EA7F0 File Offset: 0x002E89F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302680, XrefRangeEnd = 302683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionCanvas.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B325 RID: 45861 RVA: 0x002EA82C File Offset: 0x002E8A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302683, XrefRangeEnd = 302693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractionCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B326 RID: 45862 RVA: 0x002EA868 File Offset: 0x002E8A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302693, XrefRangeEnd = 302698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_Single_PDM_0(float startScale, float endScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startScale;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B327 RID: 45863 RVA: 0x00052903 File Offset: 0x00050B03
		public InteractionCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x0600B328 RID: 45864 RVA: 0x002EA8C4 File Offset: 0x002E8AC4
		// (set) Token: 0x0600B329 RID: 45865 RVA: 0x0005290C File Offset: 0x00050B0C
		public unsafe static float DisplayScaleMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionCanvas.NativeFieldInfoPtr_DisplayScaleMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionCanvas.NativeFieldInfoPtr_DisplayScaleMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x0600B32A RID: 45866 RVA: 0x002EA8E0 File Offset: 0x002E8AE0
		// (set) Token: 0x0600B32B RID: 45867 RVA: 0x0005291A File Offset: 0x00050B1A
		public unsafe static float DisplayScale3DBlend
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionCanvas.NativeFieldInfoPtr_DisplayScale3DBlend, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionCanvas.NativeFieldInfoPtr_DisplayScale3DBlend, (void*)(&value));
			}
		}

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x0600B32C RID: 45868 RVA: 0x002EA8FC File Offset: 0x002E8AFC
		// (set) Token: 0x0600B32D RID: 45869 RVA: 0x00052928 File Offset: 0x00050B28
		public unsafe float _DisplayScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr__DisplayScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr__DisplayScale_k__BackingField)) = value;
			}
		}

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x0600B32E RID: 45870 RVA: 0x002EA924 File Offset: 0x002E8B24
		// (set) Token: 0x0600B32F RID: 45871 RVA: 0x00052943 File Offset: 0x00050B43
		public unsafe Color DefaultMessageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_DefaultMessageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_DefaultMessageColor)) = value;
			}
		}

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x0600B330 RID: 45872 RVA: 0x002EA94C File Offset: 0x002E8B4C
		// (set) Token: 0x0600B331 RID: 45873 RVA: 0x0005295E File Offset: 0x00050B5E
		public unsafe Color DefaultIconColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_DefaultIconColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_DefaultIconColor)) = value;
			}
		}

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x0600B332 RID: 45874 RVA: 0x002EA974 File Offset: 0x002E8B74
		// (set) Token: 0x0600B333 RID: 45875 RVA: 0x00052979 File Offset: 0x00050B79
		public unsafe Color DefaultKeyColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_DefaultKeyColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_DefaultKeyColor)) = value;
			}
		}

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0600B334 RID: 45876 RVA: 0x002EA99C File Offset: 0x002E8B9C
		// (set) Token: 0x0600B335 RID: 45877 RVA: 0x00052994 File Offset: 0x00050B94
		public unsafe Color InvalidMessageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_InvalidMessageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_InvalidMessageColor)) = value;
			}
		}

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0600B336 RID: 45878 RVA: 0x002EA9C4 File Offset: 0x002E8BC4
		// (set) Token: 0x0600B337 RID: 45879 RVA: 0x000529AF File Offset: 0x00050BAF
		public unsafe Color InvalidIconColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_InvalidIconColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_InvalidIconColor)) = value;
			}
		}

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0600B338 RID: 45880 RVA: 0x002EA9EC File Offset: 0x002E8BEC
		// (set) Token: 0x0600B339 RID: 45881 RVA: 0x000529CA File Offset: 0x00050BCA
		public unsafe Sprite KeyIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_KeyIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_KeyIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x0600B33A RID: 45882 RVA: 0x002EAA1C File Offset: 0x002E8C1C
		// (set) Token: 0x0600B33B RID: 45883 RVA: 0x000529E9 File Offset: 0x00050BE9
		public unsafe Sprite LeftMouseIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_LeftMouseIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_LeftMouseIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0600B33C RID: 45884 RVA: 0x002EAA4C File Offset: 0x002E8C4C
		// (set) Token: 0x0600B33D RID: 45885 RVA: 0x00052A08 File Offset: 0x00050C08
		public unsafe Sprite CrossIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_CrossIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_CrossIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0600B33E RID: 45886 RVA: 0x002EAA7C File Offset: 0x002E8C7C
		// (set) Token: 0x0600B33F RID: 45887 RVA: 0x00052A27 File Offset: 0x00050C27
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0600B340 RID: 45888 RVA: 0x002EAAAC File Offset: 0x002E8CAC
		// (set) Token: 0x0600B341 RID: 45889 RVA: 0x00052A46 File Offset: 0x00050C46
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0600B342 RID: 45890 RVA: 0x002EAADC File Offset: 0x002E8CDC
		// (set) Token: 0x0600B343 RID: 45891 RVA: 0x00052A65 File Offset: 0x00050C65
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0600B344 RID: 45892 RVA: 0x002EAB0C File Offset: 0x002E8D0C
		// (set) Token: 0x0600B345 RID: 45893 RVA: 0x00052A84 File Offset: 0x00050C84
		public unsafe TextMeshProUGUI IconText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_IconText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_IconText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0600B346 RID: 45894 RVA: 0x002EAB3C File Offset: 0x002E8D3C
		// (set) Token: 0x0600B347 RID: 45895 RVA: 0x00052AA3 File Offset: 0x00050CA3
		public unsafe TextMeshProUGUI MessageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_MessageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_MessageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0600B348 RID: 45896 RVA: 0x002EAB6C File Offset: 0x002E8D6C
		// (set) Token: 0x0600B349 RID: 45897 RVA: 0x00052AC2 File Offset: 0x00050CC2
		public unsafe LayoutElement Layout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_Layout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_Layout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x0600B34A RID: 45898 RVA: 0x002EAB9C File Offset: 0x002E8D9C
		// (set) Token: 0x0600B34B RID: 45899 RVA: 0x00052AE1 File Offset: 0x00050CE1
		public unsafe RectTransform WSLabelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_WSLabelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_WSLabelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0600B34C RID: 45900 RVA: 0x002EABCC File Offset: 0x002E8DCC
		// (set) Token: 0x0600B34D RID: 45901 RVA: 0x00052B00 File Offset: 0x00050D00
		public unsafe RectTransform BackgroundImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_BackgroundImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_BackgroundImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0600B34E RID: 45902 RVA: 0x002EABFC File Offset: 0x002E8DFC
		// (set) Token: 0x0600B34F RID: 45903 RVA: 0x00052B1F File Offset: 0x00050D1F
		public unsafe GameObject WSLabelPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_WSLabelPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_WSLabelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0600B350 RID: 45904 RVA: 0x002EAC2C File Offset: 0x002E8E2C
		// (set) Token: 0x0600B351 RID: 45905 RVA: 0x00052B3E File Offset: 0x00050D3E
		public unsafe bool _interactionDisplayEnabledThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr__interactionDisplayEnabledThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr__interactionDisplayEnabledThisFrame)) = value;
			}
		}

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0600B352 RID: 45906 RVA: 0x002EAC54 File Offset: 0x002E8E54
		// (set) Token: 0x0600B353 RID: 45907 RVA: 0x00052B59 File Offset: 0x00050D59
		public unsafe Coroutine _displayScaleLerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr__displayScaleLerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr__displayScaleLerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0600B354 RID: 45908 RVA: 0x002EAC84 File Offset: 0x002E8E84
		// (set) Token: 0x0600B355 RID: 45909 RVA: 0x00052B78 File Offset: 0x00050D78
		public unsafe InputPromptsDescriptorData _currentDescriptorData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr__currentDescriptorData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsDescriptorData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr__currentDescriptorData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0600B356 RID: 45910 RVA: 0x002EACB4 File Offset: 0x002E8EB4
		// (set) Token: 0x0600B357 RID: 45911 RVA: 0x00052B97 File Offset: 0x00050D97
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0600B358 RID: 45912 RVA: 0x002EACDC File Offset: 0x002E8EDC
		// (set) Token: 0x0600B359 RID: 45913 RVA: 0x00052BB2 File Offset: 0x00050DB2
		public unsafe List<WorldSpaceLabel> ActiveWSlabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_ActiveWSlabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldSpaceLabel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.NativeFieldInfoPtr_ActiveWSlabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007B4C RID: 31564
		private static readonly IntPtr NativeFieldInfoPtr_DisplayScaleMultiplier;

		// Token: 0x04007B4D RID: 31565
		private static readonly IntPtr NativeFieldInfoPtr_DisplayScale3DBlend;

		// Token: 0x04007B4E RID: 31566
		private static readonly IntPtr NativeFieldInfoPtr__DisplayScale_k__BackingField;

		// Token: 0x04007B4F RID: 31567
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMessageColor;

		// Token: 0x04007B50 RID: 31568
		private static readonly IntPtr NativeFieldInfoPtr_DefaultIconColor;

		// Token: 0x04007B51 RID: 31569
		private static readonly IntPtr NativeFieldInfoPtr_DefaultKeyColor;

		// Token: 0x04007B52 RID: 31570
		private static readonly IntPtr NativeFieldInfoPtr_InvalidMessageColor;

		// Token: 0x04007B53 RID: 31571
		private static readonly IntPtr NativeFieldInfoPtr_InvalidIconColor;

		// Token: 0x04007B54 RID: 31572
		private static readonly IntPtr NativeFieldInfoPtr_KeyIcon;

		// Token: 0x04007B55 RID: 31573
		private static readonly IntPtr NativeFieldInfoPtr_LeftMouseIcon;

		// Token: 0x04007B56 RID: 31574
		private static readonly IntPtr NativeFieldInfoPtr_CrossIcon;

		// Token: 0x04007B57 RID: 31575
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007B58 RID: 31576
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007B59 RID: 31577
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04007B5A RID: 31578
		private static readonly IntPtr NativeFieldInfoPtr_IconText;

		// Token: 0x04007B5B RID: 31579
		private static readonly IntPtr NativeFieldInfoPtr_MessageText;

		// Token: 0x04007B5C RID: 31580
		private static readonly IntPtr NativeFieldInfoPtr_Layout;

		// Token: 0x04007B5D RID: 31581
		private static readonly IntPtr NativeFieldInfoPtr_WSLabelContainer;

		// Token: 0x04007B5E RID: 31582
		private static readonly IntPtr NativeFieldInfoPtr_BackgroundImage;

		// Token: 0x04007B5F RID: 31583
		private static readonly IntPtr NativeFieldInfoPtr_WSLabelPrefab;

		// Token: 0x04007B60 RID: 31584
		private static readonly IntPtr NativeFieldInfoPtr__interactionDisplayEnabledThisFrame;

		// Token: 0x04007B61 RID: 31585
		private static readonly IntPtr NativeFieldInfoPtr__displayScaleLerpRoutine;

		// Token: 0x04007B62 RID: 31586
		private static readonly IntPtr NativeFieldInfoPtr__currentDescriptorData;

		// Token: 0x04007B63 RID: 31587
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x04007B64 RID: 31588
		private static readonly IntPtr NativeFieldInfoPtr_ActiveWSlabels;

		// Token: 0x04007B65 RID: 31589
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayScale_Public_get_Single_0;

		// Token: 0x04007B66 RID: 31590
		private static readonly IntPtr NativeMethodInfoPtr_set_DisplayScale_Public_set_Void_Single_0;

		// Token: 0x04007B67 RID: 31591
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007B68 RID: 31592
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007B69 RID: 31593
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04007B6A RID: 31594
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x04007B6B RID: 31595
		private static readonly IntPtr NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_String_Color_Sprite_Color_String_Single_Vector2_Boolean_0;

		// Token: 0x04007B6C RID: 31596
		private static readonly IntPtr NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0;

		// Token: 0x04007B6D RID: 31597
		private static readonly IntPtr NativeMethodInfoPtr_SetIcon_Public_Void_Sprite_Color_String_Single_Vector2_Boolean_0;

		// Token: 0x04007B6E RID: 31598
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04007B6F RID: 31599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007B70 RID: 31600
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Single_PDM_0;

		// Token: 0x02000CD1 RID: 3281
		[ObfuscatedName("ScheduleOne.UI.InteractionCanvas+<<LerpDisplayScale>g__ILerpDisplayScale|33_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F52E RID: 62766 RVA: 0x003AE5C0 File Offset: 0x003AC7C0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique()
			{
				Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionCanvas>.NativeClassPtr, "<<LerpDisplayScale>g__ILerpDisplayScale|33_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr);
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, "<>1__state");
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, "<>2__current");
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, "startScale");
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, "endScale");
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, "<>4__this");
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, "<lerpTime>5__2");
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, "<i>5__3");
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, 100686827);
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, 100686828);
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, 100686829);
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, 100686830);
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, 100686831);
				InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr, 100686832);
			}

			// Token: 0x0600F52F RID: 62767 RVA: 0x003AE6F0 File Offset: 0x003AC8F0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F530 RID: 62768 RVA: 0x003AE738 File Offset: 0x003AC938
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F531 RID: 62769 RVA: 0x003AE76C File Offset: 0x003AC96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302595, XrefRangeEnd = 302603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004A81 RID: 19073
			// (get) Token: 0x0600F532 RID: 62770 RVA: 0x003AE7A8 File Offset: 0x003AC9A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F533 RID: 62771 RVA: 0x003AE7E8 File Offset: 0x003AC9E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302603, XrefRangeEnd = 302608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A82 RID: 19074
			// (get) Token: 0x0600F534 RID: 62772 RVA: 0x003AE81C File Offset: 0x003ACA1C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F535 RID: 62773 RVA: 0x00073E18 File Offset: 0x00072018
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A7A RID: 19066
			// (get) Token: 0x0600F536 RID: 62774 RVA: 0x003AE85C File Offset: 0x003ACA5C
			// (set) Token: 0x0600F537 RID: 62775 RVA: 0x00073E21 File Offset: 0x00072021
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A7B RID: 19067
			// (get) Token: 0x0600F538 RID: 62776 RVA: 0x003AE884 File Offset: 0x003ACA84
			// (set) Token: 0x0600F539 RID: 62777 RVA: 0x00073E3C File Offset: 0x0007203C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A7C RID: 19068
			// (get) Token: 0x0600F53A RID: 62778 RVA: 0x003AE8B4 File Offset: 0x003ACAB4
			// (set) Token: 0x0600F53B RID: 62779 RVA: 0x00073E5B File Offset: 0x0007205B
			public unsafe float startScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x17004A7D RID: 19069
			// (get) Token: 0x0600F53C RID: 62780 RVA: 0x003AE8DC File Offset: 0x003ACADC
			// (set) Token: 0x0600F53D RID: 62781 RVA: 0x00073E76 File Offset: 0x00072076
			public unsafe float endScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x17004A7E RID: 19070
			// (get) Token: 0x0600F53E RID: 62782 RVA: 0x003AE904 File Offset: 0x003ACB04
			// (set) Token: 0x0600F53F RID: 62783 RVA: 0x00073E91 File Offset: 0x00072091
			public unsafe InteractionCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractionCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A7F RID: 19071
			// (get) Token: 0x0600F540 RID: 62784 RVA: 0x003AE934 File Offset: 0x003ACB34
			// (set) Token: 0x0600F541 RID: 62785 RVA: 0x00073EB0 File Offset: 0x000720B0
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004A80 RID: 19072
			// (get) Token: 0x0600F542 RID: 62786 RVA: 0x003AE95C File Offset: 0x003ACB5C
			// (set) Token: 0x0600F543 RID: 62787 RVA: 0x00073ECB File Offset: 0x000720CB
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSistenSiInObSiObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400A5E6 RID: 42470
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A5E7 RID: 42471
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A5E8 RID: 42472
			private static readonly IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x0400A5E9 RID: 42473
			private static readonly IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x0400A5EA RID: 42474
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A5EB RID: 42475
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x0400A5EC RID: 42476
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400A5ED RID: 42477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A5EE RID: 42478
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A5EF RID: 42479
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A5F0 RID: 42480
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A5F1 RID: 42481
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A5F2 RID: 42482
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

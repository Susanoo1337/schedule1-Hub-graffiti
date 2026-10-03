using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002C4 RID: 708
	public class POI : MonoBehaviour
	{
		// Token: 0x060036D5 RID: 14037 RVA: 0x00131670 File Offset: 0x0012F870
		// Note: this type is marked as 'beforefieldinit'.
		static POI()
		{
			Il2CppClassPointerStore<POI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "POI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI>.NativeClassPtr);
			POI.NativeFieldInfoPtr__UISetup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<UISetup>k__BackingField");
			POI.NativeFieldInfoPtr_MainTextVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "MainTextVisibility");
			POI.NativeFieldInfoPtr_DefaultMainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "DefaultMainText");
			POI.NativeFieldInfoPtr_AutoUpdatePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "AutoUpdatePosition");
			POI.NativeFieldInfoPtr_Rotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "Rotate");
			POI.NativeFieldInfoPtr__MainText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<MainText>k__BackingField");
			POI.NativeFieldInfoPtr_UIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "UIPrefab");
			POI.NativeFieldInfoPtr__UI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<UI>k__BackingField");
			POI.NativeFieldInfoPtr__IconContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<IconContainer>k__BackingField");
			POI.NativeFieldInfoPtr__FontSetter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "<FontSetter>k__BackingField");
			POI.NativeFieldInfoPtr_mainLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "mainLabel");
			POI.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "button");
			POI.NativeFieldInfoPtr_eventTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "eventTrigger");
			POI.NativeFieldInfoPtr_mainTextSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "mainTextSet");
			POI.NativeFieldInfoPtr_onUICreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI>.NativeClassPtr, "onUICreated");
			POI.NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670222);
			POI.NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670223);
			POI.NativeMethodInfoPtr_get_MainText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670224);
			POI.NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670225);
			POI.NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670226);
			POI.NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670227);
			POI.NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670228);
			POI.NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670229);
			POI.NativeMethodInfoPtr_get_FontSetter_Public_get_FontSetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670230);
			POI.NativeMethodInfoPtr_set_FontSetter_Protected_set_Void_FontSetter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670231);
			POI.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670232);
			POI.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670233);
			POI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670234);
			POI.NativeMethodInfoPtr_SetMainText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670235);
			POI.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670236);
			POI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670237);
			POI.NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670238);
			POI.NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670239);
			POI.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670240);
			POI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670241);
			POI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670242);
			POI.NativeMethodInfoPtr__InitializeUI_b__36_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670243);
			POI.NativeMethodInfoPtr__InitializeUI_b__36_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670244);
			POI.NativeMethodInfoPtr__InitializeUI_b__36_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI>.NativeClassPtr, 100670245);
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x060036D6 RID: 14038 RVA: 0x001319AC File Offset: 0x0012FBAC
		// (set) Token: 0x060036D7 RID: 14039 RVA: 0x001319E8 File Offset: 0x0012FBE8
		public unsafe bool UISetup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x00131A28 File Offset: 0x0012FC28
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x00131A60 File Offset: 0x0012FC60
		public unsafe string MainText
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_MainText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x00131AA4 File Offset: 0x0012FCA4
		// (set) Token: 0x060036DB RID: 14043 RVA: 0x00131AE4 File Offset: 0x0012FCE4
		public unsafe RectTransform UI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x00131B28 File Offset: 0x0012FD28
		// (set) Token: 0x060036DD RID: 14045 RVA: 0x00131B68 File Offset: 0x0012FD68
		public unsafe RectTransform IconContainer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x060036DE RID: 14046 RVA: 0x00131BAC File Offset: 0x0012FDAC
		// (set) Token: 0x060036DF RID: 14047 RVA: 0x00131BEC File Offset: 0x0012FDEC
		public unsafe FontSetter FontSetter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_get_FontSetter_Public_get_FontSetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FontSetter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_set_FontSetter_Protected_set_Void_FontSetter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x00131C30 File Offset: 0x0012FE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142689, XrefRangeEnd = 142718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x00131C64 File Offset: 0x0012FE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142718, XrefRangeEnd = 142733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x00131C98 File Offset: 0x0012FE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142733, XrefRangeEnd = 142740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x00131CCC File Offset: 0x0012FECC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 142745, RefRangeEnd = 142761, XrefRangeStart = 142740, XrefRangeEnd = 142745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMainText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_SetMainText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00131D10 File Offset: 0x0012FF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142761, XrefRangeEnd = 142786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00131D4C File Offset: 0x0012FF4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142879, RefRangeEnd = 142880, XrefRangeStart = 142786, XrefRangeEnd = 142879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00131D88 File Offset: 0x0012FF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142880, XrefRangeEnd = 142881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x00131DC4 File Offset: 0x0012FFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142881, XrefRangeEnd = 142882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x00131E00 File Offset: 0x00130000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142882, XrefRangeEnd = 142892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), POI.NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00131E3C File Offset: 0x0013003C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe POI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00131E78 File Offset: 0x00130078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142892, XrefRangeEnd = 142897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00131EB8 File Offset: 0x001300B8
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 142897, RefRangeEnd = 142934, XrefRangeStart = 142897, XrefRangeEnd = 142897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitializeUI_b__36_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__36_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00131EFC File Offset: 0x001300FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 33113, RefRangeEnd = 33120, XrefRangeStart = 33113, XrefRangeEnd = 33120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitializeUI_b__36_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__36_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00131F40 File Offset: 0x00130140
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 73596, RefRangeEnd = 73622, XrefRangeStart = 73596, XrefRangeEnd = 73622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _InitializeUI_b__36_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.NativeMethodInfoPtr__InitializeUI_b__36_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x0001BDED File Offset: 0x00019FED
		public POI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x060036EF RID: 14063 RVA: 0x00131F74 File Offset: 0x00130174
		// (set) Token: 0x060036F0 RID: 14064 RVA: 0x0001BDF6 File Offset: 0x00019FF6
		public unsafe bool _UISetup_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UISetup_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UISetup_k__BackingField)) = value;
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x060036F1 RID: 14065 RVA: 0x00131F9C File Offset: 0x0013019C
		// (set) Token: 0x060036F2 RID: 14066 RVA: 0x0001BE11 File Offset: 0x0001A011
		public unsafe POI.TextShowMode MainTextVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_MainTextVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_MainTextVisibility)) = value;
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x060036F3 RID: 14067 RVA: 0x00131FC4 File Offset: 0x001301C4
		// (set) Token: 0x060036F4 RID: 14068 RVA: 0x0001BE2C File Offset: 0x0001A02C
		public unsafe string DefaultMainText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_DefaultMainText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_DefaultMainText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x060036F5 RID: 14069 RVA: 0x00131FEC File Offset: 0x001301EC
		// (set) Token: 0x060036F6 RID: 14070 RVA: 0x0001BE4B File Offset: 0x0001A04B
		public unsafe bool AutoUpdatePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_AutoUpdatePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_AutoUpdatePosition)) = value;
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x060036F7 RID: 14071 RVA: 0x00132014 File Offset: 0x00130214
		// (set) Token: 0x060036F8 RID: 14072 RVA: 0x0001BE66 File Offset: 0x0001A066
		public unsafe bool Rotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_Rotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_Rotate)) = value;
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x060036F9 RID: 14073 RVA: 0x0013203C File Offset: 0x0013023C
		// (set) Token: 0x060036FA RID: 14074 RVA: 0x0001BE81 File Offset: 0x0001A081
		public unsafe string _MainText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__MainText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__MainText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x060036FB RID: 14075 RVA: 0x00132064 File Offset: 0x00130264
		// (set) Token: 0x060036FC RID: 14076 RVA: 0x0001BEA0 File Offset: 0x0001A0A0
		public unsafe GameObject UIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_UIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_UIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x060036FD RID: 14077 RVA: 0x00132094 File Offset: 0x00130294
		// (set) Token: 0x060036FE RID: 14078 RVA: 0x0001BEBF File Offset: 0x0001A0BF
		public unsafe RectTransform _UI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__UI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x060036FF RID: 14079 RVA: 0x001320C4 File Offset: 0x001302C4
		// (set) Token: 0x06003700 RID: 14080 RVA: 0x0001BEDE File Offset: 0x0001A0DE
		public unsafe RectTransform _IconContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__IconContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__IconContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x001320F4 File Offset: 0x001302F4
		// (set) Token: 0x06003702 RID: 14082 RVA: 0x0001BEFD File Offset: 0x0001A0FD
		public unsafe FontSetter _FontSetter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__FontSetter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FontSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr__FontSetter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x00132124 File Offset: 0x00130324
		// (set) Token: 0x06003704 RID: 14084 RVA: 0x0001BF1C File Offset: 0x0001A11C
		public unsafe Text mainLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x00132154 File Offset: 0x00130354
		// (set) Token: 0x06003706 RID: 14086 RVA: 0x0001BF3B File Offset: 0x0001A13B
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06003707 RID: 14087 RVA: 0x00132184 File Offset: 0x00130384
		// (set) Token: 0x06003708 RID: 14088 RVA: 0x0001BF5A File Offset: 0x0001A15A
		public unsafe EventTrigger eventTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_eventTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_eventTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06003709 RID: 14089 RVA: 0x001321B4 File Offset: 0x001303B4
		// (set) Token: 0x0600370A RID: 14090 RVA: 0x0001BF79 File Offset: 0x0001A179
		public unsafe bool mainTextSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainTextSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_mainTextSet)) = value;
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x001321DC File Offset: 0x001303DC
		// (set) Token: 0x0600370C RID: 14092 RVA: 0x0001BF94 File Offset: 0x0001A194
		public unsafe UnityEvent onUICreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_onUICreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.NativeFieldInfoPtr_onUICreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024AF RID: 9391
		private static readonly IntPtr NativeFieldInfoPtr__UISetup_k__BackingField;

		// Token: 0x040024B0 RID: 9392
		private static readonly IntPtr NativeFieldInfoPtr_MainTextVisibility;

		// Token: 0x040024B1 RID: 9393
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMainText;

		// Token: 0x040024B2 RID: 9394
		private static readonly IntPtr NativeFieldInfoPtr_AutoUpdatePosition;

		// Token: 0x040024B3 RID: 9395
		private static readonly IntPtr NativeFieldInfoPtr_Rotate;

		// Token: 0x040024B4 RID: 9396
		private static readonly IntPtr NativeFieldInfoPtr__MainText_k__BackingField;

		// Token: 0x040024B5 RID: 9397
		private static readonly IntPtr NativeFieldInfoPtr_UIPrefab;

		// Token: 0x040024B6 RID: 9398
		private static readonly IntPtr NativeFieldInfoPtr__UI_k__BackingField;

		// Token: 0x040024B7 RID: 9399
		private static readonly IntPtr NativeFieldInfoPtr__IconContainer_k__BackingField;

		// Token: 0x040024B8 RID: 9400
		private static readonly IntPtr NativeFieldInfoPtr__FontSetter_k__BackingField;

		// Token: 0x040024B9 RID: 9401
		private static readonly IntPtr NativeFieldInfoPtr_mainLabel;

		// Token: 0x040024BA RID: 9402
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x040024BB RID: 9403
		private static readonly IntPtr NativeFieldInfoPtr_eventTrigger;

		// Token: 0x040024BC RID: 9404
		private static readonly IntPtr NativeFieldInfoPtr_mainTextSet;

		// Token: 0x040024BD RID: 9405
		private static readonly IntPtr NativeFieldInfoPtr_onUICreated;

		// Token: 0x040024BE RID: 9406
		private static readonly IntPtr NativeMethodInfoPtr_get_UISetup_Public_get_Boolean_0;

		// Token: 0x040024BF RID: 9407
		private static readonly IntPtr NativeMethodInfoPtr_set_UISetup_Protected_set_Void_Boolean_0;

		// Token: 0x040024C0 RID: 9408
		private static readonly IntPtr NativeMethodInfoPtr_get_MainText_Public_get_String_0;

		// Token: 0x040024C1 RID: 9409
		private static readonly IntPtr NativeMethodInfoPtr_set_MainText_Protected_set_Void_String_0;

		// Token: 0x040024C2 RID: 9410
		private static readonly IntPtr NativeMethodInfoPtr_get_UI_Public_get_RectTransform_0;

		// Token: 0x040024C3 RID: 9411
		private static readonly IntPtr NativeMethodInfoPtr_set_UI_Protected_set_Void_RectTransform_0;

		// Token: 0x040024C4 RID: 9412
		private static readonly IntPtr NativeMethodInfoPtr_get_IconContainer_Public_get_RectTransform_0;

		// Token: 0x040024C5 RID: 9413
		private static readonly IntPtr NativeMethodInfoPtr_set_IconContainer_Protected_set_Void_RectTransform_0;

		// Token: 0x040024C6 RID: 9414
		private static readonly IntPtr NativeMethodInfoPtr_get_FontSetter_Public_get_FontSetter_0;

		// Token: 0x040024C7 RID: 9415
		private static readonly IntPtr NativeMethodInfoPtr_set_FontSetter_Protected_set_Void_FontSetter_0;

		// Token: 0x040024C8 RID: 9416
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040024C9 RID: 9417
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040024CA RID: 9418
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040024CB RID: 9419
		private static readonly IntPtr NativeMethodInfoPtr_SetMainText_Public_Void_String_0;

		// Token: 0x040024CC RID: 9420
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Public_Virtual_New_Void_0;

		// Token: 0x040024CD RID: 9421
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUI_Public_Virtual_New_Void_0;

		// Token: 0x040024CE RID: 9422
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Protected_Virtual_New_Void_0;

		// Token: 0x040024CF RID: 9423
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Protected_Virtual_New_Void_0;

		// Token: 0x040024D0 RID: 9424
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Protected_Virtual_New_Void_0;

		// Token: 0x040024D1 RID: 9425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040024D2 RID: 9426
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040024D3 RID: 9427
		private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__36_0_Private_Void_BaseEventData_0;

		// Token: 0x040024D4 RID: 9428
		private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__36_1_Private_Void_BaseEventData_0;

		// Token: 0x040024D5 RID: 9429
		private static readonly IntPtr NativeMethodInfoPtr__InitializeUI_b__36_2_Private_Void_0;

		// Token: 0x02000A18 RID: 2584
		[OriginalName("Assembly-CSharp.dll", "", "TextShowMode")]
		public enum TextShowMode
		{
			// Token: 0x04009771 RID: 38769
			Off,
			// Token: 0x04009772 RID: 38770
			Always,
			// Token: 0x04009773 RID: 38771
			OnHover
		}

		// Token: 0x02000A19 RID: 2585
		[ObfuscatedName("ScheduleOne.Map.POI+<<OnEnable>g__Wait|31_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DE50 RID: 56912 RVA: 0x0036D2E0 File Offset: 0x0036B4E0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique()
			{
				Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<POI>.NativeClassPtr, "<<OnEnable>g__Wait|31_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>1__state");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>2__current");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, "<>4__this");
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100670246);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100670247);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100670248);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100670249);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100670250);
				POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr, 100670251);
			}

			// Token: 0x0600DE51 RID: 56913 RVA: 0x0036D3C0 File Offset: 0x0036B5C0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE52 RID: 56914 RVA: 0x0036D408 File Offset: 0x0036B608
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE53 RID: 56915 RVA: 0x0036D43C File Offset: 0x0036B63C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142651, XrefRangeEnd = 142676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043B2 RID: 17330
			// (get) Token: 0x0600DE54 RID: 56916 RVA: 0x0036D478 File Offset: 0x0036B678
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE55 RID: 56917 RVA: 0x0036D4B8 File Offset: 0x0036B6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142676, XrefRangeEnd = 142681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043B3 RID: 17331
			// (get) Token: 0x0600DE56 RID: 56918 RVA: 0x0036D4EC File Offset: 0x0036B6EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE57 RID: 56919 RVA: 0x00068A87 File Offset: 0x00066C87
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043AF RID: 17327
			// (get) Token: 0x0600DE58 RID: 56920 RVA: 0x0036D52C File Offset: 0x0036B72C
			// (set) Token: 0x0600DE59 RID: 56921 RVA: 0x00068A90 File Offset: 0x00066C90
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043B0 RID: 17328
			// (get) Token: 0x0600DE5A RID: 56922 RVA: 0x0036D554 File Offset: 0x0036B754
			// (set) Token: 0x0600DE5B RID: 56923 RVA: 0x00068AAB File Offset: 0x00066CAB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B1 RID: 17329
			// (get) Token: 0x0600DE5C RID: 56924 RVA: 0x0036D584 File Offset: 0x0036B784
			// (set) Token: 0x0600DE5D RID: 56925 RVA: 0x00068ACA File Offset: 0x00066CCA
			public unsafe POI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(POI.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPOObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009774 RID: 38772
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009775 RID: 38773
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009776 RID: 38774
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009777 RID: 38775
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009778 RID: 38776
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009779 RID: 38777
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400977A RID: 38778
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400977B RID: 38779
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400977C RID: 38780
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A1A RID: 2586
		[ObfuscatedName("ScheduleOne.Map.POI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DE5E RID: 56926 RVA: 0x0036D5B4 File Offset: 0x0036B7B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<POI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<POI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<POI.__c>.NativeClassPtr);
				POI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, "<>9");
				POI.__c.NativeFieldInfoPtr___9__31_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, "<>9__31_1");
				POI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, 100670253);
				POI.__c.NativeMethodInfoPtr__OnEnable_b__31_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<POI.__c>.NativeClassPtr, 100670254);
			}

			// Token: 0x0600DE5F RID: 56927 RVA: 0x0036D630 File Offset: 0x0036B830
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<POI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE60 RID: 56928 RVA: 0x0036D66C File Offset: 0x0036B86C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142681, XrefRangeEnd = 142689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnEnable_b__31_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(POI.__c.NativeMethodInfoPtr__OnEnable_b__31_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE61 RID: 56929 RVA: 0x00068AE9 File Offset: 0x00066CE9
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B4 RID: 17332
			// (get) Token: 0x0600DE62 RID: 56930 RVA: 0x0036D6A8 File Offset: 0x0036B8A8
			// (set) Token: 0x0600DE63 RID: 56931 RVA: 0x00068AF2 File Offset: 0x00066CF2
			public unsafe static POI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(POI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(POI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B5 RID: 17333
			// (get) Token: 0x0600DE64 RID: 56932 RVA: 0x0036D6D0 File Offset: 0x0036B8D0
			// (set) Token: 0x0600DE65 RID: 56933 RVA: 0x00068B04 File Offset: 0x00066D04
			public unsafe static Func<bool> __9__31_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(POI.__c.NativeFieldInfoPtr___9__31_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(POI.__c.NativeFieldInfoPtr___9__31_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400977D RID: 38781
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400977E RID: 38782
			private static readonly IntPtr NativeFieldInfoPtr___9__31_1;

			// Token: 0x0400977F RID: 38783
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009780 RID: 38784
			private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__31_1_Internal_Boolean_0;
		}
	}
}

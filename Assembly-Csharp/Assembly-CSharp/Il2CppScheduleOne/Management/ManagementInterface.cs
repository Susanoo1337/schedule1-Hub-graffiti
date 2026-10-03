using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management.UI;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020002F0 RID: 752
	public class ManagementInterface : Singleton<ManagementInterface>
	{
		// Token: 0x06003B87 RID: 15239 RVA: 0x00144018 File Offset: 0x00142218
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementInterface()
		{
			Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr);
			ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "PANEL_SLIDE_TIME");
			ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<EquippedClipboard>k__BackingField");
			ManagementInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "Canvas");
			ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "NothingSelectedLabel");
			ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "DifferentTypesSelectedLabel");
			ManagementInterface.NativeFieldInfoPtr_PanelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "PanelContainer");
			ManagementInterface.NativeFieldInfoPtr_MainScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "MainScreen");
			ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ItemSelectorScreen");
			ManagementInterface.NativeFieldInfoPtr_ObjectSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ObjectSelector");
			ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "RecipeSelectorScreen");
			ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "TransitEntitySelector");
			ManagementInterface.NativeFieldInfoPtr_StringSetterScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "StringSetterScreen");
			ManagementInterface.NativeFieldInfoPtr_RenameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "RenameButton");
			ManagementInterface.NativeFieldInfoPtr_UIScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "UIScreen");
			ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ConfigPanelPrefabs");
			ManagementInterface.NativeFieldInfoPtr_Configurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "Configurables");
			ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "areConfigurablesUniform");
			ManagementInterface.NativeFieldInfoPtr_loadedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "loadedPanel");
			ManagementInterface.NativeFieldInfoPtr__lastSelectableIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "_lastSelectableIndex");
			ManagementInterface.NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670937);
			ManagementInterface.NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670938);
			ManagementInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670939);
			ManagementInterface.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670940);
			ManagementInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670941);
			ManagementInterface.NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670942);
			ManagementInterface.NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670943);
			ManagementInterface.NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670944);
			ManagementInterface.NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670945);
			ManagementInterface.NativeMethodInfoPtr_RenameButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670946);
			ManagementInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670947);
			ManagementInterface.NativeMethodInfoPtr_Method_Private_Void_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, 100670948);
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x001442B4 File Offset: 0x001424B4
		// (set) Token: 0x06003B89 RID: 15241 RVA: 0x001442F4 File Offset: 0x001424F4
		public unsafe ManagementClipboard_Equippable EquippedClipboard
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManagementClipboard_Equippable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B8A RID: 15242 RVA: 0x00144338 File Offset: 0x00142538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150294, XrefRangeEnd = 150326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x00144374 File Offset: 0x00142574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150363, RefRangeEnd = 150364, XrefRangeStart = 150326, XrefRangeEnd = 150363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<IConfigurable> configurables, ManagementClipboard_Equippable _equippedClipboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurables);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_equippedClipboard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x001443C8 File Offset: 0x001425C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150382, RefRangeEnd = 150383, XrefRangeStart = 150364, XrefRangeEnd = 150382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool preserveState = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref preserveState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x00144408 File Offset: 0x00142608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150383, XrefRangeEnd = 150389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMainLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x0014443C File Offset: 0x0014263C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150461, RefRangeEnd = 150462, XrefRangeStart = 150389, XrefRangeEnd = 150461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeConfigPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x00144470 File Offset: 0x00142670
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150484, RefRangeEnd = 150486, XrefRangeStart = 150462, XrefRangeEnd = 150484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyConfigPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x001444A4 File Offset: 0x001426A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150499, RefRangeEnd = 150501, XrefRangeStart = 150486, XrefRangeEnd = 150499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigPanel GetConfigPanelPrefab(EConfigurableType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr3) : null;
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x001444F0 File Offset: 0x001426F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150501, XrefRangeEnd = 150536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenameButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_RenameButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x00144524 File Offset: 0x00142724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150536, XrefRangeEnd = 150546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x00144560 File Offset: 0x00142760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150546, XrefRangeEnd = 150568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_String_PDM_0(string newName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.NativeMethodInfoPtr_Method_Private_Void_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x0001DAE1 File Offset: 0x0001BCE1
		public ManagementInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06003B95 RID: 15253 RVA: 0x001445A4 File Offset: 0x001427A4
		// (set) Token: 0x06003B96 RID: 15254 RVA: 0x0001DAEA File Offset: 0x0001BCEA
		public unsafe static float PANEL_SLIDE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementInterface.NativeFieldInfoPtr_PANEL_SLIDE_TIME, (void*)(&value));
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06003B97 RID: 15255 RVA: 0x001445C0 File Offset: 0x001427C0
		// (set) Token: 0x06003B98 RID: 15256 RVA: 0x0001DAF8 File Offset: 0x0001BCF8
		public unsafe ManagementClipboard_Equippable _EquippedClipboard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard_Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr__EquippedClipboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x06003B99 RID: 15257 RVA: 0x001445F0 File Offset: 0x001427F0
		// (set) Token: 0x06003B9A RID: 15258 RVA: 0x0001DB17 File Offset: 0x0001BD17
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06003B9B RID: 15259 RVA: 0x00144620 File Offset: 0x00142820
		// (set) Token: 0x06003B9C RID: 15260 RVA: 0x0001DB36 File Offset: 0x0001BD36
		public unsafe TextMeshProUGUI NothingSelectedLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_NothingSelectedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06003B9D RID: 15261 RVA: 0x00144650 File Offset: 0x00142850
		// (set) Token: 0x06003B9E RID: 15262 RVA: 0x0001DB55 File Offset: 0x0001BD55
		public unsafe TextMeshProUGUI DifferentTypesSelectedLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_DifferentTypesSelectedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x06003B9F RID: 15263 RVA: 0x00144680 File Offset: 0x00142880
		// (set) Token: 0x06003BA0 RID: 15264 RVA: 0x0001DB74 File Offset: 0x0001BD74
		public unsafe RectTransform PanelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_PanelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_PanelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x06003BA1 RID: 15265 RVA: 0x001446B0 File Offset: 0x001428B0
		// (set) Token: 0x06003BA2 RID: 15266 RVA: 0x0001DB93 File Offset: 0x0001BD93
		public unsafe ClipboardScreen MainScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_MainScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_MainScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06003BA3 RID: 15267 RVA: 0x001446E0 File Offset: 0x001428E0
		// (set) Token: 0x06003BA4 RID: 15268 RVA: 0x0001DBB2 File Offset: 0x0001BDB2
		public unsafe ItemSelector ItemSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ItemSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06003BA5 RID: 15269 RVA: 0x00144710 File Offset: 0x00142910
		// (set) Token: 0x06003BA6 RID: 15270 RVA: 0x0001DBD1 File Offset: 0x0001BDD1
		public unsafe ObjectSelector ObjectSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ObjectSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ObjectSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x00144740 File Offset: 0x00142940
		// (set) Token: 0x06003BA8 RID: 15272 RVA: 0x0001DBF0 File Offset: 0x0001BDF0
		public unsafe RecipeSelector RecipeSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_RecipeSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x00144770 File Offset: 0x00142970
		// (set) Token: 0x06003BAA RID: 15274 RVA: 0x0001DC0F File Offset: 0x0001BE0F
		public unsafe TransitEntitySelector TransitEntitySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitEntitySelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_TransitEntitySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06003BAB RID: 15275 RVA: 0x001447A0 File Offset: 0x001429A0
		// (set) Token: 0x06003BAC RID: 15276 RVA: 0x0001DC2E File Offset: 0x0001BE2E
		public unsafe StringSetter StringSetterScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_StringSetterScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_StringSetterScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06003BAD RID: 15277 RVA: 0x001447D0 File Offset: 0x001429D0
		// (set) Token: 0x06003BAE RID: 15278 RVA: 0x0001DC4D File Offset: 0x0001BE4D
		public unsafe Button RenameButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_RenameButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_RenameButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06003BAF RID: 15279 RVA: 0x00144800 File Offset: 0x00142A00
		// (set) Token: 0x06003BB0 RID: 15280 RVA: 0x0001DC6C File Offset: 0x0001BE6C
		public unsafe UIScreen UIScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_UIScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_UIScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06003BB1 RID: 15281 RVA: 0x00144830 File Offset: 0x00142A30
		// (set) Token: 0x06003BB2 RID: 15282 RVA: 0x0001DC8B File Offset: 0x0001BE8B
		public unsafe Il2CppReferenceArray<ManagementInterface.ConfigurableTypePanel> ConfigPanelPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ManagementInterface.ConfigurableTypePanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_ConfigPanelPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x00144860 File Offset: 0x00142A60
		// (set) Token: 0x06003BB4 RID: 15284 RVA: 0x0001DCAA File Offset: 0x0001BEAA
		public unsafe List<IConfigurable> Configurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_Configurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_Configurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06003BB5 RID: 15285 RVA: 0x00144890 File Offset: 0x00142A90
		// (set) Token: 0x06003BB6 RID: 15286 RVA: 0x0001DCC9 File Offset: 0x0001BEC9
		public unsafe bool areConfigurablesUniform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_areConfigurablesUniform)) = value;
			}
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06003BB7 RID: 15287 RVA: 0x001448B8 File Offset: 0x00142AB8
		// (set) Token: 0x06003BB8 RID: 15288 RVA: 0x0001DCE4 File Offset: 0x0001BEE4
		public unsafe ConfigPanel loadedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_loadedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr_loadedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06003BB9 RID: 15289 RVA: 0x001448E8 File Offset: 0x00142AE8
		// (set) Token: 0x06003BBA RID: 15290 RVA: 0x0001DD03 File Offset: 0x0001BF03
		public unsafe int _lastSelectableIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr__lastSelectableIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.NativeFieldInfoPtr__lastSelectableIndex)) = value;
			}
		}

		// Token: 0x04002830 RID: 10288
		private static readonly IntPtr NativeFieldInfoPtr_PANEL_SLIDE_TIME;

		// Token: 0x04002831 RID: 10289
		private static readonly IntPtr NativeFieldInfoPtr__EquippedClipboard_k__BackingField;

		// Token: 0x04002832 RID: 10290
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04002833 RID: 10291
		private static readonly IntPtr NativeFieldInfoPtr_NothingSelectedLabel;

		// Token: 0x04002834 RID: 10292
		private static readonly IntPtr NativeFieldInfoPtr_DifferentTypesSelectedLabel;

		// Token: 0x04002835 RID: 10293
		private static readonly IntPtr NativeFieldInfoPtr_PanelContainer;

		// Token: 0x04002836 RID: 10294
		private static readonly IntPtr NativeFieldInfoPtr_MainScreen;

		// Token: 0x04002837 RID: 10295
		private static readonly IntPtr NativeFieldInfoPtr_ItemSelectorScreen;

		// Token: 0x04002838 RID: 10296
		private static readonly IntPtr NativeFieldInfoPtr_ObjectSelector;

		// Token: 0x04002839 RID: 10297
		private static readonly IntPtr NativeFieldInfoPtr_RecipeSelectorScreen;

		// Token: 0x0400283A RID: 10298
		private static readonly IntPtr NativeFieldInfoPtr_TransitEntitySelector;

		// Token: 0x0400283B RID: 10299
		private static readonly IntPtr NativeFieldInfoPtr_StringSetterScreen;

		// Token: 0x0400283C RID: 10300
		private static readonly IntPtr NativeFieldInfoPtr_RenameButton;

		// Token: 0x0400283D RID: 10301
		private static readonly IntPtr NativeFieldInfoPtr_UIScreen;

		// Token: 0x0400283E RID: 10302
		private static readonly IntPtr NativeFieldInfoPtr_ConfigPanelPrefabs;

		// Token: 0x0400283F RID: 10303
		private static readonly IntPtr NativeFieldInfoPtr_Configurables;

		// Token: 0x04002840 RID: 10304
		private static readonly IntPtr NativeFieldInfoPtr_areConfigurablesUniform;

		// Token: 0x04002841 RID: 10305
		private static readonly IntPtr NativeFieldInfoPtr_loadedPanel;

		// Token: 0x04002842 RID: 10306
		private static readonly IntPtr NativeFieldInfoPtr__lastSelectableIndex;

		// Token: 0x04002843 RID: 10307
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippedClipboard_Public_get_ManagementClipboard_Equippable_0;

		// Token: 0x04002844 RID: 10308
		private static readonly IntPtr NativeMethodInfoPtr_set_EquippedClipboard_Protected_set_Void_ManagementClipboard_Equippable_0;

		// Token: 0x04002845 RID: 10309
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002846 RID: 10310
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0;

		// Token: 0x04002847 RID: 10311
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04002848 RID: 10312
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMainLabels_Private_Void_0;

		// Token: 0x04002849 RID: 10313
		private static readonly IntPtr NativeMethodInfoPtr_InitializeConfigPanel_Private_Void_0;

		// Token: 0x0400284A RID: 10314
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConfigPanel_Private_Void_0;

		// Token: 0x0400284B RID: 10315
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigPanelPrefab_Public_ConfigPanel_EConfigurableType_0;

		// Token: 0x0400284C RID: 10316
		private static readonly IntPtr NativeMethodInfoPtr_RenameButtonClicked_Public_Void_0;

		// Token: 0x0400284D RID: 10317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400284E RID: 10318
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_String_PDM_0;

		// Token: 0x02000A36 RID: 2614
		[Serializable]
		public class ConfigurableTypePanel : Il2CppSystem.Object
		{
			// Token: 0x0600DF36 RID: 57142 RVA: 0x0036F9D0 File Offset: 0x0036DBD0
			// Note: this type is marked as 'beforefieldinit'.
			static ConfigurableTypePanel()
			{
				Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "ConfigurableTypePanel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr);
				ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, "Type");
				ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, "Panel");
				ManagementInterface.ConfigurableTypePanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr, 100670949);
			}

			// Token: 0x0600DF37 RID: 57143 RVA: 0x0036FA38 File Offset: 0x0036DC38
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConfigurableTypePanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.ConfigurableTypePanel>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.ConfigurableTypePanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF38 RID: 57144 RVA: 0x000691CD File Offset: 0x000673CD
			public ConfigurableTypePanel(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F3 RID: 17395
			// (get) Token: 0x0600DF39 RID: 57145 RVA: 0x0036FA74 File Offset: 0x0036DC74
			// (set) Token: 0x0600DF3A RID: 57146 RVA: 0x000691D6 File Offset: 0x000673D6
			public unsafe EConfigurableType Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x170043F4 RID: 17396
			// (get) Token: 0x0600DF3B RID: 57147 RVA: 0x0036FA9C File Offset: 0x0036DC9C
			// (set) Token: 0x0600DF3C RID: 57148 RVA: 0x000691F1 File Offset: 0x000673F1
			public unsafe ConfigPanel Panel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.ConfigurableTypePanel.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009806 RID: 38918
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x04009807 RID: 38919
			private static readonly IntPtr NativeFieldInfoPtr_Panel;

			// Token: 0x04009808 RID: 38920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A37 RID: 2615
		[ObfuscatedName("ScheduleOne.Management.ManagementInterface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DF3D RID: 57149 RVA: 0x0036FACC File Offset: 0x0036DCCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr);
				ManagementInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, "<>9");
				ManagementInterface.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, "<>9__27_0");
				ManagementInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, 100670951);
				ManagementInterface.__c.NativeMethodInfoPtr__InitializeConfigPanel_b__27_0_Internal_EntityConfiguration_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr, 100670952);
			}

			// Token: 0x0600DF3E RID: 57150 RVA: 0x0036FB48 File Offset: 0x0036DD48
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF3F RID: 57151 RVA: 0x0036FB84 File Offset: 0x0036DD84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150290, XrefRangeEnd = 150294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityConfiguration _InitializeConfigPanel_b__27_0(IConfigurable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c.NativeMethodInfoPtr__InitializeConfigPanel_b__27_0_Internal_EntityConfiguration_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}

			// Token: 0x0600DF40 RID: 57152 RVA: 0x00069210 File Offset: 0x00067410
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F5 RID: 17397
			// (get) Token: 0x0600DF41 RID: 57153 RVA: 0x0036FBD4 File Offset: 0x0036DDD4
			// (set) Token: 0x0600DF42 RID: 57154 RVA: 0x00069219 File Offset: 0x00067419
			public unsafe static ManagementInterface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F6 RID: 17398
			// (get) Token: 0x0600DF43 RID: 57155 RVA: 0x0036FBFC File Offset: 0x0036DDFC
			// (set) Token: 0x0600DF44 RID: 57156 RVA: 0x0006922B File Offset: 0x0006742B
			public unsafe static Func<IConfigurable, EntityConfiguration> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementInterface.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IConfigurable, EntityConfiguration>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementInterface.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009809 RID: 38921
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400980A RID: 38922
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x0400980B RID: 38923
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400980C RID: 38924
			private static readonly IntPtr NativeMethodInfoPtr__InitializeConfigPanel_b__27_0_Internal_EntityConfiguration_IConfigurable_0;
		}

		// Token: 0x02000A38 RID: 2616
		[ObfuscatedName("ScheduleOne.Management.ManagementInterface+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF45 RID: 57157 RVA: 0x0036FC24 File Offset: 0x0036DE24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementInterface>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass29_0>.NativeClassPtr);
				ManagementInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass29_0>.NativeClassPtr, "type");
				ManagementInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass29_0>.NativeClassPtr, 100670953);
				ManagementInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass29_0>.NativeClassPtr, 100670954);
			}

			// Token: 0x0600DF46 RID: 57158 RVA: 0x0036FC8C File Offset: 0x0036DE8C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementInterface.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF47 RID: 57159 RVA: 0x0036FCC8 File Offset: 0x0036DEC8
			[CallerCount(0)]
			public unsafe bool _GetConfigPanelPrefab_b__0(ManagementInterface.ConfigurableTypePanel x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DF48 RID: 57160 RVA: 0x0006923D File Offset: 0x0006743D
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F7 RID: 17399
			// (get) Token: 0x0600DF49 RID: 57161 RVA: 0x0036FD18 File Offset: 0x0036DF18
			// (set) Token: 0x0600DF4A RID: 57162 RVA: 0x00069246 File Offset: 0x00067446
			public unsafe EConfigurableType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x0400980D RID: 38925
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x0400980E RID: 38926
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400980F RID: 38927
			private static readonly IntPtr NativeMethodInfoPtr__GetConfigPanelPrefab_b__0_Internal_Boolean_ConfigurableTypePanel_0;
		}
	}
}

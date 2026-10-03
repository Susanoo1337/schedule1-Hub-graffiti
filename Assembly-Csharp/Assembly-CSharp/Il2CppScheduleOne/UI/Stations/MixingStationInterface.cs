using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x02000781 RID: 1921
	public class MixingStationInterface : StationInterface<MixingStationInterface>
	{
		// Token: 0x0600BB17 RID: 47895 RVA: 0x003018E8 File Offset: 0x002FFAE8
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationInterface()
		{
			Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "MixingStationInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr);
			MixingStationInterface.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "<Station>k__BackingField");
			MixingStationInterface.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "RecipeEntryPrefab");
			MixingStationInterface.NativeFieldInfoPtr_ProductSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "ProductSlotUI");
			MixingStationInterface.NativeFieldInfoPtr_ProductPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "ProductPropertiesLabel");
			MixingStationInterface.NativeFieldInfoPtr_IngredientSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "IngredientSlotUI");
			MixingStationInterface.NativeFieldInfoPtr_IngredientProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "IngredientProblemLabel");
			MixingStationInterface.NativeFieldInfoPtr_PreviewSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "PreviewSlotUI");
			MixingStationInterface.NativeFieldInfoPtr_PreviewIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "PreviewIcon");
			MixingStationInterface.NativeFieldInfoPtr_PreviewLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "PreviewLabel");
			MixingStationInterface.NativeFieldInfoPtr_UnknownOutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "UnknownOutputIcon");
			MixingStationInterface.NativeFieldInfoPtr_PreviewPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "PreviewPropertiesLabel");
			MixingStationInterface.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "OutputSlotUI");
			MixingStationInterface.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "InstructionLabel");
			MixingStationInterface.NativeFieldInfoPtr_MainSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "MainSlotContainer");
			MixingStationInterface.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "BeginButton");
			MixingStationInterface.NativeFieldInfoPtr_ProductHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "ProductHint");
			MixingStationInterface.NativeFieldInfoPtr_MixerHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "MixerHint");
			MixingStationInterface.NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687713);
			MixingStationInterface.NativeMethodInfoPtr_set_Station_Protected_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687714);
			MixingStationInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687715);
			MixingStationInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687716);
			MixingStationInterface.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687717);
			MixingStationInterface.NativeMethodInfoPtr_Open_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687718);
			MixingStationInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687719);
			MixingStationInterface.NativeMethodInfoPtr_MixingDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687720);
			MixingStationInterface.NativeMethodInfoPtr_CheckForUnknownMix_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687721);
			MixingStationInterface.NativeMethodInfoPtr_StationContentsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687722);
			MixingStationInterface.NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687723);
			MixingStationInterface.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687724);
			MixingStationInterface.NativeMethodInfoPtr_UpdatePreview_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687725);
			MixingStationInterface.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687726);
			MixingStationInterface.NativeMethodInfoPtr_GetPropertyString_Private_String_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687727);
			MixingStationInterface.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Effect_ProductDefinition_PropertyItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687728);
			MixingStationInterface.NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687729);
			MixingStationInterface.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687730);
			MixingStationInterface.NativeMethodInfoPtr_BeginTask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687731);
			MixingStationInterface.NativeMethodInfoPtr_BeginMix_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687732);
			MixingStationInterface.NativeMethodInfoPtr_MixNamed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687733);
			MixingStationInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, 100687734);
		}

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0600BB18 RID: 47896 RVA: 0x00301C24 File Offset: 0x002FFE24
		// (set) Token: 0x0600BB19 RID: 47897 RVA: 0x00301C64 File Offset: 0x002FFE64
		public unsafe MixingStation Station
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_set_Station_Protected_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BB1A RID: 47898 RVA: 0x00301CA8 File Offset: 0x002FFEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312192, XrefRangeEnd = 312203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB1B RID: 47899 RVA: 0x00301CE4 File Offset: 0x002FFEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312203, XrefRangeEnd = 312214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB1C RID: 47900 RVA: 0x00301D20 File Offset: 0x002FFF20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312214, XrefRangeEnd = 312216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB1D RID: 47901 RVA: 0x00301D54 File Offset: 0x002FFF54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312268, RefRangeEnd = 312270, XrefRangeStart = 312216, XrefRangeEnd = 312268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_Open_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB1E RID: 47902 RVA: 0x00301D98 File Offset: 0x002FFF98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312318, RefRangeEnd = 312320, XrefRangeStart = 312270, XrefRangeEnd = 312318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB1F RID: 47903 RVA: 0x00301DCC File Offset: 0x002FFFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312320, XrefRangeEnd = 312325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MixingDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_MixingDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB20 RID: 47904 RVA: 0x00301E00 File Offset: 0x00300000
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312377, RefRangeEnd = 312379, XrefRangeStart = 312325, XrefRangeEnd = 312377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForUnknownMix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_CheckForUnknownMix_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB21 RID: 47905 RVA: 0x00301E34 File Offset: 0x00300034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312379, XrefRangeEnd = 312388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StationContentsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_StationContentsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB22 RID: 47906 RVA: 0x00301E68 File Offset: 0x00300068
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 312405, RefRangeEnd = 312412, XrefRangeStart = 312388, XrefRangeEnd = 312405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplayMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB23 RID: 47907 RVA: 0x00301E9C File Offset: 0x0030009C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 312423, RefRangeEnd = 312427, XrefRangeStart = 312412, XrefRangeEnd = 312423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB24 RID: 47908 RVA: 0x00301ED0 File Offset: 0x003000D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 312516, RefRangeEnd = 312519, XrefRangeStart = 312427, XrefRangeEnd = 312516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePreview()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_UpdatePreview_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB25 RID: 47909 RVA: 0x00301F04 File Offset: 0x00300104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312531, RefRangeEnd = 312533, XrefRangeStart = 312519, XrefRangeEnd = 312531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyListString(List<Effect> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600BB26 RID: 47910 RVA: 0x00301F4C File Offset: 0x0030014C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312551, RefRangeEnd = 312553, XrefRangeStart = 312533, XrefRangeEnd = 312551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyString(Effect property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_GetPropertyString_Private_String_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600BB27 RID: 47911 RVA: 0x00301F94 File Offset: 0x00300194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312553, XrefRangeEnd = 312559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Effect> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Effect_ProductDefinition_PropertyItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Effect>>(intPtr3) : null;
		}

		// Token: 0x0600BB28 RID: 47912 RVA: 0x00301FF8 File Offset: 0x003001F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 312567, RefRangeEnd = 312570, XrefRangeStart = 312559, XrefRangeEnd = 312567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBeginButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB29 RID: 47913 RVA: 0x0030202C File Offset: 0x0030022C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312578, RefRangeEnd = 312579, XrefRangeStart = 312570, XrefRangeEnd = 312578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB2A RID: 47914 RVA: 0x00302060 File Offset: 0x00300260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312579, XrefRangeEnd = 312604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_BeginTask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB2B RID: 47915 RVA: 0x00302094 File Offset: 0x00300294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312604, XrefRangeEnd = 312619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginMix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_BeginMix_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB2C RID: 47916 RVA: 0x003020C8 File Offset: 0x003002C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312619, XrefRangeEnd = 312643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MixNamed(string mixName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mixName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr_MixNamed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB2D RID: 47917 RVA: 0x0030210C File Offset: 0x0030030C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312643, XrefRangeEnd = 312646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BB2E RID: 47918 RVA: 0x0005748E File Offset: 0x0005568E
		public MixingStationInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0600BB2F RID: 47919 RVA: 0x00302148 File Offset: 0x00300348
		// (set) Token: 0x0600BB30 RID: 47920 RVA: 0x00057497 File Offset: 0x00055697
		public unsafe MixingStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0600BB31 RID: 47921 RVA: 0x00302178 File Offset: 0x00300378
		// (set) Token: 0x0600BB32 RID: 47922 RVA: 0x000574B6 File Offset: 0x000556B6
		public unsafe StationRecipeEntry RecipeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_RecipeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x0600BB33 RID: 47923 RVA: 0x003021A8 File Offset: 0x003003A8
		// (set) Token: 0x0600BB34 RID: 47924 RVA: 0x000574D5 File Offset: 0x000556D5
		public unsafe ItemSlotUI ProductSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_ProductSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_ProductSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x0600BB35 RID: 47925 RVA: 0x003021D8 File Offset: 0x003003D8
		// (set) Token: 0x0600BB36 RID: 47926 RVA: 0x000574F4 File Offset: 0x000556F4
		public unsafe TextMeshProUGUI ProductPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_ProductPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_ProductPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0600BB37 RID: 47927 RVA: 0x00302208 File Offset: 0x00300408
		// (set) Token: 0x0600BB38 RID: 47928 RVA: 0x00057513 File Offset: 0x00055713
		public unsafe ItemSlotUI IngredientSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_IngredientSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_IngredientSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x0600BB39 RID: 47929 RVA: 0x00302238 File Offset: 0x00300438
		// (set) Token: 0x0600BB3A RID: 47930 RVA: 0x00057532 File Offset: 0x00055732
		public unsafe TextMeshProUGUI IngredientProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_IngredientProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_IngredientProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x0600BB3B RID: 47931 RVA: 0x00302268 File Offset: 0x00300468
		// (set) Token: 0x0600BB3C RID: 47932 RVA: 0x00057551 File Offset: 0x00055751
		public unsafe ItemSlotUI PreviewSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_PreviewSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_PreviewSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x0600BB3D RID: 47933 RVA: 0x00302298 File Offset: 0x00300498
		// (set) Token: 0x0600BB3E RID: 47934 RVA: 0x00057570 File Offset: 0x00055770
		public unsafe Image PreviewIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_PreviewIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_PreviewIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0600BB3F RID: 47935 RVA: 0x003022C8 File Offset: 0x003004C8
		// (set) Token: 0x0600BB40 RID: 47936 RVA: 0x0005758F File Offset: 0x0005578F
		public unsafe TextMeshProUGUI PreviewLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_PreviewLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_PreviewLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0600BB41 RID: 47937 RVA: 0x003022F8 File Offset: 0x003004F8
		// (set) Token: 0x0600BB42 RID: 47938 RVA: 0x000575AE File Offset: 0x000557AE
		public unsafe RectTransform UnknownOutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_UnknownOutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_UnknownOutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0600BB43 RID: 47939 RVA: 0x00302328 File Offset: 0x00300528
		// (set) Token: 0x0600BB44 RID: 47940 RVA: 0x000575CD File Offset: 0x000557CD
		public unsafe TextMeshProUGUI PreviewPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_PreviewPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_PreviewPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0600BB45 RID: 47941 RVA: 0x00302358 File Offset: 0x00300558
		// (set) Token: 0x0600BB46 RID: 47942 RVA: 0x000575EC File Offset: 0x000557EC
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0600BB47 RID: 47943 RVA: 0x00302388 File Offset: 0x00300588
		// (set) Token: 0x0600BB48 RID: 47944 RVA: 0x0005760B File Offset: 0x0005580B
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0600BB49 RID: 47945 RVA: 0x003023B8 File Offset: 0x003005B8
		// (set) Token: 0x0600BB4A RID: 47946 RVA: 0x0005762A File Offset: 0x0005582A
		public unsafe RectTransform MainSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_MainSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_MainSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x0600BB4B RID: 47947 RVA: 0x003023E8 File Offset: 0x003005E8
		// (set) Token: 0x0600BB4C RID: 47948 RVA: 0x00057649 File Offset: 0x00055849
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x0600BB4D RID: 47949 RVA: 0x00302418 File Offset: 0x00300618
		// (set) Token: 0x0600BB4E RID: 47950 RVA: 0x00057668 File Offset: 0x00055868
		public unsafe RectTransform ProductHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_ProductHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_ProductHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x0600BB4F RID: 47951 RVA: 0x00302448 File Offset: 0x00300648
		// (set) Token: 0x0600BB50 RID: 47952 RVA: 0x00057687 File Offset: 0x00055887
		public unsafe RectTransform MixerHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_MixerHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.NativeFieldInfoPtr_MixerHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400803E RID: 32830
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x0400803F RID: 32831
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;

		// Token: 0x04008040 RID: 32832
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlotUI;

		// Token: 0x04008041 RID: 32833
		private static readonly IntPtr NativeFieldInfoPtr_ProductPropertiesLabel;

		// Token: 0x04008042 RID: 32834
		private static readonly IntPtr NativeFieldInfoPtr_IngredientSlotUI;

		// Token: 0x04008043 RID: 32835
		private static readonly IntPtr NativeFieldInfoPtr_IngredientProblemLabel;

		// Token: 0x04008044 RID: 32836
		private static readonly IntPtr NativeFieldInfoPtr_PreviewSlotUI;

		// Token: 0x04008045 RID: 32837
		private static readonly IntPtr NativeFieldInfoPtr_PreviewIcon;

		// Token: 0x04008046 RID: 32838
		private static readonly IntPtr NativeFieldInfoPtr_PreviewLabel;

		// Token: 0x04008047 RID: 32839
		private static readonly IntPtr NativeFieldInfoPtr_UnknownOutputIcon;

		// Token: 0x04008048 RID: 32840
		private static readonly IntPtr NativeFieldInfoPtr_PreviewPropertiesLabel;

		// Token: 0x04008049 RID: 32841
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x0400804A RID: 32842
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x0400804B RID: 32843
		private static readonly IntPtr NativeFieldInfoPtr_MainSlotContainer;

		// Token: 0x0400804C RID: 32844
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x0400804D RID: 32845
		private static readonly IntPtr NativeFieldInfoPtr_ProductHint;

		// Token: 0x0400804E RID: 32846
		private static readonly IntPtr NativeFieldInfoPtr_MixerHint;

		// Token: 0x0400804F RID: 32847
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_MixingStation_0;

		// Token: 0x04008050 RID: 32848
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Protected_set_Void_MixingStation_0;

		// Token: 0x04008051 RID: 32849
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008052 RID: 32850
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04008053 RID: 32851
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04008054 RID: 32852
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_MixingStation_0;

		// Token: 0x04008055 RID: 32853
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04008056 RID: 32854
		private static readonly IntPtr NativeMethodInfoPtr_MixingDone_Private_Void_0;

		// Token: 0x04008057 RID: 32855
		private static readonly IntPtr NativeMethodInfoPtr_CheckForUnknownMix_Private_Void_0;

		// Token: 0x04008058 RID: 32856
		private static readonly IntPtr NativeMethodInfoPtr_StationContentsChanged_Private_Void_0;

		// Token: 0x04008059 RID: 32857
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplayMode_Private_Void_0;

		// Token: 0x0400805A RID: 32858
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x0400805B RID: 32859
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePreview_Private_Void_0;

		// Token: 0x0400805C RID: 32860
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Effect_0;

		// Token: 0x0400805D RID: 32861
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyString_Private_String_Effect_0;

		// Token: 0x0400805E RID: 32862
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Effect_ProductDefinition_PropertyItemDefinition_0;

		// Token: 0x0400805F RID: 32863
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBeginButton_Private_Void_0;

		// Token: 0x04008060 RID: 32864
		private static readonly IntPtr NativeMethodInfoPtr_BeginButtonPressed_Public_Void_0;

		// Token: 0x04008061 RID: 32865
		private static readonly IntPtr NativeMethodInfoPtr_BeginTask_Private_Void_0;

		// Token: 0x04008062 RID: 32866
		private static readonly IntPtr NativeMethodInfoPtr_BeginMix_Private_Void_0;

		// Token: 0x04008063 RID: 32867
		private static readonly IntPtr NativeMethodInfoPtr_MixNamed_Private_Void_String_0;

		// Token: 0x04008064 RID: 32868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D0D RID: 3341
		[ObfuscatedName("ScheduleOne.UI.Stations.MixingStationInterface+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F7C8 RID: 63432 RVA: 0x003B5F3C File Offset: 0x003B413C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<MixingStationInterface.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MixingStationInterface>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationInterface.__c__DisplayClass36_0>.NativeClassPtr);
				MixingStationInterface.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface.__c__DisplayClass36_0>.NativeClassPtr, "<>4__this");
				MixingStationInterface.__c__DisplayClass36_0.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationInterface.__c__DisplayClass36_0>.NativeClassPtr, "station");
				MixingStationInterface.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface.__c__DisplayClass36_0>.NativeClassPtr, 100687735);
				MixingStationInterface.__c__DisplayClass36_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationInterface.__c__DisplayClass36_0>.NativeClassPtr, 100687736);
			}

			// Token: 0x0600F7C9 RID: 63433 RVA: 0x003B5FB8 File Offset: 0x003B41B8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationInterface.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7CA RID: 63434 RVA: 0x003B5FF4 File Offset: 0x003B41F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312186, XrefRangeEnd = 312192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationInterface.__c__DisplayClass36_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7CB RID: 63435 RVA: 0x000752B0 File Offset: 0x000734B0
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B56 RID: 19286
			// (get) Token: 0x0600F7CC RID: 63436 RVA: 0x003B6028 File Offset: 0x003B4228
			// (set) Token: 0x0600F7CD RID: 63437 RVA: 0x000752B9 File Offset: 0x000734B9
			public unsafe MixingStationInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStationInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B57 RID: 19287
			// (get) Token: 0x0600F7CE RID: 63438 RVA: 0x003B6058 File Offset: 0x003B4258
			// (set) Token: 0x0600F7CF RID: 63439 RVA: 0x000752D8 File Offset: 0x000734D8
			public unsafe MixingStation station
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.__c__DisplayClass36_0.NativeFieldInfoPtr_station);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationInterface.__c__DisplayClass36_0.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A785 RID: 42885
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A786 RID: 42886
			private static readonly IntPtr NativeFieldInfoPtr_station;

			// Token: 0x0400A787 RID: 42887
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A788 RID: 42888
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}

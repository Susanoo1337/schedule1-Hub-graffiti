using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x020000AC RID: 172
	public class UIPopupScreen_ModifyAmountMenu : UIPopupScreen
	{
		// Token: 0x06000F03 RID: 3843 RVA: 0x000AD5FC File Offset: 0x000AB7FC
		// Note: this type is marked as 'beforefieldinit'.
		static UIPopupScreen_ModifyAmountMenu()
		{
			Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIPopupScreen_ModifyAmountMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr);
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "titleText");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_topMessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "topMessageText");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_bottomMessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "bottomMessageText");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_amountInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "amountInputField");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "itemImage");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "itemNameText");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemCostText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "itemCostText");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "confirmButton");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "cancelButton");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "canvas");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1DecreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier1DecreaseButton");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2DecreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier2DecreaseButton");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3DecreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier3DecreaseButton");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1IncreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier1IncreaseButton");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2IncreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier2IncreaseButton");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3IncreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier3IncreaseButton");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1DecreaseText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier1DecreaseText");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2DecreaseText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier2DecreaseText");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3DecreaseText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier3DecreaseText");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1IncreaseText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier1IncreaseText");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2IncreaseText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier2IncreaseText");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3IncreaseText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier3IncreaseText");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_holdThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "holdThreshold");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_repeatInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "repeatInterval");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1InputDetect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier1InputDetect");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2InputDetect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier2InputDetect");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3InputDetect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier3InputDetect");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_modifyAmountMenuMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "modifyAmountMenuMode");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "itemPrice");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_minAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "minAmount");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier1Amount");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier2Amount");
			UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "tier3Amount");
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665202);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_OnStarted_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665203);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665204);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665205);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_Open_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665206);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_SelectInputField_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665207);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_Open_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665208);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_RegisterInput_Private_IEnumerator_Action_1_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665209);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_UpdateStoreBottomMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665210);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_GetCurrentAmount_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665211);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetectTier1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665212);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetectTier2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665213);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetectTier3_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665214);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetect_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665215);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_ChangeCurrentAmount_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665216);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_SetCurrentAmount_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665217);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_CapAmount_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665218);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665219);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665220);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665221);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665222);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665223);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665224);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665225);
			UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_6_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, 100665226);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x000ADAB4 File Offset: 0x000ABCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82499, XrefRangeEnd = 82578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x000ADAF0 File Offset: 0x000ABCF0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_OnStarted_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x000ADB2C File Offset: 0x000ABD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82578, XrefRangeEnd = 82598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x000ADB68 File Offset: 0x000ABD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82598, XrefRangeEnd = 82607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x000ADBA4 File Offset: 0x000ABDA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82630, RefRangeEnd = 82631, XrefRangeStart = 82607, XrefRangeEnd = 82630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_Open_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x000ADBD8 File Offset: 0x000ABDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82631, XrefRangeEnd = 82636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SelectInputField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_SelectInputField_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x000ADC18 File Offset: 0x000ABE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82636, XrefRangeEnd = 82724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open([Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_Open_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x000ADC74 File Offset: 0x000ABE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82724, XrefRangeEnd = 82731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RegisterInput(Action<float> onConfirm, Action onCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onConfirm);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCancel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_RegisterInput_Private_IEnumerator_Action_1_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x000ADCD8 File Offset: 0x000ABED8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82738, RefRangeEnd = 82740, XrefRangeStart = 82731, XrefRangeEnd = 82738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStoreBottomMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_UpdateStoreBottomMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x000ADD0C File Offset: 0x000ABF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82740, XrefRangeEnd = 82741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCurrentAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_GetCurrentAmount_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x000ADD48 File Offset: 0x000ABF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82741, XrefRangeEnd = 82742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCurrentAmountBasedOnInputDetectTier1(float inputValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetectTier1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000ADD88 File Offset: 0x000ABF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82742, XrefRangeEnd = 82743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCurrentAmountBasedOnInputDetectTier2(float inputValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetectTier2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x000ADDC8 File Offset: 0x000ABFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82743, XrefRangeEnd = 82744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCurrentAmountBasedOnInputDetectTier3(float inputValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetectTier3_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x000ADE08 File Offset: 0x000AC008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82744, XrefRangeEnd = 82745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCurrentAmountBasedOnInputDetect(float inputValue, float tierAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tierAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetect_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x000ADE54 File Offset: 0x000AC054
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 82748, RefRangeEnd = 82758, XrefRangeStart = 82745, XrefRangeEnd = 82748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCurrentAmount(float increment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref increment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_ChangeCurrentAmount_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x000ADE94 File Offset: 0x000AC094
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82763, RefRangeEnd = 82767, XrefRangeStart = 82758, XrefRangeEnd = 82763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_SetCurrentAmount_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x000ADED4 File Offset: 0x000AC0D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82767, XrefRangeEnd = 82768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CapAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr_CapAmount_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x000ADF14 File Offset: 0x000AC114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82768, XrefRangeEnd = 82769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIPopupScreen_ModifyAmountMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x000ADF50 File Offset: 0x000AC150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82769, XrefRangeEnd = 82770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnAwake_b__34_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x000ADF84 File Offset: 0x000AC184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82770, XrefRangeEnd = 82771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnAwake_b__34_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000ADFB8 File Offset: 0x000AC1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82771, XrefRangeEnd = 82772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnAwake_b__34_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x000ADFEC File Offset: 0x000AC1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82772, XrefRangeEnd = 82773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnAwake_b__34_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000AE020 File Offset: 0x000AC220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82773, XrefRangeEnd = 82774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnAwake_b__34_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000AE054 File Offset: 0x000AC254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82774, XrefRangeEnd = 82775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnAwake_b__34_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x000AE088 File Offset: 0x000AC288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82775, XrefRangeEnd = 82777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnAwake_b__34_6(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.NativeMethodInfoPtr__OnAwake_b__34_6_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00008E7B File Offset: 0x0000707B
		public override void Open(params Il2CppSystem.Object[] args)
		{
			this.Open(new Il2CppReferenceArray<Il2CppSystem.Object>(args));
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00008E89 File Offset: 0x00007089
		public UIPopupScreen_ModifyAmountMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x000AE0CC File Offset: 0x000AC2CC
		// (set) Token: 0x06000F20 RID: 3872 RVA: 0x00008E92 File Offset: 0x00007092
		public unsafe TMP_Text titleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_titleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_titleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000AE0FC File Offset: 0x000AC2FC
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x00008EB1 File Offset: 0x000070B1
		public unsafe TMP_Text topMessageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_topMessageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_topMessageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x000AE12C File Offset: 0x000AC32C
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x00008ED0 File Offset: 0x000070D0
		public unsafe TMP_Text bottomMessageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_bottomMessageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_bottomMessageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x000AE15C File Offset: 0x000AC35C
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x00008EEF File Offset: 0x000070EF
		public unsafe TMP_InputField amountInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_amountInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_amountInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x000AE18C File Offset: 0x000AC38C
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x00008F0E File Offset: 0x0000710E
		public unsafe Image itemImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x000AE1BC File Offset: 0x000AC3BC
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x00008F2D File Offset: 0x0000712D
		public unsafe TMP_Text itemNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x000AE1EC File Offset: 0x000AC3EC
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x00008F4C File Offset: 0x0000714C
		public unsafe TMP_Text itemCostText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemCostText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemCostText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x000AE21C File Offset: 0x000AC41C
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00008F6B File Offset: 0x0000716B
		public unsafe UITrigger confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000AE24C File Offset: 0x000AC44C
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x00008F8A File Offset: 0x0000718A
		public unsafe UITrigger cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_cancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x000AE27C File Offset: 0x000AC47C
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x00008FA9 File Offset: 0x000071A9
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x000AE2AC File Offset: 0x000AC4AC
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x00008FC8 File Offset: 0x000071C8
		public unsafe Button tier1DecreaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1DecreaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1DecreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x000AE2DC File Offset: 0x000AC4DC
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x00008FE7 File Offset: 0x000071E7
		public unsafe Button tier2DecreaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2DecreaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2DecreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x000AE30C File Offset: 0x000AC50C
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x00009006 File Offset: 0x00007206
		public unsafe Button tier3DecreaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3DecreaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3DecreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x000AE33C File Offset: 0x000AC53C
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x00009025 File Offset: 0x00007225
		public unsafe Button tier1IncreaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1IncreaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1IncreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x000AE36C File Offset: 0x000AC56C
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00009044 File Offset: 0x00007244
		public unsafe Button tier2IncreaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2IncreaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2IncreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x000AE39C File Offset: 0x000AC59C
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00009063 File Offset: 0x00007263
		public unsafe Button tier3IncreaseButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3IncreaseButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3IncreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x000AE3CC File Offset: 0x000AC5CC
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00009082 File Offset: 0x00007282
		public unsafe TMP_Text tier1DecreaseText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1DecreaseText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1DecreaseText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x000AE3FC File Offset: 0x000AC5FC
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x000090A1 File Offset: 0x000072A1
		public unsafe TMP_Text tier2DecreaseText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2DecreaseText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2DecreaseText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x000AE42C File Offset: 0x000AC62C
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x000090C0 File Offset: 0x000072C0
		public unsafe TMP_Text tier3DecreaseText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3DecreaseText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3DecreaseText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x000AE45C File Offset: 0x000AC65C
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x000090DF File Offset: 0x000072DF
		public unsafe TMP_Text tier1IncreaseText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1IncreaseText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1IncreaseText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000AE48C File Offset: 0x000AC68C
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x000090FE File Offset: 0x000072FE
		public unsafe TMP_Text tier2IncreaseText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2IncreaseText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2IncreaseText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x000AE4BC File Offset: 0x000AC6BC
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x0000911D File Offset: 0x0000731D
		public unsafe TMP_Text tier3IncreaseText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3IncreaseText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3IncreaseText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000F4B RID: 3915 RVA: 0x000AE4EC File Offset: 0x000AC6EC
		// (set) Token: 0x06000F4C RID: 3916 RVA: 0x0000913C File Offset: 0x0000733C
		public unsafe float holdThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_holdThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_holdThreshold)) = value;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000F4D RID: 3917 RVA: 0x000AE514 File Offset: 0x000AC714
		// (set) Token: 0x06000F4E RID: 3918 RVA: 0x00009157 File Offset: 0x00007357
		public unsafe float repeatInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_repeatInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_repeatInterval)) = value;
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x000AE53C File Offset: 0x000AC73C
		// (set) Token: 0x06000F50 RID: 3920 RVA: 0x00009172 File Offset: 0x00007372
		public unsafe UIInputDetectBehaviour tier1InputDetect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1InputDetect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIInputDetectBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1InputDetect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000F51 RID: 3921 RVA: 0x000AE56C File Offset: 0x000AC76C
		// (set) Token: 0x06000F52 RID: 3922 RVA: 0x00009191 File Offset: 0x00007391
		public unsafe UIInputDetectBehaviour tier2InputDetect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2InputDetect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIInputDetectBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2InputDetect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x000AE59C File Offset: 0x000AC79C
		// (set) Token: 0x06000F54 RID: 3924 RVA: 0x000091B0 File Offset: 0x000073B0
		public unsafe UIInputDetectBehaviour tier3InputDetect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3InputDetect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIInputDetectBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3InputDetect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000F55 RID: 3925 RVA: 0x000AE5CC File Offset: 0x000AC7CC
		// (set) Token: 0x06000F56 RID: 3926 RVA: 0x000091CF File Offset: 0x000073CF
		public unsafe UIPopupScreen_ModifyAmountMenu.ModifyAmountMenuMode modifyAmountMenuMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_modifyAmountMenuMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_modifyAmountMenuMode)) = value;
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000F57 RID: 3927 RVA: 0x000AE5F4 File Offset: 0x000AC7F4
		// (set) Token: 0x06000F58 RID: 3928 RVA: 0x000091EA File Offset: 0x000073EA
		public unsafe float itemPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_itemPrice)) = value;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x000AE61C File Offset: 0x000AC81C
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x00009205 File Offset: 0x00007405
		public unsafe float minAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_minAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_minAmount)) = value;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x000AE644 File Offset: 0x000AC844
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x00009220 File Offset: 0x00007420
		public unsafe float tier1Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier1Amount)) = value;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x000AE66C File Offset: 0x000AC86C
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x0000923B File Offset: 0x0000743B
		public unsafe float tier2Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier2Amount)) = value;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x000AE694 File Offset: 0x000AC894
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x00009256 File Offset: 0x00007456
		public unsafe float tier3Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.NativeFieldInfoPtr_tier3Amount)) = value;
			}
		}

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeFieldInfoPtr_titleText;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeFieldInfoPtr_topMessageText;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeFieldInfoPtr_bottomMessageText;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeFieldInfoPtr_amountInputField;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeFieldInfoPtr_itemImage;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeFieldInfoPtr_itemNameText;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeFieldInfoPtr_itemCostText;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeFieldInfoPtr_tier1DecreaseButton;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeFieldInfoPtr_tier2DecreaseButton;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeFieldInfoPtr_tier3DecreaseButton;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeFieldInfoPtr_tier1IncreaseButton;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeFieldInfoPtr_tier2IncreaseButton;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeFieldInfoPtr_tier3IncreaseButton;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeFieldInfoPtr_tier1DecreaseText;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeFieldInfoPtr_tier2DecreaseText;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeFieldInfoPtr_tier3DecreaseText;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeFieldInfoPtr_tier1IncreaseText;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeFieldInfoPtr_tier2IncreaseText;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr_tier3IncreaseText;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeFieldInfoPtr_holdThreshold;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeFieldInfoPtr_repeatInterval;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeFieldInfoPtr_tier1InputDetect;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr_tier2InputDetect;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr_tier3InputDetect;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_modifyAmountMenuMode;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr_itemPrice;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_minAmount;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeFieldInfoPtr_tier1Amount;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_tier2Amount;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeFieldInfoPtr_tier3Amount;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_OnStarted_Protected_Virtual_Void_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Void_0;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeMethodInfoPtr_SelectInputField_Private_IEnumerator_0;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInput_Private_IEnumerator_Action_1_Single_Action_0;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStoreBottomMessage_Private_Void_0;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentAmount_Private_Single_0;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetectTier1_Private_Void_Single_0;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetectTier2_Private_Void_Single_0;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetectTier3_Private_Void_Single_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCurrentAmountBasedOnInputDetect_Private_Void_Single_Single_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCurrentAmount_Private_Void_Single_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentAmount_Private_Void_Single_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_CapAmount_Private_Void_Single_0;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr__OnAwake_b__34_0_Private_Void_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr__OnAwake_b__34_1_Private_Void_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr__OnAwake_b__34_2_Private_Void_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr__OnAwake_b__34_3_Private_Void_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr__OnAwake_b__34_4_Private_Void_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr__OnAwake_b__34_5_Private_Void_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr__OnAwake_b__34_6_Private_Void_String_0;

		// Token: 0x020008C2 RID: 2242
		[OriginalName("Assembly-CSharp.dll", "", "ModifyAmountMenuMode")]
		public enum ModifyAmountMenuMode
		{
			// Token: 0x040090D6 RID: 37078
			Store
		}

		// Token: 0x020008C3 RID: 2243
		[ObfuscatedName("ScheduleOne.UIPopupScreen_ModifyAmountMenu+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4AB RID: 54443 RVA: 0x0034F318 File Offset: 0x0034D518
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0>.NativeClassPtr);
				UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeFieldInfoPtr_onConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0>.NativeClassPtr, "onConfirm");
				UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeFieldInfoPtr_onCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0>.NativeClassPtr, "onCancel");
				UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0>.NativeClassPtr, 100665227);
				UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeMethodInfoPtr__RegisterInput_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0>.NativeClassPtr, 100665228);
				UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeMethodInfoPtr__RegisterInput_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0>.NativeClassPtr, 100665229);
			}

			// Token: 0x0600D4AC RID: 54444 RVA: 0x0034F3BC File Offset: 0x0034D5BC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4AD RID: 54445 RVA: 0x0034F3F8 File Offset: 0x0034D5F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82448, XrefRangeEnd = 82457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterInput_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeMethodInfoPtr__RegisterInput_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4AE RID: 54446 RVA: 0x0034F42C File Offset: 0x0034D62C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82457, XrefRangeEnd = 82458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterInput_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeMethodInfoPtr__RegisterInput_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4AF RID: 54447 RVA: 0x000649B1 File Offset: 0x00062BB1
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040C0 RID: 16576
			// (get) Token: 0x0600D4B0 RID: 54448 RVA: 0x0034F460 File Offset: 0x0034D660
			// (set) Token: 0x0600D4B1 RID: 54449 RVA: 0x000649BA File Offset: 0x00062BBA
			public unsafe UIPopupScreen_ModifyAmountMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupScreen_ModifyAmountMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C1 RID: 16577
			// (get) Token: 0x0600D4B2 RID: 54450 RVA: 0x0034F490 File Offset: 0x0034D690
			// (set) Token: 0x0600D4B3 RID: 54451 RVA: 0x000649D9 File Offset: 0x00062BD9
			public unsafe Action<float> onConfirm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeFieldInfoPtr_onConfirm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeFieldInfoPtr_onConfirm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C2 RID: 16578
			// (get) Token: 0x0600D4B4 RID: 54452 RVA: 0x0034F4C0 File Offset: 0x0034D6C0
			// (set) Token: 0x0600D4B5 RID: 54453 RVA: 0x000649F8 File Offset: 0x00062BF8
			public unsafe Action onCancel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeFieldInfoPtr_onCancel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0.NativeFieldInfoPtr_onCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090D7 RID: 37079
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090D8 RID: 37080
			private static readonly IntPtr NativeFieldInfoPtr_onConfirm;

			// Token: 0x040090D9 RID: 37081
			private static readonly IntPtr NativeFieldInfoPtr_onCancel;

			// Token: 0x040090DA RID: 37082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090DB RID: 37083
			private static readonly IntPtr NativeMethodInfoPtr__RegisterInput_b__0_Internal_Void_0;

			// Token: 0x040090DC RID: 37084
			private static readonly IntPtr NativeMethodInfoPtr__RegisterInput_b__1_Internal_Void_0;
		}

		// Token: 0x020008C4 RID: 2244
		[ObfuscatedName("ScheduleOne.UIPopupScreen_ModifyAmountMenu+<RegisterInput>d__41")]
		public sealed class _RegisterInput_d__41 : Il2CppSystem.Object
		{
			// Token: 0x0600D4B6 RID: 54454 RVA: 0x0034F4F0 File Offset: 0x0034D6F0
			// Note: this type is marked as 'beforefieldinit'.
			static _RegisterInput_d__41()
			{
				Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "<RegisterInput>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr);
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, "<>1__state");
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, "<>2__current");
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, "<>4__this");
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr_onConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, "onConfirm");
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr_onCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, "onCancel");
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, "<>8__1");
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, 100665230);
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, 100665231);
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, 100665232);
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, 100665233);
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, 100665234);
				UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr, 100665235);
			}

			// Token: 0x0600D4B7 RID: 54455 RVA: 0x0034F60C File Offset: 0x0034D80C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RegisterInput_d__41(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4B8 RID: 54456 RVA: 0x0034F654 File Offset: 0x0034D854
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4B9 RID: 54457 RVA: 0x0034F688 File Offset: 0x0034D888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82458, XrefRangeEnd = 82488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170040C9 RID: 16585
			// (get) Token: 0x0600D4BA RID: 54458 RVA: 0x0034F6C4 File Offset: 0x0034D8C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4BB RID: 54459 RVA: 0x0034F704 File Offset: 0x0034D904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82488, XrefRangeEnd = 82493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170040CA RID: 16586
			// (get) Token: 0x0600D4BC RID: 54460 RVA: 0x0034F738 File Offset: 0x0034D938
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4BD RID: 54461 RVA: 0x00064A17 File Offset: 0x00062C17
			public _RegisterInput_d__41(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040C3 RID: 16579
			// (get) Token: 0x0600D4BE RID: 54462 RVA: 0x0034F778 File Offset: 0x0034D978
			// (set) Token: 0x0600D4BF RID: 54463 RVA: 0x00064A20 File Offset: 0x00062C20
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040C4 RID: 16580
			// (get) Token: 0x0600D4C0 RID: 54464 RVA: 0x0034F7A0 File Offset: 0x0034D9A0
			// (set) Token: 0x0600D4C1 RID: 54465 RVA: 0x00064A3B File Offset: 0x00062C3B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C5 RID: 16581
			// (get) Token: 0x0600D4C2 RID: 54466 RVA: 0x0034F7D0 File Offset: 0x0034D9D0
			// (set) Token: 0x0600D4C3 RID: 54467 RVA: 0x00064A5A File Offset: 0x00062C5A
			public unsafe UIPopupScreen_ModifyAmountMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupScreen_ModifyAmountMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C6 RID: 16582
			// (get) Token: 0x0600D4C4 RID: 54468 RVA: 0x0034F800 File Offset: 0x0034DA00
			// (set) Token: 0x0600D4C5 RID: 54469 RVA: 0x00064A79 File Offset: 0x00062C79
			public unsafe Action<float> onConfirm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr_onConfirm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr_onConfirm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C7 RID: 16583
			// (get) Token: 0x0600D4C6 RID: 54470 RVA: 0x0034F830 File Offset: 0x0034DA30
			// (set) Token: 0x0600D4C7 RID: 54471 RVA: 0x00064A98 File Offset: 0x00062C98
			public unsafe Action onCancel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr_onCancel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr_onCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C8 RID: 16584
			// (get) Token: 0x0600D4C8 RID: 54472 RVA: 0x0034F860 File Offset: 0x0034DA60
			// (set) Token: 0x0600D4C9 RID: 54473 RVA: 0x00064AB7 File Offset: 0x00062CB7
			public unsafe UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupScreen_ModifyAmountMenu.__c__DisplayClass41_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._RegisterInput_d__41.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090DD RID: 37085
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090DE RID: 37086
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090DF RID: 37087
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090E0 RID: 37088
			private static readonly IntPtr NativeFieldInfoPtr_onConfirm;

			// Token: 0x040090E1 RID: 37089
			private static readonly IntPtr NativeFieldInfoPtr_onCancel;

			// Token: 0x040090E2 RID: 37090
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040090E3 RID: 37091
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090E4 RID: 37092
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090E5 RID: 37093
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090E6 RID: 37094
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090E7 RID: 37095
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090E8 RID: 37096
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008C5 RID: 2245
		[ObfuscatedName("ScheduleOne.UIPopupScreen_ModifyAmountMenu+<SelectInputField>d__39")]
		public sealed class _SelectInputField_d__39 : Il2CppSystem.Object
		{
			// Token: 0x0600D4CA RID: 54474 RVA: 0x0034F890 File Offset: 0x0034DA90
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectInputField_d__39()
			{
				Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu>.NativeClassPtr, "<SelectInputField>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr);
				UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr, "<>1__state");
				UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr, "<>2__current");
				UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr, "<>4__this");
				UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr, 100665236);
				UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr, 100665237);
				UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr, 100665238);
				UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr, 100665239);
				UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr, 100665240);
				UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr, 100665241);
			}

			// Token: 0x0600D4CB RID: 54475 RVA: 0x0034F970 File Offset: 0x0034DB70
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectInputField_d__39(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4CC RID: 54476 RVA: 0x0034F9B8 File Offset: 0x0034DBB8
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4CD RID: 54477 RVA: 0x0034F9EC File Offset: 0x0034DBEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82493, XrefRangeEnd = 82494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170040CE RID: 16590
			// (get) Token: 0x0600D4CE RID: 54478 RVA: 0x0034FA28 File Offset: 0x0034DC28
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4CF RID: 54479 RVA: 0x0034FA68 File Offset: 0x0034DC68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82494, XrefRangeEnd = 82499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170040CF RID: 16591
			// (get) Token: 0x0600D4D0 RID: 54480 RVA: 0x0034FA9C File Offset: 0x0034DC9C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4D1 RID: 54481 RVA: 0x00064AD6 File Offset: 0x00062CD6
			public _SelectInputField_d__39(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040CB RID: 16587
			// (get) Token: 0x0600D4D2 RID: 54482 RVA: 0x0034FADC File Offset: 0x0034DCDC
			// (set) Token: 0x0600D4D3 RID: 54483 RVA: 0x00064ADF File Offset: 0x00062CDF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040CC RID: 16588
			// (get) Token: 0x0600D4D4 RID: 54484 RVA: 0x0034FB04 File Offset: 0x0034DD04
			// (set) Token: 0x0600D4D5 RID: 54485 RVA: 0x00064AFA File Offset: 0x00062CFA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040CD RID: 16589
			// (get) Token: 0x0600D4D6 RID: 54486 RVA: 0x0034FB34 File Offset: 0x0034DD34
			// (set) Token: 0x0600D4D7 RID: 54487 RVA: 0x00064B19 File Offset: 0x00062D19
			public unsafe UIPopupScreen_ModifyAmountMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupScreen_ModifyAmountMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ModifyAmountMenu._SelectInputField_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090E9 RID: 37097
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090EA RID: 37098
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090EB RID: 37099
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090EC RID: 37100
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090ED RID: 37101
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090EE RID: 37102
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090EF RID: 37103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090F0 RID: 37104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090F1 RID: 37105
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

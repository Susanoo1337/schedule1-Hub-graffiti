using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000804 RID: 2052
	public class InputPromptObj : MonoBehaviour
	{
		// Token: 0x0600C76A RID: 51050 RVA: 0x003274C0 File Offset: 0x003256C0
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptObj()
		{
			Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptObj");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr);
			InputPromptObj.NativeFieldInfoPtr__inputPromptItemUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, "_inputPromptItemUI");
			InputPromptObj.NativeFieldInfoPtr__container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, "_container");
			InputPromptObj.NativeFieldInfoPtr__promptData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, "_promptData");
			InputPromptObj.NativeFieldInfoPtr__runOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, "_runOnEnable");
			InputPromptObj.NativeFieldInfoPtr__enablePulseAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, "_enablePulseAnimation");
			InputPromptObj.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, "_isActive");
			InputPromptObj.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, 100689110);
			InputPromptObj.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, 100689111);
			InputPromptObj.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, 100689112);
			InputPromptObj.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, 100689113);
			InputPromptObj.NativeMethodInfoPtr_ShowPrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, 100689114);
			InputPromptObj.NativeMethodInfoPtr_HidePrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, 100689115);
			InputPromptObj.NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, 100689116);
			InputPromptObj.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr, 100689117);
		}

		// Token: 0x0600C76B RID: 51051 RVA: 0x00327608 File Offset: 0x00325808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328913, XrefRangeEnd = 328916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptObj.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C76C RID: 51052 RVA: 0x0032763C File Offset: 0x0032583C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328916, XrefRangeEnd = 328919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptObj.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C76D RID: 51053 RVA: 0x00327670 File Offset: 0x00325870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328919, XrefRangeEnd = 328941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptObj.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C76E RID: 51054 RVA: 0x003276A4 File Offset: 0x003258A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 328946, RefRangeEnd = 328951, XrefRangeStart = 328941, XrefRangeEnd = 328946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptObj.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C76F RID: 51055 RVA: 0x003276E4 File Offset: 0x003258E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328971, RefRangeEnd = 328974, XrefRangeStart = 328951, XrefRangeEnd = 328971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptObj.NativeMethodInfoPtr_ShowPrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C770 RID: 51056 RVA: 0x00327718 File Offset: 0x00325918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328974, XrefRangeEnd = 328976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HidePrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptObj.NativeMethodInfoPtr_HidePrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C771 RID: 51057 RVA: 0x0032774C File Offset: 0x0032594C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328976, XrefRangeEnd = 328977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDeviceChanged(GameInput.InputDeviceType newInputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newInputDevice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptObj.NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C772 RID: 51058 RVA: 0x0032778C File Offset: 0x0032598C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptObj() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptObj>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptObj.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C773 RID: 51059 RVA: 0x0005E32D File Offset: 0x0005C52D
		public InputPromptObj(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x0600C774 RID: 51060 RVA: 0x003277C8 File Offset: 0x003259C8
		// (set) Token: 0x0600C775 RID: 51061 RVA: 0x0005E336 File Offset: 0x0005C536
		public unsafe InputPromptsItemUI _inputPromptItemUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__inputPromptItemUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__inputPromptItemUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x0600C776 RID: 51062 RVA: 0x003277F8 File Offset: 0x003259F8
		// (set) Token: 0x0600C777 RID: 51063 RVA: 0x0005E355 File Offset: 0x0005C555
		public unsafe Transform _container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x0600C778 RID: 51064 RVA: 0x00327828 File Offset: 0x00325A28
		// (set) Token: 0x0600C779 RID: 51065 RVA: 0x0005E374 File Offset: 0x0005C574
		public unsafe InputPromptsData _promptData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__promptData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__promptData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C86 RID: 15494
		// (get) Token: 0x0600C77A RID: 51066 RVA: 0x00327858 File Offset: 0x00325A58
		// (set) Token: 0x0600C77B RID: 51067 RVA: 0x0005E393 File Offset: 0x0005C593
		public unsafe bool _runOnEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__runOnEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__runOnEnable)) = value;
			}
		}

		// Token: 0x17003C87 RID: 15495
		// (get) Token: 0x0600C77C RID: 51068 RVA: 0x00327880 File Offset: 0x00325A80
		// (set) Token: 0x0600C77D RID: 51069 RVA: 0x0005E3AE File Offset: 0x0005C5AE
		public unsafe bool _enablePulseAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__enablePulseAnimation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__enablePulseAnimation)) = value;
			}
		}

		// Token: 0x17003C88 RID: 15496
		// (get) Token: 0x0600C77E RID: 51070 RVA: 0x003278A8 File Offset: 0x00325AA8
		// (set) Token: 0x0600C77F RID: 51071 RVA: 0x0005E3C9 File Offset: 0x0005C5C9
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptObj.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x040087F4 RID: 34804
		private static readonly IntPtr NativeFieldInfoPtr__inputPromptItemUI;

		// Token: 0x040087F5 RID: 34805
		private static readonly IntPtr NativeFieldInfoPtr__container;

		// Token: 0x040087F6 RID: 34806
		private static readonly IntPtr NativeFieldInfoPtr__promptData;

		// Token: 0x040087F7 RID: 34807
		private static readonly IntPtr NativeFieldInfoPtr__runOnEnable;

		// Token: 0x040087F8 RID: 34808
		private static readonly IntPtr NativeFieldInfoPtr__enablePulseAnimation;

		// Token: 0x040087F9 RID: 34809
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x040087FA RID: 34810
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040087FB RID: 34811
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040087FC RID: 34812
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040087FD RID: 34813
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x040087FE RID: 34814
		private static readonly IntPtr NativeMethodInfoPtr_ShowPrompt_Private_Void_0;

		// Token: 0x040087FF RID: 34815
		private static readonly IntPtr NativeMethodInfoPtr_HidePrompt_Private_Void_0;

		// Token: 0x04008800 RID: 34816
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0;

		// Token: 0x04008801 RID: 34817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

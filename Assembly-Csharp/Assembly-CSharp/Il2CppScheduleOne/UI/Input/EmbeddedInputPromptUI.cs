using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.CustomUI;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000802 RID: 2050
	public class EmbeddedInputPromptUI : MonoBehaviour
	{
		// Token: 0x0600C72D RID: 50989 RVA: 0x00326A94 File Offset: 0x00324C94
		// Note: this type is marked as 'beforefieldinit'.
		static EmbeddedInputPromptUI()
		{
			Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "EmbeddedInputPromptUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr);
			EmbeddedInputPromptUI.NativeFieldInfoPtr__promptImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, "_promptImage");
			EmbeddedInputPromptUI.NativeFieldInfoPtr__promptImageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, "_promptImageLabel");
			EmbeddedInputPromptUI.NativeFieldInfoPtr__promptContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, "_promptContainer");
			EmbeddedInputPromptUI.NativeFieldInfoPtr__layoutElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, "_layoutElement");
			EmbeddedInputPromptUI.NativeFieldInfoPtr__runOnlyWithGamepad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, "_runOnlyWithGamepad");
			EmbeddedInputPromptUI.NativeFieldInfoPtr__useInputSpriteVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, "_useInputSpriteVariation");
			EmbeddedInputPromptUI.NativeFieldInfoPtr__actionBindingReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, "_actionBindingReference");
			EmbeddedInputPromptUI.NativeFieldInfoPtr__isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, "_isActive");
			EmbeddedInputPromptUI.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, 100689094);
			EmbeddedInputPromptUI.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, 100689095);
			EmbeddedInputPromptUI.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, 100689096);
			EmbeddedInputPromptUI.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, 100689097);
			EmbeddedInputPromptUI.NativeMethodInfoPtr_ShowPrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, 100689098);
			EmbeddedInputPromptUI.NativeMethodInfoPtr_UpdatePrompt_Public_Void_InputPromptsBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, 100689099);
			EmbeddedInputPromptUI.NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, 100689100);
			EmbeddedInputPromptUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr, 100689101);
		}

		// Token: 0x0600C72E RID: 50990 RVA: 0x00326C04 File Offset: 0x00324E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328712, XrefRangeEnd = 328734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedInputPromptUI.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C72F RID: 50991 RVA: 0x00326C38 File Offset: 0x00324E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328734, XrefRangeEnd = 328735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedInputPromptUI.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C730 RID: 50992 RVA: 0x00326C6C File Offset: 0x00324E6C
		[CallerCount(0)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedInputPromptUI.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C731 RID: 50993 RVA: 0x00326CA0 File Offset: 0x00324EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328735, XrefRangeEnd = 328736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedInputPromptUI.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C732 RID: 50994 RVA: 0x00326CE0 File Offset: 0x00324EE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 328755, RefRangeEnd = 328758, XrefRangeStart = 328736, XrefRangeEnd = 328755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedInputPromptUI.NativeMethodInfoPtr_ShowPrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C733 RID: 50995 RVA: 0x00326D14 File Offset: 0x00324F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328769, RefRangeEnd = 328770, XrefRangeStart = 328758, XrefRangeEnd = 328769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrompt(InputPromptsBindingData bindingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bindingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedInputPromptUI.NativeMethodInfoPtr_UpdatePrompt_Public_Void_InputPromptsBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C734 RID: 50996 RVA: 0x00326D58 File Offset: 0x00324F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328770, XrefRangeEnd = 328771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDeviceChanged(GameInput.InputDeviceType newInputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newInputDevice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedInputPromptUI.NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C735 RID: 50997 RVA: 0x00326D98 File Offset: 0x00324F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328771, XrefRangeEnd = 328772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmbeddedInputPromptUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmbeddedInputPromptUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmbeddedInputPromptUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C736 RID: 50998 RVA: 0x0005E0BD File Offset: 0x0005C2BD
		public EmbeddedInputPromptUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003C6D RID: 15469
		// (get) Token: 0x0600C737 RID: 50999 RVA: 0x00326DD4 File Offset: 0x00324FD4
		// (set) Token: 0x0600C738 RID: 51000 RVA: 0x0005E0C6 File Offset: 0x0005C2C6
		public unsafe Image _promptImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__promptImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__promptImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C6E RID: 15470
		// (get) Token: 0x0600C739 RID: 51001 RVA: 0x00326E04 File Offset: 0x00325004
		// (set) Token: 0x0600C73A RID: 51002 RVA: 0x0005E0E5 File Offset: 0x0005C2E5
		public unsafe TextMeshProUGUI _promptImageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__promptImageLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__promptImageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C6F RID: 15471
		// (get) Token: 0x0600C73B RID: 51003 RVA: 0x00326E34 File Offset: 0x00325034
		// (set) Token: 0x0600C73C RID: 51004 RVA: 0x0005E104 File Offset: 0x0005C304
		public unsafe Transform _promptContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__promptContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__promptContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C70 RID: 15472
		// (get) Token: 0x0600C73D RID: 51005 RVA: 0x00326E64 File Offset: 0x00325064
		// (set) Token: 0x0600C73E RID: 51006 RVA: 0x0005E123 File Offset: 0x0005C323
		public unsafe LayoutElement _layoutElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__layoutElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__layoutElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C71 RID: 15473
		// (get) Token: 0x0600C73F RID: 51007 RVA: 0x00326E94 File Offset: 0x00325094
		// (set) Token: 0x0600C740 RID: 51008 RVA: 0x0005E142 File Offset: 0x0005C342
		public unsafe bool _runOnlyWithGamepad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__runOnlyWithGamepad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__runOnlyWithGamepad)) = value;
			}
		}

		// Token: 0x17003C72 RID: 15474
		// (get) Token: 0x0600C741 RID: 51009 RVA: 0x00326EBC File Offset: 0x003250BC
		// (set) Token: 0x0600C742 RID: 51010 RVA: 0x0005E15D File Offset: 0x0005C35D
		public unsafe bool _useInputSpriteVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__useInputSpriteVariation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__useInputSpriteVariation)) = value;
			}
		}

		// Token: 0x17003C73 RID: 15475
		// (get) Token: 0x0600C743 RID: 51011 RVA: 0x00326EE4 File Offset: 0x003250E4
		// (set) Token: 0x0600C744 RID: 51012 RVA: 0x0005E178 File Offset: 0x0005C378
		public unsafe ActionBindingReference _actionBindingReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__actionBindingReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionBindingReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__actionBindingReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003C74 RID: 15476
		// (get) Token: 0x0600C745 RID: 51013 RVA: 0x00326F14 File Offset: 0x00325114
		// (set) Token: 0x0600C746 RID: 51014 RVA: 0x0005E197 File Offset: 0x0005C397
		public unsafe bool _isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmbeddedInputPromptUI.NativeFieldInfoPtr__isActive)) = value;
			}
		}

		// Token: 0x040087D0 RID: 34768
		private static readonly IntPtr NativeFieldInfoPtr__promptImage;

		// Token: 0x040087D1 RID: 34769
		private static readonly IntPtr NativeFieldInfoPtr__promptImageLabel;

		// Token: 0x040087D2 RID: 34770
		private static readonly IntPtr NativeFieldInfoPtr__promptContainer;

		// Token: 0x040087D3 RID: 34771
		private static readonly IntPtr NativeFieldInfoPtr__layoutElement;

		// Token: 0x040087D4 RID: 34772
		private static readonly IntPtr NativeFieldInfoPtr__runOnlyWithGamepad;

		// Token: 0x040087D5 RID: 34773
		private static readonly IntPtr NativeFieldInfoPtr__useInputSpriteVariation;

		// Token: 0x040087D6 RID: 34774
		private static readonly IntPtr NativeFieldInfoPtr__actionBindingReference;

		// Token: 0x040087D7 RID: 34775
		private static readonly IntPtr NativeFieldInfoPtr__isActive;

		// Token: 0x040087D8 RID: 34776
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040087D9 RID: 34777
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x040087DA RID: 34778
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x040087DB RID: 34779
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x040087DC RID: 34780
		private static readonly IntPtr NativeMethodInfoPtr_ShowPrompt_Private_Void_0;

		// Token: 0x040087DD RID: 34781
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrompt_Public_Void_InputPromptsBindingData_0;

		// Token: 0x040087DE RID: 34782
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0;

		// Token: 0x040087DF RID: 34783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

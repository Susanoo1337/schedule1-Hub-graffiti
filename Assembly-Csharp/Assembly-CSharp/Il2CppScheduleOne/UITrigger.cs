using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x020000B9 RID: 185
	public class UITrigger : MonoBehaviour
	{
		// Token: 0x060010BA RID: 4282 RVA: 0x000B308C File Offset: 0x000B128C
		// Note: this type is marked as 'beforefieldinit'.
		static UITrigger()
		{
			Il2CppClassPointerStore<UITrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UITrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITrigger>.NativeClassPtr);
			UITrigger.NativeFieldInfoPtr_triggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "triggerType");
			UITrigger.NativeFieldInfoPtr_mouseAlwaysPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "mouseAlwaysPress");
			UITrigger.NativeFieldInfoPtr_holdDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "holdDuration");
			UITrigger.NativeFieldInfoPtr_holdImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "holdImage");
			UITrigger.NativeFieldInfoPtr_uGUISelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "uGUISelectable");
			UITrigger.NativeFieldInfoPtr__loopHold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "_loopHold");
			UITrigger.NativeFieldInfoPtr__triggerOnHoldStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "_triggerOnHoldStart");
			UITrigger.NativeFieldInfoPtr_OnTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "OnTrigger");
			UITrigger.NativeFieldInfoPtr_OnRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "OnRelease");
			UITrigger.NativeFieldInfoPtr__debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "_debugMode");
			UITrigger.NativeFieldInfoPtr_isHolding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "isHolding");
			UITrigger.NativeFieldInfoPtr_holdTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "holdTime");
			UITrigger.NativeFieldInfoPtr_isHoldStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "isHoldStarted");
			UITrigger.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "interactable");
			UITrigger.NativeFieldInfoPtr__isPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, "_isPressed");
			UITrigger.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665407);
			UITrigger.NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665408);
			UITrigger.NativeMethodInfoPtr_get_HoldImage_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665409);
			UITrigger.NativeMethodInfoPtr_set_HoldImage_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665410);
			UITrigger.NativeMethodInfoPtr_GetTriggerType_Internal_TriggerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665411);
			UITrigger.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665412);
			UITrigger.NativeMethodInfoPtr_IsInteractable_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665413);
			UITrigger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665414);
			UITrigger.NativeMethodInfoPtr_OnReset_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665415);
			UITrigger.NativeMethodInfoPtr_DetectTriggerInput_Internal_Virtual_New_Void_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665416);
			UITrigger.NativeMethodInfoPtr_OnInputDown_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665417);
			UITrigger.NativeMethodInfoPtr_OnInputRelease_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665418);
			UITrigger.NativeMethodInfoPtr_OnInputUp_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665419);
			UITrigger.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665420);
			UITrigger.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665421);
			UITrigger.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665422);
			UITrigger.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665423);
			UITrigger.NativeMethodInfoPtr_HandleHoldStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665424);
			UITrigger.NativeMethodInfoPtr_HandleHoldEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665425);
			UITrigger.NativeMethodInfoPtr_UpdateHoldImage_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665426);
			UITrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITrigger>.NativeClassPtr, 100665427);
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x000B338C File Offset: 0x000B158C
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x000B33C8 File Offset: 0x000B15C8
		public unsafe bool Interactable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 85222, RefRangeEnd = 85223, XrefRangeStart = 85217, XrefRangeEnd = 85222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x000B3408 File Offset: 0x000B1608
		// (set) Token: 0x060010BE RID: 4286 RVA: 0x000B3448 File Offset: 0x000B1648
		public unsafe Image HoldImage
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_get_HoldImage_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_set_HoldImage_Public_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x000B348C File Offset: 0x000B168C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UITrigger.TriggerType GetTriggerType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_GetTriggerType_Internal_TriggerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x000B34C8 File Offset: 0x000B16C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85228, RefRangeEnd = 85229, XrefRangeStart = 85223, XrefRangeEnd = 85228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITrigger.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x000B3504 File Offset: 0x000B1704
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 85235, RefRangeEnd = 85239, XrefRangeStart = 85229, XrefRangeEnd = 85235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInteractable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_IsInteractable_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x000B3540 File Offset: 0x000B1740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85239, XrefRangeEnd = 85247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x000B3574 File Offset: 0x000B1774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85247, XrefRangeEnd = 85249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITrigger.NativeMethodInfoPtr_OnReset_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x000B35B0 File Offset: 0x000B17B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85260, RefRangeEnd = 85261, XrefRangeStart = 85249, XrefRangeEnd = 85260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DetectTriggerInput(InputActionReference inputAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITrigger.NativeMethodInfoPtr_DetectTriggerInput_Internal_Virtual_New_Void_InputActionReference_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x000B3600 File Offset: 0x000B1800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85261, XrefRangeEnd = 85283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_OnInputDown_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x000B3634 File Offset: 0x000B1834
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 85303, RefRangeEnd = 85305, XrefRangeStart = 85283, XrefRangeEnd = 85303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputRelease()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_OnInputRelease_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x000B3668 File Offset: 0x000B1868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85305, XrefRangeEnd = 85306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_OnInputUp_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x000B369C File Offset: 0x000B189C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85306, XrefRangeEnd = 85307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITrigger.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x000B36EC File Offset: 0x000B18EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITrigger.NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x000B373C File Offset: 0x000B193C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITrigger.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x000B378C File Offset: 0x000B198C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85307, XrefRangeEnd = 85314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITrigger.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x000B37DC File Offset: 0x000B19DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 85320, RefRangeEnd = 85322, XrefRangeStart = 85314, XrefRangeEnd = 85320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleHoldStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_HandleHoldStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x000B3810 File Offset: 0x000B1A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleHoldEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_HandleHoldEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x000B3844 File Offset: 0x000B1A44
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 85327, RefRangeEnd = 85337, XrefRangeStart = 85322, XrefRangeEnd = 85327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHoldImage(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr_UpdateHoldImage_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x000B3884 File Offset: 0x000B1A84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85338, RefRangeEnd = 85339, XrefRangeStart = 85337, XrefRangeEnd = 85338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UITrigger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UITrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00009BEA File Offset: 0x00007DEA
		public UITrigger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x000B38C0 File Offset: 0x000B1AC0
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x00009BF3 File Offset: 0x00007DF3
		public unsafe UITrigger.TriggerType triggerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_triggerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_triggerType)) = value;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x000B38E8 File Offset: 0x000B1AE8
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x00009C0E File Offset: 0x00007E0E
		public unsafe bool mouseAlwaysPress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_mouseAlwaysPress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_mouseAlwaysPress)) = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x000B3910 File Offset: 0x000B1B10
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x00009C29 File Offset: 0x00007E29
		public unsafe float holdDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_holdDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_holdDuration)) = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x000B3938 File Offset: 0x000B1B38
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x00009C44 File Offset: 0x00007E44
		public unsafe Image holdImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_holdImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_holdImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x000B3968 File Offset: 0x000B1B68
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x00009C63 File Offset: 0x00007E63
		public unsafe Selectable uGUISelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_uGUISelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_uGUISelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x000B3998 File Offset: 0x000B1B98
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x00009C82 File Offset: 0x00007E82
		public unsafe bool _loopHold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr__loopHold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr__loopHold)) = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x000B39C0 File Offset: 0x000B1BC0
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x00009C9D File Offset: 0x00007E9D
		public unsafe bool _triggerOnHoldStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr__triggerOnHoldStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr__triggerOnHoldStart)) = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x000B39E8 File Offset: 0x000B1BE8
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x00009CB8 File Offset: 0x00007EB8
		public unsafe UnityEvent OnTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_OnTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_OnTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x000B3A18 File Offset: 0x000B1C18
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x00009CD7 File Offset: 0x00007ED7
		public unsafe UnityEvent OnRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_OnRelease);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_OnRelease), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x000B3A48 File Offset: 0x000B1C48
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x00009CF6 File Offset: 0x00007EF6
		public unsafe bool _debugMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr__debugMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr__debugMode)) = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x000B3A70 File Offset: 0x000B1C70
		// (set) Token: 0x060010E6 RID: 4326 RVA: 0x00009D11 File Offset: 0x00007F11
		public unsafe bool isHolding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_isHolding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_isHolding)) = value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x000B3A98 File Offset: 0x000B1C98
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x00009D2C File Offset: 0x00007F2C
		public unsafe float holdTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_holdTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_holdTime)) = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x000B3AC0 File Offset: 0x000B1CC0
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x00009D47 File Offset: 0x00007F47
		public unsafe bool isHoldStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_isHoldStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_isHoldStarted)) = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x000B3AE8 File Offset: 0x000B1CE8
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x00009D62 File Offset: 0x00007F62
		public unsafe bool interactable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_interactable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr_interactable)) = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x000B3B10 File Offset: 0x000B1D10
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x00009D7D File Offset: 0x00007F7D
		public unsafe bool _isPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr__isPressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITrigger.NativeFieldInfoPtr__isPressed)) = value;
			}
		}

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeFieldInfoPtr_triggerType;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeFieldInfoPtr_mouseAlwaysPress;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeFieldInfoPtr_holdDuration;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeFieldInfoPtr_holdImage;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeFieldInfoPtr_uGUISelectable;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeFieldInfoPtr__loopHold;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeFieldInfoPtr__triggerOnHoldStart;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeFieldInfoPtr_OnTrigger;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeFieldInfoPtr_OnRelease;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeFieldInfoPtr__debugMode;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeFieldInfoPtr_isHolding;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeFieldInfoPtr_holdTime;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeFieldInfoPtr_isHoldStarted;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeFieldInfoPtr_interactable;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeFieldInfoPtr__isPressed;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Public_set_Void_Boolean_0;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeMethodInfoPtr_get_HoldImage_Public_get_Image_0;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeMethodInfoPtr_set_HoldImage_Public_set_Void_Image_0;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeMethodInfoPtr_GetTriggerType_Internal_TriggerType_0;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeMethodInfoPtr_IsInteractable_Private_Boolean_0;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_OnReset_Internal_Virtual_New_Void_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_DetectTriggerInput_Internal_Virtual_New_Void_InputActionReference_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDown_Internal_Void_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_OnInputRelease_Internal_Void_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_OnInputUp_Internal_Void_0;

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000BC4 RID: 3012
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000BC5 RID: 3013
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000BC6 RID: 3014
		private static readonly IntPtr NativeMethodInfoPtr_HandleHoldStart_Private_Void_0;

		// Token: 0x04000BC7 RID: 3015
		private static readonly IntPtr NativeMethodInfoPtr_HandleHoldEnd_Private_Void_0;

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHoldImage_Private_Void_Single_0;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008CD RID: 2253
		[OriginalName("Assembly-CSharp.dll", "", "TriggerType")]
		public enum TriggerType
		{
			// Token: 0x0400910B RID: 37131
			Press,
			// Token: 0x0400910C RID: 37132
			Hold,
			// Token: 0x0400910D RID: 37133
			PressAndRelease
		}
	}
}

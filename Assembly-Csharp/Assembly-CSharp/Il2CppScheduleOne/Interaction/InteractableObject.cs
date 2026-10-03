using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Input;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x02000331 RID: 817
	public class InteractableObject : MonoBehaviour
	{
		// Token: 0x060045F3 RID: 17907 RVA: 0x001696C4 File Offset: 0x001678C4
		// Note: this type is marked as 'beforefieldinit'.
		static InteractableObject()
		{
			Il2CppClassPointerStore<InteractableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "InteractableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr);
			InteractableObject.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "message");
			InteractableObject.NativeFieldInfoPtr_interactionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "interactionType");
			InteractableObject.NativeFieldInfoPtr_interactionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "interactionState");
			InteractableObject.NativeFieldInfoPtr_MaxInteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "MaxInteractionRange");
			InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "RequiresUniqueClick");
			InteractableObject.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "Priority");
			InteractableObject.NativeFieldInfoPtr_displayLocationCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "displayLocationCollider");
			InteractableObject.NativeFieldInfoPtr_displayLocationPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "displayLocationPoint");
			InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "LimitInteractionAngle");
			InteractableObject.NativeFieldInfoPtr_AngleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "AngleLimit");
			InteractableObject.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onHovered");
			InteractableObject.NativeFieldInfoPtr_onInteractStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onInteractStart");
			InteractableObject.NativeFieldInfoPtr_onInteractEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "onInteractEnd");
			InteractableObject.NativeFieldInfoPtr__isMessageActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "_isMessageActive");
			InteractableObject.NativeFieldInfoPtr__currentBindingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "_currentBindingData");
			InteractableObject.NativeFieldInfoPtr__descriptorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, "_descriptorData");
			InteractableObject.NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672313);
			InteractableObject.NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672314);
			InteractableObject.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672315);
			InteractableObject.NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672316);
			InteractableObject.NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672317);
			InteractableObject.NativeMethodInfoPtr_SetMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672318);
			InteractableObject.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672319);
			InteractableObject.NativeMethodInfoPtr_Exited_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672320);
			InteractableObject.NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672321);
			InteractableObject.NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672322);
			InteractableObject.NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672323);
			InteractableObject.NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672324);
			InteractableObject.NativeMethodInfoPtr_SetInputData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672325);
			InteractableObject.NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672326);
			InteractableObject.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672327);
			InteractableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr, 100672328);
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x00169974 File Offset: 0x00167B74
		public unsafe InteractableObject.EInteractionType _interactionType
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 29072, RefRangeEnd = 29101, XrefRangeStart = 29072, XrefRangeEnd = 29101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x001699B0 File Offset: 0x00167BB0
		public unsafe InteractableObject.EInteractableState _interactionState
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 70643, RefRangeEnd = 70670, XrefRangeStart = 70643, XrefRangeEnd = 70670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x001699EC File Offset: 0x00167BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165183, XrefRangeEnd = 165205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x00169A20 File Offset: 0x00167C20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29101, RefRangeEnd = 29102, XrefRangeStart = 29101, XrefRangeEnd = 29102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractionType(InteractableObject.EInteractionType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F8 RID: 17912 RVA: 0x00169A60 File Offset: 0x00167C60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165205, RefRangeEnd = 165206, XrefRangeStart = 165205, XrefRangeEnd = 165205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractableState(InteractableObject.EInteractableState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F9 RID: 17913 RVA: 0x00169AA0 File Offset: 0x00167CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessage(string _message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FA RID: 17914 RVA: 0x00169AE4 File Offset: 0x00167CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165208, RefRangeEnd = 165209, XrefRangeStart = 165206, XrefRangeEnd = 165208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00169B20 File Offset: 0x00167D20
		[CallerCount(0)]
		public unsafe virtual void Exited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_Exited_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00169B5C File Offset: 0x00167D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165215, RefRangeEnd = 165216, XrefRangeStart = 165209, XrefRangeEnd = 165215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x00169B98 File Offset: 0x00167D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165216, XrefRangeEnd = 165223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x00169BD4 File Offset: 0x00167DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165223, XrefRangeEnd = 165250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractableObject.NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00169C10 File Offset: 0x00167E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165259, RefRangeEnd = 165260, XrefRangeStart = 165250, XrefRangeEnd = 165259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckAngleLimit(Vector3 interactionSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactionSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00169C5C File Offset: 0x00167E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 165281, RefRangeEnd = 165283, XrefRangeStart = 165260, XrefRangeEnd = 165281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInputData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_SetInputData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00169C90 File Offset: 0x00167E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165283, XrefRangeEnd = 165292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputChange(GameInput.InputDeviceType deviceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deviceType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00169CD0 File Offset: 0x00167ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165292, XrefRangeEnd = 165314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00169D04 File Offset: 0x00167F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 165332, RefRangeEnd = 165333, XrefRangeStart = 165314, XrefRangeEnd = 165332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractableObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x0002210E File Offset: 0x0002030E
		public InteractableObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06004605 RID: 17925 RVA: 0x00169D40 File Offset: 0x00167F40
		// (set) Token: 0x06004606 RID: 17926 RVA: 0x00022117 File Offset: 0x00020317
		public unsafe string message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06004607 RID: 17927 RVA: 0x00169D68 File Offset: 0x00167F68
		// (set) Token: 0x06004608 RID: 17928 RVA: 0x00022136 File Offset: 0x00020336
		public unsafe InteractableObject.EInteractionType interactionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionType)) = value;
			}
		}

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x06004609 RID: 17929 RVA: 0x00169D90 File Offset: 0x00167F90
		// (set) Token: 0x0600460A RID: 17930 RVA: 0x00022151 File Offset: 0x00020351
		public unsafe InteractableObject.EInteractableState interactionState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_interactionState)) = value;
			}
		}

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x0600460B RID: 17931 RVA: 0x00169DB8 File Offset: 0x00167FB8
		// (set) Token: 0x0600460C RID: 17932 RVA: 0x0002216C File Offset: 0x0002036C
		public unsafe float MaxInteractionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_MaxInteractionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_MaxInteractionRange)) = value;
			}
		}

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x0600460D RID: 17933 RVA: 0x00169DE0 File Offset: 0x00167FE0
		// (set) Token: 0x0600460E RID: 17934 RVA: 0x00022187 File Offset: 0x00020387
		public unsafe bool RequiresUniqueClick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_RequiresUniqueClick)) = value;
			}
		}

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x0600460F RID: 17935 RVA: 0x00169E08 File Offset: 0x00168008
		// (set) Token: 0x06004610 RID: 17936 RVA: 0x000221A2 File Offset: 0x000203A2
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06004611 RID: 17937 RVA: 0x00169E30 File Offset: 0x00168030
		// (set) Token: 0x06004612 RID: 17938 RVA: 0x000221BD File Offset: 0x000203BD
		public unsafe Collider displayLocationCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x00169E60 File Offset: 0x00168060
		// (set) Token: 0x06004614 RID: 17940 RVA: 0x000221DC File Offset: 0x000203DC
		public unsafe Transform displayLocationPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_displayLocationPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06004615 RID: 17941 RVA: 0x00169E90 File Offset: 0x00168090
		// (set) Token: 0x06004616 RID: 17942 RVA: 0x000221FB File Offset: 0x000203FB
		public unsafe bool LimitInteractionAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_LimitInteractionAngle)) = value;
			}
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x00169EB8 File Offset: 0x001680B8
		// (set) Token: 0x06004618 RID: 17944 RVA: 0x00022216 File Offset: 0x00020416
		public unsafe float AngleLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_AngleLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_AngleLimit)) = value;
			}
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x00169EE0 File Offset: 0x001680E0
		// (set) Token: 0x0600461A RID: 17946 RVA: 0x00022231 File Offset: 0x00020431
		public unsafe UnityEvent onHovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onHovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x00169F10 File Offset: 0x00168110
		// (set) Token: 0x0600461C RID: 17948 RVA: 0x00022250 File Offset: 0x00020450
		public unsafe UnityEvent onInteractStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x00169F40 File Offset: 0x00168140
		// (set) Token: 0x0600461E RID: 17950 RVA: 0x0002226F File Offset: 0x0002046F
		public unsafe UnityEvent onInteractEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr_onInteractEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x00169F70 File Offset: 0x00168170
		// (set) Token: 0x06004620 RID: 17952 RVA: 0x0002228E File Offset: 0x0002048E
		public unsafe bool _isMessageActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr__isMessageActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr__isMessageActive)) = value;
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x00169F98 File Offset: 0x00168198
		// (set) Token: 0x06004622 RID: 17954 RVA: 0x000222A9 File Offset: 0x000204A9
		public unsafe InputPromptsBindingData _currentBindingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr__currentBindingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsBindingData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr__currentBindingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x00169FC8 File Offset: 0x001681C8
		// (set) Token: 0x06004624 RID: 17956 RVA: 0x000222C8 File Offset: 0x000204C8
		public unsafe InputPromptsDescriptorData _descriptorData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr__descriptorData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsDescriptorData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteractableObject.NativeFieldInfoPtr__descriptorData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FA4 RID: 12196
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04002FA5 RID: 12197
		private static readonly IntPtr NativeFieldInfoPtr_interactionType;

		// Token: 0x04002FA6 RID: 12198
		private static readonly IntPtr NativeFieldInfoPtr_interactionState;

		// Token: 0x04002FA7 RID: 12199
		private static readonly IntPtr NativeFieldInfoPtr_MaxInteractionRange;

		// Token: 0x04002FA8 RID: 12200
		private static readonly IntPtr NativeFieldInfoPtr_RequiresUniqueClick;

		// Token: 0x04002FA9 RID: 12201
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04002FAA RID: 12202
		private static readonly IntPtr NativeFieldInfoPtr_displayLocationCollider;

		// Token: 0x04002FAB RID: 12203
		private static readonly IntPtr NativeFieldInfoPtr_displayLocationPoint;

		// Token: 0x04002FAC RID: 12204
		private static readonly IntPtr NativeFieldInfoPtr_LimitInteractionAngle;

		// Token: 0x04002FAD RID: 12205
		private static readonly IntPtr NativeFieldInfoPtr_AngleLimit;

		// Token: 0x04002FAE RID: 12206
		private static readonly IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x04002FAF RID: 12207
		private static readonly IntPtr NativeFieldInfoPtr_onInteractStart;

		// Token: 0x04002FB0 RID: 12208
		private static readonly IntPtr NativeFieldInfoPtr_onInteractEnd;

		// Token: 0x04002FB1 RID: 12209
		private static readonly IntPtr NativeFieldInfoPtr__isMessageActive;

		// Token: 0x04002FB2 RID: 12210
		private static readonly IntPtr NativeFieldInfoPtr__currentBindingData;

		// Token: 0x04002FB3 RID: 12211
		private static readonly IntPtr NativeFieldInfoPtr__descriptorData;

		// Token: 0x04002FB4 RID: 12212
		private static readonly IntPtr NativeMethodInfoPtr_get__interactionType_Public_get_EInteractionType_0;

		// Token: 0x04002FB5 RID: 12213
		private static readonly IntPtr NativeMethodInfoPtr_get__interactionState_Public_get_EInteractableState_0;

		// Token: 0x04002FB6 RID: 12214
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04002FB7 RID: 12215
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractionType_Public_Void_EInteractionType_0;

		// Token: 0x04002FB8 RID: 12216
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractableState_Public_Void_EInteractableState_0;

		// Token: 0x04002FB9 RID: 12217
		private static readonly IntPtr NativeMethodInfoPtr_SetMessage_Public_Void_String_0;

		// Token: 0x04002FBA RID: 12218
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x04002FBB RID: 12219
		private static readonly IntPtr NativeMethodInfoPtr_Exited_Public_Virtual_New_Void_0;

		// Token: 0x04002FBC RID: 12220
		private static readonly IntPtr NativeMethodInfoPtr_StartInteract_Public_Virtual_New_Void_0;

		// Token: 0x04002FBD RID: 12221
		private static readonly IntPtr NativeMethodInfoPtr_EndInteract_Public_Virtual_New_Void_0;

		// Token: 0x04002FBE RID: 12222
		private static readonly IntPtr NativeMethodInfoPtr_ShowMessage_Protected_Virtual_New_Void_0;

		// Token: 0x04002FBF RID: 12223
		private static readonly IntPtr NativeMethodInfoPtr_CheckAngleLimit_Public_Boolean_Vector3_0;

		// Token: 0x04002FC0 RID: 12224
		private static readonly IntPtr NativeMethodInfoPtr_SetInputData_Private_Void_0;

		// Token: 0x04002FC1 RID: 12225
		private static readonly IntPtr NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0;

		// Token: 0x04002FC2 RID: 12226
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002FC3 RID: 12227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A61 RID: 2657
		[OriginalName("Assembly-CSharp.dll", "", "EInteractionType")]
		public enum EInteractionType
		{
			// Token: 0x040098ED RID: 39149
			Key_Press,
			// Token: 0x040098EE RID: 39150
			LeftMouse_Click
		}

		// Token: 0x02000A62 RID: 2658
		[OriginalName("Assembly-CSharp.dll", "", "EInteractableState")]
		public enum EInteractableState
		{
			// Token: 0x040098F0 RID: 39152
			Default,
			// Token: 0x040098F1 RID: 39153
			Invalid,
			// Token: 0x040098F2 RID: 39154
			Disabled,
			// Token: 0x040098F3 RID: 39155
			Label
		}
	}
}

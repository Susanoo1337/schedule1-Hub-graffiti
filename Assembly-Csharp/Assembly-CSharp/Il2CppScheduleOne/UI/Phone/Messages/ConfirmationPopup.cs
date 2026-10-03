using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020007B7 RID: 1975
	public class ConfirmationPopup : MonoBehaviour
	{
		// Token: 0x0600C100 RID: 49408 RVA: 0x003140C8 File Offset: 0x003122C8
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmationPopup()
		{
			Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "ConfirmationPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr);
			ConfirmationPopup.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, "<IsOpen>k__BackingField");
			ConfirmationPopup.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, "Container");
			ConfirmationPopup.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, "TitleLabel");
			ConfirmationPopup.NativeFieldInfoPtr_MessageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, "MessageLabel");
			ConfirmationPopup.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, "ConfirmButton");
			ConfirmationPopup.NativeFieldInfoPtr_CancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, "CancelButton");
			ConfirmationPopup.NativeFieldInfoPtr_uiScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, "uiScreen");
			ConfirmationPopup.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, "conversation");
			ConfirmationPopup.NativeFieldInfoPtr_responseCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, "responseCallback");
			ConfirmationPopup.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, 100688431);
			ConfirmationPopup.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, 100688432);
			ConfirmationPopup.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, 100688433);
			ConfirmationPopup.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, 100688434);
			ConfirmationPopup.NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_Action_1_EResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, 100688435);
			ConfirmationPopup.NativeMethodInfoPtr_Close_Public_Void_EResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, 100688436);
			ConfirmationPopup.NativeMethodInfoPtr_Confirm_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, 100688437);
			ConfirmationPopup.NativeMethodInfoPtr_Cancel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, 100688438);
			ConfirmationPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr, 100688439);
		}

		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x0600C101 RID: 49409 RVA: 0x00314260 File Offset: 0x00312460
		// (set) Token: 0x0600C102 RID: 49410 RVA: 0x0031429C File Offset: 0x0031249C
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmationPopup.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmationPopup.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C103 RID: 49411 RVA: 0x003142DC File Offset: 0x003124DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320672, XrefRangeEnd = 320697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmationPopup.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C104 RID: 49412 RVA: 0x00314310 File Offset: 0x00312510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320697, XrefRangeEnd = 320702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmationPopup.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C105 RID: 49413 RVA: 0x00314354 File Offset: 0x00312554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320725, RefRangeEnd = 320726, XrefRangeStart = 320702, XrefRangeEnd = 320725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string message, MSGConversation conv, Action<ConfirmationPopup.EResponse> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conv);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmationPopup.NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_Action_1_EResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C106 RID: 49414 RVA: 0x003143D0 File Offset: 0x003125D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 320748, RefRangeEnd = 320752, XrefRangeStart = 320726, XrefRangeEnd = 320748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(ConfirmationPopup.EResponse outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmationPopup.NativeMethodInfoPtr_Close_Public_Void_EResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C107 RID: 49415 RVA: 0x00314410 File Offset: 0x00312610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320752, XrefRangeEnd = 320753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmationPopup.NativeMethodInfoPtr_Confirm_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C108 RID: 49416 RVA: 0x00314444 File Offset: 0x00312644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320753, XrefRangeEnd = 320754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmationPopup.NativeMethodInfoPtr_Cancel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C109 RID: 49417 RVA: 0x00314478 File Offset: 0x00312678
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmationPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmationPopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmationPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C10A RID: 49418 RVA: 0x0005A7ED File Offset: 0x000589ED
		public ConfirmationPopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003A6E RID: 14958
		// (get) Token: 0x0600C10B RID: 49419 RVA: 0x003144B4 File Offset: 0x003126B4
		// (set) Token: 0x0600C10C RID: 49420 RVA: 0x0005A7F6 File Offset: 0x000589F6
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003A6F RID: 14959
		// (get) Token: 0x0600C10D RID: 49421 RVA: 0x003144DC File Offset: 0x003126DC
		// (set) Token: 0x0600C10E RID: 49422 RVA: 0x0005A811 File Offset: 0x00058A11
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A70 RID: 14960
		// (get) Token: 0x0600C10F RID: 49423 RVA: 0x0031450C File Offset: 0x0031270C
		// (set) Token: 0x0600C110 RID: 49424 RVA: 0x0005A830 File Offset: 0x00058A30
		public unsafe Text TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x0600C111 RID: 49425 RVA: 0x0031453C File Offset: 0x0031273C
		// (set) Token: 0x0600C112 RID: 49426 RVA: 0x0005A84F File Offset: 0x00058A4F
		public unsafe Text MessageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_MessageLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_MessageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x0600C113 RID: 49427 RVA: 0x0031456C File Offset: 0x0031276C
		// (set) Token: 0x0600C114 RID: 49428 RVA: 0x0005A86E File Offset: 0x00058A6E
		public unsafe Button ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x0600C115 RID: 49429 RVA: 0x0031459C File Offset: 0x0031279C
		// (set) Token: 0x0600C116 RID: 49430 RVA: 0x0005A88D File Offset: 0x00058A8D
		public unsafe Button CancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_CancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_CancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x0600C117 RID: 49431 RVA: 0x003145CC File Offset: 0x003127CC
		// (set) Token: 0x0600C118 RID: 49432 RVA: 0x0005A8AC File Offset: 0x00058AAC
		public unsafe UIScreen uiScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_uiScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_uiScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x0600C119 RID: 49433 RVA: 0x003145FC File Offset: 0x003127FC
		// (set) Token: 0x0600C11A RID: 49434 RVA: 0x0005A8CB File Offset: 0x00058ACB
		public unsafe MSGConversation conversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_conversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x0600C11B RID: 49435 RVA: 0x0031462C File Offset: 0x0031282C
		// (set) Token: 0x0600C11C RID: 49436 RVA: 0x0005A8EA File Offset: 0x00058AEA
		public unsafe Action<ConfirmationPopup.EResponse> responseCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_responseCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ConfirmationPopup.EResponse>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmationPopup.NativeFieldInfoPtr_responseCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400840B RID: 33803
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400840C RID: 33804
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400840D RID: 33805
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x0400840E RID: 33806
		private static readonly IntPtr NativeFieldInfoPtr_MessageLabel;

		// Token: 0x0400840F RID: 33807
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x04008410 RID: 33808
		private static readonly IntPtr NativeFieldInfoPtr_CancelButton;

		// Token: 0x04008411 RID: 33809
		private static readonly IntPtr NativeFieldInfoPtr_uiScreen;

		// Token: 0x04008412 RID: 33810
		private static readonly IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x04008413 RID: 33811
		private static readonly IntPtr NativeFieldInfoPtr_responseCallback;

		// Token: 0x04008414 RID: 33812
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008415 RID: 33813
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04008416 RID: 33814
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04008417 RID: 33815
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04008418 RID: 33816
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_Action_1_EResponse_0;

		// Token: 0x04008419 RID: 33817
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_EResponse_0;

		// Token: 0x0400841A RID: 33818
		private static readonly IntPtr NativeMethodInfoPtr_Confirm_Private_Void_0;

		// Token: 0x0400841B RID: 33819
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Private_Void_0;

		// Token: 0x0400841C RID: 33820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D3F RID: 3391
		[OriginalName("Assembly-CSharp.dll", "", "EResponse")]
		public enum EResponse
		{
			// Token: 0x0400A898 RID: 43160
			Confirm,
			// Token: 0x0400A899 RID: 43161
			Cancel
		}
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020007BC RID: 1980
	public class MessageSenderInterface : MonoBehaviour
	{
		// Token: 0x0600C1EB RID: 49643 RVA: 0x00316A74 File Offset: 0x00314C74
		// Note: this type is marked as 'beforefieldinit'.
		static MessageSenderInterface()
		{
			Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageSenderInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr);
			MessageSenderInterface.NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "Visibility");
			MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "DockedMenuYPos");
			MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ExpandedMenuYPos");
			MessageSenderInterface.NativeFieldInfoPtr_Menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "Menu");
			MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "SendablesContainer");
			MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "DockedUIElements");
			MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ExpandedUIElements");
			MessageSenderInterface.NativeFieldInfoPtr_ComposeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ComposeButton");
			MessageSenderInterface.NativeFieldInfoPtr_CancelButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "CancelButtons");
			MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "sendableBubbles");
			MessageSenderInterface.NativeFieldInfoPtr_sendableMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "sendableMap");
			MessageSenderInterface.NativeFieldInfoPtr_bubbleUISelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "bubbleUISelectables");
			MessageSenderInterface.NativeFieldInfoPtr__dialogueScreenUIPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "<dialogueScreenUIPanel>k__BackingField");
			MessageSenderInterface.NativeMethodInfoPtr_get_dialogueScreenUIPanel_Public_get_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100688526);
			MessageSenderInterface.NativeMethodInfoPtr_set_dialogueScreenUIPanel_Public_set_Void_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100688527);
			MessageSenderInterface.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100688528);
			MessageSenderInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100688529);
			MessageSenderInterface.NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100688530);
			MessageSenderInterface.NativeMethodInfoPtr_UpdateSendables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100688531);
			MessageSenderInterface.NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100688532);
			MessageSenderInterface.NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100688533);
			MessageSenderInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100688534);
			MessageSenderInterface.NativeMethodInfoPtr__Awake_b__17_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100688535);
			MessageSenderInterface.NativeMethodInfoPtr__Awake_b__17_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100688536);
		}

		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x0600C1EC RID: 49644 RVA: 0x00316C84 File Offset: 0x00314E84
		// (set) Token: 0x0600C1ED RID: 49645 RVA: 0x00316CC4 File Offset: 0x00314EC4
		public unsafe UIPanel dialogueScreenUIPanel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41608, RefRangeEnd = 41609, XrefRangeStart = 41608, XrefRangeEnd = 41609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_get_dialogueScreenUIPanel_Public_get_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_set_dialogueScreenUIPanel_Public_set_Void_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C1EE RID: 49646 RVA: 0x00316D08 File Offset: 0x00314F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321472, XrefRangeEnd = 321498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C1EF RID: 49647 RVA: 0x00316D3C File Offset: 0x00314F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321498, XrefRangeEnd = 321500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C1F0 RID: 49648 RVA: 0x00316D80 File Offset: 0x00314F80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 321539, RefRangeEnd = 321544, XrefRangeStart = 321500, XrefRangeEnd = 321539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibility(MessageSenderInterface.EVisibility visibility)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visibility;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C1F1 RID: 49649 RVA: 0x00316DC0 File Offset: 0x00314FC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321565, RefRangeEnd = 321567, XrefRangeStart = 321544, XrefRangeEnd = 321565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSendables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_UpdateSendables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C1F2 RID: 49650 RVA: 0x00316DF4 File Offset: 0x00314FF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321609, RefRangeEnd = 321611, XrefRangeStart = 321567, XrefRangeEnd = 321609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSendable(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x00316E38 File Offset: 0x00315038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321611, XrefRangeEnd = 321613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendableSelected(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageSenderInterface.NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C1F4 RID: 49652 RVA: 0x00316E88 File Offset: 0x00315088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321613, XrefRangeEnd = 321635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageSenderInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C1F5 RID: 49653 RVA: 0x00316EC4 File Offset: 0x003150C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321635, XrefRangeEnd = 321636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__17_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__Awake_b__17_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C1F6 RID: 49654 RVA: 0x00316EF8 File Offset: 0x003150F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321636, XrefRangeEnd = 321637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__17_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__Awake_b__17_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C1F7 RID: 49655 RVA: 0x0005B173 File Offset: 0x00059373
		public MessageSenderInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x0600C1F8 RID: 49656 RVA: 0x00316F2C File Offset: 0x0031512C
		// (set) Token: 0x0600C1F9 RID: 49657 RVA: 0x0005B17C File Offset: 0x0005937C
		public unsafe MessageSenderInterface.EVisibility Visibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Visibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Visibility)) = value;
			}
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x0600C1FA RID: 49658 RVA: 0x00316F54 File Offset: 0x00315154
		// (set) Token: 0x0600C1FB RID: 49659 RVA: 0x0005B197 File Offset: 0x00059397
		public unsafe float DockedMenuYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos)) = value;
			}
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x0600C1FC RID: 49660 RVA: 0x00316F7C File Offset: 0x0031517C
		// (set) Token: 0x0600C1FD RID: 49661 RVA: 0x0005B1B2 File Offset: 0x000593B2
		public unsafe float ExpandedMenuYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos)) = value;
			}
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x0600C1FE RID: 49662 RVA: 0x00316FA4 File Offset: 0x003151A4
		// (set) Token: 0x0600C1FF RID: 49663 RVA: 0x0005B1CD File Offset: 0x000593CD
		public unsafe RectTransform Menu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Menu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Menu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x0600C200 RID: 49664 RVA: 0x00316FD4 File Offset: 0x003151D4
		// (set) Token: 0x0600C201 RID: 49665 RVA: 0x0005B1EC File Offset: 0x000593EC
		public unsafe RectTransform SendablesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x0600C202 RID: 49666 RVA: 0x00317004 File Offset: 0x00315204
		// (set) Token: 0x0600C203 RID: 49667 RVA: 0x0005B20B File Offset: 0x0005940B
		public unsafe Il2CppReferenceArray<RectTransform> DockedUIElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x0600C204 RID: 49668 RVA: 0x00317034 File Offset: 0x00315234
		// (set) Token: 0x0600C205 RID: 49669 RVA: 0x0005B22A File Offset: 0x0005942A
		public unsafe Il2CppReferenceArray<RectTransform> ExpandedUIElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x0600C206 RID: 49670 RVA: 0x00317064 File Offset: 0x00315264
		// (set) Token: 0x0600C207 RID: 49671 RVA: 0x0005B249 File Offset: 0x00059449
		public unsafe Button ComposeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ComposeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ComposeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AD0 RID: 15056
		// (get) Token: 0x0600C208 RID: 49672 RVA: 0x00317094 File Offset: 0x00315294
		// (set) Token: 0x0600C209 RID: 49673 RVA: 0x0005B268 File Offset: 0x00059468
		public unsafe Il2CppReferenceArray<Button> CancelButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_CancelButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_CancelButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x0600C20A RID: 49674 RVA: 0x003170C4 File Offset: 0x003152C4
		// (set) Token: 0x0600C20B RID: 49675 RVA: 0x0005B287 File Offset: 0x00059487
		public unsafe List<MessageBubble> sendableBubbles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageBubble>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x0600C20C RID: 49676 RVA: 0x003170F4 File Offset: 0x003152F4
		// (set) Token: 0x0600C20D RID: 49677 RVA: 0x0005B2A6 File Offset: 0x000594A6
		public unsafe Dictionary<MessageBubble, SendableMessage> sendableMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MessageBubble, SendableMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x0600C20E RID: 49678 RVA: 0x00317124 File Offset: 0x00315324
		// (set) Token: 0x0600C20F RID: 49679 RVA: 0x0005B2C5 File Offset: 0x000594C5
		public unsafe List<UISelectable> bubbleUISelectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_bubbleUISelectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UISelectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_bubbleUISelectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x0600C210 RID: 49680 RVA: 0x00317154 File Offset: 0x00315354
		// (set) Token: 0x0600C211 RID: 49681 RVA: 0x0005B2E4 File Offset: 0x000594E4
		public unsafe UIPanel _dialogueScreenUIPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr__dialogueScreenUIPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr__dialogueScreenUIPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008499 RID: 33945
		private static readonly IntPtr NativeFieldInfoPtr_Visibility;

		// Token: 0x0400849A RID: 33946
		private static readonly IntPtr NativeFieldInfoPtr_DockedMenuYPos;

		// Token: 0x0400849B RID: 33947
		private static readonly IntPtr NativeFieldInfoPtr_ExpandedMenuYPos;

		// Token: 0x0400849C RID: 33948
		private static readonly IntPtr NativeFieldInfoPtr_Menu;

		// Token: 0x0400849D RID: 33949
		private static readonly IntPtr NativeFieldInfoPtr_SendablesContainer;

		// Token: 0x0400849E RID: 33950
		private static readonly IntPtr NativeFieldInfoPtr_DockedUIElements;

		// Token: 0x0400849F RID: 33951
		private static readonly IntPtr NativeFieldInfoPtr_ExpandedUIElements;

		// Token: 0x040084A0 RID: 33952
		private static readonly IntPtr NativeFieldInfoPtr_ComposeButton;

		// Token: 0x040084A1 RID: 33953
		private static readonly IntPtr NativeFieldInfoPtr_CancelButtons;

		// Token: 0x040084A2 RID: 33954
		private static readonly IntPtr NativeFieldInfoPtr_sendableBubbles;

		// Token: 0x040084A3 RID: 33955
		private static readonly IntPtr NativeFieldInfoPtr_sendableMap;

		// Token: 0x040084A4 RID: 33956
		private static readonly IntPtr NativeFieldInfoPtr_bubbleUISelectables;

		// Token: 0x040084A5 RID: 33957
		private static readonly IntPtr NativeFieldInfoPtr__dialogueScreenUIPanel_k__BackingField;

		// Token: 0x040084A6 RID: 33958
		private static readonly IntPtr NativeMethodInfoPtr_get_dialogueScreenUIPanel_Public_get_UIPanel_0;

		// Token: 0x040084A7 RID: 33959
		private static readonly IntPtr NativeMethodInfoPtr_set_dialogueScreenUIPanel_Public_set_Void_UIPanel_0;

		// Token: 0x040084A8 RID: 33960
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040084A9 RID: 33961
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040084AA RID: 33962
		private static readonly IntPtr NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0;

		// Token: 0x040084AB RID: 33963
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSendables_Public_Void_0;

		// Token: 0x040084AC RID: 33964
		private static readonly IntPtr NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0;

		// Token: 0x040084AD RID: 33965
		private static readonly IntPtr NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0;

		// Token: 0x040084AE RID: 33966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040084AF RID: 33967
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__17_0_Private_Void_0;

		// Token: 0x040084B0 RID: 33968
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__17_1_Private_Void_0;

		// Token: 0x02000D4A RID: 3402
		[OriginalName("Assembly-CSharp.dll", "", "EVisibility")]
		public enum EVisibility
		{
			// Token: 0x0400A8D6 RID: 43222
			Hidden,
			// Token: 0x0400A8D7 RID: 43223
			Docked,
			// Token: 0x0400A8D8 RID: 43224
			Expanded
		}

		// Token: 0x02000D4B RID: 3403
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessageSenderInterface+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FA0A RID: 64010 RVA: 0x003BC758 File Offset: 0x003BA958
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass21_0>.NativeClassPtr);
				MessageSenderInterface.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				MessageSenderInterface.__c__DisplayClass21_0.NativeFieldInfoPtr_sendable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass21_0>.NativeClassPtr, "sendable");
				MessageSenderInterface.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass21_0>.NativeClassPtr, 100688537);
				MessageSenderInterface.__c__DisplayClass21_0.NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass21_0>.NativeClassPtr, 100688538);
			}

			// Token: 0x0600FA0B RID: 64011 RVA: 0x003BC7D4 File Offset: 0x003BA9D4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA0C RID: 64012 RVA: 0x003BC810 File Offset: 0x003BAA10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321471, XrefRangeEnd = 321472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddSendable_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.__c__DisplayClass21_0.NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA0D RID: 64013 RVA: 0x0007644E File Offset: 0x0007464E
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C04 RID: 19460
			// (get) Token: 0x0600FA0E RID: 64014 RVA: 0x003BC844 File Offset: 0x003BAA44
			// (set) Token: 0x0600FA0F RID: 64015 RVA: 0x00076457 File Offset: 0x00074657
			public unsafe MessageSenderInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageSenderInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C05 RID: 19461
			// (get) Token: 0x0600FA10 RID: 64016 RVA: 0x003BC874 File Offset: 0x003BAA74
			// (set) Token: 0x0600FA11 RID: 64017 RVA: 0x00076476 File Offset: 0x00074676
			public unsafe SendableMessage sendable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass21_0.NativeFieldInfoPtr_sendable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass21_0.NativeFieldInfoPtr_sendable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8D9 RID: 43225
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8DA RID: 43226
			private static readonly IntPtr NativeFieldInfoPtr_sendable;

			// Token: 0x0400A8DB RID: 43227
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8DC RID: 43228
			private static readonly IntPtr NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0;
		}
	}
}

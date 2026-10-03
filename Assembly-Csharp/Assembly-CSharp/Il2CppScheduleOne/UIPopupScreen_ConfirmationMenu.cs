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

namespace Il2CppScheduleOne
{
	// Token: 0x020000AA RID: 170
	public class UIPopupScreen_ConfirmationMenu : UIPopupScreen
	{
		// Token: 0x06000ECC RID: 3788 RVA: 0x000ACAC8 File Offset: 0x000AACC8
		// Note: this type is marked as 'beforefieldinit'.
		static UIPopupScreen_ConfirmationMenu()
		{
			Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIPopupScreen_ConfirmationMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr);
			UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, "titleText");
			UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_messageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, "messageText");
			UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, "confirmButton");
			UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_cancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, "cancelButton");
			UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, "canvas");
			UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, 100665169);
			UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr_Open_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, 100665170);
			UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr_Open_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, 100665171);
			UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr_RegisterInput_Private_IEnumerator_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, 100665172);
			UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr_SelectPanel_Private_Void_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, 100665173);
			UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, 100665174);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000ACBD4 File Offset: 0x000AADD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82049, XrefRangeEnd = 82058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x000ACC10 File Offset: 0x000AAE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82058, XrefRangeEnd = 82069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr_Open_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000ACC44 File Offset: 0x000AAE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82069, XrefRangeEnd = 82121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr_Open_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000ACCA0 File Offset: 0x000AAEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82121, XrefRangeEnd = 82128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RegisterInput(Action onConfirm, Action onCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onConfirm);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onCancel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr_RegisterInput_Private_IEnumerator_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x000ACD04 File Offset: 0x000AAF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82128, XrefRangeEnd = 82138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPanel(UISelectable selectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr_SelectPanel_Private_Void_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x000ACD48 File Offset: 0x000AAF48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81996, RefRangeEnd = 81998, XrefRangeStart = 81996, XrefRangeEnd = 81998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIPopupScreen_ConfirmationMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00008C9F File Offset: 0x00006E9F
		public override void Open(params Il2CppSystem.Object[] args)
		{
			this.Open(new Il2CppReferenceArray<Il2CppSystem.Object>(args));
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00008CAD File Offset: 0x00006EAD
		public UIPopupScreen_ConfirmationMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x000ACD84 File Offset: 0x000AAF84
		// (set) Token: 0x06000ED6 RID: 3798 RVA: 0x00008CB6 File Offset: 0x00006EB6
		public unsafe TMP_Text titleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_titleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_titleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x000ACDB4 File Offset: 0x000AAFB4
		// (set) Token: 0x06000ED8 RID: 3800 RVA: 0x00008CD5 File Offset: 0x00006ED5
		public unsafe TMP_Text messageText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_messageText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_messageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x000ACDE4 File Offset: 0x000AAFE4
		// (set) Token: 0x06000EDA RID: 3802 RVA: 0x00008CF4 File Offset: 0x00006EF4
		public unsafe UISelectable confirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_confirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000EDB RID: 3803 RVA: 0x000ACE14 File Offset: 0x000AB014
		// (set) Token: 0x06000EDC RID: 3804 RVA: 0x00008D13 File Offset: 0x00006F13
		public unsafe UISelectable cancelButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_cancelButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_cancelButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000EDD RID: 3805 RVA: 0x000ACE44 File Offset: 0x000AB044
		// (set) Token: 0x06000EDE RID: 3806 RVA: 0x00008D32 File Offset: 0x00006F32
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeFieldInfoPtr_titleText;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeFieldInfoPtr_messageText;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeFieldInfoPtr_cancelButton;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Void_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInput_Private_IEnumerator_Action_Action_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_SelectPanel_Private_Void_UISelectable_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008BD RID: 2237
		[ObfuscatedName("ScheduleOne.UIPopupScreen_ConfirmationMenu+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D47B RID: 54395 RVA: 0x0034EAEC File Offset: 0x0034CCEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0>.NativeClassPtr);
				UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeFieldInfoPtr_onConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0>.NativeClassPtr, "onConfirm");
				UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeFieldInfoPtr_onCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0>.NativeClassPtr, "onCancel");
				UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0>.NativeClassPtr, 100665175);
				UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeMethodInfoPtr__RegisterInput_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0>.NativeClassPtr, 100665176);
				UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeMethodInfoPtr__RegisterInput_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0>.NativeClassPtr, 100665177);
			}

			// Token: 0x0600D47C RID: 54396 RVA: 0x0034EB90 File Offset: 0x0034CD90
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D47D RID: 54397 RVA: 0x0034EBCC File Offset: 0x0034CDCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81998, XrefRangeEnd = 81999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterInput_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeMethodInfoPtr__RegisterInput_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D47E RID: 54398 RVA: 0x0034EC00 File Offset: 0x0034CE00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81999, XrefRangeEnd = 82014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterInput_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeMethodInfoPtr__RegisterInput_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D47F RID: 54399 RVA: 0x000647E3 File Offset: 0x000629E3
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B0 RID: 16560
			// (get) Token: 0x0600D480 RID: 54400 RVA: 0x0034EC34 File Offset: 0x0034CE34
			// (set) Token: 0x0600D481 RID: 54401 RVA: 0x000647EC File Offset: 0x000629EC
			public unsafe Action onConfirm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeFieldInfoPtr_onConfirm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeFieldInfoPtr_onConfirm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040B1 RID: 16561
			// (get) Token: 0x0600D482 RID: 54402 RVA: 0x0034EC64 File Offset: 0x0034CE64
			// (set) Token: 0x0600D483 RID: 54403 RVA: 0x0006480B File Offset: 0x00062A0B
			public unsafe UIPopupScreen_ConfirmationMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupScreen_ConfirmationMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040B2 RID: 16562
			// (get) Token: 0x0600D484 RID: 54404 RVA: 0x0034EC94 File Offset: 0x0034CE94
			// (set) Token: 0x0600D485 RID: 54405 RVA: 0x0006482A File Offset: 0x00062A2A
			public unsafe Action onCancel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeFieldInfoPtr_onCancel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0.NativeFieldInfoPtr_onCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090B7 RID: 37047
			private static readonly IntPtr NativeFieldInfoPtr_onConfirm;

			// Token: 0x040090B8 RID: 37048
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090B9 RID: 37049
			private static readonly IntPtr NativeFieldInfoPtr_onCancel;

			// Token: 0x040090BA RID: 37050
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090BB RID: 37051
			private static readonly IntPtr NativeMethodInfoPtr__RegisterInput_b__0_Internal_Void_0;

			// Token: 0x040090BC RID: 37052
			private static readonly IntPtr NativeMethodInfoPtr__RegisterInput_b__1_Internal_Void_0;
		}

		// Token: 0x020008BE RID: 2238
		[ObfuscatedName("ScheduleOne.UIPopupScreen_ConfirmationMenu+<RegisterInput>d__8")]
		public sealed class _RegisterInput_d__8 : Il2CppSystem.Object
		{
			// Token: 0x0600D486 RID: 54406 RVA: 0x0034ECC4 File Offset: 0x0034CEC4
			// Note: this type is marked as 'beforefieldinit'.
			static _RegisterInput_d__8()
			{
				Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu>.NativeClassPtr, "<RegisterInput>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr);
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, "<>1__state");
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, "<>2__current");
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr_onConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, "onConfirm");
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, "<>4__this");
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr_onCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, "onCancel");
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, "<>8__1");
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, 100665178);
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, 100665179);
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, 100665180);
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, 100665181);
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, 100665182);
				UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr, 100665183);
			}

			// Token: 0x0600D487 RID: 54407 RVA: 0x0034EDE0 File Offset: 0x0034CFE0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RegisterInput_d__8(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupScreen_ConfirmationMenu._RegisterInput_d__8>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D488 RID: 54408 RVA: 0x0034EE28 File Offset: 0x0034D028
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D489 RID: 54409 RVA: 0x0034EE5C File Offset: 0x0034D05C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82014, XrefRangeEnd = 82044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170040B9 RID: 16569
			// (get) Token: 0x0600D48A RID: 54410 RVA: 0x0034EE98 File Offset: 0x0034D098
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D48B RID: 54411 RVA: 0x0034EED8 File Offset: 0x0034D0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82044, XrefRangeEnd = 82049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170040BA RID: 16570
			// (get) Token: 0x0600D48C RID: 54412 RVA: 0x0034EF0C File Offset: 0x0034D10C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D48D RID: 54413 RVA: 0x00064849 File Offset: 0x00062A49
			public _RegisterInput_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B3 RID: 16563
			// (get) Token: 0x0600D48E RID: 54414 RVA: 0x0034EF4C File Offset: 0x0034D14C
			// (set) Token: 0x0600D48F RID: 54415 RVA: 0x00064852 File Offset: 0x00062A52
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040B4 RID: 16564
			// (get) Token: 0x0600D490 RID: 54416 RVA: 0x0034EF74 File Offset: 0x0034D174
			// (set) Token: 0x0600D491 RID: 54417 RVA: 0x0006486D File Offset: 0x00062A6D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040B5 RID: 16565
			// (get) Token: 0x0600D492 RID: 54418 RVA: 0x0034EFA4 File Offset: 0x0034D1A4
			// (set) Token: 0x0600D493 RID: 54419 RVA: 0x0006488C File Offset: 0x00062A8C
			public unsafe Action onConfirm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr_onConfirm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr_onConfirm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040B6 RID: 16566
			// (get) Token: 0x0600D494 RID: 54420 RVA: 0x0034EFD4 File Offset: 0x0034D1D4
			// (set) Token: 0x0600D495 RID: 54421 RVA: 0x000648AB File Offset: 0x00062AAB
			public unsafe UIPopupScreen_ConfirmationMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupScreen_ConfirmationMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040B7 RID: 16567
			// (get) Token: 0x0600D496 RID: 54422 RVA: 0x0034F004 File Offset: 0x0034D204
			// (set) Token: 0x0600D497 RID: 54423 RVA: 0x000648CA File Offset: 0x00062ACA
			public unsafe Action onCancel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr_onCancel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr_onCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040B8 RID: 16568
			// (get) Token: 0x0600D498 RID: 54424 RVA: 0x0034F034 File Offset: 0x0034D234
			// (set) Token: 0x0600D499 RID: 54425 RVA: 0x000648E9 File Offset: 0x00062AE9
			public unsafe UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupScreen_ConfirmationMenu.__c__DisplayClass8_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ConfirmationMenu._RegisterInput_d__8.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090BD RID: 37053
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090BE RID: 37054
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090BF RID: 37055
			private static readonly IntPtr NativeFieldInfoPtr_onConfirm;

			// Token: 0x040090C0 RID: 37056
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090C1 RID: 37057
			private static readonly IntPtr NativeFieldInfoPtr_onCancel;

			// Token: 0x040090C2 RID: 37058
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040090C3 RID: 37059
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090C4 RID: 37060
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090C5 RID: 37061
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090C6 RID: 37062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090C7 RID: 37063
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090C8 RID: 37064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

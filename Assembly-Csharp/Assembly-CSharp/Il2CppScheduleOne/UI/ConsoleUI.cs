using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000724 RID: 1828
	public class ConsoleUI : MonoBehaviour
	{
		// Token: 0x0600B040 RID: 45120 RVA: 0x002E1544 File Offset: 0x002DF744
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleUI()
		{
			Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ConsoleUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr);
			ConsoleUI.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, "canvas");
			ConsoleUI.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, "InputField");
			ConsoleUI.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, "Container");
			ConsoleUI.NativeFieldInfoPtr_ToggleConsoleReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, "ToggleConsoleReference");
			ConsoleUI.NativeFieldInfoPtr__commandHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, "_commandHistory");
			ConsoleUI.NativeFieldInfoPtr__currentCommandIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, "_currentCommandIndex");
			ConsoleUI.NativeMethodInfoPtr_get_IsConsoleEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, 100686478);
			ConsoleUI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, 100686479);
			ConsoleUI.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, 100686480);
			ConsoleUI.NativeMethodInfoPtr_Deselected_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, 100686481);
			ConsoleUI.NativeMethodInfoPtr_UpdateCommandHistory_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, 100686482);
			ConsoleUI.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, 100686483);
			ConsoleUI.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, 100686484);
			ConsoleUI.NativeMethodInfoPtr_Submit_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, 100686485);
			ConsoleUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr, 100686486);
		}

		// Token: 0x170034F8 RID: 13560
		// (get) Token: 0x0600B041 RID: 45121 RVA: 0x002E16A0 File Offset: 0x002DF8A0
		public unsafe bool IsConsoleEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299805, XrefRangeEnd = 299811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleUI.NativeMethodInfoPtr_get_IsConsoleEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B042 RID: 45122 RVA: 0x002E16DC File Offset: 0x002DF8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299811, XrefRangeEnd = 299845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleUI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B043 RID: 45123 RVA: 0x002E1710 File Offset: 0x002DF910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299845, XrefRangeEnd = 299864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleUI.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B044 RID: 45124 RVA: 0x002E1744 File Offset: 0x002DF944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299864, XrefRangeEnd = 299865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deselected(string _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleUI.NativeMethodInfoPtr_Deselected_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B045 RID: 45125 RVA: 0x002E1788 File Offset: 0x002DF988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299886, RefRangeEnd = 299887, XrefRangeStart = 299865, XrefRangeEnd = 299886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCommandHistory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleUI.NativeMethodInfoPtr_UpdateCommandHistory_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B046 RID: 45126 RVA: 0x002E17BC File Offset: 0x002DF9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299887, XrefRangeEnd = 299894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleUI.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B047 RID: 45127 RVA: 0x002E1800 File Offset: 0x002DFA00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 299932, RefRangeEnd = 299936, XrefRangeStart = 299894, XrefRangeEnd = 299932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleUI.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B048 RID: 45128 RVA: 0x002E1840 File Offset: 0x002DFA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299936, XrefRangeEnd = 299950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Submit(string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleUI.NativeMethodInfoPtr_Submit_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B049 RID: 45129 RVA: 0x002E1884 File Offset: 0x002DFA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299950, XrefRangeEnd = 299951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B04A RID: 45130 RVA: 0x00050F01 File Offset: 0x0004F101
		public ConsoleUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034F2 RID: 13554
		// (get) Token: 0x0600B04B RID: 45131 RVA: 0x002E18C0 File Offset: 0x002DFAC0
		// (set) Token: 0x0600B04C RID: 45132 RVA: 0x00050F0A File Offset: 0x0004F10A
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleUI.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleUI.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F3 RID: 13555
		// (get) Token: 0x0600B04D RID: 45133 RVA: 0x002E18F0 File Offset: 0x002DFAF0
		// (set) Token: 0x0600B04E RID: 45134 RVA: 0x00050F29 File Offset: 0x0004F129
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleUI.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleUI.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F4 RID: 13556
		// (get) Token: 0x0600B04F RID: 45135 RVA: 0x002E1920 File Offset: 0x002DFB20
		// (set) Token: 0x0600B050 RID: 45136 RVA: 0x00050F48 File Offset: 0x0004F148
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleUI.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleUI.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F5 RID: 13557
		// (get) Token: 0x0600B051 RID: 45137 RVA: 0x002E1950 File Offset: 0x002DFB50
		// (set) Token: 0x0600B052 RID: 45138 RVA: 0x00050F67 File Offset: 0x0004F167
		public unsafe InputActionReference ToggleConsoleReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleUI.NativeFieldInfoPtr_ToggleConsoleReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleUI.NativeFieldInfoPtr_ToggleConsoleReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F6 RID: 13558
		// (get) Token: 0x0600B053 RID: 45139 RVA: 0x002E1980 File Offset: 0x002DFB80
		// (set) Token: 0x0600B054 RID: 45140 RVA: 0x00050F86 File Offset: 0x0004F186
		public unsafe static List<string> _commandHistory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConsoleUI.NativeFieldInfoPtr__commandHistory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConsoleUI.NativeFieldInfoPtr__commandHistory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034F7 RID: 13559
		// (get) Token: 0x0600B055 RID: 45141 RVA: 0x002E19A8 File Offset: 0x002DFBA8
		// (set) Token: 0x0600B056 RID: 45142 RVA: 0x00050F98 File Offset: 0x0004F198
		public unsafe int _currentCommandIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleUI.NativeFieldInfoPtr__currentCommandIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleUI.NativeFieldInfoPtr__currentCommandIndex)) = value;
			}
		}

		// Token: 0x0400797D RID: 31101
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x0400797E RID: 31102
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x0400797F RID: 31103
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04007980 RID: 31104
		private static readonly IntPtr NativeFieldInfoPtr_ToggleConsoleReference;

		// Token: 0x04007981 RID: 31105
		private static readonly IntPtr NativeFieldInfoPtr__commandHistory;

		// Token: 0x04007982 RID: 31106
		private static readonly IntPtr NativeFieldInfoPtr__currentCommandIndex;

		// Token: 0x04007983 RID: 31107
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConsoleEnabled_Public_get_Boolean_0;

		// Token: 0x04007984 RID: 31108
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007985 RID: 31109
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007986 RID: 31110
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Private_Void_String_0;

		// Token: 0x04007987 RID: 31111
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCommandHistory_Private_Void_0;

		// Token: 0x04007988 RID: 31112
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04007989 RID: 31113
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x0400798A RID: 31114
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Public_Void_String_0;

		// Token: 0x0400798B RID: 31115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

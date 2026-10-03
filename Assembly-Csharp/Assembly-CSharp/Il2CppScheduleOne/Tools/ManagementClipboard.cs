using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.State;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x020004CA RID: 1226
	public class ManagementClipboard : Singleton<ManagementClipboard>
	{
		// Token: 0x06007064 RID: 28772 RVA: 0x001FD3C0 File Offset: 0x001FB5C0
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementClipboard()
		{
			Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ManagementClipboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr);
			ManagementClipboard.NativeFieldInfoPtr_IsEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "IsEquipped");
			ManagementClipboard.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "<IsOpen>k__BackingField");
			ManagementClipboard.NativeFieldInfoPtr__StatePreserved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "<StatePreserved>k__BackingField");
			ManagementClipboard.NativeFieldInfoPtr_OpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "OpenTime");
			ManagementClipboard.NativeFieldInfoPtr_ClipboardTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "ClipboardTransform");
			ManagementClipboard.NativeFieldInfoPtr_OverlayCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "OverlayCamera");
			ManagementClipboard.NativeFieldInfoPtr_OverlayLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "OverlayLight");
			ManagementClipboard.NativeFieldInfoPtr_SelectionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "SelectionInfo");
			ManagementClipboard.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "State");
			ManagementClipboard.NativeFieldInfoPtr_ClosedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "ClosedOffset");
			ManagementClipboard.NativeFieldInfoPtr_onClipboardEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onClipboardEquipped");
			ManagementClipboard.NativeFieldInfoPtr_onClipboardUnequipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onClipboardUnequipped");
			ManagementClipboard.NativeFieldInfoPtr_onOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onOpened");
			ManagementClipboard.NativeFieldInfoPtr_onClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "onClosed");
			ManagementClipboard.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "lerpRoutine");
			ManagementClipboard.NativeFieldInfoPtr_CurrentConfigurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "CurrentConfigurables");
			ManagementClipboard.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677838);
			ManagementClipboard.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677839);
			ManagementClipboard.NativeMethodInfoPtr_get_StatePreserved_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677840);
			ManagementClipboard.NativeMethodInfoPtr_set_StatePreserved_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677841);
			ManagementClipboard.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677842);
			ManagementClipboard.NativeMethodInfoPtr_Update_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677843);
			ManagementClipboard.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677844);
			ManagementClipboard.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677845);
			ManagementClipboard.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677846);
			ManagementClipboard.NativeMethodInfoPtr_CloseAndPreserveState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677847);
			ManagementClipboard.NativeMethodInfoPtr_OnClose_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677848);
			ManagementClipboard.NativeMethodInfoPtr_LerpToVerticalPosition_Private_Void_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677849);
			ManagementClipboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677850);
			ManagementClipboard.NativeMethodInfoPtr__OnClose_b__28_0_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677851);
			ManagementClipboard.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, 100677852);
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x06007065 RID: 28773 RVA: 0x001FD65C File Offset: 0x001FB85C
		// (set) Token: 0x06007066 RID: 28774 RVA: 0x001FD698 File Offset: 0x001FB898
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x06007067 RID: 28775 RVA: 0x001FD6D8 File Offset: 0x001FB8D8
		// (set) Token: 0x06007068 RID: 28776 RVA: 0x001FD714 File Offset: 0x001FB914
		public unsafe bool StatePreserved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_get_StatePreserved_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_set_StatePreserved_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007069 RID: 28777 RVA: 0x001FD754 File Offset: 0x001FB954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224493, XrefRangeEnd = 224522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagementClipboard.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600706A RID: 28778 RVA: 0x001FD790 File Offset: 0x001FB990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224522, XrefRangeEnd = 224532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Update_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600706B RID: 28779 RVA: 0x001FD7C4 File Offset: 0x001FB9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224532, XrefRangeEnd = 224535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x001FD808 File Offset: 0x001FBA08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224570, RefRangeEnd = 224573, XrefRangeStart = 224535, XrefRangeEnd = 224570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<IConfigurable> selection, ManagementClipboard_Equippable equippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equippable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x001FD85C File Offset: 0x001FBA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224573, XrefRangeEnd = 224575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600706E RID: 28782 RVA: 0x001FD890 File Offset: 0x001FBA90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224576, RefRangeEnd = 224578, XrefRangeStart = 224575, XrefRangeEnd = 224576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAndPreserveState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_CloseAndPreserveState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600706F RID: 28783 RVA: 0x001FD8C4 File Offset: 0x001FBAC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224622, RefRangeEnd = 224623, XrefRangeStart = 224578, XrefRangeEnd = 224622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_OnClose_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007070 RID: 28784 RVA: 0x001FD8F8 File Offset: 0x001FBAF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 224642, RefRangeEnd = 224644, XrefRangeStart = 224623, XrefRangeEnd = 224642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpToVerticalPosition(bool open, Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_LerpToVerticalPosition_Private_Void_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007071 RID: 28785 RVA: 0x001FD948 File Offset: 0x001FBB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224644, XrefRangeEnd = 224654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementClipboard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x001FD984 File Offset: 0x001FBB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224654, XrefRangeEnd = 224661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnClose_b__28_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr__OnClose_b__28_0_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x001FD9B8 File Offset: 0x001FBBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007074 RID: 28788 RVA: 0x000356B8 File Offset: 0x000338B8
		public ManagementClipboard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x06007075 RID: 28789 RVA: 0x001FD9EC File Offset: 0x001FBBEC
		// (set) Token: 0x06007076 RID: 28790 RVA: 0x000356C1 File Offset: 0x000338C1
		public unsafe bool IsEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_IsEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_IsEquipped)) = value;
			}
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x06007077 RID: 28791 RVA: 0x001FDA14 File Offset: 0x001FBC14
		// (set) Token: 0x06007078 RID: 28792 RVA: 0x000356DC File Offset: 0x000338DC
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x06007079 RID: 28793 RVA: 0x001FDA3C File Offset: 0x001FBC3C
		// (set) Token: 0x0600707A RID: 28794 RVA: 0x000356F7 File Offset: 0x000338F7
		public unsafe bool _StatePreserved_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__StatePreserved_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr__StatePreserved_k__BackingField)) = value;
			}
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x0600707B RID: 28795 RVA: 0x001FDA64 File Offset: 0x001FBC64
		// (set) Token: 0x0600707C RID: 28796 RVA: 0x00035712 File Offset: 0x00033912
		public unsafe static float OpenTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementClipboard.NativeFieldInfoPtr_OpenTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementClipboard.NativeFieldInfoPtr_OpenTime, (void*)(&value));
			}
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x0600707D RID: 28797 RVA: 0x001FDA80 File Offset: 0x001FBC80
		// (set) Token: 0x0600707E RID: 28798 RVA: 0x00035720 File Offset: 0x00033920
		public unsafe Transform ClipboardTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClipboardTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClipboardTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x0600707F RID: 28799 RVA: 0x001FDAB0 File Offset: 0x001FBCB0
		// (set) Token: 0x06007080 RID: 28800 RVA: 0x0003573F File Offset: 0x0003393F
		public unsafe Camera OverlayCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x06007081 RID: 28801 RVA: 0x001FDAE0 File Offset: 0x001FBCE0
		// (set) Token: 0x06007082 RID: 28802 RVA: 0x0003575E File Offset: 0x0003395E
		public unsafe Light OverlayLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_OverlayLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x06007083 RID: 28803 RVA: 0x001FDB10 File Offset: 0x001FBD10
		// (set) Token: 0x06007084 RID: 28804 RVA: 0x0003577D File Offset: 0x0003397D
		public unsafe SelectionInfoUI SelectionInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_SelectionInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionInfoUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_SelectionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x06007085 RID: 28805 RVA: 0x001FDB40 File Offset: 0x001FBD40
		// (set) Token: 0x06007086 RID: 28806 RVA: 0x0003579C File Offset: 0x0003399C
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x06007087 RID: 28807 RVA: 0x001FDB70 File Offset: 0x001FBD70
		// (set) Token: 0x06007088 RID: 28808 RVA: 0x000357BB File Offset: 0x000339BB
		public unsafe float ClosedOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClosedOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_ClosedOffset)) = value;
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x06007089 RID: 28809 RVA: 0x001FDB98 File Offset: 0x001FBD98
		// (set) Token: 0x0600708A RID: 28810 RVA: 0x000357D6 File Offset: 0x000339D6
		public unsafe UnityEvent onClipboardEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardEquipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardEquipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x0600708B RID: 28811 RVA: 0x001FDBC8 File Offset: 0x001FBDC8
		// (set) Token: 0x0600708C RID: 28812 RVA: 0x000357F5 File Offset: 0x000339F5
		public unsafe UnityEvent onClipboardUnequipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardUnequipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClipboardUnequipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x0600708D RID: 28813 RVA: 0x001FDBF8 File Offset: 0x001FBDF8
		// (set) Token: 0x0600708E RID: 28814 RVA: 0x00035814 File Offset: 0x00033A14
		public unsafe UnityEvent onOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x0600708F RID: 28815 RVA: 0x001FDC28 File Offset: 0x001FBE28
		// (set) Token: 0x06007090 RID: 28816 RVA: 0x00035833 File Offset: 0x00033A33
		public unsafe UnityEvent onClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_onClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x06007091 RID: 28817 RVA: 0x001FDC58 File Offset: 0x001FBE58
		// (set) Token: 0x06007092 RID: 28818 RVA: 0x00035852 File Offset: 0x00033A52
		public unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x06007093 RID: 28819 RVA: 0x001FDC88 File Offset: 0x001FBE88
		// (set) Token: 0x06007094 RID: 28820 RVA: 0x00035871 File Offset: 0x00033A71
		public unsafe List<IConfigurable> CurrentConfigurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_CurrentConfigurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.NativeFieldInfoPtr_CurrentConfigurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CE4 RID: 19684
		private static readonly IntPtr NativeFieldInfoPtr_IsEquipped;

		// Token: 0x04004CE5 RID: 19685
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04004CE6 RID: 19686
		private static readonly IntPtr NativeFieldInfoPtr__StatePreserved_k__BackingField;

		// Token: 0x04004CE7 RID: 19687
		private static readonly IntPtr NativeFieldInfoPtr_OpenTime;

		// Token: 0x04004CE8 RID: 19688
		private static readonly IntPtr NativeFieldInfoPtr_ClipboardTransform;

		// Token: 0x04004CE9 RID: 19689
		private static readonly IntPtr NativeFieldInfoPtr_OverlayCamera;

		// Token: 0x04004CEA RID: 19690
		private static readonly IntPtr NativeFieldInfoPtr_OverlayLight;

		// Token: 0x04004CEB RID: 19691
		private static readonly IntPtr NativeFieldInfoPtr_SelectionInfo;

		// Token: 0x04004CEC RID: 19692
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04004CED RID: 19693
		private static readonly IntPtr NativeFieldInfoPtr_ClosedOffset;

		// Token: 0x04004CEE RID: 19694
		private static readonly IntPtr NativeFieldInfoPtr_onClipboardEquipped;

		// Token: 0x04004CEF RID: 19695
		private static readonly IntPtr NativeFieldInfoPtr_onClipboardUnequipped;

		// Token: 0x04004CF0 RID: 19696
		private static readonly IntPtr NativeFieldInfoPtr_onOpened;

		// Token: 0x04004CF1 RID: 19697
		private static readonly IntPtr NativeFieldInfoPtr_onClosed;

		// Token: 0x04004CF2 RID: 19698
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x04004CF3 RID: 19699
		private static readonly IntPtr NativeFieldInfoPtr_CurrentConfigurables;

		// Token: 0x04004CF4 RID: 19700
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04004CF5 RID: 19701
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04004CF6 RID: 19702
		private static readonly IntPtr NativeMethodInfoPtr_get_StatePreserved_Public_get_Boolean_0;

		// Token: 0x04004CF7 RID: 19703
		private static readonly IntPtr NativeMethodInfoPtr_set_StatePreserved_Protected_set_Void_Boolean_0;

		// Token: 0x04004CF8 RID: 19704
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004CF9 RID: 19705
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_1;

		// Token: 0x04004CFA RID: 19706
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04004CFB RID: 19707
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_IConfigurable_ManagementClipboard_Equippable_0;

		// Token: 0x04004CFC RID: 19708
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004CFD RID: 19709
		private static readonly IntPtr NativeMethodInfoPtr_CloseAndPreserveState_Public_Void_0;

		// Token: 0x04004CFE RID: 19710
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_1;

		// Token: 0x04004CFF RID: 19711
		private static readonly IntPtr NativeMethodInfoPtr_LerpToVerticalPosition_Private_Void_Boolean_Action_0;

		// Token: 0x04004D00 RID: 19712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D01 RID: 19713
		private static readonly IntPtr NativeMethodInfoPtr__OnClose_b__28_0_Private_Void_1;

		// Token: 0x04004D02 RID: 19714
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000B86 RID: 2950
		[ObfuscatedName("ScheduleOne.Tools.ManagementClipboard+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E954 RID: 59732 RVA: 0x0038C0C8 File Offset: 0x0038A2C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementClipboard>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0>.NativeClassPtr);
				ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0>.NativeClassPtr, "startPos");
				ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0>.NativeClassPtr, "endPos");
				ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0>.NativeClassPtr, "callback");
				ManagementClipboard.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0>.NativeClassPtr, 100677853);
				ManagementClipboard.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0>.NativeClassPtr, 100677854);
			}

			// Token: 0x0600E955 RID: 59733 RVA: 0x0038C16C File Offset: 0x0038A36C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E956 RID: 59734 RVA: 0x0038C1A8 File Offset: 0x0038A3A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224488, XrefRangeEnd = 224493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass29_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E957 RID: 59735 RVA: 0x0006E160 File Offset: 0x0006C360
			public __c__DisplayClass29_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046C9 RID: 18121
			// (get) Token: 0x0600E958 RID: 59736 RVA: 0x0038C1E8 File Offset: 0x0038A3E8
			// (set) Token: 0x0600E959 RID: 59737 RVA: 0x0006E169 File Offset: 0x0006C369
			public unsafe ManagementClipboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046CA RID: 18122
			// (get) Token: 0x0600E95A RID: 59738 RVA: 0x0038C218 File Offset: 0x0038A418
			// (set) Token: 0x0600E95B RID: 59739 RVA: 0x0006E188 File Offset: 0x0006C388
			public unsafe Vector3 startPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr_startPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr_startPos)) = value;
				}
			}

			// Token: 0x170046CB RID: 18123
			// (get) Token: 0x0600E95C RID: 59740 RVA: 0x0038C240 File Offset: 0x0038A440
			// (set) Token: 0x0600E95D RID: 59741 RVA: 0x0006E1A3 File Offset: 0x0006C3A3
			public unsafe Vector3 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x170046CC RID: 18124
			// (get) Token: 0x0600E95E RID: 59742 RVA: 0x0038C268 File Offset: 0x0038A468
			// (set) Token: 0x0600E95F RID: 59743 RVA: 0x0006E1BE File Offset: 0x0006C3BE
			public unsafe Action callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009E3F RID: 40511
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009E40 RID: 40512
			private static readonly IntPtr NativeFieldInfoPtr_startPos;

			// Token: 0x04009E41 RID: 40513
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x04009E42 RID: 40514
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04009E43 RID: 40515
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009E44 RID: 40516
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DE7 RID: 3559
			[ObfuscatedName("ScheduleOne.Tools.ManagementClipboard+<>c__DisplayClass29_0+<<LerpToVerticalPosition>g__Lerp|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060100C0 RID: 65728 RVA: 0x003CFC78 File Offset: 0x003CDE78
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0>.NativeClassPtr, "<<LerpToVerticalPosition>g__Lerp|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677855);
					ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677856);
					ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677857);
					ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677858);
					ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677859);
					ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100677860);
				}

				// Token: 0x060100C1 RID: 65729 RVA: 0x003CFD6C File Offset: 0x003CDF6C
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100C2 RID: 65730 RVA: 0x003CFDB4 File Offset: 0x003CDFB4
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060100C3 RID: 65731 RVA: 0x003CFDE8 File Offset: 0x003CDFE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224473, XrefRangeEnd = 224483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E45 RID: 20037
				// (get) Token: 0x060100C4 RID: 65732 RVA: 0x003CFE24 File Offset: 0x003CE024
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100C5 RID: 65733 RVA: 0x003CFE64 File Offset: 0x003CE064
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224483, XrefRangeEnd = 224488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E46 RID: 20038
				// (get) Token: 0x060100C6 RID: 65734 RVA: 0x003CFE98 File Offset: 0x003CE098
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060100C7 RID: 65735 RVA: 0x00079B2C File Offset: 0x00077D2C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E41 RID: 20033
				// (get) Token: 0x060100C8 RID: 65736 RVA: 0x003CFED8 File Offset: 0x003CE0D8
				// (set) Token: 0x060100C9 RID: 65737 RVA: 0x00079B35 File Offset: 0x00077D35
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E42 RID: 20034
				// (get) Token: 0x060100CA RID: 65738 RVA: 0x003CFF00 File Offset: 0x003CE100
				// (set) Token: 0x060100CB RID: 65739 RVA: 0x00079B50 File Offset: 0x00077D50
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E43 RID: 20035
				// (get) Token: 0x060100CC RID: 65740 RVA: 0x003CFF30 File Offset: 0x003CE130
				// (set) Token: 0x060100CD RID: 65741 RVA: 0x00079B6F File Offset: 0x00077D6F
				public unsafe ManagementClipboard.__c__DisplayClass29_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementClipboard.__c__DisplayClass29_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E44 RID: 20036
				// (get) Token: 0x060100CE RID: 65742 RVA: 0x003CFF60 File Offset: 0x003CE160
				// (set) Token: 0x060100CF RID: 65743 RVA: 0x00079B8E File Offset: 0x00077D8E
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementClipboard.__c__DisplayClass29_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400ACEB RID: 44267
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ACEC RID: 44268
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ACED RID: 44269
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ACEE RID: 44270
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400ACEF RID: 44271
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ACF0 RID: 44272
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACF1 RID: 44273
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ACF2 RID: 44274
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ACF3 RID: 44275
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ACF4 RID: 44276
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}

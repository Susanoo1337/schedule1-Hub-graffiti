using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007E1 RID: 2017
	public class TransitEntitySelector : MonoBehaviour
	{
		// Token: 0x0600C53E RID: 50494 RVA: 0x00320874 File Offset: 0x0031EA74
		// Note: this type is marked as 'beforefieldinit'.
		static TransitEntitySelector()
		{
			Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "TransitEntitySelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr);
			TransitEntitySelector.NativeFieldInfoPtr_SELECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "SELECTION_RANGE");
			TransitEntitySelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			TransitEntitySelector.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "State");
			TransitEntitySelector.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "DetectionMask");
			TransitEntitySelector.NativeFieldInfoPtr_HoverOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "HoverOutlineColor");
			TransitEntitySelector.NativeFieldInfoPtr_SelectOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "SelectOutlineColor");
			TransitEntitySelector.NativeFieldInfoPtr_maxSelectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "maxSelectedObjects");
			TransitEntitySelector.NativeFieldInfoPtr_selectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "selectedObjects");
			TransitEntitySelector.NativeFieldInfoPtr_typeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "typeRequirements");
			TransitEntitySelector.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "objectFilter");
			TransitEntitySelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "callback");
			TransitEntitySelector.NativeFieldInfoPtr_hoveredObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "hoveredObj");
			TransitEntitySelector.NativeFieldInfoPtr_highlightedObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "highlightedObj");
			TransitEntitySelector.NativeFieldInfoPtr_selectionTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "selectionTitle");
			TransitEntitySelector.NativeFieldInfoPtr_transitSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "transitSources");
			TransitEntitySelector.NativeFieldInfoPtr_transitLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "transitLines");
			TransitEntitySelector.NativeFieldInfoPtr_selectDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "selectDestination");
			TransitEntitySelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688864);
			TransitEntitySelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688865);
			TransitEntitySelector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688866);
			TransitEntitySelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688867);
			TransitEntitySelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_ITransitEntity_List_1_Type_ObjectFilter_Action_1_List_1_ITransitEntity_List_1_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688868);
			TransitEntitySelector.NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688869);
			TransitEntitySelector.NativeMethodInfoPtr_CloseAndSubmit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688870);
			TransitEntitySelector.NativeMethodInfoPtr_CloseAndCancel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688871);
			TransitEntitySelector.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688872);
			TransitEntitySelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688873);
			TransitEntitySelector.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688874);
			TransitEntitySelector.NativeMethodInfoPtr_UpdateInstructions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688875);
			TransitEntitySelector.NativeMethodInfoPtr_GetHoveredObject_Private_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688876);
			TransitEntitySelector.NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_ITransitEntity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688877);
			TransitEntitySelector.NativeMethodInfoPtr_ClearSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688878);
			TransitEntitySelector.NativeMethodInfoPtr_ObjectClicked_Public_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688879);
			TransitEntitySelector.NativeMethodInfoPtr_SetSelectionOutline_Private_Void_ITransitEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688880);
			TransitEntitySelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688881);
			TransitEntitySelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688882);
			TransitEntitySelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, 100688883);
		}

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x0600C53F RID: 50495 RVA: 0x00320B88 File Offset: 0x0031ED88
		// (set) Token: 0x0600C540 RID: 50496 RVA: 0x00320BC4 File Offset: 0x0031EDC4
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C541 RID: 50497 RVA: 0x00320C04 File Offset: 0x0031EE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326678, XrefRangeEnd = 326689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C542 RID: 50498 RVA: 0x00320C38 File Offset: 0x0031EE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326689, XrefRangeEnd = 326711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C543 RID: 50499 RVA: 0x00320C6C File Offset: 0x0031EE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326711, XrefRangeEnd = 326781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<ITransitEntity> _selectedObjects, List<Type> _typeRequirements, TransitEntitySelector.ObjectFilter _objectFilter, Action<List<ITransitEntity>> _callback, List<Transform> transitLineSources = null, bool selectingDestination = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(instruction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxSelectedObjects;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedObjects);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_typeRequirements);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_objectFilter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transitLineSources);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectingDestination;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitEntitySelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_ITransitEntity_List_1_Type_ObjectFilter_Action_1_List_1_ITransitEntity_List_1_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C544 RID: 50500 RVA: 0x00320D48 File Offset: 0x0031EF48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326818, RefRangeEnd = 326820, XrefRangeStart = 326781, XrefRangeEnd = 326818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransitLines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C545 RID: 50501 RVA: 0x00320D7C File Offset: 0x0031EF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326820, XrefRangeEnd = 326822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAndSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_CloseAndSubmit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C546 RID: 50502 RVA: 0x00320DB0 File Offset: 0x0031EFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326822, XrefRangeEnd = 326823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAndCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_CloseAndCancel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C547 RID: 50503 RVA: 0x00320DE4 File Offset: 0x0031EFE4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 326868, RefRangeEnd = 326875, XrefRangeStart = 326823, XrefRangeEnd = 326868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C548 RID: 50504 RVA: 0x00320E18 File Offset: 0x0031F018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326875, XrefRangeEnd = 326951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C549 RID: 50505 RVA: 0x00320E4C File Offset: 0x0031F04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326951, XrefRangeEnd = 326952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C54A RID: 50506 RVA: 0x00320E80 File Offset: 0x0031F080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326976, RefRangeEnd = 326978, XrefRangeStart = 326952, XrefRangeEnd = 326976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstructions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_UpdateInstructions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C54B RID: 50507 RVA: 0x00320EB4 File Offset: 0x0031F0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326978, XrefRangeEnd = 326984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ITransitEntity GetHoveredObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_GetHoveredObject_Private_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr3) : null;
		}

		// Token: 0x0600C54C RID: 50508 RVA: 0x00320EF4 File Offset: 0x0031F0F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 327001, RefRangeEnd = 327004, XrefRangeStart = 326984, XrefRangeEnd = 327001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectTypeValid(ITransitEntity obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_ITransitEntity_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600C54D RID: 50509 RVA: 0x00320F5C File Offset: 0x0031F15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327004, XrefRangeEnd = 327014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_ClearSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C54E RID: 50510 RVA: 0x00320F90 File Offset: 0x0031F190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327041, RefRangeEnd = 327042, XrefRangeStart = 327014, XrefRangeEnd = 327041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectClicked(ITransitEntity obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_ObjectClicked_Public_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C54F RID: 50511 RVA: 0x00320FD4 File Offset: 0x0031F1D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327047, RefRangeEnd = 327048, XrefRangeStart = 327042, XrefRangeEnd = 327047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectionOutline(ITransitEntity obj, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_SetSelectionOutline_Private_Void_ITransitEntity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C550 RID: 50512 RVA: 0x00321024 File Offset: 0x0031F224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClipboardClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C551 RID: 50513 RVA: 0x00321058 File Offset: 0x0031F258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327048, XrefRangeEnd = 327050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C552 RID: 50514 RVA: 0x0032109C File Offset: 0x0031F29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327050, XrefRangeEnd = 327083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitEntitySelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C553 RID: 50515 RVA: 0x0005D1C3 File Offset: 0x0005B3C3
		public TransitEntitySelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x0600C554 RID: 50516 RVA: 0x003210D8 File Offset: 0x0031F2D8
		// (set) Token: 0x0600C555 RID: 50517 RVA: 0x0005D1CC File Offset: 0x0005B3CC
		public unsafe static float SELECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TransitEntitySelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TransitEntitySelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x0600C556 RID: 50518 RVA: 0x003210F4 File Offset: 0x0031F2F4
		// (set) Token: 0x0600C557 RID: 50519 RVA: 0x0005D1DA File Offset: 0x0005B3DA
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003BE2 RID: 15330
		// (get) Token: 0x0600C558 RID: 50520 RVA: 0x0032111C File Offset: 0x0031F31C
		// (set) Token: 0x0600C559 RID: 50521 RVA: 0x0005D1F5 File Offset: 0x0005B3F5
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BE3 RID: 15331
		// (get) Token: 0x0600C55A RID: 50522 RVA: 0x0032114C File Offset: 0x0031F34C
		// (set) Token: 0x0600C55B RID: 50523 RVA: 0x0005D214 File Offset: 0x0005B414
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17003BE4 RID: 15332
		// (get) Token: 0x0600C55C RID: 50524 RVA: 0x00321174 File Offset: 0x0031F374
		// (set) Token: 0x0600C55D RID: 50525 RVA: 0x0005D22F File Offset: 0x0005B42F
		public unsafe Color HoverOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_HoverOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_HoverOutlineColor)) = value;
			}
		}

		// Token: 0x17003BE5 RID: 15333
		// (get) Token: 0x0600C55E RID: 50526 RVA: 0x0032119C File Offset: 0x0031F39C
		// (set) Token: 0x0600C55F RID: 50527 RVA: 0x0005D24A File Offset: 0x0005B44A
		public unsafe Color SelectOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_SelectOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_SelectOutlineColor)) = value;
			}
		}

		// Token: 0x17003BE6 RID: 15334
		// (get) Token: 0x0600C560 RID: 50528 RVA: 0x003211C4 File Offset: 0x0031F3C4
		// (set) Token: 0x0600C561 RID: 50529 RVA: 0x0005D265 File Offset: 0x0005B465
		public unsafe int maxSelectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_maxSelectedObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_maxSelectedObjects)) = value;
			}
		}

		// Token: 0x17003BE7 RID: 15335
		// (get) Token: 0x0600C562 RID: 50530 RVA: 0x003211EC File Offset: 0x0031F3EC
		// (set) Token: 0x0600C563 RID: 50531 RVA: 0x0005D280 File Offset: 0x0005B480
		public unsafe List<ITransitEntity> selectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ITransitEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x0600C564 RID: 50532 RVA: 0x0032121C File Offset: 0x0031F41C
		// (set) Token: 0x0600C565 RID: 50533 RVA: 0x0005D29F File Offset: 0x0005B49F
		public unsafe List<Type> typeRequirements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_typeRequirements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_typeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x0600C566 RID: 50534 RVA: 0x0032124C File Offset: 0x0031F44C
		// (set) Token: 0x0600C567 RID: 50535 RVA: 0x0005D2BE File Offset: 0x0005B4BE
		public unsafe TransitEntitySelector.ObjectFilter objectFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_objectFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitEntitySelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x0600C568 RID: 50536 RVA: 0x0032127C File Offset: 0x0031F47C
		// (set) Token: 0x0600C569 RID: 50537 RVA: 0x0005D2DD File Offset: 0x0005B4DD
		public unsafe Action<List<ITransitEntity>> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<ITransitEntity>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x0600C56A RID: 50538 RVA: 0x003212AC File Offset: 0x0031F4AC
		// (set) Token: 0x0600C56B RID: 50539 RVA: 0x0005D2FC File Offset: 0x0005B4FC
		public unsafe ITransitEntity hoveredObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_hoveredObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_hoveredObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x0600C56C RID: 50540 RVA: 0x003212DC File Offset: 0x0031F4DC
		// (set) Token: 0x0600C56D RID: 50541 RVA: 0x0005D31B File Offset: 0x0005B51B
		public unsafe ITransitEntity highlightedObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_highlightedObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_highlightedObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x0600C56E RID: 50542 RVA: 0x0032130C File Offset: 0x0031F50C
		// (set) Token: 0x0600C56F RID: 50543 RVA: 0x0005D33A File Offset: 0x0005B53A
		public unsafe string selectionTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectionTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectionTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x0600C570 RID: 50544 RVA: 0x00321334 File Offset: 0x0031F534
		// (set) Token: 0x0600C571 RID: 50545 RVA: 0x0005D359 File Offset: 0x0005B559
		public unsafe List<Transform> transitSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x0600C572 RID: 50546 RVA: 0x00321364 File Offset: 0x0031F564
		// (set) Token: 0x0600C573 RID: 50547 RVA: 0x0005D378 File Offset: 0x0005B578
		public unsafe List<TransitLineVisuals> transitLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TransitLineVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_transitLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x0600C574 RID: 50548 RVA: 0x00321394 File Offset: 0x0031F594
		// (set) Token: 0x0600C575 RID: 50549 RVA: 0x0005D397 File Offset: 0x0005B597
		public unsafe bool selectDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitEntitySelector.NativeFieldInfoPtr_selectDestination)) = value;
			}
		}

		// Token: 0x0400869B RID: 34459
		private static readonly IntPtr NativeFieldInfoPtr_SELECTION_RANGE;

		// Token: 0x0400869C RID: 34460
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400869D RID: 34461
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x0400869E RID: 34462
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x0400869F RID: 34463
		private static readonly IntPtr NativeFieldInfoPtr_HoverOutlineColor;

		// Token: 0x040086A0 RID: 34464
		private static readonly IntPtr NativeFieldInfoPtr_SelectOutlineColor;

		// Token: 0x040086A1 RID: 34465
		private static readonly IntPtr NativeFieldInfoPtr_maxSelectedObjects;

		// Token: 0x040086A2 RID: 34466
		private static readonly IntPtr NativeFieldInfoPtr_selectedObjects;

		// Token: 0x040086A3 RID: 34467
		private static readonly IntPtr NativeFieldInfoPtr_typeRequirements;

		// Token: 0x040086A4 RID: 34468
		private static readonly IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x040086A5 RID: 34469
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040086A6 RID: 34470
		private static readonly IntPtr NativeFieldInfoPtr_hoveredObj;

		// Token: 0x040086A7 RID: 34471
		private static readonly IntPtr NativeFieldInfoPtr_highlightedObj;

		// Token: 0x040086A8 RID: 34472
		private static readonly IntPtr NativeFieldInfoPtr_selectionTitle;

		// Token: 0x040086A9 RID: 34473
		private static readonly IntPtr NativeFieldInfoPtr_transitSources;

		// Token: 0x040086AA RID: 34474
		private static readonly IntPtr NativeFieldInfoPtr_transitLines;

		// Token: 0x040086AB RID: 34475
		private static readonly IntPtr NativeFieldInfoPtr_selectDestination;

		// Token: 0x040086AC RID: 34476
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040086AD RID: 34477
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040086AE RID: 34478
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040086AF RID: 34479
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040086B0 RID: 34480
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_ITransitEntity_List_1_Type_ObjectFilter_Action_1_List_1_ITransitEntity_List_1_Transform_Boolean_0;

		// Token: 0x040086B1 RID: 34481
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0;

		// Token: 0x040086B2 RID: 34482
		private static readonly IntPtr NativeMethodInfoPtr_CloseAndSubmit_Private_Void_0;

		// Token: 0x040086B3 RID: 34483
		private static readonly IntPtr NativeMethodInfoPtr_CloseAndCancel_Private_Void_0;

		// Token: 0x040086B4 RID: 34484
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x040086B5 RID: 34485
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040086B6 RID: 34486
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040086B7 RID: 34487
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructions_Private_Void_0;

		// Token: 0x040086B8 RID: 34488
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredObject_Private_ITransitEntity_0;

		// Token: 0x040086B9 RID: 34489
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_ITransitEntity_byref_String_0;

		// Token: 0x040086BA RID: 34490
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Private_Void_0;

		// Token: 0x040086BB RID: 34491
		private static readonly IntPtr NativeMethodInfoPtr_ObjectClicked_Public_Void_ITransitEntity_0;

		// Token: 0x040086BC RID: 34492
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectionOutline_Private_Void_ITransitEntity_Boolean_0;

		// Token: 0x040086BD RID: 34493
		private static readonly IntPtr NativeMethodInfoPtr_ClipboardClosed_Private_Void_0;

		// Token: 0x040086BE RID: 34494
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040086BF RID: 34495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D64 RID: 3428
		public sealed class ObjectFilter : MulticastDelegate
		{
			// Token: 0x0600FAEA RID: 64234 RVA: 0x003BEF08 File Offset: 0x003BD108
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectFilter()
			{
				Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransitEntitySelector>.NativeClassPtr, "ObjectFilter");
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100688884);
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ITransitEntity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100688885);
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ITransitEntity_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100688886);
				TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr, 100688887);
			}

			// Token: 0x0600FAEB RID: 64235 RVA: 0x003BEF7C File Offset: 0x003BD17C
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 59159, RefRangeEnd = 59191, XrefRangeStart = 59159, XrefRangeEnd = 59191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectFilter(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitEntitySelector.ObjectFilter>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FAEC RID: 64236 RVA: 0x003BEFD8 File Offset: 0x003BD1D8
			[CallerCount(0)]
			public unsafe bool Invoke(ITransitEntity obj, out string reason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ITransitEntity_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600FAED RID: 64237 RVA: 0x003BF040 File Offset: 0x003BD240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ITransitEntity obj, out string reason, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ITransitEntity_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x0600FAEE RID: 64238 RVA: 0x003BF0D0 File Offset: 0x003BD2D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out string reason, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TransitEntitySelector.ObjectFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600FAEF RID: 64239 RVA: 0x00076B32 File Offset: 0x00074D32
			public ObjectFilter(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400A950 RID: 43344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400A951 RID: 43345
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_ITransitEntity_byref_String_0;

			// Token: 0x0400A952 RID: 43346
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ITransitEntity_byref_String_AsyncCallback_Object_0;

			// Token: 0x0400A953 RID: 43347
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
		}
	}
}

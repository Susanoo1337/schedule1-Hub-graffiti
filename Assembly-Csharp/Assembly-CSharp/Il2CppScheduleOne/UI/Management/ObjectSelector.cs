using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007DD RID: 2013
	public class ObjectSelector : MonoBehaviour
	{
		// Token: 0x0600C4C1 RID: 50369 RVA: 0x0031F0BC File Offset: 0x0031D2BC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSelector()
		{
			Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ObjectSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr);
			ObjectSelector.NativeFieldInfoPtr_SELECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "SELECTION_RANGE");
			ObjectSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			ObjectSelector.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "State");
			ObjectSelector.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "DetectionMask");
			ObjectSelector.NativeFieldInfoPtr_HoverOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "HoverOutlineColor");
			ObjectSelector.NativeFieldInfoPtr_SelectOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "SelectOutlineColor");
			ObjectSelector.NativeFieldInfoPtr_maxSelectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "maxSelectedObjects");
			ObjectSelector.NativeFieldInfoPtr_selectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectedObjects");
			ObjectSelector.NativeFieldInfoPtr_typeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "typeRequirements");
			ObjectSelector.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "objectFilter");
			ObjectSelector.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "callback");
			ObjectSelector.NativeFieldInfoPtr_hoveredObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "hoveredObj");
			ObjectSelector.NativeFieldInfoPtr_highlightedObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "highlightedObj");
			ObjectSelector.NativeFieldInfoPtr_selectionTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "selectionTitle");
			ObjectSelector.NativeFieldInfoPtr_changesMade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "changesMade");
			ObjectSelector.NativeFieldInfoPtr_transitSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "transitSources");
			ObjectSelector.NativeFieldInfoPtr_transitLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "transitLines");
			ObjectSelector.NativeFieldInfoPtr_targetProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "targetProperty");
			ObjectSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688817);
			ObjectSelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688818);
			ObjectSelector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688819);
			ObjectSelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688820);
			ObjectSelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_BuildableItem_List_1_Type_Property_ObjectFilter_Action_1_List_1_BuildableItem_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688821);
			ObjectSelector.NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688822);
			ObjectSelector.NativeMethodInfoPtr_CloseAndSubmit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688823);
			ObjectSelector.NativeMethodInfoPtr_CloseAndCancel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688824);
			ObjectSelector.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688825);
			ObjectSelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688826);
			ObjectSelector.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688827);
			ObjectSelector.NativeMethodInfoPtr_UpdateInstructions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688828);
			ObjectSelector.NativeMethodInfoPtr_GetHoveredObject_Private_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688829);
			ObjectSelector.NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688830);
			ObjectSelector.NativeMethodInfoPtr_ClearSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688831);
			ObjectSelector.NativeMethodInfoPtr_ObjectClicked_Public_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688832);
			ObjectSelector.NativeMethodInfoPtr_SetSelectionOutline_Private_Void_BuildableItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688833);
			ObjectSelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688834);
			ObjectSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688835);
			ObjectSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, 100688836);
		}

		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x0600C4C2 RID: 50370 RVA: 0x0031F3E4 File Offset: 0x0031D5E4
		// (set) Token: 0x0600C4C3 RID: 50371 RVA: 0x0031F420 File Offset: 0x0031D620
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C4C4 RID: 50372 RVA: 0x0031F460 File Offset: 0x0031D660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325936, XrefRangeEnd = 325947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x0031F494 File Offset: 0x0031D694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325947, XrefRangeEnd = 325969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4C6 RID: 50374 RVA: 0x0031F4C8 File Offset: 0x0031D6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325969, XrefRangeEnd = 326036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<BuildableItem> _selectedObjects, List<Type> _typeRequirements, Property property, ObjectSelector.ObjectFilter _objectFilter, Action<List<BuildableItem>> _callback, List<Transform> transitLineSources = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(instruction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxSelectedObjects;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedObjects);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_typeRequirements);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_objectFilter);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transitLineSources);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectSelector.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_BuildableItem_List_1_Type_Property_ObjectFilter_Action_1_List_1_BuildableItem_List_1_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4C7 RID: 50375 RVA: 0x0031F5A8 File Offset: 0x0031D7A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326065, RefRangeEnd = 326067, XrefRangeStart = 326036, XrefRangeEnd = 326065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransitLines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4C8 RID: 50376 RVA: 0x0031F5DC File Offset: 0x0031D7DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 326075, RefRangeEnd = 326079, XrefRangeStart = 326067, XrefRangeEnd = 326075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAndSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_CloseAndSubmit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4C9 RID: 50377 RVA: 0x0031F610 File Offset: 0x0031D810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326079, XrefRangeEnd = 326080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAndCancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_CloseAndCancel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4CA RID: 50378 RVA: 0x0031F644 File Offset: 0x0031D844
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326125, RefRangeEnd = 326128, XrefRangeStart = 326080, XrefRangeEnd = 326125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4CB RID: 50379 RVA: 0x0031F678 File Offset: 0x0031D878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326128, XrefRangeEnd = 326207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4CC RID: 50380 RVA: 0x0031F6AC File Offset: 0x0031D8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326207, XrefRangeEnd = 326208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4CD RID: 50381 RVA: 0x0031F6E0 File Offset: 0x0031D8E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 326232, RefRangeEnd = 326234, XrefRangeStart = 326208, XrefRangeEnd = 326232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstructions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_UpdateInstructions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4CE RID: 50382 RVA: 0x0031F714 File Offset: 0x0031D914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326234, XrefRangeEnd = 326240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItem GetHoveredObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_GetHoveredObject_Private_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr3) : null;
		}

		// Token: 0x0600C4CF RID: 50383 RVA: 0x0031F754 File Offset: 0x0031D954
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326259, RefRangeEnd = 326262, XrefRangeStart = 326240, XrefRangeEnd = 326259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectTypeValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600C4D0 RID: 50384 RVA: 0x0031F7BC File Offset: 0x0031D9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326262, XrefRangeEnd = 326269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_ClearSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4D1 RID: 50385 RVA: 0x0031F7F0 File Offset: 0x0031D9F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 326294, RefRangeEnd = 326295, XrefRangeStart = 326269, XrefRangeEnd = 326294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectClicked(BuildableItem obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_ObjectClicked_Public_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4D2 RID: 50386 RVA: 0x0031F834 File Offset: 0x0031DA34
		[CallerCount(0)]
		public unsafe void SetSelectionOutline(BuildableItem obj, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_SetSelectionOutline_Private_Void_BuildableItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4D3 RID: 50387 RVA: 0x0031F884 File Offset: 0x0031DA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClipboardClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_ClipboardClosed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4D4 RID: 50388 RVA: 0x0031F8B8 File Offset: 0x0031DAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326295, XrefRangeEnd = 326297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exitAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4D5 RID: 50389 RVA: 0x0031F8FC File Offset: 0x0031DAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 326297, XrefRangeEnd = 326330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C4D6 RID: 50390 RVA: 0x0005CCF8 File Offset: 0x0005AEF8
		public ObjectSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0600C4D7 RID: 50391 RVA: 0x0031F938 File Offset: 0x0031DB38
		// (set) Token: 0x0600C4D8 RID: 50392 RVA: 0x0005CD01 File Offset: 0x0005AF01
		public unsafe static float SELECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ObjectSelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectSelector.NativeFieldInfoPtr_SELECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0600C4D9 RID: 50393 RVA: 0x0031F954 File Offset: 0x0031DB54
		// (set) Token: 0x0600C4DA RID: 50394 RVA: 0x0005CD0F File Offset: 0x0005AF0F
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0600C4DB RID: 50395 RVA: 0x0031F97C File Offset: 0x0031DB7C
		// (set) Token: 0x0600C4DC RID: 50396 RVA: 0x0005CD2A File Offset: 0x0005AF2A
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x0600C4DD RID: 50397 RVA: 0x0031F9AC File Offset: 0x0031DBAC
		// (set) Token: 0x0600C4DE RID: 50398 RVA: 0x0005CD49 File Offset: 0x0005AF49
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x0600C4DF RID: 50399 RVA: 0x0031F9D4 File Offset: 0x0031DBD4
		// (set) Token: 0x0600C4E0 RID: 50400 RVA: 0x0005CD64 File Offset: 0x0005AF64
		public unsafe Color HoverOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_HoverOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_HoverOutlineColor)) = value;
			}
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x0600C4E1 RID: 50401 RVA: 0x0031F9FC File Offset: 0x0031DBFC
		// (set) Token: 0x0600C4E2 RID: 50402 RVA: 0x0005CD7F File Offset: 0x0005AF7F
		public unsafe Color SelectOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_SelectOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_SelectOutlineColor)) = value;
			}
		}

		// Token: 0x17003BBD RID: 15293
		// (get) Token: 0x0600C4E3 RID: 50403 RVA: 0x0031FA24 File Offset: 0x0031DC24
		// (set) Token: 0x0600C4E4 RID: 50404 RVA: 0x0005CD9A File Offset: 0x0005AF9A
		public unsafe int maxSelectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_maxSelectedObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_maxSelectedObjects)) = value;
			}
		}

		// Token: 0x17003BBE RID: 15294
		// (get) Token: 0x0600C4E5 RID: 50405 RVA: 0x0031FA4C File Offset: 0x0031DC4C
		// (set) Token: 0x0600C4E6 RID: 50406 RVA: 0x0005CDB5 File Offset: 0x0005AFB5
		public unsafe List<BuildableItem> selectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BBF RID: 15295
		// (get) Token: 0x0600C4E7 RID: 50407 RVA: 0x0031FA7C File Offset: 0x0031DC7C
		// (set) Token: 0x0600C4E8 RID: 50408 RVA: 0x0005CDD4 File Offset: 0x0005AFD4
		public unsafe List<Type> typeRequirements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_typeRequirements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_typeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BC0 RID: 15296
		// (get) Token: 0x0600C4E9 RID: 50409 RVA: 0x0031FAAC File Offset: 0x0031DCAC
		// (set) Token: 0x0600C4EA RID: 50410 RVA: 0x0005CDF3 File Offset: 0x0005AFF3
		public unsafe ObjectSelector.ObjectFilter objectFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_objectFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BC1 RID: 15297
		// (get) Token: 0x0600C4EB RID: 50411 RVA: 0x0031FADC File Offset: 0x0031DCDC
		// (set) Token: 0x0600C4EC RID: 50412 RVA: 0x0005CE12 File Offset: 0x0005B012
		public unsafe Action<List<BuildableItem>> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<BuildableItem>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BC2 RID: 15298
		// (get) Token: 0x0600C4ED RID: 50413 RVA: 0x0031FB0C File Offset: 0x0031DD0C
		// (set) Token: 0x0600C4EE RID: 50414 RVA: 0x0005CE31 File Offset: 0x0005B031
		public unsafe BuildableItem hoveredObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_hoveredObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x0600C4EF RID: 50415 RVA: 0x0031FB3C File Offset: 0x0031DD3C
		// (set) Token: 0x0600C4F0 RID: 50416 RVA: 0x0005CE50 File Offset: 0x0005B050
		public unsafe BuildableItem highlightedObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_highlightedObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_highlightedObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x0600C4F1 RID: 50417 RVA: 0x0031FB6C File Offset: 0x0031DD6C
		// (set) Token: 0x0600C4F2 RID: 50418 RVA: 0x0005CE6F File Offset: 0x0005B06F
		public unsafe string selectionTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectionTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_selectionTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x0600C4F3 RID: 50419 RVA: 0x0031FB94 File Offset: 0x0031DD94
		// (set) Token: 0x0600C4F4 RID: 50420 RVA: 0x0005CE8E File Offset: 0x0005B08E
		public unsafe bool changesMade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_changesMade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_changesMade)) = value;
			}
		}

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x0600C4F5 RID: 50421 RVA: 0x0031FBBC File Offset: 0x0031DDBC
		// (set) Token: 0x0600C4F6 RID: 50422 RVA: 0x0005CEA9 File Offset: 0x0005B0A9
		public unsafe List<Transform> transitSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_transitSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_transitSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x0600C4F7 RID: 50423 RVA: 0x0031FBEC File Offset: 0x0031DDEC
		// (set) Token: 0x0600C4F8 RID: 50424 RVA: 0x0005CEC8 File Offset: 0x0005B0C8
		public unsafe List<TransitLineVisuals> transitLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_transitLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TransitLineVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_transitLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x0600C4F9 RID: 50425 RVA: 0x0031FC1C File Offset: 0x0031DE1C
		// (set) Token: 0x0600C4FA RID: 50426 RVA: 0x0005CEE7 File Offset: 0x0005B0E7
		public unsafe Property targetProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_targetProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSelector.NativeFieldInfoPtr_targetProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400864E RID: 34382
		private static readonly IntPtr NativeFieldInfoPtr_SELECTION_RANGE;

		// Token: 0x0400864F RID: 34383
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04008650 RID: 34384
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04008651 RID: 34385
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x04008652 RID: 34386
		private static readonly IntPtr NativeFieldInfoPtr_HoverOutlineColor;

		// Token: 0x04008653 RID: 34387
		private static readonly IntPtr NativeFieldInfoPtr_SelectOutlineColor;

		// Token: 0x04008654 RID: 34388
		private static readonly IntPtr NativeFieldInfoPtr_maxSelectedObjects;

		// Token: 0x04008655 RID: 34389
		private static readonly IntPtr NativeFieldInfoPtr_selectedObjects;

		// Token: 0x04008656 RID: 34390
		private static readonly IntPtr NativeFieldInfoPtr_typeRequirements;

		// Token: 0x04008657 RID: 34391
		private static readonly IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x04008658 RID: 34392
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04008659 RID: 34393
		private static readonly IntPtr NativeFieldInfoPtr_hoveredObj;

		// Token: 0x0400865A RID: 34394
		private static readonly IntPtr NativeFieldInfoPtr_highlightedObj;

		// Token: 0x0400865B RID: 34395
		private static readonly IntPtr NativeFieldInfoPtr_selectionTitle;

		// Token: 0x0400865C RID: 34396
		private static readonly IntPtr NativeFieldInfoPtr_changesMade;

		// Token: 0x0400865D RID: 34397
		private static readonly IntPtr NativeFieldInfoPtr_transitSources;

		// Token: 0x0400865E RID: 34398
		private static readonly IntPtr NativeFieldInfoPtr_transitLines;

		// Token: 0x0400865F RID: 34399
		private static readonly IntPtr NativeFieldInfoPtr_targetProperty;

		// Token: 0x04008660 RID: 34400
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008661 RID: 34401
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04008662 RID: 34402
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04008663 RID: 34403
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04008664 RID: 34404
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_String_String_Int32_List_1_BuildableItem_List_1_Type_Property_ObjectFilter_Action_1_List_1_BuildableItem_List_1_Transform_0;

		// Token: 0x04008665 RID: 34405
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransitLines_Private_Void_0;

		// Token: 0x04008666 RID: 34406
		private static readonly IntPtr NativeMethodInfoPtr_CloseAndSubmit_Private_Void_0;

		// Token: 0x04008667 RID: 34407
		private static readonly IntPtr NativeMethodInfoPtr_CloseAndCancel_Private_Void_0;

		// Token: 0x04008668 RID: 34408
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04008669 RID: 34409
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400866A RID: 34410
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400866B RID: 34411
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructions_Private_Void_0;

		// Token: 0x0400866C RID: 34412
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredObject_Private_BuildableItem_0;

		// Token: 0x0400866D RID: 34413
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectTypeValid_Public_Boolean_BuildableItem_byref_String_0;

		// Token: 0x0400866E RID: 34414
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Private_Void_0;

		// Token: 0x0400866F RID: 34415
		private static readonly IntPtr NativeMethodInfoPtr_ObjectClicked_Public_Void_BuildableItem_0;

		// Token: 0x04008670 RID: 34416
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectionOutline_Private_Void_BuildableItem_Boolean_0;

		// Token: 0x04008671 RID: 34417
		private static readonly IntPtr NativeMethodInfoPtr_ClipboardClosed_Private_Void_0;

		// Token: 0x04008672 RID: 34418
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04008673 RID: 34419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D61 RID: 3425
		public sealed class ObjectFilter : MulticastDelegate
		{
			// Token: 0x0600FAD3 RID: 64211 RVA: 0x003BE9DC File Offset: 0x003BCBDC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectFilter()
			{
				Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectSelector>.NativeClassPtr, "ObjectFilter");
				ObjectSelector.ObjectFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr, 100688837);
				ObjectSelector.ObjectFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr, 100688838);
				ObjectSelector.ObjectFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuildableItem_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr, 100688839);
				ObjectSelector.ObjectFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr, 100688840);
			}

			// Token: 0x0600FAD4 RID: 64212 RVA: 0x003BEA50 File Offset: 0x003BCC50
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 59159, RefRangeEnd = 59191, XrefRangeStart = 59159, XrefRangeEnd = 59191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectFilter(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSelector.ObjectFilter>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.ObjectFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FAD5 RID: 64213 RVA: 0x003BEAAC File Offset: 0x003BCCAC
			[CallerCount(0)]
			public unsafe bool Invoke(BuildableItem obj, out string reason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.ObjectFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600FAD6 RID: 64214 RVA: 0x003BEB14 File Offset: 0x003BCD14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(BuildableItem obj, out string reason, AsyncCallback callback, Il2CppSystem.Object @object)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.ObjectFilter.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuildableItem_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
			}

			// Token: 0x0600FAD7 RID: 64215 RVA: 0x003BEBA4 File Offset: 0x003BCDA4
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectSelector.ObjectFilter.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				reason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600FAD8 RID: 64216 RVA: 0x00076AB5 File Offset: 0x00074CB5
			public ObjectFilter(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0400A943 RID: 43331
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400A944 RID: 43332
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BuildableItem_byref_String_0;

			// Token: 0x0400A945 RID: 43333
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_BuildableItem_byref_String_AsyncCallback_Object_0;

			// Token: 0x0400A946 RID: 43334
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
		}
	}
}

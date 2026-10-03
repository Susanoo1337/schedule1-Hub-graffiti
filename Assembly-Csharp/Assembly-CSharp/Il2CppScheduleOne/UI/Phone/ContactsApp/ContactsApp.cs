using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.UI.Relations;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ContactsApp
{
	// Token: 0x020007BE RID: 1982
	public class ContactsApp : App<ContactsApp>
	{
		// Token: 0x0600C231 RID: 49713 RVA: 0x003176F4 File Offset: 0x003158F4
		// Note: this type is marked as 'beforefieldinit'.
		static ContactsApp()
		{
			Il2CppClassPointerStore<ContactsApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ContactsApp", "ContactsApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr);
			ContactsApp.NativeFieldInfoPtr_SelectedRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "SelectedRegion");
			ContactsApp.NativeFieldInfoPtr_RegionDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionDict");
			ContactsApp.NativeFieldInfoPtr_ScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ScrollRect");
			ContactsApp.NativeFieldInfoPtr_CirclesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "CirclesContainer");
			ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "TutorialCirclesContainer");
			ContactsApp.NativeFieldInfoPtr_ConnectionsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ConnectionsContainer");
			ContactsApp.NativeFieldInfoPtr_ContentRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ContentRect");
			ContactsApp.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "SelectionIndicator");
			ContactsApp.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "DetailPanel");
			ContactsApp.NativeFieldInfoPtr_RegionUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionUIs");
			ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionSelectionContainer");
			ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionSelectionIndicator");
			ContactsApp.NativeFieldInfoPtr_InfluenceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "InfluenceContainer");
			ContactsApp.NativeFieldInfoPtr_InfluenceSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "InfluenceSlider");
			ContactsApp.NativeFieldInfoPtr_InfluenceCountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "InfluenceCountLabel");
			ContactsApp.NativeFieldInfoPtr_UnlockRegionSliderNotch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "UnlockRegionSliderNotch");
			ContactsApp.NativeFieldInfoPtr_InfluenceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "InfluenceText");
			ContactsApp.NativeFieldInfoPtr_LowerContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "LowerContainer");
			ContactsApp.NativeFieldInfoPtr_HorizontalScrollbarRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "HorizontalScrollbarRectTransform");
			ContactsApp.NativeFieldInfoPtr_RegionLockedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionLockedContainer");
			ContactsApp.NativeFieldInfoPtr_RegionLocked_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionLocked_Rank");
			ContactsApp.NativeFieldInfoPtr_RegionLocked_CartelInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionLocked_CartelInfluence");
			ContactsApp.NativeFieldInfoPtr_RegionLocked_CartelInfluence_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionLocked_CartelInfluence_Text");
			ContactsApp.NativeFieldInfoPtr_RegionLocked_Unavailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionLocked_Unavailable");
			ContactsApp.NativeFieldInfoPtr_ConnectionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "ConnectionPrefab");
			ContactsApp.NativeFieldInfoPtr_uiScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "uiScreen");
			ContactsApp.NativeFieldInfoPtr_uiPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "uiPanel");
			ContactsApp.NativeFieldInfoPtr_RelationCircles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RelationCircles");
			ContactsApp.NativeFieldInfoPtr_contentMoveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "contentMoveRoutine");
			ContactsApp.NativeFieldInfoPtr_connections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "connections");
			ContactsApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100688556);
			ContactsApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100688557);
			ContactsApp.NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100688558);
			ContactsApp.NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100688559);
			ContactsApp.NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100688560);
			ContactsApp.NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100688561);
			ContactsApp.NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100688562);
			ContactsApp.NativeMethodInfoPtr_StopContentMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100688563);
			ContactsApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100688564);
			ContactsApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100688565);
			ContactsApp.NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, 100688566);
		}

		// Token: 0x0600C232 RID: 49714 RVA: 0x00317A58 File Offset: 0x00315C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321812, XrefRangeEnd = 322088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C233 RID: 49715 RVA: 0x00317A94 File Offset: 0x00315C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322088, XrefRangeEnd = 322113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C234 RID: 49716 RVA: 0x00317AD0 File Offset: 0x00315CD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322128, RefRangeEnd = 322130, XrefRangeStart = 322113, XrefRangeEnd = 322128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationCircle GetRelationCircle(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr3) : null;
		}

		// Token: 0x0600C235 RID: 49717 RVA: 0x00317B20 File Offset: 0x00315D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322130, XrefRangeEnd = 322131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CircleClicked(RelationCircle circ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(circ);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C236 RID: 49718 RVA: 0x00317B64 File Offset: 0x00315D64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 322139, RefRangeEnd = 322143, XrefRangeStart = 322131, XrefRangeEnd = 322139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(RelationCircle circ)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(circ);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C237 RID: 49719 RVA: 0x00317BA8 File Offset: 0x00315DA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322246, RefRangeEnd = 322249, XrefRangeStart = 322143, XrefRangeEnd = 322246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedRegion(EMapRegion region, bool selectNPC)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectNPC;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C238 RID: 49720 RVA: 0x00317BF4 File Offset: 0x00315DF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322264, RefRangeEnd = 322267, XrefRangeStart = 322249, XrefRangeEnd = 322264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ZoomToRect(RectTransform rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C239 RID: 49721 RVA: 0x00317C38 File Offset: 0x00315E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322267, XrefRangeEnd = 322268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopContentMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_StopContentMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C23A RID: 49722 RVA: 0x00317C6C File Offset: 0x00315E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322268, XrefRangeEnd = 322288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContactsApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C23B RID: 49723 RVA: 0x00317CB8 File Offset: 0x00315EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322288, XrefRangeEnd = 322315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactsApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C23C RID: 49724 RVA: 0x00317CF4 File Offset: 0x00315EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322315, XrefRangeEnd = 322320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_Boolean_PDM_0(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C23D RID: 49725 RVA: 0x0005B41C File Offset: 0x0005961C
		public ContactsApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x0600C23E RID: 49726 RVA: 0x00317D34 File Offset: 0x00315F34
		// (set) Token: 0x0600C23F RID: 49727 RVA: 0x0005B425 File Offset: 0x00059625
		public unsafe EMapRegion SelectedRegion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectedRegion)) = value;
			}
		}

		// Token: 0x17003AE1 RID: 15073
		// (get) Token: 0x0600C240 RID: 49728 RVA: 0x00317D5C File Offset: 0x00315F5C
		// (set) Token: 0x0600C241 RID: 49729 RVA: 0x0005B440 File Offset: 0x00059640
		public unsafe Dictionary<EMapRegion, ContactsApp.RegionUI> RegionDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EMapRegion, ContactsApp.RegionUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AE2 RID: 15074
		// (get) Token: 0x0600C242 RID: 49730 RVA: 0x00317D8C File Offset: 0x00315F8C
		// (set) Token: 0x0600C243 RID: 49731 RVA: 0x0005B45F File Offset: 0x0005965F
		public unsafe PinchableScrollRect ScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PinchableScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AE3 RID: 15075
		// (get) Token: 0x0600C244 RID: 49732 RVA: 0x00317DBC File Offset: 0x00315FBC
		// (set) Token: 0x0600C245 RID: 49733 RVA: 0x0005B47E File Offset: 0x0005967E
		public unsafe RectTransform CirclesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_CirclesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_CirclesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AE4 RID: 15076
		// (get) Token: 0x0600C246 RID: 49734 RVA: 0x00317DEC File Offset: 0x00315FEC
		// (set) Token: 0x0600C247 RID: 49735 RVA: 0x0005B49D File Offset: 0x0005969D
		public unsafe RectTransform TutorialCirclesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_TutorialCirclesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AE5 RID: 15077
		// (get) Token: 0x0600C248 RID: 49736 RVA: 0x00317E1C File Offset: 0x0031601C
		// (set) Token: 0x0600C249 RID: 49737 RVA: 0x0005B4BC File Offset: 0x000596BC
		public unsafe RectTransform ConnectionsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AE6 RID: 15078
		// (get) Token: 0x0600C24A RID: 49738 RVA: 0x00317E4C File Offset: 0x0031604C
		// (set) Token: 0x0600C24B RID: 49739 RVA: 0x0005B4DB File Offset: 0x000596DB
		public unsafe RectTransform ContentRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ContentRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ContentRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AE7 RID: 15079
		// (get) Token: 0x0600C24C RID: 49740 RVA: 0x00317E7C File Offset: 0x0031607C
		// (set) Token: 0x0600C24D RID: 49741 RVA: 0x0005B4FA File Offset: 0x000596FA
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AE8 RID: 15080
		// (get) Token: 0x0600C24E RID: 49742 RVA: 0x00317EAC File Offset: 0x003160AC
		// (set) Token: 0x0600C24F RID: 49743 RVA: 0x0005B519 File Offset: 0x00059719
		public unsafe ContactsDetailPanel DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AE9 RID: 15081
		// (get) Token: 0x0600C250 RID: 49744 RVA: 0x00317EDC File Offset: 0x003160DC
		// (set) Token: 0x0600C251 RID: 49745 RVA: 0x0005B538 File Offset: 0x00059738
		public unsafe Il2CppReferenceArray<ContactsApp.RegionUI> RegionUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ContactsApp.RegionUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x0600C252 RID: 49746 RVA: 0x00317F0C File Offset: 0x0031610C
		// (set) Token: 0x0600C253 RID: 49747 RVA: 0x0005B557 File Offset: 0x00059757
		public unsafe RectTransform RegionSelectionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x0600C254 RID: 49748 RVA: 0x00317F3C File Offset: 0x0031613C
		// (set) Token: 0x0600C255 RID: 49749 RVA: 0x0005B576 File Offset: 0x00059776
		public unsafe RectTransform RegionSelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionSelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x0600C256 RID: 49750 RVA: 0x00317F6C File Offset: 0x0031616C
		// (set) Token: 0x0600C257 RID: 49751 RVA: 0x0005B595 File Offset: 0x00059795
		public unsafe RectTransform InfluenceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_InfluenceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_InfluenceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x0600C258 RID: 49752 RVA: 0x00317F9C File Offset: 0x0031619C
		// (set) Token: 0x0600C259 RID: 49753 RVA: 0x0005B5B4 File Offset: 0x000597B4
		public unsafe Slider InfluenceSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_InfluenceSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_InfluenceSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AEE RID: 15086
		// (get) Token: 0x0600C25A RID: 49754 RVA: 0x00317FCC File Offset: 0x003161CC
		// (set) Token: 0x0600C25B RID: 49755 RVA: 0x0005B5D3 File Offset: 0x000597D3
		public unsafe Text InfluenceCountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_InfluenceCountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_InfluenceCountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AEF RID: 15087
		// (get) Token: 0x0600C25C RID: 49756 RVA: 0x00317FFC File Offset: 0x003161FC
		// (set) Token: 0x0600C25D RID: 49757 RVA: 0x0005B5F2 File Offset: 0x000597F2
		public unsafe RectTransform UnlockRegionSliderNotch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_UnlockRegionSliderNotch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_UnlockRegionSliderNotch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x0600C25E RID: 49758 RVA: 0x0031802C File Offset: 0x0031622C
		// (set) Token: 0x0600C25F RID: 49759 RVA: 0x0005B611 File Offset: 0x00059811
		public unsafe Text InfluenceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_InfluenceText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_InfluenceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x0600C260 RID: 49760 RVA: 0x0031805C File Offset: 0x0031625C
		// (set) Token: 0x0600C261 RID: 49761 RVA: 0x0005B630 File Offset: 0x00059830
		public unsafe RectTransform LowerContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_LowerContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_LowerContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x0600C262 RID: 49762 RVA: 0x0031808C File Offset: 0x0031628C
		// (set) Token: 0x0600C263 RID: 49763 RVA: 0x0005B64F File Offset: 0x0005984F
		public unsafe RectTransform HorizontalScrollbarRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_HorizontalScrollbarRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_HorizontalScrollbarRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x0600C264 RID: 49764 RVA: 0x003180BC File Offset: 0x003162BC
		// (set) Token: 0x0600C265 RID: 49765 RVA: 0x0005B66E File Offset: 0x0005986E
		public unsafe RectTransform RegionLockedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionLockedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionLockedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x0600C266 RID: 49766 RVA: 0x003180EC File Offset: 0x003162EC
		// (set) Token: 0x0600C267 RID: 49767 RVA: 0x0005B68D File Offset: 0x0005988D
		public unsafe RectTransform RegionLocked_Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionLocked_Rank);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionLocked_Rank), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x0600C268 RID: 49768 RVA: 0x0031811C File Offset: 0x0031631C
		// (set) Token: 0x0600C269 RID: 49769 RVA: 0x0005B6AC File Offset: 0x000598AC
		public unsafe RectTransform RegionLocked_CartelInfluence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionLocked_CartelInfluence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionLocked_CartelInfluence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x0600C26A RID: 49770 RVA: 0x0031814C File Offset: 0x0031634C
		// (set) Token: 0x0600C26B RID: 49771 RVA: 0x0005B6CB File Offset: 0x000598CB
		public unsafe Text RegionLocked_CartelInfluence_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionLocked_CartelInfluence_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionLocked_CartelInfluence_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AF7 RID: 15095
		// (get) Token: 0x0600C26C RID: 49772 RVA: 0x0031817C File Offset: 0x0031637C
		// (set) Token: 0x0600C26D RID: 49773 RVA: 0x0005B6EA File Offset: 0x000598EA
		public unsafe RectTransform RegionLocked_Unavailable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionLocked_Unavailable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RegionLocked_Unavailable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x0600C26E RID: 49774 RVA: 0x003181AC File Offset: 0x003163AC
		// (set) Token: 0x0600C26F RID: 49775 RVA: 0x0005B709 File Offset: 0x00059909
		public unsafe GameObject ConnectionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_ConnectionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x0600C270 RID: 49776 RVA: 0x003181DC File Offset: 0x003163DC
		// (set) Token: 0x0600C271 RID: 49777 RVA: 0x0005B728 File Offset: 0x00059928
		public unsafe UIScreen uiScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_uiScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_uiScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x0600C272 RID: 49778 RVA: 0x0031820C File Offset: 0x0031640C
		// (set) Token: 0x0600C273 RID: 49779 RVA: 0x0005B747 File Offset: 0x00059947
		public unsafe UIMapPanel uiPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_uiPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIMapPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_uiPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x0600C274 RID: 49780 RVA: 0x0031823C File Offset: 0x0031643C
		// (set) Token: 0x0600C275 RID: 49781 RVA: 0x0005B766 File Offset: 0x00059966
		public unsafe List<RelationCircle> RelationCircles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RelationCircles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RelationCircle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_RelationCircles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x0600C276 RID: 49782 RVA: 0x0031826C File Offset: 0x0031646C
		// (set) Token: 0x0600C277 RID: 49783 RVA: 0x0005B785 File Offset: 0x00059985
		public unsafe Coroutine contentMoveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_contentMoveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_contentMoveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x0600C278 RID: 49784 RVA: 0x0031829C File Offset: 0x0031649C
		// (set) Token: 0x0600C279 RID: 49785 RVA: 0x0005B7A4 File Offset: 0x000599A4
		public unsafe List<Tuple<NPC, NPC>> connections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_connections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tuple<NPC, NPC>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.NativeFieldInfoPtr_connections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040084C4 RID: 33988
		private static readonly IntPtr NativeFieldInfoPtr_SelectedRegion;

		// Token: 0x040084C5 RID: 33989
		private static readonly IntPtr NativeFieldInfoPtr_RegionDict;

		// Token: 0x040084C6 RID: 33990
		private static readonly IntPtr NativeFieldInfoPtr_ScrollRect;

		// Token: 0x040084C7 RID: 33991
		private static readonly IntPtr NativeFieldInfoPtr_CirclesContainer;

		// Token: 0x040084C8 RID: 33992
		private static readonly IntPtr NativeFieldInfoPtr_TutorialCirclesContainer;

		// Token: 0x040084C9 RID: 33993
		private static readonly IntPtr NativeFieldInfoPtr_ConnectionsContainer;

		// Token: 0x040084CA RID: 33994
		private static readonly IntPtr NativeFieldInfoPtr_ContentRect;

		// Token: 0x040084CB RID: 33995
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x040084CC RID: 33996
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x040084CD RID: 33997
		private static readonly IntPtr NativeFieldInfoPtr_RegionUIs;

		// Token: 0x040084CE RID: 33998
		private static readonly IntPtr NativeFieldInfoPtr_RegionSelectionContainer;

		// Token: 0x040084CF RID: 33999
		private static readonly IntPtr NativeFieldInfoPtr_RegionSelectionIndicator;

		// Token: 0x040084D0 RID: 34000
		private static readonly IntPtr NativeFieldInfoPtr_InfluenceContainer;

		// Token: 0x040084D1 RID: 34001
		private static readonly IntPtr NativeFieldInfoPtr_InfluenceSlider;

		// Token: 0x040084D2 RID: 34002
		private static readonly IntPtr NativeFieldInfoPtr_InfluenceCountLabel;

		// Token: 0x040084D3 RID: 34003
		private static readonly IntPtr NativeFieldInfoPtr_UnlockRegionSliderNotch;

		// Token: 0x040084D4 RID: 34004
		private static readonly IntPtr NativeFieldInfoPtr_InfluenceText;

		// Token: 0x040084D5 RID: 34005
		private static readonly IntPtr NativeFieldInfoPtr_LowerContainer;

		// Token: 0x040084D6 RID: 34006
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalScrollbarRectTransform;

		// Token: 0x040084D7 RID: 34007
		private static readonly IntPtr NativeFieldInfoPtr_RegionLockedContainer;

		// Token: 0x040084D8 RID: 34008
		private static readonly IntPtr NativeFieldInfoPtr_RegionLocked_Rank;

		// Token: 0x040084D9 RID: 34009
		private static readonly IntPtr NativeFieldInfoPtr_RegionLocked_CartelInfluence;

		// Token: 0x040084DA RID: 34010
		private static readonly IntPtr NativeFieldInfoPtr_RegionLocked_CartelInfluence_Text;

		// Token: 0x040084DB RID: 34011
		private static readonly IntPtr NativeFieldInfoPtr_RegionLocked_Unavailable;

		// Token: 0x040084DC RID: 34012
		private static readonly IntPtr NativeFieldInfoPtr_ConnectionPrefab;

		// Token: 0x040084DD RID: 34013
		private static readonly IntPtr NativeFieldInfoPtr_uiScreen;

		// Token: 0x040084DE RID: 34014
		private static readonly IntPtr NativeFieldInfoPtr_uiPanel;

		// Token: 0x040084DF RID: 34015
		private static readonly IntPtr NativeFieldInfoPtr_RelationCircles;

		// Token: 0x040084E0 RID: 34016
		private static readonly IntPtr NativeFieldInfoPtr_contentMoveRoutine;

		// Token: 0x040084E1 RID: 34017
		private static readonly IntPtr NativeFieldInfoPtr_connections;

		// Token: 0x040084E2 RID: 34018
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040084E3 RID: 34019
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040084E4 RID: 34020
		private static readonly IntPtr NativeMethodInfoPtr_GetRelationCircle_Private_RelationCircle_String_0;

		// Token: 0x040084E5 RID: 34021
		private static readonly IntPtr NativeMethodInfoPtr_CircleClicked_Private_Void_RelationCircle_0;

		// Token: 0x040084E6 RID: 34022
		private static readonly IntPtr NativeMethodInfoPtr_Select_Private_Void_RelationCircle_0;

		// Token: 0x040084E7 RID: 34023
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedRegion_Public_Void_EMapRegion_Boolean_0;

		// Token: 0x040084E8 RID: 34024
		private static readonly IntPtr NativeMethodInfoPtr_ZoomToRect_Private_Void_RectTransform_0;

		// Token: 0x040084E9 RID: 34025
		private static readonly IntPtr NativeMethodInfoPtr_StopContentMove_Private_Void_0;

		// Token: 0x040084EA RID: 34026
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040084EB RID: 34027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040084EC RID: 34028
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Boolean_PDM_0;

		// Token: 0x02000D4D RID: 3405
		[Serializable]
		public class RegionUI : Il2CppSystem.Object
		{
			// Token: 0x0600FA1A RID: 64026 RVA: 0x003BC9F4 File Offset: 0x003BABF4
			// Note: this type is marked as 'beforefieldinit'.
			static RegionUI()
			{
				Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "RegionUI");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr);
				ContactsApp.RegionUI.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Region");
				ContactsApp.RegionUI.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Button");
				ContactsApp.RegionUI.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "Container");
				ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "ConnectionsContainer");
				ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, "<npcs>k__BackingField");
				ContactsApp.RegionUI.NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100688567);
				ContactsApp.RegionUI.NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100688568);
				ContactsApp.RegionUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr, 100688569);
			}

			// Token: 0x17004C0D RID: 19469
			// (get) Token: 0x0600FA1B RID: 64027 RVA: 0x003BCAC0 File Offset: 0x003BACC0
			// (set) Token: 0x0600FA1C RID: 64028 RVA: 0x003BCB00 File Offset: 0x003BAD00
			public unsafe List<NPC> npcs
			{
				[CallerCount(13)]
				[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600FA1D RID: 64029 RVA: 0x003BCB44 File Offset: 0x003BAD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321749, XrefRangeEnd = 321757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RegionUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.RegionUI>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.RegionUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA1E RID: 64030 RVA: 0x000764D8 File Offset: 0x000746D8
			public RegionUI(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C08 RID: 19464
			// (get) Token: 0x0600FA1F RID: 64031 RVA: 0x003BCB80 File Offset: 0x003BAD80
			// (set) Token: 0x0600FA20 RID: 64032 RVA: 0x000764E1 File Offset: 0x000746E1
			public unsafe EMapRegion Region
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Region);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Region)) = value;
				}
			}

			// Token: 0x17004C09 RID: 19465
			// (get) Token: 0x0600FA21 RID: 64033 RVA: 0x003BCBA8 File Offset: 0x003BADA8
			// (set) Token: 0x0600FA22 RID: 64034 RVA: 0x000764FC File Offset: 0x000746FC
			public unsafe Button Button
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Button);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C0A RID: 19466
			// (get) Token: 0x0600FA23 RID: 64035 RVA: 0x003BCBD8 File Offset: 0x003BADD8
			// (set) Token: 0x0600FA24 RID: 64036 RVA: 0x0007651B File Offset: 0x0007471B
			public unsafe RectTransform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C0B RID: 19467
			// (get) Token: 0x0600FA25 RID: 64037 RVA: 0x003BCC08 File Offset: 0x003BAE08
			// (set) Token: 0x0600FA26 RID: 64038 RVA: 0x0007653A File Offset: 0x0007473A
			public unsafe RectTransform ConnectionsContainer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr_ConnectionsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C0C RID: 19468
			// (get) Token: 0x0600FA27 RID: 64039 RVA: 0x003BCC38 File Offset: 0x003BAE38
			// (set) Token: 0x0600FA28 RID: 64040 RVA: 0x00076559 File Offset: 0x00074759
			public unsafe List<NPC> _npcs_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.RegionUI.NativeFieldInfoPtr__npcs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8E1 RID: 43233
			private static readonly IntPtr NativeFieldInfoPtr_Region;

			// Token: 0x0400A8E2 RID: 43234
			private static readonly IntPtr NativeFieldInfoPtr_Button;

			// Token: 0x0400A8E3 RID: 43235
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x0400A8E4 RID: 43236
			private static readonly IntPtr NativeFieldInfoPtr_ConnectionsContainer;

			// Token: 0x0400A8E5 RID: 43237
			private static readonly IntPtr NativeFieldInfoPtr__npcs_k__BackingField;

			// Token: 0x0400A8E6 RID: 43238
			private static readonly IntPtr NativeMethodInfoPtr_get_npcs_Public_get_List_1_NPC_0;

			// Token: 0x0400A8E7 RID: 43239
			private static readonly IntPtr NativeMethodInfoPtr_set_npcs_Public_set_Void_List_1_NPC_0;

			// Token: 0x0400A8E8 RID: 43240
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000D4E RID: 3406
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FA29 RID: 64041 RVA: 0x003BCC68 File Offset: 0x003BAE68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass31_0.NativeFieldInfoPtr_cacheReg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_0>.NativeClassPtr, "cacheReg");
				ContactsApp.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_0>.NativeClassPtr, 100688570);
				ContactsApp.__c__DisplayClass31_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_0>.NativeClassPtr, 100688571);
			}

			// Token: 0x0600FA2A RID: 64042 RVA: 0x003BCCE4 File Offset: 0x003BAEE4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA2B RID: 64043 RVA: 0x003BCD20 File Offset: 0x003BAF20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321757, XrefRangeEnd = 321759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA2C RID: 64044 RVA: 0x00076578 File Offset: 0x00074778
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C0E RID: 19470
			// (get) Token: 0x0600FA2D RID: 64045 RVA: 0x003BCD54 File Offset: 0x003BAF54
			// (set) Token: 0x0600FA2E RID: 64046 RVA: 0x00076581 File Offset: 0x00074781
			public unsafe ContactsApp.RegionUI cacheReg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_0.NativeFieldInfoPtr_cacheReg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.RegionUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_0.NativeFieldInfoPtr_cacheReg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C0F RID: 19471
			// (get) Token: 0x0600FA2F RID: 64047 RVA: 0x003BCD84 File Offset: 0x003BAF84
			// (set) Token: 0x0600FA30 RID: 64048 RVA: 0x000765A0 File Offset: 0x000747A0
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8E9 RID: 43241
			private static readonly IntPtr NativeFieldInfoPtr_cacheReg;

			// Token: 0x0400A8EA RID: 43242
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8EB RID: 43243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8EC RID: 43244
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}

		// Token: 0x02000D4F RID: 3407
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass31_1")]
		public sealed class __c__DisplayClass31_1 : Il2CppSystem.Object
		{
			// Token: 0x0600FA31 RID: 64049 RVA: 0x003BCDB4 File Offset: 0x003BAFB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_1()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass31_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_1>.NativeClassPtr);
				ContactsApp.__c__DisplayClass31_1.NativeFieldInfoPtr_rel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_1>.NativeClassPtr, "rel");
				ContactsApp.__c__DisplayClass31_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_1>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass31_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_1>.NativeClassPtr, 100688572);
				ContactsApp.__c__DisplayClass31_1.NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_1>.NativeClassPtr, 100688573);
			}

			// Token: 0x0600FA32 RID: 64050 RVA: 0x003BCE30 File Offset: 0x003BB030
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA33 RID: 64051 RVA: 0x003BCE6C File Offset: 0x003BB06C
			[CallerCount(0)]
			public unsafe bool _Start_b__1(ContactsApp.RegionUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_1.NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FA34 RID: 64052 RVA: 0x000765BF File Offset: 0x000747BF
			public __c__DisplayClass31_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C10 RID: 19472
			// (get) Token: 0x0600FA35 RID: 64053 RVA: 0x003BCEBC File Offset: 0x003BB0BC
			// (set) Token: 0x0600FA36 RID: 64054 RVA: 0x000765C8 File Offset: 0x000747C8
			public unsafe RelationCircle rel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_1.NativeFieldInfoPtr_rel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_1.NativeFieldInfoPtr_rel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C11 RID: 19473
			// (get) Token: 0x0600FA37 RID: 64055 RVA: 0x003BCEEC File Offset: 0x003BB0EC
			// (set) Token: 0x0600FA38 RID: 64056 RVA: 0x000765E7 File Offset: 0x000747E7
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8ED RID: 43245
			private static readonly IntPtr NativeFieldInfoPtr_rel;

			// Token: 0x0400A8EE RID: 43246
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8EF RID: 43247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8F0 RID: 43248
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Boolean_RegionUI_0;
		}

		// Token: 0x02000D50 RID: 3408
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass31_2")]
		public sealed class __c__DisplayClass31_2 : Il2CppSystem.Object
		{
			// Token: 0x0600FA39 RID: 64057 RVA: 0x003BCF1C File Offset: 0x003BB11C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_2()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass31_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_2>.NativeClassPtr);
				ContactsApp.__c__DisplayClass31_2.NativeFieldInfoPtr_other = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_2>.NativeClassPtr, "other");
				ContactsApp.__c__DisplayClass31_2.NativeFieldInfoPtr_field_Public___c__DisplayClass31_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_2>.NativeClassPtr, "CS$<>8__locals1");
				ContactsApp.__c__DisplayClass31_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_2>.NativeClassPtr, 100688574);
				ContactsApp.__c__DisplayClass31_2.NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_2>.NativeClassPtr, 100688575);
				ContactsApp.__c__DisplayClass31_2.NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_2>.NativeClassPtr, 100688576);
			}

			// Token: 0x0600FA3A RID: 64058 RVA: 0x003BCFAC File Offset: 0x003BB1AC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA3B RID: 64059 RVA: 0x003BCFE8 File Offset: 0x003BB1E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321759, XrefRangeEnd = 321765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__2(Tuple<NPC, NPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_2.NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FA3C RID: 64060 RVA: 0x003BD038 File Offset: 0x003BB238
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321765, XrefRangeEnd = 321771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__3(Tuple<NPC, NPC> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_2.NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FA3D RID: 64061 RVA: 0x00076606 File Offset: 0x00074806
			public __c__DisplayClass31_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C12 RID: 19474
			// (get) Token: 0x0600FA3E RID: 64062 RVA: 0x003BD088 File Offset: 0x003BB288
			// (set) Token: 0x0600FA3F RID: 64063 RVA: 0x0007660F File Offset: 0x0007480F
			public unsafe NPC other
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_2.NativeFieldInfoPtr_other);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_2.NativeFieldInfoPtr_other), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C13 RID: 19475
			// (get) Token: 0x0600FA40 RID: 64064 RVA: 0x003BD0B8 File Offset: 0x003BB2B8
			// (set) Token: 0x0600FA41 RID: 64065 RVA: 0x0007662E File Offset: 0x0007482E
			public unsafe ContactsApp.__c__DisplayClass31_1 field_Public___c__DisplayClass31_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_2.NativeFieldInfoPtr_field_Public___c__DisplayClass31_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass31_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_2.NativeFieldInfoPtr_field_Public___c__DisplayClass31_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8F1 RID: 43249
			private static readonly IntPtr NativeFieldInfoPtr_other;

			// Token: 0x0400A8F2 RID: 43250
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass31_1_0;

			// Token: 0x0400A8F3 RID: 43251
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8F4 RID: 43252
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_Internal_Boolean_Tuple_2_NPC_NPC_0;

			// Token: 0x0400A8F5 RID: 43253
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__3_Internal_Boolean_Tuple_2_NPC_NPC_0;
		}

		// Token: 0x02000D51 RID: 3409
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass31_3")]
		public sealed class __c__DisplayClass31_3 : Il2CppSystem.Object
		{
			// Token: 0x0600FA42 RID: 64066 RVA: 0x003BD0E8 File Offset: 0x003BB2E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_3()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass31_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_3>.NativeClassPtr);
				ContactsApp.__c__DisplayClass31_3.NativeFieldInfoPtr_otherCirc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_3>.NativeClassPtr, "otherCirc");
				ContactsApp.__c__DisplayClass31_3.NativeFieldInfoPtr_cacheRel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_3>.NativeClassPtr, "cacheRel");
				ContactsApp.__c__DisplayClass31_3.NativeFieldInfoPtr_field_Public___c__DisplayClass31_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_3>.NativeClassPtr, "CS$<>8__locals2");
				ContactsApp.__c__DisplayClass31_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_3>.NativeClassPtr, 100688577);
				ContactsApp.__c__DisplayClass31_3.NativeMethodInfoPtr__Start_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_3>.NativeClassPtr, 100688578);
				ContactsApp.__c__DisplayClass31_3.NativeMethodInfoPtr__Start_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_3>.NativeClassPtr, 100688579);
			}

			// Token: 0x0600FA43 RID: 64067 RVA: 0x003BD18C File Offset: 0x003BB38C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA44 RID: 64068 RVA: 0x003BD1C8 File Offset: 0x003BB3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321771, XrefRangeEnd = 321773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_3.NativeMethodInfoPtr__Start_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA45 RID: 64069 RVA: 0x003BD1FC File Offset: 0x003BB3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321773, XrefRangeEnd = 321775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_3.NativeMethodInfoPtr__Start_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA46 RID: 64070 RVA: 0x0007664D File Offset: 0x0007484D
			public __c__DisplayClass31_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C14 RID: 19476
			// (get) Token: 0x0600FA47 RID: 64071 RVA: 0x003BD230 File Offset: 0x003BB430
			// (set) Token: 0x0600FA48 RID: 64072 RVA: 0x00076656 File Offset: 0x00074856
			public unsafe RelationCircle otherCirc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_3.NativeFieldInfoPtr_otherCirc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_3.NativeFieldInfoPtr_otherCirc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C15 RID: 19477
			// (get) Token: 0x0600FA49 RID: 64073 RVA: 0x003BD260 File Offset: 0x003BB460
			// (set) Token: 0x0600FA4A RID: 64074 RVA: 0x00076675 File Offset: 0x00074875
			public unsafe RelationCircle cacheRel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_3.NativeFieldInfoPtr_cacheRel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_3.NativeFieldInfoPtr_cacheRel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C16 RID: 19478
			// (get) Token: 0x0600FA4B RID: 64075 RVA: 0x003BD290 File Offset: 0x003BB490
			// (set) Token: 0x0600FA4C RID: 64076 RVA: 0x00076694 File Offset: 0x00074894
			public unsafe ContactsApp.__c__DisplayClass31_2 field_Public___c__DisplayClass31_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_3.NativeFieldInfoPtr_field_Public___c__DisplayClass31_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass31_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_3.NativeFieldInfoPtr_field_Public___c__DisplayClass31_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8F6 RID: 43254
			private static readonly IntPtr NativeFieldInfoPtr_otherCirc;

			// Token: 0x0400A8F7 RID: 43255
			private static readonly IntPtr NativeFieldInfoPtr_cacheRel;

			// Token: 0x0400A8F8 RID: 43256
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass31_2_0;

			// Token: 0x0400A8F9 RID: 43257
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8FA RID: 43258
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__4_Internal_Void_0;

			// Token: 0x0400A8FB RID: 43259
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__5_Internal_Void_0;
		}

		// Token: 0x02000D52 RID: 3410
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass31_4")]
		public sealed class __c__DisplayClass31_4 : Il2CppSystem.Object
		{
			// Token: 0x0600FA4D RID: 64077 RVA: 0x003BD2C0 File Offset: 0x003BB4C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_4()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass31_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_4>.NativeClassPtr);
				ContactsApp.__c__DisplayClass31_4.NativeFieldInfoPtr_circ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_4>.NativeClassPtr, "circ");
				ContactsApp.__c__DisplayClass31_4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_4>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass31_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_4>.NativeClassPtr, 100688580);
				ContactsApp.__c__DisplayClass31_4.NativeMethodInfoPtr__Start_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_4>.NativeClassPtr, 100688581);
			}

			// Token: 0x0600FA4E RID: 64078 RVA: 0x003BD33C File Offset: 0x003BB53C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass31_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA4F RID: 64079 RVA: 0x003BD378 File Offset: 0x003BB578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321775, XrefRangeEnd = 321777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass31_4.NativeMethodInfoPtr__Start_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA50 RID: 64080 RVA: 0x000766B3 File Offset: 0x000748B3
			public __c__DisplayClass31_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C17 RID: 19479
			// (get) Token: 0x0600FA51 RID: 64081 RVA: 0x003BD3AC File Offset: 0x003BB5AC
			// (set) Token: 0x0600FA52 RID: 64082 RVA: 0x000766BC File Offset: 0x000748BC
			public unsafe RelationCircle circ
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_4.NativeFieldInfoPtr_circ);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_4.NativeFieldInfoPtr_circ), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C18 RID: 19480
			// (get) Token: 0x0600FA53 RID: 64083 RVA: 0x003BD3DC File Offset: 0x003BB5DC
			// (set) Token: 0x0600FA54 RID: 64084 RVA: 0x000766DB File Offset: 0x000748DB
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass31_4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A8FC RID: 43260
			private static readonly IntPtr NativeFieldInfoPtr_circ;

			// Token: 0x0400A8FD RID: 43261
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8FE RID: 43262
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8FF RID: 43263
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__6_Internal_Void_0;
		}

		// Token: 0x02000D53 RID: 3411
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FA55 RID: 64085 RVA: 0x003BD40C File Offset: 0x003BB60C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass33_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass33_0.NativeFieldInfoPtr_npcID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass33_0>.NativeClassPtr, "npcID");
				ContactsApp.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass33_0>.NativeClassPtr, 100688582);
				ContactsApp.__c__DisplayClass33_0.NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass33_0>.NativeClassPtr, 100688583);
			}

			// Token: 0x0600FA56 RID: 64086 RVA: 0x003BD474 File Offset: 0x003BB674
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA57 RID: 64087 RVA: 0x003BD4B0 File Offset: 0x003BB6B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321777, XrefRangeEnd = 321782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRelationCircle_b__0(RelationCircle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass33_0.NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FA58 RID: 64088 RVA: 0x000766FA File Offset: 0x000748FA
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C19 RID: 19481
			// (get) Token: 0x0600FA59 RID: 64089 RVA: 0x003BD500 File Offset: 0x003BB700
			// (set) Token: 0x0600FA5A RID: 64090 RVA: 0x00076703 File Offset: 0x00074903
			public unsafe string npcID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass33_0.NativeFieldInfoPtr_npcID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass33_0.NativeFieldInfoPtr_npcID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A900 RID: 43264
			private static readonly IntPtr NativeFieldInfoPtr_npcID;

			// Token: 0x0400A901 RID: 43265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A902 RID: 43266
			private static readonly IntPtr NativeMethodInfoPtr__GetRelationCircle_b__0_Internal_Boolean_RelationCircle_0;
		}

		// Token: 0x02000D54 RID: 3412
		[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FA5B RID: 64091 RVA: 0x003BD528 File Offset: 0x003BB728
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0>.NativeClassPtr);
				ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0>.NativeClassPtr, "endPos");
				ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0>.NativeClassPtr, "startScale");
				ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0>.NativeClassPtr, "endScale");
				ContactsApp.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0>.NativeClassPtr, 100688584);
				ContactsApp.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0>.NativeClassPtr, 100688585);
			}

			// Token: 0x0600FA5C RID: 64092 RVA: 0x003BD5CC File Offset: 0x003BB7CC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA5D RID: 64093 RVA: 0x003BD608 File Offset: 0x003BB808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321807, XrefRangeEnd = 321812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass37_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600FA5E RID: 64094 RVA: 0x00076722 File Offset: 0x00074922
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C1A RID: 19482
			// (get) Token: 0x0600FA5F RID: 64095 RVA: 0x003BD648 File Offset: 0x003BB848
			// (set) Token: 0x0600FA60 RID: 64096 RVA: 0x0007672B File Offset: 0x0007492B
			public unsafe ContactsApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C1B RID: 19483
			// (get) Token: 0x0600FA61 RID: 64097 RVA: 0x003BD678 File Offset: 0x003BB878
			// (set) Token: 0x0600FA62 RID: 64098 RVA: 0x0007674A File Offset: 0x0007494A
			public unsafe Vector2 endPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr_endPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr_endPos)) = value;
				}
			}

			// Token: 0x17004C1C RID: 19484
			// (get) Token: 0x0600FA63 RID: 64099 RVA: 0x003BD6A0 File Offset: 0x003BB8A0
			// (set) Token: 0x0600FA64 RID: 64100 RVA: 0x00076765 File Offset: 0x00074965
			public unsafe float startScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x17004C1D RID: 19485
			// (get) Token: 0x0600FA65 RID: 64101 RVA: 0x003BD6C8 File Offset: 0x003BB8C8
			// (set) Token: 0x0600FA66 RID: 64102 RVA: 0x00076780 File Offset: 0x00074980
			public unsafe float endScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x0400A903 RID: 43267
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A904 RID: 43268
			private static readonly IntPtr NativeFieldInfoPtr_endPos;

			// Token: 0x0400A905 RID: 43269
			private static readonly IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x0400A906 RID: 43270
			private static readonly IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x0400A907 RID: 43271
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A908 RID: 43272
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E17 RID: 3607
			[ObfuscatedName("ScheduleOne.UI.Phone.ContactsApp.ContactsApp+<>c__DisplayClass37_0+<<ZoomToRect>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060103F5 RID: 66549 RVA: 0x003D95F0 File Offset: 0x003D77F0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique()
				{
					Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0>.NativeClassPtr, "<<ZoomToRect>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr);
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>1__state");
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>2__current");
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<>4__this");
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<startPos>5__2");
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__3");
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, "<i>5__4");
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100688586);
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100688587);
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100688588);
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100688589);
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100688590);
					ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr, 100688591);
				}

				// Token: 0x060103F6 RID: 66550 RVA: 0x003D970C File Offset: 0x003D790C
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060103F7 RID: 66551 RVA: 0x003D9754 File Offset: 0x003D7954
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060103F8 RID: 66552 RVA: 0x003D9788 File Offset: 0x003D7988
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321782, XrefRangeEnd = 321802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F81 RID: 20353
				// (get) Token: 0x060103F9 RID: 66553 RVA: 0x003D97C4 File Offset: 0x003D79C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060103FA RID: 66554 RVA: 0x003D9804 File Offset: 0x003D7A04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321802, XrefRangeEnd = 321807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F82 RID: 20354
				// (get) Token: 0x060103FB RID: 66555 RVA: 0x003D9838 File Offset: 0x003D7A38
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060103FC RID: 66556 RVA: 0x0007B579 File Offset: 0x00079779
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F7B RID: 20347
				// (get) Token: 0x060103FD RID: 66557 RVA: 0x003D9878 File Offset: 0x003D7A78
				// (set) Token: 0x060103FE RID: 66558 RVA: 0x0007B582 File Offset: 0x00079782
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F7C RID: 20348
				// (get) Token: 0x060103FF RID: 66559 RVA: 0x003D98A0 File Offset: 0x003D7AA0
				// (set) Token: 0x06010400 RID: 66560 RVA: 0x0007B59D File Offset: 0x0007979D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F7D RID: 20349
				// (get) Token: 0x06010401 RID: 66561 RVA: 0x003D98D0 File Offset: 0x003D7AD0
				// (set) Token: 0x06010402 RID: 66562 RVA: 0x0007B5BC File Offset: 0x000797BC
				public unsafe ContactsApp.__c__DisplayClass37_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContactsApp.__c__DisplayClass37_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F7E RID: 20350
				// (get) Token: 0x06010403 RID: 66563 RVA: 0x003D9900 File Offset: 0x003D7B00
				// (set) Token: 0x06010404 RID: 66564 RVA: 0x0007B5DB File Offset: 0x000797DB
				public unsafe Vector2 _startPos_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__startPos_5__2)) = value;
					}
				}

				// Token: 0x17004F7F RID: 20351
				// (get) Token: 0x06010405 RID: 66565 RVA: 0x003D9928 File Offset: 0x003D7B28
				// (set) Token: 0x06010406 RID: 66566 RVA: 0x0007B5F6 File Offset: 0x000797F6
				public unsafe float _lerpTime_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3)) = value;
					}
				}

				// Token: 0x17004F80 RID: 20352
				// (get) Token: 0x06010407 RID: 66567 RVA: 0x003D9950 File Offset: 0x003D7B50
				// (set) Token: 0x06010408 RID: 66568 RVA: 0x0007B611 File Offset: 0x00079811
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContactsApp.__c__DisplayClass37_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x0400AEE6 RID: 44774
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEE7 RID: 44775
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AEE8 RID: 44776
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEE9 RID: 44777
				private static readonly IntPtr NativeFieldInfoPtr__startPos_5__2;

				// Token: 0x0400AEEA RID: 44778
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__3;

				// Token: 0x0400AEEB RID: 44779
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400AEEC RID: 44780
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AEED RID: 44781
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEEE RID: 44782
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AEEF RID: 44783
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AEF0 RID: 44784
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEF1 RID: 44785
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}

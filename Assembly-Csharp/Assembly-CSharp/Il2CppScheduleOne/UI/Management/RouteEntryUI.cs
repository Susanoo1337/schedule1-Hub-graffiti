using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007D7 RID: 2007
	public class RouteEntryUI : MonoBehaviour
	{
		// Token: 0x0600C40C RID: 50188 RVA: 0x0031CC80 File Offset: 0x0031AE80
		// Note: this type is marked as 'beforefieldinit'.
		static RouteEntryUI()
		{
			Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RouteEntryUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr);
			RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "<AssignedRoute>k__BackingField");
			RouteEntryUI.NativeFieldInfoPtr_SourceIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "SourceIcon");
			RouteEntryUI.NativeFieldInfoPtr_SourceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "SourceLabel");
			RouteEntryUI.NativeFieldInfoPtr_DestinationIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "DestinationIcon");
			RouteEntryUI.NativeFieldInfoPtr_DestinationLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "DestinationLabel");
			RouteEntryUI.NativeFieldInfoPtr_FilterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "FilterIcon");
			RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "onDeleteClicked");
			RouteEntryUI.NativeFieldInfoPtr_settingSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "settingSource");
			RouteEntryUI.NativeFieldInfoPtr_settingDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, "settingDestination");
			RouteEntryUI.NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688724);
			RouteEntryUI.NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688725);
			RouteEntryUI.NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688726);
			RouteEntryUI.NativeMethodInfoPtr_ClearRoute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688727);
			RouteEntryUI.NativeMethodInfoPtr_RefreshUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688728);
			RouteEntryUI.NativeMethodInfoPtr_SourceClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688729);
			RouteEntryUI.NativeMethodInfoPtr_DestinationClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688730);
			RouteEntryUI.NativeMethodInfoPtr_FilterClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688731);
			RouteEntryUI.NativeMethodInfoPtr_DeleteClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688732);
			RouteEntryUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688733);
			RouteEntryUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688734);
			RouteEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr, 100688735);
		}

		// Token: 0x17003B88 RID: 15240
		// (get) Token: 0x0600C40D RID: 50189 RVA: 0x0031CE54 File Offset: 0x0031B054
		// (set) Token: 0x0600C40E RID: 50190 RVA: 0x0031CE94 File Offset: 0x0031B094
		public unsafe AdvancedTransitRoute AssignedRoute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C40F RID: 50191 RVA: 0x0031CED8 File Offset: 0x0031B0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324500, XrefRangeEnd = 324502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignRoute(AdvancedTransitRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C410 RID: 50192 RVA: 0x0031CF1C File Offset: 0x0031B11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324502, XrefRangeEnd = 324503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRoute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ClearRoute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C411 RID: 50193 RVA: 0x0031CF50 File Offset: 0x0031B150
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324543, RefRangeEnd = 324545, XrefRangeStart = 324503, XrefRangeEnd = 324543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_RefreshUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C412 RID: 50194 RVA: 0x0031CF84 File Offset: 0x0031B184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324545, XrefRangeEnd = 324589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SourceClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_SourceClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C413 RID: 50195 RVA: 0x0031CFB8 File Offset: 0x0031B1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324589, XrefRangeEnd = 324633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_DestinationClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C414 RID: 50196 RVA: 0x0031CFEC File Offset: 0x0031B1EC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_FilterClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C415 RID: 50197 RVA: 0x0031D020 File Offset: 0x0031B220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 236558, RefRangeEnd = 236559, XrefRangeStart = 236558, XrefRangeEnd = 236559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_DeleteClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C416 RID: 50198 RVA: 0x0031D054 File Offset: 0x0031B254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324633, XrefRangeEnd = 324641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValid(ITransitEntity obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600C417 RID: 50199 RVA: 0x0031D0BC File Offset: 0x0031B2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324641, XrefRangeEnd = 324652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectsSelected(List<ITransitEntity> objs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C418 RID: 50200 RVA: 0x0031D100 File Offset: 0x0031B300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324652, XrefRangeEnd = 324658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteEntryUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteEntryUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteEntryUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C419 RID: 50201 RVA: 0x0005C6F2 File Offset: 0x0005A8F2
		public RouteEntryUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003B7F RID: 15231
		// (get) Token: 0x0600C41A RID: 50202 RVA: 0x0031D13C File Offset: 0x0031B33C
		// (set) Token: 0x0600C41B RID: 50203 RVA: 0x0005C6FB File Offset: 0x0005A8FB
		public unsafe AdvancedTransitRoute _AssignedRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr__AssignedRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x0600C41C RID: 50204 RVA: 0x0031D16C File Offset: 0x0031B36C
		// (set) Token: 0x0600C41D RID: 50205 RVA: 0x0005C71A File Offset: 0x0005A91A
		public unsafe Image SourceIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_SourceIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_SourceIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x0600C41E RID: 50206 RVA: 0x0031D19C File Offset: 0x0031B39C
		// (set) Token: 0x0600C41F RID: 50207 RVA: 0x0005C739 File Offset: 0x0005A939
		public unsafe TextMeshProUGUI SourceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_SourceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_SourceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x0600C420 RID: 50208 RVA: 0x0031D1CC File Offset: 0x0031B3CC
		// (set) Token: 0x0600C421 RID: 50209 RVA: 0x0005C758 File Offset: 0x0005A958
		public unsafe Image DestinationIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_DestinationIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_DestinationIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x0600C422 RID: 50210 RVA: 0x0031D1FC File Offset: 0x0031B3FC
		// (set) Token: 0x0600C423 RID: 50211 RVA: 0x0005C777 File Offset: 0x0005A977
		public unsafe TextMeshProUGUI DestinationLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_DestinationLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_DestinationLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x0600C424 RID: 50212 RVA: 0x0031D22C File Offset: 0x0031B42C
		// (set) Token: 0x0600C425 RID: 50213 RVA: 0x0005C796 File Offset: 0x0005A996
		public unsafe Image FilterIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_FilterIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_FilterIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x0600C426 RID: 50214 RVA: 0x0031D25C File Offset: 0x0031B45C
		// (set) Token: 0x0600C427 RID: 50215 RVA: 0x0005C7B5 File Offset: 0x0005A9B5
		public unsafe UnityEvent onDeleteClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_onDeleteClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003B86 RID: 15238
		// (get) Token: 0x0600C428 RID: 50216 RVA: 0x0031D28C File Offset: 0x0031B48C
		// (set) Token: 0x0600C429 RID: 50217 RVA: 0x0005C7D4 File Offset: 0x0005A9D4
		public unsafe bool settingSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingSource)) = value;
			}
		}

		// Token: 0x17003B87 RID: 15239
		// (get) Token: 0x0600C42A RID: 50218 RVA: 0x0031D2B4 File Offset: 0x0031B4B4
		// (set) Token: 0x0600C42B RID: 50219 RVA: 0x0005C7EF File Offset: 0x0005A9EF
		public unsafe bool settingDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteEntryUI.NativeFieldInfoPtr_settingDestination)) = value;
			}
		}

		// Token: 0x040085D7 RID: 34263
		private static readonly IntPtr NativeFieldInfoPtr__AssignedRoute_k__BackingField;

		// Token: 0x040085D8 RID: 34264
		private static readonly IntPtr NativeFieldInfoPtr_SourceIcon;

		// Token: 0x040085D9 RID: 34265
		private static readonly IntPtr NativeFieldInfoPtr_SourceLabel;

		// Token: 0x040085DA RID: 34266
		private static readonly IntPtr NativeFieldInfoPtr_DestinationIcon;

		// Token: 0x040085DB RID: 34267
		private static readonly IntPtr NativeFieldInfoPtr_DestinationLabel;

		// Token: 0x040085DC RID: 34268
		private static readonly IntPtr NativeFieldInfoPtr_FilterIcon;

		// Token: 0x040085DD RID: 34269
		private static readonly IntPtr NativeFieldInfoPtr_onDeleteClicked;

		// Token: 0x040085DE RID: 34270
		private static readonly IntPtr NativeFieldInfoPtr_settingSource;

		// Token: 0x040085DF RID: 34271
		private static readonly IntPtr NativeFieldInfoPtr_settingDestination;

		// Token: 0x040085E0 RID: 34272
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedRoute_Public_get_AdvancedTransitRoute_0;

		// Token: 0x040085E1 RID: 34273
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedRoute_Private_set_Void_AdvancedTransitRoute_0;

		// Token: 0x040085E2 RID: 34274
		private static readonly IntPtr NativeMethodInfoPtr_AssignRoute_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x040085E3 RID: 34275
		private static readonly IntPtr NativeMethodInfoPtr_ClearRoute_Public_Void_0;

		// Token: 0x040085E4 RID: 34276
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Public_Void_0;

		// Token: 0x040085E5 RID: 34277
		private static readonly IntPtr NativeMethodInfoPtr_SourceClicked_Public_Void_0;

		// Token: 0x040085E6 RID: 34278
		private static readonly IntPtr NativeMethodInfoPtr_DestinationClicked_Public_Void_0;

		// Token: 0x040085E7 RID: 34279
		private static readonly IntPtr NativeMethodInfoPtr_FilterClicked_Public_Void_0;

		// Token: 0x040085E8 RID: 34280
		private static readonly IntPtr NativeMethodInfoPtr_DeleteClicked_Public_Void_0;

		// Token: 0x040085E9 RID: 34281
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValid_Private_Boolean_ITransitEntity_byref_String_0;

		// Token: 0x040085EA RID: 34282
		private static readonly IntPtr NativeMethodInfoPtr_ObjectsSelected_Public_Void_List_1_ITransitEntity_0;

		// Token: 0x040085EB RID: 34283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

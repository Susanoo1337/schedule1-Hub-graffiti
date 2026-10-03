using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000761 RID: 1889
	public class TabController : MonoBehaviour
	{
		// Token: 0x0600B81F RID: 47135 RVA: 0x002F8E04 File Offset: 0x002F7004
		// Note: this type is marked as 'beforefieldinit'.
		static TabController()
		{
			Il2CppClassPointerStore<TabController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TabController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabController>.NativeClassPtr);
			TabController.NativeFieldInfoPtr__tabIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_tabIndicator");
			TabController.NativeFieldInfoPtr__tabItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_tabItems");
			TabController.NativeFieldInfoPtr__indicatorMoveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_indicatorMoveTime");
			TabController.NativeFieldInfoPtr__allowLoopingNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_allowLoopingNavigation");
			TabController.NativeFieldInfoPtr__indicatorMoveCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_indicatorMoveCurve");
			TabController.NativeFieldInfoPtr__tabColorFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_tabColorFont");
			TabController.NativeFieldInfoPtr__screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_screen");
			TabController.NativeFieldInfoPtr__uiTab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_uiTab");
			TabController.NativeFieldInfoPtr__currentTabIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_currentTabIndex");
			TabController.NativeFieldInfoPtr__indicatorPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_indicatorPosition");
			TabController.NativeFieldInfoPtr__moveIndicatorCo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_moveIndicatorCo");
			TabController.NativeFieldInfoPtr__onTabSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController>.NativeClassPtr, "_onTabSelected");
			TabController.NativeMethodInfoPtr_get_CurrentTabIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687388);
			TabController.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687389);
			TabController.NativeMethodInfoPtr_SetTab_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687390);
			TabController.NativeMethodInfoPtr_SetToSelectedTab_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687391);
			TabController.NativeMethodInfoPtr_SetTab_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687392);
			TabController.NativeMethodInfoPtr_DoMoveTabIndicatorRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687393);
			TabController.NativeMethodInfoPtr_SetTabIndicatorText_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687394);
			TabController.NativeMethodInfoPtr_HideTabIndicator_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687395);
			TabController.NativeMethodInfoPtr_GetLoopedIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687396);
			TabController.NativeMethodInfoPtr_GetClampedIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687397);
			TabController.NativeMethodInfoPtr_SubscribeToTabSelected_Public_Void_TabSelectedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687398);
			TabController.NativeMethodInfoPtr_UnsubscribeFromTabSelected_Public_Void_TabSelectedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687399);
			TabController.NativeMethodInfoPtr_DoDelayRoutine_Private_IEnumerator_Single_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687400);
			TabController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController>.NativeClassPtr, 100687401);
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x0600B820 RID: 47136 RVA: 0x002F903C File Offset: 0x002F723C
		public unsafe int CurrentTabIndex
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 42871, RefRangeEnd = 42874, XrefRangeStart = 42871, XrefRangeEnd = 42874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_get_CurrentTabIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B821 RID: 47137 RVA: 0x002F9078 File Offset: 0x002F7278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308897, XrefRangeEnd = 308916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B822 RID: 47138 RVA: 0x002F90AC File Offset: 0x002F72AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308916, XrefRangeEnd = 308917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTab(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_SetTab_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B823 RID: 47139 RVA: 0x002F90EC File Offset: 0x002F72EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308918, RefRangeEnd = 308919, XrefRangeStart = 308917, XrefRangeEnd = 308918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToSelectedTab(bool instantIndicatorMove = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref instantIndicatorMove;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_SetToSelectedTab_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B824 RID: 47140 RVA: 0x002F912C File Offset: 0x002F732C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 308975, RefRangeEnd = 308979, XrefRangeStart = 308919, XrefRangeEnd = 308975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTab(int index, bool instantIndicatorMove = false, bool forceUpdateUI = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantIndicatorMove;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceUpdateUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_SetTab_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B825 RID: 47141 RVA: 0x002F9188 File Offset: 0x002F7388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308979, XrefRangeEnd = 308984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoMoveTabIndicatorRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_DoMoveTabIndicatorRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B826 RID: 47142 RVA: 0x002F91C8 File Offset: 0x002F73C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308984, XrefRangeEnd = 308991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTabIndicatorText(int index, string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_SetTabIndicatorText_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B827 RID: 47143 RVA: 0x002F9218 File Offset: 0x002F7418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308998, RefRangeEnd = 308999, XrefRangeStart = 308991, XrefRangeEnd = 308998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideTabIndicator(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_HideTabIndicator_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B828 RID: 47144 RVA: 0x002F9258 File Offset: 0x002F7458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308999, XrefRangeEnd = 309000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLoopedIndex(int dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_GetLoopedIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B829 RID: 47145 RVA: 0x002F92A4 File Offset: 0x002F74A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309000, XrefRangeEnd = 309001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetClampedIndex(int dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_GetClampedIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B82A RID: 47146 RVA: 0x002F92F0 File Offset: 0x002F74F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309009, RefRangeEnd = 309010, XrefRangeStart = 309001, XrefRangeEnd = 309009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToTabSelected(TabSelectedEvent handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_SubscribeToTabSelected_Public_Void_TabSelectedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B82B RID: 47147 RVA: 0x002F9334 File Offset: 0x002F7534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309010, XrefRangeEnd = 309018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromTabSelected(TabSelectedEvent handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_UnsubscribeFromTabSelected_Public_Void_TabSelectedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B82C RID: 47148 RVA: 0x002F9378 File Offset: 0x002F7578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309018, XrefRangeEnd = 309023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoDelayRoutine(float delay, Action onComplete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delay;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr_DoDelayRoutine_Private_IEnumerator_Single_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B82D RID: 47149 RVA: 0x002F93D8 File Offset: 0x002F75D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309023, XrefRangeEnd = 309026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TabController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B82E RID: 47150 RVA: 0x000558F6 File Offset: 0x00053AF6
		public TabController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0600B82F RID: 47151 RVA: 0x002F9414 File Offset: 0x002F7614
		// (set) Token: 0x0600B830 RID: 47152 RVA: 0x000558FF File Offset: 0x00053AFF
		public unsafe RectTransform _tabIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__tabIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__tabIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x0600B831 RID: 47153 RVA: 0x002F9444 File Offset: 0x002F7644
		// (set) Token: 0x0600B832 RID: 47154 RVA: 0x0005591E File Offset: 0x00053B1E
		public unsafe List<TabItemUI> _tabItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__tabItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TabItemUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__tabItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x0600B833 RID: 47155 RVA: 0x002F9474 File Offset: 0x002F7674
		// (set) Token: 0x0600B834 RID: 47156 RVA: 0x0005593D File Offset: 0x00053B3D
		public unsafe float _indicatorMoveTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__indicatorMoveTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__indicatorMoveTime)) = value;
			}
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x0600B835 RID: 47157 RVA: 0x002F949C File Offset: 0x002F769C
		// (set) Token: 0x0600B836 RID: 47158 RVA: 0x00055958 File Offset: 0x00053B58
		public unsafe bool _allowLoopingNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__allowLoopingNavigation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__allowLoopingNavigation)) = value;
			}
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x0600B837 RID: 47159 RVA: 0x002F94C4 File Offset: 0x002F76C4
		// (set) Token: 0x0600B838 RID: 47160 RVA: 0x00055973 File Offset: 0x00053B73
		public unsafe AnimationCurve _indicatorMoveCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__indicatorMoveCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__indicatorMoveCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x0600B839 RID: 47161 RVA: 0x002F94F4 File Offset: 0x002F76F4
		// (set) Token: 0x0600B83A RID: 47162 RVA: 0x00055992 File Offset: 0x00053B92
		public unsafe ColorFont _tabColorFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__tabColorFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__tabColorFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0600B83B RID: 47163 RVA: 0x002F9524 File Offset: 0x002F7724
		// (set) Token: 0x0600B83C RID: 47164 RVA: 0x000559B1 File Offset: 0x00053BB1
		public unsafe UIScreen _screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0600B83D RID: 47165 RVA: 0x002F9554 File Offset: 0x002F7754
		// (set) Token: 0x0600B83E RID: 47166 RVA: 0x000559D0 File Offset: 0x00053BD0
		public unsafe UITab _uiTab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__uiTab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITab>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__uiTab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0600B83F RID: 47167 RVA: 0x002F9584 File Offset: 0x002F7784
		// (set) Token: 0x0600B840 RID: 47168 RVA: 0x000559EF File Offset: 0x00053BEF
		public unsafe int _currentTabIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__currentTabIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__currentTabIndex)) = value;
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x0600B841 RID: 47169 RVA: 0x002F95AC File Offset: 0x002F77AC
		// (set) Token: 0x0600B842 RID: 47170 RVA: 0x00055A0A File Offset: 0x00053C0A
		public unsafe Vector2 _indicatorPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__indicatorPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__indicatorPosition)) = value;
			}
		}

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x0600B843 RID: 47171 RVA: 0x002F95D4 File Offset: 0x002F77D4
		// (set) Token: 0x0600B844 RID: 47172 RVA: 0x00055A25 File Offset: 0x00053C25
		public unsafe Coroutine _moveIndicatorCo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__moveIndicatorCo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__moveIndicatorCo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x0600B845 RID: 47173 RVA: 0x002F9604 File Offset: 0x002F7804
		// (set) Token: 0x0600B846 RID: 47174 RVA: 0x00055A44 File Offset: 0x00053C44
		public unsafe TabSelectedEvent _onTabSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__onTabSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TabSelectedEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.NativeFieldInfoPtr__onTabSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007E6E RID: 32366
		private static readonly IntPtr NativeFieldInfoPtr__tabIndicator;

		// Token: 0x04007E6F RID: 32367
		private static readonly IntPtr NativeFieldInfoPtr__tabItems;

		// Token: 0x04007E70 RID: 32368
		private static readonly IntPtr NativeFieldInfoPtr__indicatorMoveTime;

		// Token: 0x04007E71 RID: 32369
		private static readonly IntPtr NativeFieldInfoPtr__allowLoopingNavigation;

		// Token: 0x04007E72 RID: 32370
		private static readonly IntPtr NativeFieldInfoPtr__indicatorMoveCurve;

		// Token: 0x04007E73 RID: 32371
		private static readonly IntPtr NativeFieldInfoPtr__tabColorFont;

		// Token: 0x04007E74 RID: 32372
		private static readonly IntPtr NativeFieldInfoPtr__screen;

		// Token: 0x04007E75 RID: 32373
		private static readonly IntPtr NativeFieldInfoPtr__uiTab;

		// Token: 0x04007E76 RID: 32374
		private static readonly IntPtr NativeFieldInfoPtr__currentTabIndex;

		// Token: 0x04007E77 RID: 32375
		private static readonly IntPtr NativeFieldInfoPtr__indicatorPosition;

		// Token: 0x04007E78 RID: 32376
		private static readonly IntPtr NativeFieldInfoPtr__moveIndicatorCo;

		// Token: 0x04007E79 RID: 32377
		private static readonly IntPtr NativeFieldInfoPtr__onTabSelected;

		// Token: 0x04007E7A RID: 32378
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTabIndex_Public_get_Int32_0;

		// Token: 0x04007E7B RID: 32379
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04007E7C RID: 32380
		private static readonly IntPtr NativeMethodInfoPtr_SetTab_Private_Void_Int32_0;

		// Token: 0x04007E7D RID: 32381
		private static readonly IntPtr NativeMethodInfoPtr_SetToSelectedTab_Public_Void_Boolean_0;

		// Token: 0x04007E7E RID: 32382
		private static readonly IntPtr NativeMethodInfoPtr_SetTab_Public_Void_Int32_Boolean_Boolean_0;

		// Token: 0x04007E7F RID: 32383
		private static readonly IntPtr NativeMethodInfoPtr_DoMoveTabIndicatorRoutine_Private_IEnumerator_0;

		// Token: 0x04007E80 RID: 32384
		private static readonly IntPtr NativeMethodInfoPtr_SetTabIndicatorText_Public_Void_Int32_String_0;

		// Token: 0x04007E81 RID: 32385
		private static readonly IntPtr NativeMethodInfoPtr_HideTabIndicator_Public_Void_Int32_0;

		// Token: 0x04007E82 RID: 32386
		private static readonly IntPtr NativeMethodInfoPtr_GetLoopedIndex_Private_Int32_Int32_0;

		// Token: 0x04007E83 RID: 32387
		private static readonly IntPtr NativeMethodInfoPtr_GetClampedIndex_Private_Int32_Int32_0;

		// Token: 0x04007E84 RID: 32388
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToTabSelected_Public_Void_TabSelectedEvent_0;

		// Token: 0x04007E85 RID: 32389
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromTabSelected_Public_Void_TabSelectedEvent_0;

		// Token: 0x04007E86 RID: 32390
		private static readonly IntPtr NativeMethodInfoPtr_DoDelayRoutine_Private_IEnumerator_Single_Action_0;

		// Token: 0x04007E87 RID: 32391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CF5 RID: 3317
		[ObfuscatedName("ScheduleOne.UI.TabController+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F6D5 RID: 63189 RVA: 0x003B3380 File Offset: 0x003B1580
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<TabController.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TabController>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabController.__c__DisplayClass17_0>.NativeClassPtr);
				TabController.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				TabController.__c__DisplayClass17_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController.__c__DisplayClass17_0>.NativeClassPtr, "index");
				TabController.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController.__c__DisplayClass17_0>.NativeClassPtr, 100687402);
				TabController.__c__DisplayClass17_0.NativeMethodInfoPtr__SetTab_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController.__c__DisplayClass17_0>.NativeClassPtr, 100687403);
			}

			// Token: 0x0600F6D6 RID: 63190 RVA: 0x003B33FC File Offset: 0x003B15FC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabController.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6D7 RID: 63191 RVA: 0x003B3438 File Offset: 0x003B1638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308861, XrefRangeEnd = 308871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetTab_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController.__c__DisplayClass17_0.NativeMethodInfoPtr__SetTab_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6D8 RID: 63192 RVA: 0x00074B52 File Offset: 0x00072D52
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B0F RID: 19215
			// (get) Token: 0x0600F6D9 RID: 63193 RVA: 0x003B346C File Offset: 0x003B166C
			// (set) Token: 0x0600F6DA RID: 63194 RVA: 0x00074B5B File Offset: 0x00072D5B
			public unsafe TabController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TabController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B10 RID: 19216
			// (get) Token: 0x0600F6DB RID: 63195 RVA: 0x003B349C File Offset: 0x003B169C
			// (set) Token: 0x0600F6DC RID: 63196 RVA: 0x00074B7A File Offset: 0x00072D7A
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.__c__DisplayClass17_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController.__c__DisplayClass17_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x0400A6F9 RID: 42745
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A6FA RID: 42746
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400A6FB RID: 42747
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A6FC RID: 42748
			private static readonly IntPtr NativeMethodInfoPtr__SetTab_b__0_Internal_Void_0;
		}

		// Token: 0x02000CF6 RID: 3318
		[ObfuscatedName("ScheduleOne.UI.TabController+<DoDelayRoutine>d__25")]
		public sealed class _DoDelayRoutine_d__25 : Il2CppSystem.Object
		{
			// Token: 0x0600F6DD RID: 63197 RVA: 0x003B34C4 File Offset: 0x003B16C4
			// Note: this type is marked as 'beforefieldinit'.
			static _DoDelayRoutine_d__25()
			{
				Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TabController>.NativeClassPtr, "<DoDelayRoutine>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr);
				TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr, "<>1__state");
				TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr, "<>2__current");
				TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr, "delay");
				TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr, "onComplete");
				TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr, 100687404);
				TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr, 100687405);
				TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr, 100687406);
				TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr, 100687407);
				TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr, 100687408);
				TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr, 100687409);
			}

			// Token: 0x0600F6DE RID: 63198 RVA: 0x003B35B8 File Offset: 0x003B17B8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoDelayRoutine_d__25(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabController._DoDelayRoutine_d__25>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6DF RID: 63199 RVA: 0x003B3600 File Offset: 0x003B1800
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6E0 RID: 63200 RVA: 0x003B3634 File Offset: 0x003B1834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308871, XrefRangeEnd = 308876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004B15 RID: 19221
			// (get) Token: 0x0600F6E1 RID: 63201 RVA: 0x003B3670 File Offset: 0x003B1870
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F6E2 RID: 63202 RVA: 0x003B36B0 File Offset: 0x003B18B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308876, XrefRangeEnd = 308881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B16 RID: 19222
			// (get) Token: 0x0600F6E3 RID: 63203 RVA: 0x003B36E4 File Offset: 0x003B18E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoDelayRoutine_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F6E4 RID: 63204 RVA: 0x00074B95 File Offset: 0x00072D95
			public _DoDelayRoutine_d__25(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B11 RID: 19217
			// (get) Token: 0x0600F6E5 RID: 63205 RVA: 0x003B3724 File Offset: 0x003B1924
			// (set) Token: 0x0600F6E6 RID: 63206 RVA: 0x00074B9E File Offset: 0x00072D9E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B12 RID: 19218
			// (get) Token: 0x0600F6E7 RID: 63207 RVA: 0x003B374C File Offset: 0x003B194C
			// (set) Token: 0x0600F6E8 RID: 63208 RVA: 0x00074BB9 File Offset: 0x00072DB9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B13 RID: 19219
			// (get) Token: 0x0600F6E9 RID: 63209 RVA: 0x003B377C File Offset: 0x003B197C
			// (set) Token: 0x0600F6EA RID: 63210 RVA: 0x00074BD8 File Offset: 0x00072DD8
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17004B14 RID: 19220
			// (get) Token: 0x0600F6EB RID: 63211 RVA: 0x003B37A4 File Offset: 0x003B19A4
			// (set) Token: 0x0600F6EC RID: 63212 RVA: 0x00074BF3 File Offset: 0x00072DF3
			public unsafe Action onComplete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr_onComplete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoDelayRoutine_d__25.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A6FD RID: 42749
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A6FE RID: 42750
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A6FF RID: 42751
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x0400A700 RID: 42752
			private static readonly IntPtr NativeFieldInfoPtr_onComplete;

			// Token: 0x0400A701 RID: 42753
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A702 RID: 42754
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A703 RID: 42755
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A704 RID: 42756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A705 RID: 42757
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A706 RID: 42758
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CF7 RID: 3319
		[ObfuscatedName("ScheduleOne.UI.TabController+<DoMoveTabIndicatorRoutine>d__18")]
		public sealed class _DoMoveTabIndicatorRoutine_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600F6ED RID: 63213 RVA: 0x003B37D4 File Offset: 0x003B19D4
			// Note: this type is marked as 'beforefieldinit'.
			static _DoMoveTabIndicatorRoutine_d__18()
			{
				Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TabController>.NativeClassPtr, "<DoMoveTabIndicatorRoutine>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr);
				TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr, "<>1__state");
				TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr, "<>2__current");
				TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr, "<>4__this");
				TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr__elapsed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr, "<elapsed>5__2");
				TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr__startingPosition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr, "<startingPosition>5__3");
				TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr, 100687410);
				TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr, 100687411);
				TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr, 100687412);
				TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr, 100687413);
				TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr, 100687414);
				TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr, 100687415);
			}

			// Token: 0x0600F6EE RID: 63214 RVA: 0x003B38DC File Offset: 0x003B1ADC
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoMoveTabIndicatorRoutine_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TabController._DoMoveTabIndicatorRoutine_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6EF RID: 63215 RVA: 0x003B3924 File Offset: 0x003B1B24
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6F0 RID: 63216 RVA: 0x003B3958 File Offset: 0x003B1B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308881, XrefRangeEnd = 308892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004B1C RID: 19228
			// (get) Token: 0x0600F6F1 RID: 63217 RVA: 0x003B3994 File Offset: 0x003B1B94
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F6F2 RID: 63218 RVA: 0x003B39D4 File Offset: 0x003B1BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308892, XrefRangeEnd = 308897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B1D RID: 19229
			// (get) Token: 0x0600F6F3 RID: 63219 RVA: 0x003B3A08 File Offset: 0x003B1C08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TabController._DoMoveTabIndicatorRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F6F4 RID: 63220 RVA: 0x00074C12 File Offset: 0x00072E12
			public _DoMoveTabIndicatorRoutine_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B17 RID: 19223
			// (get) Token: 0x0600F6F5 RID: 63221 RVA: 0x003B3A48 File Offset: 0x003B1C48
			// (set) Token: 0x0600F6F6 RID: 63222 RVA: 0x00074C1B File Offset: 0x00072E1B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B18 RID: 19224
			// (get) Token: 0x0600F6F7 RID: 63223 RVA: 0x003B3A70 File Offset: 0x003B1C70
			// (set) Token: 0x0600F6F8 RID: 63224 RVA: 0x00074C36 File Offset: 0x00072E36
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B19 RID: 19225
			// (get) Token: 0x0600F6F9 RID: 63225 RVA: 0x003B3AA0 File Offset: 0x003B1CA0
			// (set) Token: 0x0600F6FA RID: 63226 RVA: 0x00074C55 File Offset: 0x00072E55
			public unsafe TabController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TabController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B1A RID: 19226
			// (get) Token: 0x0600F6FB RID: 63227 RVA: 0x003B3AD0 File Offset: 0x003B1CD0
			// (set) Token: 0x0600F6FC RID: 63228 RVA: 0x00074C74 File Offset: 0x00072E74
			public unsafe float _elapsed_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr__elapsed_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr__elapsed_5__2)) = value;
				}
			}

			// Token: 0x17004B1B RID: 19227
			// (get) Token: 0x0600F6FD RID: 63229 RVA: 0x003B3AF8 File Offset: 0x003B1CF8
			// (set) Token: 0x0600F6FE RID: 63230 RVA: 0x00074C8F File Offset: 0x00072E8F
			public unsafe Vector2 _startingPosition_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr__startingPosition_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TabController._DoMoveTabIndicatorRoutine_d__18.NativeFieldInfoPtr__startingPosition_5__3)) = value;
				}
			}

			// Token: 0x0400A707 RID: 42759
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A708 RID: 42760
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A709 RID: 42761
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A70A RID: 42762
			private static readonly IntPtr NativeFieldInfoPtr__elapsed_5__2;

			// Token: 0x0400A70B RID: 42763
			private static readonly IntPtr NativeFieldInfoPtr__startingPosition_5__3;

			// Token: 0x0400A70C RID: 42764
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A70D RID: 42765
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A70E RID: 42766
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A70F RID: 42767
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A710 RID: 42768
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A711 RID: 42769
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}

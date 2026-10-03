using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000727 RID: 1831
	public class CyclerController : MonoBehaviour
	{
		// Token: 0x0600B06B RID: 45163 RVA: 0x002E1DD4 File Offset: 0x002DFFD4
		// Note: this type is marked as 'beforefieldinit'.
		static CyclerController()
		{
			Il2CppClassPointerStore<CyclerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CyclerController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CyclerController>.NativeClassPtr);
			CyclerController.NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, "_label");
			CyclerController.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, "_items");
			CyclerController.NativeFieldInfoPtr__allowLoopingNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, "_allowLoopingNavigation");
			CyclerController.NativeFieldInfoPtr__screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, "_screen");
			CyclerController.NativeFieldInfoPtr__currentItemIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, "_currentItemIndex");
			CyclerController.NativeFieldInfoPtr__onCycleItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, "_onCycleItem");
			CyclerController.NativeFieldInfoPtr__wasTriggeredLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, "_wasTriggeredLastFrame");
			CyclerController.NativeFieldInfoPtr__triggerTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, "_triggerTimer");
			CyclerController.NativeMethodInfoPtr_get_CurrentItemIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686497);
			CyclerController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686498);
			CyclerController.NativeMethodInfoPtr_CycleItem_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686499);
			CyclerController.NativeMethodInfoPtr_SetItem_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686500);
			CyclerController.NativeMethodInfoPtr_SetToSelectedItem_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686501);
			CyclerController.NativeMethodInfoPtr_SetItem_Public_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686502);
			CyclerController.NativeMethodInfoPtr_SetLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686503);
			CyclerController.NativeMethodInfoPtr_GetLoopedIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686504);
			CyclerController.NativeMethodInfoPtr_GetClampedIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686505);
			CyclerController.NativeMethodInfoPtr_SubscribeToCyclerEvent_Public_Void_CyclerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686506);
			CyclerController.NativeMethodInfoPtr_UnsubscribeFromCyclerEvent_Public_Void_CyclerEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686507);
			CyclerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CyclerController>.NativeClassPtr, 100686508);
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0600B06C RID: 45164 RVA: 0x002E1F94 File Offset: 0x002E0194
		public unsafe int CurrentItemIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr_get_CurrentItemIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B06D RID: 45165 RVA: 0x002E1FD0 File Offset: 0x002E01D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299962, XrefRangeEnd = 299987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B06E RID: 45166 RVA: 0x002E2004 File Offset: 0x002E0204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 299991, RefRangeEnd = 299992, XrefRangeStart = 299987, XrefRangeEnd = 299991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CycleItem(int dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr_CycleItem_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B06F RID: 45167 RVA: 0x002E2044 File Offset: 0x002E0244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299992, XrefRangeEnd = 299993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItem(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr_SetItem_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B070 RID: 45168 RVA: 0x002E2084 File Offset: 0x002E0284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 299993, XrefRangeEnd = 299994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToSelectedItem(bool instantIndicatorMove = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref instantIndicatorMove;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr_SetToSelectedItem_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B071 RID: 45169 RVA: 0x002E20C4 File Offset: 0x002E02C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 300010, RefRangeEnd = 300014, XrefRangeStart = 299994, XrefRangeEnd = 300010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItem(int index, bool instantIndicatorMove = false, bool forceUpdateUI = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantIndicatorMove;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceUpdateUI;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr_SetItem_Public_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B072 RID: 45170 RVA: 0x002E2120 File Offset: 0x002E0320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300014, XrefRangeEnd = 300018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLabel(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr_SetLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B073 RID: 45171 RVA: 0x002E2164 File Offset: 0x002E0364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300018, XrefRangeEnd = 300019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLoopedIndex(int dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr_GetLoopedIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B074 RID: 45172 RVA: 0x002E21B0 File Offset: 0x002E03B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300019, XrefRangeEnd = 300020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetClampedIndex(int dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr_GetClampedIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B075 RID: 45173 RVA: 0x002E21FC File Offset: 0x002E03FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300028, RefRangeEnd = 300029, XrefRangeStart = 300020, XrefRangeEnd = 300028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToCyclerEvent(CyclerEvent handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr_SubscribeToCyclerEvent_Public_Void_CyclerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B076 RID: 45174 RVA: 0x002E2240 File Offset: 0x002E0440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300029, XrefRangeEnd = 300037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromCyclerEvent(CyclerEvent handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr_UnsubscribeFromCyclerEvent_Public_Void_CyclerEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B077 RID: 45175 RVA: 0x002E2284 File Offset: 0x002E0484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 300037, XrefRangeEnd = 300038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CyclerController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CyclerController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CyclerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B078 RID: 45176 RVA: 0x00051026 File Offset: 0x0004F226
		public CyclerController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034FB RID: 13563
		// (get) Token: 0x0600B079 RID: 45177 RVA: 0x002E22C0 File Offset: 0x002E04C0
		// (set) Token: 0x0600B07A RID: 45178 RVA: 0x0005102F File Offset: 0x0004F22F
		public unsafe Text _label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FC RID: 13564
		// (get) Token: 0x0600B07B RID: 45179 RVA: 0x002E22F0 File Offset: 0x002E04F0
		// (set) Token: 0x0600B07C RID: 45180 RVA: 0x0005104E File Offset: 0x0004F24E
		public unsafe List<CyclerItemUI> _items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CyclerItemUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FD RID: 13565
		// (get) Token: 0x0600B07D RID: 45181 RVA: 0x002E2320 File Offset: 0x002E0520
		// (set) Token: 0x0600B07E RID: 45182 RVA: 0x0005106D File Offset: 0x0004F26D
		public unsafe bool _allowLoopingNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__allowLoopingNavigation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__allowLoopingNavigation)) = value;
			}
		}

		// Token: 0x170034FE RID: 13566
		// (get) Token: 0x0600B07F RID: 45183 RVA: 0x002E2348 File Offset: 0x002E0548
		// (set) Token: 0x0600B080 RID: 45184 RVA: 0x00051088 File Offset: 0x0004F288
		public unsafe UIScreen _screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0600B081 RID: 45185 RVA: 0x002E2378 File Offset: 0x002E0578
		// (set) Token: 0x0600B082 RID: 45186 RVA: 0x000510A7 File Offset: 0x0004F2A7
		public unsafe int _currentItemIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__currentItemIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__currentItemIndex)) = value;
			}
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0600B083 RID: 45187 RVA: 0x002E23A0 File Offset: 0x002E05A0
		// (set) Token: 0x0600B084 RID: 45188 RVA: 0x000510C2 File Offset: 0x0004F2C2
		public unsafe CyclerEvent _onCycleItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__onCycleItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CyclerEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__onCycleItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600B085 RID: 45189 RVA: 0x002E23D0 File Offset: 0x002E05D0
		// (set) Token: 0x0600B086 RID: 45190 RVA: 0x000510E1 File Offset: 0x0004F2E1
		public unsafe bool _wasTriggeredLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__wasTriggeredLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__wasTriggeredLastFrame)) = value;
			}
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600B087 RID: 45191 RVA: 0x002E23F8 File Offset: 0x002E05F8
		// (set) Token: 0x0600B088 RID: 45192 RVA: 0x000510FC File Offset: 0x0004F2FC
		public unsafe float _triggerTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__triggerTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CyclerController.NativeFieldInfoPtr__triggerTimer)) = value;
			}
		}

		// Token: 0x04007997 RID: 31127
		private static readonly IntPtr NativeFieldInfoPtr__label;

		// Token: 0x04007998 RID: 31128
		private static readonly IntPtr NativeFieldInfoPtr__items;

		// Token: 0x04007999 RID: 31129
		private static readonly IntPtr NativeFieldInfoPtr__allowLoopingNavigation;

		// Token: 0x0400799A RID: 31130
		private static readonly IntPtr NativeFieldInfoPtr__screen;

		// Token: 0x0400799B RID: 31131
		private static readonly IntPtr NativeFieldInfoPtr__currentItemIndex;

		// Token: 0x0400799C RID: 31132
		private static readonly IntPtr NativeFieldInfoPtr__onCycleItem;

		// Token: 0x0400799D RID: 31133
		private static readonly IntPtr NativeFieldInfoPtr__wasTriggeredLastFrame;

		// Token: 0x0400799E RID: 31134
		private static readonly IntPtr NativeFieldInfoPtr__triggerTimer;

		// Token: 0x0400799F RID: 31135
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentItemIndex_Public_get_Int32_0;

		// Token: 0x040079A0 RID: 31136
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040079A1 RID: 31137
		private static readonly IntPtr NativeMethodInfoPtr_CycleItem_Private_Void_Int32_0;

		// Token: 0x040079A2 RID: 31138
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Private_Void_Int32_0;

		// Token: 0x040079A3 RID: 31139
		private static readonly IntPtr NativeMethodInfoPtr_SetToSelectedItem_Public_Void_Boolean_0;

		// Token: 0x040079A4 RID: 31140
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Public_Void_Int32_Boolean_Boolean_0;

		// Token: 0x040079A5 RID: 31141
		private static readonly IntPtr NativeMethodInfoPtr_SetLabel_Public_Void_String_0;

		// Token: 0x040079A6 RID: 31142
		private static readonly IntPtr NativeMethodInfoPtr_GetLoopedIndex_Private_Int32_Int32_0;

		// Token: 0x040079A7 RID: 31143
		private static readonly IntPtr NativeMethodInfoPtr_GetClampedIndex_Private_Int32_Int32_0;

		// Token: 0x040079A8 RID: 31144
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToCyclerEvent_Public_Void_CyclerEvent_0;

		// Token: 0x040079A9 RID: 31145
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromCyclerEvent_Public_Void_CyclerEvent_0;

		// Token: 0x040079AA RID: 31146
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x0200009D RID: 157
	public class DebugInterface : MonoBehaviour
	{
		// Token: 0x06000D74 RID: 3444 RVA: 0x000A8400 File Offset: 0x000A6600
		// Note: this type is marked as 'beforefieldinit'.
		static DebugInterface()
		{
			Il2CppClassPointerStore<DebugInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "DebugInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr);
			DebugInterface.NativeFieldInfoPtr_MainScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "MainScreen");
			DebugInterface.NativeFieldInfoPtr_SecondScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "SecondScreen");
			DebugInterface.NativeFieldInfoPtr_GridPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "GridPanel");
			DebugInterface.NativeFieldInfoPtr_GridPanelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "GridPanelContainer");
			DebugInterface.NativeFieldInfoPtr_ButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "ButtonPrefab");
			DebugInterface.NativeFieldInfoPtr_horizontalPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "horizontalPanel");
			DebugInterface.NativeFieldInfoPtr_DebugText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "DebugText");
			DebugInterface.NativeFieldInfoPtr_testHorizontalSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "testHorizontalSelector");
			DebugInterface.NativeFieldInfoPtr_testPopupSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "testPopupSelector");
			DebugInterface.NativeFieldInfoPtr_testIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "testIcon");
			DebugInterface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, 100665006);
			DebugInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, 100665007);
			DebugInterface.NativeMethodInfoPtr_OpenConfirmationMenu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, 100665008);
			DebugInterface.NativeMethodInfoPtr_OpenModifyAmountMenu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, 100665009);
			DebugInterface.NativeMethodInfoPtr_SetupGridPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, 100665010);
			DebugInterface.NativeMethodInfoPtr_ApplyFilter_Public_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, 100665011);
			DebugInterface.NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, 100665012);
			DebugInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, 100665013);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000A8598 File Offset: 0x000A6798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80047, XrefRangeEnd = 80203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x000A85CC File Offset: 0x000A67CC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x000A8600 File Offset: 0x000A6800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80203, XrefRangeEnd = 80264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenConfirmationMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.NativeMethodInfoPtr_OpenConfirmationMenu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000A8634 File Offset: 0x000A6834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80264, XrefRangeEnd = 80369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenModifyAmountMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.NativeMethodInfoPtr_OpenModifyAmountMenu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x000A8668 File Offset: 0x000A6868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80403, RefRangeEnd = 80404, XrefRangeStart = 80369, XrefRangeEnd = 80403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupGridPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.NativeMethodInfoPtr_SetupGridPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000A869C File Offset: 0x000A689C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80451, RefRangeEnd = 80454, XrefRangeStart = 80404, XrefRangeEnd = 80451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFilter(Il2CppStructArray<int> filters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(filters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.NativeMethodInfoPtr_ApplyFilter_Public_Void_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x000A86E0 File Offset: 0x000A68E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80454, XrefRangeEnd = 80459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000A8720 File Offset: 0x000A6920
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0000820E File Offset: 0x0000640E
		public DebugInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x000A875C File Offset: 0x000A695C
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00008217 File Offset: 0x00006417
		public unsafe UIScreen MainScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_MainScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_MainScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x000A878C File Offset: 0x000A698C
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00008236 File Offset: 0x00006436
		public unsafe UIScreen SecondScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_SecondScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_SecondScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x000A87BC File Offset: 0x000A69BC
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00008255 File Offset: 0x00006455
		public unsafe UIPanel GridPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_GridPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_GridPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x000A87EC File Offset: 0x000A69EC
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00008274 File Offset: 0x00006474
		public unsafe Transform GridPanelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_GridPanelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_GridPanelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x000A881C File Offset: 0x000A6A1C
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00008293 File Offset: 0x00006493
		public unsafe UISelectable ButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_ButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_ButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x000A884C File Offset: 0x000A6A4C
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x000082B2 File Offset: 0x000064B2
		public unsafe UIPanel horizontalPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_horizontalPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_horizontalPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x000A887C File Offset: 0x000A6A7C
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x000082D1 File Offset: 0x000064D1
		public unsafe TextMeshProUGUI DebugText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_DebugText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_DebugText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x000A88AC File Offset: 0x000A6AAC
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x000082F0 File Offset: 0x000064F0
		public unsafe UIHorizontalSelector testHorizontalSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_testHorizontalSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIHorizontalSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_testHorizontalSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x000A88DC File Offset: 0x000A6ADC
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x0000830F File Offset: 0x0000650F
		public unsafe UIPopupSelector testPopupSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_testPopupSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_testPopupSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x000A890C File Offset: 0x000A6B0C
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x0000832E File Offset: 0x0000652E
		public unsafe Sprite testIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_testIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.NativeFieldInfoPtr_testIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeFieldInfoPtr_MainScreen;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_SecondScreen;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr_GridPanel;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr_GridPanelContainer;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeFieldInfoPtr_ButtonPrefab;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeFieldInfoPtr_horizontalPanel;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeFieldInfoPtr_DebugText;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr_testHorizontalSelector;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_testPopupSelector;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_testIcon;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_OpenConfirmationMenu_Private_Void_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_OpenModifyAmountMenu_Private_Void_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_SetupGridPanel_Private_Void_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFilter_Public_Void_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008B1 RID: 2225
		[ObfuscatedName("ScheduleOne.DebugInterface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D418 RID: 54296 RVA: 0x0034DA78 File Offset: 0x0034BC78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr);
				DebugInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, "<>9");
				DebugInterface.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, "<>9__10_0");
				DebugInterface.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, "<>9__10_1");
				DebugInterface.__c.NativeFieldInfoPtr___9__10_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, "<>9__10_2");
				DebugInterface.__c.NativeFieldInfoPtr___9__10_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, "<>9__10_3");
				DebugInterface.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, "<>9__12_0");
				DebugInterface.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, "<>9__12_1");
				DebugInterface.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, "<>9__13_0");
				DebugInterface.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, "<>9__13_1");
				DebugInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, 100665015);
				DebugInterface.__c.NativeMethodInfoPtr__Start_b__10_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, 100665016);
				DebugInterface.__c.NativeMethodInfoPtr__Start_b__10_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, 100665017);
				DebugInterface.__c.NativeMethodInfoPtr__Start_b__10_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, 100665018);
				DebugInterface.__c.NativeMethodInfoPtr__Start_b__10_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, 100665019);
				DebugInterface.__c.NativeMethodInfoPtr__OpenConfirmationMenu_b__12_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, 100665020);
				DebugInterface.__c.NativeMethodInfoPtr__OpenConfirmationMenu_b__12_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, 100665021);
				DebugInterface.__c.NativeMethodInfoPtr__OpenModifyAmountMenu_b__13_0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, 100665022);
				DebugInterface.__c.NativeMethodInfoPtr__OpenModifyAmountMenu_b__13_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr, 100665023);
			}

			// Token: 0x0600D419 RID: 54297 RVA: 0x0034DC0C File Offset: 0x0034BE0C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugInterface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D41A RID: 54298 RVA: 0x0034DC48 File Offset: 0x0034BE48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79994, XrefRangeEnd = 80000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__10_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.__c.NativeMethodInfoPtr__Start_b__10_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D41B RID: 54299 RVA: 0x0034DC7C File Offset: 0x0034BE7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80000, XrefRangeEnd = 80006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__10_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.__c.NativeMethodInfoPtr__Start_b__10_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D41C RID: 54300 RVA: 0x0034DCB0 File Offset: 0x0034BEB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80006, XrefRangeEnd = 80012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__10_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.__c.NativeMethodInfoPtr__Start_b__10_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D41D RID: 54301 RVA: 0x0034DCE4 File Offset: 0x0034BEE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80012, XrefRangeEnd = 80018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__10_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.__c.NativeMethodInfoPtr__Start_b__10_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D41E RID: 54302 RVA: 0x0034DD18 File Offset: 0x0034BF18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80018, XrefRangeEnd = 80027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenConfirmationMenu_b__12_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.__c.NativeMethodInfoPtr__OpenConfirmationMenu_b__12_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D41F RID: 54303 RVA: 0x0034DD4C File Offset: 0x0034BF4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80027, XrefRangeEnd = 80033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenConfirmationMenu_b__12_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.__c.NativeMethodInfoPtr__OpenConfirmationMenu_b__12_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D420 RID: 54304 RVA: 0x0034DD80 File Offset: 0x0034BF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80033, XrefRangeEnd = 80041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenModifyAmountMenu_b__13_0(float amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.__c.NativeMethodInfoPtr__OpenModifyAmountMenu_b__13_0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D421 RID: 54305 RVA: 0x0034DDC0 File Offset: 0x0034BFC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80041, XrefRangeEnd = 80047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OpenModifyAmountMenu_b__13_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.__c.NativeMethodInfoPtr__OpenModifyAmountMenu_b__13_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D422 RID: 54306 RVA: 0x000644C0 File Offset: 0x000626C0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700408F RID: 16527
			// (get) Token: 0x0600D423 RID: 54307 RVA: 0x0034DDF4 File Offset: 0x0034BFF4
			// (set) Token: 0x0600D424 RID: 54308 RVA: 0x000644C9 File Offset: 0x000626C9
			public unsafe static DebugInterface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004090 RID: 16528
			// (get) Token: 0x0600D425 RID: 54309 RVA: 0x0034DE1C File Offset: 0x0034C01C
			// (set) Token: 0x0600D426 RID: 54310 RVA: 0x000644DB File Offset: 0x000626DB
			public unsafe static Action __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugInterface.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInterface.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004091 RID: 16529
			// (get) Token: 0x0600D427 RID: 54311 RVA: 0x0034DE44 File Offset: 0x0034C044
			// (set) Token: 0x0600D428 RID: 54312 RVA: 0x000644ED File Offset: 0x000626ED
			public unsafe static Action __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugInterface.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInterface.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004092 RID: 16530
			// (get) Token: 0x0600D429 RID: 54313 RVA: 0x0034DE6C File Offset: 0x0034C06C
			// (set) Token: 0x0600D42A RID: 54314 RVA: 0x000644FF File Offset: 0x000626FF
			public unsafe static Action __9__10_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugInterface.__c.NativeFieldInfoPtr___9__10_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInterface.__c.NativeFieldInfoPtr___9__10_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004093 RID: 16531
			// (get) Token: 0x0600D42B RID: 54315 RVA: 0x0034DE94 File Offset: 0x0034C094
			// (set) Token: 0x0600D42C RID: 54316 RVA: 0x00064511 File Offset: 0x00062711
			public unsafe static Action __9__10_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugInterface.__c.NativeFieldInfoPtr___9__10_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInterface.__c.NativeFieldInfoPtr___9__10_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004094 RID: 16532
			// (get) Token: 0x0600D42D RID: 54317 RVA: 0x0034DEBC File Offset: 0x0034C0BC
			// (set) Token: 0x0600D42E RID: 54318 RVA: 0x00064523 File Offset: 0x00062723
			public unsafe static Action __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugInterface.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInterface.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004095 RID: 16533
			// (get) Token: 0x0600D42F RID: 54319 RVA: 0x0034DEE4 File Offset: 0x0034C0E4
			// (set) Token: 0x0600D430 RID: 54320 RVA: 0x00064535 File Offset: 0x00062735
			public unsafe static Action __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugInterface.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInterface.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004096 RID: 16534
			// (get) Token: 0x0600D431 RID: 54321 RVA: 0x0034DF0C File Offset: 0x0034C10C
			// (set) Token: 0x0600D432 RID: 54322 RVA: 0x00064547 File Offset: 0x00062747
			public unsafe static Action<float> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugInterface.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInterface.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004097 RID: 16535
			// (get) Token: 0x0600D433 RID: 54323 RVA: 0x0034DF34 File Offset: 0x0034C134
			// (set) Token: 0x0600D434 RID: 54324 RVA: 0x00064559 File Offset: 0x00062759
			public unsafe static Action __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DebugInterface.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DebugInterface.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400906D RID: 36973
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400906E RID: 36974
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400906F RID: 36975
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x04009070 RID: 36976
			private static readonly IntPtr NativeFieldInfoPtr___9__10_2;

			// Token: 0x04009071 RID: 36977
			private static readonly IntPtr NativeFieldInfoPtr___9__10_3;

			// Token: 0x04009072 RID: 36978
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04009073 RID: 36979
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04009074 RID: 36980
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04009075 RID: 36981
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04009076 RID: 36982
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009077 RID: 36983
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__10_0_Internal_Void_0;

			// Token: 0x04009078 RID: 36984
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__10_1_Internal_Void_0;

			// Token: 0x04009079 RID: 36985
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__10_2_Internal_Void_0;

			// Token: 0x0400907A RID: 36986
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__10_3_Internal_Void_0;

			// Token: 0x0400907B RID: 36987
			private static readonly IntPtr NativeMethodInfoPtr__OpenConfirmationMenu_b__12_0_Internal_Void_0;

			// Token: 0x0400907C RID: 36988
			private static readonly IntPtr NativeMethodInfoPtr__OpenConfirmationMenu_b__12_1_Internal_Void_0;

			// Token: 0x0400907D RID: 36989
			private static readonly IntPtr NativeMethodInfoPtr__OpenModifyAmountMenu_b__13_0_Internal_Void_Single_0;

			// Token: 0x0400907E RID: 36990
			private static readonly IntPtr NativeMethodInfoPtr__OpenModifyAmountMenu_b__13_1_Internal_Void_0;
		}

		// Token: 0x020008B2 RID: 2226
		[ObfuscatedName("ScheduleOne.DebugInterface+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D435 RID: 54325 RVA: 0x0034DF5C File Offset: 0x0034C15C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<DebugInterface.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugInterface>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInterface.__c__DisplayClass15_0>.NativeClassPtr);
				DebugInterface.__c__DisplayClass15_0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface.__c__DisplayClass15_0>.NativeClassPtr, "count");
				DebugInterface.__c__DisplayClass15_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInterface.__c__DisplayClass15_0>.NativeClassPtr, "<>9__0");
				DebugInterface.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface.__c__DisplayClass15_0>.NativeClassPtr, 100665024);
				DebugInterface.__c__DisplayClass15_0.NativeMethodInfoPtr__ApplyFilter_b__0_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInterface.__c__DisplayClass15_0>.NativeClassPtr, 100665025);
			}

			// Token: 0x0600D436 RID: 54326 RVA: 0x0034DFD8 File Offset: 0x0034C1D8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugInterface.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D437 RID: 54327 RVA: 0x0034E014 File Offset: 0x0034C214
			[CallerCount(0)]
			public unsafe bool _ApplyFilter_b__0(int element)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref element;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInterface.__c__DisplayClass15_0.NativeMethodInfoPtr__ApplyFilter_b__0_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D438 RID: 54328 RVA: 0x0006456B File Offset: 0x0006276B
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004098 RID: 16536
			// (get) Token: 0x0600D439 RID: 54329 RVA: 0x0034E060 File Offset: 0x0034C260
			// (set) Token: 0x0600D43A RID: 54330 RVA: 0x00064574 File Offset: 0x00062774
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.__c__DisplayClass15_0.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.__c__DisplayClass15_0.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17004099 RID: 16537
			// (get) Token: 0x0600D43B RID: 54331 RVA: 0x0034E088 File Offset: 0x0034C288
			// (set) Token: 0x0600D43C RID: 54332 RVA: 0x0006458F File Offset: 0x0006278F
			public unsafe Predicate<int> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.__c__DisplayClass15_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInterface.__c__DisplayClass15_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400907F RID: 36991
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04009080 RID: 36992
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04009081 RID: 36993
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009082 RID: 36994
			private static readonly IntPtr NativeMethodInfoPtr__ApplyFilter_b__0_Internal_Boolean_Int32_0;
		}
	}
}

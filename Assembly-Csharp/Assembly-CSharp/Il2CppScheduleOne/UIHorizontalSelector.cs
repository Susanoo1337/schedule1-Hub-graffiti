using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x020000A0 RID: 160
	public class UIHorizontalSelector : UIOption
	{
		// Token: 0x06000DA8 RID: 3496 RVA: 0x000A8D88 File Offset: 0x000A6F88
		// Note: this type is marked as 'beforefieldinit'.
		static UIHorizontalSelector()
		{
			Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIHorizontalSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr);
			UIHorizontalSelector.NativeFieldInfoPtr_prevButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, "prevButton");
			UIHorizontalSelector.NativeFieldInfoPtr_nextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, "nextButton");
			UIHorizontalSelector.NativeFieldInfoPtr_currentOptionNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, "currentOptionNameText");
			UIHorizontalSelector.NativeFieldInfoPtr_OnChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, "OnChanged");
			UIHorizontalSelector.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, "options");
			UIHorizontalSelector.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, "currentIndex");
			UIHorizontalSelector.NativeMethodInfoPtr_get_NavigationRepeatRateMult_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665035);
			UIHorizontalSelector.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665036);
			UIHorizontalSelector.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665037);
			UIHorizontalSelector.NativeMethodInfoPtr_MoveLeft_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665038);
			UIHorizontalSelector.NativeMethodInfoPtr_MoveRight_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665039);
			UIHorizontalSelector.NativeMethodInfoPtr_MovePrev_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665040);
			UIHorizontalSelector.NativeMethodInfoPtr_MoveNext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665041);
			UIHorizontalSelector.NativeMethodInfoPtr_UpdateCurrentOptionText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665042);
			UIHorizontalSelector.NativeMethodInfoPtr_SetOptions_Public_Void_List_1_OptionInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665043);
			UIHorizontalSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665044);
			UIHorizontalSelector.NativeMethodInfoPtr__Awake_b__8_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665045);
			UIHorizontalSelector.NativeMethodInfoPtr__Awake_b__8_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr, 100665046);
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x000A8F20 File Offset: 0x000A7120
		public unsafe override float NavigationRepeatRateMult
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 80619, RefRangeEnd = 80621, XrefRangeStart = 80619, XrefRangeEnd = 80619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIHorizontalSelector.NativeMethodInfoPtr_get_NavigationRepeatRateMult_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000A8F68 File Offset: 0x000A7168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80621, XrefRangeEnd = 80639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIHorizontalSelector.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000A8FA4 File Offset: 0x000A71A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34910, RefRangeEnd = 34911, XrefRangeStart = 34910, XrefRangeEnd = 34911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIHorizontalSelector.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000A8FE0 File Offset: 0x000A71E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80639, XrefRangeEnd = 80641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIHorizontalSelector.NativeMethodInfoPtr_MoveLeft_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x000A901C File Offset: 0x000A721C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80641, XrefRangeEnd = 80643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MoveRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIHorizontalSelector.NativeMethodInfoPtr_MoveRight_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x000A9058 File Offset: 0x000A7258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80643, XrefRangeEnd = 80645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MovePrev()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelector.NativeMethodInfoPtr_MovePrev_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x000A908C File Offset: 0x000A728C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelector.NativeMethodInfoPtr_MoveNext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x000A90C0 File Offset: 0x000A72C0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 80653, RefRangeEnd = 80661, XrefRangeStart = 80645, XrefRangeEnd = 80653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentOptionText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelector.NativeMethodInfoPtr_UpdateCurrentOptionText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000A90F4 File Offset: 0x000A72F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80661, XrefRangeEnd = 80668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOptions(List<UIOption.OptionInfo> newOptions, int defaultIndex = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newOptions);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelector.NativeMethodInfoPtr_SetOptions_Public_Void_List_1_OptionInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x000A9144 File Offset: 0x000A7344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80668, XrefRangeEnd = 80680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIHorizontalSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHorizontalSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x000A9180 File Offset: 0x000A7380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__8_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelector.NativeMethodInfoPtr__Awake_b__8_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x000A91B4 File Offset: 0x000A73B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__8_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelector.NativeMethodInfoPtr__Awake_b__8_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000083F2 File Offset: 0x000065F2
		public UIHorizontalSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x000A91E8 File Offset: 0x000A73E8
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x000083FB File Offset: 0x000065FB
		public unsafe Button prevButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_prevButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_prevButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x000A9218 File Offset: 0x000A7418
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x0000841A File Offset: 0x0000661A
		public unsafe Button nextButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_nextButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_nextButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x000A9248 File Offset: 0x000A7448
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00008439 File Offset: 0x00006639
		public unsafe TextMeshProUGUI currentOptionNameText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_currentOptionNameText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_currentOptionNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000DBC RID: 3516 RVA: 0x000A9278 File Offset: 0x000A7478
		// (set) Token: 0x06000DBD RID: 3517 RVA: 0x00008458 File Offset: 0x00006658
		public unsafe UnityEvent<UIOption.OptionInfo> OnChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_OnChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<UIOption.OptionInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_OnChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x000A92A8 File Offset: 0x000A74A8
		// (set) Token: 0x06000DBF RID: 3519 RVA: 0x00008477 File Offset: 0x00006677
		public unsafe List<UIOption.OptionInfo> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIOption.OptionInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x000A92D8 File Offset: 0x000A74D8
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x00008496 File Offset: 0x00006696
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalSelector.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeFieldInfoPtr_prevButton;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeFieldInfoPtr_nextButton;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeFieldInfoPtr_currentOptionNameText;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeFieldInfoPtr_OnChanged;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_get_NavigationRepeatRateMult_Protected_Virtual_get_Single_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Protected_Virtual_Void_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Protected_Virtual_Void_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_MovePrev_Private_Void_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Void_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentOptionText_Private_Void_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_SetOptions_Public_Void_List_1_OptionInfo_Int32_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__8_0_Private_Void_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__8_1_Private_Void_0;
	}
}

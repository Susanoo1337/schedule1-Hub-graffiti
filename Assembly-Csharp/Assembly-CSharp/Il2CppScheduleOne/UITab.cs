using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne
{
	// Token: 0x020000B7 RID: 183
	public class UITab : UIPanel
	{
		// Token: 0x06001089 RID: 4233 RVA: 0x000B2718 File Offset: 0x000B0918
		// Note: this type is marked as 'beforefieldinit'.
		static UITab()
		{
			Il2CppClassPointerStore<UITab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UITab");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITab>.NativeClassPtr);
			UITab.NativeFieldInfoPtr_allowLooping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITab>.NativeClassPtr, "allowLooping");
			UITab.NativeFieldInfoPtr_cycleInputActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITab>.NativeClassPtr, "cycleInputActionType");
			UITab.NativeFieldInfoPtr_cycleDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITab>.NativeClassPtr, "cycleDirection");
			UITab.NativeFieldInfoPtr_reverseCycleDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITab>.NativeClassPtr, "reverseCycleDirection");
			UITab.NativeFieldInfoPtr_cycleLeftVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITab>.NativeClassPtr, "cycleLeftVisual");
			UITab.NativeFieldInfoPtr_cycleRightVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITab>.NativeClassPtr, "cycleRightVisual");
			UITab.NativeFieldInfoPtr_cycleTabTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITab>.NativeClassPtr, "cycleTabTimer");
			UITab.NativeFieldInfoPtr_wasCycleTabPressedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITab>.NativeClassPtr, "wasCycleTabPressedLastFrame");
			UITab.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITab>.NativeClassPtr, 100665390);
			UITab.NativeMethodInfoPtr_EarlyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITab>.NativeClassPtr, 100665391);
			UITab.NativeMethodInfoPtr_GetCycleTabInputValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITab>.NativeClassPtr, 100665392);
			UITab.NativeMethodInfoPtr_CycleTab_Private_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITab>.NativeClassPtr, 100665393);
			UITab.NativeMethodInfoPtr_CycleTabWithoutEvent_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITab>.NativeClassPtr, 100665394);
			UITab.NativeMethodInfoPtr_Navigate_Private_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITab>.NativeClassPtr, 100665395);
			UITab.NativeMethodInfoPtr_CanNavigate_Protected_Virtual_New_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITab>.NativeClassPtr, 100665396);
			UITab.NativeMethodInfoPtr_HandleInputDeviceChanged_Protected_Virtual_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITab>.NativeClassPtr, 100665397);
			UITab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITab>.NativeClassPtr, 100665398);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x000B289C File Offset: 0x000B0A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85035, XrefRangeEnd = 85050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITab.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x000B28D8 File Offset: 0x000B0AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85050, XrefRangeEnd = 85079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EarlyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITab.NativeMethodInfoPtr_EarlyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x000B2914 File Offset: 0x000B0B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85079, XrefRangeEnd = 85086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCycleTabInputValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITab.NativeMethodInfoPtr_GetCycleTabInputValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x000B2950 File Offset: 0x000B0B50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85088, RefRangeEnd = 85089, XrefRangeStart = 85086, XrefRangeEnd = 85088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CycleTab(float navDir, float delay, float speed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref navDir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITab.NativeMethodInfoPtr_CycleTab_Private_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x000B29AC File Offset: 0x000B0BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85090, RefRangeEnd = 85091, XrefRangeStart = 85089, XrefRangeEnd = 85090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CycleTabWithoutEvent(float navDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref navDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITab.NativeMethodInfoPtr_CycleTabWithoutEvent_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x000B29EC File Offset: 0x000B0BEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 85156, RefRangeEnd = 85159, XrefRangeStart = 85091, XrefRangeEnd = 85156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Navigate(float navDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref navDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITab.NativeMethodInfoPtr_Navigate_Private_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x000B2A38 File Offset: 0x000B0C38
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanNavigate(float navDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref navDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITab.NativeMethodInfoPtr_CanNavigate_Protected_Virtual_New_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x000B2A8C File Offset: 0x000B0C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85159, XrefRangeEnd = 85173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UITab.NativeMethodInfoPtr_HandleInputDeviceChanged_Protected_Virtual_Void_InputDeviceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x000B2AD8 File Offset: 0x000B0CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85174, RefRangeEnd = 85175, XrefRangeStart = 85173, XrefRangeEnd = 85174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UITab() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UITab>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UITab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00009A5C File Offset: 0x00007C5C
		public UITab(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x000B2B14 File Offset: 0x000B0D14
		// (set) Token: 0x06001095 RID: 4245 RVA: 0x00009A65 File Offset: 0x00007C65
		public unsafe bool allowLooping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_allowLooping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_allowLooping)) = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x000B2B3C File Offset: 0x000B0D3C
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x00009A80 File Offset: 0x00007C80
		public unsafe UITab.CycleInputActionType cycleInputActionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_cycleInputActionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_cycleInputActionType)) = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x000B2B64 File Offset: 0x000B0D64
		// (set) Token: 0x06001099 RID: 4249 RVA: 0x00009A9B File Offset: 0x00007C9B
		public unsafe UITab.CycleDirection cycleDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_cycleDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_cycleDirection)) = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x000B2B8C File Offset: 0x000B0D8C
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x00009AB6 File Offset: 0x00007CB6
		public unsafe bool reverseCycleDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_reverseCycleDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_reverseCycleDirection)) = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x000B2BB4 File Offset: 0x000B0DB4
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x00009AD1 File Offset: 0x00007CD1
		public unsafe TextMeshProUGUI cycleLeftVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_cycleLeftVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_cycleLeftVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x000B2BE4 File Offset: 0x000B0DE4
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x00009AF0 File Offset: 0x00007CF0
		public unsafe TextMeshProUGUI cycleRightVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_cycleRightVisual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_cycleRightVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x000B2C14 File Offset: 0x000B0E14
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x00009B0F File Offset: 0x00007D0F
		public unsafe float cycleTabTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_cycleTabTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_cycleTabTimer)) = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060010A2 RID: 4258 RVA: 0x000B2C3C File Offset: 0x000B0E3C
		// (set) Token: 0x060010A3 RID: 4259 RVA: 0x00009B2A File Offset: 0x00007D2A
		public unsafe bool wasCycleTabPressedLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_wasCycleTabPressedLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UITab.NativeFieldInfoPtr_wasCycleTabPressedLastFrame)) = value;
			}
		}

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeFieldInfoPtr_allowLooping;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeFieldInfoPtr_cycleInputActionType;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeFieldInfoPtr_cycleDirection;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeFieldInfoPtr_reverseCycleDirection;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeFieldInfoPtr_cycleLeftVisual;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeFieldInfoPtr_cycleRightVisual;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeFieldInfoPtr_cycleTabTimer;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeFieldInfoPtr_wasCycleTabPressedLastFrame;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000B90 RID: 2960
		private static readonly IntPtr NativeMethodInfoPtr_EarlyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeMethodInfoPtr_GetCycleTabInputValue_Private_Single_0;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_CycleTab_Private_Void_Single_Single_Single_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_CycleTabWithoutEvent_Public_Void_Single_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Private_Boolean_Single_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_CanNavigate_Protected_Virtual_New_Boolean_Single_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_HandleInputDeviceChanged_Protected_Virtual_Void_InputDeviceType_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008CB RID: 2251
		[OriginalName("Assembly-CSharp.dll", "", "CycleInputActionType")]
		public enum CycleInputActionType
		{
			// Token: 0x04009104 RID: 37124
			Primary,
			// Token: 0x04009105 RID: 37125
			Secondary,
			// Token: 0x04009106 RID: 37126
			Tertiary
		}

		// Token: 0x020008CC RID: 2252
		[OriginalName("Assembly-CSharp.dll", "", "CycleDirection")]
		public enum CycleDirection
		{
			// Token: 0x04009108 RID: 37128
			Horizontal,
			// Token: 0x04009109 RID: 37129
			Vertical
		}
	}
}
